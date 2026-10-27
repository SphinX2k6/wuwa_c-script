using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000500 RID: 1280
	[NullableContext(1)]
	[Nullable(0)]
	public class IMonsterChooseType
	{
		// Token: 0x06001A0A RID: 6666 RVA: 0x0004C634 File Offset: 0x0004A834
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

		// Token: 0x06001A0B RID: 6667 RVA: 0x0004C66C File Offset: 0x0004A86C
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

		// Token: 0x06001A0C RID: 6668 RVA: 0x0004C67F File Offset: 0x0004A87F
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

		// Token: 0x06001A0D RID: 6669 RVA: 0x0004C692 File Offset: 0x0004A892
		public IMonsterChooseType_SetValue ToSetValue()
		{
			return new IMonsterChooseType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06001A0E RID: 6670 RVA: 0x0004C6A5 File Offset: 0x0004A8A5
		// (set) Token: 0x06001A0F RID: 6671 RVA: 0x0004C6D0 File Offset: 0x0004A8D0
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

		// Token: 0x040012FA RID: 4858
		[Nullable(2)]
		protected IMonsterChooseType FbInstance;

		// Token: 0x040012FB RID: 4859
		[Nullable(2)]
		protected IMonsterChooseType_SetValue PocoInterface;
	}
}
