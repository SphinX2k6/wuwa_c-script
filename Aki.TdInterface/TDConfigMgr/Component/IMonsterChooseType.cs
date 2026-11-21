using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000561 RID: 1377
	public class IMonsterChooseType
	{
		// Token: 0x06001BEC RID: 7148 RVA: 0x00051178 File Offset: 0x0004F378
		private IMonsterChooseType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMonsterChooseType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMonsterChooseType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMonsterChooseType_SetValue());
			}
			return result;
		}

		// Token: 0x06001BED RID: 7149 RVA: 0x000511B0 File Offset: 0x0004F3B0
		public static IMonsterChooseType Create([Nullable(2)] IMonsterChooseType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterChooseType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001BEE RID: 7150 RVA: 0x000511C3 File Offset: 0x0004F3C3
		public static IMonsterChooseType CreateFromSetValue([Nullable(2)] IMonsterChooseType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMonsterChooseType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001BEF RID: 7151 RVA: 0x000511D6 File Offset: 0x0004F3D6
		public IMonsterChooseType_SetValue ToSetValue()
		{
			return new IMonsterChooseType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06001BF0 RID: 7152 RVA: 0x000511E9 File Offset: 0x0004F3E9
		// (set) Token: 0x06001BF1 RID: 7153 RVA: 0x00051214 File Offset: 0x0004F414
		public virtual EMonsterChooseType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMonsterChooseType.RandomPoolChoose;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400145A RID: 5210
		[Nullable(2)]
		protected IMonsterChooseType FbInstance;

		// Token: 0x0400145B RID: 5211
		[Nullable(2)]
		protected IMonsterChooseType_SetValue PocoInterface;
	}
}
