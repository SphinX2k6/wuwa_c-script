using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D7E RID: 15742
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoguelikeAchieveTogRoleRecordItem : GridProxyAbstract<RoguelikeAchieveSlotData>
	{
		// Token: 0x06028426 RID: 164902 RVA: 0x00B47094 File Offset: 0x00B45294
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

		// Token: 0x06028427 RID: 164903 RVA: 0x00B4717C File Offset: 0x00B4537C
		public override void Refresh(RoguelikeAchieveSlotData data, bool isSelected, int gridIndex)
		{
			this.SlotData = data;
			this.RefreshSlotIndex(data);
			this.RefreshRoleAvatar(data);
			this.SetToggleState(isSelected, false);
		}

		// Token: 0x06028428 RID: 164904 RVA: 0x00B4719B File Offset: 0x00B4539B
		protected override void OnStart()
		{
			this.SetRoleAvatarActive(false);
			this.SetToggleState(false, false);
		}

		// Token: 0x06028429 RID: 164905 RVA: 0x00B471AC File Offset: 0x00B453AC
		protected override void OnBeforeDestroy()
		{
			this.SlotData = null;
			this.OnToggleStateChanged = null;
		}

		// Token: 0x0602842A RID: 164906 RVA: 0x00B471BC File Offset: 0x00B453BC
		public void BindOnToggleStateChanged(Action<RoguelikeAchieveSlotData, int, EToggleState> callback)
		{
			this.OnToggleStateChanged = callback;
		}

		// Token: 0x0602842B RID: 164907 RVA: 0x00B471C5 File Offset: 0x00B453C5
		public override void OnSelected(bool fireEvent)
		{
			this.SetToggleState(true, fireEvent);
		}

		// Token: 0x0602842C RID: 164908 RVA: 0x00B471CF File Offset: 0x00B453CF
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleState(false, fireEvent);
		}

		// Token: 0x0602842D RID: 164909 RVA: 0x00B471D9 File Offset: 0x00B453D9
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

		// Token: 0x0602842E RID: 164910 RVA: 0x00B47204 File Offset: 0x00B45404
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

		// Token: 0x0602842F RID: 164911 RVA: 0x00B47298 File Offset: 0x00B45498
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

		// Token: 0x06028430 RID: 164912 RVA: 0x00B47380 File Offset: 0x00B45580
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

		// Token: 0x06028431 RID: 164913 RVA: 0x00B473AA File Offset: 0x00B455AA
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

		// Token: 0x04015E45 RID: 89669
		[Nullable(2)]
		private RoguelikeAchieveSlotData SlotData;

		// Token: 0x04015E46 RID: 89670
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<RoguelikeAchieveSlotData, int, EToggleState> OnToggleStateChanged;

		// Token: 0x02009961 RID: 39265
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0402FD4F RID: 195919
			public const int ToggleItem = 0;

			// Token: 0x0402FD50 RID: 195920
			public const int TxtNum = 1;

			// Token: 0x0402FD51 RID: 195921
			public const int RoleAvatarItem = 2;

			// Token: 0x0402FD52 RID: 195922
			public const int TexRole = 3;
		}
	}
}
