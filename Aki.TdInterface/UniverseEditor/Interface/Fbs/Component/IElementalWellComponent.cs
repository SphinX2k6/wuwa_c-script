using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200513E RID: 20798
	public struct IElementalWellComponent : IFlatbufferObject
	{
		// Token: 0x17009791 RID: 38801
		// (get) Token: 0x060218B0 RID: 137392 RVA: 0x004A81F8 File Offset: 0x004A63F8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060218B1 RID: 137393 RVA: 0x004A8205 File Offset: 0x004A6405
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060218B2 RID: 137394 RVA: 0x004A820C File Offset: 0x004A640C
		public static IElementalWellComponent GetRootAsIElementalWellComponent(ByteBuffer _bb)
		{
			return IElementalWellComponent.GetRootAsIElementalWellComponent(_bb, default(IElementalWellComponent));
		}

		// Token: 0x060218B3 RID: 137395 RVA: 0x004A8228 File Offset: 0x004A6428
		public static IElementalWellComponent GetRootAsIElementalWellComponent(ByteBuffer _bb, IElementalWellComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060218B4 RID: 137396 RVA: 0x004A8245 File Offset: 0x004A6445
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060218B5 RID: 137397 RVA: 0x004A8254 File Offset: 0x004A6454
		public IElementalWellComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009792 RID: 38802
		// (get) Token: 0x060218B6 RID: 137398 RVA: 0x004A8264 File Offset: 0x004A6464
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009793 RID: 38803
		// (get) Token: 0x060218B7 RID: 137399 RVA: 0x004A82A4 File Offset: 0x004A64A4
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

		// Token: 0x17009794 RID: 38804
		// (get) Token: 0x060218B8 RID: 137400 RVA: 0x004A82E0 File Offset: 0x004A64E0
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

		// Token: 0x17009795 RID: 38805
		// (get) Token: 0x060218B9 RID: 137401 RVA: 0x004A8340 File Offset: 0x004A6540
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

		// Token: 0x17009796 RID: 38806
		// (get) Token: 0x060218BA RID: 137402 RVA: 0x004A83A0 File Offset: 0x004A65A0
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

		// Token: 0x060218BB RID: 137403 RVA: 0x004A83D8 File Offset: 0x004A65D8
		public Span<byte> GetStreamingFinishedToStateBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060218BC RID: 137404 RVA: 0x004A83E8 File Offset: 0x004A65E8
		public byte[] GetStreamingFinishedToStateArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x17009797 RID: 38807
		// (get) Token: 0x060218BD RID: 137405 RVA: 0x004A83F8 File Offset: 0x004A65F8
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

		// Token: 0x060218BE RID: 137406 RVA: 0x004A8430 File Offset: 0x004A6630
		public Span<byte> GetLeaveRangeToStateBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060218BF RID: 137407 RVA: 0x004A8440 File Offset: 0x004A6640
		public byte[] GetLeaveRangeToStateArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x17009798 RID: 38808
		// (get) Token: 0x060218C0 RID: 137408 RVA: 0x004A8450 File Offset: 0x004A6650
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

		// Token: 0x060218C1 RID: 137409 RVA: 0x004A8488 File Offset: 0x004A6688
		public Span<byte> GetPrefabBindPointKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060218C2 RID: 137410 RVA: 0x004A8498 File Offset: 0x004A6698
		public byte[] GetPrefabBindPointKeyArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x17009799 RID: 38809
		// (get) Token: 0x060218C3 RID: 137411 RVA: 0x004A84A8 File Offset: 0x004A66A8
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

		// Token: 0x060218C4 RID: 137412 RVA: 0x004A84E8 File Offset: 0x004A66E8
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

		// Token: 0x060218C5 RID: 137413 RVA: 0x004A853F File Offset: 0x004A673F
		public static void StartIElementalWellComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x060218C6 RID: 137414 RVA: 0x004A8548 File Offset: 0x004A6748
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060218C7 RID: 137415 RVA: 0x004A8553 File Offset: 0x004A6753
		public static void AddWellType(FlatBufferBuilder builder, EElementalWellEntryType wellType)
		{
			builder.AddByte(1, (byte)wellType, 0);
		}

		// Token: 0x060218C8 RID: 137416 RVA: 0x004A855E File Offset: 0x004A675E
		public static void AddStreamingRenderConfig(FlatBufferBuilder builder, Offset<IWellStreamingRenderConfig> streamingRenderConfigOffset)
		{
			builder.AddOffset(2, streamingRenderConfigOffset.Value, 0);
		}

		// Token: 0x060218C9 RID: 137417 RVA: 0x004A856E File Offset: 0x004A676E
		public static void AddStreamWaitConfig(FlatBufferBuilder builder, Offset<IStreamingWaitConfig> streamWaitConfigOffset)
		{
			builder.AddOffset(3, streamWaitConfigOffset.Value, 0);
		}

		// Token: 0x060218CA RID: 137418 RVA: 0x004A857E File Offset: 0x004A677E
		public static void AddStreamingFinishedToState(FlatBufferBuilder builder, StringOffset streamingFinishedToStateOffset)
		{
			builder.AddOffset(4, streamingFinishedToStateOffset.Value, 0);
		}

		// Token: 0x060218CB RID: 137419 RVA: 0x004A858E File Offset: 0x004A678E
		public static void AddLeaveRangeToState(FlatBufferBuilder builder, StringOffset leaveRangeToStateOffset)
		{
			builder.AddOffset(5, leaveRangeToStateOffset.Value, 0);
		}

		// Token: 0x060218CC RID: 137420 RVA: 0x004A859E File Offset: 0x004A679E
		public static void AddPrefabBindPointKey(FlatBufferBuilder builder, StringOffset prefabBindPointKeyOffset)
		{
			builder.AddOffset(6, prefabBindPointKeyOffset.Value, 0);
		}

		// Token: 0x060218CD RID: 137421 RVA: 0x004A85AE File Offset: 0x004A67AE
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x060218CE RID: 137422 RVA: 0x004A85B9 File Offset: 0x004A67B9
		public static Offset<IElementalWellComponent> EndIElementalWellComponent(FlatBufferBuilder builder)
		{
			return new Offset<IElementalWellComponent>(builder.EndTable());
		}

		// Token: 0x060218CF RID: 137423 RVA: 0x004A85C8 File Offset: 0x004A67C8
		public IElementalWellComponentT UnPack()
		{
			IElementalWellComponentT elementalWellComponentT = new IElementalWellComponentT();
			this.UnPackTo(elementalWellComponentT);
			return elementalWellComponentT;
		}

		// Token: 0x060218D0 RID: 137424 RVA: 0x004A85E4 File Offset: 0x004A67E4
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

		// Token: 0x060218D1 RID: 137425 RVA: 0x004A8698 File Offset: 0x004A6898
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

		// Token: 0x0400E1C9 RID: 57801
		private Table __p;
	}
}
