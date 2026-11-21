using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x02001FB8 RID: 8120
[NullableContext(1)]
[Nullable(0)]
public class CalabashSkinController : UiControllerBase
{
	// Token: 0x0601426D RID: 82541 RVA: 0x005E1CD8 File Offset: 0x005DFED8
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnLoadingNetDataDone, new Action(this.OnDataDone));
	}

	// Token: 0x0601426E RID: 82542 RVA: 0x005E1CF6 File Offset: 0x005DFEF6
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnLoadingNetDataDone, new Action(this.OnDataDone));
	}

	// Token: 0x0601426F RID: 82543 RVA: 0x005E1D14 File Offset: 0x005DFF14
	private void OnDataDone()
	{
		CalabashSkinController.Instance.RequestLoadCalabashSkinInfo();
	}

	// Token: 0x06014270 RID: 82544 RVA: 0x005E1D20 File Offset: 0x005DFF20
	protected unsafe override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.CalabashSkinUpdateNotify, delegate(IMessage msg, Net.CallbackStatus status)
		{
			CalabashSkinUpdateNotify calabashSkinUpdateNotify = (CalabashSkinUpdateNotify)msg;
			int[] array = new int[calabashSkinUpdateNotify.SkinIds.Count];
			calabashSkinUpdateNotify.SkinIds.CopyTo(array, 0);
			CalabashSkinModel.Instance.NotifyAddUnlockSkinData(array);
			int[] array2 = new int[calabashSkinUpdateNotify.SkinIds.Count];
			calabashSkinUpdateNotify.SkinIds.CopyTo(array2, 0);
			InventoryController.Instance.AddCalabashSkinItemData(array2);
		});
		Net.Instance.Register(ENotifyMessageId.CalabashSkinTakeOnNotify, delegate(IMessage msg, Net.CallbackStatus status)
		{
			CalabashSkinTakeOnNotify calabashSkinTakeOnNotify = (CalabashSkinTakeOnNotify)msg;
			CalabashSkinModel.Instance.NotifyCurrentEquippedSkinId(calabashSkinTakeOnNotify.SkinId);
		});
		Net.Instance.Register(ENotifyMessageId.EntityCalabashSkinChangeNotify, delegate(IMessage msg, Net.CallbackStatus status)
		{
			EntityCalabashSkinChangeNotify entityCalabashSkinChangeNotify = (EntityCalabashSkinChangeNotify)msg;
			long num = MathUtils.Instance.LongToNumber(entityCalabashSkinChangeNotify.EntityId);
			CalabashSkinComponentPb calabashSkinComponent = entityCalabashSkinChangeNotify.CalabashSkinComponent;
			int num2 = (calabashSkinComponent != null) ? calabashSkinComponent.CalabashSkinId : 0;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.CalabashSkin;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "服务器下发葫芦皮肤";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "CalabashSkinId";
			CalabashSkinComponentPb calabashSkinComponent2 = entityCalabashSkinChangeNotify.CalabashSkinComponent;
			ptr = new ValueTuple<string, object>(item, (calabashSkinComponent2 != null) ? new int?(calabashSkinComponent2.CalabashSkinId) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ServerEntityId", num);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			EntityHandle entity = CreatureModel.Instance.GetEntity(num);
			CreatureDataComponent creatureDataComponent = (entity != null) ? entity.Entity.GetComponent<CreatureDataComponent>() : null;
			if (creatureDataComponent != null && creatureDataComponent.Valid)
			{
				creatureDataComponent.HuluSkinId = num2;
			}
			CharacterWeaponComponent characterWeaponComponent = (entity != null) ? entity.Entity.GetComponent<CharacterWeaponComponent>() : null;
			if (characterWeaponComponent != null && characterWeaponComponent.Valid)
			{
				characterWeaponComponent.OnEntityHuluSkinChangeNotify(num2);
			}
		});
	}

	// Token: 0x06014271 RID: 82545 RVA: 0x005E1DBA File Offset: 0x005DFFBA
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.CalabashSkinUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.CalabashSkinTakeOnNotify);
		Net.Instance.UnRegister(ENotifyMessageId.EntityCalabashSkinChangeNotify);
	}

	// Token: 0x06014272 RID: 82546 RVA: 0x005E1DEC File Offset: 0x005DFFEC
	private void RequestLoadCalabashSkinInfo()
	{
		LoadCalabashSkinInfoRequest message = LoadCalabashSkinInfoRequest.Create();
		Net.Instance.Call(ERequestMessageId.LoadCalabashSkinInfoRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
		{
			LoadCalabashSkinInfoResponse loadCalabashSkinInfoResponse = (LoadCalabashSkinInfoResponse)msg;
			if (loadCalabashSkinInfoResponse == null)
			{
				return;
			}
			if (loadCalabashSkinInfoResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(loadCalabashSkinInfoResponse.ErrorCode, 18646, null, true, true);
				return;
			}
			int[] array = new int[loadCalabashSkinInfoResponse.SkinItemIds.Count];
			loadCalabashSkinInfoResponse.SkinItemIds.CopyTo(array, 0);
			CalabashSkinModel.Instance.NotifyCalabashSkinData(loadCalabashSkinInfoResponse.EquipSkinId, array);
			int[] array2 = new int[loadCalabashSkinInfoResponse.SkinItemIds.Count];
			loadCalabashSkinInfoResponse.SkinItemIds.CopyTo(array2, 0);
			InventoryController.Instance.InitCalabashSkinItemData(array2);
		}, 0);
	}

	// Token: 0x06014273 RID: 82547 RVA: 0x005E1E30 File Offset: 0x005E0030
	[NullableContext(0)]
	public UniTask<bool> RequestCalabashSkinTakeOn(int skinId)
	{
		CalabashSkinController.<RequestCalabashSkinTakeOn>d__6 <RequestCalabashSkinTakeOn>d__;
		<RequestCalabashSkinTakeOn>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestCalabashSkinTakeOn>d__.skinId = skinId;
		<RequestCalabashSkinTakeOn>d__.<>1__state = -1;
		<RequestCalabashSkinTakeOn>d__.<>t__builder.Start<CalabashSkinController.<RequestCalabashSkinTakeOn>d__6>(ref <RequestCalabashSkinTakeOn>d__);
		return <RequestCalabashSkinTakeOn>d__.<>t__builder.Task;
	}

	// Token: 0x06014274 RID: 82548 RVA: 0x005E1E74 File Offset: 0x005E0074
	public void SelectedCalabashSkinChange(int skinId, int roleId, [Nullable(2)] UiModelBase calabashModel, string caseName = "TerminalCase")
	{
		if (calabashModel == null)
		{
			return;
		}
		UiHuluSkinDataComponent dataComponent = calabashModel.CheckGetComponent<UiHuluSkinDataComponent>();
		dataComponent.SetSkinId(roleId, skinId);
		int modelId = dataComponent.ModelId;
		UiModelActorComponent actorComponent = calabashModel.CheckGetComponent<UiModelActorComponent>();
		UiModelActorComponent actorComponent4 = actorComponent;
		if (actorComponent4 != null)
		{
			actorComponent4.SetTransformByTag(caseName);
		}
		CalabashTransform transformData = SkinConfig.Instance.GetCalabashTransformById(dataComponent.TransformId);
		Action loadFinishCallBack = delegate()
		{
			UiModelUtil.Instance.SetVisible(calabashModel, true);
			global::Vector inT = global::Vector.Create((double)transformData.Location.Value.X, (double)transformData.Location.Value.Y, (double)transformData.Location.Value.Z);
			global::Rotator rotator = global::Rotator.Create(transformData.Rotation.Value.Y, transformData.Rotation.Value.Z, transformData.Rotation.Value.X);
			global::Vector inS = global::Vector.Create((double)transformData.Size.Value.X, (double)transformData.Size.Value.Y, (double)transformData.Size.Value.Z);
			global::Transform transform = global::Transform.Create(rotator.Quaternion(null), inT, inS);
			FHitResult fhitResult = new FHitResult();
			UiModelActorComponent actorComponent2 = actorComponent;
			if (actorComponent2 != null)
			{
				USkeletalMeshComponent mainMeshComponent = actorComponent2.MainMeshComponent;
				if (mainMeshComponent != null)
				{
					FTransformDouble ftransformDouble = transform.ToUeTransform();
					mainMeshComponent.D_K2_SetRelativeTransform(ftransformDouble, false, ref fhitResult, false);
				}
			}
			UiModelUtil.Instance.SetRenderingMaterial(calabashModel, "CalabashSwitchController");
			UiModelUtil.Instance.PlayEffectAtRootComponentByPath(calabashModel, dataComponent.EffectPath);
			UiModelRotateComponent uiModelRotateComponent = calabashModel.CheckGetComponent<UiModelRotateComponent>();
			uiModelRotateComponent.SetRotateParam((float)transformData.RotateTime, ERotateAxis.Roll, false);
			uiModelRotateComponent.StartRotate();
			rotator.Set(transformData.AxisRotate.Value.X, transformData.AxisRotate.Value.Y, transformData.AxisRotate.Value.Z);
			UiModelActorComponent actorComponent3 = actorComponent;
			if (actorComponent3 == null)
			{
				return;
			}
			AActor actor = actorComponent3.Actor;
			if (actor == null)
			{
				return;
			}
			actor.K2_SetActorRotation(rotator.ToUeRotator(), false);
		};
		UiModelLoadComponent uiModelLoadComponent = calabashModel.CheckGetComponent<UiModelLoadComponent>();
		if (uiModelLoadComponent == null)
		{
			return;
		}
		uiModelLoadComponent.LoadModelByModelId(modelId, true, loadFinishCallBack, null);
	}

	// Token: 0x17001E31 RID: 7729
	// (get) Token: 0x06014275 RID: 82549 RVA: 0x005E1F26 File Offset: 0x005E0126
	public static CalabashSkinController Instance
	{
		get
		{
			return CalabashSkinController._Instance;
		}
	}

	// Token: 0x06014276 RID: 82550 RVA: 0x005E1F2D File Offset: 0x005E012D
	public static CalabashSkinController GetOrCreateInstance()
	{
		if (CalabashSkinController._Instance == null)
		{
			CalabashSkinController.CreateInstance();
		}
		return CalabashSkinController._Instance;
	}

	// Token: 0x06014277 RID: 82551 RVA: 0x005E1F41 File Offset: 0x005E0141
	public static bool CreateInstance()
	{
		if (CalabashSkinController._Instance != null)
		{
			return true;
		}
		CalabashSkinController._Instance = new CalabashSkinController();
		return true;
	}

	// Token: 0x06014278 RID: 82552 RVA: 0x005E1F57 File Offset: 0x005E0157
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06014279 RID: 82553 RVA: 0x005E1F59 File Offset: 0x005E0159
	public static void ResetStaticDefaultValue()
	{
		CalabashSkinController._Instance = null;
	}

	// Token: 0x0601427A RID: 82554 RVA: 0x005E1F61 File Offset: 0x005E0161
	static CalabashSkinController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CalabashSkinController.CreateStaticDefaultValue), new Action(CalabashSkinController.ResetStaticDefaultValue));
	}

	// Token: 0x0400AB45 RID: 43845
	[Nullable(2)]
	private static CalabashSkinController _Instance;
}
