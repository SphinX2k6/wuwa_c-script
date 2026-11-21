using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D71 RID: 15729
	public class RoguelikeAchieveBtnMainRoleItem : UiPanelBase
	{
		// Token: 0x060283DD RID: 164829 RVA: 0x00B4602C File Offset: 0x00B4422C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060283DE RID: 164830 RVA: 0x00B460B6 File Offset: 0x00B442B6
		protected override void OnStart()
		{
			this.SetEmptyState(true);
		}

		// Token: 0x060283DF RID: 164831 RVA: 0x00B460C0 File Offset: 0x00B442C0
		[NullableContext(2)]
		public void Refresh(RogueArchiveInfoData archiveInfoData)
		{
			int num = (archiveInfoData != null && archiveInfoData.RoleIds.Count > 0) ? archiveInfoData.RoleIds[0] : 0;
			if (num <= 0)
			{
				this.SetEmptyState(true);
				return;
			}
			RoleDataBase roguelikeRoleData = RoguelikeModel.Instance.GetRoguelikeRoleData(num);
			RoleInfo? roleInfo = (roguelikeRoleData != null) ? new RoleInfo?(roguelikeRoleData.GetRoleConfig()) : null;
			string text = (roleInfo != null) ? roleInfo.GetValueOrDefault().RoleHeadIconCircle : null;
			if (roguelikeRoleData == null || roleInfo == null || string.IsNullOrEmpty(text))
			{
				this.SetEmptyState(true);
				return;
			}
			int roleSkinId = roguelikeRoleData.GetRoleSkinId();
			base.SetRoleSkinIcon(text, base.GetTexture(2), roleSkinId, null, null);
			this.SetEmptyState(false);
		}

		// Token: 0x060283E0 RID: 164832 RVA: 0x00B46184 File Offset: 0x00B44384
		private void SetEmptyState(bool isEmpty)
		{
			base.GetItem(1).SetUIActive(isEmpty);
			base.GetTexture(2).SetUIActive(!isEmpty);
		}

		// Token: 0x02009958 RID: 39256
		private class EComponents
		{
			// Token: 0x0402FD33 RID: 195891
			public const int BtnMainRole = 0;

			// Token: 0x0402FD34 RID: 195892
			public const int PnlEmpty = 1;

			// Token: 0x0402FD35 RID: 195893
			public const int TexMainRoleAvatar = 2;
		}
	}
}
