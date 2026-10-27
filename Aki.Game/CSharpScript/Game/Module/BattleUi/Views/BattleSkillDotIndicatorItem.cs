using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CE1 RID: 23777
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleSkillDotIndicatorItem : UiPanelBase
	{
		// Token: 0x0603C2AD RID: 246445 RVA: 0x00E67553 File Offset: 0x00E65753
		private string GetResourceId()
		{
			return "UiItem_LuhesSkillPoint";
		}

		// Token: 0x0603C2AE RID: 246446 RVA: 0x00E6755A File Offset: 0x00E6575A
		public BattleSkillDotIndicatorItem(UUIItem parentItem)
		{
			base.CreateByResourceIdAsync(this.GetResourceId(), parentItem, false).Forget();
		}

		// Token: 0x0603C2AF RID: 246447 RVA: 0x00E6758C File Offset: 0x00E6578C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603C2B0 RID: 246448 RVA: 0x00E67618 File Offset: 0x00E65818
		protected override UniTask OnBeforeStartAsync()
		{
			BattleSkillDotIndicatorItem.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BattleSkillDotIndicatorItem.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603C2B1 RID: 246449 RVA: 0x00E6765B File Offset: 0x00E6585B
		protected override void OnStart()
		{
			this.IsEnable = true;
			this.SetIconPath(this.IconPath, true);
		}

		// Token: 0x17008DFF RID: 36351
		// (get) Token: 0x0603C2B2 RID: 246450 RVA: 0x00E67671 File Offset: 0x00E65871
		public bool IsComponentActive
		{
			get
			{
				return this.IsActive;
			}
		}

		// Token: 0x0603C2B3 RID: 246451 RVA: 0x00E67679 File Offset: 0x00E65879
		public void SetComponentActive(bool bShow)
		{
			if (this.IsActive != bShow)
			{
				base.SetUiActive(bShow);
			}
			this.IsActive = bShow;
		}

		// Token: 0x0603C2B4 RID: 246452 RVA: 0x00E67694 File Offset: 0x00E65894
		public void SetCount(int num, bool force = false)
		{
			if (this.CurrentCount == num && !force)
			{
				return;
			}
			this.CurrentCount = num;
			if (!base.GetActive() && !force)
			{
				return;
			}
			for (int i = 0; i < this.DotViews.Count; i++)
			{
				this.DotViews[i].SetDotState(i < num, force);
			}
		}

		// Token: 0x0603C2B5 RID: 246453 RVA: 0x00E676F0 File Offset: 0x00E658F0
		public void SetIconPath(string iconPath, bool force = false)
		{
			if (this.IconPath == iconPath && !force)
			{
				return;
			}
			this.IconPath = iconPath;
			if (!this.IsEnable)
			{
				return;
			}
			if (this.LoadHandleId != 0)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.LoadHandleId);
				this.LoadHandleId = 0;
			}
			if (StringUtils.IsEmpty(this.IconPath))
			{
				using (List<SkillButtonDotIndicator>.Enumerator enumerator = this.DotViews.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						SkillButtonDotIndicator skillButtonDotIndicator = enumerator.Current;
						skillButtonDotIndicator.SetIconResource(null);
					}
					return;
				}
			}
			this.LoadHandleId = ResourceSystem.Instance.LoadAsync<UTexture>(this.IconPath, delegate([Nullable(2)] UTexture textureData, string _)
			{
				if (!this.IsEnable)
				{
					return;
				}
				if (this.IconPath != iconPath)
				{
					return;
				}
				foreach (SkillButtonDotIndicator skillButtonDotIndicator2 in this.DotViews)
				{
					skillButtonDotIndicator2.SetIconResource(textureData);
				}
			}, 100, "js_undefined");
		}

		// Token: 0x0603C2B6 RID: 246454 RVA: 0x00E677D8 File Offset: 0x00E659D8
		protected override void OnBeforeDestroy()
		{
			this.IsEnable = false;
			this.DotViews.Clear();
			if (this.LoadHandleId != 0)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.LoadHandleId);
				this.LoadHandleId = 0;
			}
		}

		// Token: 0x0401F5DE RID: 128478
		private readonly List<SkillButtonDotIndicator> DotViews = new List<SkillButtonDotIndicator>();

		// Token: 0x0401F5DF RID: 128479
		private string IconPath = "";

		// Token: 0x0401F5E0 RID: 128480
		private int LoadHandleId;

		// Token: 0x0401F5E1 RID: 128481
		private bool IsEnable;

		// Token: 0x0401F5E2 RID: 128482
		private bool IsActive;

		// Token: 0x0401F5E3 RID: 128483
		private int CurrentCount;

		// Token: 0x0200BF3B RID: 48955
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04039AE6 RID: 236262
			Dot1,
			// Token: 0x04039AE7 RID: 236263
			Dot2,
			// Token: 0x04039AE8 RID: 236264
			Dot3
		}
	}
}
