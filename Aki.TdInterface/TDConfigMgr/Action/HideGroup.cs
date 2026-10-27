using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001742 RID: 5954
	[NullableContext(1)]
	[Nullable(0)]
	public class HideGroup : ActionParams
	{
		// Token: 0x06007E03 RID: 32259 RVA: 0x0012DF68 File Offset: 0x0012C168
		private HideGroup_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("HideGroup 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			HideGroup_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new HideGroup_SetValue());
			}
			return result;
		}

		// Token: 0x06007E04 RID: 32260 RVA: 0x0012DFA0 File Offset: 0x0012C1A0
		public static HideGroup Create([Nullable(2)] HideGroup instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new HideGroup
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007E05 RID: 32261 RVA: 0x0012DFB3 File Offset: 0x0012C1B3
		public static HideGroup CreateFromSetValue([Nullable(2)] HideGroup_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new HideGroup
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007E06 RID: 32262 RVA: 0x0012DFC6 File Offset: 0x0012C1C6
		public HideGroup_SetValue ToSetValue()
		{
			return new HideGroup_SetValue
			{
				GroupKey = this.GroupKey,
				HideConfig = this.HideConfig,
				IsHidePasserByNpc = this.IsHidePasserByNpc
			};
		}

		// Token: 0x17002972 RID: 10610
		// (get) Token: 0x06007E07 RID: 32263 RVA: 0x0012DFF1 File Offset: 0x0012C1F1
		// (set) Token: 0x06007E08 RID: 32264 RVA: 0x0012E01C File Offset: 0x0012C21C
		public virtual string GroupKey
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GroupKey;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.GroupKey;
			}
			set
			{
				this.GetOrCreatePoco().GroupKey = value;
			}
		}

		// Token: 0x17002973 RID: 10611
		// (get) Token: 0x06007E09 RID: 32265 RVA: 0x0012E02A File Offset: 0x0012C22A
		// (set) Token: 0x06007E0A RID: 32266 RVA: 0x0012E051 File Offset: 0x0012C251
		public virtual IHideGroupType HideConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HideConfig;
				}
				HideGroup_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.HideConfig;
			}
			set
			{
				this.GetOrCreatePoco().HideConfig = value;
			}
		}

		// Token: 0x17002974 RID: 10612
		// (get) Token: 0x06007E0B RID: 32267 RVA: 0x0012E060 File Offset: 0x0012C260
		// (set) Token: 0x06007E0C RID: 32268 RVA: 0x0012E09A File Offset: 0x0012C29A
		public virtual bool? IsHidePasserByNpc
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsHidePasserByNpc;
				}
				HideGroup_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsHidePasserByNpc;
			}
			set
			{
				this.GetOrCreatePoco().IsHidePasserByNpc = value;
			}
		}

		// Token: 0x04005053 RID: 20563
		[Nullable(2)]
		protected new HideGroup FbInstance;

		// Token: 0x04005054 RID: 20564
		[Nullable(2)]
		protected HideGroup_SetValue PocoInterface;
	}
}
