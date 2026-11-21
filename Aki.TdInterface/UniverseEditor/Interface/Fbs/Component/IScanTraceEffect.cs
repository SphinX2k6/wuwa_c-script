using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EA7 RID: 24231
	public struct IScanTraceEffect : IFlatbufferObject
	{
		// Token: 0x1700B2F4 RID: 45812
		// (get) Token: 0x06028946 RID: 166214 RVA: 0x0058C258 File Offset: 0x0058A458
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028947 RID: 166215 RVA: 0x0058C265 File Offset: 0x0058A465
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028948 RID: 166216 RVA: 0x0058C26C File Offset: 0x0058A46C
		public static IScanTraceEffect GetRootAsIScanTraceEffect(ByteBuffer _bb)
		{
			return IScanTraceEffect.GetRootAsIScanTraceEffect(_bb, default(IScanTraceEffect));
		}

		// Token: 0x06028949 RID: 166217 RVA: 0x0058C288 File Offset: 0x0058A488
		public static IScanTraceEffect GetRootAsIScanTraceEffect(ByteBuffer _bb, IScanTraceEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602894A RID: 166218 RVA: 0x0058C2A5 File Offset: 0x0058A4A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602894B RID: 166219 RVA: 0x0058C2B4 File Offset: 0x0058A4B4
		public IScanTraceEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B2F5 RID: 45813
		// (get) Token: 0x0602894C RID: 166220 RVA: 0x0058C2C4 File Offset: 0x0058A4C4
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

		// Token: 0x0602894D RID: 166221 RVA: 0x0058C2FB File Offset: 0x0058A4FB
		public Span<byte> GetEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602894E RID: 166222 RVA: 0x0058C30A File Offset: 0x0058A50A
		public byte[] GetEffectArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700B2F6 RID: 45814
		// (get) Token: 0x0602894F RID: 166223 RVA: 0x0058C318 File Offset: 0x0058A518
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

		// Token: 0x06028950 RID: 166224 RVA: 0x0058C354 File Offset: 0x0058A554
		public static Offset<IScanTraceEffect> CreateIScanTraceEffect(FlatBufferBuilder builder, StringOffset EffectOffset = default(StringOffset), int Target = 0)
		{
			builder.StartTable(2);
			IScanTraceEffect.AddTarget(builder, Target);
			IScanTraceEffect.AddEffect(builder, EffectOffset);
			return IScanTraceEffect.EndIScanTraceEffect(builder);
		}

		// Token: 0x06028951 RID: 166225 RVA: 0x0058C371 File Offset: 0x0058A571
		public static void StartIScanTraceEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06028952 RID: 166226 RVA: 0x0058C37A File Offset: 0x0058A57A
		public static void AddEffect(FlatBufferBuilder builder, StringOffset effectOffset)
		{
			builder.AddOffset(0, effectOffset.Value, 0);
		}

		// Token: 0x06028953 RID: 166227 RVA: 0x0058C38A File Offset: 0x0058A58A
		public static void AddTarget(FlatBufferBuilder builder, int target)
		{
			builder.AddInt(1, target, 0);
		}

		// Token: 0x06028954 RID: 166228 RVA: 0x0058C395 File Offset: 0x0058A595
		public static Offset<IScanTraceEffect> EndIScanTraceEffect(FlatBufferBuilder builder)
		{
			return new Offset<IScanTraceEffect>(builder.EndTable());
		}

		// Token: 0x06028955 RID: 166229 RVA: 0x0058C3A4 File Offset: 0x0058A5A4
		public IScanTraceEffectT UnPack()
		{
			IScanTraceEffectT scanTraceEffectT = new IScanTraceEffectT();
			this.UnPackTo(scanTraceEffectT);
			return scanTraceEffectT;
		}

		// Token: 0x06028956 RID: 166230 RVA: 0x0058C3BF File Offset: 0x0058A5BF
		public void UnPackTo(IScanTraceEffectT _o)
		{
			_o.Effect = this.Effect;
			_o.Target = this.Target;
		}

		// Token: 0x06028957 RID: 166231 RVA: 0x0058C3DC File Offset: 0x0058A5DC
		public static Offset<IScanTraceEffect> Pack(FlatBufferBuilder builder, IScanTraceEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IScanTraceEffect>);
			}
			StringOffset effectOffset = (_o.Effect == null) ? default(StringOffset) : builder.CreateString(_o.Effect);
			return IScanTraceEffect.CreateIScanTraceEffect(builder, effectOffset, _o.Target);
		}

		// Token: 0x0400FAED RID: 64237
		private Table __p;
	}
}
