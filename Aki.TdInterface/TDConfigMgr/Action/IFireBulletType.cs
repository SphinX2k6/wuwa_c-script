using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A67 RID: 6759
	[NullableContext(1)]
	[Nullable(0)]
	public class IFireBulletType
	{
		// Token: 0x060090BE RID: 37054 RVA: 0x00151474 File Offset: 0x0014F674
		private IFireBulletType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFireBulletType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFireBulletType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFireBulletType_SetValue());
			}
			return result;
		}

		// Token: 0x060090BF RID: 37055 RVA: 0x001514AC File Offset: 0x0014F6AC
		public static IFireBulletType Create([Nullable(2)] IFireBulletType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFireBulletType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060090C0 RID: 37056 RVA: 0x001514BF File Offset: 0x0014F6BF
		public static IFireBulletType CreateFromSetValue([Nullable(2)] IFireBulletType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFireBulletType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060090C1 RID: 37057 RVA: 0x001514D2 File Offset: 0x0014F6D2
		public IFireBulletType_SetValue ToSetValue()
		{
			return new IFireBulletType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002E1A RID: 11802
		// (get) Token: 0x060090C2 RID: 37058 RVA: 0x001514E5 File Offset: 0x0014F6E5
		// (set) Token: 0x060090C3 RID: 37059 RVA: 0x00151510 File Offset: 0x0014F710
		public virtual EFireBulletType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EFireBulletType.TrackTarget;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400595B RID: 22875
		[Nullable(2)]
		protected IFireBulletType FbInstance;

		// Token: 0x0400595C RID: 22876
		[Nullable(2)]
		protected IFireBulletType_SetValue PocoInterface;
	}
}
