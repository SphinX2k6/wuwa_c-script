using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D81 RID: 3457
	public struct FloroRanchAction : IFlatbufferObject
	{
		// Token: 0x170012D3 RID: 4819
		// (get) Token: 0x06007803 RID: 30723 RVA: 0x002567F8 File Offset: 0x002549F8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007804 RID: 30724 RVA: 0x00256805 File Offset: 0x00254A05
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007805 RID: 30725 RVA: 0x0025680C File Offset: 0x00254A0C
		public static FloroRanchAction GetRootAsFloroRanchAction(ByteBuffer _bb)
		{
			return FloroRanchAction.GetRootAsFloroRanchAction(_bb, default(FloroRanchAction));
		}

		// Token: 0x06007806 RID: 30726 RVA: 0x00256828 File Offset: 0x00254A28
		public static FloroRanchAction GetRootAsFloroRanchAction(ByteBuffer _bb, FloroRanchAction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007807 RID: 30727 RVA: 0x00256845 File Offset: 0x00254A45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007808 RID: 30728 RVA: 0x00256854 File Offset: 0x00254A54
		public FloroRanchAction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170012D4 RID: 4820
		// (get) Token: 0x06007809 RID: 30729 RVA: 0x00256864 File Offset: 0x00254A64
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

		// Token: 0x170012D5 RID: 4821
		// (get) Token: 0x0600780A RID: 30730 RVA: 0x002568A0 File Offset: 0x00254AA0
		public string Desc
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

		// Token: 0x0600780B RID: 30731 RVA: 0x002568D7 File Offset: 0x00254AD7
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600780C RID: 30732 RVA: 0x002568E6 File Offset: 0x00254AE6
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x040052D8 RID: 21208
		private Table __p;
	}
}
