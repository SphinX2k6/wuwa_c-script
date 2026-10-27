using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D5B RID: 23899
	public struct IBvbRecycleBoardCardData : IFlatbufferObject
	{
		// Token: 0x1700B311 RID: 45841
		// (get) Token: 0x06028E32 RID: 167474 RVA: 0x0059E34D File Offset: 0x0059C54D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028E33 RID: 167475 RVA: 0x0059E35A File Offset: 0x0059C55A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028E34 RID: 167476 RVA: 0x0059E364 File Offset: 0x0059C564
		public static IBvbRecycleBoardCardData GetRootAsIBvbRecycleBoardCardData(ByteBuffer _bb)
		{
			return IBvbRecycleBoardCardData.GetRootAsIBvbRecycleBoardCardData(_bb, default(IBvbRecycleBoardCardData));
		}

		// Token: 0x06028E35 RID: 167477 RVA: 0x0059E380 File Offset: 0x0059C580
		public static IBvbRecycleBoardCardData GetRootAsIBvbRecycleBoardCardData(ByteBuffer _bb, IBvbRecycleBoardCardData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028E36 RID: 167478 RVA: 0x0059E39D File Offset: 0x0059C59D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028E37 RID: 167479 RVA: 0x0059E3AC File Offset: 0x0059C5AC
		public IBvbRecycleBoardCardData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B312 RID: 45842
		// (get) Token: 0x06028E38 RID: 167480 RVA: 0x0059E3BC File Offset: 0x0059C5BC
		public EGoalActType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGoalActType.Deploy;
				}
				return (EGoalActType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028E39 RID: 167481 RVA: 0x0059E3F8 File Offset: 0x0059C5F8
		public static Offset<IBvbRecycleBoardCardData> CreateIBvbRecycleBoardCardData(FlatBufferBuilder builder, EGoalActType Type = EGoalActType.Deploy)
		{
			builder.StartTable(1);
			IBvbRecycleBoardCardData.AddType(builder, Type);
			return IBvbRecycleBoardCardData.EndIBvbRecycleBoardCardData(builder);
		}

		// Token: 0x06028E3A RID: 167482 RVA: 0x0059E40E File Offset: 0x0059C60E
		public static void StartIBvbRecycleBoardCardData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06028E3B RID: 167483 RVA: 0x0059E417 File Offset: 0x0059C617
		public static void AddType(FlatBufferBuilder builder, EGoalActType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028E3C RID: 167484 RVA: 0x0059E422 File Offset: 0x0059C622
		public static Offset<IBvbRecycleBoardCardData> EndIBvbRecycleBoardCardData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbRecycleBoardCardData>(builder.EndTable());
		}

		// Token: 0x06028E3D RID: 167485 RVA: 0x0059E430 File Offset: 0x0059C630
		public IBvbRecycleBoardCardDataT UnPack()
		{
			IBvbRecycleBoardCardDataT bvbRecycleBoardCardDataT = new IBvbRecycleBoardCardDataT();
			this.UnPackTo(bvbRecycleBoardCardDataT);
			return bvbRecycleBoardCardDataT;
		}

		// Token: 0x06028E3E RID: 167486 RVA: 0x0059E44B File Offset: 0x0059C64B
		public void UnPackTo(IBvbRecycleBoardCardDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06028E3F RID: 167487 RVA: 0x0059E45C File Offset: 0x0059C65C
		public static Offset<IBvbRecycleBoardCardData> Pack(FlatBufferBuilder builder, IBvbRecycleBoardCardDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbRecycleBoardCardData>);
			}
			return IBvbRecycleBoardCardData.CreateIBvbRecycleBoardCardData(builder, _o.Type);
		}

		// Token: 0x0400F725 RID: 63269
		private Table __p;
	}
}
