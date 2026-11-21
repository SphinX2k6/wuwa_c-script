using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.PathLine
{
	// Token: 0x020031A6 RID: 12710
	[UnrealObjectPath("/Game/Aki/Data/PathLine/BP_Miaozhunxian_Bullet.BP_Miaozhunxian_Bullet_C")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class BP_Miaozhunxian_Bullet_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F615 RID: 128533 RVA: 0x0092C778 File Offset: 0x0092A978
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Miaozhunxian_Bullet_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/PathLine/BP_Miaozhunxian_Bullet.BP_Miaozhunxian_Bullet_C");
			}
			return BP_Miaozhunxian_Bullet_C._ClassPtr;
		}

		// Token: 0x0601F616 RID: 128534 RVA: 0x0092C79C File Offset: 0x0092A99C
		public BP_Miaozhunxian_Bullet_C() : this(BuiltinUtils.AllocNativeUObject(BP_Miaozhunxian_Bullet_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F617 RID: 128535 RVA: 0x0092C7C4 File Offset: 0x0092A9C4
		[NullableContext(1)]
		public BP_Miaozhunxian_Bullet_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Miaozhunxian_Bullet_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170038FC RID: 14588
		// (get) Token: 0x0601F618 RID: 128536 RVA: 0x0092C7F7 File Offset: 0x0092A9F7
		// (set) Token: 0x0601F619 RID: 128537 RVA: 0x0092C80B File Offset: 0x0092AA0B
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Miaozhunxian_Bullet_C.__PropertyOffset_DefaultSceneRoot);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Miaozhunxian_Bullet_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x0601F61A RID: 128538 RVA: 0x0092C820 File Offset: 0x0092AA20
		protected BP_Miaozhunxian_Bullet_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010D1D RID: 68893
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/PathLine/BP_Miaozhunxian_Bullet.BP_Miaozhunxian_Bullet_C";

		// Token: 0x04010D1E RID: 68894
		private static IntPtr _ClassPtr;

		// Token: 0x04010D1F RID: 68895
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010D20 RID: 68896
		internal static int __PropertyOffset_DefaultSceneRoot;
	}
}
