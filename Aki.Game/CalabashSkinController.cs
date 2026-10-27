using System;
using System.Linq;
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

// Token: 0x02002A3D RID: 10813
[NullableContext(1)]
[Nullable(0)]
public class CalabashSkinController : UiControllerBase
{
	// Token: 0x0601684C RID: 92236 RVA: 0x005B5B70 File Offset: 0x005B3D70
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnLoadingNetDataDone, new Action(this.OnDataDone));
	}

	// Token: 0x0601684D RID: 92237 RVA: 0x005B5B8E File Offset: 0x005B3D8E
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnLoadingNetDataDone, new Action(this.OnDataDone));
	}

	// Token: 0x0601684E RID: 92238 RVA: 0x005B5BAC File Offset: 0x005B3DAC
	private void OnDataDone()
	{
		CalabashSkinController.Instance.RequestLoadCalabashSkinInfo();
	}

	// Token: 0x0601684F RID: 92239 RVA: 0x005B5BB8 File Offset: 0x005B3DB8
	protected unsafe override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.CalabashSkinUpdateNotify, delegate(IMessage msg, Net.CallbackStatus status)
		{
			CalabashSkinUpdateNotify calabashSkinUpdateNotify = (CalabashSkinUpdateNotify)msg;
			CalabashSkinModel.Instance.NotifyAddUnlockSkinData(calabashSkinUpdateNotify.SkinIds.ToArray<int>());
			InventoryController.Instance.AddCalabashSkinItemData(calabashSkinUpdateNotify.SkinIds.ToArray<int>());
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

	// Token: 0x06016850 RID: 92240 RVA: 0x005B5C52 File Offset: 0x005B3E52
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.CalabashSkinUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.CalabashSkinTakeOnNotify);
		Net.Instance.UnRegister(ENotifyMessageId.EntityCalabashSkinChangeNotify);
	}

	// Token: 0x06016851 RID: 92241 RVA: 0x005B5C84 File Offset: 0x005B3E84
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(loadCalabashSkinInfoResponse.ErrorCode, 17073, null, true, true);
				return;
			}
			CalabashSkinModel.Instance.NotifyCalabashSkinData(loadCalabashSkinInfoResponse.EquipSkinId, loadCalabashSkinInfoResponse.SkinItemIds.ToArray<int>());
			InventoryController.Instance.InitCalabashSkinItemData(loadCalabashSkinInfoResponse.SkinItemIds.ToArray<int>());
		}, 0);
	}

	// Token: 0x06016852 RID: 92242 RVA: 0x005B5CC8 File Offset: 0x005B3EC8
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

	// Token: 0x06016853 RID: 92243 RVA: 0x005B5D0C File Offset: 0x005B3F0C
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

	// Token: 0x17001DD9 RID: 7641
	// (get) Token: 0x06016854 RID: 92244 RVA: 0x005B5DBE File Offset: 0x005B3FBE
	public static CalabashSkinController Instance
	{
		get
		{
			return CalabashSkinController._Instance;
		}
	}

	// Token: 0x06016855 RID: 92245 RVA: 0x005B5DC5 File Offset: 0x005B3FC5
	public static CalabashSkinController GetOrCreateInstance()
	{
		if (CalabashSkinController._Instance == null)
		{
			CalabashSkinController.CreateInstance();
		}
		return CalabashSkinController._Instance;
	}

	// Token: 0x06016856 RID: 92246 RVA: 0x005B5DD9 File Offset: 0x005B3FD9
	public static bool CreateInstance()
	{
		if (CalabashSkinController._Instance != null)
		{
			return true;
		}
		CalabashSkinController._Instance = new CalabashSkinController();
		return true;
	}

	// Token: 0x06016857 RID: 92247 RVA: 0x005B5DEF File Offset: 0x005B3FEF
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06016858 RID: 92248 RVA: 0x005B5DF1 File Offset: 0x005B3FF1
	public static void ResetStaticDefaultValue()
	{
		CalabashSkinController._Instance = null;
	}

	// Token: 0x06016859 RID: 92249 RVA: 0x005B5DF9 File Offset: 0x005B3FF9
	static CalabashSkinController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CalabashSkinController.CreateStaticDefaultValue), new Action(CalabashSkinController.ResetStaticDefaultValue));
	}

	// Token: 0x0400A741 RID: 42817
	[Nullable(2)]
	private static CalabashSkinController _Instance;
}
