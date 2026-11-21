using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001251 RID: 4689
	public struct TeleportIntercept : IFlatbufferObject
	{
		// Token: 0x17003D3E RID: 15678
		// (get) Token: 0x0600EA98 RID: 60056 RVA: 0x00355958 File Offset: 0x00353B58
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EA99 RID: 60057 RVA: 0x00355965 File Offset: 0x00353B65
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EA9A RID: 60058 RVA: 0x0035596C File Offset: 0x00353B6C
		public static TeleportIntercept GetRootAsTeleportIntercept(ByteBuffer _bb)
		{
			return TeleportIntercept.GetRootAsTeleportIntercept(_bb, default(TeleportIntercept));
		}

		// Token: 0x0600EA9B RID: 60059 RVA: 0x00355988 File Offset: 0x00353B88
		public static TeleportIntercept GetRootAsTeleportIntercept(ByteBuffer _bb, TeleportIntercept obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EA9C RID: 60060 RVA: 0x003559A5 File Offset: 0x00353BA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EA9D RID: 60061 RVA: 0x003559B4 File Offset: 0x00353BB4
		public TeleportIntercept __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003D3F RID: 15679
		// (get) Token: 0x0600EA9E RID: 60062 RVA: 0x003559C4 File Offset: 0x00353BC4
		public int InterceptId
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

		// Token: 0x17003D40 RID: 15680
		// (get) Token: 0x0600EA9F RID: 60063 RVA: 0x00355A00 File Offset: 0x00353C00
		public int EntityConfigId
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

		// Token: 0x17003D41 RID: 15681
		// (get) Token: 0x0600EAA0 RID: 60064 RVA: 0x00355A3C File Offset: 0x00353C3C
		public int Type
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003D42 RID: 15682
		// (get) Token: 0x0600EAA1 RID: 60065 RVA: 0x00355A78 File Offset: 0x00353C78
		public int OptionIndex
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

		// Token: 0x17003D43 RID: 15683
		// (get) Token: 0x0600EAA2 RID: 60066 RVA: 0x00355AB8 File Offset: 0x00353CB8
		public int CurInstConfigId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003D44 RID: 15684
		// (get) Token: 0x0600EAA3 RID: 60067 RVA: 0x00355AF8 File Offset: 0x00353CF8
		public int TargetMapConfigId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EAA4 RID: 60068 RVA: 0x00355B38 File Offset: 0x00353D38
		public int TargetPosition(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003D45 RID: 15685
		// (get) Token: 0x0600EAA5 RID: 60069 RVA: 0x00355B78 File Offset: 0x00353D78
		public int TargetPositionLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600EAA6 RID: 60070 RVA: 0x00355BA4 File Offset: 0x00353DA4
		public Span<int> GetTargetPositionBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600EAA7 RID: 60071 RVA: 0x00355BB4 File Offset: 0x00353DB4
		public int[] GetTargetPositionArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x0600EAA8 RID: 60072 RVA: 0x00355BCC File Offset: 0x00353DCC
		[NullableContext(1)]
		public int[] TargetPosition()
		{
			return this.GetTargetPositionArray();
		}

		// Token: 0x0600EAA9 RID: 60073 RVA: 0x00355BD4 File Offset: 0x00353DD4
		[NullableContext(1)]
		public IEnumerable<int> TargetPositionIter()
		{
			TeleportIntercept.<TargetPositionIter>d__26 <TargetPositionIter>d__ = new TeleportIntercept.<TargetPositionIter>d__26(-2);
			<TargetPositionIter>d__.<>3__<>4__this = this;
			return <TargetPositionIter>d__;
		}

		// Token: 0x0400589B RID: 22683
		private Table __p;
	}
}
