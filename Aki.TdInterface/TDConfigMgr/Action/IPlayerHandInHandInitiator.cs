using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D02 RID: 7426
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlayerHandInHandInitiator : IHandInHandInitiatorType
	{
		// Token: 0x06009F67 RID: 40807 RVA: 0x0016C2DC File Offset: 0x0016A4DC
		private IPlayerHandInHandInitiator_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPlayerHandInHandInitiator 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPlayerHandInHandInitiator_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPlayerHandInHandInitiator_SetValue());
			}
			return result;
		}

		// Token: 0x06009F68 RID: 40808 RVA: 0x0016C314 File Offset: 0x0016A514
		public static IPlayerHandInHandInitiator Create([Nullable(2)] IPlayerHandInHandInitiator instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayerHandInHandInitiator
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009F69 RID: 40809 RVA: 0x0016C327 File Offset: 0x0016A527
		public static IPlayerHandInHandInitiator CreateFromSetValue([Nullable(2)] IPlayerHandInHandInitiator_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPlayerHandInHandInitiator
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009F6A RID: 40810 RVA: 0x0016C33A File Offset: 0x0016A53A
		public new IPlayerHandInHandInitiator_SetValue ToSetValue()
		{
			return new IPlayerHandInHandInitiator_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003187 RID: 12679
		// (get) Token: 0x06009F6B RID: 40811 RVA: 0x0016C34D File Offset: 0x0016A54D
		// (set) Token: 0x06009F6C RID: 40812 RVA: 0x0016C378 File Offset: 0x0016A578
		public override EHandInHandInitiatorType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHandInHandInitiatorType.Player;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006038 RID: 24632
		[Nullable(2)]
		protected new IPlayerHandInHandInitiator FbInstance;

		// Token: 0x04006039 RID: 24633
		[Nullable(2)]
		protected new IPlayerHandInHandInitiator_SetValue PocoInterface;
	}
}
