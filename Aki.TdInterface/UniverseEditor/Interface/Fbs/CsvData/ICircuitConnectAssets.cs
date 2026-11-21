using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D70 RID: 19824
	public struct ICircuitConnectAssets : IFlatbufferObject
	{
		// Token: 0x17008DD7 RID: 36311
		// (get) Token: 0x0601EB95 RID: 125845 RVA: 0x0044C2AC File Offset: 0x0044A4AC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EB96 RID: 125846 RVA: 0x0044C2B9 File Offset: 0x0044A4B9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EB97 RID: 125847 RVA: 0x0044C2C0 File Offset: 0x0044A4C0
		public static ICircuitConnectAssets GetRootAsICircuitConnectAssets(ByteBuffer _bb)
		{
			return ICircuitConnectAssets.GetRootAsICircuitConnectAssets(_bb, default(ICircuitConnectAssets));
		}

		// Token: 0x0601EB98 RID: 125848 RVA: 0x0044C2DC File Offset: 0x0044A4DC
		public static ICircuitConnectAssets GetRootAsICircuitConnectAssets(ByteBuffer _bb, ICircuitConnectAssets obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EB99 RID: 125849 RVA: 0x0044C2F9 File Offset: 0x0044A4F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EB9A RID: 125850 RVA: 0x0044C308 File Offset: 0x0044A508
		public ICircuitConnectAssets __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008DD8 RID: 36312
		// (get) Token: 0x0601EB9B RID: 125851 RVA: 0x0044C318 File Offset: 0x0044A518
		public ETurntableConnectorGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETurntableConnectorGameplayType.CircuitConnect;
				}
				return (ETurntableConnectorGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601EB9C RID: 125852 RVA: 0x0044C354 File Offset: 0x0044A554
		public ICircuitConnectAssetConfig? Assets(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ICircuitConnectAssetConfig?(default(ICircuitConnectAssetConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008DD9 RID: 36313
		// (get) Token: 0x0601EB9D RID: 125853 RVA: 0x0044C3B4 File Offset: 0x0044A5B4
		public int AssetsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601EB9E RID: 125854 RVA: 0x0044C3DF File Offset: 0x0044A5DF
		public static Offset<ICircuitConnectAssets> CreateICircuitConnectAssets(FlatBufferBuilder builder, ETurntableConnectorGameplayType Type = ETurntableConnectorGameplayType.CircuitConnect, VectorOffset AssetsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ICircuitConnectAssets.AddAssets(builder, AssetsOffset);
			ICircuitConnectAssets.AddType(builder, Type);
			return ICircuitConnectAssets.EndICircuitConnectAssets(builder);
		}

		// Token: 0x0601EB9F RID: 125855 RVA: 0x0044C3FC File Offset: 0x0044A5FC
		public static void StartICircuitConnectAssets(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601EBA0 RID: 125856 RVA: 0x0044C405 File Offset: 0x0044A605
		public static void AddType(FlatBufferBuilder builder, ETurntableConnectorGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EBA1 RID: 125857 RVA: 0x0044C410 File Offset: 0x0044A610
		public static void AddAssets(FlatBufferBuilder builder, VectorOffset assetsOffset)
		{
			builder.AddOffset(1, assetsOffset.Value, 0);
		}

		// Token: 0x0601EBA2 RID: 125858 RVA: 0x0044C420 File Offset: 0x0044A620
		public static VectorOffset CreateAssetsVector(FlatBufferBuilder builder, Offset<ICircuitConnectAssetConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601EBA3 RID: 125859 RVA: 0x0044C460 File Offset: 0x0044A660
		public static VectorOffset CreateAssetsVectorBlock(FlatBufferBuilder builder, Offset<ICircuitConnectAssetConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICircuitConnectAssetConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601EBA4 RID: 125860 RVA: 0x0044C47A File Offset: 0x0044A67A
		public static VectorOffset CreateAssetsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICircuitConnectAssetConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICircuitConnectAssetConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601EBA5 RID: 125861 RVA: 0x0044C498 File Offset: 0x0044A698
		public static VectorOffset CreateAssetsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICircuitConnectAssetConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601EBA6 RID: 125862 RVA: 0x0044C4B1 File Offset: 0x0044A6B1
		public static void StartAssetsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601EBA7 RID: 125863 RVA: 0x0044C4BC File Offset: 0x0044A6BC
		public static Offset<ICircuitConnectAssets> EndICircuitConnectAssets(FlatBufferBuilder builder)
		{
			return new Offset<ICircuitConnectAssets>(builder.EndTable());
		}

		// Token: 0x0601EBA8 RID: 125864 RVA: 0x0044C4CC File Offset: 0x0044A6CC
		public ICircuitConnectAssetsT UnPack()
		{
			ICircuitConnectAssetsT circuitConnectAssetsT = new ICircuitConnectAssetsT();
			this.UnPackTo(circuitConnectAssetsT);
			return circuitConnectAssetsT;
		}

		// Token: 0x0601EBA9 RID: 125865 RVA: 0x0044C4E8 File Offset: 0x0044A6E8
		public void UnPackTo(ICircuitConnectAssetsT _o)
		{
			_o.Type = this.Type;
			_o.Assets = new List<ICircuitConnectAssetConfigT>();
			for (int i = 0; i < this.AssetsLength; i++)
			{
				_o.Assets.Add((this.Assets(i) != null) ? this.Assets(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601EBAA RID: 125866 RVA: 0x0044C554 File Offset: 0x0044A754
		public static Offset<ICircuitConnectAssets> Pack(FlatBufferBuilder builder, ICircuitConnectAssetsT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICircuitConnectAssets>);
			}
			VectorOffset assetsOffset = default(VectorOffset);
			if (_o.Assets != null)
			{
				Offset<ICircuitConnectAssetConfig>[] array = new Offset<ICircuitConnectAssetConfig>[_o.Assets.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ICircuitConnectAssetConfig.Pack(builder, _o.Assets[i]);
				}
				assetsOffset = ICircuitConnectAssets.CreateAssetsVector(builder, array);
			}
			return ICircuitConnectAssets.CreateICircuitConnectAssets(builder, _o.Type, assetsOffset);
		}

		// Token: 0x0400D9C3 RID: 55747
		private Table __p;
	}
}
