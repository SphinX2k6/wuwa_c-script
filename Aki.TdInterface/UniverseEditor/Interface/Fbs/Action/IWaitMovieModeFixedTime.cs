using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E0C RID: 32268
	public struct IWaitMovieModeFixedTime : IFlatbufferObject
	{
		// Token: 0x1700F1B3 RID: 61875
		// (get) Token: 0x0603A501 RID: 238849 RVA: 0x007DB2D5 File Offset: 0x007D94D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A502 RID: 238850 RVA: 0x007DB2E2 File Offset: 0x007D94E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A503 RID: 238851 RVA: 0x007DB2EC File Offset: 0x007D94EC
		public static IWaitMovieModeFixedTime GetRootAsIWaitMovieModeFixedTime(ByteBuffer _bb)
		{
			return IWaitMovieModeFixedTime.GetRootAsIWaitMovieModeFixedTime(_bb, default(IWaitMovieModeFixedTime));
		}

		// Token: 0x0603A504 RID: 238852 RVA: 0x007DB308 File Offset: 0x007D9508
		public static IWaitMovieModeFixedTime GetRootAsIWaitMovieModeFixedTime(ByteBuffer _bb, IWaitMovieModeFixedTime obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A505 RID: 238853 RVA: 0x007DB325 File Offset: 0x007D9525
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A506 RID: 238854 RVA: 0x007DB334 File Offset: 0x007D9534
		public IWaitMovieModeFixedTime __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F1B4 RID: 61876
		// (get) Token: 0x0603A507 RID: 238855 RVA: 0x007DB344 File Offset: 0x007D9544
		public EEnterMovieModeDurationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEnterMovieModeDurationType.BorderAnimFinished;
				}
				return (EEnterMovieModeDurationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700F1B5 RID: 61877
		// (get) Token: 0x0603A508 RID: 238856 RVA: 0x007DB380 File Offset: 0x007D9580
		public float Duration
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603A509 RID: 238857 RVA: 0x007DB3C0 File Offset: 0x007D95C0
		public static Offset<IWaitMovieModeFixedTime> CreateIWaitMovieModeFixedTime(FlatBufferBuilder builder, EEnterMovieModeDurationType Type = EEnterMovieModeDurationType.BorderAnimFinished, float Duration = 0f)
		{
			builder.StartTable(2);
			IWaitMovieModeFixedTime.AddDuration(builder, Duration);
			IWaitMovieModeFixedTime.AddType(builder, Type);
			return IWaitMovieModeFixedTime.EndIWaitMovieModeFixedTime(builder);
		}

		// Token: 0x0603A50A RID: 238858 RVA: 0x007DB3DD File Offset: 0x007D95DD
		public static void StartIWaitMovieModeFixedTime(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603A50B RID: 238859 RVA: 0x007DB3E6 File Offset: 0x007D95E6
		public static void AddType(FlatBufferBuilder builder, EEnterMovieModeDurationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603A50C RID: 238860 RVA: 0x007DB3F1 File Offset: 0x007D95F1
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(1, duration, 0.0);
		}

		// Token: 0x0603A50D RID: 238861 RVA: 0x007DB404 File Offset: 0x007D9604
		public static Offset<IWaitMovieModeFixedTime> EndIWaitMovieModeFixedTime(FlatBufferBuilder builder)
		{
			return new Offset<IWaitMovieModeFixedTime>(builder.EndTable());
		}

		// Token: 0x0603A50E RID: 238862 RVA: 0x007DB414 File Offset: 0x007D9614
		public IWaitMovieModeFixedTimeT UnPack()
		{
			IWaitMovieModeFixedTimeT waitMovieModeFixedTimeT = new IWaitMovieModeFixedTimeT();
			this.UnPackTo(waitMovieModeFixedTimeT);
			return waitMovieModeFixedTimeT;
		}

		// Token: 0x0603A50F RID: 238863 RVA: 0x007DB42F File Offset: 0x007D962F
		public void UnPackTo(IWaitMovieModeFixedTimeT _o)
		{
			_o.Type = this.Type;
			_o.Duration = this.Duration;
		}

		// Token: 0x0603A510 RID: 238864 RVA: 0x007DB44C File Offset: 0x007D964C
		public static Offset<IWaitMovieModeFixedTime> Pack(FlatBufferBuilder builder, IWaitMovieModeFixedTimeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWaitMovieModeFixedTime>);
			}
			return IWaitMovieModeFixedTime.CreateIWaitMovieModeFixedTime(builder, _o.Type, _o.Duration);
		}

		// Token: 0x040135BA RID: 79290
		private Table __p;
	}
}
