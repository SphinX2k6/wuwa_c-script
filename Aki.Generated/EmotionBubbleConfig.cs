using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C2B RID: 3115
	public struct EmotionBubbleConfig : IFlatbufferObject
	{
		// Token: 0x17000EDB RID: 3803
		// (get) Token: 0x06006882 RID: 26754 RVA: 0x00221E31 File Offset: 0x00220031
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006883 RID: 26755 RVA: 0x00221E3E File Offset: 0x0022003E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006884 RID: 26756 RVA: 0x00221E48 File Offset: 0x00220048
		public static EmotionBubbleConfig GetRootAsEmotionBubbleConfig(ByteBuffer _bb)
		{
			return EmotionBubbleConfig.GetRootAsEmotionBubbleConfig(_bb, default(EmotionBubbleConfig));
		}

		// Token: 0x06006885 RID: 26757 RVA: 0x00221E64 File Offset: 0x00220064
		public static EmotionBubbleConfig GetRootAsEmotionBubbleConfig(ByteBuffer _bb, EmotionBubbleConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006886 RID: 26758 RVA: 0x00221E81 File Offset: 0x00220081
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006887 RID: 26759 RVA: 0x00221E90 File Offset: 0x00220090
		public EmotionBubbleConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000EDC RID: 3804
		// (get) Token: 0x06006888 RID: 26760 RVA: 0x00221EA0 File Offset: 0x002200A0
		public string EmotionName
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

		// Token: 0x06006889 RID: 26761 RVA: 0x00221ED7 File Offset: 0x002200D7
		public Span<byte> GetEmotionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600688A RID: 26762 RVA: 0x00221EE6 File Offset: 0x002200E6
		public byte[] GetEmotionNameArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EDD RID: 3805
		// (get) Token: 0x0600688B RID: 26763 RVA: 0x00221F00 File Offset: 0x00220100
		public string EmotionPath
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

		// Token: 0x0600688C RID: 26764 RVA: 0x00221F37 File Offset: 0x00220137
		public Span<byte> GetEmotionPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600688D RID: 26765 RVA: 0x00221F46 File Offset: 0x00220146
		public byte[] GetEmotionPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EDE RID: 3806
		// (get) Token: 0x0600688E RID: 26766 RVA: 0x00221F60 File Offset: 0x00220160
		public string EmotionDesc
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

		// Token: 0x0600688F RID: 26767 RVA: 0x00221F97 File Offset: 0x00220197
		public Span<byte> GetEmotionDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006890 RID: 26768 RVA: 0x00221FA6 File Offset: 0x002201A6
		public byte[] GetEmotionDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004C6B RID: 19563
		private Table __p;
	}
}
