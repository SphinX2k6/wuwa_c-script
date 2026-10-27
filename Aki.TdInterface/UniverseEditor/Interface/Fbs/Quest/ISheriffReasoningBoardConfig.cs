using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004118 RID: 16664
	public struct ISheriffReasoningBoardConfig : IFlatbufferObject
	{
		// Token: 0x17007604 RID: 30212
		// (get) Token: 0x06018667 RID: 99943 RVA: 0x003850A2 File Offset: 0x003832A2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018668 RID: 99944 RVA: 0x003850AF File Offset: 0x003832AF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018669 RID: 99945 RVA: 0x003850B8 File Offset: 0x003832B8
		public static ISheriffReasoningBoardConfig GetRootAsISheriffReasoningBoardConfig(ByteBuffer _bb)
		{
			return ISheriffReasoningBoardConfig.GetRootAsISheriffReasoningBoardConfig(_bb, default(ISheriffReasoningBoardConfig));
		}

		// Token: 0x0601866A RID: 99946 RVA: 0x003850D4 File Offset: 0x003832D4
		public static ISheriffReasoningBoardConfig GetRootAsISheriffReasoningBoardConfig(ByteBuffer _bb, ISheriffReasoningBoardConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601866B RID: 99947 RVA: 0x003850F1 File Offset: 0x003832F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601866C RID: 99948 RVA: 0x00385100 File Offset: 0x00383300
		public ISheriffReasoningBoardConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007605 RID: 30213
		// (get) Token: 0x0601866D RID: 99949 RVA: 0x00385110 File Offset: 0x00383310
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

		// Token: 0x0601866E RID: 99950 RVA: 0x0038514C File Offset: 0x0038334C
		public static Offset<ISheriffReasoningBoardConfig> CreateISheriffReasoningBoardConfig(FlatBufferBuilder builder, int Id = 0)
		{
			builder.StartTable(1);
			ISheriffReasoningBoardConfig.AddId(builder, Id);
			return ISheriffReasoningBoardConfig.EndISheriffReasoningBoardConfig(builder);
		}

		// Token: 0x0601866F RID: 99951 RVA: 0x00385162 File Offset: 0x00383362
		public static void StartISheriffReasoningBoardConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06018670 RID: 99952 RVA: 0x0038516B File Offset: 0x0038336B
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x06018671 RID: 99953 RVA: 0x00385176 File Offset: 0x00383376
		public static Offset<ISheriffReasoningBoardConfig> EndISheriffReasoningBoardConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISheriffReasoningBoardConfig>(builder.EndTable());
		}

		// Token: 0x06018672 RID: 99954 RVA: 0x00385184 File Offset: 0x00383384
		public ISheriffReasoningBoardConfigT UnPack()
		{
			ISheriffReasoningBoardConfigT sheriffReasoningBoardConfigT = new ISheriffReasoningBoardConfigT();
			this.UnPackTo(sheriffReasoningBoardConfigT);
			return sheriffReasoningBoardConfigT;
		}

		// Token: 0x06018673 RID: 99955 RVA: 0x0038519F File Offset: 0x0038339F
		public void UnPackTo(ISheriffReasoningBoardConfigT _o)
		{
			_o.Id = this.Id;
		}

		// Token: 0x06018674 RID: 99956 RVA: 0x003851B0 File Offset: 0x003833B0
		public static Offset<ISheriffReasoningBoardConfig> Pack(FlatBufferBuilder builder, ISheriffReasoningBoardConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISheriffReasoningBoardConfig>);
			}
			return ISheriffReasoningBoardConfig.CreateISheriffReasoningBoardConfig(builder, _o.Id);
		}

		// Token: 0x0400BD04 RID: 48388
		private Table __p;
	}
}
