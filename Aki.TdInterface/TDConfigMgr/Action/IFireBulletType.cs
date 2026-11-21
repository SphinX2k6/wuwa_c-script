using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BFC RID: 7164
	public class IFireBulletType
	{
		// Token: 0x06009828 RID: 38952 RVA: 0x001613A0 File Offset: 0x0015F5A0
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

		// Token: 0x06009829 RID: 38953 RVA: 0x001613D8 File Offset: 0x0015F5D8
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

		// Token: 0x0600982A RID: 38954 RVA: 0x001613EB File Offset: 0x0015F5EB
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

		// Token: 0x0600982B RID: 38955 RVA: 0x001613FE File Offset: 0x0015F5FE
		public IFireBulletType_SetValue ToSetValue()
		{
			return new IFireBulletType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003027 RID: 12327
		// (get) Token: 0x0600982C RID: 38956 RVA: 0x00161411 File Offset: 0x0015F611
		// (set) Token: 0x0600982D RID: 38957 RVA: 0x0016143C File Offset: 0x0015F63C
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

		// Token: 0x04005DC0 RID: 24000
		[Nullable(2)]
		protected IFireBulletType FbInstance;

		// Token: 0x04005DC1 RID: 24001
		[Nullable(2)]
		protected IFireBulletType_SetValue PocoInterface;
	}
}
