using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BAC RID: 2988
	public struct CustomizedThumbnail : IFlatbufferObject
	{
		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x06005A90 RID: 23184 RVA: 0x00202419 File Offset: 0x00200619
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005A91 RID: 23185 RVA: 0x00202426 File Offset: 0x00200626
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005A92 RID: 23186 RVA: 0x00202430 File Offset: 0x00200630
		public static CustomizedThumbnail GetRootAsCustomizedThumbnail(ByteBuffer _bb)
		{
			return CustomizedThumbnail.GetRootAsCustomizedThumbnail(_bb, default(CustomizedThumbnail));
		}

		// Token: 0x06005A93 RID: 23187 RVA: 0x0020244C File Offset: 0x0020064C
		public static CustomizedThumbnail GetRootAsCustomizedThumbnail(ByteBuffer _bb, CustomizedThumbnail obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005A94 RID: 23188 RVA: 0x00202469 File Offset: 0x00200669
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005A95 RID: 23189 RVA: 0x00202478 File Offset: 0x00200678
		public CustomizedThumbnail __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06005A96 RID: 23190 RVA: 0x00202488 File Offset: 0x00200688
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

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x06005A97 RID: 23191 RVA: 0x002024C4 File Offset: 0x002006C4
		public int AreaId
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

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x06005A98 RID: 23192 RVA: 0x00202500 File Offset: 0x00200700
		public int MarkId
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

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x06005A99 RID: 23193 RVA: 0x0020253C File Offset: 0x0020073C
		public bool DefaultSelected
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04004BCF RID: 19407
		private Table __p;
	}
}
