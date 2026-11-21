using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EC7 RID: 7879
	public class IParticipateGroupPatrol : ILeisureInteractType
	{
		// Token: 0x0600A7AF RID: 42927 RVA: 0x0017D5A0 File Offset: 0x0017B7A0
		private IParticipateGroupPatrol_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IParticipateGroupPatrol 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IParticipateGroupPatrol_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IParticipateGroupPatrol_SetValue());
			}
			return result;
		}

		// Token: 0x0600A7B0 RID: 42928 RVA: 0x0017D5D8 File Offset: 0x0017B7D8
		public static IParticipateGroupPatrol Create([Nullable(2)] IParticipateGroupPatrol instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IParticipateGroupPatrol
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A7B1 RID: 42929 RVA: 0x0017D5EB File Offset: 0x0017B7EB
		public static IParticipateGroupPatrol CreateFromSetValue([Nullable(2)] IParticipateGroupPatrol_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IParticipateGroupPatrol
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A7B2 RID: 42930 RVA: 0x0017D5FE File Offset: 0x0017B7FE
		public new IParticipateGroupPatrol_SetValue ToSetValue()
		{
			return new IParticipateGroupPatrol_SetValue
			{
				Type = this.Type,
				GroupAiEntityId = this.GroupAiEntityId
			};
		}

		// Token: 0x170033BB RID: 13243
		// (get) Token: 0x0600A7B3 RID: 42931 RVA: 0x0017D61D File Offset: 0x0017B81D
		// (set) Token: 0x0600A7B4 RID: 42932 RVA: 0x0017D648 File Offset: 0x0017B848
		public override ELeisureInteract Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELeisureInteract.CustomSkill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170033BC RID: 13244
		// (get) Token: 0x0600A7B5 RID: 42933 RVA: 0x0017D656 File Offset: 0x0017B856
		// (set) Token: 0x0600A7B6 RID: 42934 RVA: 0x0017D681 File Offset: 0x0017B881
		public virtual int GroupAiEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GroupAiEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.GroupAiEntityId;
			}
			set
			{
				this.GetOrCreatePoco().GroupAiEntityId = value;
			}
		}

		// Token: 0x040064EC RID: 25836
		[Nullable(2)]
		protected new IParticipateGroupPatrol FbInstance;

		// Token: 0x040064ED RID: 25837
		[Nullable(2)]
		protected new IParticipateGroupPatrol_SetValue PocoInterface;
	}
}
