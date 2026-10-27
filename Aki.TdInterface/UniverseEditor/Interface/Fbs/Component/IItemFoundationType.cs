using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005497 RID: 21655
	public struct IItemFoundationType : IFlatbufferObject
	{
		// Token: 0x17009F79 RID: 40825
		// (get) Token: 0x06023A46 RID: 145990 RVA: 0x004ED9EC File Offset: 0x004EBBEC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023A47 RID: 145991 RVA: 0x004ED9F9 File Offset: 0x004EBBF9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023A48 RID: 145992 RVA: 0x004EDA00 File Offset: 0x004EBC00
		public static IItemFoundationType GetRootAsIItemFoundationType(ByteBuffer _bb)
		{
			return IItemFoundationType.GetRootAsIItemFoundationType(_bb, default(IItemFoundationType));
		}

		// Token: 0x06023A49 RID: 145993 RVA: 0x004EDA1C File Offset: 0x004EBC1C
		public static IItemFoundationType GetRootAsIItemFoundationType(ByteBuffer _bb, IItemFoundationType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023A4A RID: 145994 RVA: 0x004EDA39 File Offset: 0x004EBC39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023A4B RID: 145995 RVA: 0x004EDA48 File Offset: 0x004EBC48
		public IItemFoundationType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009F7A RID: 40826
		// (get) Token: 0x06023A4C RID: 145996 RVA: 0x004EDA58 File Offset: 0x004EBC58
		public EItemFoundation Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EItemFoundation.CategoryMatching;
				}
				return (EItemFoundation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023A4D RID: 145997 RVA: 0x004EDA94 File Offset: 0x004EBC94
		public static Offset<IItemFoundationType> CreateIItemFoundationType(FlatBufferBuilder builder, EItemFoundation Type = EItemFoundation.CategoryMatching)
		{
			builder.StartTable(1);
			IItemFoundationType.AddType(builder, Type);
			return IItemFoundationType.EndIItemFoundationType(builder);
		}

		// Token: 0x06023A4E RID: 145998 RVA: 0x004EDAAA File Offset: 0x004EBCAA
		public static void StartIItemFoundationType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06023A4F RID: 145999 RVA: 0x004EDAB3 File Offset: 0x004EBCB3
		public static void AddType(FlatBufferBuilder builder, EItemFoundation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023A50 RID: 146000 RVA: 0x004EDABE File Offset: 0x004EBCBE
		public static Offset<IItemFoundationType> EndIItemFoundationType(FlatBufferBuilder builder)
		{
			return new Offset<IItemFoundationType>(builder.EndTable());
		}

		// Token: 0x06023A51 RID: 146001 RVA: 0x004EDACC File Offset: 0x004EBCCC
		public IItemFoundationTypeT UnPack()
		{
			IItemFoundationTypeT itemFoundationTypeT = new IItemFoundationTypeT();
			this.UnPackTo(itemFoundationTypeT);
			return itemFoundationTypeT;
		}

		// Token: 0x06023A52 RID: 146002 RVA: 0x004EDAE7 File Offset: 0x004EBCE7
		public void UnPackTo(IItemFoundationTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06023A53 RID: 146003 RVA: 0x004EDAF8 File Offset: 0x004EBCF8
		public static Offset<IItemFoundationType> Pack(FlatBufferBuilder builder, IItemFoundationTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IItemFoundationType>);
			}
			return IItemFoundationType.CreateIItemFoundationType(builder, _o.Type);
		}

		// Token: 0x0400E72D RID: 59181
		private Table __p;
	}
}
