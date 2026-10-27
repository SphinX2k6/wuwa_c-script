using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DB4 RID: 19892
	public class RoguelikeAchieveTeamRoleItem : UiPanelBase
	{
		// Token: 0x060335B4 RID: 210356 RVA: 0x00BFD9D4 File Offset: 0x00BFBBD4
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

		// Token: 0x060335B5 RID: 210357 RVA: 0x00BFDA5E File Offset: 0x00BFBC5E
		protected override void OnStart()
		{
			this.SetEmptyState(true);
		}

		// Token: 0x060335B6 RID: 210358 RVA: 0x00BFDA68 File Offset: 0x00BFBC68
		[NullableContext(2)]
		public void Refresh(RogueArchiveInfoData archiveInfoData, int roleIndex)
		{
			if (roleIndex < 0)
			{
				this.SetEmptyState(true);
				return;
			}
			int num = (archiveInfoData != null) ? archiveInfoData.RoleIds.ElementAtOrDefault(roleIndex) : 0;
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

		// Token: 0x060335B7 RID: 210359 RVA: 0x00BFDB2A File Offset: 0x00BFBD2A
		private void SetEmptyState(bool isEmpty)
		{
			base.GetItem(1).SetUIActive(isEmpty);
			base.GetTexture(2).SetUIActive(!isEmpty);
		}

		// Token: 0x0200AF2B RID: 44843
		private class ERoguelikeAchieveTeamRoleItemComponents
		{
			// Token: 0x04035317 RID: 217879
			public const int BtnItem = 0;

			// Token: 0x04035318 RID: 217880
			public const int PnlEmpty = 1;

			// Token: 0x04035319 RID: 217881
			public const int TexRoleAvatar = 2;
		}
	}
}
