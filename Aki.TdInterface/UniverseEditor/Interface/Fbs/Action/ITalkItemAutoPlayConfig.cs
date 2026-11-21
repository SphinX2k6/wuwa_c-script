using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A94 RID: 31380
	public struct ITalkItemAutoPlayConfig : IFlatbufferObject
	{
		// Token: 0x1700E61B RID: 58907
		// (get) Token: 0x060375E8 RID: 226792 RVA: 0x00765B83 File Offset: 0x00763D83
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060375E9 RID: 226793 RVA: 0x00765B90 File Offset: 0x00763D90
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060375EA RID: 226794 RVA: 0x00765B98 File Offset: 0x00763D98
		public static ITalkItemAutoPlayConfig GetRootAsITalkItemAutoPlayConfig(ByteBuffer _bb)
		{
			return ITalkItemAutoPlayConfig.GetRootAsITalkItemAutoPlayConfig(_bb, default(ITalkItemAutoPlayConfig));
		}

		// Token: 0x060375EB RID: 226795 RVA: 0x00765BB4 File Offset: 0x00763DB4
		public static ITalkItemAutoPlayConfig GetRootAsITalkItemAutoPlayConfig(ByteBuffer _bb, ITalkItemAutoPlayConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060375EC RID: 226796 RVA: 0x00765BD1 File Offset: 0x00763DD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060375ED RID: 226797 RVA: 0x00765BE0 File Offset: 0x00763DE0
		public ITalkItemAutoPlayConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E61C RID: 58908
		// (get) Token: 0x060375EE RID: 226798 RVA: 0x00765BF0 File Offset: 0x00763DF0
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

		// Token: 0x060375EF RID: 226799 RVA: 0x00765C4D File Offset: 0x00763E4D
		public static Offset<ITalkItemAutoPlayConfig> CreateITalkItemAutoPlayConfig(FlatBufferBuilder builder, Offset<ITalkItemDisableAutoSelectOptionGroup> DisableAutoSelectOptionGroupOffset = default(Offset<ITalkItemDisableAutoSelectOptionGroup>))
		{
			builder.StartTable(1);
			ITalkItemAutoPlayConfig.AddDisableAutoSelectOptionGroup(builder, DisableAutoSelectOptionGroupOffset);
			return ITalkItemAutoPlayConfig.EndITalkItemAutoPlayConfig(builder);
		}

		// Token: 0x060375F0 RID: 226800 RVA: 0x00765C63 File Offset: 0x00763E63
		public static void StartITalkItemAutoPlayConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060375F1 RID: 226801 RVA: 0x00765C6C File Offset: 0x00763E6C
		public static void AddDisableAutoSelectOptionGroup(FlatBufferBuilder builder, Offset<ITalkItemDisableAutoSelectOptionGroup> disableAutoSelectOptionGroupOffset)
		{
			builder.AddOffset(0, disableAutoSelectOptionGroupOffset.Value, 0);
		}

		// Token: 0x060375F2 RID: 226802 RVA: 0x00765C7C File Offset: 0x00763E7C
		public static Offset<ITalkItemAutoPlayConfig> EndITalkItemAutoPlayConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITalkItemAutoPlayConfig>(builder.EndTable());
		}

		// Token: 0x060375F3 RID: 226803 RVA: 0x00765C8C File Offset: 0x00763E8C
		public ITalkItemAutoPlayConfigT UnPack()
		{
			ITalkItemAutoPlayConfigT talkItemAutoPlayConfigT = new ITalkItemAutoPlayConfigT();
			this.UnPackTo(talkItemAutoPlayConfigT);
			return talkItemAutoPlayConfigT;
		}

		// Token: 0x060375F4 RID: 226804 RVA: 0x00765CA8 File Offset: 0x00763EA8
		public void UnPackTo(ITalkItemAutoPlayConfigT _o)
		{
			_o.DisableAutoSelectOptionGroup = ((this.DisableAutoSelectOptionGroup != null) ? this.DisableAutoSelectOptionGroup.Value.UnPack() : null);
		}

		// Token: 0x060375F5 RID: 226805 RVA: 0x00765CE4 File Offset: 0x00763EE4
		public static Offset<ITalkItemAutoPlayConfig> Pack(FlatBufferBuilder builder, ITalkItemAutoPlayConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkItemAutoPlayConfig>);
			}
			Offset<ITalkItemDisableAutoSelectOptionGroup> disableAutoSelectOptionGroupOffset = (_o.DisableAutoSelectOptionGroup == null) ? default(Offset<ITalkItemDisableAutoSelectOptionGroup>) : ITalkItemDisableAutoSelectOptionGroup.Pack(builder, _o.DisableAutoSelectOptionGroup);
			return ITalkItemAutoPlayConfig.CreateITalkItemAutoPlayConfig(builder, disableAutoSelectOptionGroupOffset);
		}

		// Token: 0x04012E05 RID: 77317
		private Table __p;
	}
}
