using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Battle;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002399 RID: 9113
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsBattleUiBlueprintFunctionLibrary.TsBattleUiBlueprintFunctionLibrary_C")]
public class TsBattleUiBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
{
	// Token: 0x060168C5 RID: 92357 RVA: 0x006971A8 File Offset: 0x006953A8
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static string GetBattleScoreStr()
	{
		BattleScoreModel instance = BattleScoreModel.Instance;
		int num = (instance != null) ? instance.GetCurScoreId() : 0;
		if (num == 0)
		{
			return "";
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 2);
		defaultInterpolatedStringHandler.AppendLiteral("Id:");
		defaultInterpolatedStringHandler.AppendFormatted<int>(num);
		defaultInterpolatedStringHandler.AppendLiteral(",Score:");
		BattleScoreModel instance2 = BattleScoreModel.Instance;
		defaultInterpolatedStringHandler.AppendFormatted<int>((instance2 != null) ? instance2.GetScore(num) : 0);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x060168C6 RID: 92358 RVA: 0x0069721A File Offset: 0x0069541A
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsBattleUiBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsBattleUiBlueprintFunctionLibrary.TsBattleUiBlueprintFunctionLibrary_C");
		}
		return TsBattleUiBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x060168C7 RID: 92359 RVA: 0x00697240 File Offset: 0x00695440
	public TsBattleUiBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(TsBattleUiBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060168C8 RID: 92360 RVA: 0x00697268 File Offset: 0x00695468
	[NullableContext(1)]
	public TsBattleUiBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsBattleUiBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060168C9 RID: 92361 RVA: 0x0069729B File Offset: 0x0069549B
	protected TsBattleUiBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060168CA RID: 92362 RVA: 0x006972A4 File Offset: 0x006954A4
	protected unsafe static void __CPPCALL_GetBattleScoreStr_Implementation(TsBattleUiBlueprintFunctionLibrary.__GetBattleScoreStr_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsBattleUiBlueprintFunctionLibrary.GetBattleScoreStr());
	}

	// Token: 0x0400BF17 RID: 48919
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsBattleUiBlueprintFunctionLibrary.TsBattleUiBlueprintFunctionLibrary_C";

	// Token: 0x0400BF18 RID: 48920
	private static IntPtr _ClassPtr;

	// Token: 0x0400BF19 RID: 48921
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x020085CA RID: 34250
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetBattleScoreStr_FunctionParams
	{
		// Token: 0x0402B0C1 RID: 176321
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402B0C2 RID: 176322
		[FieldOffset(8)]
		public FString __Result;
	}
}
