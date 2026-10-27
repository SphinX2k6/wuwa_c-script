using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.MultiEffect;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Effect.Setting.EffectDataAsset
{
	// Token: 0x02003E74 RID: 15988
	[UnrealObjectPath("/Game/Aki/Effect/Setting/EffectDataAsset/BP_EffectModelMultiEffect.BP_EffectModelMultiEffect_C")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 133)]
	public class BP_EffectModelMultiEffect_C : BP_EffectModelBase_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028447 RID: 164935 RVA: 0x009A8079 File Offset: 0x009A6279
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_EffectModelMultiEffect_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Effect/Setting/EffectDataAsset/BP_EffectModelMultiEffect.BP_EffectModelMultiEffect_C");
			}
			return BP_EffectModelMultiEffect_C._ClassPtr;
		}

		// Token: 0x06028448 RID: 164936 RVA: 0x009A80A0 File Offset: 0x009A62A0
		public BP_EffectModelMultiEffect_C() : this(BuiltinUtils.AllocNativeUObject(BP_EffectModelMultiEffect_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028449 RID: 164937 RVA: 0x009A80C8 File Offset: 0x009A62C8
		[NullableContext(1)]
		public BP_EffectModelMultiEffect_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_EffectModelMultiEffect_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005CBE RID: 23742
		// (get) Token: 0x0602844A RID: 164938 RVA: 0x009A80FB File Offset: 0x009A62FB
		// (set) Token: 0x0602844B RID: 164939 RVA: 0x009A810F File Offset: 0x009A630F
		[Nullable(2)]
		public unsafe UObject EffectData
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectModelMultiEffect_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectModelMultiEffect_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17005CBF RID: 23743
		// (get) Token: 0x0602844C RID: 164940 RVA: 0x009A8124 File Offset: 0x009A6324
		// (set) Token: 0x0602844D RID: 164941 RVA: 0x009A8134 File Offset: 0x009A6334
		public unsafe int BaseNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelMultiEffect_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelMultiEffect_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005CC0 RID: 23744
		// (get) Token: 0x0602844E RID: 164942 RVA: 0x009A8145 File Offset: 0x009A6345
		// (set) Token: 0x0602844F RID: 164943 RVA: 0x009A8155 File Offset: 0x009A6355
		public unsafe float SpinSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelMultiEffect_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelMultiEffect_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005CC1 RID: 23745
		// (get) Token: 0x06028450 RID: 164944 RVA: 0x009A8166 File Offset: 0x009A6366
		// (set) Token: 0x06028451 RID: 164945 RVA: 0x009A8176 File Offset: 0x009A6376
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelMultiEffect_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelMultiEffect_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17005CC2 RID: 23746
		// (get) Token: 0x06028452 RID: 164946 RVA: 0x009A8187 File Offset: 0x009A6387
		// (set) Token: 0x06028453 RID: 164947 RVA: 0x009A819B File Offset: 0x009A639B
		public unsafe TEnumAsByte<AkiClient.Game.Aki.Render.RuntimeBP.Effect.MultiEffect.EMultiEffectType> Type
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelMultiEffect_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelMultiEffect_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x06028454 RID: 164948 RVA: 0x009A81B0 File Offset: 0x009A63B0
		protected BP_EffectModelMultiEffect_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014815 RID: 83989
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Effect/Setting/EffectDataAsset/BP_EffectModelMultiEffect.BP_EffectModelMultiEffect_C";

		// Token: 0x04014816 RID: 83990
		private static IntPtr _ClassPtr;

		// Token: 0x04014817 RID: 83991
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014818 RID: 83992
		internal new static int __PropertyOffset_0;

		// Token: 0x04014819 RID: 83993
		internal new static int __PropertyOffset_1;

		// Token: 0x0401481A RID: 83994
		internal new static int __PropertyOffset_2;

		// Token: 0x0401481B RID: 83995
		internal new static int __PropertyOffset_3;

		// Token: 0x0401481C RID: 83996
		internal new static int __PropertyOffset_4;
	}
}
