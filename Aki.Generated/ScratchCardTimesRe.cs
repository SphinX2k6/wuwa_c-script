using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200118D RID: 4493
	public struct ScratchCardTimesRe : IFlatbufferObject
	{
		// Token: 0x17003615 RID: 13845
		// (get) Token: 0x0600D7B4 RID: 55220 RVA: 0x00329F95 File Offset: 0x00328195
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D7B5 RID: 55221 RVA: 0x00329FA2 File Offset: 0x003281A2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D7B6 RID: 55222 RVA: 0x00329FAC File Offset: 0x003281AC
		public static ScratchCardTimesRe GetRootAsScratchCardTimesRe(ByteBuffer _bb)
		{
			return ScratchCardTimesRe.GetRootAsScratchCardTimesRe(_bb, default(ScratchCardTimesRe));
		}

		// Token: 0x0600D7B7 RID: 55223 RVA: 0x00329FC8 File Offset: 0x003281C8
		public static ScratchCardTimesRe GetRootAsScratchCardTimesRe(ByteBuffer _bb, ScratchCardTimesRe obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D7B8 RID: 55224 RVA: 0x00329FE5 File Offset: 0x003281E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D7B9 RID: 55225 RVA: 0x00329FF4 File Offset: 0x003281F4
		public ScratchCardTimesRe __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003616 RID: 13846
		// (get) Token: 0x0600D7BA RID: 55226 RVA: 0x0032A004 File Offset: 0x00328204
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

		// Token: 0x17003617 RID: 13847
		// (get) Token: 0x0600D7BB RID: 55227 RVA: 0x0032A040 File Offset: 0x00328240
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

		// Token: 0x0600D7BC RID: 55228 RVA: 0x0032A077 File Offset: 0x00328277
		public Span<byte> GetTaskNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D7BD RID: 55229 RVA: 0x0032A086 File Offset: 0x00328286
		public byte[] GetTaskNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003618 RID: 13848
		// (get) Token: 0x0600D7BE RID: 55230 RVA: 0x0032A0A0 File Offset: 0x003282A0
		public int TaskType
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

		// Token: 0x17003619 RID: 13849
		// (get) Token: 0x0600D7BF RID: 55231 RVA: 0x0032A0DC File Offset: 0x003282DC
		public string TaskTypeName
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

		// Token: 0x0600D7C0 RID: 55232 RVA: 0x0032A114 File Offset: 0x00328314
		public Span<byte> GetTaskTypeNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D7C1 RID: 55233 RVA: 0x0032A124 File Offset: 0x00328324
		public byte[] GetTaskTypeNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700361A RID: 13850
		// (get) Token: 0x0600D7C2 RID: 55234 RVA: 0x0032A13C File Offset: 0x0032833C
		public int TaskReward
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

		// Token: 0x0600D7C3 RID: 55235 RVA: 0x0032A17C File Offset: 0x0032837C
		public int TaskParams(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700361B RID: 13851
		// (get) Token: 0x0600D7C4 RID: 55236 RVA: 0x0032A1BC File Offset: 0x003283BC
		public int TaskParamsLength
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

		// Token: 0x0600D7C5 RID: 55237 RVA: 0x0032A1E8 File Offset: 0x003283E8
		public Span<int> GetTaskParamsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600D7C6 RID: 55238 RVA: 0x0032A1F8 File Offset: 0x003283F8
		public int[] GetTaskParamsArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x1700361C RID: 13852
		// (get) Token: 0x0600D7C7 RID: 55239 RVA: 0x0032A210 File Offset: 0x00328410
		public int RefreshTimesLimit
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

		// Token: 0x0600D7C8 RID: 55240 RVA: 0x0032A24D File Offset: 0x0032844D
		[NullableContext(1)]
		public int[] TaskParams()
		{
			return this.GetTaskParamsArray();
		}

		// Token: 0x0600D7C9 RID: 55241 RVA: 0x0032A255 File Offset: 0x00328455
		[NullableContext(1)]
		public IEnumerable<int> TaskParamsIter()
		{
			ScratchCardTimesRe.<TaskParamsIter>d__30 <TaskParamsIter>d__ = new ScratchCardTimesRe.<TaskParamsIter>d__30(-2);
			<TaskParamsIter>d__.<>3__<>4__this = this;
			return <TaskParamsIter>d__;
		}

		// Token: 0x0400579E RID: 22430
		private Table __p;
	}
}
