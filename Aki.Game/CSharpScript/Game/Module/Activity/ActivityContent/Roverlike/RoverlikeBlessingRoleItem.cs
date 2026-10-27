using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020060F3 RID: 24819
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoverlikeBlessingRoleItem : GridProxyAbstract<IRoverlikeBlessingRoleData>
	{
		// Token: 0x0603EC40 RID: 257088 RVA: 0x00F2934E File Offset: 0x00F2754E
		public void BindOnRoleClick(Action<IRoverlikeBlessingRoleData> callback)
		{
			this.OnRoleClick = callback;
		}

		// Token: 0x0603EC41 RID: 257089 RVA: 0x00F29357 File Offset: 0x00F27557
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x0603EC42 RID: 257090 RVA: 0x00F2936A File Offset: 0x00F2756A
		public override void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0603EC43 RID: 257091 RVA: 0x00F2937D File Offset: 0x00F2757D
		public override object GetKey(IRoverlikeBlessingRoleData data, int displayIndex)
		{
			return data.RoleId;
		}

		// Token: 0x0603EC44 RID: 257092 RVA: 0x00F2938C File Offset: 0x00F2758C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnTogCommonStateChanged));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603EC45 RID: 257093 RVA: 0x00F29434 File Offset: 0x00F27634
		public override void Refresh(IRoverlikeBlessingRoleData data, bool isSelected, int gridIndex)
		{
			this.CurrentData = data;
			RoverRogueBlessRole? blessRoleConfig = RoverlikeConfig.Instance.GetBlessRoleConfig(data.RoleId);
			if (blessRoleConfig != null)
			{
				base.SetTextureByPath(blessRoleConfig.Value.RoleIcon, base.GetTexture(1), null, null);
			}
			base.GetExtendToggle(0).SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0603EC46 RID: 257094 RVA: 0x00F2949F File Offset: 0x00F2769F
		private void OnTogCommonStateChanged(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked && this.CurrentData != null)
			{
				Action<IRoverlikeBlessingRoleData> onRoleClick = this.OnRoleClick;
				if (onRoleClick == null)
				{
					return;
				}
				onRoleClick(this.CurrentData);
			}
		}

		// Token: 0x04020CC8 RID: 134344
		[Nullable(2)]
		private IRoverlikeBlessingRoleData CurrentData;

		// Token: 0x04020CC9 RID: 134345
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<IRoverlikeBlessingRoleData> OnRoleClick;

		// Token: 0x0200C350 RID: 50000
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403AF31 RID: 241457
			public const int TogCommon = 0;

			// Token: 0x0403AF32 RID: 241458
			public const int TexRole = 1;
		}
	}
}
