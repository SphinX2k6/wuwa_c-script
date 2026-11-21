using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004935 RID: 18741
	public struct IFixedDateTimeRefresh : IFlatbufferObject
	{
		// Token: 0x17008290 RID: 33424
		// (get) Token: 0x0601BCFD RID: 113917 RVA: 0x003EE3DE File Offset: 0x003EC5DE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BCFE RID: 113918 RVA: 0x003EE3EB File Offset: 0x003EC5EB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BCFF RID: 113919 RVA: 0x003EE3F4 File Offset: 0x003EC5F4
		public static IFixedDateTimeRefresh GetRootAsIFixedDateTimeRefresh(ByteBuffer _bb)
		{
			return IFixedDateTimeRefresh.GetRootAsIFixedDateTimeRefresh(_bb, default(IFixedDateTimeRefresh));
		}

		// Token: 0x0601BD00 RID: 113920 RVA: 0x003EE410 File Offset: 0x003EC610
		public static IFixedDateTimeRefresh GetRootAsIFixedDateTimeRefresh(ByteBuffer _bb, IFixedDateTimeRefresh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BD01 RID: 113921 RVA: 0x003EE42D File Offset: 0x003EC62D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BD02 RID: 113922 RVA: 0x003EE43C File Offset: 0x003EC63C
		public IFixedDateTimeRefresh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008291 RID: 33425
		// (get) Token: 0x0601BD03 RID: 113923 RVA: 0x003EE44C File Offset: 0x003EC64C
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

		// Token: 0x17008292 RID: 33426
		// (get) Token: 0x0601BD04 RID: 113924 RVA: 0x003EE488 File Offset: 0x003EC688
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

		// Token: 0x0601BD05 RID: 113925 RVA: 0x003EE4C4 File Offset: 0x003EC6C4
		public static Offset<IFixedDateTimeRefresh> CreateIFixedDateTimeRefresh(FlatBufferBuilder builder, ELevelPlayRefreshType Type = ELevelPlayRefreshType.None, ELevelPlayInteractResetTime UpdateType = ELevelPlayInteractResetTime.Weekly)
		{
			builder.StartTable(2);
			IFixedDateTimeRefresh.AddUpdateType(builder, UpdateType);
			IFixedDateTimeRefresh.AddType(builder, Type);
			return IFixedDateTimeRefresh.EndIFixedDateTimeRefresh(builder);
		}

		// Token: 0x0601BD06 RID: 113926 RVA: 0x003EE4E1 File Offset: 0x003EC6E1
		public static void StartIFixedDateTimeRefresh(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601BD07 RID: 113927 RVA: 0x003EE4EA File Offset: 0x003EC6EA
		public static void AddType(FlatBufferBuilder builder, ELevelPlayRefreshType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601BD08 RID: 113928 RVA: 0x003EE4F5 File Offset: 0x003EC6F5
		public static void AddUpdateType(FlatBufferBuilder builder, ELevelPlayInteractResetTime updateType)
		{
			builder.AddByte(1, (byte)updateType, 0);
		}

		// Token: 0x0601BD09 RID: 113929 RVA: 0x003EE500 File Offset: 0x003EC700
		public static Offset<IFixedDateTimeRefresh> EndIFixedDateTimeRefresh(FlatBufferBuilder builder)
		{
			return new Offset<IFixedDateTimeRefresh>(builder.EndTable());
		}

		// Token: 0x0601BD0A RID: 113930 RVA: 0x003EE510 File Offset: 0x003EC710
		public IFixedDateTimeRefreshT UnPack()
		{
			IFixedDateTimeRefreshT fixedDateTimeRefreshT = new IFixedDateTimeRefreshT();
			this.UnPackTo(fixedDateTimeRefreshT);
			return fixedDateTimeRefreshT;
		}

		// Token: 0x0601BD0B RID: 113931 RVA: 0x003EE52B File Offset: 0x003EC72B
		public void UnPackTo(IFixedDateTimeRefreshT _o)
		{
			_o.Type = this.Type;
			_o.UpdateType = this.UpdateType;
		}

		// Token: 0x0601BD0C RID: 113932 RVA: 0x003EE548 File Offset: 0x003EC748
		public static Offset<IFixedDateTimeRefresh> Pack(FlatBufferBuilder builder, IFixedDateTimeRefreshT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFixedDateTimeRefresh>);
			}
			return IFixedDateTimeRefresh.CreateIFixedDateTimeRefresh(builder, _o.Type, _o.UpdateType);
		}

		// Token: 0x0400CF13 RID: 53011
		private Table __p;
	}
}
