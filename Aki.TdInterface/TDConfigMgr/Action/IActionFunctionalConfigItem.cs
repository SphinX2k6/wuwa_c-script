using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018D9 RID: 6361
	public class IActionFunctionalConfigItem
	{
		// Token: 0x06008571 RID: 34161 RVA: 0x0013E118 File Offset: 0x0013C318
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

		// Token: 0x06008572 RID: 34162 RVA: 0x0013E150 File Offset: 0x0013C350
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

		// Token: 0x06008573 RID: 34163 RVA: 0x0013E163 File Offset: 0x0013C363
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

		// Token: 0x06008574 RID: 34164 RVA: 0x0013E176 File Offset: 0x0013C376
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

		// Token: 0x17002B7F RID: 11135
		// (get) Token: 0x06008575 RID: 34165 RVA: 0x0013E1B0 File Offset: 0x0013C3B0
		// (set) Token: 0x06008576 RID: 34166 RVA: 0x0013E1EA File Offset: 0x0013C3EA
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

		// Token: 0x17002B80 RID: 11136
		// (get) Token: 0x06008577 RID: 34167 RVA: 0x0013E1F8 File Offset: 0x0013C3F8
		// (set) Token: 0x06008578 RID: 34168 RVA: 0x0013E232 File Offset: 0x0013C432
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

		// Token: 0x17002B81 RID: 11137
		// (get) Token: 0x06008579 RID: 34169 RVA: 0x0013E240 File Offset: 0x0013C440
		// (set) Token: 0x0600857A RID: 34170 RVA: 0x0013E27A File Offset: 0x0013C47A
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

		// Token: 0x17002B82 RID: 11138
		// (get) Token: 0x0600857B RID: 34171 RVA: 0x0013E288 File Offset: 0x0013C488
		// (set) Token: 0x0600857C RID: 34172 RVA: 0x0013E2C2 File Offset: 0x0013C4C2
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

		// Token: 0x040054C6 RID: 21702
		[Nullable(2)]
		protected IActionFunctionalConfigItem FbInstance;

		// Token: 0x040054C7 RID: 21703
		[Nullable(2)]
		protected IActionFunctionalConfigItem_SetValue PocoInterface;
	}
}
