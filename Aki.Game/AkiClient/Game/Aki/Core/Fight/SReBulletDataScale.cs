using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x0200327A RID: 12922
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Core/Fight/SReBulletDataScale.SReBulletDataScale")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 25)]
	public class SReBulletDataScale : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060204C3 RID: 132291 RVA: 0x009423B5 File Offset: 0x009405B5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SReBulletDataScale._ScriptStructPtr != 0) ? SReBulletDataScale._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Core/Fight/SReBulletDataScale.SReBulletDataScale", ref SReBulletDataScale._ScriptStructPtr);
		}

		// Token: 0x17003E60 RID: 15968
		// (get) Token: 0x060204C4 RID: 132292 RVA: 0x009423D9 File Offset: 0x009405D9
		// (set) Token: 0x060204C5 RID: 132293 RVA: 0x009423ED File Offset: 0x009405ED
		public unsafe FVector 缩放倍率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataScale.__PropertyOffset_缩放倍率);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataScale.__PropertyOffset_缩放倍率) = value;
			}
		}

		// Token: 0x17003E61 RID: 15969
		// (get) Token: 0x060204C6 RID: 132294 RVA: 0x00942402 File Offset: 0x00940602
		// (set) Token: 0x060204C7 RID: 132295 RVA: 0x00942416 File Offset: 0x00940616
		[Nullable(2)]
		public unsafe UCurveVector 缩放倍率曲线
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveVector>(base.NativePtr / (IntPtr)sizeof(void*) + SReBulletDataScale.__PropertyOffset_缩放倍率曲线);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SReBulletDataScale.__PropertyOffset_缩放倍率曲线, value);
			}
		}

		// Token: 0x17003E62 RID: 15970
		// (get) Token: 0x060204C8 RID: 132296 RVA: 0x0094242B File Offset: 0x0094062B
		// (set) Token: 0x060204C9 RID: 132297 RVA: 0x0094243B File Offset: 0x0094063B
		public unsafe bool 特定形状开关
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataScale.__PropertyOffset_特定形状开关) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataScale.__PropertyOffset_特定形状开关) = (value ? 1 : 0);
			}
		}

		// Token: 0x060204CA RID: 132298 RVA: 0x0094244C File Offset: 0x0094064C
		public SReBulletDataScale()
		{
		}

		// Token: 0x060204CB RID: 132299 RVA: 0x00942454 File Offset: 0x00940654
		protected override IntPtr GetUStructPtr()
		{
			return SReBulletDataScale.StaticStruct();
		}

		// Token: 0x060204CC RID: 132300 RVA: 0x00942460 File Offset: 0x00940660
		[NullableContext(2)]
		public SReBulletDataScale(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060204CD RID: 132301 RVA: 0x0094246A File Offset: 0x0094066A
		public SReBulletDataScale(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060204CE RID: 132302 RVA: 0x00942475 File Offset: 0x00940675
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SReBulletDataScale(Pointer, false, true);
		}

		// Token: 0x060204CF RID: 132303 RVA: 0x0094247F File Offset: 0x0094067F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SReBulletDataScale(Pointer, MemoryOwner);
		}

		// Token: 0x040116F9 RID: 71417
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Core/Fight/SReBulletDataScale.SReBulletDataScale";

		// Token: 0x040116FA RID: 71418
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040116FB RID: 71419
		internal static int __PropertyOffset_缩放倍率;

		// Token: 0x040116FC RID: 71420
		internal static int __PropertyOffset_缩放倍率曲线;

		// Token: 0x040116FD RID: 71421
		internal static int __PropertyOffset_特定形状开关;
	}
}
