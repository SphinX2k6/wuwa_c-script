using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x0200193D RID: 6461
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class PhantomInteractController : UiControllerBase
{
	// Token: 0x0600FF58 RID: 65368 RVA: 0x004A99FF File Offset: 0x004A7BFF
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.PhantomInteractionUnlockNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPhantomInteractionUnlockNotify));
		Net.Instance.Register(ENotifyMessageId.PhantomInteractionInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPhantomInteractionInfoUpdateNotify));
	}

	// Token: 0x0600FF59 RID: 65369 RVA: 0x004A9A39 File Offset: 0x004A7C39
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.PhantomInteractionUnlockNotify);
		Net.Instance.UnRegister(ENotifyMessageId.PhantomInteractionInfoUpdateNotify);
	}

	// Token: 0x0600FF5A RID: 65370 RVA: 0x004A9A5C File Offset: 0x004A7C5C
	[NullableContext(2)]
	private void OnPhantomInteractionUnlockNotify(IMessage msg, Net.CallbackStatus status)
	{
		PhantomInteractionUnlockNotify proto = (PhantomInteractionUnlockNotify)msg;
		PhantomInteractModel.Instance.InteractInfoData.LoadFromProto(proto);
	}

	// Token: 0x0600FF5B RID: 65371 RVA: 0x004A9A80 File Offset: 0x004A7C80
	[NullableContext(2)]
	private void OnPhantomInteractionInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		PhantomInteractionInfoUpdateNotify phantomInteractionInfoUpdateNotify = (PhantomInteractionInfoUpdateNotify)msg;
		bool flag = PhantomInteractModel.Instance.InteractInfoData.UpdateFromProto(phantomInteractionInfoUpdateNotify);
		UnlockIllustratedPhantom unlockIllustratedPhantom = phantomInteractionInfoUpdateNotify.UnlockIllustratedPhantom;
		if (flag && unlockIllustratedPhantom != null && unlockIllustratedPhantom.IsSpecial)
		{
			PhantomInteractModel.Instance.SetPhantomInteractUnlockRedDot(unlockIllustratedPhantom.MonsterId, true);
		}
	}

	// Token: 0x0600FF5C RID: 65372 RVA: 0x004A9ACC File Offset: 0x004A7CCC
	public void OpenPhantomVisionSummonView(int entityId, int skillId)
	{
		PhantomInteractModel instance = PhantomInteractModel.Instance;
		instance.InitEditViewModel(0);
		instance.CacheOpenSkillInfo(entityId, skillId);
		UiManager.Instance.OpenView(EUiViewName.PhantomInteractSummonView, instance.InteractInfoData, null);
	}

	// Token: 0x0600FF5D RID: 65373 RVA: 0x004A9B04 File Offset: 0x004A7D04
	public void OpenPhantomVisionEditView(int index = 0, bool fromSummonView = false)
	{
		PhantomInteractModel instance = PhantomInteractModel.Instance;
		instance.InitEditViewModel(index);
		PhantomInteractEditViewParam phantomInteractEditViewParam = new PhantomInteractEditViewParam();
		phantomInteractEditViewParam.InfoData = instance.InteractInfoData;
		phantomInteractEditViewParam.OpenSlotIndex = index;
		phantomInteractEditViewParam.FromSummonView = fromSummonView;
		UiManager.Instance.OpenView(EUiViewName.PhantomInteractEditView, phantomInteractEditViewParam, null);
	}

	// Token: 0x0600FF5E RID: 65374 RVA: 0x004A9B50 File Offset: 0x004A7D50
	public void BeginVisionSkill(int monsterId)
	{
		PhantomInteractModel instance = PhantomInteractModel.Instance;
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		WorldEntity worldEntity = (getCurrentEntity != null) ? getCurrentEntity.Entity : null;
		if (worldEntity == null)
		{
			return;
		}
		CharacterSkillComponent component = worldEntity.GetComponent<CharacterSkillComponent>();
		CharacterSkillCdComponent component2 = worldEntity.GetComponent<CharacterSkillCdComponent>();
		if (component == null || component2 == null)
		{
			return;
		}
		ISkillParam skillParam = PhantomUtil.BeforeVisionSkillExecute(worldEntity, monsterId);
		instance.SetSummonMonsterId(monsterId);
		component.BeginSkillAsync(210008, skillParam);
	}

	// Token: 0x0600FF5F RID: 65375 RVA: 0x004A9BB4 File Offset: 0x004A7DB4
	public UniTask UpdateEquippedPhantom()
	{
		PhantomInteractController.<UpdateEquippedPhantom>d__7 <UpdateEquippedPhantom>d__;
		<UpdateEquippedPhantom>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<UpdateEquippedPhantom>d__.<>1__state = -1;
		<UpdateEquippedPhantom>d__.<>t__builder.Start<PhantomInteractController.<UpdateEquippedPhantom>d__7>(ref <UpdateEquippedPhantom>d__);
		return <UpdateEquippedPhantom>d__.<>t__builder.Task;
	}

	// Token: 0x0600FF60 RID: 65376 RVA: 0x004A9BF0 File Offset: 0x004A7DF0
	public UniTask UpdateEquippedPhantomSkin(int monsterId, int skinId)
	{
		PhantomInteractController.<UpdateEquippedPhantomSkin>d__8 <UpdateEquippedPhantomSkin>d__;
		<UpdateEquippedPhantomSkin>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<UpdateEquippedPhantomSkin>d__.monsterId = monsterId;
		<UpdateEquippedPhantomSkin>d__.skinId = skinId;
		<UpdateEquippedPhantomSkin>d__.<>1__state = -1;
		<UpdateEquippedPhantomSkin>d__.<>t__builder.Start<PhantomInteractController.<UpdateEquippedPhantomSkin>d__8>(ref <UpdateEquippedPhantomSkin>d__);
		return <UpdateEquippedPhantomSkin>d__.<>t__builder.Task;
	}

	// Token: 0x1700186E RID: 6254
	// (get) Token: 0x0600FF61 RID: 65377 RVA: 0x004A9C3B File Offset: 0x004A7E3B
	public static PhantomInteractController Instance
	{
		get
		{
			return PhantomInteractController._Instance;
		}
	}

	// Token: 0x0600FF62 RID: 65378 RVA: 0x004A9C42 File Offset: 0x004A7E42
	public static PhantomInteractController GetOrCreateInstance()
	{
		if (PhantomInteractController._Instance == null)
		{
			PhantomInteractController.CreateInstance();
		}
		return PhantomInteractController._Instance;
	}

	// Token: 0x0600FF63 RID: 65379 RVA: 0x004A9C56 File Offset: 0x004A7E56
	public static bool CreateInstance()
	{
		if (PhantomInteractController._Instance != null)
		{
			return true;
		}
		PhantomInteractController._Instance = new PhantomInteractController();
		return true;
	}

	// Token: 0x0600FF64 RID: 65380 RVA: 0x004A9C6C File Offset: 0x004A7E6C
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600FF65 RID: 65381 RVA: 0x004A9C6E File Offset: 0x004A7E6E
	public static void ResetStaticDefaultValue()
	{
		PhantomInteractController._Instance = null;
	}

	// Token: 0x0600FF66 RID: 65382 RVA: 0x004A9C76 File Offset: 0x004A7E76
	static PhantomInteractController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PhantomInteractController.CreateStaticDefaultValue), new Action(PhantomInteractController.ResetStaticDefaultValue));
	}

	// Token: 0x04008DE7 RID: 36327
	[Nullable(2)]
	private static PhantomInteractController _Instance;
}
