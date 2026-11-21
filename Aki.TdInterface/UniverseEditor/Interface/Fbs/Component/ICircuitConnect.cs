using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054D2 RID: 21714
	public struct ICircuitConnect : IFlatbufferObject
	{
		// Token: 0x17009B1F RID: 39711
		// (get) Token: 0x06022457 RID: 140375 RVA: 0x004B97D8 File Offset: 0x004B79D8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022458 RID: 140376 RVA: 0x004B97E5 File Offset: 0x004B79E5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022459 RID: 140377 RVA: 0x004B97EC File Offset: 0x004B79EC
		public static ICircuitConnect GetRootAsICircuitConnect(ByteBuffer _bb)
		{
			return ICircuitConnect.GetRootAsICircuitConnect(_bb, default(ICircuitConnect));
		}

		// Token: 0x0602245A RID: 140378 RVA: 0x004B9808 File Offset: 0x004B7A08
		public static ICircuitConnect GetRootAsICircuitConnect(ByteBuffer _bb, ICircuitConnect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602245B RID: 140379 RVA: 0x004B9825 File Offset: 0x004B7A25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602245C RID: 140380 RVA: 0x004B9834 File Offset: 0x004B7A34
		public ICircuitConnect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009B20 RID: 39712
		// (get) Token: 0x0602245D RID: 140381 RVA: 0x004B9844 File Offset: 0x004B7A44
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

		// Token: 0x17009B21 RID: 39713
		// (get) Token: 0x0602245E RID: 140382 RVA: 0x004B9880 File Offset: 0x004B7A80
		public int AssetConfigId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009B22 RID: 39714
		// (get) Token: 0x0602245F RID: 140383 RVA: 0x004B98BC File Offset: 0x004B7ABC
		public ICircuitConnectLevelData? LevelData
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new ICircuitConnectLevelData?(default(ICircuitConnectLevelData).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06022460 RID: 140384 RVA: 0x004B9919 File Offset: 0x004B7B19
		public static Offset<ICircuitConnect> CreateICircuitConnect(FlatBufferBuilder builder, ETurntableConnectorGameplayType Type = ETurntableConnectorGameplayType.CircuitConnect, int AssetConfigId = 0, Offset<ICircuitConnectLevelData> LevelDataOffset = default(Offset<ICircuitConnectLevelData>))
		{
			builder.StartTable(3);
			ICircuitConnect.AddLevelData(builder, LevelDataOffset);
			ICircuitConnect.AddAssetConfigId(builder, AssetConfigId);
			ICircuitConnect.AddType(builder, Type);
			return ICircuitConnect.EndICircuitConnect(builder);
		}

		// Token: 0x06022461 RID: 140385 RVA: 0x004B993D File Offset: 0x004B7B3D
		public static void StartICircuitConnect(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06022462 RID: 140386 RVA: 0x004B9946 File Offset: 0x004B7B46
		public static void AddType(FlatBufferBuilder builder, ETurntableConnectorGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022463 RID: 140387 RVA: 0x004B9951 File Offset: 0x004B7B51
		public static void AddAssetConfigId(FlatBufferBuilder builder, int assetConfigId)
		{
			builder.AddInt(1, assetConfigId, 0);
		}

		// Token: 0x06022464 RID: 140388 RVA: 0x004B995C File Offset: 0x004B7B5C
		public static void AddLevelData(FlatBufferBuilder builder, Offset<ICircuitConnectLevelData> levelDataOffset)
		{
			builder.AddOffset(2, levelDataOffset.Value, 0);
		}

		// Token: 0x06022465 RID: 140389 RVA: 0x004B996C File Offset: 0x004B7B6C
		public static Offset<ICircuitConnect> EndICircuitConnect(FlatBufferBuilder builder)
		{
			return new Offset<ICircuitConnect>(builder.EndTable());
		}

		// Token: 0x06022466 RID: 140390 RVA: 0x004B997C File Offset: 0x004B7B7C
		public ICircuitConnectT UnPack()
		{
			ICircuitConnectT circuitConnectT = new ICircuitConnectT();
			this.UnPackTo(circuitConnectT);
			return circuitConnectT;
		}

		// Token: 0x06022467 RID: 140391 RVA: 0x004B9998 File Offset: 0x004B7B98
		public void UnPackTo(ICircuitConnectT _o)
		{
			_o.Type = this.Type;
			_o.AssetConfigId = this.AssetConfigId;
			_o.LevelData = ((this.LevelData != null) ? this.LevelData.Value.UnPack() : null);
		}

		// Token: 0x06022468 RID: 140392 RVA: 0x004B99EC File Offset: 0x004B7BEC
		public static Offset<ICircuitConnect> Pack(FlatBufferBuilder builder, ICircuitConnectT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICircuitConnect>);
			}
			Offset<ICircuitConnectLevelData> levelDataOffset = (_o.LevelData == null) ? default(Offset<ICircuitConnectLevelData>) : ICircuitConnectLevelData.Pack(builder, _o.LevelData);
			return ICircuitConnect.CreateICircuitConnect(builder, _o.Type, _o.AssetConfigId, levelDataOffset);
		}

		// Token: 0x0400EA24 RID: 59940
		private Table __p;
	}
}
