using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.PhoneMessage;
using CSharpScript.Game.Module.PhoneMessage.View;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D8D RID: 19853
	public class GamepadPhoneMessageButton : UiPanelBase, IPhoneMessageButtonImplement
	{
		// Token: 0x06031DA4 RID: 204196 RVA: 0x00DF13B0 File Offset: 0x00DEF5B0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUINiagara));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnButtonClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06031DA5 RID: 204197 RVA: 0x00DF151C File Offset: 0x00DEF71C
		protected override void OnStart()
		{
			base.GetItem(1).SetUIActive(false);
			this.Helper = new PhoneMessageButtonHelper(this.RootItem, this.RootActor, base.GetItem(1), base.GetSprite(2), base.GetItem(4), base.GetTexture(5), base.GetItem(6), base.GetUiNiagara(7), delegate(string path, UUITexture texture)
			{
				base.SetTextureByPath(path, texture, null, null);
			});
			this.Helper.Init();
		}

		// Token: 0x06031DA6 RID: 204198 RVA: 0x00DF158E File Offset: 0x00DEF78E
		public void OnShowGamepadTopPanel()
		{
			PhoneMessageButtonHelper helper = this.Helper;
			if (helper == null)
			{
				return;
			}
			helper.OnShowBattleChildView();
		}

		// Token: 0x06031DA7 RID: 204199 RVA: 0x00DF15A0 File Offset: 0x00DEF7A0
		public void OnHideGamepadTopPanel()
		{
			PhoneMessageButtonHelper helper = this.Helper;
			if (helper == null)
			{
				return;
			}
			helper.OnHideBattleChildView();
		}

		// Token: 0x06031DA8 RID: 204200 RVA: 0x00DF15B2 File Offset: 0x00DEF7B2
		protected override void OnBeforeDestroy()
		{
			base.OnBeforeDestroy();
			PhoneMessageButtonHelper helper = this.Helper;
			if (helper == null)
			{
				return;
			}
			helper.Clear();
		}

		// Token: 0x06031DA9 RID: 204201 RVA: 0x00DF15CA File Offset: 0x00DEF7CA
		private void OnButtonClick()
		{
			PhoneMsgController.Instance.OpenAndJumpShowTipShortMessage(EPhoneMsgOpenWay.HUD, EPhoneMsgViewType.Big);
		}

		// Token: 0x06031DAA RID: 204202 RVA: 0x00DF15D8 File Offset: 0x00DEF7D8
		public void CheckAndPlayPhoneSequence()
		{
			PhoneMessageButtonHelper helper = this.Helper;
			if (helper == null)
			{
				return;
			}
			helper.CheckAndPlayPhoneSequence();
		}

		// Token: 0x06031DAB RID: 204203 RVA: 0x00DF15EA File Offset: 0x00DEF7EA
		public void PopShowHeadIcon()
		{
			PhoneMessageButtonHelper helper = this.Helper;
			if (helper == null)
			{
				return;
			}
			helper.PopShowHeadIcon();
		}

		// Token: 0x06031DAC RID: 204204 RVA: 0x00DF15FC File Offset: 0x00DEF7FC
		public void HideHeadIcon()
		{
			PhoneMessageButtonHelper helper = this.Helper;
			if (helper == null)
			{
				return;
			}
			helper.HideHeadIcon();
		}

		// Token: 0x0401A62D RID: 108077
		[Nullable(2)]
		private PhoneMessageButtonHelper Helper;

		// Token: 0x0200AA8E RID: 43662
		private enum EChildType
		{
			// Token: 0x04034B59 RID: 215897
			Button,
			// Token: 0x04034B5A RID: 215898
			RedDotItem,
			// Token: 0x04034B5B RID: 215899
			SpriteEnterIcon,
			// Token: 0x04034B5C RID: 215900
			TexPhoneBlue,
			// Token: 0x04034B5D RID: 215901
			PanelPrefabHead,
			// Token: 0x04034B5E RID: 215902
			TexIconHead,
			// Token: 0x04034B5F RID: 215903
			BubbleItem,
			// Token: 0x04034B60 RID: 215904
			NiagaraItem
		}
	}
}
