using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AEF RID: 6895
	public class IDaolingAuthentication : IUiGame
	{
		// Token: 0x06009277 RID: 37495 RVA: 0x00157300 File Offset: 0x00155500
		private IDaolingAuthentication_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDaolingAuthentication 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDaolingAuthentication_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDaolingAuthentication_SetValue());
			}
			return result;
		}

		// Token: 0x06009278 RID: 37496 RVA: 0x00157338 File Offset: 0x00155538
		public static IDaolingAuthentication Create([Nullable(2)] IDaolingAuthentication instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDaolingAuthentication
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009279 RID: 37497 RVA: 0x0015734B File Offset: 0x0015554B
		public static IDaolingAuthentication CreateFromSetValue([Nullable(2)] IDaolingAuthentication_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDaolingAuthentication
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600927A RID: 37498 RVA: 0x0015735E File Offset: 0x0015555E
		public new IDaolingAuthentication_SetValue ToSetValue()
		{
			return new IDaolingAuthentication_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002EE1 RID: 12001
		// (get) Token: 0x0600927B RID: 37499 RVA: 0x00157371 File Offset: 0x00155571
		// (set) Token: 0x0600927C RID: 37500 RVA: 0x0015739C File Offset: 0x0015559C
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

		// Token: 0x04005B3E RID: 23358
		[Nullable(2)]
		protected new IDaolingAuthentication FbInstance;

		// Token: 0x04005B3F RID: 23359
		[Nullable(2)]
		protected new IDaolingAuthentication_SetValue PocoInterface;
	}
}
