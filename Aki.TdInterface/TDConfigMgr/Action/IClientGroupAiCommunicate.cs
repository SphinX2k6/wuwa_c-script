using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018BE RID: 6334
	[NullableContext(1)]
	[Nullable(0)]
	public class IClientGroupAiCommunicate : IExecClientBattleActionType
	{
		// Token: 0x060087E5 RID: 34789 RVA: 0x00141D40 File Offset: 0x0013FF40
		private IClientGroupAiCommunicate_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IClientGroupAiCommunicate 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IClientGroupAiCommunicate_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IClientGroupAiCommunicate_SetValue());
			}
			return result;
		}

		// Token: 0x060087E6 RID: 34790 RVA: 0x00141D78 File Offset: 0x0013FF78
		public static IClientGroupAiCommunicate Create([Nullable(2)] IClientGroupAiCommunicate instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientGroupAiCommunicate
			{
				FbInstance = instance
			};
		}

		// Token: 0x060087E7 RID: 34791 RVA: 0x00141D8B File Offset: 0x0013FF8B
		public static IClientGroupAiCommunicate CreateFromSetValue([Nullable(2)] IClientGroupAiCommunicate_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IClientGroupAiCommunicate
			{
				PocoInterface = value
			};
		}

		// Token: 0x060087E8 RID: 34792 RVA: 0x00141D9E File Offset: 0x0013FF9E
		public new IClientGroupAiCommunicate_SetValue ToSetValue()
		{
			return new IClientGroupAiCommunicate_SetValue
			{
				Type = this.Type,
				GroupEntityId = this.GroupEntityId,
				Option = this.Option
			};
		}

		// Token: 0x17002C2A RID: 11306
		// (get) Token: 0x060087E9 RID: 34793 RVA: 0x00141DC9 File Offset: 0x0013FFC9
		// (set) Token: 0x060087EA RID: 34794 RVA: 0x00141DF4 File Offset: 0x0013FFF4
		public override EExecClientBattleActionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EExecClientBattleActionType.SendTagEventToControlCharacter;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002C2B RID: 11307
		// (get) Token: 0x060087EB RID: 34795 RVA: 0x00141E02 File Offset: 0x00140002
		// (set) Token: 0x060087EC RID: 34796 RVA: 0x00141E2D File Offset: 0x0014002D
		public virtual int GroupEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GroupEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.GroupEntityId;
			}
			set
			{
				this.GetOrCreatePoco().GroupEntityId = value;
			}
		}

		// Token: 0x17002C2C RID: 11308
		// (get) Token: 0x060087ED RID: 34797 RVA: 0x00141E3B File Offset: 0x0014003B
		// (set) Token: 0x060087EE RID: 34798 RVA: 0x00141E62 File Offset: 0x00140062
		public virtual IGroupAiCommunicateMode Option
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Option;
				}
				IClientGroupAiCommunicate_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Option;
			}
			set
			{
				this.GetOrCreatePoco().Option = value;
			}
		}

		// Token: 0x04005571 RID: 21873
		[Nullable(2)]
		protected new IClientGroupAiCommunicate FbInstance;

		// Token: 0x04005572 RID: 21874
		[Nullable(2)]
		protected new IClientGroupAiCommunicate_SetValue PocoInterface;
	}
}
