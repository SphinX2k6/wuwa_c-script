using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071F2 RID: 29170
	public struct IModifyMaterialConfig : IFlatbufferObject
	{
		// Token: 0x1700D58C RID: 54668
		// (get) Token: 0x06032BF6 RID: 207862 RVA: 0x006DAF2C File Offset: 0x006D912C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032BF7 RID: 207863 RVA: 0x006DAF39 File Offset: 0x006D9139
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032BF8 RID: 207864 RVA: 0x006DAF40 File Offset: 0x006D9140
		public static IModifyMaterialConfig GetRootAsIModifyMaterialConfig(ByteBuffer _bb)
		{
			return IModifyMaterialConfig.GetRootAsIModifyMaterialConfig(_bb, default(IModifyMaterialConfig));
		}

		// Token: 0x06032BF9 RID: 207865 RVA: 0x006DAF5C File Offset: 0x006D915C
		public static IModifyMaterialConfig GetRootAsIModifyMaterialConfig(ByteBuffer _bb, IModifyMaterialConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032BFA RID: 207866 RVA: 0x006DAF79 File Offset: 0x006D9179
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032BFB RID: 207867 RVA: 0x006DAF88 File Offset: 0x006D9188
		public IModifyMaterialConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D58D RID: 54669
		// (get) Token: 0x06032BFC RID: 207868 RVA: 0x006DAF98 File Offset: 0x006D9198
		public EModifyActorMaterialType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EModifyActorMaterialType.ChangeMaterialData;
				}
				return (EModifyActorMaterialType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032BFD RID: 207869 RVA: 0x006DAFD4 File Offset: 0x006D91D4
		public static Offset<IModifyMaterialConfig> CreateIModifyMaterialConfig(FlatBufferBuilder builder, EModifyActorMaterialType Type = EModifyActorMaterialType.ChangeMaterialData)
		{
			builder.StartTable(1);
			IModifyMaterialConfig.AddType(builder, Type);
			return IModifyMaterialConfig.EndIModifyMaterialConfig(builder);
		}

		// Token: 0x06032BFE RID: 207870 RVA: 0x006DAFEA File Offset: 0x006D91EA
		public static void StartIModifyMaterialConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032BFF RID: 207871 RVA: 0x006DAFF3 File Offset: 0x006D91F3
		public static void AddType(FlatBufferBuilder builder, EModifyActorMaterialType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032C00 RID: 207872 RVA: 0x006DAFFE File Offset: 0x006D91FE
		public static Offset<IModifyMaterialConfig> EndIModifyMaterialConfig(FlatBufferBuilder builder)
		{
			return new Offset<IModifyMaterialConfig>(builder.EndTable());
		}

		// Token: 0x06032C01 RID: 207873 RVA: 0x006DB00C File Offset: 0x006D920C
		public IModifyMaterialConfigT UnPack()
		{
			IModifyMaterialConfigT modifyMaterialConfigT = new IModifyMaterialConfigT();
			this.UnPackTo(modifyMaterialConfigT);
			return modifyMaterialConfigT;
		}

		// Token: 0x06032C02 RID: 207874 RVA: 0x006DB027 File Offset: 0x006D9227
		public void UnPackTo(IModifyMaterialConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06032C03 RID: 207875 RVA: 0x006DB038 File Offset: 0x006D9238
		public static Offset<IModifyMaterialConfig> Pack(FlatBufferBuilder builder, IModifyMaterialConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IModifyMaterialConfig>);
			}
			return IModifyMaterialConfig.CreateIModifyMaterialConfig(builder, _o.Type);
		}

		// Token: 0x0401220E RID: 74254
		private Table __p;
	}
}
