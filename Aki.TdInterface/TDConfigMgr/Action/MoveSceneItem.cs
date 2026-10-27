using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020DD RID: 8413
	[NullableContext(1)]
	[Nullable(0)]
	public class MoveSceneItem : ActionParams
	{
		// Token: 0x0600B8D4 RID: 47316 RVA: 0x001AB6CC File Offset: 0x001A98CC
		private MoveSceneItem_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("MoveSceneItem 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			MoveSceneItem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new MoveSceneItem_SetValue());
			}
			return result;
		}

		// Token: 0x0600B8D5 RID: 47317 RVA: 0x001AB704 File Offset: 0x001A9904
		public static MoveSceneItem Create([Nullable(2)] MoveSceneItem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new MoveSceneItem
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B8D6 RID: 47318 RVA: 0x001AB717 File Offset: 0x001A9917
		public static MoveSceneItem CreateFromSetValue([Nullable(2)] MoveSceneItem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new MoveSceneItem
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B8D7 RID: 47319 RVA: 0x001AB72A File Offset: 0x001A992A
		public MoveSceneItem_SetValue ToSetValue()
		{
			return new MoveSceneItem_SetValue
			{
				EntityId = this.EntityId,
				StopBeforeMove = this.StopBeforeMove,
				MoveConfig = this.MoveConfig,
				BypassClientResponse = this.BypassClientResponse
			};
		}

		// Token: 0x17003877 RID: 14455
		// (get) Token: 0x0600B8D8 RID: 47320 RVA: 0x001AB761 File Offset: 0x001A9961
		// (set) Token: 0x0600B8D9 RID: 47321 RVA: 0x001AB78C File Offset: 0x001A998C
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x17003878 RID: 14456
		// (get) Token: 0x0600B8DA RID: 47322 RVA: 0x001AB79C File Offset: 0x001A999C
		// (set) Token: 0x0600B8DB RID: 47323 RVA: 0x001AB7D6 File Offset: 0x001A99D6
		public virtual bool? StopBeforeMove
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StopBeforeMove;
				}
				MoveSceneItem_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.StopBeforeMove;
			}
			set
			{
				this.GetOrCreatePoco().StopBeforeMove = value;
			}
		}

		// Token: 0x17003879 RID: 14457
		// (get) Token: 0x0600B8DC RID: 47324 RVA: 0x001AB7E4 File Offset: 0x001A99E4
		// (set) Token: 0x0600B8DD RID: 47325 RVA: 0x001AB80B File Offset: 0x001A9A0B
		public virtual IMoveSceneItemType MoveConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MoveConfig;
				}
				MoveSceneItem_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MoveConfig;
			}
			set
			{
				this.GetOrCreatePoco().MoveConfig = value;
			}
		}

		// Token: 0x1700387A RID: 14458
		// (get) Token: 0x0600B8DE RID: 47326 RVA: 0x001AB81C File Offset: 0x001A9A1C
		// (set) Token: 0x0600B8DF RID: 47327 RVA: 0x001AB856 File Offset: 0x001A9A56
		public virtual bool? BypassClientResponse
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BypassClientResponse;
				}
				MoveSceneItem_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.BypassClientResponse;
			}
			set
			{
				this.GetOrCreatePoco().BypassClientResponse = value;
			}
		}

		// Token: 0x04006EB6 RID: 28342
		[Nullable(2)]
		protected new MoveSceneItem FbInstance;

		// Token: 0x04006EB7 RID: 28343
		[Nullable(2)]
		protected MoveSceneItem_SetValue PocoInterface;
	}
}
