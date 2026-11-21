using System;
using Aki.UniverseEditor.Interface.Fbs.Component;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D76 RID: 19830
	public struct ICircuitConnectOutputPortAsset : IFlatbufferObject
	{
		// Token: 0x17008DE1 RID: 36321
		// (get) Token: 0x0601EBC7 RID: 125895 RVA: 0x0044C856 File Offset: 0x0044AA56
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EBC8 RID: 125896 RVA: 0x0044C863 File Offset: 0x0044AA63
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EBC9 RID: 125897 RVA: 0x0044C86C File Offset: 0x0044AA6C
		public static ICircuitConnectOutputPortAsset GetRootAsICircuitConnectOutputPortAsset(ByteBuffer _bb)
		{
			return ICircuitConnectOutputPortAsset.GetRootAsICircuitConnectOutputPortAsset(_bb, default(ICircuitConnectOutputPortAsset));
		}

		// Token: 0x0601EBCA RID: 125898 RVA: 0x0044C888 File Offset: 0x0044AA88
		public static ICircuitConnectOutputPortAsset GetRootAsICircuitConnectOutputPortAsset(ByteBuffer _bb, ICircuitConnectOutputPortAsset obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EBCB RID: 125899 RVA: 0x0044C8A5 File Offset: 0x0044AAA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EBCC RID: 125900 RVA: 0x0044C8B4 File Offset: 0x0044AAB4
		public ICircuitConnectOutputPortAsset __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008DE2 RID: 36322
		// (get) Token: 0x0601EBCD RID: 125901 RVA: 0x0044C8C4 File Offset: 0x0044AAC4
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

		// Token: 0x0601EBCE RID: 125902 RVA: 0x0044C900 File Offset: 0x0044AB00
		public static Offset<ICircuitConnectOutputPortAsset> CreateICircuitConnectOutputPortAsset(FlatBufferBuilder builder, ECircuitConnectElementType Type = ECircuitConnectElementType.Straight)
		{
			builder.StartTable(1);
			ICircuitConnectOutputPortAsset.AddType(builder, Type);
			return ICircuitConnectOutputPortAsset.EndICircuitConnectOutputPortAsset(builder);
		}

		// Token: 0x0601EBCF RID: 125903 RVA: 0x0044C916 File Offset: 0x0044AB16
		public static void StartICircuitConnectOutputPortAsset(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601EBD0 RID: 125904 RVA: 0x0044C91F File Offset: 0x0044AB1F
		public static void AddType(FlatBufferBuilder builder, ECircuitConnectElementType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EBD1 RID: 125905 RVA: 0x0044C92A File Offset: 0x0044AB2A
		public static Offset<ICircuitConnectOutputPortAsset> EndICircuitConnectOutputPortAsset(FlatBufferBuilder builder)
		{
			return new Offset<ICircuitConnectOutputPortAsset>(builder.EndTable());
		}

		// Token: 0x0601EBD2 RID: 125906 RVA: 0x0044C938 File Offset: 0x0044AB38
		public ICircuitConnectOutputPortAssetT UnPack()
		{
			ICircuitConnectOutputPortAssetT circuitConnectOutputPortAssetT = new ICircuitConnectOutputPortAssetT();
			this.UnPackTo(circuitConnectOutputPortAssetT);
			return circuitConnectOutputPortAssetT;
		}

		// Token: 0x0601EBD3 RID: 125907 RVA: 0x0044C953 File Offset: 0x0044AB53
		public void UnPackTo(ICircuitConnectOutputPortAssetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601EBD4 RID: 125908 RVA: 0x0044C964 File Offset: 0x0044AB64
		public static Offset<ICircuitConnectOutputPortAsset> Pack(FlatBufferBuilder builder, ICircuitConnectOutputPortAssetT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICircuitConnectOutputPortAsset>);
			}
			return ICircuitConnectOutputPortAsset.CreateICircuitConnectOutputPortAsset(builder, _o.Type);
		}

		// Token: 0x0400D9C9 RID: 55753
		private Table __p;
	}
}
