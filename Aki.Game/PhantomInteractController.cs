using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x02002458 RID: 9304
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class PhantomInteractController : UiControllerBase
{
	// Token: 0x06012AA0 RID: 76448 RVA: 0x0049C293 File Offset: 0x0049A493
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.PhantomInteractionUnlockNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPhantomInteractionUnlockNotify));
		Net.Instance.Register(ENotifyMessageId.PhantomInteractionInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPhantomInteractionInfoUpdateNotify));
	}

	// Token: 0x06012AA1 RID: 76449 RVA: 0x0049C2CD File Offset: 0x0049A4CD
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.PhantomInteractionUnlockNotify);
		Net.Instance.UnRegister(ENotifyMessageId.PhantomInteractionInfoUpdateNotify);
	}

	// Token: 0x06012AA2 RID: 76450 RVA: 0x0049C2F0 File Offset: 0x0049A4F0
	[NullableContext(2)]
	private void OnPhantomInteractionUnlockNotify(IMessage msg, Net.CallbackStatus status)
	{
		PhantomInteractionUnlockNotify proto = (PhantomInteractionUnlockNotify)msg;
		PhantomInteractModel.Instance.InteractInfoData.LoadFromProto(proto);
	}

	// Token: 0x06012AA3 RID: 76451 RVA: 0x0049C314 File Offset: 0x0049A514
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

	// Token: 0x06012AA4 RID: 76452 RVA: 0x0049C360 File Offset: 0x0049A560
	public void OpenPhantomVisionSummonView(int entityId, int skillId)
	{
		PhantomInteractModel instance = PhantomInteractModel.Instance;
		instance.InitEditViewModel(0);
		instance.CacheOpenSkillInfo(entityId, skillId);
		UiManager.Instance.OpenView(EUiViewName.PhantomInteractSummonView, instance.InteractInfoData, null);
	}

	// Token: 0x06012AA5 RID: 76453 RVA: 0x0049C398 File Offset: 0x0049A598
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

	// Token: 0x06012AA6 RID: 76454 RVA: 0x0049C3E4 File Offset: 0x0049A5E4
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

	// Token: 0x06012AA7 RID: 76455 RVA: 0x0049C448 File Offset: 0x0049A648
	public UniTask UpdateEquippedPhantom()
	{
		PhantomInteractController.<UpdateEquippedPhantom>d__7 <UpdateEquippedPhantom>d__;
		<UpdateEquippedPhantom>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<UpdateEquippedPhantom>d__.<>1__state = -1;
		<UpdateEquippedPhantom>d__.<>t__builder.Start<PhantomInteractController.<UpdateEquippedPhantom>d__7>(ref <UpdateEquippedPhantom>d__);
		return <UpdateEquippedPhantom>d__.<>t__builder.Task;
	}

	// Token: 0x06012AA8 RID: 76456 RVA: 0x0049C484 File Offset: 0x0049A684
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

	// Token: 0x17001834 RID: 6196
	// (get) Token: 0x06012AA9 RID: 76457 RVA: 0x0049C4CF File Offset: 0x0049A6CF
	public static PhantomInteractController Instance
	{
		get
		{
			return PhantomInteractController._Instance;
		}
	}

	// Token: 0x06012AAA RID: 76458 RVA: 0x0049C4D6 File Offset: 0x0049A6D6
	public static PhantomInteractController GetOrCreateInstance()
	{
		if (PhantomInteractController._Instance == null)
		{
			PhantomInteractController.CreateInstance();
		}
		return PhantomInteractController._Instance;
	}

	// Token: 0x06012AAB RID: 76459 RVA: 0x0049C4EA File Offset: 0x0049A6EA
	public static bool CreateInstance()
	{
		if (PhantomInteractController._Instance != null)
		{
			return true;
		}
		PhantomInteractController._Instance = new PhantomInteractController();
		return true;
	}

	// Token: 0x06012AAC RID: 76460 RVA: 0x0049C500 File Offset: 0x0049A700
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06012AAD RID: 76461 RVA: 0x0049C502 File Offset: 0x0049A702
	public static void ResetStaticDefaultValue()
	{
		PhantomInteractController._Instance = null;
	}

	// Token: 0x06012AAE RID: 76462 RVA: 0x0049C50A File Offset: 0x0049A70A
	static PhantomInteractController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PhantomInteractController.CreateStaticDefaultValue), new Action(PhantomInteractController.ResetStaticDefaultValue));
	}

	// Token: 0x04008CA0 RID: 36000
	[Nullable(2)]
	private static PhantomInteractController _Instance;
}
