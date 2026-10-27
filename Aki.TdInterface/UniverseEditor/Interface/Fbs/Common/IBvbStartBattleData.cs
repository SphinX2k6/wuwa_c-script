using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D67 RID: 23911
	public struct IBvbStartBattleData : IFlatbufferObject
	{
		// Token: 0x1700B31C RID: 45852
		// (get) Token: 0x06028E76 RID: 167542 RVA: 0x0059E8FD File Offset: 0x0059CAFD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028E77 RID: 167543 RVA: 0x0059E90A File Offset: 0x0059CB0A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028E78 RID: 167544 RVA: 0x0059E914 File Offset: 0x0059CB14
		public static IBvbStartBattleData GetRootAsIBvbStartBattleData(ByteBuffer _bb)
		{
			return IBvbStartBattleData.GetRootAsIBvbStartBattleData(_bb, default(IBvbStartBattleData));
		}

		// Token: 0x06028E79 RID: 167545 RVA: 0x0059E930 File Offset: 0x0059CB30
		public static IBvbStartBattleData GetRootAsIBvbStartBattleData(ByteBuffer _bb, IBvbStartBattleData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028E7A RID: 167546 RVA: 0x0059E94D File Offset: 0x0059CB4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028E7B RID: 167547 RVA: 0x0059E95C File Offset: 0x0059CB5C
		public IBvbStartBattleData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B31D RID: 45853
		// (get) Token: 0x06028E7C RID: 167548 RVA: 0x0059E96C File Offset: 0x0059CB6C
		public EBvbEventName Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBvbEventName.AIEvolution;
				}
				return (EBvbEventName)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028E7D RID: 167549 RVA: 0x0059E9A8 File Offset: 0x0059CBA8
		public static Offset<IBvbStartBattleData> CreateIBvbStartBattleData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution)
		{
			builder.StartTable(1);
			IBvbStartBattleData.AddType(builder, Type);
			return IBvbStartBattleData.EndIBvbStartBattleData(builder);
		}

		// Token: 0x06028E7E RID: 167550 RVA: 0x0059E9BE File Offset: 0x0059CBBE
		public static void StartIBvbStartBattleData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06028E7F RID: 167551 RVA: 0x0059E9C7 File Offset: 0x0059CBC7
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028E80 RID: 167552 RVA: 0x0059E9D2 File Offset: 0x0059CBD2
		public static Offset<IBvbStartBattleData> EndIBvbStartBattleData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbStartBattleData>(builder.EndTable());
		}

		// Token: 0x06028E81 RID: 167553 RVA: 0x0059E9E0 File Offset: 0x0059CBE0
		public IBvbStartBattleDataT UnPack()
		{
			IBvbStartBattleDataT bvbStartBattleDataT = new IBvbStartBattleDataT();
			this.UnPackTo(bvbStartBattleDataT);
			return bvbStartBattleDataT;
		}

		// Token: 0x06028E82 RID: 167554 RVA: 0x0059E9FB File Offset: 0x0059CBFB
		public void UnPackTo(IBvbStartBattleDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06028E83 RID: 167555 RVA: 0x0059EA0C File Offset: 0x0059CC0C
		public static Offset<IBvbStartBattleData> Pack(FlatBufferBuilder builder, IBvbStartBattleDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbStartBattleData>);
			}
			return IBvbStartBattleData.CreateIBvbStartBattleData(builder, _o.Type);
		}

		// Token: 0x0400F732 RID: 63282
		private Table __p;
	}
}
