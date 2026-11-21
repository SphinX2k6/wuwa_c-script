using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020AA RID: 8362
	public class ISitOnGround : ILeisureInteractType
	{
		// Token: 0x0600B19A RID: 45466 RVA: 0x0018F530 File Offset: 0x0018D730
		private ISitOnGround_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISitOnGround 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISitOnGround_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISitOnGround_SetValue());
			}
			return result;
		}

		// Token: 0x0600B19B RID: 45467 RVA: 0x0018F568 File Offset: 0x0018D768
		public static ISitOnGround Create([Nullable(2)] ISitOnGround instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISitOnGround
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B19C RID: 45468 RVA: 0x0018F57B File Offset: 0x0018D77B
		public static ISitOnGround CreateFromSetValue([Nullable(2)] ISitOnGround_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISitOnGround
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B19D RID: 45469 RVA: 0x0018F58E File Offset: 0x0018D78E
		public new ISitOnGround_SetValue ToSetValue()
		{
			return new ISitOnGround_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170035DD RID: 13789
		// (get) Token: 0x0600B19E RID: 45470 RVA: 0x0018F5A1 File Offset: 0x0018D7A1
		// (set) Token: 0x0600B19F RID: 45471 RVA: 0x0018F5CC File Offset: 0x0018D7CC
		public override ELeisureInteract Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELeisureInteract.CustomSkill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006988 RID: 27016
		[Nullable(2)]
		protected new ISitOnGround FbInstance;

		// Token: 0x04006989 RID: 27017
		[Nullable(2)]
		protected new ISitOnGround_SetValue PocoInterface;
	}
}
