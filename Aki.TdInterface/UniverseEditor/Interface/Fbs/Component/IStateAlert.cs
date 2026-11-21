using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FA8 RID: 24488
	public struct IStateAlert : IFlatbufferObject
	{
		// Token: 0x1700B557 RID: 46423
		// (get) Token: 0x060292FE RID: 168702 RVA: 0x0059F7DC File Offset: 0x0059D9DC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060292FF RID: 168703 RVA: 0x0059F7E9 File Offset: 0x0059D9E9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029300 RID: 168704 RVA: 0x0059F7F0 File Offset: 0x0059D9F0
		public static IStateAlert GetRootAsIStateAlert(ByteBuffer _bb)
		{
			return IStateAlert.GetRootAsIStateAlert(_bb, default(IStateAlert));
		}

		// Token: 0x06029301 RID: 168705 RVA: 0x0059F80C File Offset: 0x0059DA0C
		public static IStateAlert GetRootAsIStateAlert(ByteBuffer _bb, IStateAlert obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029302 RID: 168706 RVA: 0x0059F829 File Offset: 0x0059DA29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029303 RID: 168707 RVA: 0x0059F838 File Offset: 0x0059DA38
		public IStateAlert __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B558 RID: 46424
		// (get) Token: 0x06029304 RID: 168708 RVA: 0x0059F848 File Offset: 0x0059DA48
		public string State
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029305 RID: 168709 RVA: 0x0059F87F File Offset: 0x0059DA7F
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06029306 RID: 168710 RVA: 0x0059F88E File Offset: 0x0059DA8E
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700B559 RID: 46425
		// (get) Token: 0x06029307 RID: 168711 RVA: 0x0059F89C File Offset: 0x0059DA9C
		public int Alert
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029308 RID: 168712 RVA: 0x0059F8D8 File Offset: 0x0059DAD8
		public static Offset<IStateAlert> CreateIStateAlert(FlatBufferBuilder builder, StringOffset StateOffset = default(StringOffset), int Alert = 0)
		{
			builder.StartTable(2);
			IStateAlert.AddAlert(builder, Alert);
			IStateAlert.AddState(builder, StateOffset);
			return IStateAlert.EndIStateAlert(builder);
		}

		// Token: 0x06029309 RID: 168713 RVA: 0x0059F8F5 File Offset: 0x0059DAF5
		public static void StartIStateAlert(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602930A RID: 168714 RVA: 0x0059F8FE File Offset: 0x0059DAFE
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(0, stateOffset.Value, 0);
		}

		// Token: 0x0602930B RID: 168715 RVA: 0x0059F90E File Offset: 0x0059DB0E
		public static void AddAlert(FlatBufferBuilder builder, int alert)
		{
			builder.AddInt(1, alert, 0);
		}

		// Token: 0x0602930C RID: 168716 RVA: 0x0059F919 File Offset: 0x0059DB19
		public static Offset<IStateAlert> EndIStateAlert(FlatBufferBuilder builder)
		{
			return new Offset<IStateAlert>(builder.EndTable());
		}

		// Token: 0x0602930D RID: 168717 RVA: 0x0059F928 File Offset: 0x0059DB28
		public IStateAlertT UnPack()
		{
			IStateAlertT stateAlertT = new IStateAlertT();
			this.UnPackTo(stateAlertT);
			return stateAlertT;
		}

		// Token: 0x0602930E RID: 168718 RVA: 0x0059F943 File Offset: 0x0059DB43
		public void UnPackTo(IStateAlertT _o)
		{
			_o.State = this.State;
			_o.Alert = this.Alert;
		}

		// Token: 0x0602930F RID: 168719 RVA: 0x0059F960 File Offset: 0x0059DB60
		public static Offset<IStateAlert> Pack(FlatBufferBuilder builder, IStateAlertT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStateAlert>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IStateAlert.CreateIStateAlert(builder, stateOffset, _o.Alert);
		}

		// Token: 0x0400FC9A RID: 64666
		private Table __p;
	}
}
