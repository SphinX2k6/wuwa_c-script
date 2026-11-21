using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x02004827 RID: 18471
	public struct IScreenResourceOccupationData : IFlatbufferObject
	{
		// Token: 0x170080E4 RID: 32996
		// (get) Token: 0x0601B57B RID: 111995 RVA: 0x003DF9EE File Offset: 0x003DDBEE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B57C RID: 111996 RVA: 0x003DF9FB File Offset: 0x003DDBFB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B57D RID: 111997 RVA: 0x003DFA04 File Offset: 0x003DDC04
		public static IScreenResourceOccupationData GetRootAsIScreenResourceOccupationData(ByteBuffer _bb)
		{
			return IScreenResourceOccupationData.GetRootAsIScreenResourceOccupationData(_bb, default(IScreenResourceOccupationData));
		}

		// Token: 0x0601B57E RID: 111998 RVA: 0x003DFA20 File Offset: 0x003DDC20
		public static IScreenResourceOccupationData GetRootAsIScreenResourceOccupationData(ByteBuffer _bb, IScreenResourceOccupationData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B57F RID: 111999 RVA: 0x003DFA3D File Offset: 0x003DDC3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B580 RID: 112000 RVA: 0x003DFA4C File Offset: 0x003DDC4C
		public IScreenResourceOccupationData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170080E5 RID: 32997
		// (get) Token: 0x0601B581 RID: 112001 RVA: 0x003DFA5C File Offset: 0x003DDC5C
		public EOccupationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EOccupationType.Npc;
				}
				return (EOccupationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B582 RID: 112002 RVA: 0x003DFA98 File Offset: 0x003DDC98
		public static Offset<IScreenResourceOccupationData> CreateIScreenResourceOccupationData(FlatBufferBuilder builder, EOccupationType Type = EOccupationType.Npc)
		{
			builder.StartTable(1);
			IScreenResourceOccupationData.AddType(builder, Type);
			return IScreenResourceOccupationData.EndIScreenResourceOccupationData(builder);
		}

		// Token: 0x0601B583 RID: 112003 RVA: 0x003DFAAE File Offset: 0x003DDCAE
		public static void StartIScreenResourceOccupationData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601B584 RID: 112004 RVA: 0x003DFAB7 File Offset: 0x003DDCB7
		public static void AddType(FlatBufferBuilder builder, EOccupationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B585 RID: 112005 RVA: 0x003DFAC2 File Offset: 0x003DDCC2
		public static Offset<IScreenResourceOccupationData> EndIScreenResourceOccupationData(FlatBufferBuilder builder)
		{
			return new Offset<IScreenResourceOccupationData>(builder.EndTable());
		}

		// Token: 0x0601B586 RID: 112006 RVA: 0x003DFAD0 File Offset: 0x003DDCD0
		public IScreenResourceOccupationDataT UnPack()
		{
			IScreenResourceOccupationDataT screenResourceOccupationDataT = new IScreenResourceOccupationDataT();
			this.UnPackTo(screenResourceOccupationDataT);
			return screenResourceOccupationDataT;
		}

		// Token: 0x0601B587 RID: 112007 RVA: 0x003DFAEB File Offset: 0x003DDCEB
		public void UnPackTo(IScreenResourceOccupationDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601B588 RID: 112008 RVA: 0x003DFAFC File Offset: 0x003DDCFC
		public static Offset<IScreenResourceOccupationData> Pack(FlatBufferBuilder builder, IScreenResourceOccupationDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IScreenResourceOccupationData>);
			}
			return IScreenResourceOccupationData.CreateIScreenResourceOccupationData(builder, _o.Type);
		}

		// Token: 0x0400CC33 RID: 52275
		private Table __p;
	}
}
