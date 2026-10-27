using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.CreatureTools;
using AkiClient.Game.Aki.Data.Entity.Struct;
using UnrealEngine;
using UnrealEngine.Extension;

// Token: 0x020034A8 RID: 13480
[NullableContext(1)]
[Nullable(0)]
public class ActorUtils
{
	// Token: 0x0601D591 RID: 120209 RVA: 0x0082E398 File Offset: 0x0082C598
	[return: Nullable(2)]
	public static AActor LoadActorByModelConfig(SModelConfig modelConfig, FTransformDouble transform)
	{
		FName assetPathName = modelConfig.蓝图.GetAssetPathName();
		if (assetPathName == FName.NAME_None)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.World;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "[ActorUtils.LoadActorByModelConfig] 加载Actor失败，因为模型的蓝图没有设置。";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ModelId", modelConfig.ID);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		UClass loadedAsset = ResourceSystem.Instance.GetLoadedAsset<UClass>(assetPathName.ToString());
		if (loadedAsset == null || !loadedAsset.IsValid())
		{
			return null;
		}
		AActor aactor;
		if (loadedAsset.IsChildOf(TsBaseItem.StaticClass()))
		{
			aactor = ActorSystem.Instance.Get(loadedAsset.ClassStackOnlyPtr, transform, null, true);
		}
		else
		{
			aactor = ActorSystem.Instance.Spawn(loadedAsset.ClassStackOnlyPtr, transform, null);
		}
		if (aactor != null && aactor.IsValid())
		{
			aactor.SetActorHiddenInGame(true);
			aactor.SetActorTickEnabled(false);
			aactor.SetActorEnableCollision(false);
		}
		return aactor;
	}

	// Token: 0x0601D592 RID: 120210 RVA: 0x0082E474 File Offset: 0x0082C674
	[return: Nullable(2)]
	public unsafe static AActor LoadActorByPath(string assetPathName, in FTransformDouble transform, int PbDataId)
	{
		if (string.IsNullOrEmpty(assetPathName) || assetPathName == "None")
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.World;
			ELogAuthor author = ELogAuthor.YZH;
			string message = "[ActorUtils.LoadActorByPath] 加载Actor失败，因为模型的蓝图没有设置。";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Path", assetPathName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EntityConfigId", PbDataId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return null;
		}
		UClass loadedAsset = ResourceSystem.Instance.GetLoadedAsset<UClass>(assetPathName);
		if (loadedAsset == null || !loadedAsset.IsValid())
		{
			return null;
		}
		AActor aactor;
		if (loadedAsset.IsChildOf(TsBaseItem.StaticClass()))
		{
			aactor = ActorSystem.Instance.Get(loadedAsset.ClassStackOnlyPtr, transform, null, true);
		}
		else
		{
			aactor = ActorSystem.Instance.Spawn(loadedAsset.ClassStackOnlyPtr, transform, null);
		}
		if (aactor != null && aactor.IsValid())
		{
			aactor.SetActorHiddenInGame(true);
			aactor.SetActorTickEnabled(false);
			aactor.SetActorEnableCollision(false);
		}
		return aactor;
	}

	// Token: 0x0601D593 RID: 120211 RVA: 0x0082E570 File Offset: 0x0082C770
	public static void LoadAndChangeMeshAnim(USkeletalMeshComponent meshComp, TSoftObjectPtr<USkeletalMesh> meshClass, TSoftClassPtr<UAnimInstance> animBlueprintClass)
	{
		string text = meshClass.ToAssetPathName();
		if (!string.IsNullOrEmpty(text) && text != "None")
		{
			USkeletalMesh loadedAsset = ResourceSystem.Instance.GetLoadedAsset<USkeletalMesh>(text);
			if (loadedAsset != null && meshComp.SkeletalMesh != loadedAsset)
			{
				meshComp.SetSkeletalMesh(loadedAsset, true);
			}
		}
		string text2 = animBlueprintClass.ToAssetPathName();
		if (!string.IsNullOrEmpty(text2) && text2 != "None")
		{
			UClass loadedAsset2 = ResourceSystem.Instance.GetLoadedAsset<UClass>(text2);
			if (loadedAsset2 != null && meshComp.AnimClass.Get() != loadedAsset2.ToClassStackOnlyPtr())
			{
				meshComp.SetAnimClass(loadedAsset2.ToClassStackOnlyPtr());
			}
		}
	}

	// Token: 0x0601D594 RID: 120212 RVA: 0x0082E60C File Offset: 0x0082C80C
	[NullableContext(2)]
	public static EntityHandle GetEntityByActor(AActor actor, bool showLog = true)
	{
		IBPI_CreatureInterface_C ibpi_CreatureInterface_C = actor as IBPI_CreatureInterface_C;
		if (ibpi_CreatureInterface_C == null)
		{
			if (showLog)
			{
				Log.Instance.Error(ELogModule.World, ELogAuthor.YZ, "[WorldBridge.GetEntityByActor] Actor未实现接口CreatureInterface", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return null;
		}
		return CreatureModel.Instance.GetEntityById(ibpi_CreatureInterface_C.GetEntityId());
	}

	// Token: 0x0601D595 RID: 120213 RVA: 0x0082E654 File Offset: 0x0082C854
	[NullableContext(2)]
	public static FName? TryGetBoneSocket(AActor actor, string targetSocket)
	{
		if (actor != null && actor.IsValid())
		{
			USkeletalMeshComponent uskeletalMeshComponent = actor.GetComponentByClass(USkeletalMeshComponent.StaticClass()) as USkeletalMeshComponent;
			if (uskeletalMeshComponent != null && uskeletalMeshComponent.IsValid())
			{
				FName? dynamicFName = FNameUtil.GetDynamicFName(targetSocket);
				if (dynamicFName != null && (uskeletalMeshComponent.DoesSocketExist(dynamicFName.Value) || uskeletalMeshComponent.GetBoneIndex(dynamicFName.Value) != -1))
				{
					return dynamicFName;
				}
			}
		}
		return null;
	}
}
