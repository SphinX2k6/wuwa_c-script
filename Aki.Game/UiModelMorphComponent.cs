using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Entity.Struct;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x020021EA RID: 8682
[NullableContext(2)]
[Nullable(0)]
public class UiModelMorphComponent : UiModelComponentBase
{
	// Token: 0x060155F0 RID: 87536 RVA: 0x00636207 File Offset: 0x00634407
	protected override void OnStart()
	{
		this.UiModelDataComponent = base.Owner.CheckGetComponent<UiModelDataComponent>();
		this.UiModelActorComponent = base.Owner.CheckGetComponent<UiModelActorComponent>();
	}

	// Token: 0x060155F1 RID: 87537 RVA: 0x0063622B File Offset: 0x0063442B
	protected override void OnEnd()
	{
		this.MorphType = EUiModelMorphType.默认形态;
		this.MorphDataMap = null;
		this.MorphIdMap = null;
		this.UiModelDataComponent = null;
		this.UiModelActorComponent = null;
		this.IsEnableMorphInternal = false;
	}

	// Token: 0x060155F2 RID: 87538 RVA: 0x00636257 File Offset: 0x00634457
	public EUiModelMorphType GetMorphType()
	{
		return this.MorphType;
	}

	// Token: 0x060155F3 RID: 87539 RVA: 0x00636260 File Offset: 0x00634460
	public unsafe bool SetMorphType(EUiModelMorphType morphType)
	{
		if (!this.IsEnableMorphInternal)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiModelMorph;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "该角色不支持多形态";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roleId", this.UiModelDataComponent.ModelConfigId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		if (this.MorphType == morphType)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.UiModelMorph;
			ELogAuthor author2 = ELogAuthor.LRC;
			string message2 = "当前形态与目标形态相同";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("morphType", morphType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("this.MorphType", this.MorphType);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		this.MorphType = morphType;
		if (this.MorphDataMap == null)
		{
			return false;
		}
		IUiMorphData uiMorphData;
		if (!this.MorphDataMap.TryGetValue(morphType, out uiMorphData))
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.UiModelMorph;
			ELogAuthor author3 = ELogAuthor.LRC;
			string message3 = "[UiModelMorphComponent]初始化获取morphData有误";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("MorphType", morphType);
			instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return false;
		}
		UiModelActorComponent uiModelActorComponent = this.UiModelActorComponent;
		if (uiModelActorComponent != null)
		{
			uiModelActorComponent.ChangeMesh(uiMorphData.MainSkeletalMesh, uiMorphData.AnimClass, uiMorphData.ChildSkeletalMesh, uiMorphData.DecorationParamList, 0);
		}
		EventSystem.Instance.EmitWithTarget(base.Owner, EEventName.OnUiModelSetMorphTypeComplete);
		return true;
	}

