using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200589A RID: 22682
	public struct IScanTraceEffect : IFlatbufferObject
	{
		// Token: 0x1700A9C4 RID: 43460
		// (get) Token: 0x060263E4 RID: 156644 RVA: 0x0054570C File Offset: 0x0054390C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060263E5 RID: 156645 RVA: 0x00545719 File Offset: 0x00543919
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060263E6 RID: 156646 RVA: 0x00545720 File Offset: 0x00543920
		public static IScanTraceEffect GetRootAsIScanTraceEffect(ByteBuffer _bb)
		{
			return IScanTraceEffect.GetRootAsIScanTraceEffect(_bb, default(IScanTraceEffect));
		}

		// Token: 0x060263E7 RID: 156647 RVA: 0x0054573C File Offset: 0x0054393C
		public static IScanTraceEffect GetRootAsIScanTraceEffect(ByteBuffer _bb, IScanTraceEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060263E8 RID: 156648 RVA: 0x00545759 File Offset: 0x00543959
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060263E9 RID: 156649 RVA: 0x00545768 File Offset: 0x00543968
		public IScanTraceEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A9C5 RID: 43461
		// (get) Token: 0x060263EA RID: 156650 RVA: 0x00545778 File Offset: 0x00543978
		public string Effect
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

		// Token: 0x060263EB RID: 156651 RVA: 0x005457AF File Offset: 0x005439AF
		public Span<byte> GetEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060263EC RID: 156652 RVA: 0x005457BE File Offset: 0x005439BE
		public byte[] GetEffectArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700A9C6 RID: 43462
		// (get) Token: 0x060263ED RID: 156653 RVA: 0x005457CC File Offset: 0x005439CC
		public int Target
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060263EE RID: 156654 RVA: 0x00545808 File Offset: 0x00543A08
		public static Offset<IScanTraceEffect> CreateIScanTraceEffect(FlatBufferBuilder builder, StringOffset EffectOffset = default(StringOffset), int Target = 0)
		{
			builder.StartTable(2);
			IScanTraceEffect.AddTarget(builder, Target);
			IScanTraceEffect.AddEffect(builder, EffectOffset);
			return IScanTraceEffect.EndIScanTraceEffect(builder);
		}

		// Token: 0x060263EF RID: 156655 RVA: 0x00545825 File Offset: 0x00543A25
		public static void StartIScanTraceEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060263F0 RID: 156656 RVA: 0x0054582E File Offset: 0x00543A2E
		public static void AddEffect(FlatBufferBuilder builder, StringOffset effectOffset)
		{
			builder.AddOffset(0, effectOffset.Value, 0);
		}

		// Token: 0x060263F1 RID: 156657 RVA: 0x0054583E File Offset: 0x00543A3E
		public static void AddTarget(FlatBufferBuilder builder, int target)
		{
			builder.AddInt(1, target, 0);
		}

		// Token: 0x060263F2 RID: 156658 RVA: 0x00545849 File Offset: 0x00543A49
		public static Offset<IScanTraceEffect> EndIScanTraceEffect(FlatBufferBuilder builder)
		{
			return new Offset<IScanTraceEffect>(builder.EndTable());
		}

		// Token: 0x060263F3 RID: 156659 RVA: 0x00545858 File Offset: 0x00543A58
		public IScanTraceEffectT UnPack()
		{
			IScanTraceEffectT scanTraceEffectT = new IScanTraceEffectT();
			this.UnPackTo(scanTraceEffectT);
			return scanTraceEffectT;
		}

		// Token: 0x060263F4 RID: 156660 RVA: 0x00545873 File Offset: 0x00543A73
		public void UnPackTo(IScanTraceEffectT _o)
		{
			_o.Effect = this.Effect;
			_o.Target = this.Target;
		}

		// Token: 0x060263F5 RID: 156661 RVA: 0x00545890 File Offset: 0x00543A90
		public static Offset<IScanTraceEffect> Pack(FlatBufferBuilder builder, IScanTraceEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IScanTraceEffect>);
			}
			StringOffset effectOffset = (_o.Effect == null) ? default(StringOffset) : builder.CreateString(_o.Effect);
			return IScanTraceEffect.CreateIScanTraceEffect(builder, effectOffset, _o.Target);
		}

		// Token: 0x0400EDFA RID: 60922
		private Table __p;
	}
}
