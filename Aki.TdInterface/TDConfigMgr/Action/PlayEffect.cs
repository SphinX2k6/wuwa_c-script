using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200236A RID: 9066
	public class PlayEffect : ActionParams
	{
		// Token: 0x0600C598 RID: 50584 RVA: 0x001C5154 File Offset: 0x001C3354
		private PlayEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("PlayEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			PlayEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new PlayEffect_SetValue());
			}
			return result;
		}

		// Token: 0x0600C599 RID: 50585 RVA: 0x001C518C File Offset: 0x001C338C
		public static PlayEffect Create([Nullable(2)] PlayEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PlayEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C59A RID: 50586 RVA: 0x001C519F File Offset: 0x001C339F
		public static PlayEffect CreateFromSetValue([Nullable(2)] PlayEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new PlayEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C59B RID: 50587 RVA: 0x001C51B2 File Offset: 0x001C33B2
		public PlayEffect_SetValue ToSetValue()
		{
			return new PlayEffect_SetValue
			{
				Path = this.Path,
				Pos2 = this.Pos2
			};
		}

		// Token: 0x17003BBE RID: 15294
		// (get) Token: 0x0600C59C RID: 50588 RVA: 0x001C51D1 File Offset: 0x001C33D1
		// (set) Token: 0x0600C59D RID: 50589 RVA: 0x001C51FC File Offset: 0x001C33FC
		public virtual string Path
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Path;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Path;
			}
			set
			{
				this.GetOrCreatePoco().Path = value;
			}
		}

		// Token: 0x17003BBF RID: 15295
		// (get) Token: 0x0600C59E RID: 50590 RVA: 0x001C520A File Offset: 0x001C340A
		// (set) Token: 0x0600C59F RID: 50591 RVA: 0x001C5231 File Offset: 0x001C3431
		public virtual IBasePos2 Pos2
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Pos2;
				}
				PlayEffect_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Pos2;
			}
			set
			{
				this.GetOrCreatePoco().Pos2 = value;
			}
		}

		// Token: 0x04007597 RID: 30103
		[Nullable(2)]
		protected new PlayEffect FbInstance;

		// Token: 0x04007598 RID: 30104
		[Nullable(2)]
		protected PlayEffect_SetValue PocoInterface;
	}
}
