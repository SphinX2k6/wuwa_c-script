using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048B1 RID: 18609
	public struct ICompletedRefresh : IFlatbufferObject
	{
		// Token: 0x1700816A RID: 33130
		// (get) Token: 0x0601B7F9 RID: 112633 RVA: 0x003E3D68 File Offset: 0x003E1F68
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B7FA RID: 112634 RVA: 0x003E3D75 File Offset: 0x003E1F75
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B7FB RID: 112635 RVA: 0x003E3D7C File Offset: 0x003E1F7C
		public static ICompletedRefresh GetRootAsICompletedRefresh(ByteBuffer _bb)
		{
			return ICompletedRefresh.GetRootAsICompletedRefresh(_bb, default(ICompletedRefresh));
		}

		// Token: 0x0601B7FC RID: 112636 RVA: 0x003E3D98 File Offset: 0x003E1F98
		public static ICompletedRefresh GetRootAsICompletedRefresh(ByteBuffer _bb, ICompletedRefresh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B7FD RID: 112637 RVA: 0x003E3DB5 File Offset: 0x003E1FB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B7FE RID: 112638 RVA: 0x003E3DC4 File Offset: 0x003E1FC4
		public ICompletedRefresh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700816B RID: 33131
		// (get) Token: 0x0601B7FF RID: 112639 RVA: 0x003E3DD4 File Offset: 0x003E1FD4
		public ELevelPlayRefreshType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELevelPlayRefreshType.None;
				}
				return (ELevelPlayRefreshType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700816C RID: 33132
		// (get) Token: 0x0601B800 RID: 112640 RVA: 0x003E3E10 File Offset: 0x003E2010
		public int MinRefreshCd
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

		// Token: 0x1700816D RID: 33133
		// (get) Token: 0x0601B801 RID: 112641 RVA: 0x003E3E4C File Offset: 0x003E204C
		public int MaxRefreshCd
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

		// Token: 0x0601B802 RID: 112642 RVA: 0x003E3E88 File Offset: 0x003E2088
		public static Offset<ICompletedRefresh> CreateICompletedRefresh(FlatBufferBuilder builder, ELevelPlayRefreshType Type = ELevelPlayRefreshType.None, int MinRefreshCd = 0, int MaxRefreshCd = 0)
		{
			builder.StartTable(3);
			ICompletedRefresh.AddMaxRefreshCd(builder, MaxRefreshCd);
			ICompletedRefresh.AddMinRefreshCd(builder, MinRefreshCd);
			ICompletedRefresh.AddType(builder, Type);
			return ICompletedRefresh.EndICompletedRefresh(builder);
		}

		// Token: 0x0601B803 RID: 112643 RVA: 0x003E3EAC File Offset: 0x003E20AC
		public static void StartICompletedRefresh(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601B804 RID: 112644 RVA: 0x003E3EB5 File Offset: 0x003E20B5
		public static void AddType(FlatBufferBuilder builder, ELevelPlayRefreshType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B805 RID: 112645 RVA: 0x003E3EC0 File Offset: 0x003E20C0
		public static void AddMinRefreshCd(FlatBufferBuilder builder, int minRefreshCd)
		{
			builder.AddInt(1, minRefreshCd, 0);
		}

		// Token: 0x0601B806 RID: 112646 RVA: 0x003E3ECB File Offset: 0x003E20CB
		public static void AddMaxRefreshCd(FlatBufferBuilder builder, int maxRefreshCd)
		{
			builder.AddInt(2, maxRefreshCd, 0);
		}

		// Token: 0x0601B807 RID: 112647 RVA: 0x003E3ED6 File Offset: 0x003E20D6
		public static Offset<ICompletedRefresh> EndICompletedRefresh(FlatBufferBuilder builder)
		{
			return new Offset<ICompletedRefresh>(builder.EndTable());
		}

		// Token: 0x0601B808 RID: 112648 RVA: 0x003E3EE4 File Offset: 0x003E20E4
		public ICompletedRefreshT UnPack()
		{
			ICompletedRefreshT completedRefreshT = new ICompletedRefreshT();
			this.UnPackTo(completedRefreshT);
			return completedRefreshT;
		}

		// Token: 0x0601B809 RID: 112649 RVA: 0x003E3EFF File Offset: 0x003E20FF
		public void UnPackTo(ICompletedRefreshT _o)
		{
			_o.Type = this.Type;
			_o.MinRefreshCd = this.MinRefreshCd;
			_o.MaxRefreshCd = this.MaxRefreshCd;
		}

		// Token: 0x0601B80A RID: 112650 RVA: 0x003E3F28 File Offset: 0x003E2128
		public static Offset<ICompletedRefresh> Pack(FlatBufferBuilder builder, ICompletedRefreshT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompletedRefresh>);
			}
			return ICompletedRefresh.CreateICompletedRefresh(builder, _o.Type, _o.MinRefreshCd, _o.MaxRefreshCd);
		}

		// Token: 0x0400CE46 RID: 52806
		private Table __p;
	}
}
