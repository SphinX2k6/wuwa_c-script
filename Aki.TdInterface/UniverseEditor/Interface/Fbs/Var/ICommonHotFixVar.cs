using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A8D RID: 14989
	public struct ICommonHotFixVar : IFlatbufferObject
	{
		// Token: 0x170066AB RID: 26283
		// (get) Token: 0x06014541 RID: 83265 RVA: 0x002F755B File Offset: 0x002F575B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014542 RID: 83266 RVA: 0x002F7568 File Offset: 0x002F5768
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014543 RID: 83267 RVA: 0x002F7570 File Offset: 0x002F5770
		public static ICommonHotFixVar GetRootAsICommonHotFixVar(ByteBuffer _bb)
		{
			return ICommonHotFixVar.GetRootAsICommonHotFixVar(_bb, default(ICommonHotFixVar));
		}

		// Token: 0x06014544 RID: 83268 RVA: 0x002F758C File Offset: 0x002F578C
		public static ICommonHotFixVar GetRootAsICommonHotFixVar(ByteBuffer _bb, ICommonHotFixVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014545 RID: 83269 RVA: 0x002F75A9 File Offset: 0x002F57A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014546 RID: 83270 RVA: 0x002F75B8 File Offset: 0x002F57B8
		public ICommonHotFixVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170066AC RID: 26284
		// (get) Token: 0x06014547 RID: 83271 RVA: 0x002F75C8 File Offset: 0x002F57C8
		public ESystemVarName Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESystemVarName.CommonHotFixVar;
				}
				return (ESystemVarName)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170066AD RID: 26285
		// (get) Token: 0x06014548 RID: 83272 RVA: 0x002F7604 File Offset: 0x002F5804
		public string VarName
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014549 RID: 83273 RVA: 0x002F763B File Offset: 0x002F583B
		public Span<byte> GetVarNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601454A RID: 83274 RVA: 0x002F764A File Offset: 0x002F584A
		public byte[] GetVarNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x170066AE RID: 26286
		// (get) Token: 0x0601454B RID: 83275 RVA: 0x002F7658 File Offset: 0x002F5858
		public string VarParams
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601454C RID: 83276 RVA: 0x002F768F File Offset: 0x002F588F
		public Span<byte> GetVarParamsBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601454D RID: 83277 RVA: 0x002F769E File Offset: 0x002F589E
		public byte[] GetVarParamsArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0601454E RID: 83278 RVA: 0x002F76AC File Offset: 0x002F58AC
		public static Offset<ICommonHotFixVar> CreateICommonHotFixVar(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar, StringOffset VarNameOffset = default(StringOffset), StringOffset VarParamsOffset = default(StringOffset))
		{
			builder.StartTable(3);
			ICommonHotFixVar.AddVarParams(builder, VarParamsOffset);
			ICommonHotFixVar.AddVarName(builder, VarNameOffset);
			ICommonHotFixVar.AddType(builder, Type);
			return ICommonHotFixVar.EndICommonHotFixVar(builder);
		}

		// Token: 0x0601454F RID: 83279 RVA: 0x002F76D0 File Offset: 0x002F58D0
		public static void StartICommonHotFixVar(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06014550 RID: 83280 RVA: 0x002F76D9 File Offset: 0x002F58D9
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014551 RID: 83281 RVA: 0x002F76E4 File Offset: 0x002F58E4
		public static void AddVarName(FlatBufferBuilder builder, StringOffset varNameOffset)
		{
			builder.AddOffset(1, varNameOffset.Value, 0);
		}

		// Token: 0x06014552 RID: 83282 RVA: 0x002F76F4 File Offset: 0x002F58F4
		public static void AddVarParams(FlatBufferBuilder builder, StringOffset varParamsOffset)
		{
			builder.AddOffset(2, varParamsOffset.Value, 0);
		}

		// Token: 0x06014553 RID: 83283 RVA: 0x002F7704 File Offset: 0x002F5904
		public static Offset<ICommonHotFixVar> EndICommonHotFixVar(FlatBufferBuilder builder)
		{
			return new Offset<ICommonHotFixVar>(builder.EndTable());
		}

		// Token: 0x06014554 RID: 83284 RVA: 0x002F7714 File Offset: 0x002F5914
		public ICommonHotFixVarT UnPack()
		{
			ICommonHotFixVarT commonHotFixVarT = new ICommonHotFixVarT();
			this.UnPackTo(commonHotFixVarT);
			return commonHotFixVarT;
		}

		// Token: 0x06014555 RID: 83285 RVA: 0x002F772F File Offset: 0x002F592F
		public void UnPackTo(ICommonHotFixVarT _o)
		{
			_o.Type = this.Type;
			_o.VarName = this.VarName;
			_o.VarParams = this.VarParams;
		}

		// Token: 0x06014556 RID: 83286 RVA: 0x002F7758 File Offset: 0x002F5958
		public static Offset<ICommonHotFixVar> Pack(FlatBufferBuilder builder, ICommonHotFixVarT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonHotFixVar>);
			}
			StringOffset varNameOffset = (_o.VarName == null) ? default(StringOffset) : builder.CreateString(_o.VarName);
			StringOffset varParamsOffset = (_o.VarParams == null) ? default(StringOffset) : builder.CreateString(_o.VarParams);
			return ICommonHotFixVar.CreateICommonHotFixVar(builder, _o.Type, varNameOffset, varParamsOffset);
		}

		// Token: 0x0400AF0A RID: 44810
		private Table __p;
	}
}
