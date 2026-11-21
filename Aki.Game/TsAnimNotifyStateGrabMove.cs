using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000138 RID: 312
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateGrabMove.TsAnimNotifyStateGrabMove_C")]
public class TsAnimNotifyStateGrabMove : TsAnimNotifyStateBase, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x06001324 RID: 4900 RVA: 0x0006D400 File Offset: 0x0006B600
	static TsAnimNotifyStateGrabMove()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsAnimNotifyStateGrabMove.CreateStaticDefaultValue), new Action(TsAnimNotifyStateGrabMove.ResetStaticDefaultValue));
	}

	// Token: 0x06001325 RID: 4901 RVA: 0x0006D451 File Offset: 0x0006B651
	public static void CreateStaticDefaultValue()
	{
		TsAnimNotifyStateGrabMove.QueryEntities = new List<EntityHandle>();
		TsAnimNotifyStateGrabMove.ParamPool = new List<TsAnimNotifyStateGrabMove.GrabMoveParams>();
		TsAnimNotifyStateGrabMove.TargetInfoPool = new List<TsAnimNotifyStateGrabMove.GrabTargetInfo>();
		TsAnimNotifyStateGrabMove.ParamMap = new Dictionary<int, TsAnimNotifyStateGrabMove.GrabMoveParams>();
	}

	// Token: 0x06001326 RID: 4902 RVA: 0x0006D47B File Offset: 0x0006B67B
	public static void ResetStaticDefaultValue()
	{
		TsAnimNotifyStateGrabMove.QueryEntities = null;
		TsAnimNotifyStateGrabMove.ParamPool = null;
		TsAnimNotifyStateGrabMove.TargetInfoPool = null;
		TsAnimNotifyStateGrabMove.ParamMap = null;
	}

	// Token: 0x17000326 RID: 806
	// (get) Token: 0x06001327 RID: 4903 RVA: 0x0006D498 File Offset: 0x0006B698
	// (set) Token: 0x06001328 RID: 4904 RVA: 0x0006D4D1 File Offset: 0x0006B6D1
	[UProperty(EPropertyFlags.CPF_None)]
	public FGameplayTagContainer 可抓取Tag
	{
		get
		{
			base.FastCheckIsValid();
			FGameplayTagContainer result;
			if ((result = this._可抓取Tag) == null)
			{
				result = (this._可抓取Tag = new FGameplayTagContainer(base.NativePtr + (IntPtr)TsAnimNotifyStateGrabMove.__PropertyOffset_可抓取Tag, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)TsAnimNotifyStateGrabMove.__PropertyOffset_可抓取Tag, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17000327 RID: 807
	// (get) Token: 0x06001329 RID: 4905 RVA: 0x0006D4FC File Offset: 0x0006B6FC
	// (set) Token: 0x0600132A RID: 4906 RVA: 0x0006D535 File Offset: 0x0006B735
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<string> 监听子弹Id列表
	{
		get
		{
			base.FastCheckIsValid();
			TArray<string> result;
			if ((result = this._监听子弹Id列表) == null)
			{
				result = (this._监听子弹Id列表 = new TArray<string>(base.NativePtr + (IntPtr)TsAnimNotifyStateGrabMove.__PropertyOffset_监听子弹Id列表, this));
			}
			return result;
		}
		set
		{
			this.监听子弹Id列表.CopyAssign(value);
		}
	}

	// Token: 0x17000328 RID: 808
	// (get) Token: 0x0600132B RID: 4907 RVA: 0x0006D543 File Offset: 0x0006B743
	// (set) Token: 0x0600132C RID: 4908 RVA: 0x0006D553 File Offset: 0x0006B753
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 命中后状态确认时间
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateGrabMove.__PropertyOffset_命中后状态确认时间);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateGrabMove.__PropertyOffset_命中后状态确认时间) = value;
		}
	}

	// Token: 0x17000329 RID: 809
	// (get) Token: 0x0600132D RID: 4909 RVA: 0x0006D564 File Offset: 0x0006B764
	// (set) Token: 0x0600132E RID: 4910 RVA: 0x0006D578 File Offset: 0x0006B778
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UCurveFloat 运动曲线
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateGrabMove.__PropertyOffset_运动曲线);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateGrabMove.__PropertyOffset_运动曲线, value);
		}
	}

	// Token: 0x1700032A RID: 810
	// (get) Token: 0x0600132F RID: 4911 RVA: 0x0006D58D File Offset: 0x0006B78D
	// (set) Token: 0x06001330 RID: 4912 RVA: 0x0006D59D File Offset: 0x0006B79D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 目标停留距离
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateGrabMove.__PropertyOffset_目标停留距离);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateGrabMove.__PropertyOffset_目标停留距离) = value;
		}
	}

	// Token: 0x1700032B RID: 811
	// (get) Token: 0x06001331 RID: 4913 RVA: 0x0006D5AE File Offset: 0x0006B7AE
	// (set) Token: 0x06001332 RID: 4914 RVA: 0x0006D5BE File Offset: 0x0006B7BE
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 抓取忽略双方半径
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateGrabMove.__PropertyOffset_抓取忽略双方半径) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateGrabMove.__PropertyOffset_抓取忽略双方半径) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700032C RID: 812
	// (get) Token: 0x06001333 RID: 4915 RVA: 0x0006D5CF File Offset: 0x0006B7CF
	// (set) Token: 0x06001334 RID: 4916 RVA: 0x0006D5DF File Offset: 0x0006B7DF
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 目标拉取期望时间
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateGrabMove.__PropertyOffset_目标拉取期望时间);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateGrabMove.__PropertyOffset_目标拉取期望时间) = value;
		}
	}

	// Token: 0x1700032D RID: 813
	// (get) Token: 0x06001335 RID: 4917 RVA: 0x0006D5F0 File Offset: 0x0006B7F0
	// (set) Token: 0x06001336 RID: 4918 RVA: 0x0006D600 File Offset: 0x0006B800
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 目标拉取最长时间
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateGrabMove.__PropertyOffset_目标拉取最长时间);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateGrabMove.__PropertyOffset_目标拉取最长时间) = value;
		}
	}

	// Token: 0x1700032E RID: 814
	// (get) Token: 0x06001337 RID: 4919 RVA: 0x0006D611 File Offset: 0x0006B811
	// (set) Token: 0x06001338 RID: 4920 RVA: 0x0006D621 File Offset: 0x0006B821
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 群体抓取
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateGrabMove.__PropertyOffset_群体抓取) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateGrabMove.__PropertyOffset_群体抓取) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700032F RID: 815
	// (get) Token: 0x06001339 RID: 4921 RVA: 0x0006D632 File Offset: 0x0006B832
	// (set) Token: 0x0600133A RID: 4922 RVA: 0x0006D642 File Offset: 0x0006B842
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 群体搜索半径
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateGrabMove.__PropertyOffset_群体搜索半径);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateGrabMove.__PropertyOffset_群体搜索半径) = value;
		}
	}

	// Token: 0x17000330 RID: 816
	// (get) Token: 0x0600133B RID: 4923 RVA: 0x0006D653 File Offset: 0x0006B853
	// (set) Token: 0x0600133C RID: 4924 RVA: 0x0006D663 File Offset: 0x0006B863
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 群体最大抓取数量
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateGrabMove.__PropertyOffset_群体最大抓取数量);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateGrabMove.__PropertyOffset_群体最大抓取数量) = value;
		}
	}

	// Token: 0x17000331 RID: 817
	// (get) Token: 0x0600133D RID: 4925 RVA: 0x0006D674 File Offset: 0x0006B874
	// (set) Token: 0x0600133E RID: 4926 RVA: 0x0006D684 File Offset: 0x0006B884
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 群体补抓窗口时间
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateGrabMove.__PropertyOffset_群体补抓窗口时间);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateGrabMove.__PropertyOffset_群体补抓窗口时间) = value;
		}
	}

	// Token: 0x17000332 RID: 818
	// (get) Token: 0x0600133F RID: 4927 RVA: 0x0006D695 File Offset: 0x0006B895
	// (set) Token: 0x06001340 RID: 4928 RVA: 0x0006D6A5 File Offset: 0x0006B8A5
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 群体保持相对布局
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateGrabMove.__PropertyOffset_群体保持相对布局) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateGrabMove.__PropertyOffset_群体保持相对布局) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000333 RID: 819
	// (get) Token: 0x06001341 RID: 4929 RVA: 0x0006D6B6 File Offset: 0x0006B8B6
	// (set) Token: 0x06001342 RID: 4930 RVA: 0x0006D6C6 File Offset: 0x0006B8C6
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 群体最大散布半径
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateGrabMove.__PropertyOffset_群体最大散布半径);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateGrabMove.__PropertyOffset_群体最大散布半径) = value;
		}
	}

	// Token: 0x17000334 RID: 820
	// (get) Token: 0x06001343 RID: 4931 RVA: 0x0006D6D7 File Offset: 0x0006B8D7
	// (set) Token: 0x06001344 RID: 4932 RVA: 0x0006D6E7 File Offset: 0x0006B8E7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 启用自身靠近
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateGrabMove.__PropertyOffset_启用自身靠近) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateGrabMove.__PropertyOffset_启用自身靠近) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000335 RID: 821
	// (get) Token: 0x06001345 RID: 4933 RVA: 0x0006D6F8 File Offset: 0x0006B8F8
	// (set) Token: 0x06001346 RID: 4934 RVA: 0x0006D708 File Offset: 0x0006B908
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 启用空中运动曲线
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateGrabMove.__PropertyOffset_启用空中运动曲线) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateGrabMove.__PropertyOffset_启用空中运动曲线) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000336 RID: 822
	// (get) Token: 0x06001347 RID: 4935 RVA: 0x0006D719 File Offset: 0x0006B919
	// (set) Token: 0x06001348 RID: 4936 RVA: 0x0006D72D File Offset: 0x0006B92D
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UCurveFloat 空中运动曲线
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateGrabMove.__PropertyOffset_空中运动曲线);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateGrabMove.__PropertyOffset_空中运动曲线, value);
		}
	}

	// Token: 0x17000337 RID: 823
	// (get) Token: 0x06001349 RID: 4937 RVA: 0x0006D742 File Offset: 0x0006B942
	// (set) Token: 0x0600134A RID: 4938 RVA: 0x0006D752 File Offset: 0x0006B952
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 空中运动高度
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateGrabMove.__PropertyOffset_空中运动高度);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateGrabMove.__PropertyOffset_空中运动高度) = value;
		}
	}

	// Token: 0x17000338 RID: 824
	// (get) Token: 0x0600134B RID: 4939 RVA: 0x0006D763 File Offset: 0x0006B963
	// (set) Token: 0x0600134C RID: 4940 RVA: 0x0006D773 File Offset: 0x0006B973
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 锁点前保留距离
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateGrabMove.__PropertyOffset_锁点前保留距离);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateGrabMove.__PropertyOffset_锁点前保留距离) = value;
		}
	}

	// Token: 0x17000339 RID: 825
	// (get) Token: 0x0600134D RID: 4941 RVA: 0x0006D784 File Offset: 0x0006B984
	// (set) Token: 0x0600134E RID: 4942 RVA: 0x0006D794 File Offset: 0x0006B994
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 自身靠近忽略双方半径
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateGrabMove.__PropertyOffset_自身靠近忽略双方半径) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateGrabMove.__PropertyOffset_自身靠近忽略双方半径) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700033A RID: 826
	// (get) Token: 0x0600134F RID: 4943 RVA: 0x0006D7A5 File Offset: 0x0006B9A5
	// (set) Token: 0x06001350 RID: 4944 RVA: 0x0006D7B5 File Offset: 0x0006B9B5
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 自身靠近期望时间
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateGrabMove.__PropertyOffset_自身靠近期望时间);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateGrabMove.__PropertyOffset_自身靠近期望时间) = value;
		}
	}

	// Token: 0x1700033B RID: 827
	// (get) Token: 0x06001351 RID: 4945 RVA: 0x0006D7C6 File Offset: 0x0006B9C6
	// (set) Token: 0x06001352 RID: 4946 RVA: 0x0006D7D6 File Offset: 0x0006B9D6
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 自身靠近最长时间
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateGrabMove.__PropertyOffset_自身靠近最长时间);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateGrabMove.__PropertyOffset_自身靠近最长时间) = value;
		}
	}

	// Token: 0x1700033C RID: 828
	// (get) Token: 0x06001353 RID: 4947 RVA: 0x0006D7E7 File Offset: 0x0006B9E7
	// (set) Token: 0x06001354 RID: 4948 RVA: 0x0006D7F7 File Offset: 0x0006B9F7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 自身高度偏移
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateGrabMove.__PropertyOffset_自身高度偏移);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateGrabMove.__PropertyOffset_自身高度偏移) = value;
		}
	}

	// Token: 0x1700033D RID: 829
	// (get) Token: 0x06001355 RID: 4949 RVA: 0x0006D808 File Offset: 0x0006BA08
	// (set) Token: 0x06001356 RID: 4950 RVA: 0x0006D818 File Offset: 0x0006BA18
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 自身最低落点高度
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateGrabMove.__PropertyOffset_自身最低落点高度);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateGrabMove.__PropertyOffset_自身最低落点高度) = value;
		}
	}

	// Token: 0x06001357 RID: 4951 RVA: 0x0006D82C File Offset: 0x0006BA2C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateGrabMove) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateGrabMove.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyBegin_Implementation(meshComp, animation, totalDuration);
		}
		UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		ptr->TotalDuration = totalDuration;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06001358 RID: 4952 RVA: 0x0006D8EC File Offset: 0x0006BAEC
	[NullableContext(2)]
	protected unsafe virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor aactor = (meshComp != null) ? meshComp.GetOwner() : null;
		TsBaseCharacter tsBaseCharacter = aactor as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.SZL;
			string message = "[GrabMove] Begin失败，Owner不是TsBaseCharacter";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("OwnerName", (aactor != null) ? aactor.GetName() : null);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
		Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
		if (entity == null || !entity.Valid)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Battle;
			ELogAuthor author2 = ELogAuthor.SZL;
			string message2 = "[GrabMove] Begin失败，Owner没有有效Entity";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("OwnerName", tsBaseCharacter.GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EntityId", tsBaseCharacter.EntityId);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		TsAnimNotifyStateGrabMove.GrabMoveParams grabMoveParams;
		if (TsAnimNotifyStateGrabMove.ParamMap.TryGetValue(tsBaseCharacter.EntityId, out grabMoveParams))
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Battle;
			ELogAuthor author3 = ELogAuthor.SZL;
			string message3 = "[GrabMove] Begin时发现旧上下文，先释放";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("OwnerEntity", tsBaseCharacter.EntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("OldState", this.GetStateName(grabMoveParams.State));
			instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			TsAnimNotifyStateGrabMove.ParamMap.Remove(tsBaseCharacter.EntityId);
			this.ReleaseParam(grabMoveParams);
		}
		BaseSkillComponent component = entity.GetComponent<BaseSkillComponent>();
		CharacterActorComponent characterActorComponent2 = tsBaseCharacter.CharacterActorComponent;
		BaseMoveComponent component2 = entity.GetComponent<BaseMoveComponent>();
		if (characterActorComponent2 == null || component2 == null)
		{
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.Battle;
			ELogAuthor author4 = ELogAuthor.SZL;
			string message4 = "[GrabMove] Begin失败，施法者组件缺失";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("OwnerEntity", entity.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("HasActorComp", characterActorComponent2 != null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("HasMoveComp", component2 != null);
			instance4.Info(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
			return false;
		}
		TsAnimNotifyStateGrabMove.GrabMoveParams grabMoveParams2 = this.AllocParam();
		grabMoveParams2.OwnerEntity = entity;
		grabMoveParams2.OwnerActorComp = characterActorComponent2;
		grabMoveParams2.OwnerMoveComp = component2;
		grabMoveParams2.SkillComp = component;
		grabMoveParams2.SelfStartLocation.DeepCopy(characterActorComponent2.ActorLocationProxy);
		this.InitBulletIdSet(grabMoveParams2);
		this.RefreshTarget(grabMoveParams2);
		this.BindOwnerHitEvent(grabMoveParams2);
		TsAnimNotifyStateGrabMove.ParamMap[tsBaseCharacter.EntityId] = grabMoveParams2;
		return true;
	}

	// Token: 0x06001359 RID: 4953 RVA: 0x0006DB7C File Offset: 0x0006BD7C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateGrabMove) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyTick"), TsAnimNotifyStateGrabMove.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyTick_Implementation(meshComp, animation, frameDeltaTime);
		}
		UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		ptr->FrameDeltaTime = frameDeltaTime;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0600135A RID: 4954 RVA: 0x0006DC3C File Offset: 0x0006BE3C
	[NullableContext(2)]
	protected unsafe virtual bool K2_NotifyTick_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		TsBaseCharacter tsBaseCharacter = ((meshComp != null) ? meshComp.GetOwner() : null) as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		TsAnimNotifyStateGrabMove.GrabMoveParams grabMoveParams;
		if (!TsAnimNotifyStateGrabMove.ParamMap.TryGetValue(tsBaseCharacter.EntityId, out grabMoveParams))
		{
			return false;
		}
		string invalidParamReason = this.GetInvalidParamReason(grabMoveParams, null);
		if (invalidParamReason != null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.SZL;
			string message = "[GrabMove] Tick上下文失效，释放";
			<>y__InlineArray7<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray7<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("OwnerEntity", tsBaseCharacter.EntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Reason", invalidParamReason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("State", this.GetStateName(grabMoveParams.State));
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3);
			string item = "TargetEntity";
			Entity targetEntity = grabMoveParams.TargetEntity;
			ptr = new ValueTuple<string, object>(item, (targetEntity != null) ? new int?(targetEntity.Id) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("HasOwnerActorComp", grabMoveParams.OwnerActorComp != null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("HasOwnerMoveComp", grabMoveParams.OwnerMoveComp != null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("HasTargetActorComp", grabMoveParams.TargetActorComp != null);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 7));
			TsAnimNotifyStateGrabMove.ParamMap.Remove(tsBaseCharacter.EntityId);
			this.ReleaseParam(grabMoveParams);
			return false;
		}
		switch (grabMoveParams.State)
		{
		case TsAnimNotifyStateGrabMove.EGrabMoveState.Waiting:
			this.TickWaiting(grabMoveParams, frameDeltaTime);
			break;
		case TsAnimNotifyStateGrabMove.EGrabMoveState.PullTargets:
			this.TickPullTargets(grabMoveParams, frameDeltaTime);
			break;
		case TsAnimNotifyStateGrabMove.EGrabMoveState.MoveSelf:
			this.TickMoveSelf(grabMoveParams, frameDeltaTime);
			break;
		}
		if (grabMoveParams.State == TsAnimNotifyStateGrabMove.EGrabMoveState.Finished)
		{
			TsAnimNotifyStateGrabMove.ParamMap.Remove(tsBaseCharacter.EntityId);
			this.ReleaseParam(grabMoveParams);
		}
		return true;
	}

	// Token: 0x0600135B RID: 4955 RVA: 0x0006DE30 File Offset: 0x0006C030
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateGrabMove) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateGrabMove.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyEnd_Implementation(meshComp, animation);
		}
		UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0600135C RID: 4956 RVA: 0x0006DEE8 File Offset: 0x0006C0E8
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = ((meshComp != null) ? meshComp.GetOwner() : null) as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		TsAnimNotifyStateGrabMove.GrabMoveParams grabParams;
		if (TsAnimNotifyStateGrabMove.ParamMap.TryGetValue(tsBaseCharacter.EntityId, out grabParams))
		{
			TsAnimNotifyStateGrabMove.ParamMap.Remove(tsBaseCharacter.EntityId);
			this.ReleaseParam(grabParams);
		}
		return true;
	}

	// Token: 0x0600135D RID: 4957 RVA: 0x0006DF3C File Offset: 0x0006C13C
	private void TickWaiting(TsAnimNotifyStateGrabMove.GrabMoveParams grabParams, float deltaTime)
	{
		if (!grabParams.MatchedBulletHit)
		{
			this.RefreshTarget(grabParams);
			return;
		}
		if (this.CheckTargetGrabbable(grabParams.TargetEntity, "TickWaiting即时判定"))
		{
			this.StartPullTargets(grabParams);
			return;
		}
		if (grabParams.HitConfirmTime > 0f)
		{
			grabParams.HitConfirmTime -= deltaTime;
			if (grabParams.HitConfirmTime <= 0f)
			{
				if (this.CheckTargetGrabbable(grabParams.TargetEntity, "HitConfirm结束判定"))
				{
					this.StartPullTargets(grabParams);
					return;
				}
				this.StartMoveSelf(grabParams);
			}
		}
	}

	// Token: 0x0600135E RID: 4958 RVA: 0x0006DFC0 File Offset: 0x0006C1C0
	private unsafe void TickPullTargets(TsAnimNotifyStateGrabMove.GrabMoveParams grabParams, float deltaTime)
	{
		if (grabParams.TargetInfos.Count == 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.SZL;
			string message = "[GrabMove] 拉目标阶段目标列表为空，结束";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "OwnerEntity";
			Entity ownerEntity = grabParams.OwnerEntity;
			ptr = new ValueTuple<string, object>(item, (ownerEntity != null) ? new int?(ownerEntity.Id) : null);
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item2 = "MainTarget";
			Entity targetEntity = grabParams.TargetEntity;
			ptr2 = new ValueTuple<string, object>(item2, (targetEntity != null) ? new int?(targetEntity.Id) : null);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			grabParams.State = TsAnimNotifyStateGrabMove.EGrabMoveState.Finished;
			return;
		}
		grabParams.PullTime += deltaTime;
		this.TickGroupSupplementCollect(grabParams, deltaTime);
		float timeRate = this.GetTimeRate(grabParams.PullTime, grabParams.PullDuration);
		float curveRate = this.GetCurveRate(this.运动曲线, timeRate);
		bool flag = timeRate >= 1f;
		foreach (TsAnimNotifyStateGrabMove.GrabTargetInfo grabTargetInfo in grabParams.TargetInfos)
		{
			Entity entity = grabTargetInfo.Entity;
			if (entity == null || !entity.Valid || grabTargetInfo.ActorComp == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Battle;
				ELogAuthor author2 = ELogAuthor.SZL;
				string message2 = "[GrabMove] 拉目标Tick跳过无效目标";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				ref ValueTuple<string, object> ptr3 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0);
				string item3 = "TargetEntity";
				Entity entity2 = grabTargetInfo.Entity;
				ptr3 = new ValueTuple<string, object>(item3, (entity2 != null) ? new int?(entity2.Id) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("HasActorComp", grabTargetInfo.ActorComp != null);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			}
			else
			{
				this.GetTargetAimLocation(grabParams, grabTargetInfo, this.TmpVector);
				this.CalcCurveLocation(grabTargetInfo.StartLocation, this.TmpVector, curveRate, this.TmpVector2);
				if (grabTargetInfo.UpdateWhirlpoolLocation(this.TmpVector2))
				{
					if (flag)
					{
						this.FinishPullTarget(grabTargetInfo, this.TmpVector2);
					}
				}
				else
				{
					this.TmpVector2.Subtraction(grabTargetInfo.ActorComp.ActorLocationProxy, this.TmpVector3);
					if (grabTargetInfo.TryMarkDirectMoveLogged())
					{
						Log instance3 = Log.Instance;
						ELogModule module3 = ELogModule.Battle;
						ELogAuthor author3 = ELogAuthor.SZL;
						string message3 = "[GrabMove] Whirlpool不可用，使用直接位移拉目标";
						<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray4<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("TargetEntity", grabTargetInfo.Entity.Id);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("AimLocation", this.TmpVector.ToString());
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("CurveLocation", this.TmpVector2.ToString());
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 3) = new ValueTuple<string, object>("Offset", this.TmpVector3.ToString());
						instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 4));
					}
					this.MoveActor(grabTargetInfo.ActorComp, this.TmpVector3, deltaTime, "TsAnimNotifyStateGrabMove.PullTarget");
					if (flag)
					{
						grabTargetInfo.RestoreCollision();
					}
				}
			}
		}
		if (flag)
		{
			grabParams.State = TsAnimNotifyStateGrabMove.EGrabMoveState.Finished;
		}
	}

	// Token: 0x0600135F RID: 4959 RVA: 0x0006E320 File Offset: 0x0006C520
	private void FinishPullTarget(TsAnimNotifyStateGrabMove.GrabTargetInfo targetInfo, Vector finishLocation)
	{
		BaseActorComponent actorComp = targetInfo.ActorComp;
		if (actorComp != null)
		{
			actorComp.SetActorLocation(finishLocation.ToUeVector(false), "TsAnimNotifyStateGrabMove.PullTargetFinish", true);
		}
		targetInfo.EndWhirlpool("TsAnimNotifyStateGrabMove.PullTargetFinished");
		targetInfo.RestoreCollision();
	}

	// Token: 0x06001360 RID: 4960 RVA: 0x0006E354 File Offset: 0x0006C554
	private void TickMoveSelf(TsAnimNotifyStateGrabMove.GrabMoveParams grabParams, float deltaTime)
	{
		if (grabParams.TargetActorComp == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.SZL;
			string message = "[GrabMove] 自身靠近阶段目标组件丢失，结束";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "OwnerEntity";
			Entity ownerEntity = grabParams.OwnerEntity;
			ptr = new ValueTuple<string, object>(item, (ownerEntity != null) ? new int?(ownerEntity.Id) : null);
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item2 = "TargetEntity";
			Entity targetEntity = grabParams.TargetEntity;
			ptr2 = new ValueTuple<string, object>(item2, (targetEntity != null) ? new int?(targetEntity.Id) : null);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			grabParams.State = TsAnimNotifyStateGrabMove.EGrabMoveState.Finished;
			return;
		}
		grabParams.MoveSelfTime += deltaTime;
		float totalTime = Math.Max(grabParams.MoveSelfDuration, 0.001f);
		float timeRate = this.GetTimeRate(grabParams.MoveSelfTime, totalTime);
		float curveRate = this.GetCurveRate(this.运动曲线, timeRate);
		this.GetSelfAimLocation(grabParams, this.TmpVector);
		this.CalcSelfMoveLocation(grabParams, this.TmpVector, curveRate, timeRate, this.TmpVector2);
		this.ApplySelfAirMoveHeight(grabParams, timeRate, this.TmpVector2);
		this.TmpVector2.Subtraction(grabParams.OwnerActorComp.ActorLocationProxy, this.TmpVector3);
		grabParams.OwnerMoveComp.MoveCharacter(this.TmpVector3, deltaTime, "TsAnimNotifyStateGrabMove.MoveSelf");
		this.FaceTarget(grabParams, "TsAnimNotifyStateGrabMove.MoveSelfFacing");
		if (timeRate >= 1f)
		{
			grabParams.State = TsAnimNotifyStateGrabMove.EGrabMoveState.Finished;
		}
	}

	// Token: 0x06001361 RID: 4961 RVA: 0x0006E4CC File Offset: 0x0006C6CC
	private unsafe void StartPullTargets(TsAnimNotifyStateGrabMove.GrabMoveParams grabParams)
	{
		string invalidParamReason = this.GetInvalidParamReason(grabParams, new bool?(true));
		if (grabParams.State != TsAnimNotifyStateGrabMove.EGrabMoveState.Waiting || invalidParamReason != null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.SZL;
			string message = "[GrabMove] StartPullTargets失败";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "OwnerEntity";
			Entity ownerEntity = grabParams.OwnerEntity;
			ptr = new ValueTuple<string, object>(item, (ownerEntity != null) ? new int?(ownerEntity.Id) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Reason", invalidParamReason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("State", this.GetStateName(grabParams.State));
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3);
			string item2 = "TargetEntity";
			Entity targetEntity = grabParams.TargetEntity;
			ptr2 = new ValueTuple<string, object>(item2, (targetEntity != null) ? new int?(targetEntity.Id) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("HasTargetActorComp", grabParams.TargetActorComp != null);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
			return;
		}
		grabParams.State = TsAnimNotifyStateGrabMove.EGrabMoveState.PullTargets;
		grabParams.PullTime = 0f;
		float num = this.IsGroupSearchEnabled() ? this.GetGroupSupplementCollectTime() : 0f;
		grabParams.GroupSupplementRemainTime = num;
		grabParams.MainTargetStartLocation.DeepCopy(grabParams.TargetActorComp.ActorLocationProxy);
		this.GetPlanarDirection(grabParams.OwnerActorComp.ActorLocationProxy, grabParams.MainTargetStartLocation, grabParams.OwnerActorComp, grabParams.PullDirection);
		this.CollectPullTargets(grabParams);
		this.UpdatePullDuration(grabParams, num);
	}

	// Token: 0x06001362 RID: 4962 RVA: 0x0006E668 File Offset: 0x0006C868
	private unsafe void StartMoveSelf(TsAnimNotifyStateGrabMove.GrabMoveParams grabParams)
	{
		if (!this.启用自身靠近)
		{
			grabParams.State = TsAnimNotifyStateGrabMove.EGrabMoveState.Finished;
			return;
		}
		string invalidParamReason = this.GetInvalidParamReason(grabParams, new bool?(true));
		if (grabParams.State != TsAnimNotifyStateGrabMove.EGrabMoveState.Waiting || invalidParamReason != null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.SZL;
			string message = "[GrabMove] StartMoveSelf失败";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "OwnerEntity";
			Entity ownerEntity = grabParams.OwnerEntity;
			ptr = new ValueTuple<string, object>(item, (ownerEntity != null) ? new int?(ownerEntity.Id) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Reason", invalidParamReason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("State", this.GetStateName(grabParams.State));
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3);
			string item2 = "TargetEntity";
			Entity targetEntity = grabParams.TargetEntity;
			ptr2 = new ValueTuple<string, object>(item2, (targetEntity != null) ? new int?(targetEntity.Id) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("HasTargetActorComp", grabParams.TargetActorComp != null);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
			return;
		}
		grabParams.State = TsAnimNotifyStateGrabMove.EGrabMoveState.MoveSelf;
		grabParams.MoveSelfTime = 0f;
		grabParams.SelfBaseHeightRate = 0f;
		grabParams.SelfStartLocation.DeepCopy(grabParams.OwnerActorComp.ActorLocationProxy);
		this.UpdateMoveSelfDuration(grabParams);
		if (!grabParams.SelfFallingSet)
		{
			grabParams.OwnerActorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
			{
				Mode = EMovementMode.MOVE_Falling,
				Context = "[TsAnimNotifyStateGrabMove.StartMoveSelf]"
			});
			grabParams.SelfFallingSet = true;
		}
	}

	// Token: 0x06001363 RID: 4963 RVA: 0x0006E80C File Offset: 0x0006CA0C
	private void CollectPullTargets(TsAnimNotifyStateGrabMove.GrabMoveParams grabParams)
	{
		grabParams.TargetInfos.Clear();
		this.AddPullTarget(grabParams, grabParams.TargetEntity, grabParams.TargetActorComp);
		if (!this.IsGroupSearchEnabled())
		{
			return;
		}
		List<EntityHandle> queryEntities = TsAnimNotifyStateGrabMove.QueryEntities;
		queryEntities.Clear();
		CreatureModel.Instance.GetEntitiesInRangeWithLocation(grabParams.MainTargetStartLocation, this.群体搜索半径, EEntityTypeQuery.Character, queryEntities, true);
		int groupMaxCount = this.GetGroupMaxCount();
		foreach (EntityHandle entityHandle in queryEntities)
		{
			if (grabParams.TargetInfos.Count >= groupMaxCount)
			{
				break;
			}
			WorldEntity entity = entityHandle.Entity;
			if (entityHandle.Valid && entity != null && entity.Valid && entity != grabParams.OwnerEntity && entity != grabParams.TargetEntity)
			{
				BaseActorComponent component = entity.GetComponent<BaseActorComponent>();
				if (component != null && this.CheckTargetGrabbable(entity, null))
				{
					this.AddPullTarget(grabParams, entity, component);
				}
			}
		}
	}

	// Token: 0x06001364 RID: 4964 RVA: 0x0006E914 File Offset: 0x0006CB14
	private void TickGroupSupplementCollect(TsAnimNotifyStateGrabMove.GrabMoveParams grabParams, float deltaTime)
	{
		if (grabParams.GroupSupplementRemainTime <= 0f || !this.IsGroupSearchEnabled())
		{
			return;
		}
		grabParams.GroupSupplementRemainTime -= deltaTime;
		int groupMaxCount = this.GetGroupMaxCount();
		if (grabParams.TargetInfos.Count >= groupMaxCount)
		{
			grabParams.GroupSupplementRemainTime = 0f;
			return;
		}
		List<EntityHandle> queryEntities = TsAnimNotifyStateGrabMove.QueryEntities;
		queryEntities.Clear();
		CreatureModel.Instance.GetEntitiesInRangeWithLocation(grabParams.MainTargetStartLocation, this.群体搜索半径, EEntityTypeQuery.Character, queryEntities, true);
		foreach (EntityHandle entityHandle in queryEntities)
		{
			if (grabParams.TargetInfos.Count >= groupMaxCount)
			{
				grabParams.GroupSupplementRemainTime = 0f;
				break;
			}
			WorldEntity entity = entityHandle.Entity;
			if (entityHandle.Valid && entity != null && entity.Valid && entity != grabParams.OwnerEntity && entity != grabParams.TargetEntity && !this.IsEntityInPullTargetList(grabParams, entity))
			{
				BaseActorComponent component = entity.GetComponent<BaseActorComponent>();
				if (component != null && this.CheckTargetGrabbable(entity, null))
				{
					this.AddPullTarget(grabParams, entity, component);
				}
			}
		}
	}

	// Token: 0x06001365 RID: 4965 RVA: 0x0006EA54 File Offset: 0x0006CC54
	private bool IsGroupSearchEnabled()
	{
		return this.群体抓取 && this.群体搜索半径 > 0f && this.群体最大抓取数量 != 1f;
	}

	// Token: 0x06001366 RID: 4966 RVA: 0x0006EA7D File Offset: 0x0006CC7D
	private int GetGroupMaxCount()
	{
		if (this.群体最大抓取数量 > 0f)
		{
			return Math.Max(1, (int)Math.Ceiling((double)this.群体最大抓取数量));
		}
		return int.MaxValue;
	}

	// Token: 0x06001367 RID: 4967 RVA: 0x0006EAA5 File Offset: 0x0006CCA5
	private float GetGroupSupplementCollectTime()
	{
		return Math.Max(0f, this.群体补抓窗口时间);
	}

	// Token: 0x06001368 RID: 4968 RVA: 0x0006EAB8 File Offset: 0x0006CCB8
	private bool IsEntityInPullTargetList(TsAnimNotifyStateGrabMove.GrabMoveParams grabParams, Entity entity)
	{
		using (List<TsAnimNotifyStateGrabMove.GrabTargetInfo>.Enumerator enumerator = grabParams.TargetInfos.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Entity == entity)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06001369 RID: 4969 RVA: 0x0006EB14 File Offset: 0x0006CD14
	private void AddPullTarget(TsAnimNotifyStateGrabMove.GrabMoveParams grabParams, Entity entity, BaseActorComponent actorComp)
	{
		TsAnimNotifyStateGrabMove.GrabTargetInfo grabTargetInfo = this.AllocTargetInfo();
		grabTargetInfo.Init(entity, actorComp, grabParams.MainTargetStartLocation);
		grabTargetInfo.DisableCollision();
		grabTargetInfo.BeginWhirlpool(entity.GetComponent<CharacterMoveComponent>());
		grabParams.TargetInfos.Add(grabTargetInfo);
	}

	// Token: 0x0600136A RID: 4970 RVA: 0x0006EB54 File Offset: 0x0006CD54
	private bool RefreshTarget(TsAnimNotifyStateGrabMove.GrabMoveParams grabParams)
	{
		if (grabParams.MatchedBulletHit)
		{
			Entity targetEntity = grabParams.TargetEntity;
			return targetEntity != null && targetEntity.Valid && grabParams.TargetActorComp != null;
		}
		BaseSkillComponent skillComp = grabParams.SkillComp;
		WorldEntity worldEntity;
		if (skillComp == null)
		{
			worldEntity = null;
		}
		else
		{
			EntityHandle skillTargetForAns = skillComp.GetSkillTargetForAns();
			worldEntity = ((skillTargetForAns != null) ? skillTargetForAns.Entity : null);
		}
		WorldEntity worldEntity2 = worldEntity;
		if (worldEntity2 == null || !worldEntity2.Valid || worldEntity2 == grabParams.OwnerEntity)
		{
			this.ClearTargetCache(grabParams);
			return false;
		}
		return this.SetTarget(grabParams, worldEntity2, true);
	}

	// Token: 0x0600136B RID: 4971 RVA: 0x0006EBD4 File Offset: 0x0006CDD4
	private unsafe bool SetTarget(TsAnimNotifyStateGrabMove.GrabMoveParams grabParams, Entity targetEntity, bool isSkillTarget)
	{
		if (grabParams.TargetEntity == targetEntity)
		{
			BaseActorComponent targetActorComp = grabParams.TargetActorComp;
			if (targetActorComp != null && targetActorComp.Valid)
			{
				grabParams.HasSkillTargetCache = (grabParams.HasSkillTargetCache || isSkillTarget);
				return true;
			}
		}
		BaseActorComponent component = targetEntity.GetComponent<BaseActorComponent>();
		BaseTagComponent component2 = targetEntity.GetComponent<BaseTagComponent>();
		if (component == null || component2 == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.SZL;
			string message = "[GrabMove] 设置目标失败：组件缺失";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("TargetEntity", targetEntity.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("HasActorComp", component != null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("HasTagComp", component2 != null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("IsSkillTarget", isSkillTarget);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			return false;
		}
		grabParams.TargetEntity = targetEntity;
		grabParams.TargetActorComp = component;
		grabParams.HasSkillTargetCache = isSkillTarget;
		return true;
	}

	// Token: 0x0600136C RID: 4972 RVA: 0x0006ECDF File Offset: 0x0006CEDF
	private void ClearTargetCache(TsAnimNotifyStateGrabMove.GrabMoveParams grabParams)
	{
		grabParams.TargetEntity = null;
		grabParams.TargetActorComp = null;
		grabParams.HasSkillTargetCache = false;
	}

	// Token: 0x0600136D RID: 4973 RVA: 0x0006ECF8 File Offset: 0x0006CEF8
	private void UpdatePullDuration(TsAnimNotifyStateGrabMove.GrabMoveParams grabParams, float groupSupplementTime)
	{
		float val = Math.Max(this.目标拉取期望时间, 0.001f);
		float val2 = Math.Max(this.目标拉取最长时间, 0.001f);
		float val3 = Math.Max(0f, groupSupplementTime);
		grabParams.PullDuration = Math.Min(Math.Max(val, val3), val2);
	}

	// Token: 0x0600136E RID: 4974 RVA: 0x0006ED48 File Offset: 0x0006CF48
	private void UpdateMoveSelfDuration(TsAnimNotifyStateGrabMove.GrabMoveParams grabParams)
	{
		float val = Math.Max(this.自身靠近期望时间, 0.001f);
		float val2 = Math.Max(this.自身靠近最长时间, 0.001f);
		grabParams.MoveSelfDuration = Math.Min(val, val2);
	}

	// Token: 0x0600136F RID: 4975 RVA: 0x0006ED84 File Offset: 0x0006CF84
	private void GetTargetAimLocation(TsAnimNotifyStateGrabMove.GrabMoveParams grabParams, TsAnimNotifyStateGrabMove.GrabTargetInfo targetInfo, Vector @out)
	{
		@out.DeepCopy(grabParams.OwnerActorComp.ActorLocationProxy);
		float targetStayDistance = this.GetTargetStayDistance(grabParams, targetInfo);
		grabParams.PullDirection.Multiply((double)targetStayDistance, this.TmpVector4);
		@out.AdditionEqual(this.TmpVector4);
		this.ApplyTargetPullHeight(grabParams, targetInfo, @out);
		if (this.群体抓取 && this.群体保持相对布局 && targetInfo.Entity != grabParams.TargetEntity)
		{
			this.TmpVector4.DeepCopy(targetInfo.RelativeOffset);
			this.ClampMoveOffset(this.TmpVector4, this.群体最大散布半径);
			@out.AdditionEqual(this.TmpVector4);
		}
	}

	// Token: 0x06001370 RID: 4976 RVA: 0x0006EE24 File Offset: 0x0006D024
	private void ApplyTargetPullHeight(TsAnimNotifyStateGrabMove.GrabMoveParams grabParams, TsAnimNotifyStateGrabMove.GrabTargetInfo targetInfo, Vector @out)
	{
		this.GetGravityUp(grabParams.OwnerMoveComp, this.TmpVector4);
		if (!this.TmpVector4.Normalize(9.99999993922529E-09))
		{
			this.TmpVector4.DeepCopy(Vector.UpVectorProxy);
		}
		Vector inA = (this.群体抓取 && this.群体保持相对布局 && targetInfo.Entity != grabParams.TargetEntity) ? grabParams.MainTargetStartLocation : targetInfo.StartLocation;
		double num = Vector.DotProduct(@out, this.TmpVector4);
		double num2 = Vector.DotProduct(inA, this.TmpVector4);
		this.TmpVector4.MultiplyEqual(num2 - num);
		@out.AdditionEqual(this.TmpVector4);
	}

	// Token: 0x06001371 RID: 4977 RVA: 0x0006EECA File Offset: 0x0006D0CA
	private void GetSelfAimLocation(TsAnimNotifyStateGrabMove.GrabMoveParams grabParams, Vector @out)
	{
		this.GetSkillTargetSocketAimLocation(grabParams, @out);
	}

	// Token: 0x06001372 RID: 4978 RVA: 0x0006EED4 File Offset: 0x0006D0D4
	private void GetSkillTargetSocketAimLocation(TsAnimNotifyStateGrabMove.GrabMoveParams grabParams, Vector @out)
	{
		BaseActorComponent targetActorComp = grabParams.TargetActorComp;
		TsBaseCharacter tsBaseCharacter = ((targetActorComp != null) ? targetActorComp.Owner : null) as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			USkeletalMeshComponent mesh = tsBaseCharacter.Mesh;
			if (mesh != null && mesh.IsValid())
			{
				BaseSkillComponent skillComp = grabParams.SkillComp;
				Entity entity;
				if (skillComp == null)
				{
					entity = null;
				}
				else
				{
					EntityHandle skillTarget = skillComp.SkillTarget;
					entity = ((skillTarget != null) ? skillTarget.Entity : null);
				}
				string text;
				if (entity != grabParams.TargetEntity)
				{
					text = "";
				}
				else
				{
					BaseSkillComponent skillComp2 = grabParams.SkillComp;
					text = ((skillComp2 != null) ? skillComp2.SkillTargetSocket : null);
				}
				string skillSocketName = text;
				FName? validSelfAimSocket = this.GetValidSelfAimSocket(tsBaseCharacter.Mesh, skillSocketName);
				if (validSelfAimSocket != null)
				{
					FVectorDouble fvectorDouble = tsBaseCharacter.Mesh.D_GetSocketLocation(validSelfAimSocket.Value);
					@out.FromUeVector(fvectorDouble);
					this.ApplySelfLockPointStayDistance(grabParams, @out);
					this.ApplySelfAimHeight(grabParams, @out);
					return;
				}
			}
		}
		@out.DeepCopy(grabParams.TargetActorComp.ActorLocationProxy);
		this.ApplySelfLockPointStayDistance(grabParams, @out);
		this.ApplySelfAimHeight(grabParams, @out);
	}

	// Token: 0x06001373 RID: 4979 RVA: 0x0006EFBC File Offset: 0x0006D1BC
	private FName? GetValidSelfAimSocket(USkeletalMeshComponent mesh, [Nullable(2)] string skillSocketName)
	{
		FName? dynamicFName = FNameUtil.GetDynamicFName(skillSocketName);
		if (dynamicFName != null && mesh.DoesSocketExist(dynamicFName.Value))
		{
			return new FName?(dynamicFName.Value);
		}
		if (mesh.DoesSocketExist(TsAnimNotifyStateGrabMove.HIT_CASE_SOCKET_NAME))
		{
			return new FName?(TsAnimNotifyStateGrabMove.HIT_CASE_SOCKET_NAME);
		}
		return null;
	}

	// Token: 0x06001374 RID: 4980 RVA: 0x0006F018 File Offset: 0x0006D218
	private void ApplySelfLockPointStayDistance(TsAnimNotifyStateGrabMove.GrabMoveParams grabParams, Vector @out)
	{
		float selfStayDistance = this.GetSelfStayDistance(grabParams);
		if ((double)selfStayDistance <= 0.0001)
		{
			return;
		}
		this.GetPlanarDirection(grabParams.SelfStartLocation, @out, grabParams.OwnerActorComp, this.TmpVector4);
		this.TmpVector4.MultiplyEqual((double)(-(double)selfStayDistance));
		@out.AdditionEqual(this.TmpVector4);
	}

	// Token: 0x06001375 RID: 4981 RVA: 0x0006F070 File Offset: 0x0006D270
	private void ApplySelfAimHeight(TsAnimNotifyStateGrabMove.GrabMoveParams grabParams, Vector @out)
	{
		if (grabParams.TargetActorComp == null)
		{
			return;
		}
		this.GetGravityUp(grabParams.OwnerMoveComp, this.TmpVector4);
		if (!this.TmpVector4.Normalize(9.99999993922529E-09))
		{
			this.TmpVector4.DeepCopy(Vector.UpVectorProxy);
		}
		double num = Vector.DotProduct(@out, this.TmpVector4);
		double val = this.GetTargetFloorHeight(grabParams.TargetActorComp, this.TmpVector4) + (double)Math.Max(0f, this.自身最低落点高度);
		double num2 = Math.Max(num + (double)this.自身高度偏移, val);
		this.TmpVector4.MultiplyEqual(num2 - num);
		@out.AdditionEqual(this.TmpVector4);
	}

	// Token: 0x06001376 RID: 4982 RVA: 0x0006F11C File Offset: 0x0006D31C
	private void ApplySelfAirMoveHeight(TsAnimNotifyStateGrabMove.GrabMoveParams grabParams, float timeRate, Vector @out)
	{
		if (!this.IsSelfAirMoveEnabled())
		{
			return;
		}
		this.GetGravityUp(grabParams.OwnerMoveComp, this.TmpVector4);
		if (!this.TmpVector4.Normalize(9.99999993922529E-09))
		{
			this.TmpVector4.DeepCopy(Vector.UpVectorProxy);
		}
		this.TmpVector4.MultiplyEqual((double)(this.GetSelfAirMoveRate(timeRate) * this.空中运动高度));
		@out.AdditionEqual(this.TmpVector4);
	}

	// Token: 0x06001377 RID: 4983 RVA: 0x0006F192 File Offset: 0x0006D392
	private bool IsSelfAirMoveEnabled()
	{
		return this.启用空中运动曲线 && (double)Math.Abs(this.空中运动高度) > 0.0001;
	}

	// Token: 0x06001378 RID: 4984 RVA: 0x0006F1B5 File Offset: 0x0006D3B5
	private float GetSelfAirMoveRate(float timeRate)
	{
		UCurveFloat 空中运动曲线 = this.空中运动曲线;
		if (空中运动曲线 != null && 空中运动曲线.IsValid())
		{
			return this.空中运动曲线.GetFloatValue(timeRate);
		}
		return (float)Math.Sin(3.141592653589793 * (double)timeRate);
	}

	// Token: 0x06001379 RID: 4985 RVA: 0x0006F1EC File Offset: 0x0006D3EC
	private float GetTargetStayDistance(TsAnimNotifyStateGrabMove.GrabMoveParams grabParams, TsAnimNotifyStateGrabMove.GrabTargetInfo targetInfo)
	{
		if (this.抓取忽略双方半径)
		{
			return this.目标停留距离;
		}
		float 目标停留距离 = this.目标停留距离;
		CharacterActorComponent ownerActorComp = grabParams.OwnerActorComp;
		float num = 目标停留距离 + ((ownerActorComp != null) ? ownerActorComp.ScaledRadius : 0f);
		BaseActorComponent actorComp = targetInfo.ActorComp;
		return num + ((actorComp != null) ? actorComp.ScaledRadius : 0f);
	}

	// Token: 0x0600137A RID: 4986 RVA: 0x0006F23C File Offset: 0x0006D43C
	private float GetSelfStayDistance(TsAnimNotifyStateGrabMove.GrabMoveParams grabParams)
	{
		float num = Math.Max(0f, this.锁点前保留距离);
		if (this.自身靠近忽略双方半径)
		{
			return num;
		}
		float num2 = num;
		CharacterActorComponent ownerActorComp = grabParams.OwnerActorComp;
		float num3 = num2 + ((ownerActorComp != null) ? ownerActorComp.ScaledRadius : 0f);
		BaseActorComponent targetActorComp = grabParams.TargetActorComp;
		return num3 + ((targetActorComp != null) ? targetActorComp.ScaledRadius : 0f);
	}

	// Token: 0x0600137B RID: 4987 RVA: 0x0006F294 File Offset: 0x0006D494
	private double GetTargetFloorHeight(BaseActorComponent actorComp, Vector gravityUp)
	{
		CharacterActorComponent characterActorComponent = actorComp as CharacterActorComponent;
		if (characterActorComponent != null)
		{
			return Vector.DotProduct(characterActorComponent.FloorLocation, gravityUp);
		}
		return Vector.DotProduct(actorComp.ActorLocationProxy, gravityUp) - (double)this.GetTargetScaledHalfHeight(actorComp);
	}

	// Token: 0x0600137C RID: 4988 RVA: 0x0006F2D0 File Offset: 0x0006D4D0
	private float GetTargetScaledHalfHeight(BaseActorComponent actorComp)
	{
		if ((double)actorComp.ScaledHalfHeight > 0.0001)
		{
			return actorComp.ScaledHalfHeight;
		}
		CharacterActorComponent characterActorComponent = actorComp as CharacterActorComponent;
		UCapsuleComponent ucapsuleComponent = (characterActorComponent != null) ? characterActorComponent.Actor.CapsuleComponent : null;
		if (ucapsuleComponent == null || !ucapsuleComponent.IsValid())
		{
			return 0f;
		}
		return ucapsuleComponent.GetScaledCapsuleHalfHeight();
	}

	// Token: 0x0600137D RID: 4989 RVA: 0x0006F328 File Offset: 0x0006D528
	private void FaceTarget(TsAnimNotifyStateGrabMove.GrabMoveParams grabParams, string reason)
	{
		BaseActorComponent targetActorComp = grabParams.TargetActorComp;
		if (targetActorComp == null || !targetActorComp.Valid)
		{
			return;
		}
		grabParams.TargetActorComp.ActorLocationProxy.Subtraction(grabParams.OwnerActorComp.ActorLocationProxy, this.TmpVector);
		if (this.TmpVector.SizeSquared() <= 1E-08)
		{
			return;
		}
		MathUtils instance = MathUtils.Instance;
		Vector tmpVector = this.TmpVector;
		BaseMoveComponent ownerMoveComp = grabParams.OwnerMoveComp;
		instance.LookRotationUpFirst(tmpVector, ((ownerMoveComp != null) ? ownerMoveComp.GravityUp : null) ?? Vector.UpVectorProxy, this.TmpQuat);
		this.TmpQuat.Rotator(this.TmpRotator);
		grabParams.OwnerActorComp.SetActorRotation(this.TmpRotator.ToUeRotator(), reason, false);
	}

	// Token: 0x0600137E RID: 4990 RVA: 0x0006F3E4 File Offset: 0x0006D5E4
	private void MoveActor(BaseActorComponent actorComp, Vector offset, float deltaTime, string reason)
	{
		BaseMoveComponent moveComp = actorComp.MoveComp;
		if (moveComp != null)
		{
			moveComp.MoveCharacter(offset, deltaTime, reason);
			return;
		}
		this.TmpVector.DeepCopy(actorComp.ActorLocationProxy);
		this.TmpVector.AdditionEqual(offset);
		actorComp.SetActorLocation(this.TmpVector.ToUeVector(false), reason, true);
	}

	// Token: 0x0600137F RID: 4991 RVA: 0x0006F43A File Offset: 0x0006D63A
	private void CalcCurveLocation(Vector start, Vector target, float rate, Vector @out)
	{
		target.Subtraction(start, @out);
		@out.MultiplyEqual((double)rate);
		@out.AdditionEqual(start);
	}

	// Token: 0x06001380 RID: 4992 RVA: 0x0006F45C File Offset: 0x0006D65C
	private void CalcSelfMoveLocation(TsAnimNotifyStateGrabMove.GrabMoveParams grabParams, Vector target, float planarRate, float timeRate, Vector @out)
	{
		this.GetGravityUp(grabParams.OwnerMoveComp, this.TmpVector4);
		if (!this.TmpVector4.Normalize(9.99999993922529E-09))
		{
			this.TmpVector4.DeepCopy(Vector.UpVectorProxy);
		}
		float val = (timeRate >= 1f) ? 1f : Math.Min(Math.Max(planarRate, 0f), 1f);
		grabParams.SelfBaseHeightRate = Math.Max(grabParams.SelfBaseHeightRate, val);
		target.Subtraction(grabParams.SelfStartLocation, @out);
		this.TmpVector4.Multiply(Vector.DotProduct(@out, this.TmpVector4), this.TmpVector3);
		@out.SubtractionEqual(this.TmpVector3);
		@out.MultiplyEqual((double)planarRate);
		@out.AdditionEqual(grabParams.SelfStartLocation);
		this.TmpVector3.MultiplyEqual((double)grabParams.SelfBaseHeightRate);
		@out.AdditionEqual(this.TmpVector3);
	}

	// Token: 0x06001381 RID: 4993 RVA: 0x0006F550 File Offset: 0x0006D750
	private void GetPlanarDirection(Vector from, Vector to, [Nullable(2)] BaseActorComponent actorComp, Vector @out)
	{
		to.Subtraction(from, @out);
		GravityUtils.Instance.ConvertToPlanarVectorForActor(actorComp, @out);
		if (@out.Normalize(9.99999993922529E-09))
		{
			return;
		}
		@out.DeepCopy(((actorComp != null) ? actorComp.ActorForwardProxy : null) ?? Vector.ForwardVectorProxy);
		GravityUtils.Instance.ConvertToPlanarVectorForActor(actorComp, @out);
		if (!@out.Normalize(9.99999993922529E-09))
		{
			@out.DeepCopy(Vector.ForwardVectorProxy);
		}
	}

	// Token: 0x06001382 RID: 4994 RVA: 0x0006F5D0 File Offset: 0x0006D7D0
	private void GetGravityUp([Nullable(2)] BaseMoveComponent moveComp, Vector @out)
	{
		@out.DeepCopy(((moveComp != null) ? moveComp.GravityUp : null) ?? Vector.UpVectorProxy);
	}

	// Token: 0x06001383 RID: 4995 RVA: 0x0006F5F0 File Offset: 0x0006D7F0
	private void ClampMoveOffset(Vector offset, float maxSize)
	{
		if (maxSize <= 0f)
		{
			offset.Reset();
			return;
		}
		double num = offset.Size();
		if (num > (double)maxSize && num > 0.0001)
		{
			offset.MultiplyEqual((double)maxSize / num);
		}
	}

	// Token: 0x06001384 RID: 4996 RVA: 0x0006F62F File Offset: 0x0006D82F
	private float GetTimeRate(float nowTime, float totalTime)
	{
		if (totalTime <= 0.001f)
		{
			return 1f;
		}
		return Math.Min(Math.Max(nowTime / totalTime, 0f), 1f);
	}

	// Token: 0x06001385 RID: 4997 RVA: 0x0006F656 File Offset: 0x0006D856
	[NullableContext(2)]
	private float GetCurveRate(UCurveFloat curve, float timeRate)
	{
		if (curve == null || !curve.IsValid())
		{
			return timeRate;
		}
		return curve.GetFloatValue(timeRate);
	}

	// Token: 0x06001386 RID: 4998 RVA: 0x0006F66C File Offset: 0x0006D86C
	[NullableContext(2)]
	private unsafe bool CheckTargetGrabbable(Entity entity, string stage = null)
	{
		if (entity == null || !entity.Valid)
		{
			if (stage != null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.SZL;
				string message = "[GrabMove] 可抓取判定失败：目标无效";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Stage", stage);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return false;
		}
		BaseTagComponent component = entity.GetComponent<BaseTagComponent>();
		if (component == null)
		{
			if (stage != null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Battle;
				ELogAuthor author2 = ELogAuthor.SZL;
				string message2 = "[GrabMove] 可抓取判定失败：目标没有Tag组件";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Stage", stage);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("TargetEntity", entity.Id);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			return false;
		}
		if (this.可抓取Tag.GameplayTags.Num() <= 0)
		{
			if (stage != null)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.Battle;
				ELogAuthor author3 = ELogAuthor.SZL;
				string message3 = "[GrabMove] 可抓取Tag为空，无法判定目标可抓取";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Stage", stage);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("TargetEntity", entity.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("启用自身靠近", this.启用自身靠近);
				instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			}
			return false;
		}
		return component.HasAnyTagContainer(this.可抓取Tag);
	}

	// Token: 0x06001387 RID: 4999 RVA: 0x0006F7C8 File Offset: 0x0006D9C8
	private bool IsMatchedHit(TsAnimNotifyStateGrabMove.GrabMoveParams grabParams, HitInformation hitData, HitContext hitContext)
	{
		if (grabParams.State != TsAnimNotifyStateGrabMove.EGrabMoveState.Waiting || grabParams.MatchedBulletHit)
		{
			return false;
		}
		if (hitContext.Attacker != grabParams.OwnerEntity)
		{
			return false;
		}
		if (!hitContext.Target.Valid)
		{
			return false;
		}
		if (hitContext.Target == grabParams.OwnerEntity)
		{
			return false;
		}
		if (grabParams.HasSkillTargetCache && hitContext.Target != grabParams.TargetEntity)
		{
			return false;
		}
		if (grabParams.BulletIdSet.Count <= 0)
		{
			return true;
		}
		string item = hitContext.BulletId.ToString();
		return grabParams.BulletIdSet.Contains(hitData.BulletRowName) || grabParams.BulletIdSet.Contains(item);
	}

	// Token: 0x06001388 RID: 5000 RVA: 0x0006F86C File Offset: 0x0006DA6C
	private void InitBulletIdSet(TsAnimNotifyStateGrabMove.GrabMoveParams grabParams)
	{
		TArray<string> 监听子弹Id列表 = this.监听子弹Id列表;
		int num = (监听子弹Id列表 != null) ? 监听子弹Id列表.Num() : 0;
		for (int i = 0; i < num; i++)
		{
			string text = 监听子弹Id列表.Get(i);
			if (!string.IsNullOrEmpty(text))
			{
				grabParams.BulletIdSet.Add(text);
			}
		}
	}

	// Token: 0x06001389 RID: 5001 RVA: 0x0006F8B8 File Offset: 0x0006DAB8
	private unsafe void BindOwnerHitEvent(TsAnimNotifyStateGrabMove.GrabMoveParams grabParams)
	{
		grabParams.OnOwnerHit = delegate(HitInformation hitData, HitContext hitContext)
		{
			if (!this.IsMatchedHit(grabParams, hitData, hitContext))
			{
				return;
			}
			if (!this.AcceptHitTarget(grabParams, hitContext.Target))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.SZL;
				string message = "[GrabMove] 命中目标未能被接受";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
				string item = "OwnerEntity";
				Entity ownerEntity = grabParams.OwnerEntity;
				ptr = new ValueTuple<string, object>(item, (ownerEntity != null) ? new int?(ownerEntity.Id) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("HitTarget", hitContext.Target.Id);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			grabParams.MatchedBulletHit = true;
			this.BindTargetMoveStateEvent(grabParams);
			if (this.CheckTargetGrabbable(grabParams.TargetEntity, "命中后即时判定"))
			{
				this.StartPullTargets(grabParams);
				return;
			}
			float hitConfirmTime = this.GetHitConfirmTime();
			if (hitConfirmTime <= 0f)
			{
				this.StartMoveSelf(grabParams);
				return;
			}
			grabParams.HitConfirmTime = hitConfirmTime;
		};
		EventSystem.Instance.AddWithTarget<HitInformation, HitContext>(grabParams.OwnerEntity, EEventName.CharHitLocal, grabParams.OnOwnerHit);
	}

	// Token: 0x0600138A RID: 5002 RVA: 0x0006F913 File Offset: 0x0006DB13
	private bool AcceptHitTarget(TsAnimNotifyStateGrabMove.GrabMoveParams grabParams, Entity hitTarget)
	{
		if (grabParams.HasSkillTargetCache)
		{
			return hitTarget == grabParams.TargetEntity && this.SetTarget(grabParams, hitTarget, true);
		}
		return this.SetTarget(grabParams, hitTarget, false);
	}

	// Token: 0x0600138B RID: 5003 RVA: 0x0006F93C File Offset: 0x0006DB3C
	private void BindTargetMoveStateEvent(TsAnimNotifyStateGrabMove.GrabMoveParams grabParams)
	{
		grabParams.OnTargetMoveStateChanged = delegate(ECharMoveState _oldMoveState, ECharMoveState newMoveState)
		{
			if (grabParams.State != TsAnimNotifyStateGrabMove.EGrabMoveState.Waiting || !grabParams.MatchedBulletHit)
			{
				return;
			}
			if ((newMoveState == ECharMoveState.KnockUp || newMoveState == ECharMoveState.Captured) && this.CheckTargetGrabbable(grabParams.TargetEntity, "MoveState变化后判定"))
			{
				this.StartPullTargets(grabParams);
			}
		};
		if (grabParams.TargetEntity != null)
		{
			grabParams.MoveStateEventTarget = grabParams.TargetEntity;
			EventSystem.Instance.AddWithTarget<ECharMoveState, ECharMoveState>(grabParams.TargetEntity, EEventName.CharOnUnifiedMoveStateChanged, grabParams.OnTargetMoveStateChanged);
		}
	}

	// Token: 0x0600138C RID: 5004 RVA: 0x0006F9BD File Offset: 0x0006DBBD
	private float GetHitConfirmTime()
	{
		return Math.Min(Math.Max(this.命中后状态确认时间, 0f), 0.08f);
	}

	// Token: 0x0600138D RID: 5005 RVA: 0x0006F9DC File Offset: 0x0006DBDC
	private string GetStateName(TsAnimNotifyStateGrabMove.EGrabMoveState state)
	{
		switch (state)
		{
		case TsAnimNotifyStateGrabMove.EGrabMoveState.Waiting:
			return "Waiting";
		case TsAnimNotifyStateGrabMove.EGrabMoveState.PullTargets:
			return "PullTargets";
		case TsAnimNotifyStateGrabMove.EGrabMoveState.MoveSelf:
			return "MoveSelf";
		case TsAnimNotifyStateGrabMove.EGrabMoveState.Finished:
			return "Finished";
		default:
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Unknown(");
			defaultInterpolatedStringHandler.AppendFormatted<TsAnimNotifyStateGrabMove.EGrabMoveState>(state);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		}
	}

	// Token: 0x0600138E RID: 5006 RVA: 0x0006FA4C File Offset: 0x0006DC4C
	[return: Nullable(2)]
	private string GetInvalidParamReason(TsAnimNotifyStateGrabMove.GrabMoveParams grabParams, bool? requireTarget = null)
	{
		bool flag = requireTarget ?? grabParams.MatchedBulletHit;
		Entity ownerEntity = grabParams.OwnerEntity;
		if (ownerEntity == null || !ownerEntity.Valid)
		{
			return "OwnerEntityInvalid";
		}
		CharacterActorComponent ownerActorComp = grabParams.OwnerActorComp;
		if (ownerActorComp == null || !ownerActorComp.Valid)
		{
			return "OwnerActorCompInvalid";
		}
		BaseMoveComponent ownerMoveComp = grabParams.OwnerMoveComp;
		if (ownerMoveComp == null || !ownerMoveComp.Valid)
		{
			return "OwnerMoveCompInvalid";
		}
		if (flag)
		{
			Entity targetEntity = grabParams.TargetEntity;
			if (targetEntity == null || !targetEntity.Valid)
			{
				return "TargetEntityInvalid";
			}
		}
		if (flag)
		{
			BaseActorComponent targetActorComp = grabParams.TargetActorComp;
			if (targetActorComp == null || !targetActorComp.Valid)
			{
				return "TargetActorCompInvalid";
			}
		}
		return null;
	}

	// Token: 0x0600138F RID: 5007 RVA: 0x0006FB0C File Offset: 0x0006DD0C
	private TsAnimNotifyStateGrabMove.GrabMoveParams AllocParam()
	{
		List<TsAnimNotifyStateGrabMove.GrabMoveParams> paramPool = TsAnimNotifyStateGrabMove.ParamPool;
		if (paramPool.Count <= 0)
		{
			return new TsAnimNotifyStateGrabMove.GrabMoveParams();
		}
		int index = paramPool.Count - 1;
		TsAnimNotifyStateGrabMove.GrabMoveParams result = paramPool[index];
		paramPool.RemoveAt(index);
		return result;
	}

	// Token: 0x06001390 RID: 5008 RVA: 0x0006FB48 File Offset: 0x0006DD48
	private void ReleaseParam(TsAnimNotifyStateGrabMove.GrabMoveParams grabParams)
	{
		foreach (TsAnimNotifyStateGrabMove.GrabTargetInfo grabTargetInfo in grabParams.TargetInfos)
		{
			grabTargetInfo.Clear();
			TsAnimNotifyStateGrabMove.TargetInfoPool.Add(grabTargetInfo);
		}
		grabParams.TargetInfos.Clear();
		grabParams.Clear();
		TsAnimNotifyStateGrabMove.ParamPool.Add(grabParams);
	}

	// Token: 0x06001391 RID: 5009 RVA: 0x0006FBC4 File Offset: 0x0006DDC4
	private TsAnimNotifyStateGrabMove.GrabTargetInfo AllocTargetInfo()
	{
		List<TsAnimNotifyStateGrabMove.GrabTargetInfo> targetInfoPool = TsAnimNotifyStateGrabMove.TargetInfoPool;
		if (targetInfoPool.Count <= 0)
		{
			return new TsAnimNotifyStateGrabMove.GrabTargetInfo();
		}
		int index = targetInfoPool.Count - 1;
		TsAnimNotifyStateGrabMove.GrabTargetInfo result = targetInfoPool[index];
		targetInfoPool.RemoveAt(index);
		return result;
	}

	// Token: 0x06001392 RID: 5010 RVA: 0x0006FC00 File Offset: 0x0006DE00
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateGrabMove) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateGrabMove.StaticClass(), out intPtr, out num))
		{
			return this.GetNotifyName_Implementation();
		}
		UAnimNotifyState.__GetNotifyName_FunctionParams* ptr = stackalloc UAnimNotifyState.__GetNotifyName_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UAnimNotifyState.__GetNotifyName_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x06001393 RID: 5011 RVA: 0x0006FC90 File Offset: 0x0006DE90
	protected override string GetNotifyName_Implementation()
	{
		return "抓取表现移动";
	}

	// Token: 0x06001394 RID: 5012 RVA: 0x0006FC97 File Offset: 0x0006DE97
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateGrabMove._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateGrabMove.TsAnimNotifyStateGrabMove_C");
		}
		return TsAnimNotifyStateGrabMove._ClassPtr;
	}

	// Token: 0x06001395 RID: 5013 RVA: 0x0006FCBC File Offset: 0x0006DEBC
	public TsAnimNotifyStateGrabMove() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateGrabMove.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001396 RID: 5014 RVA: 0x0006FCE4 File Offset: 0x0006DEE4
	public TsAnimNotifyStateGrabMove(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateGrabMove.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001397 RID: 5015 RVA: 0x0006FD18 File Offset: 0x0006DF18
	protected TsAnimNotifyStateGrabMove(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001398 RID: 5016 RVA: 0x0006FD94 File Offset: 0x0006DF94
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001399 RID: 5017 RVA: 0x0006FDD0 File Offset: 0x0006DFD0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x0600139A RID: 5018 RVA: 0x0006FE0C File Offset: 0x0006E00C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600139B RID: 5019 RVA: 0x0006FE3F File Offset: 0x0006E03F
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000E19 RID: 3609
	internal const string MOVE_REASON = "TsAnimNotifyStateGrabMove";

	// Token: 0x04000E1A RID: 3610
	internal const float MIN_CURVE_TIME = 0.001f;

	// Token: 0x04000E1B RID: 3611
	private static readonly FName HIT_CASE_SOCKET_NAME = new FName("HitCase");

	// Token: 0x04000E1C RID: 3612
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static List<EntityHandle> QueryEntities = null;

	// Token: 0x04000E1D RID: 3613
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static List<TsAnimNotifyStateGrabMove.GrabMoveParams> ParamPool = null;

	// Token: 0x04000E1E RID: 3614
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static List<TsAnimNotifyStateGrabMove.GrabTargetInfo> TargetInfoPool = null;

	// Token: 0x04000E1F RID: 3615
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Dictionary<int, TsAnimNotifyStateGrabMove.GrabMoveParams> ParamMap = null;

	// Token: 0x04000E20 RID: 3616
	private readonly Vector TmpVector = Vector.Create();

	// Token: 0x04000E21 RID: 3617
	private readonly Vector TmpVector2 = Vector.Create();

	// Token: 0x04000E22 RID: 3618
	private readonly Vector TmpVector3 = Vector.Create();

	// Token: 0x04000E23 RID: 3619
	private readonly Vector TmpVector4 = Vector.Create();

	// Token: 0x04000E24 RID: 3620
	private readonly Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x04000E25 RID: 3621
	private readonly Rotator TmpRotator = Rotator.Create();

	// Token: 0x04000E26 RID: 3622
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateGrabMove.TsAnimNotifyStateGrabMove_C";

	// Token: 0x04000E27 RID: 3623
	private static IntPtr _ClassPtr;

	// Token: 0x04000E28 RID: 3624
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000E29 RID: 3625
	private static int __PropertyOffset_可抓取Tag;

	// Token: 0x04000E2A RID: 3626
	[Nullable(2)]
	private FGameplayTagContainer _可抓取Tag;

	// Token: 0x04000E2B RID: 3627
	private static int __PropertyOffset_监听子弹Id列表;

	// Token: 0x04000E2C RID: 3628
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<string> _监听子弹Id列表;

	// Token: 0x04000E2D RID: 3629
	private static int __PropertyOffset_命中后状态确认时间;

	// Token: 0x04000E2E RID: 3630
	private static int __PropertyOffset_运动曲线;

	// Token: 0x04000E2F RID: 3631
	private static int __PropertyOffset_目标停留距离;

	// Token: 0x04000E30 RID: 3632
	private static int __PropertyOffset_抓取忽略双方半径;

	// Token: 0x04000E31 RID: 3633
	private static int __PropertyOffset_目标拉取期望时间;

	// Token: 0x04000E32 RID: 3634
	private static int __PropertyOffset_目标拉取最长时间;

	// Token: 0x04000E33 RID: 3635
	private static int __PropertyOffset_群体抓取;

	// Token: 0x04000E34 RID: 3636
	private static int __PropertyOffset_群体搜索半径;

	// Token: 0x04000E35 RID: 3637
	private static int __PropertyOffset_群体最大抓取数量;

	// Token: 0x04000E36 RID: 3638
	private static int __PropertyOffset_群体补抓窗口时间;

	// Token: 0x04000E37 RID: 3639
	private static int __PropertyOffset_群体保持相对布局;

	// Token: 0x04000E38 RID: 3640
	private static int __PropertyOffset_群体最大散布半径;

	// Token: 0x04000E39 RID: 3641
	private static int __PropertyOffset_启用自身靠近;

	// Token: 0x04000E3A RID: 3642
	private static int __PropertyOffset_启用空中运动曲线;

	// Token: 0x04000E3B RID: 3643
	private static int __PropertyOffset_空中运动曲线;

	// Token: 0x04000E3C RID: 3644
	private static int __PropertyOffset_空中运动高度;

	// Token: 0x04000E3D RID: 3645
	private static int __PropertyOffset_锁点前保留距离;

	// Token: 0x04000E3E RID: 3646
	private static int __PropertyOffset_自身靠近忽略双方半径;

	// Token: 0x04000E3F RID: 3647
	private static int __PropertyOffset_自身靠近期望时间;

	// Token: 0x04000E40 RID: 3648
	private static int __PropertyOffset_自身靠近最长时间;

	// Token: 0x04000E41 RID: 3649
	private static int __PropertyOffset_自身高度偏移;

	// Token: 0x04000E42 RID: 3650
	private static int __PropertyOffset_自身最低落点高度;

	// Token: 0x02006541 RID: 25921
	[NullableContext(0)]
	private enum EGrabMoveState
	{
		// Token: 0x04021973 RID: 137587
		Waiting,
		// Token: 0x04021974 RID: 137588
		PullTargets,
		// Token: 0x04021975 RID: 137589
		MoveSelf,
		// Token: 0x04021976 RID: 137590
		Finished
	}

	// Token: 0x02006542 RID: 25922
	[Nullable(0)]
	private class GrabTargetInfo
	{
		// Token: 0x0603EBB3 RID: 256947 RVA: 0x01244C60 File Offset: 0x01242E60
		public void Init(Entity entity, BaseActorComponent actorComp, Vector mainStartLocation)
		{
			this.Entity = entity;
			this.ActorComp = actorComp;
			this.StartLocation.DeepCopy(actorComp.ActorLocationProxy);
			this.StartLocation.Subtraction(mainStartLocation, this.RelativeOffset);
		}

		// Token: 0x0603EBB4 RID: 256948 RVA: 0x01244C94 File Offset: 0x01242E94
		[NullableContext(2)]
		public unsafe void BeginWhirlpool(CharacterMoveComponent moveComp)
		{
			if (moveComp == null || !moveComp.Valid || this.ActorComp == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.SZL;
				string message = "[GrabMove] 目标Whirlpool开启失败";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
				string item = "TargetEntity";
				Entity entity = this.Entity;
				ptr = new ValueTuple<string, object>(item, (entity != null) ? new int?(entity.Id) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("HasMoveComp", moveComp != null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("HasActorComp", this.ActorComp != null);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return;
			}
			this.MoveComp = moveComp;
			this.WhirlpoolId = WhirlpoolPoint.GenId();
			moveComp.BeginWhirlpool(this.WhirlpoolId, 0.001f, this.StartLocation, this.ActorComp.ActorLocationProxy, -1f, EVelocityCurveType.None, false, 0);
			this.WhirlpoolOpened = true;
		}

		// Token: 0x0603EBB5 RID: 256949 RVA: 0x01244DA4 File Offset: 0x01242FA4
		public void DisableCollision()
		{
			if (this.CollisionDisableHandle == null)
			{
				BaseActorComponent actorComp = this.ActorComp;
				if (actorComp != null && actorComp.Valid)
				{
					this.CollisionDisableHandle = new int?(this.ActorComp.DisableCollision("TsAnimNotifyStateGrabMove.DisableTargetCollision"));
					return;
				}
			}
		}

		// Token: 0x0603EBB6 RID: 256950 RVA: 0x01244DF1 File Offset: 0x01242FF1
		public void RestoreCollision()
		{
			if (this.CollisionDisableHandle == null)
			{
				return;
			}
			BaseActorComponent actorComp = this.ActorComp;
			if (actorComp != null)
			{
				actorComp.EnableCollision(this.CollisionDisableHandle.Value);
			}
			this.CollisionDisableHandle = null;
		}

		// Token: 0x0603EBB7 RID: 256951 RVA: 0x01244E2C File Offset: 0x0124302C
		public unsafe bool UpdateWhirlpoolLocation(Vector location)
		{
			if (this.WhirlpoolOpened)
			{
				CharacterMoveComponent moveComp = this.MoveComp;
				if (moveComp != null && moveComp.Valid)
				{
					if (!this.MoveComp.GetWhirlpoolEnable() || this.MoveComp.GetWhirlpoolId() != this.WhirlpoolId)
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.Battle;
						ELogAuthor author = ELogAuthor.SZL;
						string message = "[GrabMove] 目标Whirlpool已失效或被覆盖";
						<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
						ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
						string item = "TargetEntity";
						Entity entity = this.Entity;
						ptr = new ValueTuple<string, object>(item, (entity != null) ? new int?(entity.Id) : null);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SelfWhirlpoolId", this.WhirlpoolId);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("CurrentWhirlpoolId", this.MoveComp.GetWhirlpoolId());
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("CurrentEnable", this.MoveComp.GetWhirlpoolEnable());
						instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
						this.WhirlpoolOpened = false;
						this.MoveComp = null;
						return false;
					}
					this.MoveComp.UpdateWhirlpoolLocation(location);
					return true;
				}
			}
			return false;
		}

		// Token: 0x0603EBB8 RID: 256952 RVA: 0x01244F68 File Offset: 0x01243168
		public bool TryMarkDirectMoveLogged()
		{
			if (this.DirectMoveLogged)
			{
				return false;
			}
			this.DirectMoveLogged = true;
			return true;
		}

		// Token: 0x0603EBB9 RID: 256953 RVA: 0x01244F7C File Offset: 0x0124317C
		public void EndWhirlpool(string reason)
		{
			if (this.WhirlpoolOpened)
			{
				CharacterMoveComponent moveComp = this.MoveComp;
				if (moveComp != null && moveComp.Valid && this.MoveComp.GetWhirlpoolEnable() && this.MoveComp.GetWhirlpoolId() == this.WhirlpoolId)
				{
					this.MoveComp.EndWhirlpool(reason);
				}
			}
			this.WhirlpoolOpened = false;
			this.WhirlpoolId = 0;
			this.MoveComp = null;
		}

		// Token: 0x0603EBBA RID: 256954 RVA: 0x01244FE6 File Offset: 0x012431E6
		public void Clear()
		{
			this.EndWhirlpool("TsAnimNotifyStateGrabMove.ClearTarget");
			this.RestoreCollision();
			this.Entity = null;
			this.ActorComp = null;
			this.StartLocation.Reset();
			this.RelativeOffset.Reset();
			this.DirectMoveLogged = false;
		}

		// Token: 0x04021977 RID: 137591
		[Nullable(2)]
		public Entity Entity;

		// Token: 0x04021978 RID: 137592
		[Nullable(2)]
		public BaseActorComponent ActorComp;

		// Token: 0x04021979 RID: 137593
		[Nullable(2)]
		public CharacterMoveComponent MoveComp;

		// Token: 0x0402197A RID: 137594
		public readonly Vector StartLocation = Vector.Create();

		// Token: 0x0402197B RID: 137595
		public readonly Vector RelativeOffset = Vector.Create();

		// Token: 0x0402197C RID: 137596
		private int WhirlpoolId;

		// Token: 0x0402197D RID: 137597
		private bool WhirlpoolOpened;

		// Token: 0x0402197E RID: 137598
		private bool DirectMoveLogged;

		// Token: 0x0402197F RID: 137599
		private int? CollisionDisableHandle;
	}

	// Token: 0x02006543 RID: 25923
	[NullableContext(2)]
	[Nullable(0)]
	private class GrabMoveParams
	{
		// Token: 0x0603EBBC RID: 256956 RVA: 0x01245044 File Offset: 0x01243244
		public void Clear()
		{
			if (this.OwnerEntity != null && this.OnOwnerHit != null && EventSystem.Instance.HasWithTarget<HitInformation, HitContext>(this.OwnerEntity, EEventName.CharHitLocal, this.OnOwnerHit))
			{
				EventSystem.Instance.RemoveWithTarget<HitInformation, HitContext>(this.OwnerEntity, EEventName.CharHitLocal, this.OnOwnerHit);
			}
			if (this.MoveStateEventTarget != null && this.OnTargetMoveStateChanged != null && EventSystem.Instance.HasWithTarget<ECharMoveState, ECharMoveState>(this.MoveStateEventTarget, EEventName.CharOnUnifiedMoveStateChanged, this.OnTargetMoveStateChanged))
			{
				EventSystem.Instance.RemoveWithTarget<ECharMoveState, ECharMoveState>(this.MoveStateEventTarget, EEventName.CharOnUnifiedMoveStateChanged, this.OnTargetMoveStateChanged);
			}
			foreach (TsAnimNotifyStateGrabMove.GrabTargetInfo grabTargetInfo in this.TargetInfos)
			{
				grabTargetInfo.Clear();
			}
			this.TargetInfos.Clear();
			this.BulletIdSet.Clear();
			this.OwnerEntity = null;
			this.OwnerActorComp = null;
			this.OwnerMoveComp = null;
			this.SkillComp = null;
			this.TargetEntity = null;
			this.TargetActorComp = null;
			this.State = TsAnimNotifyStateGrabMove.EGrabMoveState.Waiting;
			this.PullTime = 0f;
			this.PullDuration = 0.001f;
			this.MoveSelfTime = 0f;
			this.MoveSelfDuration = 0.001f;
			this.SelfBaseHeightRate = 0f;
			this.HitConfirmTime = 0f;
			this.GroupSupplementRemainTime = 0f;
			this.MatchedBulletHit = false;
			this.HasSkillTargetCache = false;
			this.SelfFallingSet = false;
			this.SelfStartLocation.Reset();
			this.MainTargetStartLocation.Reset();
			this.PullDirection.Reset();
			this.OnOwnerHit = null;
			this.OnTargetMoveStateChanged = null;
			this.MoveStateEventTarget = null;
		}

		// Token: 0x04021980 RID: 137600
		public Entity OwnerEntity;

		// Token: 0x04021981 RID: 137601
		public CharacterActorComponent OwnerActorComp;

		// Token: 0x04021982 RID: 137602
		public BaseMoveComponent OwnerMoveComp;

		// Token: 0x04021983 RID: 137603
		public BaseSkillComponent SkillComp;

		// Token: 0x04021984 RID: 137604
		public Entity TargetEntity;

		// Token: 0x04021985 RID: 137605
		public BaseActorComponent TargetActorComp;

		// Token: 0x04021986 RID: 137606
		public TsAnimNotifyStateGrabMove.EGrabMoveState State;

		// Token: 0x04021987 RID: 137607
		public float PullTime;

		// Token: 0x04021988 RID: 137608
		public float PullDuration = 0.001f;

		// Token: 0x04021989 RID: 137609
		public float MoveSelfTime;

		// Token: 0x0402198A RID: 137610
		public float MoveSelfDuration = 0.001f;

		// Token: 0x0402198B RID: 137611
		public float SelfBaseHeightRate;

		// Token: 0x0402198C RID: 137612
		public float HitConfirmTime;

		// Token: 0x0402198D RID: 137613
		public float GroupSupplementRemainTime;

		// Token: 0x0402198E RID: 137614
		public bool MatchedBulletHit;

		// Token: 0x0402198F RID: 137615
		public bool HasSkillTargetCache;

		// Token: 0x04021990 RID: 137616
		public bool SelfFallingSet;

		// Token: 0x04021991 RID: 137617
		[Nullable(1)]
		public readonly Vector SelfStartLocation = Vector.Create();

		// Token: 0x04021992 RID: 137618
		[Nullable(1)]
		public readonly Vector MainTargetStartLocation = Vector.Create();

		// Token: 0x04021993 RID: 137619
		[Nullable(1)]
		public readonly Vector PullDirection = Vector.Create();

		// Token: 0x04021994 RID: 137620
		[Nullable(1)]
		public readonly HashSet<string> BulletIdSet = new HashSet<string>();

		// Token: 0x04021995 RID: 137621
		[Nullable(1)]
		public readonly List<TsAnimNotifyStateGrabMove.GrabTargetInfo> TargetInfos = new List<TsAnimNotifyStateGrabMove.GrabTargetInfo>();

		// Token: 0x04021996 RID: 137622
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Action<HitInformation, HitContext> OnOwnerHit;

		// Token: 0x04021997 RID: 137623
		public Action<ECharMoveState, ECharMoveState> OnTargetMoveStateChanged;

		// Token: 0x04021998 RID: 137624
		public Entity MoveStateEventTarget;
	}
}
