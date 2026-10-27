using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006702 RID: 26370
	public struct IExecBpActorFunc : IFlatbufferObject
	{
		// Token: 0x1700C3F0 RID: 50160
		// (get) Token: 0x0602DDC9 RID: 187849 RVA: 0x006457B6 File Offset: 0x006439B6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DDCA RID: 187850 RVA: 0x006457C3 File Offset: 0x006439C3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DDCB RID: 187851 RVA: 0x006457CC File Offset: 0x006439CC
		public static IExecBpActorFunc GetRootAsIExecBpActorFunc(ByteBuffer _bb)
		{
			return IExecBpActorFunc.GetRootAsIExecBpActorFunc(_bb, default(IExecBpActorFunc));
		}

		// Token: 0x0602DDCC RID: 187852 RVA: 0x006457E8 File Offset: 0x006439E8
		public static IExecBpActorFunc GetRootAsIExecBpActorFunc(ByteBuffer _bb, IExecBpActorFunc obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DDCD RID: 187853 RVA: 0x00645805 File Offset: 0x00643A05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DDCE RID: 187854 RVA: 0x00645814 File Offset: 0x00643A14
		public IExecBpActorFunc __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C3F1 RID: 50161
		// (get) Token: 0x0602DDCF RID: 187855 RVA: 0x00645824 File Offset: 0x00643A24
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

		// Token: 0x0602DDD0 RID: 187856 RVA: 0x00645860 File Offset: 0x00643A60
		public TTable? ExecFuncType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602DDD1 RID: 187857 RVA: 0x006458A4 File Offset: 0x00643AA4
		public IBrokenBridgeEffectInMobileBpActorFunc ExecFuncTypeAsIBrokenBridgeEffectInMobileBpActorFunc()
		{
			return this.ExecFuncType<IBrokenBridgeEffectInMobileBpActorFunc>().Value;
		}

		// Token: 0x0602DDD2 RID: 187858 RVA: 0x006458C0 File Offset: 0x00643AC0
		public ICarPaintChangeBpActorFunc ExecFuncTypeAsICarPaintChangeBpActorFunc()
		{
			return this.ExecFuncType<ICarPaintChangeBpActorFunc>().Value;
		}

		// Token: 0x0602DDD3 RID: 187859 RVA: 0x006458DB File Offset: 0x00643ADB
		public static Offset<IExecBpActorFunc> CreateIExecBpActorFunc(FlatBufferBuilder builder, TBpActorFuncType ExecFuncType_type = TBpActorFuncType.NONE, int ExecFuncTypeOffset = 0)
		{
			builder.StartTable(2);
			IExecBpActorFunc.AddExecFuncType(builder, ExecFuncTypeOffset);
			IExecBpActorFunc.AddExecFuncTypeType(builder, ExecFuncType_type);
			return IExecBpActorFunc.EndIExecBpActorFunc(builder);
		}

		// Token: 0x0602DDD4 RID: 187860 RVA: 0x006458F8 File Offset: 0x00643AF8
		public static void StartIExecBpActorFunc(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602DDD5 RID: 187861 RVA: 0x00645901 File Offset: 0x00643B01
		public static void AddExecFuncTypeType(FlatBufferBuilder builder, TBpActorFuncType execFuncTypeType)
		{
			builder.AddByte(0, (byte)execFuncTypeType, 0);
		}

		// Token: 0x0602DDD6 RID: 187862 RVA: 0x0064590C File Offset: 0x00643B0C
		public static void AddExecFuncType(FlatBufferBuilder builder, int execFuncTypeOffset)
		{
			builder.AddOffset(1, execFuncTypeOffset, 0);
		}

		// Token: 0x0602DDD7 RID: 187863 RVA: 0x00645917 File Offset: 0x00643B17
		public static Offset<IExecBpActorFunc> EndIExecBpActorFunc(FlatBufferBuilder builder)
		{
			return new Offset<IExecBpActorFunc>(builder.EndTable());
		}

		// Token: 0x0602DDD8 RID: 187864 RVA: 0x00645924 File Offset: 0x00643B24
		public IExecBpActorFuncT UnPack()
		{
			IExecBpActorFuncT execBpActorFuncT = new IExecBpActorFuncT();
			this.UnPackTo(execBpActorFuncT);
			return execBpActorFuncT;
		}

		// Token: 0x0602DDD9 RID: 187865 RVA: 0x00645940 File Offset: 0x00643B40
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

		// Token: 0x0602DDDA RID: 187866 RVA: 0x006459E4 File Offset: 0x00643BE4
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

		// Token: 0x04010DE0 RID: 69088
		private Table __p;
	}
}
