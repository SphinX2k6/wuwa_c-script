using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhoneMessage.View;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CBB RID: 19643
	public class BattlePhoneMessageButton : BattleEntranceButton, IPhoneMessageButtonImplement
	{
		// Token: 0x060311B0 RID: 201136 RVA: 0x00DB6748 File Offset: 0x00DB4948
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

		// Token: 0x060311B1 RID: 201137 RVA: 0x00DB6800 File Offset: 0x00DB4A00
		protected override void OnStart()
		{
			base.OnStart();
			this.Helper = new PhoneMessageButtonHelper(this.RootItem, this.RootActor, base.GetItem(1), base.GetSprite(2), base.GetItem(4), base.GetTexture(5), base.GetItem(6), base.GetUiNiagara(7), delegate(string path, UUITexture texture)
			{
				base.SetTextureByPath(path, texture, null, null);
			});
			this.Helper.Init();
		}

		// Token: 0x060311B2 RID: 201138 RVA: 0x00DB686B File Offset: 0x00DB4A6B
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

		// Token: 0x060311B3 RID: 201139 RVA: 0x00DB6883 File Offset: 0x00DB4A83
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

		// Token: 0x060311B4 RID: 201140 RVA: 0x00DB689B File Offset: 0x00DB4A9B
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

		// Token: 0x060311B5 RID: 201141 RVA: 0x00DB68B3 File Offset: 0x00DB4AB3
		public void CheckAndPlayPhoneSequence()
		{
			PhoneMessageButtonHelper helper = this.Helper;
			if (helper == null)
			{
				return;
			}
			helper.CheckAndPlayPhoneSequence();
		}

		// Token: 0x060311B6 RID: 201142 RVA: 0x00DB68C5 File Offset: 0x00DB4AC5
		public void PopShowHeadIcon()
		{
			PhoneMessageButtonHelper helper = this.Helper;
			if (helper == null)
			{
				return;
			}
			helper.PopShowHeadIcon();
		}

		// Token: 0x060311B7 RID: 201143 RVA: 0x00DB68D7 File Offset: 0x00DB4AD7
		public void HideHeadIcon()
		{
			PhoneMessageButtonHelper helper = this.Helper;
			if (helper == null)
			{
				return;
			}
			helper.HideHeadIcon();
		}

		// Token: 0x0401A075 RID: 106613
		[Nullable(2)]
		private PhoneMessageButtonHelper Helper;

		// Token: 0x0200A937 RID: 43319
		private enum EChildType
		{
			// Token: 0x0403447B RID: 214139
			Button,
			// Token: 0x0403447C RID: 214140
			RedDotItem,
			// Token: 0x0403447D RID: 214141
			SpriteEnterIcon,
			// Token: 0x0403447E RID: 214142
			TexPhoneBlue,
			// Token: 0x0403447F RID: 214143
			PanelPrefabHead,
			// Token: 0x04034480 RID: 214144
			TexIconHead,
			// Token: 0x04034481 RID: 214145
			BubbleItem,
			// Token: 0x04034482 RID: 214146
			NiagaraItem
		}
	}
}
