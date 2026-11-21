using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005BF RID: 1471
	public class INpcBumpShow
	{
		// Token: 0x06001DFA RID: 7674 RVA: 0x00055500 File Offset: 0x00053700
		private INpcBumpShow_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcBumpShow 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcBumpShow_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcBumpShow_SetValue());
			}
			return result;
		}

		// Token: 0x06001DFB RID: 7675 RVA: 0x00055538 File Offset: 0x00053738
		public static INpcBumpShow Create([Nullable(2)] INpcBumpShow instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcBumpShow
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001DFC RID: 7676 RVA: 0x0005554B File Offset: 0x0005374B
		public static INpcBumpShow CreateFromSetValue([Nullable(2)] INpcBumpShow_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcBumpShow
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001DFD RID: 7677 RVA: 0x0005555E File Offset: 0x0005375E
		public INpcBumpShow_SetValue ToSetValue()
		{
			return new INpcBumpShow_SetValue
			{
				BumpBubble = this.BumpBubble
			};
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x06001DFE RID: 7678 RVA: 0x00055574 File Offset: 0x00053774
		// (set) Token: 0x06001DFF RID: 7679 RVA: 0x000555D5 File Offset: 0x000537D5
		[Nullable(2)]
		public virtual INpcPerformBubble BumpBubble
		{
			[NullableContext(2)]
			get
			{
				if (this._BumpBubbleInited)
				{
					return this._BumpBubbleCache;
				}
				this._BumpBubbleInited = true;
				if (this.FbInstance != null)
				{
					this._BumpBubbleCache = INpcPerformBubble.Create(this.FbInstance.BumpBubble);
				}
				else
				{
					INpcBumpShow_SetValue pocoInterface = this.PocoInterface;
					this._BumpBubbleCache = ((pocoInterface != null) ? pocoInterface.BumpBubble : null);
				}
				return this._BumpBubbleCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().BumpBubble = value;
				this._BumpBubbleInited = false;
			}
		}

		// Token: 0x04001578 RID: 5496
		[Nullable(2)]
		protected INpcBumpShow FbInstance;

		// Token: 0x04001579 RID: 5497
		[Nullable(2)]
		protected INpcBumpShow_SetValue PocoInterface;

		// Token: 0x0400157A RID: 5498
		private INpcPerformBubble _BumpBubbleCache;

		// Token: 0x0400157B RID: 5499
		private bool _BumpBubbleInited;
	}
}
