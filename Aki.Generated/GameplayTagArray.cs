using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011C8 RID: 4552
	public struct GameplayTagArray : IFlatbufferObject
	{
		// Token: 0x17003EE6 RID: 16102
		// (get) Token: 0x0600EA75 RID: 60021 RVA: 0x0034817C File Offset: 0x0034637C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EA76 RID: 60022 RVA: 0x00348189 File Offset: 0x00346389
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EA77 RID: 60023 RVA: 0x00348190 File Offset: 0x00346390
		public static GameplayTagArray GetRootAsGameplayTagArray(ByteBuffer _bb)
		{
			return GameplayTagArray.GetRootAsGameplayTagArray(_bb, default(GameplayTagArray));
		}

		// Token: 0x0600EA78 RID: 60024 RVA: 0x003481AC File Offset: 0x003463AC
		public static GameplayTagArray GetRootAsGameplayTagArray(ByteBuffer _bb, GameplayTagArray obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EA79 RID: 60025 RVA: 0x003481C9 File Offset: 0x003463C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EA7A RID: 60026 RVA: 0x003481D8 File Offset: 0x003463D8
		public GameplayTagArray __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0600EA7B RID: 60027 RVA: 0x003481E8 File Offset: 0x003463E8
		public string ArrayString(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003EE7 RID: 16103
		// (get) Token: 0x0600EA7C RID: 60028 RVA: 0x00348224 File Offset: 0x00346424
		public int ArrayStringLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600EA7D RID: 60029 RVA: 0x0034824F File Offset: 0x0034644F
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ArrayStringIter()或GetArrayStringBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ArrayString()
		{
			return this.ArrayStringIter().ToArray<string>();
		}

		// Token: 0x0600EA7E RID: 60030 RVA: 0x0034825C File Offset: 0x0034645C
		[NullableContext(1)]
		public readonly IEnumerable<string> ArrayStringIter()
		{
			GameplayTagArray.<ArrayStringIter>d__12 <ArrayStringIter>d__ = new GameplayTagArray.<ArrayStringIter>d__12(-2);
			<ArrayStringIter>d__.<>3__<>4__this = this;
			return <ArrayStringIter>d__;
		}

		// Token: 0x0400532B RID: 21291
		private Table __p;
	}
}
