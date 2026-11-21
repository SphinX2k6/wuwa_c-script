using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074A4 RID: 29860
	public struct IPlayMontage : IFlatbufferObject
	{
		// Token: 0x1700DB66 RID: 56166
		// (get) Token: 0x06034494 RID: 214164 RVA: 0x0070AAB1 File Offset: 0x00708CB1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034495 RID: 214165 RVA: 0x0070AABE File Offset: 0x00708CBE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034496 RID: 214166 RVA: 0x0070AAC8 File Offset: 0x00708CC8
		public static IPlayMontage GetRootAsIPlayMontage(ByteBuffer _bb)
		{
			return IPlayMontage.GetRootAsIPlayMontage(_bb, default(IPlayMontage));
		}

		// Token: 0x06034497 RID: 214167 RVA: 0x0070AAE4 File Offset: 0x00708CE4
		public static IPlayMontage GetRootAsIPlayMontage(ByteBuffer _bb, IPlayMontage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034498 RID: 214168 RVA: 0x0070AB01 File Offset: 0x00708D01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034499 RID: 214169 RVA: 0x0070AB10 File Offset: 0x00708D10
		public IPlayMontage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DB67 RID: 56167
		// (get) Token: 0x0603449A RID: 214170 RVA: 0x0070AB20 File Offset: 0x00708D20
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DB68 RID: 56168
		// (get) Token: 0x0603449B RID: 214171 RVA: 0x0070AB5C File Offset: 0x00708D5C
		public IActionMontage? ActionMontage
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IActionMontage?(default(IActionMontage).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700DB69 RID: 56169
		// (get) Token: 0x0603449C RID: 214172 RVA: 0x0070ABBC File Offset: 0x00708DBC
		public string ExpressionMontage
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603449D RID: 214173 RVA: 0x0070ABF3 File Offset: 0x00708DF3
		public Span<byte> GetExpressionMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0603449E RID: 214174 RVA: 0x0070AC02 File Offset: 0x00708E02
		public byte[] GetExpressionMontageArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700DB6A RID: 56170
		// (get) Token: 0x0603449F RID: 214175 RVA: 0x0070AC10 File Offset: 0x00708E10
		public string MouthSequence
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060344A0 RID: 214176 RVA: 0x0070AC48 File Offset: 0x00708E48
		public Span<byte> GetMouthSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060344A1 RID: 214177 RVA: 0x0070AC58 File Offset: 0x00708E58
		public byte[] GetMouthSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700DB6B RID: 56171
		// (get) Token: 0x060344A2 RID: 214178 RVA: 0x0070AC68 File Offset: 0x00708E68
		public int Duration
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DB6C RID: 56172
		// (get) Token: 0x060344A3 RID: 214179 RVA: 0x0070ACA8 File Offset: 0x00708EA8
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

		// Token: 0x060344A4 RID: 214180 RVA: 0x0070ACE5 File Offset: 0x00708EE5
		public static Offset<IPlayMontage> CreateIPlayMontage(FlatBufferBuilder builder, int EntityId = 0, Offset<IActionMontage> ActionMontageOffset = default(Offset<IActionMontage>), StringOffset ExpressionMontageOffset = default(StringOffset), StringOffset MouthSequenceOffset = default(StringOffset), int Duration = 0, byte NullMask = 0)
		{
			builder.StartTable(6);
			IPlayMontage.AddDuration(builder, Duration);
			IPlayMontage.AddMouthSequence(builder, MouthSequenceOffset);
			IPlayMontage.AddExpressionMontage(builder, ExpressionMontageOffset);
			IPlayMontage.AddActionMontage(builder, ActionMontageOffset);
			IPlayMontage.AddEntityId(builder, EntityId);
			IPlayMontage.AddNullMask(builder, NullMask);
			return IPlayMontage.EndIPlayMontage(builder);
		}

		// Token: 0x060344A5 RID: 214181 RVA: 0x0070AD21 File Offset: 0x00708F21
		public static void StartIPlayMontage(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060344A6 RID: 214182 RVA: 0x0070AD2A File Offset: 0x00708F2A
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x060344A7 RID: 214183 RVA: 0x0070AD35 File Offset: 0x00708F35
		public static void AddActionMontage(FlatBufferBuilder builder, Offset<IActionMontage> actionMontageOffset)
		{
			builder.AddOffset(1, actionMontageOffset.Value, 0);
		}

		// Token: 0x060344A8 RID: 214184 RVA: 0x0070AD45 File Offset: 0x00708F45
		public static void AddExpressionMontage(FlatBufferBuilder builder, StringOffset expressionMontageOffset)
		{
			builder.AddOffset(2, expressionMontageOffset.Value, 0);
		}

		// Token: 0x060344A9 RID: 214185 RVA: 0x0070AD55 File Offset: 0x00708F55
		public static void AddMouthSequence(FlatBufferBuilder builder, StringOffset mouthSequenceOffset)
		{
			builder.AddOffset(3, mouthSequenceOffset.Value, 0);
		}

		// Token: 0x060344AA RID: 214186 RVA: 0x0070AD65 File Offset: 0x00708F65
		public static void AddDuration(FlatBufferBuilder builder, int duration)
		{
			builder.AddInt(4, duration, 0);
		}

		// Token: 0x060344AB RID: 214187 RVA: 0x0070AD70 File Offset: 0x00708F70
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060344AC RID: 214188 RVA: 0x0070AD7B File Offset: 0x00708F7B
		public static Offset<IPlayMontage> EndIPlayMontage(FlatBufferBuilder builder)
		{
			return new Offset<IPlayMontage>(builder.EndTable());
		}

		// Token: 0x060344AD RID: 214189 RVA: 0x0070AD88 File Offset: 0x00708F88
		public IPlayMontageT UnPack()
		{
			IPlayMontageT playMontageT = new IPlayMontageT();
			this.UnPackTo(playMontageT);
			return playMontageT;
		}

		// Token: 0x060344AE RID: 214190 RVA: 0x0070ADA4 File Offset: 0x00708FA4
		public void UnPackTo(IPlayMontageT _o)
		{
			_o.EntityId = this.EntityId;
			_o.ActionMontage = ((this.ActionMontage != null) ? this.ActionMontage.Value.UnPack() : null);
			_o.ExpressionMontage = this.ExpressionMontage;
			_o.MouthSequence = this.MouthSequence;
			_o.Duration = this.Duration;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060344AF RID: 214191 RVA: 0x0070AE1C File Offset: 0x0070901C
		public static Offset<IPlayMontage> Pack(FlatBufferBuilder builder, IPlayMontageT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayMontage>);
			}
			Offset<IActionMontage> actionMontageOffset = (_o.ActionMontage == null) ? default(Offset<IActionMontage>) : IActionMontage.Pack(builder, _o.ActionMontage);
			StringOffset expressionMontageOffset = (_o.ExpressionMontage == null) ? default(StringOffset) : builder.CreateString(_o.ExpressionMontage);
			StringOffset mouthSequenceOffset = (_o.MouthSequence == null) ? default(StringOffset) : builder.CreateString(_o.MouthSequence);
			return IPlayMontage.CreateIPlayMontage(builder, _o.EntityId, actionMontageOffset, expressionMontageOffset, mouthSequenceOffset, _o.Duration, _o.NullMask);
		}

		// Token: 0x0401262C RID: 75308
		private Table __p;
	}
}
