using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A53 RID: 6739
	public class IClientModifySelfTarget : IClientModifyTarget
	{
		// Token: 0x06008F41 RID: 36673 RVA: 0x00151AB4 File Offset: 0x0014FCB4
		private IClientModifySelfTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IClientModifySelfTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IClientModifySelfTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IClientModifySelfTarget_SetValue());
			}
			return result;
		}

		// Token: 0x06008F42 RID: 36674 RVA: 0x00151AEC File Offset: 0x0014FCEC
		public static IClientModifySelfTarget Create([Nullable(2)] IClientModifySelfTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientModifySelfTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008F43 RID: 36675 RVA: 0x00151AFF File Offset: 0x0014FCFF
		public static IClientModifySelfTarget CreateFromSetValue([Nullable(2)] IClientModifySelfTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IClientModifySelfTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008F44 RID: 36676 RVA: 0x00151B12 File Offset: 0x0014FD12
		public new IClientModifySelfTarget_SetValue ToSetValue()
		{
			return new IClientModifySelfTarget_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002E30 RID: 11824
		// (get) Token: 0x06008F45 RID: 36677 RVA: 0x00151B25 File Offset: 0x0014FD25
		// (set) Token: 0x06008F46 RID: 36678 RVA: 0x00151B50 File Offset: 0x0014FD50
		public override EClientModifyTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EClientModifyTargetType.Self;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040059D3 RID: 22995
		[Nullable(2)]
		protected new IClientModifySelfTarget FbInstance;

		// Token: 0x040059D4 RID: 22996
		[Nullable(2)]
		protected new IClientModifySelfTarget_SetValue PocoInterface;
	}
}
