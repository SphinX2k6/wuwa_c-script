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
	// Token: 0x02005DA9 RID: 23977
	public class GamepadPhoneMessageButton : UiPanelBase, IPhoneMessageButtonImplement
	{
		// Token: 0x0603CE2D RID: 249389 RVA: 0x00EA0504 File Offset: 0x00E9E704
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

		// Token: 0x0603CE2E RID: 249390 RVA: 0x00EA0670 File Offset: 0x00E9E870
		protected override void OnStart()
		{
			base.GetItem(1).SetUIActive(false);
			this.Helper = new PhoneMessageButtonHelper(this.RootItem, this.RootActor, base.GetItem(1), base.GetSprite(2), base.GetItem(4), base.GetTexture(5), base.GetItem(6), base.GetUiNiagara(7), delegate(string path, UUITexture texture)
			{
				base.SetTextureByPath(path, texture, null, null);
			});
			this.Helper.Init();
		}

		// Token: 0x0603CE2F RID: 249391 RVA: 0x00EA06E2 File Offset: 0x00E9E8E2
		public void OnShowGamepadTopPanel()
		{
			PhoneMessageButtonHelper helper = this.Helper;
			if (helper == null)
			{
				return;
			}
			helper.OnShowBattleChildView();
		}

		// Token: 0x0603CE30 RID: 249392 RVA: 0x00EA06F4 File Offset: 0x00E9E8F4
		public void OnHideGamepadTopPanel()
		{
			PhoneMessageButtonHelper helper = this.Helper;
			if (helper == null)
			{
				return;
			}
			helper.OnHideBattleChildView();
		}

		// Token: 0x0603CE31 RID: 249393 RVA: 0x00EA0706 File Offset: 0x00E9E906
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

		// Token: 0x0603CE32 RID: 249394 RVA: 0x00EA071E File Offset: 0x00E9E91E
		private void OnButtonClick()
		{
			PhoneMsgController.Instance.OpenAndJumpShowTipShortMessage(EPhoneMsgOpenWay.HUD, EPhoneMsgViewType.Big);
		}

		// Token: 0x0603CE33 RID: 249395 RVA: 0x00EA072C File Offset: 0x00E9E92C
		public void CheckAndPlayPhoneSequence()
		{
			PhoneMessageButtonHelper helper = this.Helper;
			if (helper == null)
			{
				return;
			}
			helper.CheckAndPlayPhoneSequence();
		}

		// Token: 0x0603CE34 RID: 249396 RVA: 0x00EA073E File Offset: 0x00E9E93E
		public void PopShowHeadIcon()
		{
			PhoneMessageButtonHelper helper = this.Helper;
			if (helper == null)
			{
				return;
			}
			helper.PopShowHeadIcon();
		}

		// Token: 0x0603CE35 RID: 249397 RVA: 0x00EA0750 File Offset: 0x00E9E950
		public void HideHeadIcon()
		{
			PhoneMessageButtonHelper helper = this.Helper;
			if (helper == null)
			{
				return;
			}
			helper.HideHeadIcon();
		}

		// Token: 0x0401FB70 RID: 129904
		[Nullable(2)]
		private PhoneMessageButtonHelper Helper;

		// Token: 0x0200C084 RID: 49284
		private enum EChildType
		{
			// Token: 0x0403A185 RID: 237957
			Button,
			// Token: 0x0403A186 RID: 237958
			RedDotItem,
			// Token: 0x0403A187 RID: 237959
			SpriteEnterIcon,
			// Token: 0x0403A188 RID: 237960
			TexPhoneBlue,
			// Token: 0x0403A189 RID: 237961
			PanelPrefabHead,
			// Token: 0x0403A18A RID: 237962
			TexIconHead,
			// Token: 0x0403A18B RID: 237963
			BubbleItem,
			// Token: 0x0403A18C RID: 237964
			NiagaraItem
		}
	}
}
