using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B11 RID: 15121
	public struct IVarQuestStateValidateConfig : IFlatbufferObject
	{
		// Token: 0x170067C0 RID: 26560
		// (get) Token: 0x06014A39 RID: 84537 RVA: 0x00301261 File Offset: 0x002FF461
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014A3A RID: 84538 RVA: 0x0030126E File Offset: 0x002FF46E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014A3B RID: 84539 RVA: 0x00301278 File Offset: 0x002FF478
		public static IVarQuestStateValidateConfig GetRootAsIVarQuestStateValidateConfig(ByteBuffer _bb)
		{
			return IVarQuestStateValidateConfig.GetRootAsIVarQuestStateValidateConfig(_bb, default(IVarQuestStateValidateConfig));
		}

		// Token: 0x06014A3C RID: 84540 RVA: 0x00301294 File Offset: 0x002FF494
		public static IVarQuestStateValidateConfig GetRootAsIVarQuestStateValidateConfig(ByteBuffer _bb, IVarQuestStateValidateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014A3D RID: 84541 RVA: 0x003012B1 File Offset: 0x002FF4B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014A3E RID: 84542 RVA: 0x003012C0 File Offset: 0x002FF4C0
		public IVarQuestStateValidateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170067C1 RID: 26561
		// (get) Token: 0x06014A3F RID: 84543 RVA: 0x003012D0 File Offset: 0x002FF4D0
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

		// Token: 0x06014A40 RID: 84544 RVA: 0x0030130C File Offset: 0x002FF50C
		public static Offset<IVarQuestStateValidateConfig> CreateIVarQuestStateValidateConfig(FlatBufferBuilder builder, EVar Type = EVar.Boolean)
		{
			builder.StartTable(1);
			IVarQuestStateValidateConfig.AddType(builder, Type);
			return IVarQuestStateValidateConfig.EndIVarQuestStateValidateConfig(builder);
		}

		// Token: 0x06014A41 RID: 84545 RVA: 0x00301322 File Offset: 0x002FF522
		public static void StartIVarQuestStateValidateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06014A42 RID: 84546 RVA: 0x0030132B File Offset: 0x002FF52B
		public static void AddType(FlatBufferBuilder builder, EVar type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014A43 RID: 84547 RVA: 0x00301336 File Offset: 0x002FF536
		public static Offset<IVarQuestStateValidateConfig> EndIVarQuestStateValidateConfig(FlatBufferBuilder builder)
		{
			return new Offset<IVarQuestStateValidateConfig>(builder.EndTable());
		}

		// Token: 0x06014A44 RID: 84548 RVA: 0x00301344 File Offset: 0x002FF544
		public IVarQuestStateValidateConfigT UnPack()
		{
			IVarQuestStateValidateConfigT varQuestStateValidateConfigT = new IVarQuestStateValidateConfigT();
			this.UnPackTo(varQuestStateValidateConfigT);
			return varQuestStateValidateConfigT;
		}

		// Token: 0x06014A45 RID: 84549 RVA: 0x0030135F File Offset: 0x002FF55F
		public void UnPackTo(IVarQuestStateValidateConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06014A46 RID: 84550 RVA: 0x00301370 File Offset: 0x002FF570
		public static Offset<IVarQuestStateValidateConfig> Pack(FlatBufferBuilder builder, IVarQuestStateValidateConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVarQuestStateValidateConfig>);
			}
			return IVarQuestStateValidateConfig.CreateIVarQuestStateValidateConfig(builder, _o.Type);
		}

		// Token: 0x0400AFE1 RID: 45025
		private Table __p;
	}
}
