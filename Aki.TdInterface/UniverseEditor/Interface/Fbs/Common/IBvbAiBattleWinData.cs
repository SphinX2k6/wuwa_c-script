using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D1C RID: 23836
	public struct IBvbAiBattleWinData : IFlatbufferObject
	{
		// Token: 0x1700B2A7 RID: 45735
		// (get) Token: 0x06028BAF RID: 166831 RVA: 0x005980CC File Offset: 0x005962CC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028BB0 RID: 166832 RVA: 0x005980D9 File Offset: 0x005962D9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028BB1 RID: 166833 RVA: 0x005980E0 File Offset: 0x005962E0
		public static IBvbAiBattleWinData GetRootAsIBvbAiBattleWinData(ByteBuffer _bb)
		{
			return IBvbAiBattleWinData.GetRootAsIBvbAiBattleWinData(_bb, default(IBvbAiBattleWinData));
		}

		// Token: 0x06028BB2 RID: 166834 RVA: 0x005980FC File Offset: 0x005962FC
		public static IBvbAiBattleWinData GetRootAsIBvbAiBattleWinData(ByteBuffer _bb, IBvbAiBattleWinData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028BB3 RID: 166835 RVA: 0x00598119 File Offset: 0x00596319
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028BB4 RID: 166836 RVA: 0x00598128 File Offset: 0x00596328
		public IBvbAiBattleWinData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B2A8 RID: 45736
		// (get) Token: 0x06028BB5 RID: 166837 RVA: 0x00598138 File Offset: 0x00596338
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

		// Token: 0x06028BB6 RID: 166838 RVA: 0x00598174 File Offset: 0x00596374
		public static Offset<IBvbAiBattleWinData> CreateIBvbAiBattleWinData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution)
		{
			builder.StartTable(1);
			IBvbAiBattleWinData.AddType(builder, Type);
			return IBvbAiBattleWinData.EndIBvbAiBattleWinData(builder);
		}

		// Token: 0x06028BB7 RID: 166839 RVA: 0x0059818A File Offset: 0x0059638A
		public static void StartIBvbAiBattleWinData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06028BB8 RID: 166840 RVA: 0x00598193 File Offset: 0x00596393
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028BB9 RID: 166841 RVA: 0x0059819E File Offset: 0x0059639E
		public static Offset<IBvbAiBattleWinData> EndIBvbAiBattleWinData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbAiBattleWinData>(builder.EndTable());
		}

		// Token: 0x06028BBA RID: 166842 RVA: 0x005981AC File Offset: 0x005963AC
		public IBvbAiBattleWinDataT UnPack()
		{
			IBvbAiBattleWinDataT bvbAiBattleWinDataT = new IBvbAiBattleWinDataT();
			this.UnPackTo(bvbAiBattleWinDataT);
			return bvbAiBattleWinDataT;
		}

		// Token: 0x06028BBB RID: 166843 RVA: 0x005981C7 File Offset: 0x005963C7
		public void UnPackTo(IBvbAiBattleWinDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06028BBC RID: 166844 RVA: 0x005981D8 File Offset: 0x005963D8
		public static Offset<IBvbAiBattleWinData> Pack(FlatBufferBuilder builder, IBvbAiBattleWinDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbAiBattleWinData>);
			}
			return IBvbAiBattleWinData.CreateIBvbAiBattleWinData(builder, _o.Type);
		}

		// Token: 0x0400F6CA RID: 63178
		private Table __p;
	}
}
