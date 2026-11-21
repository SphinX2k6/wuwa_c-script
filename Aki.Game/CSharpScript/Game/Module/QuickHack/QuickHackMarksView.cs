using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi.Views;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02003F52 RID: 16210
	[NullableContext(1)]
	[Nullable(0)]
	public class QuickHackMarksView : BattleChildView
	{
		// Token: 0x0602908E RID: 168078 RVA: 0x00B857BC File Offset: 0x00B839BC
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

		// Token: 0x0602908F RID: 168079 RVA: 0x00B85840 File Offset: 0x00B83A40
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

		// Token: 0x06029090 RID: 168080 RVA: 0x00B858AD File Offset: 0x00B83AAD
		public void OnShowBattleChildViewPanel()
		{
			QuickHackMarkManager markManager = QuickHackModel.Instance.MarkManager;
			if (markManager == null)
			{
				return;
			}
			markManager.UpdateMarks();
		}

		// Token: 0x06029091 RID: 168081 RVA: 0x00B858C3 File Offset: 0x00B83AC3
		public void Update()
		{
			this.ConsumeWaitMarks();
			this.UpdateAllMarksItem();
		}

		// Token: 0x06029092 RID: 168082 RVA: 0x00B858D4 File Offset: 0x00B83AD4
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

		// Token: 0x06029093 RID: 168083 RVA: 0x00B85930 File Offset: 0x00B83B30
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

		// Token: 0x06029094 RID: 168084 RVA: 0x00B85A94 File Offset: 0x00B83C94
		private void OnQuickHackStartMark(QuickHackMarkInstance mark)
		{
			this.PushMark(mark);
		}

		// Token: 0x06029095 RID: 168085 RVA: 0x00B85A9D File Offset: 0x00B83C9D
		private void PushMark(QuickHackMarkInstance mark)
		{
			if (this.WaitMarkQueue == null)
			{
				this.WaitMarkQueue = new Queue<QuickHackMarkInstance>(4);
			}
			this.WaitMarkQueue.Push(mark);
		}

		// Token: 0x06029096 RID: 168086 RVA: 0x00B85AC0 File Offset: 0x00B83CC0
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

		// Token: 0x06029097 RID: 168087 RVA: 0x00B85B0C File Offset: 0x00B83D0C
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

		// Token: 0x06029098 RID: 168088 RVA: 0x00B85B58 File Offset: 0x00B83D58
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

		// Token: 0x04016556 RID: 91478
		private const int SHOW_MAX_SIZE_PER_UPDATE = 3;

		// Token: 0x04016557 RID: 91479
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Queue<QuickHackMarkInstance> WaitMarkQueue;

		// Token: 0x04016558 RID: 91480
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Dictionary<EntityHandle, QuickHackMarksItem> MarksItemMap;

		// Token: 0x04016559 RID: 91481
		[Nullable(2)]
		private Vector TempVector;

		// Token: 0x0401655A RID: 91482
		[Nullable(2)]
		private Vector2D TempScreenPosition;
	}
}
