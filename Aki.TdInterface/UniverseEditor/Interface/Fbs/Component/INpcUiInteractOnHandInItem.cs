using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C18 RID: 23576
	public struct INpcUiInteractOnHandInItem : IFlatbufferObject
	{
		// Token: 0x1700ACCA RID: 44234
		// (get) Token: 0x06026FEE RID: 159726 RVA: 0x00556CA8 File Offset: 0x00554EA8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026FEF RID: 159727 RVA: 0x00556CB5 File Offset: 0x00554EB5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026FF0 RID: 159728 RVA: 0x00556CBC File Offset: 0x00554EBC
		public static INpcUiInteractOnHandInItem GetRootAsINpcUiInteractOnHandInItem(ByteBuffer _bb)
		{
			return INpcUiInteractOnHandInItem.GetRootAsINpcUiInteractOnHandInItem(_bb, default(INpcUiInteractOnHandInItem));
		}

		// Token: 0x06026FF1 RID: 159729 RVA: 0x00556CD8 File Offset: 0x00554ED8
		public static INpcUiInteractOnHandInItem GetRootAsINpcUiInteractOnHandInItem(ByteBuffer _bb, INpcUiInteractOnHandInItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026FF2 RID: 159730 RVA: 0x00556CF5 File Offset: 0x00554EF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026FF3 RID: 159731 RVA: 0x00556D04 File Offset: 0x00554F04
		public INpcUiInteractOnHandInItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ACCB RID: 44235
		// (get) Token: 0x06026FF4 RID: 159732 RVA: 0x00556D14 File Offset: 0x00554F14
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

		// Token: 0x1700ACCC RID: 44236
		// (get) Token: 0x06026FF5 RID: 159733 RVA: 0x00556D50 File Offset: 0x00554F50
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

		// Token: 0x06026FF6 RID: 159734 RVA: 0x00556D87 File Offset: 0x00554F87
		public Span<byte> GetEnterMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06026FF7 RID: 159735 RVA: 0x00556D96 File Offset: 0x00554F96
		public byte[] GetEnterMontageArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700ACCD RID: 44237
		// (get) Token: 0x06026FF8 RID: 159736 RVA: 0x00556DA4 File Offset: 0x00554FA4
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

		// Token: 0x06026FF9 RID: 159737 RVA: 0x00556DDB File Offset: 0x00554FDB
		public Span<byte> GetStandByMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06026FFA RID: 159738 RVA: 0x00556DEA File Offset: 0x00554FEA
		public byte[] GetStandByMontageArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700ACCE RID: 44238
		// (get) Token: 0x06026FFB RID: 159739 RVA: 0x00556DF8 File Offset: 0x00554FF8
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

		// Token: 0x06026FFC RID: 159740 RVA: 0x00556E30 File Offset: 0x00555030
		public Span<byte> GetHandInFailedMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06026FFD RID: 159741 RVA: 0x00556E40 File Offset: 0x00555040
		public byte[] GetHandInFailedMontageArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700ACCF RID: 44239
		// (get) Token: 0x06026FFE RID: 159742 RVA: 0x00556E50 File Offset: 0x00555050
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

		// Token: 0x1700ACD0 RID: 44240
		// (get) Token: 0x06026FFF RID: 159743 RVA: 0x00556EB0 File Offset: 0x005550B0
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

		// Token: 0x06027000 RID: 159744 RVA: 0x00556F0E File Offset: 0x0055510E
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

		// Token: 0x06027001 RID: 159745 RVA: 0x00556F4A File Offset: 0x0055514A
		public static void StartINpcUiInteractOnHandInItem(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06027002 RID: 159746 RVA: 0x00556F53 File Offset: 0x00555153
		public static void AddType(FlatBufferBuilder builder, ENpcUiInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027003 RID: 159747 RVA: 0x00556F5E File Offset: 0x0055515E
		public static void AddEnterMontage(FlatBufferBuilder builder, StringOffset enterMontageOffset)
		{
			builder.AddOffset(1, enterMontageOffset.Value, 0);
		}

		// Token: 0x06027004 RID: 159748 RVA: 0x00556F6E File Offset: 0x0055516E
		public static void AddStandByMontage(FlatBufferBuilder builder, StringOffset standByMontageOffset)
		{
			builder.AddOffset(2, standByMontageOffset.Value, 0);
		}

		// Token: 0x06027005 RID: 159749 RVA: 0x00556F7E File Offset: 0x0055517E
		public static void AddHandInFailedMontage(FlatBufferBuilder builder, StringOffset handInFailedMontageOffset)
		{
			builder.AddOffset(3, handInFailedMontageOffset.Value, 0);
		}

		// Token: 0x06027006 RID: 159750 RVA: 0x00556F8E File Offset: 0x0055518E
		public static void AddEnterFlow(FlatBufferBuilder builder, Offset<IPlayFlow> enterFlowOffset)
		{
			builder.AddOffset(4, enterFlowOffset.Value, 0);
		}

		// Token: 0x06027007 RID: 159751 RVA: 0x00556F9E File Offset: 0x0055519E
		public static void AddHandInFailedFlow(FlatBufferBuilder builder, Offset<IPlayFlow> handInFailedFlowOffset)
		{
			builder.AddOffset(5, handInFailedFlowOffset.Value, 0);
		}

		// Token: 0x06027008 RID: 159752 RVA: 0x00556FAE File Offset: 0x005551AE
		public static Offset<INpcUiInteractOnHandInItem> EndINpcUiInteractOnHandInItem(FlatBufferBuilder builder)
		{
			return new Offset<INpcUiInteractOnHandInItem>(builder.EndTable());
		}

		// Token: 0x06027009 RID: 159753 RVA: 0x00556FBC File Offset: 0x005551BC
		public INpcUiInteractOnHandInItemT UnPack()
		{
			INpcUiInteractOnHandInItemT npcUiInteractOnHandInItemT = new INpcUiInteractOnHandInItemT();
			this.UnPackTo(npcUiInteractOnHandInItemT);
			return npcUiInteractOnHandInItemT;
		}

		// Token: 0x0602700A RID: 159754 RVA: 0x00556FD8 File Offset: 0x005551D8
		public void UnPackTo(INpcUiInteractOnHandInItemT _o)
		{
			_o.Type = this.Type;
			_o.EnterMontage = this.EnterMontage;
			_o.StandByMontage = this.StandByMontage;
			_o.HandInFailedMontage = this.HandInFailedMontage;
			_o.EnterFlow = ((this.EnterFlow != null) ? this.EnterFlow.Value.UnPack() : null);
			_o.HandInFailedFlow = ((this.HandInFailedFlow != null) ? this.HandInFailedFlow.Value.UnPack() : null);
		}

		// Token: 0x0602700B RID: 159755 RVA: 0x00557074 File Offset: 0x00555274
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

		// Token: 0x0400F6C0 RID: 63168
		private Table __p;
	}
}
