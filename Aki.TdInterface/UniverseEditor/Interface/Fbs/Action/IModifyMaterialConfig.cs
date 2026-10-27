using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ABE RID: 27326
	public struct IModifyMaterialConfig : IFlatbufferObject
	{
		// Token: 0x1700CAC4 RID: 51908
		// (get) Token: 0x0602FE40 RID: 196160 RVA: 0x00683C87 File Offset: 0x00681E87
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FE41 RID: 196161 RVA: 0x00683C94 File Offset: 0x00681E94
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FE42 RID: 196162 RVA: 0x00683C9C File Offset: 0x00681E9C
		public static IModifyMaterialConfig GetRootAsIModifyMaterialConfig(ByteBuffer _bb)
		{
			return IModifyMaterialConfig.GetRootAsIModifyMaterialConfig(_bb, default(IModifyMaterialConfig));
		}

		// Token: 0x0602FE43 RID: 196163 RVA: 0x00683CB8 File Offset: 0x00681EB8
		public static IModifyMaterialConfig GetRootAsIModifyMaterialConfig(ByteBuffer _bb, IModifyMaterialConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FE44 RID: 196164 RVA: 0x00683CD5 File Offset: 0x00681ED5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FE45 RID: 196165 RVA: 0x00683CE4 File Offset: 0x00681EE4
		public IModifyMaterialConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CAC5 RID: 51909
		// (get) Token: 0x0602FE46 RID: 196166 RVA: 0x00683CF4 File Offset: 0x00681EF4
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

		// Token: 0x0602FE47 RID: 196167 RVA: 0x00683D30 File Offset: 0x00681F30
		public static Offset<IModifyMaterialConfig> CreateIModifyMaterialConfig(FlatBufferBuilder builder, EModifyActorMaterialType Type = EModifyActorMaterialType.ChangeMaterialData)
		{
			builder.StartTable(1);
			IModifyMaterialConfig.AddType(builder, Type);
			return IModifyMaterialConfig.EndIModifyMaterialConfig(builder);
		}

		// Token: 0x0602FE48 RID: 196168 RVA: 0x00683D46 File Offset: 0x00681F46
		public static void StartIModifyMaterialConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602FE49 RID: 196169 RVA: 0x00683D4F File Offset: 0x00681F4F
		public static void AddType(FlatBufferBuilder builder, EModifyActorMaterialType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FE4A RID: 196170 RVA: 0x00683D5A File Offset: 0x00681F5A
		public static Offset<IModifyMaterialConfig> EndIModifyMaterialConfig(FlatBufferBuilder builder)
		{
			return new Offset<IModifyMaterialConfig>(builder.EndTable());
		}

		// Token: 0x0602FE4B RID: 196171 RVA: 0x00683D68 File Offset: 0x00681F68
		public IModifyMaterialConfigT UnPack()
		{
			IModifyMaterialConfigT modifyMaterialConfigT = new IModifyMaterialConfigT();
			this.UnPackTo(modifyMaterialConfigT);
			return modifyMaterialConfigT;
		}

		// Token: 0x0602FE4C RID: 196172 RVA: 0x00683D83 File Offset: 0x00681F83
		public void UnPackTo(IModifyMaterialConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602FE4D RID: 196173 RVA: 0x00683D94 File Offset: 0x00681F94
		public static Offset<IModifyMaterialConfig> Pack(FlatBufferBuilder builder, IModifyMaterialConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IModifyMaterialConfig>);
			}
			return IModifyMaterialConfig.CreateIModifyMaterialConfig(builder, _o.Type);
		}

		// Token: 0x040112FF RID: 70399
		private Table __p;
	}
}
