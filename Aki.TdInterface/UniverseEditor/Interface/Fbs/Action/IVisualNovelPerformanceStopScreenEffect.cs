using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DBB RID: 32187
	public struct IVisualNovelPerformanceStopScreenEffect : IFlatbufferObject
	{
		// Token: 0x1700F11B RID: 61723
		// (get) Token: 0x0603A28F RID: 238223 RVA: 0x007D7238 File Offset: 0x007D5438
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A290 RID: 238224 RVA: 0x007D7245 File Offset: 0x007D5445
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A291 RID: 238225 RVA: 0x007D724C File Offset: 0x007D544C
		public static IVisualNovelPerformanceStopScreenEffect GetRootAsIVisualNovelPerformanceStopScreenEffect(ByteBuffer _bb)
		{
			return IVisualNovelPerformanceStopScreenEffect.GetRootAsIVisualNovelPerformanceStopScreenEffect(_bb, default(IVisualNovelPerformanceStopScreenEffect));
		}

		// Token: 0x0603A292 RID: 238226 RVA: 0x007D7268 File Offset: 0x007D5468
		public static IVisualNovelPerformanceStopScreenEffect GetRootAsIVisualNovelPerformanceStopScreenEffect(ByteBuffer _bb, IVisualNovelPerformanceStopScreenEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A293 RID: 238227 RVA: 0x007D7285 File Offset: 0x007D5485
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A294 RID: 238228 RVA: 0x007D7294 File Offset: 0x007D5494
		public IVisualNovelPerformanceStopScreenEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F11C RID: 61724
		// (get) Token: 0x0603A295 RID: 238229 RVA: 0x007D72A4 File Offset: 0x007D54A4
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

		// Token: 0x1700F11D RID: 61725
		// (get) Token: 0x0603A296 RID: 238230 RVA: 0x007D72E0 File Offset: 0x007D54E0
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

		// Token: 0x1700F11E RID: 61726
		// (get) Token: 0x0603A297 RID: 238231 RVA: 0x007D7320 File Offset: 0x007D5520
		public IVisualNovelStopScreenEffectPersistent? EffectConfig
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVisualNovelStopScreenEffectPersistent?(default(IVisualNovelStopScreenEffectPersistent).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700F11F RID: 61727
		// (get) Token: 0x0603A298 RID: 238232 RVA: 0x007D7380 File Offset: 0x007D5580
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

		// Token: 0x0603A299 RID: 238233 RVA: 0x007D73BD File Offset: 0x007D55BD
		public static Offset<IVisualNovelPerformanceStopScreenEffect> CreateIVisualNovelPerformanceStopScreenEffect(FlatBufferBuilder builder, EVisualNovelPerformanceType Type = EVisualNovelPerformanceType.Enter, float StartTime = 0f, Offset<IVisualNovelStopScreenEffectPersistent> EffectConfigOffset = default(Offset<IVisualNovelStopScreenEffectPersistent>), byte NullMask = 0)
		{
			builder.StartTable(4);
			IVisualNovelPerformanceStopScreenEffect.AddEffectConfig(builder, EffectConfigOffset);
			IVisualNovelPerformanceStopScreenEffect.AddStartTime(builder, StartTime);
			IVisualNovelPerformanceStopScreenEffect.AddNullMask(builder, NullMask);
			IVisualNovelPerformanceStopScreenEffect.AddType(builder, Type);
			return IVisualNovelPerformanceStopScreenEffect.EndIVisualNovelPerformanceStopScreenEffect(builder);
		}

		// Token: 0x0603A29A RID: 238234 RVA: 0x007D73E9 File Offset: 0x007D55E9
		public static void StartIVisualNovelPerformanceStopScreenEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0603A29B RID: 238235 RVA: 0x007D73F2 File Offset: 0x007D55F2
		public static void AddType(FlatBufferBuilder builder, EVisualNovelPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603A29C RID: 238236 RVA: 0x007D73FD File Offset: 0x007D55FD
		public static void AddStartTime(FlatBufferBuilder builder, float startTime)
		{
			builder.AddFloat(1, startTime, 0.0);
		}

		// Token: 0x0603A29D RID: 238237 RVA: 0x007D7410 File Offset: 0x007D5610
		public static void AddEffectConfig(FlatBufferBuilder builder, Offset<IVisualNovelStopScreenEffectPersistent> effectConfigOffset)
		{
			builder.AddOffset(2, effectConfigOffset.Value, 0);
		}

		// Token: 0x0603A29E RID: 238238 RVA: 0x007D7420 File Offset: 0x007D5620
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0603A29F RID: 238239 RVA: 0x007D742B File Offset: 0x007D562B
		public static Offset<IVisualNovelPerformanceStopScreenEffect> EndIVisualNovelPerformanceStopScreenEffect(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelPerformanceStopScreenEffect>(builder.EndTable());
		}

		// Token: 0x0603A2A0 RID: 238240 RVA: 0x007D7438 File Offset: 0x007D5638
		public IVisualNovelPerformanceStopScreenEffectT UnPack()
		{
			IVisualNovelPerformanceStopScreenEffectT visualNovelPerformanceStopScreenEffectT = new IVisualNovelPerformanceStopScreenEffectT();
			this.UnPackTo(visualNovelPerformanceStopScreenEffectT);
			return visualNovelPerformanceStopScreenEffectT;
		}

		// Token: 0x0603A2A1 RID: 238241 RVA: 0x007D7454 File Offset: 0x007D5654
		public void UnPackTo(IVisualNovelPerformanceStopScreenEffectT _o)
		{
			_o.Type = this.Type;
			_o.StartTime = this.StartTime;
			_o.EffectConfig = ((this.EffectConfig != null) ? this.EffectConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603A2A2 RID: 238242 RVA: 0x007D74B4 File Offset: 0x007D56B4
		public static Offset<IVisualNovelPerformanceStopScreenEffect> Pack(FlatBufferBuilder builder, IVisualNovelPerformanceStopScreenEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelPerformanceStopScreenEffect>);
			}
			Offset<IVisualNovelStopScreenEffectPersistent> effectConfigOffset = (_o.EffectConfig == null) ? default(Offset<IVisualNovelStopScreenEffectPersistent>) : IVisualNovelStopScreenEffectPersistent.Pack(builder, _o.EffectConfig);
			return IVisualNovelPerformanceStopScreenEffect.CreateIVisualNovelPerformanceStopScreenEffect(builder, _o.Type, _o.StartTime, effectConfigOffset, _o.NullMask);
		}

		// Token: 0x04013547 RID: 79175
		private Table __p;
	}
}
