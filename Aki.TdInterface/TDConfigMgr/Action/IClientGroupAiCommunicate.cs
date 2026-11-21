using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A4D RID: 6733
	public class IClientGroupAiCommunicate : IExecClientBattleActionType
	{
		// Token: 0x06008F1F RID: 36639 RVA: 0x00151730 File Offset: 0x0014F930
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

		// Token: 0x06008F20 RID: 36640 RVA: 0x00151768 File Offset: 0x0014F968
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

		// Token: 0x06008F21 RID: 36641 RVA: 0x0015177B File Offset: 0x0014F97B
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

		// Token: 0x06008F22 RID: 36642 RVA: 0x0015178E File Offset: 0x0014F98E
		public new IClientGroupAiCommunicate_SetValue ToSetValue()
		{
			return new IClientGroupAiCommunicate_SetValue
			{
				Type = this.Type,
				GroupEntityId = this.GroupEntityId,
				Option = this.Option
			};
		}

		// Token: 0x17002E28 RID: 11816
		// (get) Token: 0x06008F23 RID: 36643 RVA: 0x001517B9 File Offset: 0x0014F9B9
		// (set) Token: 0x06008F24 RID: 36644 RVA: 0x001517E4 File Offset: 0x0014F9E4
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

		// Token: 0x17002E29 RID: 11817
		// (get) Token: 0x06008F25 RID: 36645 RVA: 0x001517F2 File Offset: 0x0014F9F2
		// (set) Token: 0x06008F26 RID: 36646 RVA: 0x0015181D File Offset: 0x0014FA1D
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

		// Token: 0x17002E2A RID: 11818
		// (get) Token: 0x06008F27 RID: 36647 RVA: 0x0015182B File Offset: 0x0014FA2B
		// (set) Token: 0x06008F28 RID: 36648 RVA: 0x00151852 File Offset: 0x0014FA52
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

		// Token: 0x040059C5 RID: 22981
		[Nullable(2)]
		protected new IClientGroupAiCommunicate FbInstance;

		// Token: 0x040059C6 RID: 22982
		[Nullable(2)]
		protected new IClientGroupAiCommunicate_SetValue PocoInterface;
	}
}
