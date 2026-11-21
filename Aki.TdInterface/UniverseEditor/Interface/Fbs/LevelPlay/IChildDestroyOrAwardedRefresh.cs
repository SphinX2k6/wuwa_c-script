using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048AB RID: 18603
	public struct IChildDestroyOrAwardedRefresh : IFlatbufferObject
	{
		// Token: 0x1700815C RID: 33116
		// (get) Token: 0x0601B7C5 RID: 112581 RVA: 0x003E3741 File Offset: 0x003E1941
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B7C6 RID: 112582 RVA: 0x003E374E File Offset: 0x003E194E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B7C7 RID: 112583 RVA: 0x003E3758 File Offset: 0x003E1958
		public static IChildDestroyOrAwardedRefresh GetRootAsIChildDestroyOrAwardedRefresh(ByteBuffer _bb)
		{
			return IChildDestroyOrAwardedRefresh.GetRootAsIChildDestroyOrAwardedRefresh(_bb, default(IChildDestroyOrAwardedRefresh));
		}

		// Token: 0x0601B7C8 RID: 112584 RVA: 0x003E3774 File Offset: 0x003E1974
		public static IChildDestroyOrAwardedRefresh GetRootAsIChildDestroyOrAwardedRefresh(ByteBuffer _bb, IChildDestroyOrAwardedRefresh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B7C9 RID: 112585 RVA: 0x003E3791 File Offset: 0x003E1991
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B7CA RID: 112586 RVA: 0x003E37A0 File Offset: 0x003E19A0
		public IChildDestroyOrAwardedRefresh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700815D RID: 33117
		// (get) Token: 0x0601B7CB RID: 112587 RVA: 0x003E37B0 File Offset: 0x003E19B0
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

		// Token: 0x1700815E RID: 33118
		// (get) Token: 0x0601B7CC RID: 112588 RVA: 0x003E37EC File Offset: 0x003E19EC
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

		// Token: 0x1700815F RID: 33119
		// (get) Token: 0x0601B7CD RID: 112589 RVA: 0x003E384C File Offset: 0x003E1A4C
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

		// Token: 0x0601B7CE RID: 112590 RVA: 0x003E38A9 File Offset: 0x003E1AA9
		public static Offset<IChildDestroyOrAwardedRefresh> CreateIChildDestroyOrAwardedRefresh(FlatBufferBuilder builder, ELevelPlayRefreshType Type = ELevelPlayRefreshType.None, Offset<ILevelPlayRefreshCd> AwardedRefreshCdOffset = default(Offset<ILevelPlayRefreshCd>), Offset<ILevelPlayRefreshCd> ChildDestroyRefreshCdOffset = default(Offset<ILevelPlayRefreshCd>))
		{
			builder.StartTable(3);
			IChildDestroyOrAwardedRefresh.AddChildDestroyRefreshCd(builder, ChildDestroyRefreshCdOffset);
			IChildDestroyOrAwardedRefresh.AddAwardedRefreshCd(builder, AwardedRefreshCdOffset);
			IChildDestroyOrAwardedRefresh.AddType(builder, Type);
			return IChildDestroyOrAwardedRefresh.EndIChildDestroyOrAwardedRefresh(builder);
		}

		// Token: 0x0601B7CF RID: 112591 RVA: 0x003E38CD File Offset: 0x003E1ACD
		public static void StartIChildDestroyOrAwardedRefresh(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601B7D0 RID: 112592 RVA: 0x003E38D6 File Offset: 0x003E1AD6
		public static void AddType(FlatBufferBuilder builder, ELevelPlayRefreshType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B7D1 RID: 112593 RVA: 0x003E38E1 File Offset: 0x003E1AE1
		public static void AddAwardedRefreshCd(FlatBufferBuilder builder, Offset<ILevelPlayRefreshCd> awardedRefreshCdOffset)
		{
			builder.AddOffset(1, awardedRefreshCdOffset.Value, 0);
		}

		// Token: 0x0601B7D2 RID: 112594 RVA: 0x003E38F1 File Offset: 0x003E1AF1
		public static void AddChildDestroyRefreshCd(FlatBufferBuilder builder, Offset<ILevelPlayRefreshCd> childDestroyRefreshCdOffset)
		{
			builder.AddOffset(2, childDestroyRefreshCdOffset.Value, 0);
		}

		// Token: 0x0601B7D3 RID: 112595 RVA: 0x003E3901 File Offset: 0x003E1B01
		public static Offset<IChildDestroyOrAwardedRefresh> EndIChildDestroyOrAwardedRefresh(FlatBufferBuilder builder)
		{
			return new Offset<IChildDestroyOrAwardedRefresh>(builder.EndTable());
		}

		// Token: 0x0601B7D4 RID: 112596 RVA: 0x003E3910 File Offset: 0x003E1B10
		public IChildDestroyOrAwardedRefreshT UnPack()
		{
			IChildDestroyOrAwardedRefreshT childDestroyOrAwardedRefreshT = new IChildDestroyOrAwardedRefreshT();
			this.UnPackTo(childDestroyOrAwardedRefreshT);
			return childDestroyOrAwardedRefreshT;
		}

		// Token: 0x0601B7D5 RID: 112597 RVA: 0x003E392C File Offset: 0x003E1B2C
		public void UnPackTo(IChildDestroyOrAwardedRefreshT _o)
		{
			_o.Type = this.Type;
			_o.AwardedRefreshCd = ((this.AwardedRefreshCd != null) ? this.AwardedRefreshCd.Value.UnPack() : null);
			_o.ChildDestroyRefreshCd = ((this.ChildDestroyRefreshCd != null) ? this.ChildDestroyRefreshCd.Value.UnPack() : null);
		}

		// Token: 0x0601B7D6 RID: 112598 RVA: 0x003E39A4 File Offset: 0x003E1BA4
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

		// Token: 0x0400CE3E RID: 52798
		private Table __p;
	}
}
