using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DFD RID: 32253
	public struct IVisualNovelTransitionPerformanceSolarSchool : IFlatbufferObject
	{
		// Token: 0x1700F192 RID: 61842
		// (get) Token: 0x0603A47F RID: 238719 RVA: 0x007DA366 File Offset: 0x007D8566
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A480 RID: 238720 RVA: 0x007DA373 File Offset: 0x007D8573
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A481 RID: 238721 RVA: 0x007DA37C File Offset: 0x007D857C
		public static IVisualNovelTransitionPerformanceSolarSchool GetRootAsIVisualNovelTransitionPerformanceSolarSchool(ByteBuffer _bb)
		{
			return IVisualNovelTransitionPerformanceSolarSchool.GetRootAsIVisualNovelTransitionPerformanceSolarSchool(_bb, default(IVisualNovelTransitionPerformanceSolarSchool));
		}

		// Token: 0x0603A482 RID: 238722 RVA: 0x007DA398 File Offset: 0x007D8598
		public static IVisualNovelTransitionPerformanceSolarSchool GetRootAsIVisualNovelTransitionPerformanceSolarSchool(ByteBuffer _bb, IVisualNovelTransitionPerformanceSolarSchool obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A483 RID: 238723 RVA: 0x007DA3B5 File Offset: 0x007D85B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A484 RID: 238724 RVA: 0x007DA3C4 File Offset: 0x007D85C4
		public IVisualNovelTransitionPerformanceSolarSchool __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F193 RID: 61843
		// (get) Token: 0x0603A485 RID: 238725 RVA: 0x007DA3D4 File Offset: 0x007D85D4
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

		// Token: 0x1700F194 RID: 61844
		// (get) Token: 0x0603A486 RID: 238726 RVA: 0x007DA410 File Offset: 0x007D8610
		public TVisualNovelTransitionConfig TransitionConfigType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TVisualNovelTransitionConfig.NONE;
				}
				return (TVisualNovelTransitionConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603A487 RID: 238727 RVA: 0x007DA44C File Offset: 0x007D864C
		public TTable? TransitionConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603A488 RID: 238728 RVA: 0x007DA490 File Offset: 0x007D8690
		public IVisualNovelTransitionLocation TransitionConfigAsIVisualNovelTransitionLocation()
		{
			return this.TransitionConfig<IVisualNovelTransitionLocation>().Value;
		}

		// Token: 0x0603A489 RID: 238729 RVA: 0x007DA4AC File Offset: 0x007D86AC
		public IVisualNovelTransitionTime TransitionConfigAsIVisualNovelTransitionTime()
		{
			return this.TransitionConfig<IVisualNovelTransitionTime>().Value;
		}

		// Token: 0x0603A48A RID: 238730 RVA: 0x007DA4C7 File Offset: 0x007D86C7
		public static Offset<IVisualNovelTransitionPerformanceSolarSchool> CreateIVisualNovelTransitionPerformanceSolarSchool(FlatBufferBuilder builder, EVisualNovelSubType Type = EVisualNovelSubType.SolarSchool, TVisualNovelTransitionConfig TransitionConfig_type = TVisualNovelTransitionConfig.NONE, int TransitionConfigOffset = 0)
		{
			builder.StartTable(3);
			IVisualNovelTransitionPerformanceSolarSchool.AddTransitionConfig(builder, TransitionConfigOffset);
			IVisualNovelTransitionPerformanceSolarSchool.AddTransitionConfigType(builder, TransitionConfig_type);
			IVisualNovelTransitionPerformanceSolarSchool.AddType(builder, Type);
			return IVisualNovelTransitionPerformanceSolarSchool.EndIVisualNovelTransitionPerformanceSolarSchool(builder);
		}

		// Token: 0x0603A48B RID: 238731 RVA: 0x007DA4EB File Offset: 0x007D86EB
		public static void StartIVisualNovelTransitionPerformanceSolarSchool(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603A48C RID: 238732 RVA: 0x007DA4F4 File Offset: 0x007D86F4
		public static void AddType(FlatBufferBuilder builder, EVisualNovelSubType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603A48D RID: 238733 RVA: 0x007DA4FF File Offset: 0x007D86FF
		public static void AddTransitionConfigType(FlatBufferBuilder builder, TVisualNovelTransitionConfig transitionConfigType)
		{
			builder.AddByte(1, (byte)transitionConfigType, 0);
		}

		// Token: 0x0603A48E RID: 238734 RVA: 0x007DA50A File Offset: 0x007D870A
		public static void AddTransitionConfig(FlatBufferBuilder builder, int transitionConfigOffset)
		{
			builder.AddOffset(2, transitionConfigOffset, 0);
		}

		// Token: 0x0603A48F RID: 238735 RVA: 0x007DA515 File Offset: 0x007D8715
		public static Offset<IVisualNovelTransitionPerformanceSolarSchool> EndIVisualNovelTransitionPerformanceSolarSchool(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelTransitionPerformanceSolarSchool>(builder.EndTable());
		}

		// Token: 0x0603A490 RID: 238736 RVA: 0x007DA524 File Offset: 0x007D8724
		public IVisualNovelTransitionPerformanceSolarSchoolT UnPack()
		{
			IVisualNovelTransitionPerformanceSolarSchoolT visualNovelTransitionPerformanceSolarSchoolT = new IVisualNovelTransitionPerformanceSolarSchoolT();
			this.UnPackTo(visualNovelTransitionPerformanceSolarSchoolT);
			return visualNovelTransitionPerformanceSolarSchoolT;
		}

		// Token: 0x0603A491 RID: 238737 RVA: 0x007DA540 File Offset: 0x007D8740
		public void UnPackTo(IVisualNovelTransitionPerformanceSolarSchoolT _o)
		{
			_o.Type = this.Type;
			_o.TransitionConfig = new TVisualNovelTransitionConfigUnion();
			_o.TransitionConfig.Type = this.TransitionConfigType;
			TVisualNovelTransitionConfig transitionConfigType = this.TransitionConfigType;
			if (transitionConfigType == TVisualNovelTransitionConfig.IVisualNovelTransitionLocation)
			{
				_o.TransitionConfig.Value = ((this.TransitionConfig<IVisualNovelTransitionLocation>() != null) ? this.TransitionConfig<IVisualNovelTransitionLocation>().Value.UnPack() : null);
				return;
			}
			if (transitionConfigType != TVisualNovelTransitionConfig.IVisualNovelTransitionTime)
			{
				return;
			}
			_o.TransitionConfig.Value = ((this.TransitionConfig<IVisualNovelTransitionTime>() != null) ? this.TransitionConfig<IVisualNovelTransitionTime>().Value.UnPack() : null);
		}

		// Token: 0x0603A492 RID: 238738 RVA: 0x007DA5F0 File Offset: 0x007D87F0
		public static Offset<IVisualNovelTransitionPerformanceSolarSchool> Pack(FlatBufferBuilder builder, IVisualNovelTransitionPerformanceSolarSchoolT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelTransitionPerformanceSolarSchool>);
			}
			TVisualNovelTransitionConfig transitionConfig_type = (_o.TransitionConfig == null) ? TVisualNovelTransitionConfig.NONE : _o.TransitionConfig.Type;
			int transitionConfigOffset = (_o.TransitionConfig == null) ? 0 : TVisualNovelTransitionConfigUnion.Pack(builder, _o.TransitionConfig);
			return IVisualNovelTransitionPerformanceSolarSchool.CreateIVisualNovelTransitionPerformanceSolarSchool(builder, _o.Type, transitionConfig_type, transitionConfigOffset);
		}

		// Token: 0x040135A7 RID: 79271
		private Table __p;
	}
}
