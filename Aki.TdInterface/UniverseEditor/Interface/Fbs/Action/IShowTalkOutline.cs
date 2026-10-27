using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007100 RID: 28928
	public struct IShowTalkOutline : IFlatbufferObject
	{
		// Token: 0x1700D70B RID: 55051
		// (get) Token: 0x0603346F RID: 210031 RVA: 0x006E9E3A File Offset: 0x006E803A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033470 RID: 210032 RVA: 0x006E9E47 File Offset: 0x006E8047
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033471 RID: 210033 RVA: 0x006E9E50 File Offset: 0x006E8050
		public static IShowTalkOutline GetRootAsIShowTalkOutline(ByteBuffer _bb)
		{
			return IShowTalkOutline.GetRootAsIShowTalkOutline(_bb, default(IShowTalkOutline));
		}

		// Token: 0x06033472 RID: 210034 RVA: 0x006E9E6C File Offset: 0x006E806C
		public static IShowTalkOutline GetRootAsIShowTalkOutline(ByteBuffer _bb, IShowTalkOutline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033473 RID: 210035 RVA: 0x006E9E89 File Offset: 0x006E8089
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033474 RID: 210036 RVA: 0x006E9E98 File Offset: 0x006E8098
		public IShowTalkOutline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D70C RID: 55052
		// (get) Token: 0x06033475 RID: 210037 RVA: 0x006E9EA8 File Offset: 0x006E80A8
		public int TextId
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

		// Token: 0x1700D70D RID: 55053
		// (get) Token: 0x06033476 RID: 210038 RVA: 0x006E9EE4 File Offset: 0x006E80E4
		public string TidOutline
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

		// Token: 0x06033477 RID: 210039 RVA: 0x006E9F1B File Offset: 0x006E811B
		public Span<byte> GetTidOutlineBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06033478 RID: 210040 RVA: 0x006E9F2A File Offset: 0x006E812A
		public byte[] GetTidOutlineArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700D70E RID: 55054
		// (get) Token: 0x06033479 RID: 210041 RVA: 0x006E9F38 File Offset: 0x006E8138
		public string PlotLineKey
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

		// Token: 0x0603347A RID: 210042 RVA: 0x006E9F6F File Offset: 0x006E816F
		public Span<byte> GetPlotLineKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0603347B RID: 210043 RVA: 0x006E9F7E File Offset: 0x006E817E
		public byte[] GetPlotLineKeyArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0603347C RID: 210044 RVA: 0x006E9F8C File Offset: 0x006E818C
		public static Offset<IShowTalkOutline> CreateIShowTalkOutline(FlatBufferBuilder builder, int TextId = 0, StringOffset TidOutlineOffset = default(StringOffset), StringOffset PlotLineKeyOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IShowTalkOutline.AddPlotLineKey(builder, PlotLineKeyOffset);
			IShowTalkOutline.AddTidOutline(builder, TidOutlineOffset);
			IShowTalkOutline.AddTextId(builder, TextId);
			return IShowTalkOutline.EndIShowTalkOutline(builder);
		}

		// Token: 0x0603347D RID: 210045 RVA: 0x006E9FB0 File Offset: 0x006E81B0
		public static void StartIShowTalkOutline(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603347E RID: 210046 RVA: 0x006E9FB9 File Offset: 0x006E81B9
		public static void AddTextId(FlatBufferBuilder builder, int textId)
		{
			builder.AddInt(0, textId, 0);
		}

		// Token: 0x0603347F RID: 210047 RVA: 0x006E9FC4 File Offset: 0x006E81C4
		public static void AddTidOutline(FlatBufferBuilder builder, StringOffset tidOutlineOffset)
		{
			builder.AddOffset(1, tidOutlineOffset.Value, 0);
		}

		// Token: 0x06033480 RID: 210048 RVA: 0x006E9FD4 File Offset: 0x006E81D4
		public static void AddPlotLineKey(FlatBufferBuilder builder, StringOffset plotLineKeyOffset)
		{
			builder.AddOffset(2, plotLineKeyOffset.Value, 0);
		}

		// Token: 0x06033481 RID: 210049 RVA: 0x006E9FE4 File Offset: 0x006E81E4
		public static Offset<IShowTalkOutline> EndIShowTalkOutline(FlatBufferBuilder builder)
		{
			return new Offset<IShowTalkOutline>(builder.EndTable());
		}

		// Token: 0x06033482 RID: 210050 RVA: 0x006E9FF4 File Offset: 0x006E81F4
		public IShowTalkOutlineT UnPack()
		{
			IShowTalkOutlineT showTalkOutlineT = new IShowTalkOutlineT();
			this.UnPackTo(showTalkOutlineT);
			return showTalkOutlineT;
		}

		// Token: 0x06033483 RID: 210051 RVA: 0x006EA00F File Offset: 0x006E820F
		public void UnPackTo(IShowTalkOutlineT _o)
		{
			_o.TextId = this.TextId;
			_o.TidOutline = this.TidOutline;
			_o.PlotLineKey = this.PlotLineKey;
		}

		// Token: 0x06033484 RID: 210052 RVA: 0x006EA038 File Offset: 0x006E8238
		public static Offset<IShowTalkOutline> Pack(FlatBufferBuilder builder, IShowTalkOutlineT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowTalkOutline>);
			}
			StringOffset tidOutlineOffset = (_o.TidOutline == null) ? default(StringOffset) : builder.CreateString(_o.TidOutline);
			StringOffset plotLineKeyOffset = (_o.PlotLineKey == null) ? default(StringOffset) : builder.CreateString(_o.PlotLineKey);
			return IShowTalkOutline.CreateIShowTalkOutline(builder, _o.TextId, tidOutlineOffset, plotLineKeyOffset);
		}

		// Token: 0x04011B8E RID: 72590
		private Table __p;
	}
}
