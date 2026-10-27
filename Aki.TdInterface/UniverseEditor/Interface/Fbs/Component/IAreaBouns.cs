using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EB6 RID: 20150
	public struct IAreaBouns : IFlatbufferObject
	{
		// Token: 0x17009091 RID: 37009
		// (get) Token: 0x0601FBB6 RID: 129974 RVA: 0x0046AE9F File Offset: 0x0046909F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FBB7 RID: 129975 RVA: 0x0046AEAC File Offset: 0x004690AC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FBB8 RID: 129976 RVA: 0x0046AEB4 File Offset: 0x004690B4
		public static IAreaBouns GetRootAsIAreaBouns(ByteBuffer _bb)
		{
			return IAreaBouns.GetRootAsIAreaBouns(_bb, default(IAreaBouns));
		}

		// Token: 0x0601FBB9 RID: 129977 RVA: 0x0046AED0 File Offset: 0x004690D0
		public static IAreaBouns GetRootAsIAreaBouns(ByteBuffer _bb, IAreaBouns obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FBBA RID: 129978 RVA: 0x0046AEED File Offset: 0x004690ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FBBB RID: 129979 RVA: 0x0046AEFC File Offset: 0x004690FC
		public IAreaBouns __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009092 RID: 37010
		// (get) Token: 0x0601FBBC RID: 129980 RVA: 0x0046AF0C File Offset: 0x0046910C
		public EWorldLevelBonus Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EWorldLevelBonus.WorldLevelTable;
				}
				return (EWorldLevelBonus)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601FBBD RID: 129981 RVA: 0x0046AF48 File Offset: 0x00469148
		public static Offset<IAreaBouns> CreateIAreaBouns(FlatBufferBuilder builder, EWorldLevelBonus Type = EWorldLevelBonus.WorldLevelTable)
		{
			builder.StartTable(1);
			IAreaBouns.AddType(builder, Type);
			return IAreaBouns.EndIAreaBouns(builder);
		}

		// Token: 0x0601FBBE RID: 129982 RVA: 0x0046AF5E File Offset: 0x0046915E
		public static void StartIAreaBouns(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601FBBF RID: 129983 RVA: 0x0046AF67 File Offset: 0x00469167
		public static void AddType(FlatBufferBuilder builder, EWorldLevelBonus type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FBC0 RID: 129984 RVA: 0x0046AF72 File Offset: 0x00469172
		public static Offset<IAreaBouns> EndIAreaBouns(FlatBufferBuilder builder)
		{
			return new Offset<IAreaBouns>(builder.EndTable());
		}

		// Token: 0x0601FBC1 RID: 129985 RVA: 0x0046AF80 File Offset: 0x00469180
		public IAreaBounsT UnPack()
		{
			IAreaBounsT areaBounsT = new IAreaBounsT();
			this.UnPackTo(areaBounsT);
			return areaBounsT;
		}

		// Token: 0x0601FBC2 RID: 129986 RVA: 0x0046AF9B File Offset: 0x0046919B
		public void UnPackTo(IAreaBounsT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601FBC3 RID: 129987 RVA: 0x0046AFAC File Offset: 0x004691AC
		public static Offset<IAreaBouns> Pack(FlatBufferBuilder builder, IAreaBounsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAreaBouns>);
			}
			return IAreaBouns.CreateIAreaBouns(builder, _o.Type);
		}

		// Token: 0x0400DC9F RID: 56479
		private Table __p;
	}
}
