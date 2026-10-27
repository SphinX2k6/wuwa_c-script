using System;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005365 RID: 21349
	public struct IHeadStateViewConfig : IFlatbufferObject
	{
		// Token: 0x17009CE1 RID: 40161
		// (get) Token: 0x06022EE8 RID: 143080 RVA: 0x004D6743 File Offset: 0x004D4943
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022EE9 RID: 143081 RVA: 0x004D6750 File Offset: 0x004D4950
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022EEA RID: 143082 RVA: 0x004D6758 File Offset: 0x004D4958
		public static IHeadStateViewConfig GetRootAsIHeadStateViewConfig(ByteBuffer _bb)
		{
			return IHeadStateViewConfig.GetRootAsIHeadStateViewConfig(_bb, default(IHeadStateViewConfig));
		}

		// Token: 0x06022EEB RID: 143083 RVA: 0x004D6774 File Offset: 0x004D4974
		public static IHeadStateViewConfig GetRootAsIHeadStateViewConfig(ByteBuffer _bb, IHeadStateViewConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022EEC RID: 143084 RVA: 0x004D6791 File Offset: 0x004D4991
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022EED RID: 143085 RVA: 0x004D67A0 File Offset: 0x004D49A0
		public IHeadStateViewConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009CE2 RID: 40162
		// (get) Token: 0x06022EEE RID: 143086 RVA: 0x004D67B0 File Offset: 0x004D49B0
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

		// Token: 0x17009CE3 RID: 40163
		// (get) Token: 0x06022EEF RID: 143087 RVA: 0x004D67EC File Offset: 0x004D49EC
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

		// Token: 0x17009CE4 RID: 40164
		// (get) Token: 0x06022EF0 RID: 143088 RVA: 0x004D6828 File Offset: 0x004D4A28
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

		// Token: 0x17009CE5 RID: 40165
		// (get) Token: 0x06022EF1 RID: 143089 RVA: 0x004D6864 File Offset: 0x004D4A64
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

		// Token: 0x06022EF2 RID: 143090 RVA: 0x004D689C File Offset: 0x004D4A9C
		public Span<byte> GetHeadStateSocketNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06022EF3 RID: 143091 RVA: 0x004D68AC File Offset: 0x004D4AAC
		public byte[] GetHeadStateSocketNameArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x06022EF4 RID: 143092 RVA: 0x004D68BB File Offset: 0x004D4ABB
		public static Offset<IHeadStateViewConfig> CreateIHeadStateViewConfig(FlatBufferBuilder builder, EHeadStateViewType HeadStateViewType = EHeadStateViewType.None, int ZOffset = 0, int ForwardOffset = 0, StringOffset HeadStateSocketNameOffset = default(StringOffset))
		{
			builder.StartTable(4);
			IHeadStateViewConfig.AddHeadStateSocketName(builder, HeadStateSocketNameOffset);
			IHeadStateViewConfig.AddForwardOffset(builder, ForwardOffset);
			IHeadStateViewConfig.AddZOffset(builder, ZOffset);
			IHeadStateViewConfig.AddHeadStateViewType(builder, HeadStateViewType);
			return IHeadStateViewConfig.EndIHeadStateViewConfig(builder);
		}

		// Token: 0x06022EF5 RID: 143093 RVA: 0x004D68E7 File Offset: 0x004D4AE7
		public static void StartIHeadStateViewConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06022EF6 RID: 143094 RVA: 0x004D68F0 File Offset: 0x004D4AF0
		public static void AddHeadStateViewType(FlatBufferBuilder builder, EHeadStateViewType headStateViewType)
		{
			builder.AddByte(0, (byte)headStateViewType, 0);
		}

		// Token: 0x06022EF7 RID: 143095 RVA: 0x004D68FB File Offset: 0x004D4AFB
		public static void AddZOffset(FlatBufferBuilder builder, int zOffset)
		{
			builder.AddInt(1, zOffset, 0);
		}

		// Token: 0x06022EF8 RID: 143096 RVA: 0x004D6906 File Offset: 0x004D4B06
		public static void AddForwardOffset(FlatBufferBuilder builder, int forwardOffset)
		{
			builder.AddInt(2, forwardOffset, 0);
		}

		// Token: 0x06022EF9 RID: 143097 RVA: 0x004D6911 File Offset: 0x004D4B11
		public static void AddHeadStateSocketName(FlatBufferBuilder builder, StringOffset headStateSocketNameOffset)
		{
			builder.AddOffset(3, headStateSocketNameOffset.Value, 0);
		}

		// Token: 0x06022EFA RID: 143098 RVA: 0x004D6921 File Offset: 0x004D4B21
		public static Offset<IHeadStateViewConfig> EndIHeadStateViewConfig(FlatBufferBuilder builder)
		{
			return new Offset<IHeadStateViewConfig>(builder.EndTable());
		}

		// Token: 0x06022EFB RID: 143099 RVA: 0x004D6930 File Offset: 0x004D4B30
		public IHeadStateViewConfigT UnPack()
		{
			IHeadStateViewConfigT headStateViewConfigT = new IHeadStateViewConfigT();
			this.UnPackTo(headStateViewConfigT);
			return headStateViewConfigT;
		}

		// Token: 0x06022EFC RID: 143100 RVA: 0x004D694B File Offset: 0x004D4B4B
		public void UnPackTo(IHeadStateViewConfigT _o)
		{
			_o.HeadStateViewType = this.HeadStateViewType;
			_o.ZOffset = this.ZOffset;
			_o.ForwardOffset = this.ForwardOffset;
			_o.HeadStateSocketName = this.HeadStateSocketName;
		}

		// Token: 0x06022EFD RID: 143101 RVA: 0x004D6980 File Offset: 0x004D4B80
		public static Offset<IHeadStateViewConfig> Pack(FlatBufferBuilder builder, IHeadStateViewConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHeadStateViewConfig>);
			}
			StringOffset headStateSocketNameOffset = (_o.HeadStateSocketName == null) ? default(StringOffset) : builder.CreateString(_o.HeadStateSocketName);
			return IHeadStateViewConfig.CreateIHeadStateViewConfig(builder, _o.HeadStateViewType, _o.ZOffset, _o.ForwardOffset, headStateSocketNameOffset);
		}

		// Token: 0x0400E542 RID: 58690
		private Table __p;
	}
}
