using System;
using Aki.UniverseEditor.Interface.Fbs.Component;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D7C RID: 19836
	public struct ICircuitConnectStraightAsset : IFlatbufferObject
	{
		// Token: 0x17008DE7 RID: 36327
		// (get) Token: 0x0601EBEB RID: 125931 RVA: 0x0044CB45 File Offset: 0x0044AD45
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EBEC RID: 125932 RVA: 0x0044CB52 File Offset: 0x0044AD52
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EBED RID: 125933 RVA: 0x0044CB5C File Offset: 0x0044AD5C
		public static ICircuitConnectStraightAsset GetRootAsICircuitConnectStraightAsset(ByteBuffer _bb)
		{
			return ICircuitConnectStraightAsset.GetRootAsICircuitConnectStraightAsset(_bb, default(ICircuitConnectStraightAsset));
		}

		// Token: 0x0601EBEE RID: 125934 RVA: 0x0044CB78 File Offset: 0x0044AD78
		public static ICircuitConnectStraightAsset GetRootAsICircuitConnectStraightAsset(ByteBuffer _bb, ICircuitConnectStraightAsset obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EBEF RID: 125935 RVA: 0x0044CB95 File Offset: 0x0044AD95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EBF0 RID: 125936 RVA: 0x0044CBA4 File Offset: 0x0044ADA4
		public ICircuitConnectStraightAsset __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008DE8 RID: 36328
		// (get) Token: 0x0601EBF1 RID: 125937 RVA: 0x0044CBB4 File Offset: 0x0044ADB4
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

		// Token: 0x0601EBF2 RID: 125938 RVA: 0x0044CBF0 File Offset: 0x0044ADF0
		public static Offset<ICircuitConnectStraightAsset> CreateICircuitConnectStraightAsset(FlatBufferBuilder builder, ECircuitConnectElementType Type = ECircuitConnectElementType.Straight)
		{
			builder.StartTable(1);
			ICircuitConnectStraightAsset.AddType(builder, Type);
			return ICircuitConnectStraightAsset.EndICircuitConnectStraightAsset(builder);
		}

		// Token: 0x0601EBF3 RID: 125939 RVA: 0x0044CC06 File Offset: 0x0044AE06
		public static void StartICircuitConnectStraightAsset(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601EBF4 RID: 125940 RVA: 0x0044CC0F File Offset: 0x0044AE0F
		public static void AddType(FlatBufferBuilder builder, ECircuitConnectElementType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EBF5 RID: 125941 RVA: 0x0044CC1A File Offset: 0x0044AE1A
		public static Offset<ICircuitConnectStraightAsset> EndICircuitConnectStraightAsset(FlatBufferBuilder builder)
		{
			return new Offset<ICircuitConnectStraightAsset>(builder.EndTable());
		}

		// Token: 0x0601EBF6 RID: 125942 RVA: 0x0044CC28 File Offset: 0x0044AE28
		public ICircuitConnectStraightAssetT UnPack()
		{
			ICircuitConnectStraightAssetT circuitConnectStraightAssetT = new ICircuitConnectStraightAssetT();
			this.UnPackTo(circuitConnectStraightAssetT);
			return circuitConnectStraightAssetT;
		}

		// Token: 0x0601EBF7 RID: 125943 RVA: 0x0044CC43 File Offset: 0x0044AE43
		public void UnPackTo(ICircuitConnectStraightAssetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601EBF8 RID: 125944 RVA: 0x0044CC54 File Offset: 0x0044AE54
		public static Offset<ICircuitConnectStraightAsset> Pack(FlatBufferBuilder builder, ICircuitConnectStraightAssetT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICircuitConnectStraightAsset>);
			}
			return ICircuitConnectStraightAsset.CreateICircuitConnectStraightAsset(builder, _o.Type);
		}

		// Token: 0x0400D9CD RID: 55757
		private Table __p;
	}
}
