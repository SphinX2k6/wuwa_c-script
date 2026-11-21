using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FC5 RID: 28613
	public struct IHideWorldMonsterAndMonsterTreasure : IFlatbufferObject
	{
		// Token: 0x1700D19D RID: 53661
		// (get) Token: 0x0603191A RID: 203034 RVA: 0x006B7A82 File Offset: 0x006B5C82
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603191B RID: 203035 RVA: 0x006B7A8F File Offset: 0x006B5C8F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603191C RID: 203036 RVA: 0x006B7A98 File Offset: 0x006B5C98
		public static IHideWorldMonsterAndMonsterTreasure GetRootAsIHideWorldMonsterAndMonsterTreasure(ByteBuffer _bb)
		{
			return IHideWorldMonsterAndMonsterTreasure.GetRootAsIHideWorldMonsterAndMonsterTreasure(_bb, default(IHideWorldMonsterAndMonsterTreasure));
		}

		// Token: 0x0603191D RID: 203037 RVA: 0x006B7AB4 File Offset: 0x006B5CB4
		public static IHideWorldMonsterAndMonsterTreasure GetRootAsIHideWorldMonsterAndMonsterTreasure(ByteBuffer _bb, IHideWorldMonsterAndMonsterTreasure obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603191E RID: 203038 RVA: 0x006B7AD1 File Offset: 0x006B5CD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603191F RID: 203039 RVA: 0x006B7AE0 File Offset: 0x006B5CE0
		public IHideWorldMonsterAndMonsterTreasure __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D19E RID: 53662
		// (get) Token: 0x06031920 RID: 203040 RVA: 0x006B7AF0 File Offset: 0x006B5CF0
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

		// Token: 0x06031921 RID: 203041 RVA: 0x006B7B2C File Offset: 0x006B5D2C
		public static Offset<IHideWorldMonsterAndMonsterTreasure> CreateIHideWorldMonsterAndMonsterTreasure(FlatBufferBuilder builder, EHideType Type = EHideType.WorldMonsterAndMonsterTreasure)
		{
			builder.StartTable(1);
			IHideWorldMonsterAndMonsterTreasure.AddType(builder, Type);
			return IHideWorldMonsterAndMonsterTreasure.EndIHideWorldMonsterAndMonsterTreasure(builder);
		}

		// Token: 0x06031922 RID: 203042 RVA: 0x006B7B42 File Offset: 0x006B5D42
		public static void StartIHideWorldMonsterAndMonsterTreasure(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031923 RID: 203043 RVA: 0x006B7B4B File Offset: 0x006B5D4B
		public static void AddType(FlatBufferBuilder builder, EHideType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031924 RID: 203044 RVA: 0x006B7B56 File Offset: 0x006B5D56
		public static Offset<IHideWorldMonsterAndMonsterTreasure> EndIHideWorldMonsterAndMonsterTreasure(FlatBufferBuilder builder)
		{
			return new Offset<IHideWorldMonsterAndMonsterTreasure>(builder.EndTable());
		}

		// Token: 0x06031925 RID: 203045 RVA: 0x006B7B64 File Offset: 0x006B5D64
		public IHideWorldMonsterAndMonsterTreasureT UnPack()
		{
			IHideWorldMonsterAndMonsterTreasureT hideWorldMonsterAndMonsterTreasureT = new IHideWorldMonsterAndMonsterTreasureT();
			this.UnPackTo(hideWorldMonsterAndMonsterTreasureT);
			return hideWorldMonsterAndMonsterTreasureT;
		}

		// Token: 0x06031926 RID: 203046 RVA: 0x006B7B7F File Offset: 0x006B5D7F
		public void UnPackTo(IHideWorldMonsterAndMonsterTreasureT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06031927 RID: 203047 RVA: 0x006B7B90 File Offset: 0x006B5D90
		public static Offset<IHideWorldMonsterAndMonsterTreasure> Pack(FlatBufferBuilder builder, IHideWorldMonsterAndMonsterTreasureT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHideWorldMonsterAndMonsterTreasure>);
			}
			return IHideWorldMonsterAndMonsterTreasure.CreateIHideWorldMonsterAndMonsterTreasure(builder, _o.Type);
		}

		// Token: 0x04011EFC RID: 73468
		private Table __p;
	}
}
