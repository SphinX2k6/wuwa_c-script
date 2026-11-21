using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DE8 RID: 3560
	public struct GivebackTask : IFlatbufferObject
	{
		// Token: 0x17001626 RID: 5670
		// (get) Token: 0x0600810D RID: 33037 RVA: 0x0026B055 File Offset: 0x00269255
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600810E RID: 33038 RVA: 0x0026B062 File Offset: 0x00269262
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600810F RID: 33039 RVA: 0x0026B06C File Offset: 0x0026926C
		public static GivebackTask GetRootAsGivebackTask(ByteBuffer _bb)
		{
			return GivebackTask.GetRootAsGivebackTask(_bb, default(GivebackTask));
		}

		// Token: 0x06008110 RID: 33040 RVA: 0x0026B088 File Offset: 0x00269288
		public static GivebackTask GetRootAsGivebackTask(ByteBuffer _bb, GivebackTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008111 RID: 33041 RVA: 0x0026B0A5 File Offset: 0x002692A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008112 RID: 33042 RVA: 0x0026B0B4 File Offset: 0x002692B4
		public GivebackTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001627 RID: 5671
		// (get) Token: 0x06008113 RID: 33043 RVA: 0x0026B0C4 File Offset: 0x002692C4
		public int TaskId
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

		// Token: 0x17001628 RID: 5672
		// (get) Token: 0x06008114 RID: 33044 RVA: 0x0026B100 File Offset: 0x00269300
		public string TaskName
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

		// Token: 0x06008115 RID: 33045 RVA: 0x0026B137 File Offset: 0x00269337
		public Span<byte> GetTaskNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008116 RID: 33046 RVA: 0x0026B146 File Offset: 0x00269346
		public byte[] GetTaskNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001629 RID: 5673
		// (get) Token: 0x06008117 RID: 33047 RVA: 0x0026B160 File Offset: 0x00269360
		public string TaskDes
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

		// Token: 0x06008118 RID: 33048 RVA: 0x0026B197 File Offset: 0x00269397
		public Span<byte> GetTaskDesBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008119 RID: 33049 RVA: 0x0026B1A6 File Offset: 0x002693A6
		public byte[] GetTaskDesArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700162A RID: 5674
		// (get) Token: 0x0600811A RID: 33050 RVA: 0x0026B1C0 File Offset: 0x002693C0
		public int SortId
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

		// Token: 0x1700162B RID: 5675
		// (get) Token: 0x0600811B RID: 33051 RVA: 0x0026B200 File Offset: 0x00269400
		public int HelpBtn
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

		// Token: 0x0600811C RID: 33052 RVA: 0x0026B240 File Offset: 0x00269440
		public int Param(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700162C RID: 5676
		// (get) Token: 0x0600811D RID: 33053 RVA: 0x0026B280 File Offset: 0x00269480
		public int ParamLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600811E RID: 33054 RVA: 0x0026B2AC File Offset: 0x002694AC
		public Span<int> GetParamBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600811F RID: 33055 RVA: 0x0026B2BC File Offset: 0x002694BC
		public int[] GetParamArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x1700162D RID: 5677
		// (get) Token: 0x06008120 RID: 33056 RVA: 0x0026B2D4 File Offset: 0x002694D4
		public int MaxScore
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

		// Token: 0x06008121 RID: 33057 RVA: 0x0026B311 File Offset: 0x00269511
		[NullableContext(1)]
		public int[] Param()
		{
			return this.GetParamArray();
		}

		// Token: 0x06008122 RID: 33058 RVA: 0x0026B319 File Offset: 0x00269519
		[NullableContext(1)]
		public IEnumerable<int> ParamIter()
		{
			GivebackTask.<ParamIter>d__30 <ParamIter>d__ = new GivebackTask.<ParamIter>d__30(-2);
			<ParamIter>d__.<>3__<>4__this = this;
			return <ParamIter>d__;
		}

		// Token: 0x0400535E RID: 21342
		private Table __p;
	}
}
