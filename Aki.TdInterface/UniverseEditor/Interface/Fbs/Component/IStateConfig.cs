using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FB1 RID: 24497
	public struct IStateConfig : IFlatbufferObject
	{
		// Token: 0x1700B56E RID: 46446
		// (get) Token: 0x06029364 RID: 168804 RVA: 0x005A04C0 File Offset: 0x0059E6C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029365 RID: 168805 RVA: 0x005A04CD File Offset: 0x0059E6CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029366 RID: 168806 RVA: 0x005A04D4 File Offset: 0x0059E6D4
		public static IStateConfig GetRootAsIStateConfig(ByteBuffer _bb)
		{
			return IStateConfig.GetRootAsIStateConfig(_bb, default(IStateConfig));
		}

		// Token: 0x06029367 RID: 168807 RVA: 0x005A04F0 File Offset: 0x0059E6F0
		public static IStateConfig GetRootAsIStateConfig(ByteBuffer _bb, IStateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029368 RID: 168808 RVA: 0x005A050D File Offset: 0x0059E70D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029369 RID: 168809 RVA: 0x005A051C File Offset: 0x0059E71C
		public IStateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B56F RID: 46447
		// (get) Token: 0x0602936A RID: 168810 RVA: 0x005A052C File Offset: 0x0059E72C
		public string State
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

		// Token: 0x0602936B RID: 168811 RVA: 0x005A0563 File Offset: 0x0059E763
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602936C RID: 168812 RVA: 0x005A0572 File Offset: 0x0059E772
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700B570 RID: 46448
		// (get) Token: 0x0602936D RID: 168813 RVA: 0x005A0580 File Offset: 0x0059E780
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

		// Token: 0x0602936E RID: 168814 RVA: 0x005A05C0 File Offset: 0x0059E7C0
		public static Offset<IStateConfig> CreateIStateConfig(FlatBufferBuilder builder, StringOffset StateOffset = default(StringOffset), float Duration = 0f)
		{
			builder.StartTable(2);
			IStateConfig.AddDuration(builder, Duration);
			IStateConfig.AddState(builder, StateOffset);
			return IStateConfig.EndIStateConfig(builder);
		}

		// Token: 0x0602936F RID: 168815 RVA: 0x005A05DD File Offset: 0x0059E7DD
		public static void StartIStateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06029370 RID: 168816 RVA: 0x005A05E6 File Offset: 0x0059E7E6
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(0, stateOffset.Value, 0);
		}

		// Token: 0x06029371 RID: 168817 RVA: 0x005A05F6 File Offset: 0x0059E7F6
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(1, duration, 0.0);
		}

		// Token: 0x06029372 RID: 168818 RVA: 0x005A0609 File Offset: 0x0059E809
		public static Offset<IStateConfig> EndIStateConfig(FlatBufferBuilder builder)
		{
			return new Offset<IStateConfig>(builder.EndTable());
		}

		// Token: 0x06029373 RID: 168819 RVA: 0x005A0618 File Offset: 0x0059E818
		public IStateConfigT UnPack()
		{
			IStateConfigT stateConfigT = new IStateConfigT();
			this.UnPackTo(stateConfigT);
			return stateConfigT;
		}

		// Token: 0x06029374 RID: 168820 RVA: 0x005A0633 File Offset: 0x0059E833
		public void UnPackTo(IStateConfigT _o)
		{
			_o.State = this.State;
			_o.Duration = this.Duration;
		}

		// Token: 0x06029375 RID: 168821 RVA: 0x005A0650 File Offset: 0x0059E850
		public static Offset<IStateConfig> Pack(FlatBufferBuilder builder, IStateConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStateConfig>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IStateConfig.CreateIStateConfig(builder, stateOffset, _o.Duration);
		}

		// Token: 0x0400FCA7 RID: 64679
		private Table __p;
	}
}
