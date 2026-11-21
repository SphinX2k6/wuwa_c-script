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

// Token: 0x02000272 RID: 626
[UClass("/Game/Aki/TypeScript/Game/Effect/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Effect/TsEffectFunctionLibrary.TsEffectFunctionLibrary_C")]
public class TsEffectFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
{
	// Token: 0x060026A8 RID: 9896 RVA: 0x000E99B8 File Offset: 0x000E7BB8
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

	// Token: 0x060026A9 RID: 9897 RVA: 0x000E9B60 File Offset: 0x000E7D60
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

	// Token: 0x060026AA RID: 9898 RVA: 0x000E9E14 File Offset: 0x000E8014
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

	// Token: 0x060026AB RID: 9899 RVA: 0x000E9FBC File Offset: 0x000E81BC
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

	// Token: 0x060026AC RID: 9900 RVA: 0x000EA1EC File Offset: 0x000E83EC
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void InitializeWithPreview(bool refresh)
	{
		EffectSystem.Instance.InitializeWithPreview(refresh);
	}

	// Token: 0x060026AD RID: 9901 RVA: 0x000EA1F9 File Offset: 0x000E83F9
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool EffectHandleIsValid(int handle)
	{
		return EffectSystem.Instance.IsValid(handle);
	}

	// Token: 0x060026AE RID: 9902 RVA: 0x000EA208 File Offset: 0x000E8408
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

	// Token: 0x060026AF RID: 9903 RVA: 0x000EA420 File Offset: 0x000E8620
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

	// Token: 0x060026B0 RID: 9904 RVA: 0x000EA634 File Offset: 0x000E8834
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

	// Token: 0x060026B1 RID: 9905 RVA: 0x000EA81C File Offset: 0x000E8A1C
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

	// Token: 0x060026B2 RID: 9906 RVA: 0x000EAA20 File Offset: 0x000E8C20
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void EditorTickHandle(int handle, float delta)
	{
		EffectSystem.Instance.TickHandleInEditor(handle, delta);
	}

	// Token: 0x060026B3 RID: 9907 RVA: 0x000EAA2E File Offset: 0x000E8C2E
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static AActor GetEffectActor(int handle)
	{
		return EffectSystem.Instance.GetSureEffectActor(handle);
	}

	// Token: 0x060026B4 RID: 9908 RVA: 0x000EAA3C File Offset: 0x000E8C3C
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

	// Token: 0x060026B5 RID: 9909 RVA: 0x000EAA6C File Offset: 0x000E8C6C
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

	// Token: 0x060026B6 RID: 9910 RVA: 0x000EAAAC File Offset: 0x000E8CAC
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

	// Token: 0x060026B7 RID: 9911 RVA: 0x000EAADE File Offset: 0x000E8CDE
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetEffectActorRelativeLocation(int handle, FVectorDouble newRelativeLocation, bool bSweep, bool bTeleport)
	{
		if (!EffectSystem.Instance.IsValid(handle))
		{
			return;
		}
		EffectSystem.Instance.GetEffectActor(handle).D_K2_SetActorRelativeLocation(newRelativeLocation, bSweep, ref WorldGlobal.SweepHitResult, bTeleport);
	}

	// Token: 0x060026B8 RID: 9912 RVA: 0x000EAB07 File Offset: 0x000E8D07
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetEffectHiddenInGame(int handle, bool value)
	{
		if (!EffectSystem.Instance.IsValid(handle))
		{
			return;
		}
		EffectSystem.Instance.SetEffectHidden(handle, value, "TsEffectFunctionLibrary.SetEffectHiddenInGame", false);
	}

	// Token: 0x060026B9 RID: 9913 RVA: 0x000EAB2C File Offset: 0x000E8D2C
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

	// Token: 0x060026BA RID: 9914 RVA: 0x000EAB80 File Offset: 0x000E8D80
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

	// Token: 0x060026BB RID: 9915 RVA: 0x000EABD4 File Offset: 0x000E8DD4
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetGlobalStoppingTime(bool stoppingTime, float playTime)
	{
		EffectSystem.Instance.SetGlobalStoppingTime(stoppingTime, playTime, EEffectStoppingTimeSource.ScenePaused);
	}

