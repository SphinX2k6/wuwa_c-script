using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005093 RID: 20627
	public struct IDollComboCameraConfig : IFlatbufferObject
	{
		// Token: 0x170095CE RID: 38350
		// (get) Token: 0x060211BB RID: 135611 RVA: 0x00499B88 File Offset: 0x00497D88
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060211BC RID: 135612 RVA: 0x00499B95 File Offset: 0x00497D95
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060211BD RID: 135613 RVA: 0x00499B9C File Offset: 0x00497D9C
		public static IDollComboCameraConfig GetRootAsIDollComboCameraConfig(ByteBuffer _bb)
		{
			return IDollComboCameraConfig.GetRootAsIDollComboCameraConfig(_bb, default(IDollComboCameraConfig));
		}

		// Token: 0x060211BE RID: 135614 RVA: 0x00499BB8 File Offset: 0x00497DB8
		public static IDollComboCameraConfig GetRootAsIDollComboCameraConfig(ByteBuffer _bb, IDollComboCameraConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060211BF RID: 135615 RVA: 0x00499BD5 File Offset: 0x00497DD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060211C0 RID: 135616 RVA: 0x00499BE4 File Offset: 0x00497DE4
		public IDollComboCameraConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170095CF RID: 38351
		// (get) Token: 0x060211C1 RID: 135617 RVA: 0x00499BF4 File Offset: 0x00497DF4
		public int ComboId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170095D0 RID: 38352
		// (get) Token: 0x060211C2 RID: 135618 RVA: 0x00499C30 File Offset: 0x00497E30
		public IPosAndRot? PosAndRot
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPosAndRot?(default(IPosAndRot).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060211C3 RID: 135619 RVA: 0x00499C8D File Offset: 0x00497E8D
		public static Offset<IDollComboCameraConfig> CreateIDollComboCameraConfig(FlatBufferBuilder builder, int ComboId = 0, Offset<IPosAndRot> PosAndRotOffset = default(Offset<IPosAndRot>))
		{
			builder.StartTable(2);
			IDollComboCameraConfig.AddPosAndRot(builder, PosAndRotOffset);
			IDollComboCameraConfig.AddComboId(builder, ComboId);
			return IDollComboCameraConfig.EndIDollComboCameraConfig(builder);
		}

		// Token: 0x060211C4 RID: 135620 RVA: 0x00499CAA File Offset: 0x00497EAA
		public static void StartIDollComboCameraConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060211C5 RID: 135621 RVA: 0x00499CB3 File Offset: 0x00497EB3
		public static void AddComboId(FlatBufferBuilder builder, int comboId)
		{
			builder.AddInt(0, comboId, 0);
		}

		// Token: 0x060211C6 RID: 135622 RVA: 0x00499CBE File Offset: 0x00497EBE
		public static void AddPosAndRot(FlatBufferBuilder builder, Offset<IPosAndRot> posAndRotOffset)
		{
			builder.AddOffset(1, posAndRotOffset.Value, 0);
		}

		// Token: 0x060211C7 RID: 135623 RVA: 0x00499CCE File Offset: 0x00497ECE
		public static Offset<IDollComboCameraConfig> EndIDollComboCameraConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDollComboCameraConfig>(builder.EndTable());
		}

		// Token: 0x060211C8 RID: 135624 RVA: 0x00499CDC File Offset: 0x00497EDC
		public IDollComboCameraConfigT UnPack()
		{
			IDollComboCameraConfigT dollComboCameraConfigT = new IDollComboCameraConfigT();
			this.UnPackTo(dollComboCameraConfigT);
			return dollComboCameraConfigT;
		}

		// Token: 0x060211C9 RID: 135625 RVA: 0x00499CF8 File Offset: 0x00497EF8
		public void UnPackTo(IDollComboCameraConfigT _o)
		{
			_o.ComboId = this.ComboId;
			_o.PosAndRot = ((this.PosAndRot != null) ? this.PosAndRot.Value.UnPack() : null);
		}

		// Token: 0x060211CA RID: 135626 RVA: 0x00499D40 File Offset: 0x00497F40
		public static Offset<IDollComboCameraConfig> Pack(FlatBufferBuilder builder, IDollComboCameraConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDollComboCameraConfig>);
			}
			Offset<IPosAndRot> posAndRotOffset = (_o.PosAndRot == null) ? default(Offset<IPosAndRot>) : IPosAndRot.Pack(builder, _o.PosAndRot);
			return IDollComboCameraConfig.CreateIDollComboCameraConfig(builder, _o.ComboId, posAndRotOffset);
		}

		// Token: 0x0400E0AC RID: 57516
		private Table __p;
	}
}
