using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BE2 RID: 23522
	public struct INpcRideInGongduolaPerform : IFlatbufferObject
	{
		// Token: 0x1700AC25 RID: 44069
		// (get) Token: 0x06026D82 RID: 159106 RVA: 0x00551A8D File Offset: 0x0054FC8D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026D83 RID: 159107 RVA: 0x00551A9A File Offset: 0x0054FC9A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026D84 RID: 159108 RVA: 0x00551AA4 File Offset: 0x0054FCA4
		public static INpcRideInGongduolaPerform GetRootAsINpcRideInGongduolaPerform(ByteBuffer _bb)
		{
			return INpcRideInGongduolaPerform.GetRootAsINpcRideInGongduolaPerform(_bb, default(INpcRideInGongduolaPerform));
		}

		// Token: 0x06026D85 RID: 159109 RVA: 0x00551AC0 File Offset: 0x0054FCC0
		public static INpcRideInGongduolaPerform GetRootAsINpcRideInGongduolaPerform(ByteBuffer _bb, INpcRideInGongduolaPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026D86 RID: 159110 RVA: 0x00551ADD File Offset: 0x0054FCDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026D87 RID: 159111 RVA: 0x00551AEC File Offset: 0x0054FCEC
		public INpcRideInGongduolaPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AC26 RID: 44070
		// (get) Token: 0x06026D88 RID: 159112 RVA: 0x00551AFC File Offset: 0x0054FCFC
		public EVehicleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVehicleType.Gongduola;
				}
				return (EVehicleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AC27 RID: 44071
		// (get) Token: 0x06026D89 RID: 159113 RVA: 0x00551B38 File Offset: 0x0054FD38
		public string Montage
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

		// Token: 0x06026D8A RID: 159114 RVA: 0x00551B6F File Offset: 0x0054FD6F
		public Span<byte> GetMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06026D8B RID: 159115 RVA: 0x00551B7E File Offset: 0x0054FD7E
		public byte[] GetMontageArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06026D8C RID: 159116 RVA: 0x00551B8C File Offset: 0x0054FD8C
		public static Offset<INpcRideInGongduolaPerform> CreateINpcRideInGongduolaPerform(FlatBufferBuilder builder, EVehicleType Type = EVehicleType.Gongduola, StringOffset MontageOffset = default(StringOffset))
		{
			builder.StartTable(2);
			INpcRideInGongduolaPerform.AddMontage(builder, MontageOffset);
			INpcRideInGongduolaPerform.AddType(builder, Type);
			return INpcRideInGongduolaPerform.EndINpcRideInGongduolaPerform(builder);
		}

		// Token: 0x06026D8D RID: 159117 RVA: 0x00551BA9 File Offset: 0x0054FDA9
		public static void StartINpcRideInGongduolaPerform(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06026D8E RID: 159118 RVA: 0x00551BB2 File Offset: 0x0054FDB2
		public static void AddType(FlatBufferBuilder builder, EVehicleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026D8F RID: 159119 RVA: 0x00551BBD File Offset: 0x0054FDBD
		public static void AddMontage(FlatBufferBuilder builder, StringOffset montageOffset)
		{
			builder.AddOffset(1, montageOffset.Value, 0);
		}

		// Token: 0x06026D90 RID: 159120 RVA: 0x00551BCD File Offset: 0x0054FDCD
		public static Offset<INpcRideInGongduolaPerform> EndINpcRideInGongduolaPerform(FlatBufferBuilder builder)
		{
			return new Offset<INpcRideInGongduolaPerform>(builder.EndTable());
		}

		// Token: 0x06026D91 RID: 159121 RVA: 0x00551BDC File Offset: 0x0054FDDC
		public INpcRideInGongduolaPerformT UnPack()
		{
			INpcRideInGongduolaPerformT npcRideInGongduolaPerformT = new INpcRideInGongduolaPerformT();
			this.UnPackTo(npcRideInGongduolaPerformT);
			return npcRideInGongduolaPerformT;
		}

		// Token: 0x06026D92 RID: 159122 RVA: 0x00551BF7 File Offset: 0x0054FDF7
		public void UnPackTo(INpcRideInGongduolaPerformT _o)
		{
			_o.Type = this.Type;
			_o.Montage = this.Montage;
		}

		// Token: 0x06026D93 RID: 159123 RVA: 0x00551C14 File Offset: 0x0054FE14
		public static Offset<INpcRideInGongduolaPerform> Pack(FlatBufferBuilder builder, INpcRideInGongduolaPerformT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcRideInGongduolaPerform>);
			}
			StringOffset montageOffset = (_o.Montage == null) ? default(StringOffset) : builder.CreateString(_o.Montage);
			return INpcRideInGongduolaPerform.CreateINpcRideInGongduolaPerform(builder, _o.Type, montageOffset);
		}

		// Token: 0x0400F650 RID: 63056
		private Table __p;
	}
}
