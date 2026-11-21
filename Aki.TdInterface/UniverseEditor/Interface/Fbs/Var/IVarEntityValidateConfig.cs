using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F04 RID: 16132
	public struct IVarEntityValidateConfig : IFlatbufferObject
	{
		// Token: 0x17006D3A RID: 27962
		// (get) Token: 0x06015E47 RID: 89671 RVA: 0x0032610B File Offset: 0x0032430B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015E48 RID: 89672 RVA: 0x00326118 File Offset: 0x00324318
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015E49 RID: 89673 RVA: 0x00326120 File Offset: 0x00324320
		public static IVarEntityValidateConfig GetRootAsIVarEntityValidateConfig(ByteBuffer _bb)
		{
			return IVarEntityValidateConfig.GetRootAsIVarEntityValidateConfig(_bb, default(IVarEntityValidateConfig));
		}

		// Token: 0x06015E4A RID: 89674 RVA: 0x0032613C File Offset: 0x0032433C
		public static IVarEntityValidateConfig GetRootAsIVarEntityValidateConfig(ByteBuffer _bb, IVarEntityValidateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015E4B RID: 89675 RVA: 0x00326159 File Offset: 0x00324359
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015E4C RID: 89676 RVA: 0x00326168 File Offset: 0x00324368
		public IVarEntityValidateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006D3B RID: 27963
		// (get) Token: 0x06015E4D RID: 89677 RVA: 0x00326178 File Offset: 0x00324378
		public EVar Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVar.Boolean;
				}
				return (EVar)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015E4E RID: 89678 RVA: 0x003261B4 File Offset: 0x003243B4
		public static Offset<IVarEntityValidateConfig> CreateIVarEntityValidateConfig(FlatBufferBuilder builder, EVar Type = EVar.Boolean)
		{
			builder.StartTable(1);
			IVarEntityValidateConfig.AddType(builder, Type);
			return IVarEntityValidateConfig.EndIVarEntityValidateConfig(builder);
		}

		// Token: 0x06015E4F RID: 89679 RVA: 0x003261CA File Offset: 0x003243CA
		public static void StartIVarEntityValidateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06015E50 RID: 89680 RVA: 0x003261D3 File Offset: 0x003243D3
		public static void AddType(FlatBufferBuilder builder, EVar type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015E51 RID: 89681 RVA: 0x003261DE File Offset: 0x003243DE
		public static Offset<IVarEntityValidateConfig> EndIVarEntityValidateConfig(FlatBufferBuilder builder)
		{
			return new Offset<IVarEntityValidateConfig>(builder.EndTable());
		}

		// Token: 0x06015E52 RID: 89682 RVA: 0x003261EC File Offset: 0x003243EC
		public IVarEntityValidateConfigT UnPack()
		{
			IVarEntityValidateConfigT varEntityValidateConfigT = new IVarEntityValidateConfigT();
			this.UnPackTo(varEntityValidateConfigT);
			return varEntityValidateConfigT;
		}

		// Token: 0x06015E53 RID: 89683 RVA: 0x00326207 File Offset: 0x00324407
		public void UnPackTo(IVarEntityValidateConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06015E54 RID: 89684 RVA: 0x00326218 File Offset: 0x00324418
		public static Offset<IVarEntityValidateConfig> Pack(FlatBufferBuilder builder, IVarEntityValidateConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVarEntityValidateConfig>);
			}
			return IVarEntityValidateConfig.CreateIVarEntityValidateConfig(builder, _o.Type);
		}

		// Token: 0x0400B93B RID: 47419
		private Table __p;
	}
}
