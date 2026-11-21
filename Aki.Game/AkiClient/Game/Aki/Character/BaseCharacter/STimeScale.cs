using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200336E RID: 13166
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/STimeScale.STimeScale")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class STimeScale : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060216EA RID: 136938 RVA: 0x0096077D File Offset: 0x0095E97D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (STimeScale._ScriptStructPtr != 0) ? STimeScale._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/STimeScale.STimeScale", ref STimeScale._ScriptStructPtr);
		}

		// Token: 0x1700446C RID: 17516
		// (get) Token: 0x060216EB RID: 136939 RVA: 0x009607A1 File Offset: 0x0095E9A1
		// (set) Token: 0x060216EC RID: 136940 RVA: 0x009607B5 File Offset: 0x0095E9B5
		[Nullable(2)]
		public unsafe UCurveFloat 时间膨胀变化曲线
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + STimeScale.__PropertyOffset_时间膨胀变化曲线);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + STimeScale.__PropertyOffset_时间膨胀变化曲线, value);
			}
		}

		// Token: 0x1700446D RID: 17517
		// (get) Token: 0x060216ED RID: 136941 RVA: 0x009607CA File Offset: 0x0095E9CA
		// (set) Token: 0x060216EE RID: 136942 RVA: 0x009607DA File Offset: 0x0095E9DA
		public unsafe float 时间膨胀时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)STimeScale.__PropertyOffset_时间膨胀时长);
			}
			set
			{
				*(base.NativePtr + (IntPtr)STimeScale.__PropertyOffset_时间膨胀时长) = value;
			}
		}

		// Token: 0x1700446E RID: 17518
		// (get) Token: 0x060216EF RID: 136943 RVA: 0x009607EB File Offset: 0x0095E9EB
		// (set) Token: 0x060216F0 RID: 136944 RVA: 0x009607FB File Offset: 0x0095E9FB
		public unsafe float 时间膨胀值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)STimeScale.__PropertyOffset_时间膨胀值);
			}
			set
			{
				*(base.NativePtr + (IntPtr)STimeScale.__PropertyOffset_时间膨胀值) = value;
			}
		}

		// Token: 0x1700446F RID: 17519
		// (get) Token: 0x060216F1 RID: 136945 RVA: 0x0096080C File Offset: 0x0095EA0C
		// (set) Token: 0x060216F2 RID: 136946 RVA: 0x0096081C File Offset: 0x0095EA1C
		public unsafe int 优先级
		{
			get
			{
				return *(base.NativePtr + (IntPtr)STimeScale.__PropertyOffset_优先级);
			}
			set
			{
				*(base.NativePtr + (IntPtr)STimeScale.__PropertyOffset_优先级) = value;
			}
		}

		// Token: 0x060216F3 RID: 136947 RVA: 0x0096082D File Offset: 0x0095EA2D
		public STimeScale()
		{
		}

		// Token: 0x060216F4 RID: 136948 RVA: 0x00960835 File Offset: 0x0095EA35
		protected override IntPtr GetUStructPtr()
		{
			return STimeScale.StaticStruct();
		}

		// Token: 0x060216F5 RID: 136949 RVA: 0x00960841 File Offset: 0x0095EA41
		[NullableContext(2)]
		public STimeScale(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060216F6 RID: 136950 RVA: 0x0096084B File Offset: 0x0095EA4B
		public STimeScale(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060216F7 RID: 136951 RVA: 0x00960856 File Offset: 0x0095EA56
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new STimeScale(Pointer, false, true);
		}

		// Token: 0x060216F8 RID: 136952 RVA: 0x00960860 File Offset: 0x0095EA60
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new STimeScale(Pointer, MemoryOwner);
		}

		// Token: 0x0401245C RID: 74844
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/STimeScale.STimeScale";

		// Token: 0x0401245D RID: 74845
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401245E RID: 74846
		internal static int __PropertyOffset_时间膨胀变化曲线;

		// Token: 0x0401245F RID: 74847
		internal static int __PropertyOffset_时间膨胀时长;

		// Token: 0x04012460 RID: 74848
		internal static int __PropertyOffset_时间膨胀值;

		// Token: 0x04012461 RID: 74849
		internal static int __PropertyOffset_优先级;
	}
}
