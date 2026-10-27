using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072BF RID: 29375
	public struct ITalkItemAutoPlayConfig : IFlatbufferObject
	{
		// Token: 0x1700DA22 RID: 55842
		// (get) Token: 0x060342E4 RID: 213732 RVA: 0x007047E7 File Offset: 0x007029E7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060342E5 RID: 213733 RVA: 0x007047F4 File Offset: 0x007029F4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060342E6 RID: 213734 RVA: 0x007047FC File Offset: 0x007029FC
		public static ITalkItemAutoPlayConfig GetRootAsITalkItemAutoPlayConfig(ByteBuffer _bb)
		{
			return ITalkItemAutoPlayConfig.GetRootAsITalkItemAutoPlayConfig(_bb, default(ITalkItemAutoPlayConfig));
		}

		// Token: 0x060342E7 RID: 213735 RVA: 0x00704818 File Offset: 0x00702A18
		public static ITalkItemAutoPlayConfig GetRootAsITalkItemAutoPlayConfig(ByteBuffer _bb, ITalkItemAutoPlayConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060342E8 RID: 213736 RVA: 0x00704835 File Offset: 0x00702A35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060342E9 RID: 213737 RVA: 0x00704844 File Offset: 0x00702A44
		public ITalkItemAutoPlayConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DA23 RID: 55843
		// (get) Token: 0x060342EA RID: 213738 RVA: 0x00704854 File Offset: 0x00702A54
		public ITalkItemDisableAutoSelectOptionGroup? DisableAutoSelectOptionGroup
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new ITalkItemDisableAutoSelectOptionGroup?(default(ITalkItemDisableAutoSelectOptionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060342EB RID: 213739 RVA: 0x007048B1 File Offset: 0x00702AB1
		public static Offset<ITalkItemAutoPlayConfig> CreateITalkItemAutoPlayConfig(FlatBufferBuilder builder, Offset<ITalkItemDisableAutoSelectOptionGroup> DisableAutoSelectOptionGroupOffset = default(Offset<ITalkItemDisableAutoSelectOptionGroup>))
		{
			builder.StartTable(1);
			ITalkItemAutoPlayConfig.AddDisableAutoSelectOptionGroup(builder, DisableAutoSelectOptionGroupOffset);
			return ITalkItemAutoPlayConfig.EndITalkItemAutoPlayConfig(builder);
		}

		// Token: 0x060342EC RID: 213740 RVA: 0x007048C7 File Offset: 0x00702AC7
		public static void StartITalkItemAutoPlayConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060342ED RID: 213741 RVA: 0x007048D0 File Offset: 0x00702AD0
		public static void AddDisableAutoSelectOptionGroup(FlatBufferBuilder builder, Offset<ITalkItemDisableAutoSelectOptionGroup> disableAutoSelectOptionGroupOffset)
		{
			builder.AddOffset(0, disableAutoSelectOptionGroupOffset.Value, 0);
		}

		// Token: 0x060342EE RID: 213742 RVA: 0x007048E0 File Offset: 0x00702AE0
		public static Offset<ITalkItemAutoPlayConfig> EndITalkItemAutoPlayConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITalkItemAutoPlayConfig>(builder.EndTable());
		}

		// Token: 0x060342EF RID: 213743 RVA: 0x007048F0 File Offset: 0x00702AF0
		public ITalkItemAutoPlayConfigT UnPack()
		{
			ITalkItemAutoPlayConfigT talkItemAutoPlayConfigT = new ITalkItemAutoPlayConfigT();
			this.UnPackTo(talkItemAutoPlayConfigT);
			return talkItemAutoPlayConfigT;
		}

		// Token: 0x060342F0 RID: 213744 RVA: 0x0070490C File Offset: 0x00702B0C
		public void UnPackTo(ITalkItemAutoPlayConfigT _o)
		{
			_o.DisableAutoSelectOptionGroup = ((this.DisableAutoSelectOptionGroup != null) ? this.DisableAutoSelectOptionGroup.Value.UnPack() : null);
		}

		// Token: 0x060342F1 RID: 213745 RVA: 0x00704948 File Offset: 0x00702B48
		public static Offset<ITalkItemAutoPlayConfig> Pack(FlatBufferBuilder builder, ITalkItemAutoPlayConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkItemAutoPlayConfig>);
			}
			Offset<ITalkItemDisableAutoSelectOptionGroup> disableAutoSelectOptionGroupOffset = (_o.DisableAutoSelectOptionGroup == null) ? default(Offset<ITalkItemDisableAutoSelectOptionGroup>) : ITalkItemDisableAutoSelectOptionGroup.Pack(builder, _o.DisableAutoSelectOptionGroup);
			return ITalkItemAutoPlayConfig.CreateITalkItemAutoPlayConfig(builder, disableAutoSelectOptionGroupOffset);
		}

		// Token: 0x04011E02 RID: 73218
		private Table __p;
	}
}
