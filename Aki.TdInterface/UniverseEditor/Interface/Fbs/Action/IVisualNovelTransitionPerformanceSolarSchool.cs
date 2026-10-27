using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075EF RID: 30191
	public struct IVisualNovelTransitionPerformanceSolarSchool : IFlatbufferObject
	{
		// Token: 0x1700E554 RID: 58708
		// (get) Token: 0x06036FDA RID: 225242 RVA: 0x0077626A File Offset: 0x0077446A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036FDB RID: 225243 RVA: 0x00776277 File Offset: 0x00774477
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036FDC RID: 225244 RVA: 0x00776280 File Offset: 0x00774480
		public static IVisualNovelTransitionPerformanceSolarSchool GetRootAsIVisualNovelTransitionPerformanceSolarSchool(ByteBuffer _bb)
		{
			return IVisualNovelTransitionPerformanceSolarSchool.GetRootAsIVisualNovelTransitionPerformanceSolarSchool(_bb, default(IVisualNovelTransitionPerformanceSolarSchool));
		}

		// Token: 0x06036FDD RID: 225245 RVA: 0x0077629C File Offset: 0x0077449C
		public static IVisualNovelTransitionPerformanceSolarSchool GetRootAsIVisualNovelTransitionPerformanceSolarSchool(ByteBuffer _bb, IVisualNovelTransitionPerformanceSolarSchool obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036FDE RID: 225246 RVA: 0x007762B9 File Offset: 0x007744B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036FDF RID: 225247 RVA: 0x007762C8 File Offset: 0x007744C8
		public IVisualNovelTransitionPerformanceSolarSchool __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E555 RID: 58709
		// (get) Token: 0x06036FE0 RID: 225248 RVA: 0x007762D8 File Offset: 0x007744D8
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

		// Token: 0x1700E556 RID: 58710
		// (get) Token: 0x06036FE1 RID: 225249 RVA: 0x00776314 File Offset: 0x00774514
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

		// Token: 0x06036FE2 RID: 225250 RVA: 0x00776350 File Offset: 0x00774550
		public TTable? TransitionConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06036FE3 RID: 225251 RVA: 0x00776394 File Offset: 0x00774594
		public IVisualNovelTransitionLocation TransitionConfigAsIVisualNovelTransitionLocation()
		{
			return this.TransitionConfig<IVisualNovelTransitionLocation>().Value;
		}

		// Token: 0x06036FE4 RID: 225252 RVA: 0x007763B0 File Offset: 0x007745B0
		public IVisualNovelTransitionTime TransitionConfigAsIVisualNovelTransitionTime()
		{
			return this.TransitionConfig<IVisualNovelTransitionTime>().Value;
		}

		// Token: 0x06036FE5 RID: 225253 RVA: 0x007763CB File Offset: 0x007745CB
		public static Offset<IVisualNovelTransitionPerformanceSolarSchool> CreateIVisualNovelTransitionPerformanceSolarSchool(FlatBufferBuilder builder, EVisualNovelSubType Type = EVisualNovelSubType.SolarSchool, TVisualNovelTransitionConfig TransitionConfig_type = TVisualNovelTransitionConfig.NONE, int TransitionConfigOffset = 0)
		{
			builder.StartTable(3);
			IVisualNovelTransitionPerformanceSolarSchool.AddTransitionConfig(builder, TransitionConfigOffset);
			IVisualNovelTransitionPerformanceSolarSchool.AddTransitionConfigType(builder, TransitionConfig_type);
			IVisualNovelTransitionPerformanceSolarSchool.AddType(builder, Type);
			return IVisualNovelTransitionPerformanceSolarSchool.EndIVisualNovelTransitionPerformanceSolarSchool(builder);
		}

		// Token: 0x06036FE6 RID: 225254 RVA: 0x007763EF File Offset: 0x007745EF
		public static void StartIVisualNovelTransitionPerformanceSolarSchool(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06036FE7 RID: 225255 RVA: 0x007763F8 File Offset: 0x007745F8
		public static void AddType(FlatBufferBuilder builder, EVisualNovelSubType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036FE8 RID: 225256 RVA: 0x00776403 File Offset: 0x00774603
		public static void AddTransitionConfigType(FlatBufferBuilder builder, TVisualNovelTransitionConfig transitionConfigType)
		{
			builder.AddByte(1, (byte)transitionConfigType, 0);
		}

		// Token: 0x06036FE9 RID: 225257 RVA: 0x0077640E File Offset: 0x0077460E
		public static void AddTransitionConfig(FlatBufferBuilder builder, int transitionConfigOffset)
		{
			builder.AddOffset(2, transitionConfigOffset, 0);
		}

		// Token: 0x06036FEA RID: 225258 RVA: 0x00776419 File Offset: 0x00774619
		public static Offset<IVisualNovelTransitionPerformanceSolarSchool> EndIVisualNovelTransitionPerformanceSolarSchool(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelTransitionPerformanceSolarSchool>(builder.EndTable());
		}

		// Token: 0x06036FEB RID: 225259 RVA: 0x00776428 File Offset: 0x00774628
		public IVisualNovelTransitionPerformanceSolarSchoolT UnPack()
		{
			IVisualNovelTransitionPerformanceSolarSchoolT visualNovelTransitionPerformanceSolarSchoolT = new IVisualNovelTransitionPerformanceSolarSchoolT();
			this.UnPackTo(visualNovelTransitionPerformanceSolarSchoolT);
			return visualNovelTransitionPerformanceSolarSchoolT;
		}

		// Token: 0x06036FEC RID: 225260 RVA: 0x00776444 File Offset: 0x00774644
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

		// Token: 0x06036FED RID: 225261 RVA: 0x007764F4 File Offset: 0x007746F4
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

		// Token: 0x0401255D RID: 75101
		private Table __p;
	}
}
