using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BDF RID: 23519
	public struct INpcRideInAutoGongduolaPerform : IFlatbufferObject
	{
		// Token: 0x1700AC20 RID: 44064
		// (get) Token: 0x06026D6A RID: 159082 RVA: 0x0055185A File Offset: 0x0054FA5A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026D6B RID: 159083 RVA: 0x00551867 File Offset: 0x0054FA67
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026D6C RID: 159084 RVA: 0x00551870 File Offset: 0x0054FA70
		public static INpcRideInAutoGongduolaPerform GetRootAsINpcRideInAutoGongduolaPerform(ByteBuffer _bb)
		{
			return INpcRideInAutoGongduolaPerform.GetRootAsINpcRideInAutoGongduolaPerform(_bb, default(INpcRideInAutoGongduolaPerform));
		}

		// Token: 0x06026D6D RID: 159085 RVA: 0x0055188C File Offset: 0x0054FA8C
		public static INpcRideInAutoGongduolaPerform GetRootAsINpcRideInAutoGongduolaPerform(ByteBuffer _bb, INpcRideInAutoGongduolaPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026D6E RID: 159086 RVA: 0x005518A9 File Offset: 0x0054FAA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026D6F RID: 159087 RVA: 0x005518B8 File Offset: 0x0054FAB8
		public INpcRideInAutoGongduolaPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AC21 RID: 44065
		// (get) Token: 0x06026D70 RID: 159088 RVA: 0x005518C8 File Offset: 0x0054FAC8
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

		// Token: 0x1700AC22 RID: 44066
		// (get) Token: 0x06026D71 RID: 159089 RVA: 0x00551904 File Offset: 0x0054FB04
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

		// Token: 0x06026D72 RID: 159090 RVA: 0x0055193B File Offset: 0x0054FB3B
		public Span<byte> GetMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06026D73 RID: 159091 RVA: 0x0055194A File Offset: 0x0054FB4A
		public byte[] GetMontageArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06026D74 RID: 159092 RVA: 0x00551958 File Offset: 0x0054FB58
		public static Offset<INpcRideInAutoGongduolaPerform> CreateINpcRideInAutoGongduolaPerform(FlatBufferBuilder builder, EVehicleType Type = EVehicleType.Gongduola, StringOffset MontageOffset = default(StringOffset))
		{
			builder.StartTable(2);
			INpcRideInAutoGongduolaPerform.AddMontage(builder, MontageOffset);
			INpcRideInAutoGongduolaPerform.AddType(builder, Type);
			return INpcRideInAutoGongduolaPerform.EndINpcRideInAutoGongduolaPerform(builder);
		}

		// Token: 0x06026D75 RID: 159093 RVA: 0x00551975 File Offset: 0x0054FB75
		public static void StartINpcRideInAutoGongduolaPerform(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06026D76 RID: 159094 RVA: 0x0055197E File Offset: 0x0054FB7E
		public static void AddType(FlatBufferBuilder builder, EVehicleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026D77 RID: 159095 RVA: 0x00551989 File Offset: 0x0054FB89
		public static void AddMontage(FlatBufferBuilder builder, StringOffset montageOffset)
		{
			builder.AddOffset(1, montageOffset.Value, 0);
		}

		// Token: 0x06026D78 RID: 159096 RVA: 0x00551999 File Offset: 0x0054FB99
		public static Offset<INpcRideInAutoGongduolaPerform> EndINpcRideInAutoGongduolaPerform(FlatBufferBuilder builder)
		{
			return new Offset<INpcRideInAutoGongduolaPerform>(builder.EndTable());
		}

		// Token: 0x06026D79 RID: 159097 RVA: 0x005519A8 File Offset: 0x0054FBA8
		public INpcRideInAutoGongduolaPerformT UnPack()
		{
			INpcRideInAutoGongduolaPerformT npcRideInAutoGongduolaPerformT = new INpcRideInAutoGongduolaPerformT();
			this.UnPackTo(npcRideInAutoGongduolaPerformT);
			return npcRideInAutoGongduolaPerformT;
		}

		// Token: 0x06026D7A RID: 159098 RVA: 0x005519C3 File Offset: 0x0054FBC3
		public void UnPackTo(INpcRideInAutoGongduolaPerformT _o)
		{
			_o.Type = this.Type;
			_o.Montage = this.Montage;
		}

		// Token: 0x06026D7B RID: 159099 RVA: 0x005519E0 File Offset: 0x0054FBE0
		public static Offset<INpcRideInAutoGongduolaPerform> Pack(FlatBufferBuilder builder, INpcRideInAutoGongduolaPerformT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcRideInAutoGongduolaPerform>);
			}
			StringOffset montageOffset = (_o.Montage == null) ? default(StringOffset) : builder.CreateString(_o.Montage);
			return INpcRideInAutoGongduolaPerform.CreateINpcRideInAutoGongduolaPerform(builder, _o.Type, montageOffset);
		}

		// Token: 0x0400F64D RID: 63053
		private Table __p;
	}
}
