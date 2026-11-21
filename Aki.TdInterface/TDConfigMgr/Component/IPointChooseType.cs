using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006A7 RID: 1703
	public class IPointChooseType
	{
		// Token: 0x06002408 RID: 9224 RVA: 0x00062734 File Offset: 0x00060934
		private IPointChooseType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPointChooseType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPointChooseType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPointChooseType_SetValue());
			}
			return result;
		}

		// Token: 0x06002409 RID: 9225 RVA: 0x0006276C File Offset: 0x0006096C
		public static IPointChooseType Create([Nullable(2)] IPointChooseType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPointChooseType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600240A RID: 9226 RVA: 0x0006277F File Offset: 0x0006097F
		public static IPointChooseType CreateFromSetValue([Nullable(2)] IPointChooseType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPointChooseType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600240B RID: 9227 RVA: 0x00062792 File Offset: 0x00060992
		public IPointChooseType_SetValue ToSetValue()
		{
			return new IPointChooseType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x0600240C RID: 9228 RVA: 0x000627A5 File Offset: 0x000609A5
		// (set) Token: 0x0600240D RID: 9229 RVA: 0x000627D0 File Offset: 0x000609D0
		public virtual EPointChooseType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPointChooseType.SpawnMonsterPoint;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400190B RID: 6411
		[Nullable(2)]
		protected IPointChooseType FbInstance;

		// Token: 0x0400190C RID: 6412
		[Nullable(2)]
		protected IPointChooseType_SetValue PocoInterface;
	}
}
