using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.Statistics
{
	// Token: 0x02003DC1 RID: 15809
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/Statistics/SEffectOutput.SEffectOutput")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class SEffectOutput : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060274EC RID: 161004 RVA: 0x0098DD10 File Offset: 0x0098BF10
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SEffectOutput._ScriptStructPtr != 0) ? SEffectOutput._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Effect/Statistics/SEffectOutput.SEffectOutput", ref SEffectOutput._ScriptStructPtr);
		}

		// Token: 0x1700575C RID: 22364
		// (get) Token: 0x060274ED RID: 161005 RVA: 0x0098DD34 File Offset: 0x0098BF34
		// (set) Token: 0x060274EE RID: 161006 RVA: 0x0098DD48 File Offset: 0x0098BF48
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SEffectOutput.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SEffectOutput.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x1700575D RID: 22365
		// (get) Token: 0x060274EF RID: 161007 RVA: 0x0098DD5D File Offset: 0x0098BF5D
		// (set) Token: 0x060274F0 RID: 161008 RVA: 0x0098DD6D File Offset: 0x0098BF6D
		public unsafe int MaxSystemNumber
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEffectOutput.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEffectOutput.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x1700575E RID: 22366
		// (get) Token: 0x060274F1 RID: 161009 RVA: 0x0098DD7E File Offset: 0x0098BF7E
		// (set) Token: 0x060274F2 RID: 161010 RVA: 0x0098DD8E File Offset: 0x0098BF8E
		public unsafe int MaxParticleAverageNumber
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEffectOutput.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEffectOutput.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x1700575F RID: 22367
		// (get) Token: 0x060274F3 RID: 161011 RVA: 0x0098DD9F File Offset: 0x0098BF9F
		// (set) Token: 0x060274F4 RID: 161012 RVA: 0x0098DDAF File Offset: 0x0098BFAF
		public unsafe int MaxParticleTotalNumber
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEffectOutput.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEffectOutput.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x060274F5 RID: 161013 RVA: 0x0098DDC0 File Offset: 0x0098BFC0
		public SEffectOutput()
		{
		}

		// Token: 0x060274F6 RID: 161014 RVA: 0x0098DDC8 File Offset: 0x0098BFC8
		public SEffectOutput(string Name, int MaxSystemNumber, int MaxParticleAverageNumber, int MaxParticleTotalNumber)
		{
			this.Name = Name;
			this.MaxSystemNumber = MaxSystemNumber;
			this.MaxParticleAverageNumber = MaxParticleAverageNumber;
			this.MaxParticleTotalNumber = MaxParticleTotalNumber;
		}

		// Token: 0x060274F7 RID: 161015 RVA: 0x0098DDED File Offset: 0x0098BFED
		protected override IntPtr GetUStructPtr()
		{
			return SEffectOutput.StaticStruct();
		}

		// Token: 0x060274F8 RID: 161016 RVA: 0x0098DDF9 File Offset: 0x0098BFF9
		[NullableContext(2)]
		public SEffectOutput(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060274F9 RID: 161017 RVA: 0x0098DE03 File Offset: 0x0098C003
		public SEffectOutput(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060274FA RID: 161018 RVA: 0x0098DE0E File Offset: 0x0098C00E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SEffectOutput(Pointer, false, true);
		}

		// Token: 0x060274FB RID: 161019 RVA: 0x0098DE18 File Offset: 0x0098C018
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SEffectOutput(Pointer, MemoryOwner);
		}

		// Token: 0x04013D6A RID: 81258
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/Statistics/SEffectOutput.SEffectOutput";

		// Token: 0x04013D6B RID: 81259
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013D6C RID: 81260
		internal static int __PropertyOffset_0;

		// Token: 0x04013D6D RID: 81261
		internal static int __PropertyOffset_1;

		// Token: 0x04013D6E RID: 81262
		internal static int __PropertyOffset_2;

		// Token: 0x04013D6F RID: 81263
		internal static int __PropertyOffset_3;
	}
}
