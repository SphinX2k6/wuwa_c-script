using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006173 RID: 24947
	public struct IAdjustTodTime : IFlatbufferObject
	{
		// Token: 0x1700B9CF RID: 47567
		// (get) Token: 0x0602AF10 RID: 175888 RVA: 0x005ECA3A File Offset: 0x005EAC3A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602AF11 RID: 175889 RVA: 0x005ECA47 File Offset: 0x005EAC47
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602AF12 RID: 175890 RVA: 0x005ECA50 File Offset: 0x005EAC50
		public static IAdjustTodTime GetRootAsIAdjustTodTime(ByteBuffer _bb)
		{
			return IAdjustTodTime.GetRootAsIAdjustTodTime(_bb, default(IAdjustTodTime));
		}

		// Token: 0x0602AF13 RID: 175891 RVA: 0x005ECA6C File Offset: 0x005EAC6C
		public static IAdjustTodTime GetRootAsIAdjustTodTime(ByteBuffer _bb, IAdjustTodTime obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602AF14 RID: 175892 RVA: 0x005ECA89 File Offset: 0x005EAC89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602AF15 RID: 175893 RVA: 0x005ECA98 File Offset: 0x005EAC98
		public IAdjustTodTime __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B9D0 RID: 47568
		// (get) Token: 0x0602AF16 RID: 175894 RVA: 0x005ECAA8 File Offset: 0x005EACA8
		public int Hour
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B9D1 RID: 47569
		// (get) Token: 0x0602AF17 RID: 175895 RVA: 0x005ECAE4 File Offset: 0x005EACE4
		public int Min
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

		// Token: 0x1700B9D2 RID: 47570
		// (get) Token: 0x0602AF18 RID: 175896 RVA: 0x005ECB20 File Offset: 0x005EAD20
		public bool ShowUi
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602AF19 RID: 175897 RVA: 0x005ECB5F File Offset: 0x005EAD5F
		public static Offset<IAdjustTodTime> CreateIAdjustTodTime(FlatBufferBuilder builder, int Hour = 0, int Min = 0, bool ShowUi = false)
		{
			builder.StartTable(3);
			IAdjustTodTime.AddMin(builder, Min);
			IAdjustTodTime.AddHour(builder, Hour);
			IAdjustTodTime.AddShowUi(builder, ShowUi);
			return IAdjustTodTime.EndIAdjustTodTime(builder);
		}

		// Token: 0x0602AF1A RID: 175898 RVA: 0x005ECB83 File Offset: 0x005EAD83
		public static void StartIAdjustTodTime(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602AF1B RID: 175899 RVA: 0x005ECB8C File Offset: 0x005EAD8C
		public static void AddHour(FlatBufferBuilder builder, int hour)
		{
			builder.AddInt(0, hour, 0);
		}

		// Token: 0x0602AF1C RID: 175900 RVA: 0x005ECB97 File Offset: 0x005EAD97
		public static void AddMin(FlatBufferBuilder builder, int min)
		{
			builder.AddInt(1, min, 0);
		}

		// Token: 0x0602AF1D RID: 175901 RVA: 0x005ECBA2 File Offset: 0x005EADA2
		public static void AddShowUi(FlatBufferBuilder builder, bool showUi)
		{
			builder.AddBool(2, showUi, false);
		}

		// Token: 0x0602AF1E RID: 175902 RVA: 0x005ECBAD File Offset: 0x005EADAD
		public static Offset<IAdjustTodTime> EndIAdjustTodTime(FlatBufferBuilder builder)
		{
			return new Offset<IAdjustTodTime>(builder.EndTable());
		}

		// Token: 0x0602AF1F RID: 175903 RVA: 0x005ECBBC File Offset: 0x005EADBC
		public IAdjustTodTimeT UnPack()
		{
			IAdjustTodTimeT adjustTodTimeT = new IAdjustTodTimeT();
			this.UnPackTo(adjustTodTimeT);
			return adjustTodTimeT;
		}

		// Token: 0x0602AF20 RID: 175904 RVA: 0x005ECBD7 File Offset: 0x005EADD7
		public void UnPackTo(IAdjustTodTimeT _o)
		{
			_o.Hour = this.Hour;
			_o.Min = this.Min;
			_o.ShowUi = this.ShowUi;
		}

		// Token: 0x0602AF21 RID: 175905 RVA: 0x005ECC00 File Offset: 0x005EAE00
		public static Offset<IAdjustTodTime> Pack(FlatBufferBuilder builder, IAdjustTodTimeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAdjustTodTime>);
			}
			return IAdjustTodTime.CreateIAdjustTodTime(builder, _o.Hour, _o.Min, _o.ShowUi);
		}

		// Token: 0x04010659 RID: 67161
		private Table __p;
	}
}
