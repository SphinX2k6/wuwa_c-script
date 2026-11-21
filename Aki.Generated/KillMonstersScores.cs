using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E71 RID: 3697
	public struct KillMonstersScores : IFlatbufferObject
	{
		// Token: 0x17001AE1 RID: 6881
		// (get) Token: 0x06008DB5 RID: 36277 RVA: 0x00286E49 File Offset: 0x00285049
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008DB6 RID: 36278 RVA: 0x00286E56 File Offset: 0x00285056
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008DB7 RID: 36279 RVA: 0x00286E60 File Offset: 0x00285060
		public static KillMonstersScores GetRootAsKillMonstersScores(ByteBuffer _bb)
		{
			return KillMonstersScores.GetRootAsKillMonstersScores(_bb, default(KillMonstersScores));
		}

		// Token: 0x06008DB8 RID: 36280 RVA: 0x00286E7C File Offset: 0x0028507C
		public static KillMonstersScores GetRootAsKillMonstersScores(ByteBuffer _bb, KillMonstersScores obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008DB9 RID: 36281 RVA: 0x00286E99 File Offset: 0x00285099
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008DBA RID: 36282 RVA: 0x00286EA8 File Offset: 0x002850A8
		public KillMonstersScores __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001AE2 RID: 6882
		// (get) Token: 0x06008DBB RID: 36283 RVA: 0x00286EB8 File Offset: 0x002850B8
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

		// Token: 0x17001AE3 RID: 6883
		// (get) Token: 0x06008DBC RID: 36284 RVA: 0x00286EF4 File Offset: 0x002850F4
		public int InstanceID
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

		// Token: 0x17001AE4 RID: 6884
		// (get) Token: 0x06008DBD RID: 36285 RVA: 0x00286F30 File Offset: 0x00285130
		public int ScoreMin
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

		// Token: 0x17001AE5 RID: 6885
		// (get) Token: 0x06008DBE RID: 36286 RVA: 0x00286F6C File Offset: 0x0028516C
		public int ScoreMax
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

		// Token: 0x17001AE6 RID: 6886
		// (get) Token: 0x06008DBF RID: 36287 RVA: 0x00286FAC File Offset: 0x002851AC
		public int Reward
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

		// Token: 0x06008DC0 RID: 36288 RVA: 0x00286FEC File Offset: 0x002851EC
		public int DifficultyOptions(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001AE7 RID: 6887
		// (get) Token: 0x06008DC1 RID: 36289 RVA: 0x0028702C File Offset: 0x0028522C
		public int DifficultyOptionsLength
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

		// Token: 0x06008DC2 RID: 36290 RVA: 0x00287058 File Offset: 0x00285258
		public Span<int> GetDifficultyOptionsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x06008DC3 RID: 36291 RVA: 0x00287068 File Offset: 0x00285268
		public int[] GetDifficultyOptionsArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17001AE8 RID: 6888
		// (get) Token: 0x06008DC4 RID: 36292 RVA: 0x00287080 File Offset: 0x00285280
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008DC5 RID: 36293 RVA: 0x002870B8 File Offset: 0x002852B8
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06008DC6 RID: 36294 RVA: 0x002870C8 File Offset: 0x002852C8
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x06008DC7 RID: 36295 RVA: 0x002870E0 File Offset: 0x002852E0
		[NullableContext(1)]
		public int[] DifficultyOptions()
		{
			return this.GetDifficultyOptionsArray();
		}

		// Token: 0x06008DC8 RID: 36296 RVA: 0x002870E8 File Offset: 0x002852E8
		[NullableContext(1)]
		public IEnumerable<int> DifficultyOptionsIter()
		{
			KillMonstersScores.<DifficultyOptionsIter>d__28 <DifficultyOptionsIter>d__ = new KillMonstersScores.<DifficultyOptionsIter>d__28(-2);
			<DifficultyOptionsIter>d__.<>3__<>4__this = this;
			return <DifficultyOptionsIter>d__;
		}

		// Token: 0x040053FD RID: 21501
		private Table __p;
	}
}
