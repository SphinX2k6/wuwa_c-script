using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02003FF3 RID: 16371
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/DefaultBulletSceneInteraction.DefaultBulletSceneInteraction_C")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class DefaultBulletSceneInteraction_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06029F9E RID: 171934 RVA: 0x009D24E6 File Offset: 0x009D06E6
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (DefaultBulletSceneInteraction_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Core/Fight/DefaultBulletSceneInteraction.DefaultBulletSceneInteraction_C");
			}
			return DefaultBulletSceneInteraction_C._ClassPtr;
		}

		// Token: 0x06029F9F RID: 171935 RVA: 0x009D250C File Offset: 0x009D070C
		public DefaultBulletSceneInteraction_C() : this(BuiltinUtils.AllocNativeUObject(DefaultBulletSceneInteraction_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06029FA0 RID: 171936 RVA: 0x009D2534 File Offset: 0x009D0734
		public DefaultBulletSceneInteraction_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(DefaultBulletSceneInteraction_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006618 RID: 26136
		// (get) Token: 0x06029FA1 RID: 171937 RVA: 0x009D2568 File Offset: 0x009D0768
		// (set) Token: 0x06029FA2 RID: 171938 RVA: 0x009D25A1 File Offset: 0x009D07A1
		public TArray<ConditionBulletSceneInteraction> ConditionConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ConditionBulletSceneInteraction> result;
				if ((result = this._ConditionConfig) == null)
				{
					result = (this._ConditionConfig = new TArray<ConditionBulletSceneInteraction>(base.NativePtr + (IntPtr)DefaultBulletSceneInteraction_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				this.ConditionConfig.CopyAssign(value);
			}
		}

		// Token: 0x06029FA3 RID: 171939 RVA: 0x009D25AF File Offset: 0x009D07AF
		protected DefaultBulletSceneInteraction_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015920 RID: 88352
		public new const string __ObjectPath = "/Game/Aki/Core/Fight/DefaultBulletSceneInteraction.DefaultBulletSceneInteraction_C";

		// Token: 0x04015921 RID: 88353
		private static IntPtr _ClassPtr;

		// Token: 0x04015922 RID: 88354
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015923 RID: 88355
		internal static int __PropertyOffset_0;

		// Token: 0x04015924 RID: 88356
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ConditionBulletSceneInteraction> _ConditionConfig;
	}
}
