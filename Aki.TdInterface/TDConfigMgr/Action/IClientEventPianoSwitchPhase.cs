using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A37 RID: 6711
	public class IClientEventPianoSwitchPhase : IClientEventPianoEvent
	{
		// Token: 0x06008EBB RID: 36539 RVA: 0x00150D08 File Offset: 0x0014EF08
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

		// Token: 0x06008EBC RID: 36540 RVA: 0x00150D40 File Offset: 0x0014EF40
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

		// Token: 0x06008EBD RID: 36541 RVA: 0x00150D53 File Offset: 0x0014EF53
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

		// Token: 0x06008EBE RID: 36542 RVA: 0x00150D66 File Offset: 0x0014EF66
		public new IClientEventPianoSwitchPhase_SetValue ToSetValue()
		{
			return new IClientEventPianoSwitchPhase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002E17 RID: 11799
		// (get) Token: 0x06008EBF RID: 36543 RVA: 0x00150D79 File Offset: 0x0014EF79
		// (set) Token: 0x06008EC0 RID: 36544 RVA: 0x00150DA4 File Offset: 0x0014EFA4
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

		// Token: 0x0400599A RID: 22938
		[Nullable(2)]
		protected new IClientEventPianoSwitchPhase FbInstance;

		// Token: 0x0400599B RID: 22939
		[Nullable(2)]
		protected new IClientEventPianoSwitchPhase_SetValue PocoInterface;
	}
}
