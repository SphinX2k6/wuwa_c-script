using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Battle;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002E3D RID: 11837
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsBattleUiBlueprintFunctionLibrary.TsBattleUiBlueprintFunctionLibrary_C")]
public class TsBattleUiBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
{
	// Token: 0x06018FF8 RID: 102392 RVA: 0x006712E0 File Offset: 0x0066F4E0
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

	// Token: 0x06018FF9 RID: 102393 RVA: 0x00671352 File Offset: 0x0066F552
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsBattleUiBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsBattleUiBlueprintFunctionLibrary.TsBattleUiBlueprintFunctionLibrary_C");
		}
		return TsBattleUiBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x06018FFA RID: 102394 RVA: 0x00671378 File Offset: 0x0066F578
	public TsBattleUiBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(TsBattleUiBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06018FFB RID: 102395 RVA: 0x006713A0 File Offset: 0x0066F5A0
	[NullableContext(1)]
	public TsBattleUiBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsBattleUiBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06018FFC RID: 102396 RVA: 0x006713D3 File Offset: 0x0066F5D3
	protected TsBattleUiBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06018FFD RID: 102397 RVA: 0x006713DC File Offset: 0x0066F5DC
	protected unsafe static void __CPPCALL_GetBattleScoreStr_Implementation(TsBattleUiBlueprintFunctionLibrary.__GetBattleScoreStr_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsBattleUiBlueprintFunctionLibrary.GetBattleScoreStr());
	}

	// Token: 0x0400BB89 RID: 48009
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsBattleUiBlueprintFunctionLibrary.TsBattleUiBlueprintFunctionLibrary_C";

	// Token: 0x0400BB8A RID: 48010
	private static IntPtr _ClassPtr;

	// Token: 0x0400BB8B RID: 48011
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x020093A4 RID: 37796
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetBattleScoreStr_FunctionParams
	{
		// Token: 0x0402FA3B RID: 195131
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402FA3C RID: 195132
		[FieldOffset(8)]
		public FString __Result;
	}
}
