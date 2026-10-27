using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DF2 RID: 7666
	[NullableContext(1)]
	[Nullable(0)]
	public class ISelfEntity : ITargetEntityType
	{
		// Token: 0x0600A40F RID: 41999 RVA: 0x00174350 File Offset: 0x00172550
		private ISelfEntity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISelfEntity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISelfEntity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISelfEntity_SetValue());
			}
			return result;
		}

		// Token: 0x0600A410 RID: 42000 RVA: 0x00174388 File Offset: 0x00172588
		public static ISelfEntity Create([Nullable(2)] ISelfEntity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISelfEntity
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A411 RID: 42001 RVA: 0x0017439B File Offset: 0x0017259B
		public static ISelfEntity CreateFromSetValue([Nullable(2)] ISelfEntity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISelfEntity
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A412 RID: 42002 RVA: 0x001743AE File Offset: 0x001725AE
		public new ISelfEntity_SetValue ToSetValue()
		{
			return new ISelfEntity_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003273 RID: 12915
		// (get) Token: 0x0600A413 RID: 42003 RVA: 0x001743C1 File Offset: 0x001725C1
		// (set) Token: 0x0600A414 RID: 42004 RVA: 0x001743EC File Offset: 0x001725EC
		public override ETargetEntityType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETargetEntityType.Target;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006246 RID: 25158
		[Nullable(2)]
		protected new ISelfEntity FbInstance;

		// Token: 0x04006247 RID: 25159
		[Nullable(2)]
		protected new ISelfEntity_SetValue PocoInterface;
	}
}
