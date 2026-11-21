using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056FA RID: 22266
	public struct IEntityMatchConfig : IFlatbufferObject
	{
		// Token: 0x1700A088 RID: 41096
		// (get) Token: 0x06023BE7 RID: 146407 RVA: 0x004E9F11 File Offset: 0x004E8111
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023BE8 RID: 146408 RVA: 0x004E9F1E File Offset: 0x004E811E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023BE9 RID: 146409 RVA: 0x004E9F28 File Offset: 0x004E8128
		public static IEntityMatchConfig GetRootAsIEntityMatchConfig(ByteBuffer _bb)
		{
			return IEntityMatchConfig.GetRootAsIEntityMatchConfig(_bb, default(IEntityMatchConfig));
		}

		// Token: 0x06023BEA RID: 146410 RVA: 0x004E9F44 File Offset: 0x004E8144
		public static IEntityMatchConfig GetRootAsIEntityMatchConfig(ByteBuffer _bb, IEntityMatchConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023BEB RID: 146411 RVA: 0x004E9F61 File Offset: 0x004E8161
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023BEC RID: 146412 RVA: 0x004E9F70 File Offset: 0x004E8170
		public IEntityMatchConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A089 RID: 41097
		// (get) Token: 0x06023BED RID: 146413 RVA: 0x004E9F80 File Offset: 0x004E8180
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

		// Token: 0x06023BEE RID: 146414 RVA: 0x004E9FBC File Offset: 0x004E81BC
		public static Offset<IEntityMatchConfig> CreateIEntityMatchConfig(FlatBufferBuilder builder, EEntityMatchType Type = EEntityMatchType.Player)
		{
			builder.StartTable(1);
			IEntityMatchConfig.AddType(builder, Type);
			return IEntityMatchConfig.EndIEntityMatchConfig(builder);
		}

		// Token: 0x06023BEF RID: 146415 RVA: 0x004E9FD2 File Offset: 0x004E81D2
		public static void StartIEntityMatchConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06023BF0 RID: 146416 RVA: 0x004E9FDB File Offset: 0x004E81DB
		public static void AddType(FlatBufferBuilder builder, EEntityMatchType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023BF1 RID: 146417 RVA: 0x004E9FE6 File Offset: 0x004E81E6
		public static Offset<IEntityMatchConfig> EndIEntityMatchConfig(FlatBufferBuilder builder)
		{
			return new Offset<IEntityMatchConfig>(builder.EndTable());
		}

		// Token: 0x06023BF2 RID: 146418 RVA: 0x004E9FF4 File Offset: 0x004E81F4
		public IEntityMatchConfigT UnPack()
		{
			IEntityMatchConfigT entityMatchConfigT = new IEntityMatchConfigT();
			this.UnPackTo(entityMatchConfigT);
			return entityMatchConfigT;
		}

		// Token: 0x06023BF3 RID: 146419 RVA: 0x004EA00F File Offset: 0x004E820F
		public void UnPackTo(IEntityMatchConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06023BF4 RID: 146420 RVA: 0x004EA020 File Offset: 0x004E8220
		public static Offset<IEntityMatchConfig> Pack(FlatBufferBuilder builder, IEntityMatchConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityMatchConfig>);
			}
			return IEntityMatchConfig.CreateIEntityMatchConfig(builder, _o.Type);
		}

		// Token: 0x0400EE6A RID: 61034
		private Table __p;
	}
}
