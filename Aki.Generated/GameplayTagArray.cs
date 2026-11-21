using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012FE RID: 4862
	public struct GameplayTagArray : IFlatbufferObject
	{
		// Token: 0x1700424B RID: 16971
		// (get) Token: 0x0600F7E6 RID: 63462 RVA: 0x00372DE8 File Offset: 0x00370FE8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F7E7 RID: 63463 RVA: 0x00372DF5 File Offset: 0x00370FF5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F7E8 RID: 63464 RVA: 0x00372DFC File Offset: 0x00370FFC
		public static GameplayTagArray GetRootAsGameplayTagArray(ByteBuffer _bb)
		{
			return GameplayTagArray.GetRootAsGameplayTagArray(_bb, default(GameplayTagArray));
		}

		// Token: 0x0600F7E9 RID: 63465 RVA: 0x00372E18 File Offset: 0x00371018
		public static GameplayTagArray GetRootAsGameplayTagArray(ByteBuffer _bb, GameplayTagArray obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F7EA RID: 63466 RVA: 0x00372E35 File Offset: 0x00371035
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F7EB RID: 63467 RVA: 0x00372E44 File Offset: 0x00371044
		public GameplayTagArray __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0600F7EC RID: 63468 RVA: 0x00372E54 File Offset: 0x00371054
		public string ArrayString(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700424C RID: 16972
		// (get) Token: 0x0600F7ED RID: 63469 RVA: 0x00372E90 File Offset: 0x00371090
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

		// Token: 0x0600F7EE RID: 63470 RVA: 0x00372EBB File Offset: 0x003710BB
		[NullableContext(1)]
		public string[] ArrayString()
		{
			return this.ArrayStringIter().ToArray<string>();
		}

		// Token: 0x0600F7EF RID: 63471 RVA: 0x00372EC8 File Offset: 0x003710C8
		[NullableContext(1)]
		public IEnumerable<string> ArrayStringIter()
		{
			GameplayTagArray.<ArrayStringIter>d__12 <ArrayStringIter>d__ = new GameplayTagArray.<ArrayStringIter>d__12(-2);
			<ArrayStringIter>d__.<>3__<>4__this = this;
			return <ArrayStringIter>d__;
		}

		// Token: 0x0400596E RID: 22894
		private Table __p;
	}
}
