using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020A8 RID: 8360
	public class ISitDown : ILeisureInteractType
	{
		// Token: 0x0600B190 RID: 45456 RVA: 0x0018F420 File Offset: 0x0018D620
		private ISitDown_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISitDown 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISitDown_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISitDown_SetValue());
			}
			return result;
		}

		// Token: 0x0600B191 RID: 45457 RVA: 0x0018F458 File Offset: 0x0018D658
		public static ISitDown Create([Nullable(2)] ISitDown instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISitDown
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B192 RID: 45458 RVA: 0x0018F46B File Offset: 0x0018D66B
		public static ISitDown CreateFromSetValue([Nullable(2)] ISitDown_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISitDown
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B193 RID: 45459 RVA: 0x0018F47E File Offset: 0x0018D67E
		public new ISitDown_SetValue ToSetValue()
		{
			return new ISitDown_SetValue
			{
				Type = this.Type,
				OnlyAllowForwardStandUp = this.OnlyAllowForwardStandUp
			};
		}

		// Token: 0x170035DB RID: 13787
		// (get) Token: 0x0600B194 RID: 45460 RVA: 0x0018F49D File Offset: 0x0018D69D
		// (set) Token: 0x0600B195 RID: 45461 RVA: 0x0018F4C8 File Offset: 0x0018D6C8
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

		// Token: 0x170035DC RID: 13788
		// (get) Token: 0x0600B196 RID: 45462 RVA: 0x0018F4D8 File Offset: 0x0018D6D8
		// (set) Token: 0x0600B197 RID: 45463 RVA: 0x0018F512 File Offset: 0x0018D712
		public virtual bool? OnlyAllowForwardStandUp
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.OnlyAllowForwardStandUp;
				}
				ISitDown_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.OnlyAllowForwardStandUp;
			}
			set
			{
				this.GetOrCreatePoco().OnlyAllowForwardStandUp = value;
			}
		}

		// Token: 0x04006984 RID: 27012
		[Nullable(2)]
		protected new ISitDown FbInstance;

		// Token: 0x04006985 RID: 27013
		[Nullable(2)]
		protected new ISitDown_SetValue PocoInterface;
	}
}
