using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018AC RID: 6316
	[NullableContext(1)]
	[Nullable(0)]
	public class IClientEventPianoSwitchPhase : IClientEventPianoEvent
	{
		// Token: 0x06008793 RID: 34707 RVA: 0x001414D4 File Offset: 0x0013F6D4
		private IClientEventPianoSwitchPhase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IClientEventPianoSwitchPhase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IClientEventPianoSwitchPhase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IClientEventPianoSwitchPhase_SetValue());
			}
			return result;
		}

		// Token: 0x06008794 RID: 34708 RVA: 0x0014150C File Offset: 0x0013F70C
		public static IClientEventPianoSwitchPhase Create([Nullable(2)] IClientEventPianoSwitchPhase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientEventPianoSwitchPhase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008795 RID: 34709 RVA: 0x0014151F File Offset: 0x0013F71F
		public static IClientEventPianoSwitchPhase CreateFromSetValue([Nullable(2)] IClientEventPianoSwitchPhase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IClientEventPianoSwitchPhase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008796 RID: 34710 RVA: 0x00141532 File Offset: 0x0013F732
		public new IClientEventPianoSwitchPhase_SetValue ToSetValue()
		{
			return new IClientEventPianoSwitchPhase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002C1C RID: 11292
		// (get) Token: 0x06008797 RID: 34711 RVA: 0x00141545 File Offset: 0x0013F745
		// (set) Token: 0x06008798 RID: 34712 RVA: 0x00141570 File Offset: 0x0013F770
		public override EClientEventPianoEventType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EClientEventPianoEventType.UpdateSubtitle;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400554D RID: 21837
		[Nullable(2)]
		protected new IClientEventPianoSwitchPhase FbInstance;

		// Token: 0x0400554E RID: 21838
		[Nullable(2)]
		protected new IClientEventPianoSwitchPhase_SetValue PocoInterface;
	}
}
