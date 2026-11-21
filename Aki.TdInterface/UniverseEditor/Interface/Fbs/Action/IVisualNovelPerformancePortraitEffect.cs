using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DB2 RID: 32178
	public struct IVisualNovelPerformancePortraitEffect : IFlatbufferObject
	{
		// Token: 0x1700F0F6 RID: 61686
		// (get) Token: 0x0603A21F RID: 238111 RVA: 0x007D6500 File Offset: 0x007D4700
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A220 RID: 238112 RVA: 0x007D650D File Offset: 0x007D470D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A221 RID: 238113 RVA: 0x007D6514 File Offset: 0x007D4714
		public static IVisualNovelPerformancePortraitEffect GetRootAsIVisualNovelPerformancePortraitEffect(ByteBuffer _bb)
		{
			return IVisualNovelPerformancePortraitEffect.GetRootAsIVisualNovelPerformancePortraitEffect(_bb, default(IVisualNovelPerformancePortraitEffect));
		}

		// Token: 0x0603A222 RID: 238114 RVA: 0x007D6530 File Offset: 0x007D4730
		public static IVisualNovelPerformancePortraitEffect GetRootAsIVisualNovelPerformancePortraitEffect(ByteBuffer _bb, IVisualNovelPerformancePortraitEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A223 RID: 238115 RVA: 0x007D654D File Offset: 0x007D474D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A224 RID: 238116 RVA: 0x007D655C File Offset: 0x007D475C
		public IVisualNovelPerformancePortraitEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F0F7 RID: 61687
		// (get) Token: 0x0603A225 RID: 238117 RVA: 0x007D656C File Offset: 0x007D476C
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

		// Token: 0x1700F0F8 RID: 61688
		// (get) Token: 0x0603A226 RID: 238118 RVA: 0x007D65A8 File Offset: 0x007D47A8
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

		// Token: 0x1700F0F9 RID: 61689
		// (get) Token: 0x0603A227 RID: 238119 RVA: 0x007D65E8 File Offset: 0x007D47E8
		public int WhoId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700F0FA RID: 61690
		// (get) Token: 0x0603A228 RID: 238120 RVA: 0x007D6624 File Offset: 0x007D4824
		public EVisualNovelPortraitEffectType EffectType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return EVisualNovelPortraitEffectType.Jump;
				}
				return (EVisualNovelPortraitEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700F0FB RID: 61691
		// (get) Token: 0x0603A229 RID: 238121 RVA: 0x007D6664 File Offset: 0x007D4864
		public EVisualNovelAmplitude Amplitude
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return EVisualNovelAmplitude.Small;
				}
				return (EVisualNovelAmplitude)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700F0FC RID: 61692
		// (get) Token: 0x0603A22A RID: 238122 RVA: 0x007D66A4 File Offset: 0x007D48A4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603A22B RID: 238123 RVA: 0x007D66E1 File Offset: 0x007D48E1
		public static Offset<IVisualNovelPerformancePortraitEffect> CreateIVisualNovelPerformancePortraitEffect(FlatBufferBuilder builder, EVisualNovelPerformanceType Type = EVisualNovelPerformanceType.Enter, float StartTime = 0f, int WhoId = 0, EVisualNovelPortraitEffectType EffectType = EVisualNovelPortraitEffectType.Jump, EVisualNovelAmplitude Amplitude = EVisualNovelAmplitude.Small, byte NullMask = 0)
		{
			builder.StartTable(6);
			IVisualNovelPerformancePortraitEffect.AddWhoId(builder, WhoId);
			IVisualNovelPerformancePortraitEffect.AddStartTime(builder, StartTime);
			IVisualNovelPerformancePortraitEffect.AddNullMask(builder, NullMask);
			IVisualNovelPerformancePortraitEffect.AddAmplitude(builder, Amplitude);
			IVisualNovelPerformancePortraitEffect.AddEffectType(builder, EffectType);
			IVisualNovelPerformancePortraitEffect.AddType(builder, Type);
			return IVisualNovelPerformancePortraitEffect.EndIVisualNovelPerformancePortraitEffect(builder);
		}

		// Token: 0x0603A22C RID: 238124 RVA: 0x007D671D File Offset: 0x007D491D
		public static void StartIVisualNovelPerformancePortraitEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0603A22D RID: 238125 RVA: 0x007D6726 File Offset: 0x007D4926
		public static void AddType(FlatBufferBuilder builder, EVisualNovelPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603A22E RID: 238126 RVA: 0x007D6731 File Offset: 0x007D4931
		public static void AddStartTime(FlatBufferBuilder builder, float startTime)
		{
			builder.AddFloat(1, startTime, 0.0);
		}

		// Token: 0x0603A22F RID: 238127 RVA: 0x007D6744 File Offset: 0x007D4944
		public static void AddWhoId(FlatBufferBuilder builder, int whoId)
		{
			builder.AddInt(2, whoId, 0);
		}

		// Token: 0x0603A230 RID: 238128 RVA: 0x007D674F File Offset: 0x007D494F
		public static void AddEffectType(FlatBufferBuilder builder, EVisualNovelPortraitEffectType effectType)
		{
			builder.AddByte(3, (byte)effectType, 0);
		}

		// Token: 0x0603A231 RID: 238129 RVA: 0x007D675A File Offset: 0x007D495A
		public static void AddAmplitude(FlatBufferBuilder builder, EVisualNovelAmplitude amplitude)
		{
			builder.AddByte(4, (byte)amplitude, 0);
		}

		// Token: 0x0603A232 RID: 238130 RVA: 0x007D6765 File Offset: 0x007D4965
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0603A233 RID: 238131 RVA: 0x007D6770 File Offset: 0x007D4970
		public static Offset<IVisualNovelPerformancePortraitEffect> EndIVisualNovelPerformancePortraitEffect(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelPerformancePortraitEffect>(builder.EndTable());
		}

		// Token: 0x0603A234 RID: 238132 RVA: 0x007D6780 File Offset: 0x007D4980
		public IVisualNovelPerformancePortraitEffectT UnPack()
		{
			IVisualNovelPerformancePortraitEffectT visualNovelPerformancePortraitEffectT = new IVisualNovelPerformancePortraitEffectT();
			this.UnPackTo(visualNovelPerformancePortraitEffectT);
			return visualNovelPerformancePortraitEffectT;
		}

		// Token: 0x0603A235 RID: 238133 RVA: 0x007D679C File Offset: 0x007D499C
		public void UnPackTo(IVisualNovelPerformancePortraitEffectT _o)
		{
			_o.Type = this.Type;
			_o.StartTime = this.StartTime;
			_o.WhoId = this.WhoId;
			_o.EffectType = this.EffectType;
			_o.Amplitude = this.Amplitude;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603A236 RID: 238134 RVA: 0x007D67F4 File Offset: 0x007D49F4
		public static Offset<IVisualNovelPerformancePortraitEffect> Pack(FlatBufferBuilder builder, IVisualNovelPerformancePortraitEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelPerformancePortraitEffect>);
			}
			return IVisualNovelPerformancePortraitEffect.CreateIVisualNovelPerformancePortraitEffect(builder, _o.Type, _o.StartTime, _o.WhoId, _o.EffectType, _o.Amplitude, _o.NullMask);
		}

		// Token: 0x04013533 RID: 79155
		private Table __p;
	}
}
