using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200452D RID: 17709
	public struct INoBustResult : IFlatbufferObject
	{
		// Token: 0x17007D9E RID: 32158
		// (get) Token: 0x0601AA15 RID: 109077 RVA: 0x003CD0B0 File Offset: 0x003CB2B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AA16 RID: 109078 RVA: 0x003CD0BD File Offset: 0x003CB2BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AA17 RID: 109079 RVA: 0x003CD0C4 File Offset: 0x003CB2C4
		public static INoBustResult GetRootAsINoBustResult(ByteBuffer _bb)
		{
			return INoBustResult.GetRootAsINoBustResult(_bb, default(INoBustResult));
		}

		// Token: 0x0601AA18 RID: 109080 RVA: 0x003CD0E0 File Offset: 0x003CB2E0
		public static INoBustResult GetRootAsINoBustResult(ByteBuffer _bb, INoBustResult obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AA19 RID: 109081 RVA: 0x003CD0FD File Offset: 0x003CB2FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AA1A RID: 109082 RVA: 0x003CD10C File Offset: 0x003CB30C
		public INoBustResult __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007D9F RID: 32159
		// (get) Token: 0x0601AA1B RID: 109083 RVA: 0x003CD11C File Offset: 0x003CB31C
		public EDartSkillResultType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDartSkillResultType.NoBust;
				}
				return (EDartSkillResultType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007DA0 RID: 32160
		// (get) Token: 0x0601AA1C RID: 109084 RVA: 0x003CD158 File Offset: 0x003CB358
		public int Probability
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

		// Token: 0x0601AA1D RID: 109085 RVA: 0x003CD194 File Offset: 0x003CB394
		public static Offset<INoBustResult> CreateINoBustResult(FlatBufferBuilder builder, EDartSkillResultType Type = EDartSkillResultType.NoBust, int Probability = 0)
		{
			builder.StartTable(2);
			INoBustResult.AddProbability(builder, Probability);
			INoBustResult.AddType(builder, Type);
			return INoBustResult.EndINoBustResult(builder);
		}

		// Token: 0x0601AA1E RID: 109086 RVA: 0x003CD1B1 File Offset: 0x003CB3B1
		public static void StartINoBustResult(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601AA1F RID: 109087 RVA: 0x003CD1BA File Offset: 0x003CB3BA
		public static void AddType(FlatBufferBuilder builder, EDartSkillResultType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601AA20 RID: 109088 RVA: 0x003CD1C5 File Offset: 0x003CB3C5
		public static void AddProbability(FlatBufferBuilder builder, int probability)
		{
			builder.AddInt(1, probability, 0);
		}

		// Token: 0x0601AA21 RID: 109089 RVA: 0x003CD1D0 File Offset: 0x003CB3D0
		public static Offset<INoBustResult> EndINoBustResult(FlatBufferBuilder builder)
		{
			return new Offset<INoBustResult>(builder.EndTable());
		}

		// Token: 0x0601AA22 RID: 109090 RVA: 0x003CD1E0 File Offset: 0x003CB3E0
		public INoBustResultT UnPack()
		{
			INoBustResultT noBustResultT = new INoBustResultT();
			this.UnPackTo(noBustResultT);
			return noBustResultT;
		}

		// Token: 0x0601AA23 RID: 109091 RVA: 0x003CD1FB File Offset: 0x003CB3FB
		public void UnPackTo(INoBustResultT _o)
		{
			_o.Type = this.Type;
			_o.Probability = this.Probability;
		}

		// Token: 0x0601AA24 RID: 109092 RVA: 0x003CD218 File Offset: 0x003CB418
		public static Offset<INoBustResult> Pack(FlatBufferBuilder builder, INoBustResultT _o)
		{
			if (_o == null)
			{
				return default(Offset<INoBustResult>);
			}
			return INoBustResult.CreateINoBustResult(builder, _o.Type, _o.Probability);
		}

		// Token: 0x0400C5B3 RID: 50611
		private Table __p;
	}
}
