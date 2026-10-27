using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020029FD RID: 10749
[NullableContext(2)]
[Nullable(0)]
public class MoonTogetherMainView : UiTickViewBase
{
	// Token: 0x060164CD RID: 91341 RVA: 0x005A4BF7 File Offset: 0x005A2DF7
	[NullableContext(1)]
	public MoonTogetherMainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060164CE RID: 91342 RVA: 0x005A4C00 File Offset: 0x005A2E00
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(delegate()
			{
				this.OnCloseButtonClick().Forget();
			}))
		};
	}

	// Token: 0x060164CF RID: 91343 RVA: 0x005A4CAC File Offset: 0x005A2EAC
	protected override UniTask OnBeforeStartAsync()
	{
		MoonTogetherMainView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MoonTogetherMainView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060164D0 RID: 91344 RVA: 0x005A4CF0 File Offset: 0x005A2EF0
	protected override void OnStart()
	{
		base.GetItem(4).SetUIActive(false);
		this.InviteSkillItem.SetPressCallback(delegate
		{
			this.OnInviteButtonClick().Forget();
		});
		this.ChangeVisionSkillItem.SetPressCallback(delegate
		{
			this.OnChangeVisionButtonClick().Forget();
		});
		this.TakePictureSkillItem.SetPressCallback(new Action(this.OnTakePictureButtonClick));
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		Entity entity = (baseCharacter != null) ? baseCharacter.GetEntityNoBlueprint() : null;
		BaseTagComponent baseTagComponent = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
		if (baseTagComponent != null)
		{
			baseTagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["系统.功能.致敬观察索拉里斯.默认镜头"]));
		}
		IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("MoonTogetherCameraRotation");
		CameraController.Instance.MainModel.FightCamera.LogicComponent.ResetArmLengthAndRotation(Rotator.ZeroRotator);
		CameraController.Instance.MainModel.FightCamera.LogicComponent.SetRotation(Rotator.Create((float)((intArrayConfig != null) ? intArrayConfig.GetValueOrNull(0) : null).GetValueOrDefault(), (float)((intArrayConfig != null) ? intArrayConfig.GetValueOrNull(1) : null).GetValueOrDefault(), (float)((intArrayConfig != null) ? intArrayConfig.GetValueOrNull(2) : null).GetValueOrDefault()).ToUeRotator());
		MoonTogetherModel.Instance.IsInMoonTogether = true;
	}

	// Token: 0x060164D1 RID: 91345 RVA: 0x005A4E3C File Offset: 0x005A303C
	protected override void OnBeforeDestroy()
	{
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		Entity entity = (baseCharacter != null) ? baseCharacter.GetEntityNoBlueprint() : null;
		BaseTagComponent baseTagComponent = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
		if (baseTagComponent != null)
		{
			baseTagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["系统.功能.致敬观察索拉里斯.第一人称镜头"]));
		}
		if (baseTagComponent == null)
		{
			return;
		}
		baseTagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["系统.功能.致敬观察索拉里斯.默认镜头"]));
	}

	// Token: 0x060164D2 RID: 91346 RVA: 0x005A4EA8 File Offset: 0x005A30A8
	protected override void OnBeforeShow()
	{
		this.IsFirstPerson = false;
		int curInviteRoleId = MoonTogetherModel.Instance.CurInviteRoleId;
		if (curInviteRoleId > 0 && MoonTogetherModel.Instance.IsLinkageRole(curInviteRoleId))
		{
			this.OnInviteLinkageRole();
			return;
		}
		this.OnInviteNormalRole();
	}

	// Token: 0x060164D3 RID: 91347 RVA: 0x005A4EE5 File Offset: 0x005A30E5
	protected override void OnTick(float delta)
	{
		this.ChangeVisionSkillItem.TickSkillCoolDown(delta);
	}

	// Token: 0x060164D4 RID: 91348 RVA: 0x005A4EF4 File Offset: 0x005A30F4
	private UniTask OnInviteButtonClick()
	{
		MoonTogetherMainView.<OnInviteButtonClick>d__12 <OnInviteButtonClick>d__;
		<OnInviteButtonClick>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnInviteButtonClick>d__.<>4__this = this;
		<OnInviteButtonClick>d__.<>1__state = -1;
		<OnInviteButtonClick>d__.<>t__builder.Start<MoonTogetherMainView.<OnInviteButtonClick>d__12>(ref <OnInviteButtonClick>d__);
		return <OnInviteButtonClick>d__.<>t__builder.Task;
	}

	// Token: 0x060164D5 RID: 91349 RVA: 0x005A4F38 File Offset: 0x005A3138
	private UniTask OnChangeVisionButtonClick()
	{
		MoonTogetherMainView.<OnChangeVisionButtonClick>d__13 <OnChangeVisionButtonClick>d__;
		<OnChangeVisionButtonClick>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnChangeVisionButtonClick>d__.<>4__this = this;
		<OnChangeVisionButtonClick>d__.<>1__state = -1;
		<OnChangeVisionButtonClick>d__.<>t__builder.Start<MoonTogetherMainView.<OnChangeVisionButtonClick>d__13>(ref <OnChangeVisionButtonClick>d__);
		return <OnChangeVisionButtonClick>d__.<>t__builder.Task;
	}

	// Token: 0x060164D6 RID: 91350 RVA: 0x005A4F7C File Offset: 0x005A317C
	private void OnTakePictureButtonClick()
	{
		PhotoSaveViewParam param = new PhotoSaveViewParam
		{
			ScreenShot = true,
			PrepareFullScreenShot = false,
			IsHiddenBattleView = true,
			HandBookPhotoData = null,
			GachaData = null,
			FragmentMemory = null,
			RoleSkinData = null,
			ShareId = 1
		};
		PhotographController.Instance.ScreenShot(param);
	}

	// Token: 0x060164D7 RID: 91351 RVA: 0x005A4FD4 File Offset: 0x005A31D4
	private UniTask OnCloseButtonClick()
	{
		MoonTogetherMainView.<OnCloseButtonClick>d__15 <OnCloseButtonClick>d__;
		<OnCloseButtonClick>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnCloseButtonClick>d__.<>4__this = this;
		<OnCloseButtonClick>d__.<>1__state = -1;
		<OnCloseButtonClick>d__.<>t__builder.Start<MoonTogetherMainView.<OnCloseButtonClick>d__15>(ref <OnCloseButtonClick>d__);
		return <OnCloseButtonClick>d__.<>t__builder.Task;
	}

	// Token: 0x060164D8 RID: 91352 RVA: 0x005A5018 File Offset: 0x005A3218
	public void OnInviteLinkageRole()
	{
		string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_IconMoonView01");
		ShowerSkillButton inviteSkillItem = this.InviteSkillItem;
		if (inviteSkillItem != null)
		{
			inviteSkillItem.SetSkillIconSprite(resourcePath);
		}
		ShowerSkillButton changeVisionSkillItem = this.ChangeVisionSkillItem;
		if (changeVisionSkillItem != null)
		{
			changeVisionSkillItem.SetButtonInteractive(false);
		}
		ShowerSkillButton changeVisionSkillItem2 = this.ChangeVisionSkillItem;
		if (changeVisionSkillItem2 == null)
		{
			return;
		}
		changeVisionSkillItem2.SetDisabledHint(delegate
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Perspective_switching_disabled_Tips", Array.Empty<object>());
		});
	}

	// Token: 0x060164D9 RID: 91353 RVA: 0x005A5088 File Offset: 0x005A3288
	public void OnInviteNormalRole()
	{
		string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_IconMoonView02");
		ShowerSkillButton inviteSkillItem = this.InviteSkillItem;
		if (inviteSkillItem != null)
		{
			inviteSkillItem.SetSkillIconSprite(resourcePath);
		}
		ShowerSkillButton changeVisionSkillItem = this.ChangeVisionSkillItem;
		if (changeVisionSkillItem != null)
		{
			changeVisionSkillItem.SetButtonInteractive(true);
		}
		ShowerSkillButton changeVisionSkillItem2 = this.ChangeVisionSkillItem;
		if (changeVisionSkillItem2 == null)
		{
			return;
		}
		changeVisionSkillItem2.SetDisabledHint(null);
	}

	// Token: 0x0400A5E4 RID: 42468
	private ShowerSkillButton InviteSkillItem;

	// Token: 0x0400A5E5 RID: 42469
	private ShowerSkillButton ChangeVisionSkillItem;

	// Token: 0x0400A5E6 RID: 42470
	private ShowerSkillButton TakePictureSkillItem;

	// Token: 0x0400A5E7 RID: 42471
	private bool IsFirstPerson;

	// Token: 0x02009036 RID: 36918
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402EB28 RID: 191272
		public const int InviteSkillItem = 0;

		// Token: 0x0402EB29 RID: 191273
		public const int ChangeVisionSkillItem = 1;

		// Token: 0x0402EB2A RID: 191274
		public const int TakePictureSkillItem = 2;

		// Token: 0x0402EB2B RID: 191275
		public const int CloseButton = 3;

		// Token: 0x0402EB2C RID: 191276
		public const int NiaItem = 4;
	}
}
