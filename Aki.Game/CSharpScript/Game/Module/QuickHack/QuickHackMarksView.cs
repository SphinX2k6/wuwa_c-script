using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi.Views;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02004F89 RID: 20361
	[NullableContext(1)]
	[Nullable(0)]
	public class QuickHackMarksView : BattleChildView
	{
		// Token: 0x06034220 RID: 213536 RVA: 0x00C3C010 File Offset: 0x00C3A210
		[NullableContext(2)]
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			QuickHackMarkManager markManager = QuickHackModel.Instance.MarkManager;
			if (markManager != null)
			{
				markManager.UpdateMarks();
				foreach (QuickHackMarkInstance mark in markManager.GetMarks())
				{
					this.PushMark(mark);
				}
			}
			EventSystem.Instance.Add<QuickHackMarkInstance>(EEventName.OnQuickHackStartMark, new Action<QuickHackMarkInstance>(this.OnQuickHackStartMark));
		}

		// Token: 0x06034221 RID: 213537 RVA: 0x00C3C094 File Offset: 0x00C3A294
		public override void Reset()
		{
			base.Reset();
			Dictionary<EntityHandle, QuickHackMarksItem> marksItemMap = this.MarksItemMap;
			if (marksItemMap != null)
			{
				marksItemMap.Clear();
			}
			this.MarksItemMap = null;
			Queue<QuickHackMarkInstance> waitMarkQueue = this.WaitMarkQueue;
			if (waitMarkQueue != null)
			{
				waitMarkQueue.Clear();
			}
			this.WaitMarkQueue = null;
			this.TempVector = null;
			this.TempScreenPosition = null;
			EventSystem.Instance.Remove<QuickHackMarkInstance>(EEventName.OnQuickHackStartMark, new Action<QuickHackMarkInstance>(this.OnQuickHackStartMark));
		}

		// Token: 0x06034222 RID: 213538 RVA: 0x00C3C101 File Offset: 0x00C3A301
		public void OnShowBattleChildViewPanel()
		{
			QuickHackMarkManager markManager = QuickHackModel.Instance.MarkManager;
			if (markManager == null)
			{
				return;
			}
			markManager.UpdateMarks();
		}

		// Token: 0x06034223 RID: 213539 RVA: 0x00C3C117 File Offset: 0x00C3A317
		public void Update()
		{
			this.ConsumeWaitMarks();
			this.UpdateAllMarksItem();
		}

		// Token: 0x06034224 RID: 213540 RVA: 0x00C3C128 File Offset: 0x00C3A328
		private void ConsumeWaitMarks()
		{
			if (this.WaitMarkQueue == null || this.WaitMarkQueue.Size <= 0)
			{
				return;
			}
			for (int i = 0; i < 3; i++)
			{
				QuickHackMarkInstance quickHackMarkInstance = this.WaitMarkQueue.Pop();
				if (quickHackMarkInstance != null)
				{
					this.StartMarkAsync(quickHackMarkInstance).Forget();
				}
				if (this.WaitMarkQueue.Size <= 0)
				{
					break;
				}
			}
		}

		// Token: 0x06034225 RID: 213541 RVA: 0x00C3C184 File Offset: 0x00C3A384
		private void UpdateAllMarksItem()
		{
			if (this.MarksItemMap == null || this.MarksItemMap.Count <= 0)
			{
				return;
			}
			QuickHackMarkManager markManager = QuickHackModel.Instance.MarkManager;
			if (markManager != null)
			{
				markManager.UpdateMarks();
			}
			if (this.TempVector == null)
			{
				this.TempVector = Vector.Create();
			}
			if (this.TempScreenPosition == null)
			{
				this.TempScreenPosition = Vector2D.Create();
			}
			List<EntityHandle> list = new List<EntityHandle>();
			foreach (KeyValuePair<EntityHandle, QuickHackMarksItem> keyValuePair in this.MarksItemMap)
			{
				EntityHandle entityHandle;
				QuickHackMarksItem quickHackMarksItem;
				keyValuePair.Deconstruct(out entityHandle, out quickHackMarksItem);
				EntityHandle item = entityHandle;
				QuickHackMarksItem quickHackMarksItem2 = quickHackMarksItem;
				if (!quickHackMarksItem2.GetWorldLocation(this.TempVector))
				{
					quickHackMarksItem2.Destroy(null);
					list.Add(item);
				}
				else if (!HudUnitUtils.PositionUtil.ProjectWorldToScreen(this.TempVector.ToUeVector(false), this.TempScreenPosition))
				{
					quickHackMarksItem2.SetActive(false);
				}
				else
				{
					quickHackMarksItem2.SetActive(true);
					quickHackMarksItem2.GetRootItem().SetAnchorOffset(this.TempScreenPosition.ToUeVector2D(false));
				}
			}
			foreach (EntityHandle key in list)
			{
				this.MarksItemMap.Remove(key);
			}
		}

		// Token: 0x06034226 RID: 213542 RVA: 0x00C3C2E8 File Offset: 0x00C3A4E8
		private void OnQuickHackStartMark(QuickHackMarkInstance mark)
		{
			this.PushMark(mark);
		}

		// Token: 0x06034227 RID: 213543 RVA: 0x00C3C2F1 File Offset: 0x00C3A4F1
		private void PushMark(QuickHackMarkInstance mark)
		{
			if (this.WaitMarkQueue == null)
			{
				this.WaitMarkQueue = new Queue<QuickHackMarkInstance>(4);
			}
			this.WaitMarkQueue.Push(mark);
		}

		// Token: 0x06034228 RID: 213544 RVA: 0x00C3C314 File Offset: 0x00C3A514
		private UniTask StartMarkAsync(QuickHackMarkInstance mark)
		{
			QuickHackMarksView.<StartMarkAsync>d__13 <StartMarkAsync>d__;
			<StartMarkAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<StartMarkAsync>d__.<>4__this = this;
			<StartMarkAsync>d__.mark = mark;
			<StartMarkAsync>d__.<>1__state = -1;
			<StartMarkAsync>d__.<>t__builder.Start<QuickHackMarksView.<StartMarkAsync>d__13>(ref <StartMarkAsync>d__);
			return <StartMarkAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034229 RID: 213545 RVA: 0x00C3C360 File Offset: 0x00C3A560
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<QuickHackMarksItem> GetOrCreateMarksItem(EntityHandle owner)
		{
			QuickHackMarksView.<GetOrCreateMarksItem>d__14 <GetOrCreateMarksItem>d__;
			<GetOrCreateMarksItem>d__.<>t__builder = AsyncUniTaskMethodBuilder<QuickHackMarksItem>.Create();
			<GetOrCreateMarksItem>d__.<>4__this = this;
			<GetOrCreateMarksItem>d__.owner = owner;
			<GetOrCreateMarksItem>d__.<>1__state = -1;
			<GetOrCreateMarksItem>d__.<>t__builder.Start<QuickHackMarksView.<GetOrCreateMarksItem>d__14>(ref <GetOrCreateMarksItem>d__);
			return <GetOrCreateMarksItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603422A RID: 213546 RVA: 0x00C3C3AC File Offset: 0x00C3A5AC
		private void OnMarksFinish(EntityHandle owner)
		{
			if (this.MarksItemMap == null)
			{
				return;
			}
			QuickHackMarksItem quickHackMarksItem;
			if (this.MarksItemMap.TryGetValue(owner, out quickHackMarksItem))
			{
				this.MarksItemMap.Remove(owner);
				quickHackMarksItem.Destroy(null);
			}
		}

		// Token: 0x0401BB81 RID: 113537
		private const int SHOW_MAX_SIZE_PER_UPDATE = 3;

		// Token: 0x0401BB82 RID: 113538
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Queue<QuickHackMarkInstance> WaitMarkQueue;

		// Token: 0x0401BB83 RID: 113539
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Dictionary<EntityHandle, QuickHackMarksItem> MarksItemMap;

		// Token: 0x0401BB84 RID: 113540
		[Nullable(2)]
		private Vector TempVector;

		// Token: 0x0401BB85 RID: 113541
		[Nullable(2)]
		private Vector2D TempScreenPosition;
	}
}
