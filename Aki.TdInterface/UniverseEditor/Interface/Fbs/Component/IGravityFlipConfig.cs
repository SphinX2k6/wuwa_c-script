using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005324 RID: 21284
	public struct IGravityFlipConfig : IFlatbufferObject
	{
		// Token: 0x17009C4B RID: 40011
		// (get) Token: 0x06022C78 RID: 142456 RVA: 0x004D17E3 File Offset: 0x004CF9E3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022C79 RID: 142457 RVA: 0x004D17F0 File Offset: 0x004CF9F0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022C7A RID: 142458 RVA: 0x004D17F8 File Offset: 0x004CF9F8
		public static IGravityFlipConfig GetRootAsIGravityFlipConfig(ByteBuffer _bb)
		{
			return IGravityFlipConfig.GetRootAsIGravityFlipConfig(_bb, default(IGravityFlipConfig));
		}

		// Token: 0x06022C7B RID: 142459 RVA: 0x004D1814 File Offset: 0x004CFA14
		public static IGravityFlipConfig GetRootAsIGravityFlipConfig(ByteBuffer _bb, IGravityFlipConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022C7C RID: 142460 RVA: 0x004D1831 File Offset: 0x004CFA31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022C7D RID: 142461 RVA: 0x004D1840 File Offset: 0x004CFA40
		public IGravityFlipConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009C4C RID: 40012
		// (get) Token: 0x06022C7E RID: 142462 RVA: 0x004D1850 File Offset: 0x004CFA50
		public EGravityFlipType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGravityFlipType.None;
				}
				return (EGravityFlipType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009C4D RID: 40013
		// (get) Token: 0x06022C7F RID: 142463 RVA: 0x004D188C File Offset: 0x004CFA8C
		public int LocationEntityId
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

		// Token: 0x06022C80 RID: 142464 RVA: 0x004D18C8 File Offset: 0x004CFAC8
		public static Offset<IGravityFlipConfig> CreateIGravityFlipConfig(FlatBufferBuilder builder, EGravityFlipType Type = EGravityFlipType.None, int LocationEntityId = 0)
		{
			builder.StartTable(2);
			IGravityFlipConfig.AddLocationEntityId(builder, LocationEntityId);
			IGravityFlipConfig.AddType(builder, Type);
			return IGravityFlipConfig.EndIGravityFlipConfig(builder);
		}

		// Token: 0x06022C81 RID: 142465 RVA: 0x004D18E5 File Offset: 0x004CFAE5
		public static void StartIGravityFlipConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06022C82 RID: 142466 RVA: 0x004D18EE File Offset: 0x004CFAEE
		public static void AddType(FlatBufferBuilder builder, EGravityFlipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022C83 RID: 142467 RVA: 0x004D18F9 File Offset: 0x004CFAF9
		public static void AddLocationEntityId(FlatBufferBuilder builder, int locationEntityId)
		{
			builder.AddInt(1, locationEntityId, 0);
		}

		// Token: 0x06022C84 RID: 142468 RVA: 0x004D1904 File Offset: 0x004CFB04
		public static Offset<IGravityFlipConfig> EndIGravityFlipConfig(FlatBufferBuilder builder)
		{
			return new Offset<IGravityFlipConfig>(builder.EndTable());
		}

		// Token: 0x06022C85 RID: 142469 RVA: 0x004D1914 File Offset: 0x004CFB14
		public IGravityFlipConfigT UnPack()
		{
			IGravityFlipConfigT gravityFlipConfigT = new IGravityFlipConfigT();
			this.UnPackTo(gravityFlipConfigT);
			return gravityFlipConfigT;
		}

		// Token: 0x06022C86 RID: 142470 RVA: 0x004D192F File Offset: 0x004CFB2F
		public void UnPackTo(IGravityFlipConfigT _o)
		{
			_o.Type = this.Type;
			_o.LocationEntityId = this.LocationEntityId;
		}

		// Token: 0x06022C87 RID: 142471 RVA: 0x004D194C File Offset: 0x004CFB4C
		public static Offset<IGravityFlipConfig> Pack(FlatBufferBuilder builder, IGravityFlipConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGravityFlipConfig>);
			}
			return IGravityFlipConfig.CreateIGravityFlipConfig(builder, _o.Type, _o.LocationEntityId);
		}

		// Token: 0x0400E4E0 RID: 58592
		private Table __p;
	}
}
