using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F8D RID: 3981
	public struct RacingBetsOddsUpdate : IFlatbufferObject
	{
		// Token: 0x17002CBD RID: 11453
		// (get) Token: 0x0600B86F RID: 47215 RVA: 0x002D604D File Offset: 0x002D424D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B870 RID: 47216 RVA: 0x002D605A File Offset: 0x002D425A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B871 RID: 47217 RVA: 0x002D6064 File Offset: 0x002D4264
		public static RacingBetsOddsUpdate GetRootAsRacingBetsOddsUpdate(ByteBuffer _bb)
		{
			return RacingBetsOddsUpdate.GetRootAsRacingBetsOddsUpdate(_bb, default(RacingBetsOddsUpdate));
		}

		// Token: 0x0600B872 RID: 47218 RVA: 0x002D6080 File Offset: 0x002D4280
		public static RacingBetsOddsUpdate GetRootAsRacingBetsOddsUpdate(ByteBuffer _bb, RacingBetsOddsUpdate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B873 RID: 47219 RVA: 0x002D609D File Offset: 0x002D429D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B874 RID: 47220 RVA: 0x002D60AC File Offset: 0x002D42AC
		public RacingBetsOddsUpdate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002CBE RID: 11454
		// (get) Token: 0x0600B875 RID: 47221 RVA: 0x002D60BC File Offset: 0x002D42BC
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

		// Token: 0x17002CBF RID: 11455
		// (get) Token: 0x0600B876 RID: 47222 RVA: 0x002D60F8 File Offset: 0x002D42F8
		public int IndexId
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

		// Token: 0x0600B877 RID: 47223 RVA: 0x002D6134 File Offset: 0x002D4334
		public string OddsUpdatePoint(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002CC0 RID: 11456
		// (get) Token: 0x0600B878 RID: 47224 RVA: 0x002D6170 File Offset: 0x002D4370
		public int OddsUpdatePointLength
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

		// Token: 0x0600B879 RID: 47225 RVA: 0x002D619B File Offset: 0x002D439B
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用OddsUpdatePointIter()或GetOddsUpdatePointBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] OddsUpdatePoint()
		{
			return this.OddsUpdatePointIter().ToArray<string>();
		}

		// Token: 0x0600B87A RID: 47226 RVA: 0x002D61A8 File Offset: 0x002D43A8
		[NullableContext(1)]
		public readonly IEnumerable<string> OddsUpdatePointIter()
		{
			RacingBetsOddsUpdate.<OddsUpdatePointIter>d__16 <OddsUpdatePointIter>d__ = new RacingBetsOddsUpdate.<OddsUpdatePointIter>d__16(-2);
			<OddsUpdatePointIter>d__.<>3__<>4__this = this;
			return <OddsUpdatePointIter>d__;
		}

		// Token: 0x0400505C RID: 20572
		private Table __p;
	}
}
