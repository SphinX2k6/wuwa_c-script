using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006699 RID: 26265
	public struct IEnableTemporaryTeleport : IFlatbufferObject
	{
		// Token: 0x1700C331 RID: 49969
		// (get) Token: 0x0602DA69 RID: 186985 RVA: 0x0063F649 File Offset: 0x0063D849
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DA6A RID: 186986 RVA: 0x0063F656 File Offset: 0x0063D856
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DA6B RID: 186987 RVA: 0x0063F660 File Offset: 0x0063D860
		public static IEnableTemporaryTeleport GetRootAsIEnableTemporaryTeleport(ByteBuffer _bb)
		{
			return IEnableTemporaryTeleport.GetRootAsIEnableTemporaryTeleport(_bb, default(IEnableTemporaryTeleport));
		}

		// Token: 0x0602DA6C RID: 186988 RVA: 0x0063F67C File Offset: 0x0063D87C
		public static IEnableTemporaryTeleport GetRootAsIEnableTemporaryTeleport(ByteBuffer _bb, IEnableTemporaryTeleport obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DA6D RID: 186989 RVA: 0x0063F699 File Offset: 0x0063D899
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DA6E RID: 186990 RVA: 0x0063F6A8 File Offset: 0x0063D8A8
		public IEnableTemporaryTeleport __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C332 RID: 49970
		// (get) Token: 0x0602DA6F RID: 186991 RVA: 0x0063F6B8 File Offset: 0x0063D8B8
		public bool Enable
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C333 RID: 49971
		// (get) Token: 0x0602DA70 RID: 186992 RVA: 0x0063F6F8 File Offset: 0x0063D8F8
		public int RangeEntity
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

		// Token: 0x0602DA71 RID: 186993 RVA: 0x0063F734 File Offset: 0x0063D934
		public static Offset<IEnableTemporaryTeleport> CreateIEnableTemporaryTeleport(FlatBufferBuilder builder, bool Enable = false, int RangeEntity = 0)
		{
			builder.StartTable(2);
			IEnableTemporaryTeleport.AddRangeEntity(builder, RangeEntity);
			IEnableTemporaryTeleport.AddEnable(builder, Enable);
			return IEnableTemporaryTeleport.EndIEnableTemporaryTeleport(builder);
		}

		// Token: 0x0602DA72 RID: 186994 RVA: 0x0063F751 File Offset: 0x0063D951
		public static void StartIEnableTemporaryTeleport(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602DA73 RID: 186995 RVA: 0x0063F75A File Offset: 0x0063D95A
		public static void AddEnable(FlatBufferBuilder builder, bool enable)
		{
			builder.AddBool(0, enable, false);
		}

		// Token: 0x0602DA74 RID: 186996 RVA: 0x0063F765 File Offset: 0x0063D965
		public static void AddRangeEntity(FlatBufferBuilder builder, int rangeEntity)
		{
			builder.AddInt(1, rangeEntity, 0);
		}

		// Token: 0x0602DA75 RID: 186997 RVA: 0x0063F770 File Offset: 0x0063D970
		public static Offset<IEnableTemporaryTeleport> EndIEnableTemporaryTeleport(FlatBufferBuilder builder)
		{
			return new Offset<IEnableTemporaryTeleport>(builder.EndTable());
		}

		// Token: 0x0602DA76 RID: 186998 RVA: 0x0063F780 File Offset: 0x0063D980
		public IEnableTemporaryTeleportT UnPack()
		{
			IEnableTemporaryTeleportT enableTemporaryTeleportT = new IEnableTemporaryTeleportT();
			this.UnPackTo(enableTemporaryTeleportT);
			return enableTemporaryTeleportT;
		}

		// Token: 0x0602DA77 RID: 186999 RVA: 0x0063F79B File Offset: 0x0063D99B
		public void UnPackTo(IEnableTemporaryTeleportT _o)
		{
			_o.Enable = this.Enable;
			_o.RangeEntity = this.RangeEntity;
		}

		// Token: 0x0602DA78 RID: 187000 RVA: 0x0063F7B8 File Offset: 0x0063D9B8
		public static Offset<IEnableTemporaryTeleport> Pack(FlatBufferBuilder builder, IEnableTemporaryTeleportT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableTemporaryTeleport>);
			}
			return IEnableTemporaryTeleport.CreateIEnableTemporaryTeleport(builder, _o.Enable, _o.RangeEntity);
		}

		// Token: 0x04010D54 RID: 68948
		private Table __p;
	}
}
