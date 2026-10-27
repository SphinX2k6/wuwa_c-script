using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.NewWorld.SceneItem.BulletCaster
{
	// Token: 0x0200722E RID: 29230
	[NullableContext(1)]
	[Nullable(0)]
	public class BulletCasterClassFactory : Singleton
	{
		// Token: 0x06047A4C RID: 293452 RVA: 0x01254B9C File Offset: 0x01252D9C
		public BulletCasterClassFactory()
		{
			this.BulletCasterClassRegistry.TryAdd(EBatchBulletMovementType.Stationary, typeof(BulletCasterStationary));
			this.BulletCasterClassRegistry.TryAdd(EBatchBulletMovementType.Sprint, typeof(BulletCasterSprint));
		}

		// Token: 0x06047A4D RID: 293453 RVA: 0x01254BE8 File Offset: 0x01252DE8
		[return: Nullable(2)]
		public IBulletCaster GetInstance(EBatchBulletMovementType type, BulletCasterInitParam initParam)
		{
			Type type2;
			if (this.BulletCasterClassRegistry.TryGetValue(type, out type2))
			{
				return (IBulletCaster)Activator.CreateInstance(type2, new object[]
				{
					initParam
				});
			}
			return null;
		}

		// Token: 0x17009E3D RID: 40509
		// (get) Token: 0x06047A4E RID: 293454 RVA: 0x01254C1C File Offset: 0x01252E1C
		public static BulletCasterClassFactory Instance
		{
			get
			{
				if (BulletCasterClassFactory._instance == null)
				{
					BulletCasterClassFactory._instance = new BulletCasterClassFactory();
					BulletCasterClassFactory._instance.OnInit();
				}
				return BulletCasterClassFactory._instance;
			}
		}

		// Token: 0x06047A4F RID: 293455 RVA: 0x01254C3F File Offset: 0x01252E3F
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06047A50 RID: 293456 RVA: 0x01254C41 File Offset: 0x01252E41
		public static void ResetStaticDefaultValue()
		{
			BulletCasterClassFactory instance = BulletCasterClassFactory._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			BulletCasterClassFactory._instance = null;
		}

		// Token: 0x06047A51 RID: 293457 RVA: 0x01254C5A File Offset: 0x01252E5A
		static BulletCasterClassFactory()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BulletCasterClassFactory.CreateStaticDefaultValue), new Action(BulletCasterClassFactory.ResetStaticDefaultValue));
		}

		// Token: 0x04025B1B RID: 154395
		private readonly Dictionary<EBatchBulletMovementType, Type> BulletCasterClassRegistry = new Dictionary<EBatchBulletMovementType, Type>();

		// Token: 0x04025B1C RID: 154396
		[Nullable(2)]
		private static BulletCasterClassFactory _instance;
	}
}
