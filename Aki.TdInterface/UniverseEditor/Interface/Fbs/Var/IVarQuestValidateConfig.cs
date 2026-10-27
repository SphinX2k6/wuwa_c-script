using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B14 RID: 15124
	public struct IVarQuestValidateConfig : IFlatbufferObject
	{
		// Token: 0x170067C3 RID: 26563
		// (get) Token: 0x06014A4B RID: 84555 RVA: 0x003013D9 File Offset: 0x002FF5D9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014A4C RID: 84556 RVA: 0x003013E6 File Offset: 0x002FF5E6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014A4D RID: 84557 RVA: 0x003013F0 File Offset: 0x002FF5F0
		public static IVarQuestValidateConfig GetRootAsIVarQuestValidateConfig(ByteBuffer _bb)
		{
			return IVarQuestValidateConfig.GetRootAsIVarQuestValidateConfig(_bb, default(IVarQuestValidateConfig));
		}

		// Token: 0x06014A4E RID: 84558 RVA: 0x0030140C File Offset: 0x002FF60C
		public static IVarQuestValidateConfig GetRootAsIVarQuestValidateConfig(ByteBuffer _bb, IVarQuestValidateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014A4F RID: 84559 RVA: 0x00301429 File Offset: 0x002FF629
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014A50 RID: 84560 RVA: 0x00301438 File Offset: 0x002FF638
		public IVarQuestValidateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170067C4 RID: 26564
		// (get) Token: 0x06014A51 RID: 84561 RVA: 0x00301448 File Offset: 0x002FF648
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

		// Token: 0x06014A52 RID: 84562 RVA: 0x00301484 File Offset: 0x002FF684
		public static Offset<IVarQuestValidateConfig> CreateIVarQuestValidateConfig(FlatBufferBuilder builder, EVar Type = EVar.Boolean)
		{
			builder.StartTable(1);
			IVarQuestValidateConfig.AddType(builder, Type);
			return IVarQuestValidateConfig.EndIVarQuestValidateConfig(builder);
		}

		// Token: 0x06014A53 RID: 84563 RVA: 0x0030149A File Offset: 0x002FF69A
		public static void StartIVarQuestValidateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06014A54 RID: 84564 RVA: 0x003014A3 File Offset: 0x002FF6A3
		public static void AddType(FlatBufferBuilder builder, EVar type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014A55 RID: 84565 RVA: 0x003014AE File Offset: 0x002FF6AE
		public static Offset<IVarQuestValidateConfig> EndIVarQuestValidateConfig(FlatBufferBuilder builder)
		{
			return new Offset<IVarQuestValidateConfig>(builder.EndTable());
		}

		// Token: 0x06014A56 RID: 84566 RVA: 0x003014BC File Offset: 0x002FF6BC
		public IVarQuestValidateConfigT UnPack()
		{
			IVarQuestValidateConfigT varQuestValidateConfigT = new IVarQuestValidateConfigT();
			this.UnPackTo(varQuestValidateConfigT);
			return varQuestValidateConfigT;
		}

		// Token: 0x06014A57 RID: 84567 RVA: 0x003014D7 File Offset: 0x002FF6D7
		public void UnPackTo(IVarQuestValidateConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06014A58 RID: 84568 RVA: 0x003014E8 File Offset: 0x002FF6E8
		public static Offset<IVarQuestValidateConfig> Pack(FlatBufferBuilder builder, IVarQuestValidateConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVarQuestValidateConfig>);
			}
			return IVarQuestValidateConfig.CreateIVarQuestValidateConfig(builder, _o.Type);
		}

		// Token: 0x0400AFE3 RID: 45027
		private Table __p;
	}
}
