using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006182 RID: 24962
	public struct IAkEventMapType : IFlatbufferObject
	{
		// Token: 0x1700BA24 RID: 47652
		// (get) Token: 0x0602AFFE RID: 176126 RVA: 0x005EEB36 File Offset: 0x005ECD36
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602AFFF RID: 176127 RVA: 0x005EEB43 File Offset: 0x005ECD43
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B000 RID: 176128 RVA: 0x005EEB4C File Offset: 0x005ECD4C
		public static IAkEventMapType GetRootAsIAkEventMapType(ByteBuffer _bb)
		{
			return IAkEventMapType.GetRootAsIAkEventMapType(_bb, default(IAkEventMapType));
		}

		// Token: 0x0602B001 RID: 176129 RVA: 0x005EEB68 File Offset: 0x005ECD68
		public static IAkEventMapType GetRootAsIAkEventMapType(ByteBuffer _bb, IAkEventMapType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B002 RID: 176130 RVA: 0x005EEB85 File Offset: 0x005ECD85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B003 RID: 176131 RVA: 0x005EEB94 File Offset: 0x005ECD94
		public IAkEventMapType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BA25 RID: 47653
		// (get) Token: 0x0602B004 RID: 176132 RVA: 0x005EEBA4 File Offset: 0x005ECDA4
		public EAkEventMap Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAkEventMap.PlayMapMusic;
				}
				return (EAkEventMap)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B005 RID: 176133 RVA: 0x005EEBE0 File Offset: 0x005ECDE0
		public static Offset<IAkEventMapType> CreateIAkEventMapType(FlatBufferBuilder builder, EAkEventMap Type = EAkEventMap.PlayMapMusic)
		{
			builder.StartTable(1);
			IAkEventMapType.AddType(builder, Type);
			return IAkEventMapType.EndIAkEventMapType(builder);
		}

		// Token: 0x0602B006 RID: 176134 RVA: 0x005EEBF6 File Offset: 0x005ECDF6
		public static void StartIAkEventMapType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B007 RID: 176135 RVA: 0x005EEBFF File Offset: 0x005ECDFF
		public static void AddType(FlatBufferBuilder builder, EAkEventMap type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B008 RID: 176136 RVA: 0x005EEC0A File Offset: 0x005ECE0A
		public static Offset<IAkEventMapType> EndIAkEventMapType(FlatBufferBuilder builder)
		{
			return new Offset<IAkEventMapType>(builder.EndTable());
		}

		// Token: 0x0602B009 RID: 176137 RVA: 0x005EEC18 File Offset: 0x005ECE18
		public IAkEventMapTypeT UnPack()
		{
			IAkEventMapTypeT akEventMapTypeT = new IAkEventMapTypeT();
			this.UnPackTo(akEventMapTypeT);
			return akEventMapTypeT;
		}

		// Token: 0x0602B00A RID: 176138 RVA: 0x005EEC33 File Offset: 0x005ECE33
		public void UnPackTo(IAkEventMapTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602B00B RID: 176139 RVA: 0x005EEC44 File Offset: 0x005ECE44
		public static Offset<IAkEventMapType> Pack(FlatBufferBuilder builder, IAkEventMapTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAkEventMapType>);
			}
			return IAkEventMapType.CreateIAkEventMapType(builder, _o.Type);
		}

		// Token: 0x04010686 RID: 67206
		private Table __p;
	}
}
