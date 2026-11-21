using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055F8 RID: 22008
	public struct IDollComboCameraConfig : IFlatbufferObject
	{
		// Token: 0x17009DBB RID: 40379
		// (get) Token: 0x0602310F RID: 143631 RVA: 0x004D3B14 File Offset: 0x004D1D14
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023110 RID: 143632 RVA: 0x004D3B21 File Offset: 0x004D1D21
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023111 RID: 143633 RVA: 0x004D3B28 File Offset: 0x004D1D28
		public static IDollComboCameraConfig GetRootAsIDollComboCameraConfig(ByteBuffer _bb)
		{
			return IDollComboCameraConfig.GetRootAsIDollComboCameraConfig(_bb, default(IDollComboCameraConfig));
		}

		// Token: 0x06023112 RID: 143634 RVA: 0x004D3B44 File Offset: 0x004D1D44
		public static IDollComboCameraConfig GetRootAsIDollComboCameraConfig(ByteBuffer _bb, IDollComboCameraConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023113 RID: 143635 RVA: 0x004D3B61 File Offset: 0x004D1D61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023114 RID: 143636 RVA: 0x004D3B70 File Offset: 0x004D1D70
		public IDollComboCameraConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009DBC RID: 40380
		// (get) Token: 0x06023115 RID: 143637 RVA: 0x004D3B80 File Offset: 0x004D1D80
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

		// Token: 0x17009DBD RID: 40381
		// (get) Token: 0x06023116 RID: 143638 RVA: 0x004D3BBC File Offset: 0x004D1DBC
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

		// Token: 0x06023117 RID: 143639 RVA: 0x004D3C19 File Offset: 0x004D1E19
		public static Offset<IDollComboCameraConfig> CreateIDollComboCameraConfig(FlatBufferBuilder builder, int ComboId = 0, Offset<IPosAndRot> PosAndRotOffset = default(Offset<IPosAndRot>))
		{
			builder.StartTable(2);
			IDollComboCameraConfig.AddPosAndRot(builder, PosAndRotOffset);
			IDollComboCameraConfig.AddComboId(builder, ComboId);
			return IDollComboCameraConfig.EndIDollComboCameraConfig(builder);
		}

		// Token: 0x06023118 RID: 143640 RVA: 0x004D3C36 File Offset: 0x004D1E36
		public static void StartIDollComboCameraConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06023119 RID: 143641 RVA: 0x004D3C3F File Offset: 0x004D1E3F
		public static void AddComboId(FlatBufferBuilder builder, int comboId)
		{
			builder.AddInt(0, comboId, 0);
		}

		// Token: 0x0602311A RID: 143642 RVA: 0x004D3C4A File Offset: 0x004D1E4A
		public static void AddPosAndRot(FlatBufferBuilder builder, Offset<IPosAndRot> posAndRotOffset)
		{
			builder.AddOffset(1, posAndRotOffset.Value, 0);
		}

		// Token: 0x0602311B RID: 143643 RVA: 0x004D3C5A File Offset: 0x004D1E5A
		public static Offset<IDollComboCameraConfig> EndIDollComboCameraConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDollComboCameraConfig>(builder.EndTable());
		}

		// Token: 0x0602311C RID: 143644 RVA: 0x004D3C68 File Offset: 0x004D1E68
		public IDollComboCameraConfigT UnPack()
		{
			IDollComboCameraConfigT dollComboCameraConfigT = new IDollComboCameraConfigT();
			this.UnPackTo(dollComboCameraConfigT);
			return dollComboCameraConfigT;
		}

		// Token: 0x0602311D RID: 143645 RVA: 0x004D3C84 File Offset: 0x004D1E84
		public void UnPackTo(IDollComboCameraConfigT _o)
		{
			_o.ComboId = this.ComboId;
			_o.PosAndRot = ((this.PosAndRot != null) ? this.PosAndRot.Value.UnPack() : null);
		}

		// Token: 0x0602311E RID: 143646 RVA: 0x004D3CCC File Offset: 0x004D1ECC
		public static Offset<IDollComboCameraConfig> Pack(FlatBufferBuilder builder, IDollComboCameraConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDollComboCameraConfig>);
			}
			Offset<IPosAndRot> posAndRotOffset = (_o.PosAndRot == null) ? default(Offset<IPosAndRot>) : IPosAndRot.Pack(builder, _o.PosAndRot);
			return IDollComboCameraConfig.CreateIDollComboCameraConfig(builder, _o.ComboId, posAndRotOffset);
		}

		// Token: 0x0400ECA9 RID: 60585
		private Table __p;
	}
}
