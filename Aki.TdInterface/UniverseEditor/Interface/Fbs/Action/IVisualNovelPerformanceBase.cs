using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D94 RID: 32148
	public struct IVisualNovelPerformanceBase : IFlatbufferObject
	{
		// Token: 0x1700F081 RID: 61569
		// (get) Token: 0x0603A08E RID: 237710 RVA: 0x007D2CD7 File Offset: 0x007D0ED7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A08F RID: 237711 RVA: 0x007D2CE4 File Offset: 0x007D0EE4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A090 RID: 237712 RVA: 0x007D2CEC File Offset: 0x007D0EEC
		public static IVisualNovelPerformanceBase GetRootAsIVisualNovelPerformanceBase(ByteBuffer _bb)
		{
			return IVisualNovelPerformanceBase.GetRootAsIVisualNovelPerformanceBase(_bb, default(IVisualNovelPerformanceBase));
		}

		// Token: 0x0603A091 RID: 237713 RVA: 0x007D2D08 File Offset: 0x007D0F08
		public static IVisualNovelPerformanceBase GetRootAsIVisualNovelPerformanceBase(ByteBuffer _bb, IVisualNovelPerformanceBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A092 RID: 237714 RVA: 0x007D2D25 File Offset: 0x007D0F25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A093 RID: 237715 RVA: 0x007D2D34 File Offset: 0x007D0F34
		public IVisualNovelPerformanceBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F082 RID: 61570
		// (get) Token: 0x0603A094 RID: 237716 RVA: 0x007D2D44 File Offset: 0x007D0F44
		public EVisualNovelPerformanceType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisualNovelPerformanceType.Enter;
				}
				return (EVisualNovelPerformanceType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700F083 RID: 61571
		// (get) Token: 0x0603A095 RID: 237717 RVA: 0x007D2D80 File Offset: 0x007D0F80
		public float StartTime
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

		// Token: 0x1700F084 RID: 61572
		// (get) Token: 0x0603A096 RID: 237718 RVA: 0x007D2DC0 File Offset: 0x007D0FC0
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

		// Token: 0x0603A097 RID: 237719 RVA: 0x007D2DFC File Offset: 0x007D0FFC
		public static Offset<IVisualNovelPerformanceBase> CreateIVisualNovelPerformanceBase(FlatBufferBuilder builder, EVisualNovelPerformanceType Type = EVisualNovelPerformanceType.Enter, float StartTime = 0f, byte NullMask = 0)
		{
			builder.StartTable(3);
			IVisualNovelPerformanceBase.AddStartTime(builder, StartTime);
			IVisualNovelPerformanceBase.AddNullMask(builder, NullMask);
			IVisualNovelPerformanceBase.AddType(builder, Type);
			return IVisualNovelPerformanceBase.EndIVisualNovelPerformanceBase(builder);
		}

		// Token: 0x0603A098 RID: 237720 RVA: 0x007D2E20 File Offset: 0x007D1020
		public static void StartIVisualNovelPerformanceBase(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603A099 RID: 237721 RVA: 0x007D2E29 File Offset: 0x007D1029
		public static void AddType(FlatBufferBuilder builder, EVisualNovelPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603A09A RID: 237722 RVA: 0x007D2E34 File Offset: 0x007D1034
		public static void AddStartTime(FlatBufferBuilder builder, float startTime)
		{
			builder.AddFloat(1, startTime, 0.0);
		}

		// Token: 0x0603A09B RID: 237723 RVA: 0x007D2E47 File Offset: 0x007D1047
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0603A09C RID: 237724 RVA: 0x007D2E52 File Offset: 0x007D1052
		public static Offset<IVisualNovelPerformanceBase> EndIVisualNovelPerformanceBase(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelPerformanceBase>(builder.EndTable());
		}

		// Token: 0x0603A09D RID: 237725 RVA: 0x007D2E60 File Offset: 0x007D1060
		public IVisualNovelPerformanceBaseT UnPack()
		{
			IVisualNovelPerformanceBaseT visualNovelPerformanceBaseT = new IVisualNovelPerformanceBaseT();
			this.UnPackTo(visualNovelPerformanceBaseT);
			return visualNovelPerformanceBaseT;
		}

		// Token: 0x0603A09E RID: 237726 RVA: 0x007D2E7B File Offset: 0x007D107B
		public void UnPackTo(IVisualNovelPerformanceBaseT _o)
		{
			_o.Type = this.Type;
			_o.StartTime = this.StartTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603A09F RID: 237727 RVA: 0x007D2EA4 File Offset: 0x007D10A4
		public static Offset<IVisualNovelPerformanceBase> Pack(FlatBufferBuilder builder, IVisualNovelPerformanceBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelPerformanceBase>);
			}
			return IVisualNovelPerformanceBase.CreateIVisualNovelPerformanceBase(builder, _o.Type, _o.StartTime, _o.NullMask);
		}

		// Token: 0x040134E0 RID: 79072
		private Table __p;
	}
}
