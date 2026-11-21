using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200699D RID: 27037
	public struct IChangeTimer : IFlatbufferObject
	{
		// Token: 0x1700C709 RID: 50953
		// (get) Token: 0x0602E60F RID: 189967 RVA: 0x00654874 File Offset: 0x00652A74
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E610 RID: 189968 RVA: 0x00654881 File Offset: 0x00652A81
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E611 RID: 189969 RVA: 0x00654888 File Offset: 0x00652A88
		public static IChangeTimer GetRootAsIChangeTimer(ByteBuffer _bb)
		{
			return IChangeTimer.GetRootAsIChangeTimer(_bb, default(IChangeTimer));
		}

		// Token: 0x0602E612 RID: 189970 RVA: 0x006548A4 File Offset: 0x00652AA4
		public static IChangeTimer GetRootAsIChangeTimer(ByteBuffer _bb, IChangeTimer obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E613 RID: 189971 RVA: 0x006548C1 File Offset: 0x00652AC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E614 RID: 189972 RVA: 0x006548D0 File Offset: 0x00652AD0
		public IChangeTimer __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C70A RID: 50954
		// (get) Token: 0x0602E615 RID: 189973 RVA: 0x006548E0 File Offset: 0x00652AE0
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

		// Token: 0x1700C70B RID: 50955
		// (get) Token: 0x0602E616 RID: 189974 RVA: 0x0065491C File Offset: 0x00652B1C
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

		// Token: 0x0602E617 RID: 189975 RVA: 0x00654958 File Offset: 0x00652B58
		public TTable? ChangeType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602E618 RID: 189976 RVA: 0x0065499C File Offset: 0x00652B9C
		public IAddTime ChangeTypeAsIAddTime()
		{
			return this.ChangeType<IAddTime>().Value;
		}

		// Token: 0x0602E619 RID: 189977 RVA: 0x006549B8 File Offset: 0x00652BB8
		public IReduceTime ChangeTypeAsIReduceTime()
		{
			return this.ChangeType<IReduceTime>().Value;
		}

		// Token: 0x0602E61A RID: 189978 RVA: 0x006549D4 File Offset: 0x00652BD4
		public ISetTime ChangeTypeAsISetTime()
		{
			return this.ChangeType<ISetTime>().Value;
		}

		// Token: 0x0602E61B RID: 189979 RVA: 0x006549EF File Offset: 0x00652BEF
		public static Offset<IChangeTimer> CreateIChangeTimer(FlatBufferBuilder builder, ETimerType TimerType = ETimerType.CountDownChallenge, TChangeTimer ChangeType_type = TChangeTimer.NONE, int ChangeTypeOffset = 0)
		{
			builder.StartTable(3);
			IChangeTimer.AddChangeType(builder, ChangeTypeOffset);
			IChangeTimer.AddChangeTypeType(builder, ChangeType_type);
			IChangeTimer.AddTimerType(builder, TimerType);
			return IChangeTimer.EndIChangeTimer(builder);
		}

		// Token: 0x0602E61C RID: 189980 RVA: 0x00654A13 File Offset: 0x00652C13
		public static void StartIChangeTimer(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602E61D RID: 189981 RVA: 0x00654A1C File Offset: 0x00652C1C
		public static void AddTimerType(FlatBufferBuilder builder, ETimerType timerType)
		{
			builder.AddByte(0, (byte)timerType, 0);
		}

		// Token: 0x0602E61E RID: 189982 RVA: 0x00654A27 File Offset: 0x00652C27
		public static void AddChangeTypeType(FlatBufferBuilder builder, TChangeTimer changeTypeType)
		{
			builder.AddByte(1, (byte)changeTypeType, 0);
		}

		// Token: 0x0602E61F RID: 189983 RVA: 0x00654A32 File Offset: 0x00652C32
		public static void AddChangeType(FlatBufferBuilder builder, int changeTypeOffset)
		{
			builder.AddOffset(2, changeTypeOffset, 0);
		}

		// Token: 0x0602E620 RID: 189984 RVA: 0x00654A3D File Offset: 0x00652C3D
		public static Offset<IChangeTimer> EndIChangeTimer(FlatBufferBuilder builder)
		{
			return new Offset<IChangeTimer>(builder.EndTable());
		}

		// Token: 0x0602E621 RID: 189985 RVA: 0x00654A4C File Offset: 0x00652C4C
		public IChangeTimerT UnPack()
		{
			IChangeTimerT changeTimerT = new IChangeTimerT();
			this.UnPackTo(changeTimerT);
			return changeTimerT;
		}

		// Token: 0x0602E622 RID: 189986 RVA: 0x00654A68 File Offset: 0x00652C68
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

		// Token: 0x0602E623 RID: 189987 RVA: 0x00654B5C File Offset: 0x00652D5C
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

		// Token: 0x04011704 RID: 71428
		private Table __p;
	}
}
