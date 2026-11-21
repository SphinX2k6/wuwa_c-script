using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006160 RID: 24928
	public struct IWalkingPatternStayAwayConfig : IFlatbufferObject
	{
		// Token: 0x1700B9BC RID: 47548
		// (get) Token: 0x0602A51D RID: 173341 RVA: 0x005C6273 File Offset: 0x005C4473
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A51E RID: 173342 RVA: 0x005C6280 File Offset: 0x005C4480
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A51F RID: 173343 RVA: 0x005C6288 File Offset: 0x005C4488
		public static IWalkingPatternStayAwayConfig GetRootAsIWalkingPatternStayAwayConfig(ByteBuffer _bb)
		{
			return IWalkingPatternStayAwayConfig.GetRootAsIWalkingPatternStayAwayConfig(_bb, default(IWalkingPatternStayAwayConfig));
		}

		// Token: 0x0602A520 RID: 173344 RVA: 0x005C62A4 File Offset: 0x005C44A4
		public static IWalkingPatternStayAwayConfig GetRootAsIWalkingPatternStayAwayConfig(ByteBuffer _bb, IWalkingPatternStayAwayConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A521 RID: 173345 RVA: 0x005C62C1 File Offset: 0x005C44C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A522 RID: 173346 RVA: 0x005C62D0 File Offset: 0x005C44D0
		public IWalkingPatternStayAwayConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B9BD RID: 47549
		// (get) Token: 0x0602A523 RID: 173347 RVA: 0x005C62E0 File Offset: 0x005C44E0
		public int SplineDistance
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

		// Token: 0x1700B9BE RID: 47550
		// (get) Token: 0x0602A524 RID: 173348 RVA: 0x005C631C File Offset: 0x005C451C
		public int StayAwayTime
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

		// Token: 0x1700B9BF RID: 47551
		// (get) Token: 0x0602A525 RID: 173349 RVA: 0x005C6358 File Offset: 0x005C4558
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A526 RID: 173350 RVA: 0x005C6394 File Offset: 0x005C4594
		public static Offset<IWalkingPatternStayAwayConfig> CreateIWalkingPatternStayAwayConfig(FlatBufferBuilder builder, int SplineDistance = 0, int StayAwayTime = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IWalkingPatternStayAwayConfig.AddStayAwayTime(builder, StayAwayTime);
			IWalkingPatternStayAwayConfig.AddSplineDistance(builder, SplineDistance);
			IWalkingPatternStayAwayConfig.AddNullMask(builder, NullMask);
			return IWalkingPatternStayAwayConfig.EndIWalkingPatternStayAwayConfig(builder);
		}

		// Token: 0x0602A527 RID: 173351 RVA: 0x005C63B8 File Offset: 0x005C45B8
		public static void StartIWalkingPatternStayAwayConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602A528 RID: 173352 RVA: 0x005C63C1 File Offset: 0x005C45C1
		public static void AddSplineDistance(FlatBufferBuilder builder, int splineDistance)
		{
			builder.AddInt(0, splineDistance, 0);
		}

		// Token: 0x0602A529 RID: 173353 RVA: 0x005C63CC File Offset: 0x005C45CC
		public static void AddStayAwayTime(FlatBufferBuilder builder, int stayAwayTime)
		{
			builder.AddInt(1, stayAwayTime, 0);
		}

		// Token: 0x0602A52A RID: 173354 RVA: 0x005C63D7 File Offset: 0x005C45D7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602A52B RID: 173355 RVA: 0x005C63E2 File Offset: 0x005C45E2
		public static Offset<IWalkingPatternStayAwayConfig> EndIWalkingPatternStayAwayConfig(FlatBufferBuilder builder)
		{
			return new Offset<IWalkingPatternStayAwayConfig>(builder.EndTable());
		}

		// Token: 0x0602A52C RID: 173356 RVA: 0x005C63F0 File Offset: 0x005C45F0
		public IWalkingPatternStayAwayConfigT UnPack()
		{
			IWalkingPatternStayAwayConfigT walkingPatternStayAwayConfigT = new IWalkingPatternStayAwayConfigT();
			this.UnPackTo(walkingPatternStayAwayConfigT);
			return walkingPatternStayAwayConfigT;
		}

		// Token: 0x0602A52D RID: 173357 RVA: 0x005C640B File Offset: 0x005C460B
		public void UnPackTo(IWalkingPatternStayAwayConfigT _o)
		{
			_o.SplineDistance = this.SplineDistance;
			_o.StayAwayTime = this.StayAwayTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602A52E RID: 173358 RVA: 0x005C6434 File Offset: 0x005C4634
		public static Offset<IWalkingPatternStayAwayConfig> Pack(FlatBufferBuilder builder, IWalkingPatternStayAwayConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWalkingPatternStayAwayConfig>);
			}
			return IWalkingPatternStayAwayConfig.CreateIWalkingPatternStayAwayConfig(builder, _o.SplineDistance, _o.StayAwayTime, _o.NullMask);
		}

		// Token: 0x0400FF88 RID: 65416
		private Table __p;
	}
}
