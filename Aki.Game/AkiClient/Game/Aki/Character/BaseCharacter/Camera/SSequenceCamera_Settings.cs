using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033E9 RID: 13289
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/SSequenceCamera_Settings.SSequenceCamera_Settings")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 66)]
	public class SSequenceCamera_Settings : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021B4A RID: 138058 RVA: 0x0096756D File Offset: 0x0096576D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSequenceCamera_Settings._ScriptStructPtr != 0) ? SSequenceCamera_Settings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/SSequenceCamera_Settings.SSequenceCamera_Settings", ref SSequenceCamera_Settings._ScriptStructPtr);
		}

		// Token: 0x170045C8 RID: 17864
		// (get) Token: 0x06021B4B RID: 138059 RVA: 0x00967591 File Offset: 0x00965791
		// (set) Token: 0x06021B4C RID: 138060 RVA: 0x009675A1 File Offset: 0x009657A1
		public unsafe float BlendInTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSequenceCamera_Settings.__PropertyOffset_BlendInTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSequenceCamera_Settings.__PropertyOffset_BlendInTime) = value;
			}
		}

		// Token: 0x170045C9 RID: 17865
		// (get) Token: 0x06021B4D RID: 138061 RVA: 0x009675B2 File Offset: 0x009657B2
		// (set) Token: 0x06021B4E RID: 138062 RVA: 0x009675C2 File Offset: 0x009657C2
		public unsafe float BlendOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSequenceCamera_Settings.__PropertyOffset_BlendOutTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSequenceCamera_Settings.__PropertyOffset_BlendOutTime) = value;
			}
		}

		// Token: 0x170045CA RID: 17866
		// (get) Token: 0x06021B4F RID: 138063 RVA: 0x009675D3 File Offset: 0x009657D3
		// (set) Token: 0x06021B50 RID: 138064 RVA: 0x009675E7 File Offset: 0x009657E7
		[Nullable(2)]
		public unsafe ULevelSequence CameraSequence
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULevelSequence>(base.NativePtr / (IntPtr)sizeof(void*) + SSequenceCamera_Settings.__PropertyOffset_CameraSequence);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SSequenceCamera_Settings.__PropertyOffset_CameraSequence, value);
			}
		}

		// Token: 0x170045CB RID: 17867
		// (get) Token: 0x06021B51 RID: 138065 RVA: 0x009675FC File Offset: 0x009657FC
		// (set) Token: 0x06021B52 RID: 138066 RVA: 0x0096760C File Offset: 0x0096580C
		public unsafe bool IsHideHud
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSequenceCamera_Settings.__PropertyOffset_IsHideHud) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSequenceCamera_Settings.__PropertyOffset_IsHideHud) = (value ? 1 : 0);
			}
		}

		// Token: 0x170045CC RID: 17868
		// (get) Token: 0x06021B53 RID: 138067 RVA: 0x00967620 File Offset: 0x00965820
		// (set) Token: 0x06021B54 RID: 138068 RVA: 0x00967663 File Offset: 0x00965863
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<EBattleUIChild>> VisibleChild
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<EBattleUIChild>> result;
				if ((result = this._VisibleChild) == null)
				{
					result = (this._VisibleChild = new TArray<TEnumAsByte<EBattleUIChild>>(base.NativePtr + (IntPtr)SSequenceCamera_Settings.__PropertyOffset_VisibleChild, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.VisibleChild.CopyAssign(value);
			}
		}

		// Token: 0x170045CD RID: 17869
		// (get) Token: 0x06021B55 RID: 138069 RVA: 0x00967671 File Offset: 0x00965871
		// (set) Token: 0x06021B56 RID: 138070 RVA: 0x00967681 File Offset: 0x00965881
		public unsafe float HideHudTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSequenceCamera_Settings.__PropertyOffset_HideHudTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSequenceCamera_Settings.__PropertyOffset_HideHudTime) = value;
			}
		}

		// Token: 0x170045CE RID: 17870
		// (get) Token: 0x06021B57 RID: 138071 RVA: 0x00967692 File Offset: 0x00965892
		// (set) Token: 0x06021B58 RID: 138072 RVA: 0x009676A2 File Offset: 0x009658A2
		public unsafe bool EnableSpecificSequenceTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSequenceCamera_Settings.__PropertyOffset_EnableSpecificSequenceTime) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSequenceCamera_Settings.__PropertyOffset_EnableSpecificSequenceTime) = (value ? 1 : 0);
			}
		}

		// Token: 0x170045CF RID: 17871
		// (get) Token: 0x06021B59 RID: 138073 RVA: 0x009676B3 File Offset: 0x009658B3
		// (set) Token: 0x06021B5A RID: 138074 RVA: 0x009676C3 File Offset: 0x009658C3
		public unsafe float SpecificSequenceTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSequenceCamera_Settings.__PropertyOffset_SpecificSequenceTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSequenceCamera_Settings.__PropertyOffset_SpecificSequenceTime) = value;
			}
		}

		// Token: 0x170045D0 RID: 17872
		// (get) Token: 0x06021B5B RID: 138075 RVA: 0x009676D4 File Offset: 0x009658D4
		// (set) Token: 0x06021B5C RID: 138076 RVA: 0x009676E4 File Offset: 0x009658E4
		public unsafe bool NeedWaitInPlot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSequenceCamera_Settings.__PropertyOffset_NeedWaitInPlot) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSequenceCamera_Settings.__PropertyOffset_NeedWaitInPlot) = (value ? 1 : 0);
			}
		}

		// Token: 0x170045D1 RID: 17873
		// (get) Token: 0x06021B5D RID: 138077 RVA: 0x009676F5 File Offset: 0x009658F5
		// (set) Token: 0x06021B5E RID: 138078 RVA: 0x00967709 File Offset: 0x00965909
		public unsafe SFrameAbstractData FrameAbstract
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSequenceCamera_Settings.__PropertyOffset_FrameAbstract);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSequenceCamera_Settings.__PropertyOffset_FrameAbstract) = value;
			}
		}

		// Token: 0x170045D2 RID: 17874
		// (get) Token: 0x06021B5F RID: 138079 RVA: 0x0096771E File Offset: 0x0096591E
		// (set) Token: 0x06021B60 RID: 138080 RVA: 0x0096772E File Offset: 0x0096592E
		public unsafe bool IsStopModify
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSequenceCamera_Settings.__PropertyOffset_IsStopModify) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSequenceCamera_Settings.__PropertyOffset_IsStopModify) = (value ? 1 : 0);
			}
		}

		// Token: 0x170045D3 RID: 17875
		// (get) Token: 0x06021B61 RID: 138081 RVA: 0x0096773F File Offset: 0x0096593F
		// (set) Token: 0x06021B62 RID: 138082 RVA: 0x0096774F File Offset: 0x0096594F
		public unsafe bool IsFinishBySkillInterrupt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSequenceCamera_Settings.__PropertyOffset_IsFinishBySkillInterrupt) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSequenceCamera_Settings.__PropertyOffset_IsFinishBySkillInterrupt) = (value ? 1 : 0);
			}
		}

		// Token: 0x06021B63 RID: 138083 RVA: 0x00967760 File Offset: 0x00965960
		public SSequenceCamera_Settings()
		{
		}

		// Token: 0x06021B64 RID: 138084 RVA: 0x00967768 File Offset: 0x00965968
		protected override IntPtr GetUStructPtr()
		{
			return SSequenceCamera_Settings.StaticStruct();
		}

		// Token: 0x06021B65 RID: 138085 RVA: 0x00967774 File Offset: 0x00965974
		[NullableContext(2)]
		public SSequenceCamera_Settings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021B66 RID: 138086 RVA: 0x0096777E File Offset: 0x0096597E
		public SSequenceCamera_Settings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021B67 RID: 138087 RVA: 0x00967789 File Offset: 0x00965989
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSequenceCamera_Settings(Pointer, false, true);
		}

		// Token: 0x06021B68 RID: 138088 RVA: 0x00967793 File Offset: 0x00965993
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSequenceCamera_Settings(Pointer, MemoryOwner);
		}

		// Token: 0x04012910 RID: 76048
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/SSequenceCamera_Settings.SSequenceCamera_Settings";

		// Token: 0x04012911 RID: 76049
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012912 RID: 76050
		internal static int __PropertyOffset_BlendInTime;

		// Token: 0x04012913 RID: 76051
		internal static int __PropertyOffset_BlendOutTime;

		// Token: 0x04012914 RID: 76052
		internal static int __PropertyOffset_CameraSequence;

		// Token: 0x04012915 RID: 76053
		internal static int __PropertyOffset_IsHideHud;

		// Token: 0x04012916 RID: 76054
		internal static int __PropertyOffset_VisibleChild;

		// Token: 0x04012917 RID: 76055
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EBattleUIChild>> _VisibleChild;

		// Token: 0x04012918 RID: 76056
		internal static int __PropertyOffset_HideHudTime;

		// Token: 0x04012919 RID: 76057
		internal static int __PropertyOffset_EnableSpecificSequenceTime;

		// Token: 0x0401291A RID: 76058
		internal static int __PropertyOffset_SpecificSequenceTime;

		// Token: 0x0401291B RID: 76059
		internal static int __PropertyOffset_NeedWaitInPlot;

		// Token: 0x0401291C RID: 76060
		internal static int __PropertyOffset_FrameAbstract;

		// Token: 0x0401291D RID: 76061
		internal static int __PropertyOffset_IsStopModify;

		// Token: 0x0401291E RID: 76062
		internal static int __PropertyOffset_IsFinishBySkillInterrupt;
	}
}
