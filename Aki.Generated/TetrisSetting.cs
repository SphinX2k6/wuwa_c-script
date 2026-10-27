using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001127 RID: 4391
	public struct TetrisSetting : IFlatbufferObject
	{
		// Token: 0x17003A4C RID: 14924
		// (get) Token: 0x0600DE59 RID: 56921 RVA: 0x0032CDB1 File Offset: 0x0032AFB1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DE5A RID: 56922 RVA: 0x0032CDBE File Offset: 0x0032AFBE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DE5B RID: 56923 RVA: 0x0032CDC8 File Offset: 0x0032AFC8
		public static TetrisSetting GetRootAsTetrisSetting(ByteBuffer _bb)
		{
			return TetrisSetting.GetRootAsTetrisSetting(_bb, default(TetrisSetting));
		}

		// Token: 0x0600DE5C RID: 56924 RVA: 0x0032CDE4 File Offset: 0x0032AFE4
		public static TetrisSetting GetRootAsTetrisSetting(ByteBuffer _bb, TetrisSetting obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DE5D RID: 56925 RVA: 0x0032CE01 File Offset: 0x0032B001
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DE5E RID: 56926 RVA: 0x0032CE10 File Offset: 0x0032B010
		public TetrisSetting __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003A4D RID: 14925
		// (get) Token: 0x0600DE5F RID: 56927 RVA: 0x0032CE20 File Offset: 0x0032B020
		public string Key
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

		// Token: 0x0600DE60 RID: 56928 RVA: 0x0032CE57 File Offset: 0x0032B057
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600DE61 RID: 56929 RVA: 0x0032CE66 File Offset: 0x0032B066
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x0600DE62 RID: 56930 RVA: 0x0032CE80 File Offset: 0x0032B080
		public int BasicScore(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003A4E RID: 14926
		// (get) Token: 0x0600DE63 RID: 56931 RVA: 0x0032CEC0 File Offset: 0x0032B0C0
		public int BasicScoreLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600DE64 RID: 56932 RVA: 0x0032CEEB File Offset: 0x0032B0EB
		public Span<int> GetBasicScoreBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600DE65 RID: 56933 RVA: 0x0032CEFA File Offset: 0x0032B0FA
		public int[] GetBasicScoreArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600DE66 RID: 56934 RVA: 0x0032CF14 File Offset: 0x0032B114
		public int ComboAddation(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003A4F RID: 14927
		// (get) Token: 0x0600DE67 RID: 56935 RVA: 0x0032CF54 File Offset: 0x0032B154
		public int ComboAddationLength
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

		// Token: 0x0600DE68 RID: 56936 RVA: 0x0032CF7F File Offset: 0x0032B17F
		public Span<int> GetComboAddationBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600DE69 RID: 56937 RVA: 0x0032CF8E File Offset: 0x0032B18E
		public int[] GetComboAddationArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17003A50 RID: 14928
		// (get) Token: 0x0600DE6A RID: 56938 RVA: 0x0032CFA8 File Offset: 0x0032B1A8
		public int AllClear
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DE6B RID: 56939 RVA: 0x0032CFE8 File Offset: 0x0032B1E8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BasicScoreIter()或GetBasicScoreBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BasicScore()
		{
			TetrisSetting tetrisSetting = this;
			return tetrisSetting.GetBasicScoreArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600DE6C RID: 56940 RVA: 0x0032D00C File Offset: 0x0032B20C
		[NullableContext(1)]
		public readonly IEnumerable<int> BasicScoreIter()
		{
			TetrisSetting.<BasicScoreIter>d__25 <BasicScoreIter>d__ = new TetrisSetting.<BasicScoreIter>d__25(-2);
			<BasicScoreIter>d__.<>3__<>4__this = this;
			return <BasicScoreIter>d__;
		}

		// Token: 0x0600DE6D RID: 56941 RVA: 0x0032D024 File Offset: 0x0032B224
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ComboAddationIter()或GetComboAddationBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ComboAddation()
		{
			TetrisSetting tetrisSetting = this;
			return tetrisSetting.GetComboAddationArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600DE6E RID: 56942 RVA: 0x0032D048 File Offset: 0x0032B248
		[NullableContext(1)]
		public readonly IEnumerable<int> ComboAddationIter()
		{
			TetrisSetting.<ComboAddationIter>d__27 <ComboAddationIter>d__ = new TetrisSetting.<ComboAddationIter>d__27(-2);
			<ComboAddationIter>d__.<>3__<>4__this = this;
			return <ComboAddationIter>d__;
		}

		// Token: 0x04005265 RID: 21093
		private Table __p;
	}
}
