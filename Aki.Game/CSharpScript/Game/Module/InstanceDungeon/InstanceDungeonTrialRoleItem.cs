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
	// Token: 0x02004858 RID: 18520
	public class InstanceDungeonTrialRoleItem : UiPanelBase
	{
		// Token: 0x0602E9AF RID: 190895 RVA: 0x00D02FDB File Offset: 0x00D011DB
		[NullableContext(1)]
		public InstanceDungeonTrialRoleItem(UUIItem baseUiItem, int roleId)
		{
			this.RoleId = roleId;
		}

		// Token: 0x0602E9B0 RID: 190896 RVA: 0x00D02FEC File Offset: 0x00D011EC
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

		// Token: 0x0602E9B1 RID: 190897 RVA: 0x00D03078 File Offset: 0x00D01278
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

		// Token: 0x0602E9B2 RID: 190898 RVA: 0x00D030DB File Offset: 0x00D012DB
		protected override void OnBeforeDestroy()
		{
			this.RoleId = 0;
		}

		// Token: 0x0602E9B3 RID: 190899 RVA: 0x00D030E4 File Offset: 0x00D012E4
		public void SetRoleId(int id)
		{
			this.RoleId = id;
			this.ShowRoleTexture();
		}

		// Token: 0x0602E9B4 RID: 190900 RVA: 0x00D030F4 File Offset: 0x00D012F4
		private void ShowRoleTexture()
		{
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(this.RoleId);
			base.SetRoleIcon(((roleConfig != null) ? roleConfig.GetValueOrDefault().RoleHeadIcon : null) ?? "", base.GetTexture(1), this.RoleId, null, null);
		}

		// Token: 0x04018CB3 RID: 101555
		private int RoleId;

		// Token: 0x0200A4F5 RID: 42229
		private static class EInstanceDungeonTrialRoleItem
		{
			// Token: 0x04033176 RID: 209270
			public const int RoleTexture = 1;

			// Token: 0x04033177 RID: 209271
			public const int NameItem = 2;

			// Token: 0x04033178 RID: 209272
			public const int Toggle = 7;
		}
	}
}
