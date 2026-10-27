using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CFE RID: 7422
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlayerBlendAnimTarget : IBlendAnimTargetBase
	{
		// Token: 0x06009F55 RID: 40789 RVA: 0x0016C110 File Offset: 0x0016A310
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

		// Token: 0x06009F56 RID: 40790 RVA: 0x0016C148 File Offset: 0x0016A348
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

		// Token: 0x06009F57 RID: 40791 RVA: 0x0016C15B File Offset: 0x0016A35B
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

		// Token: 0x06009F58 RID: 40792 RVA: 0x0016C16E File Offset: 0x0016A36E
		public new IPlayerBlendAnimTarget_SetValue ToSetValue()
		{
			return new IPlayerBlendAnimTarget_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003184 RID: 12676
		// (get) Token: 0x06009F59 RID: 40793 RVA: 0x0016C181 File Offset: 0x0016A381
		// (set) Token: 0x06009F5A RID: 40794 RVA: 0x0016C1AC File Offset: 0x0016A3AC
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

		// Token: 0x04006031 RID: 24625
		[Nullable(2)]
		protected new IPlayerBlendAnimTarget FbInstance;

		// Token: 0x04006032 RID: 24626
		[Nullable(2)]
		protected new IPlayerBlendAnimTarget_SetValue PocoInterface;
	}
}
