using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074E0 RID: 29920
	public struct IPosAndRot : IFlatbufferObject
	{
		// Token: 0x1700DC23 RID: 56355
		// (get) Token: 0x0603472E RID: 214830 RVA: 0x0070FC80 File Offset: 0x0070DE80
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603472F RID: 214831 RVA: 0x0070FC8D File Offset: 0x0070DE8D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034730 RID: 214832 RVA: 0x0070FC94 File Offset: 0x0070DE94
		public static IPosAndRot GetRootAsIPosAndRot(ByteBuffer _bb)
		{
			return IPosAndRot.GetRootAsIPosAndRot(_bb, default(IPosAndRot));
		}

		// Token: 0x06034731 RID: 214833 RVA: 0x0070FCB0 File Offset: 0x0070DEB0
		public static IPosAndRot GetRootAsIPosAndRot(ByteBuffer _bb, IPosAndRot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034732 RID: 214834 RVA: 0x0070FCCD File Offset: 0x0070DECD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034733 RID: 214835 RVA: 0x0070FCDC File Offset: 0x0070DEDC
		public IPosAndRot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DC24 RID: 56356
		// (get) Token: 0x06034734 RID: 214836 RVA: 0x0070FCEC File Offset: 0x0070DEEC
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

		// Token: 0x1700DC25 RID: 56357
		// (get) Token: 0x06034735 RID: 214837 RVA: 0x0070FD2C File Offset: 0x0070DF2C
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

		// Token: 0x1700DC26 RID: 56358
		// (get) Token: 0x06034736 RID: 214838 RVA: 0x0070FD6C File Offset: 0x0070DF6C
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

		// Token: 0x1700DC27 RID: 56359
		// (get) Token: 0x06034737 RID: 214839 RVA: 0x0070FDAC File Offset: 0x0070DFAC
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

		// Token: 0x1700DC28 RID: 56360
		// (get) Token: 0x06034738 RID: 214840 RVA: 0x0070FDF0 File Offset: 0x0070DFF0
		public float Roll
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DC29 RID: 56361
		// (get) Token: 0x06034739 RID: 214841 RVA: 0x0070FE34 File Offset: 0x0070E034
		public float Pitch
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DC2A RID: 56362
		// (get) Token: 0x0603473A RID: 214842 RVA: 0x0070FE78 File Offset: 0x0070E078
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603473B RID: 214843 RVA: 0x0070FEB8 File Offset: 0x0070E0B8
		public static Offset<IPosAndRot> CreateIPosAndRot(FlatBufferBuilder builder, float X = 0f, float Y = 0f, float Z = 0f, float A = 0f, float Roll = 0f, float Pitch = 0f, byte NullMask = 0)
		{
			builder.StartTable(7);
			IPosAndRot.AddPitch(builder, Pitch);
			IPosAndRot.AddRoll(builder, Roll);
			IPosAndRot.AddA(builder, A);
			IPosAndRot.AddZ(builder, Z);
			IPosAndRot.AddY(builder, Y);
			IPosAndRot.AddX(builder, X);
			IPosAndRot.AddNullMask(builder, NullMask);
			return IPosAndRot.EndIPosAndRot(builder);
		}

		// Token: 0x0603473C RID: 214844 RVA: 0x0070FF07 File Offset: 0x0070E107
		public static void StartIPosAndRot(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0603473D RID: 214845 RVA: 0x0070FF10 File Offset: 0x0070E110
		public static void AddX(FlatBufferBuilder builder, float x)
		{
			builder.AddFloat(0, x, 0.0);
		}

		// Token: 0x0603473E RID: 214846 RVA: 0x0070FF23 File Offset: 0x0070E123
		public static void AddY(FlatBufferBuilder builder, float y)
		{
			builder.AddFloat(1, y, 0.0);
		}

		// Token: 0x0603473F RID: 214847 RVA: 0x0070FF36 File Offset: 0x0070E136
		public static void AddZ(FlatBufferBuilder builder, float z)
		{
			builder.AddFloat(2, z, 0.0);
		}

		// Token: 0x06034740 RID: 214848 RVA: 0x0070FF49 File Offset: 0x0070E149
		public static void AddA(FlatBufferBuilder builder, float a)
		{
			builder.AddFloat(3, a, 0.0);
		}

		// Token: 0x06034741 RID: 214849 RVA: 0x0070FF5C File Offset: 0x0070E15C
		public static void AddRoll(FlatBufferBuilder builder, float roll)
		{
			builder.AddFloat(4, roll, 0.0);
		}

		// Token: 0x06034742 RID: 214850 RVA: 0x0070FF6F File Offset: 0x0070E16F
		public static void AddPitch(FlatBufferBuilder builder, float pitch)
		{
			builder.AddFloat(5, pitch, 0.0);
		}

		// Token: 0x06034743 RID: 214851 RVA: 0x0070FF82 File Offset: 0x0070E182
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06034744 RID: 214852 RVA: 0x0070FF8D File Offset: 0x0070E18D
		public static Offset<IPosAndRot> EndIPosAndRot(FlatBufferBuilder builder)
		{
			return new Offset<IPosAndRot>(builder.EndTable());
		}

		// Token: 0x06034745 RID: 214853 RVA: 0x0070FF9C File Offset: 0x0070E19C
		public IPosAndRotT UnPack()
		{
			IPosAndRotT posAndRotT = new IPosAndRotT();
			this.UnPackTo(posAndRotT);
			return posAndRotT;
		}

		// Token: 0x06034746 RID: 214854 RVA: 0x0070FFB8 File Offset: 0x0070E1B8
		public void UnPackTo(IPosAndRotT _o)
		{
			_o.X = this.X;
			_o.Y = this.Y;
			_o.Z = this.Z;
			_o.A = this.A;
			_o.Roll = this.Roll;
			_o.Pitch = this.Pitch;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06034747 RID: 214855 RVA: 0x0071001C File Offset: 0x0070E21C
		public static Offset<IPosAndRot> Pack(FlatBufferBuilder builder, IPosAndRotT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPosAndRot>);
			}
			return IPosAndRot.CreateIPosAndRot(builder, _o.X, _o.Y, _o.Z, _o.A, _o.Roll, _o.Pitch, _o.NullMask);
		}

		// Token: 0x04012699 RID: 75417
		private Table __p;
	}
}
