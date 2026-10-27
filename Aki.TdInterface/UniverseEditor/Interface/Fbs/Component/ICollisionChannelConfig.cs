using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FB8 RID: 20408
	public struct ICollisionChannelConfig : IFlatbufferObject
	{
		// Token: 0x170093D1 RID: 37841
		// (get) Token: 0x060207C9 RID: 133065 RVA: 0x00484F94 File Offset: 0x00483194
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060207CA RID: 133066 RVA: 0x00484FA1 File Offset: 0x004831A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060207CB RID: 133067 RVA: 0x00484FA8 File Offset: 0x004831A8
		public static ICollisionChannelConfig GetRootAsICollisionChannelConfig(ByteBuffer _bb)
		{
			return ICollisionChannelConfig.GetRootAsICollisionChannelConfig(_bb, default(ICollisionChannelConfig));
		}

		// Token: 0x060207CC RID: 133068 RVA: 0x00484FC4 File Offset: 0x004831C4
		public static ICollisionChannelConfig GetRootAsICollisionChannelConfig(ByteBuffer _bb, ICollisionChannelConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060207CD RID: 133069 RVA: 0x00484FE1 File Offset: 0x004831E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060207CE RID: 133070 RVA: 0x00484FF0 File Offset: 0x004831F0
		public ICollisionChannelConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170093D2 RID: 37842
		// (get) Token: 0x060207CF RID: 133071 RVA: 0x00485000 File Offset: 0x00483200
		public IOverrideCollisionChannel? OverrideCollisionChannel
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IOverrideCollisionChannel?(default(IOverrideCollisionChannel).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060207D0 RID: 133072 RVA: 0x0048505D File Offset: 0x0048325D
		public static Offset<ICollisionChannelConfig> CreateICollisionChannelConfig(FlatBufferBuilder builder, Offset<IOverrideCollisionChannel> OverrideCollisionChannelOffset = default(Offset<IOverrideCollisionChannel>))
		{
			builder.StartTable(1);
			ICollisionChannelConfig.AddOverrideCollisionChannel(builder, OverrideCollisionChannelOffset);
			return ICollisionChannelConfig.EndICollisionChannelConfig(builder);
		}

		// Token: 0x060207D1 RID: 133073 RVA: 0x00485073 File Offset: 0x00483273
		public static void StartICollisionChannelConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060207D2 RID: 133074 RVA: 0x0048507C File Offset: 0x0048327C
		public static void AddOverrideCollisionChannel(FlatBufferBuilder builder, Offset<IOverrideCollisionChannel> overrideCollisionChannelOffset)
		{
			builder.AddOffset(0, overrideCollisionChannelOffset.Value, 0);
		}

		// Token: 0x060207D3 RID: 133075 RVA: 0x0048508C File Offset: 0x0048328C
		public static Offset<ICollisionChannelConfig> EndICollisionChannelConfig(FlatBufferBuilder builder)
		{
			return new Offset<ICollisionChannelConfig>(builder.EndTable());
		}

		// Token: 0x060207D4 RID: 133076 RVA: 0x0048509C File Offset: 0x0048329C
		public ICollisionChannelConfigT UnPack()
		{
			ICollisionChannelConfigT collisionChannelConfigT = new ICollisionChannelConfigT();
			this.UnPackTo(collisionChannelConfigT);
			return collisionChannelConfigT;
		}

		// Token: 0x060207D5 RID: 133077 RVA: 0x004850B8 File Offset: 0x004832B8
		public void UnPackTo(ICollisionChannelConfigT _o)
		{
			_o.OverrideCollisionChannel = ((this.OverrideCollisionChannel != null) ? this.OverrideCollisionChannel.Value.UnPack() : null);
		}

		// Token: 0x060207D6 RID: 133078 RVA: 0x004850F4 File Offset: 0x004832F4
		public static Offset<ICollisionChannelConfig> Pack(FlatBufferBuilder builder, ICollisionChannelConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICollisionChannelConfig>);
			}
			Offset<IOverrideCollisionChannel> overrideCollisionChannelOffset = (_o.OverrideCollisionChannel == null) ? default(Offset<IOverrideCollisionChannel>) : IOverrideCollisionChannel.Pack(builder, _o.OverrideCollisionChannel);
			return ICollisionChannelConfig.CreateICollisionChannelConfig(builder, overrideCollisionChannelOffset);
		}

		// Token: 0x0400DE93 RID: 56979
		private Table __p;
	}
}
