using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000410 RID: 1040
	[NullableContext(1)]
	[Nullable(0)]
	public class IHitBulletTypeAllCharacterAttack : IHitBulletType
	{
		// Token: 0x060014FD RID: 5373 RVA: 0x0004254C File Offset: 0x0004074C
		private IHitBulletTypeAllCharacterAttack_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHitBulletTypeAllCharacterAttack 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHitBulletTypeAllCharacterAttack_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHitBulletTypeAllCharacterAttack_SetValue());
			}
			return result;
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x00042584 File Offset: 0x00040784
		public static IHitBulletTypeAllCharacterAttack Create([Nullable(2)] IHitBulletTypeAllCharacterAttack instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitBulletTypeAllCharacterAttack
			{
				FbInstance = instance
			};
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x00042597 File Offset: 0x00040797
		public static IHitBulletTypeAllCharacterAttack CreateFromSetValue([Nullable(2)] IHitBulletTypeAllCharacterAttack_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHitBulletTypeAllCharacterAttack
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001500 RID: 5376 RVA: 0x000425AA File Offset: 0x000407AA
		public new IHitBulletTypeAllCharacterAttack_SetValue ToSetValue()
		{
			return new IHitBulletTypeAllCharacterAttack_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06001501 RID: 5377 RVA: 0x000425BD File Offset: 0x000407BD
		// (set) Token: 0x06001502 RID: 5378 RVA: 0x000425E8 File Offset: 0x000407E8
		public override EHitBulletType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHitBulletType.OnlyDropAttack;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001059 RID: 4185
		[Nullable(2)]
		protected new IHitBulletTypeAllCharacterAttack FbInstance;

		// Token: 0x0400105A RID: 4186
		[Nullable(2)]
		protected new IHitBulletTypeAllCharacterAttack_SetValue PocoInterface;
	}
}
