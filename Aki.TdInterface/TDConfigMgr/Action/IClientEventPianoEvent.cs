using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A35 RID: 6709
	public class IClientEventPianoEvent
	{
		// Token: 0x06008EB3 RID: 36531 RVA: 0x00150C4C File Offset: 0x0014EE4C
		private IClientEventPianoEvent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IClientEventPianoEvent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IClientEventPianoEvent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IClientEventPianoEvent_SetValue());
			}
			return result;
		}

		// Token: 0x06008EB4 RID: 36532 RVA: 0x00150C84 File Offset: 0x0014EE84
		public static IClientEventPianoEvent Create([Nullable(2)] IClientEventPianoEvent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientEventPianoEvent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008EB5 RID: 36533 RVA: 0x00150C97 File Offset: 0x0014EE97
		public static IClientEventPianoEvent CreateFromSetValue([Nullable(2)] IClientEventPianoEvent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IClientEventPianoEvent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008EB6 RID: 36534 RVA: 0x00150CAA File Offset: 0x0014EEAA
		public IClientEventPianoEvent_SetValue ToSetValue()
		{
			return new IClientEventPianoEvent_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002E16 RID: 11798
		// (get) Token: 0x06008EB7 RID: 36535 RVA: 0x00150CBD File Offset: 0x0014EEBD
		// (set) Token: 0x06008EB8 RID: 36536 RVA: 0x00150CE8 File Offset: 0x0014EEE8
		public virtual EClientEventPianoEventType Type
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

		// Token: 0x04005997 RID: 22935
		[Nullable(2)]
		protected IClientEventPianoEvent FbInstance;

		// Token: 0x04005998 RID: 22936
		[Nullable(2)]
		protected IClientEventPianoEvent_SetValue PocoInterface;
	}
}
