using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.Debug
{
	// Token: 0x02003DDC RID: 15836
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/Debug/PDA_EffectPaths.PDA_EffectPaths_C")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class PDA_EffectPaths_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060277D9 RID: 161753 RVA: 0x00992E7C File Offset: 0x0099107C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PDA_EffectPaths_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Effect/Debug/PDA_EffectPaths.PDA_EffectPaths_C");
			}
			return PDA_EffectPaths_C._ClassPtr;
		}

		// Token: 0x060277DA RID: 161754 RVA: 0x00992EA0 File Offset: 0x009910A0
		public PDA_EffectPaths_C() : this(BuiltinUtils.AllocNativeUObject(PDA_EffectPaths_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060277DB RID: 161755 RVA: 0x00992EC8 File Offset: 0x009910C8
		public PDA_EffectPaths_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PDA_EffectPaths_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700586F RID: 22639
		// (get) Token: 0x060277DC RID: 161756 RVA: 0x00992EFC File Offset: 0x009910FC
		// (set) Token: 0x060277DD RID: 161757 RVA: 0x00992F35 File Offset: 0x00991135
		public TArray<string> BasePaths
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._BasePaths) == null)
				{
					result = (this._BasePaths = new TArray<string>(base.NativePtr + (IntPtr)PDA_EffectPaths_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				this.BasePaths.CopyAssign(value);
			}
		}

		// Token: 0x060277DE RID: 161758 RVA: 0x00992F43 File Offset: 0x00991143
		protected PDA_EffectPaths_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013F5E RID: 81758
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/Debug/PDA_EffectPaths.PDA_EffectPaths_C";

		// Token: 0x04013F5F RID: 81759
		private static IntPtr _ClassPtr;

		// Token: 0x04013F60 RID: 81760
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013F61 RID: 81761
		internal static int __PropertyOffset_0;

		// Token: 0x04013F62 RID: 81762
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _BasePaths;
	}
}
