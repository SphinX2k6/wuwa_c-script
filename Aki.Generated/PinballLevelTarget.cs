using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001013 RID: 4115
	public struct PinballLevelTarget : IFlatbufferObject
	{
		// Token: 0x170029CB RID: 10699
		// (get) Token: 0x0600B554 RID: 46420 RVA: 0x002DF06C File Offset: 0x002DD26C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B555 RID: 46421 RVA: 0x002DF079 File Offset: 0x002DD279
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B556 RID: 46422 RVA: 0x002DF080 File Offset: 0x002DD280
		public static PinballLevelTarget GetRootAsPinballLevelTarget(ByteBuffer _bb)
		{
			return PinballLevelTarget.GetRootAsPinballLevelTarget(_bb, default(PinballLevelTarget));
		}

		// Token: 0x0600B557 RID: 46423 RVA: 0x002DF09C File Offset: 0x002DD29C
		public static PinballLevelTarget GetRootAsPinballLevelTarget(ByteBuffer _bb, PinballLevelTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B558 RID: 46424 RVA: 0x002DF0B9 File Offset: 0x002DD2B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B559 RID: 46425 RVA: 0x002DF0C8 File Offset: 0x002DD2C8
		public PinballLevelTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170029CC RID: 10700
		// (get) Token: 0x0600B55A RID: 46426 RVA: 0x002DF0D8 File Offset: 0x002DD2D8
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

		// Token: 0x170029CD RID: 10701
		// (get) Token: 0x0600B55B RID: 46427 RVA: 0x002DF114 File Offset: 0x002DD314
		public int CondType
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

		// Token: 0x170029CE RID: 10702
		// (get) Token: 0x0600B55C RID: 46428 RVA: 0x002DF150 File Offset: 0x002DD350
		public string CondDesc
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

		// Token: 0x0600B55D RID: 46429 RVA: 0x002DF187 File Offset: 0x002DD387
		public Span<byte> GetCondDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B55E RID: 46430 RVA: 0x002DF196 File Offset: 0x002DD396
		public byte[] GetCondDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170029CF RID: 10703
		// (get) Token: 0x0600B55F RID: 46431 RVA: 0x002DF1B0 File Offset: 0x002DD3B0
		public int NeedNum
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

		// Token: 0x040055DD RID: 21981
		private Table __p;
	}
}
