using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004604 RID: 17924
	public struct ITakePhotoPosCondition : IFlatbufferObject
	{
		// Token: 0x17007D66 RID: 32102
		// (get) Token: 0x0601A350 RID: 107344 RVA: 0x003BB8BE File Offset: 0x003B9ABE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A351 RID: 107345 RVA: 0x003BB8CB File Offset: 0x003B9ACB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A352 RID: 107346 RVA: 0x003BB8D4 File Offset: 0x003B9AD4
		public static ITakePhotoPosCondition GetRootAsITakePhotoPosCondition(ByteBuffer _bb)
		{
			return ITakePhotoPosCondition.GetRootAsITakePhotoPosCondition(_bb, default(ITakePhotoPosCondition));
		}

		// Token: 0x0601A353 RID: 107347 RVA: 0x003BB8F0 File Offset: 0x003B9AF0
		public static ITakePhotoPosCondition GetRootAsITakePhotoPosCondition(ByteBuffer _bb, ITakePhotoPosCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A354 RID: 107348 RVA: 0x003BB90D File Offset: 0x003B9B0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A355 RID: 107349 RVA: 0x003BB91C File Offset: 0x003B9B1C
		public ITakePhotoPosCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007D67 RID: 32103
		// (get) Token: 0x0601A356 RID: 107350 RVA: 0x003BB92C File Offset: 0x003B9B2C
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

		// Token: 0x17007D68 RID: 32104
		// (get) Token: 0x0601A357 RID: 107351 RVA: 0x003BB968 File Offset: 0x003B9B68
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

		// Token: 0x0601A358 RID: 107352 RVA: 0x003BB99F File Offset: 0x003B9B9F
		public Span<byte> GetTidDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601A359 RID: 107353 RVA: 0x003BB9AE File Offset: 0x003B9BAE
		public byte[] GetTidDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601A35A RID: 107354 RVA: 0x003BB9BC File Offset: 0x003B9BBC
		public static Offset<ITakePhotoPosCondition> CreateITakePhotoPosCondition(FlatBufferBuilder builder, int RangeEntity = 0, StringOffset TidDescriptionOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ITakePhotoPosCondition.AddTidDescription(builder, TidDescriptionOffset);
			ITakePhotoPosCondition.AddRangeEntity(builder, RangeEntity);
			return ITakePhotoPosCondition.EndITakePhotoPosCondition(builder);
		}

		// Token: 0x0601A35B RID: 107355 RVA: 0x003BB9D9 File Offset: 0x003B9BD9
		public static void StartITakePhotoPosCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601A35C RID: 107356 RVA: 0x003BB9E2 File Offset: 0x003B9BE2
		public static void AddRangeEntity(FlatBufferBuilder builder, int rangeEntity)
		{
			builder.AddInt(0, rangeEntity, 0);
		}

		// Token: 0x0601A35D RID: 107357 RVA: 0x003BB9ED File Offset: 0x003B9BED
		public static void AddTidDescription(FlatBufferBuilder builder, StringOffset tidDescriptionOffset)
		{
			builder.AddOffset(1, tidDescriptionOffset.Value, 0);
		}

		// Token: 0x0601A35E RID: 107358 RVA: 0x003BB9FD File Offset: 0x003B9BFD
		public static Offset<ITakePhotoPosCondition> EndITakePhotoPosCondition(FlatBufferBuilder builder)
		{
			return new Offset<ITakePhotoPosCondition>(builder.EndTable());
		}

		// Token: 0x0601A35F RID: 107359 RVA: 0x003BBA0C File Offset: 0x003B9C0C
		public ITakePhotoPosConditionT UnPack()
		{
			ITakePhotoPosConditionT takePhotoPosConditionT = new ITakePhotoPosConditionT();
			this.UnPackTo(takePhotoPosConditionT);
			return takePhotoPosConditionT;
		}

		// Token: 0x0601A360 RID: 107360 RVA: 0x003BBA27 File Offset: 0x003B9C27
		public void UnPackTo(ITakePhotoPosConditionT _o)
		{
			_o.RangeEntity = this.RangeEntity;
			_o.TidDescription = this.TidDescription;
		}

		// Token: 0x0601A361 RID: 107361 RVA: 0x003BBA44 File Offset: 0x003B9C44
		public static Offset<ITakePhotoPosCondition> Pack(FlatBufferBuilder builder, ITakePhotoPosConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITakePhotoPosCondition>);
			}
			StringOffset tidDescriptionOffset = (_o.TidDescription == null) ? default(StringOffset) : builder.CreateString(_o.TidDescription);
			return ITakePhotoPosCondition.CreateITakePhotoPosCondition(builder, _o.RangeEntity, tidDescriptionOffset);
		}

		// Token: 0x0400C7F5 RID: 51189
		private Table __p;
	}
}
