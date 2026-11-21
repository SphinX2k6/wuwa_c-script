using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Combat
{
	// Token: 0x02006533 RID: 25907
	public struct ITagConfig : IFlatbufferObject
	{
		// Token: 0x1700BF1F RID: 48927
		// (get) Token: 0x0602C286 RID: 180870 RVA: 0x00603A6F File Offset: 0x00601C6F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C287 RID: 180871 RVA: 0x00603A7C File Offset: 0x00601C7C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C288 RID: 180872 RVA: 0x00603A84 File Offset: 0x00601C84
		public static ITagConfig GetRootAsITagConfig(ByteBuffer _bb)
		{
			return ITagConfig.GetRootAsITagConfig(_bb, default(ITagConfig));
		}

		// Token: 0x0602C289 RID: 180873 RVA: 0x00603AA0 File Offset: 0x00601CA0
		public static ITagConfig GetRootAsITagConfig(ByteBuffer _bb, ITagConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C28A RID: 180874 RVA: 0x00603ABD File Offset: 0x00601CBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C28B RID: 180875 RVA: 0x00603ACC File Offset: 0x00601CCC
		public ITagConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BF20 RID: 48928
		// (get) Token: 0x0602C28C RID: 180876 RVA: 0x00603ADC File Offset: 0x00601CDC
		public string Tag
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

		// Token: 0x0602C28D RID: 180877 RVA: 0x00603B13 File Offset: 0x00601D13
		public Span<byte> GetTagBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602C28E RID: 180878 RVA: 0x00603B22 File Offset: 0x00601D22
		public byte[] GetTagArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700BF21 RID: 48929
		// (get) Token: 0x0602C28F RID: 180879 RVA: 0x00603B30 File Offset: 0x00601D30
		public string Name
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

		// Token: 0x0602C290 RID: 180880 RVA: 0x00603B67 File Offset: 0x00601D67
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602C291 RID: 180881 RVA: 0x00603B76 File Offset: 0x00601D76
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602C292 RID: 180882 RVA: 0x00603B84 File Offset: 0x00601D84
		public static Offset<ITagConfig> CreateITagConfig(FlatBufferBuilder builder, StringOffset TagOffset = default(StringOffset), StringOffset NameOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ITagConfig.AddName(builder, NameOffset);
			ITagConfig.AddTag(builder, TagOffset);
			return ITagConfig.EndITagConfig(builder);
		}

		// Token: 0x0602C293 RID: 180883 RVA: 0x00603BA1 File Offset: 0x00601DA1
		public static void StartITagConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602C294 RID: 180884 RVA: 0x00603BAA File Offset: 0x00601DAA
		public static void AddTag(FlatBufferBuilder builder, StringOffset tagOffset)
		{
			builder.AddOffset(0, tagOffset.Value, 0);
		}

		// Token: 0x0602C295 RID: 180885 RVA: 0x00603BBA File Offset: 0x00601DBA
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(1, nameOffset.Value, 0);
		}

		// Token: 0x0602C296 RID: 180886 RVA: 0x00603BCA File Offset: 0x00601DCA
		public static Offset<ITagConfig> EndITagConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITagConfig>(builder.EndTable());
		}

		// Token: 0x0602C297 RID: 180887 RVA: 0x00603BD8 File Offset: 0x00601DD8
		public ITagConfigT UnPack()
		{
			ITagConfigT tagConfigT = new ITagConfigT();
			this.UnPackTo(tagConfigT);
			return tagConfigT;
		}

		// Token: 0x0602C298 RID: 180888 RVA: 0x00603BF3 File Offset: 0x00601DF3
		public void UnPackTo(ITagConfigT _o)
		{
			_o.Tag = this.Tag;
			_o.Name = this.Name;
		}

		// Token: 0x0602C299 RID: 180889 RVA: 0x00603C10 File Offset: 0x00601E10
		public static Offset<ITagConfig> Pack(FlatBufferBuilder builder, ITagConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITagConfig>);
			}
			StringOffset tagOffset = (_o.Tag == null) ? default(StringOffset) : builder.CreateString(_o.Tag);
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			return ITagConfig.CreateITagConfig(builder, tagOffset, nameOffset);
		}

		// Token: 0x04010757 RID: 67415
		private Table __p;
	}
}
