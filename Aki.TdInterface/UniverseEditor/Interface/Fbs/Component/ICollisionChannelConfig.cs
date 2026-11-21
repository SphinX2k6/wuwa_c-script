using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005514 RID: 21780
	public struct ICollisionChannelConfig : IFlatbufferObject
	{
		// Token: 0x17009BA9 RID: 39849
		// (get) Token: 0x060226BD RID: 140989 RVA: 0x004BE478 File Offset: 0x004BC678
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060226BE RID: 140990 RVA: 0x004BE485 File Offset: 0x004BC685
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060226BF RID: 140991 RVA: 0x004BE48C File Offset: 0x004BC68C
		public static ICollisionChannelConfig GetRootAsICollisionChannelConfig(ByteBuffer _bb)
		{
			return ICollisionChannelConfig.GetRootAsICollisionChannelConfig(_bb, default(ICollisionChannelConfig));
		}

		// Token: 0x060226C0 RID: 140992 RVA: 0x004BE4A8 File Offset: 0x004BC6A8
		public static ICollisionChannelConfig GetRootAsICollisionChannelConfig(ByteBuffer _bb, ICollisionChannelConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060226C1 RID: 140993 RVA: 0x004BE4C5 File Offset: 0x004BC6C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060226C2 RID: 140994 RVA: 0x004BE4D4 File Offset: 0x004BC6D4
		public ICollisionChannelConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009BAA RID: 39850
		// (get) Token: 0x060226C3 RID: 140995 RVA: 0x004BE4E4 File Offset: 0x004BC6E4
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

		// Token: 0x060226C4 RID: 140996 RVA: 0x004BE541 File Offset: 0x004BC741
		public static Offset<ICollisionChannelConfig> CreateICollisionChannelConfig(FlatBufferBuilder builder, Offset<IOverrideCollisionChannel> OverrideCollisionChannelOffset = default(Offset<IOverrideCollisionChannel>))
		{
			builder.StartTable(1);
			ICollisionChannelConfig.AddOverrideCollisionChannel(builder, OverrideCollisionChannelOffset);
			return ICollisionChannelConfig.EndICollisionChannelConfig(builder);
		}

		// Token: 0x060226C5 RID: 140997 RVA: 0x004BE557 File Offset: 0x004BC757
		public static void StartICollisionChannelConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060226C6 RID: 140998 RVA: 0x004BE560 File Offset: 0x004BC760
		public static void AddOverrideCollisionChannel(FlatBufferBuilder builder, Offset<IOverrideCollisionChannel> overrideCollisionChannelOffset)
		{
			builder.AddOffset(0, overrideCollisionChannelOffset.Value, 0);
		}

		// Token: 0x060226C7 RID: 140999 RVA: 0x004BE570 File Offset: 0x004BC770
		public static Offset<ICollisionChannelConfig> EndICollisionChannelConfig(FlatBufferBuilder builder)
		{
			return new Offset<ICollisionChannelConfig>(builder.EndTable());
		}

		// Token: 0x060226C8 RID: 141000 RVA: 0x004BE580 File Offset: 0x004BC780
		public ICollisionChannelConfigT UnPack()
		{
			ICollisionChannelConfigT collisionChannelConfigT = new ICollisionChannelConfigT();
			this.UnPackTo(collisionChannelConfigT);
			return collisionChannelConfigT;
		}

		// Token: 0x060226C9 RID: 141001 RVA: 0x004BE59C File Offset: 0x004BC79C
		public void UnPackTo(ICollisionChannelConfigT _o)
		{
			_o.OverrideCollisionChannel = ((this.OverrideCollisionChannel != null) ? this.OverrideCollisionChannel.Value.UnPack() : null);
		}

		// Token: 0x060226CA RID: 141002 RVA: 0x004BE5D8 File Offset: 0x004BC7D8
		public static Offset<ICollisionChannelConfig> Pack(FlatBufferBuilder builder, ICollisionChannelConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICollisionChannelConfig>);
			}
			Offset<IOverrideCollisionChannel> overrideCollisionChannelOffset = (_o.OverrideCollisionChannel == null) ? default(Offset<IOverrideCollisionChannel>) : IOverrideCollisionChannel.Pack(builder, _o.OverrideCollisionChannel);
			return ICollisionChannelConfig.CreateICollisionChannelConfig(builder, overrideCollisionChannelOffset);
		}

		// Token: 0x0400EA81 RID: 60033
		private Table __p;
	}
}
