using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EA1 RID: 24225
	public struct IRtSize : IFlatbufferObject
	{
		// Token: 0x1700B2E4 RID: 45796
		// (get) Token: 0x0602890A RID: 166154 RVA: 0x0058BC47 File Offset: 0x00589E47
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602890B RID: 166155 RVA: 0x0058BC54 File Offset: 0x00589E54
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602890C RID: 166156 RVA: 0x0058BC5C File Offset: 0x00589E5C
		public static IRtSize GetRootAsIRtSize(ByteBuffer _bb)
		{
			return IRtSize.GetRootAsIRtSize(_bb, default(IRtSize));
		}

		// Token: 0x0602890D RID: 166157 RVA: 0x0058BC78 File Offset: 0x00589E78
		public static IRtSize GetRootAsIRtSize(ByteBuffer _bb, IRtSize obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602890E RID: 166158 RVA: 0x0058BC95 File Offset: 0x00589E95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602890F RID: 166159 RVA: 0x0058BCA4 File Offset: 0x00589EA4
		public IRtSize __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B2E5 RID: 45797
		// (get) Token: 0x06028910 RID: 166160 RVA: 0x0058BCB4 File Offset: 0x00589EB4
		public int Length
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

		// Token: 0x1700B2E6 RID: 45798
		// (get) Token: 0x06028911 RID: 166161 RVA: 0x0058BCF0 File Offset: 0x00589EF0
		public int Width
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

		// Token: 0x06028912 RID: 166162 RVA: 0x0058BD2C File Offset: 0x00589F2C
		public static Offset<IRtSize> CreateIRtSize(FlatBufferBuilder builder, int Length = 0, int Width = 0)
		{
			builder.StartTable(2);
			IRtSize.AddWidth(builder, Width);
			IRtSize.AddLength(builder, Length);
			return IRtSize.EndIRtSize(builder);
		}

		// Token: 0x06028913 RID: 166163 RVA: 0x0058BD49 File Offset: 0x00589F49
		public static void StartIRtSize(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06028914 RID: 166164 RVA: 0x0058BD52 File Offset: 0x00589F52
		public static void AddLength(FlatBufferBuilder builder, int length)
		{
			builder.AddInt(0, length, 0);
		}

		// Token: 0x06028915 RID: 166165 RVA: 0x0058BD5D File Offset: 0x00589F5D
		public static void AddWidth(FlatBufferBuilder builder, int width)
		{
			builder.AddInt(1, width, 0);
		}

		// Token: 0x06028916 RID: 166166 RVA: 0x0058BD68 File Offset: 0x00589F68
		public static Offset<IRtSize> EndIRtSize(FlatBufferBuilder builder)
		{
			return new Offset<IRtSize>(builder.EndTable());
		}

		// Token: 0x06028917 RID: 166167 RVA: 0x0058BD78 File Offset: 0x00589F78
		public IRtSizeT UnPack()
		{
			IRtSizeT rtSizeT = new IRtSizeT();
			this.UnPackTo(rtSizeT);
			return rtSizeT;
		}

		// Token: 0x06028918 RID: 166168 RVA: 0x0058BD93 File Offset: 0x00589F93
		public void UnPackTo(IRtSizeT _o)
		{
			_o.Length = this.Length;
			_o.Width = this.Width;
		}

		// Token: 0x06028919 RID: 166169 RVA: 0x0058BDB0 File Offset: 0x00589FB0
		public static Offset<IRtSize> Pack(FlatBufferBuilder builder, IRtSizeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRtSize>);
			}
			return IRtSize.CreateIRtSize(builder, _o.Length, _o.Width);
		}

		// Token: 0x0400FAE4 RID: 64228
		private Table __p;
	}
}
