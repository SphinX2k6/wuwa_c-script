using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuickHack.View
{
	// Token: 0x02003F5B RID: 16219
	[NullableContext(1)]
	[Nullable(0)]
	public class QuickHackSkillItem : UiPanelBase
	{
		// Token: 0x0602910C RID: 168204 RVA: 0x00B88610 File Offset: 0x00B86810
		protected unsafe override void OnRegisterComponent()
		{
			int num = 12;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIExtendToggleSpriteTransition));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602910D RID: 168205 RVA: 0x00B887C8 File Offset: 0x00B869C8
		protected override void OnStart()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			extendToggle.bLockStateOnSelect = true;
			extendToggle.OnStateChange.Add(new Action<EToggleState>(this.OnStateChange));
			extendToggle.OnPointDownCallBack.Bind(new Action<EToggleState>(this.OnPointDown));
		}

		// Token: 0x0602910E RID: 168206 RVA: 0x00B88821 File Offset: 0x00B86A21
		public void InitSelectSkillAudioPath(string selectSkillAudioPath)
		{
			this.SelectSkillAudioPath = selectSkillAudioPath;
		}

		// Token: 0x0602910F RID: 168207 RVA: 0x00B8882A File Offset: 0x00B86A2A
		public void PlayUseSkillSequence()
		{
			if (this.SequencePlayer == null)
			{
				return;
			}
			this.SequencePlayer.StopPrevSequence(false, true);
			this.SequencePlayer.PlaySequencePurely("PitchOn", false, false);
		}

		// Token: 0x06029110 RID: 168208 RVA: 0x00B88854 File Offset: 0x00B86A54
		public void PlayDisableSequence()
		{
			if (this.SequencePlayer == null)
			{
				return;
			}
			this.SequencePlayer.StopPrevSequence(false, true);
			this.SequencePlayer.PlaySequencePurely("Refused", false, false);
		}

		// Token: 0x06029111 RID: 168209 RVA: 0x00B88880 File Offset: 0x00B86A80
		public void Refresh(QuickHackSkillInstance data, bool isSelected, int gridIndex)
		{
			int num = (gridIndex < QuickHackDefine.quickHackSkillItemOffsets.Count) ? QuickHackDefine.quickHackSkillItemOffsets[gridIndex] : 0;
			base.GetExtendToggle(0).RootUIComp.Get().SetAnchorOffsetX((float)num);
			QuickHackSkillInstance skill = this.Skill;
			if (skill != null)
			{
				skill.UnRegisterOnCheckSkillCanUse(new Action<QuickHackSkillConditionResult>(this.OnCheckSkillCanUse));
			}
			this.RefreshByState(data.GetSkillCanUseInfo().IsSuccess);
			data.RegisterOnCheckSkillCanUse(new Action<QuickHackSkillConditionResult>(this.OnCheckSkillCanUse));
			this.Skill = data;
			QuickHackSkill config = data.GetConfig();
			base.GetText(4).SetText(config.RamCost.ToString(), true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), config.SkillName, Array.Empty<object>());
			base.SetTextureByPath(config.Icon, base.GetTexture(2), null, null);
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			extendToggle.SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			this.RefreshKeyItem(isSelected);
			if (isSelected)
			{
				UiNavigationNewController.Instance.SetNavigationFocusForView(extendToggle.RootUIComp, true, false, false);
			}
		}

		// Token: 0x06029112 RID: 168210 RVA: 0x00B889A8 File Offset: 0x00B86BA8
		protected override void OnBeforeDestroy()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			extendToggle.OnStateChange.Remove(new Action<EToggleState>(this.OnStateChange));
			extendToggle.OnPointDownCallBack.Unbind();
			this.CancelItemBgAsyncLoad();
			QuickHackSkillInstance skill = this.Skill;
			if (skill != null)
			{
				skill.UnRegisterOnCheckSkillCanUse(new Action<QuickHackSkillConditionResult>(this.OnCheckSkillCanUse));
			}
			this.Skill = null;
		}

		// Token: 0x06029113 RID: 168211 RVA: 0x00B88A07 File Offset: 0x00B86C07
		private void OnCheckSkillCanUse(QuickHackSkillConditionResult result)
		{
			this.RefreshByState(result.IsSuccess);
		}

		// Token: 0x06029114 RID: 168212 RVA: 0x00B88A18 File Offset: 0x00B86C18
		private void RefreshByState(bool enable)
		{
			UUIText text = base.GetText(7);
			string textStringId = enable ? "Skill_10001511_HackSkill101" : "Skill_10001511_HackSkill102";
			LguiUtil.Instance.SetLocalTextNew(text, textStringId, Array.Empty<object>());
			if (this.IsEnable == enable)
			{
				return;
			}
			this.IsEnable = enable;
			bool flag = false;
			string resourceId;
			string resourceId2;
			string resourceId3;
			string resourceId4;
			string resourceId5;
			string hexStr;
			if (enable)
			{
				resourceId = "QuickHackSkillEnableBg";
				resourceId2 = "QuickHackSkillEnableHoldBg";
				resourceId3 = "QuickHackSkillEnableIconBg";
				resourceId4 = "QuickHackSkillEnableRamIcon";
				resourceId5 = "QuickHackSkillEnableTagBg";
				hexStr = "#55DAFFFF";
			}
			else
			{
				flag = true;
				resourceId = "QuickHackSkillDisableBg";
				resourceId2 = "QuickHackSkillDisableHoldBg";
				resourceId3 = "QuickHackSkillDisableIconBg";
				resourceId4 = "QuickHackSkillDisableRamIcon";
				resourceId5 = "QuickHackSkillDisableTagBg";
				hexStr = "#FF5753FF";
			}
			this.CancelItemBgAsyncLoad();
			this.ItemBgResourceId = ResourceSystem.Instance.LoadAsync<ULGUISpriteData_BaseObject>(UiResourceConfig.Instance.GetResourcePath(resourceId), delegate([Nullable(2)] ULGUISpriteData_BaseObject sprite, string _)
			{
				this.ItemBgResourceId = -1;
				if (sprite == null || !sprite.IsValid())
				{
					return;
				}
				UUIExtendToggleSpriteTransition uiExtendToggleSpriteTransition = base.GetUiExtendToggleSpriteTransition(8);
				if (uiExtendToggleSpriteTransition == null || !uiExtendToggleSpriteTransition.IsValid())
				{
					return;
				}
				uiExtendToggleSpriteTransition.SetStateSprite(EToggleTransitionState.ETT_UnCheckedUnHover, sprite, false);
			}, ResourceSystem.EResourceLoadPriority.Default, this.MemoryTag);
			this.ItemHoldBgResourceId = ResourceSystem.Instance.LoadAsync<ULGUISpriteData_BaseObject>(UiResourceConfig.Instance.GetResourcePath(resourceId2), delegate([Nullable(2)] ULGUISpriteData_BaseObject sprite, string _)
			{
				this.ItemHoldBgResourceId = -1;
				if (sprite == null || !sprite.IsValid())
				{
					return;
				}
				UUIExtendToggleSpriteTransition uiExtendToggleSpriteTransition = base.GetUiExtendToggleSpriteTransition(8);
				if (uiExtendToggleSpriteTransition == null || !uiExtendToggleSpriteTransition.IsValid())
				{
					return;
				}
				uiExtendToggleSpriteTransition.SetStateSprite(EToggleTransitionState.ETT_UnCheckedHover, sprite, false);
				uiExtendToggleSpriteTransition.SetStateSprite(EToggleTransitionState.ETT_UnCheckedPressed, sprite, false);
				uiExtendToggleSpriteTransition.SetStateSprite(EToggleTransitionState.ETT_CheckedUnHover, sprite, false);
				uiExtendToggleSpriteTransition.SetStateSprite(EToggleTransitionState.ETT_CheckedHover, sprite, false);
				uiExtendToggleSpriteTransition.SetStateSprite(EToggleTransitionState.ETT_CheckedPressed, sprite, false);
			}, ResourceSystem.EResourceLoadPriority.Default, this.MemoryTag);
			this.SetSpriteByPath(UiResourceConfig.Instance.GetResourcePath(resourceId3), base.GetSprite(1), false, null, null);
			this.SetSpriteByPath(UiResourceConfig.Instance.GetResourcePath(resourceId4), base.GetSprite(3), false, null, null);
			this.SetSpriteByPath(UiResourceConfig.Instance.GetResourcePath(resourceId5), base.GetSprite(6), false, null, null);
			UUIText text2 = base.GetText(4);
			UUIText text3 = base.GetText(5);
			UUITexture texture = base.GetTexture(2);
			UUIItem uuiitem = text2;
			bool bUseChangeColor = flag;
			FColor? fcolor = new FColor?(text2.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			UUIItem uuiitem2 = text3;
			bool bUseChangeColor2 = flag;
			fcolor = new FColor?(text3.changeColor);
			uuiitem2.SetChangeColor(bUseChangeColor2, fcolor);
			UUIItem uuiitem3 = text;
			bool bUseChangeColor3 = flag;
			fcolor = new FColor?(text.changeColor);
			uuiitem3.SetChangeColor(bUseChangeColor3, fcolor);
			UUIItem uuiitem4 = texture;
			bool bUseChangeColor4 = flag;
			fcolor = new FColor?(texture.changeColor);
			uuiitem4.SetChangeColor(bUseChangeColor4, fcolor);
			base.GetItem(10).SetColor(FColor.FromHex(hexStr));
			base.GetTexture(9).SetUIActive(!enable);
		}

		// Token: 0x06029115 RID: 168213 RVA: 0x00B88C40 File Offset: 0x00B86E40
		public void OnSelected()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
			UiNavigationNewController.Instance.SetNavigationFocusForView(extendToggle.RootUIComp, true, false, false);
			this.RefreshKeyItem(true);
		}

		// Token: 0x06029116 RID: 168214 RVA: 0x00B88C80 File Offset: 0x00B86E80
		public void OnDeselected()
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			this.RefreshKeyItem(false);
		}

		// Token: 0x06029117 RID: 168215 RVA: 0x00B88C9A File Offset: 0x00B86E9A
		private void OnStateChange(EToggleState state)
		{
			this.RefreshKeyItem(state == EToggleState.ETT_Checked);
			if (state == EToggleState.ETT_Checked && this.Skill != null)
			{
				QuickHackController.Instance.SelectSkill(this.Skill, true);
			}
		}

		// Token: 0x06029118 RID: 168216 RVA: 0x00B88CC4 File Offset: 0x00B86EC4
		private void CancelItemBgAsyncLoad()
		{
			if (this.ItemBgResourceId != -1)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.ItemBgResourceId);
				this.ItemBgResourceId = -1;
			}
			if (this.ItemHoldBgResourceId != -1)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.ItemHoldBgResourceId);
				this.ItemHoldBgResourceId = -1;
			}
		}

		// Token: 0x06029119 RID: 168217 RVA: 0x00B88D14 File Offset: 0x00B86F14
		private void RefreshKeyItem(bool isSelected)
		{
			UUIItem item = base.GetItem(11);
			List<QuickHackSkillInstance> currentSkillList = QuickHackModel.Instance.CurrentSkillList;
			bool uiactive = ((currentSkillList != null) ? currentSkillList.Count : 0) > 1 && isSelected;
			item.SetUIActive(uiactive);
		}

		// Token: 0x0602911A RID: 168218 RVA: 0x00B88D4B File Offset: 0x00B86F4B
		private void OnPointDown(EToggleState state)
		{
			if (!StringUtils.IsBlank(this.SelectSkillAudioPath))
			{
				AudioSystem.Instance.PostEvent(this.SelectSkillAudioPath);
			}
		}

		// Token: 0x04016584 RID: 91524
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x04016585 RID: 91525
		[Nullable(2)]
		private QuickHackSkillInstance Skill;

		// Token: 0x04016586 RID: 91526
		private bool IsEnable = true;

		// Token: 0x04016587 RID: 91527
		private int ItemBgResourceId = -1;

		// Token: 0x04016588 RID: 91528
		private int ItemHoldBgResourceId = -1;

		// Token: 0x04016589 RID: 91529
		private string SelectSkillAudioPath = "";

		// Token: 0x02009AD6 RID: 39638
		[NullableContext(0)]
		private class EComponentType
		{
			// Token: 0x04030429 RID: 197673
			public const int SkillToggle = 0;

			// Token: 0x0403042A RID: 197674
			public const int IconBgSprite = 1;

			// Token: 0x0403042B RID: 197675
			public const int IconTexture = 2;

			// Token: 0x0403042C RID: 197676
			public const int StateSprite = 3;

			// Token: 0x0403042D RID: 197677
			public const int CostText = 4;

			// Token: 0x0403042E RID: 197678
			public const int NameText = 5;

			// Token: 0x0403042F RID: 197679
			public const int TagBgSprite = 6;

			// Token: 0x04030430 RID: 197680
			public const int TagText = 7;

			// Token: 0x04030431 RID: 197681
			public const int ItemBgSprite = 8;

			// Token: 0x04030432 RID: 197682
			public const int DisableTexture = 9;

			// Token: 0x04030433 RID: 197683
			public const int ClickItem = 10;

			// Token: 0x04030434 RID: 197684
			public const int KeyItem = 11;
		}
	}
}
