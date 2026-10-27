using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014C6 RID: 5318
	[NullableContext(1)]
	[Nullable(0)]
	public class ChangeActorTalker : ActionParams
	{
		// Token: 0x0600791E RID: 31006 RVA: 0x001221EC File Offset: 0x001203EC
		private ChangeActorTalker_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ChangeActorTalker 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ChangeActorTalker_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ChangeActorTalker_SetValue());
			}
			return result;
		}

		// Token: 0x0600791F RID: 31007 RVA: 0x00122224 File Offset: 0x00120424
		public static ChangeActorTalker Create([Nullable(2)] ChangeActorTalker instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeActorTalker
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007920 RID: 31008 RVA: 0x00122237 File Offset: 0x00120437
		public static ChangeActorTalker CreateFromSetValue([Nullable(2)] ChangeActorTalker_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ChangeActorTalker
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007921 RID: 31009 RVA: 0x0012224A File Offset: 0x0012044A
		public ChangeActorTalker_SetValue ToSetValue()
		{
			return new ChangeActorTalker_SetValue
			{
				ActorIndex = this.ActorIndex,
				Talker = this.Talker
			};
		}

		// Token: 0x1700289C RID: 10396
		// (get) Token: 0x06007922 RID: 31010 RVA: 0x00122269 File Offset: 0x00120469
		// (set) Token: 0x06007923 RID: 31011 RVA: 0x00122294 File Offset: 0x00120494
		public virtual int ActorIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ActorIndex;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ActorIndex;
			}
			set
			{
				this.GetOrCreatePoco().ActorIndex = value;
			}
		}

		// Token: 0x1700289D RID: 10397
		// (get) Token: 0x06007924 RID: 31012 RVA: 0x001222A2 File Offset: 0x001204A2
		// (set) Token: 0x06007925 RID: 31013 RVA: 0x001222CD File Offset: 0x001204CD
		public virtual int Talker
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Talker;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Talker;
			}
			set
			{
				this.GetOrCreatePoco().Talker = value;
			}
		}

		// Token: 0x04004655 RID: 18005
		[Nullable(2)]
		protected new ChangeActorTalker FbInstance;

		// Token: 0x04004656 RID: 18006
		[Nullable(2)]
		protected ChangeActorTalker_SetValue PocoInterface;
	}
}
