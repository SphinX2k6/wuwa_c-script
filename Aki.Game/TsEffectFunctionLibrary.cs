using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Data.Effect.Struct;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.Data;
using CSharpScript.Game.Effect;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200026E RID: 622
[UClass("/Game/Aki/TypeScript/Game/Effect/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Effect/TsEffectFunctionLibrary.TsEffectFunctionLibrary_C")]
public class TsEffectFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
{
	// Token: 0x060025EF RID: 9711 RVA: 0x000E33B4 File Offset: 0x000E15B4
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public unsafe static int SpawnEffect(UObject worldContext, UObject callObject, string path, FTransformDouble transform, string reason, EEffectPlay playType, bool disablePostProcess = false)
	{
		if (callObject == null || !callObject.IsValid())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderEffect;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "TsEffectFunctionLibrary.SpawnEffect失败，因为CallObject无效";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Path", path);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Reason", reason);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return 0;
		}
		if (string.IsNullOrEmpty(reason))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Entity;
			ELogAuthor author2 = ELogAuthor.LFJW;
			string message2 = "TsEffectFunctionLibrary.SpawnEffectWithActor的Reason不能使用undefined";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("蓝图对象", callObject.GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Reason", reason);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			return 0;
		}
		if (reason.Length < 4)
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Entity;
			ELogAuthor author3 = ELogAuthor.LFJW;
			string message3 = "TsEffectFunctionLibrary.SpawnEffectWithActor的Reason字符串长度必须大于等于限制字符数量";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("蓝图对象", callObject.GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("Reason", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("限制的字符数量", 4);
			instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
			return 0;
		}
		string reason2 = "[蓝图:" + callObject.GetName() + "] " + reason;
		EffectSystem instance4 = EffectSystem.Instance;
		FTransformDouble? ftransformDouble = new FTransformDouble?(transform);
		int? num = new int?(instance4.SpawnEffect(worldContext, ftransformDouble, path, reason2, new EffectContext(null, callObject, disablePostProcess), global::EEffectType.Scene, null, null, null, false, false));
		return num.GetValueOrDefault();
	}

	// Token: 0x060025F0 RID: 9712 RVA: 0x000E355C File Offset: 0x000E175C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public unsafe static int SpawnEffectAttachToBone(UObject worldContext, UObject callObject, USkeletalMeshComponent skeletalMeshComponent, FName socketName, string path, FTransformDouble transform, string reason, EEffectPlay playType, bool disablePostProcess = false)
	{
		if (skeletalMeshComponent == null || !skeletalMeshComponent.IsValid())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderEffect;
			ELogAuthor author = ELogAuthor.ZJL;
			string message = "TsEffectFunctionLibrary.SpawnEffectAttachToBone失败，因为SkeletalMeshComponent无效";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Path", path);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Reason", reason);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return 0;
		}
		if (!skeletalMeshComponent.DoesSocketExist(socketName) && skeletalMeshComponent.GetBoneIndex(socketName) < 0)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.RenderEffect;
			ELogAuthor author2 = ELogAuthor.ZJL;
			string message2 = "TsEffectFunctionLibrary.SpawnEffectAttachToBone失败，因为SocketName无效";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Path", path);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("SocketName", socketName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("Reason", reason);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			return 0;
		}
		if (callObject == null || !callObject.IsValid())
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.RenderEffect;
			ELogAuthor author3 = ELogAuthor.ZJL;
			string message3 = "TsEffectFunctionLibrary.SpawnEffectAttachToBone失败，因为CallObject无效";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("Path", path);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("Reason", reason);
			instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
			return 0;
		}
		if (string.IsNullOrEmpty(reason))
		{
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.Entity;
			ELogAuthor author4 = ELogAuthor.ZJL;
			string message4 = "TsEffectFunctionLibrary.SpawnEffectAttachToBone的Reason不能使用undefined";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("蓝图对象", callObject.GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("Reason", reason);
			instance4.Error(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 2));
			return 0;
		}
		if (reason.Length < 4)
		{
			Log instance5 = Log.Instance;
			ELogModule module5 = ELogModule.Entity;
			ELogAuthor author5 = ELogAuthor.ZJL;
			string message5 = "TsEffectFunctionLibrary.SpawnEffectAttachToBone的Reason字符串长度必须大于等于限制字符数量";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray5 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 0) = new ValueTuple<string, object>("蓝图对象", callObject.GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 1) = new ValueTuple<string, object>("Reason", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 2) = new ValueTuple<string, object>("限制的字符数量", 4);
			instance5.Error(module5, author5, message5, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray5, 3));
			return 0;
		}
		string reason2 = "[蓝图:" + callObject.GetName() + "] " + reason;
		EffectSystem instance6 = EffectSystem.Instance;
		FTransformDouble? ftransformDouble = new FTransformDouble?(transform);
		int num = instance6.SpawnEffect(worldContext, ftransformDouble, path, reason2, new EffectContext(null, callObject, disablePostProcess), global::EEffectType.Scene, null, null, null, false, false);
		if (!EffectSystem.Instance.IsValid(num))
		{
			return 0;
		}
		EffectSystem.Instance.GetEffectActor(num).K2_AttachToComponent(skeletalMeshComponent, new FName?(socketName), EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, false);
		return num;
	}

	// Token: 0x060025F1 RID: 9713 RVA: 0x000E3810 File Offset: 0x000E1A10
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public unsafe static int SpawnEffectUI(UObject worldContext, UObject callObject, string path, FTransformDouble transform, string reason)
	{
		if (callObject == null || !callObject.IsValid())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderEffect;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "TsEffectFunctionLibrary.SpawnEffectUI失败，因为CallObject无效";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Path", path);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Reason", reason);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return 0;
		}
		if (string.IsNullOrEmpty(reason))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Entity;
			ELogAuthor author2 = ELogAuthor.LFJW;
			string message2 = "TsEffectFunctionLibrary.SpawnEffectUI的Reason不能使用undefined";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("蓝图对象", callObject.GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Reason", reason);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			return 0;
		}
		if (reason.Length < 4)
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Entity;
			ELogAuthor author3 = ELogAuthor.LFJW;
			string message3 = "TsEffectFunctionLibrary.SpawnEffectUI的Reason字符串长度必须大于等于限制字符数量";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("蓝图对象", callObject.GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("Reason", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("限制的字符数量", 4);
			instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
			return 0;
		}
		string reason2 = "[蓝图:" + callObject.GetName() + "] " + reason;
		EffectSystem instance4 = EffectSystem.Instance;
		FTransformDouble? ftransformDouble = new FTransformDouble?(transform);
		int? num = new int?(instance4.SpawnEffect(worldContext, ftransformDouble, path, reason2, new EffectContext(null, callObject, false), global::EEffectType.UiScene3D, null, null, null, false, false));
		return num.GetValueOrDefault();
	}

	// Token: 0x060025F2 RID: 9714 RVA: 0x000E39B8 File Offset: 0x000E1BB8
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public unsafe static int SpawnEffectWithActor(UObject worldContext, UObject callObject, AActor effectActor, string path, string reason, EEffectPlay playType, AkiClient.Game.Aki.Data.Effect.Struct.EEffectType effectType, bool disablePostProcess = false)
	{
		BP_EWorldType worldType = UKuroRenderingRuntimeBPPluginBPLibrary.GetWorldType(worldContext);
		if (worldType != BP_EWorldType.Editor && worldType != BP_EWorldType.EditorPreview)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderEffect;
			ELogAuthor author = ELogAuthor.CJH;
			string message = "TsEffectFunctionLibrary.SpawnEffectWithActor仅能于编辑时调用";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Path", path);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Reason", reason);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return 0;
		}
		if (effectActor == null || !effectActor.IsValid())
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.RenderEffect;
			ELogAuthor author2 = ELogAuthor.LFJW;
			string message2 = "TsEffectFunctionLibrary.SpawnEffectWithActor失败，因为effectActor参数无效";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Reason", reason);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return 0;
		}
		if (callObject == null || !callObject.IsValid())
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.RenderEffect;
			ELogAuthor author3 = ELogAuthor.LFJW;
			string message3 = "SpawnEffectWithActor失败，因为CallObject无效";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Actor", effectActor.GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Reason", reason);
			instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			return 0;
		}
		if (string.IsNullOrEmpty(reason))
		{
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.Entity;
			ELogAuthor author4 = ELogAuthor.LFJW;
			string message4 = "TsEffectFunctionLibrary.SpawnEffectWithActor的Reason不能使用undefined";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("蓝图对象", callObject.GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("Reason", reason);
			instance4.Error(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
			return 0;
		}
		if (reason.Length < 4)
		{
			Log instance5 = Log.Instance;
			ELogModule module5 = ELogModule.Entity;
			ELogAuthor author5 = ELogAuthor.LFJW;
			string message5 = "TsEffectFunctionLibrary.SpawnEffectWithActor的Reason字符串长度必须大于等于限制字符数量";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("蓝图对象", callObject.GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("Reason", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 2) = new ValueTuple<string, object>("限制的字符数量", 4);
			instance5.Error(module5, author5, message5, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 3));
			return 0;
		}
		string reason2 = "[蓝图:" + callObject.GetName() + "] " + reason;
		return EffectSystem.Instance.SpawnEffectWithActor(worldContext, effectActor, path, reason2, true, new EffectContext(null, callObject, disablePostProcess), false, (global::EEffectType)effectType);
	}

	// Token: 0x060025F3 RID: 9715 RVA: 0x000E3BE8 File Offset: 0x000E1DE8
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void InitializeWithPreview(bool refresh)
	{
		EffectSystem.Instance.InitializeWithPreview(refresh);
	}

	// Token: 0x060025F4 RID: 9716 RVA: 0x000E3BF5 File Offset: 0x000E1DF5
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool EffectHandleIsValid(int handle)
	{
		return EffectSystem.Instance.IsValid(handle);
	}

	// Token: 0x060025F5 RID: 9717 RVA: 0x000E3C04 File Offset: 0x000E1E04
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public unsafe static bool StopEffect(int handle, UObject callObject, string reason, bool immediately, bool destroyActor)
	{
		if (callObject == null || !callObject.IsValid())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderEffect;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "CallObject无效";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Reason", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Handle", handle);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		if (string.IsNullOrEmpty(reason))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Entity;
			ELogAuthor author2 = ELogAuthor.LFJW;
			string message2 = "TsEffectFunctionLibrary.StopEffect的Reason不能使用undefined";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("蓝图对象", callObject.GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Reason", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("Handle", handle);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			return false;
		}
		if (reason.Length < 4)
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Entity;
			ELogAuthor author3 = ELogAuthor.LFJW;
			string message3 = "TsEffectFunctionLibrary.StopEffect的Reason字符串长度必须大于等于限制字符数量";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("蓝图对象", callObject.GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("Reason", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("限制的字符数量", 4);
			instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
			return false;
		}
		if (handle == 0)
		{
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.RenderEffect;
			ELogAuthor author4 = ELogAuthor.LFJW;
			string message4 = "特效句柄无效";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("CallObject", callObject.GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("Reason", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 2) = new ValueTuple<string, object>("Handle", handle);
			instance4.Error(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 3));
			return false;
		}
		string reason2 = "[蓝图:" + callObject.GetName() + "] " + reason;
		return EffectSystem.Instance.StopEffectById(handle, reason2, immediately, null);
	}

	// Token: 0x060025F6 RID: 9718 RVA: 0x000E3E1C File Offset: 0x000E201C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public unsafe static bool StopAndDestroyEffect(int handle, UObject callObject, string reason, bool immediately)
	{
		if (callObject == null || !callObject.IsValid())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderEffect;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "CallObject无效";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Reason", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Handle", handle);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		if (string.IsNullOrEmpty(reason))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Entity;
			ELogAuthor author2 = ELogAuthor.LFJW;
			string message2 = "TsEffectFunctionLibrary.StopAndDestroyEffect的Reason不能使用undefined";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("蓝图对象", callObject.GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Reason", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("Handle", handle);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			return false;
		}
		if (reason.Length < 4)
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Entity;
			ELogAuthor author3 = ELogAuthor.LFJW;
			string message3 = "TsEffectFunctionLibrary.StopAndDestroyEffect的Reason字符串长度必须大于等于限制字符数量";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("蓝图对象", callObject.GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("Reason", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("限制的字符数量", 4);
			instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
			return false;
		}
		if (handle == 0)
		{
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.RenderEffect;
			ELogAuthor author4 = ELogAuthor.LWH;
			string message4 = "特效句柄无效";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("CallObject", callObject.GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("Reason", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 2) = new ValueTuple<string, object>("Handle", handle);
			instance4.Error(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 3));
			return false;
		}
		string reason2 = "[蓝图:" + callObject.GetName() + "] " + reason;
		return EffectSystem.Instance.StopEffectById(handle, reason2, immediately, new bool?(true));
	}

	// Token: 0x060025F7 RID: 9719 RVA: 0x000E4030 File Offset: 0x000E2230
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public unsafe static bool PlayEffect(int handle, UObject callObject, string reason)
	{
		if (callObject == null || !callObject.IsValid())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderEffect;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "CallObject无效";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Reason", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Handle", handle);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		if (string.IsNullOrEmpty(reason))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Entity;
			ELogAuthor author2 = ELogAuthor.LFJW;
			string message2 = "TsEffectFunctionLibrary.PlayEffect的Reason不能使用undefined";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("蓝图对象", callObject.GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Reason", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("Handle", handle);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			return false;
		}
		if (reason.Length < 4)
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Entity;
			ELogAuthor author3 = ELogAuthor.LFJW;
			string message3 = "TsEffectFunctionLibrary.PlayEffect的Reason字符串长度必须大于等于限制字符数量";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("蓝图对象", callObject.GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("Reason", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("限制的字符数量", 4);
			instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
			return false;
		}
		if (handle == 0)
		{
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.RenderEffect;
			ELogAuthor author4 = ELogAuthor.LFJW;
			string message4 = "特效句柄无效";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("CallObject", callObject.GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("Reason", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 2) = new ValueTuple<string, object>("Handle", handle);
			instance4.Error(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 3));
			return false;
		}
		return true;
	}

	// Token: 0x060025F8 RID: 9720 RVA: 0x000E4218 File Offset: 0x000E2418
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetEffectParameterNiagara(int handle, ref TArray<SEffectFloatParameter> userParameterFloat, ref TArray<SEffectColorParameter> userParameterColor, ref TArray<SEffectVectorParameter> userParameterVector, ref TArray<SEffectFloatParameter> materialParameterFloat, ref TArray<SEffectColorParameter> materialParameterColor)
	{
		if (handle == 0)
		{
			Log.Instance.Error(ELogModule.RenderEffect, ELogAuthor.LSY, "特效句柄无效", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		EffectParameterNiagara effectParameterNiagara = new EffectParameterNiagara();
		if (userParameterFloat != null)
		{
			TArray<SEffectFloatParameter> tarray = userParameterFloat;
			int num = tarray.Num();
			if (num > 0)
			{
				effectParameterNiagara.UserParameterFloat = new List<ValueTuple<FName, float>>();
				for (int i = 0; i < num; i++)
				{
					SEffectFloatParameter seffectFloatParameter = tarray.Get(i);
					effectParameterNiagara.UserParameterFloat.Add(new ValueTuple<FName, float>(seffectFloatParameter.Name, seffectFloatParameter.Value));
				}
			}
		}
		if (userParameterColor != null)
		{
			TArray<SEffectColorParameter> tarray2 = userParameterColor;
			int num2 = tarray2.Num();
			if (num2 > 0)
			{
				effectParameterNiagara.UserParameterColor = new List<ValueTuple<FName, FLinearColor>>();
				for (int j = 0; j < num2; j++)
				{
					SEffectColorParameter seffectColorParameter = tarray2.Get(j);
					effectParameterNiagara.UserParameterColor.Add(new ValueTuple<FName, FLinearColor>(seffectColorParameter.Name, seffectColorParameter.Value));
				}
			}
		}
		if (userParameterVector != null)
		{
			TArray<SEffectVectorParameter> tarray3 = userParameterVector;
			int num3 = tarray3.Num();
			if (num3 > 0)
			{
				effectParameterNiagara.UserParameterVector = new List<ValueTuple<FName, FVector>>();
				for (int k = 0; k < num3; k++)
				{
					SEffectVectorParameter seffectVectorParameter = tarray3.Get(k);
					effectParameterNiagara.UserParameterVector.Add(new ValueTuple<FName, FVector>(seffectVectorParameter.Name, seffectVectorParameter.Value));
				}
			}
		}
		if (materialParameterFloat != null)
		{
			TArray<SEffectFloatParameter> tarray4 = materialParameterFloat;
			int num4 = tarray4.Num();
			if (num4 > 0)
			{
				effectParameterNiagara.MaterialParameterFloat = new List<ValueTuple<FName, float>>();
				for (int l = 0; l < num4; l++)
				{
					SEffectFloatParameter seffectFloatParameter2 = tarray4.Get(l);
					effectParameterNiagara.MaterialParameterFloat.Add(new ValueTuple<FName, float>(seffectFloatParameter2.Name, seffectFloatParameter2.Value));
				}
			}
		}
		if (materialParameterColor != null)
		{
			TArray<SEffectColorParameter> tarray5 = materialParameterColor;
			int num5 = tarray5.Num();
			if (num5 > 0)
			{
				effectParameterNiagara.MaterialParameterColor = new List<ValueTuple<FName, FLinearColor>>();
				for (int m = 0; m < num5; m++)
				{
					SEffectColorParameter seffectColorParameter2 = tarray5.Get(m);
					effectParameterNiagara.MaterialParameterColor.Add(new ValueTuple<FName, FLinearColor>(seffectColorParameter2.Name, seffectColorParameter2.Value));
				}
			}
		}
		EffectSystem.Instance.SetEffectParameterNiagara(handle, effectParameterNiagara);
	}

	// Token: 0x060025F9 RID: 9721 RVA: 0x000E441C File Offset: 0x000E261C
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void EditorTickHandle(int handle, float delta)
	{
		EffectSystem.Instance.TickHandleInEditor(handle, delta);
	}

	// Token: 0x060025FA RID: 9722 RVA: 0x000E442A File Offset: 0x000E262A
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static AActor GetEffectActor(int handle)
	{
		return EffectSystem.Instance.GetSureEffectActor(handle);
	}

	// Token: 0x060025FB RID: 9723 RVA: 0x000E4438 File Offset: 0x000E2638
	public static bool? GetPlayType(EEffectPlay playType)
	{
		if (playType == EEffectPlay.Play)
		{
			return new bool?(true);
		}
		if (playType != EEffectPlay.DoNotPlay)
		{
			return null;
		}
		return new bool?(false);
	}

	// Token: 0x060025FC RID: 9724 RVA: 0x000E4468 File Offset: 0x000E2668
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void AttachEffectActorToActor(int handle, AActor parent, FName socketName, EAttachmentRule locationRule, EAttachmentRule rotationRule, EAttachmentRule scaleRule, bool bWeldSimulatedBodies)
	{
		if (!EffectSystem.Instance.IsValid(handle))
		{
			return;
		}
		if (parent == null)
		{
			return;
		}
		OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(handle);
		FName? fname = new FName?(socketName);
		effectActor.K2_AttachToActor(parent, fname, locationRule, rotationRule, scaleRule, bWeldSimulatedBodies);
	}

	// Token: 0x060025FD RID: 9725 RVA: 0x000E44A8 File Offset: 0x000E26A8
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void AttachEffectActorToComponent(int handle, USceneComponent parent, FName socketName, EAttachmentRule locationRule, EAttachmentRule rotationRule, EAttachmentRule scaleRule, bool bWeldSimulatedBodies)
	{
		if (!EffectSystem.Instance.IsValid(handle))
		{
			return;
		}
		if (parent == null)
		{
			return;
		}
		EffectSystem.Instance.GetEffectActor(handle).K2_AttachToComponent(parent, new FName?(socketName), locationRule, rotationRule, scaleRule, bWeldSimulatedBodies);
	}

	// Token: 0x060025FE RID: 9726 RVA: 0x000E44DA File Offset: 0x000E26DA
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetEffectActorRelativeLocation(int handle, FVectorDouble newRelativeLocation, bool bSweep, bool bTeleport)
	{
		if (!EffectSystem.Instance.IsValid(handle))
		{
			return;
		}
		EffectSystem.Instance.GetEffectActor(handle).D_K2_SetActorRelativeLocation(newRelativeLocation, bSweep, ref WorldGlobal.SweepHitResult, bTeleport);
	}

	// Token: 0x060025FF RID: 9727 RVA: 0x000E4503 File Offset: 0x000E2703
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetEffectHiddenInGame(int handle, bool value)
	{
		if (!EffectSystem.Instance.IsValid(handle))
		{
			return;
		}
		EffectSystem.Instance.SetEffectHidden(handle, value, "TsEffectFunctionLibrary.SetEffectHiddenInGame", false);
	}

	// Token: 0x06002600 RID: 9728 RVA: 0x000E4528 File Offset: 0x000E2728
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetEffectIgnoreVisibilityOptimize(int handle, bool ignore)
	{
		if (!EffectSystem.Instance.IsValid(handle))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderEffect;
			ELogAuthor author = ELogAuthor.WLJ;
			string message = "设置EffectIgnoreVisibilityOptimize，句柄失效";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("handle", handle);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		EffectSystem.Instance.SetEffectIgnoreVisibilityOptimize(handle, ignore);
	}

	// Token: 0x06002601 RID: 9729 RVA: 0x000E457C File Offset: 0x000E277C
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetEffectStoppingTime(int handle, bool stoppingTime)
	{
		if (!EffectSystem.Instance.IsValid(handle))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderEffect;
			ELogAuthor author = ELogAuthor.WLJ;
			string message = "设置EffectStoppingTime，句柄失效";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("handle", handle);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		EffectSystem.Instance.SetEffectStoppingTime(handle, stoppingTime, EEffectStoppingTimeSource.ScenePaused);
	}

	// Token: 0x06002602 RID: 9730 RVA: 0x000E45D0 File Offset: 0x000E27D0
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetGlobalStoppingTime(bool stoppingTime, float playTime)
	{
		EffectSystem.Instance.SetGlobalStoppingTime(stoppingTime, playTime, EEffectStoppingTimeSource.ScenePaused);
	}

	// Token: 0x06002603 RID: 9731 RVA: 0x000E45DF File Offset: 0x000E27DF
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetPublicToSequence(int handle, BP_EffectActor_C actor)
	{
	}

	// Token: 0x06002604 RID: 9732 RVA: 0x000E45E1 File Offset: 0x000E27E1
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetSimulateFromSequence(int handle, BP_EffectActor_C actor)
	{
	}

	// Token: 0x06002605 RID: 9733 RVA: 0x000E45E3 File Offset: 0x000E27E3
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsEffectFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Effect/TsEffectFunctionLibrary.TsEffectFunctionLibrary_C");
		}
		return TsEffectFunctionLibrary._ClassPtr;
	}

	// Token: 0x06002606 RID: 9734 RVA: 0x000E4608 File Offset: 0x000E2808
	public TsEffectFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(TsEffectFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06002607 RID: 9735 RVA: 0x000E4630 File Offset: 0x000E2830
	[NullableContext(1)]
	public TsEffectFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsEffectFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06002608 RID: 9736 RVA: 0x000E4663 File Offset: 0x000E2863
	protected TsEffectFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06002609 RID: 9737 RVA: 0x000E466C File Offset: 0x000E286C
	protected unsafe static void __CPPCALL_SpawnEffect_Implementation(TsEffectFunctionLibrary.__SpawnEffect_FunctionParams* __Params)
	{
		UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->worldContext);
		UObject orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->callObject);
		string path = FString.ToString((void*)(&__Params->path));
		string reason = FString.ToString((void*)(&__Params->reason));
		EEffectPlay playType = (EEffectPlay)__Params->playType;
		__Params->__Result = TsEffectFunctionLibrary.SpawnEffect(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, path, __Params->transform, reason, playType, __Params->disablePostProcess);
	}

	// Token: 0x0600260A RID: 9738 RVA: 0x000E46D0 File Offset: 0x000E28D0
	protected unsafe static void __CPPCALL_SpawnEffectAttachToBone_Implementation(TsEffectFunctionLibrary.__SpawnEffectAttachToBone_FunctionParams* __Params)
	{
		UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->worldContext);
		UObject orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->callObject);
		USkeletalMeshComponent orCreateUObjectByNativePointer3 = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->skeletalMeshComponent);
		string path = FString.ToString((void*)(&__Params->path));
		string reason = FString.ToString((void*)(&__Params->reason));
		EEffectPlay playType = (EEffectPlay)__Params->playType;
		__Params->__Result = TsEffectFunctionLibrary.SpawnEffectAttachToBone(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, orCreateUObjectByNativePointer3, __Params->socketName, path, __Params->transform, reason, playType, __Params->disablePostProcess);
	}

	// Token: 0x0600260B RID: 9739 RVA: 0x000E474C File Offset: 0x000E294C
	protected unsafe static void __CPPCALL_SpawnEffectUI_Implementation(TsEffectFunctionLibrary.__SpawnEffectUI_FunctionParams* __Params)
	{
		UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->worldContext);
		UObject orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->callObject);
		string path = FString.ToString((void*)(&__Params->path));
		string reason = FString.ToString((void*)(&__Params->reason));
		__Params->__Result = TsEffectFunctionLibrary.SpawnEffectUI(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, path, __Params->transform, reason);
	}

	// Token: 0x0600260C RID: 9740 RVA: 0x000E47A0 File Offset: 0x000E29A0
	protected unsafe static void __CPPCALL_SpawnEffectWithActor_Implementation(TsEffectFunctionLibrary.__SpawnEffectWithActor_FunctionParams* __Params)
	{
		UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->worldContext);
		UObject orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->callObject);
		AActor orCreateUObjectByNativePointer3 = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->effectActor);
		string path = FString.ToString((void*)(&__Params->path));
		string reason = FString.ToString((void*)(&__Params->reason));
		EEffectPlay playType = (EEffectPlay)__Params->playType;
		AkiClient.Game.Aki.Data.Effect.Struct.EEffectType effectType = (AkiClient.Game.Aki.Data.Effect.Struct.EEffectType)__Params->effectType;
		__Params->__Result = TsEffectFunctionLibrary.SpawnEffectWithActor(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, orCreateUObjectByNativePointer3, path, reason, playType, effectType, __Params->disablePostProcess);
	}

	// Token: 0x0600260D RID: 9741 RVA: 0x000E4817 File Offset: 0x000E2A17
	protected unsafe static void __CPPCALL_InitializeWithPreview_Implementation(TsEffectFunctionLibrary.__InitializeWithPreview_FunctionParams* __Params)
	{
		TsEffectFunctionLibrary.InitializeWithPreview(__Params->refresh);
	}

	// Token: 0x0600260E RID: 9742 RVA: 0x000E4824 File Offset: 0x000E2A24
	protected unsafe static void __CPPCALL_EffectHandleIsValid_Implementation(TsEffectFunctionLibrary.__EffectHandleIsValid_FunctionParams* __Params)
	{
		__Params->__Result = TsEffectFunctionLibrary.EffectHandleIsValid(__Params->handle);
	}

	// Token: 0x0600260F RID: 9743 RVA: 0x000E4838 File Offset: 0x000E2A38
	protected unsafe static void __CPPCALL_StopEffect_Implementation(TsEffectFunctionLibrary.__StopEffect_FunctionParams* __Params)
	{
		UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->callObject);
		string reason = FString.ToString((void*)(&__Params->reason));
		__Params->__Result = TsEffectFunctionLibrary.StopEffect(__Params->handle, orCreateUObjectByNativePointer, reason, __Params->immediately, __Params->destroyActor);
	}

	// Token: 0x06002610 RID: 9744 RVA: 0x000E4880 File Offset: 0x000E2A80
	protected unsafe static void __CPPCALL_StopAndDestroyEffect_Implementation(TsEffectFunctionLibrary.__StopAndDestroyEffect_FunctionParams* __Params)
	{
		UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->callObject);
		string reason = FString.ToString((void*)(&__Params->reason));
		__Params->__Result = TsEffectFunctionLibrary.StopAndDestroyEffect(__Params->handle, orCreateUObjectByNativePointer, reason, __Params->immediately);
	}

	// Token: 0x06002611 RID: 9745 RVA: 0x000E48C0 File Offset: 0x000E2AC0
	protected unsafe static void __CPPCALL_PlayEffect_Implementation(TsEffectFunctionLibrary.__PlayEffect_FunctionParams* __Params)
	{
		UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->callObject);
		string reason = FString.ToString((void*)(&__Params->reason));
		__Params->__Result = TsEffectFunctionLibrary.PlayEffect(__Params->handle, orCreateUObjectByNativePointer, reason);
	}

	// Token: 0x06002612 RID: 9746 RVA: 0x000E48FC File Offset: 0x000E2AFC
	protected unsafe static void __CPPCALL_SetEffectParameterNiagara_Implementation(TsEffectFunctionLibrary.__SetEffectParameterNiagara_FunctionParams* __Params)
	{
		TArray<SEffectFloatParameter> tarray = new TArray<SEffectFloatParameter>(&__Params->userParameterFloat, true, true);
		TArray<SEffectColorParameter> tarray2 = new TArray<SEffectColorParameter>(&__Params->userParameterColor, true, true);
		TArray<SEffectVectorParameter> tarray3 = new TArray<SEffectVectorParameter>(&__Params->userParameterVector, true, true);
		TArray<SEffectFloatParameter> tarray4 = new TArray<SEffectFloatParameter>(&__Params->materialParameterFloat, true, true);
		TArray<SEffectColorParameter> tarray5 = new TArray<SEffectColorParameter>(&__Params->materialParameterColor, true, true);
		TsEffectFunctionLibrary.SetEffectParameterNiagara(__Params->handle, ref tarray, ref tarray2, ref tarray3, ref tarray4, ref tarray5);
		if (tarray != null)
		{
			tarray.CopyTo(&__Params->userParameterFloat, default(UScriptStructStackOnlyPtr));
		}
		if (tarray2 != null)
		{
			tarray2.CopyTo(&__Params->userParameterColor, default(UScriptStructStackOnlyPtr));
		}
		if (tarray3 != null)
		{
			tarray3.CopyTo(&__Params->userParameterVector, default(UScriptStructStackOnlyPtr));
		}
		if (tarray4 != null)
		{
			tarray4.CopyTo(&__Params->materialParameterFloat, default(UScriptStructStackOnlyPtr));
		}
		if (tarray5 != null)
		{
			tarray5.CopyTo(&__Params->materialParameterColor, default(UScriptStructStackOnlyPtr));
		}
	}

	// Token: 0x06002613 RID: 9747 RVA: 0x000E49EE File Offset: 0x000E2BEE
	protected unsafe static void __CPPCALL_EditorTickHandle_Implementation(TsEffectFunctionLibrary.__EditorTickHandle_FunctionParams* __Params)
	{
		TsEffectFunctionLibrary.EditorTickHandle(__Params->handle, __Params->delta);
	}

	// Token: 0x06002614 RID: 9748 RVA: 0x000E4A01 File Offset: 0x000E2C01
	protected unsafe static void __CPPCALL_GetEffectActor_Implementation(TsEffectFunctionLibrary.__GetEffectActor_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		AActor effectActor = TsEffectFunctionLibrary.GetEffectActor(__Params->handle);
		ptr = ((effectActor != null) ? effectActor.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06002615 RID: 9749 RVA: 0x000E4A24 File Offset: 0x000E2C24
	protected unsafe static void __CPPCALL_AttachEffectActorToActor_Implementation(TsEffectFunctionLibrary.__AttachEffectActorToActor_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->parent);
		EAttachmentRule locationRule = (EAttachmentRule)__Params->locationRule;
		EAttachmentRule rotationRule = (EAttachmentRule)__Params->rotationRule;
		EAttachmentRule scaleRule = (EAttachmentRule)__Params->scaleRule;
		TsEffectFunctionLibrary.AttachEffectActorToActor(__Params->handle, orCreateUObjectByNativePointer, __Params->socketName, locationRule, rotationRule, scaleRule, __Params->bWeldSimulatedBodies);
	}

	// Token: 0x06002616 RID: 9750 RVA: 0x000E4A70 File Offset: 0x000E2C70
	protected unsafe static void __CPPCALL_AttachEffectActorToComponent_Implementation(TsEffectFunctionLibrary.__AttachEffectActorToComponent_FunctionParams* __Params)
	{
		USceneComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USceneComponent>(__Params->parent);
		EAttachmentRule locationRule = (EAttachmentRule)__Params->locationRule;
		EAttachmentRule rotationRule = (EAttachmentRule)__Params->rotationRule;
		EAttachmentRule scaleRule = (EAttachmentRule)__Params->scaleRule;
		TsEffectFunctionLibrary.AttachEffectActorToComponent(__Params->handle, orCreateUObjectByNativePointer, __Params->socketName, locationRule, rotationRule, scaleRule, __Params->bWeldSimulatedBodies);
	}

	// Token: 0x06002617 RID: 9751 RVA: 0x000E4AB9 File Offset: 0x000E2CB9
	protected unsafe static void __CPPCALL_SetEffectActorRelativeLocation_Implementation(TsEffectFunctionLibrary.__SetEffectActorRelativeLocation_FunctionParams* __Params)
	{
		TsEffectFunctionLibrary.SetEffectActorRelativeLocation(__Params->handle, __Params->newRelativeLocation, __Params->bSweep, __Params->bTeleport);
	}

	// Token: 0x06002618 RID: 9752 RVA: 0x000E4AD8 File Offset: 0x000E2CD8
	protected unsafe static void __CPPCALL_SetEffectHiddenInGame_Implementation(TsEffectFunctionLibrary.__SetEffectHiddenInGame_FunctionParams* __Params)
	{
		TsEffectFunctionLibrary.SetEffectHiddenInGame(__Params->handle, __Params->value);
	}

	// Token: 0x06002619 RID: 9753 RVA: 0x000E4AEB File Offset: 0x000E2CEB
	protected unsafe static void __CPPCALL_SetEffectIgnoreVisibilityOptimize_Implementation(TsEffectFunctionLibrary.__SetEffectIgnoreVisibilityOptimize_FunctionParams* __Params)
	{
		TsEffectFunctionLibrary.SetEffectIgnoreVisibilityOptimize(__Params->handle, __Params->ignore);
	}

	// Token: 0x0600261A RID: 9754 RVA: 0x000E4AFE File Offset: 0x000E2CFE
	protected unsafe static void __CPPCALL_SetEffectStoppingTime_Implementation(TsEffectFunctionLibrary.__SetEffectStoppingTime_FunctionParams* __Params)
	{
		TsEffectFunctionLibrary.SetEffectStoppingTime(__Params->handle, __Params->stoppingTime);
	}

	// Token: 0x0600261B RID: 9755 RVA: 0x000E4B11 File Offset: 0x000E2D11
	protected unsafe static void __CPPCALL_SetGlobalStoppingTime_Implementation(TsEffectFunctionLibrary.__SetGlobalStoppingTime_FunctionParams* __Params)
	{
		TsEffectFunctionLibrary.SetGlobalStoppingTime(__Params->stoppingTime, __Params->playTime);
	}

	// Token: 0x0600261C RID: 9756 RVA: 0x000E4B24 File Offset: 0x000E2D24
	protected unsafe static void __CPPCALL_SetPublicToSequence_Implementation(TsEffectFunctionLibrary.__SetPublicToSequence_FunctionParams* __Params)
	{
		BP_EffectActor_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_EffectActor_C>(__Params->actor);
		TsEffectFunctionLibrary.SetPublicToSequence(__Params->handle, orCreateUObjectByNativePointer);
	}

	// Token: 0x0600261D RID: 9757 RVA: 0x000E4B4C File Offset: 0x000E2D4C
	protected unsafe static void __CPPCALL_SetSimulateFromSequence_Implementation(TsEffectFunctionLibrary.__SetSimulateFromSequence_FunctionParams* __Params)
	{
		BP_EffectActor_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_EffectActor_C>(__Params->actor);
		TsEffectFunctionLibrary.SetSimulateFromSequence(__Params->handle, orCreateUObjectByNativePointer);
	}

	// Token: 0x04002485 RID: 9349
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Effect/TsEffectFunctionLibrary.TsEffectFunctionLibrary_C";

	// Token: 0x04002486 RID: 9350
	private static IntPtr _ClassPtr;

	// Token: 0x04002487 RID: 9351
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x02007456 RID: 29782
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 144)]
	protected ref struct __SpawnEffect_FunctionParams
	{
		// Token: 0x0402684F RID: 157775
		[FieldOffset(0)]
		public IntPtr worldContext;

		// Token: 0x04026850 RID: 157776
		[FieldOffset(8)]
		public IntPtr callObject;

		// Token: 0x04026851 RID: 157777
		[FieldOffset(16)]
		public FString path;

		// Token: 0x04026852 RID: 157778
		[FieldOffset(32)]
		public FTransformDouble transform;

		// Token: 0x04026853 RID: 157779
		[FieldOffset(96)]
		public FString reason;

		// Token: 0x04026854 RID: 157780
		[FieldOffset(112)]
		public byte playType;

		// Token: 0x04026855 RID: 157781
		[FieldOffset(113)]
		public bool disablePostProcess;

		// Token: 0x04026856 RID: 157782
		[FieldOffset(120)]
		public IntPtr __WorldContext;

		// Token: 0x04026857 RID: 157783
		[FieldOffset(128)]
		public int __Result;
	}

	// Token: 0x02007457 RID: 29783
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 176)]
	protected ref struct __SpawnEffectAttachToBone_FunctionParams
	{
		// Token: 0x04026858 RID: 157784
		[FieldOffset(0)]
		public IntPtr worldContext;

		// Token: 0x04026859 RID: 157785
		[FieldOffset(8)]
		public IntPtr callObject;

		// Token: 0x0402685A RID: 157786
		[FieldOffset(16)]
		public IntPtr skeletalMeshComponent;

		// Token: 0x0402685B RID: 157787
		[FieldOffset(24)]
		public FName socketName;

		// Token: 0x0402685C RID: 157788
		[FieldOffset(40)]
		public FString path;

		// Token: 0x0402685D RID: 157789
		[FieldOffset(64)]
		public FTransformDouble transform;

		// Token: 0x0402685E RID: 157790
		[FieldOffset(128)]
		public FString reason;

		// Token: 0x0402685F RID: 157791
		[FieldOffset(144)]
		public byte playType;

		// Token: 0x04026860 RID: 157792
		[FieldOffset(145)]
		public bool disablePostProcess;

		// Token: 0x04026861 RID: 157793
		[FieldOffset(152)]
		public IntPtr __WorldContext;

		// Token: 0x04026862 RID: 157794
		[FieldOffset(160)]
		public int __Result;
	}

	// Token: 0x02007458 RID: 29784
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 128)]
	protected ref struct __SpawnEffectUI_FunctionParams
	{
		// Token: 0x04026863 RID: 157795
		[FieldOffset(0)]
		public IntPtr worldContext;

		// Token: 0x04026864 RID: 157796
		[FieldOffset(8)]
		public IntPtr callObject;

		// Token: 0x04026865 RID: 157797
		[FieldOffset(16)]
		public FString path;

		// Token: 0x04026866 RID: 157798
		[FieldOffset(32)]
		public FTransformDouble transform;

		// Token: 0x04026867 RID: 157799
		[FieldOffset(96)]
		public FString reason;

		// Token: 0x04026868 RID: 157800
		[FieldOffset(112)]
		public IntPtr __WorldContext;

		// Token: 0x04026869 RID: 157801
		[FieldOffset(120)]
		public int __Result;
	}

	// Token: 0x02007459 RID: 29785
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 80)]
	protected ref struct __SpawnEffectWithActor_FunctionParams
	{
		// Token: 0x0402686A RID: 157802
		[FieldOffset(0)]
		public IntPtr worldContext;

		// Token: 0x0402686B RID: 157803
		[FieldOffset(8)]
		public IntPtr callObject;

		// Token: 0x0402686C RID: 157804
		[FieldOffset(16)]
		public IntPtr effectActor;

		// Token: 0x0402686D RID: 157805
		[FieldOffset(24)]
		public FString path;

		// Token: 0x0402686E RID: 157806
		[FieldOffset(40)]
		public FString reason;

		// Token: 0x0402686F RID: 157807
		[FieldOffset(56)]
		public byte playType;

		// Token: 0x04026870 RID: 157808
		[FieldOffset(57)]
		public byte effectType;

		// Token: 0x04026871 RID: 157809
		[FieldOffset(58)]
		public bool disablePostProcess;

		// Token: 0x04026872 RID: 157810
		[FieldOffset(64)]
		public IntPtr __WorldContext;

		// Token: 0x04026873 RID: 157811
		[FieldOffset(72)]
		public int __Result;
	}

	// Token: 0x0200745A RID: 29786
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __InitializeWithPreview_FunctionParams
	{
		// Token: 0x04026874 RID: 157812
		[FieldOffset(0)]
		public bool refresh;

		// Token: 0x04026875 RID: 157813
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200745B RID: 29787
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __EffectHandleIsValid_FunctionParams
	{
		// Token: 0x04026876 RID: 157814
		[FieldOffset(0)]
		public int handle;

		// Token: 0x04026877 RID: 157815
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x04026878 RID: 157816
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x0200745C RID: 29788
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __StopEffect_FunctionParams
	{
		// Token: 0x04026879 RID: 157817
		[FieldOffset(0)]
		public int handle;

		// Token: 0x0402687A RID: 157818
		[FieldOffset(8)]
		public IntPtr callObject;

		// Token: 0x0402687B RID: 157819
		[FieldOffset(16)]
		public FString reason;

		// Token: 0x0402687C RID: 157820
		[FieldOffset(32)]
		public bool immediately;

		// Token: 0x0402687D RID: 157821
		[FieldOffset(33)]
		public bool destroyActor;

		// Token: 0x0402687E RID: 157822
		[FieldOffset(40)]
		public IntPtr __WorldContext;

		// Token: 0x0402687F RID: 157823
		[FieldOffset(48)]
		public bool __Result;
	}

	// Token: 0x0200745D RID: 29789
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __StopAndDestroyEffect_FunctionParams
	{
		// Token: 0x04026880 RID: 157824
		[FieldOffset(0)]
		public int handle;

		// Token: 0x04026881 RID: 157825
		[FieldOffset(8)]
		public IntPtr callObject;

		// Token: 0x04026882 RID: 157826
		[FieldOffset(16)]
		public FString reason;

		// Token: 0x04026883 RID: 157827
		[FieldOffset(32)]
		public bool immediately;

		// Token: 0x04026884 RID: 157828
		[FieldOffset(40)]
		public IntPtr __WorldContext;

		// Token: 0x04026885 RID: 157829
		[FieldOffset(48)]
		public bool __Result;
	}

	// Token: 0x0200745E RID: 29790
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __PlayEffect_FunctionParams
	{
		// Token: 0x04026886 RID: 157830
		[FieldOffset(0)]
		public int handle;

		// Token: 0x04026887 RID: 157831
		[FieldOffset(8)]
		public IntPtr callObject;

		// Token: 0x04026888 RID: 157832
		[FieldOffset(16)]
		public FString reason;

		// Token: 0x04026889 RID: 157833
		[FieldOffset(32)]
		public IntPtr __WorldContext;

		// Token: 0x0402688A RID: 157834
		[FieldOffset(40)]
		public bool __Result;
	}

	// Token: 0x0200745F RID: 29791
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 96)]
	protected ref struct __SetEffectParameterNiagara_FunctionParams
	{
		// Token: 0x0402688B RID: 157835
		[FieldOffset(0)]
		public int handle;

		// Token: 0x0402688C RID: 157836
		[FieldOffset(8)]
		public byte userParameterFloat;

		// Token: 0x0402688D RID: 157837
		[FieldOffset(24)]
		public byte userParameterColor;

		// Token: 0x0402688E RID: 157838
		[FieldOffset(40)]
		public byte userParameterVector;

		// Token: 0x0402688F RID: 157839
		[FieldOffset(56)]
		public byte materialParameterFloat;

		// Token: 0x04026890 RID: 157840
		[FieldOffset(72)]
		public byte materialParameterColor;

		// Token: 0x04026891 RID: 157841
		[FieldOffset(88)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02007460 RID: 29792
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __EditorTickHandle_FunctionParams
	{
		// Token: 0x04026892 RID: 157842
		[FieldOffset(0)]
		public int handle;

		// Token: 0x04026893 RID: 157843
		[FieldOffset(4)]
		public float delta;

		// Token: 0x04026894 RID: 157844
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02007461 RID: 29793
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetEffectActor_FunctionParams
	{
		// Token: 0x04026895 RID: 157845
		[FieldOffset(0)]
		public int handle;

		// Token: 0x04026896 RID: 157846
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x04026897 RID: 157847
		[FieldOffset(16)]
		public IntPtr __Result;
	}

	// Token: 0x02007462 RID: 29794
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __AttachEffectActorToActor_FunctionParams
	{
		// Token: 0x04026898 RID: 157848
		[FieldOffset(0)]
		public int handle;

		// Token: 0x04026899 RID: 157849
		[FieldOffset(8)]
		public IntPtr parent;

		// Token: 0x0402689A RID: 157850
		[FieldOffset(16)]
		public FName socketName;

		// Token: 0x0402689B RID: 157851
		[FieldOffset(28)]
		public byte locationRule;

		// Token: 0x0402689C RID: 157852
		[FieldOffset(29)]
		public byte rotationRule;

		// Token: 0x0402689D RID: 157853
		[FieldOffset(30)]
		public byte scaleRule;

		// Token: 0x0402689E RID: 157854
		[FieldOffset(31)]
		public bool bWeldSimulatedBodies;

		// Token: 0x0402689F RID: 157855
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02007463 RID: 29795
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __AttachEffectActorToComponent_FunctionParams
	{
		// Token: 0x040268A0 RID: 157856
		[FieldOffset(0)]
		public int handle;

		// Token: 0x040268A1 RID: 157857
		[FieldOffset(8)]
		public IntPtr parent;

		// Token: 0x040268A2 RID: 157858
		[FieldOffset(16)]
		public FName socketName;

		// Token: 0x040268A3 RID: 157859
		[FieldOffset(28)]
		public byte locationRule;

		// Token: 0x040268A4 RID: 157860
		[FieldOffset(29)]
		public byte rotationRule;

		// Token: 0x040268A5 RID: 157861
		[FieldOffset(30)]
		public byte scaleRule;

		// Token: 0x040268A6 RID: 157862
		[FieldOffset(31)]
		public bool bWeldSimulatedBodies;

		// Token: 0x040268A7 RID: 157863
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02007464 RID: 29796
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __SetEffectActorRelativeLocation_FunctionParams
	{
		// Token: 0x040268A8 RID: 157864
		[FieldOffset(0)]
		public int handle;

		// Token: 0x040268A9 RID: 157865
		[FieldOffset(8)]
		public FVectorDouble newRelativeLocation;

		// Token: 0x040268AA RID: 157866
		[FieldOffset(32)]
		public bool bSweep;

		// Token: 0x040268AB RID: 157867
		[FieldOffset(33)]
		public bool bTeleport;

		// Token: 0x040268AC RID: 157868
		[FieldOffset(40)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02007465 RID: 29797
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetEffectHiddenInGame_FunctionParams
	{
		// Token: 0x040268AD RID: 157869
		[FieldOffset(0)]
		public int handle;

		// Token: 0x040268AE RID: 157870
		[FieldOffset(4)]
		public bool value;

		// Token: 0x040268AF RID: 157871
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02007466 RID: 29798
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetEffectIgnoreVisibilityOptimize_FunctionParams
	{
		// Token: 0x040268B0 RID: 157872
		[FieldOffset(0)]
		public int handle;

		// Token: 0x040268B1 RID: 157873
		[FieldOffset(4)]
		public bool ignore;

		// Token: 0x040268B2 RID: 157874
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02007467 RID: 29799
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetEffectStoppingTime_FunctionParams
	{
		// Token: 0x040268B3 RID: 157875
		[FieldOffset(0)]
		public int handle;

		// Token: 0x040268B4 RID: 157876
		[FieldOffset(4)]
		public bool stoppingTime;

		// Token: 0x040268B5 RID: 157877
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02007468 RID: 29800
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetGlobalStoppingTime_FunctionParams
	{
		// Token: 0x040268B6 RID: 157878
		[FieldOffset(0)]
		public bool stoppingTime;

		// Token: 0x040268B7 RID: 157879
		[FieldOffset(4)]
		public float playTime;

		// Token: 0x040268B8 RID: 157880
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02007469 RID: 29801
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetPublicToSequence_FunctionParams
	{
		// Token: 0x040268B9 RID: 157881
		[FieldOffset(0)]
		public int handle;

		// Token: 0x040268BA RID: 157882
		[FieldOffset(8)]
		public IntPtr actor;

		// Token: 0x040268BB RID: 157883
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200746A RID: 29802
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetSimulateFromSequence_FunctionParams
	{
		// Token: 0x040268BC RID: 157884
		[FieldOffset(0)]
		public int handle;

		// Token: 0x040268BD RID: 157885
		[FieldOffset(8)]
		public IntPtr actor;

		// Token: 0x040268BE RID: 157886
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}
}
