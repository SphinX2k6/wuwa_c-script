using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002237 RID: 8759
	public class ITrapDefensePlayerOperationRecycleTrap : ITrapDefensePlayerOperationType
	{
		// Token: 0x0600BEF0 RID: 48880 RVA: 0x001B8D78 File Offset: 0x001B6F78
		private ITrapDefensePlayerOperationRecycleTrap_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITrapDefensePlayerOperationRecycleTrap 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITrapDefensePlayerOperationRecycleTrap_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITrapDefensePlayerOperationRecycleTrap_SetValue());
			}
			return result;
		}

		// Token: 0x0600BEF1 RID: 48881 RVA: 0x001B8DB0 File Offset: 0x001B6FB0
		public static ITrapDefensePlayerOperationRecycleTrap Create([Nullable(2)] ITrapDefensePlayerOperationRecycleTrap instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrapDefensePlayerOperationRecycleTrap
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BEF2 RID: 48882 RVA: 0x001B8DC3 File Offset: 0x001B6FC3
		public static ITrapDefensePlayerOperationRecycleTrap CreateFromSetValue([Nullable(2)] ITrapDefensePlayerOperationRecycleTrap_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITrapDefensePlayerOperationRecycleTrap
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BEF3 RID: 48883 RVA: 0x001B8DD6 File Offset: 0x001B6FD6
		public new ITrapDefensePlayerOperationRecycleTrap_SetValue ToSetValue()
		{
			return new ITrapDefensePlayerOperationRecycleTrap_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003A35 RID: 14901
		// (get) Token: 0x0600BEF4 RID: 48884 RVA: 0x001B8DE9 File Offset: 0x001B6FE9
		// (set) Token: 0x0600BEF5 RID: 48885 RVA: 0x001B8E14 File Offset: 0x001B7014
		public override ETrapDefensePlayerOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETrapDefensePlayerOperationType.SpawnMonster;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04007278 RID: 29304
		[Nullable(2)]
		protected new ITrapDefensePlayerOperationRecycleTrap FbInstance;

		// Token: 0x04007279 RID: 29305
		[Nullable(2)]
		protected new ITrapDefensePlayerOperationRecycleTrap_SetValue PocoInterface;
	}
}
