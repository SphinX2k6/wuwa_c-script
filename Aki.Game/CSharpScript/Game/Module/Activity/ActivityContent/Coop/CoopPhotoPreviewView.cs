using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Coop
{
	// Token: 0x020068D9 RID: 26841
	[NullableContext(2)]
	[Nullable(0)]
	public class CoopPhotoPreviewView : UiViewBase
	{
		// Token: 0x170097D8 RID: 38872
		// (get) Token: 0x06042F77 RID: 274295 RVA: 0x0104F043 File Offset: 0x0104D243
		public new CoopPhotoPreviewViewParams OpenParam
		{
			get
			{
				return this.OpenParam as CoopPhotoPreviewViewParams;
			}
		}

		// Token: 0x06042F78 RID: 274296 RVA: 0x0104F050 File Offset: 0x0104D250
		[NullableContext(1)]
		public CoopPhotoPreviewView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06042F79 RID: 274297 RVA: 0x0104F05C File Offset: 0x0104D25C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUIText))
			};
		}

		// Token: 0x06042F7A RID: 274298 RVA: 0x0104F0B8 File Offset: 0x0104D2B8
		protected override void OnBeforeCreate()
		{
			this.ActData = this.OpenParam.ActivityData;
			this.RoleId = this.OpenParam.RoleId;
			CoopActivityData actData = this.ActData;
			this.TimeStamp = ((actData != null) ? actData.GetRoleMaxLevelTimeStamp(this.RoleId) : 0L);
		}

		// Token: 0x06042F7B RID: 274299 RVA: 0x0104F108 File Offset: 0x0104D308
		protected override UniTask OnBeforeStartAsync()
		{
			CoopPhotoPreviewView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CoopPhotoPreviewView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042F7C RID: 274300 RVA: 0x0104F14C File Offset: 0x0104D34C
		protected override void OnBeforeShow()
		{
			CoopRole? coopRoleConfigByRoleId = CoopConfig.Instance.GetCoopRoleConfigByRoleId(this.RoleId);
			string text = (PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Male) ? (((coopRoleConfigByRoleId != null) ? coopRoleConfigByRoleId.GetValueOrDefault().BigPhotoPathM : null) ?? "") : (((coopRoleConfigByRoleId != null) ? coopRoleConfigByRoleId.GetValueOrDefault().BigPhotoPathF : null) ?? "");
			if (!string.IsNullOrEmpty(text))
			{
				base.SetTextureByPath(text, base.GetTexture(1), null, null);
			}
			DateTime dataFromTimeStamp = TimeUtil.Instance.GetDataFromTimeStamp((double)this.TimeStamp);
			string birthLocalText = PersonalConfig.Instance.GetBirthLocalText(dataFromTimeStamp.Month, EBirthDateType.MONTH);
			string birthLocalText2 = PersonalConfig.Instance.GetBirthLocalText(dataFromTimeStamp.Day, EBirthDateType.DAY);
			string textContentIdById = TextConfig.Instance.GetTextContentIdById("BirthDay");
			string multiText = TextConfig.Instance.GetMultiText(textContentIdById, new string[]
			{
				birthLocalText,
				birthLocalText2
			});
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "Coop_Role_Photo", new <>z__ReadOnlyArray<object>(new object[]
			{
				dataFromTimeStamp.Year,
				multiText
			}));
		}

		// Token: 0x06042F7D RID: 274301 RVA: 0x0104F281 File Offset: 0x0104D481
		private void OnCloseClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x04022D8C RID: 142732
		private CoopActivityData ActData;

		// Token: 0x04022D8D RID: 142733
		private int RoleId;

		// Token: 0x04022D8E RID: 142734
		private long TimeStamp;

		// Token: 0x04022D8F RID: 142735
		private PopupCaptionItem CaptionItem;
	}
}
