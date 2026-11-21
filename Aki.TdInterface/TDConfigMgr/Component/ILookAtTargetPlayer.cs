using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200052D RID: 1325
	public class ILookAtTargetPlayer : ILookAtTargetBase
	{
		// Token: 0x06001AB0 RID: 6832 RVA: 0x0004E4D0 File Offset: 0x0004C6D0
		private ILookAtTargetPlayer_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILookAtTargetPlayer 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILookAtTargetPlayer_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILookAtTargetPlayer_SetValue());
			}
			return result;
		}

		// Token: 0x06001AB1 RID: 6833 RVA: 0x0004E508 File Offset: 0x0004C708
		public static ILookAtTargetPlayer Create([Nullable(2)] ILookAtTargetPlayer instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILookAtTargetPlayer
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001AB2 RID: 6834 RVA: 0x0004E51B File Offset: 0x0004C71B
		public static ILookAtTargetPlayer CreateFromSetValue([Nullable(2)] ILookAtTargetPlayer_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILookAtTargetPlayer
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001AB3 RID: 6835 RVA: 0x0004E52E File Offset: 0x0004C72E
		public new ILookAtTargetPlayer_SetValue ToSetValue()
		{
			return new ILookAtTargetPlayer_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x06001AB4 RID: 6836 RVA: 0x0004E541 File Offset: 0x0004C741
		// (set) Token: 0x06001AB5 RID: 6837 RVA: 0x0004E56C File Offset: 0x0004C76C
		public override ELookAtTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELookAtTargetType.Entity;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400139C RID: 5020
		[Nullable(2)]
		protected new ILookAtTargetPlayer FbInstance;

		// Token: 0x0400139D RID: 5021
		[Nullable(2)]
		protected new ILookAtTargetPlayer_SetValue PocoInterface;
	}
}
