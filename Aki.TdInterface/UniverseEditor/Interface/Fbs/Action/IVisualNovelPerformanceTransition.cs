using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075C8 RID: 30152
	public struct IVisualNovelPerformanceTransition : IFlatbufferObject
	{
		// Token: 0x1700E500 RID: 58624
		// (get) Token: 0x06036E9C RID: 224924 RVA: 0x0077420F File Offset: 0x0077240F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036E9D RID: 224925 RVA: 0x0077421C File Offset: 0x0077241C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036E9E RID: 224926 RVA: 0x00774224 File Offset: 0x00772424
		public static IVisualNovelPerformanceTransition GetRootAsIVisualNovelPerformanceTransition(ByteBuffer _bb)
		{
			return IVisualNovelPerformanceTransition.GetRootAsIVisualNovelPerformanceTransition(_bb, default(IVisualNovelPerformanceTransition));
		}

		// Token: 0x06036E9F RID: 224927 RVA: 0x00774240 File Offset: 0x00772440
		public static IVisualNovelPerformanceTransition GetRootAsIVisualNovelPerformanceTransition(ByteBuffer _bb, IVisualNovelPerformanceTransition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036EA0 RID: 224928 RVA: 0x0077425D File Offset: 0x0077245D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036EA1 RID: 224929 RVA: 0x0077426C File Offset: 0x0077246C
		public IVisualNovelPerformanceTransition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E501 RID: 58625
		// (get) Token: 0x06036EA2 RID: 224930 RVA: 0x0077427C File Offset: 0x0077247C
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

		// Token: 0x1700E502 RID: 58626
		// (get) Token: 0x06036EA3 RID: 224931 RVA: 0x007742B8 File Offset: 0x007724B8
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

		// Token: 0x1700E503 RID: 58627
		// (get) Token: 0x06036EA4 RID: 224932 RVA: 0x007742F8 File Offset: 0x007724F8
		public IVisualNovelTransitionPerformanceSolarSchool? TransitionPerformanceConfig
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVisualNovelTransitionPerformanceSolarSchool?(default(IVisualNovelTransitionPerformanceSolarSchool).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700E504 RID: 58628
		// (get) Token: 0x06036EA5 RID: 224933 RVA: 0x00774358 File Offset: 0x00772558
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036EA6 RID: 224934 RVA: 0x00774395 File Offset: 0x00772595
		public static Offset<IVisualNovelPerformanceTransition> CreateIVisualNovelPerformanceTransition(FlatBufferBuilder builder, EVisualNovelPerformanceType Type = EVisualNovelPerformanceType.Enter, float StartTime = 0f, Offset<IVisualNovelTransitionPerformanceSolarSchool> TransitionPerformanceConfigOffset = default(Offset<IVisualNovelTransitionPerformanceSolarSchool>), byte NullMask = 0)
		{
			builder.StartTable(4);
			IVisualNovelPerformanceTransition.AddTransitionPerformanceConfig(builder, TransitionPerformanceConfigOffset);
			IVisualNovelPerformanceTransition.AddStartTime(builder, StartTime);
			IVisualNovelPerformanceTransition.AddNullMask(builder, NullMask);
			IVisualNovelPerformanceTransition.AddType(builder, Type);
			return IVisualNovelPerformanceTransition.EndIVisualNovelPerformanceTransition(builder);
		}

		// Token: 0x06036EA7 RID: 224935 RVA: 0x007743C1 File Offset: 0x007725C1
		public static void StartIVisualNovelPerformanceTransition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06036EA8 RID: 224936 RVA: 0x007743CA File Offset: 0x007725CA
		public static void AddType(FlatBufferBuilder builder, EVisualNovelPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036EA9 RID: 224937 RVA: 0x007743D5 File Offset: 0x007725D5
		public static void AddStartTime(FlatBufferBuilder builder, float startTime)
		{
			builder.AddFloat(1, startTime, 0.0);
		}

		// Token: 0x06036EAA RID: 224938 RVA: 0x007743E8 File Offset: 0x007725E8
		public static void AddTransitionPerformanceConfig(FlatBufferBuilder builder, Offset<IVisualNovelTransitionPerformanceSolarSchool> transitionPerformanceConfigOffset)
		{
			builder.AddOffset(2, transitionPerformanceConfigOffset.Value, 0);
		}

		// Token: 0x06036EAB RID: 224939 RVA: 0x007743F8 File Offset: 0x007725F8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06036EAC RID: 224940 RVA: 0x00774403 File Offset: 0x00772603
		public static Offset<IVisualNovelPerformanceTransition> EndIVisualNovelPerformanceTransition(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelPerformanceTransition>(builder.EndTable());
		}

		// Token: 0x06036EAD RID: 224941 RVA: 0x00774410 File Offset: 0x00772610
		public IVisualNovelPerformanceTransitionT UnPack()
		{
			IVisualNovelPerformanceTransitionT visualNovelPerformanceTransitionT = new IVisualNovelPerformanceTransitionT();
			this.UnPackTo(visualNovelPerformanceTransitionT);
			return visualNovelPerformanceTransitionT;
		}

		// Token: 0x06036EAE RID: 224942 RVA: 0x0077442C File Offset: 0x0077262C
		public void UnPackTo(IVisualNovelPerformanceTransitionT _o)
		{
			_o.Type = this.Type;
			_o.StartTime = this.StartTime;
			_o.TransitionPerformanceConfig = ((this.TransitionPerformanceConfig != null) ? this.TransitionPerformanceConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06036EAF RID: 224943 RVA: 0x0077448C File Offset: 0x0077268C
		public static Offset<IVisualNovelPerformanceTransition> Pack(FlatBufferBuilder builder, IVisualNovelPerformanceTransitionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelPerformanceTransition>);
			}
			Offset<IVisualNovelTransitionPerformanceSolarSchool> transitionPerformanceConfigOffset = (_o.TransitionPerformanceConfig == null) ? default(Offset<IVisualNovelTransitionPerformanceSolarSchool>) : IVisualNovelTransitionPerformanceSolarSchool.Pack(builder, _o.TransitionPerformanceConfig);
			return IVisualNovelPerformanceTransition.CreateIVisualNovelPerformanceTransition(builder, _o.Type, _o.StartTime, transitionPerformanceConfigOffset, _o.NullMask);
		}

		// Token: 0x0401251E RID: 75038
		private Table __p;
	}
}
