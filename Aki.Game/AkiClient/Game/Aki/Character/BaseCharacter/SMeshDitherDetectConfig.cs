using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004322 RID: 17186
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SMeshDitherDetectConfig.SMeshDitherDetectConfig")]
	[UnrealStructLayout(92, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 92)]
	public class SMeshDitherDetectConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C7D6 RID: 182230 RVA: 0x00A20E7C File Offset: 0x00A1F07C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMeshDitherDetectConfig._ScriptStructPtr != 0) ? SMeshDitherDetectConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SMeshDitherDetectConfig.SMeshDitherDetectConfig", ref SMeshDitherDetectConfig._ScriptStructPtr);
		}

		// Token: 0x17006F7F RID: 28543
		// (get) Token: 0x0602C7D7 RID: 182231 RVA: 0x00A20EA0 File Offset: 0x00A1F0A0
		// (set) Token: 0x0602C7D8 RID: 182232 RVA: 0x00A20EB0 File Offset: 0x00A1F0B0
		public unsafe int Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMeshDitherDetectConfig.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMeshDitherDetectConfig.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006F80 RID: 28544
		// (get) Token: 0x0602C7D9 RID: 182233 RVA: 0x00A20EC4 File Offset: 0x00A1F0C4
		// (set) Token: 0x0602C7DA RID: 182234 RVA: 0x00A20F07 File Offset: 0x00A1F107
		public SMeshDitherDetectTraceConfig TraceConfig
		{
			get
			{
				base.FastCheckIsValid();
				SMeshDitherDetectTraceConfig result;
				if ((result = this._TraceConfig) == null)
				{
					result = (this._TraceConfig = new SMeshDitherDetectTraceConfig(base.NativePtr + (IntPtr)SMeshDitherDetectConfig.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMeshDitherDetectTraceConfig.StaticStruct(), base.NativePtr + (IntPtr)SMeshDitherDetectConfig.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006F81 RID: 28545
		// (get) Token: 0x0602C7DB RID: 182235 RVA: 0x00A20F28 File Offset: 0x00A1F128
		// (set) Token: 0x0602C7DC RID: 182236 RVA: 0x00A20F6B File Offset: 0x00A1F16B
		public SDitherDistanceConfig DitherConfig
		{
			get
			{
				base.FastCheckIsValid();
				SDitherDistanceConfig result;
				if ((result = this._DitherConfig) == null)
				{
					result = (this._DitherConfig = new SDitherDistanceConfig(base.NativePtr + (IntPtr)SMeshDitherDetectConfig.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SDitherDistanceConfig.StaticStruct(), base.NativePtr + (IntPtr)SMeshDitherDetectConfig.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602C7DD RID: 182237 RVA: 0x00A20F8C File Offset: 0x00A1F18C
		public SMeshDitherDetectConfig()
		{
		}

		// Token: 0x0602C7DE RID: 182238 RVA: 0x00A20F94 File Offset: 0x00A1F194
		public SMeshDitherDetectConfig(int Priority, SMeshDitherDetectTraceConfig TraceConfig, SDitherDistanceConfig DitherConfig)
		{
			this.Priority = Priority;
			this.TraceConfig = TraceConfig;
			this.DitherConfig = DitherConfig;
		}

		// Token: 0x0602C7DF RID: 182239 RVA: 0x00A20FB1 File Offset: 0x00A1F1B1
		protected override IntPtr GetUStructPtr()
		{
			return SMeshDitherDetectConfig.StaticStruct();
		}

		// Token: 0x0602C7E0 RID: 182240 RVA: 0x00A20FBD File Offset: 0x00A1F1BD
		[NullableContext(2)]
		public SMeshDitherDetectConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C7E1 RID: 182241 RVA: 0x00A20FC7 File Offset: 0x00A1F1C7
		public SMeshDitherDetectConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C7E2 RID: 182242 RVA: 0x00A20FD2 File Offset: 0x00A1F1D2
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMeshDitherDetectConfig(Pointer, false, true);
		}

		// Token: 0x0602C7E3 RID: 182243 RVA: 0x00A20FDC File Offset: 0x00A1F1DC
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMeshDitherDetectConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0401773C RID: 96060
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SMeshDitherDetectConfig.SMeshDitherDetectConfig";

		// Token: 0x0401773D RID: 96061
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401773E RID: 96062
		internal static int __PropertyOffset_0;

		// Token: 0x0401773F RID: 96063
		internal static int __PropertyOffset_1;

		// Token: 0x04017740 RID: 96064
		[Nullable(2)]
		private SMeshDitherDetectTraceConfig _TraceConfig;

		// Token: 0x04017741 RID: 96065
		internal static int __PropertyOffset_2;

		// Token: 0x04017742 RID: 96066
		[Nullable(2)]
		private SDitherDistanceConfig _DitherConfig;
	}
}
