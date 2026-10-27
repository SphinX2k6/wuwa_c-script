using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B80 RID: 2944
	public struct CircumFluenceTask : IFlatbufferObject
	{
		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x060055EB RID: 21995 RVA: 0x001F6CC1 File Offset: 0x001F4EC1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060055EC RID: 21996 RVA: 0x001F6CCE File Offset: 0x001F4ECE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060055ED RID: 21997 RVA: 0x001F6CD8 File Offset: 0x001F4ED8
		public static CircumFluenceTask GetRootAsCircumFluenceTask(ByteBuffer _bb)
		{
			return CircumFluenceTask.GetRootAsCircumFluenceTask(_bb, default(CircumFluenceTask));
		}

		// Token: 0x060055EE RID: 21998 RVA: 0x001F6CF4 File Offset: 0x001F4EF4
		public static CircumFluenceTask GetRootAsCircumFluenceTask(ByteBuffer _bb, CircumFluenceTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060055EF RID: 21999 RVA: 0x001F6D11 File Offset: 0x001F4F11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060055F0 RID: 22000 RVA: 0x001F6D20 File Offset: 0x001F4F20
		public CircumFluenceTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x060055F1 RID: 22001 RVA: 0x001F6D30 File Offset: 0x001F4F30
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

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x060055F2 RID: 22002 RVA: 0x001F6D6C File Offset: 0x001F4F6C
		public int TaskType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 2;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x060055F3 RID: 22003 RVA: 0x001F6DA8 File Offset: 0x001F4FA8
		public string TargetName
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

		// Token: 0x060055F4 RID: 22004 RVA: 0x001F6DDF File Offset: 0x001F4FDF
		public Span<byte> GetTargetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060055F5 RID: 22005 RVA: 0x001F6DEE File Offset: 0x001F4FEE
		public byte[] GetTargetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x060055F6 RID: 22006 RVA: 0x001F6E08 File Offset: 0x001F5008
		public int TaskSubType
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

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x060055F7 RID: 22007 RVA: 0x001F6E48 File Offset: 0x001F5048
		public int ExploreType
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

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x060055F8 RID: 22008 RVA: 0x001F6E88 File Offset: 0x001F5088
		public int TargetReward
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

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x060055F9 RID: 22009 RVA: 0x001F6EC8 File Offset: 0x001F50C8
		public int TargetFunc
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004B84 RID: 19332
		private Table __p;
	}
}
