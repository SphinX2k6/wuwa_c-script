using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.CharacterDecal
{
	// Token: 0x02003DE2 RID: 15842
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/CharacterDecal/BP_Seq_CharacterDecalPostprocess.BP_Seq_CharacterDecalPostprocess_C")]
	[UnrealStructLayout(1896, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1896)]
	public class BP_Seq_CharacterDecalPostprocess_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602780C RID: 161804 RVA: 0x0099336A File Offset: 0x0099156A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Seq_CharacterDecalPostprocess_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Effect/CharacterDecal/BP_Seq_CharacterDecalPostprocess.BP_Seq_CharacterDecalPostprocess_C");
			}
			return BP_Seq_CharacterDecalPostprocess_C._ClassPtr;
		}

		// Token: 0x0602780D RID: 161805 RVA: 0x00993390 File Offset: 0x00991590
		public BP_Seq_CharacterDecalPostprocess_C() : this(BuiltinUtils.AllocNativeUObject(BP_Seq_CharacterDecalPostprocess_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602780E RID: 161806 RVA: 0x009933B8 File Offset: 0x009915B8
		[NullableContext(1)]
		public BP_Seq_CharacterDecalPostprocess_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Seq_CharacterDecalPostprocess_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005876 RID: 22646
		// (get) Token: 0x0602780F RID: 161807 RVA: 0x009933EB File Offset: 0x009915EB
		// (set) Token: 0x06027810 RID: 161808 RVA: 0x009933FF File Offset: 0x009915FF
		public unsafe UKuroPostProcessComponent KuroPostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005877 RID: 22647
		// (get) Token: 0x06027811 RID: 161809 RVA: 0x00993414 File Offset: 0x00991614
		// (set) Token: 0x06027812 RID: 161810 RVA: 0x00993428 File Offset: 0x00991628
		public unsafe UArrowComponent Arrow
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UArrowComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17005878 RID: 22648
		// (get) Token: 0x06027813 RID: 161811 RVA: 0x0099343D File Offset: 0x0099163D
		// (set) Token: 0x06027814 RID: 161812 RVA: 0x00993451 File Offset: 0x00991651
		public unsafe USphereComponent Sphere
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USphereComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17005879 RID: 22649
		// (get) Token: 0x06027815 RID: 161813 RVA: 0x00993466 File Offset: 0x00991666
		// (set) Token: 0x06027816 RID: 161814 RVA: 0x0099347A File Offset: 0x0099167A
		public unsafe UMaterialInterface MainMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700587A RID: 22650
		// (get) Token: 0x06027817 RID: 161815 RVA: 0x0099348F File Offset: 0x0099168F
		// (set) Token: 0x06027818 RID: 161816 RVA: 0x009934A3 File Offset: 0x009916A3
		public unsafe UTexture BaseTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x1700587B RID: 22651
		// (get) Token: 0x06027819 RID: 161817 RVA: 0x009934B8 File Offset: 0x009916B8
		// (set) Token: 0x0602781A RID: 161818 RVA: 0x009934CC File Offset: 0x009916CC
		public unsafe FLinearColor BaseTexEmissiveChannel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x1700587C RID: 22652
		// (get) Token: 0x0602781B RID: 161819 RVA: 0x009934E1 File Offset: 0x009916E1
		// (set) Token: 0x0602781C RID: 161820 RVA: 0x009934F5 File Offset: 0x009916F5
		public unsafe FLinearColor BaseTexAlphaChannel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x1700587D RID: 22653
		// (get) Token: 0x0602781D RID: 161821 RVA: 0x0099350A File Offset: 0x0099170A
		// (set) Token: 0x0602781E RID: 161822 RVA: 0x0099351E File Offset: 0x0099171E
		public unsafe FLinearColor BaseTexColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x1700587E RID: 22654
		// (get) Token: 0x0602781F RID: 161823 RVA: 0x00993533 File Offset: 0x00991733
		// (set) Token: 0x06027820 RID: 161824 RVA: 0x00993543 File Offset: 0x00991743
		public unsafe float BaseTex_UseChannelAsEmissive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x1700587F RID: 22655
		// (get) Token: 0x06027821 RID: 161825 RVA: 0x00993554 File Offset: 0x00991754
		// (set) Token: 0x06027822 RID: 161826 RVA: 0x00993564 File Offset: 0x00991764
		public unsafe float BaseTexDesaturation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17005880 RID: 22656
		// (get) Token: 0x06027823 RID: 161827 RVA: 0x00993575 File Offset: 0x00991775
		// (set) Token: 0x06027824 RID: 161828 RVA: 0x00993585 File Offset: 0x00991785
		public unsafe float BaseTexIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17005881 RID: 22657
		// (get) Token: 0x06027825 RID: 161829 RVA: 0x00993596 File Offset: 0x00991796
		// (set) Token: 0x06027826 RID: 161830 RVA: 0x009935A6 File Offset: 0x009917A6
		public unsafe float BaseTex_Alpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17005882 RID: 22658
		// (get) Token: 0x06027827 RID: 161831 RVA: 0x009935B7 File Offset: 0x009917B7
		// (set) Token: 0x06027828 RID: 161832 RVA: 0x009935C7 File Offset: 0x009917C7
		public unsafe float BaseTex_U_Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17005883 RID: 22659
		// (get) Token: 0x06027829 RID: 161833 RVA: 0x009935D8 File Offset: 0x009917D8
		// (set) Token: 0x0602782A RID: 161834 RVA: 0x009935E8 File Offset: 0x009917E8
		public unsafe float BaseTex_V_Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17005884 RID: 22660
		// (get) Token: 0x0602782B RID: 161835 RVA: 0x009935F9 File Offset: 0x009917F9
		// (set) Token: 0x0602782C RID: 161836 RVA: 0x00993609 File Offset: 0x00991809
		public unsafe float BaseTex_V_Pos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17005885 RID: 22661
		// (get) Token: 0x0602782D RID: 161837 RVA: 0x0099361A File Offset: 0x0099181A
		// (set) Token: 0x0602782E RID: 161838 RVA: 0x0099362A File Offset: 0x0099182A
		public unsafe float BaseTex_U_Pos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17005886 RID: 22662
		// (get) Token: 0x0602782F RID: 161839 RVA: 0x0099363B File Offset: 0x0099183B
		// (set) Token: 0x06027830 RID: 161840 RVA: 0x0099364B File Offset: 0x0099184B
		public unsafe float BaseTexUClamp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17005887 RID: 22663
		// (get) Token: 0x06027831 RID: 161841 RVA: 0x0099365C File Offset: 0x0099185C
		// (set) Token: 0x06027832 RID: 161842 RVA: 0x0099366C File Offset: 0x0099186C
		public unsafe float BaseTexVClamp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17005888 RID: 22664
		// (get) Token: 0x06027833 RID: 161843 RVA: 0x0099367D File Offset: 0x0099187D
		// (set) Token: 0x06027834 RID: 161844 RVA: 0x00993691 File Offset: 0x00991891
		public unsafe UTexture DissolveTex
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_19);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_19, value);
			}
		}

		// Token: 0x17005889 RID: 22665
		// (get) Token: 0x06027835 RID: 161845 RVA: 0x009936A6 File Offset: 0x009918A6
		// (set) Token: 0x06027836 RID: 161846 RVA: 0x009936BA File Offset: 0x009918BA
		public unsafe FLinearColor DissolveTexChannel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x1700588A RID: 22666
		// (get) Token: 0x06027837 RID: 161847 RVA: 0x009936CF File Offset: 0x009918CF
		// (set) Token: 0x06027838 RID: 161848 RVA: 0x009936DF File Offset: 0x009918DF
		public unsafe float Dissolve_Progress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x1700588B RID: 22667
		// (get) Token: 0x06027839 RID: 161849 RVA: 0x009936F0 File Offset: 0x009918F0
		// (set) Token: 0x0602783A RID: 161850 RVA: 0x00993700 File Offset: 0x00991900
		public unsafe float Dissolve_Smooth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x1700588C RID: 22668
		// (get) Token: 0x0602783B RID: 161851 RVA: 0x00993711 File Offset: 0x00991911
		// (set) Token: 0x0602783C RID: 161852 RVA: 0x00993725 File Offset: 0x00991925
		public unsafe FLinearColor Dissolve_EdgeColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x1700588D RID: 22669
		// (get) Token: 0x0602783D RID: 161853 RVA: 0x0099373A File Offset: 0x0099193A
		// (set) Token: 0x0602783E RID: 161854 RVA: 0x0099374A File Offset: 0x0099194A
		public unsafe float Dissolve_EdgeStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x1700588E RID: 22670
		// (get) Token: 0x0602783F RID: 161855 RVA: 0x0099375B File Offset: 0x0099195B
		// (set) Token: 0x06027840 RID: 161856 RVA: 0x0099376F File Offset: 0x0099196F
		public unsafe UMaterialInstanceDynamic DynamicMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_25);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_25, value);
			}
		}

		// Token: 0x1700588F RID: 22671
		// (get) Token: 0x06027841 RID: 161857 RVA: 0x00993784 File Offset: 0x00991984
		// (set) Token: 0x06027842 RID: 161858 RVA: 0x00993794 File Offset: 0x00991994
		public unsafe bool 不选中时允许编辑器Tick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_26) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_26) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005890 RID: 22672
		// (get) Token: 0x06027843 RID: 161859 RVA: 0x009937A8 File Offset: 0x009919A8
		// (set) Token: 0x06027844 RID: 161860 RVA: 0x009937E1 File Offset: 0x009919E1
		[Nullable(1)]
		public TMap<FName, float> Scalar_Parameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._Scalar_Parameters) == null)
				{
					result = (this._Scalar_Parameters = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_27, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Scalar_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x17005891 RID: 22673
		// (get) Token: 0x06027845 RID: 161861 RVA: 0x009937F0 File Offset: 0x009919F0
		// (set) Token: 0x06027846 RID: 161862 RVA: 0x00993829 File Offset: 0x00991A29
		[Nullable(1)]
		public TMap<FName, FLinearColor> Vector_Parameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._Vector_Parameters) == null)
				{
					result = (this._Vector_Parameters = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_28, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Vector_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x17005892 RID: 22674
		// (get) Token: 0x06027847 RID: 161863 RVA: 0x00993838 File Offset: 0x00991A38
		// (set) Token: 0x06027848 RID: 161864 RVA: 0x00993871 File Offset: 0x00991A71
		[Nullable(1)]
		public TMap<FName, UTexture> Texture_Parameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, UTexture> result;
				if ((result = this._Texture_Parameters) == null)
				{
					result = (this._Texture_Parameters = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)BP_Seq_CharacterDecalPostprocess_C.__PropertyOffset_29, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Texture_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x06027849 RID: 161865 RVA: 0x0099387F File Offset: 0x00991A7F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Update()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Seq_CharacterDecalPostprocess_C.__Update_NativeFunctionPtr, null);
		}

		// Token: 0x0602784A RID: 161866 RVA: 0x00993893 File Offset: 0x00991A93
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Seq_CharacterDecalPostprocess_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602784B RID: 161867 RVA: 0x009938A7 File Offset: 0x00991AA7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Seq_CharacterDecalPostprocess_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602784C RID: 161868 RVA: 0x009938BC File Offset: 0x00991ABC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Seq_CharacterDecalPostprocess_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602784D RID: 161869 RVA: 0x009938D0 File Offset: 0x00991AD0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Seq_CharacterDecalPostprocess_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602784E RID: 161870 RVA: 0x009938E8 File Offset: 0x00991AE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_Seq_CharacterDecalPostprocess_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Seq_CharacterDecalPostprocess_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Seq_CharacterDecalPostprocess_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Seq_CharacterDecalPostprocess_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Seq_CharacterDecalPostprocess_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602784F RID: 161871 RVA: 0x00993930 File Offset: 0x00991B30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_Seq_CharacterDecalPostprocess_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Seq_CharacterDecalPostprocess_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Seq_CharacterDecalPostprocess_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Seq_CharacterDecalPostprocess_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Seq_CharacterDecalPostprocess_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06027850 RID: 161872 RVA: 0x00993977 File Offset: 0x00991B77
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void EditorInit()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Seq_CharacterDecalPostprocess_C.__EditorInit_NativeFunctionPtr, null);
		}

		// Token: 0x06027851 RID: 161873 RVA: 0x0099398B File Offset: 0x00991B8B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void EditorInit_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Seq_CharacterDecalPostprocess_C.__EditorInit_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06027852 RID: 161874 RVA: 0x009939A0 File Offset: 0x00991BA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Seq_CharacterDecalPostprocess_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Seq_CharacterDecalPostprocess_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Seq_CharacterDecalPostprocess_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Seq_CharacterDecalPostprocess_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Seq_CharacterDecalPostprocess_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027853 RID: 161875 RVA: 0x009939E8 File Offset: 0x00991BE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Seq_CharacterDecalPostprocess_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Seq_CharacterDecalPostprocess_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Seq_CharacterDecalPostprocess_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Seq_CharacterDecalPostprocess_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Seq_CharacterDecalPostprocess_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06027854 RID: 161876 RVA: 0x00993A2F File Offset: 0x00991C2F
		protected BP_Seq_CharacterDecalPostprocess_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013F7B RID: 81787
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/CharacterDecal/BP_Seq_CharacterDecalPostprocess.BP_Seq_CharacterDecalPostprocess_C";

		// Token: 0x04013F7C RID: 81788
		private static IntPtr _ClassPtr;

		// Token: 0x04013F7D RID: 81789
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013F7E RID: 81790
		internal static int __PropertyOffset_1;

		// Token: 0x04013F7F RID: 81791
		internal static int __PropertyOffset_2;

		// Token: 0x04013F80 RID: 81792
		internal static int __PropertyOffset_3;

		// Token: 0x04013F81 RID: 81793
		internal static int __PropertyOffset_4;

		// Token: 0x04013F82 RID: 81794
		internal static int __PropertyOffset_5;

		// Token: 0x04013F83 RID: 81795
		internal static int __PropertyOffset_6;

		// Token: 0x04013F84 RID: 81796
		internal static int __PropertyOffset_7;

		// Token: 0x04013F85 RID: 81797
		internal static int __PropertyOffset_8;

		// Token: 0x04013F86 RID: 81798
		internal static int __PropertyOffset_9;

		// Token: 0x04013F87 RID: 81799
		internal static int __PropertyOffset_10;

		// Token: 0x04013F88 RID: 81800
		internal static int __PropertyOffset_11;

		// Token: 0x04013F89 RID: 81801
		internal static int __PropertyOffset_12;

		// Token: 0x04013F8A RID: 81802
		internal static int __PropertyOffset_13;

		// Token: 0x04013F8B RID: 81803
		internal static int __PropertyOffset_14;

		// Token: 0x04013F8C RID: 81804
		internal static int __PropertyOffset_15;

		// Token: 0x04013F8D RID: 81805
		internal static int __PropertyOffset_16;

		// Token: 0x04013F8E RID: 81806
		internal static int __PropertyOffset_17;

		// Token: 0x04013F8F RID: 81807
		internal static int __PropertyOffset_18;

		// Token: 0x04013F90 RID: 81808
		internal static int __PropertyOffset_19;

		// Token: 0x04013F91 RID: 81809
		internal static int __PropertyOffset_20;

		// Token: 0x04013F92 RID: 81810
		internal static int __PropertyOffset_21;

		// Token: 0x04013F93 RID: 81811
		internal static int __PropertyOffset_22;

		// Token: 0x04013F94 RID: 81812
		internal static int __PropertyOffset_23;

		// Token: 0x04013F95 RID: 81813
		internal static int __PropertyOffset_24;

		// Token: 0x04013F96 RID: 81814
		internal static int __PropertyOffset_25;

		// Token: 0x04013F97 RID: 81815
		internal static int __PropertyOffset_26;

		// Token: 0x04013F98 RID: 81816
		internal static int __PropertyOffset_27;

		// Token: 0x04013F99 RID: 81817
		private TMap<FName, float> _Scalar_Parameters;

		// Token: 0x04013F9A RID: 81818
		internal static int __PropertyOffset_28;

		// Token: 0x04013F9B RID: 81819
		private TMap<FName, FLinearColor> _Vector_Parameters;

		// Token: 0x04013F9C RID: 81820
		internal static int __PropertyOffset_29;

		// Token: 0x04013F9D RID: 81821
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _Texture_Parameters;

		// Token: 0x04013F9E RID: 81822
		private static IntPtr __Update_NativeFunctionPtr;

		// Token: 0x04013F9F RID: 81823
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04013FA0 RID: 81824
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04013FA1 RID: 81825
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04013FA2 RID: 81826
		private static IntPtr __EditorInit_NativeFunctionPtr;

		// Token: 0x04013FA3 RID: 81827
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0200A23F RID: 41535
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031ECC RID: 204492
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A240 RID: 41536
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031ECD RID: 204493
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
