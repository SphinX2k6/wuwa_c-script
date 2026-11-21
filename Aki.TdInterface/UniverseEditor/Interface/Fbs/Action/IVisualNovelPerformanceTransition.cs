using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DC1 RID: 32193
	public struct IVisualNovelPerformanceTransition : IFlatbufferObject
	{
		// Token: 0x1700F12D RID: 61741
		// (get) Token: 0x0603A2CB RID: 238283 RVA: 0x007D7997 File Offset: 0x007D5B97
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A2CC RID: 238284 RVA: 0x007D79A4 File Offset: 0x007D5BA4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A2CD RID: 238285 RVA: 0x007D79AC File Offset: 0x007D5BAC
		public static IVisualNovelPerformanceTransition GetRootAsIVisualNovelPerformanceTransition(ByteBuffer _bb)
		{
			return IVisualNovelPerformanceTransition.GetRootAsIVisualNovelPerformanceTransition(_bb, default(IVisualNovelPerformanceTransition));
		}

		// Token: 0x0603A2CE RID: 238286 RVA: 0x007D79C8 File Offset: 0x007D5BC8
		public static IVisualNovelPerformanceTransition GetRootAsIVisualNovelPerformanceTransition(ByteBuffer _bb, IVisualNovelPerformanceTransition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A2CF RID: 238287 RVA: 0x007D79E5 File Offset: 0x007D5BE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A2D0 RID: 238288 RVA: 0x007D79F4 File Offset: 0x007D5BF4
		public IVisualNovelPerformanceTransition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F12E RID: 61742
		// (get) Token: 0x0603A2D1 RID: 238289 RVA: 0x007D7A04 File Offset: 0x007D5C04
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

		// Token: 0x1700F12F RID: 61743
		// (get) Token: 0x0603A2D2 RID: 238290 RVA: 0x007D7A40 File Offset: 0x007D5C40
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

		// Token: 0x1700F130 RID: 61744
		// (get) Token: 0x0603A2D3 RID: 238291 RVA: 0x007D7A80 File Offset: 0x007D5C80
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

		// Token: 0x1700F131 RID: 61745
		// (get) Token: 0x0603A2D4 RID: 238292 RVA: 0x007D7AE0 File Offset: 0x007D5CE0
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

		// Token: 0x0603A2D5 RID: 238293 RVA: 0x007D7B1D File Offset: 0x007D5D1D
		public static Offset<IVisualNovelPerformanceTransition> CreateIVisualNovelPerformanceTransition(FlatBufferBuilder builder, EVisualNovelPerformanceType Type = EVisualNovelPerformanceType.Enter, float StartTime = 0f, Offset<IVisualNovelTransitionPerformanceSolarSchool> TransitionPerformanceConfigOffset = default(Offset<IVisualNovelTransitionPerformanceSolarSchool>), byte NullMask = 0)
		{
			builder.StartTable(4);
			IVisualNovelPerformanceTransition.AddTransitionPerformanceConfig(builder, TransitionPerformanceConfigOffset);
			IVisualNovelPerformanceTransition.AddStartTime(builder, StartTime);
			IVisualNovelPerformanceTransition.AddNullMask(builder, NullMask);
			IVisualNovelPerformanceTransition.AddType(builder, Type);
			return IVisualNovelPerformanceTransition.EndIVisualNovelPerformanceTransition(builder);
		}

		// Token: 0x0603A2D6 RID: 238294 RVA: 0x007D7B49 File Offset: 0x007D5D49
		public static void StartIVisualNovelPerformanceTransition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0603A2D7 RID: 238295 RVA: 0x007D7B52 File Offset: 0x007D5D52
		public static void AddType(FlatBufferBuilder builder, EVisualNovelPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603A2D8 RID: 238296 RVA: 0x007D7B5D File Offset: 0x007D5D5D
		public static void AddStartTime(FlatBufferBuilder builder, float startTime)
		{
			builder.AddFloat(1, startTime, 0.0);
		}

		// Token: 0x0603A2D9 RID: 238297 RVA: 0x007D7B70 File Offset: 0x007D5D70
		public static void AddTransitionPerformanceConfig(FlatBufferBuilder builder, Offset<IVisualNovelTransitionPerformanceSolarSchool> transitionPerformanceConfigOffset)
		{
			builder.AddOffset(2, transitionPerformanceConfigOffset.Value, 0);
		}

		// Token: 0x0603A2DA RID: 238298 RVA: 0x007D7B80 File Offset: 0x007D5D80
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0603A2DB RID: 238299 RVA: 0x007D7B8B File Offset: 0x007D5D8B
		public static Offset<IVisualNovelPerformanceTransition> EndIVisualNovelPerformanceTransition(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelPerformanceTransition>(builder.EndTable());
		}

		// Token: 0x0603A2DC RID: 238300 RVA: 0x007D7B98 File Offset: 0x007D5D98
		public IVisualNovelPerformanceTransitionT UnPack()
		{
			IVisualNovelPerformanceTransitionT visualNovelPerformanceTransitionT = new IVisualNovelPerformanceTransitionT();
			this.UnPackTo(visualNovelPerformanceTransitionT);
			return visualNovelPerformanceTransitionT;
		}

		// Token: 0x0603A2DD RID: 238301 RVA: 0x007D7BB4 File Offset: 0x007D5DB4
		public void UnPackTo(IVisualNovelPerformanceTransitionT _o)
		{
			_o.Type = this.Type;
			_o.StartTime = this.StartTime;
			_o.TransitionPerformanceConfig = ((this.TransitionPerformanceConfig != null) ? this.TransitionPerformanceConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603A2DE RID: 238302 RVA: 0x007D7C14 File Offset: 0x007D5E14
		public static Offset<IVisualNovelPerformanceTransition> Pack(FlatBufferBuilder builder, IVisualNovelPerformanceTransitionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelPerformanceTransition>);
			}
			Offset<IVisualNovelTransitionPerformanceSolarSchool> transitionPerformanceConfigOffset = (_o.TransitionPerformanceConfig == null) ? default(Offset<IVisualNovelTransitionPerformanceSolarSchool>) : IVisualNovelTransitionPerformanceSolarSchool.Pack(builder, _o.TransitionPerformanceConfig);
			return IVisualNovelPerformanceTransition.CreateIVisualNovelPerformanceTransition(builder, _o.Type, _o.StartTime, transitionPerformanceConfigOffset, _o.NullMask);
		}

		// Token: 0x04013551 RID: 79185
		private Table __p;
	}
}
