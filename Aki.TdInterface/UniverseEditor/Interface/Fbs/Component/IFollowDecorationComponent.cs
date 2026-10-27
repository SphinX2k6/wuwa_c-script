using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200528E RID: 21134
	public struct IFollowDecorationComponent : IFlatbufferObject
	{
		// Token: 0x17009AF6 RID: 39670
		// (get) Token: 0x06022706 RID: 141062 RVA: 0x004C65F8 File Offset: 0x004C47F8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022707 RID: 141063 RVA: 0x004C6605 File Offset: 0x004C4805
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022708 RID: 141064 RVA: 0x004C660C File Offset: 0x004C480C
		public static IFollowDecorationComponent GetRootAsIFollowDecorationComponent(ByteBuffer _bb)
		{
			return IFollowDecorationComponent.GetRootAsIFollowDecorationComponent(_bb, default(IFollowDecorationComponent));
		}

		// Token: 0x06022709 RID: 141065 RVA: 0x004C6628 File Offset: 0x004C4828
		public static IFollowDecorationComponent GetRootAsIFollowDecorationComponent(ByteBuffer _bb, IFollowDecorationComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602270A RID: 141066 RVA: 0x004C6645 File Offset: 0x004C4845
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602270B RID: 141067 RVA: 0x004C6654 File Offset: 0x004C4854
		public IFollowDecorationComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009AF7 RID: 39671
		// (get) Token: 0x0602270C RID: 141068 RVA: 0x004C6664 File Offset: 0x004C4864
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009AF8 RID: 39672
		// (get) Token: 0x0602270D RID: 141069 RVA: 0x004C66A4 File Offset: 0x004C48A4
		public IFollowDecorationChairConfig? DecorationConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IFollowDecorationChairConfig?(default(IFollowDecorationChairConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009AF9 RID: 39673
		// (get) Token: 0x0602270E RID: 141070 RVA: 0x004C6704 File Offset: 0x004C4904
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

		// Token: 0x0602270F RID: 141071 RVA: 0x004C6740 File Offset: 0x004C4940
		public static Offset<IFollowDecorationComponent> CreateIFollowDecorationComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IFollowDecorationChairConfig> DecorationConfigOffset = default(Offset<IFollowDecorationChairConfig>), byte NullMask = 0)
		{
			builder.StartTable(3);
			IFollowDecorationComponent.AddDecorationConfig(builder, DecorationConfigOffset);
			IFollowDecorationComponent.AddNullMask(builder, NullMask);
			IFollowDecorationComponent.AddDisabled(builder, Disabled);
			return IFollowDecorationComponent.EndIFollowDecorationComponent(builder);
		}

		// Token: 0x06022710 RID: 141072 RVA: 0x004C6764 File Offset: 0x004C4964
		public static void StartIFollowDecorationComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06022711 RID: 141073 RVA: 0x004C676D File Offset: 0x004C496D
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06022712 RID: 141074 RVA: 0x004C6778 File Offset: 0x004C4978
		public static void AddDecorationConfig(FlatBufferBuilder builder, Offset<IFollowDecorationChairConfig> decorationConfigOffset)
		{
			builder.AddOffset(1, decorationConfigOffset.Value, 0);
		}

		// Token: 0x06022713 RID: 141075 RVA: 0x004C6788 File Offset: 0x004C4988
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06022714 RID: 141076 RVA: 0x004C6793 File Offset: 0x004C4993
		public static Offset<IFollowDecorationComponent> EndIFollowDecorationComponent(FlatBufferBuilder builder)
		{
			return new Offset<IFollowDecorationComponent>(builder.EndTable());
		}

		// Token: 0x06022715 RID: 141077 RVA: 0x004C67A0 File Offset: 0x004C49A0
		public IFollowDecorationComponentT UnPack()
		{
			IFollowDecorationComponentT followDecorationComponentT = new IFollowDecorationComponentT();
			this.UnPackTo(followDecorationComponentT);
			return followDecorationComponentT;
		}

		// Token: 0x06022716 RID: 141078 RVA: 0x004C67BC File Offset: 0x004C49BC
		public void UnPackTo(IFollowDecorationComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.DecorationConfig = ((this.DecorationConfig != null) ? this.DecorationConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06022717 RID: 141079 RVA: 0x004C6810 File Offset: 0x004C4A10
		public static Offset<IFollowDecorationComponent> Pack(FlatBufferBuilder builder, IFollowDecorationComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFollowDecorationComponent>);
			}
			Offset<IFollowDecorationChairConfig> decorationConfigOffset = (_o.DecorationConfig == null) ? default(Offset<IFollowDecorationChairConfig>) : IFollowDecorationChairConfig.Pack(builder, _o.DecorationConfig);
			return IFollowDecorationComponent.CreateIFollowDecorationComponent(builder, _o.Disabled, decorationConfigOffset, _o.NullMask);
		}

		// Token: 0x0400E3FA RID: 58362
		private Table __p;
	}
}
