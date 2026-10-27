using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.UI
{
	// Token: 0x02003F59 RID: 16217
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Fight/UI/SSpecialEnergyBarEffectPercent.SSpecialEnergyBarEffectPercent")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class SSpecialEnergyBarEffectPercent : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060294F0 RID: 169200 RVA: 0x009C0F5C File Offset: 0x009BF15C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSpecialEnergyBarEffectPercent._ScriptStructPtr != 0) ? SSpecialEnergyBarEffectPercent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/UI/SSpecialEnergyBarEffectPercent.SSpecialEnergyBarEffectPercent", ref SSpecialEnergyBarEffectPercent._ScriptStructPtr);
		}

		// Token: 0x17006294 RID: 25236
		// (get) Token: 0x060294F1 RID: 169201 RVA: 0x009C0F80 File Offset: 0x009BF180
		// (set) Token: 0x060294F2 RID: 169202 RVA: 0x009C0F90 File Offset: 0x009BF190
		public unsafe int MinPercent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSpecialEnergyBarEffectPercent.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSpecialEnergyBarEffectPercent.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006295 RID: 25237
		// (get) Token: 0x060294F3 RID: 169203 RVA: 0x009C0FA1 File Offset: 0x009BF1A1
		// (set) Token: 0x060294F4 RID: 169204 RVA: 0x009C0FB1 File Offset: 0x009BF1B1
		public unsafe int MaxPercent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSpecialEnergyBarEffectPercent.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSpecialEnergyBarEffectPercent.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006296 RID: 25238
		// (get) Token: 0x060294F5 RID: 169205 RVA: 0x009C0FC2 File Offset: 0x009BF1C2
		// (set) Token: 0x060294F6 RID: 169206 RVA: 0x009C0FD2 File Offset: 0x009BF1D2
		public unsafe float MinValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSpecialEnergyBarEffectPercent.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSpecialEnergyBarEffectPercent.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006297 RID: 25239
		// (get) Token: 0x060294F7 RID: 169207 RVA: 0x009C0FE3 File Offset: 0x009BF1E3
		// (set) Token: 0x060294F8 RID: 169208 RVA: 0x009C0FF3 File Offset: 0x009BF1F3
		public unsafe float MaxValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSpecialEnergyBarEffectPercent.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSpecialEnergyBarEffectPercent.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006298 RID: 25240
		// (get) Token: 0x060294F9 RID: 169209 RVA: 0x009C1004 File Offset: 0x009BF204
		// (set) Token: 0x060294FA RID: 169210 RVA: 0x009C1018 File Offset: 0x009BF218
		public unsafe string FloatParameterName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SSpecialEnergyBarEffectPercent.__PropertyOffset_4)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SSpecialEnergyBarEffectPercent.__PropertyOffset_4)), value);
			}
		}

		// Token: 0x060294FB RID: 169211 RVA: 0x009C102D File Offset: 0x009BF22D
		public SSpecialEnergyBarEffectPercent()
		{
		}

		// Token: 0x060294FC RID: 169212 RVA: 0x009C1035 File Offset: 0x009BF235
		public SSpecialEnergyBarEffectPercent(int MinPercent, int MaxPercent, float MinValue, float MaxValue, string FloatParameterName)
		{
			this.MinPercent = MinPercent;
			this.MaxPercent = MaxPercent;
			this.MinValue = MinValue;
			this.MaxValue = MaxValue;
			this.FloatParameterName = FloatParameterName;
		}

		// Token: 0x060294FD RID: 169213 RVA: 0x009C1062 File Offset: 0x009BF262
		protected override IntPtr GetUStructPtr()
		{
			return SSpecialEnergyBarEffectPercent.StaticStruct();
		}

		// Token: 0x060294FE RID: 169214 RVA: 0x009C106E File Offset: 0x009BF26E
		[NullableContext(2)]
		public SSpecialEnergyBarEffectPercent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060294FF RID: 169215 RVA: 0x009C1078 File Offset: 0x009BF278
		public SSpecialEnergyBarEffectPercent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029500 RID: 169216 RVA: 0x009C1083 File Offset: 0x009BF283
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSpecialEnergyBarEffectPercent(Pointer, false, true);
		}

		// Token: 0x06029501 RID: 169217 RVA: 0x009C108D File Offset: 0x009BF28D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSpecialEnergyBarEffectPercent(Pointer, MemoryOwner);
		}

		// Token: 0x040152A1 RID: 86689
		public const string __ObjectPath = "/Game/Aki/Data/Fight/UI/SSpecialEnergyBarEffectPercent.SSpecialEnergyBarEffectPercent";

		// Token: 0x040152A2 RID: 86690
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040152A3 RID: 86691
		internal static int __PropertyOffset_0;

		// Token: 0x040152A4 RID: 86692
		internal static int __PropertyOffset_1;

		// Token: 0x040152A5 RID: 86693
		internal static int __PropertyOffset_2;

		// Token: 0x040152A6 RID: 86694
		internal static int __PropertyOffset_3;

		// Token: 0x040152A7 RID: 86695
		internal static int __PropertyOffset_4;
	}
}
