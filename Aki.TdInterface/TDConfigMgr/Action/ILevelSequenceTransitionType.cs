using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D25 RID: 7461
	public class ILevelSequenceTransitionType
	{
		// Token: 0x06009E73 RID: 40563 RVA: 0x0016C6E4 File Offset: 0x0016A8E4
		private ILevelSequenceTransitionType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILevelSequenceTransitionType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILevelSequenceTransitionType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILevelSequenceTransitionType_SetValue());
			}
			return result;
		}

		// Token: 0x06009E74 RID: 40564 RVA: 0x0016C71C File Offset: 0x0016A91C
		public static ILevelSequenceTransitionType Create([Nullable(2)] ILevelSequenceTransitionType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILevelSequenceTransitionType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009E75 RID: 40565 RVA: 0x0016C72F File Offset: 0x0016A92F
		public static ILevelSequenceTransitionType CreateFromSetValue([Nullable(2)] ILevelSequenceTransitionType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILevelSequenceTransitionType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009E76 RID: 40566 RVA: 0x0016C742 File Offset: 0x0016A942
		public ILevelSequenceTransitionType_SetValue ToSetValue()
		{
			return new ILevelSequenceTransitionType_SetValue
			{
				Type = this.Type,
				Duration = this.Duration
			};
		}

		// Token: 0x17003190 RID: 12688
		// (get) Token: 0x06009E77 RID: 40567 RVA: 0x0016C761 File Offset: 0x0016A961
		// (set) Token: 0x06009E78 RID: 40568 RVA: 0x0016C78C File Offset: 0x0016A98C
		public virtual ELevelSequenceTransition Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELevelSequenceTransition.Camera;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003191 RID: 12689
		// (get) Token: 0x06009E79 RID: 40569 RVA: 0x0016C79C File Offset: 0x0016A99C
		// (set) Token: 0x06009E7A RID: 40570 RVA: 0x0016C7D6 File Offset: 0x0016A9D6
		public virtual float? Duration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Duration;
				}
				ILevelSequenceTransitionType_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Duration;
			}
			set
			{
				this.GetOrCreatePoco().Duration = value;
			}
		}

		// Token: 0x040060A1 RID: 24737
		[Nullable(2)]
		protected ILevelSequenceTransitionType FbInstance;

		// Token: 0x040060A2 RID: 24738
		[Nullable(2)]
		protected ILevelSequenceTransitionType_SetValue PocoInterface;
	}
}
