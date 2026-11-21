using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D82 RID: 28034
	public struct IExecBpActorFunc : IFlatbufferObject
	{
		// Token: 0x1700CDA6 RID: 52646
		// (get) Token: 0x0603060C RID: 198156 RVA: 0x00692E5E File Offset: 0x0069105E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603060D RID: 198157 RVA: 0x00692E6B File Offset: 0x0069106B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603060E RID: 198158 RVA: 0x00692E74 File Offset: 0x00691074
		public static IExecBpActorFunc GetRootAsIExecBpActorFunc(ByteBuffer _bb)
		{
			return IExecBpActorFunc.GetRootAsIExecBpActorFunc(_bb, default(IExecBpActorFunc));
		}

		// Token: 0x0603060F RID: 198159 RVA: 0x00692E90 File Offset: 0x00691090
		public static IExecBpActorFunc GetRootAsIExecBpActorFunc(ByteBuffer _bb, IExecBpActorFunc obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030610 RID: 198160 RVA: 0x00692EAD File Offset: 0x006910AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030611 RID: 198161 RVA: 0x00692EBC File Offset: 0x006910BC
		public IExecBpActorFunc __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CDA7 RID: 52647
		// (get) Token: 0x06030612 RID: 198162 RVA: 0x00692ECC File Offset: 0x006910CC
		public TBpActorFuncType ExecFuncTypeType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TBpActorFuncType.NONE;
				}
				return (TBpActorFuncType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030613 RID: 198163 RVA: 0x00692F08 File Offset: 0x00691108
		public TTable? ExecFuncType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06030614 RID: 198164 RVA: 0x00692F4C File Offset: 0x0069114C
		public IBrokenBridgeEffectInMobileBpActorFunc ExecFuncTypeAsIBrokenBridgeEffectInMobileBpActorFunc()
		{
			return this.ExecFuncType<IBrokenBridgeEffectInMobileBpActorFunc>().Value;
		}

		// Token: 0x06030615 RID: 198165 RVA: 0x00692F68 File Offset: 0x00691168
		public ICarPaintChangeBpActorFunc ExecFuncTypeAsICarPaintChangeBpActorFunc()
		{
			return this.ExecFuncType<ICarPaintChangeBpActorFunc>().Value;
		}

		// Token: 0x06030616 RID: 198166 RVA: 0x00692F83 File Offset: 0x00691183
		public static Offset<IExecBpActorFunc> CreateIExecBpActorFunc(FlatBufferBuilder builder, TBpActorFuncType ExecFuncType_type = TBpActorFuncType.NONE, int ExecFuncTypeOffset = 0)
		{
			builder.StartTable(2);
			IExecBpActorFunc.AddExecFuncType(builder, ExecFuncTypeOffset);
			IExecBpActorFunc.AddExecFuncTypeType(builder, ExecFuncType_type);
			return IExecBpActorFunc.EndIExecBpActorFunc(builder);
		}

		// Token: 0x06030617 RID: 198167 RVA: 0x00692FA0 File Offset: 0x006911A0
		public static void StartIExecBpActorFunc(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030618 RID: 198168 RVA: 0x00692FA9 File Offset: 0x006911A9
		public static void AddExecFuncTypeType(FlatBufferBuilder builder, TBpActorFuncType execFuncTypeType)
		{
			builder.AddByte(0, (byte)execFuncTypeType, 0);
		}

		// Token: 0x06030619 RID: 198169 RVA: 0x00692FB4 File Offset: 0x006911B4
		public static void AddExecFuncType(FlatBufferBuilder builder, int execFuncTypeOffset)
		{
			builder.AddOffset(1, execFuncTypeOffset, 0);
		}

		// Token: 0x0603061A RID: 198170 RVA: 0x00692FBF File Offset: 0x006911BF
		public static Offset<IExecBpActorFunc> EndIExecBpActorFunc(FlatBufferBuilder builder)
		{
			return new Offset<IExecBpActorFunc>(builder.EndTable());
		}

		// Token: 0x0603061B RID: 198171 RVA: 0x00692FCC File Offset: 0x006911CC
		public IExecBpActorFuncT UnPack()
		{
			IExecBpActorFuncT execBpActorFuncT = new IExecBpActorFuncT();
			this.UnPackTo(execBpActorFuncT);
			return execBpActorFuncT;
		}

		// Token: 0x0603061C RID: 198172 RVA: 0x00692FE8 File Offset: 0x006911E8
		public void UnPackTo(IExecBpActorFuncT _o)
		{
			_o.ExecFuncType = new TBpActorFuncTypeUnion();
			_o.ExecFuncType.Type = this.ExecFuncTypeType;
			TBpActorFuncType execFuncTypeType = this.ExecFuncTypeType;
			if (execFuncTypeType == TBpActorFuncType.IBrokenBridgeEffectInMobileBpActorFunc)
			{
				_o.ExecFuncType.Value = ((this.ExecFuncType<IBrokenBridgeEffectInMobileBpActorFunc>() != null) ? this.ExecFuncType<IBrokenBridgeEffectInMobileBpActorFunc>().Value.UnPack() : null);
				return;
			}
			if (execFuncTypeType != TBpActorFuncType.ICarPaintChangeBpActorFunc)
			{
				return;
			}
			_o.ExecFuncType.Value = ((this.ExecFuncType<ICarPaintChangeBpActorFunc>() != null) ? this.ExecFuncType<ICarPaintChangeBpActorFunc>().Value.UnPack() : null);
		}

		// Token: 0x0603061D RID: 198173 RVA: 0x0069308C File Offset: 0x0069128C
		public static Offset<IExecBpActorFunc> Pack(FlatBufferBuilder builder, IExecBpActorFuncT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExecBpActorFunc>);
			}
			TBpActorFuncType execFuncType_type = (_o.ExecFuncType == null) ? TBpActorFuncType.NONE : _o.ExecFuncType.Type;
			int execFuncTypeOffset = (_o.ExecFuncType == null) ? 0 : TBpActorFuncTypeUnion.Pack(builder, _o.ExecFuncType);
			return IExecBpActorFunc.CreateIExecBpActorFunc(builder, execFuncType_type, execFuncTypeOffset);
		}

		// Token: 0x04011C11 RID: 72721
		private Table __p;
	}
}
