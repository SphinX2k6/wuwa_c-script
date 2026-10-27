using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02004019 RID: 16409
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Core/Fight/SReBulletDataScale.SReBulletDataScale")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 25)]
	public class SReBulletDataScale : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602A11A RID: 172314 RVA: 0x009D4DC4 File Offset: 0x009D2FC4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SReBulletDataScale._ScriptStructPtr != 0) ? SReBulletDataScale._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Core/Fight/SReBulletDataScale.SReBulletDataScale", ref SReBulletDataScale._ScriptStructPtr);
		}

		// Token: 0x1700669A RID: 26266
		// (get) Token: 0x0602A11B RID: 172315 RVA: 0x009D4DE8 File Offset: 0x009D2FE8
		// (set) Token: 0x0602A11C RID: 172316 RVA: 0x009D4DFC File Offset: 0x009D2FFC
		public unsafe FVector 缩放倍率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataScale.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataScale.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x1700669B RID: 26267
		// (get) Token: 0x0602A11D RID: 172317 RVA: 0x009D4E11 File Offset: 0x009D3011
		// (set) Token: 0x0602A11E RID: 172318 RVA: 0x009D4E25 File Offset: 0x009D3025
		[Nullable(2)]
		public unsafe UCurveVector 缩放倍率曲线
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveVector>(base.NativePtr / (IntPtr)sizeof(void*) + SReBulletDataScale.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SReBulletDataScale.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700669C RID: 26268
		// (get) Token: 0x0602A11F RID: 172319 RVA: 0x009D4E3A File Offset: 0x009D303A
		// (set) Token: 0x0602A120 RID: 172320 RVA: 0x009D4E4A File Offset: 0x009D304A
		public unsafe bool 特定形状开关
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataScale.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataScale.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602A121 RID: 172321 RVA: 0x009D4E5B File Offset: 0x009D305B
		public SReBulletDataScale()
		{
		}

		// Token: 0x0602A122 RID: 172322 RVA: 0x009D4E63 File Offset: 0x009D3063
		[NullableContext(1)]
		public SReBulletDataScale(FVector 缩放倍率, UCurveVector 缩放倍率曲线, bool 特定形状开关)
		{
			this.缩放倍率 = 缩放倍率;
			this.缩放倍率曲线 = 缩放倍率曲线;
			this.特定形状开关 = 特定形状开关;
		}

		// Token: 0x0602A123 RID: 172323 RVA: 0x009D4E80 File Offset: 0x009D3080
		protected override IntPtr GetUStructPtr()
		{
			return SReBulletDataScale.StaticStruct();
		}

		// Token: 0x0602A124 RID: 172324 RVA: 0x009D4E8C File Offset: 0x009D308C
		[NullableContext(2)]
		public SReBulletDataScale(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602A125 RID: 172325 RVA: 0x009D4E96 File Offset: 0x009D3096
		public SReBulletDataScale(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602A126 RID: 172326 RVA: 0x009D4EA1 File Offset: 0x009D30A1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SReBulletDataScale(Pointer, false, true);
		}

		// Token: 0x0602A127 RID: 172327 RVA: 0x009D4EAB File Offset: 0x009D30AB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SReBulletDataScale(Pointer, MemoryOwner);
		}

		// Token: 0x04015AA7 RID: 88743
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Core/Fight/SReBulletDataScale.SReBulletDataScale";

		// Token: 0x04015AA8 RID: 88744
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015AA9 RID: 88745
		internal static int __PropertyOffset_0;

		// Token: 0x04015AAA RID: 88746
		internal static int __PropertyOffset_1;

		// Token: 0x04015AAB RID: 88747
		internal static int __PropertyOffset_2;
	}
}
