using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.TypeScript.Game.NewWorld.Character.SimpleNpc.Blueprint
{
	// Token: 0x02003A14 RID: 14868
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Character/SimpleNpc/Blueprint/PD_HolographicEffect.PD_HolographicEffect_C")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 290)]
	public class PD_HolographicEffect_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F2F3 RID: 127731 RVA: 0x008AF71C File Offset: 0x008AD91C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PD_HolographicEffect_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Character/SimpleNpc/Blueprint/PD_HolographicEffect.PD_HolographicEffect_C");
			}
			return PD_HolographicEffect_C._ClassPtr;
		}

		// Token: 0x0601F2F4 RID: 127732 RVA: 0x008AF740 File Offset: 0x008AD940
		public PD_HolographicEffect_C() : this(BuiltinUtils.AllocNativeUObject(PD_HolographicEffect_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F2F5 RID: 127733 RVA: 0x008AF768 File Offset: 0x008AD968
		public PD_HolographicEffect_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PD_HolographicEffect_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002A28 RID: 10792
		// (get) Token: 0x0601F2F6 RID: 127734 RVA: 0x008AF79B File Offset: 0x008AD99B
		// (set) Token: 0x0601F2F7 RID: 127735 RVA: 0x008AF7AB File Offset: 0x008AD9AB
		public unsafe float Start
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_HolographicEffect_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_HolographicEffect_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17002A29 RID: 10793
		// (get) Token: 0x0601F2F8 RID: 127736 RVA: 0x008AF7BC File Offset: 0x008AD9BC
		// (set) Token: 0x0601F2F9 RID: 127737 RVA: 0x008AF7CC File Offset: 0x008AD9CC
		public unsafe float Loop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_HolographicEffect_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_HolographicEffect_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17002A2A RID: 10794
		// (get) Token: 0x0601F2FA RID: 127738 RVA: 0x008AF7DD File Offset: 0x008AD9DD
		// (set) Token: 0x0601F2FB RID: 127739 RVA: 0x008AF7ED File Offset: 0x008AD9ED
		public unsafe float End
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_HolographicEffect_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_HolographicEffect_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17002A2B RID: 10795
		// (get) Token: 0x0601F2FC RID: 127740 RVA: 0x008AF800 File Offset: 0x008ADA00
		// (set) Token: 0x0601F2FD RID: 127741 RVA: 0x008AF839 File Offset: 0x008ADA39
		public SHolographicData OutlineData
		{
			get
			{
				base.FastCheckIsValid();
				SHolographicData result;
				if ((result = this._OutlineData) == null)
				{
					result = (this._OutlineData = new SHolographicData(base.NativePtr + (IntPtr)PD_HolographicEffect_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SHolographicData.StaticStruct(), base.NativePtr + (IntPtr)PD_HolographicEffect_C.__PropertyOffset_3, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002A2C RID: 10796
		// (get) Token: 0x0601F2FE RID: 127742 RVA: 0x008AF85C File Offset: 0x008ADA5C
		// (set) Token: 0x0601F2FF RID: 127743 RVA: 0x008AF895 File Offset: 0x008ADA95
		public SHolographicData OtherData
		{
			get
			{
				base.FastCheckIsValid();
				SHolographicData result;
				if ((result = this._OtherData) == null)
				{
					result = (this._OtherData = new SHolographicData(base.NativePtr + (IntPtr)PD_HolographicEffect_C.__PropertyOffset_4, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SHolographicData.StaticStruct(), base.NativePtr + (IntPtr)PD_HolographicEffect_C.__PropertyOffset_4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002A2D RID: 10797
		// (get) Token: 0x0601F300 RID: 127744 RVA: 0x008AF8B6 File Offset: 0x008ADAB6
		// (set) Token: 0x0601F301 RID: 127745 RVA: 0x008AF8C6 File Offset: 0x008ADAC6
		public unsafe bool CanSkipLoopUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_HolographicEffect_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_HolographicEffect_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002A2E RID: 10798
		// (get) Token: 0x0601F302 RID: 127746 RVA: 0x008AF8D7 File Offset: 0x008ADAD7
		// (set) Token: 0x0601F303 RID: 127747 RVA: 0x008AF8E7 File Offset: 0x008ADAE7
		public unsafe bool ExtraUpdateOnStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_HolographicEffect_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_HolographicEffect_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601F304 RID: 127748 RVA: 0x008AF8F8 File Offset: 0x008ADAF8
		protected PD_HolographicEffect_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EF0A RID: 61194
		public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Character/SimpleNpc/Blueprint/PD_HolographicEffect.PD_HolographicEffect_C";

		// Token: 0x0400EF0B RID: 61195
		private static IntPtr _ClassPtr;

		// Token: 0x0400EF0C RID: 61196
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EF0D RID: 61197
		internal static int __PropertyOffset_0;

		// Token: 0x0400EF0E RID: 61198
		internal static int __PropertyOffset_1;

		// Token: 0x0400EF0F RID: 61199
		internal static int __PropertyOffset_2;

		// Token: 0x0400EF10 RID: 61200
		internal static int __PropertyOffset_3;

		// Token: 0x0400EF11 RID: 61201
		[Nullable(2)]
		private SHolographicData _OutlineData;

		// Token: 0x0400EF12 RID: 61202
		internal static int __PropertyOffset_4;

		// Token: 0x0400EF13 RID: 61203
		[Nullable(2)]
		private SHolographicData _OtherData;

		// Token: 0x0400EF14 RID: 61204
		internal static int __PropertyOffset_5;

		// Token: 0x0400EF15 RID: 61205
		internal static int __PropertyOffset_6;
	}
}
