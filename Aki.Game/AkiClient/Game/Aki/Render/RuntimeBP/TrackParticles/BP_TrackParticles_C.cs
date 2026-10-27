using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.TrackParticles.DT;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.TrackParticles
{
	// Token: 0x02003AB9 RID: 15033
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/TrackParticles/BP_TrackParticles.BP_TrackParticles_C")]
	[UnrealStructLayout(1472, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1472)]
	public class BP_TrackParticles_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060203EF RID: 132079 RVA: 0x008CDA97 File Offset: 0x008CBC97
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_TrackParticles_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/TrackParticles/BP_TrackParticles.BP_TrackParticles_C");
			}
			return BP_TrackParticles_C._ClassPtr;
		}

		// Token: 0x060203F0 RID: 132080 RVA: 0x008CDABC File Offset: 0x008CBCBC
		public BP_TrackParticles_C() : this(BuiltinUtils.AllocNativeUObject(BP_TrackParticles_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060203F1 RID: 132081 RVA: 0x008CDAE4 File Offset: 0x008CBCE4
		public BP_TrackParticles_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_TrackParticles_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002FB2 RID: 12210
		// (get) Token: 0x060203F2 RID: 132082 RVA: 0x008CDB17 File Offset: 0x008CBD17
		// (set) Token: 0x060203F3 RID: 132083 RVA: 0x008CDB2B File Offset: 0x008CBD2B
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrackParticles_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrackParticles_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17002FB3 RID: 12211
		// (get) Token: 0x060203F4 RID: 132084 RVA: 0x008CDB40 File Offset: 0x008CBD40
		// (set) Token: 0x060203F5 RID: 132085 RVA: 0x008CDB79 File Offset: 0x008CBD79
		public TArray<UTexture2D> TrackTextureArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UTexture2D> result;
				if ((result = this._TrackTextureArray) == null)
				{
					result = (this._TrackTextureArray = new TArray<UTexture2D>(base.NativePtr + (IntPtr)BP_TrackParticles_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				this.TrackTextureArray.CopyAssign(value);
			}
		}

		// Token: 0x17002FB4 RID: 12212
		// (get) Token: 0x060203F6 RID: 132086 RVA: 0x008CDB88 File Offset: 0x008CBD88
		// (set) Token: 0x060203F7 RID: 132087 RVA: 0x008CDBC1 File Offset: 0x008CBDC1
		public TArray<Struct_TrackParticles> TrackDataArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<Struct_TrackParticles> result;
				if ((result = this._TrackDataArray) == null)
				{
					result = (this._TrackDataArray = new TArray<Struct_TrackParticles>(base.NativePtr + (IntPtr)BP_TrackParticles_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				this.TrackDataArray.CopyAssign(value);
			}
		}

		// Token: 0x060203F8 RID: 132088 RVA: 0x008CDBCF File Offset: 0x008CBDCF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrackParticles_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060203F9 RID: 132089 RVA: 0x008CDBE3 File Offset: 0x008CBDE3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_TrackParticles_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060203FA RID: 132090 RVA: 0x008CDBF8 File Offset: 0x008CBDF8
		protected BP_TrackParticles_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F978 RID: 63864
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/TrackParticles/BP_TrackParticles.BP_TrackParticles_C";

		// Token: 0x0400F979 RID: 63865
		private static IntPtr _ClassPtr;

		// Token: 0x0400F97A RID: 63866
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F97B RID: 63867
		internal static int __PropertyOffset_0;

		// Token: 0x0400F97C RID: 63868
		internal static int __PropertyOffset_1;

		// Token: 0x0400F97D RID: 63869
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UTexture2D> _TrackTextureArray;

		// Token: 0x0400F97E RID: 63870
		internal static int __PropertyOffset_2;

		// Token: 0x0400F97F RID: 63871
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<Struct_TrackParticles> _TrackDataArray;

		// Token: 0x0400F980 RID: 63872
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;
	}
}
