using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B0E RID: 15118
	public struct IVarPrefabValidateConfig : IFlatbufferObject
	{
		// Token: 0x170067BD RID: 26557
		// (get) Token: 0x06014A27 RID: 84519 RVA: 0x003010EA File Offset: 0x002FF2EA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014A28 RID: 84520 RVA: 0x003010F7 File Offset: 0x002FF2F7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014A29 RID: 84521 RVA: 0x00301100 File Offset: 0x002FF300
		public static IVarPrefabValidateConfig GetRootAsIVarPrefabValidateConfig(ByteBuffer _bb)
		{
			return IVarPrefabValidateConfig.GetRootAsIVarPrefabValidateConfig(_bb, default(IVarPrefabValidateConfig));
		}

		// Token: 0x06014A2A RID: 84522 RVA: 0x0030111C File Offset: 0x002FF31C
		public static IVarPrefabValidateConfig GetRootAsIVarPrefabValidateConfig(ByteBuffer _bb, IVarPrefabValidateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014A2B RID: 84523 RVA: 0x00301139 File Offset: 0x002FF339
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014A2C RID: 84524 RVA: 0x00301148 File Offset: 0x002FF348
		public IVarPrefabValidateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170067BE RID: 26558
		// (get) Token: 0x06014A2D RID: 84525 RVA: 0x00301158 File Offset: 0x002FF358
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

		// Token: 0x06014A2E RID: 84526 RVA: 0x00301194 File Offset: 0x002FF394
		public static Offset<IVarPrefabValidateConfig> CreateIVarPrefabValidateConfig(FlatBufferBuilder builder, EVar Type = EVar.Boolean)
		{
			builder.StartTable(1);
			IVarPrefabValidateConfig.AddType(builder, Type);
			return IVarPrefabValidateConfig.EndIVarPrefabValidateConfig(builder);
		}

		// Token: 0x06014A2F RID: 84527 RVA: 0x003011AA File Offset: 0x002FF3AA
		public static void StartIVarPrefabValidateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06014A30 RID: 84528 RVA: 0x003011B3 File Offset: 0x002FF3B3
		public static void AddType(FlatBufferBuilder builder, EVar type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014A31 RID: 84529 RVA: 0x003011BE File Offset: 0x002FF3BE
		public static Offset<IVarPrefabValidateConfig> EndIVarPrefabValidateConfig(FlatBufferBuilder builder)
		{
			return new Offset<IVarPrefabValidateConfig>(builder.EndTable());
		}

		// Token: 0x06014A32 RID: 84530 RVA: 0x003011CC File Offset: 0x002FF3CC
		public IVarPrefabValidateConfigT UnPack()
		{
			IVarPrefabValidateConfigT varPrefabValidateConfigT = new IVarPrefabValidateConfigT();
			this.UnPackTo(varPrefabValidateConfigT);
			return varPrefabValidateConfigT;
		}

		// Token: 0x06014A33 RID: 84531 RVA: 0x003011E7 File Offset: 0x002FF3E7
		public void UnPackTo(IVarPrefabValidateConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06014A34 RID: 84532 RVA: 0x003011F8 File Offset: 0x002FF3F8
		public static Offset<IVarPrefabValidateConfig> Pack(FlatBufferBuilder builder, IVarPrefabValidateConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVarPrefabValidateConfig>);
			}
			return IVarPrefabValidateConfig.CreateIVarPrefabValidateConfig(builder, _o.Type);
		}

		// Token: 0x0400AFDF RID: 45023
		private Table __p;
	}
}
