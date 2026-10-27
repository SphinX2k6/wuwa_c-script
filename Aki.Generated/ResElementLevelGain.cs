using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FB9 RID: 4025
	public struct ResElementLevelGain : IFlatbufferObject
	{
		// Token: 0x17002DEE RID: 11758
		// (get) Token: 0x0600BB9B RID: 48027 RVA: 0x002DD475 File Offset: 0x002DB675
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BB9C RID: 48028 RVA: 0x002DD482 File Offset: 0x002DB682
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BB9D RID: 48029 RVA: 0x002DD48C File Offset: 0x002DB68C
		public static ResElementLevelGain GetRootAsResElementLevelGain(ByteBuffer _bb)
		{
			return ResElementLevelGain.GetRootAsResElementLevelGain(_bb, default(ResElementLevelGain));
		}

		// Token: 0x0600BB9E RID: 48030 RVA: 0x002DD4A8 File Offset: 0x002DB6A8
		public static ResElementLevelGain GetRootAsResElementLevelGain(ByteBuffer _bb, ResElementLevelGain obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BB9F RID: 48031 RVA: 0x002DD4C5 File Offset: 0x002DB6C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BBA0 RID: 48032 RVA: 0x002DD4D4 File Offset: 0x002DB6D4
		public ResElementLevelGain __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002DEF RID: 11759
		// (get) Token: 0x0600BBA1 RID: 48033 RVA: 0x002DD4E4 File Offset: 0x002DB6E4
		public int TargetType
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

		// Token: 0x17002DF0 RID: 11760
		// (get) Token: 0x0600BBA2 RID: 48034 RVA: 0x002DD520 File Offset: 0x002DB720
		public long BuffId
		{
			get
			{
				int num = this.__p.__offset(6);
				return (long)((num != 0) ? this.__p.bb.GetDouble(num + this.__p.bb_pos) : 0.0);
			}
		}

		// Token: 0x0600BBA3 RID: 48035 RVA: 0x002DD568 File Offset: 0x002DB768
		public long AddBuffs(int j)
		{
			int num = this.__p.__offset(8);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17002DF1 RID: 11761
		// (get) Token: 0x0600BBA4 RID: 48036 RVA: 0x002DD5B4 File Offset: 0x002DB7B4
		public int AddBuffsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600BBA5 RID: 48037 RVA: 0x002DD5DF File Offset: 0x002DB7DF
		public Span<long> GetAddBuffsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(8, 8));
		}

		// Token: 0x0600BBA6 RID: 48038 RVA: 0x002DD5F3 File Offset: 0x002DB7F3
		public long[] GetAddBuffsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(8) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x17002DF2 RID: 11762
		// (get) Token: 0x0600BBA7 RID: 48039 RVA: 0x002DD630 File Offset: 0x002DB830
		public string TextId
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

		// Token: 0x0600BBA8 RID: 48040 RVA: 0x002DD668 File Offset: 0x002DB868
		public Span<byte> GetTextIdBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600BBA9 RID: 48041 RVA: 0x002DD678 File Offset: 0x002DB878
		public byte[] GetTextIdArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600BBAA RID: 48042 RVA: 0x002DD690 File Offset: 0x002DB890
		public string TextIdArgs(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002DF3 RID: 11763
		// (get) Token: 0x0600BBAB RID: 48043 RVA: 0x002DD6CC File Offset: 0x002DB8CC
		public int TextIdArgsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600BBAC RID: 48044 RVA: 0x002DD6F8 File Offset: 0x002DB8F8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AddBuffsIter()或GetAddBuffsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] AddBuffs()
		{
			ResElementLevelGain resElementLevelGain = this;
			return resElementLevelGain.GetAddBuffsArray() ?? Array.Empty<long>();
		}

		// Token: 0x0600BBAD RID: 48045 RVA: 0x002DD71C File Offset: 0x002DB91C
		[NullableContext(1)]
		public readonly IEnumerable<long> AddBuffsIter()
		{
			ResElementLevelGain.<AddBuffsIter>d__25 <AddBuffsIter>d__ = new ResElementLevelGain.<AddBuffsIter>d__25(-2);
			<AddBuffsIter>d__.<>3__<>4__this = this;
			return <AddBuffsIter>d__;
		}

		// Token: 0x0600BBAE RID: 48046 RVA: 0x002DD731 File Offset: 0x002DB931
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TextIdArgsIter()或GetTextIdArgsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] TextIdArgs()
		{
			return this.TextIdArgsIter().ToArray<string>();
		}

		// Token: 0x0600BBAF RID: 48047 RVA: 0x002DD73E File Offset: 0x002DB93E
		[NullableContext(1)]
		public readonly IEnumerable<string> TextIdArgsIter()
		{
			ResElementLevelGain.<TextIdArgsIter>d__27 <TextIdArgsIter>d__ = new ResElementLevelGain.<TextIdArgsIter>d__27(-2);
			<TextIdArgsIter>d__.<>3__<>4__this = this;
			return <TextIdArgsIter>d__;
		}

		// Token: 0x04005092 RID: 20626
		private Table __p;
	}
}
