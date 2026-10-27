using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005677 RID: 22135
	public struct INpcUiInteractOnHandInItem : IFlatbufferObject
	{
		// Token: 0x1700A43B RID: 42043
		// (get) Token: 0x06024DB5 RID: 150965 RVA: 0x0051610C File Offset: 0x0051430C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024DB6 RID: 150966 RVA: 0x00516119 File Offset: 0x00514319
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024DB7 RID: 150967 RVA: 0x00516120 File Offset: 0x00514320
		public static INpcUiInteractOnHandInItem GetRootAsINpcUiInteractOnHandInItem(ByteBuffer _bb)
		{
			return INpcUiInteractOnHandInItem.GetRootAsINpcUiInteractOnHandInItem(_bb, default(INpcUiInteractOnHandInItem));
		}

		// Token: 0x06024DB8 RID: 150968 RVA: 0x0051613C File Offset: 0x0051433C
		public static INpcUiInteractOnHandInItem GetRootAsINpcUiInteractOnHandInItem(ByteBuffer _bb, INpcUiInteractOnHandInItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024DB9 RID: 150969 RVA: 0x00516159 File Offset: 0x00514359
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024DBA RID: 150970 RVA: 0x00516168 File Offset: 0x00514368
		public INpcUiInteractOnHandInItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A43C RID: 42044
		// (get) Token: 0x06024DBB RID: 150971 RVA: 0x00516178 File Offset: 0x00514378
		public ENpcUiInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENpcUiInteractType.HandInItem;
				}
				return (ENpcUiInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A43D RID: 42045
		// (get) Token: 0x06024DBC RID: 150972 RVA: 0x005161B4 File Offset: 0x005143B4
		public string EnterMontage
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024DBD RID: 150973 RVA: 0x005161EB File Offset: 0x005143EB
		public Span<byte> GetEnterMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06024DBE RID: 150974 RVA: 0x005161FA File Offset: 0x005143FA
		public byte[] GetEnterMontageArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700A43E RID: 42046
		// (get) Token: 0x06024DBF RID: 150975 RVA: 0x00516208 File Offset: 0x00514408
		public string StandByMontage
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024DC0 RID: 150976 RVA: 0x0051623F File Offset: 0x0051443F
		public Span<byte> GetStandByMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06024DC1 RID: 150977 RVA: 0x0051624E File Offset: 0x0051444E
		public byte[] GetStandByMontageArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700A43F RID: 42047
		// (get) Token: 0x06024DC2 RID: 150978 RVA: 0x0051625C File Offset: 0x0051445C
		public string HandInFailedMontage
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024DC3 RID: 150979 RVA: 0x00516294 File Offset: 0x00514494
		public Span<byte> GetHandInFailedMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06024DC4 RID: 150980 RVA: 0x005162A4 File Offset: 0x005144A4
		public byte[] GetHandInFailedMontageArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700A440 RID: 42048
		// (get) Token: 0x06024DC5 RID: 150981 RVA: 0x005162B4 File Offset: 0x005144B4
		public IPlayFlow? EnterFlow
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IPlayFlow?(default(IPlayFlow).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A441 RID: 42049
		// (get) Token: 0x06024DC6 RID: 150982 RVA: 0x00516314 File Offset: 0x00514514
		public IPlayFlow? HandInFailedFlow
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IPlayFlow?(default(IPlayFlow).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06024DC7 RID: 150983 RVA: 0x00516372 File Offset: 0x00514572
		public static Offset<INpcUiInteractOnHandInItem> CreateINpcUiInteractOnHandInItem(FlatBufferBuilder builder, ENpcUiInteractType Type = ENpcUiInteractType.HandInItem, StringOffset EnterMontageOffset = default(StringOffset), StringOffset StandByMontageOffset = default(StringOffset), StringOffset HandInFailedMontageOffset = default(StringOffset), Offset<IPlayFlow> EnterFlowOffset = default(Offset<IPlayFlow>), Offset<IPlayFlow> HandInFailedFlowOffset = default(Offset<IPlayFlow>))
		{
			builder.StartTable(6);
			INpcUiInteractOnHandInItem.AddHandInFailedFlow(builder, HandInFailedFlowOffset);
			INpcUiInteractOnHandInItem.AddEnterFlow(builder, EnterFlowOffset);
			INpcUiInteractOnHandInItem.AddHandInFailedMontage(builder, HandInFailedMontageOffset);
			INpcUiInteractOnHandInItem.AddStandByMontage(builder, StandByMontageOffset);
			INpcUiInteractOnHandInItem.AddEnterMontage(builder, EnterMontageOffset);
			INpcUiInteractOnHandInItem.AddType(builder, Type);
			return INpcUiInteractOnHandInItem.EndINpcUiInteractOnHandInItem(builder);
		}

		// Token: 0x06024DC8 RID: 150984 RVA: 0x005163AE File Offset: 0x005145AE
		public static void StartINpcUiInteractOnHandInItem(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06024DC9 RID: 150985 RVA: 0x005163B7 File Offset: 0x005145B7
		public static void AddType(FlatBufferBuilder builder, ENpcUiInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024DCA RID: 150986 RVA: 0x005163C2 File Offset: 0x005145C2
		public static void AddEnterMontage(FlatBufferBuilder builder, StringOffset enterMontageOffset)
		{
			builder.AddOffset(1, enterMontageOffset.Value, 0);
		}

		// Token: 0x06024DCB RID: 150987 RVA: 0x005163D2 File Offset: 0x005145D2
		public static void AddStandByMontage(FlatBufferBuilder builder, StringOffset standByMontageOffset)
		{
			builder.AddOffset(2, standByMontageOffset.Value, 0);
		}

		// Token: 0x06024DCC RID: 150988 RVA: 0x005163E2 File Offset: 0x005145E2
		public static void AddHandInFailedMontage(FlatBufferBuilder builder, StringOffset handInFailedMontageOffset)
		{
			builder.AddOffset(3, handInFailedMontageOffset.Value, 0);
		}

		// Token: 0x06024DCD RID: 150989 RVA: 0x005163F2 File Offset: 0x005145F2
		public static void AddEnterFlow(FlatBufferBuilder builder, Offset<IPlayFlow> enterFlowOffset)
		{
			builder.AddOffset(4, enterFlowOffset.Value, 0);
		}

		// Token: 0x06024DCE RID: 150990 RVA: 0x00516402 File Offset: 0x00514602
		public static void AddHandInFailedFlow(FlatBufferBuilder builder, Offset<IPlayFlow> handInFailedFlowOffset)
		{
			builder.AddOffset(5, handInFailedFlowOffset.Value, 0);
		}

		// Token: 0x06024DCF RID: 150991 RVA: 0x00516412 File Offset: 0x00514612
		public static Offset<INpcUiInteractOnHandInItem> EndINpcUiInteractOnHandInItem(FlatBufferBuilder builder)
		{
			return new Offset<INpcUiInteractOnHandInItem>(builder.EndTable());
		}

		// Token: 0x06024DD0 RID: 150992 RVA: 0x00516420 File Offset: 0x00514620
		public INpcUiInteractOnHandInItemT UnPack()
		{
			INpcUiInteractOnHandInItemT npcUiInteractOnHandInItemT = new INpcUiInteractOnHandInItemT();
			this.UnPackTo(npcUiInteractOnHandInItemT);
			return npcUiInteractOnHandInItemT;
		}

		// Token: 0x06024DD1 RID: 150993 RVA: 0x0051643C File Offset: 0x0051463C
		public void UnPackTo(INpcUiInteractOnHandInItemT _o)
		{
			_o.Type = this.Type;
			_o.EnterMontage = this.EnterMontage;
			_o.StandByMontage = this.StandByMontage;
			_o.HandInFailedMontage = this.HandInFailedMontage;
			_o.EnterFlow = ((this.EnterFlow != null) ? this.EnterFlow.Value.UnPack() : null);
			_o.HandInFailedFlow = ((this.HandInFailedFlow != null) ? this.HandInFailedFlow.Value.UnPack() : null);
		}

		// Token: 0x06024DD2 RID: 150994 RVA: 0x005164D8 File Offset: 0x005146D8
		public static Offset<INpcUiInteractOnHandInItem> Pack(FlatBufferBuilder builder, INpcUiInteractOnHandInItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcUiInteractOnHandInItem>);
			}
			StringOffset enterMontageOffset = (_o.EnterMontage == null) ? default(StringOffset) : builder.CreateString(_o.EnterMontage);
			StringOffset standByMontageOffset = (_o.StandByMontage == null) ? default(StringOffset) : builder.CreateString(_o.StandByMontage);
			StringOffset handInFailedMontageOffset = (_o.HandInFailedMontage == null) ? default(StringOffset) : builder.CreateString(_o.HandInFailedMontage);
			Offset<IPlayFlow> enterFlowOffset = (_o.EnterFlow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.EnterFlow);
			Offset<IPlayFlow> handInFailedFlowOffset = (_o.HandInFailedFlow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.HandInFailedFlow);
			return INpcUiInteractOnHandInItem.CreateINpcUiInteractOnHandInItem(builder, _o.Type, enterMontageOffset, standByMontageOffset, handInFailedMontageOffset, enterFlowOffset, handInFailedFlowOffset);
		}

		// Token: 0x0400EA57 RID: 59991
		private Table __p;
	}
}
