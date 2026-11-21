using System;
using Aki.UniverseEditor.Interface.Fbs.Component;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D67 RID: 19815
	public struct ICircuitConnectAssetBase : IFlatbufferObject
	{
		// Token: 0x17008DCD RID: 36301
		// (get) Token: 0x0601EB53 RID: 125779 RVA: 0x0044BB04 File Offset: 0x00449D04
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EB54 RID: 125780 RVA: 0x0044BB11 File Offset: 0x00449D11
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EB55 RID: 125781 RVA: 0x0044BB18 File Offset: 0x00449D18
		public static ICircuitConnectAssetBase GetRootAsICircuitConnectAssetBase(ByteBuffer _bb)
		{
			return ICircuitConnectAssetBase.GetRootAsICircuitConnectAssetBase(_bb, default(ICircuitConnectAssetBase));
		}

		// Token: 0x0601EB56 RID: 125782 RVA: 0x0044BB34 File Offset: 0x00449D34
		public static ICircuitConnectAssetBase GetRootAsICircuitConnectAssetBase(ByteBuffer _bb, ICircuitConnectAssetBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EB57 RID: 125783 RVA: 0x0044BB51 File Offset: 0x00449D51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EB58 RID: 125784 RVA: 0x0044BB60 File Offset: 0x00449D60
		public ICircuitConnectAssetBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008DCE RID: 36302
		// (get) Token: 0x0601EB59 RID: 125785 RVA: 0x0044BB70 File Offset: 0x00449D70
		public ECircuitConnectElementType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECircuitConnectElementType.Straight;
				}
				return (ECircuitConnectElementType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601EB5A RID: 125786 RVA: 0x0044BBAC File Offset: 0x00449DAC
		public static Offset<ICircuitConnectAssetBase> CreateICircuitConnectAssetBase(FlatBufferBuilder builder, ECircuitConnectElementType Type = ECircuitConnectElementType.Straight)
		{
			builder.StartTable(1);
			ICircuitConnectAssetBase.AddType(builder, Type);
			return ICircuitConnectAssetBase.EndICircuitConnectAssetBase(builder);
		}

		// Token: 0x0601EB5B RID: 125787 RVA: 0x0044BBC2 File Offset: 0x00449DC2
		public static void StartICircuitConnectAssetBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601EB5C RID: 125788 RVA: 0x0044BBCB File Offset: 0x00449DCB
		public static void AddType(FlatBufferBuilder builder, ECircuitConnectElementType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EB5D RID: 125789 RVA: 0x0044BBD6 File Offset: 0x00449DD6
		public static Offset<ICircuitConnectAssetBase> EndICircuitConnectAssetBase(FlatBufferBuilder builder)
		{
			return new Offset<ICircuitConnectAssetBase>(builder.EndTable());
		}

		// Token: 0x0601EB5E RID: 125790 RVA: 0x0044BBE4 File Offset: 0x00449DE4
		public ICircuitConnectAssetBaseT UnPack()
		{
			ICircuitConnectAssetBaseT circuitConnectAssetBaseT = new ICircuitConnectAssetBaseT();
			this.UnPackTo(circuitConnectAssetBaseT);
			return circuitConnectAssetBaseT;
		}

		// Token: 0x0601EB5F RID: 125791 RVA: 0x0044BBFF File Offset: 0x00449DFF
		public void UnPackTo(ICircuitConnectAssetBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601EB60 RID: 125792 RVA: 0x0044BC10 File Offset: 0x00449E10
		public static Offset<ICircuitConnectAssetBase> Pack(FlatBufferBuilder builder, ICircuitConnectAssetBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICircuitConnectAssetBase>);
			}
			return ICircuitConnectAssetBase.CreateICircuitConnectAssetBase(builder, _o.Type);
		}

		// Token: 0x0400D9B5 RID: 55733
		private Table __p;
	}
}
