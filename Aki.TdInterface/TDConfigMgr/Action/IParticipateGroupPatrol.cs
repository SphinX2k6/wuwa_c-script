using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CC0 RID: 7360
	[NullableContext(1)]
	[Nullable(0)]
	public class IParticipateGroupPatrol : ILeisureInteractType
	{
		// Token: 0x06009E01 RID: 40449 RVA: 0x00169940 File Offset: 0x00167B40
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

		// Token: 0x06009E02 RID: 40450 RVA: 0x00169978 File Offset: 0x00167B78
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

		// Token: 0x06009E03 RID: 40451 RVA: 0x0016998B File Offset: 0x00167B8B
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

		// Token: 0x06009E04 RID: 40452 RVA: 0x0016999E File Offset: 0x00167B9E
		public new IParticipateGroupPatrol_SetValue ToSetValue()
		{
			return new IParticipateGroupPatrol_SetValue
			{
				Type = this.Type,
				GroupAiEntityId = this.GroupAiEntityId
			};
		}

		// Token: 0x17003137 RID: 12599
		// (get) Token: 0x06009E05 RID: 40453 RVA: 0x001699BD File Offset: 0x00167BBD
		// (set) Token: 0x06009E06 RID: 40454 RVA: 0x001699E8 File Offset: 0x00167BE8
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

		// Token: 0x17003138 RID: 12600
		// (get) Token: 0x06009E07 RID: 40455 RVA: 0x001699F6 File Offset: 0x00167BF6
		// (set) Token: 0x06009E08 RID: 40456 RVA: 0x00169A21 File Offset: 0x00167C21
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

		// Token: 0x04005F90 RID: 24464
		[Nullable(2)]
		protected new IParticipateGroupPatrol FbInstance;

		// Token: 0x04005F91 RID: 24465
		[Nullable(2)]
		protected new IParticipateGroupPatrol_SetValue PocoInterface;
	}
}
