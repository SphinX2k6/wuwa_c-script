using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C24 RID: 7204
	public class IFlowerSeaEscape : IUiGame
	{
		// Token: 0x06009902 RID: 39170 RVA: 0x00162BC4 File Offset: 0x00160DC4
		private IFlowerSeaEscape_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFlowerSeaEscape 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFlowerSeaEscape_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFlowerSeaEscape_SetValue());
			}
			return result;
		}

		// Token: 0x06009903 RID: 39171 RVA: 0x00162BFC File Offset: 0x00160DFC
		public static IFlowerSeaEscape Create([Nullable(2)] IFlowerSeaEscape instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowerSeaEscape
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009904 RID: 39172 RVA: 0x00162C0F File Offset: 0x00160E0F
		public static IFlowerSeaEscape CreateFromSetValue([Nullable(2)] IFlowerSeaEscape_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFlowerSeaEscape
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009905 RID: 39173 RVA: 0x00162C24 File Offset: 0x00160E24
		public new IFlowerSeaEscape_SetValue ToSetValue()
		{
			return new IFlowerSeaEscape_SetValue
			{
				Type = this.Type,
				EndAreaEntityId = this.EndAreaEntityId,
				ConfigDa = this.ConfigDa,
				SpreadingState = this.SpreadingState,
				PausedState = this.PausedState,
				ResetState = this.ResetState
			};
		}

		// Token: 0x17003058 RID: 12376
		// (get) Token: 0x06009906 RID: 39174 RVA: 0x00162C7E File Offset: 0x00160E7E
		// (set) Token: 0x06009907 RID: 39175 RVA: 0x00162CA9 File Offset: 0x00160EA9
		public override ESimpleGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESimpleGameplayType.Cipher;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003059 RID: 12377
		// (get) Token: 0x06009908 RID: 39176 RVA: 0x00162CB7 File Offset: 0x00160EB7
		// (set) Token: 0x06009909 RID: 39177 RVA: 0x00162CE2 File Offset: 0x00160EE2
		public virtual int EndAreaEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EndAreaEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EndAreaEntityId;
			}
			set
			{
				this.GetOrCreatePoco().EndAreaEntityId = value;
			}
		}

		// Token: 0x1700305A RID: 12378
		// (get) Token: 0x0600990A RID: 39178 RVA: 0x00162CF0 File Offset: 0x00160EF0
		// (set) Token: 0x0600990B RID: 39179 RVA: 0x00162D1B File Offset: 0x00160F1B
		public virtual string ConfigDa
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ConfigDa;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.ConfigDa;
			}
			set
			{
				this.GetOrCreatePoco().ConfigDa = value;
			}
		}

		// Token: 0x1700305B RID: 12379
		// (get) Token: 0x0600990C RID: 39180 RVA: 0x00162D29 File Offset: 0x00160F29
		// (set) Token: 0x0600990D RID: 39181 RVA: 0x00162D54 File Offset: 0x00160F54
		public virtual string SpreadingState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SpreadingState;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.SpreadingState;
			}
			set
			{
				this.GetOrCreatePoco().SpreadingState = value;
			}
		}

		// Token: 0x1700305C RID: 12380
		// (get) Token: 0x0600990E RID: 39182 RVA: 0x00162D62 File Offset: 0x00160F62
		// (set) Token: 0x0600990F RID: 39183 RVA: 0x00162D8D File Offset: 0x00160F8D
		public virtual string PausedState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PausedState;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.PausedState;
			}
			set
			{
				this.GetOrCreatePoco().PausedState = value;
			}
		}

		// Token: 0x1700305D RID: 12381
		// (get) Token: 0x06009910 RID: 39184 RVA: 0x00162D9B File Offset: 0x00160F9B
		// (set) Token: 0x06009911 RID: 39185 RVA: 0x00162DC6 File Offset: 0x00160FC6
		public virtual string ResetState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ResetState;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.ResetState;
			}
			set
			{
				this.GetOrCreatePoco().ResetState = value;
			}
		}

		// Token: 0x04005E25 RID: 24101
		[Nullable(2)]
		protected new IFlowerSeaEscape FbInstance;

		// Token: 0x04005E26 RID: 24102
		[Nullable(2)]
		protected new IFlowerSeaEscape_SetValue PocoInterface;
	}
}