	// Token: 0x060155F4 RID: 87540 RVA: 0x006363AC File Offset: 0x006345AC
	public IUiMorphData GetCurrentMorphData()
	{
		if (this.MorphDataMap == null)
		{
			return null;
		}
		IUiMorphData result;
		if (this.MorphDataMap.TryGetValue(this.MorphType, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x060155F5 RID: 87541 RVA: 0x006363DB File Offset: 0x006345DB
	protected virtual void PreloadMorphId()
	{
		this.MorphIdMap = null;
		this.IsEnableMorphInternal = false;
	}

	// Token: 0x060155F6 RID: 87542 RVA: 0x006363EC File Offset: 0x006345EC
	public void PreloadMorphData()
	{
		this.PreloadMorphId();
		if (this.MorphIdMap == null)
		{
			return;
		}
		if (this.MorphDataMap != null)
		{
			this.MorphDataMap.Clear();
			this.MorphDataMap = null;
		}
		Dictionary<EUiModelMorphType, IUiMorphData> dictionary = new Dictionary<EUiModelMorphType, IUiMorphData>();
		foreach (KeyValuePair<EUiModelMorphType, IUiMorphId> keyValuePair in this.MorphIdMap)
		{
			EUiModelMorphType key = keyValuePair.Key;
			IUiMorphId value = keyValuePair.Value;
			if (!string.IsNullOrEmpty(value.MainMeshPath) && !string.IsNullOrEmpty(value.AnimPath))
			{
				string mainMeshPath = value.MainMeshPath;
				string animPath = value.AnimPath;
				List<string> childMeshPathList = value.ChildMeshPathList;
				TArray<SModelDecorationConfig> decorationMeshConfigArray = value.DecorationMeshConfigArray;
				USkeletalMesh loadedAsset = ResourceSystem.Instance.GetLoadedAsset<USkeletalMesh>(mainMeshPath);
				if (loadedAsset == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.UiModelMorph;
					ELogAuthor author = ELogAuthor.LRC;
					string message = "[UiRoleMorphComponent]获取mainMesh失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MainMeshPath", mainMeshPath);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				UClass loadedAsset2 = ResourceSystem.Instance.GetLoadedAsset<UClass>(animPath);
				if (loadedAsset2 == null)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.UiModelMorph;
					ELogAuthor author2 = ELogAuthor.LRC;
					string message2 = "[UiRoleMorphComponent]获取animClass失败";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("AnimClassPath", animPath);
					instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				}
				List<USkeletalMesh> list = null;
				if (childMeshPathList != null)
				{
					list = new List<USkeletalMesh>();
					foreach (string text in childMeshPathList)
					{
						USkeletalMesh loadedAsset3 = ResourceSystem.Instance.GetLoadedAsset<USkeletalMesh>(text);
						if (loadedAsset3 == null)
						{
							Log instance3 = Log.Instance;
							ELogModule module3 = ELogModule.UiModelMorph;
							ELogAuthor author3 = ELogAuthor.LRC;
							string message3 = "[UiRoleMorphComponent]获取childMesh失败";
							ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("ChildMeshPath", text);
							instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
						}
						else
						{
							list.Add(loadedAsset3);
						}
					}
				}
				UiMorphData value2 = new UiMorphData
				{
					MainSkeletalMesh = loadedAsset,
					AnimClass = loadedAsset2,
					ChildSkeletalMesh = list,
					DecorationParamList = this.GetModelMeshDecorationList(decorationMeshConfigArray),
					RoleBody = value.RoleBody
				};
				dictionary[key] = value2;
			}
		}
		this.MorphDataMap = dictionary;
		this.MorphType = EUiModelMorphType.默认形态;
	}

	// Token: 0x060155F7 RID: 87543 RVA: 0x00636630 File Offset: 0x00634830
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public virtual List<string> GetAllMorphPathList()
	{
		return null;
	}

	// Token: 0x060155F8 RID: 87544 RVA: 0x00636633 File Offset: 0x00634833
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public virtual List<IUiMorphId> GetSpecialMorphIdList()
	{
		return null;
	}

	// Token: 0x060155F9 RID: 87545 RVA: 0x00636636 File Offset: 0x00634836
	public void ClearData()
	{
		if (this.MorphDataMap != null)
		{
			this.MorphDataMap.Clear();
		}
		if (this.MorphIdMap != null)
		{
			this.MorphIdMap.Clear();
		}
		this.MorphDataMap = null;
		this.MorphIdMap = null;
	}

	// Token: 0x060155FA RID: 87546 RVA: 0x0063666C File Offset: 0x0063486C
	[NullableContext(1)]
	public List<UiModelDecorationParam> GetModelMeshDecorationList(TArray<SModelDecorationConfig> configArray)
	{
		int num = configArray.Num();
		List<UiModelDecorationParam> list = new List<UiModelDecorationParam>();
		if (num > 0)
		{
			for (int i = 0; i < num; i++)
			{
				SModelDecorationConfig smodelDecorationConfig = configArray.Get(i);
				string text = smodelDecorationConfig.SkeletalMesh.ToAssetPathName();
				USkeletalMesh loadedAsset = ResourceSystem.Instance.GetLoadedAsset<USkeletalMesh>(text);
				if (loadedAsset == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.UiModelMorph;
					ELogAuthor author = ELogAuthor.BB;
					string message = "[UiRoleMorphComponent]获取decorationMesh失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("DecorationMeshPath", text);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					UiModelDecorationParam item = new UiModelDecorationParam
					{
						SocketName = smodelDecorationConfig.SocketName,
						Transform = smodelDecorationConfig.Transform,
						SkeletalMesh = loadedAsset
					};
					list.Add(item);
				}
			}
		}
		return list;
	}

	// Token: 0x0400B532 RID: 46386
	protected EUiModelMorphType MorphType;

	// Token: 0x0400B533 RID: 46387
	protected bool IsEnableMorphInternal;

	// Token: 0x0400B534 RID: 46388
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected Dictionary<EUiModelMorphType, IUiMorphData> MorphDataMap;

	// Token: 0x0400B535 RID: 46389
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected Dictionary<EUiModelMorphType, IUiMorphId> MorphIdMap;

	// Token: 0x0400B536 RID: 46390
	protected UiModelDataComponent UiModelDataComponent;

	// Token: 0x0400B537 RID: 46391
	protected UiModelActorComponent UiModelActorComponent;
}
