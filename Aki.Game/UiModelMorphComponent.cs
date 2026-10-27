using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Entity.Struct;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02002C91 RID: 11409
[NullableContext(2)]
[Nullable(0)]
public class UiModelMorphComponent : UiModelComponentBase
{
	// Token: 0x06017D7C RID: 97660 RVA: 0x00610667 File Offset: 0x0060E867
	protected override void OnStart()
	{
		this.UiModelDataComponent = base.Owner.CheckGetComponent<UiModelDataComponent>();
		this.UiModelActorComponent = base.Owner.CheckGetComponent<UiModelActorComponent>();
	}

	// Token: 0x06017D7D RID: 97661 RVA: 0x0061068B File Offset: 0x0060E88B
	protected override void OnEnd()
	{
		this.MorphType = EUiModelMorphType.默认形态;
		this.MorphDataMap = null;
		this.MorphIdMap = null;
		this.UiModelDataComponent = null;
		this.UiModelActorComponent = null;
		this.IsEnableMorphInternal = false;
	}

	// Token: 0x06017D7E RID: 97662 RVA: 0x006106B7 File Offset: 0x0060E8B7
	public EUiModelMorphType GetMorphType()
	{
		return this.MorphType;
	}

	// Token: 0x06017D7F RID: 97663 RVA: 0x006106C0 File Offset: 0x0060E8C0
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

	// Token: 0x06017D80 RID: 97664 RVA: 0x0061080C File Offset: 0x0060EA0C
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

	// Token: 0x06017D81 RID: 97665 RVA: 0x0061083B File Offset: 0x0060EA3B
	protected virtual void PreloadMorphId()
	{
		this.MorphIdMap = null;
		this.IsEnableMorphInternal = false;
	}

	// Token: 0x06017D82 RID: 97666 RVA: 0x0061084C File Offset: 0x0060EA4C
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

	// Token: 0x06017D83 RID: 97667 RVA: 0x00610A90 File Offset: 0x0060EC90
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public virtual List<string> GetAllMorphPathList()
	{
		return null;
	}

	// Token: 0x06017D84 RID: 97668 RVA: 0x00610A93 File Offset: 0x0060EC93
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public virtual List<IUiMorphId> GetSpecialMorphIdList()
	{
		return null;
	}

	// Token: 0x06017D85 RID: 97669 RVA: 0x00610A96 File Offset: 0x0060EC96
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

	// Token: 0x06017D86 RID: 97670 RVA: 0x00610ACC File Offset: 0x0060ECCC
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

	// Token: 0x0400B1C7 RID: 45511
	protected EUiModelMorphType MorphType;

	// Token: 0x0400B1C8 RID: 45512
	protected bool IsEnableMorphInternal;

	// Token: 0x0400B1C9 RID: 45513
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected Dictionary<EUiModelMorphType, IUiMorphData> MorphDataMap;

	// Token: 0x0400B1CA RID: 45514
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected Dictionary<EUiModelMorphType, IUiMorphId> MorphIdMap;

	// Token: 0x0400B1CB RID: 45515
	protected UiModelDataComponent UiModelDataComponent;

	// Token: 0x0400B1CC RID: 45516
	protected UiModelActorComponent UiModelActorComponent;
}
