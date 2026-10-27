using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041AB RID: 16811
	public struct ITakePhotoPosCondition : IFlatbufferObject
	{
		// Token: 0x1700773A RID: 30522
		// (get) Token: 0x06018BFA RID: 101370 RVA: 0x0039046A File Offset: 0x0038E66A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018BFB RID: 101371 RVA: 0x00390477 File Offset: 0x0038E677
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018BFC RID: 101372 RVA: 0x00390480 File Offset: 0x0038E680
		public static ITakePhotoPosCondition GetRootAsITakePhotoPosCondition(ByteBuffer _bb)
		{
			return ITakePhotoPosCondition.GetRootAsITakePhotoPosCondition(_bb, default(ITakePhotoPosCondition));
		}

		// Token: 0x06018BFD RID: 101373 RVA: 0x0039049C File Offset: 0x0038E69C
		public static ITakePhotoPosCondition GetRootAsITakePhotoPosCondition(ByteBuffer _bb, ITakePhotoPosCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018BFE RID: 101374 RVA: 0x003904B9 File Offset: 0x0038E6B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018BFF RID: 101375 RVA: 0x003904C8 File Offset: 0x0038E6C8
		public ITakePhotoPosCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700773B RID: 30523
		// (get) Token: 0x06018C00 RID: 101376 RVA: 0x003904D8 File Offset: 0x0038E6D8
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

		// Token: 0x1700773C RID: 30524
		// (get) Token: 0x06018C01 RID: 101377 RVA: 0x00390514 File Offset: 0x0038E714
		public string TidDescription
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018C02 RID: 101378 RVA: 0x0039054B File Offset: 0x0038E74B
		public Span<byte> GetTidDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06018C03 RID: 101379 RVA: 0x0039055A File Offset: 0x0038E75A
		public byte[] GetTidDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06018C04 RID: 101380 RVA: 0x00390568 File Offset: 0x0038E768
		public static Offset<ITakePhotoPosCondition> CreateITakePhotoPosCondition(FlatBufferBuilder builder, int RangeEntity = 0, StringOffset TidDescriptionOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ITakePhotoPosCondition.AddTidDescription(builder, TidDescriptionOffset);
			ITakePhotoPosCondition.AddRangeEntity(builder, RangeEntity);
			return ITakePhotoPosCondition.EndITakePhotoPosCondition(builder);
		}

		// Token: 0x06018C05 RID: 101381 RVA: 0x00390585 File Offset: 0x0038E785
		public static void StartITakePhotoPosCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06018C06 RID: 101382 RVA: 0x0039058E File Offset: 0x0038E78E
		public static void AddRangeEntity(FlatBufferBuilder builder, int rangeEntity)
		{
			builder.AddInt(0, rangeEntity, 0);
		}

		// Token: 0x06018C07 RID: 101383 RVA: 0x00390599 File Offset: 0x0038E799
		public static void AddTidDescription(FlatBufferBuilder builder, StringOffset tidDescriptionOffset)
		{
			builder.AddOffset(1, tidDescriptionOffset.Value, 0);
		}

		// Token: 0x06018C08 RID: 101384 RVA: 0x003905A9 File Offset: 0x0038E7A9
		public static Offset<ITakePhotoPosCondition> EndITakePhotoPosCondition(FlatBufferBuilder builder)
		{
			return new Offset<ITakePhotoPosCondition>(builder.EndTable());
		}

		// Token: 0x06018C09 RID: 101385 RVA: 0x003905B8 File Offset: 0x0038E7B8
		public ITakePhotoPosConditionT UnPack()
		{
			ITakePhotoPosConditionT takePhotoPosConditionT = new ITakePhotoPosConditionT();
			this.UnPackTo(takePhotoPosConditionT);
			return takePhotoPosConditionT;
		}

		// Token: 0x06018C0A RID: 101386 RVA: 0x003905D3 File Offset: 0x0038E7D3
		public void UnPackTo(ITakePhotoPosConditionT _o)
		{
			_o.RangeEntity = this.RangeEntity;
			_o.TidDescription = this.TidDescription;
		}

		// Token: 0x06018C0B RID: 101387 RVA: 0x003905F0 File Offset: 0x0038E7F0
		public static Offset<ITakePhotoPosCondition> Pack(FlatBufferBuilder builder, ITakePhotoPosConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITakePhotoPosCondition>);
			}
			StringOffset tidDescriptionOffset = (_o.TidDescription == null) ? default(StringOffset) : builder.CreateString(_o.TidDescription);
			return ITakePhotoPosCondition.CreateITakePhotoPosCondition(builder, _o.RangeEntity, tidDescriptionOffset);
		}

		// Token: 0x0400BDEB RID: 48619
		private Table __p;
	}
}
