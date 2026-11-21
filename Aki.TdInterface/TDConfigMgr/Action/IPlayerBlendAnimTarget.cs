using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F0F RID: 7951
	public class IPlayerBlendAnimTarget : IBlendAnimTargetBase
	{
		// Token: 0x0600A93F RID: 43327 RVA: 0x001804B0 File Offset: 0x0017E6B0
		private IPlayerBlendAnimTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPlayerBlendAnimTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPlayerBlendAnimTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPlayerBlendAnimTarget_SetValue());
			}
			return result;
		}

		// Token: 0x0600A940 RID: 43328 RVA: 0x001804E8 File Offset: 0x0017E6E8
		public static IPlayerBlendAnimTarget Create([Nullable(2)] IPlayerBlendAnimTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayerBlendAnimTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A941 RID: 43329 RVA: 0x001804FB File Offset: 0x0017E6FB
		public static IPlayerBlendAnimTarget CreateFromSetValue([Nullable(2)] IPlayerBlendAnimTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPlayerBlendAnimTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A942 RID: 43330 RVA: 0x0018050E File Offset: 0x0017E70E
		public new IPlayerBlendAnimTarget_SetValue ToSetValue()
		{
			return new IPlayerBlendAnimTarget_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003417 RID: 13335
		// (get) Token: 0x0600A943 RID: 43331 RVA: 0x00180521 File Offset: 0x0017E721
		// (set) Token: 0x0600A944 RID: 43332 RVA: 0x0018054C File Offset: 0x0017E74C
		public override EBlendAnimTarget Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EBlendAnimTarget.Player;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040065AA RID: 26026
		[Nullable(2)]
		protected new IPlayerBlendAnimTarget FbInstance;

		// Token: 0x040065AB RID: 26027
		[Nullable(2)]
		protected new IPlayerBlendAnimTarget_SetValue PocoInterface;
	}
}
