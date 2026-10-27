using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.PathLine
{
	// Token: 0x02003EE3 RID: 16099
	[UnrealObjectPath("/Game/Aki/Data/PathLine/BP_Miaozhunxian_Bullet.BP_Miaozhunxian_Bullet_C")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class BP_Miaozhunxian_Bullet_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028C1C RID: 166940 RVA: 0x009B3E58 File Offset: 0x009B2058
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Miaozhunxian_Bullet_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/PathLine/BP_Miaozhunxian_Bullet.BP_Miaozhunxian_Bullet_C");
			}
			return BP_Miaozhunxian_Bullet_C._ClassPtr;
		}

		// Token: 0x06028C1D RID: 166941 RVA: 0x009B3E7C File Offset: 0x009B207C
		public BP_Miaozhunxian_Bullet_C() : this(BuiltinUtils.AllocNativeUObject(BP_Miaozhunxian_Bullet_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028C1E RID: 166942 RVA: 0x009B3EA4 File Offset: 0x009B20A4
		[NullableContext(1)]
		public BP_Miaozhunxian_Bullet_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Miaozhunxian_Bullet_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005F7B RID: 24443
		// (get) Token: 0x06028C1F RID: 166943 RVA: 0x009B3ED7 File Offset: 0x009B20D7
		// (set) Token: 0x06028C20 RID: 166944 RVA: 0x009B3EEB File Offset: 0x009B20EB
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Miaozhunxian_Bullet_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Miaozhunxian_Bullet_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06028C21 RID: 166945 RVA: 0x009B3F00 File Offset: 0x009B2100
		protected BP_Miaozhunxian_Bullet_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014D50 RID: 85328
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/PathLine/BP_Miaozhunxian_Bullet.BP_Miaozhunxian_Bullet_C";

		// Token: 0x04014D51 RID: 85329
		private static IntPtr _ClassPtr;

		// Token: 0x04014D52 RID: 85330
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014D53 RID: 85331
		internal static int __PropertyOffset_0;
	}
}
