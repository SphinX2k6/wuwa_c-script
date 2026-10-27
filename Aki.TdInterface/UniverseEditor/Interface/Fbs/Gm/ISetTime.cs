using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004690 RID: 18064
	public struct ISetTime : IFlatbufferObject
	{
		// Token: 0x17008039 RID: 32825
		// (get) Token: 0x0601B6C7 RID: 112327 RVA: 0x003E557D File Offset: 0x003E377D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B6C8 RID: 112328 RVA: 0x003E558A File Offset: 0x003E378A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B6C9 RID: 112329 RVA: 0x003E5594 File Offset: 0x003E3794
		public static ISetTime GetRootAsISetTime(ByteBuffer _bb)
		{
			return ISetTime.GetRootAsISetTime(_bb, default(ISetTime));
		}

		// Token: 0x0601B6CA RID: 112330 RVA: 0x003E55B0 File Offset: 0x003E37B0
		public static ISetTime GetRootAsISetTime(ByteBuffer _bb, ISetTime obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B6CB RID: 112331 RVA: 0x003E55CD File Offset: 0x003E37CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B6CC RID: 112332 RVA: 0x003E55DC File Offset: 0x003E37DC
		public ISetTime __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700803A RID: 32826
		// (get) Token: 0x0601B6CD RID: 112333 RVA: 0x003E55EC File Offset: 0x003E37EC
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700803B RID: 32827
		// (get) Token: 0x0601B6CE RID: 112334 RVA: 0x003E5628 File Offset: 0x003E3828
		public int Hour
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

		// Token: 0x1700803C RID: 32828
		// (get) Token: 0x0601B6CF RID: 112335 RVA: 0x003E5664 File Offset: 0x003E3864
		public int Minute
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

		// Token: 0x1700803D RID: 32829
		// (get) Token: 0x0601B6D0 RID: 112336 RVA: 0x003E56A0 File Offset: 0x003E38A0
		public bool ShowUi
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601B6D1 RID: 112337 RVA: 0x003E56E0 File Offset: 0x003E38E0
		public static Offset<ISetTime> CreateISetTime(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, int Hour = 0, int Minute = 0, bool ShowUi = false)
		{
			builder.StartTable(4);
			ISetTime.AddMinute(builder, Minute);
			ISetTime.AddHour(builder, Hour);
			ISetTime.AddShowUi(builder, ShowUi);
			ISetTime.AddType(builder, Type);
			return ISetTime.EndISetTime(builder);
		}

		// Token: 0x0601B6D2 RID: 112338 RVA: 0x003E570C File Offset: 0x003E390C
		public static void StartISetTime(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601B6D3 RID: 112339 RVA: 0x003E5715 File Offset: 0x003E3915
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B6D4 RID: 112340 RVA: 0x003E5720 File Offset: 0x003E3920
		public static void AddHour(FlatBufferBuilder builder, int hour)
		{
			builder.AddInt(1, hour, 0);
		}

		// Token: 0x0601B6D5 RID: 112341 RVA: 0x003E572B File Offset: 0x003E392B
		public static void AddMinute(FlatBufferBuilder builder, int minute)
		{
			builder.AddInt(2, minute, 0);
		}

		// Token: 0x0601B6D6 RID: 112342 RVA: 0x003E5736 File Offset: 0x003E3936
		public static void AddShowUi(FlatBufferBuilder builder, bool showUi)
		{
			builder.AddBool(3, showUi, false);
		}

		// Token: 0x0601B6D7 RID: 112343 RVA: 0x003E5741 File Offset: 0x003E3941
		public static Offset<ISetTime> EndISetTime(FlatBufferBuilder builder)
		{
			return new Offset<ISetTime>(builder.EndTable());
		}

		// Token: 0x0601B6D8 RID: 112344 RVA: 0x003E5750 File Offset: 0x003E3950
		public ISetTimeT UnPack()
		{
			ISetTimeT setTimeT = new ISetTimeT();
			this.UnPackTo(setTimeT);
			return setTimeT;
		}

		// Token: 0x0601B6D9 RID: 112345 RVA: 0x003E576B File Offset: 0x003E396B
		public void UnPackTo(ISetTimeT _o)
		{
			_o.Type = this.Type;
			_o.Hour = this.Hour;
			_o.Minute = this.Minute;
			_o.ShowUi = this.ShowUi;
		}

		// Token: 0x0601B6DA RID: 112346 RVA: 0x003E57A0 File Offset: 0x003E39A0
		public static Offset<ISetTime> Pack(FlatBufferBuilder builder, ISetTimeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetTime>);
			}
			return ISetTime.CreateISetTime(builder, _o.Type, _o.Hour, _o.Minute, _o.ShowUi);
		}

		// Token: 0x0400C84E RID: 51278
		private Table __p;
	}
}
