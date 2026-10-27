using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DB7 RID: 19895
	public class RoguelikeAchieveTogTempRecordItem : UiPanelBase
	{
		// Token: 0x060335CA RID: 210378 RVA: 0x00BFDE9C File Offset: 0x00BFC09C
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

		// Token: 0x060335CB RID: 210379 RVA: 0x00BFDFA5 File Offset: 0x00BFC1A5
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

		// Token: 0x060335CC RID: 210380 RVA: 0x00BFDFD0 File Offset: 0x00BFC1D0
		protected override void OnBeforeDestroy()
		{
			this.OnToggleStateChanged = null;
		}

		// Token: 0x060335CD RID: 210381 RVA: 0x00BFDFD9 File Offset: 0x00BFC1D9
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

		// Token: 0x060335CE RID: 210382 RVA: 0x00BFE003 File Offset: 0x00BFC203
		[NullableContext(1)]
		public void BindOnToggleStateChanged(TTempRecordToggleStateChanged callback)
		{
			this.OnToggleStateChanged = callback;
		}

		// Token: 0x060335CF RID: 210383 RVA: 0x00BFE00C File Offset: 0x00BFC20C
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

		// Token: 0x060335D0 RID: 210384 RVA: 0x00BFE036 File Offset: 0x00BFC236
		private void OnToggleItemClick(EToggleState state)
		{
			TTempRecordToggleStateChanged onToggleStateChanged = this.OnToggleStateChanged;
			if (onToggleStateChanged == null)
			{
				return;
			}
			onToggleStateChanged(state);
		}

		// Token: 0x060335D1 RID: 210385 RVA: 0x00BFE04C File Offset: 0x00BFC24C
		private void RefreshStateIcon(bool isSaved)
		{
			string path = isSaved ? RoguelikeAchieveDefine.RoguelikeAchieveUnSavedStateIconPath : RoguelikeAchieveDefine.RoguelikeAchieveSavedStateIconPath;
			this.SetSpriteByPath(path, base.GetSprite(1), false, null, null);
		}

		// Token: 0x060335D2 RID: 210386 RVA: 0x00BFE084 File Offset: 0x00BFC284
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

		// Token: 0x060335D3 RID: 210387 RVA: 0x00BFE13F File Offset: 0x00BFC33F
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

		// Token: 0x0401B474 RID: 111732
		[Nullable(2)]
		private TTempRecordToggleStateChanged OnToggleStateChanged;

		// Token: 0x0200AF2D RID: 44845
		private class EComponents
		{
			// Token: 0x0403531E RID: 217886
			public const int ToggleItem = 0;

			// Token: 0x0403531F RID: 217887
			public const int SprStateIcon = 1;

			// Token: 0x04035320 RID: 217888
			public const int TxtRoleName = 2;

			// Token: 0x04035321 RID: 217889
			public const int RoleAvatarItem = 3;

			// Token: 0x04035322 RID: 217890
			public const int TexRole = 4;
		}
	}
}
