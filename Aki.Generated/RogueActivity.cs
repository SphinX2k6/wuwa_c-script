using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FD6 RID: 4054
	public struct RogueActivity : IFlatbufferObject
	{
		// Token: 0x17002ED7 RID: 11991
		// (get) Token: 0x0600BE00 RID: 48640 RVA: 0x002E29A9 File Offset: 0x002E0BA9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BE01 RID: 48641 RVA: 0x002E29B6 File Offset: 0x002E0BB6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BE02 RID: 48642 RVA: 0x002E29C0 File Offset: 0x002E0BC0
		public static RogueActivity GetRootAsRogueActivity(ByteBuffer _bb)
		{
			return RogueActivity.GetRootAsRogueActivity(_bb, default(RogueActivity));
		}

		// Token: 0x0600BE03 RID: 48643 RVA: 0x002E29DC File Offset: 0x002E0BDC
		public static RogueActivity GetRootAsRogueActivity(ByteBuffer _bb, RogueActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BE04 RID: 48644 RVA: 0x002E29F9 File Offset: 0x002E0BF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BE05 RID: 48645 RVA: 0x002E2A08 File Offset: 0x002E0C08
		public RogueActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002ED8 RID: 11992
		// (get) Token: 0x0600BE06 RID: 48646 RVA: 0x002E2A18 File Offset: 0x002E0C18
		public int Id
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

		// Token: 0x17002ED9 RID: 11993
		// (get) Token: 0x0600BE07 RID: 48647 RVA: 0x002E2A54 File Offset: 0x002E0C54
		public int FunctionType
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

		// Token: 0x0600BE08 RID: 48648 RVA: 0x002E2A90 File Offset: 0x002E0C90
		public string FunctionParams(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002EDA RID: 11994
		// (get) Token: 0x0600BE09 RID: 48649 RVA: 0x002E2ACC File Offset: 0x002E0CCC
		public int FunctionParamsLength
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

		// Token: 0x17002EDB RID: 11995
		// (get) Token: 0x0600BE0A RID: 48650 RVA: 0x002E2AF8 File Offset: 0x002E0CF8
		public string ActivityResource
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

		// Token: 0x0600BE0B RID: 48651 RVA: 0x002E2B30 File Offset: 0x002E0D30
		public Span<byte> GetActivityResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600BE0C RID: 48652 RVA: 0x002E2B40 File Offset: 0x002E0D40
		public byte[] GetActivityResourceArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600BE0D RID: 48653 RVA: 0x002E2B58 File Offset: 0x002E0D58
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FunctionParamsIter()或GetFunctionParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] FunctionParams()
		{
			return this.FunctionParamsIter().ToArray<string>();
		}

		// Token: 0x0600BE0E RID: 48654 RVA: 0x002E2B65 File Offset: 0x002E0D65
		[NullableContext(1)]
		public readonly IEnumerable<string> FunctionParamsIter()
		{
			RogueActivity.<FunctionParamsIter>d__20 <FunctionParamsIter>d__ = new RogueActivity.<FunctionParamsIter>d__20(-2);
			<FunctionParamsIter>d__.<>3__<>4__this = this;
			return <FunctionParamsIter>d__;
		}

		// Token: 0x040050B2 RID: 20658
		private Table __p;
	}
}
