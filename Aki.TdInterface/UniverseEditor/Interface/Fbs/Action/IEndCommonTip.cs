using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D19 RID: 27929
	public struct IEndCommonTip : IFlatbufferObject
	{
		// Token: 0x1700CCEA RID: 52458
		// (get) Token: 0x060302AE RID: 197294 RVA: 0x0068CC79 File Offset: 0x0068AE79
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060302AF RID: 197295 RVA: 0x0068CC86 File Offset: 0x0068AE86
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060302B0 RID: 197296 RVA: 0x0068CC90 File Offset: 0x0068AE90
		public static IEndCommonTip GetRootAsIEndCommonTip(ByteBuffer _bb)
		{
			return IEndCommonTip.GetRootAsIEndCommonTip(_bb, default(IEndCommonTip));
		}

		// Token: 0x060302B1 RID: 197297 RVA: 0x0068CCAC File Offset: 0x0068AEAC
		public static IEndCommonTip GetRootAsIEndCommonTip(ByteBuffer _bb, IEndCommonTip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060302B2 RID: 197298 RVA: 0x0068CCC9 File Offset: 0x0068AEC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060302B3 RID: 197299 RVA: 0x0068CCD8 File Offset: 0x0068AED8
		public IEndCommonTip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CCEB RID: 52459
		// (get) Token: 0x060302B4 RID: 197300 RVA: 0x0068CCE8 File Offset: 0x0068AEE8
		public string Token
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060302B5 RID: 197301 RVA: 0x0068CD1F File Offset: 0x0068AF1F
		public Span<byte> GetTokenBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060302B6 RID: 197302 RVA: 0x0068CD2E File Offset: 0x0068AF2E
		public byte[] GetTokenArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x060302B7 RID: 197303 RVA: 0x0068CD3C File Offset: 0x0068AF3C
		public static Offset<IEndCommonTip> CreateIEndCommonTip(FlatBufferBuilder builder, StringOffset TokenOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IEndCommonTip.AddToken(builder, TokenOffset);
			return IEndCommonTip.EndIEndCommonTip(builder);
		}

		// Token: 0x060302B8 RID: 197304 RVA: 0x0068CD52 File Offset: 0x0068AF52
		public static void StartIEndCommonTip(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060302B9 RID: 197305 RVA: 0x0068CD5B File Offset: 0x0068AF5B
		public static void AddToken(FlatBufferBuilder builder, StringOffset tokenOffset)
		{
			builder.AddOffset(0, tokenOffset.Value, 0);
		}

		// Token: 0x060302BA RID: 197306 RVA: 0x0068CD6B File Offset: 0x0068AF6B
		public static Offset<IEndCommonTip> EndIEndCommonTip(FlatBufferBuilder builder)
		{
			return new Offset<IEndCommonTip>(builder.EndTable());
		}

		// Token: 0x060302BB RID: 197307 RVA: 0x0068CD78 File Offset: 0x0068AF78
		public IEndCommonTipT UnPack()
		{
			IEndCommonTipT endCommonTipT = new IEndCommonTipT();
			this.UnPackTo(endCommonTipT);
			return endCommonTipT;
		}

		// Token: 0x060302BC RID: 197308 RVA: 0x0068CD93 File Offset: 0x0068AF93
		public void UnPackTo(IEndCommonTipT _o)
		{
			_o.Token = this.Token;
		}

		// Token: 0x060302BD RID: 197309 RVA: 0x0068CDA4 File Offset: 0x0068AFA4
		public static Offset<IEndCommonTip> Pack(FlatBufferBuilder builder, IEndCommonTipT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEndCommonTip>);
			}
			StringOffset tokenOffset = (_o.Token == null) ? default(StringOffset) : builder.CreateString(_o.Token);
			return IEndCommonTip.CreateIEndCommonTip(builder, tokenOffset);
		}

		// Token: 0x04011B7F RID: 72575
		private Table __p;
	}
}
