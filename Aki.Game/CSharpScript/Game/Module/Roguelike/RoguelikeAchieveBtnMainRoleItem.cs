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
	// Token: 0x02004DA8 RID: 19880
	public class RoguelikeAchieveBtnMainRoleItem : UiPanelBase
	{
		// Token: 0x06033570 RID: 210288 RVA: 0x00BFCB08 File Offset: 0x00BFAD08
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

		// Token: 0x06033571 RID: 210289 RVA: 0x00BFCB92 File Offset: 0x00BFAD92
		protected override void OnStart()
		{
			this.SetEmptyState(true);
		}

		// Token: 0x06033572 RID: 210290 RVA: 0x00BFCB9C File Offset: 0x00BFAD9C
		[NullableContext(2)]
		public void Refresh(RogueArchiveInfoData archiveInfoData)
		{
			int num = (archiveInfoData != null) ? archiveInfoData.RoleIds.ElementAtOrDefault(0) : 0;
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

		// Token: 0x06033573 RID: 210291 RVA: 0x00BFCC52 File Offset: 0x00BFAE52
		private void SetEmptyState(bool isEmpty)
		{
			base.GetItem(1).SetUIActive(isEmpty);
			base.GetTexture(2).SetUIActive(!isEmpty);
		}

		// Token: 0x0200AF23 RID: 44835
		private class EComponents
		{
			// Token: 0x040352FE RID: 217854
			public const int BtnMainRole = 0;

			// Token: 0x040352FF RID: 217855
			public const int PnlEmpty = 1;

			// Token: 0x04035300 RID: 217856
			public const int TexMainRoleAvatar = 2;
		}
	}
}
