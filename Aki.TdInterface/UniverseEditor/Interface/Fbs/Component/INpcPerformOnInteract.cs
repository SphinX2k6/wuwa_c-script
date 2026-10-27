using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005635 RID: 22069
	public struct INpcPerformOnInteract : IFlatbufferObject
	{
		// Token: 0x1700A378 RID: 41848
		// (get) Token: 0x06024ACB RID: 150219 RVA: 0x0050FF57 File Offset: 0x0050E157
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024ACC RID: 150220 RVA: 0x0050FF64 File Offset: 0x0050E164
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024ACD RID: 150221 RVA: 0x0050FF6C File Offset: 0x0050E16C
		public static INpcPerformOnInteract GetRootAsINpcPerformOnInteract(ByteBuffer _bb)
		{
			return INpcPerformOnInteract.GetRootAsINpcPerformOnInteract(_bb, default(INpcPerformOnInteract));
		}

		// Token: 0x06024ACE RID: 150222 RVA: 0x0050FF88 File Offset: 0x0050E188
		public static INpcPerformOnInteract GetRootAsINpcPerformOnInteract(ByteBuffer _bb, INpcPerformOnInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024ACF RID: 150223 RVA: 0x0050FFA5 File Offset: 0x0050E1A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024AD0 RID: 150224 RVA: 0x0050FFB4 File Offset: 0x0050E1B4
		public INpcPerformOnInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A379 RID: 41849
		// (get) Token: 0x06024AD1 RID: 150225 RVA: 0x0050FFC4 File Offset: 0x0050E1C4
		public string Montage
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

		// Token: 0x06024AD2 RID: 150226 RVA: 0x0050FFFB File Offset: 0x0050E1FB
		public Span<byte> GetMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06024AD3 RID: 150227 RVA: 0x0051000A File Offset: 0x0050E20A
		public byte[] GetMontageArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700A37A RID: 41850
		// (get) Token: 0x06024AD4 RID: 150228 RVA: 0x00510018 File Offset: 0x0050E218
		public bool NotInterruptMontageWhenFinishedInteract
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A37B RID: 41851
		// (get) Token: 0x06024AD5 RID: 150229 RVA: 0x00510058 File Offset: 0x0050E258
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024AD6 RID: 150230 RVA: 0x00510094 File Offset: 0x0050E294
		public static Offset<INpcPerformOnInteract> CreateINpcPerformOnInteract(FlatBufferBuilder builder, StringOffset MontageOffset = default(StringOffset), bool NotInterruptMontageWhenFinishedInteract = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			INpcPerformOnInteract.AddMontage(builder, MontageOffset);
			INpcPerformOnInteract.AddNullMask(builder, NullMask);
			INpcPerformOnInteract.AddNotInterruptMontageWhenFinishedInteract(builder, NotInterruptMontageWhenFinishedInteract);
			return INpcPerformOnInteract.EndINpcPerformOnInteract(builder);
		}

		// Token: 0x06024AD7 RID: 150231 RVA: 0x005100B8 File Offset: 0x0050E2B8
		public static void StartINpcPerformOnInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06024AD8 RID: 150232 RVA: 0x005100C1 File Offset: 0x0050E2C1
		public static void AddMontage(FlatBufferBuilder builder, StringOffset montageOffset)
		{
			builder.AddOffset(0, montageOffset.Value, 0);
		}

		// Token: 0x06024AD9 RID: 150233 RVA: 0x005100D1 File Offset: 0x0050E2D1
		public static void AddNotInterruptMontageWhenFinishedInteract(FlatBufferBuilder builder, bool notInterruptMontageWhenFinishedInteract)
		{
			builder.AddBool(1, notInterruptMontageWhenFinishedInteract, false);
		}

		// Token: 0x06024ADA RID: 150234 RVA: 0x005100DC File Offset: 0x0050E2DC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06024ADB RID: 150235 RVA: 0x005100E7 File Offset: 0x0050E2E7
		public static Offset<INpcPerformOnInteract> EndINpcPerformOnInteract(FlatBufferBuilder builder)
		{
			return new Offset<INpcPerformOnInteract>(builder.EndTable());
		}

		// Token: 0x06024ADC RID: 150236 RVA: 0x005100F4 File Offset: 0x0050E2F4
		public INpcPerformOnInteractT UnPack()
		{
			INpcPerformOnInteractT npcPerformOnInteractT = new INpcPerformOnInteractT();
			this.UnPackTo(npcPerformOnInteractT);
			return npcPerformOnInteractT;
		}

		// Token: 0x06024ADD RID: 150237 RVA: 0x0051010F File Offset: 0x0050E30F
		public void UnPackTo(INpcPerformOnInteractT _o)
		{
			_o.Montage = this.Montage;
			_o.NotInterruptMontageWhenFinishedInteract = this.NotInterruptMontageWhenFinishedInteract;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06024ADE RID: 150238 RVA: 0x00510138 File Offset: 0x0050E338
		public static Offset<INpcPerformOnInteract> Pack(FlatBufferBuilder builder, INpcPerformOnInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcPerformOnInteract>);
			}
			StringOffset montageOffset = (_o.Montage == null) ? default(StringOffset) : builder.CreateString(_o.Montage);
			return INpcPerformOnInteract.CreateINpcPerformOnInteract(builder, montageOffset, _o.NotInterruptMontageWhenFinishedInteract, _o.NullMask);
		}

		// Token: 0x0400E9D7 RID: 59863
		private Table __p;
	}
}
