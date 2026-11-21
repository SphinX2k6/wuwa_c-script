using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200161F RID: 5663
	public class ChangeActorTalker : ActionParams
	{
		// Token: 0x06007FEB RID: 32747 RVA: 0x00130E38 File Offset: 0x0012F038
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

		// Token: 0x06007FEC RID: 32748 RVA: 0x00130E70 File Offset: 0x0012F070
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

		// Token: 0x06007FED RID: 32749 RVA: 0x00130E83 File Offset: 0x0012F083
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

		// Token: 0x06007FEE RID: 32750 RVA: 0x00130E96 File Offset: 0x0012F096
		public ChangeActorTalker_SetValue ToSetValue()
		{
			return new ChangeActorTalker_SetValue
			{
				ActorIndex = this.ActorIndex,
				Talker = this.Talker
			};
		}

		// Token: 0x17002A86 RID: 10886
		// (get) Token: 0x06007FEF RID: 32751 RVA: 0x00130EB5 File Offset: 0x0012F0B5
		// (set) Token: 0x06007FF0 RID: 32752 RVA: 0x00130EE0 File Offset: 0x0012F0E0
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

		// Token: 0x17002A87 RID: 10887
		// (get) Token: 0x06007FF1 RID: 32753 RVA: 0x00130EEE File Offset: 0x0012F0EE
		// (set) Token: 0x06007FF2 RID: 32754 RVA: 0x00130F19 File Offset: 0x0012F119
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

		// Token: 0x040049F0 RID: 18928
		[Nullable(2)]
		protected new ChangeActorTalker FbInstance;

		// Token: 0x040049F1 RID: 18929
		[Nullable(2)]
		protected ChangeActorTalker_SetValue PocoInterface;
	}
}
