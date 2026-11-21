using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DAF RID: 32175
	public struct IVisualNovelPerformancePlayScreenEffect : IFlatbufferObject
	{
		// Token: 0x1700F0ED RID: 61677
		// (get) Token: 0x0603A1FC RID: 238076 RVA: 0x007D5FF2 File Offset: 0x007D41F2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A1FD RID: 238077 RVA: 0x007D5FFF File Offset: 0x007D41FF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A1FE RID: 238078 RVA: 0x007D6008 File Offset: 0x007D4208
		public static IVisualNovelPerformancePlayScreenEffect GetRootAsIVisualNovelPerformancePlayScreenEffect(ByteBuffer _bb)
		{
			return IVisualNovelPerformancePlayScreenEffect.GetRootAsIVisualNovelPerformancePlayScreenEffect(_bb, default(IVisualNovelPerformancePlayScreenEffect));
		}

		// Token: 0x0603A1FF RID: 238079 RVA: 0x007D6024 File Offset: 0x007D4224
		public static IVisualNovelPerformancePlayScreenEffect GetRootAsIVisualNovelPerformancePlayScreenEffect(ByteBuffer _bb, IVisualNovelPerformancePlayScreenEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A200 RID: 238080 RVA: 0x007D6041 File Offset: 0x007D4241
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A201 RID: 238081 RVA: 0x007D6050 File Offset: 0x007D4250
		public IVisualNovelPerformancePlayScreenEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F0EE RID: 61678
		// (get) Token: 0x0603A202 RID: 238082 RVA: 0x007D6060 File Offset: 0x007D4260
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

		// Token: 0x1700F0EF RID: 61679
		// (get) Token: 0x0603A203 RID: 238083 RVA: 0x007D609C File Offset: 0x007D429C
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

		// Token: 0x1700F0F0 RID: 61680
		// (get) Token: 0x0603A204 RID: 238084 RVA: 0x007D60DC File Offset: 0x007D42DC
		public TVisualNovelPlayScreenEffectConfig EffectConfigType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TVisualNovelPlayScreenEffectConfig.NONE;
				}
				return (TVisualNovelPlayScreenEffectConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603A205 RID: 238085 RVA: 0x007D6118 File Offset: 0x007D4318
		public TTable? EffectConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603A206 RID: 238086 RVA: 0x007D6160 File Offset: 0x007D4360
		public IVisualNovelPlayScreenEffectCustom EffectConfigAsIVisualNovelPlayScreenEffectCustom()
		{
			return this.EffectConfig<IVisualNovelPlayScreenEffectCustom>().Value;
		}

		// Token: 0x0603A207 RID: 238087 RVA: 0x007D617C File Offset: 0x007D437C
		public IVisualNovelPlayScreenEffectOneShot EffectConfigAsIVisualNovelPlayScreenEffectOneShot()
		{
			return this.EffectConfig<IVisualNovelPlayScreenEffectOneShot>().Value;
		}

		// Token: 0x0603A208 RID: 238088 RVA: 0x007D6198 File Offset: 0x007D4398
		public IVisualNovelPlayScreenEffectPersistent EffectConfigAsIVisualNovelPlayScreenEffectPersistent()
		{
			return this.EffectConfig<IVisualNovelPlayScreenEffectPersistent>().Value;
		}

		// Token: 0x1700F0F1 RID: 61681
		// (get) Token: 0x0603A209 RID: 238089 RVA: 0x007D61B4 File Offset: 0x007D43B4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603A20A RID: 238090 RVA: 0x007D61F1 File Offset: 0x007D43F1
		public static Offset<IVisualNovelPerformancePlayScreenEffect> CreateIVisualNovelPerformancePlayScreenEffect(FlatBufferBuilder builder, EVisualNovelPerformanceType Type = EVisualNovelPerformanceType.Enter, float StartTime = 0f, TVisualNovelPlayScreenEffectConfig EffectConfig_type = TVisualNovelPlayScreenEffectConfig.NONE, int EffectConfigOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(5);
			IVisualNovelPerformancePlayScreenEffect.AddEffectConfig(builder, EffectConfigOffset);
			IVisualNovelPerformancePlayScreenEffect.AddStartTime(builder, StartTime);
			IVisualNovelPerformancePlayScreenEffect.AddNullMask(builder, NullMask);
			IVisualNovelPerformancePlayScreenEffect.AddEffectConfigType(builder, EffectConfig_type);
			IVisualNovelPerformancePlayScreenEffect.AddType(builder, Type);
			return IVisualNovelPerformancePlayScreenEffect.EndIVisualNovelPerformancePlayScreenEffect(builder);
		}

		// Token: 0x0603A20B RID: 238091 RVA: 0x007D6225 File Offset: 0x007D4425
		public static void StartIVisualNovelPerformancePlayScreenEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0603A20C RID: 238092 RVA: 0x007D622E File Offset: 0x007D442E
		public static void AddType(FlatBufferBuilder builder, EVisualNovelPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603A20D RID: 238093 RVA: 0x007D6239 File Offset: 0x007D4439
		public static void AddStartTime(FlatBufferBuilder builder, float startTime)
		{
			builder.AddFloat(1, startTime, 0.0);
		}

		// Token: 0x0603A20E RID: 238094 RVA: 0x007D624C File Offset: 0x007D444C
		public static void AddEffectConfigType(FlatBufferBuilder builder, TVisualNovelPlayScreenEffectConfig effectConfigType)
		{
			builder.AddByte(2, (byte)effectConfigType, 0);
		}

		// Token: 0x0603A20F RID: 238095 RVA: 0x007D6257 File Offset: 0x007D4457
		public static void AddEffectConfig(FlatBufferBuilder builder, int effectConfigOffset)
		{
			builder.AddOffset(3, effectConfigOffset, 0);
		}

		// Token: 0x0603A210 RID: 238096 RVA: 0x007D6262 File Offset: 0x007D4462
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0603A211 RID: 238097 RVA: 0x007D626D File Offset: 0x007D446D
		public static Offset<IVisualNovelPerformancePlayScreenEffect> EndIVisualNovelPerformancePlayScreenEffect(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelPerformancePlayScreenEffect>(builder.EndTable());
		}

		// Token: 0x0603A212 RID: 238098 RVA: 0x007D627C File Offset: 0x007D447C
		public IVisualNovelPerformancePlayScreenEffectT UnPack()
		{
			IVisualNovelPerformancePlayScreenEffectT visualNovelPerformancePlayScreenEffectT = new IVisualNovelPerformancePlayScreenEffectT();
			this.UnPackTo(visualNovelPerformancePlayScreenEffectT);
			return visualNovelPerformancePlayScreenEffectT;
		}

		// Token: 0x0603A213 RID: 238099 RVA: 0x007D6298 File Offset: 0x007D4498
		public void UnPackTo(IVisualNovelPerformancePlayScreenEffectT _o)
		{
			_o.Type = this.Type;
			_o.StartTime = this.StartTime;
			_o.EffectConfig = new TVisualNovelPlayScreenEffectConfigUnion();
			_o.EffectConfig.Type = this.EffectConfigType;
			switch (this.EffectConfigType)
			{
			case TVisualNovelPlayScreenEffectConfig.IVisualNovelPlayScreenEffectCustom:
				_o.EffectConfig.Value = ((this.EffectConfig<IVisualNovelPlayScreenEffectCustom>() != null) ? this.EffectConfig<IVisualNovelPlayScreenEffectCustom>().Value.UnPack() : null);
				break;
			case TVisualNovelPlayScreenEffectConfig.IVisualNovelPlayScreenEffectOneShot:
				_o.EffectConfig.Value = ((this.EffectConfig<IVisualNovelPlayScreenEffectOneShot>() != null) ? this.EffectConfig<IVisualNovelPlayScreenEffectOneShot>().Value.UnPack() : null);
				break;
			case TVisualNovelPlayScreenEffectConfig.IVisualNovelPlayScreenEffectPersistent:
				_o.EffectConfig.Value = ((this.EffectConfig<IVisualNovelPlayScreenEffectPersistent>() != null) ? this.EffectConfig<IVisualNovelPlayScreenEffectPersistent>().Value.UnPack() : null);
				break;
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603A214 RID: 238100 RVA: 0x007D63AC File Offset: 0x007D45AC
		public static Offset<IVisualNovelPerformancePlayScreenEffect> Pack(FlatBufferBuilder builder, IVisualNovelPerformancePlayScreenEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelPerformancePlayScreenEffect>);
			}
			TVisualNovelPlayScreenEffectConfig effectConfig_type = (_o.EffectConfig == null) ? TVisualNovelPlayScreenEffectConfig.NONE : _o.EffectConfig.Type;
			int effectConfigOffset = (_o.EffectConfig == null) ? 0 : TVisualNovelPlayScreenEffectConfigUnion.Pack(builder, _o.EffectConfig);
			return IVisualNovelPerformancePlayScreenEffect.CreateIVisualNovelPerformancePlayScreenEffect(builder, _o.Type, _o.StartTime, effectConfig_type, effectConfigOffset, _o.NullMask);
		}

		// Token: 0x0401352E RID: 79150
		private Table __p;
	}
}
