using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02003271 RID: 12913
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Core/Fight/SReBulletDataChildren.SReBulletDataChildren")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 22)]
	public class SReBulletDataChildren : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060203F6 RID: 132086 RVA: 0x00940FA2 File Offset: 0x0093F1A2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SReBulletDataChildren._ScriptStructPtr != 0) ? SReBulletDataChildren._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Core/Fight/SReBulletDataChildren.SReBulletDataChildren", ref SReBulletDataChildren._ScriptStructPtr);
		}

		// Token: 0x17003E19 RID: 15897
		// (get) Token: 0x060203F7 RID: 132087 RVA: 0x00940FC6 File Offset: 0x0093F1C6
		// (set) Token: 0x060203F8 RID: 132088 RVA: 0x00940FD6 File Offset: 0x0093F1D6
		public unsafe long 召唤子弹ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataChildren.__PropertyOffset_召唤子弹ID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataChildren.__PropertyOffset_召唤子弹ID) = value;
			}
		}

		// Token: 0x17003E1A RID: 15898
		// (get) Token: 0x060203F9 RID: 132089 RVA: 0x00940FE7 File Offset: 0x0093F1E7
		// (set) Token: 0x060203FA RID: 132090 RVA: 0x00940FF7 File Offset: 0x0093F1F7
		public unsafe float 召唤子弹延迟
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataChildren.__PropertyOffset_召唤子弹延迟);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataChildren.__PropertyOffset_召唤子弹延迟) = value;
			}
		}

		// Token: 0x17003E1B RID: 15899
		// (get) Token: 0x060203FB RID: 132091 RVA: 0x00941008 File Offset: 0x0093F208
		// (set) Token: 0x060203FC RID: 132092 RVA: 0x00941018 File Offset: 0x0093F218
		public unsafe int 召唤子弹数量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataChildren.__PropertyOffset_召唤子弹数量);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataChildren.__PropertyOffset_召唤子弹数量) = value;
			}
		}

		// Token: 0x17003E1C RID: 15900
		// (get) Token: 0x060203FD RID: 132093 RVA: 0x00941029 File Offset: 0x0093F229
		// (set) Token: 0x060203FE RID: 132094 RVA: 0x00941039 File Offset: 0x0093F239
		public unsafe float 召唤子弹间隔
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataChildren.__PropertyOffset_召唤子弹间隔);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataChildren.__PropertyOffset_召唤子弹间隔) = value;
			}
		}

		// Token: 0x17003E1D RID: 15901
		// (get) Token: 0x060203FF RID: 132095 RVA: 0x0094104A File Offset: 0x0093F24A
		// (set) Token: 0x06020400 RID: 132096 RVA: 0x0094105E File Offset: 0x0093F25E
		public unsafe TEnumAsByte<EBulletChildrenType> 召唤触发
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataChildren.__PropertyOffset_召唤触发);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataChildren.__PropertyOffset_召唤触发) = value;
			}
		}

		// Token: 0x17003E1E RID: 15902
		// (get) Token: 0x06020401 RID: 132097 RVA: 0x00941073 File Offset: 0x0093F273
		// (set) Token: 0x06020402 RID: 132098 RVA: 0x00941083 File Offset: 0x0093F283
		public unsafe bool 失败是否停止
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataChildren.__PropertyOffset_失败是否停止) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataChildren.__PropertyOffset_失败是否停止) = (value ? 1 : 0);
			}
		}

		// Token: 0x06020403 RID: 132099 RVA: 0x00941094 File Offset: 0x0093F294
		public SReBulletDataChildren()
		{
		}

		// Token: 0x06020404 RID: 132100 RVA: 0x0094109C File Offset: 0x0093F29C
		protected override IntPtr GetUStructPtr()
		{
			return SReBulletDataChildren.StaticStruct();
		}

		// Token: 0x06020405 RID: 132101 RVA: 0x009410A8 File Offset: 0x0093F2A8
		[NullableContext(2)]
		public SReBulletDataChildren(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06020406 RID: 132102 RVA: 0x009410B2 File Offset: 0x0093F2B2
		public SReBulletDataChildren(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06020407 RID: 132103 RVA: 0x009410BD File Offset: 0x0093F2BD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SReBulletDataChildren(Pointer, false, true);
		}

		// Token: 0x06020408 RID: 132104 RVA: 0x009410C7 File Offset: 0x0093F2C7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SReBulletDataChildren(Pointer, MemoryOwner);
		}

		// Token: 0x04011686 RID: 71302
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Core/Fight/SReBulletDataChildren.SReBulletDataChildren";

		// Token: 0x04011687 RID: 71303
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011688 RID: 71304
		internal static int __PropertyOffset_召唤子弹ID;

		// Token: 0x04011689 RID: 71305
		internal static int __PropertyOffset_召唤子弹延迟;

		// Token: 0x0401168A RID: 71306
		internal static int __PropertyOffset_召唤子弹数量;

		// Token: 0x0401168B RID: 71307
		internal static int __PropertyOffset_召唤子弹间隔;

		// Token: 0x0401168C RID: 71308
		internal static int __PropertyOffset_召唤触发;

		// Token: 0x0401168D RID: 71309
		internal static int __PropertyOffset_失败是否停止;
	}
}
