using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004B50 RID: 19280
	public struct IEntityClientRunningData : IFlatbufferObject
	{
		// Token: 0x170087DD RID: 34781
		// (get) Token: 0x0601D3D4 RID: 119764 RVA: 0x0041B405 File Offset: 0x00419605
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D3D5 RID: 119765 RVA: 0x0041B412 File Offset: 0x00419612
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D3D6 RID: 119766 RVA: 0x0041B41C File Offset: 0x0041961C
		public static IEntityClientRunningData GetRootAsIEntityClientRunningData(ByteBuffer _bb)
		{
			return IEntityClientRunningData.GetRootAsIEntityClientRunningData(_bb, default(IEntityClientRunningData));
		}

		// Token: 0x0601D3D7 RID: 119767 RVA: 0x0041B438 File Offset: 0x00419638
		public static IEntityClientRunningData GetRootAsIEntityClientRunningData(ByteBuffer _bb, IEntityClientRunningData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D3D8 RID: 119768 RVA: 0x0041B455 File Offset: 0x00419655
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D3D9 RID: 119769 RVA: 0x0041B464 File Offset: 0x00419664
		public IEntityClientRunningData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170087DE RID: 34782
		// (get) Token: 0x0601D3DA RID: 119770 RVA: 0x0041B474 File Offset: 0x00419674
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

		// Token: 0x170087DF RID: 34783
		// (get) Token: 0x0601D3DB RID: 119771 RVA: 0x0041B4B0 File Offset: 0x004196B0
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

		// Token: 0x170087E0 RID: 34784
		// (get) Token: 0x0601D3DC RID: 119772 RVA: 0x0041B4EC File Offset: 0x004196EC
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

		// Token: 0x0601D3DD RID: 119773 RVA: 0x0041B523 File Offset: 0x00419723
		public Span<byte> GetReasonBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601D3DE RID: 119774 RVA: 0x0041B532 File Offset: 0x00419732
		public byte[] GetReasonArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x170087E1 RID: 34785
		// (get) Token: 0x0601D3DF RID: 119775 RVA: 0x0041B540 File Offset: 0x00419740
		public bool IsClientVisible
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170087E2 RID: 34786
		// (get) Token: 0x0601D3E0 RID: 119776 RVA: 0x0041B580 File Offset: 0x00419780
		public bool IsInRange
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170087E3 RID: 34787
		// (get) Token: 0x0601D3E1 RID: 119777 RVA: 0x0041B5C0 File Offset: 0x004197C0
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

		// Token: 0x0601D3E2 RID: 119778 RVA: 0x0041B5F8 File Offset: 0x004197F8
		public Span<byte> GetTagsBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0601D3E3 RID: 119779 RVA: 0x0041B608 File Offset: 0x00419808
		public byte[] GetTagsArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x170087E4 RID: 34788
		// (get) Token: 0x0601D3E4 RID: 119780 RVA: 0x0041B618 File Offset: 0x00419818
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

		// Token: 0x0601D3E5 RID: 119781 RVA: 0x0041B658 File Offset: 0x00419858
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

		// Token: 0x0601D3E6 RID: 119782 RVA: 0x0041B6A7 File Offset: 0x004198A7
		public static void StartIEntityClientRunningData(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601D3E7 RID: 119783 RVA: 0x0041B6B0 File Offset: 0x004198B0
		public static void AddConfigId(FlatBufferBuilder builder, int configId)
		{
			builder.AddInt(0, configId, 0);
		}

		// Token: 0x0601D3E8 RID: 119784 RVA: 0x0041B6BB File Offset: 0x004198BB
		public static void AddCreateState(FlatBufferBuilder builder, EEntityClientCreateState createState)
		{
			builder.AddByte(1, (byte)createState, 0);
		}

		// Token: 0x0601D3E9 RID: 119785 RVA: 0x0041B6C6 File Offset: 0x004198C6
		public static void AddReason(FlatBufferBuilder builder, StringOffset reasonOffset)
		{
			builder.AddOffset(2, reasonOffset.Value, 0);
		}

		// Token: 0x0601D3EA RID: 119786 RVA: 0x0041B6D6 File Offset: 0x004198D6
		public static void AddIsClientVisible(FlatBufferBuilder builder, bool isClientVisible)
		{
			builder.AddBool(3, isClientVisible, false);
		}

		// Token: 0x0601D3EB RID: 119787 RVA: 0x0041B6E1 File Offset: 0x004198E1
		public static void AddIsInRange(FlatBufferBuilder builder, bool isInRange)
		{
			builder.AddBool(4, isInRange, false);
		}

		// Token: 0x0601D3EC RID: 119788 RVA: 0x0041B6EC File Offset: 0x004198EC
		public static void AddTags(FlatBufferBuilder builder, StringOffset tagsOffset)
		{
			builder.AddOffset(5, tagsOffset.Value, 0);
		}

		// Token: 0x0601D3ED RID: 119789 RVA: 0x0041B6FC File Offset: 0x004198FC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0601D3EE RID: 119790 RVA: 0x0041B707 File Offset: 0x00419907
		public static Offset<IEntityClientRunningData> EndIEntityClientRunningData(FlatBufferBuilder builder)
		{
			return new Offset<IEntityClientRunningData>(builder.EndTable());
		}

		// Token: 0x0601D3EF RID: 119791 RVA: 0x0041B714 File Offset: 0x00419914
		public IEntityClientRunningDataT UnPack()
		{
			IEntityClientRunningDataT entityClientRunningDataT = new IEntityClientRunningDataT();
			this.UnPackTo(entityClientRunningDataT);
			return entityClientRunningDataT;
		}

		// Token: 0x0601D3F0 RID: 119792 RVA: 0x0041B730 File Offset: 0x00419930
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

		// Token: 0x0601D3F1 RID: 119793 RVA: 0x0041B794 File Offset: 0x00419994
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

		// Token: 0x0400D3AC RID: 54188
		private Table __p;
	}
}
