using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006912 RID: 26898
	public struct IHideWorldMonsterAndMonsterTreasure : IFlatbufferObject
	{
		// Token: 0x1700C79A RID: 51098
		// (get) Token: 0x0602EF4A RID: 192330 RVA: 0x0066759A File Offset: 0x0066579A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EF4B RID: 192331 RVA: 0x006675A7 File Offset: 0x006657A7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EF4C RID: 192332 RVA: 0x006675B0 File Offset: 0x006657B0
		public static IHideWorldMonsterAndMonsterTreasure GetRootAsIHideWorldMonsterAndMonsterTreasure(ByteBuffer _bb)
		{
			return IHideWorldMonsterAndMonsterTreasure.GetRootAsIHideWorldMonsterAndMonsterTreasure(_bb, default(IHideWorldMonsterAndMonsterTreasure));
		}

		// Token: 0x0602EF4D RID: 192333 RVA: 0x006675CC File Offset: 0x006657CC
		public static IHideWorldMonsterAndMonsterTreasure GetRootAsIHideWorldMonsterAndMonsterTreasure(ByteBuffer _bb, IHideWorldMonsterAndMonsterTreasure obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EF4E RID: 192334 RVA: 0x006675E9 File Offset: 0x006657E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EF4F RID: 192335 RVA: 0x006675F8 File Offset: 0x006657F8
		public IHideWorldMonsterAndMonsterTreasure __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C79B RID: 51099
		// (get) Token: 0x0602EF50 RID: 192336 RVA: 0x00667608 File Offset: 0x00665808
		public EHideType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHideType.WorldMonsterAndMonsterTreasure;
				}
				return (EHideType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602EF51 RID: 192337 RVA: 0x00667644 File Offset: 0x00665844
		public static Offset<IHideWorldMonsterAndMonsterTreasure> CreateIHideWorldMonsterAndMonsterTreasure(FlatBufferBuilder builder, EHideType Type = EHideType.WorldMonsterAndMonsterTreasure)
		{
			builder.StartTable(1);
			IHideWorldMonsterAndMonsterTreasure.AddType(builder, Type);
			return IHideWorldMonsterAndMonsterTreasure.EndIHideWorldMonsterAndMonsterTreasure(builder);
		}

		// Token: 0x0602EF52 RID: 192338 RVA: 0x0066765A File Offset: 0x0066585A
		public static void StartIHideWorldMonsterAndMonsterTreasure(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602EF53 RID: 192339 RVA: 0x00667663 File Offset: 0x00665863
		public static void AddType(FlatBufferBuilder builder, EHideType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EF54 RID: 192340 RVA: 0x0066766E File Offset: 0x0066586E
		public static Offset<IHideWorldMonsterAndMonsterTreasure> EndIHideWorldMonsterAndMonsterTreasure(FlatBufferBuilder builder)
		{
			return new Offset<IHideWorldMonsterAndMonsterTreasure>(builder.EndTable());
		}

		// Token: 0x0602EF55 RID: 192341 RVA: 0x0066767C File Offset: 0x0066587C
		public IHideWorldMonsterAndMonsterTreasureT UnPack()
		{
			IHideWorldMonsterAndMonsterTreasureT hideWorldMonsterAndMonsterTreasureT = new IHideWorldMonsterAndMonsterTreasureT();
			this.UnPackTo(hideWorldMonsterAndMonsterTreasureT);
			return hideWorldMonsterAndMonsterTreasureT;
		}

		// Token: 0x0602EF56 RID: 192342 RVA: 0x00667697 File Offset: 0x00665897
		public void UnPackTo(IHideWorldMonsterAndMonsterTreasureT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602EF57 RID: 192343 RVA: 0x006676A8 File Offset: 0x006658A8
		public static Offset<IHideWorldMonsterAndMonsterTreasure> Pack(FlatBufferBuilder builder, IHideWorldMonsterAndMonsterTreasureT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHideWorldMonsterAndMonsterTreasure>);
			}
			return IHideWorldMonsterAndMonsterTreasure.CreateIHideWorldMonsterAndMonsterTreasure(builder, _o.Type);
		}

		// Token: 0x04011090 RID: 69776
		private Table __p;
	}
}
