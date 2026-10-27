using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075FE RID: 30206
	public struct IWaitMovieModeFixedTime : IFlatbufferObject
	{
		// Token: 0x1700E575 RID: 58741
		// (get) Token: 0x0603705C RID: 225372 RVA: 0x007771D9 File Offset: 0x007753D9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603705D RID: 225373 RVA: 0x007771E6 File Offset: 0x007753E6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603705E RID: 225374 RVA: 0x007771F0 File Offset: 0x007753F0
		public static IWaitMovieModeFixedTime GetRootAsIWaitMovieModeFixedTime(ByteBuffer _bb)
		{
			return IWaitMovieModeFixedTime.GetRootAsIWaitMovieModeFixedTime(_bb, default(IWaitMovieModeFixedTime));
		}

		// Token: 0x0603705F RID: 225375 RVA: 0x0077720C File Offset: 0x0077540C
		public static IWaitMovieModeFixedTime GetRootAsIWaitMovieModeFixedTime(ByteBuffer _bb, IWaitMovieModeFixedTime obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06037060 RID: 225376 RVA: 0x00777229 File Offset: 0x00775429
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06037061 RID: 225377 RVA: 0x00777238 File Offset: 0x00775438
		public IWaitMovieModeFixedTime __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E576 RID: 58742
		// (get) Token: 0x06037062 RID: 225378 RVA: 0x00777248 File Offset: 0x00775448
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

		// Token: 0x1700E577 RID: 58743
		// (get) Token: 0x06037063 RID: 225379 RVA: 0x00777284 File Offset: 0x00775484
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

		// Token: 0x06037064 RID: 225380 RVA: 0x007772C4 File Offset: 0x007754C4
		public static Offset<IWaitMovieModeFixedTime> CreateIWaitMovieModeFixedTime(FlatBufferBuilder builder, EEnterMovieModeDurationType Type = EEnterMovieModeDurationType.BorderAnimFinished, float Duration = 0f)
		{
			builder.StartTable(2);
			IWaitMovieModeFixedTime.AddDuration(builder, Duration);
			IWaitMovieModeFixedTime.AddType(builder, Type);
			return IWaitMovieModeFixedTime.EndIWaitMovieModeFixedTime(builder);
		}

		// Token: 0x06037065 RID: 225381 RVA: 0x007772E1 File Offset: 0x007754E1
		public static void StartIWaitMovieModeFixedTime(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06037066 RID: 225382 RVA: 0x007772EA File Offset: 0x007754EA
		public static void AddType(FlatBufferBuilder builder, EEnterMovieModeDurationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06037067 RID: 225383 RVA: 0x007772F5 File Offset: 0x007754F5
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(1, duration, 0.0);
		}

		// Token: 0x06037068 RID: 225384 RVA: 0x00777308 File Offset: 0x00775508
		public static Offset<IWaitMovieModeFixedTime> EndIWaitMovieModeFixedTime(FlatBufferBuilder builder)
		{
			return new Offset<IWaitMovieModeFixedTime>(builder.EndTable());
		}

		// Token: 0x06037069 RID: 225385 RVA: 0x00777318 File Offset: 0x00775518
		public IWaitMovieModeFixedTimeT UnPack()
		{
			IWaitMovieModeFixedTimeT waitMovieModeFixedTimeT = new IWaitMovieModeFixedTimeT();
			this.UnPackTo(waitMovieModeFixedTimeT);
			return waitMovieModeFixedTimeT;
		}

		// Token: 0x0603706A RID: 225386 RVA: 0x00777333 File Offset: 0x00775533
		public void UnPackTo(IWaitMovieModeFixedTimeT _o)
		{
			_o.Type = this.Type;
			_o.Duration = this.Duration;
		}

		// Token: 0x0603706B RID: 225387 RVA: 0x00777350 File Offset: 0x00775550
		public static Offset<IWaitMovieModeFixedTime> Pack(FlatBufferBuilder builder, IWaitMovieModeFixedTimeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWaitMovieModeFixedTime>);
			}
			return IWaitMovieModeFixedTime.CreateIWaitMovieModeFixedTime(builder, _o.Type, _o.Duration);
		}

		// Token: 0x04012570 RID: 75120
		private Table __p;
	}
}
