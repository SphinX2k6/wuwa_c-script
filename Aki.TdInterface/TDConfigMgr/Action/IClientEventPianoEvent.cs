using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018AA RID: 6314
	[NullableContext(1)]
	[Nullable(0)]
	public class IClientEventPianoEvent
	{
		// Token: 0x0600878B RID: 34699 RVA: 0x00141418 File Offset: 0x0013F618
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

		// Token: 0x0600878C RID: 34700 RVA: 0x00141450 File Offset: 0x0013F650
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

		// Token: 0x0600878D RID: 34701 RVA: 0x00141463 File Offset: 0x0013F663
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

		// Token: 0x0600878E RID: 34702 RVA: 0x00141476 File Offset: 0x0013F676
		public IClientEventPianoEvent_SetValue ToSetValue()
		{
			return new IClientEventPianoEvent_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002C1B RID: 11291
		// (get) Token: 0x0600878F RID: 34703 RVA: 0x00141489 File Offset: 0x0013F689
		// (set) Token: 0x06008790 RID: 34704 RVA: 0x001414B4 File Offset: 0x0013F6B4
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

		// Token: 0x0400554A RID: 21834
		[Nullable(2)]
		protected IClientEventPianoEvent FbInstance;

		// Token: 0x0400554B RID: 21835
		[Nullable(2)]
		protected IClientEventPianoEvent_SetValue PocoInterface;
	}
}
