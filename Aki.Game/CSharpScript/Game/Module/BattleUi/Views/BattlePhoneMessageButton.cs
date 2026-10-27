using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhoneMessage.View;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CD9 RID: 23769
	public class BattlePhoneMessageButton : BattleEntranceButton, IPhoneMessageButtonImplement
	{
		// Token: 0x0603C25A RID: 246362 RVA: 0x00E66194 File Offset: 0x00E64394
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(2, typeof(UUISprite)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(3, typeof(UUITexture)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(4, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(5, typeof(UUITexture)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(6, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(7, typeof(UUINiagara)));
		}

		// Token: 0x0603C25B RID: 246363 RVA: 0x00E6624C File Offset: 0x00E6444C
		protected override void OnStart()
		{
			base.OnStart();
			this.Helper = new PhoneMessageButtonHelper(this.RootItem, this.RootActor, base.GetItem(1), base.GetSprite(2), base.GetItem(4), base.GetTexture(5), base.GetItem(6), base.GetUiNiagara(7), delegate(string path, UUITexture texture)
			{
				base.SetTextureByPath(path, texture, null, null);
			});
			this.Helper.Init();
		}

		// Token: 0x0603C25C RID: 246364 RVA: 0x00E662B7 File Offset: 0x00E644B7
		protected override void OnShowBattleChildView()
		{
			base.OnShowBattleChildView();
			PhoneMessageButtonHelper helper = this.Helper;
			if (helper == null)
			{
				return;
			}
			helper.OnShowBattleChildView();
		}

		// Token: 0x0603C25D RID: 246365 RVA: 0x00E662CF File Offset: 0x00E644CF
		protected override void OnHideBattleChildView()
		{
			base.OnHideBattleChildView();
			PhoneMessageButtonHelper helper = this.Helper;
			if (helper == null)
			{
				return;
			}
			helper.OnHideBattleChildView();
		}

		// Token: 0x0603C25E RID: 246366 RVA: 0x00E662E7 File Offset: 0x00E644E7
		public override void Reset()
		{
			base.Reset();
			PhoneMessageButtonHelper helper = this.Helper;
			if (helper == null)
			{
				return;
			}
			helper.Clear();
		}

		// Token: 0x0603C25F RID: 246367 RVA: 0x00E662FF File Offset: 0x00E644FF
		public void CheckAndPlayPhoneSequence()
		{
			PhoneMessageButtonHelper helper = this.Helper;
			if (helper == null)
			{
				return;
			}
			helper.CheckAndPlayPhoneSequence();
		}

		// Token: 0x0603C260 RID: 246368 RVA: 0x00E66311 File Offset: 0x00E64511
		public void PopShowHeadIcon()
		{
			PhoneMessageButtonHelper helper = this.Helper;
			if (helper == null)
			{
				return;
			}
			helper.PopShowHeadIcon();
		}

		// Token: 0x0603C261 RID: 246369 RVA: 0x00E66323 File Offset: 0x00E64523
		public void HideHeadIcon()
		{
			PhoneMessageButtonHelper helper = this.Helper;
			if (helper == null)
			{
				return;
			}
			helper.HideHeadIcon();
		}

		// Token: 0x0401F5BC RID: 128444
		[Nullable(2)]
		private PhoneMessageButtonHelper Helper;

		// Token: 0x0200BF31 RID: 48945
		private enum EChildType
		{
			// Token: 0x04039AB9 RID: 236217
			Button,
			// Token: 0x04039ABA RID: 236218
			RedDotItem,
			// Token: 0x04039ABB RID: 236219
			SpriteEnterIcon,
			// Token: 0x04039ABC RID: 236220
			TexPhoneBlue,
			// Token: 0x04039ABD RID: 236221
			PanelPrefabHead,
			// Token: 0x04039ABE RID: 236222
			TexIconHead,
			// Token: 0x04039ABF RID: 236223
			BubbleItem,
			// Token: 0x04039AC0 RID: 236224
			NiagaraItem
		}
	}
}
