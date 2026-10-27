using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000016 RID: 22
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/LevelAiDecorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/LevelAiDecorator/TsDecoratorBlackboardValuesCompare.TsDecoratorBlackboardValuesCompare_C")]
public class TsDecoratorBlackboardValuesCompare : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700000A RID: 10
	// (get) Token: 0x06000052 RID: 82 RVA: 0x00002E40 File Offset: 0x00001040
	// (set) Token: 0x06000053 RID: 83 RVA: 0x00002E79 File Offset: 0x00001079
	[UProperty(EPropertyFlags.CPF_None)]
	public TMap<string, string> StringMap
	{
		get
		{
			base.FastCheckIsValid();
			TMap<string, string> result;
			if ((result = this._StringMap) == null)
			{
				result = (this._StringMap = new TMap<string, string>(base.NativePtr + (IntPtr)TsDecoratorBlackboardValuesCompare.__PropertyOffset_StringMap, this));
			}
			return result;
		}
		set
		{
			this.StringMap.CopyAssign(value);
		}
	}

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x06000054 RID: 84 RVA: 0x00002E88 File Offset: 0x00001088
	// (set) Token: 0x06000055 RID: 85 RVA: 0x00002EC1 File Offset: 0x000010C1
	[UProperty(EPropertyFlags.CPF_None)]
	public TMap<string, float> FloatMap
	{
		get
		{
			base.FastCheckIsValid();
			TMap<string, float> result;
			if ((result = this._FloatMap) == null)
			{
				result = (this._FloatMap = new TMap<string, float>(base.NativePtr + (IntPtr)TsDecoratorBlackboardValuesCompare.__PropertyOffset_FloatMap, this));
			}
			return result;
		}
		set
		{
			this.FloatMap.CopyAssign(value);
		}
	}

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x06000056 RID: 86 RVA: 0x00002ED0 File Offset: 0x000010D0
	// (set) Token: 0x06000057 RID: 87 RVA: 0x00002F09 File Offset: 0x00001109
	[UProperty(EPropertyFlags.CPF_None)]
	public TMap<string, int> IntMap
	{
		get
		{
			base.FastCheckIsValid();
			TMap<string, int> result;
			if ((result = this._IntMap) == null)
			{
				result = (this._IntMap = new TMap<string, int>(base.NativePtr + (IntPtr)TsDecoratorBlackboardValuesCompare.__PropertyOffset_IntMap, this));
			}
			return result;
		}
		set
		{
			this.IntMap.CopyAssign(value);
		}
	}

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x06000058 RID: 88 RVA: 0x00002F18 File Offset: 0x00001118
	// (set) Token: 0x06000059 RID: 89 RVA: 0x00002F51 File Offset: 0x00001151
	[UProperty(EPropertyFlags.CPF_None)]
	public TMap<string, bool> BooleanMap
	{
		get
		{
			base.FastCheckIsValid();
			TMap<string, bool> result;
			if ((result = this._BooleanMap) == null)
			{
				result = (this._BooleanMap = new TMap<string, bool>(base.NativePtr + (IntPtr)TsDecoratorBlackboardValuesCompare.__PropertyOffset_BooleanMap, this));
			}
			return result;
		}
		set
		{
			this.BooleanMap.CopyAssign(value);
		}
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x0600005A RID: 90 RVA: 0x00002F60 File Offset: 0x00001160
	// (set) Token: 0x0600005B RID: 91 RVA: 0x00002F99 File Offset: 0x00001199
	[UProperty(EPropertyFlags.CPF_None)]
	public TMap<string, FVector> VectorMap
	{
		get
		{
			base.FastCheckIsValid();
			TMap<string, FVector> result;
			if ((result = this._VectorMap) == null)
			{
				result = (this._VectorMap = new TMap<string, FVector>(base.NativePtr + (IntPtr)TsDecoratorBlackboardValuesCompare.__PropertyOffset_VectorMap, this));
			}
			return result;
		}
		set
		{
			this.VectorMap.CopyAssign(value);
		}
	}

	// Token: 0x0600005C RID: 92 RVA: 0x00002FA8 File Offset: 0x000011A8
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
				this.TsStringMap.Add(key, value);
			}
			foreach (KeyValuePair<string, float> keyValuePair2 in this.FloatMap)
			{
				string text2;
				float num;
				keyValuePair2.Deconstruct(out text2, out num);
				string key2 = text2;
				float value2 = num;
				this.TsFloatMap.Add(key2, value2);
			}
			foreach (KeyValuePair<string, int> keyValuePair3 in this.IntMap)
			{
				string text2;
				int num2;
				keyValuePair3.Deconstruct(out text2, out num2);
				string key3 = text2;
				int value3 = num2;
				this.TsIntMap.Add(key3, value3);
			}
			foreach (KeyValuePair<string, bool> keyValuePair4 in this.BooleanMap)
			{
				string text2;
				bool flag;
				keyValuePair4.Deconstruct(out text2, out flag);
				string key4 = text2;
				bool value4 = flag;
				this.TsBooleanMap.Add(key4, value4);
			}
			foreach (KeyValuePair<string, FVector> keyValuePair5 in this.VectorMap)
			{
				string text2;
				FVector fvector;
				keyValuePair5.Deconstruct(out text2, out fvector);
				string key5 = text2;
				FVector value5 = fvector;
				this.TsVectorMap.Add(key5, value5);
			}
		}
	}

	// Token: 0x0600005D RID: 93 RVA: 0x00003208 File Offset: 0x00001408
	private bool ExecuteStringMapCompare()
	{
		foreach (KeyValuePair<string, string> keyValuePair in this.TsStringMap)
		{
			string text;
			string text2;
			keyValuePair.Deconstruct(out text, out text2);
			string key = text;
			string b = text2;
			if (BlackboardController.Instance.GetStringValueByEntity(this.EntityId.Value, key) != b)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600005E RID: 94 RVA: 0x0000328C File Offset: 0x0000148C
	private bool ExecuteFloatMapCompare()
	{
		foreach (KeyValuePair<string, float> keyValuePair in this.TsFloatMap)
		{
			string text;
			float num;
			keyValuePair.Deconstruct(out text, out num);
			string key = text;
			float num2 = num;
			float? floatValueByEntity = BlackboardController.Instance.GetFloatValueByEntity(this.EntityId.Value, key);
			num = num2;
			if (!(floatValueByEntity.GetValueOrDefault() == num & floatValueByEntity != null))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600005F RID: 95 RVA: 0x00003320 File Offset: 0x00001520
	private bool ExecuteIntMapCompare()
	{
		foreach (KeyValuePair<string, int> keyValuePair in this.TsIntMap)
		{
			string text;
			int num;
			keyValuePair.Deconstruct(out text, out num);
			string key = text;
			int num2 = num;
			int? intValueByEntity = BlackboardController.Instance.GetIntValueByEntity(this.EntityId.Value, key);
			num = num2;
			if (!(intValueByEntity.GetValueOrDefault() == num & intValueByEntity != null))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06000060 RID: 96 RVA: 0x000033B4 File Offset: 0x000015B4
	private bool ExecuteBooleanMapCompare()
	{
		foreach (KeyValuePair<string, bool> keyValuePair in this.TsBooleanMap)
		{
			string text;
			bool flag;
			keyValuePair.Deconstruct(out text, out flag);
			string key = text;
			bool flag2 = flag;
			bool? booleanValueByEntity = BlackboardController.Instance.GetBooleanValueByEntity(this.EntityId.Value, key);
			flag = flag2;
			if (!(booleanValueByEntity.GetValueOrDefault() == flag & booleanValueByEntity != null))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06000061 RID: 97 RVA: 0x00003448 File Offset: 0x00001648
	private bool ExecuteVectorMapCompare()
	{
		foreach (KeyValuePair<string, FVector> keyValuePair in this.TsVectorMap)
		{
			string text;
			FVector fvector;
			keyValuePair.Deconstruct(out text, out fvector);
			string key = text;
			FVector fvector2 = fvector;
			Aki.Protocol.Vector vectorValueByEntity = BlackboardController.Instance.GetVectorValueByEntity(this.EntityId.Value, key);
			if (vectorValueByEntity == null)
			{
				return false;
			}
			if (!vectorValueByEntity.ToFVector().Equals(fvector2, 0.0001f))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06000062 RID: 98 RVA: 0x000034E8 File Offset: 0x000016E8
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool PerformConditionCheckAI(AAIController ownerController, APawn controlledPawn)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("PerformConditionCheckAI"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams*)ptr + 15L / (long)sizeof(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
			*(&ptr2->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x06000063 RID: 99 RVA: 0x00003588 File Offset: 0x00001788
	[NullableContext(2)]
	protected virtual bool PerformConditionCheckAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		AiController aiController = (ownerController as TsAiController).AiController;
		if (aiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		this.InitTsVariables();
		this.EntityId = new int?(aiController.CharActorComp.Entity.Id);
		return this.ExecuteIntMapCompare() && this.ExecuteStringMapCompare() && this.ExecuteBooleanMapCompare() && this.ExecuteFloatMapCompare() && this.ExecuteVectorMapCompare();
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00003622 File Offset: 0x00001822
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorBlackboardValuesCompare._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/LevelAiDecorator/TsDecoratorBlackboardValuesCompare.TsDecoratorBlackboardValuesCompare_C");
		}
		return TsDecoratorBlackboardValuesCompare._ClassPtr;
	}

	// Token: 0x06000065 RID: 101 RVA: 0x00003648 File Offset: 0x00001848
	public TsDecoratorBlackboardValuesCompare() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorBlackboardValuesCompare.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000066 RID: 102 RVA: 0x00003670 File Offset: 0x00001870
	public TsDecoratorBlackboardValuesCompare(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorBlackboardValuesCompare.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000067 RID: 103 RVA: 0x000036A3 File Offset: 0x000018A3
	protected TsDecoratorBlackboardValuesCompare(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000068 RID: 104 RVA: 0x000036AC File Offset: 0x000018AC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0400002B RID: 43
	private bool IsInitTsVariables;

	// Token: 0x0400002C RID: 44
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<string, string> TsStringMap;

	// Token: 0x0400002D RID: 45
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<string, float> TsFloatMap;

	// Token: 0x0400002E RID: 46
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<string, int> TsIntMap;

	// Token: 0x0400002F RID: 47
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<string, bool> TsBooleanMap;

	// Token: 0x04000030 RID: 48
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<string, FVector> TsVectorMap;

	// Token: 0x04000031 RID: 49
	private int? EntityId;

	// Token: 0x04000032 RID: 50
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/LevelAiDecorator/TsDecoratorBlackboardValuesCompare.TsDecoratorBlackboardValuesCompare_C";

	// Token: 0x04000033 RID: 51
	private static IntPtr _ClassPtr;

	// Token: 0x04000034 RID: 52
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000035 RID: 53
	private static int __PropertyOffset_StringMap;

	// Token: 0x04000036 RID: 54
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private TMap<string, string> _StringMap;

	// Token: 0x04000037 RID: 55
	private static int __PropertyOffset_FloatMap;

	// Token: 0x04000038 RID: 56
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TMap<string, float> _FloatMap;

	// Token: 0x04000039 RID: 57
	private static int __PropertyOffset_IntMap;

	// Token: 0x0400003A RID: 58
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TMap<string, int> _IntMap;

	// Token: 0x0400003B RID: 59
	private static int __PropertyOffset_BooleanMap;

	// Token: 0x0400003C RID: 60
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TMap<string, bool> _BooleanMap;

	// Token: 0x0400003D RID: 61
	private static int __PropertyOffset_VectorMap;

	// Token: 0x0400003E RID: 62
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TMap<string, FVector> _VectorMap;
}
