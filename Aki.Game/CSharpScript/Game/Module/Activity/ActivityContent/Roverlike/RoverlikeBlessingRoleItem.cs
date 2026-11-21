using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005071 RID: 20593
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoverlikeBlessingRoleItem : GridProxyAbstract<IRoverlikeBlessingRoleData>
	{
		// Token: 0x06033902 RID: 211202 RVA: 0x00E70162 File Offset: 0x00E6E362
		public void BindOnRoleClick(Action<IRoverlikeBlessingRoleData> callback)
		{
			this.OnRoleClick = callback;
		}

		// Token: 0x06033903 RID: 211203 RVA: 0x00E7016B File Offset: 0x00E6E36B
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x06033904 RID: 211204 RVA: 0x00E7017E File Offset: 0x00E6E37E
		public override void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06033905 RID: 211205 RVA: 0x00E70191 File Offset: 0x00E6E391
		public override object GetKey(IRoverlikeBlessingRoleData data, int displayIndex)
		{
			return data.RoleId;
		}

		// Token: 0x06033906 RID: 211206 RVA: 0x00E701A0 File Offset: 0x00E6E3A0
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

		// Token: 0x06033907 RID: 211207 RVA: 0x00E70248 File Offset: 0x00E6E448
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

		// Token: 0x06033908 RID: 211208 RVA: 0x00E702B3 File Offset: 0x00E6E4B3
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

		// Token: 0x0401B5F5 RID: 112117
		[Nullable(2)]
		private IRoverlikeBlessingRoleData CurrentData;

		// Token: 0x0401B5F6 RID: 112118
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<IRoverlikeBlessingRoleData> OnRoleClick;

		// Token: 0x0200AD38 RID: 44344
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04035896 RID: 219286
			public const int TogCommon = 0;

			// Token: 0x04035897 RID: 219287
			public const int TexRole = 1;
		}
	}
}
