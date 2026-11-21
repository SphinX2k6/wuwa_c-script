using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056A3 RID: 22179
	public struct IElementalWellComponent : IFlatbufferObject
	{
		// Token: 0x17009F7E RID: 40830
		// (get) Token: 0x06023804 RID: 145412 RVA: 0x004E2184 File Offset: 0x004E0384
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023805 RID: 145413 RVA: 0x004E2191 File Offset: 0x004E0391
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023806 RID: 145414 RVA: 0x004E2198 File Offset: 0x004E0398
		public static IElementalWellComponent GetRootAsIElementalWellComponent(ByteBuffer _bb)
		{
			return IElementalWellComponent.GetRootAsIElementalWellComponent(_bb, default(IElementalWellComponent));
		}

		// Token: 0x06023807 RID: 145415 RVA: 0x004E21B4 File Offset: 0x004E03B4
		public static IElementalWellComponent GetRootAsIElementalWellComponent(ByteBuffer _bb, IElementalWellComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023808 RID: 145416 RVA: 0x004E21D1 File Offset: 0x004E03D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023809 RID: 145417 RVA: 0x004E21E0 File Offset: 0x004E03E0
		public IElementalWellComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009F7F RID: 40831
		// (get) Token: 0x0602380A RID: 145418 RVA: 0x004E21F0 File Offset: 0x004E03F0
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009F80 RID: 40832
		// (get) Token: 0x0602380B RID: 145419 RVA: 0x004E2230 File Offset: 0x004E0430
		public EElementalWellEntryType WellType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EElementalWellEntryType.Entry;
				}
				return (EElementalWellEntryType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009F81 RID: 40833
		// (get) Token: 0x0602380C RID: 145420 RVA: 0x004E226C File Offset: 0x004E046C
		public IWellStreamingRenderConfig? StreamingRenderConfig
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IWellStreamingRenderConfig?(default(IWellStreamingRenderConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009F82 RID: 40834
		// (get) Token: 0x0602380D RID: 145421 RVA: 0x004E22CC File Offset: 0x004E04CC
		public IStreamingWaitConfig? StreamWaitConfig
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IStreamingWaitConfig?(default(IStreamingWaitConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009F83 RID: 40835
		// (get) Token: 0x0602380E RID: 145422 RVA: 0x004E232C File Offset: 0x004E052C
		public string StreamingFinishedToState
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602380F RID: 145423 RVA: 0x004E2364 File Offset: 0x004E0564
		public Span<byte> GetStreamingFinishedToStateBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06023810 RID: 145424 RVA: 0x004E2374 File Offset: 0x004E0574
		public byte[] GetStreamingFinishedToStateArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x17009F84 RID: 40836
		// (get) Token: 0x06023811 RID: 145425 RVA: 0x004E2384 File Offset: 0x004E0584
		public string LeaveRangeToState
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

		// Token: 0x06023812 RID: 145426 RVA: 0x004E23BC File Offset: 0x004E05BC
		public Span<byte> GetLeaveRangeToStateBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06023813 RID: 145427 RVA: 0x004E23CC File Offset: 0x004E05CC
		public byte[] GetLeaveRangeToStateArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x17009F85 RID: 40837
		// (get) Token: 0x06023814 RID: 145428 RVA: 0x004E23DC File Offset: 0x004E05DC
		public string PrefabBindPointKey
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023815 RID: 145429 RVA: 0x004E2414 File Offset: 0x004E0614
		public Span<byte> GetPrefabBindPointKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06023816 RID: 145430 RVA: 0x004E2424 File Offset: 0x004E0624
		public byte[] GetPrefabBindPointKeyArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x17009F86 RID: 40838
		// (get) Token: 0x06023817 RID: 145431 RVA: 0x004E2434 File Offset: 0x004E0634
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023818 RID: 145432 RVA: 0x004E2474 File Offset: 0x004E0674
		public static Offset<IElementalWellComponent> CreateIElementalWellComponent(FlatBufferBuilder builder, bool Disabled = false, EElementalWellEntryType WellType = EElementalWellEntryType.Entry, Offset<IWellStreamingRenderConfig> StreamingRenderConfigOffset = default(Offset<IWellStreamingRenderConfig>), Offset<IStreamingWaitConfig> StreamWaitConfigOffset = default(Offset<IStreamingWaitConfig>), StringOffset StreamingFinishedToStateOffset = default(StringOffset), StringOffset LeaveRangeToStateOffset = default(StringOffset), StringOffset PrefabBindPointKeyOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(8);
			IElementalWellComponent.AddPrefabBindPointKey(builder, PrefabBindPointKeyOffset);
			IElementalWellComponent.AddLeaveRangeToState(builder, LeaveRangeToStateOffset);
			IElementalWellComponent.AddStreamingFinishedToState(builder, StreamingFinishedToStateOffset);
			IElementalWellComponent.AddStreamWaitConfig(builder, StreamWaitConfigOffset);
			IElementalWellComponent.AddStreamingRenderConfig(builder, StreamingRenderConfigOffset);
			IElementalWellComponent.AddNullMask(builder, NullMask);
			IElementalWellComponent.AddWellType(builder, WellType);
			IElementalWellComponent.AddDisabled(builder, Disabled);
			return IElementalWellComponent.EndIElementalWellComponent(builder);
		}

		// Token: 0x06023819 RID: 145433 RVA: 0x004E24CB File Offset: 0x004E06CB
		public static void StartIElementalWellComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0602381A RID: 145434 RVA: 0x004E24D4 File Offset: 0x004E06D4
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602381B RID: 145435 RVA: 0x004E24DF File Offset: 0x004E06DF
		public static void AddWellType(FlatBufferBuilder builder, EElementalWellEntryType wellType)
		{
			builder.AddByte(1, (byte)wellType, 0);
		}

		// Token: 0x0602381C RID: 145436 RVA: 0x004E24EA File Offset: 0x004E06EA
		public static void AddStreamingRenderConfig(FlatBufferBuilder builder, Offset<IWellStreamingRenderConfig> streamingRenderConfigOffset)
		{
			builder.AddOffset(2, streamingRenderConfigOffset.Value, 0);
		}

		// Token: 0x0602381D RID: 145437 RVA: 0x004E24FA File Offset: 0x004E06FA
		public static void AddStreamWaitConfig(FlatBufferBuilder builder, Offset<IStreamingWaitConfig> streamWaitConfigOffset)
		{
			builder.AddOffset(3, streamWaitConfigOffset.Value, 0);
		}

		// Token: 0x0602381E RID: 145438 RVA: 0x004E250A File Offset: 0x004E070A
		public static void AddStreamingFinishedToState(FlatBufferBuilder builder, StringOffset streamingFinishedToStateOffset)
		{
			builder.AddOffset(4, streamingFinishedToStateOffset.Value, 0);
		}

		// Token: 0x0602381F RID: 145439 RVA: 0x004E251A File Offset: 0x004E071A
		public static void AddLeaveRangeToState(FlatBufferBuilder builder, StringOffset leaveRangeToStateOffset)
		{
			builder.AddOffset(5, leaveRangeToStateOffset.Value, 0);
		}

		// Token: 0x06023820 RID: 145440 RVA: 0x004E252A File Offset: 0x004E072A
		public static void AddPrefabBindPointKey(FlatBufferBuilder builder, StringOffset prefabBindPointKeyOffset)
		{
			builder.AddOffset(6, prefabBindPointKeyOffset.Value, 0);
		}

		// Token: 0x06023821 RID: 145441 RVA: 0x004E253A File Offset: 0x004E073A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06023822 RID: 145442 RVA: 0x004E2545 File Offset: 0x004E0745
		public static Offset<IElementalWellComponent> EndIElementalWellComponent(FlatBufferBuilder builder)
		{
			return new Offset<IElementalWellComponent>(builder.EndTable());
		}

		// Token: 0x06023823 RID: 145443 RVA: 0x004E2554 File Offset: 0x004E0754
		public IElementalWellComponentT UnPack()
		{
			IElementalWellComponentT elementalWellComponentT = new IElementalWellComponentT();
			this.UnPackTo(elementalWellComponentT);
			return elementalWellComponentT;
		}

		// Token: 0x06023824 RID: 145444 RVA: 0x004E2570 File Offset: 0x004E0770
		public void UnPackTo(IElementalWellComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.WellType = this.WellType;
			_o.StreamingRenderConfig = ((this.StreamingRenderConfig != null) ? this.StreamingRenderConfig.Value.UnPack() : null);
			_o.StreamWaitConfig = ((this.StreamWaitConfig != null) ? this.StreamWaitConfig.Value.UnPack() : null);
			_o.StreamingFinishedToState = this.StreamingFinishedToState;
			_o.LeaveRangeToState = this.LeaveRangeToState;
			_o.PrefabBindPointKey = this.PrefabBindPointKey;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023825 RID: 145445 RVA: 0x004E2624 File Offset: 0x004E0824
		public static Offset<IElementalWellComponent> Pack(FlatBufferBuilder builder, IElementalWellComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IElementalWellComponent>);
			}
			Offset<IWellStreamingRenderConfig> streamingRenderConfigOffset = (_o.StreamingRenderConfig == null) ? default(Offset<IWellStreamingRenderConfig>) : IWellStreamingRenderConfig.Pack(builder, _o.StreamingRenderConfig);
			Offset<IStreamingWaitConfig> streamWaitConfigOffset = (_o.StreamWaitConfig == null) ? default(Offset<IStreamingWaitConfig>) : IStreamingWaitConfig.Pack(builder, _o.StreamWaitConfig);
			StringOffset streamingFinishedToStateOffset = (_o.StreamingFinishedToState == null) ? default(StringOffset) : builder.CreateString(_o.StreamingFinishedToState);
			StringOffset leaveRangeToStateOffset = (_o.LeaveRangeToState == null) ? default(StringOffset) : builder.CreateString(_o.LeaveRangeToState);
			StringOffset prefabBindPointKeyOffset = (_o.PrefabBindPointKey == null) ? default(StringOffset) : builder.CreateString(_o.PrefabBindPointKey);
			return IElementalWellComponent.CreateIElementalWellComponent(builder, _o.Disabled, _o.WellType, streamingRenderConfigOffset, streamWaitConfigOffset, streamingFinishedToStateOffset, leaveRangeToStateOffset, prefabBindPointKeyOffset, _o.NullMask);
		}

		// Token: 0x0400EDC6 RID: 60870
		private Table __p;
	}
}
