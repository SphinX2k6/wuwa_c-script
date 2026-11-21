using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DF7 RID: 32247
	public struct IVisualNovelTransitionPerformanceConfigBase : IFlatbufferObject
	{
		// Token: 0x1700F18D RID: 61837
		// (get) Token: 0x0603A461 RID: 238689 RVA: 0x007DA0F4 File Offset: 0x007D82F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A462 RID: 238690 RVA: 0x007DA101 File Offset: 0x007D8301
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A463 RID: 238691 RVA: 0x007DA108 File Offset: 0x007D8308
		public static IVisualNovelTransitionPerformanceConfigBase GetRootAsIVisualNovelTransitionPerformanceConfigBase(ByteBuffer _bb)
		{
			return IVisualNovelTransitionPerformanceConfigBase.GetRootAsIVisualNovelTransitionPerformanceConfigBase(_bb, default(IVisualNovelTransitionPerformanceConfigBase));
		}

		// Token: 0x0603A464 RID: 238692 RVA: 0x007DA124 File Offset: 0x007D8324
		public static IVisualNovelTransitionPerformanceConfigBase GetRootAsIVisualNovelTransitionPerformanceConfigBase(ByteBuffer _bb, IVisualNovelTransitionPerformanceConfigBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A465 RID: 238693 RVA: 0x007DA141 File Offset: 0x007D8341
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A466 RID: 238694 RVA: 0x007DA150 File Offset: 0x007D8350
		public IVisualNovelTransitionPerformanceConfigBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F18E RID: 61838
		// (get) Token: 0x0603A467 RID: 238695 RVA: 0x007DA160 File Offset: 0x007D8360
		public EVisualNovelSubType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisualNovelSubType.SolarSchool;
				}
				return (EVisualNovelSubType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603A468 RID: 238696 RVA: 0x007DA19C File Offset: 0x007D839C
		public static Offset<IVisualNovelTransitionPerformanceConfigBase> CreateIVisualNovelTransitionPerformanceConfigBase(FlatBufferBuilder builder, EVisualNovelSubType Type = EVisualNovelSubType.SolarSchool)
		{
			builder.StartTable(1);
			IVisualNovelTransitionPerformanceConfigBase.AddType(builder, Type);
			return IVisualNovelTransitionPerformanceConfigBase.EndIVisualNovelTransitionPerformanceConfigBase(builder);
		}

		// Token: 0x0603A469 RID: 238697 RVA: 0x007DA1B2 File Offset: 0x007D83B2
		public static void StartIVisualNovelTransitionPerformanceConfigBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603A46A RID: 238698 RVA: 0x007DA1BB File Offset: 0x007D83BB
		public static void AddType(FlatBufferBuilder builder, EVisualNovelSubType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603A46B RID: 238699 RVA: 0x007DA1C6 File Offset: 0x007D83C6
		public static Offset<IVisualNovelTransitionPerformanceConfigBase> EndIVisualNovelTransitionPerformanceConfigBase(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelTransitionPerformanceConfigBase>(builder.EndTable());
		}

		// Token: 0x0603A46C RID: 238700 RVA: 0x007DA1D4 File Offset: 0x007D83D4
		public IVisualNovelTransitionPerformanceConfigBaseT UnPack()
		{
			IVisualNovelTransitionPerformanceConfigBaseT visualNovelTransitionPerformanceConfigBaseT = new IVisualNovelTransitionPerformanceConfigBaseT();
			this.UnPackTo(visualNovelTransitionPerformanceConfigBaseT);
			return visualNovelTransitionPerformanceConfigBaseT;
		}

		// Token: 0x0603A46D RID: 238701 RVA: 0x007DA1EF File Offset: 0x007D83EF
		public void UnPackTo(IVisualNovelTransitionPerformanceConfigBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603A46E RID: 238702 RVA: 0x007DA200 File Offset: 0x007D8400
		public static Offset<IVisualNovelTransitionPerformanceConfigBase> Pack(FlatBufferBuilder builder, IVisualNovelTransitionPerformanceConfigBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelTransitionPerformanceConfigBase>);
			}
			return IVisualNovelTransitionPerformanceConfigBase.CreateIVisualNovelTransitionPerformanceConfigBase(builder, _o.Type);
		}

		// Token: 0x0401359F RID: 79263
		private Table __p;
	}
}
