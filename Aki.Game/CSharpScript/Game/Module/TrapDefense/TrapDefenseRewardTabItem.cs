using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AC9 RID: 19145
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseRewardTabItem : GridProxyAbstract<TrapDefenseRewardTabData>
	{
		// Token: 0x0603198A RID: 203146 RVA: 0x00B806E0 File Offset: 0x00B7E8E0
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

		// Token: 0x0603198B RID: 203147 RVA: 0x00B807E9 File Offset: 0x00B7E9E9
		protected override void OnStart()
		{
			TrapDefenseModel.Instance.ViewModelReward.RegisterOnSelectRewardTypeChange(new Action<ETrapDefenseRewardType>(this.OnSelectedTypeChange));
			EventSystem.Instance.Add(EEventName.RedDotUpdateTrapDefenseLimitReward, new Action(this.OnRedDotUpdate));
		}

		// Token: 0x0603198C RID: 203148 RVA: 0x00B80822 File Offset: 0x00B7EA22
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.RedDotUpdateTrapDefenseLimitReward, new Action(this.OnRedDotUpdate));
			TrapDefenseModel.Instance.ViewModelReward.UnregisterOnSelectRewardTypeChange(new Action<ETrapDefenseRewardType>(this.OnSelectedTypeChange));
		}

		// Token: 0x0603198D RID: 203149 RVA: 0x00B8085C File Offset: 0x00B7EA5C
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

		// Token: 0x0603198E RID: 203150 RVA: 0x00B808CC File Offset: 0x00B7EACC
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

		// Token: 0x0603198F RID: 203151 RVA: 0x00B80916 File Offset: 0x00B7EB16
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleState(EToggleState.ETT_UnChecked, fireEvent);
		}

		// Token: 0x06031990 RID: 203152 RVA: 0x00B80920 File Offset: 0x00B7EB20
		private void SetToggleState(EToggleState state, bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(state, fireEvent, false, false);
			}
		}

		// Token: 0x06031991 RID: 203153 RVA: 0x00B80943 File Offset: 0x00B7EB43
		private void OnClick(EToggleState state)
		{
			this.OnSelected(false);
		}

		// Token: 0x06031992 RID: 203154 RVA: 0x00B8094C File Offset: 0x00B7EB4C
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

		// Token: 0x06031993 RID: 203155 RVA: 0x00B8096C File Offset: 0x00B7EB6C
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

		// Token: 0x0401A7FE RID: 108542
		private TrapDefenseRewardTabData Data;

		// Token: 0x0200AC39 RID: 44089
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04034545 RID: 214341
			public const int TogSelf = 0;

			// Token: 0x04034546 RID: 214342
			public const int TextTitle = 1;

			// Token: 0x04034547 RID: 214343
			public const int TextProgress = 2;

			// Token: 0x04034548 RID: 214344
			public const int TextureFinished = 3;

			// Token: 0x04034549 RID: 214345
			public const int ItemRedDot = 4;
		}
	}
}
