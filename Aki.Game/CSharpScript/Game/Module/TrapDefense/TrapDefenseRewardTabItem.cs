using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A71 RID: 14961
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseRewardTabItem : GridProxyAbstract<TrapDefenseRewardTabData>
	{
		// Token: 0x0602671A RID: 157466 RVA: 0x00AC4694 File Offset: 0x00AC2894
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602671B RID: 157467 RVA: 0x00AC479D File Offset: 0x00AC299D
		protected override void OnStart()
		{
			TrapDefenseModel.Instance.ViewModelReward.RegisterOnSelectRewardTypeChange(new Action<ETrapDefenseRewardType>(this.OnSelectedTypeChange));
			EventSystem.Instance.Add(EEventName.RedDotUpdateTrapDefenseLimitReward, new Action(this.OnRedDotUpdate));
		}

		// Token: 0x0602671C RID: 157468 RVA: 0x00AC47D6 File Offset: 0x00AC29D6
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.RedDotUpdateTrapDefenseLimitReward, new Action(this.OnRedDotUpdate));
			TrapDefenseModel.Instance.ViewModelReward.UnregisterOnSelectRewardTypeChange(new Action<ETrapDefenseRewardType>(this.OnSelectedTypeChange));
		}

		// Token: 0x0602671D RID: 157469 RVA: 0x00AC4810 File Offset: 0x00AC2A10
		public override void Refresh(TrapDefenseRewardTabData data, bool isSelected, int gridIndex)
		{
			if (data == null)
			{
				return;
			}
			this.Data = data;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.GetTitle(), Array.Empty<object>());
			base.GetText(2).SetText(data.GetProgressText(), true);
			base.GetTexture(3).SetUIActive(data.IsFinished());
			base.GetItem(4).SetUIActive(data.HasRedDot());
		}

		// Token: 0x0602671E RID: 157470 RVA: 0x00AC4880 File Offset: 0x00AC2A80
		public override void OnSelected(bool fireEvent)
		{
			this.SetToggleState(EToggleState.ETT_Checked, fireEvent);
			TrapDefenseModel instance = TrapDefenseModel.Instance;
			if (instance.ViewModelReward.CurSelectRewardType == this.Data.Type)
			{
				return;
			}
			instance.ViewModelReward.SetCurSelectRewardType(this.Data.Type);
		}

		// Token: 0x0602671F RID: 157471 RVA: 0x00AC48CA File Offset: 0x00AC2ACA
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleState(EToggleState.ETT_UnChecked, fireEvent);
		}

		// Token: 0x06026720 RID: 157472 RVA: 0x00AC48D4 File Offset: 0x00AC2AD4
		private void SetToggleState(EToggleState state, bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(state, fireEvent, false, false);
			}
		}

		// Token: 0x06026721 RID: 157473 RVA: 0x00AC48F7 File Offset: 0x00AC2AF7
		private void OnClick(EToggleState state)
		{
			this.OnSelected(false);
		}

		// Token: 0x06026722 RID: 157474 RVA: 0x00AC4900 File Offset: 0x00AC2B00
		private void OnSelectedTypeChange(ETrapDefenseRewardType type)
		{
			if (this.Data == null)
			{
				return;
			}
			if (type != this.Data.Type)
			{
				this.OnDeselected(false);
			}
		}

		// Token: 0x06026723 RID: 157475 RVA: 0x00AC4920 File Offset: 0x00AC2B20
		private void OnRedDotUpdate()
		{
			if (this.Data == null)
			{
				return;
			}
			UUIItem item = base.GetItem(4);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(this.Data.HasRedDot());
		}

		// Token: 0x04015150 RID: 86352
		private TrapDefenseRewardTabData Data;

		// Token: 0x02009659 RID: 38489
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0402EEF6 RID: 192246
			public const int TogSelf = 0;

			// Token: 0x0402EEF7 RID: 192247
			public const int TextTitle = 1;

			// Token: 0x0402EEF8 RID: 192248
			public const int TextProgress = 2;

			// Token: 0x0402EEF9 RID: 192249
			public const int TextureFinished = 3;

			// Token: 0x0402EEFA RID: 192250
			public const int ItemRedDot = 4;
		}
	}
}
