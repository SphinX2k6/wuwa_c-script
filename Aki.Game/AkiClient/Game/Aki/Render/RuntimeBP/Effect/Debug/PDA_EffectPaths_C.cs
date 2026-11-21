using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.Debug
{
	// Token: 0x02003110 RID: 12560
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/Debug/PDA_EffectPaths.PDA_EffectPaths_C")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class PDA_EffectPaths_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EC5E RID: 126046 RVA: 0x0091CF1F File Offset: 0x0091B11F
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PDA_EffectPaths_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Effect/Debug/PDA_EffectPaths.PDA_EffectPaths_C");
			}
			return PDA_EffectPaths_C._ClassPtr;
		}

		// Token: 0x0601EC5F RID: 126047 RVA: 0x0091CF44 File Offset: 0x0091B144
		public PDA_EffectPaths_C() : this(BuiltinUtils.AllocNativeUObject(PDA_EffectPaths_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EC60 RID: 126048 RVA: 0x0091CF6C File Offset: 0x0091B16C
		public PDA_EffectPaths_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PDA_EffectPaths_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003582 RID: 13698
		// (get) Token: 0x0601EC61 RID: 126049 RVA: 0x0091CFA0 File Offset: 0x0091B1A0
		// (set) Token: 0x0601EC62 RID: 126050 RVA: 0x0091CFD9 File Offset: 0x0091B1D9
		public TArray<string> BasePaths
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._BasePaths) == null)
				{
					result = (this._BasePaths = new TArray<string>(base.NativePtr + (IntPtr)PDA_EffectPaths_C.__PropertyOffset_BasePaths, this));
				}
				return result;
			}
			set
			{
				this.BasePaths.CopyAssign(value);
			}
		}

		// Token: 0x0601EC63 RID: 126051 RVA: 0x0091CFE7 File Offset: 0x0091B1E7
		protected PDA_EffectPaths_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401058E RID: 66958
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/Debug/PDA_EffectPaths.PDA_EffectPaths_C";

		// Token: 0x0401058F RID: 66959
		private static IntPtr _ClassPtr;

		// Token: 0x04010590 RID: 66960
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010591 RID: 66961
		internal static int __PropertyOffset_BasePaths;

		// Token: 0x04010592 RID: 66962
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _BasePaths;
	}
}
