using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x020046E8 RID: 18152
	public struct IEntityClientRunningData : IFlatbufferObject
	{
		// Token: 0x1700819C RID: 33180
		// (get) Token: 0x0601BBFF RID: 113663 RVA: 0x003EF169 File Offset: 0x003ED369
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BC00 RID: 113664 RVA: 0x003EF176 File Offset: 0x003ED376
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BC01 RID: 113665 RVA: 0x003EF180 File Offset: 0x003ED380
		public static IEntityClientRunningData GetRootAsIEntityClientRunningData(ByteBuffer _bb)
		{
			return IEntityClientRunningData.GetRootAsIEntityClientRunningData(_bb, default(IEntityClientRunningData));
		}

		// Token: 0x0601BC02 RID: 113666 RVA: 0x003EF19C File Offset: 0x003ED39C
		public static IEntityClientRunningData GetRootAsIEntityClientRunningData(ByteBuffer _bb, IEntityClientRunningData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BC03 RID: 113667 RVA: 0x003EF1B9 File Offset: 0x003ED3B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BC04 RID: 113668 RVA: 0x003EF1C8 File Offset: 0x003ED3C8
		public IEntityClientRunningData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700819D RID: 33181
		// (get) Token: 0x0601BC05 RID: 113669 RVA: 0x003EF1D8 File Offset: 0x003ED3D8
		public int ConfigId
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

		// Token: 0x1700819E RID: 33182
		// (get) Token: 0x0601BC06 RID: 113670 RVA: 0x003EF214 File Offset: 0x003ED414
		public EEntityClientCreateState CreateState
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EEntityClientCreateState.None;
				}
				return (EEntityClientCreateState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700819F RID: 33183
		// (get) Token: 0x0601BC07 RID: 113671 RVA: 0x003EF250 File Offset: 0x003ED450
		public string Reason
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BC08 RID: 113672 RVA: 0x003EF287 File Offset: 0x003ED487
		public Span<byte> GetReasonBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601BC09 RID: 113673 RVA: 0x003EF296 File Offset: 0x003ED496
		public byte[] GetReasonArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x170081A0 RID: 33184
		// (get) Token: 0x0601BC0A RID: 113674 RVA: 0x003EF2A4 File Offset: 0x003ED4A4
		public bool IsClientVisible
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170081A1 RID: 33185
		// (get) Token: 0x0601BC0B RID: 113675 RVA: 0x003EF2E4 File Offset: 0x003ED4E4
		public bool IsInRange
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170081A2 RID: 33186
		// (get) Token: 0x0601BC0C RID: 113676 RVA: 0x003EF324 File Offset: 0x003ED524
		public string Tags
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BC0D RID: 113677 RVA: 0x003EF35C File Offset: 0x003ED55C
		public Span<byte> GetTagsBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0601BC0E RID: 113678 RVA: 0x003EF36C File Offset: 0x003ED56C
		public byte[] GetTagsArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x170081A3 RID: 33187
		// (get) Token: 0x0601BC0F RID: 113679 RVA: 0x003EF37C File Offset: 0x003ED57C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BC10 RID: 113680 RVA: 0x003EF3BC File Offset: 0x003ED5BC
		public static Offset<IEntityClientRunningData> CreateIEntityClientRunningData(FlatBufferBuilder builder, int ConfigId = 0, EEntityClientCreateState CreateState = EEntityClientCreateState.None, StringOffset ReasonOffset = default(StringOffset), bool IsClientVisible = false, bool IsInRange = false, StringOffset TagsOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(7);
			IEntityClientRunningData.AddTags(builder, TagsOffset);
			IEntityClientRunningData.AddReason(builder, ReasonOffset);
			IEntityClientRunningData.AddConfigId(builder, ConfigId);
			IEntityClientRunningData.AddNullMask(builder, NullMask);
			IEntityClientRunningData.AddIsInRange(builder, IsInRange);
			IEntityClientRunningData.AddIsClientVisible(builder, IsClientVisible);
			IEntityClientRunningData.AddCreateState(builder, CreateState);
			return IEntityClientRunningData.EndIEntityClientRunningData(builder);
		}

		// Token: 0x0601BC11 RID: 113681 RVA: 0x003EF40B File Offset: 0x003ED60B
		public static void StartIEntityClientRunningData(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601BC12 RID: 113682 RVA: 0x003EF414 File Offset: 0x003ED614
		public static void AddConfigId(FlatBufferBuilder builder, int configId)
		{
			builder.AddInt(0, configId, 0);
		}

		// Token: 0x0601BC13 RID: 113683 RVA: 0x003EF41F File Offset: 0x003ED61F
		public static void AddCreateState(FlatBufferBuilder builder, EEntityClientCreateState createState)
		{
			builder.AddByte(1, (byte)createState, 0);
		}

		// Token: 0x0601BC14 RID: 113684 RVA: 0x003EF42A File Offset: 0x003ED62A
		public static void AddReason(FlatBufferBuilder builder, StringOffset reasonOffset)
		{
			builder.AddOffset(2, reasonOffset.Value, 0);
		}

		// Token: 0x0601BC15 RID: 113685 RVA: 0x003EF43A File Offset: 0x003ED63A
		public static void AddIsClientVisible(FlatBufferBuilder builder, bool isClientVisible)
		{
			builder.AddBool(3, isClientVisible, false);
		}

		// Token: 0x0601BC16 RID: 113686 RVA: 0x003EF445 File Offset: 0x003ED645
		public static void AddIsInRange(FlatBufferBuilder builder, bool isInRange)
		{
			builder.AddBool(4, isInRange, false);
		}

		// Token: 0x0601BC17 RID: 113687 RVA: 0x003EF450 File Offset: 0x003ED650
		public static void AddTags(FlatBufferBuilder builder, StringOffset tagsOffset)
		{
			builder.AddOffset(5, tagsOffset.Value, 0);
		}

		// Token: 0x0601BC18 RID: 113688 RVA: 0x003EF460 File Offset: 0x003ED660
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0601BC19 RID: 113689 RVA: 0x003EF46B File Offset: 0x003ED66B
		public static Offset<IEntityClientRunningData> EndIEntityClientRunningData(FlatBufferBuilder builder)
		{
			return new Offset<IEntityClientRunningData>(builder.EndTable());
		}

		// Token: 0x0601BC1A RID: 113690 RVA: 0x003EF478 File Offset: 0x003ED678
		public IEntityClientRunningDataT UnPack()
		{
			IEntityClientRunningDataT entityClientRunningDataT = new IEntityClientRunningDataT();
			this.UnPackTo(entityClientRunningDataT);
			return entityClientRunningDataT;
		}

		// Token: 0x0601BC1B RID: 113691 RVA: 0x003EF494 File Offset: 0x003ED694
		public void UnPackTo(IEntityClientRunningDataT _o)
		{
			_o.ConfigId = this.ConfigId;
			_o.CreateState = this.CreateState;
			_o.Reason = this.Reason;
			_o.IsClientVisible = this.IsClientVisible;
			_o.IsInRange = this.IsInRange;
			_o.Tags = this.Tags;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601BC1C RID: 113692 RVA: 0x003EF4F8 File Offset: 0x003ED6F8
		public static Offset<IEntityClientRunningData> Pack(FlatBufferBuilder builder, IEntityClientRunningDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityClientRunningData>);
			}
			StringOffset reasonOffset = (_o.Reason == null) ? default(StringOffset) : builder.CreateString(_o.Reason);
			StringOffset tagsOffset = (_o.Tags == null) ? default(StringOffset) : builder.CreateString(_o.Tags);
			return IEntityClientRunningData.CreateIEntityClientRunningData(builder, _o.ConfigId, _o.CreateState, reasonOffset, _o.IsClientVisible, _o.IsInRange, tagsOffset, _o.NullMask);
		}

		// Token: 0x0400C97D RID: 51581
		private Table __p;
	}
}
