using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004ADD RID: 19165
	public struct IOpenBackLoginView : IFlatbufferObject
	{
		// Token: 0x17008657 RID: 34391
		// (get) Token: 0x0601CDE8 RID: 118248 RVA: 0x00410804 File Offset: 0x0040EA04
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CDE9 RID: 118249 RVA: 0x00410811 File Offset: 0x0040EA11
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CDEA RID: 118250 RVA: 0x00410818 File Offset: 0x0040EA18
		public static IOpenBackLoginView GetRootAsIOpenBackLoginView(ByteBuffer _bb)
		{
			return IOpenBackLoginView.GetRootAsIOpenBackLoginView(_bb, default(IOpenBackLoginView));
		}

		// Token: 0x0601CDEB RID: 118251 RVA: 0x00410834 File Offset: 0x0040EA34
		public static IOpenBackLoginView GetRootAsIOpenBackLoginView(ByteBuffer _bb, IOpenBackLoginView obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CDEC RID: 118252 RVA: 0x00410851 File Offset: 0x0040EA51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CDED RID: 118253 RVA: 0x00410860 File Offset: 0x0040EA60
		public IOpenBackLoginView __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008658 RID: 34392
		// (get) Token: 0x0601CDEE RID: 118254 RVA: 0x00410870 File Offset: 0x0040EA70
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008659 RID: 34393
		// (get) Token: 0x0601CDEF RID: 118255 RVA: 0x004108AC File Offset: 0x0040EAAC
		public string Account
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

		// Token: 0x0601CDF0 RID: 118256 RVA: 0x004108E3 File Offset: 0x0040EAE3
		public Span<byte> GetAccountBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601CDF1 RID: 118257 RVA: 0x004108F2 File Offset: 0x0040EAF2
		public byte[] GetAccountArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601CDF2 RID: 118258 RVA: 0x00410900 File Offset: 0x0040EB00
		public static Offset<IOpenBackLoginView> CreateIOpenBackLoginView(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, StringOffset AccountOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IOpenBackLoginView.AddAccount(builder, AccountOffset);
			IOpenBackLoginView.AddType(builder, Type);
			return IOpenBackLoginView.EndIOpenBackLoginView(builder);
		}

		// Token: 0x0601CDF3 RID: 118259 RVA: 0x0041091D File Offset: 0x0040EB1D
		public static void StartIOpenBackLoginView(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601CDF4 RID: 118260 RVA: 0x00410926 File Offset: 0x0040EB26
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CDF5 RID: 118261 RVA: 0x00410931 File Offset: 0x0040EB31
		public static void AddAccount(FlatBufferBuilder builder, StringOffset accountOffset)
		{
			builder.AddOffset(1, accountOffset.Value, 0);
		}

		// Token: 0x0601CDF6 RID: 118262 RVA: 0x00410941 File Offset: 0x0040EB41
		public static Offset<IOpenBackLoginView> EndIOpenBackLoginView(FlatBufferBuilder builder)
		{
			return new Offset<IOpenBackLoginView>(builder.EndTable());
		}

		// Token: 0x0601CDF7 RID: 118263 RVA: 0x00410950 File Offset: 0x0040EB50
		public IOpenBackLoginViewT UnPack()
		{
			IOpenBackLoginViewT openBackLoginViewT = new IOpenBackLoginViewT();
			this.UnPackTo(openBackLoginViewT);
			return openBackLoginViewT;
		}

		// Token: 0x0601CDF8 RID: 118264 RVA: 0x0041096B File Offset: 0x0040EB6B
		public void UnPackTo(IOpenBackLoginViewT _o)
		{
			_o.Type = this.Type;
			_o.Account = this.Account;
		}

		// Token: 0x0601CDF9 RID: 118265 RVA: 0x00410988 File Offset: 0x0040EB88
		public static Offset<IOpenBackLoginView> Pack(FlatBufferBuilder builder, IOpenBackLoginViewT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenBackLoginView>);
			}
			StringOffset accountOffset = (_o.Account == null) ? default(StringOffset) : builder.CreateString(_o.Account);
			return IOpenBackLoginView.CreateIOpenBackLoginView(builder, _o.Type, accountOffset);
		}

		// Token: 0x0400D267 RID: 53863
		private Table __p;
	}
}
