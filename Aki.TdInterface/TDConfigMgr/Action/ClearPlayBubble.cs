using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001652 RID: 5714
	public class ClearPlayBubble : ActionParams
	{
		// Token: 0x060080DF RID: 32991 RVA: 0x0013278C File Offset: 0x0013098C
		private ClearPlayBubble_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ClearPlayBubble 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ClearPlayBubble_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ClearPlayBubble_SetValue());
			}
			return result;
		}

		// Token: 0x060080E0 RID: 32992 RVA: 0x001327C4 File Offset: 0x001309C4
		public static ClearPlayBubble Create([Nullable(2)] ClearPlayBubble instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ClearPlayBubble
			{
				FbInstance = instance
			};
		}

		// Token: 0x060080E1 RID: 32993 RVA: 0x001327D7 File Offset: 0x001309D7
		public static ClearPlayBubble CreateFromSetValue([Nullable(2)] ClearPlayBubble_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ClearPlayBubble
			{
				PocoInterface = value
			};
		}

		// Token: 0x060080E2 RID: 32994 RVA: 0x001327EA File Offset: 0x001309EA
		public ClearPlayBubble_SetValue ToSetValue()
		{
			return new ClearPlayBubble_SetValue
			{
				EntityIds = this.EntityIds,
				OnlyClearRedDot = this.OnlyClearRedDot
			};
		}

		// Token: 0x17002AB5 RID: 10933
		// (get) Token: 0x060080E3 RID: 32995 RVA: 0x00132809 File Offset: 0x00130A09
		// (set) Token: 0x060080E4 RID: 32996 RVA: 0x00132830 File Offset: 0x00130A30
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				ClearPlayBubble_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EntityIds;
			}
			set
			{
				this.GetOrCreatePoco().EntityIds = value;
			}
		}

		// Token: 0x17002AB6 RID: 10934
		// (get) Token: 0x060080E5 RID: 32997 RVA: 0x00132840 File Offset: 0x00130A40
		// (set) Token: 0x060080E6 RID: 32998 RVA: 0x0013287A File Offset: 0x00130A7A
		public virtual bool? OnlyClearRedDot
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.OnlyClearRedDot;
				}
				ClearPlayBubble_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.OnlyClearRedDot;
			}
			set
			{
				this.GetOrCreatePoco().OnlyClearRedDot = value;
			}
		}

		// Token: 0x04004A5C RID: 19036
		[Nullable(2)]
		protected new ClearPlayBubble FbInstance;

		// Token: 0x04004A5D RID: 19037
		[Nullable(2)]
		protected ClearPlayBubble_SetValue PocoInterface;
	}
}
