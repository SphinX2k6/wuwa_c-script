using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000094 RID: 148
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskCheckTarget.TsTaskCheckTarget_C")]
public class TsTaskCheckTarget : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700012B RID: 299
	// (get) Token: 0x06000773 RID: 1907 RVA: 0x00025EDB File Offset: 0x000240DB
	// (set) Token: 0x06000774 RID: 1908 RVA: 0x00025EEB File Offset: 0x000240EB
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool CheckSight
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskCheckTarget.__PropertyOffset_CheckSight) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskCheckTarget.__PropertyOffset_CheckSight) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700012C RID: 300
	// (get) Token: 0x06000775 RID: 1909 RVA: 0x00025EFC File Offset: 0x000240FC
	// (set) Token: 0x06000776 RID: 1910 RVA: 0x00025F0C File Offset: 0x0002410C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float CheckDistance
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskCheckTarget.__PropertyOffset_CheckDistance);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskCheckTarget.__PropertyOffset_CheckDistance) = value;
		}
	}

	// Token: 0x1700012D RID: 301
	// (get) Token: 0x06000777 RID: 1911 RVA: 0x00025F1D File Offset: 0x0002411D
	// (set) Token: 0x06000778 RID: 1912 RVA: 0x00025F2D File Offset: 0x0002412D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float CheckAngle
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskCheckTarget.__PropertyOffset_CheckAngle);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskCheckTarget.__PropertyOffset_CheckAngle) = value;
		}
	}

	// Token: 0x1700012E RID: 302
	// (get) Token: 0x06000779 RID: 1913 RVA: 0x00025F3E File Offset: 0x0002413E
	// (set) Token: 0x0600077A RID: 1914 RVA: 0x00025F4E File Offset: 0x0002414E
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float CheckHeight
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskCheckTarget.__PropertyOffset_CheckHeight);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskCheckTarget.__PropertyOffset_CheckHeight) = value;
		}
	}

	// Token: 0x1700012F RID: 303
	// (get) Token: 0x0600077B RID: 1915 RVA: 0x00025F5F File Offset: 0x0002415F
	// (set) Token: 0x0600077C RID: 1916 RVA: 0x00025F6F File Offset: 0x0002416F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool NeedCheckAutonomous
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskCheckTarget.__PropertyOffset_NeedCheckAutonomous) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskCheckTarget.__PropertyOffset_NeedCheckAutonomous) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000130 RID: 304
	// (get) Token: 0x0600077D RID: 1917 RVA: 0x00025F80 File Offset: 0x00024180
	// (set) Token: 0x0600077E RID: 1918 RVA: 0x00025F90 File Offset: 0x00024190
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int CheckCampRelevance
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskCheckTarget.__PropertyOffset_CheckCampRelevance);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskCheckTarget.__PropertyOffset_CheckCampRelevance) = value;
		}
	}

	// Token: 0x17000131 RID: 305
	// (get) Token: 0x0600077F RID: 1919 RVA: 0x00025FA1 File Offset: 0x000241A1
	// (set) Token: 0x06000780 RID: 1920 RVA: 0x00025FB1 File Offset: 0x000241B1
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe ECamp CheckCamp
	{
		get
		{
			return (ECamp)(*(base.NativePtr + (IntPtr)TsTaskCheckTarget.__PropertyOffset_CheckCamp));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskCheckTarget.__PropertyOffset_CheckCamp) = (byte)value;
		}
	}

	// Token: 0x17000132 RID: 306
	// (get) Token: 0x06000781 RID: 1921 RVA: 0x00025FC2 File Offset: 0x000241C2
	// (set) Token: 0x06000782 RID: 1922 RVA: 0x00025FD2 File Offset: 0x000241D2
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe ETargetPriority SelectTargetPriority
	{
		get
		{
			return (ETargetPriority)(*(base.NativePtr + (IntPtr)TsTaskCheckTarget.__PropertyOffset_SelectTargetPriority));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskCheckTarget.__PropertyOffset_SelectTargetPriority) = (byte)value;
		}
	}

	// Token: 0x17000133 RID: 307
	// (get) Token: 0x06000783 RID: 1923 RVA: 0x00025FE4 File Offset: 0x000241E4
	[Nullable(1)]
	[UProperty(EPropertyFlags.CPF_None)]
	public TMap<FGameplayTag, bool> CheckTags
	{
		[NullableContext(1)]
		get
		{
			base.FastCheckIsValid();
			TMap<FGameplayTag, bool> result;
			if ((result = this._CheckTags) == null)
			{
				result = (this._CheckTags = new TMap<FGameplayTag, bool>(base.NativePtr + (IntPtr)TsTaskCheckTarget.__PropertyOffset_CheckTags, this));
			}
			return result;
		}
	}

	// Token: 0x17000134 RID: 308
	// (get) Token: 0x06000784 RID: 1924 RVA: 0x0002601D File Offset: 0x0002421D
	// (set) Token: 0x06000785 RID: 1925 RVA: 0x0002602D File Offset: 0x0002422D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool KeepTarget
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskCheckTarget.__PropertyOffset_KeepTarget) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskCheckTarget.__PropertyOffset_KeepTarget) = (value ? 1 : 0);
		}
	}

	// Token: 0x06000786 RID: 1926 RVA: 0x00026040 File Offset: 0x00024240
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsCheckSight = this.CheckSight;
			this.TsNeedCheckAutonomous = this.NeedCheckAutonomous;
			this.TsCheckCampRelevance = this.CheckCampRelevance;
			this.TsCheckCamp = this.CheckCamp;
			this.TsSelectTargetPriority = this.SelectTargetPriority;
			this.TsKeepTarget = this.KeepTarget;
		}
	}

	// Token: 0x06000787 RID: 1927 RVA: 0x000260AC File Offset: 0x000242AC
	private void SwapAndClearTmpTargets()
	{
		HashSet<CharacterActorComponent> tmpTargets = this.TmpTargets;
		this.TmpTargets = this.TmpTargets2;
		this.TmpTargets2 = tmpTargets;
		this.TmpTargets.Clear();
	}

	// Token: 0x06000788 RID: 1928 RVA: 0x000260E0 File Offset: 0x000242E0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskCheckTarget) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskCheckTarget.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000789 RID: 1929 RVA: 0x00026190 File Offset: 0x00024390
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.InitTsVariables();
		if (this.DistanceRange == null)
		{
			this.DistanceRange = new double[]
			{
				-1E+50,
				(double)this.CheckDistance
			};
			this.AngleRange = new double[]
			{
				(double)(-(double)this.CheckAngle),
				(double)this.CheckAngle
			};
			this.HeightRange = new double[]
			{
				(double)(-(double)this.CheckHeight),
				(double)this.CheckHeight
			};
		}
	}

	// Token: 0x0600078A RID: 1930 RVA: 0x00026210 File Offset: 0x00024410
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskCheckTarget) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTickAI"), TsTaskCheckTarget.StaticClass(), out intPtr, out num))
		{
			this.ReceiveTickAI_Implementation(ownerController, controlledPawn, deltaSeconds);
			return;
		}
		UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* ptr = stackalloc UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
		*(&ptr->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		ptr->DeltaSeconds = deltaSeconds;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0600078B RID: 1931 RVA: 0x000262C8 File Offset: 0x000244C8
	protected virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
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
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		int? entityIdByEntity = BlackboardController.Instance.GetEntityIdByEntity(charActorComp.Entity.Id, "Target");
		BlackboardController.Instance.RemoveValueByEntity(charActorComp.Entity.Id, "TargetArray");
		BlackboardController.Instance.RemoveValueByEntity(charActorComp.Entity.Id, "Target");
		if (this.TmpTargets != null)
		{
			this.TmpTargets.Clear();
			this.TmpTargets2.Clear();
		}
		else
		{
			this.TmpTargets = new HashSet<CharacterActorComponent>();
			this.TmpTargets2 = new HashSet<CharacterActorComponent>();
		}
		this.RelevanceAndCamp(aiController, charActorComp);
		if (this.TmpTargets.Count == 0)
		{
			base.FinishExecute(false);
			return;
		}
		this.Tags();
		if (this.TmpTargets.Count == 0)
		{
			base.FinishExecute(false);
			return;
		}
		if (this.TsCheckSight)
		{
			this.SwapAndClearTmpTargets();
			foreach (CharacterActorComponent characterActorComponent in this.TmpTargets2)
			{
				if (MathUtils.Instance.LocationInRangeArray(charActorComp.FloorLocation, charActorComp.ActorRotationProxy, characterActorComponent.FloorLocation, (double)(charActorComp.ScaledRadius + characterActorComponent.ScaledRadius), this.DistanceRange, this.AngleRange, this.HeightRange))
				{
					this.TmpTargets.Add(characterActorComponent);
				}
			}
		}
		List<int> list = new List<int>();
		List<CharacterActorComponent> list2 = new List<CharacterActorComponent>();
		foreach (CharacterActorComponent characterActorComponent2 in this.TmpTargets)
		{
			if (!this.TsNeedCheckAutonomous || characterActorComponent2.IsAutonomousProxy)
			{
				list.Add(characterActorComponent2.Entity.Id);
				list2.Add(characterActorComponent2);
			}
		}
		if (list.Count == 0)
		{
			base.FinishExecute(false);
			return;
		}
		BlackboardController.Instance.SetIntValuesByEntity(charActorComp.Entity.Id, "TargetArray", list);
		int? num = entityIdByEntity;
		if (!this.TsKeepTarget || num == null || !list.Contains(num.Value))
		{
			num = new int?(this.SelectTarget(charActorComp, list2));
		}
		BlackboardController.Instance.SetEntityIdByEntity(charActorComp.Entity.Id, "Target", num.Value);
		base.FinishExecute(true);
	}

	// Token: 0x0600078C RID: 1932 RVA: 0x00026588 File Offset: 0x00024788
	[NullableContext(1)]
	private int SelectTarget(CharacterActorComponent character, List<CharacterActorComponent> targets)
	{
		if (this.TsSelectTargetPriority == ETargetPriority.随机)
		{
			return MathUtils.Instance.GetRandomItem<CharacterActorComponent>(targets).Entity.Id;
		}
		targets.Sort((CharacterActorComponent a, CharacterActorComponent b) => Vector.DistSquared(character.FloorLocation, a.FloorLocation).CompareTo(Vector.DistSquared(character.FloorLocation, b.FloorLocation)));
		if (this.TsSelectTargetPriority == ETargetPriority.主控优先)
		{
			foreach (CharacterActorComponent characterActorComponent in targets)
			{
				if (characterActorComponent.IsAutonomousProxy)
				{
					return characterActorComponent.Entity.Id;
				}
			}
		}
		return targets[0].Entity.Id;
	}

	// Token: 0x0600078D RID: 1933 RVA: 0x00026640 File Offset: 0x00024840
	[NullableContext(1)]
	private void RelevanceAndCamp(AiController aiController, CharacterActorComponent character)
	{
		if ((this.TsCheckCampRelevance & 1) > 0)
		{
			this.TmpTargets.Add(character);
		}
		if ((this.TsCheckCampRelevance & 2) > 0)
		{
			int id = aiController.CharAiDesignComp.Entity.Id;
			foreach (int num in aiController.AiPerception.Allies)
			{
				if (num != id)
				{
					CharacterActorComponent characterActorComponentById = CharacterController.Instance.GetCharacterActorComponentById(num);
					if (characterActorComponentById != null)
					{
						this.TmpTargets.Add(characterActorComponentById);
					}
				}
			}
		}
		if ((this.TsCheckCampRelevance & 4) > 0)
		{
			foreach (int id2 in aiController.AiPerception.AllEnemies)
			{
				CharacterActorComponent characterActorComponentById2 = CharacterController.Instance.GetCharacterActorComponentById(id2);
				if (characterActorComponentById2 != null)
				{
					this.TmpTargets.Add(characterActorComponentById2);
				}
			}
		}
		if ((this.TsCheckCampRelevance & 8) > 0)
		{
			foreach (int id3 in aiController.AiPerception.Neutrals)
			{
				CharacterActorComponent characterActorComponentById3 = CharacterController.Instance.GetCharacterActorComponentById(id3);
				if (characterActorComponentById3 != null)
				{
					this.TmpTargets.Add(characterActorComponentById3);
				}
			}
		}
		if (this.TsCheckCamp != ECamp.Camp_None)
		{
			this.SwapAndClearTmpTargets();
			foreach (CharacterActorComponent characterActorComponent in this.TmpTargets2)
			{
				if (characterActorComponent.Actor.Camp == this.TsCheckCamp)
				{
					this.TmpTargets.Add(characterActorComponent);
				}
			}
		}
	}

	// Token: 0x0600078E RID: 1934 RVA: 0x0002682C File Offset: 0x00024A2C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected virtual void Tags()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsTaskCheckTarget) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("Tags"), TsTaskCheckTarget.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.Tags_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0600078F RID: 1935 RVA: 0x00026888 File Offset: 0x00024A88
	protected void Tags_Implementation()
	{
		if (this.CheckTagsCopy == null)
		{
			this.NeedOneTag = false;
			this.CheckTagsCopy = new List<KeyValuePair<FGameplayTag, bool>>(this.CheckTags.Num());
			foreach (KeyValuePair<FGameplayTag, bool> item in this.CheckTags)
			{
				this.CheckTagsCopy.Add(item);
				if (item.Value)
				{
					this.NeedOneTag = true;
				}
			}
		}
		if (this.CheckTagsCopy.Count > 0)
		{
			this.SwapAndClearTmpTargets();
			foreach (CharacterActorComponent characterActorComponent in this.TmpTargets2)
			{
				BaseTagComponent component = characterActorComponent.Entity.GetComponent<BaseTagComponent>();
				if (component == null || !component.Valid)
				{
					if (!this.NeedOneTag)
					{
						this.TmpTargets.Add(characterActorComponent);
					}
				}
				else
				{
					bool flag = true;
					foreach (KeyValuePair<FGameplayTag, bool> keyValuePair in this.CheckTagsCopy)
					{
						FGameplayTag fgameplayTag;
						bool flag2;
						keyValuePair.Deconstruct(out fgameplayTag, out flag2);
						FGameplayTag tag = fgameplayTag;
						bool flag3 = flag2;
						if (component.HasTag(tag.TagId()) != flag3)
						{
							flag = false;
							break;
						}
					}
					if (flag)
					{
						this.TmpTargets.Add(characterActorComponent);
					}
				}
			}
		}
	}

	// Token: 0x06000790 RID: 1936 RVA: 0x00026A20 File Offset: 0x00024C20
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskCheckTarget._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskCheckTarget.TsTaskCheckTarget_C");
		}
		return TsTaskCheckTarget._ClassPtr;
	}

	// Token: 0x06000791 RID: 1937 RVA: 0x00026A44 File Offset: 0x00024C44
	public TsTaskCheckTarget() : this(BuiltinUtils.AllocNativeUObject(TsTaskCheckTarget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000792 RID: 1938 RVA: 0x00026A6C File Offset: 0x00024C6C
	[NullableContext(1)]
	public TsTaskCheckTarget(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskCheckTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000793 RID: 1939 RVA: 0x00026A9F File Offset: 0x00024C9F
	protected TsTaskCheckTarget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000794 RID: 1940 RVA: 0x00026AB0 File Offset: 0x00024CB0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000795 RID: 1941 RVA: 0x00026AE0 File Offset: 0x00024CE0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x06000796 RID: 1942 RVA: 0x00026B13 File Offset: 0x00024D13
	protected virtual void __CPPCALL_Tags_Implementation()
	{
		this.Tags_Implementation();
	}

	// Token: 0x04000573 RID: 1395
	private const int SELF_MASK = 1;

	// Token: 0x04000574 RID: 1396
	private const int ALLY_MASK = 2;

	// Token: 0x04000575 RID: 1397
	private const int ENEMY_MASK = 4;

	// Token: 0x04000576 RID: 1398
	private const int NEUTRAL_MASK = 8;

	// Token: 0x04000577 RID: 1399
	private bool IsInitTsVariables;

	// Token: 0x04000578 RID: 1400
	private bool TsCheckSight;

	// Token: 0x04000579 RID: 1401
	private bool TsNeedCheckAutonomous;

	// Token: 0x0400057A RID: 1402
	private int TsCheckCampRelevance;

	// Token: 0x0400057B RID: 1403
	private ECamp TsCheckCamp;

	// Token: 0x0400057C RID: 1404
	private ETargetPriority TsSelectTargetPriority = ETargetPriority.随机;

	// Token: 0x0400057D RID: 1405
	private bool TsKeepTarget;

	// Token: 0x0400057E RID: 1406
	private double[] DistanceRange;

	// Token: 0x0400057F RID: 1407
	private double[] AngleRange;

	// Token: 0x04000580 RID: 1408
	private double[] HeightRange;

	// Token: 0x04000581 RID: 1409
	[Nullable(new byte[]
	{
		2,
		0
	})]
	private List<KeyValuePair<FGameplayTag, bool>> CheckTagsCopy;

	// Token: 0x04000582 RID: 1410
	private bool NeedOneTag;

	// Token: 0x04000583 RID: 1411
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private HashSet<CharacterActorComponent> TmpTargets;

	// Token: 0x04000584 RID: 1412
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private HashSet<CharacterActorComponent> TmpTargets2;

	// Token: 0x04000585 RID: 1413
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskCheckTarget.TsTaskCheckTarget_C";

	// Token: 0x04000586 RID: 1414
	private static IntPtr _ClassPtr;

	// Token: 0x04000587 RID: 1415
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000588 RID: 1416
	private static int __PropertyOffset_CheckSight;

	// Token: 0x04000589 RID: 1417
	private static int __PropertyOffset_CheckDistance;

	// Token: 0x0400058A RID: 1418
	private static int __PropertyOffset_CheckAngle;

	// Token: 0x0400058B RID: 1419
	private static int __PropertyOffset_CheckHeight;

	// Token: 0x0400058C RID: 1420
	private static int __PropertyOffset_NeedCheckAutonomous;

	// Token: 0x0400058D RID: 1421
	private static int __PropertyOffset_CheckCampRelevance;

	// Token: 0x0400058E RID: 1422
	private static int __PropertyOffset_CheckCamp;

	// Token: 0x0400058F RID: 1423
	private static int __PropertyOffset_SelectTargetPriority;

	// Token: 0x04000590 RID: 1424
	private static int __PropertyOffset_CheckTags;

	// Token: 0x04000591 RID: 1425
	private TMap<FGameplayTag, bool> _CheckTags;

	// Token: 0x04000592 RID: 1426
	private static int __PropertyOffset_KeepTarget;
}
