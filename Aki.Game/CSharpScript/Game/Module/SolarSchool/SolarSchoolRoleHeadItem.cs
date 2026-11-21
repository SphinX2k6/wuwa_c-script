using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x0200599B RID: 22939
	public class SolarSchoolRoleHeadItem : UiPanelBase
	{
		// Token: 0x060388FE RID: 231678 RVA: 0x00FD3360 File Offset: 0x00FD1560
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060388FF RID: 231679 RVA: 0x00FD3427 File Offset: 0x00FD1627
		[NullableContext(1)]
		public void SetClickCallback(Action<int> callback)
		{
			this.ClickCallback = callback;
		}

		// Token: 0x06038900 RID: 231680 RVA: 0x00FD3430 File Offset: 0x00FD1630
		public void SetRole(int roleId)
		{
			this.RoleId = roleId;
			base.SetUiActive(roleId != 0);
			if (roleId == 0)
			{
				return;
			}
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			SolarSchoolRole? role = SolarSchoolConfig.Instance.GetRole(roleId);
			if (role == null)
			{
				return;
			}
			if (!string.IsNullOrEmpty(role.Value.HeadIcon))
			{
				base.SetTextureShowUntilLoaded(role.Value.HeadIcon, base.GetTexture(1), null);
			}
		}

		// Token: 0x06038901 RID: 231681 RVA: 0x00FD34AE File Offset: 0x00FD16AE
		private void OnBtnClick()
		{
			if (this.RoleId != 0)
			{
				Action<int> clickCallback = this.ClickCallback;
				if (clickCallback == null)
				{
					return;
				}
				clickCallback(this.RoleId);
			}
		}

		// Token: 0x0401DC9E RID: 122014
		private int RoleId;

		// Token: 0x0401DC9F RID: 122015
		[Nullable(2)]
		private Action<int> ClickCallback;

		// Token: 0x0200B545 RID: 46405
		private class EComponents
		{
			// Token: 0x040380B8 RID: 229560
			public const int Btn = 0;

			// Token: 0x040380B9 RID: 229561
			public const int TexRoleIcon = 1;

			// Token: 0x040380BA RID: 229562
			public const int RedDot = 2;
		}
	}
}
