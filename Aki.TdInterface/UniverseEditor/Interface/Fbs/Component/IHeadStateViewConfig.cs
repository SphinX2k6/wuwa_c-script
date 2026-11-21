using System;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058EB RID: 22763
	public struct IHeadStateViewConfig : IFlatbufferObject
	{
		// Token: 0x1700A519 RID: 42265
		// (get) Token: 0x06024F9C RID: 151452 RVA: 0x00513617 File Offset: 0x00511817
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024F9D RID: 151453 RVA: 0x00513624 File Offset: 0x00511824
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024F9E RID: 151454 RVA: 0x0051362C File Offset: 0x0051182C
		public static IHeadStateViewConfig GetRootAsIHeadStateViewConfig(ByteBuffer _bb)
		{
			return IHeadStateViewConfig.GetRootAsIHeadStateViewConfig(_bb, default(IHeadStateViewConfig));
		}

		// Token: 0x06024F9F RID: 151455 RVA: 0x00513648 File Offset: 0x00511848
		public static IHeadStateViewConfig GetRootAsIHeadStateViewConfig(ByteBuffer _bb, IHeadStateViewConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024FA0 RID: 151456 RVA: 0x00513665 File Offset: 0x00511865
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024FA1 RID: 151457 RVA: 0x00513674 File Offset: 0x00511874
		public IHeadStateViewConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A51A RID: 42266
		// (get) Token: 0x06024FA2 RID: 151458 RVA: 0x00513684 File Offset: 0x00511884
		public EHeadStateViewType HeadStateViewType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHeadStateViewType.None;
				}
				return (EHeadStateViewType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A51B RID: 42267
		// (get) Token: 0x06024FA3 RID: 151459 RVA: 0x005136C0 File Offset: 0x005118C0
		public int ZOffset
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A51C RID: 42268
		// (get) Token: 0x06024FA4 RID: 151460 RVA: 0x005136FC File Offset: 0x005118FC
		public int ForwardOffset
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A51D RID: 42269
		// (get) Token: 0x06024FA5 RID: 151461 RVA: 0x00513738 File Offset: 0x00511938
		public string HeadStateSocketName
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024FA6 RID: 151462 RVA: 0x00513770 File Offset: 0x00511970
		public Span<byte> GetHeadStateSocketNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06024FA7 RID: 151463 RVA: 0x00513780 File Offset: 0x00511980
		public byte[] GetHeadStateSocketNameArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x06024FA8 RID: 151464 RVA: 0x0051378F File Offset: 0x0051198F
		public static Offset<IHeadStateViewConfig> CreateIHeadStateViewConfig(FlatBufferBuilder builder, EHeadStateViewType HeadStateViewType = EHeadStateViewType.None, int ZOffset = 0, int ForwardOffset = 0, StringOffset HeadStateSocketNameOffset = default(StringOffset))
		{
			builder.StartTable(4);
			IHeadStateViewConfig.AddHeadStateSocketName(builder, HeadStateSocketNameOffset);
			IHeadStateViewConfig.AddForwardOffset(builder, ForwardOffset);
			IHeadStateViewConfig.AddZOffset(builder, ZOffset);
			IHeadStateViewConfig.AddHeadStateViewType(builder, HeadStateViewType);
			return IHeadStateViewConfig.EndIHeadStateViewConfig(builder);
		}

		// Token: 0x06024FA9 RID: 151465 RVA: 0x005137BB File Offset: 0x005119BB
		public static void StartIHeadStateViewConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06024FAA RID: 151466 RVA: 0x005137C4 File Offset: 0x005119C4
		public static void AddHeadStateViewType(FlatBufferBuilder builder, EHeadStateViewType headStateViewType)
		{
			builder.AddByte(0, (byte)headStateViewType, 0);
		}

		// Token: 0x06024FAB RID: 151467 RVA: 0x005137CF File Offset: 0x005119CF
		public static void AddZOffset(FlatBufferBuilder builder, int zOffset)
		{
			builder.AddInt(1, zOffset, 0);
		}

		// Token: 0x06024FAC RID: 151468 RVA: 0x005137DA File Offset: 0x005119DA
		public static void AddForwardOffset(FlatBufferBuilder builder, int forwardOffset)
		{
			builder.AddInt(2, forwardOffset, 0);
		}

		// Token: 0x06024FAD RID: 151469 RVA: 0x005137E5 File Offset: 0x005119E5
		public static void AddHeadStateSocketName(FlatBufferBuilder builder, StringOffset headStateSocketNameOffset)
		{
			builder.AddOffset(3, headStateSocketNameOffset.Value, 0);
		}

		// Token: 0x06024FAE RID: 151470 RVA: 0x005137F5 File Offset: 0x005119F5
		public static Offset<IHeadStateViewConfig> EndIHeadStateViewConfig(FlatBufferBuilder builder)
		{
			return new Offset<IHeadStateViewConfig>(builder.EndTable());
		}

		// Token: 0x06024FAF RID: 151471 RVA: 0x00513804 File Offset: 0x00511A04
		public IHeadStateViewConfigT UnPack()
		{
			IHeadStateViewConfigT headStateViewConfigT = new IHeadStateViewConfigT();
			this.UnPackTo(headStateViewConfigT);
			return headStateViewConfigT;
		}

		// Token: 0x06024FB0 RID: 151472 RVA: 0x0051381F File Offset: 0x00511A1F
		public void UnPackTo(IHeadStateViewConfigT _o)
		{
			_o.HeadStateViewType = this.HeadStateViewType;
			_o.ZOffset = this.ZOffset;
			_o.ForwardOffset = this.ForwardOffset;
			_o.HeadStateSocketName = this.HeadStateSocketName;
		}

		// Token: 0x06024FB1 RID: 151473 RVA: 0x00513854 File Offset: 0x00511A54
		public static Offset<IHeadStateViewConfig> Pack(FlatBufferBuilder builder, IHeadStateViewConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHeadStateViewConfig>);
			}
			StringOffset headStateSocketNameOffset = (_o.HeadStateSocketName == null) ? default(StringOffset) : builder.CreateString(_o.HeadStateSocketName);
			return IHeadStateViewConfig.CreateIHeadStateViewConfig(builder, _o.HeadStateViewType, _o.ZOffset, _o.ForwardOffset, headStateSocketNameOffset);
		}

		// Token: 0x0400F172 RID: 61810
		private Table __p;
	}
}
