using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001929 RID: 6441
	public class IAddEntityDecoration : IEntityDecorationConfig
	{
		// Token: 0x06008719 RID: 34585 RVA: 0x00141170 File Offset: 0x0013F370
		private IAddEntityDecoration_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAddEntityDecoration 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAddEntityDecoration_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAddEntityDecoration_SetValue());
			}
			return result;
		}

		// Token: 0x0600871A RID: 34586 RVA: 0x001411A8 File Offset: 0x0013F3A8
		public static IAddEntityDecoration Create([Nullable(2)] IAddEntityDecoration instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAddEntityDecoration
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600871B RID: 34587 RVA: 0x001411BB File Offset: 0x0013F3BB
		public static IAddEntityDecoration CreateFromSetValue([Nullable(2)] IAddEntityDecoration_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAddEntityDecoration
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600871C RID: 34588 RVA: 0x001411CE File Offset: 0x0013F3CE
		public new IAddEntityDecoration_SetValue ToSetValue()
		{
			return new IAddEntityDecoration_SetValue
			{
				Type = this.Type,
				DecorationId = this.DecorationId
			};
		}

		// Token: 0x17002BDB RID: 11227
		// (get) Token: 0x0600871D RID: 34589 RVA: 0x001411ED File Offset: 0x0013F3ED
		// (set) Token: 0x0600871E RID: 34590 RVA: 0x00141218 File Offset: 0x0013F418
		public override EEntityDecorationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEntityDecorationType.Add;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002BDC RID: 11228
		// (get) Token: 0x0600871F RID: 34591 RVA: 0x00141226 File Offset: 0x0013F426
		// (set) Token: 0x06008720 RID: 34592 RVA: 0x00141251 File Offset: 0x0013F451
		public virtual string DecorationId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DecorationId;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.DecorationId;
			}
			set
			{
				this.GetOrCreatePoco().DecorationId = value;
			}
		}

		// Token: 0x0400558E RID: 21902
		[Nullable(2)]
		protected new IAddEntityDecoration FbInstance;

		// Token: 0x0400558F RID: 21903
		[Nullable(2)]
		protected new IAddEntityDecoration_SetValue PocoInterface;
	}
}
