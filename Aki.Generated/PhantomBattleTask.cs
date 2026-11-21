using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FC1 RID: 4033
	public struct PhantomBattleTask : IFlatbufferObject
	{
		// Token: 0x170026F1 RID: 9969
		// (get) Token: 0x0600AE05 RID: 44549 RVA: 0x002CEA37 File Offset: 0x002CCC37
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AE06 RID: 44550 RVA: 0x002CEA44 File Offset: 0x002CCC44
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AE07 RID: 44551 RVA: 0x002CEA4C File Offset: 0x002CCC4C
		public static PhantomBattleTask GetRootAsPhantomBattleTask(ByteBuffer _bb)
		{
			return PhantomBattleTask.GetRootAsPhantomBattleTask(_bb, default(PhantomBattleTask));
		}

		// Token: 0x0600AE08 RID: 44552 RVA: 0x002CEA68 File Offset: 0x002CCC68
		public static PhantomBattleTask GetRootAsPhantomBattleTask(ByteBuffer _bb, PhantomBattleTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AE09 RID: 44553 RVA: 0x002CEA85 File Offset: 0x002CCC85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AE0A RID: 44554 RVA: 0x002CEA94 File Offset: 0x002CCC94
		public PhantomBattleTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170026F2 RID: 9970
		// (get) Token: 0x0600AE0B RID: 44555 RVA: 0x002CEAA4 File Offset: 0x002CCCA4
		public int TaskId
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

		// Token: 0x170026F3 RID: 9971
		// (get) Token: 0x0600AE0C RID: 44556 RVA: 0x002CEAE0 File Offset: 0x002CCCE0
		public int ActivityId
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

		// Token: 0x170026F4 RID: 9972
		// (get) Token: 0x0600AE0D RID: 44557 RVA: 0x002CEB1C File Offset: 0x002CCD1C
		public string Desc
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

		// Token: 0x0600AE0E RID: 44558 RVA: 0x002CEB53 File Offset: 0x002CCD53
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600AE0F RID: 44559 RVA: 0x002CEB62 File Offset: 0x002CCD62
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170026F5 RID: 9973
		// (get) Token: 0x0600AE10 RID: 44560 RVA: 0x002CEB7C File Offset: 0x002CCD7C
		public int LimitShopItemNum
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

		// Token: 0x170026F6 RID: 9974
		// (get) Token: 0x0600AE11 RID: 44561 RVA: 0x002CEBBC File Offset: 0x002CCDBC
		public int NormalDropId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170026F7 RID: 9975
		// (get) Token: 0x0600AE12 RID: 44562 RVA: 0x002CEBFC File Offset: 0x002CCDFC
		public int AccessPath
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170026F8 RID: 9976
		// (get) Token: 0x0600AE13 RID: 44563 RVA: 0x002CEC3C File Offset: 0x002CCE3C
		public int TaskType
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400557F RID: 21887
		private Table __p;
	}
}
