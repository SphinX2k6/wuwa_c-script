using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004443 RID: 17475
	public struct IChildDestroyOrAwardedRefresh : IFlatbufferObject
	{
		// Token: 0x17007B1D RID: 31517
		// (get) Token: 0x06019FF4 RID: 106484 RVA: 0x003B7535 File Offset: 0x003B5735
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019FF5 RID: 106485 RVA: 0x003B7542 File Offset: 0x003B5742
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019FF6 RID: 106486 RVA: 0x003B754C File Offset: 0x003B574C
		public static IChildDestroyOrAwardedRefresh GetRootAsIChildDestroyOrAwardedRefresh(ByteBuffer _bb)
		{
			return IChildDestroyOrAwardedRefresh.GetRootAsIChildDestroyOrAwardedRefresh(_bb, default(IChildDestroyOrAwardedRefresh));
		}

		// Token: 0x06019FF7 RID: 106487 RVA: 0x003B7568 File Offset: 0x003B5768
		public static IChildDestroyOrAwardedRefresh GetRootAsIChildDestroyOrAwardedRefresh(ByteBuffer _bb, IChildDestroyOrAwardedRefresh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019FF8 RID: 106488 RVA: 0x003B7585 File Offset: 0x003B5785
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019FF9 RID: 106489 RVA: 0x003B7594 File Offset: 0x003B5794
		public IChildDestroyOrAwardedRefresh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007B1E RID: 31518
		// (get) Token: 0x06019FFA RID: 106490 RVA: 0x003B75A4 File Offset: 0x003B57A4
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

		// Token: 0x17007B1F RID: 31519
		// (get) Token: 0x06019FFB RID: 106491 RVA: 0x003B75E0 File Offset: 0x003B57E0
		public ILevelPlayRefreshCd? AwardedRefreshCd
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ILevelPlayRefreshCd?(default(ILevelPlayRefreshCd).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007B20 RID: 31520
		// (get) Token: 0x06019FFC RID: 106492 RVA: 0x003B7640 File Offset: 0x003B5840
		public ILevelPlayRefreshCd? ChildDestroyRefreshCd
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new ILevelPlayRefreshCd?(default(ILevelPlayRefreshCd).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06019FFD RID: 106493 RVA: 0x003B769D File Offset: 0x003B589D
		public static Offset<IChildDestroyOrAwardedRefresh> CreateIChildDestroyOrAwardedRefresh(FlatBufferBuilder builder, ELevelPlayRefreshType Type = ELevelPlayRefreshType.None, Offset<ILevelPlayRefreshCd> AwardedRefreshCdOffset = default(Offset<ILevelPlayRefreshCd>), Offset<ILevelPlayRefreshCd> ChildDestroyRefreshCdOffset = default(Offset<ILevelPlayRefreshCd>))
		{
			builder.StartTable(3);
			IChildDestroyOrAwardedRefresh.AddChildDestroyRefreshCd(builder, ChildDestroyRefreshCdOffset);
			IChildDestroyOrAwardedRefresh.AddAwardedRefreshCd(builder, AwardedRefreshCdOffset);
			IChildDestroyOrAwardedRefresh.AddType(builder, Type);
			return IChildDestroyOrAwardedRefresh.EndIChildDestroyOrAwardedRefresh(builder);
		}

		// Token: 0x06019FFE RID: 106494 RVA: 0x003B76C1 File Offset: 0x003B58C1
		public static void StartIChildDestroyOrAwardedRefresh(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06019FFF RID: 106495 RVA: 0x003B76CA File Offset: 0x003B58CA
		public static void AddType(FlatBufferBuilder builder, ELevelPlayRefreshType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A000 RID: 106496 RVA: 0x003B76D5 File Offset: 0x003B58D5
		public static void AddAwardedRefreshCd(FlatBufferBuilder builder, Offset<ILevelPlayRefreshCd> awardedRefreshCdOffset)
		{
			builder.AddOffset(1, awardedRefreshCdOffset.Value, 0);
		}

		// Token: 0x0601A001 RID: 106497 RVA: 0x003B76E5 File Offset: 0x003B58E5
		public static void AddChildDestroyRefreshCd(FlatBufferBuilder builder, Offset<ILevelPlayRefreshCd> childDestroyRefreshCdOffset)
		{
			builder.AddOffset(2, childDestroyRefreshCdOffset.Value, 0);
		}

		// Token: 0x0601A002 RID: 106498 RVA: 0x003B76F5 File Offset: 0x003B58F5
		public static Offset<IChildDestroyOrAwardedRefresh> EndIChildDestroyOrAwardedRefresh(FlatBufferBuilder builder)
		{
			return new Offset<IChildDestroyOrAwardedRefresh>(builder.EndTable());
		}

		// Token: 0x0601A003 RID: 106499 RVA: 0x003B7704 File Offset: 0x003B5904
		public IChildDestroyOrAwardedRefreshT UnPack()
		{
			IChildDestroyOrAwardedRefreshT childDestroyOrAwardedRefreshT = new IChildDestroyOrAwardedRefreshT();
			this.UnPackTo(childDestroyOrAwardedRefreshT);
			return childDestroyOrAwardedRefreshT;
		}

		// Token: 0x0601A004 RID: 106500 RVA: 0x003B7720 File Offset: 0x003B5920
		public void UnPackTo(IChildDestroyOrAwardedRefreshT _o)
		{
			_o.Type = this.Type;
			_o.AwardedRefreshCd = ((this.AwardedRefreshCd != null) ? this.AwardedRefreshCd.Value.UnPack() : null);
			_o.ChildDestroyRefreshCd = ((this.ChildDestroyRefreshCd != null) ? this.ChildDestroyRefreshCd.Value.UnPack() : null);
		}

		// Token: 0x0601A005 RID: 106501 RVA: 0x003B7798 File Offset: 0x003B5998
		public static Offset<IChildDestroyOrAwardedRefresh> Pack(FlatBufferBuilder builder, IChildDestroyOrAwardedRefreshT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChildDestroyOrAwardedRefresh>);
			}
			Offset<ILevelPlayRefreshCd> awardedRefreshCdOffset = (_o.AwardedRefreshCd == null) ? default(Offset<ILevelPlayRefreshCd>) : ILevelPlayRefreshCd.Pack(builder, _o.AwardedRefreshCd);
			Offset<ILevelPlayRefreshCd> childDestroyRefreshCdOffset = (_o.ChildDestroyRefreshCd == null) ? default(Offset<ILevelPlayRefreshCd>) : ILevelPlayRefreshCd.Pack(builder, _o.ChildDestroyRefreshCd);
			return IChildDestroyOrAwardedRefresh.CreateIChildDestroyOrAwardedRefresh(builder, _o.Type, awardedRefreshCdOffset, childDestroyRefreshCdOffset);
		}

		// Token: 0x0400C410 RID: 50192
		private Table __p;
	}
}
