using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AF8 RID: 19192
	public struct ISetTime : IFlatbufferObject
	{
		// Token: 0x1700867A RID: 34426
		// (get) Token: 0x0601CE9C RID: 118428 RVA: 0x00411819 File Offset: 0x0040FA19
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CE9D RID: 118429 RVA: 0x00411826 File Offset: 0x0040FA26
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CE9E RID: 118430 RVA: 0x00411830 File Offset: 0x0040FA30
		public static ISetTime GetRootAsISetTime(ByteBuffer _bb)
		{
			return ISetTime.GetRootAsISetTime(_bb, default(ISetTime));
		}

		// Token: 0x0601CE9F RID: 118431 RVA: 0x0041184C File Offset: 0x0040FA4C
		public static ISetTime GetRootAsISetTime(ByteBuffer _bb, ISetTime obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CEA0 RID: 118432 RVA: 0x00411869 File Offset: 0x0040FA69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CEA1 RID: 118433 RVA: 0x00411878 File Offset: 0x0040FA78
		public ISetTime __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700867B RID: 34427
		// (get) Token: 0x0601CEA2 RID: 118434 RVA: 0x00411888 File Offset: 0x0040FA88
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

		// Token: 0x1700867C RID: 34428
		// (get) Token: 0x0601CEA3 RID: 118435 RVA: 0x004118C4 File Offset: 0x0040FAC4
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

		// Token: 0x1700867D RID: 34429
		// (get) Token: 0x0601CEA4 RID: 118436 RVA: 0x00411900 File Offset: 0x0040FB00
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

		// Token: 0x1700867E RID: 34430
		// (get) Token: 0x0601CEA5 RID: 118437 RVA: 0x0041193C File Offset: 0x0040FB3C
		public bool ShowUi
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601CEA6 RID: 118438 RVA: 0x0041197C File Offset: 0x0040FB7C
		public static Offset<ISetTime> CreateISetTime(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, int Hour = 0, int Minute = 0, bool ShowUi = false)
		{
			builder.StartTable(4);
			ISetTime.AddMinute(builder, Minute);
			ISetTime.AddHour(builder, Hour);
			ISetTime.AddShowUi(builder, ShowUi);
			ISetTime.AddType(builder, Type);
			return ISetTime.EndISetTime(builder);
		}

		// Token: 0x0601CEA7 RID: 118439 RVA: 0x004119A8 File Offset: 0x0040FBA8
		public static void StartISetTime(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601CEA8 RID: 118440 RVA: 0x004119B1 File Offset: 0x0040FBB1
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CEA9 RID: 118441 RVA: 0x004119BC File Offset: 0x0040FBBC
		public static void AddHour(FlatBufferBuilder builder, int hour)
		{
			builder.AddInt(1, hour, 0);
		}

		// Token: 0x0601CEAA RID: 118442 RVA: 0x004119C7 File Offset: 0x0040FBC7
		public static void AddMinute(FlatBufferBuilder builder, int minute)
		{
			builder.AddInt(2, minute, 0);
		}

		// Token: 0x0601CEAB RID: 118443 RVA: 0x004119D2 File Offset: 0x0040FBD2
		public static void AddShowUi(FlatBufferBuilder builder, bool showUi)
		{
			builder.AddBool(3, showUi, false);
		}

		// Token: 0x0601CEAC RID: 118444 RVA: 0x004119DD File Offset: 0x0040FBDD
		public static Offset<ISetTime> EndISetTime(FlatBufferBuilder builder)
		{
			return new Offset<ISetTime>(builder.EndTable());
		}

		// Token: 0x0601CEAD RID: 118445 RVA: 0x004119EC File Offset: 0x0040FBEC
		public ISetTimeT UnPack()
		{
			ISetTimeT setTimeT = new ISetTimeT();
			this.UnPackTo(setTimeT);
			return setTimeT;
		}

		// Token: 0x0601CEAE RID: 118446 RVA: 0x00411A07 File Offset: 0x0040FC07
		public void UnPackTo(ISetTimeT _o)
		{
			_o.Type = this.Type;
			_o.Hour = this.Hour;
			_o.Minute = this.Minute;
			_o.ShowUi = this.ShowUi;
		}

		// Token: 0x0601CEAF RID: 118447 RVA: 0x00411A3C File Offset: 0x0040FC3C
		public static Offset<ISetTime> Pack(FlatBufferBuilder builder, ISetTimeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetTime>);
			}
			return ISetTime.CreateISetTime(builder, _o.Type, _o.Hour, _o.Minute, _o.ShowUi);
		}

		// Token: 0x0400D27D RID: 53885
		private Table __p;
	}
}
