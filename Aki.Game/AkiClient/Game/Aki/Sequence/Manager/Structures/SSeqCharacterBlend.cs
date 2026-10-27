using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Sequence.Manager.Structures
{
	// Token: 0x02003A33 RID: 14899
	[UnrealObjectPath("/Game/Aki/Sequence/Manager/Structures/SSeqCharacterBlend.SSeqCharacterBlend")]
	[UnrealStructLayout(96, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 84)]
	public class SSeqCharacterBlend : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F610 RID: 128528 RVA: 0x008B6DF8 File Offset: 0x008B4FF8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSeqCharacterBlend._ScriptStructPtr != 0) ? SSeqCharacterBlend._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Sequence/Manager/Structures/SSeqCharacterBlend.SSeqCharacterBlend", ref SSeqCharacterBlend._ScriptStructPtr);
		}

		// Token: 0x17002B14 RID: 11028
		// (get) Token: 0x0601F611 RID: 128529 RVA: 0x008B6E1C File Offset: 0x008B501C
		// (set) Token: 0x0601F612 RID: 128530 RVA: 0x008B6E30 File Offset: 0x008B5030
		public unsafe FName TargetTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSeqCharacterBlend.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSeqCharacterBlend.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17002B15 RID: 11029
		// (get) Token: 0x0601F613 RID: 128531 RVA: 0x008B6E45 File Offset: 0x008B5045
		// (set) Token: 0x0601F614 RID: 128532 RVA: 0x008B6E59 File Offset: 0x008B5059
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSeqCharacterBlend.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSeqCharacterBlend.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17002B16 RID: 11030
		// (get) Token: 0x0601F615 RID: 128533 RVA: 0x008B6E6E File Offset: 0x008B506E
		// (set) Token: 0x0601F616 RID: 128534 RVA: 0x008B6E7E File Offset: 0x008B507E
		public unsafe float BlendTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSeqCharacterBlend.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSeqCharacterBlend.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17002B17 RID: 11031
		// (get) Token: 0x0601F617 RID: 128535 RVA: 0x008B6E8F File Offset: 0x008B508F
		// (set) Token: 0x0601F618 RID: 128536 RVA: 0x008B6EA3 File Offset: 0x008B50A3
		[Nullable(2)]
		public unsafe AActor Target
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + SSeqCharacterBlend.__PropertyOffset_3);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SSeqCharacterBlend.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17002B18 RID: 11032
		// (get) Token: 0x0601F619 RID: 128537 RVA: 0x008B6EB8 File Offset: 0x008B50B8
		// (set) Token: 0x0601F61A RID: 128538 RVA: 0x008B6EC8 File Offset: 0x008B50C8
		public unsafe float BlendAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSeqCharacterBlend.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSeqCharacterBlend.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x0601F61B RID: 128539 RVA: 0x008B6ED9 File Offset: 0x008B50D9
		public SSeqCharacterBlend()
		{
		}

		// Token: 0x0601F61C RID: 128540 RVA: 0x008B6EE1 File Offset: 0x008B50E1
		[NullableContext(1)]
		public SSeqCharacterBlend(FName TargetTag, FTransform Transform, float BlendTime, AActor Target, float BlendAlpha)
		{
			this.TargetTag = TargetTag;
			this.Transform = Transform;
			this.BlendTime = BlendTime;
			this.Target = Target;
			this.BlendAlpha = BlendAlpha;
		}

		// Token: 0x0601F61D RID: 128541 RVA: 0x008B6F0E File Offset: 0x008B510E
		protected override IntPtr GetUStructPtr()
		{
			return SSeqCharacterBlend.StaticStruct();
		}

		// Token: 0x0601F61E RID: 128542 RVA: 0x008B6F1A File Offset: 0x008B511A
		[NullableContext(2)]
		public SSeqCharacterBlend(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F61F RID: 128543 RVA: 0x008B6F24 File Offset: 0x008B5124
		public SSeqCharacterBlend(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F620 RID: 128544 RVA: 0x008B6F2F File Offset: 0x008B512F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSeqCharacterBlend(Pointer, false, true);
		}

		// Token: 0x0601F621 RID: 128545 RVA: 0x008B6F39 File Offset: 0x008B5139
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSeqCharacterBlend(Pointer, MemoryOwner);
		}

		// Token: 0x0400F114 RID: 61716
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Sequence/Manager/Structures/SSeqCharacterBlend.SSeqCharacterBlend";

		// Token: 0x0400F115 RID: 61717
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F116 RID: 61718
		internal static int __PropertyOffset_0;

		// Token: 0x0400F117 RID: 61719
		internal static int __PropertyOffset_1;

		// Token: 0x0400F118 RID: 61720
		internal static int __PropertyOffset_2;

		// Token: 0x0400F119 RID: 61721
		internal static int __PropertyOffset_3;

		// Token: 0x0400F11A RID: 61722
		internal static int __PropertyOffset_4;
	}
}
