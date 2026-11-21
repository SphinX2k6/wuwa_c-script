using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A41 RID: 6721
	public class IClientEventUiPlayPiano : IClientEventUi
	{
		// Token: 0x06008EE9 RID: 36585 RVA: 0x00151200 File Offset: 0x0014F400
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

		// Token: 0x06008EEA RID: 36586 RVA: 0x00151238 File Offset: 0x0014F438
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

		// Token: 0x06008EEB RID: 36587 RVA: 0x0015124B File Offset: 0x0014F44B
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

		// Token: 0x06008EEC RID: 36588 RVA: 0x0015125E File Offset: 0x0014F45E
		public new IClientEventUiPlayPiano_SetValue ToSetValue()
		{
			return new IClientEventUiPlayPiano_SetValue
			{
				Type = this.Type,
				EventType = this.EventType
			};
		}

		// Token: 0x17002E1F RID: 11807
		// (get) Token: 0x06008EED RID: 36589 RVA: 0x0015127D File Offset: 0x0014F47D
		// (set) Token: 0x06008EEE RID: 36590 RVA: 0x001512A8 File Offset: 0x0014F4A8
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

		// Token: 0x17002E20 RID: 11808
		// (get) Token: 0x06008EEF RID: 36591 RVA: 0x001512B6 File Offset: 0x0014F4B6
		// (set) Token: 0x06008EF0 RID: 36592 RVA: 0x001512DD File Offset: 0x0014F4DD
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

		// Token: 0x040059B0 RID: 22960
		[Nullable(2)]
		protected new IClientEventUiPlayPiano FbInstance;

		// Token: 0x040059B1 RID: 22961
		[Nullable(2)]
		protected new IClientEventUiPlayPiano_SetValue PocoInterface;
	}
}
