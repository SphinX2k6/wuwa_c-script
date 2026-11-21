using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012A4 RID: 4772
	public struct TrapDefenseSpecialCellType : IFlatbufferObject
	{
		// Token: 0x17003FE0 RID: 16352
		// (get) Token: 0x0600F1F0 RID: 61936 RVA: 0x003658F5 File Offset: 0x00363AF5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F1F1 RID: 61937 RVA: 0x00365902 File Offset: 0x00363B02
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F1F2 RID: 61938 RVA: 0x0036590C File Offset: 0x00363B0C
		public static TrapDefenseSpecialCellType GetRootAsTrapDefenseSpecialCellType(ByteBuffer _bb)
		{
			return TrapDefenseSpecialCellType.GetRootAsTrapDefenseSpecialCellType(_bb, default(TrapDefenseSpecialCellType));
		}

		// Token: 0x0600F1F3 RID: 61939 RVA: 0x00365928 File Offset: 0x00363B28
		public static TrapDefenseSpecialCellType GetRootAsTrapDefenseSpecialCellType(ByteBuffer _bb, TrapDefenseSpecialCellType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F1F4 RID: 61940 RVA: 0x00365945 File Offset: 0x00363B45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F1F5 RID: 61941 RVA: 0x00365954 File Offset: 0x00363B54
		public TrapDefenseSpecialCellType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003FE1 RID: 16353
		// (get) Token: 0x0600F1F6 RID: 61942 RVA: 0x00365964 File Offset: 0x00363B64
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

		// Token: 0x17003FE2 RID: 16354
		// (get) Token: 0x0600F1F7 RID: 61943 RVA: 0x003659A0 File Offset: 0x00363BA0
		public int TemplateId
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

		// Token: 0x040058F7 RID: 22775
		private Table __p;
	}
}
