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
	// Token: 0x02005829 RID: 22569
	[NullableContext(2)]
	[Nullable(0)]
	public class CoopPhotoPreviewView : UiViewBase
	{
		// Token: 0x17006B18 RID: 27416
		// (get) Token: 0x06037ACF RID: 228047 RVA: 0x00F9066B File Offset: 0x00F8E86B
		public new CoopPhotoPreviewViewParams OpenParam
		{
			get
			{
				return this.OpenParam as CoopPhotoPreviewViewParams;
			}
		}

		// Token: 0x06037AD0 RID: 228048 RVA: 0x00F90678 File Offset: 0x00F8E878
		[NullableContext(1)]
		public CoopPhotoPreviewView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06037AD1 RID: 228049 RVA: 0x00F90684 File Offset: 0x00F8E884
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUIText))
			};
		}

		// Token: 0x06037AD2 RID: 228050 RVA: 0x00F906E0 File Offset: 0x00F8E8E0
		protected override void OnBeforeCreate()
		{
			this.ActData = this.OpenParam.ActivityData;
			this.RoleId = this.OpenParam.RoleId;
			CoopActivityData actData = this.ActData;
			this.TimeStamp = ((actData != null) ? actData.GetRoleMaxLevelTimeStamp(this.RoleId) : 0L);
		}

		// Token: 0x06037AD3 RID: 228051 RVA: 0x00F90730 File Offset: 0x00F8E930
		protected override UniTask OnBeforeStartAsync()
		{
			CoopPhotoPreviewView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CoopPhotoPreviewView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037AD4 RID: 228052 RVA: 0x00F90774 File Offset: 0x00F8E974
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

		// Token: 0x06037AD5 RID: 228053 RVA: 0x00F908A9 File Offset: 0x00F8EAA9
		private void OnCloseClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401D5E8 RID: 120296
		private CoopActivityData ActData;

		// Token: 0x0401D5E9 RID: 120297
		private int RoleId;

		// Token: 0x0401D5EA RID: 120298
		private long TimeStamp;

		// Token: 0x0401D5EB RID: 120299
		private PopupCaptionItem CaptionItem;
	}
}
