using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D6D RID: 32109
	public struct IVisualNovelDate : IFlatbufferObject
	{
		// Token: 0x1700F044 RID: 61508
		// (get) Token: 0x06039F76 RID: 237430 RVA: 0x007D1000 File Offset: 0x007CF200
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039F77 RID: 237431 RVA: 0x007D100D File Offset: 0x007CF20D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039F78 RID: 237432 RVA: 0x007D1014 File Offset: 0x007CF214
		public static IVisualNovelDate GetRootAsIVisualNovelDate(ByteBuffer _bb)
		{
			return IVisualNovelDate.GetRootAsIVisualNovelDate(_bb, default(IVisualNovelDate));
		}

		// Token: 0x06039F79 RID: 237433 RVA: 0x007D1030 File Offset: 0x007CF230
		public static IVisualNovelDate GetRootAsIVisualNovelDate(ByteBuffer _bb, IVisualNovelDate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039F7A RID: 237434 RVA: 0x007D104D File Offset: 0x007CF24D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039F7B RID: 237435 RVA: 0x007D105C File Offset: 0x007CF25C
		public IVisualNovelDate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F045 RID: 61509
		// (get) Token: 0x06039F7C RID: 237436 RVA: 0x007D106C File Offset: 0x007CF26C
		public int Month
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

		// Token: 0x1700F046 RID: 61510
		// (get) Token: 0x06039F7D RID: 237437 RVA: 0x007D10A8 File Offset: 0x007CF2A8
		public int Day
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

		// Token: 0x06039F7E RID: 237438 RVA: 0x007D10E4 File Offset: 0x007CF2E4
		public static Offset<IVisualNovelDate> CreateIVisualNovelDate(FlatBufferBuilder builder, int Month = 0, int Day = 0)
		{
			builder.StartTable(2);
			IVisualNovelDate.AddDay(builder, Day);
			IVisualNovelDate.AddMonth(builder, Month);
			return IVisualNovelDate.EndIVisualNovelDate(builder);
		}

		// Token: 0x06039F7F RID: 237439 RVA: 0x007D1101 File Offset: 0x007CF301
		public static void StartIVisualNovelDate(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06039F80 RID: 237440 RVA: 0x007D110A File Offset: 0x007CF30A
		public static void AddMonth(FlatBufferBuilder builder, int month)
		{
			builder.AddInt(0, month, 0);
		}

		// Token: 0x06039F81 RID: 237441 RVA: 0x007D1115 File Offset: 0x007CF315
		public static void AddDay(FlatBufferBuilder builder, int day)
		{
			builder.AddInt(1, day, 0);
		}

		// Token: 0x06039F82 RID: 237442 RVA: 0x007D1120 File Offset: 0x007CF320
		public static Offset<IVisualNovelDate> EndIVisualNovelDate(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelDate>(builder.EndTable());
		}

		// Token: 0x06039F83 RID: 237443 RVA: 0x007D1130 File Offset: 0x007CF330
		public IVisualNovelDateT UnPack()
		{
			IVisualNovelDateT visualNovelDateT = new IVisualNovelDateT();
			this.UnPackTo(visualNovelDateT);
			return visualNovelDateT;
		}

		// Token: 0x06039F84 RID: 237444 RVA: 0x007D114B File Offset: 0x007CF34B
		public void UnPackTo(IVisualNovelDateT _o)
		{
			_o.Month = this.Month;
			_o.Day = this.Day;
		}

		// Token: 0x06039F85 RID: 237445 RVA: 0x007D1168 File Offset: 0x007CF368
		public static Offset<IVisualNovelDate> Pack(FlatBufferBuilder builder, IVisualNovelDateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelDate>);
			}
			return IVisualNovelDate.CreateIVisualNovelDate(builder, _o.Month, _o.Day);
		}

		// Token: 0x040134AF RID: 79023
		private Table __p;
	}
}
