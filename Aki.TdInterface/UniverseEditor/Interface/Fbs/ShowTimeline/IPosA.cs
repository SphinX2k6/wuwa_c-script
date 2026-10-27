using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003B98 RID: 15256
	public struct IPosA : IFlatbufferObject
	{
		// Token: 0x17006889 RID: 26761
		// (get) Token: 0x06014E56 RID: 85590 RVA: 0x003082E2 File Offset: 0x003064E2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014E57 RID: 85591 RVA: 0x003082EF File Offset: 0x003064EF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014E58 RID: 85592 RVA: 0x003082F8 File Offset: 0x003064F8
		public static IPosA GetRootAsIPosA(ByteBuffer _bb)
		{
			return IPosA.GetRootAsIPosA(_bb, default(IPosA));
		}

		// Token: 0x06014E59 RID: 85593 RVA: 0x00308314 File Offset: 0x00306514
		public static IPosA GetRootAsIPosA(ByteBuffer _bb, IPosA obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014E5A RID: 85594 RVA: 0x00308331 File Offset: 0x00306531
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014E5B RID: 85595 RVA: 0x00308340 File Offset: 0x00306540
		public IPosA __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700688A RID: 26762
		// (get) Token: 0x06014E5C RID: 85596 RVA: 0x00308350 File Offset: 0x00306550
		public float X
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

		// Token: 0x1700688B RID: 26763
		// (get) Token: 0x06014E5D RID: 85597 RVA: 0x00308390 File Offset: 0x00306590
		public float Y
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

		// Token: 0x1700688C RID: 26764
		// (get) Token: 0x06014E5E RID: 85598 RVA: 0x003083D0 File Offset: 0x003065D0
		public float Z
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700688D RID: 26765
		// (get) Token: 0x06014E5F RID: 85599 RVA: 0x00308410 File Offset: 0x00306610
		public float A
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700688E RID: 26766
		// (get) Token: 0x06014E60 RID: 85600 RVA: 0x00308454 File Offset: 0x00306654
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014E61 RID: 85601 RVA: 0x00308491 File Offset: 0x00306691
		public static Offset<IPosA> CreateIPosA(FlatBufferBuilder builder, float X = 0f, float Y = 0f, float Z = 0f, float A = 0f, byte NullMask = 0)
		{
			builder.StartTable(5);
			IPosA.AddA(builder, A);
			IPosA.AddZ(builder, Z);
			IPosA.AddY(builder, Y);
			IPosA.AddX(builder, X);
			IPosA.AddNullMask(builder, NullMask);
			return IPosA.EndIPosA(builder);
		}

		// Token: 0x06014E62 RID: 85602 RVA: 0x003084C5 File Offset: 0x003066C5
		public static void StartIPosA(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06014E63 RID: 85603 RVA: 0x003084CE File Offset: 0x003066CE
		public static void AddX(FlatBufferBuilder builder, float x)
		{
			builder.AddFloat(0, x, 0.0);
		}

		// Token: 0x06014E64 RID: 85604 RVA: 0x003084E1 File Offset: 0x003066E1
		public static void AddY(FlatBufferBuilder builder, float y)
		{
			builder.AddFloat(1, y, 0.0);
		}

		// Token: 0x06014E65 RID: 85605 RVA: 0x003084F4 File Offset: 0x003066F4
		public static void AddZ(FlatBufferBuilder builder, float z)
		{
			builder.AddFloat(2, z, 0.0);
		}

		// Token: 0x06014E66 RID: 85606 RVA: 0x00308507 File Offset: 0x00306707
		public static void AddA(FlatBufferBuilder builder, float a)
		{
			builder.AddFloat(3, a, 0.0);
		}

		// Token: 0x06014E67 RID: 85607 RVA: 0x0030851A File Offset: 0x0030671A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06014E68 RID: 85608 RVA: 0x00308525 File Offset: 0x00306725
		public static Offset<IPosA> EndIPosA(FlatBufferBuilder builder)
		{
			return new Offset<IPosA>(builder.EndTable());
		}

		// Token: 0x06014E69 RID: 85609 RVA: 0x00308534 File Offset: 0x00306734
		public IPosAT UnPack()
		{
			IPosAT posAT = new IPosAT();
			this.UnPackTo(posAT);
			return posAT;
		}

		// Token: 0x06014E6A RID: 85610 RVA: 0x0030854F File Offset: 0x0030674F
		public void UnPackTo(IPosAT _o)
		{
			_o.X = this.X;
			_o.Y = this.Y;
			_o.Z = this.Z;
			_o.A = this.A;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06014E6B RID: 85611 RVA: 0x00308590 File Offset: 0x00306790
		public static Offset<IPosA> Pack(FlatBufferBuilder builder, IPosAT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPosA>);
			}
			return IPosA.CreateIPosA(builder, _o.X, _o.Y, _o.Z, _o.A, _o.NullMask);
		}

		// Token: 0x0400B102 RID: 45314
		private Table __p;
	}
}
