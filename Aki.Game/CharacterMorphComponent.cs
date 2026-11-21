using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.Input.Blueprints;
using AkiClient.Game.Aki.Data.Entity.Struct;
using AkiClient.Game.Aki.Data.Fight.Struct;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move;
using UnrealEngine;

// Token: 0x02002641 RID: 9793
[NullableContext(1)]
[Nullable(0)]
public class CharacterMorphComponent : EntityComponent
{
	// Token: 0x0601873F RID: 100159 RVA: 0x00761795 File Offset: 0x0075F995
	[NullableContext(2)]
	protected override bool OnInitData(IEntityArgs args = null)
	{
		return true;
	}

	// Token: 0x06018740 RID: 100160 RVA: 0x00761798 File Offset: 0x0075F998
	protected override bool OnStart()
	{
		this.CreatureDataComp = base.Entity.GetComponent<CreatureDataComponent>();
		this.RolePreloadComp = base.Entity.GetComponent<RolePreloadComponent>();
		this.ActorComp = base.Entity.GetComponent<CharacterActorComponent>();
		this.MoveComp = base.Entity.GetComponent<CharacterMoveComponent>();
		this.TagComp = base.Entity.GetComponent<BaseTagComponent>();
		this.CharacterAnimationComp = base.Entity.GetComponent<CharacterAnimationComponent>();
		this.CharacterFloatingComp = base.Entity.GetComponent<CharacterFloatingComponent>();
		this.InitMorphData();
		if (this.IsEnableMorphInternal)
		{
			if (this.TagComp != null)
			{
				this.MorphTagListenTasks = new List<ITagTask>();
				foreach (KeyValuePair<int, EMorphType> keyValuePair in CharacterMorphComponent.morphTagTypeMap)
				{
					int num;
					EMorphType morphType2;
					keyValuePair.Deconstruct(out num, out morphType2);
					int value = num;
					EMorphType morphType = morphType2;
					Dictionary<EMorphType, IMorphData> morphDataMap = this.MorphDataMap;
					if (morphDataMap != null && morphDataMap.ContainsKey(morphType))
					{
						ITagTask tagTask = this.TagComp.ListenForTagAddOrRemove(new int?(value), delegate(int id, bool tagExist)
						{
							this.OnMorphTagChanged(morphType, tagExist);
						}, null);
						if (tagTask != null)
						{
							this.MorphTagListenTasks.Add(tagTask);
						}
					}
				}
			}
			this.LoadMorphResource();
			this.TempVector = Vector.Create();
		}
		return true;
	}

	// Token: 0x06018741 RID: 100161 RVA: 0x00761908 File Offset: 0x0075FB08
	protected override bool OnEnd()
	{
		if (this.IsEnableMorphInternal)
		{
			if (this.MorphType != EMorphType.默认形态)
			{
				UDataTable morphCameraConfig = this.GetMorphCameraConfig(null);
				if (morphCameraConfig != null)
				{
					CameraController.Instance.UnloadCharacterCameraConfig(morphCameraConfig, "MainCamera");
				}
			}
			if (this.MorphTagListenTasks != null)
			{
				foreach (ITagTask tagTask in this.MorphTagListenTasks)
				{
					tagTask.EndTask();
				}
				this.MorphTagListenTasks = null;
			}
			this.MorphDataMap = null;
			this.MorphModelIdMap = null;
			this.MorphAssetMap = null;
			this.MorphMontageMapByName = null;
			this.MorphMontagePathMapByName = null;
			this.MorphMontagePathMap = null;
			if (this.LoadingBpInputTypes != null)
			{
				foreach (KeyValuePair<EMorphType, int> keyValuePair in this.LoadingBpInputTypes)
				{
					EMorphType emorphType;
					int num;
					keyValuePair.Deconstruct(out emorphType, out num);
					int id = num;
					ResourceSystem.Instance.CancelAsyncLoad(id);
				}
				this.LoadingBpInputTypes = null;
			}
			if (this.LoadingMovementDataTypes != null)
			{
				foreach (KeyValuePair<EMorphType, int> keyValuePair in this.LoadingMovementDataTypes)
				{
					EMorphType emorphType;
					int num;
					keyValuePair.Deconstruct(out emorphType, out num);
					int id2 = num;
					ResourceSystem.Instance.CancelAsyncLoad(id2);
				}
				this.LoadingMovementDataTypes = null;
			}
			if (this.LoadingCameraConfigTypes != null)
			{
				foreach (KeyValuePair<EMorphType, int> keyValuePair in this.LoadingCameraConfigTypes)
				{
					EMorphType emorphType;
					int num;
					keyValuePair.Deconstruct(out emorphType, out num);
					int id3 = num;
					ResourceSystem.Instance.CancelAsyncLoad(id3);
				}
				this.LoadingCameraConfigTypes = null;
			}
			this.CurrentCameraConfig = null;
			this.TempVector = null;
			this.IsEnableMorphInternal = false;
		}
		return true;
	}

	// Token: 0x06018742 RID: 100162 RVA: 0x00761B10 File Offset: 0x0075FD10
	private void OnMorphTagChanged(EMorphType morphType, bool tagExist)
	{
		if (tagExist)
		{
			this.SetMorphType(morphType);
			return;
		}
		this.SetMorphType(this.GetActiveMorphTypeFromTags());
	}

	// Token: 0x06018743 RID: 100163 RVA: 0x00761B2C File Offset: 0x0075FD2C
	private EMorphType GetActiveMorphTypeFromTags()
	{
		if (this.TagComp == null)
		{
			return EMorphType.默认形态;
		}
		foreach (KeyValuePair<int, EMorphType> keyValuePair in CharacterMorphComponent.morphTagTypeMap)
		{
			int num;
			EMorphType emorphType;
			keyValuePair.Deconstruct(out num, out emorphType);
			int tagId = num;
			EMorphType emorphType2 = emorphType;
			Dictionary<EMorphType, IMorphData> morphDataMap = this.MorphDataMap;
			if (morphDataMap != null && morphDataMap.ContainsKey(emorphType2) && this.TagComp.HasTag(tagId))
			{
				return emorphType2;
			}
		}
		return EMorphType.默认形态;
	}

