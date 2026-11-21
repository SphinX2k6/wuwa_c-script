using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FAE RID: 24494
	public struct IStateChangeConfig : IFlatbufferObject
	{
		// Token: 0x1700B569 RID: 46441
		// (get) Token: 0x0602934A RID: 168778 RVA: 0x005A025B File Offset: 0x0059E45B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602934B RID: 168779 RVA: 0x005A0268 File Offset: 0x0059E468
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602934C RID: 168780 RVA: 0x005A0270 File Offset: 0x0059E470
		public static IStateChangeConfig GetRootAsIStateChangeConfig(ByteBuffer _bb)
		{
			return IStateChangeConfig.GetRootAsIStateChangeConfig(_bb, default(IStateChangeConfig));
		}

		// Token: 0x0602934D RID: 168781 RVA: 0x005A028C File Offset: 0x0059E48C
		public static IStateChangeConfig GetRootAsIStateChangeConfig(ByteBuffer _bb, IStateChangeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602934E RID: 168782 RVA: 0x005A02A9 File Offset: 0x0059E4A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602934F RID: 168783 RVA: 0x005A02B8 File Offset: 0x0059E4B8
		public IStateChangeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B56A RID: 46442
		// (get) Token: 0x06029350 RID: 168784 RVA: 0x005A02C8 File Offset: 0x0059E4C8
		public string RefreshState
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

		// Token: 0x06029351 RID: 168785 RVA: 0x005A02FF File Offset: 0x0059E4FF
		public Span<byte> GetRefreshStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06029352 RID: 168786 RVA: 0x005A030E File Offset: 0x0059E50E
		public byte[] GetRefreshStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700B56B RID: 46443
		// (get) Token: 0x06029353 RID: 168787 RVA: 0x005A031C File Offset: 0x0059E51C
		public string SubDestroyState
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029354 RID: 168788 RVA: 0x005A0353 File Offset: 0x0059E553
		public Span<byte> GetSubDestroyStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06029355 RID: 168789 RVA: 0x005A0362 File Offset: 0x0059E562
		public byte[] GetSubDestroyStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06029356 RID: 168790 RVA: 0x005A0370 File Offset: 0x0059E570
		public static Offset<IStateChangeConfig> CreateIStateChangeConfig(FlatBufferBuilder builder, StringOffset RefreshStateOffset = default(StringOffset), StringOffset SubDestroyStateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IStateChangeConfig.AddSubDestroyState(builder, SubDestroyStateOffset);
			IStateChangeConfig.AddRefreshState(builder, RefreshStateOffset);
			return IStateChangeConfig.EndIStateChangeConfig(builder);
		}

		// Token: 0x06029357 RID: 168791 RVA: 0x005A038D File Offset: 0x0059E58D
		public static void StartIStateChangeConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06029358 RID: 168792 RVA: 0x005A0396 File Offset: 0x0059E596
		public static void AddRefreshState(FlatBufferBuilder builder, StringOffset refreshStateOffset)
		{
			builder.AddOffset(0, refreshStateOffset.Value, 0);
		}

		// Token: 0x06029359 RID: 168793 RVA: 0x005A03A6 File Offset: 0x0059E5A6
		public static void AddSubDestroyState(FlatBufferBuilder builder, StringOffset subDestroyStateOffset)
		{
			builder.AddOffset(1, subDestroyStateOffset.Value, 0);
		}

		// Token: 0x0602935A RID: 168794 RVA: 0x005A03B6 File Offset: 0x0059E5B6
		public static Offset<IStateChangeConfig> EndIStateChangeConfig(FlatBufferBuilder builder)
		{
			return new Offset<IStateChangeConfig>(builder.EndTable());
		}

		// Token: 0x0602935B RID: 168795 RVA: 0x005A03C4 File Offset: 0x0059E5C4
		public IStateChangeConfigT UnPack()
		{
			IStateChangeConfigT stateChangeConfigT = new IStateChangeConfigT();
			this.UnPackTo(stateChangeConfigT);
			return stateChangeConfigT;
		}

		// Token: 0x0602935C RID: 168796 RVA: 0x005A03DF File Offset: 0x0059E5DF
		public void UnPackTo(IStateChangeConfigT _o)
		{
			_o.RefreshState = this.RefreshState;
			_o.SubDestroyState = this.SubDestroyState;
		}

		// Token: 0x0602935D RID: 168797 RVA: 0x005A03FC File Offset: 0x0059E5FC
		public static Offset<IStateChangeConfig> Pack(FlatBufferBuilder builder, IStateChangeConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStateChangeConfig>);
			}
			StringOffset refreshStateOffset = (_o.RefreshState == null) ? default(StringOffset) : builder.CreateString(_o.RefreshState);
			StringOffset subDestroyStateOffset = (_o.SubDestroyState == null) ? default(StringOffset) : builder.CreateString(_o.SubDestroyState);
			return IStateChangeConfig.CreateIStateChangeConfig(builder, refreshStateOffset, subDestroyStateOffset);
		}

		// Token: 0x0400FCA4 RID: 64676
		private Table __p;
	}
}
