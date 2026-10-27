using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EEE RID: 3822
	public struct PhantomLevel : IFlatbufferObject
	{
		// Token: 0x17002714 RID: 10004
		// (get) Token: 0x0600A975 RID: 43381 RVA: 0x002B51AD File Offset: 0x002B33AD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A976 RID: 43382 RVA: 0x002B51BA File Offset: 0x002B33BA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A977 RID: 43383 RVA: 0x002B51C4 File Offset: 0x002B33C4
		public static PhantomLevel GetRootAsPhantomLevel(ByteBuffer _bb)
		{
			return PhantomLevel.GetRootAsPhantomLevel(_bb, default(PhantomLevel));
		}

		// Token: 0x0600A978 RID: 43384 RVA: 0x002B51E0 File Offset: 0x002B33E0
		public static PhantomLevel GetRootAsPhantomLevel(ByteBuffer _bb, PhantomLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A979 RID: 43385 RVA: 0x002B51FD File Offset: 0x002B33FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A97A RID: 43386 RVA: 0x002B520C File Offset: 0x002B340C
		public PhantomLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002715 RID: 10005
		// (get) Token: 0x0600A97B RID: 43387 RVA: 0x002B521C File Offset: 0x002B341C
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

		// Token: 0x17002716 RID: 10006
		// (get) Token: 0x0600A97C RID: 43388 RVA: 0x002B5258 File Offset: 0x002B3458
		public int GroupId
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

		// Token: 0x17002717 RID: 10007
		// (get) Token: 0x0600A97D RID: 43389 RVA: 0x002B5294 File Offset: 0x002B3494
		public int Level
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

		// Token: 0x17002718 RID: 10008
		// (get) Token: 0x0600A97E RID: 43390 RVA: 0x002B52D0 File Offset: 0x002B34D0
		public int Exp
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

		// Token: 0x04004FB0 RID: 20400
		private Table __p;
	}
}
