using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004559 RID: 17753
	public struct ISheriffReasoningBoardConfig : IFlatbufferObject
	{
		// Token: 0x17007C0A RID: 31754
		// (get) Token: 0x06019D0A RID: 105738 RVA: 0x003AF0AA File Offset: 0x003AD2AA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019D0B RID: 105739 RVA: 0x003AF0B7 File Offset: 0x003AD2B7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019D0C RID: 105740 RVA: 0x003AF0C0 File Offset: 0x003AD2C0
		public static ISheriffReasoningBoardConfig GetRootAsISheriffReasoningBoardConfig(ByteBuffer _bb)
		{
			return ISheriffReasoningBoardConfig.GetRootAsISheriffReasoningBoardConfig(_bb, default(ISheriffReasoningBoardConfig));
		}

		// Token: 0x06019D0D RID: 105741 RVA: 0x003AF0DC File Offset: 0x003AD2DC
		public static ISheriffReasoningBoardConfig GetRootAsISheriffReasoningBoardConfig(ByteBuffer _bb, ISheriffReasoningBoardConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019D0E RID: 105742 RVA: 0x003AF0F9 File Offset: 0x003AD2F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019D0F RID: 105743 RVA: 0x003AF108 File Offset: 0x003AD308
		public ISheriffReasoningBoardConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007C0B RID: 31755
		// (get) Token: 0x06019D10 RID: 105744 RVA: 0x003AF118 File Offset: 0x003AD318
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019D11 RID: 105745 RVA: 0x003AF154 File Offset: 0x003AD354
		public static Offset<ISheriffReasoningBoardConfig> CreateISheriffReasoningBoardConfig(FlatBufferBuilder builder, int Id = 0)
		{
			builder.StartTable(1);
			ISheriffReasoningBoardConfig.AddId(builder, Id);
			return ISheriffReasoningBoardConfig.EndISheriffReasoningBoardConfig(builder);
		}

		// Token: 0x06019D12 RID: 105746 RVA: 0x003AF16A File Offset: 0x003AD36A
		public static void StartISheriffReasoningBoardConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06019D13 RID: 105747 RVA: 0x003AF173 File Offset: 0x003AD373
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x06019D14 RID: 105748 RVA: 0x003AF17E File Offset: 0x003AD37E
		public static Offset<ISheriffReasoningBoardConfig> EndISheriffReasoningBoardConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISheriffReasoningBoardConfig>(builder.EndTable());
		}

		// Token: 0x06019D15 RID: 105749 RVA: 0x003AF18C File Offset: 0x003AD38C
		public ISheriffReasoningBoardConfigT UnPack()
		{
			ISheriffReasoningBoardConfigT sheriffReasoningBoardConfigT = new ISheriffReasoningBoardConfigT();
			this.UnPackTo(sheriffReasoningBoardConfigT);
			return sheriffReasoningBoardConfigT;
		}

		// Token: 0x06019D16 RID: 105750 RVA: 0x003AF1A7 File Offset: 0x003AD3A7
		public void UnPackTo(ISheriffReasoningBoardConfigT _o)
		{
			_o.Id = this.Id;
		}

		// Token: 0x06019D17 RID: 105751 RVA: 0x003AF1B8 File Offset: 0x003AD3B8
		public static Offset<ISheriffReasoningBoardConfig> Pack(FlatBufferBuilder builder, ISheriffReasoningBoardConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISheriffReasoningBoardConfig>);
			}
			return ISheriffReasoningBoardConfig.CreateISheriffReasoningBoardConfig(builder, _o.Id);
		}

		// Token: 0x0400C6ED RID: 50925
		private Table __p;
	}
}
