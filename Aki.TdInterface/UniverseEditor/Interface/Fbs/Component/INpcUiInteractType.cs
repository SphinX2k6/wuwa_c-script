using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C2D RID: 23597
	public struct INpcUiInteractType : IFlatbufferObject
	{
		// Token: 0x1700AD55 RID: 44373
		// (get) Token: 0x060271A8 RID: 160168 RVA: 0x0055BB7C File Offset: 0x00559D7C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060271A9 RID: 160169 RVA: 0x0055BB89 File Offset: 0x00559D89
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060271AA RID: 160170 RVA: 0x0055BB90 File Offset: 0x00559D90
		public static INpcUiInteractType GetRootAsINpcUiInteractType(ByteBuffer _bb)
		{
			return INpcUiInteractType.GetRootAsINpcUiInteractType(_bb, default(INpcUiInteractType));
		}

		// Token: 0x060271AB RID: 160171 RVA: 0x0055BBAC File Offset: 0x00559DAC
		public static INpcUiInteractType GetRootAsINpcUiInteractType(ByteBuffer _bb, INpcUiInteractType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060271AC RID: 160172 RVA: 0x0055BBC9 File Offset: 0x00559DC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060271AD RID: 160173 RVA: 0x0055BBD8 File Offset: 0x00559DD8
		public INpcUiInteractType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AD56 RID: 44374
		// (get) Token: 0x060271AE RID: 160174 RVA: 0x0055BBE8 File Offset: 0x00559DE8
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

		// Token: 0x060271AF RID: 160175 RVA: 0x0055BC24 File Offset: 0x00559E24
		public static Offset<INpcUiInteractType> CreateINpcUiInteractType(FlatBufferBuilder builder, ENpcUiInteractType Type = ENpcUiInteractType.HandInItem)
		{
			builder.StartTable(1);
			INpcUiInteractType.AddType(builder, Type);
			return INpcUiInteractType.EndINpcUiInteractType(builder);
		}

		// Token: 0x060271B0 RID: 160176 RVA: 0x0055BC3A File Offset: 0x00559E3A
		public static void StartINpcUiInteractType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060271B1 RID: 160177 RVA: 0x0055BC43 File Offset: 0x00559E43
		public static void AddType(FlatBufferBuilder builder, ENpcUiInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060271B2 RID: 160178 RVA: 0x0055BC4E File Offset: 0x00559E4E
		public static Offset<INpcUiInteractType> EndINpcUiInteractType(FlatBufferBuilder builder)
		{
			return new Offset<INpcUiInteractType>(builder.EndTable());
		}

		// Token: 0x060271B3 RID: 160179 RVA: 0x0055BC5C File Offset: 0x00559E5C
		public INpcUiInteractTypeT UnPack()
		{
			INpcUiInteractTypeT npcUiInteractTypeT = new INpcUiInteractTypeT();
			this.UnPackTo(npcUiInteractTypeT);
			return npcUiInteractTypeT;
		}

		// Token: 0x060271B4 RID: 160180 RVA: 0x0055BC77 File Offset: 0x00559E77
		public void UnPackTo(INpcUiInteractTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060271B5 RID: 160181 RVA: 0x0055BC88 File Offset: 0x00559E88
		public static Offset<INpcUiInteractType> Pack(FlatBufferBuilder builder, INpcUiInteractTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcUiInteractType>);
			}
			return INpcUiInteractType.CreateINpcUiInteractType(builder, _o.Type);
		}

		// Token: 0x0400F709 RID: 63241
		private Table __p;
	}
}
