using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029BE RID: 10686
	public class IClientGroupAiCommunicate : IExecClientBattleActionType
	{
		// Token: 0x0600ECA2 RID: 60578 RVA: 0x0022D290 File Offset: 0x0022B490
		public static IClientGroupAiCommunicate Create(IClientGroupAiCommunicate? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientGroupAiCommunicate
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045D4 RID: 17876
		// (get) Token: 0x0600ECA3 RID: 60579 RVA: 0x0022D2AF File Offset: 0x0022B4AF
		public override EExecClientBattleActionType Type
		{
			get
			{
				return (EExecClientBattleActionType)this.Instance.Type;
			}
		}

		// Token: 0x170045D5 RID: 17877
		// (get) Token: 0x0600ECA4 RID: 60580 RVA: 0x0022D2BC File Offset: 0x0022B4BC
		public virtual int GroupEntityId
		{
			get
			{
				return this.Instance.GroupEntityId;
			}
		}

		// Token: 0x170045D6 RID: 17878
		// (get) Token: 0x0600ECA5 RID: 60581 RVA: 0x0022D2C9 File Offset: 0x0022B4C9
		public virtual IGroupAiCommunicateMode Option
		{
			get
			{
				if (this._OptionInited)
				{
					return this._OptionCache;
				}
				this._OptionInited = true;
				this._OptionCache = ActionReadHelper.ReadIClientGroupAiCommunicate_Option(this.Instance);
				return this._OptionCache;
			}
		}

		// Token: 0x04008244 RID: 33348
		private IClientGroupAiCommunicate Instance;

		// Token: 0x04008245 RID: 33349
		private IGroupAiCommunicateMode _OptionCache;

		// Token: 0x04008246 RID: 33350
		private bool _OptionInited;
	}
}
