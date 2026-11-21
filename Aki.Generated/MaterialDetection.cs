using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EEA RID: 3818
	public struct MaterialDetection : IFlatbufferObject
	{
		// Token: 0x17001F30 RID: 7984
		// (get) Token: 0x0600997C RID: 39292 RVA: 0x002A1931 File Offset: 0x0029FB31
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600997D RID: 39293 RVA: 0x002A193E File Offset: 0x0029FB3E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600997E RID: 39294 RVA: 0x002A1948 File Offset: 0x0029FB48
		public static MaterialDetection GetRootAsMaterialDetection(ByteBuffer _bb)
		{
			return MaterialDetection.GetRootAsMaterialDetection(_bb, default(MaterialDetection));
		}

		// Token: 0x0600997F RID: 39295 RVA: 0x002A1964 File Offset: 0x0029FB64
		public static MaterialDetection GetRootAsMaterialDetection(ByteBuffer _bb, MaterialDetection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009980 RID: 39296 RVA: 0x002A1981 File Offset: 0x0029FB81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009981 RID: 39297 RVA: 0x002A1990 File Offset: 0x0029FB90
		public MaterialDetection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001F31 RID: 7985
		// (get) Token: 0x06009982 RID: 39298 RVA: 0x002A19A0 File Offset: 0x0029FBA0
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

		// Token: 0x17001F32 RID: 7986
		// (get) Token: 0x06009983 RID: 39299 RVA: 0x002A19DC File Offset: 0x0029FBDC
		public int AccessPathId
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

		// Token: 0x0400548B RID: 21643
		private Table __p;
	}
}
