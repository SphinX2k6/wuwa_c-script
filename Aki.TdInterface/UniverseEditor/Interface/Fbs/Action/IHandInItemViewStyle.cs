using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F77 RID: 28535
	public struct IHandInItemViewStyle : IFlatbufferObject
	{
		// Token: 0x1700D104 RID: 53508
		// (get) Token: 0x06031638 RID: 202296 RVA: 0x006B29C8 File Offset: 0x006B0BC8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031639 RID: 202297 RVA: 0x006B29D5 File Offset: 0x006B0BD5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603163A RID: 202298 RVA: 0x006B29DC File Offset: 0x006B0BDC
		public static IHandInItemViewStyle GetRootAsIHandInItemViewStyle(ByteBuffer _bb)
		{
			return IHandInItemViewStyle.GetRootAsIHandInItemViewStyle(_bb, default(IHandInItemViewStyle));
		}

		// Token: 0x0603163B RID: 202299 RVA: 0x006B29F8 File Offset: 0x006B0BF8
		public static IHandInItemViewStyle GetRootAsIHandInItemViewStyle(ByteBuffer _bb, IHandInItemViewStyle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603163C RID: 202300 RVA: 0x006B2A15 File Offset: 0x006B0C15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603163D RID: 202301 RVA: 0x006B2A24 File Offset: 0x006B0C24
		public IHandInItemViewStyle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D105 RID: 53509
		// (get) Token: 0x0603163E RID: 202302 RVA: 0x006B2A34 File Offset: 0x006B0C34
		public EDeliverItemProbeCollectibleViewStyle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDeliverItemProbeCollectibleViewStyle.HandInItemStyle;
				}
				return (EDeliverItemProbeCollectibleViewStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D106 RID: 53510
		// (get) Token: 0x0603163F RID: 202303 RVA: 0x006B2A70 File Offset: 0x006B0C70
		public string TidDescText
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

		// Token: 0x06031640 RID: 202304 RVA: 0x006B2AA7 File Offset: 0x006B0CA7
		public Span<byte> GetTidDescTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06031641 RID: 202305 RVA: 0x006B2AB6 File Offset: 0x006B0CB6
		public byte[] GetTidDescTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06031642 RID: 202306 RVA: 0x006B2AC4 File Offset: 0x006B0CC4
		public static Offset<IHandInItemViewStyle> CreateIHandInItemViewStyle(FlatBufferBuilder builder, EDeliverItemProbeCollectibleViewStyle Type = EDeliverItemProbeCollectibleViewStyle.HandInItemStyle, StringOffset TidDescTextOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IHandInItemViewStyle.AddTidDescText(builder, TidDescTextOffset);
			IHandInItemViewStyle.AddType(builder, Type);
			return IHandInItemViewStyle.EndIHandInItemViewStyle(builder);
		}

		// Token: 0x06031643 RID: 202307 RVA: 0x006B2AE1 File Offset: 0x006B0CE1
		public static void StartIHandInItemViewStyle(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031644 RID: 202308 RVA: 0x006B2AEA File Offset: 0x006B0CEA
		public static void AddType(FlatBufferBuilder builder, EDeliverItemProbeCollectibleViewStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031645 RID: 202309 RVA: 0x006B2AF5 File Offset: 0x006B0CF5
		public static void AddTidDescText(FlatBufferBuilder builder, StringOffset tidDescTextOffset)
		{
			builder.AddOffset(1, tidDescTextOffset.Value, 0);
		}

		// Token: 0x06031646 RID: 202310 RVA: 0x006B2B05 File Offset: 0x006B0D05
		public static Offset<IHandInItemViewStyle> EndIHandInItemViewStyle(FlatBufferBuilder builder)
		{
			return new Offset<IHandInItemViewStyle>(builder.EndTable());
		}

		// Token: 0x06031647 RID: 202311 RVA: 0x006B2B14 File Offset: 0x006B0D14
		public IHandInItemViewStyleT UnPack()
		{
			IHandInItemViewStyleT handInItemViewStyleT = new IHandInItemViewStyleT();
			this.UnPackTo(handInItemViewStyleT);
			return handInItemViewStyleT;
		}

		// Token: 0x06031648 RID: 202312 RVA: 0x006B2B2F File Offset: 0x006B0D2F
		public void UnPackTo(IHandInItemViewStyleT _o)
		{
			_o.Type = this.Type;
			_o.TidDescText = this.TidDescText;
		}

		// Token: 0x06031649 RID: 202313 RVA: 0x006B2B4C File Offset: 0x006B0D4C
		public static Offset<IHandInItemViewStyle> Pack(FlatBufferBuilder builder, IHandInItemViewStyleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHandInItemViewStyle>);
			}
			StringOffset tidDescTextOffset = (_o.TidDescText == null) ? default(StringOffset) : builder.CreateString(_o.TidDescText);
			return IHandInItemViewStyle.CreateIHandInItemViewStyle(builder, _o.Type, tidDescTextOffset);
		}

		// Token: 0x04011E8B RID: 73355
		private Table __p;
	}
}
