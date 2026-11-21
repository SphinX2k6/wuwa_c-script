using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Manipulate
{
	// Token: 0x020031B5 RID: 12725
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Manipulate/SManipulateConfig.SManipulateConfig")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 36)]
	public class SManipulateConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F6CD RID: 128717 RVA: 0x0092D7AB File Offset: 0x0092B9AB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SManipulateConfig._ScriptStructPtr != 0) ? SManipulateConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Manipulate/SManipulateConfig.SManipulateConfig", ref SManipulateConfig._ScriptStructPtr);
		}

		// Token: 0x1700392F RID: 14639
		// (get) Token: 0x0601F6CE RID: 128718 RVA: 0x0092D7CF File Offset: 0x0092B9CF
		// (set) Token: 0x0601F6CF RID: 128719 RVA: 0x0092D7E3 File Offset: 0x0092B9E3
		public unsafe FName ConfigName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SManipulateConfig.__PropertyOffset_ConfigName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SManipulateConfig.__PropertyOffset_ConfigName) = value;
			}
		}

		// Token: 0x17003930 RID: 14640
		// (get) Token: 0x0601F6D0 RID: 128720 RVA: 0x0092D7F8 File Offset: 0x0092B9F8
		// (set) Token: 0x0601F6D1 RID: 128721 RVA: 0x0092D83B File Offset: 0x0092BA3B
		public TArray<SManipulatePointInfo> ManipulatePoints
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SManipulatePointInfo> result;
				if ((result = this._ManipulatePoints) == null)
				{
					result = (this._ManipulatePoints = new TArray<SManipulatePointInfo>(base.NativePtr + (IntPtr)SManipulateConfig.__PropertyOffset_ManipulatePoints, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ManipulatePoints.CopyAssign(value);
			}
		}

		// Token: 0x17003931 RID: 14641
		// (get) Token: 0x0601F6D2 RID: 128722 RVA: 0x0092D849 File Offset: 0x0092BA49
		// (set) Token: 0x0601F6D3 RID: 128723 RVA: 0x0092D859 File Offset: 0x0092BA59
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SManipulateConfig.__PropertyOffset_Duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SManipulateConfig.__PropertyOffset_Duration) = value;
			}
		}

		// Token: 0x0601F6D4 RID: 128724 RVA: 0x0092D86A File Offset: 0x0092BA6A
		public SManipulateConfig()
		{
		}

		// Token: 0x0601F6D5 RID: 128725 RVA: 0x0092D872 File Offset: 0x0092BA72
		protected override IntPtr GetUStructPtr()
		{
			return SManipulateConfig.StaticStruct();
		}

		// Token: 0x0601F6D6 RID: 128726 RVA: 0x0092D87E File Offset: 0x0092BA7E
		[NullableContext(2)]
		public SManipulateConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F6D7 RID: 128727 RVA: 0x0092D888 File Offset: 0x0092BA88
		public SManipulateConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F6D8 RID: 128728 RVA: 0x0092D893 File Offset: 0x0092BA93
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SManipulateConfig(Pointer, false, true);
		}

		// Token: 0x0601F6D9 RID: 128729 RVA: 0x0092D89D File Offset: 0x0092BA9D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SManipulateConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04010D9F RID: 69023
		public const string __ObjectPath = "/Game/Aki/Data/Manipulate/SManipulateConfig.SManipulateConfig";

		// Token: 0x04010DA0 RID: 69024
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010DA1 RID: 69025
		internal static int __PropertyOffset_ConfigName;

		// Token: 0x04010DA2 RID: 69026
		internal static int __PropertyOffset_ManipulatePoints;

		// Token: 0x04010DA3 RID: 69027
		[Nullable(2)]
		private TArray<SManipulatePointInfo> _ManipulatePoints;

		// Token: 0x04010DA4 RID: 69028
		internal static int __PropertyOffset_Duration;
	}
}
