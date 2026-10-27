using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004446 RID: 17478
	public struct IChildDestroyRefresh : IFlatbufferObject
	{
		// Token: 0x17007B24 RID: 31524
		// (get) Token: 0x0601A00E RID: 106510 RVA: 0x003B78CA File Offset: 0x003B5ACA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A00F RID: 106511 RVA: 0x003B78D7 File Offset: 0x003B5AD7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A010 RID: 106512 RVA: 0x003B78E0 File Offset: 0x003B5AE0
		public static IChildDestroyRefresh GetRootAsIChildDestroyRefresh(ByteBuffer _bb)
		{
			return IChildDestroyRefresh.GetRootAsIChildDestroyRefresh(_bb, default(IChildDestroyRefresh));
		}

		// Token: 0x0601A011 RID: 106513 RVA: 0x003B78FC File Offset: 0x003B5AFC
		public static IChildDestroyRefresh GetRootAsIChildDestroyRefresh(ByteBuffer _bb, IChildDestroyRefresh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A012 RID: 106514 RVA: 0x003B7919 File Offset: 0x003B5B19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A013 RID: 106515 RVA: 0x003B7928 File Offset: 0x003B5B28
		public IChildDestroyRefresh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007B25 RID: 31525
		// (get) Token: 0x0601A014 RID: 106516 RVA: 0x003B7938 File Offset: 0x003B5B38
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

		// Token: 0x17007B26 RID: 31526
		// (get) Token: 0x0601A015 RID: 106517 RVA: 0x003B7974 File Offset: 0x003B5B74
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

		// Token: 0x17007B27 RID: 31527
		// (get) Token: 0x0601A016 RID: 106518 RVA: 0x003B79B0 File Offset: 0x003B5BB0
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

		// Token: 0x0601A017 RID: 106519 RVA: 0x003B79EC File Offset: 0x003B5BEC
		public static Offset<IChildDestroyRefresh> CreateIChildDestroyRefresh(FlatBufferBuilder builder, ELevelPlayRefreshType Type = ELevelPlayRefreshType.None, int MinRefreshCd = 0, int MaxRefreshCd = 0)
		{
			builder.StartTable(3);
			IChildDestroyRefresh.AddMaxRefreshCd(builder, MaxRefreshCd);
			IChildDestroyRefresh.AddMinRefreshCd(builder, MinRefreshCd);
			IChildDestroyRefresh.AddType(builder, Type);
			return IChildDestroyRefresh.EndIChildDestroyRefresh(builder);
		}

		// Token: 0x0601A018 RID: 106520 RVA: 0x003B7A10 File Offset: 0x003B5C10
		public static void StartIChildDestroyRefresh(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601A019 RID: 106521 RVA: 0x003B7A19 File Offset: 0x003B5C19
		public static void AddType(FlatBufferBuilder builder, ELevelPlayRefreshType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A01A RID: 106522 RVA: 0x003B7A24 File Offset: 0x003B5C24
		public static void AddMinRefreshCd(FlatBufferBuilder builder, int minRefreshCd)
		{
			builder.AddInt(1, minRefreshCd, 0);
		}

		// Token: 0x0601A01B RID: 106523 RVA: 0x003B7A2F File Offset: 0x003B5C2F
		public static void AddMaxRefreshCd(FlatBufferBuilder builder, int maxRefreshCd)
		{
			builder.AddInt(2, maxRefreshCd, 0);
		}

		// Token: 0x0601A01C RID: 106524 RVA: 0x003B7A3A File Offset: 0x003B5C3A
		public static Offset<IChildDestroyRefresh> EndIChildDestroyRefresh(FlatBufferBuilder builder)
		{
			return new Offset<IChildDestroyRefresh>(builder.EndTable());
		}

		// Token: 0x0601A01D RID: 106525 RVA: 0x003B7A48 File Offset: 0x003B5C48
		public IChildDestroyRefreshT UnPack()
		{
			IChildDestroyRefreshT childDestroyRefreshT = new IChildDestroyRefreshT();
			this.UnPackTo(childDestroyRefreshT);
			return childDestroyRefreshT;
		}

		// Token: 0x0601A01E RID: 106526 RVA: 0x003B7A63 File Offset: 0x003B5C63
		public void UnPackTo(IChildDestroyRefreshT _o)
		{
			_o.Type = this.Type;
			_o.MinRefreshCd = this.MinRefreshCd;
			_o.MaxRefreshCd = this.MaxRefreshCd;
		}

		// Token: 0x0601A01F RID: 106527 RVA: 0x003B7A8C File Offset: 0x003B5C8C
		public static Offset<IChildDestroyRefresh> Pack(FlatBufferBuilder builder, IChildDestroyRefreshT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChildDestroyRefresh>);
			}
			return IChildDestroyRefresh.CreateIChildDestroyRefresh(builder, _o.Type, _o.MinRefreshCd, _o.MaxRefreshCd);
		}

		// Token: 0x0400C414 RID: 50196
		private Table __p;
	}
}
