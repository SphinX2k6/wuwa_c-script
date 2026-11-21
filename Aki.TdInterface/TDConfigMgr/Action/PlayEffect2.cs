using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200236C RID: 9068
	public class PlayEffect2 : ActionParams
	{
		// Token: 0x0600C5A2 RID: 50594 RVA: 0x001C5250 File Offset: 0x001C3450
		private PlayEffect2_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("PlayEffect2 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			PlayEffect2_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new PlayEffect2_SetValue());
			}
			return result;
		}

		// Token: 0x0600C5A3 RID: 50595 RVA: 0x001C5288 File Offset: 0x001C3488
		public static PlayEffect2 Create([Nullable(2)] PlayEffect2 instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PlayEffect2
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C5A4 RID: 50596 RVA: 0x001C529B File Offset: 0x001C349B
		public static PlayEffect2 CreateFromSetValue([Nullable(2)] PlayEffect2_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new PlayEffect2
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C5A5 RID: 50597 RVA: 0x001C52AE File Offset: 0x001C34AE
		public PlayEffect2_SetValue ToSetValue()
		{
			return new PlayEffect2_SetValue
			{
				Type = this.Type,
				Path = this.Path
			};
		}

		// Token: 0x17003BC0 RID: 15296
		// (get) Token: 0x0600C5A6 RID: 50598 RVA: 0x001C52CD File Offset: 0x001C34CD
		// (set) Token: 0x0600C5A7 RID: 50599 RVA: 0x001C52F8 File Offset: 0x001C34F8
		public virtual EEffectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEffectType.Effect;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003BC1 RID: 15297
		// (get) Token: 0x0600C5A8 RID: 50600 RVA: 0x001C5306 File Offset: 0x001C3506
		// (set) Token: 0x0600C5A9 RID: 50601 RVA: 0x001C5331 File Offset: 0x001C3531
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

		// Token: 0x0400759B RID: 30107
		[Nullable(2)]
		protected new PlayEffect2 FbInstance;

		// Token: 0x0400759C RID: 30108
		[Nullable(2)]
		protected PlayEffect2_SetValue PocoInterface;
	}
}
