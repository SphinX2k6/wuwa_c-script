using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200599B RID: 22939
	public struct IStateAlert : IFlatbufferObject
	{
		// Token: 0x1700AC23 RID: 44067
		// (get) Token: 0x06026D94 RID: 159124 RVA: 0x00558B70 File Offset: 0x00556D70
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026D95 RID: 159125 RVA: 0x00558B7D File Offset: 0x00556D7D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026D96 RID: 159126 RVA: 0x00558B84 File Offset: 0x00556D84
		public static IStateAlert GetRootAsIStateAlert(ByteBuffer _bb)
		{
			return IStateAlert.GetRootAsIStateAlert(_bb, default(IStateAlert));
		}

		// Token: 0x06026D97 RID: 159127 RVA: 0x00558BA0 File Offset: 0x00556DA0
		public static IStateAlert GetRootAsIStateAlert(ByteBuffer _bb, IStateAlert obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026D98 RID: 159128 RVA: 0x00558BBD File Offset: 0x00556DBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026D99 RID: 159129 RVA: 0x00558BCC File Offset: 0x00556DCC
		public IStateAlert __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AC24 RID: 44068
		// (get) Token: 0x06026D9A RID: 159130 RVA: 0x00558BDC File Offset: 0x00556DDC
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

		// Token: 0x06026D9B RID: 159131 RVA: 0x00558C13 File Offset: 0x00556E13
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06026D9C RID: 159132 RVA: 0x00558C22 File Offset: 0x00556E22
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700AC25 RID: 44069
		// (get) Token: 0x06026D9D RID: 159133 RVA: 0x00558C30 File Offset: 0x00556E30
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

		// Token: 0x06026D9E RID: 159134 RVA: 0x00558C6C File Offset: 0x00556E6C
		public static Offset<IStateAlert> CreateIStateAlert(FlatBufferBuilder builder, StringOffset StateOffset = default(StringOffset), int Alert = 0)
		{
			builder.StartTable(2);
			IStateAlert.AddAlert(builder, Alert);
			IStateAlert.AddState(builder, StateOffset);
			return IStateAlert.EndIStateAlert(builder);
		}

		// Token: 0x06026D9F RID: 159135 RVA: 0x00558C89 File Offset: 0x00556E89
		public static void StartIStateAlert(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06026DA0 RID: 159136 RVA: 0x00558C92 File Offset: 0x00556E92
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(0, stateOffset.Value, 0);
		}

		// Token: 0x06026DA1 RID: 159137 RVA: 0x00558CA2 File Offset: 0x00556EA2
		public static void AddAlert(FlatBufferBuilder builder, int alert)
		{
			builder.AddInt(1, alert, 0);
		}

		// Token: 0x06026DA2 RID: 159138 RVA: 0x00558CAD File Offset: 0x00556EAD
		public static Offset<IStateAlert> EndIStateAlert(FlatBufferBuilder builder)
		{
			return new Offset<IStateAlert>(builder.EndTable());
		}

		// Token: 0x06026DA3 RID: 159139 RVA: 0x00558CBC File Offset: 0x00556EBC
		public IStateAlertT UnPack()
		{
			IStateAlertT stateAlertT = new IStateAlertT();
			this.UnPackTo(stateAlertT);
			return stateAlertT;
		}

		// Token: 0x06026DA4 RID: 159140 RVA: 0x00558CD7 File Offset: 0x00556ED7
		public void UnPackTo(IStateAlertT _o)
		{
			_o.State = this.State;
			_o.Alert = this.Alert;
		}

		// Token: 0x06026DA5 RID: 159141 RVA: 0x00558CF4 File Offset: 0x00556EF4
		public static Offset<IStateAlert> Pack(FlatBufferBuilder builder, IStateAlertT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStateAlert>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IStateAlert.CreateIStateAlert(builder, stateOffset, _o.Alert);
		}

		// Token: 0x0400EFA5 RID: 61349
		private Table __p;
	}
}
