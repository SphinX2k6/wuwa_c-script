using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018B6 RID: 6326
	[NullableContext(1)]
	[Nullable(0)]
	public class IClientEventUiPlayPiano : IClientEventUi
	{
		// Token: 0x060087C1 RID: 34753 RVA: 0x001419CC File Offset: 0x0013FBCC
		private IClientEventUiPlayPiano_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IClientEventUiPlayPiano 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IClientEventUiPlayPiano_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IClientEventUiPlayPiano_SetValue());
			}
			return result;
		}

		// Token: 0x060087C2 RID: 34754 RVA: 0x00141A04 File Offset: 0x0013FC04
		public static IClientEventUiPlayPiano Create([Nullable(2)] IClientEventUiPlayPiano instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientEventUiPlayPiano
			{
				FbInstance = instance
			};
		}

		// Token: 0x060087C3 RID: 34755 RVA: 0x00141A17 File Offset: 0x0013FC17
		public static IClientEventUiPlayPiano CreateFromSetValue([Nullable(2)] IClientEventUiPlayPiano_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IClientEventUiPlayPiano
			{
				PocoInterface = value
			};
		}

		// Token: 0x060087C4 RID: 34756 RVA: 0x00141A2A File Offset: 0x0013FC2A
		public new IClientEventUiPlayPiano_SetValue ToSetValue()
		{
			return new IClientEventUiPlayPiano_SetValue
			{
				Type = this.Type,
				EventType = this.EventType
			};
		}

		// Token: 0x17002C24 RID: 11300
		// (get) Token: 0x060087C5 RID: 34757 RVA: 0x00141A49 File Offset: 0x0013FC49
		// (set) Token: 0x060087C6 RID: 34758 RVA: 0x00141A74 File Offset: 0x0013FC74
		public override EClientEventUiType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EClientEventUiType.PlayPiano;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002C25 RID: 11301
		// (get) Token: 0x060087C7 RID: 34759 RVA: 0x00141A82 File Offset: 0x0013FC82
		// (set) Token: 0x060087C8 RID: 34760 RVA: 0x00141AA9 File Offset: 0x0013FCA9
		public virtual IClientEventPianoEvent EventType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EventType;
				}
				IClientEventUiPlayPiano_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EventType;
			}
			set
			{
				this.GetOrCreatePoco().EventType = value;
			}
		}

		// Token: 0x04005563 RID: 21859
		[Nullable(2)]
		protected new IClientEventUiPlayPiano FbInstance;

		// Token: 0x04005564 RID: 21860
		[Nullable(2)]
		protected new IClientEventUiPlayPiano_SetValue PocoInterface;
	}
}
