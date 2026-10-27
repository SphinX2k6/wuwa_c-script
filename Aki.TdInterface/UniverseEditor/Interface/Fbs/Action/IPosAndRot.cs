using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D65 RID: 28005
	public struct IPosAndRot : IFlatbufferObject
	{
		// Token: 0x1700D0DB RID: 53467
		// (get) Token: 0x06031732 RID: 202546 RVA: 0x006B4598 File Offset: 0x006B2798
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031733 RID: 202547 RVA: 0x006B45A5 File Offset: 0x006B27A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031734 RID: 202548 RVA: 0x006B45AC File Offset: 0x006B27AC
		public static IPosAndRot GetRootAsIPosAndRot(ByteBuffer _bb)
		{
			return IPosAndRot.GetRootAsIPosAndRot(_bb, default(IPosAndRot));
		}

		// Token: 0x06031735 RID: 202549 RVA: 0x006B45C8 File Offset: 0x006B27C8
		public static IPosAndRot GetRootAsIPosAndRot(ByteBuffer _bb, IPosAndRot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031736 RID: 202550 RVA: 0x006B45E5 File Offset: 0x006B27E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031737 RID: 202551 RVA: 0x006B45F4 File Offset: 0x006B27F4
		public IPosAndRot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D0DC RID: 53468
		// (get) Token: 0x06031738 RID: 202552 RVA: 0x006B4604 File Offset: 0x006B2804
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

		// Token: 0x1700D0DD RID: 53469
		// (get) Token: 0x06031739 RID: 202553 RVA: 0x006B4644 File Offset: 0x006B2844
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

		// Token: 0x1700D0DE RID: 53470
		// (get) Token: 0x0603173A RID: 202554 RVA: 0x006B4684 File Offset: 0x006B2884
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

		// Token: 0x1700D0DF RID: 53471
		// (get) Token: 0x0603173B RID: 202555 RVA: 0x006B46C4 File Offset: 0x006B28C4
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

		// Token: 0x1700D0E0 RID: 53472
		// (get) Token: 0x0603173C RID: 202556 RVA: 0x006B4708 File Offset: 0x006B2908
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

		// Token: 0x1700D0E1 RID: 53473
		// (get) Token: 0x0603173D RID: 202557 RVA: 0x006B474C File Offset: 0x006B294C
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

		// Token: 0x1700D0E2 RID: 53474
		// (get) Token: 0x0603173E RID: 202558 RVA: 0x006B4790 File Offset: 0x006B2990
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

		// Token: 0x0603173F RID: 202559 RVA: 0x006B47D0 File Offset: 0x006B29D0
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

		// Token: 0x06031740 RID: 202560 RVA: 0x006B481F File Offset: 0x006B2A1F
		public static void StartIPosAndRot(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06031741 RID: 202561 RVA: 0x006B4828 File Offset: 0x006B2A28
		public static void AddX(FlatBufferBuilder builder, float x)
		{
			builder.AddFloat(0, x, 0.0);
		}

		// Token: 0x06031742 RID: 202562 RVA: 0x006B483B File Offset: 0x006B2A3B
		public static void AddY(FlatBufferBuilder builder, float y)
		{
			builder.AddFloat(1, y, 0.0);
		}

		// Token: 0x06031743 RID: 202563 RVA: 0x006B484E File Offset: 0x006B2A4E
		public static void AddZ(FlatBufferBuilder builder, float z)
		{
			builder.AddFloat(2, z, 0.0);
		}

		// Token: 0x06031744 RID: 202564 RVA: 0x006B4861 File Offset: 0x006B2A61
		public static void AddA(FlatBufferBuilder builder, float a)
		{
			builder.AddFloat(3, a, 0.0);
		}

		// Token: 0x06031745 RID: 202565 RVA: 0x006B4874 File Offset: 0x006B2A74
		public static void AddRoll(FlatBufferBuilder builder, float roll)
		{
			builder.AddFloat(4, roll, 0.0);
		}

		// Token: 0x06031746 RID: 202566 RVA: 0x006B4887 File Offset: 0x006B2A87
		public static void AddPitch(FlatBufferBuilder builder, float pitch)
		{
			builder.AddFloat(5, pitch, 0.0);
		}

		// Token: 0x06031747 RID: 202567 RVA: 0x006B489A File Offset: 0x006B2A9A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06031748 RID: 202568 RVA: 0x006B48A5 File Offset: 0x006B2AA5
		public static Offset<IPosAndRot> EndIPosAndRot(FlatBufferBuilder builder)
		{
			return new Offset<IPosAndRot>(builder.EndTable());
		}

		// Token: 0x06031749 RID: 202569 RVA: 0x006B48B4 File Offset: 0x006B2AB4
		public IPosAndRotT UnPack()
		{
			IPosAndRotT posAndRotT = new IPosAndRotT();
			this.UnPackTo(posAndRotT);
			return posAndRotT;
		}

		// Token: 0x0603174A RID: 202570 RVA: 0x006B48D0 File Offset: 0x006B2AD0
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

		// Token: 0x0603174B RID: 202571 RVA: 0x006B4934 File Offset: 0x006B2B34
		public static Offset<IPosAndRot> Pack(FlatBufferBuilder builder, IPosAndRotT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPosAndRot>);
			}
			return IPosAndRot.CreateIPosAndRot(builder, _o.X, _o.Y, _o.Z, _o.A, _o.Roll, _o.Pitch, _o.NullMask);
		}

		// Token: 0x0401171D RID: 71453
		private Table __p;
	}
}
