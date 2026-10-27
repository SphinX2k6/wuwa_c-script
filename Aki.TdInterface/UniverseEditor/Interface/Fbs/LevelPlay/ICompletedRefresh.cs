using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004449 RID: 17481
	public struct ICompletedRefresh : IFlatbufferObject
	{
		// Token: 0x17007B2B RID: 31531
		// (get) Token: 0x0601A028 RID: 106536 RVA: 0x003B7B5C File Offset: 0x003B5D5C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A029 RID: 106537 RVA: 0x003B7B69 File Offset: 0x003B5D69
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A02A RID: 106538 RVA: 0x003B7B70 File Offset: 0x003B5D70
		public static ICompletedRefresh GetRootAsICompletedRefresh(ByteBuffer _bb)
		{
			return ICompletedRefresh.GetRootAsICompletedRefresh(_bb, default(ICompletedRefresh));
		}

		// Token: 0x0601A02B RID: 106539 RVA: 0x003B7B8C File Offset: 0x003B5D8C
		public static ICompletedRefresh GetRootAsICompletedRefresh(ByteBuffer _bb, ICompletedRefresh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A02C RID: 106540 RVA: 0x003B7BA9 File Offset: 0x003B5DA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A02D RID: 106541 RVA: 0x003B7BB8 File Offset: 0x003B5DB8
		public ICompletedRefresh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007B2C RID: 31532
		// (get) Token: 0x0601A02E RID: 106542 RVA: 0x003B7BC8 File Offset: 0x003B5DC8
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

		// Token: 0x17007B2D RID: 31533
		// (get) Token: 0x0601A02F RID: 106543 RVA: 0x003B7C04 File Offset: 0x003B5E04
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

		// Token: 0x17007B2E RID: 31534
		// (get) Token: 0x0601A030 RID: 106544 RVA: 0x003B7C40 File Offset: 0x003B5E40
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

		// Token: 0x0601A031 RID: 106545 RVA: 0x003B7C7C File Offset: 0x003B5E7C
		public static Offset<ICompletedRefresh> CreateICompletedRefresh(FlatBufferBuilder builder, ELevelPlayRefreshType Type = ELevelPlayRefreshType.None, int MinRefreshCd = 0, int MaxRefreshCd = 0)
		{
			builder.StartTable(3);
			ICompletedRefresh.AddMaxRefreshCd(builder, MaxRefreshCd);
			ICompletedRefresh.AddMinRefreshCd(builder, MinRefreshCd);
			ICompletedRefresh.AddType(builder, Type);
			return ICompletedRefresh.EndICompletedRefresh(builder);
		}

		// Token: 0x0601A032 RID: 106546 RVA: 0x003B7CA0 File Offset: 0x003B5EA0
		public static void StartICompletedRefresh(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601A033 RID: 106547 RVA: 0x003B7CA9 File Offset: 0x003B5EA9
		public static void AddType(FlatBufferBuilder builder, ELevelPlayRefreshType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A034 RID: 106548 RVA: 0x003B7CB4 File Offset: 0x003B5EB4
		public static void AddMinRefreshCd(FlatBufferBuilder builder, int minRefreshCd)
		{
			builder.AddInt(1, minRefreshCd, 0);
		}

		// Token: 0x0601A035 RID: 106549 RVA: 0x003B7CBF File Offset: 0x003B5EBF
		public static void AddMaxRefreshCd(FlatBufferBuilder builder, int maxRefreshCd)
		{
			builder.AddInt(2, maxRefreshCd, 0);
		}

		// Token: 0x0601A036 RID: 106550 RVA: 0x003B7CCA File Offset: 0x003B5ECA
		public static Offset<ICompletedRefresh> EndICompletedRefresh(FlatBufferBuilder builder)
		{
			return new Offset<ICompletedRefresh>(builder.EndTable());
		}

		// Token: 0x0601A037 RID: 106551 RVA: 0x003B7CD8 File Offset: 0x003B5ED8
		public ICompletedRefreshT UnPack()
		{
			ICompletedRefreshT completedRefreshT = new ICompletedRefreshT();
			this.UnPackTo(completedRefreshT);
			return completedRefreshT;
		}

		// Token: 0x0601A038 RID: 106552 RVA: 0x003B7CF3 File Offset: 0x003B5EF3
		public void UnPackTo(ICompletedRefreshT _o)
		{
			_o.Type = this.Type;
			_o.MinRefreshCd = this.MinRefreshCd;
			_o.MaxRefreshCd = this.MaxRefreshCd;
		}

		// Token: 0x0601A039 RID: 106553 RVA: 0x003B7D1C File Offset: 0x003B5F1C
		public static Offset<ICompletedRefresh> Pack(FlatBufferBuilder builder, ICompletedRefreshT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompletedRefresh>);
			}
			return ICompletedRefresh.CreateICompletedRefresh(builder, _o.Type, _o.MinRefreshCd, _o.MaxRefreshCd);
		}

		// Token: 0x0400C418 RID: 50200
		private Table __p;
	}
}
