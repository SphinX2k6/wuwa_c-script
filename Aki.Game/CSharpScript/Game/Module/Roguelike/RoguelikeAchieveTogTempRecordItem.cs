using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D80 RID: 15744
	public class RoguelikeAchieveTogTempRecordItem : UiPanelBase
	{
		// Token: 0x06028437 RID: 164919 RVA: 0x00B473DC File Offset: 0x00B455DC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleItemClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06028438 RID: 164920 RVA: 0x00B474E5 File Offset: 0x00B456E5
		protected override void OnStart()
		{
			base.SetUiActive(false);
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.SetUIActive(false);
			}
			this.SetRoleAvatarActive(false);
			this.SetToggleState(false, false);
		}

		// Token: 0x06028439 RID: 164921 RVA: 0x00B47510 File Offset: 0x00B45710
		protected override void OnBeforeDestroy()
		{
			this.OnToggleStateChanged = null;
		}

		// Token: 0x0602843A RID: 164922 RVA: 0x00B47519 File Offset: 0x00B45719
		[NullableContext(2)]
		public void Refresh(RogueArchiveInfoData archiveInfoData, bool isSaved)
		{
			if (archiveInfoData == null)
			{
				base.SetUiActive(false);
				this.SetToggleState(false, false);
				return;
			}
			base.SetUiActive(true);
			this.RefreshStateIcon(isSaved);
			this.RefreshRoleAvatar(archiveInfoData);
		}

		// Token: 0x0602843B RID: 164923 RVA: 0x00B47543 File Offset: 0x00B45743
		[NullableContext(1)]
		public void BindOnToggleStateChanged(TTempRecordToggleStateChanged callback)
		{
			this.OnToggleStateChanged = callback;
		}

		// Token: 0x0602843C RID: 164924 RVA: 0x00B4754C File Offset: 0x00B4574C
		public void SetToggleState(bool isSelected, bool fireEvent)
		{
			EToggleState state = isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(state, fireEvent, false, false);
		}

		// Token: 0x0602843D RID: 164925 RVA: 0x00B47576 File Offset: 0x00B45776
		private void OnToggleItemClick(EToggleState state)
		{
			TTempRecordToggleStateChanged onToggleStateChanged = this.OnToggleStateChanged;
			if (onToggleStateChanged == null)
			{
				return;
			}
			onToggleStateChanged(state);
		}

		// Token: 0x0602843E RID: 164926 RVA: 0x00B4758C File Offset: 0x00B4578C
		private void RefreshStateIcon(bool isSaved)
		{
			string path = isSaved ? RoguelikeAchieveDefine.RoguelikeAchieveUnSavedStateIconPath : RoguelikeAchieveDefine.RoguelikeAchieveSavedStateIconPath;
			this.SetSpriteByPath(path, base.GetSprite(1), false, null, null);
		}

		// Token: 0x0602843F RID: 164927 RVA: 0x00B475C4 File Offset: 0x00B457C4
		[NullableContext(1)]
		private void RefreshRoleAvatar(RogueArchiveInfoData archiveInfoData)
		{
			RoguelikeInfo roguelikeInfo = archiveInfoData.RoguelikeInfo;
			int num = (roguelikeInfo != null) ? roguelikeInfo.RoleEntry.ConfigId : 0;
			if (num <= 0)
			{
				this.SetRoleAvatarActive(false);
				return;
			}
			RoleDataBase roguelikeRoleData = RoguelikeModel.Instance.GetRoguelikeRoleData(num);
			RoleInfo? roleInfo = (roguelikeRoleData != null) ? new RoleInfo?(roguelikeRoleData.GetRoleConfig()) : null;
			string text = (roleInfo != null) ? roleInfo.GetValueOrDefault().RoleHeadIconCircle : null;
			if (roguelikeRoleData == null || roleInfo == null || string.IsNullOrEmpty(text))
			{
				this.SetRoleAvatarActive(false);
				return;
			}
			int roleSkinId = roguelikeRoleData.GetRoleSkinId();
			this.SetRoleAvatarActive(true);
			base.SetRoleSkinIcon(text, base.GetTexture(4), roleSkinId, null, null);
		}

		// Token: 0x06028440 RID: 164928 RVA: 0x00B4767F File Offset: 0x00B4587F
		private void SetRoleAvatarActive(bool isActive)
		{
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(isActive);
			}
			UUITexture texture = base.GetTexture(4);
			if (texture == null)
			{
				return;
			}
			texture.SetUIActive(isActive);
		}

		// Token: 0x04015E47 RID: 89671
		[Nullable(2)]
		private TTempRecordToggleStateChanged OnToggleStateChanged;

		// Token: 0x02009962 RID: 39266
		private class EComponents
		{
			// Token: 0x0402FD53 RID: 195923
			public const int ToggleItem = 0;

			// Token: 0x0402FD54 RID: 195924
			public const int SprStateIcon = 1;

			// Token: 0x0402FD55 RID: 195925
			public const int TxtRoleName = 2;

			// Token: 0x0402FD56 RID: 195926
			public const int RoleAvatarItem = 3;

			// Token: 0x0402FD57 RID: 195927
			public const int TexRole = 4;
		}
	}
}
