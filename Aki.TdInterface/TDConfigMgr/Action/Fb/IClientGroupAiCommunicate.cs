using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026F8 RID: 9976
	[NullableContext(1)]
	[Nullable(0)]
	public class IClientGroupAiCommunicate : IExecClientBattleActionType
	{
		// Token: 0x0600DEBA RID: 57018 RVA: 0x00210928 File Offset: 0x0020EB28
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

		// Token: 0x1700428C RID: 17036
		// (get) Token: 0x0600DEBB RID: 57019 RVA: 0x00210947 File Offset: 0x0020EB47
		public override EExecClientBattleActionType Type
		{
			get
			{
				return (EExecClientBattleActionType)this.Instance.Type;
			}
		}

		// Token: 0x1700428D RID: 17037
		// (get) Token: 0x0600DEBC RID: 57020 RVA: 0x00210954 File Offset: 0x0020EB54
		public virtual int GroupEntityId
		{
			get
			{
				return this.Instance.GroupEntityId;
			}
		}

		// Token: 0x1700428E RID: 17038
		// (get) Token: 0x0600DEBD RID: 57021 RVA: 0x00210961 File Offset: 0x0020EB61
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

		// Token: 0x04007BA0 RID: 31648
		private IClientGroupAiCommunicate Instance;

		// Token: 0x04007BA1 RID: 31649
		private IGroupAiCommunicateMode _OptionCache;

		// Token: 0x04007BA2 RID: 31650
		private bool _OptionInited;
	}
}
