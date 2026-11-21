using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000783 RID: 1923
	public class ISpawnConfigType
	{
		// Token: 0x06002918 RID: 10520 RVA: 0x0006D040 File Offset: 0x0006B240
		private ISpawnConfigType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISpawnConfigType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISpawnConfigType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISpawnConfigType_SetValue());
			}
			return result;
		}

		// Token: 0x06002919 RID: 10521 RVA: 0x0006D078 File Offset: 0x0006B278
		public static ISpawnConfigType Create([Nullable(2)] ISpawnConfigType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpawnConfigType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600291A RID: 10522 RVA: 0x0006D08B File Offset: 0x0006B28B
		public static ISpawnConfigType CreateFromSetValue([Nullable(2)] ISpawnConfigType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISpawnConfigType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600291B RID: 10523 RVA: 0x0006D09E File Offset: 0x0006B29E
		public ISpawnConfigType_SetValue ToSetValue()
		{
			return new ISpawnConfigType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x0600291C RID: 10524 RVA: 0x0006D0B1 File Offset: 0x0006B2B1
		// (set) Token: 0x0600291D RID: 10525 RVA: 0x0006D0DC File Offset: 0x0006B2DC
		public virtual ESpawnConfigType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESpawnConfigType.TemplateMatrix;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001BDB RID: 7131
		[Nullable(2)]
		protected ISpawnConfigType FbInstance;

		// Token: 0x04001BDC RID: 7132
		[Nullable(2)]
		protected ISpawnConfigType_SetValue PocoInterface;
	}
}
