using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C51 RID: 27729
	public struct IOverrideAbpAnimSchemeConfig : IFlatbufferObject
	{
		// Token: 0x1700CE84 RID: 52868
		// (get) Token: 0x06030DA5 RID: 200101 RVA: 0x006A2D83 File Offset: 0x006A0F83
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030DA6 RID: 200102 RVA: 0x006A2D90 File Offset: 0x006A0F90
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030DA7 RID: 200103 RVA: 0x006A2D98 File Offset: 0x006A0F98
		public static IOverrideAbpAnimSchemeConfig GetRootAsIOverrideAbpAnimSchemeConfig(ByteBuffer _bb)
		{
			return IOverrideAbpAnimSchemeConfig.GetRootAsIOverrideAbpAnimSchemeConfig(_bb, default(IOverrideAbpAnimSchemeConfig));
		}

		// Token: 0x06030DA8 RID: 200104 RVA: 0x006A2DB4 File Offset: 0x006A0FB4
		public static IOverrideAbpAnimSchemeConfig GetRootAsIOverrideAbpAnimSchemeConfig(ByteBuffer _bb, IOverrideAbpAnimSchemeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030DA9 RID: 200105 RVA: 0x006A2DD1 File Offset: 0x006A0FD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030DAA RID: 200106 RVA: 0x006A2DE0 File Offset: 0x006A0FE0
		public IOverrideAbpAnimSchemeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CE85 RID: 52869
		// (get) Token: 0x06030DAB RID: 200107 RVA: 0x006A2DF0 File Offset: 0x006A0FF0
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CE86 RID: 52870
		// (get) Token: 0x06030DAC RID: 200108 RVA: 0x006A2E2C File Offset: 0x006A102C
		public EAbpAnimScheme AnimScheme
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EAbpAnimScheme.Scheme1;
				}
				return (EAbpAnimScheme)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030DAD RID: 200109 RVA: 0x006A2E68 File Offset: 0x006A1068
		public static Offset<IOverrideAbpAnimSchemeConfig> CreateIOverrideAbpAnimSchemeConfig(FlatBufferBuilder builder, int EntityId = 0, EAbpAnimScheme AnimScheme = EAbpAnimScheme.Scheme1)
		{
			builder.StartTable(2);
			IOverrideAbpAnimSchemeConfig.AddEntityId(builder, EntityId);
			IOverrideAbpAnimSchemeConfig.AddAnimScheme(builder, AnimScheme);
			return IOverrideAbpAnimSchemeConfig.EndIOverrideAbpAnimSchemeConfig(builder);
		}

		// Token: 0x06030DAE RID: 200110 RVA: 0x006A2E85 File Offset: 0x006A1085
		public static void StartIOverrideAbpAnimSchemeConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030DAF RID: 200111 RVA: 0x006A2E8E File Offset: 0x006A108E
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06030DB0 RID: 200112 RVA: 0x006A2E99 File Offset: 0x006A1099
		public static void AddAnimScheme(FlatBufferBuilder builder, EAbpAnimScheme animScheme)
		{
			builder.AddByte(1, (byte)animScheme, 0);
		}

		// Token: 0x06030DB1 RID: 200113 RVA: 0x006A2EA4 File Offset: 0x006A10A4
		public static Offset<IOverrideAbpAnimSchemeConfig> EndIOverrideAbpAnimSchemeConfig(FlatBufferBuilder builder)
		{
			return new Offset<IOverrideAbpAnimSchemeConfig>(builder.EndTable());
		}

		// Token: 0x06030DB2 RID: 200114 RVA: 0x006A2EB4 File Offset: 0x006A10B4
		public IOverrideAbpAnimSchemeConfigT UnPack()
		{
			IOverrideAbpAnimSchemeConfigT overrideAbpAnimSchemeConfigT = new IOverrideAbpAnimSchemeConfigT();
			this.UnPackTo(overrideAbpAnimSchemeConfigT);
			return overrideAbpAnimSchemeConfigT;
		}

		// Token: 0x06030DB3 RID: 200115 RVA: 0x006A2ECF File Offset: 0x006A10CF
		public void UnPackTo(IOverrideAbpAnimSchemeConfigT _o)
		{
			_o.EntityId = this.EntityId;
			_o.AnimScheme = this.AnimScheme;
		}

		// Token: 0x06030DB4 RID: 200116 RVA: 0x006A2EEC File Offset: 0x006A10EC
		public static Offset<IOverrideAbpAnimSchemeConfig> Pack(FlatBufferBuilder builder, IOverrideAbpAnimSchemeConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOverrideAbpAnimSchemeConfig>);
			}
			return IOverrideAbpAnimSchemeConfig.CreateIOverrideAbpAnimSchemeConfig(builder, _o.EntityId, _o.AnimScheme);
		}

		// Token: 0x04011591 RID: 71057
		private Table __p;
	}
}
