using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014F9 RID: 5369
	[NullableContext(1)]
	[Nullable(0)]
	public class ClearPlayBubble : ActionParams
	{
		// Token: 0x06007A12 RID: 31250 RVA: 0x00123B54 File Offset: 0x00121D54
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

		// Token: 0x06007A13 RID: 31251 RVA: 0x00123B8C File Offset: 0x00121D8C
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

		// Token: 0x06007A14 RID: 31252 RVA: 0x00123B9F File Offset: 0x00121D9F
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

		// Token: 0x06007A15 RID: 31253 RVA: 0x00123BB2 File Offset: 0x00121DB2
		public ClearPlayBubble_SetValue ToSetValue()
		{
			return new ClearPlayBubble_SetValue
			{
				EntityIds = this.EntityIds,
				OnlyClearRedDot = this.OnlyClearRedDot
			};
		}

		// Token: 0x170028CB RID: 10443
		// (get) Token: 0x06007A16 RID: 31254 RVA: 0x00123BD1 File Offset: 0x00121DD1
		// (set) Token: 0x06007A17 RID: 31255 RVA: 0x00123BF8 File Offset: 0x00121DF8
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

		// Token: 0x170028CC RID: 10444
		// (get) Token: 0x06007A18 RID: 31256 RVA: 0x00123C08 File Offset: 0x00121E08
		// (set) Token: 0x06007A19 RID: 31257 RVA: 0x00123C42 File Offset: 0x00121E42
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

		// Token: 0x040046C1 RID: 18113
		[Nullable(2)]
		protected new ClearPlayBubble FbInstance;

		// Token: 0x040046C2 RID: 18114
		[Nullable(2)]
		protected ClearPlayBubble_SetValue PocoInterface;
	}
}
