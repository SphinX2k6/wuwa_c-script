using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044CD RID: 17613
	public struct IFixedDateTimeRefresh : IFlatbufferObject
	{
		// Token: 0x17007C51 RID: 31825
		// (get) Token: 0x0601A52C RID: 107820 RVA: 0x003C21D2 File Offset: 0x003C03D2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A52D RID: 107821 RVA: 0x003C21DF File Offset: 0x003C03DF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A52E RID: 107822 RVA: 0x003C21E8 File Offset: 0x003C03E8
		public static IFixedDateTimeRefresh GetRootAsIFixedDateTimeRefresh(ByteBuffer _bb)
		{
			return IFixedDateTimeRefresh.GetRootAsIFixedDateTimeRefresh(_bb, default(IFixedDateTimeRefresh));
		}

		// Token: 0x0601A52F RID: 107823 RVA: 0x003C2204 File Offset: 0x003C0404
		public static IFixedDateTimeRefresh GetRootAsIFixedDateTimeRefresh(ByteBuffer _bb, IFixedDateTimeRefresh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A530 RID: 107824 RVA: 0x003C2221 File Offset: 0x003C0421
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A531 RID: 107825 RVA: 0x003C2230 File Offset: 0x003C0430
		public IFixedDateTimeRefresh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007C52 RID: 31826
		// (get) Token: 0x0601A532 RID: 107826 RVA: 0x003C2240 File Offset: 0x003C0440
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

		// Token: 0x17007C53 RID: 31827
		// (get) Token: 0x0601A533 RID: 107827 RVA: 0x003C227C File Offset: 0x003C047C
		public ELevelPlayInteractResetTime UpdateType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ELevelPlayInteractResetTime.Weekly;
				}
				return (ELevelPlayInteractResetTime)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A534 RID: 107828 RVA: 0x003C22B8 File Offset: 0x003C04B8
		public static Offset<IFixedDateTimeRefresh> CreateIFixedDateTimeRefresh(FlatBufferBuilder builder, ELevelPlayRefreshType Type = ELevelPlayRefreshType.None, ELevelPlayInteractResetTime UpdateType = ELevelPlayInteractResetTime.Weekly)
		{
			builder.StartTable(2);
			IFixedDateTimeRefresh.AddUpdateType(builder, UpdateType);
			IFixedDateTimeRefresh.AddType(builder, Type);
			return IFixedDateTimeRefresh.EndIFixedDateTimeRefresh(builder);
		}

		// Token: 0x0601A535 RID: 107829 RVA: 0x003C22D5 File Offset: 0x003C04D5
		public static void StartIFixedDateTimeRefresh(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601A536 RID: 107830 RVA: 0x003C22DE File Offset: 0x003C04DE
		public static void AddType(FlatBufferBuilder builder, ELevelPlayRefreshType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A537 RID: 107831 RVA: 0x003C22E9 File Offset: 0x003C04E9
		public static void AddUpdateType(FlatBufferBuilder builder, ELevelPlayInteractResetTime updateType)
		{
			builder.AddByte(1, (byte)updateType, 0);
		}

		// Token: 0x0601A538 RID: 107832 RVA: 0x003C22F4 File Offset: 0x003C04F4
		public static Offset<IFixedDateTimeRefresh> EndIFixedDateTimeRefresh(FlatBufferBuilder builder)
		{
			return new Offset<IFixedDateTimeRefresh>(builder.EndTable());
		}

		// Token: 0x0601A539 RID: 107833 RVA: 0x003C2304 File Offset: 0x003C0504
		public IFixedDateTimeRefreshT UnPack()
		{
			IFixedDateTimeRefreshT fixedDateTimeRefreshT = new IFixedDateTimeRefreshT();
			this.UnPackTo(fixedDateTimeRefreshT);
			return fixedDateTimeRefreshT;
		}

		// Token: 0x0601A53A RID: 107834 RVA: 0x003C231F File Offset: 0x003C051F
		public void UnPackTo(IFixedDateTimeRefreshT _o)
		{
			_o.Type = this.Type;
			_o.UpdateType = this.UpdateType;
		}

		// Token: 0x0601A53B RID: 107835 RVA: 0x003C233C File Offset: 0x003C053C
		public static Offset<IFixedDateTimeRefresh> Pack(FlatBufferBuilder builder, IFixedDateTimeRefreshT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFixedDateTimeRefresh>);
			}
			return IFixedDateTimeRefresh.CreateIFixedDateTimeRefresh(builder, _o.Type, _o.UpdateType);
		}

		// Token: 0x0400C4E5 RID: 50405
		private Table __p;
	}
}
