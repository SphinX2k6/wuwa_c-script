using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.NewWorld.SceneItem.BulletCaster
{
	// Token: 0x020062E3 RID: 25315
	[NullableContext(1)]
	[Nullable(0)]
	public class BulletCasterClassFactory : Singleton
	{
		// Token: 0x0603D3AD RID: 250797 RVA: 0x011AD734 File Offset: 0x011AB934
		public BulletCasterClassFactory()
		{
			this.BulletCasterClassRegistry.TryAdd(EBatchBulletMovementType.Stationary, typeof(BulletCasterStationary));
			this.BulletCasterClassRegistry.TryAdd(EBatchBulletMovementType.Sprint, typeof(BulletCasterSprint));
		}

		// Token: 0x0603D3AE RID: 250798 RVA: 0x011AD780 File Offset: 0x011AB980
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

		// Token: 0x170073F4 RID: 29684
		// (get) Token: 0x0603D3AF RID: 250799 RVA: 0x011AD7B4 File Offset: 0x011AB9B4
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

		// Token: 0x0603D3B0 RID: 250800 RVA: 0x011AD7D7 File Offset: 0x011AB9D7
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603D3B1 RID: 250801 RVA: 0x011AD7D9 File Offset: 0x011AB9D9
		public static void ResetStaticDefaultValue()
		{
			BulletCasterClassFactory instance = BulletCasterClassFactory._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			BulletCasterClassFactory._instance = null;
		}

		// Token: 0x0603D3B2 RID: 250802 RVA: 0x011AD7F2 File Offset: 0x011AB9F2
		static BulletCasterClassFactory()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BulletCasterClassFactory.CreateStaticDefaultValue), new Action(BulletCasterClassFactory.ResetStaticDefaultValue));
		}

		// Token: 0x0402078A RID: 133002
		private readonly Dictionary<EBatchBulletMovementType, Type> BulletCasterClassRegistry = new Dictionary<EBatchBulletMovementType, Type>();

		// Token: 0x0402078B RID: 133003
		[Nullable(2)]
		private static BulletCasterClassFactory _instance;
	}
}
