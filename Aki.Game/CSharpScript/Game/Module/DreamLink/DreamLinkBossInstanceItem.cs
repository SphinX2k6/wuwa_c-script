using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02004A95 RID: 19093
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DreamLinkBossInstanceItem : GridProxyAbstract<DreamLinkBossInstanceData>
	{
		// Token: 0x0602FC83 RID: 195715 RVA: 0x00D549B8 File Offset: 0x00D52BB8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
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
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.ToggleFunctionInternal));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602FC84 RID: 195716 RVA: 0x00D54B68 File Offset: 0x00D52D68
		protected override void OnStart()
		{
			base.GetItem(3).SetUIActive(false);
			base.GetItem(7).SetUIActive(false);
			this.ActivityDataBase = DreamLinkController.Instance.GetCurrentActivityData();
		}

		// Token: 0x0602FC85 RID: 195717 RVA: 0x00D54B94 File Offset: 0x00D52D94
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x0602FC86 RID: 195718 RVA: 0x00D54B98 File Offset: 0x00D52D98
		public override void Refresh(DreamLinkBossInstanceData data, bool isSelected, int gridIndex)
		{
			this.InstData = data;
			RogueBossInstance? rogueBossInstanceConfig = DreamLinkConfig.Instance.GetRogueBossInstanceConfig(data.TypeId);
			if (!StringUtils.IsEmpty(rogueBossInstanceConfig.Value.InstTitle))
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), rogueBossInstanceConfig.Value.InstTitle, Array.Empty<object>());
			}
			base.GetText(6).SetText(rogueBossInstanceConfig.Value.InstNumber, true);
			if (data.IsUnlock)
			{
				if (data.Score > 0)
				{
					LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "DaMaoScore_Normal", new <>z__ReadOnlySingleElementList<object>(data.Score));
				}
				else
				{
					LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "DaMaoScore_Unfinish", Array.Empty<object>());
				}
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "DaMaoFushua_Level_Unlock", Array.Empty<object>());
			}
			base.GetItem(4).SetUIActive(!data.IsUnlock);
			base.GetItem(8).SetUIActive(!data.IsUnlock);
			this.RefreshRedDot();
		}

		// Token: 0x0602FC87 RID: 195719 RVA: 0x00D54CB5 File Offset: 0x00D52EB5
		public override void OnSelected(bool fireEvent)
		{
			this.SetToggleSelected(true);
		}

		// Token: 0x0602FC88 RID: 195720 RVA: 0x00D54CBE File Offset: 0x00D52EBE
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleSelected(false);
		}

		// Token: 0x0602FC89 RID: 195721 RVA: 0x00D54CC8 File Offset: 0x00D52EC8
		private void RefreshRedDot()
		{
			bool bossInstRedDotState = this.ActivityDataBase.GetBossInstRedDotState(this.InstData.InstId);
			base.GetItem(5).SetUIActive(bossInstRedDotState);
			base.GetItem(9).SetUIActive(bossInstRedDotState);
		}

		// Token: 0x0602FC8A RID: 195722 RVA: 0x00D54D07 File Offset: 0x00D52F07
		private void SetToggleSelected(bool bOn)
		{
			base.GetExtendToggle(0).SetToggleState(bOn ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, true, false, false);
		}

		// Token: 0x0602FC8B RID: 195723 RVA: 0x00D54D20 File Offset: 0x00D52F20
		private void ToggleFunctionInternal(EToggleState toggleState)
		{
			if (toggleState == EToggleState.ETT_Checked)
			{
				this.ActivityDataBase.SaveBossInstRedDotState(this.InstData.InstId);
				this.RefreshRedDot();
				Action<DreamLinkBossInstanceData, int> toggleFunction = this.ToggleFunction;
				if (toggleFunction == null)
				{
					return;
				}
				toggleFunction(this.InstData, base.GridIndex);
			}
		}

		// Token: 0x0602FC8C RID: 195724 RVA: 0x00D54D5E File Offset: 0x00D52F5E
		public override object GetKey(DreamLinkBossInstanceData data, int displayIndex)
		{
			return this.InstData.InstId;
		}

		// Token: 0x040195D0 RID: 103888
		[Nullable(2)]
		protected DreamLinkBossInstanceData InstData;

		// Token: 0x040195D1 RID: 103889
		[Nullable(2)]
		protected DreamLinkData ActivityDataBase;

		// Token: 0x040195D2 RID: 103890
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<DreamLinkBossInstanceData, int> ToggleFunction;

		// Token: 0x0200A714 RID: 42772
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040339FF RID: 211455
			public const int Toggle = 0;

			// Token: 0x04033A00 RID: 211456
			public const int TxtTitleB = 1;

			// Token: 0x04033A01 RID: 211457
			public const int TxtScoreB = 2;

			// Token: 0x04033A02 RID: 211458
			public const int PanelDoneB = 3;

			// Token: 0x04033A03 RID: 211459
			public const int PanelLockB = 4;

			// Token: 0x04033A04 RID: 211460
			public const int RedDotB = 5;

			// Token: 0x04033A05 RID: 211461
			public const int TxtTitleA = 6;

			// Token: 0x04033A06 RID: 211462
			public const int PanelDoneA = 7;

			// Token: 0x04033A07 RID: 211463
			public const int PanelLockA = 8;

			// Token: 0x04033A08 RID: 211464
			public const int RedDotA = 9;
		}
	}
}
