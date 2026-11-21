using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007222 RID: 29218
	public struct IMonsterStandByConfig : IFlatbufferObject
	{
		// Token: 0x1700D5D8 RID: 54744
		// (get) Token: 0x06032D68 RID: 208232 RVA: 0x006DD4FA File Offset: 0x006DB6FA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032D69 RID: 208233 RVA: 0x006DD507 File Offset: 0x006DB707
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032D6A RID: 208234 RVA: 0x006DD510 File Offset: 0x006DB710
		public static IMonsterStandByConfig GetRootAsIMonsterStandByConfig(ByteBuffer _bb)
		{
			return IMonsterStandByConfig.GetRootAsIMonsterStandByConfig(_bb, default(IMonsterStandByConfig));
		}

		// Token: 0x06032D6B RID: 208235 RVA: 0x006DD52C File Offset: 0x006DB72C
		public static IMonsterStandByConfig GetRootAsIMonsterStandByConfig(ByteBuffer _bb, IMonsterStandByConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032D6C RID: 208236 RVA: 0x006DD549 File Offset: 0x006DB749
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032D6D RID: 208237 RVA: 0x006DD558 File Offset: 0x006DB758
		public IMonsterStandByConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D5D9 RID: 54745
		// (get) Token: 0x06032D6E RID: 208238 RVA: 0x006DD568 File Offset: 0x006DB768
		public string Tag
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032D6F RID: 208239 RVA: 0x006DD59F File Offset: 0x006DB79F
		public Span<byte> GetTagBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06032D70 RID: 208240 RVA: 0x006DD5AE File Offset: 0x006DB7AE
		public byte[] GetTagArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700D5DA RID: 54746
		// (get) Token: 0x06032D71 RID: 208241 RVA: 0x006DD5BC File Offset: 0x006DB7BC
		public float Duration
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

		// Token: 0x1700D5DB RID: 54747
		// (get) Token: 0x06032D72 RID: 208242 RVA: 0x006DD5FC File Offset: 0x006DB7FC
		public int RepeatTimes
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

		// Token: 0x1700D5DC RID: 54748
		// (get) Token: 0x06032D73 RID: 208243 RVA: 0x006DD638 File Offset: 0x006DB838
		public int EmotionId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D5DD RID: 54749
		// (get) Token: 0x06032D74 RID: 208244 RVA: 0x006DD678 File Offset: 0x006DB878
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

		// Token: 0x06032D75 RID: 208245 RVA: 0x006DD6B5 File Offset: 0x006DB8B5
		public static Offset<IMonsterStandByConfig> CreateIMonsterStandByConfig(FlatBufferBuilder builder, StringOffset TagOffset = default(StringOffset), float Duration = 0f, int RepeatTimes = 0, int EmotionId = 0, byte NullMask = 0)
		{
			builder.StartTable(5);
			IMonsterStandByConfig.AddEmotionId(builder, EmotionId);
			IMonsterStandByConfig.AddRepeatTimes(builder, RepeatTimes);
			IMonsterStandByConfig.AddDuration(builder, Duration);
			IMonsterStandByConfig.AddTag(builder, TagOffset);
			IMonsterStandByConfig.AddNullMask(builder, NullMask);
			return IMonsterStandByConfig.EndIMonsterStandByConfig(builder);
		}

		// Token: 0x06032D76 RID: 208246 RVA: 0x006DD6E9 File Offset: 0x006DB8E9
		public static void StartIMonsterStandByConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06032D77 RID: 208247 RVA: 0x006DD6F2 File Offset: 0x006DB8F2
		public static void AddTag(FlatBufferBuilder builder, StringOffset tagOffset)
		{
			builder.AddOffset(0, tagOffset.Value, 0);
		}

		// Token: 0x06032D78 RID: 208248 RVA: 0x006DD702 File Offset: 0x006DB902
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(1, duration, 0.0);
		}

		// Token: 0x06032D79 RID: 208249 RVA: 0x006DD715 File Offset: 0x006DB915
		public static void AddRepeatTimes(FlatBufferBuilder builder, int repeatTimes)
		{
			builder.AddInt(2, repeatTimes, 0);
		}

		// Token: 0x06032D7A RID: 208250 RVA: 0x006DD720 File Offset: 0x006DB920
		public static void AddEmotionId(FlatBufferBuilder builder, int emotionId)
		{
			builder.AddInt(3, emotionId, 0);
		}

		// Token: 0x06032D7B RID: 208251 RVA: 0x006DD72B File Offset: 0x006DB92B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06032D7C RID: 208252 RVA: 0x006DD736 File Offset: 0x006DB936
		public static Offset<IMonsterStandByConfig> EndIMonsterStandByConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterStandByConfig>(builder.EndTable());
		}

		// Token: 0x06032D7D RID: 208253 RVA: 0x006DD744 File Offset: 0x006DB944
		public IMonsterStandByConfigT UnPack()
		{
			IMonsterStandByConfigT monsterStandByConfigT = new IMonsterStandByConfigT();
			this.UnPackTo(monsterStandByConfigT);
			return monsterStandByConfigT;
		}

		// Token: 0x06032D7E RID: 208254 RVA: 0x006DD75F File Offset: 0x006DB95F
		public void UnPackTo(IMonsterStandByConfigT _o)
		{
			_o.Tag = this.Tag;
			_o.Duration = this.Duration;
			_o.RepeatTimes = this.RepeatTimes;
			_o.EmotionId = this.EmotionId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06032D7F RID: 208255 RVA: 0x006DD7A0 File Offset: 0x006DB9A0
		public static Offset<IMonsterStandByConfig> Pack(FlatBufferBuilder builder, IMonsterStandByConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterStandByConfig>);
			}
			StringOffset tagOffset = (_o.Tag == null) ? default(StringOffset) : builder.CreateString(_o.Tag);
			return IMonsterStandByConfig.CreateIMonsterStandByConfig(builder, tagOffset, _o.Duration, _o.RepeatTimes, _o.EmotionId, _o.NullMask);
		}

		// Token: 0x04012250 RID: 74320
		private Table __p;
	}
}
