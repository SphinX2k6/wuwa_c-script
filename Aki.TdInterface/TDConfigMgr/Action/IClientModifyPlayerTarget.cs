using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A51 RID: 6737
	public class IClientModifyPlayerTarget : IClientModifyTarget
	{
		// Token: 0x06008F39 RID: 36665 RVA: 0x001519F8 File Offset: 0x0014FBF8
		private IClientModifyPlayerTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IClientModifyPlayerTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IClientModifyPlayerTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IClientModifyPlayerTarget_SetValue());
			}
			return result;
		}

		// Token: 0x06008F3A RID: 36666 RVA: 0x00151A30 File Offset: 0x0014FC30
		public static IClientModifyPlayerTarget Create([Nullable(2)] IClientModifyPlayerTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientModifyPlayerTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008F3B RID: 36667 RVA: 0x00151A43 File Offset: 0x0014FC43
		public static IClientModifyPlayerTarget CreateFromSetValue([Nullable(2)] IClientModifyPlayerTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IClientModifyPlayerTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008F3C RID: 36668 RVA: 0x00151A56 File Offset: 0x0014FC56
		public new IClientModifyPlayerTarget_SetValue ToSetValue()
		{
			return new IClientModifyPlayerTarget_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002E2F RID: 11823
		// (get) Token: 0x06008F3D RID: 36669 RVA: 0x00151A69 File Offset: 0x0014FC69
		// (set) Token: 0x06008F3E RID: 36670 RVA: 0x00151A94 File Offset: 0x0014FC94
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

		// Token: 0x040059D0 RID: 22992
		[Nullable(2)]
		protected new IClientModifyPlayerTarget FbInstance;

		// Token: 0x040059D1 RID: 22993
		[Nullable(2)]
		protected new IClientModifyPlayerTarget_SetValue PocoInterface;
	}
}
