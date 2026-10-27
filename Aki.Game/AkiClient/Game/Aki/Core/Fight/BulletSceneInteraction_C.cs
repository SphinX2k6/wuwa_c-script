using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.WaterInteraction;
using AkiClient.Game.Aki.Render.RuntimeBP.Interaction;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02003FF1 RID: 16369
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/BulletSceneInteraction.BulletSceneInteraction_C")]
	[UnrealStructLayout(320, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class BulletSceneInteraction_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06029F8A RID: 171914 RVA: 0x009D22CB File Offset: 0x009D04CB
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BulletSceneInteraction_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Core/Fight/BulletSceneInteraction.BulletSceneInteraction_C");
			}
			return BulletSceneInteraction_C._ClassPtr;
		}

		// Token: 0x06029F8B RID: 171915 RVA: 0x009D22F0 File Offset: 0x009D04F0
		public BulletSceneInteraction_C() : this(BuiltinUtils.AllocNativeUObject(BulletSceneInteraction_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06029F8C RID: 171916 RVA: 0x009D2318 File Offset: 0x009D0518
		public BulletSceneInteraction_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BulletSceneInteraction_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006614 RID: 26132
		// (get) Token: 0x06029F8D RID: 171917 RVA: 0x009D234C File Offset: 0x009D054C
		// (set) Token: 0x06029F8E RID: 171918 RVA: 0x009D2385 File Offset: 0x009D0585
		public SKuroInteractionLimbsConfig WaterInteraction
		{
			get
			{
				base.FastCheckIsValid();
				SKuroInteractionLimbsConfig result;
				if ((result = this._WaterInteraction) == null)
				{
					result = (this._WaterInteraction = new SKuroInteractionLimbsConfig(base.NativePtr + (IntPtr)BulletSceneInteraction_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SKuroInteractionLimbsConfig.StaticStruct(), base.NativePtr + (IntPtr)BulletSceneInteraction_C.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006615 RID: 26133
		// (get) Token: 0x06029F8F RID: 171919 RVA: 0x009D23A8 File Offset: 0x009D05A8
		// (set) Token: 0x06029F90 RID: 171920 RVA: 0x009D23E1 File Offset: 0x009D05E1
		public SWaterEffectObject WaterEffect
		{
			get
			{
				base.FastCheckIsValid();
				SWaterEffectObject result;
				if ((result = this._WaterEffect) == null)
				{
					result = (this._WaterEffect = new SWaterEffectObject(base.NativePtr + (IntPtr)BulletSceneInteraction_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SWaterEffectObject.StaticStruct(), base.NativePtr + (IntPtr)BulletSceneInteraction_C.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06029F91 RID: 171921 RVA: 0x009D2402 File Offset: 0x009D0602
		protected BulletSceneInteraction_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015915 RID: 88341
		public new const string __ObjectPath = "/Game/Aki/Core/Fight/BulletSceneInteraction.BulletSceneInteraction_C";

		// Token: 0x04015916 RID: 88342
		private static IntPtr _ClassPtr;

		// Token: 0x04015917 RID: 88343
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015918 RID: 88344
		internal static int __PropertyOffset_0;

		// Token: 0x04015919 RID: 88345
		[Nullable(2)]
		private SKuroInteractionLimbsConfig _WaterInteraction;

		// Token: 0x0401591A RID: 88346
		internal static int __PropertyOffset_1;

		// Token: 0x0401591B RID: 88347
		[Nullable(2)]
		private SWaterEffectObject _WaterEffect;
	}
}
