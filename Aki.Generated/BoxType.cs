using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C2C RID: 3116
	public struct BoxType : IFlatbufferObject
	{
		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x0600553D RID: 21821 RVA: 0x00208675 File Offset: 0x00206875
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600553E RID: 21822 RVA: 0x00208682 File Offset: 0x00206882
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600553F RID: 21823 RVA: 0x0020868C File Offset: 0x0020688C
		public static BoxType GetRootAsBoxType(ByteBuffer _bb)
		{
			return BoxType.GetRootAsBoxType(_bb, default(BoxType));
		}

		// Token: 0x06005540 RID: 21824 RVA: 0x002086A8 File Offset: 0x002068A8
		public static BoxType GetRootAsBoxType(ByteBuffer _bb, BoxType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005541 RID: 21825 RVA: 0x002086C5 File Offset: 0x002068C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005542 RID: 21826 RVA: 0x002086D4 File Offset: 0x002068D4
		public BoxType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06005543 RID: 21827 RVA: 0x002086E4 File Offset: 0x002068E4
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

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06005544 RID: 21828 RVA: 0x00208720 File Offset: 0x00206920
		public string Mark
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

		// Token: 0x06005545 RID: 21829 RVA: 0x00208757 File Offset: 0x00206957
		public Span<byte> GetMarkBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005546 RID: 21830 RVA: 0x00208766 File Offset: 0x00206966
		public byte[] GetMarkArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06005547 RID: 21831 RVA: 0x00208780 File Offset: 0x00206980
		public int StartState
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

		// Token: 0x06005548 RID: 21832 RVA: 0x002087BC File Offset: 0x002069BC
		public int IdleState(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06005549 RID: 21833 RVA: 0x002087FC File Offset: 0x002069FC
		public int IdleStateLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600554A RID: 21834 RVA: 0x00208828 File Offset: 0x00206A28
		public Span<int> GetIdleStateBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600554B RID: 21835 RVA: 0x00208838 File Offset: 0x00206A38
		public int[] GetIdleStateArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600554C RID: 21836 RVA: 0x00208850 File Offset: 0x00206A50
		public int IdleStartState(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x0600554D RID: 21837 RVA: 0x00208890 File Offset: 0x00206A90
		public int IdleStartStateLength
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

		// Token: 0x0600554E RID: 21838 RVA: 0x002088BC File Offset: 0x00206ABC
		public Span<int> GetIdleStartStateBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600554F RID: 21839 RVA: 0x002088CC File Offset: 0x00206ACC
		public int[] GetIdleStartStateArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06005550 RID: 21840 RVA: 0x002088E4 File Offset: 0x00206AE4
		public int DeathState
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

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06005551 RID: 21841 RVA: 0x00208924 File Offset: 0x00206B24
		public float OpenTime
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005552 RID: 21842 RVA: 0x00208965 File Offset: 0x00206B65
		[NullableContext(1)]
		public int[] IdleStartState()
		{
			return this.GetIdleStartStateArray();
		}

		// Token: 0x06005553 RID: 21843 RVA: 0x0020896D File Offset: 0x00206B6D
		[NullableContext(1)]
		public IEnumerable<int> IdleStartStateIter()
		{
			BoxType.<IdleStartStateIter>d__31 <IdleStartStateIter>d__ = new BoxType.<IdleStartStateIter>d__31(-2);
			<IdleStartStateIter>d__.<>3__<>4__this = this;
			return <IdleStartStateIter>d__;
		}

		// Token: 0x06005554 RID: 21844 RVA: 0x00208982 File Offset: 0x00206B82
		[NullableContext(1)]
		public int[] IdleState()
		{
			return this.GetIdleStateArray();
		}

		// Token: 0x06005555 RID: 21845 RVA: 0x0020898A File Offset: 0x00206B8A
		[NullableContext(1)]
		public IEnumerable<int> IdleStateIter()
		{
			BoxType.<IdleStateIter>d__33 <IdleStateIter>d__ = new BoxType.<IdleStateIter>d__33(-2);
			<IdleStateIter>d__.<>3__<>4__this = this;
			return <IdleStateIter>d__;
		}

		// Token: 0x04005127 RID: 20775
		private Table __p;
	}
}
