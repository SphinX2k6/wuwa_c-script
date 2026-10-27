using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043D2 RID: 17362
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/SSequenceCamera_Settings.SSequenceCamera_Settings")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 66)]
	public class SSequenceCamera_Settings : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602CF8F RID: 184207 RVA: 0x00A2D809 File Offset: 0x00A2BA09
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSequenceCamera_Settings._ScriptStructPtr != 0) ? SSequenceCamera_Settings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/SSequenceCamera_Settings.SSequenceCamera_Settings", ref SSequenceCamera_Settings._ScriptStructPtr);
		}

		// Token: 0x170071DA RID: 29146
		// (get) Token: 0x0602CF90 RID: 184208 RVA: 0x00A2D82D File Offset: 0x00A2BA2D
		// (set) Token: 0x0602CF91 RID: 184209 RVA: 0x00A2D83D File Offset: 0x00A2BA3D
		public unsafe float BlendInTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSequenceCamera_Settings.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSequenceCamera_Settings.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170071DB RID: 29147
		// (get) Token: 0x0602CF92 RID: 184210 RVA: 0x00A2D84E File Offset: 0x00A2BA4E
		// (set) Token: 0x0602CF93 RID: 184211 RVA: 0x00A2D85E File Offset: 0x00A2BA5E
		public unsafe float BlendOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSequenceCamera_Settings.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSequenceCamera_Settings.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170071DC RID: 29148
		// (get) Token: 0x0602CF94 RID: 184212 RVA: 0x00A2D86F File Offset: 0x00A2BA6F
		// (set) Token: 0x0602CF95 RID: 184213 RVA: 0x00A2D883 File Offset: 0x00A2BA83
		[Nullable(2)]
		public unsafe ULevelSequence CameraSequence
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULevelSequence>(base.NativePtr / (IntPtr)sizeof(void*) + SSequenceCamera_Settings.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SSequenceCamera_Settings.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170071DD RID: 29149
		// (get) Token: 0x0602CF96 RID: 184214 RVA: 0x00A2D898 File Offset: 0x00A2BA98
		// (set) Token: 0x0602CF97 RID: 184215 RVA: 0x00A2D8A8 File Offset: 0x00A2BAA8
		public unsafe bool IsHideHud
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSequenceCamera_Settings.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSequenceCamera_Settings.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x170071DE RID: 29150
		// (get) Token: 0x0602CF98 RID: 184216 RVA: 0x00A2D8BC File Offset: 0x00A2BABC
		// (set) Token: 0x0602CF99 RID: 184217 RVA: 0x00A2D8FF File Offset: 0x00A2BAFF
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
					result = (this._VisibleChild = new TArray<TEnumAsByte<EBattleUIChild>>(base.NativePtr + (IntPtr)SSequenceCamera_Settings.__PropertyOffset_4, base.MemoryOwner ?? this));
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

		// Token: 0x170071DF RID: 29151
		// (get) Token: 0x0602CF9A RID: 184218 RVA: 0x00A2D90D File Offset: 0x00A2BB0D
		// (set) Token: 0x0602CF9B RID: 184219 RVA: 0x00A2D91D File Offset: 0x00A2BB1D
		public unsafe float HideHudTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSequenceCamera_Settings.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSequenceCamera_Settings.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170071E0 RID: 29152
		// (get) Token: 0x0602CF9C RID: 184220 RVA: 0x00A2D92E File Offset: 0x00A2BB2E
		// (set) Token: 0x0602CF9D RID: 184221 RVA: 0x00A2D93E File Offset: 0x00A2BB3E
		public unsafe bool EnableSpecificSequenceTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSequenceCamera_Settings.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSequenceCamera_Settings.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x170071E1 RID: 29153
		// (get) Token: 0x0602CF9E RID: 184222 RVA: 0x00A2D94F File Offset: 0x00A2BB4F
		// (set) Token: 0x0602CF9F RID: 184223 RVA: 0x00A2D95F File Offset: 0x00A2BB5F
		public unsafe float SpecificSequenceTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSequenceCamera_Settings.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSequenceCamera_Settings.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170071E2 RID: 29154
		// (get) Token: 0x0602CFA0 RID: 184224 RVA: 0x00A2D970 File Offset: 0x00A2BB70
		// (set) Token: 0x0602CFA1 RID: 184225 RVA: 0x00A2D980 File Offset: 0x00A2BB80
		public unsafe bool NeedWaitInPlot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSequenceCamera_Settings.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSequenceCamera_Settings.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x170071E3 RID: 29155
		// (get) Token: 0x0602CFA2 RID: 184226 RVA: 0x00A2D991 File Offset: 0x00A2BB91
		// (set) Token: 0x0602CFA3 RID: 184227 RVA: 0x00A2D9A5 File Offset: 0x00A2BBA5
		public unsafe SFrameAbstractData FrameAbstract
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSequenceCamera_Settings.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSequenceCamera_Settings.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170071E4 RID: 29156
		// (get) Token: 0x0602CFA4 RID: 184228 RVA: 0x00A2D9BA File Offset: 0x00A2BBBA
		// (set) Token: 0x0602CFA5 RID: 184229 RVA: 0x00A2D9CA File Offset: 0x00A2BBCA
		public unsafe bool IsStopModify
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSequenceCamera_Settings.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSequenceCamera_Settings.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x170071E5 RID: 29157
		// (get) Token: 0x0602CFA6 RID: 184230 RVA: 0x00A2D9DB File Offset: 0x00A2BBDB
		// (set) Token: 0x0602CFA7 RID: 184231 RVA: 0x00A2D9EB File Offset: 0x00A2BBEB
		public unsafe bool IsFinishBySkillInterrupt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSequenceCamera_Settings.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSequenceCamera_Settings.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602CFA8 RID: 184232 RVA: 0x00A2D9FC File Offset: 0x00A2BBFC
		public SSequenceCamera_Settings()
		{
		}

		// Token: 0x0602CFA9 RID: 184233 RVA: 0x00A2DA04 File Offset: 0x00A2BC04
		[NullableContext(1)]
		public SSequenceCamera_Settings(float BlendInTime, float BlendOutTime, ULevelSequence CameraSequence, bool IsHideHud, [Nullable(new byte[]
		{
			1,
			0
		})] TArray<TEnumAsByte<EBattleUIChild>> VisibleChild, float HideHudTime, bool EnableSpecificSequenceTime, float SpecificSequenceTime, bool NeedWaitInPlot, SFrameAbstractData FrameAbstract, bool IsStopModify, bool IsFinishBySkillInterrupt)
		{
			this.BlendInTime = BlendInTime;
			this.BlendOutTime = BlendOutTime;
			this.CameraSequence = CameraSequence;
			this.IsHideHud = IsHideHud;
			this.VisibleChild = VisibleChild;
			this.HideHudTime = HideHudTime;
			this.EnableSpecificSequenceTime = EnableSpecificSequenceTime;
			this.SpecificSequenceTime = SpecificSequenceTime;
			this.NeedWaitInPlot = NeedWaitInPlot;
			this.FrameAbstract = FrameAbstract;
			this.IsStopModify = IsStopModify;
			this.IsFinishBySkillInterrupt = IsFinishBySkillInterrupt;
		}

		// Token: 0x0602CFAA RID: 184234 RVA: 0x00A2DA74 File Offset: 0x00A2BC74
		protected override IntPtr GetUStructPtr()
		{
			return SSequenceCamera_Settings.StaticStruct();
		}

		// Token: 0x0602CFAB RID: 184235 RVA: 0x00A2DA80 File Offset: 0x00A2BC80
		[NullableContext(2)]
		public SSequenceCamera_Settings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602CFAC RID: 184236 RVA: 0x00A2DA8A File Offset: 0x00A2BC8A
		public SSequenceCamera_Settings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602CFAD RID: 184237 RVA: 0x00A2DA95 File Offset: 0x00A2BC95
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSequenceCamera_Settings(Pointer, false, true);
		}

		// Token: 0x0602CFAE RID: 184238 RVA: 0x00A2DA9F File Offset: 0x00A2BC9F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSequenceCamera_Settings(Pointer, MemoryOwner);
		}

		// Token: 0x04017DCF RID: 97743
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/SSequenceCamera_Settings.SSequenceCamera_Settings";

		// Token: 0x04017DD0 RID: 97744
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017DD1 RID: 97745
		internal static int __PropertyOffset_0;

		// Token: 0x04017DD2 RID: 97746
		internal static int __PropertyOffset_1;

		// Token: 0x04017DD3 RID: 97747
		internal static int __PropertyOffset_2;

		// Token: 0x04017DD4 RID: 97748
		internal static int __PropertyOffset_3;

		// Token: 0x04017DD5 RID: 97749
		internal static int __PropertyOffset_4;

		// Token: 0x04017DD6 RID: 97750
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EBattleUIChild>> _VisibleChild;

		// Token: 0x04017DD7 RID: 97751
		internal static int __PropertyOffset_5;

		// Token: 0x04017DD8 RID: 97752
		internal static int __PropertyOffset_6;

		// Token: 0x04017DD9 RID: 97753
		internal static int __PropertyOffset_7;

		// Token: 0x04017DDA RID: 97754
		internal static int __PropertyOffset_8;

		// Token: 0x04017DDB RID: 97755
		internal static int __PropertyOffset_9;

		// Token: 0x04017DDC RID: 97756
		internal static int __PropertyOffset_10;

		// Token: 0x04017DDD RID: 97757
		internal static int __PropertyOffset_11;
	}
}
