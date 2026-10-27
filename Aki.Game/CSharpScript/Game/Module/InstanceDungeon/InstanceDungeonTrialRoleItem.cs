using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x02005880 RID: 22656
	public class InstanceDungeonTrialRoleItem : UiPanelBase
	{
		// Token: 0x06039A8C RID: 236172 RVA: 0x00DB40C7 File Offset: 0x00DB22C7
		[NullableContext(1)]
		public InstanceDungeonTrialRoleItem(UUIItem baseUiItem, int roleId)
		{
			this.RoleId = roleId;
		}

		// Token: 0x06039A8D RID: 236173 RVA: 0x00DB40D8 File Offset: 0x00DB22D8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIExtendToggle));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06039A8E RID: 236174 RVA: 0x00DB4164 File Offset: 0x00DB2364
		protected override void OnStart()
		{
			base.GetExtendToggle(7).CanExecuteChange.Bind(() => false);
			base.GetExtendToggle(7).IsSelfInteractive = false;
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			this.ShowRoleTexture();
		}

		// Token: 0x06039A8F RID: 236175 RVA: 0x00DB41C7 File Offset: 0x00DB23C7
		protected override void OnBeforeDestroy()
		{
			this.RoleId = 0;
		}

		// Token: 0x06039A90 RID: 236176 RVA: 0x00DB41D0 File Offset: 0x00DB23D0
		public void SetRoleId(int id)
		{
			this.RoleId = id;
			this.ShowRoleTexture();
		}

		// Token: 0x06039A91 RID: 236177 RVA: 0x00DB41E0 File Offset: 0x00DB23E0
		private void ShowRoleTexture()
		{
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(this.RoleId);
			base.SetRoleIcon(((roleConfig != null) ? roleConfig.GetValueOrDefault().RoleHeadIcon : null) ?? "", base.GetTexture(1), this.RoleId, null, null);
		}

		// Token: 0x0401E216 RID: 123414
		private int RoleId;

		// Token: 0x0200BADC RID: 47836
		private static class EInstanceDungeonTrialRoleItem
		{
			// Token: 0x04038775 RID: 231285
			public const int RoleTexture = 1;

			// Token: 0x04038776 RID: 231286
			public const int NameItem = 2;

			// Token: 0x04038777 RID: 231287
			public const int Toggle = 7;
		}
	}
}