	// Token: 0x06018744 RID: 100164 RVA: 0x00761BC4 File Offset: 0x0075FDC4
	private unsafe void InitMorphData()
	{
		this.InitModelIdMap();
		if (this.MorphModelIdMap == null)
		{
			return;
		}
		RolePreloadComponent rolePreloadComp = this.RolePreloadComp;
		TMap<TEnumAsByte<EMorphType>, SCharacterMorphInfo> tmap;
		if (rolePreloadComp == null)
		{
			tmap = null;
		}
		else
		{
			SCharacterFightInfo fightInfo = rolePreloadComp.GetFightInfo();
			tmap = ((fightInfo != null) ? fightInfo.MorphModelInfoMap : null);
		}
		TMap<TEnumAsByte<EMorphType>, SCharacterMorphInfo> tmap2 = tmap;
		Dictionary<EMorphType, IMorphData> dictionary = new Dictionary<EMorphType, IMorphData>();
		foreach (KeyValuePair<EMorphType, int> keyValuePair in this.MorphModelIdMap)
		{
			EMorphType key = keyValuePair.Key;
			int value = keyValuePair.Value;
			if (value == 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.WWJ;
				string message = "[CharacterMorphComponent]初始化获取ModelId有误";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ModelId", value);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("MorphType", key);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				dictionary[key] = new MorphData
				{
					ModelId = 0
				};
			}
			else
			{
				SModelConfig modelConfig = ModelUtil.GetModelConfig(value);
				SCharacterMorphInfo scharacterMorphInfo = (tmap2 != null) ? tmap2.GetValueOrDefault(key) : null;
				MorphData morphData = new MorphData
				{
					ModelId = value,
					SkeletalMesh = ResourceSystem.Instance.GetLoadedAsset<USkeletalMesh>(modelConfig.网格体.ToAssetPathName()),
					AnimClass = ResourceSystem.Instance.GetLoadedAsset<UClass>(modelConfig.动画蓝图.ToAssetPathName()),
					ComponentFloatParams = new Dictionary<string, Dictionary<string, float>>(),
					ComponentVectorParams = new Dictionary<string, Dictionary<string, Vector>>(),
					ComponentStringParams = new Dictionary<string, Dictionary<string, string>>()
				};
				if (key != EMorphType.默认形态)
				{
					morphData.DtBaseMovementSetting = ((scharacterMorphInfo != null) ? scharacterMorphInfo.DtBaseMovementSetting : null);
					morphData.DtCameraConfig = ((scharacterMorphInfo != null) ? scharacterMorphInfo.DtCameraConfig : null);
					morphData.InputComponentClass = ((scharacterMorphInfo != null) ? scharacterMorphInfo.InputComponentClass : null);
					this.InitComponentFloatParams(morphData, (scharacterMorphInfo != null) ? scharacterMorphInfo.ComponentFloatParams : null);
					this.InitComponentVectorParams(morphData, (scharacterMorphInfo != null) ? scharacterMorphInfo.ComponentVectorParams : null);
					this.InitComponentStringParams(morphData, (scharacterMorphInfo != null) ? scharacterMorphInfo.ComponentStringParams : null);
				}
				if (morphData.SkeletalMesh == null)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.Battle;
					ELogAuthor author2 = ELogAuthor.WWJ;
					string message2 = "[CharacterMorphComponent]初始化资源有误";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("ModelId", value);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("MorphType", key);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("SkeletalMeshPath", modelConfig.网格体.ToAssetPathName());
					instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				}
				if (morphData.AnimClass == null)
				{
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.Battle;
					ELogAuthor author3 = ELogAuthor.WWJ;
					string message3 = "[CharacterMorphComponent]初始化资源有误";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("ModelId", value);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("MorphType", key);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("AnimClassPath", modelConfig.动画蓝图.ToAssetPathName());
					instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
				}
				dictionary[key] = morphData;
			}
		}
		this.MorphDataMap = dictionary;
		this.IsEnableMorphInternal = (dictionary.Count != 0);
	}

	// Token: 0x06018745 RID: 100165 RVA: 0x00761F30 File Offset: 0x00760130
	private void InitModelIdMap()
	{
		if (this.MorphModelIdMap != null)
		{
			return;
		}
		RolePreloadComponent rolePreloadComp = this.RolePreloadComp;
		TMap<TEnumAsByte<EMorphType>, SCharacterMorphInfo> tmap;
		if (rolePreloadComp == null)
		{
			tmap = null;
		}
		else
		{
			SCharacterFightInfo fightInfo = rolePreloadComp.GetFightInfo();
			tmap = ((fightInfo != null) ? fightInfo.MorphModelInfoMap : null);
		}
		TMap<TEnumAsByte<EMorphType>, SCharacterMorphInfo> tmap2 = tmap;
		if (tmap2 != null && tmap2.Num() > 0)
		{
			Dictionary<EMorphType, int> dictionary = new Dictionary<EMorphType, int>();
			foreach (KeyValuePair<TEnumAsByte<EMorphType>, SCharacterMorphInfo> keyValuePair in tmap2)
			{
				TEnumAsByte<EMorphType> tenumAsByte;
				SCharacterMorphInfo scharacterMorphInfo;
				keyValuePair.Deconstruct(out tenumAsByte, out scharacterMorphInfo);
				TEnumAsByte<EMorphType> tenumAsByte2 = tenumAsByte;
				SCharacterMorphInfo scharacterMorphInfo2 = scharacterMorphInfo;
				if (!(tenumAsByte2 == EMorphType.默认形态) && scharacterMorphInfo2.ModelId != 0)
				{
					dictionary[tenumAsByte2] = scharacterMorphInfo2.ModelId;
				}
			}
			if (dictionary.Count > 0)
			{
				CreatureDataComponent creatureDataComp = this.CreatureDataComp;
				int num = (creatureDataComp != null) ? creatureDataComp.GetModelId() : 0;
				if (num != 0)
				{
					dictionary[EMorphType.默认形态] = num;
					this.MorphModelIdMap = dictionary;
				}
			}
		}
	}

	// Token: 0x06018746 RID: 100166 RVA: 0x00762028 File Offset: 0x00760228
	private void InitComponentFloatParams(IMorphData morphData, [Nullable(new byte[]
	{
		2,
		1
	})] TMap<string, float> componentFloatParams)
	{
		if (componentFloatParams == null)
		{
			return;
		}
		Dictionary<string, Dictionary<string, float>> componentFloatParams2 = morphData.ComponentFloatParams;
		foreach (KeyValuePair<string, float> keyValuePair in componentFloatParams)
		{
			string text;
			float num;
			keyValuePair.Deconstruct(out text, out num);
			string text2 = text;
			float value = num;
			string[] array = text2.Split('.', StringSplitOptions.None);
			if (array.Length >= 2)
			{
				if (array.Length > 2 && array[1] == "可变胶囊体碰撞")
				{
					array = CharacterMorphComponent.ProcessAdjustableCapsuleParamName(array);
				}
				string key = array[0];
				string key2 = array[1];
				Dictionary<string, float> dictionary;
				if (!componentFloatParams2.TryGetValue(key, out dictionary))
				{
					dictionary = (componentFloatParams2[key] = new Dictionary<string, float>());
				}
				dictionary[key2] = value;
			}
		}
	}

	// Token: 0x06018747 RID: 100167 RVA: 0x007620F0 File Offset: 0x007602F0
	private void InitComponentVectorParams(IMorphData morphData, [Nullable(new byte[]
	{
		2,
		1
	})] TMap<string, FVector> componentVectorParams)
	{
		if (componentVectorParams == null)
		{
			return;
		}
		Dictionary<string, Dictionary<string, Vector>> componentVectorParams2 = morphData.ComponentVectorParams;
		foreach (KeyValuePair<string, FVector> keyValuePair in componentVectorParams)
		{
			string text;
			FVector fvector;
			keyValuePair.Deconstruct(out text, out fvector);
			string text2 = text;
			FVector fvector2 = fvector;
			string[] array = text2.Split('.', StringSplitOptions.None);
			if (array.Length >= 2)
			{
				string key = array[0];
				string key2 = array[1];
				Dictionary<string, Vector> dictionary;
				if (!componentVectorParams2.TryGetValue(key, out dictionary))
				{
					dictionary = (componentVectorParams2[key] = new Dictionary<string, Vector>());
				}
				Vector vector = Vector.Create();
				vector.FromUeVector(fvector2);
				dictionary[key2] = vector;
			}
		}
	}

	// Token: 0x06018748 RID: 100168 RVA: 0x007621A8 File Offset: 0x007603A8
	private void InitComponentStringParams(IMorphData morphData, [Nullable(new byte[]
	{
		2,
		1,
		1
	})] TMap<string, string> componentStringParams)
	{
		if (componentStringParams == null)
		{
			return;
		}
		Dictionary<string, Dictionary<string, string>> componentStringParams2 = morphData.ComponentStringParams;
		foreach (KeyValuePair<string, string> keyValuePair in componentStringParams)
		{
			string text;
			string text2;
			keyValuePair.Deconstruct(out text, out text2);
			string text3 = text;
			string text4 = text2;
			string[] array = text3.Split('.', StringSplitOptions.None);
			if (text4 != null && array.Length >= 2)
			{
				if (array.Length > 2 && array[1] == "可变胶囊体碰撞")
				{
					array = CharacterMorphComponent.ProcessAdjustableCapsuleParamName(array);
				}
				string key = array[0];
				string key2 = array[1];
				Dictionary<string, string> dictionary;
				if (!componentStringParams2.TryGetValue(key, out dictionary))
				{
					dictionary = (componentStringParams2[key] = new Dictionary<string, string>());
				}
				dictionary[key2] = text4;
			}
		}
	}

	// Token: 0x06018749 RID: 100169 RVA: 0x00762274 File Offset: 0x00760474
	private static string[] ProcessAdjustableCapsuleParamName(string[] sp)
	{
		string text = sp[0] + "#" + sp[1];
		string text2 = "";
		for (int i = 2; i < sp.Length; i++)
		{
			if (i > 2)
			{
				text2 += "#";
			}
			text2 += sp[i];
		}
		return new string[]
		{
			text,
			text2
		};
	}

	// Token: 0x0601874A RID: 100170 RVA: 0x007622D0 File Offset: 0x007604D0
	[return: Nullable(2)]
	private static UKuroAdjustableCapsuleComponent FindAdjustableCapsuleByName(string capsuleName, USkeletalMeshComponent mesh)
	{
		AActor owner = mesh.GetOwner();
		if (owner == null)
		{
			return null;
		}
		TArray<UActorComponent> tarray = owner.K2_GetComponentsByClass(UKuroAdjustableCapsuleComponent.StaticClass());
		for (int i = 0; i < tarray.Num(); i++)
		{
			UKuroAdjustableCapsuleComponent ukuroAdjustableCapsuleComponent = tarray.Get(i) as UKuroAdjustableCapsuleComponent;
			string a = (ukuroAdjustableCapsuleComponent != null) ? ukuroAdjustableCapsuleComponent.GetName() : null;
			if (ukuroAdjustableCapsuleComponent != null && a == capsuleName)
			{
				return ukuroAdjustableCapsuleComponent;
			}
		}
		return null;
	}

	// Token: 0x0601874B RID: 100171 RVA: 0x00762336 File Offset: 0x00760536
	public EMorphType GetMorphType()
	{
		return this.MorphType;
	}

	// Token: 0x0601874C RID: 100172 RVA: 0x00762340 File Offset: 0x00760540
	[NullableContext(2)]
	public IMorphData GetMorphData(EMorphType? morphType = null)
	{
		if (morphType == null)
		{
			return this.MorphData;
		}
		IMorphData result;
		if (this.MorphDataMap != null && this.MorphDataMap.TryGetValue(morphType.Value, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x0601874D RID: 100173 RVA: 0x00762380 File Offset: 0x00760580
	[NullableContext(2)]
	public UDataTable GetMorphCameraConfig(EMorphType? morphType = null)
	{
		EMorphType value = morphType ?? this.MorphType;
		IMorphData morphData = this.GetMorphData(new EMorphType?(value));
		if (morphData == null)
		{
			return null;
		}
		return morphData.CameraConfig;
	}

	// Token: 0x0601874E RID: 100174 RVA: 0x007623BF File Offset: 0x007605BF
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<EMorphType, IMorphData> GetMorphDataMap()
	{
		return this.MorphDataMap;
	}

	// Token: 0x0601874F RID: 100175 RVA: 0x007623C7 File Offset: 0x007605C7
	[NullableContext(2)]
	public BP_InputBase_C GetMorphBpInputComp(EMorphType morphType)
	{
		IMorphData morphData = this.GetMorphData(new EMorphType?(morphType));
		if (morphData == null)
		{
			return null;
		}
		return morphData.InputComponent;
	}

	// Token: 0x06018750 RID: 100176 RVA: 0x007623E0 File Offset: 0x007605E0
	private bool IsValidMorphType(EMorphType morphType)
	{
		return morphType < EMorphType.EMorphType_MAX;
	}

	// Token: 0x06018751 RID: 100177 RVA: 0x007623E6 File Offset: 0x007605E6
	public bool IsEnableMorph()
	{
		return this.IsEnableMorphInternal;
	}

	// Token: 0x06018752 RID: 100178 RVA: 0x007623EE File Offset: 0x007605EE
	public bool IsMorphing()
	{
		return this.MorphType > EMorphType.默认形态;
	}

	// Token: 0x06018753 RID: 100179 RVA: 0x007623FC File Offset: 0x007605FC
	public bool HasComponentFloatParam(EMorphType morphType, string compName, string paramName)
	{
		IMorphData morphData = this.GetMorphData(new EMorphType?(morphType));
		Dictionary<string, float> dictionary;
		float num;
		return morphData != null && morphData.ComponentFloatParams != null && morphData.ComponentFloatParams.TryGetValue(compName, out dictionary) && dictionary != null && dictionary.TryGetValue(paramName, out num);
	}

	// Token: 0x06018754 RID: 100180 RVA: 0x00762448 File Offset: 0x00760648
	public void SetComponentFloatParam(EMorphType morphType, string compName, string paramName, float value)
	{
		IMorphData morphData = this.GetMorphData(new EMorphType?(morphType));
		if (morphData == null)
		{
			return;
		}
		Dictionary<string, Dictionary<string, float>> componentFloatParams = morphData.ComponentFloatParams;
		if (componentFloatParams == null)
		{
			return;
		}
		Dictionary<string, float> dictionary;
		if (!componentFloatParams.TryGetValue(compName, out dictionary) || dictionary == null)
		{
			dictionary = new Dictionary<string, float>();
			componentFloatParams[compName] = dictionary;
		}
		dictionary[paramName] = value;
	}

	// Token: 0x06018755 RID: 100181 RVA: 0x00762498 File Offset: 0x00760698
	public bool HasComponentVectorParam(EMorphType morphType, string compName, string paramName)
	{
		IMorphData morphData = this.GetMorphData(new EMorphType?(morphType));
		Dictionary<string, Vector> dictionary;
		Vector vector;
		return morphData != null && morphData.ComponentVectorParams != null && morphData.ComponentVectorParams.TryGetValue(compName, out dictionary) && dictionary != null && dictionary.TryGetValue(paramName, out vector);
	}

	// Token: 0x06018756 RID: 100182 RVA: 0x007624E4 File Offset: 0x007606E4
	public void SetComponentVectorParam(EMorphType morphType, string compName, string paramName, Vector value)
	{
		IMorphData morphData = this.GetMorphData(new EMorphType?(morphType));
		if (morphData == null)
		{
			return;
		}
		Dictionary<string, Dictionary<string, Vector>> componentVectorParams = morphData.ComponentVectorParams;
		if (componentVectorParams == null)
		{
			return;
		}
		Dictionary<string, Vector> dictionary;
		if (!componentVectorParams.TryGetValue(compName, out dictionary) || dictionary == null)
		{
			dictionary = new Dictionary<string, Vector>();
			componentVectorParams[compName] = dictionary;
		}
		dictionary[paramName] = value;
	}

	// Token: 0x06018757 RID: 100183 RVA: 0x00762534 File Offset: 0x00760734
	public bool HasComponentStringParam(EMorphType morphType, string compName, string paramName)
	{
		IMorphData morphData = this.GetMorphData(new EMorphType?(morphType));
		Dictionary<string, string> dictionary;
		string text;
		return morphData != null && morphData.ComponentStringParams != null && morphData.ComponentStringParams.TryGetValue(compName, out dictionary) && dictionary != null && dictionary.TryGetValue(paramName, out text);
	}

	// Token: 0x06018758 RID: 100184 RVA: 0x00762580 File Offset: 0x00760780
	public void SetComponentStringParam(EMorphType morphType, string compName, string paramName, string value)
	{
		IMorphData morphData = this.GetMorphData(new EMorphType?(morphType));
		if (morphData == null)
		{
			return;
		}
		Dictionary<string, Dictionary<string, string>> componentStringParams = morphData.ComponentStringParams;
		if (componentStringParams == null)
		{
			return;
		}
		Dictionary<string, string> dictionary;
		if (!componentStringParams.TryGetValue(compName, out dictionary) || dictionary == null)
		{
			dictionary = new Dictionary<string, string>();
			componentStringParams[compName] = dictionary;
		}
		dictionary[paramName] = value;
	}

	// Token: 0x06018759 RID: 100185 RVA: 0x007625CE File Offset: 0x007607CE
	public void SetAssetElement(EMorphType morphType, AssetElement assetElement)
	{
		if (this.MorphAssetMap == null)
		{
			this.MorphAssetMap = new Dictionary<EMorphType, AssetElement>();
		}
		this.MorphAssetMap[morphType] = assetElement;
	}

	// Token: 0x0601875A RID: 100186 RVA: 0x007625F0 File Offset: 0x007607F0
	public void AddMontage(string name, UAnimMontage montage, string path)
	{
		Dictionary<string, EMorphType> morphMontagePathMap = this.MorphMontagePathMap;
		EMorphType? emorphType = (morphMontagePathMap != null) ? new EMorphType?(morphMontagePathMap.GetValueOrDefault(path)) : null;
		if (emorphType != null)
		{
			EMorphType? emorphType2 = emorphType;
			EMorphType emorphType3 = EMorphType.默认形态;
			if (!(emorphType2.GetValueOrDefault() == emorphType3 & emorphType2 != null))
			{
				if (this.MorphMontageMapByName == null)
				{
					this.MorphMontageMapByName = new Dictionary<EMorphType, Dictionary<string, UAnimMontage>>();
				}
				Dictionary<string, UAnimMontage> dictionary;
				if (!this.MorphMontageMapByName.TryGetValue(emorphType.Value, out dictionary) || dictionary == null)
				{
					dictionary = new Dictionary<string, UAnimMontage>();
					this.MorphMontageMapByName[emorphType.Value] = dictionary;
				}
				dictionary[name] = montage;
				if (this.MorphMontagePathMapByName == null)
				{
					this.MorphMontagePathMapByName = new Dictionary<EMorphType, Dictionary<string, string>>();
				}
				Dictionary<string, string> dictionary2;
				if (!this.MorphMontagePathMapByName.TryGetValue(emorphType.Value, out dictionary2) || dictionary2 == null)
				{
					dictionary2 = new Dictionary<string, string>();
					this.MorphMontagePathMapByName[emorphType.Value] = dictionary2;
				}
				dictionary2[name] = path;
				return;
			}
		}
	}

	// Token: 0x0601875B RID: 100187 RVA: 0x007626DC File Offset: 0x007608DC
	public void AddMorphMontagePath(string path, EMorphType morphType)
	{
		if (this.MorphMontagePathMap == null)
		{
			this.MorphMontagePathMap = new Dictionary<string, EMorphType>();
		}
		this.MorphMontagePathMap[path] = morphType;
	}

	// Token: 0x0601875C RID: 100188 RVA: 0x007626FE File Offset: 0x007608FE
	public void SetMontageSubPathMorphType(string name, EMorphType morphType)
	{
		if (this.SubPathNameMorphTypeMap == null)
		{
			this.SubPathNameMorphTypeMap = new Dictionary<string, EMorphType>();
		}
		this.SubPathNameMorphTypeMap[name] = morphType;
	}

	// Token: 0x0601875D RID: 100189 RVA: 0x00762720 File Offset: 0x00760920
	public EMorphType GetMontagePathMorphType(string path)
	{
		if (this.SubPathNameMorphTypeMap != null)
		{
			foreach (KeyValuePair<string, EMorphType> keyValuePair in this.SubPathNameMorphTypeMap)
			{
				if (path.Contains(keyValuePair.Key))
				{
					return keyValuePair.Value;
				}
			}
			return EMorphType.默认形态;
		}
		return EMorphType.默认形态;
	}

	// Token: 0x0601875E RID: 100190 RVA: 0x00762790 File Offset: 0x00760990
	[return: Nullable(2)]
	public UAnimMontage GetMontageByName(string name)
	{
		if (this.MorphMontageMapByName == null)
		{
			return null;
		}
		Dictionary<string, UAnimMontage> dictionary;
		if (!this.MorphMontageMapByName.TryGetValue(this.MorphType, out dictionary) || dictionary == null)
		{
			return null;
		}
		UAnimMontage result;
		if (!dictionary.TryGetValue(name, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x0601875F RID: 100191 RVA: 0x007627D0 File Offset: 0x007609D0
	[return: Nullable(2)]
	public string GetMontagePathByName(string name)
	{
		if (this.MorphMontagePathMapByName == null)
		{
			return null;
		}
		Dictionary<string, string> dictionary;
		if (!this.MorphMontagePathMapByName.TryGetValue(this.MorphType, out dictionary) || dictionary == null)
		{
			return null;
		}
		string result;
		if (!dictionary.TryGetValue(name, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x06018760 RID: 100192 RVA: 0x00762810 File Offset: 0x00760A10
	public FVectorDouble? GetCenterActorLocationOffset()
	{
		if (this.IsMorphing())
		{
			IMorphData morphData = this.MorphData;
			if (((morphData != null) ? morphData.CenterActorLocationOffset : null) != null)
			{
				return new FVectorDouble?(this.MorphData.CenterActorLocationOffset.ToUeVector(false));
			}
		}
		return null;
	}

	// Token: 0x06018761 RID: 100193 RVA: 0x0076285C File Offset: 0x00760A5C
	public unsafe void SetMorphType(EMorphType morphType)
	{
		if (morphType == this.MorphType)
		{
			return;
		}
		if (!this.IsValidMorphType(morphType))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.WWJ;
			string message = "[CharacterMorphComponent]设置了无效的形态类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MorphType", morphType);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		Dictionary<EMorphType, IMorphData> morphDataMap = this.MorphDataMap;
		IMorphData morphData = (morphDataMap != null) ? morphDataMap.GetValueOrDefault(morphType) : null;
		if (morphData == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Battle;
			ELogAuthor author2 = ELogAuthor.WWJ;
			string message2 = "[CharacterMorphComponent]设置形态失败, 无对应形态数据";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("MorphType", morphType);
			instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return;
		}
		if (morphData.SkeletalMesh == null || morphData.AnimClass == null)
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Battle;
			ELogAuthor author3 = ELogAuthor.WWJ;
			string message3 = "[CharacterMorphComponent]设置形态失败, 对应形态数据有误";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("MorphType", morphType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SkeletalMesh", morphData.SkeletalMesh);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("AnimClass", morphData.AnimClass);
			instance3.Warn(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return;
		}
		if (this.ActorComp != null && !this.ActorComp.IsAutonomousProxy)
		{
			Entity entity = base.Entity;
			CharacterCombatMessageComponent component = entity.GetComponent<CharacterCombatMessageComponent>();
			if (component != null)
			{
				component.FlushPendingMessagesBeforeMorph();
			}
			if (entity.IsEnd || morphType == this.MorphType)
			{
				return;
			}
		}
		this.SetBpCompParamsBackup();
		CombatLog instance4 = CombatLog.Instance;
		CombatLog.EDebugModule flag = CombatLog.EDebugModule.Skill;
		Entity entity2 = base.Entity;
		string message4 = "设置形态成功, 开始切换";
		ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("MorphType", morphType);
		instance4.Info(flag, entity2, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
		EMorphType morphType2 = this.MorphType;
		this.MorphType = morphType;
		this.MorphData = morphData;
		EventSystem.Instance.EmitWithTarget<Entity, EMorphType, EMorphType>(base.Entity, EEventName.OnBeforeCharacterMorphTypeChanged, base.Entity, morphType, morphType2);
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp != null)
		{
			actorComp.ChangeMeshAnim(morphData.SkeletalMesh, morphData.AnimClass);
		}
		CreatureDataComponent creatureDataComp = this.CreatureDataComp;
		if (creatureDataComp != null)
		{
			creatureDataComp.SetModelConfig(morphData.ModelId);
		}
		CharacterActorComponent actorComp2 = this.ActorComp;
		if (actorComp2 != null)
		{
			actorComp2.UpdateModelResPath();
		}
		this.UpdateMovementData();
		this.UpdateMoveComp();
		this.UpdateCapsuleComp();
		this.UpdateCameraConfig();
		this.UpdateMeshComp();
		this.UpdateAdjustableCapsule();
		EventSystem.Instance.Emit<Entity, EMorphType, EMorphType>(EEventName.OnCharacterMorphTypeChanged, base.Entity, morphType, morphType2);
		EventSystem.Instance.EmitWithTarget<Entity, EMorphType, EMorphType>(base.Entity, EEventName.OnCharacterMorphTypeChanged, base.Entity, morphType, morphType2);
	}

	// Token: 0x06018762 RID: 100194 RVA: 0x00762AC4 File Offset: 0x00760CC4
	private void UpdateMovementData()
	{
		if (this.MoveComp == null)
		{
			return;
		}
		UDataTable udataTable;
		if (this.MorphType == EMorphType.默认形态)
		{
			CharacterActorComponent actorComp = this.ActorComp;
			udataTable = ((actorComp != null) ? actorComp.Actor.DtBaseMovementSetting : null);
		}
		else
		{
			IMorphData morphData = this.MorphData;
			udataTable = ((morphData != null) ? morphData.BaseMovementSetting : null);
		}
		if (udataTable != null)
		{
			SMovementSetting_State dataTableRow = DataTableUtil.GetDataTableRow<SMovementSetting_State>(udataTable, CharacterNameDefines.Instance.NORMAL.ToString());
			if (dataTableRow != null)
			{
				this.MoveComp.SetMovementData(dataTableRow, true);
			}
		}
	}

	// Token: 0x06018763 RID: 100195 RVA: 0x00762B48 File Offset: 0x00760D48
	private void UpdateMoveComp()
	{
		CharacterMoveComponent moveComp = this.MoveComp;
		if (moveComp == null)
		{
			return;
		}
		IMorphData morphData = this.MorphData;
		object obj;
		if (morphData == null)
		{
			obj = null;
		}
		else
		{
			Dictionary<string, Dictionary<string, float>> componentFloatParams = morphData.ComponentFloatParams;
			obj = ((componentFloatParams != null) ? componentFloatParams.GetValueOrDefault("角色移动") : null);
		}
		object obj2 = obj;
		float? num = (obj2 != null) ? new float?(obj2.GetValueOrDefault("最大步高")) : null;
		float? num2 = (obj2 != null) ? new float?(obj2.GetValueOrDefault("可行走地面角度")) : null;
		float? num3 = (obj2 != null) ? new float?(obj2.GetValueOrDefault("维持水平地面速度")) : null;
		float? num4 = (obj2 != null) ? new float?(obj2.GetValueOrDefault("默认水中运动模式")) : null;
		if (this.MorphType != EMorphType.默认形态)
		{
			if (num != null)
			{
				moveComp.SetStepHeight(num.Value);
			}
			if (num2 != null)
			{
				moveComp.SetWalkableFloorAngle(num2.Value);
			}
		}
		else
		{
			moveComp.ResetStepHeight();
			moveComp.ResetWalkableFloorAngle();
		}
		UCharacterMovementComponent characterMovement = moveComp.CharacterMovement;
		if (characterMovement != null)
		{
			if (num3 != null)
			{
				characterMovement.bMaintainHorizontalGroundVelocity = (num3.Value != 0f);
			}
			if (num4 != null)
			{
				characterMovement.DefaultWaterMovementMode = (EMovementMode)((byte)num4.Value);
			}
		}
	}

	// Token: 0x06018764 RID: 100196 RVA: 0x00762C94 File Offset: 0x00760E94
	private void UpdateMeshComp()
	{
		CharacterActorComponent actorComp = this.ActorComp;
		if (((actorComp != null) ? actorComp.Actor.Mesh : null) == null)
		{
			return;
		}
		IMorphData morphData = this.MorphData;
		if (morphData == null)
		{
			return;
		}
		if (morphData.ComponentVectorParams == null)
		{
			return;
		}
		Dictionary<string, Vector> dictionary;
		if (!morphData.ComponentVectorParams.TryGetValue("网格体", out dictionary) || dictionary == null)
		{
			return;
		}
		Vector vector;
		if (dictionary.TryGetValue("位置", out vector) && vector != null)
		{
			vector.X = 0.0;
			vector.Y = 0.0;
			CharacterAnimationComponent characterAnimationComp = this.CharacterAnimationComp;
			if (characterAnimationComp == null)
			{
				return;
			}
			characterAnimationComp.SetOriginLocation(vector);
		}
	}

	// Token: 0x06018765 RID: 100197 RVA: 0x00762D28 File Offset: 0x00760F28
	[return: Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private Dictionary<string, Dictionary<string, float>> ParseAdjustableCapsuleParams([Nullable(new byte[]
	{
		2,
		1
	})] Dictionary<string, float> capsuleParams)
	{
		if (capsuleParams == null)
		{
			return null;
		}
		Dictionary<string, Dictionary<string, float>> dictionary = new Dictionary<string, Dictionary<string, float>>();
		foreach (KeyValuePair<string, float> keyValuePair in capsuleParams)
		{
			string key = keyValuePair.Key;
			float value = keyValuePair.Value;
			string[] array = key.Split('#', StringSplitOptions.None);
			if (array.Length >= 2)
			{
				string key2 = array[0];
				string key3 = array[1];
				Dictionary<string, float> dictionary2;
				if (!dictionary.TryGetValue(key2, out dictionary2) || dictionary2 == null)
				{
					dictionary2 = new Dictionary<string, float>();
					dictionary[key2] = dictionary2;
				}
				dictionary2[key3] = value;
			}
		}
		return dictionary;
	}

	// Token: 0x06018766 RID: 100198 RVA: 0x00762DD4 File Offset: 0x00760FD4
	[return: Nullable(new byte[]
	{
		2,
		1,
		1,
		1,
		1
	})]
	private Dictionary<string, Dictionary<string, string>> ParseAdjustableCapsuleStringParams([Nullable(new byte[]
	{
		2,
		1,
		1
	})] Dictionary<string, string> capsuleParams)
	{
		if (capsuleParams == null)
		{
			return null;
		}
		Dictionary<string, Dictionary<string, string>> dictionary = new Dictionary<string, Dictionary<string, string>>();
		foreach (KeyValuePair<string, string> keyValuePair in capsuleParams)
		{
			string key = keyValuePair.Key;
			string value = keyValuePair.Value;
			string[] array = key.Split('#', StringSplitOptions.None);
			if (array.Length >= 2)
			{
				string key2 = array[0];
				string key3 = array[1];
				Dictionary<string, string> dictionary2;
				if (!dictionary.TryGetValue(key2, out dictionary2) || dictionary2 == null)
				{
					dictionary2 = new Dictionary<string, string>();
					dictionary[key2] = dictionary2;
				}
				dictionary2[key3] = value;
			}
		}
		return dictionary;
	}

	// Token: 0x06018767 RID: 100199 RVA: 0x00762E80 File Offset: 0x00761080
	private static string[] ParseSocketNamesString(string value)
	{
		string text = value.Trim();
		if (text.StartsWith("["))
		{
			text = text.Substring(1);
		}
		if (text.EndsWith("]"))
		{
			text = text.Substring(0, text.Length - 1);
		}
		if (text.Length == 0)
		{
			return Array.Empty<string>();
		}
		List<string> list = new List<string>();
		string[] array = text.Split(',', StringSplitOptions.None);
		for (int i = 0; i < array.Length; i++)
		{
			string text2 = array[i].Trim();
			if (text2.Length > 0)
			{
				list.Add(text2);
			}
		}
		return list.ToArray();
	}

	// Token: 0x06018768 RID: 100200 RVA: 0x00762F14 File Offset: 0x00761114
	private static void SetAdjustableCapsuleBindSocketNames(UKuroAdjustableCapsuleComponent adjustableCapsule, string[] socketNames)
	{
		TArray<FName> tarray = new TArray<FName>();
		foreach (string name in socketNames)
		{
			tarray.Add(new FName(name));
		}
		adjustableCapsule.BindSocketNames = tarray;
	}

	// Token: 0x06018769 RID: 100201 RVA: 0x00762F50 File Offset: 0x00761150
	private static string GetAdjustableCapsuleBindSocketNames(UKuroAdjustableCapsuleComponent adjustableCapsule)
	{
		TArray<FName> bindSocketNames = adjustableCapsule.BindSocketNames;
		List<string> list = new List<string>();
		for (int i = 0; i < bindSocketNames.Num(); i++)
		{
			list.Add(bindSocketNames.Get(i).ToString());
		}
		return "[" + string.Join(",", list) + "]";
	}

	// Token: 0x0601876A RID: 100202 RVA: 0x00762FB0 File Offset: 0x007611B0
	private void UpdateAdjustableCapsule()
	{
		CharacterActorComponent actorComp = this.ActorComp;
		USkeletalMeshComponent uskeletalMeshComponent = (actorComp != null) ? actorComp.Actor.Mesh : null;
		if (uskeletalMeshComponent == null)
		{
			return;
		}
		if (this.MorphType == EMorphType.默认形态)
		{
			Dictionary<string, Dictionary<string, float>> defaultAdjustableCapsuleParams = this.DefaultAdjustableCapsuleParams;
			if (defaultAdjustableCapsuleParams != null && defaultAdjustableCapsuleParams.Count > 0)
			{
				foreach (KeyValuePair<string, Dictionary<string, float>> keyValuePair in defaultAdjustableCapsuleParams)
				{
					string key = keyValuePair.Key;
					Dictionary<string, float> value = keyValuePair.Value;
					UKuroAdjustableCapsuleComponent ukuroAdjustableCapsuleComponent = CharacterMorphComponent.FindAdjustableCapsuleByName(key, uskeletalMeshComponent);
					if (ukuroAdjustableCapsuleComponent != null)
					{
						foreach (KeyValuePair<string, float> keyValuePair2 in value)
						{
							string key2 = keyValuePair2.Key;
							if (!(key2 == "AddRadius"))
							{
								if (!(key2 == "MinRadius"))
								{
									if (key2 == "MaxRadius")
									{
										ukuroAdjustableCapsuleComponent.MaxRadius = keyValuePair2.Value;
									}
								}
								else
								{
									ukuroAdjustableCapsuleComponent.MinRadius = keyValuePair2.Value;
								}
							}
							else
							{
								ukuroAdjustableCapsuleComponent.AddRadius = keyValuePair2.Value;
							}
						}
					}
				}
			}
			Dictionary<string, Dictionary<string, string>> defaultAdjustableCapsuleStringParams = this.DefaultAdjustableCapsuleStringParams;
			if (defaultAdjustableCapsuleStringParams == null || defaultAdjustableCapsuleStringParams.Count <= 0)
			{
				return;
			}
			using (Dictionary<string, Dictionary<string, string>>.Enumerator enumerator3 = defaultAdjustableCapsuleStringParams.GetEnumerator())
			{
				while (enumerator3.MoveNext())
				{
					KeyValuePair<string, Dictionary<string, string>> keyValuePair3 = enumerator3.Current;
					string key3 = keyValuePair3.Key;
					Dictionary<string, string> value2 = keyValuePair3.Value;
					UKuroAdjustableCapsuleComponent ukuroAdjustableCapsuleComponent2 = CharacterMorphComponent.FindAdjustableCapsuleByName(key3, uskeletalMeshComponent);
					if (ukuroAdjustableCapsuleComponent2 != null)
					{
						foreach (KeyValuePair<string, string> keyValuePair4 in value2)
						{
							if (keyValuePair4.Key == "BindSocketNames")
							{
								CharacterMorphComponent.SetAdjustableCapsuleBindSocketNames(ukuroAdjustableCapsuleComponent2, CharacterMorphComponent.ParseSocketNamesString(keyValuePair4.Value));
							}
						}
					}
				}
				return;
			}
		}
		if (this.MorphData == null)
		{
			return;
		}
		Dictionary<string, Dictionary<string, float>> componentFloatParams = this.MorphData.ComponentFloatParams;
		Dictionary<string, float> capsuleParams = (componentFloatParams != null) ? componentFloatParams.GetValueOrDefault("网格体#可变胶囊体碰撞") : null;
		Dictionary<string, Dictionary<string, float>> dictionary = this.ParseAdjustableCapsuleParams(capsuleParams);
		if (dictionary != null)
		{
			foreach (KeyValuePair<string, Dictionary<string, float>> keyValuePair5 in dictionary)
			{
				string key4 = keyValuePair5.Key;
				Dictionary<string, float> value3 = keyValuePair5.Value;
				UKuroAdjustableCapsuleComponent ukuroAdjustableCapsuleComponent3 = CharacterMorphComponent.FindAdjustableCapsuleByName(key4, uskeletalMeshComponent);
				if (ukuroAdjustableCapsuleComponent3 != null)
				{
					foreach (KeyValuePair<string, float> keyValuePair6 in value3)
					{
						string key2 = keyValuePair6.Key;
						if (!(key2 == "AddRadius"))
						{
							if (!(key2 == "MinRadius"))
							{
								if (key2 == "MaxRadius")
								{
									ukuroAdjustableCapsuleComponent3.MaxRadius = keyValuePair6.Value;
								}
							}
							else
							{
								ukuroAdjustableCapsuleComponent3.MinRadius = keyValuePair6.Value;
							}
						}
						else
						{
							ukuroAdjustableCapsuleComponent3.AddRadius = keyValuePair6.Value;
						}
					}
				}
			}
		}
		Dictionary<string, Dictionary<string, string>> componentStringParams = this.MorphData.ComponentStringParams;
		Dictionary<string, string> capsuleParams2 = (componentStringParams != null) ? componentStringParams.GetValueOrDefault("网格体#可变胶囊体碰撞") : null;
		Dictionary<string, Dictionary<string, string>> dictionary2 = this.ParseAdjustableCapsuleStringParams(capsuleParams2);
		if (dictionary2 != null)
		{
			foreach (KeyValuePair<string, Dictionary<string, string>> keyValuePair7 in dictionary2)
			{
				string key5 = keyValuePair7.Key;
				Dictionary<string, string> value4 = keyValuePair7.Value;
				UKuroAdjustableCapsuleComponent ukuroAdjustableCapsuleComponent4 = CharacterMorphComponent.FindAdjustableCapsuleByName(key5, uskeletalMeshComponent);
				if (ukuroAdjustableCapsuleComponent4 != null)
				{
					foreach (KeyValuePair<string, string> keyValuePair8 in value4)
					{
						if (keyValuePair8.Key == "BindSocketNames")
						{
							CharacterMorphComponent.SetAdjustableCapsuleBindSocketNames(ukuroAdjustableCapsuleComponent4, CharacterMorphComponent.ParseSocketNamesString(keyValuePair8.Value));
						}
					}
				}
			}
		}
	}

	// Token: 0x0601876B RID: 100203 RVA: 0x007633E4 File Offset: 0x007615E4
	private void UpdateCapsuleComp()
	{
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp == null)
		{
			return;
		}
		if (!this.IsBackupDefaultCapsule)
		{
			this.DefaultHalfHeightInternal = actorComp.DefaultHalfHeight;
			this.DefaultRadiusInternal = actorComp.DefaultRadius;
			this.IsBackupDefaultCapsule = true;
		}
		float num = 0f;
		bool isRoleAndCtrlByMe = actorComp.IsRoleAndCtrlByMe;
		if (this.MorphType == EMorphType.默认形态)
		{
			num = this.DefaultHalfHeightInternal - actorComp.HalfHeight;
			actorComp.SetDefaultRadiusAndHalfHeight(this.DefaultRadiusInternal, this.DefaultHalfHeightInternal);
			actorComp.SetRadiusAndHalfHeight(this.DefaultRadiusInternal, this.DefaultHalfHeightInternal, false, false);
			if (isRoleAndCtrlByMe)
			{
				GameBudgetController.Instance.SetCenterOffset(Vector.ZeroVectorDouble);
			}
		}
		else
		{
			IMorphData morphData = this.MorphData;
			object obj;
			if (morphData == null)
			{
				obj = null;
			}
			else
			{
				Dictionary<string, Dictionary<string, float>> componentFloatParams = morphData.ComponentFloatParams;
				obj = ((componentFloatParams != null) ? componentFloatParams.GetValueOrDefault("胶囊体组件") : null);
			}
			object obj2 = obj;
			float? num2 = (obj2 != null) ? new float?(obj2.GetValueOrDefault("胶囊体半高")) : null;
			float? num3 = (obj2 != null) ? new float?(obj2.GetValueOrDefault("胶囊体半径")) : null;
			if (num2 != null || num3 != null)
			{
				num2 = new float?(num2 ?? actorComp.HalfHeight);
				num3 = new float?(num3 ?? actorComp.Radius);
				if (num2.Value > 0f && num3.Value > 0f)
				{
					num = num2.Value - actorComp.HalfHeight;
					actorComp.SetRadiusAndHalfHeight(num3.Value, num2.Value, false, false);
					if (isRoleAndCtrlByMe && morphData != null)
					{
						float defaultHalfHeightInternal = this.DefaultHalfHeightInternal;
						float defaultRadiusInternal = this.DefaultRadiusInternal;
						if (defaultHalfHeightInternal > 0f && defaultRadiusInternal > 0f)
						{
							if (morphData.CenterActorLocationOffset == null)
							{
								morphData.CenterActorLocationOffset = Vector.Create(0.0, 0.0, (double)(-(double)(num2.Value + num3.Value - defaultHalfHeightInternal - defaultRadiusInternal)));
							}
							GameBudgetController.Instance.SetCenterOffset(morphData.CenterActorLocationOffset.ToUeVector(false));
						}
					}
					actorComp.SetDefaultRadiusAndHalfHeight(num3.Value, num2.Value);
				}
			}
		}
		if (isRoleAndCtrlByMe)
		{
			CharacterFloatingComponent characterFloatingComp = this.CharacterFloatingComp;
			float num4 = (characterFloatingComp != null && characterFloatingComp.IsNearGround) ? (num - this.CharacterFloatingComp.NearGroundDist) : num;
			if (num4 != 0f)
			{
				UCharacterMovementComponent characterMovement = actorComp.Actor.CharacterMovement;
				TEnumAsByte<EMovementMode>? tenumAsByte = (characterMovement != null) ? new TEnumAsByte<EMovementMode>?(characterMovement.MovementMode) : null;
				UCharacterMovementComponent characterMovement2 = actorComp.Actor.CharacterMovement;
				byte? b = (characterMovement2 != null) ? new byte?(characterMovement2.CustomMovementMode) : null;
				if (!(tenumAsByte == EMovementMode.MOVE_Walking) && !(tenumAsByte == EMovementMode.MOVE_NavWalking) && !(tenumAsByte == EMovementMode.MOVE_None))
				{
					byte? b2 = b;
					if (((b2 != null) ? new int?((int)b2.GetValueOrDefault()) : null).GetValueOrDefault() != 15)
					{
						return;
					}
					CharacterFloatingComponent characterFloatingComp2 = this.CharacterFloatingComp;
					if (characterFloatingComp2 == null || !characterFloatingComp2.IsNearGround)
					{
						return;
					}
				}
				if (this.TempVector == null)
				{
					this.TempVector = Vector.Create();
				}
				Vector tempVector = this.TempVector;
				FVectorDouble actorLocation = actorComp.ActorLocation;
				tempVector.FromUeVector(actorLocation);
				this.TempVector.Z += (double)num4;
				actorComp.SetActorLocation(this.TempVector.ToUeVector(false), "角色形态改变修改胶囊体的位置修正优化", true);
			}
		}
	}

	// Token: 0x0601876C RID: 100204 RVA: 0x007637BC File Offset: 0x007619BC
	private void UpdateCameraConfig()
	{
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp == null || !actorComp.IsRoleAndCtrlByMe)
		{
			return;
		}
		CharacterActorComponent actorComp2 = this.ActorComp;
		UDataTable udataTable = (actorComp2 != null) ? actorComp2.Actor.DtCameraConfig : null;
		if (udataTable == null)
		{
			return;
		}
		if (this.CurrentCameraConfig == null)
		{
			this.CurrentCameraConfig = udataTable;
		}
		UDataTable udataTable2 = this.GetMorphCameraConfig(null) ?? udataTable;
		if (udataTable2 == this.CurrentCameraConfig)
		{
			return;
		}
		if (this.CurrentCameraConfig != null)
		{
			CameraController.Instance.UnloadCharacterCameraConfig(this.CurrentCameraConfig, "MainCamera");
			this.CurrentCameraConfig = null;
		}
		if (udataTable2 != null)
		{
			CameraController.Instance.LoadCharacterCameraConfig(udataTable2);
			this.CurrentCameraConfig = udataTable2;
		}
	}

	// Token: 0x0601876D RID: 100205 RVA: 0x00763864 File Offset: 0x00761A64
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<string, float> CollectMorphFloatParams(string compName)
	{
		if (this.MorphDataMap == null)
		{
			return null;
		}
		Dictionary<string, float> dictionary = null;
		foreach (KeyValuePair<EMorphType, IMorphData> keyValuePair in this.MorphDataMap)
		{
			EMorphType emorphType;
			IMorphData morphData;
			keyValuePair.Deconstruct(out emorphType, out morphData);
			bool flag = emorphType != EMorphType.默认形态;
			IMorphData morphData2 = morphData;
			if (flag)
			{
				Dictionary<string, Dictionary<string, float>> componentFloatParams = morphData2.ComponentFloatParams;
				Dictionary<string, float> dictionary2 = (componentFloatParams != null) ? componentFloatParams.GetValueOrDefault(compName) : null;
				if (dictionary2 != null)
				{
					if (dictionary == null)
					{
						dictionary = new Dictionary<string, float>();
					}
					foreach (KeyValuePair<string, float> keyValuePair2 in dictionary2)
					{
						string text;
						float num;
						keyValuePair2.Deconstruct(out text, out num);
						string key = text;
						float value = num;
						dictionary[key] = value;
					}
				}
			}
		}
		return dictionary;
	}

	// Token: 0x0601876E RID: 100206 RVA: 0x00763950 File Offset: 0x00761B50
	[return: Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<string, string> CollectMorphStringParams(string compName)
	{
		if (this.MorphDataMap == null)
		{
			return null;
		}
		Dictionary<string, string> dictionary = null;
		foreach (KeyValuePair<EMorphType, IMorphData> keyValuePair in this.MorphDataMap)
		{
			EMorphType emorphType;
			IMorphData morphData;
			keyValuePair.Deconstruct(out emorphType, out morphData);
			bool flag = emorphType != EMorphType.默认形态;
			IMorphData morphData2 = morphData;
			if (flag)
			{
				Dictionary<string, Dictionary<string, string>> componentStringParams = morphData2.ComponentStringParams;
				Dictionary<string, string> dictionary2 = (componentStringParams != null) ? componentStringParams.GetValueOrDefault(compName) : null;
				if (dictionary2 != null)
				{
					if (dictionary == null)
					{
						dictionary = new Dictionary<string, string>();
					}
					foreach (KeyValuePair<string, string> keyValuePair2 in dictionary2)
					{
						string text;
						string text2;
						keyValuePair2.Deconstruct(out text, out text2);
						string key = text;
						string value = text2;
						dictionary[key] = value;
					}
				}
			}
		}
		return dictionary;
	}

	// Token: 0x0601876F RID: 100207 RVA: 0x00763A3C File Offset: 0x00761C3C
	private bool HasAnyMorphFloatParam(string compName, string paramName)
	{
		if (this.MorphDataMap == null)
		{
			return false;
		}
		foreach (EMorphType emorphType in this.MorphDataMap.Keys)
		{
			if (emorphType != EMorphType.默认形态 && this.HasComponentFloatParam(emorphType, compName, paramName))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06018770 RID: 100208 RVA: 0x00763AAC File Offset: 0x00761CAC
	private bool HasAnyMorphVectorParam(string compName, string paramName)
	{
		if (this.MorphDataMap == null)
		{
			return false;
		}
		foreach (EMorphType emorphType in this.MorphDataMap.Keys)
		{
			if (emorphType != EMorphType.默认形态 && this.HasComponentVectorParam(emorphType, compName, paramName))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06018771 RID: 100209 RVA: 0x00763B1C File Offset: 0x00761D1C
	private void SetBpCompParamsBackup()
	{
		if (this.MorphType != EMorphType.默认形态 || this.IsBackupBpCompParams)
		{
			return;
		}
		this.IsBackupBpCompParams = true;
		CharacterMoveComponent moveComp = this.MoveComp;
		UCharacterMovementComponent ucharacterMovementComponent = (moveComp != null) ? moveComp.CharacterMovement : null;
		if (ucharacterMovementComponent != null)
		{
			if (this.HasAnyMorphFloatParam("角色移动", "维持水平地面速度"))
			{
				this.SetComponentFloatParam(EMorphType.默认形态, "角色移动", "维持水平地面速度", ucharacterMovementComponent.bMaintainHorizontalGroundVelocity ? 1f : 0f);
			}
			if (this.HasAnyMorphFloatParam("角色移动", "默认水中运动模式"))
			{
				this.SetComponentFloatParam(EMorphType.默认形态, "角色移动", "默认水中运动模式", (float)ucharacterMovementComponent.DefaultWaterMovementMode);
			}
		}
		CharacterActorComponent actorComp = this.ActorComp;
		USkeletalMeshComponent uskeletalMeshComponent = (actorComp != null) ? actorComp.Actor.Mesh : null;
		if (uskeletalMeshComponent != null)
		{
			if (this.HasAnyMorphVectorParam("网格体", "位置"))
			{
				Vector vector = Vector.Create();
				Vector vector2 = vector;
				FVector relativeLocation = uskeletalMeshComponent.RelativeLocation;
				vector2.FromUeVector(relativeLocation);
				this.SetComponentVectorParam(EMorphType.默认形态, "网格体", "位置", vector);
			}
			Dictionary<string, float> capsuleParams = this.CollectMorphFloatParams("网格体#可变胶囊体碰撞");
			Dictionary<string, Dictionary<string, float>> dictionary = this.ParseAdjustableCapsuleParams(capsuleParams);
			if (dictionary != null && dictionary.Count > 0)
			{
				this.DefaultAdjustableCapsuleParams = new Dictionary<string, Dictionary<string, float>>();
				foreach (KeyValuePair<string, Dictionary<string, float>> keyValuePair in dictionary)
				{
					string key = keyValuePair.Key;
					Dictionary<string, float> value = keyValuePair.Value;
					UKuroAdjustableCapsuleComponent ukuroAdjustableCapsuleComponent = CharacterMorphComponent.FindAdjustableCapsuleByName(key, uskeletalMeshComponent);
					if (ukuroAdjustableCapsuleComponent != null)
					{
						Dictionary<string, float> dictionary2 = new Dictionary<string, float>();
						foreach (KeyValuePair<string, float> keyValuePair2 in value)
						{
							string key2 = keyValuePair2.Key;
							if (!(key2 == "AddRadius"))
							{
								if (!(key2 == "MinRadius"))
								{
									if (key2 == "MaxRadius")
									{
										dictionary2["MaxRadius"] = ukuroAdjustableCapsuleComponent.MaxRadius;
									}
								}
								else
								{
									dictionary2["MinRadius"] = ukuroAdjustableCapsuleComponent.MinRadius;
								}
							}
							else
							{
								dictionary2["AddRadius"] = ukuroAdjustableCapsuleComponent.AddRadius;
							}
						}
						this.DefaultAdjustableCapsuleParams[key] = dictionary2;
					}
				}
			}
			Dictionary<string, string> capsuleParams2 = this.CollectMorphStringParams("网格体#可变胶囊体碰撞");
			Dictionary<string, Dictionary<string, string>> dictionary3 = this.ParseAdjustableCapsuleStringParams(capsuleParams2);
			if (dictionary3 != null && dictionary3.Count > 0)
			{
				this.DefaultAdjustableCapsuleStringParams = new Dictionary<string, Dictionary<string, string>>();
				foreach (KeyValuePair<string, Dictionary<string, string>> keyValuePair3 in dictionary3)
				{
					string key3 = keyValuePair3.Key;
					Dictionary<string, string> value2 = keyValuePair3.Value;
					UKuroAdjustableCapsuleComponent ukuroAdjustableCapsuleComponent2 = CharacterMorphComponent.FindAdjustableCapsuleByName(key3, uskeletalMeshComponent);
					if (ukuroAdjustableCapsuleComponent2 != null)
					{
						Dictionary<string, string> dictionary4 = new Dictionary<string, string>();
						foreach (KeyValuePair<string, string> keyValuePair4 in value2)
						{
							if (keyValuePair4.Key == "BindSocketNames")
							{
								dictionary4["BindSocketNames"] = CharacterMorphComponent.GetAdjustableCapsuleBindSocketNames(ukuroAdjustableCapsuleComponent2);
							}
						}
						this.DefaultAdjustableCapsuleStringParams[key3] = dictionary4;
					}
				}
			}
		}
	}

	// Token: 0x06018772 RID: 100210 RVA: 0x00763E7C File Offset: 0x0076207C
	private void LoadMorphResource()
	{
		if (this.MorphDataMap == null)
		{
			return;
		}
		CharacterActorComponent actorComp = this.ActorComp;
		bool flag = actorComp != null && actorComp.IsRoleAndCtrlByMe;
		foreach (KeyValuePair<EMorphType, IMorphData> keyValuePair in this.MorphDataMap)
		{
			EMorphType emorphType;
			IMorphData morphData;
			keyValuePair.Deconstruct(out emorphType, out morphData);
			EMorphType emorphType2 = emorphType;
			IMorphData morphData2 = morphData;
			if (emorphType2 != EMorphType.默认形态)
			{
				this.LoadMovementDataForType(emorphType2, morphData2);
				if (flag)
				{
					this.LoadCameraConfigForType(emorphType2, morphData2);
					this.LoadBpInputCompForType(emorphType2, morphData2);
				}
			}
		}
	}

	// Token: 0x06018773 RID: 100211 RVA: 0x00763F14 File Offset: 0x00762114
	private void LoadMovementDataForType(EMorphType morphType, IMorphData morphData)
	{
		if (morphData.BaseMovementSetting == null)
		{
			Dictionary<EMorphType, int> loadingMovementDataTypes = this.LoadingMovementDataTypes;
			if (loadingMovementDataTypes == null || !loadingMovementDataTypes.ContainsKey(morphType))
			{
				TSoftObjectPtr<UDataTable> dtBaseMovementSetting = morphData.DtBaseMovementSetting;
				string text = (dtBaseMovementSetting != null) ? dtBaseMovementSetting.ToAssetPathName() : null;
				if (string.IsNullOrEmpty(text) || text == "None")
				{
					return;
				}
				if (this.LoadingMovementDataTypes == null)
				{
					this.LoadingMovementDataTypes = new Dictionary<EMorphType, int>();
				}
				bool isLoadFinish = false;
				int value = ResourceSystem.Instance.LoadAsync<UDataTable>(text, delegate([Nullable(2)] UDataTable movementData, string _)
				{
					isLoadFinish = true;
					if (movementData != null)
					{
						Dictionary<EMorphType, IMorphData> morphDataMap = this.MorphDataMap;
						if (((morphDataMap != null) ? morphDataMap.GetValueOrDefault(morphType) : null) == morphData)
						{
							morphData.BaseMovementSetting = movementData;
							if (this.MorphType == morphType)
							{
								this.UpdateMovementData();
							}
						}
					}
					Dictionary<EMorphType, int> loadingMovementDataTypes2 = this.LoadingMovementDataTypes;
					if (loadingMovementDataTypes2 == null)
					{
						return;
					}
					loadingMovementDataTypes2.Remove(morphType);
				}, 100, "js_undefined");
				if (!isLoadFinish)
				{
					this.LoadingMovementDataTypes.Add(morphType, value);
				}
				return;
			}
		}
	}

	// Token: 0x06018774 RID: 100212 RVA: 0x00763FE8 File Offset: 0x007621E8
	private void LoadCameraConfigForType(EMorphType morphType, IMorphData morphData)
	{
		if (morphData.CameraConfig == null)
		{
			Dictionary<EMorphType, int> loadingCameraConfigTypes = this.LoadingCameraConfigTypes;
			if (loadingCameraConfigTypes == null || !loadingCameraConfigTypes.ContainsKey(morphType))
			{
				TSoftObjectPtr<UDataTable> dtCameraConfig = morphData.DtCameraConfig;
				string text = (dtCameraConfig != null) ? dtCameraConfig.ToAssetPathName() : null;
				if (string.IsNullOrEmpty(text) || text == "None")
				{
					return;
				}
				if (this.LoadingCameraConfigTypes == null)
				{
					this.LoadingCameraConfigTypes = new Dictionary<EMorphType, int>();
				}
				bool isLoadFinish = false;
				int value = ResourceSystem.Instance.LoadAsync<UDataTable>(text, delegate([Nullable(2)] UDataTable cameraConfig, string _)
				{
					isLoadFinish = true;
					if (cameraConfig != null)
					{
						Dictionary<EMorphType, IMorphData> morphDataMap = this.MorphDataMap;
						if (((morphDataMap != null) ? morphDataMap.GetValueOrDefault(morphType) : null) == morphData)
						{
							morphData.CameraConfig = cameraConfig;
							if (this.MorphType == morphType)
							{
								this.UpdateCameraConfig();
							}
						}
					}
					Dictionary<EMorphType, int> loadingCameraConfigTypes2 = this.LoadingCameraConfigTypes;
					if (loadingCameraConfigTypes2 == null)
					{
						return;
					}
					loadingCameraConfigTypes2.Remove(morphType);
				}, 100, "js_undefined");
				if (!isLoadFinish)
				{
					this.LoadingCameraConfigTypes.Add(morphType, value);
				}
				return;
			}
		}
	}

	// Token: 0x06018775 RID: 100213 RVA: 0x007640BC File Offset: 0x007622BC
	private void LoadBpInputCompForType(EMorphType morphType, IMorphData morphData)
	{
		if (morphData.InputComponent == null)
		{
			Dictionary<EMorphType, int> loadingBpInputTypes = this.LoadingBpInputTypes;
			if (loadingBpInputTypes == null || !loadingBpInputTypes.ContainsKey(morphType))
			{
				FSoftClassPath inputComponentClass2 = morphData.InputComponentClass;
				string text = (inputComponentClass2 != null) ? inputComponentClass2.AssetPathName.ToString() : null;
				if (string.IsNullOrEmpty(text))
				{
					return;
				}
				if (this.LoadingBpInputTypes == null)
				{
					this.LoadingBpInputTypes = new Dictionary<EMorphType, int>();
				}
				bool isLoadFinish = false;
				int value = ResourceSystem.Instance.LoadAsync<UClass>(text, delegate([Nullable(2)] UClass inputComponentClass, string _)
				{
					isLoadFinish = true;
					CharacterActorComponent actorComp = this.ActorComp;
					TsBaseCharacter tsBaseCharacter = (actorComp != null) ? actorComp.Actor : null;
					if (tsBaseCharacter != null)
					{
						BP_InputBase_C bp_InputBase_C = tsBaseCharacter.AddComponentByClass(inputComponentClass, false, MathUtils.Instance.DefaultTransform, false, default(FName)) as BP_InputBase_C;
						bp_InputBase_C.OwnerActor = tsBaseCharacter;
						morphData.InputComponent = bp_InputBase_C;
						if (this.MorphType == morphType && this.Entity.GetComponent<CharacterInputComponent>() != null)
						{
							CharacterInputLayer characterInputLayer = InputController.Instance.GetInputLayer(this.Entity.Id, EInputLayer.Character) as CharacterInputLayer;
							if (characterInputLayer != null)
							{
								characterInputLayer.SetBpInputComp(bp_InputBase_C);
							}
						}
					}
					Dictionary<EMorphType, int> loadingBpInputTypes2 = this.LoadingBpInputTypes;
					if (loadingBpInputTypes2 == null)
					{
						return;
					}
					loadingBpInputTypes2.Remove(morphType);
				}, 100, "js_undefined");
				if (!isLoadFinish)
				{
					this.LoadingBpInputTypes.Add(morphType, value);
				}
				return;
			}
		}
	}

	// Token: 0x06018776 RID: 100214 RVA: 0x00764190 File Offset: 0x00762390
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterMorphComponent characterMorphComponent = (CharacterMorphComponent)componentTemplate;
		this.MorphType = characterMorphComponent.MorphType;
		if (characterMorphComponent.MorphData == null)
		{
			this.MorphData = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MorphData), "MorphData"))
		{
			return false;
		}
		this.IsEnableMorphInternal = characterMorphComponent.IsEnableMorphInternal;
		if (characterMorphComponent.MorphDataMap == null)
		{
			this.MorphDataMap = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MorphDataMap), "MorphDataMap"))
		{
			return false;
		}
		if (characterMorphComponent.MorphModelIdMap == null)
		{
			this.MorphModelIdMap = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MorphModelIdMap), "MorphModelIdMap"))
		{
			return false;
		}
		if (characterMorphComponent.MorphAssetMap == null)
		{
			this.MorphAssetMap = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MorphAssetMap), "MorphAssetMap"))
		{
			return false;
		}
		if (characterMorphComponent.MorphMontageMapByName == null)
		{
			this.MorphMontageMapByName = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MorphMontageMapByName), "MorphMontageMapByName"))
		{
			return false;
		}
		if (characterMorphComponent.MorphMontagePathMapByName == null)
		{
			this.MorphMontagePathMapByName = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MorphMontagePathMapByName), "MorphMontagePathMapByName"))
		{
			return false;
		}
		if (characterMorphComponent.MorphMontagePathMap == null)
		{
			this.MorphMontagePathMap = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MorphMontagePathMap), "MorphMontagePathMap"))
		{
			return false;
		}
		if (characterMorphComponent.SubPathNameMorphTypeMap == null)
		{
			this.SubPathNameMorphTypeMap = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SubPathNameMorphTypeMap), "SubPathNameMorphTypeMap"))
		{
			return false;
		}
		if (characterMorphComponent.CreatureDataComp == null)
		{
			this.CreatureDataComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureDataComp), "CreatureDataComp"))
		{
			return false;
		}
		if (characterMorphComponent.RolePreloadComp == null)
		{
			this.RolePreloadComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.RolePreloadComp), "RolePreloadComp"))
		{
			return false;
		}
		if (characterMorphComponent.ActorComp == null)
		{
			this.ActorComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
		{
			return false;
		}
		if (characterMorphComponent.MoveComp == null)
		{
			this.MoveComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveComp), "MoveComp"))
		{
			return false;
		}
		if (characterMorphComponent.TagComp == null)
		{
			this.TagComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComp), "TagComp"))
		{
			return false;
		}
		if (characterMorphComponent.CharacterAnimationComp == null)
		{
			this.CharacterAnimationComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CharacterAnimationComp), "CharacterAnimationComp"))
		{
			return false;
		}
		if (characterMorphComponent.CharacterFloatingComp == null)
		{
			this.CharacterFloatingComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CharacterFloatingComp), "CharacterFloatingComp"))
		{
			return false;
		}
		if (characterMorphComponent.MorphTagListenTasks == null)
		{
			this.MorphTagListenTasks = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MorphTagListenTasks), "MorphTagListenTasks"))
		{
			return false;
		}
		this.IsBackupBpCompParams = characterMorphComponent.IsBackupBpCompParams;
		this.IsBackupDefaultCapsule = characterMorphComponent.IsBackupDefaultCapsule;
		if (characterMorphComponent.LoadingBpInputTypes == null)
		{
			this.LoadingBpInputTypes = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LoadingBpInputTypes), "LoadingBpInputTypes"))
		{
			return false;
		}
		if (characterMorphComponent.LoadingMovementDataTypes == null)
		{
			this.LoadingMovementDataTypes = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LoadingMovementDataTypes), "LoadingMovementDataTypes"))
		{
			return false;
		}
		if (characterMorphComponent.LoadingCameraConfigTypes == null)
		{
			this.LoadingCameraConfigTypes = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LoadingCameraConfigTypes), "LoadingCameraConfigTypes"))
		{
			return false;
		}
		if (characterMorphComponent.CurrentCameraConfig == null)
		{
			this.CurrentCameraConfig = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CurrentCameraConfig), "CurrentCameraConfig"))
		{
			return false;
		}
		if (characterMorphComponent.TempVector == null)
		{
			this.TempVector = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempVector), "TempVector"))
		{
			return false;
		}
		this.DefaultRadiusInternal = characterMorphComponent.DefaultRadiusInternal;
		this.DefaultHalfHeightInternal = characterMorphComponent.DefaultHalfHeightInternal;
		if (characterMorphComponent.DefaultAdjustableCapsuleParams == null)
		{
			this.DefaultAdjustableCapsuleParams = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DefaultAdjustableCapsuleParams), "DefaultAdjustableCapsuleParams"))
		{
			return false;
		}
		if (characterMorphComponent.DefaultAdjustableCapsuleStringParams == null)
		{
			this.DefaultAdjustableCapsuleStringParams = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DefaultAdjustableCapsuleStringParams), "DefaultAdjustableCapsuleStringParams"))
		{
			return false;
		}
		return true;
	}

	// Token: 0x17002679 RID: 9849
	// (get) Token: 0x06018777 RID: 100215 RVA: 0x007645D5 File Offset: 0x007627D5
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700267A RID: 9850
	// (get) Token: 0x06018778 RID: 100216 RVA: 0x007645D8 File Offset: 0x007627D8
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0601877A RID: 100218 RVA: 0x007645E4 File Offset: 0x007627E4
	// Note: this type is marked as 'beforefieldinit'.
	static CharacterMorphComponent()
	{
		Dictionary<int, EMorphType> dictionary = new Dictionary<int, EMorphType>();
		int key = GameplayTagDefine.EGameplayTagId["角色.Common.角色形态.变装变身形态1"];
		dictionary[key] = EMorphType.变身形态;
		int key2 = GameplayTagDefine.EGameplayTagId["角色.Common.角色形态.变装变身形态2"];
		dictionary[key2] = EMorphType.变身形态2;
		CharacterMorphComponent.morphTagTypeMap = dictionary;
		CharacterMorphComponent.StatOnSetMorphType = Stat.Create("[CharacterMorphComponent]SetMorphType", "", "");
		CharacterMorphComponent.StatOnUpdateModel = Stat.Create("[CharacterMorphComponent]UpdateModel", "", "");
		CharacterMorphComponent.StatOnUpdateMovement = Stat.Create("[CharacterMorphComponent]UpdateMovement", "", "");
		CharacterMorphComponent.StatOnUpdateComponents = Stat.Create("[CharacterMorphComponent]UpdateComponents", "", "");
	}

	// Token: 0x0400D312 RID: 54034
	private const string CAPSULE_COMPONENT = "胶囊体组件";

	// Token: 0x0400D313 RID: 54035
	private const string CAPSULE_HALF_HEIGHT = "胶囊体半高";

	// Token: 0x0400D314 RID: 54036
	private const string CAPSULE_RADIUS = "胶囊体半径";

	// Token: 0x0400D315 RID: 54037
	private const string MESH_COMPONENT = "网格体";

	// Token: 0x0400D316 RID: 54038
	private const string MESH_LOCATION = "位置";

	// Token: 0x0400D317 RID: 54039
	private const string MOVE_COMPONENT = "角色移动";

	// Token: 0x0400D318 RID: 54040
	private const string MOVE_MAX_STEP_HEIGHT = "最大步高";

	// Token: 0x0400D319 RID: 54041
	private const string MOVE_WALKABLE_FLOOR_ANGLE = "可行走地面角度";

	// Token: 0x0400D31A RID: 54042
	private const string MOVE_MAINTAIN_HORIZONTAL_GROUND_VELOCITY = "维持水平地面速度";

	// Token: 0x0400D31B RID: 54043
	private const string MOVE_DEFAULT_WATER_MOVEMENT_MODE = "默认水中运动模式";

	// Token: 0x0400D31C RID: 54044
	private const string MESH_ADJUSTABLE_CAPSULE = "网格体#可变胶囊体碰撞";

	// Token: 0x0400D31D RID: 54045
	private const string CAPSULE_ADD_RADIUS = "AddRadius";

	// Token: 0x0400D31E RID: 54046
	private const string CAPSULE_MIN_RADIUS = "MinRadius";

	// Token: 0x0400D31F RID: 54047
	private const string CAPSULE_MAX_RADIUS = "MaxRadius";

	// Token: 0x0400D320 RID: 54048
	private const string CAPSULE_BIND_SOCKET_NAMES = "BindSocketNames";

	// Token: 0x0400D321 RID: 54049
	private const bool IS_ENABLE_OPTIMIZE = true;

	// Token: 0x0400D322 RID: 54050
	[StaticVariableRuleIgnore]
	private static readonly Dictionary<int, EMorphType> morphTagTypeMap;

	// Token: 0x0400D323 RID: 54051
	[StaticVariableRuleIgnore]
	private static readonly Stat StatOnSetMorphType;

	// Token: 0x0400D324 RID: 54052
	[StaticVariableRuleIgnore]
	private static readonly Stat StatOnUpdateModel;

	// Token: 0x0400D325 RID: 54053
	[StaticVariableRuleIgnore]
	private static readonly Stat StatOnUpdateMovement;

	// Token: 0x0400D326 RID: 54054
	[StaticVariableRuleIgnore]
	private static readonly Stat StatOnUpdateComponents;

	// Token: 0x0400D327 RID: 54055
	private EMorphType MorphType;

	// Token: 0x0400D328 RID: 54056
	[Nullable(2)]
	private IMorphData MorphData;

	// Token: 0x0400D329 RID: 54057
	private bool IsEnableMorphInternal;

	// Token: 0x0400D32A RID: 54058
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<EMorphType, IMorphData> MorphDataMap;

	// Token: 0x0400D32B RID: 54059
	[Nullable(2)]
	private Dictionary<EMorphType, int> MorphModelIdMap;

	// Token: 0x0400D32C RID: 54060
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<EMorphType, AssetElement> MorphAssetMap;

	// Token: 0x0400D32D RID: 54061
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private Dictionary<EMorphType, Dictionary<string, UAnimMontage>> MorphMontageMapByName;

	// Token: 0x0400D32E RID: 54062
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private Dictionary<EMorphType, Dictionary<string, string>> MorphMontagePathMapByName;

	// Token: 0x0400D32F RID: 54063
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<string, EMorphType> MorphMontagePathMap;

	// Token: 0x0400D330 RID: 54064
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<string, EMorphType> SubPathNameMorphTypeMap;

	// Token: 0x0400D331 RID: 54065
	[Nullable(2)]
	private CreatureDataComponent CreatureDataComp;

	// Token: 0x0400D332 RID: 54066
	[Nullable(2)]
	private RolePreloadComponent RolePreloadComp;

	// Token: 0x0400D333 RID: 54067
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x0400D334 RID: 54068
	[Nullable(2)]
	private CharacterMoveComponent MoveComp;

	// Token: 0x0400D335 RID: 54069
	[Nullable(2)]
	private BaseTagComponent TagComp;

	// Token: 0x0400D336 RID: 54070
	[Nullable(2)]
	private CharacterAnimationComponent CharacterAnimationComp;

	// Token: 0x0400D337 RID: 54071
	[Nullable(2)]
	private CharacterFloatingComponent CharacterFloatingComp;

	// Token: 0x0400D338 RID: 54072
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ITagTask> MorphTagListenTasks;

	// Token: 0x0400D339 RID: 54073
	private bool IsBackupBpCompParams;

	// Token: 0x0400D33A RID: 54074
	private bool IsBackupDefaultCapsule;

	// Token: 0x0400D33B RID: 54075
	[Nullable(2)]
	private Dictionary<EMorphType, int> LoadingBpInputTypes;

	// Token: 0x0400D33C RID: 54076
	[Nullable(2)]
	private Dictionary<EMorphType, int> LoadingMovementDataTypes;

	// Token: 0x0400D33D RID: 54077
	[Nullable(2)]
	private Dictionary<EMorphType, int> LoadingCameraConfigTypes;

	// Token: 0x0400D33E RID: 54078
	[Nullable(2)]
	private UDataTable CurrentCameraConfig;

	// Token: 0x0400D33F RID: 54079
	[Nullable(2)]
	private Vector TempVector;

	// Token: 0x0400D340 RID: 54080
	private float DefaultRadiusInternal;

	// Token: 0x0400D341 RID: 54081
	private float DefaultHalfHeightInternal;

	// Token: 0x0400D342 RID: 54082
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private Dictionary<string, Dictionary<string, float>> DefaultAdjustableCapsuleParams;

	// Token: 0x0400D343 RID: 54083
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1,
		1
	})]
	private Dictionary<string, Dictionary<string, string>> DefaultAdjustableCapsuleStringParams;
}
