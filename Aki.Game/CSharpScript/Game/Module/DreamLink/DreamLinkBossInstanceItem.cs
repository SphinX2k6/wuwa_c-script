using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02005AB9 RID: 23225
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DreamLinkBossInstanceItem : GridProxyAbstract<DreamLinkBossInstanceData>
	{
		// Token: 0x0603AD37 RID: 240951 RVA: 0x00E043F0 File Offset: 0x00E025F0
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

		// Token: 0x0603AD38 RID: 240952 RVA: 0x00E045A0 File Offset: 0x00E027A0
		protected override void OnStart()
		{
			base.GetItem(3).SetUIActive(false);
			base.GetItem(7).SetUIActive(false);
			this.ActivityDataBase = DreamLinkController.Instance.GetCurrentActivityData();
		}

		// Token: 0x0603AD39 RID: 240953 RVA: 0x00E045CC File Offset: 0x00E027CC
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x0603AD3A RID: 240954 RVA: 0x00E045D0 File Offset: 0x00E027D0
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

		// Token: 0x0603AD3B RID: 240955 RVA: 0x00E046ED File Offset: 0x00E028ED
		public override void OnSelected(bool fireEvent)
		{
			this.SetToggleSelected(true);
		}

		// Token: 0x0603AD3C RID: 240956 RVA: 0x00E046F6 File Offset: 0x00E028F6
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleSelected(false);
		}

		// Token: 0x0603AD3D RID: 240957 RVA: 0x00E04700 File Offset: 0x00E02900
		private void RefreshRedDot()
		{
			bool bossInstRedDotState = this.ActivityDataBase.GetBossInstRedDotState(this.InstData.InstId);
			base.GetItem(5).SetUIActive(bossInstRedDotState);
			base.GetItem(9).SetUIActive(bossInstRedDotState);
		}

		// Token: 0x0603AD3E RID: 240958 RVA: 0x00E0473F File Offset: 0x00E0293F
		private void SetToggleSelected(bool bOn)
		{
			base.GetExtendToggle(0).SetToggleState(bOn ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, true, false, false);
		}

		// Token: 0x0603AD3F RID: 240959 RVA: 0x00E04758 File Offset: 0x00E02958
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

		// Token: 0x0603AD40 RID: 240960 RVA: 0x00E04796 File Offset: 0x00E02996
		public override object GetKey(DreamLinkBossInstanceData data, int displayIndex)
		{
			return this.InstData.InstId;
		}

		// Token: 0x0401EB29 RID: 125737
		[Nullable(2)]
		protected DreamLinkBossInstanceData InstData;

		// Token: 0x0401EB2A RID: 125738
		[Nullable(2)]
		protected DreamLinkData ActivityDataBase;

		// Token: 0x0401EB2B RID: 125739
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<DreamLinkBossInstanceData, int> ToggleFunction;

		// Token: 0x0200BD0C RID: 48396
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04039035 RID: 233525
			public const int Toggle = 0;

			// Token: 0x04039036 RID: 233526
			public const int TxtTitleB = 1;

			// Token: 0x04039037 RID: 233527
			public const int TxtScoreB = 2;

			// Token: 0x04039038 RID: 233528
			public const int PanelDoneB = 3;

			// Token: 0x04039039 RID: 233529
			public const int PanelLockB = 4;

			// Token: 0x0403903A RID: 233530
			public const int RedDotB = 5;

			// Token: 0x0403903B RID: 233531
			public const int TxtTitleA = 6;

			// Token: 0x0403903C RID: 233532
			public const int PanelDoneA = 7;

			// Token: 0x0403903D RID: 233533
			public const int PanelLockA = 8;

			// Token: 0x0403903E RID: 233534
			public const int RedDotA = 9;
		}
	}
}
