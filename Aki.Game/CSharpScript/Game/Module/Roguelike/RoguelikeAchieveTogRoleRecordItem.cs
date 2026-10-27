using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DB5 RID: 19893
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoguelikeAchieveTogRoleRecordItem : GridProxyAbstract<RoguelikeAchieveSlotData>
	{
		// Token: 0x060335B9 RID: 210361 RVA: 0x00BFDB54 File Offset: 0x00BFBD54
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleItemClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060335BA RID: 210362 RVA: 0x00BFDC3C File Offset: 0x00BFBE3C
		public override void Refresh(RoguelikeAchieveSlotData data, bool isSelected, int gridIndex)
		{
			this.SlotData = data;
			this.RefreshSlotIndex(data);
			this.RefreshRoleAvatar(data);
			this.SetToggleState(isSelected, false);
		}

		// Token: 0x060335BB RID: 210363 RVA: 0x00BFDC5B File Offset: 0x00BFBE5B
		protected override void OnStart()
		{
			this.SetRoleAvatarActive(false);
			this.SetToggleState(false, false);
		}

		// Token: 0x060335BC RID: 210364 RVA: 0x00BFDC6C File Offset: 0x00BFBE6C
		protected override void OnBeforeDestroy()
		{
			this.SlotData = null;
			this.OnToggleStateChanged = null;
		}

		// Token: 0x060335BD RID: 210365 RVA: 0x00BFDC7C File Offset: 0x00BFBE7C
		public void BindOnToggleStateChanged(Action<RoguelikeAchieveSlotData, int, EToggleState> callback)
		{
			this.OnToggleStateChanged = callback;
		}

		// Token: 0x060335BE RID: 210366 RVA: 0x00BFDC85 File Offset: 0x00BFBE85
		public override void OnSelected(bool fireEvent)
		{
			this.SetToggleState(true, fireEvent);
		}

		// Token: 0x060335BF RID: 210367 RVA: 0x00BFDC8F File Offset: 0x00BFBE8F
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleState(false, fireEvent);
		}

		// Token: 0x060335C0 RID: 210368 RVA: 0x00BFDC99 File Offset: 0x00BFBE99
		private void OnToggleItemClick(EToggleState state)
		{
			if (this.SlotData == null)
			{
				return;
			}
			Action<RoguelikeAchieveSlotData, int, EToggleState> onToggleStateChanged = this.OnToggleStateChanged;
			if (onToggleStateChanged == null)
			{
				return;
			}
			onToggleStateChanged(this.SlotData, base.GridIndex, state);
		}

		// Token: 0x060335C1 RID: 210369 RVA: 0x00BFDCC4 File Offset: 0x00BFBEC4
		private void RefreshSlotIndex(RoguelikeAchieveSlotData data)
		{
			RogueArchiveInfoData archiveInfoData = data.ArchiveInfoData;
			int? num = (archiveInfoData != null) ? new int?(archiveInfoData.ShowIndex) : null;
			if (num != null)
			{
				int? num2 = num;
				int num3 = 0;
				if (!(num2.GetValueOrDefault() <= num3 & num2 != null))
				{
					UUIText text = base.GetText(1);
					if (text == null)
					{
						return;
					}
					text.SetText(num.Value.ToString().PadLeft(2, '0'), true);
					return;
				}
			}
			UUIText text2 = base.GetText(1);
			if (text2 == null)
			{
				return;
			}
			text2.SetText("", true);
		}

		// Token: 0x060335C2 RID: 210370 RVA: 0x00BFDD58 File Offset: 0x00BFBF58
		private void RefreshRoleAvatar(RoguelikeAchieveSlotData data)
		{
			RogueArchiveInfoData archiveInfoData = data.ArchiveInfoData;
			int? num;
			if (archiveInfoData == null)
			{
				num = null;
			}
			else
			{
				RoguelikeInfo roguelikeInfo = archiveInfoData.RoguelikeInfo;
				num = ((roguelikeInfo != null) ? new int?(roguelikeInfo.RoleEntry.ConfigId) : null);
			}
			int? num2 = num;
			int valueOrDefault = num2.GetValueOrDefault();
			if (valueOrDefault <= 0)
			{
				this.SetRoleAvatarActive(false);
				return;
			}
			RoleDataBase roguelikeRoleData = RoguelikeModel.Instance.GetRoguelikeRoleData(valueOrDefault);
			RoleInfo? roleInfo = (roguelikeRoleData != null) ? new RoleInfo?(roguelikeRoleData.GetRoleConfig()) : null;
			string text = (roleInfo != null) ? roleInfo.GetValueOrDefault().RoleHeadIconCircle : null;
			if (roguelikeRoleData == null || roleInfo == null || string.IsNullOrEmpty(text))
			{
				this.SetRoleAvatarActive(false);
				return;
			}
			int roleSkinId = roguelikeRoleData.GetRoleSkinId();
			this.SetRoleAvatarActive(true);
			base.SetRoleSkinIcon(text, base.GetTexture(3), roleSkinId, null, null);
		}

		// Token: 0x060335C3 RID: 210371 RVA: 0x00BFDE40 File Offset: 0x00BFC040
		private void SetToggleState(bool isSelected, bool fireEvent)
		{
			EToggleState state = isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(state, fireEvent, false, false);
		}

		// Token: 0x060335C4 RID: 210372 RVA: 0x00BFDE6A File Offset: 0x00BFC06A
		private void SetRoleAvatarActive(bool isActive)
		{
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(isActive);
			}
			UUITexture texture = base.GetTexture(3);
			if (texture == null)
			{
				return;
			}
			texture.SetUIActive(isActive);
		}

		// Token: 0x0401B472 RID: 111730
		[Nullable(2)]
		private RoguelikeAchieveSlotData SlotData;

		// Token: 0x0401B473 RID: 111731
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<RoguelikeAchieveSlotData, int, EToggleState> OnToggleStateChanged;

		// Token: 0x0200AF2C RID: 44844
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403531A RID: 217882
			public const int ToggleItem = 0;

			// Token: 0x0403531B RID: 217883
			public const int TxtNum = 1;

			// Token: 0x0403531C RID: 217884
			public const int RoleAvatarItem = 2;

			// Token: 0x0403531D RID: 217885
			public const int TexRole = 3;
		}
	}
}
