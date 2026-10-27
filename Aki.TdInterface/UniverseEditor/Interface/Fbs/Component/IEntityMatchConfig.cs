using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005195 RID: 20885
	public struct IEntityMatchConfig : IFlatbufferObject
	{
		// Token: 0x17009899 RID: 39065
		// (get) Token: 0x06021C8F RID: 138383 RVA: 0x004AFEF1 File Offset: 0x004AE0F1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021C90 RID: 138384 RVA: 0x004AFEFE File Offset: 0x004AE0FE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021C91 RID: 138385 RVA: 0x004AFF08 File Offset: 0x004AE108
		public static IEntityMatchConfig GetRootAsIEntityMatchConfig(ByteBuffer _bb)
		{
			return IEntityMatchConfig.GetRootAsIEntityMatchConfig(_bb, default(IEntityMatchConfig));
		}

		// Token: 0x06021C92 RID: 138386 RVA: 0x004AFF24 File Offset: 0x004AE124
		public static IEntityMatchConfig GetRootAsIEntityMatchConfig(ByteBuffer _bb, IEntityMatchConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021C93 RID: 138387 RVA: 0x004AFF41 File Offset: 0x004AE141
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021C94 RID: 138388 RVA: 0x004AFF50 File Offset: 0x004AE150
		public IEntityMatchConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700989A RID: 39066
		// (get) Token: 0x06021C95 RID: 138389 RVA: 0x004AFF60 File Offset: 0x004AE160
		public EEntityMatchType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEntityMatchType.Player;
				}
				return (EEntityMatchType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021C96 RID: 138390 RVA: 0x004AFF9C File Offset: 0x004AE19C
		public static Offset<IEntityMatchConfig> CreateIEntityMatchConfig(FlatBufferBuilder builder, EEntityMatchType Type = EEntityMatchType.Player)
		{
			builder.StartTable(1);
			IEntityMatchConfig.AddType(builder, Type);
			return IEntityMatchConfig.EndIEntityMatchConfig(builder);
		}

		// Token: 0x06021C97 RID: 138391 RVA: 0x004AFFB2 File Offset: 0x004AE1B2
		public static void StartIEntityMatchConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06021C98 RID: 138392 RVA: 0x004AFFBB File Offset: 0x004AE1BB
		public static void AddType(FlatBufferBuilder builder, EEntityMatchType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021C99 RID: 138393 RVA: 0x004AFFC6 File Offset: 0x004AE1C6
		public static Offset<IEntityMatchConfig> EndIEntityMatchConfig(FlatBufferBuilder builder)
		{
			return new Offset<IEntityMatchConfig>(builder.EndTable());
		}

		// Token: 0x06021C9A RID: 138394 RVA: 0x004AFFD4 File Offset: 0x004AE1D4
		public IEntityMatchConfigT UnPack()
		{
			IEntityMatchConfigT entityMatchConfigT = new IEntityMatchConfigT();
			this.UnPackTo(entityMatchConfigT);
			return entityMatchConfigT;
		}

		// Token: 0x06021C9B RID: 138395 RVA: 0x004AFFEF File Offset: 0x004AE1EF
		public void UnPackTo(IEntityMatchConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06021C9C RID: 138396 RVA: 0x004B0000 File Offset: 0x004AE200
		public static Offset<IEntityMatchConfig> Pack(FlatBufferBuilder builder, IEntityMatchConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityMatchConfig>);
			}
			return IEntityMatchConfig.CreateIEntityMatchConfig(builder, _o.Type);
		}

		// Token: 0x0400E26C RID: 57964
		private Table __p;
	}
}
