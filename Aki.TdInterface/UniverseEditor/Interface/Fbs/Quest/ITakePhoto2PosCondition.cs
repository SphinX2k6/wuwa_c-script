using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004184 RID: 16772
	public struct ITakePhoto2PosCondition : IFlatbufferObject
	{
		// Token: 0x170076E8 RID: 30440
		// (get) Token: 0x06018A9F RID: 101023 RVA: 0x0038D8EC File Offset: 0x0038BAEC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018AA0 RID: 101024 RVA: 0x0038D8F9 File Offset: 0x0038BAF9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018AA1 RID: 101025 RVA: 0x0038D900 File Offset: 0x0038BB00
		public static ITakePhoto2PosCondition GetRootAsITakePhoto2PosCondition(ByteBuffer _bb)
		{
			return ITakePhoto2PosCondition.GetRootAsITakePhoto2PosCondition(_bb, default(ITakePhoto2PosCondition));
		}

		// Token: 0x06018AA2 RID: 101026 RVA: 0x0038D91C File Offset: 0x0038BB1C
		public static ITakePhoto2PosCondition GetRootAsITakePhoto2PosCondition(ByteBuffer _bb, ITakePhoto2PosCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018AA3 RID: 101027 RVA: 0x0038D939 File Offset: 0x0038BB39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018AA4 RID: 101028 RVA: 0x0038D948 File Offset: 0x0038BB48
		public ITakePhoto2PosCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170076E9 RID: 30441
		// (get) Token: 0x06018AA5 RID: 101029 RVA: 0x0038D958 File Offset: 0x0038BB58
		public int RangeEntity
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

		// Token: 0x06018AA6 RID: 101030 RVA: 0x0038D994 File Offset: 0x0038BB94
		public static Offset<ITakePhoto2PosCondition> CreateITakePhoto2PosCondition(FlatBufferBuilder builder, int RangeEntity = 0)
		{
			builder.StartTable(1);
			ITakePhoto2PosCondition.AddRangeEntity(builder, RangeEntity);
			return ITakePhoto2PosCondition.EndITakePhoto2PosCondition(builder);
		}

		// Token: 0x06018AA7 RID: 101031 RVA: 0x0038D9AA File Offset: 0x0038BBAA
		public static void StartITakePhoto2PosCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06018AA8 RID: 101032 RVA: 0x0038D9B3 File Offset: 0x0038BBB3
		public static void AddRangeEntity(FlatBufferBuilder builder, int rangeEntity)
		{
			builder.AddInt(0, rangeEntity, 0);
		}

		// Token: 0x06018AA9 RID: 101033 RVA: 0x0038D9BE File Offset: 0x0038BBBE
		public static Offset<ITakePhoto2PosCondition> EndITakePhoto2PosCondition(FlatBufferBuilder builder)
		{
			return new Offset<ITakePhoto2PosCondition>(builder.EndTable());
		}

		// Token: 0x06018AAA RID: 101034 RVA: 0x0038D9CC File Offset: 0x0038BBCC
		public ITakePhoto2PosConditionT UnPack()
		{
			ITakePhoto2PosConditionT takePhoto2PosConditionT = new ITakePhoto2PosConditionT();
			this.UnPackTo(takePhoto2PosConditionT);
			return takePhoto2PosConditionT;
		}

		// Token: 0x06018AAB RID: 101035 RVA: 0x0038D9E7 File Offset: 0x0038BBE7
		public void UnPackTo(ITakePhoto2PosConditionT _o)
		{
			_o.RangeEntity = this.RangeEntity;
		}

		// Token: 0x06018AAC RID: 101036 RVA: 0x0038D9F8 File Offset: 0x0038BBF8
		public static Offset<ITakePhoto2PosCondition> Pack(FlatBufferBuilder builder, ITakePhoto2PosConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITakePhoto2PosCondition>);
			}
			return ITakePhoto2PosCondition.CreateITakePhoto2PosCondition(builder, _o.RangeEntity);
		}

		// Token: 0x0400BDB4 RID: 48564
		private Table __p;
	}
}
