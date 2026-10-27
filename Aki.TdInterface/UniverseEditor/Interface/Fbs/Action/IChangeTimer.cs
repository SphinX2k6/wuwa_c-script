using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200632C RID: 25388
	public struct IChangeTimer : IFlatbufferObject
	{
		// Token: 0x1700BD81 RID: 48513
		// (get) Token: 0x0602BEA5 RID: 179877 RVA: 0x00609720 File Offset: 0x00607920
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BEA6 RID: 179878 RVA: 0x0060972D File Offset: 0x0060792D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BEA7 RID: 179879 RVA: 0x00609734 File Offset: 0x00607934
		public static IChangeTimer GetRootAsIChangeTimer(ByteBuffer _bb)
		{
			return IChangeTimer.GetRootAsIChangeTimer(_bb, default(IChangeTimer));
		}

		// Token: 0x0602BEA8 RID: 179880 RVA: 0x00609750 File Offset: 0x00607950
		public static IChangeTimer GetRootAsIChangeTimer(ByteBuffer _bb, IChangeTimer obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BEA9 RID: 179881 RVA: 0x0060976D File Offset: 0x0060796D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BEAA RID: 179882 RVA: 0x0060977C File Offset: 0x0060797C
		public IChangeTimer __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD82 RID: 48514
		// (get) Token: 0x0602BEAB RID: 179883 RVA: 0x0060978C File Offset: 0x0060798C
		public ETimerType TimerType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETimerType.CountDownChallenge;
				}
				return (ETimerType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BD83 RID: 48515
		// (get) Token: 0x0602BEAC RID: 179884 RVA: 0x006097C8 File Offset: 0x006079C8
		public TChangeTimer ChangeTypeType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TChangeTimer.NONE;
				}
				return (TChangeTimer)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BEAD RID: 179885 RVA: 0x00609804 File Offset: 0x00607A04
		public TTable? ChangeType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602BEAE RID: 179886 RVA: 0x00609848 File Offset: 0x00607A48
		public IAddTime ChangeTypeAsIAddTime()
		{
			return this.ChangeType<IAddTime>().Value;
		}

		// Token: 0x0602BEAF RID: 179887 RVA: 0x00609864 File Offset: 0x00607A64
		public IReduceTime ChangeTypeAsIReduceTime()
		{
			return this.ChangeType<IReduceTime>().Value;
		}

		// Token: 0x0602BEB0 RID: 179888 RVA: 0x00609880 File Offset: 0x00607A80
		public ISetTime ChangeTypeAsISetTime()
		{
			return this.ChangeType<ISetTime>().Value;
		}

		// Token: 0x0602BEB1 RID: 179889 RVA: 0x0060989B File Offset: 0x00607A9B
		public static Offset<IChangeTimer> CreateIChangeTimer(FlatBufferBuilder builder, ETimerType TimerType = ETimerType.CountDownChallenge, TChangeTimer ChangeType_type = TChangeTimer.NONE, int ChangeTypeOffset = 0)
		{
			builder.StartTable(3);
			IChangeTimer.AddChangeType(builder, ChangeTypeOffset);
			IChangeTimer.AddChangeTypeType(builder, ChangeType_type);
			IChangeTimer.AddTimerType(builder, TimerType);
			return IChangeTimer.EndIChangeTimer(builder);
		}

		// Token: 0x0602BEB2 RID: 179890 RVA: 0x006098BF File Offset: 0x00607ABF
		public static void StartIChangeTimer(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602BEB3 RID: 179891 RVA: 0x006098C8 File Offset: 0x00607AC8
		public static void AddTimerType(FlatBufferBuilder builder, ETimerType timerType)
		{
			builder.AddByte(0, (byte)timerType, 0);
		}

		// Token: 0x0602BEB4 RID: 179892 RVA: 0x006098D3 File Offset: 0x00607AD3
		public static void AddChangeTypeType(FlatBufferBuilder builder, TChangeTimer changeTypeType)
		{
			builder.AddByte(1, (byte)changeTypeType, 0);
		}

		// Token: 0x0602BEB5 RID: 179893 RVA: 0x006098DE File Offset: 0x00607ADE
		public static void AddChangeType(FlatBufferBuilder builder, int changeTypeOffset)
		{
			builder.AddOffset(2, changeTypeOffset, 0);
		}

		// Token: 0x0602BEB6 RID: 179894 RVA: 0x006098E9 File Offset: 0x00607AE9
		public static Offset<IChangeTimer> EndIChangeTimer(FlatBufferBuilder builder)
		{
			return new Offset<IChangeTimer>(builder.EndTable());
		}

		// Token: 0x0602BEB7 RID: 179895 RVA: 0x006098F8 File Offset: 0x00607AF8
		public IChangeTimerT UnPack()
		{
			IChangeTimerT changeTimerT = new IChangeTimerT();
			this.UnPackTo(changeTimerT);
			return changeTimerT;
		}

		// Token: 0x0602BEB8 RID: 179896 RVA: 0x00609914 File Offset: 0x00607B14
		public void UnPackTo(IChangeTimerT _o)
		{
			_o.TimerType = this.TimerType;
			_o.ChangeType = new TChangeTimerUnion();
			_o.ChangeType.Type = this.ChangeTypeType;
			switch (this.ChangeTypeType)
			{
			case TChangeTimer.IAddTime:
				_o.ChangeType.Value = ((this.ChangeType<IAddTime>() != null) ? this.ChangeType<IAddTime>().Value.UnPack() : null);
				return;
			case TChangeTimer.IReduceTime:
				_o.ChangeType.Value = ((this.ChangeType<IReduceTime>() != null) ? this.ChangeType<IReduceTime>().Value.UnPack() : null);
				return;
			case TChangeTimer.ISetTime:
				_o.ChangeType.Value = ((this.ChangeType<ISetTime>() != null) ? this.ChangeType<ISetTime>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0602BEB9 RID: 179897 RVA: 0x00609A08 File Offset: 0x00607C08
		public static Offset<IChangeTimer> Pack(FlatBufferBuilder builder, IChangeTimerT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeTimer>);
			}
			TChangeTimer changeType_type = (_o.ChangeType == null) ? TChangeTimer.NONE : _o.ChangeType.Type;
			int changeTypeOffset = (_o.ChangeType == null) ? 0 : TChangeTimerUnion.Pack(builder, _o.ChangeType);
			return IChangeTimer.CreateIChangeTimer(builder, _o.TimerType, changeType_type, changeTypeOffset);
		}

		// Token: 0x040108EF RID: 67823
		private Table __p;
	}
}
