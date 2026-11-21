using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E0C RID: 24076
	public struct IRangedRandom : IFlatbufferObject
	{
		// Token: 0x1700B177 RID: 45431
		// (get) Token: 0x06028331 RID: 164657 RVA: 0x0057F77A File Offset: 0x0057D97A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028332 RID: 164658 RVA: 0x0057F787 File Offset: 0x0057D987
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028333 RID: 164659 RVA: 0x0057F790 File Offset: 0x0057D990
		public static IRangedRandom GetRootAsIRangedRandom(ByteBuffer _bb)
		{
			return IRangedRandom.GetRootAsIRangedRandom(_bb, default(IRangedRandom));
		}

		// Token: 0x06028334 RID: 164660 RVA: 0x0057F7AC File Offset: 0x0057D9AC
		public static IRangedRandom GetRootAsIRangedRandom(ByteBuffer _bb, IRangedRandom obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028335 RID: 164661 RVA: 0x0057F7C9 File Offset: 0x0057D9C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028336 RID: 164662 RVA: 0x0057F7D8 File Offset: 0x0057D9D8
		public IRangedRandom __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B178 RID: 45432
		// (get) Token: 0x06028337 RID: 164663 RVA: 0x0057F7E8 File Offset: 0x0057D9E8
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

		// Token: 0x1700B179 RID: 45433
		// (get) Token: 0x06028338 RID: 164664 RVA: 0x0057F828 File Offset: 0x0057DA28
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

		// Token: 0x06028339 RID: 164665 RVA: 0x0057F868 File Offset: 0x0057DA68
		public static Offset<IRangedRandom> CreateIRangedRandom(FlatBufferBuilder builder, float Left = 0f, float Right = 0f)
		{
			builder.StartTable(2);
			IRangedRandom.AddRight(builder, Right);
			IRangedRandom.AddLeft(builder, Left);
			return IRangedRandom.EndIRangedRandom(builder);
		}

		// Token: 0x0602833A RID: 164666 RVA: 0x0057F885 File Offset: 0x0057DA85
		public static void StartIRangedRandom(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602833B RID: 164667 RVA: 0x0057F88E File Offset: 0x0057DA8E
		public static void AddLeft(FlatBufferBuilder builder, float left)
		{
			builder.AddFloat(0, left, 0.0);
		}

		// Token: 0x0602833C RID: 164668 RVA: 0x0057F8A1 File Offset: 0x0057DAA1
		public static void AddRight(FlatBufferBuilder builder, float right)
		{
			builder.AddFloat(1, right, 0.0);
		}

		// Token: 0x0602833D RID: 164669 RVA: 0x0057F8B4 File Offset: 0x0057DAB4
		public static Offset<IRangedRandom> EndIRangedRandom(FlatBufferBuilder builder)
		{
			return new Offset<IRangedRandom>(builder.EndTable());
		}

		// Token: 0x0602833E RID: 164670 RVA: 0x0057F8C4 File Offset: 0x0057DAC4
		public IRangedRandomT UnPack()
		{
			IRangedRandomT rangedRandomT = new IRangedRandomT();
			this.UnPackTo(rangedRandomT);
			return rangedRandomT;
		}

		// Token: 0x0602833F RID: 164671 RVA: 0x0057F8DF File Offset: 0x0057DADF
		public void UnPackTo(IRangedRandomT _o)
		{
			_o.Left = this.Left;
			_o.Right = this.Right;
		}

		// Token: 0x06028340 RID: 164672 RVA: 0x0057F8FC File Offset: 0x0057DAFC
		public static Offset<IRangedRandom> Pack(FlatBufferBuilder builder, IRangedRandomT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRangedRandom>);
			}
			return IRangedRandom.CreateIRangedRandom(builder, _o.Left, _o.Right);
		}

		// Token: 0x0400F9ED RID: 63981
		private Table __p;
	}
}