	// Token: 0x060026BC RID: 9916 RVA: 0x000EABE3 File Offset: 0x000E8DE3
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetPublicToSequence(int handle, BP_EffectActor_C actor)
	{
	}

	// Token: 0x060026BD RID: 9917 RVA: 0x000EABE5 File Offset: 0x000E8DE5
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetSimulateFromSequence(int handle, BP_EffectActor_C actor)
	{
	}

	// Token: 0x060026BE RID: 9918 RVA: 0x000EABE7 File Offset: 0x000E8DE7
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsEffectFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Effect/TsEffectFunctionLibrary.TsEffectFunctionLibrary_C");
		}
		return TsEffectFunctionLibrary._ClassPtr;
	}

	// Token: 0x060026BF RID: 9919 RVA: 0x000EAC0C File Offset: 0x000E8E0C
	public TsEffectFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(TsEffectFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060026C0 RID: 9920 RVA: 0x000EAC34 File Offset: 0x000E8E34
	[NullableContext(1)]
	public TsEffectFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsEffectFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060026C1 RID: 9921 RVA: 0x000EAC67 File Offset: 0x000E8E67
	protected TsEffectFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060026C2 RID: 9922 RVA: 0x000EAC70 File Offset: 0x000E8E70
	protected unsafe static void __CPPCALL_SpawnEffect_Implementation(TsEffectFunctionLibrary.__SpawnEffect_FunctionParams* __Params)
	{
		UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->worldContext);
		UObject orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->callObject);
		string path = FString.ToString((void*)(&__Params->path));
		string reason = FString.ToString((void*)(&__Params->reason));
		EEffectPlay playType = (EEffectPlay)__Params->playType;
		__Params->__Result = TsEffectFunctionLibrary.SpawnEffect(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, path, __Params->transform, reason, playType, __Params->disablePostProcess);
	}

	// Token: 0x060026C3 RID: 9923 RVA: 0x000EACD4 File Offset: 0x000E8ED4
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

	// Token: 0x060026C4 RID: 9924 RVA: 0x000EAD50 File Offset: 0x000E8F50
	protected unsafe static void __CPPCALL_SpawnEffectUI_Implementation(TsEffectFunctionLibrary.__SpawnEffectUI_FunctionParams* __Params)
	{
		UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->worldContext);
		UObject orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->callObject);
		string path = FString.ToString((void*)(&__Params->path));
		string reason = FString.ToString((void*)(&__Params->reason));
		__Params->__Result = TsEffectFunctionLibrary.SpawnEffectUI(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, path, __Params->transform, reason);
	}

	// Token: 0x060026C5 RID: 9925 RVA: 0x000EADA4 File Offset: 0x000E8FA4
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

	// Token: 0x060026C6 RID: 9926 RVA: 0x000EAE1B File Offset: 0x000E901B
	protected unsafe static void __CPPCALL_InitializeWithPreview_Implementation(TsEffectFunctionLibrary.__InitializeWithPreview_FunctionParams* __Params)
	{
		TsEffectFunctionLibrary.InitializeWithPreview(__Params->refresh);
	}

	// Token: 0x060026C7 RID: 9927 RVA: 0x000EAE28 File Offset: 0x000E9028
	protected unsafe static void __CPPCALL_EffectHandleIsValid_Implementation(TsEffectFunctionLibrary.__EffectHandleIsValid_FunctionParams* __Params)
	{
		__Params->__Result = TsEffectFunctionLibrary.EffectHandleIsValid(__Params->handle);
	}

	// Token: 0x060026C8 RID: 9928 RVA: 0x000EAE3C File Offset: 0x000E903C
	protected unsafe static void __CPPCALL_StopEffect_Implementation(TsEffectFunctionLibrary.__StopEffect_FunctionParams* __Params)
	{
		UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->callObject);
		string reason = FString.ToString((void*)(&__Params->reason));
		__Params->__Result = TsEffectFunctionLibrary.StopEffect(__Params->handle, orCreateUObjectByNativePointer, reason, __Params->immediately, __Params->destroyActor);
	}

	// Token: 0x060026C9 RID: 9929 RVA: 0x000EAE84 File Offset: 0x000E9084
	protected unsafe static void __CPPCALL_StopAndDestroyEffect_Implementation(TsEffectFunctionLibrary.__StopAndDestroyEffect_FunctionParams* __Params)
	{
		UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->callObject);
		string reason = FString.ToString((void*)(&__Params->reason));
		__Params->__Result = TsEffectFunctionLibrary.StopAndDestroyEffect(__Params->handle, orCreateUObjectByNativePointer, reason, __Params->immediately);
	}

	// Token: 0x060026CA RID: 9930 RVA: 0x000EAEC4 File Offset: 0x000E90C4
	protected unsafe static void __CPPCALL_PlayEffect_Implementation(TsEffectFunctionLibrary.__PlayEffect_FunctionParams* __Params)
	{
		UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->callObject);
		string reason = FString.ToString((void*)(&__Params->reason));
		__Params->__Result = TsEffectFunctionLibrary.PlayEffect(__Params->handle, orCreateUObjectByNativePointer, reason);
	}

	// Token: 0x060026CB RID: 9931 RVA: 0x000EAF00 File Offset: 0x000E9100
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

	// Token: 0x060026CC RID: 9932 RVA: 0x000EAFF2 File Offset: 0x000E91F2
	protected unsafe static void __CPPCALL_EditorTickHandle_Implementation(TsEffectFunctionLibrary.__EditorTickHandle_FunctionParams* __Params)
	{
		TsEffectFunctionLibrary.EditorTickHandle(__Params->handle, __Params->delta);
	}

	// Token: 0x060026CD RID: 9933 RVA: 0x000EB005 File Offset: 0x000E9205
	protected unsafe static void __CPPCALL_GetEffectActor_Implementation(TsEffectFunctionLibrary.__GetEffectActor_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		AActor effectActor = TsEffectFunctionLibrary.GetEffectActor(__Params->handle);
		ptr = ((effectActor != null) ? effectActor.NativePtr : ((IntPtr)0));
	}

	// Token: 0x060026CE RID: 9934 RVA: 0x000EB028 File Offset: 0x000E9228
	protected unsafe static void __CPPCALL_AttachEffectActorToActor_Implementation(TsEffectFunctionLibrary.__AttachEffectActorToActor_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->parent);
		EAttachmentRule locationRule = (EAttachmentRule)__Params->locationRule;
		EAttachmentRule rotationRule = (EAttachmentRule)__Params->rotationRule;
		EAttachmentRule scaleRule = (EAttachmentRule)__Params->scaleRule;
		TsEffectFunctionLibrary.AttachEffectActorToActor(__Params->handle, orCreateUObjectByNativePointer, __Params->socketName, locationRule, rotationRule, scaleRule, __Params->bWeldSimulatedBodies);
	}

	// Token: 0x060026CF RID: 9935 RVA: 0x000EB074 File Offset: 0x000E9274
	protected unsafe static void __CPPCALL_AttachEffectActorToComponent_Implementation(TsEffectFunctionLibrary.__AttachEffectActorToComponent_FunctionParams* __Params)
	{
		USceneComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USceneComponent>(__Params->parent);
		EAttachmentRule locationRule = (EAttachmentRule)__Params->locationRule;
		EAttachmentRule rotationRule = (EAttachmentRule)__Params->rotationRule;
		EAttachmentRule scaleRule = (EAttachmentRule)__Params->scaleRule;
		TsEffectFunctionLibrary.AttachEffectActorToComponent(__Params->handle, orCreateUObjectByNativePointer, __Params->socketName, locationRule, rotationRule, scaleRule, __Params->bWeldSimulatedBodies);
	}

	// Token: 0x060026D0 RID: 9936 RVA: 0x000EB0BD File Offset: 0x000E92BD
	protected unsafe static void __CPPCALL_SetEffectActorRelativeLocation_Implementation(TsEffectFunctionLibrary.__SetEffectActorRelativeLocation_FunctionParams* __Params)
	{
		TsEffectFunctionLibrary.SetEffectActorRelativeLocation(__Params->handle, __Params->newRelativeLocation, __Params->bSweep, __Params->bTeleport);
	}

	// Token: 0x060026D1 RID: 9937 RVA: 0x000EB0DC File Offset: 0x000E92DC
	protected unsafe static void __CPPCALL_SetEffectHiddenInGame_Implementation(TsEffectFunctionLibrary.__SetEffectHiddenInGame_FunctionParams* __Params)
	{
		TsEffectFunctionLibrary.SetEffectHiddenInGame(__Params->handle, __Params->value);
	}

	// Token: 0x060026D2 RID: 9938 RVA: 0x000EB0EF File Offset: 0x000E92EF
	protected unsafe static void __CPPCALL_SetEffectIgnoreVisibilityOptimize_Implementation(TsEffectFunctionLibrary.__SetEffectIgnoreVisibilityOptimize_FunctionParams* __Params)
	{
		TsEffectFunctionLibrary.SetEffectIgnoreVisibilityOptimize(__Params->handle, __Params->ignore);
	}

	// Token: 0x060026D3 RID: 9939 RVA: 0x000EB102 File Offset: 0x000E9302
	protected unsafe static void __CPPCALL_SetEffectStoppingTime_Implementation(TsEffectFunctionLibrary.__SetEffectStoppingTime_FunctionParams* __Params)
	{
		TsEffectFunctionLibrary.SetEffectStoppingTime(__Params->handle, __Params->stoppingTime);
	}

	// Token: 0x060026D4 RID: 9940 RVA: 0x000EB115 File Offset: 0x000E9315
	protected unsafe static void __CPPCALL_SetGlobalStoppingTime_Implementation(TsEffectFunctionLibrary.__SetGlobalStoppingTime_FunctionParams* __Params)
	{
		TsEffectFunctionLibrary.SetGlobalStoppingTime(__Params->stoppingTime, __Params->playTime);
	}

	// Token: 0x060026D5 RID: 9941 RVA: 0x000EB128 File Offset: 0x000E9328
	protected unsafe static void __CPPCALL_SetPublicToSequence_Implementation(TsEffectFunctionLibrary.__SetPublicToSequence_FunctionParams* __Params)
	{
		BP_EffectActor_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_EffectActor_C>(__Params->actor);
		TsEffectFunctionLibrary.SetPublicToSequence(__Params->handle, orCreateUObjectByNativePointer);
	}

	// Token: 0x060026D6 RID: 9942 RVA: 0x000EB150 File Offset: 0x000E9350
	protected unsafe static void __CPPCALL_SetSimulateFromSequence_Implementation(TsEffectFunctionLibrary.__SetSimulateFromSequence_FunctionParams* __Params)
	{
		BP_EffectActor_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_EffectActor_C>(__Params->actor);
		TsEffectFunctionLibrary.SetSimulateFromSequence(__Params->handle, orCreateUObjectByNativePointer);
	}

	// Token: 0x04002505 RID: 9477
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Effect/TsEffectFunctionLibrary.TsEffectFunctionLibrary_C";

	// Token: 0x04002506 RID: 9478
	private static IntPtr _ClassPtr;

	// Token: 0x04002507 RID: 9479
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x020065E7 RID: 26087
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 144)]
	protected ref struct __SpawnEffect_FunctionParams
	{
		// Token: 0x04021B8D RID: 138125
		[FieldOffset(0)]
		public IntPtr worldContext;

		// Token: 0x04021B8E RID: 138126
		[FieldOffset(8)]
		public IntPtr callObject;

		// Token: 0x04021B8F RID: 138127
		[FieldOffset(16)]
		public FString path;

		// Token: 0x04021B90 RID: 138128
		[FieldOffset(32)]
		public FTransformDouble transform;

		// Token: 0x04021B91 RID: 138129
		[FieldOffset(96)]
		public FString reason;

		// Token: 0x04021B92 RID: 138130
		[FieldOffset(112)]
		public byte playType;

		// Token: 0x04021B93 RID: 138131
		[FieldOffset(113)]
		public bool disablePostProcess;

		// Token: 0x04021B94 RID: 138132
		[FieldOffset(120)]
		public IntPtr __WorldContext;

		// Token: 0x04021B95 RID: 138133
		[FieldOffset(128)]
		public int __Result;
	}

	// Token: 0x020065E8 RID: 26088
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 176)]
	protected ref struct __SpawnEffectAttachToBone_FunctionParams
	{
		// Token: 0x04021B96 RID: 138134
		[FieldOffset(0)]
		public IntPtr worldContext;

		// Token: 0x04021B97 RID: 138135
		[FieldOffset(8)]
		public IntPtr callObject;

		// Token: 0x04021B98 RID: 138136
		[FieldOffset(16)]
		public IntPtr skeletalMeshComponent;

		// Token: 0x04021B99 RID: 138137
		[FieldOffset(24)]
		public FName socketName;

		// Token: 0x04021B9A RID: 138138
		[FieldOffset(40)]
		public FString path;

		// Token: 0x04021B9B RID: 138139
		[FieldOffset(64)]
		public FTransformDouble transform;

		// Token: 0x04021B9C RID: 138140
		[FieldOffset(128)]
		public FString reason;

		// Token: 0x04021B9D RID: 138141
		[FieldOffset(144)]
		public byte playType;

		// Token: 0x04021B9E RID: 138142
		[FieldOffset(145)]
		public bool disablePostProcess;

		// Token: 0x04021B9F RID: 138143
		[FieldOffset(152)]
		public IntPtr __WorldContext;

		// Token: 0x04021BA0 RID: 138144
		[FieldOffset(160)]
		public int __Result;
	}

	// Token: 0x020065E9 RID: 26089
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 128)]
	protected ref struct __SpawnEffectUI_FunctionParams
	{
		// Token: 0x04021BA1 RID: 138145
		[FieldOffset(0)]
		public IntPtr worldContext;

		// Token: 0x04021BA2 RID: 138146
		[FieldOffset(8)]
		public IntPtr callObject;

		// Token: 0x04021BA3 RID: 138147
		[FieldOffset(16)]
		public FString path;

		// Token: 0x04021BA4 RID: 138148
		[FieldOffset(32)]
		public FTransformDouble transform;

		// Token: 0x04021BA5 RID: 138149
		[FieldOffset(96)]
		public FString reason;

		// Token: 0x04021BA6 RID: 138150
		[FieldOffset(112)]
		public IntPtr __WorldContext;

		// Token: 0x04021BA7 RID: 138151
		[FieldOffset(120)]
		public int __Result;
	}

	// Token: 0x020065EA RID: 26090
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 80)]
	protected ref struct __SpawnEffectWithActor_FunctionParams
	{
		// Token: 0x04021BA8 RID: 138152
		[FieldOffset(0)]
		public IntPtr worldContext;

		// Token: 0x04021BA9 RID: 138153
		[FieldOffset(8)]
		public IntPtr callObject;

		// Token: 0x04021BAA RID: 138154
		[FieldOffset(16)]
		public IntPtr effectActor;

		// Token: 0x04021BAB RID: 138155
		[FieldOffset(24)]
		public FString path;

		// Token: 0x04021BAC RID: 138156
		[FieldOffset(40)]
		public FString reason;

		// Token: 0x04021BAD RID: 138157
		[FieldOffset(56)]
		public byte playType;

		// Token: 0x04021BAE RID: 138158
		[FieldOffset(57)]
		public byte effectType;

		// Token: 0x04021BAF RID: 138159
		[FieldOffset(58)]
		public bool disablePostProcess;

		// Token: 0x04021BB0 RID: 138160
		[FieldOffset(64)]
		public IntPtr __WorldContext;

		// Token: 0x04021BB1 RID: 138161
		[FieldOffset(72)]
		public int __Result;
	}

	// Token: 0x020065EB RID: 26091
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __InitializeWithPreview_FunctionParams
	{
		// Token: 0x04021BB2 RID: 138162
		[FieldOffset(0)]
		public bool refresh;

		// Token: 0x04021BB3 RID: 138163
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020065EC RID: 26092
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __EffectHandleIsValid_FunctionParams
	{
		// Token: 0x04021BB4 RID: 138164
		[FieldOffset(0)]
		public int handle;

		// Token: 0x04021BB5 RID: 138165
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x04021BB6 RID: 138166
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020065ED RID: 26093
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __StopEffect_FunctionParams
	{
		// Token: 0x04021BB7 RID: 138167
		[FieldOffset(0)]
		public int handle;

		// Token: 0x04021BB8 RID: 138168
		[FieldOffset(8)]
		public IntPtr callObject;

		// Token: 0x04021BB9 RID: 138169
		[FieldOffset(16)]
		public FString reason;

		// Token: 0x04021BBA RID: 138170
		[FieldOffset(32)]
		public bool immediately;

		// Token: 0x04021BBB RID: 138171
		[FieldOffset(33)]
		public bool destroyActor;

		// Token: 0x04021BBC RID: 138172
		[FieldOffset(40)]
		public IntPtr __WorldContext;

		// Token: 0x04021BBD RID: 138173
		[FieldOffset(48)]
		public bool __Result;
	}

	// Token: 0x020065EE RID: 26094
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __StopAndDestroyEffect_FunctionParams
	{
		// Token: 0x04021BBE RID: 138174
		[FieldOffset(0)]
		public int handle;

		// Token: 0x04021BBF RID: 138175
		[FieldOffset(8)]
		public IntPtr callObject;

		// Token: 0x04021BC0 RID: 138176
		[FieldOffset(16)]
		public FString reason;

		// Token: 0x04021BC1 RID: 138177
		[FieldOffset(32)]
		public bool immediately;

		// Token: 0x04021BC2 RID: 138178
		[FieldOffset(40)]
		public IntPtr __WorldContext;

		// Token: 0x04021BC3 RID: 138179
		[FieldOffset(48)]
		public bool __Result;
	}

	// Token: 0x020065EF RID: 26095
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __PlayEffect_FunctionParams
	{
		// Token: 0x04021BC4 RID: 138180
		[FieldOffset(0)]
		public int handle;

		// Token: 0x04021BC5 RID: 138181
		[FieldOffset(8)]
		public IntPtr callObject;

		// Token: 0x04021BC6 RID: 138182
		[FieldOffset(16)]
		public FString reason;

		// Token: 0x04021BC7 RID: 138183
		[FieldOffset(32)]
		public IntPtr __WorldContext;

		// Token: 0x04021BC8 RID: 138184
		[FieldOffset(40)]
		public bool __Result;
	}

	// Token: 0x020065F0 RID: 26096
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 96)]
	protected ref struct __SetEffectParameterNiagara_FunctionParams
	{
		// Token: 0x04021BC9 RID: 138185
		[FieldOffset(0)]
		public int handle;

		// Token: 0x04021BCA RID: 138186
		[FieldOffset(8)]
		public byte userParameterFloat;

		// Token: 0x04021BCB RID: 138187
		[FieldOffset(24)]
		public byte userParameterColor;

		// Token: 0x04021BCC RID: 138188
		[FieldOffset(40)]
		public byte userParameterVector;

		// Token: 0x04021BCD RID: 138189
		[FieldOffset(56)]
		public byte materialParameterFloat;

		// Token: 0x04021BCE RID: 138190
		[FieldOffset(72)]
		public byte materialParameterColor;

		// Token: 0x04021BCF RID: 138191
		[FieldOffset(88)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020065F1 RID: 26097
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __EditorTickHandle_FunctionParams
	{
		// Token: 0x04021BD0 RID: 138192
		[FieldOffset(0)]
		public int handle;

		// Token: 0x04021BD1 RID: 138193
		[FieldOffset(4)]
		public float delta;

		// Token: 0x04021BD2 RID: 138194
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020065F2 RID: 26098
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetEffectActor_FunctionParams
	{
		// Token: 0x04021BD3 RID: 138195
		[FieldOffset(0)]
		public int handle;

		// Token: 0x04021BD4 RID: 138196
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x04021BD5 RID: 138197
		[FieldOffset(16)]
		public IntPtr __Result;
	}

	// Token: 0x020065F3 RID: 26099
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __AttachEffectActorToActor_FunctionParams
	{
		// Token: 0x04021BD6 RID: 138198
		[FieldOffset(0)]
		public int handle;

		// Token: 0x04021BD7 RID: 138199
		[FieldOffset(8)]
		public IntPtr parent;

		// Token: 0x04021BD8 RID: 138200
		[FieldOffset(16)]
		public FName socketName;

		// Token: 0x04021BD9 RID: 138201
		[FieldOffset(28)]
		public byte locationRule;

		// Token: 0x04021BDA RID: 138202
		[FieldOffset(29)]
		public byte rotationRule;

		// Token: 0x04021BDB RID: 138203
		[FieldOffset(30)]
		public byte scaleRule;

		// Token: 0x04021BDC RID: 138204
		[FieldOffset(31)]
		public bool bWeldSimulatedBodies;

		// Token: 0x04021BDD RID: 138205
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020065F4 RID: 26100
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __AttachEffectActorToComponent_FunctionParams
	{
		// Token: 0x04021BDE RID: 138206
		[FieldOffset(0)]
		public int handle;

		// Token: 0x04021BDF RID: 138207
		[FieldOffset(8)]
		public IntPtr parent;

		// Token: 0x04021BE0 RID: 138208
		[FieldOffset(16)]
		public FName socketName;

		// Token: 0x04021BE1 RID: 138209
		[FieldOffset(28)]
		public byte locationRule;

		// Token: 0x04021BE2 RID: 138210
		[FieldOffset(29)]
		public byte rotationRule;

		// Token: 0x04021BE3 RID: 138211
		[FieldOffset(30)]
		public byte scaleRule;

		// Token: 0x04021BE4 RID: 138212
		[FieldOffset(31)]
		public bool bWeldSimulatedBodies;

		// Token: 0x04021BE5 RID: 138213
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020065F5 RID: 26101
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __SetEffectActorRelativeLocation_FunctionParams
	{
		// Token: 0x04021BE6 RID: 138214
		[FieldOffset(0)]
		public int handle;

		// Token: 0x04021BE7 RID: 138215
		[FieldOffset(8)]
		public FVectorDouble newRelativeLocation;

		// Token: 0x04021BE8 RID: 138216
		[FieldOffset(32)]
		public bool bSweep;

		// Token: 0x04021BE9 RID: 138217
		[FieldOffset(33)]
		public bool bTeleport;

		// Token: 0x04021BEA RID: 138218
		[FieldOffset(40)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020065F6 RID: 26102
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetEffectHiddenInGame_FunctionParams
	{
		// Token: 0x04021BEB RID: 138219
		[FieldOffset(0)]
		public int handle;

		// Token: 0x04021BEC RID: 138220
		[FieldOffset(4)]
		public bool value;

		// Token: 0x04021BED RID: 138221
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020065F7 RID: 26103
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetEffectIgnoreVisibilityOptimize_FunctionParams
	{
		// Token: 0x04021BEE RID: 138222
		[FieldOffset(0)]
		public int handle;

		// Token: 0x04021BEF RID: 138223
		[FieldOffset(4)]
		public bool ignore;

		// Token: 0x04021BF0 RID: 138224
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020065F8 RID: 26104
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetEffectStoppingTime_FunctionParams
	{
		// Token: 0x04021BF1 RID: 138225
		[FieldOffset(0)]
		public int handle;

		// Token: 0x04021BF2 RID: 138226
		[FieldOffset(4)]
		public bool stoppingTime;

		// Token: 0x04021BF3 RID: 138227
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020065F9 RID: 26105
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetGlobalStoppingTime_FunctionParams
	{
		// Token: 0x04021BF4 RID: 138228
		[FieldOffset(0)]
		public bool stoppingTime;

		// Token: 0x04021BF5 RID: 138229
		[FieldOffset(4)]
		public float playTime;

		// Token: 0x04021BF6 RID: 138230
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020065FA RID: 26106
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetPublicToSequence_FunctionParams
	{
		// Token: 0x04021BF7 RID: 138231
		[FieldOffset(0)]
		public int handle;

		// Token: 0x04021BF8 RID: 138232
		[FieldOffset(8)]
		public IntPtr actor;

		// Token: 0x04021BF9 RID: 138233
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020065FB RID: 26107
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetSimulateFromSequence_FunctionParams
	{
		// Token: 0x04021BFA RID: 138234
		[FieldOffset(0)]
		public int handle;

		// Token: 0x04021BFB RID: 138235
		[FieldOffset(8)]
		public IntPtr actor;

		// Token: 0x04021BFC RID: 138236
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}
}
