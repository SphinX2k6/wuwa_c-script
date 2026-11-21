using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D7D RID: 15741
	public class RoguelikeAchieveTeamRoleItem : UiPanelBase
	{
		// Token: 0x06028421 RID: 164897 RVA: 0x00B46F04 File Offset: 0x00B45104
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06028422 RID: 164898 RVA: 0x00B46F8E File Offset: 0x00B4518E
		protected override void OnStart()
		{
			this.SetEmptyState(true);
		}

		// Token: 0x06028423 RID: 164899 RVA: 0x00B46F98 File Offset: 0x00B45198
		[NullableContext(2)]
		public void Refresh(RogueArchiveInfoData archiveInfoData, int roleIndex)
		{
			if (roleIndex < 0)
			{
				this.SetEmptyState(true);
				return;
			}
			int num = (archiveInfoData != null && roleIndex >= 0 && roleIndex < archiveInfoData.RoleIds.Count) ? archiveInfoData.RoleIds[roleIndex] : 0;
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

		// Token: 0x06028424 RID: 164900 RVA: 0x00B4706C File Offset: 0x00B4526C
		private void SetEmptyState(bool isEmpty)
		{
			base.GetItem(1).SetUIActive(isEmpty);
			base.GetTexture(2).SetUIActive(!isEmpty);
		}

		// Token: 0x02009960 RID: 39264
		private class ERoguelikeAchieveTeamRoleItemComponents
		{
			// Token: 0x0402FD4C RID: 195916
			public const int BtnItem = 0;

			// Token: 0x0402FD4D RID: 195917
			public const int PnlEmpty = 1;

			// Token: 0x0402FD4E RID: 195918
			public const int TexRoleAvatar = 2;
		}
	}
}
