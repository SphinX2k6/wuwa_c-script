using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005805 RID: 22533
	public struct IRangedRandom : IFlatbufferObject
	{
		// Token: 0x1700A853 RID: 43091
		// (get) Token: 0x06025E11 RID: 155153 RVA: 0x005395EE File Offset: 0x005377EE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025E12 RID: 155154 RVA: 0x005395FB File Offset: 0x005377FB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025E13 RID: 155155 RVA: 0x00539604 File Offset: 0x00537804
		public static IRangedRandom GetRootAsIRangedRandom(ByteBuffer _bb)
		{
			return IRangedRandom.GetRootAsIRangedRandom(_bb, default(IRangedRandom));
		}

		// Token: 0x06025E14 RID: 155156 RVA: 0x00539620 File Offset: 0x00537820
		public static IRangedRandom GetRootAsIRangedRandom(ByteBuffer _bb, IRangedRandom obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025E15 RID: 155157 RVA: 0x0053963D File Offset: 0x0053783D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025E16 RID: 155158 RVA: 0x0053964C File Offset: 0x0053784C
		public IRangedRandom __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A854 RID: 43092
		// (get) Token: 0x06025E17 RID: 155159 RVA: 0x0053965C File Offset: 0x0053785C
		public float Left
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A855 RID: 43093
		// (get) Token: 0x06025E18 RID: 155160 RVA: 0x0053969C File Offset: 0x0053789C
		public float Right
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025E19 RID: 155161 RVA: 0x005396DC File Offset: 0x005378DC
		public static Offset<IRangedRandom> CreateIRangedRandom(FlatBufferBuilder builder, float Left = 0f, float Right = 0f)
		{
			builder.StartTable(2);
			IRangedRandom.AddRight(builder, Right);
			IRangedRandom.AddLeft(builder, Left);
			return IRangedRandom.EndIRangedRandom(builder);
		}

		// Token: 0x06025E1A RID: 155162 RVA: 0x005396F9 File Offset: 0x005378F9
		public static void StartIRangedRandom(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06025E1B RID: 155163 RVA: 0x00539702 File Offset: 0x00537902
		public static void AddLeft(FlatBufferBuilder builder, float left)
		{
			builder.AddFloat(0, left, 0.0);
		}

		// Token: 0x06025E1C RID: 155164 RVA: 0x00539715 File Offset: 0x00537915
		public static void AddRight(FlatBufferBuilder builder, float right)
		{
			builder.AddFloat(1, right, 0.0);
		}

		// Token: 0x06025E1D RID: 155165 RVA: 0x00539728 File Offset: 0x00537928
		public static Offset<IRangedRandom> EndIRangedRandom(FlatBufferBuilder builder)
		{
			return new Offset<IRangedRandom>(builder.EndTable());
		}

		// Token: 0x06025E1E RID: 155166 RVA: 0x00539738 File Offset: 0x00537938
		public IRangedRandomT UnPack()
		{
			IRangedRandomT rangedRandomT = new IRangedRandomT();
			this.UnPackTo(rangedRandomT);
			return rangedRandomT;
		}

		// Token: 0x06025E1F RID: 155167 RVA: 0x00539753 File Offset: 0x00537953
		public void UnPackTo(IRangedRandomT _o)
		{
			_o.Left = this.Left;
			_o.Right = this.Right;
		}

		// Token: 0x06025E20 RID: 155168 RVA: 0x00539770 File Offset: 0x00537970
		public static Offset<IRangedRandom> Pack(FlatBufferBuilder builder, IRangedRandomT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRangedRandom>);
			}
			return IRangedRandom.CreateIRangedRandom(builder, _o.Left, _o.Right);
		}

		// Token: 0x0400ED02 RID: 60674
		private Table __p;
	}
}
