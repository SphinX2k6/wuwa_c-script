using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200008D RID: 141
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskBlackBoardSetValues.TsTaskBlackBoardSetValues_C")]
public class TsTaskBlackBoardSetValues : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700011C RID: 284
	// (get) Token: 0x06000717 RID: 1815 RVA: 0x00024558 File Offset: 0x00022758
	[UProperty(EPropertyFlags.CPF_None)]
	public TMap<string, string> StringMap
	{
		get
		{
			base.FastCheckIsValid();
			TMap<string, string> result;
			if ((result = this._StringMap) == null)
			{
				result = (this._StringMap = new TMap<string, string>(base.NativePtr + (IntPtr)TsTaskBlackBoardSetValues.__PropertyOffset_StringMap, this));
			}
			return result;
		}
	}

	// Token: 0x1700011D RID: 285
	// (get) Token: 0x06000718 RID: 1816 RVA: 0x00024594 File Offset: 0x00022794
	[UProperty(EPropertyFlags.CPF_None)]
	public TMap<string, float> FloatMap
	{
		get
		{
			base.FastCheckIsValid();
			TMap<string, float> result;
			if ((result = this._FloatMap) == null)
			{
				result = (this._FloatMap = new TMap<string, float>(base.NativePtr + (IntPtr)TsTaskBlackBoardSetValues.__PropertyOffset_FloatMap, this));
			}
			return result;
		}
	}

	// Token: 0x1700011E RID: 286
	// (get) Token: 0x06000719 RID: 1817 RVA: 0x000245D0 File Offset: 0x000227D0
	[UProperty(EPropertyFlags.CPF_None)]
	public TMap<string, int> IntMap
	{
		get
		{
			base.FastCheckIsValid();
			TMap<string, int> result;
			if ((result = this._IntMap) == null)
			{
				result = (this._IntMap = new TMap<string, int>(base.NativePtr + (IntPtr)TsTaskBlackBoardSetValues.__PropertyOffset_IntMap, this));
			}
			return result;
		}
	}

	// Token: 0x1700011F RID: 287
	// (get) Token: 0x0600071A RID: 1818 RVA: 0x0002460C File Offset: 0x0002280C
	[UProperty(EPropertyFlags.CPF_None)]
	public TMap<string, bool> BooleanMap
	{
		get
		{
			base.FastCheckIsValid();
			TMap<string, bool> result;
			if ((result = this._BooleanMap) == null)
			{
				result = (this._BooleanMap = new TMap<string, bool>(base.NativePtr + (IntPtr)TsTaskBlackBoardSetValues.__PropertyOffset_BooleanMap, this));
			}
			return result;
		}
	}

	// Token: 0x17000120 RID: 288
	// (get) Token: 0x0600071B RID: 1819 RVA: 0x00024648 File Offset: 0x00022848
	[UProperty(EPropertyFlags.CPF_None)]
	public TMap<string, FVector> VectorMap
	{
		get
		{
			base.FastCheckIsValid();
			TMap<string, FVector> result;
			if ((result = this._VectorMap) == null)
			{
				result = (this._VectorMap = new TMap<string, FVector>(base.NativePtr + (IntPtr)TsTaskBlackBoardSetValues.__PropertyOffset_VectorMap, this));
			}
			return result;
		}
	}

	// Token: 0x0600071C RID: 1820 RVA: 0x00024684 File Offset: 0x00022884
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsStringMap = new Dictionary<string, string>(this.StringMap.Num());
			this.TsFloatMap = new Dictionary<string, float>(this.FloatMap.Num());
			this.TsIntMap = new Dictionary<string, int>(this.IntMap.Num());
			this.TsBooleanMap = new Dictionary<string, bool>(this.BooleanMap.Num());
			this.TsVectorMap = new Dictionary<string, FVector>(this.VectorMap.Num());
			foreach (KeyValuePair<string, string> keyValuePair in this.StringMap)
			{
				string text;
				string text2;
				keyValuePair.Deconstruct(out text, out text2);
				string key = text;
				string value = text2;
				this.TsStringMap[key] = value;
			}
			foreach (KeyValuePair<string, float> keyValuePair2 in this.FloatMap)
			{
				string text2;
				float num;
				keyValuePair2.Deconstruct(out text2, out num);
				string key2 = text2;
				float value2 = num;
				this.TsFloatMap[key2] = value2;
			}
			foreach (KeyValuePair<string, int> keyValuePair3 in this.IntMap)
			{
				string text2;
				int num2;
				keyValuePair3.Deconstruct(out text2, out num2);
				string key3 = text2;
				int value3 = num2;
				this.TsIntMap[key3] = value3;
			}
			foreach (KeyValuePair<string, bool> keyValuePair4 in this.BooleanMap)
			{
				string text2;
				bool flag;
				keyValuePair4.Deconstruct(out text2, out flag);
				string key4 = text2;
				bool value4 = flag;
				this.TsBooleanMap[key4] = value4;
			}
			foreach (KeyValuePair<string, FVector> keyValuePair5 in this.VectorMap)
			{
				string text2;
				FVector fvector;
				keyValuePair5.Deconstruct(out text2, out fvector);
				string key5 = text2;
				FVector value5 = fvector;
				this.TsVectorMap[key5] = value5;
			}
		}
	}

	// Token: 0x0600071D RID: 1821 RVA: 0x000248F4 File Offset: 0x00022AF4
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskBlackBoardSetValues) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskBlackBoardSetValues.StaticClass(), out intPtr, out num))
		{
			this.ReceiveExecuteAI_Implementation(ownerController, controlledPawn);
			return;
		}
		UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* ptr = stackalloc UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
		*(&ptr->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0600071E RID: 1822 RVA: 0x000249A4 File Offset: 0x00022BA4
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		if (aiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.FinishExecute(false);
			return;
		}
		this.InitTsVariables();
		int id = aiController.CharActorComp.Entity.Id;
		this.ExecuteStringMap(id);
		this.ExecuteFloatMap(id);
		this.ExecuteIntMap(id);
		this.ExecuteBooleanMap(id);
		this.ExecuteVectorMap(id);
		base.FinishExecute(true);
	}

	// Token: 0x0600071F RID: 1823 RVA: 0x00024A44 File Offset: 0x00022C44
	private void ExecuteStringMap(int id)
	{
		foreach (KeyValuePair<string, string> keyValuePair in this.TsStringMap)
		{
			BlackboardController.Instance.SetStringValueByEntity(id, keyValuePair.Key, keyValuePair.Value);
		}
	}

	// Token: 0x06000720 RID: 1824 RVA: 0x00024AAC File Offset: 0x00022CAC
	private void ExecuteFloatMap(int id)
	{
		foreach (KeyValuePair<string, float> keyValuePair in this.TsFloatMap)
		{
			BlackboardController.Instance.SetFloatValueByEntity(id, keyValuePair.Key, keyValuePair.Value);
		}
	}

	// Token: 0x06000721 RID: 1825 RVA: 0x00024B14 File Offset: 0x00022D14
	private void ExecuteIntMap(int id)
	{
		foreach (KeyValuePair<string, int> keyValuePair in this.TsIntMap)
		{
			BlackboardController.Instance.SetIntValueByEntity(id, keyValuePair.Key, keyValuePair.Value);
		}
	}

	// Token: 0x06000722 RID: 1826 RVA: 0x00024B7C File Offset: 0x00022D7C
	private void ExecuteBooleanMap(int id)
	{
		foreach (KeyValuePair<string, bool> keyValuePair in this.TsBooleanMap)
		{
			BlackboardController.Instance.SetBooleanValueByEntity(id, keyValuePair.Key, keyValuePair.Value);
		}
	}

	// Token: 0x06000723 RID: 1827 RVA: 0x00024BE4 File Offset: 0x00022DE4
	private void ExecuteVectorMap(int id)
	{
		foreach (KeyValuePair<string, FVector> keyValuePair in this.TsVectorMap)
		{
			string text;
			FVector fvector;
			keyValuePair.Deconstruct(out text, out fvector);
			string key = text;
			FVector fvector2 = fvector;
			BlackboardController.Instance.SetVectorValueByEntity(id, key, (double)fvector2.X, (double)fvector2.Y, (double)fvector2.Z);
		}
	}

	// Token: 0x06000724 RID: 1828 RVA: 0x00024C64 File Offset: 0x00022E64
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskBlackBoardSetValues._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskBlackBoardSetValues.TsTaskBlackBoardSetValues_C");
		}
		return TsTaskBlackBoardSetValues._ClassPtr;
	}

	// Token: 0x06000725 RID: 1829 RVA: 0x00024C88 File Offset: 0x00022E88
	public TsTaskBlackBoardSetValues() : this(BuiltinUtils.AllocNativeUObject(TsTaskBlackBoardSetValues.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000726 RID: 1830 RVA: 0x00024CB0 File Offset: 0x00022EB0
	public TsTaskBlackBoardSetValues(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskBlackBoardSetValues.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000727 RID: 1831 RVA: 0x00024CE3 File Offset: 0x00022EE3
	protected TsTaskBlackBoardSetValues(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000728 RID: 1832 RVA: 0x00024CEC File Offset: 0x00022EEC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000534 RID: 1332
	private bool IsInitTsVariables;

	// Token: 0x04000535 RID: 1333
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<string, string> TsStringMap;

	// Token: 0x04000536 RID: 1334
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<string, float> TsFloatMap;

	// Token: 0x04000537 RID: 1335
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<string, int> TsIntMap;

	// Token: 0x04000538 RID: 1336
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<string, bool> TsBooleanMap;

	// Token: 0x04000539 RID: 1337
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<string, FVector> TsVectorMap;

	// Token: 0x0400053A RID: 1338
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskBlackBoardSetValues.TsTaskBlackBoardSetValues_C";

	// Token: 0x0400053B RID: 1339
	private static IntPtr _ClassPtr;

	// Token: 0x0400053C RID: 1340
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400053D RID: 1341
	private static int __PropertyOffset_StringMap;

	// Token: 0x0400053E RID: 1342
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private TMap<string, string> _StringMap;

	// Token: 0x0400053F RID: 1343
	private static int __PropertyOffset_FloatMap;

	// Token: 0x04000540 RID: 1344
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TMap<string, float> _FloatMap;

	// Token: 0x04000541 RID: 1345
	private static int __PropertyOffset_IntMap;

	// Token: 0x04000542 RID: 1346
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TMap<string, int> _IntMap;

	// Token: 0x04000543 RID: 1347
	private static int __PropertyOffset_BooleanMap;

	// Token: 0x04000544 RID: 1348
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TMap<string, bool> _BooleanMap;

	// Token: 0x04000545 RID: 1349
	private static int __PropertyOffset_VectorMap;

	// Token: 0x04000546 RID: 1350
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TMap<string, FVector> _VectorMap;
}
