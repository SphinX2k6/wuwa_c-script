using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001758 RID: 5976
	[NullableContext(1)]
	[Nullable(0)]
	public class IActionFunctionalConfigItem
	{
		// Token: 0x06007E81 RID: 32385 RVA: 0x0012EEB8 File Offset: 0x0012D0B8
		private IActionFunctionalConfigItem_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActionFunctionalConfigItem 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActionFunctionalConfigItem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActionFunctionalConfigItem_SetValue());
			}
			return result;
		}

		// Token: 0x06007E82 RID: 32386 RVA: 0x0012EEF0 File Offset: 0x0012D0F0
		public static IActionFunctionalConfigItem Create([Nullable(2)] IActionFunctionalConfigItem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActionFunctionalConfigItem
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007E83 RID: 32387 RVA: 0x0012EF03 File Offset: 0x0012D103
		public static IActionFunctionalConfigItem CreateFromSetValue([Nullable(2)] IActionFunctionalConfigItem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActionFunctionalConfigItem
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007E84 RID: 32388 RVA: 0x0012EF16 File Offset: 0x0012D116
		public IActionFunctionalConfigItem_SetValue ToSetValue()
		{
			return new IActionFunctionalConfigItem_SetValue
			{
				OnlineParticipateRule = this.OnlineParticipateRule,
				IsDetectScreenOccupation = this.IsDetectScreenOccupation,
				IsWithResultOnly = this.IsWithResultOnly,
				IsOperatePlayer = this.IsOperatePlayer
			};
		}

		// Token: 0x17002991 RID: 10641
		// (get) Token: 0x06007E85 RID: 32389 RVA: 0x0012EF50 File Offset: 0x0012D150
		// (set) Token: 0x06007E86 RID: 32390 RVA: 0x0012EF8A File Offset: 0x0012D18A
		public virtual EOnlineParticipateRule? OnlineParticipateRule
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.OnlineParticipateRule;
				}
				IActionFunctionalConfigItem_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.OnlineParticipateRule;
			}
			set
			{
				this.GetOrCreatePoco().OnlineParticipateRule = value;
			}
		}

		// Token: 0x17002992 RID: 10642
		// (get) Token: 0x06007E87 RID: 32391 RVA: 0x0012EF98 File Offset: 0x0012D198
		// (set) Token: 0x06007E88 RID: 32392 RVA: 0x0012EFD2 File Offset: 0x0012D1D2
		public virtual bool? IsDetectScreenOccupation
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsDetectScreenOccupation;
				}
				IActionFunctionalConfigItem_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsDetectScreenOccupation;
			}
			set
			{
				this.GetOrCreatePoco().IsDetectScreenOccupation = value;
			}
		}

		// Token: 0x17002993 RID: 10643
		// (get) Token: 0x06007E89 RID: 32393 RVA: 0x0012EFE0 File Offset: 0x0012D1E0
		// (set) Token: 0x06007E8A RID: 32394 RVA: 0x0012F01A File Offset: 0x0012D21A
		public virtual bool? IsWithResultOnly
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsWithResultOnly;
				}
				IActionFunctionalConfigItem_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsWithResultOnly;
			}
			set
			{
				this.GetOrCreatePoco().IsWithResultOnly = value;
			}
		}

		// Token: 0x17002994 RID: 10644
		// (get) Token: 0x06007E8B RID: 32395 RVA: 0x0012F028 File Offset: 0x0012D228
		// (set) Token: 0x06007E8C RID: 32396 RVA: 0x0012F062 File Offset: 0x0012D262
		public virtual bool? IsOperatePlayer
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsOperatePlayer;
				}
				IActionFunctionalConfigItem_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsOperatePlayer;
			}
			set
			{
				this.GetOrCreatePoco().IsOperatePlayer = value;
			}
		}

		// Token: 0x04005090 RID: 20624
		[Nullable(2)]
		protected IActionFunctionalConfigItem FbInstance;

		// Token: 0x04005091 RID: 20625
		[Nullable(2)]
		protected IActionFunctionalConfigItem_SetValue PocoInterface;
	}
}
