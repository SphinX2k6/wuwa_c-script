using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001049 RID: 4169
	public struct QualityIconTag : IFlatbufferObject
	{
		// Token: 0x17002BA7 RID: 11175
		// (get) Token: 0x0600BA3D RID: 47677 RVA: 0x002E9740 File Offset: 0x002E7940
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BA3E RID: 47678 RVA: 0x002E974D File Offset: 0x002E794D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BA3F RID: 47679 RVA: 0x002E9754 File Offset: 0x002E7954
		public static QualityIconTag GetRootAsQualityIconTag(ByteBuffer _bb)
		{
			return QualityIconTag.GetRootAsQualityIconTag(_bb, default(QualityIconTag));
		}

		// Token: 0x0600BA40 RID: 47680 RVA: 0x002E9770 File Offset: 0x002E7970
		public static QualityIconTag GetRootAsQualityIconTag(ByteBuffer _bb, QualityIconTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BA41 RID: 47681 RVA: 0x002E978D File Offset: 0x002E798D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BA42 RID: 47682 RVA: 0x002E979C File Offset: 0x002E799C
		public QualityIconTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002BA8 RID: 11176
		// (get) Token: 0x0600BA43 RID: 47683 RVA: 0x002E97AC File Offset: 0x002E79AC
		public string Id
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

		// Token: 0x0600BA44 RID: 47684 RVA: 0x002E97E3 File Offset: 0x002E79E3
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600BA45 RID: 47685 RVA: 0x002E97F2 File Offset: 0x002E79F2
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BA9 RID: 11177
		// (get) Token: 0x0600BA46 RID: 47686 RVA: 0x002E980C File Offset: 0x002E7A0C
		public string ConfigParam
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

		// Token: 0x0600BA47 RID: 47687 RVA: 0x002E9843 File Offset: 0x002E7A43
		public Span<byte> GetConfigParamBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600BA48 RID: 47688 RVA: 0x002E9852 File Offset: 0x002E7A52
		public byte[] GetConfigParamArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005617 RID: 22039
		private Table __p;
	}
}
