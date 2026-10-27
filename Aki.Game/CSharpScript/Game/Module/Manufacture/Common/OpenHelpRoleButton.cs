using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Common
{
	// Token: 0x02005699 RID: 22169
	public class OpenHelpRoleButton : UiPanelBase
	{
		// Token: 0x060386A0 RID: 231072 RVA: 0x00D64964 File Offset: 0x00D62B64
		[NullableContext(1)]
		public OpenHelpRoleButton(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x060386A1 RID: 231073 RVA: 0x00D6497C File Offset: 0x00D62B7C
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
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OpenHelpRole));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060386A2 RID: 231074 RVA: 0x00D64A44 File Offset: 0x00D62C44
		public void RefreshIcon()
		{
			int? currentRoleId = CommonManager.Instance.GetCurrentRoleId();
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(currentRoleId.Value, true);
			base.SetRoleIcon(roleDataById.GetRoleConfig().RoleHeadIcon, base.GetTexture(1), currentRoleId.Value, null, null);
		}

		// Token: 0x060386A3 RID: 231075 RVA: 0x00D64A9C File Offset: 0x00D62C9C
		public void RefreshRedDot(int itemId)
		{
			int? currentRoleId = CommonManager.Instance.GetCurrentRoleId();
			base.GetItem(2).SetUIActive(CommonManager.Instance.CheckIsBuffEx(currentRoleId.Value, itemId));
		}

		// Token: 0x060386A4 RID: 231076 RVA: 0x00D64AD2 File Offset: 0x00D62CD2
		[NullableContext(1)]
		public void BindOnCallback(Action onCallback)
		{
			this.OnCallback = onCallback;
		}

		// Token: 0x060386A5 RID: 231077 RVA: 0x00D64ADB File Offset: 0x00D62CDB
		private void OpenHelpRole()
		{
			if (this.OnCallback != null)
			{
				this.OnCallback();
			}
		}

		// Token: 0x0401DA25 RID: 121381
		[Nullable(2)]
		private Action OnCallback;

		// Token: 0x0200B85B RID: 47195
		private class EOpenHelpRoleDefine
		{
			// Token: 0x04037CD1 RID: 228561
			public const int OpenButton = 0;

			// Token: 0x04037CD2 RID: 228562
			public const int RoleIconTexture = 1;

			// Token: 0x04037CD3 RID: 228563
			public const int RedDotItem = 2;
		}
	}
}
