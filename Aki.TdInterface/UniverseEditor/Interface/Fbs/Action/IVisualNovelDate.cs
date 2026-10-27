using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007577 RID: 30071
	public struct IVisualNovelDate : IFlatbufferObject
	{
		// Token: 0x1700E414 RID: 58388
		// (get) Token: 0x06036B4E RID: 224078 RVA: 0x0076DA5A File Offset: 0x0076BC5A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036B4F RID: 224079 RVA: 0x0076DA67 File Offset: 0x0076BC67
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036B50 RID: 224080 RVA: 0x0076DA70 File Offset: 0x0076BC70
		public static IVisualNovelDate GetRootAsIVisualNovelDate(ByteBuffer _bb)
		{
			return IVisualNovelDate.GetRootAsIVisualNovelDate(_bb, default(IVisualNovelDate));
		}

		// Token: 0x06036B51 RID: 224081 RVA: 0x0076DA8C File Offset: 0x0076BC8C
		public static IVisualNovelDate GetRootAsIVisualNovelDate(ByteBuffer _bb, IVisualNovelDate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036B52 RID: 224082 RVA: 0x0076DAA9 File Offset: 0x0076BCA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036B53 RID: 224083 RVA: 0x0076DAB8 File Offset: 0x0076BCB8
		public IVisualNovelDate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E415 RID: 58389
		// (get) Token: 0x06036B54 RID: 224084 RVA: 0x0076DAC8 File Offset: 0x0076BCC8
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

		// Token: 0x1700E416 RID: 58390
		// (get) Token: 0x06036B55 RID: 224085 RVA: 0x0076DB04 File Offset: 0x0076BD04
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

		// Token: 0x06036B56 RID: 224086 RVA: 0x0076DB40 File Offset: 0x0076BD40
		public static Offset<IVisualNovelDate> CreateIVisualNovelDate(FlatBufferBuilder builder, int Month = 0, int Day = 0)
		{
			builder.StartTable(2);
			IVisualNovelDate.AddDay(builder, Day);
			IVisualNovelDate.AddMonth(builder, Month);
			return IVisualNovelDate.EndIVisualNovelDate(builder);
		}

		// Token: 0x06036B57 RID: 224087 RVA: 0x0076DB5D File Offset: 0x0076BD5D
		public static void StartIVisualNovelDate(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06036B58 RID: 224088 RVA: 0x0076DB66 File Offset: 0x0076BD66
		public static void AddMonth(FlatBufferBuilder builder, int month)
		{
			builder.AddInt(0, month, 0);
		}

		// Token: 0x06036B59 RID: 224089 RVA: 0x0076DB71 File Offset: 0x0076BD71
		public static void AddDay(FlatBufferBuilder builder, int day)
		{
			builder.AddInt(1, day, 0);
		}

		// Token: 0x06036B5A RID: 224090 RVA: 0x0076DB7C File Offset: 0x0076BD7C
		public static Offset<IVisualNovelDate> EndIVisualNovelDate(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelDate>(builder.EndTable());
		}

		// Token: 0x06036B5B RID: 224091 RVA: 0x0076DB8C File Offset: 0x0076BD8C
		public IVisualNovelDateT UnPack()
		{
			IVisualNovelDateT visualNovelDateT = new IVisualNovelDateT();
			this.UnPackTo(visualNovelDateT);
			return visualNovelDateT;
		}

		// Token: 0x06036B5C RID: 224092 RVA: 0x0076DBA7 File Offset: 0x0076BDA7
		public void UnPackTo(IVisualNovelDateT _o)
		{
			_o.Month = this.Month;
			_o.Day = this.Day;
		}

		// Token: 0x06036B5D RID: 224093 RVA: 0x0076DBC4 File Offset: 0x0076BDC4
		public static Offset<IVisualNovelDate> Pack(FlatBufferBuilder builder, IVisualNovelDateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelDate>);
			}
			return IVisualNovelDate.CreateIVisualNovelDate(builder, _o.Month, _o.Day);
		}

		// Token: 0x0401247B RID: 74875
		private Table __p;
	}
}
