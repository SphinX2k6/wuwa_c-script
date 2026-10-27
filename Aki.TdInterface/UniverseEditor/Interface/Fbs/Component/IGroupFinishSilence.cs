using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005356 RID: 21334
	public struct IGroupFinishSilence : IFlatbufferObject
	{
		// Token: 0x17009CBC RID: 40124
		// (get) Token: 0x06022E5C RID: 142940 RVA: 0x004D5718 File Offset: 0x004D3918
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022E5D RID: 142941 RVA: 0x004D5725 File Offset: 0x004D3925
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022E5E RID: 142942 RVA: 0x004D572C File Offset: 0x004D392C
		public static IGroupFinishSilence GetRootAsIGroupFinishSilence(ByteBuffer _bb)
		{
			return IGroupFinishSilence.GetRootAsIGroupFinishSilence(_bb, default(IGroupFinishSilence));
		}

		// Token: 0x06022E5F RID: 142943 RVA: 0x004D5748 File Offset: 0x004D3948
		public static IGroupFinishSilence GetRootAsIGroupFinishSilence(ByteBuffer _bb, IGroupFinishSilence obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022E60 RID: 142944 RVA: 0x004D5765 File Offset: 0x004D3965
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022E61 RID: 142945 RVA: 0x004D5774 File Offset: 0x004D3974
		public IGroupFinishSilence __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009CBD RID: 40125
		// (get) Token: 0x06022E62 RID: 142946 RVA: 0x004D5784 File Offset: 0x004D3984
		public EGroupFinishConfig Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGroupFinishConfig.Silence;
				}
				return (EGroupFinishConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009CBE RID: 40126
		// (get) Token: 0x06022E63 RID: 142947 RVA: 0x004D57C0 File Offset: 0x004D39C0
		public IEntityState? SwitchSpecifiedStatus
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IEntityState?(default(IEntityState).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06022E64 RID: 142948 RVA: 0x004D581D File Offset: 0x004D3A1D
		public static Offset<IGroupFinishSilence> CreateIGroupFinishSilence(FlatBufferBuilder builder, EGroupFinishConfig Type = EGroupFinishConfig.Silence, Offset<IEntityState> SwitchSpecifiedStatusOffset = default(Offset<IEntityState>))
		{
			builder.StartTable(2);
			IGroupFinishSilence.AddSwitchSpecifiedStatus(builder, SwitchSpecifiedStatusOffset);
			IGroupFinishSilence.AddType(builder, Type);
			return IGroupFinishSilence.EndIGroupFinishSilence(builder);
		}

		// Token: 0x06022E65 RID: 142949 RVA: 0x004D583A File Offset: 0x004D3A3A
		public static void StartIGroupFinishSilence(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06022E66 RID: 142950 RVA: 0x004D5843 File Offset: 0x004D3A43
		public static void AddType(FlatBufferBuilder builder, EGroupFinishConfig type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022E67 RID: 142951 RVA: 0x004D584E File Offset: 0x004D3A4E
		public static void AddSwitchSpecifiedStatus(FlatBufferBuilder builder, Offset<IEntityState> switchSpecifiedStatusOffset)
		{
			builder.AddOffset(1, switchSpecifiedStatusOffset.Value, 0);
		}

		// Token: 0x06022E68 RID: 142952 RVA: 0x004D585E File Offset: 0x004D3A5E
		public static Offset<IGroupFinishSilence> EndIGroupFinishSilence(FlatBufferBuilder builder)
		{
			return new Offset<IGroupFinishSilence>(builder.EndTable());
		}

		// Token: 0x06022E69 RID: 142953 RVA: 0x004D586C File Offset: 0x004D3A6C
		public IGroupFinishSilenceT UnPack()
		{
			IGroupFinishSilenceT groupFinishSilenceT = new IGroupFinishSilenceT();
			this.UnPackTo(groupFinishSilenceT);
			return groupFinishSilenceT;
		}

		// Token: 0x06022E6A RID: 142954 RVA: 0x004D5888 File Offset: 0x004D3A88
		public void UnPackTo(IGroupFinishSilenceT _o)
		{
			_o.Type = this.Type;
			_o.SwitchSpecifiedStatus = ((this.SwitchSpecifiedStatus != null) ? this.SwitchSpecifiedStatus.Value.UnPack() : null);
		}

		// Token: 0x06022E6B RID: 142955 RVA: 0x004D58D0 File Offset: 0x004D3AD0
		public static Offset<IGroupFinishSilence> Pack(FlatBufferBuilder builder, IGroupFinishSilenceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGroupFinishSilence>);
			}
			Offset<IEntityState> switchSpecifiedStatusOffset = (_o.SwitchSpecifiedStatus == null) ? default(Offset<IEntityState>) : IEntityState.Pack(builder, _o.SwitchSpecifiedStatus);
			return IGroupFinishSilence.CreateIGroupFinishSilence(builder, _o.Type, switchSpecifiedStatusOffset);
		}

		// Token: 0x0400E52D RID: 58669
		private Table __p;
	}
}
