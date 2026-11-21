using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A25 RID: 18981
	public struct ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion : IFlatbufferObject
	{
		// Token: 0x1700852D RID: 34093
		// (get) Token: 0x0601C7E2 RID: 116706 RVA: 0x00405C54 File Offset: 0x00403E54
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C7E3 RID: 116707 RVA: 0x00405C61 File Offset: 0x00403E61
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C7E4 RID: 116708 RVA: 0x00405C68 File Offset: 0x00403E68
		public static ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion GetRootAsITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion(ByteBuffer _bb)
		{
			return ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion.GetRootAsITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion(_bb, default(ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion));
		}

		// Token: 0x0601C7E5 RID: 116709 RVA: 0x00405C84 File Offset: 0x00403E84
		public static ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion GetRootAsITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion(ByteBuffer _bb, ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C7E6 RID: 116710 RVA: 0x00405CA1 File Offset: 0x00403EA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C7E7 RID: 116711 RVA: 0x00405CB0 File Offset: 0x00403EB0
		public ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700852E RID: 34094
		// (get) Token: 0x0601C7E8 RID: 116712 RVA: 0x00405CC0 File Offset: 0x00403EC0
		public ETrapDefenseSpawnMonsterCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETrapDefenseSpawnMonsterCondition.Completed;
				}
				return (ETrapDefenseSpawnMonsterCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C7E9 RID: 116713 RVA: 0x00405CFC File Offset: 0x00403EFC
		public static Offset<ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion> CreateITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion(FlatBufferBuilder builder, ETrapDefenseSpawnMonsterCondition Type = ETrapDefenseSpawnMonsterCondition.Completed)
		{
			builder.StartTable(1);
			ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion.AddType(builder, Type);
			return ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion.EndITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion(builder);
		}

		// Token: 0x0601C7EA RID: 116714 RVA: 0x00405D12 File Offset: 0x00403F12
		public static void StartITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601C7EB RID: 116715 RVA: 0x00405D1B File Offset: 0x00403F1B
		public static void AddType(FlatBufferBuilder builder, ETrapDefenseSpawnMonsterCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C7EC RID: 116716 RVA: 0x00405D26 File Offset: 0x00403F26
		public static Offset<ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion> EndITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion>(builder.EndTable());
		}

		// Token: 0x0601C7ED RID: 116717 RVA: 0x00405D34 File Offset: 0x00403F34
		public ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletionT UnPack()
		{
			ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletionT trapDefenseSpawnMonsterConditionAllOpenedIsCompletionT = new ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletionT();
			this.UnPackTo(trapDefenseSpawnMonsterConditionAllOpenedIsCompletionT);
			return trapDefenseSpawnMonsterConditionAllOpenedIsCompletionT;
		}

		// Token: 0x0601C7EE RID: 116718 RVA: 0x00405D4F File Offset: 0x00403F4F
		public void UnPackTo(ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601C7EF RID: 116719 RVA: 0x00405D60 File Offset: 0x00403F60
		public static Offset<ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion> Pack(FlatBufferBuilder builder, ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion>);
			}
			return ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion.CreateITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion(builder, _o.Type);
		}

		// Token: 0x0400D0BA RID: 53434
		private Table __p;
	}
}
