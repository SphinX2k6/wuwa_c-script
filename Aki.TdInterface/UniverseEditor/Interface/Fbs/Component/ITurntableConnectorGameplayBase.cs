using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006103 RID: 24835
	public struct ITurntableConnectorGameplayBase : IFlatbufferObject
	{
		// Token: 0x1700B8E8 RID: 47336
		// (get) Token: 0x0602A192 RID: 172434 RVA: 0x005BF16B File Offset: 0x005BD36B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A193 RID: 172435 RVA: 0x005BF178 File Offset: 0x005BD378
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A194 RID: 172436 RVA: 0x005BF180 File Offset: 0x005BD380
		public static ITurntableConnectorGameplayBase GetRootAsITurntableConnectorGameplayBase(ByteBuffer _bb)
		{
			return ITurntableConnectorGameplayBase.GetRootAsITurntableConnectorGameplayBase(_bb, default(ITurntableConnectorGameplayBase));
		}

		// Token: 0x0602A195 RID: 172437 RVA: 0x005BF19C File Offset: 0x005BD39C
		public static ITurntableConnectorGameplayBase GetRootAsITurntableConnectorGameplayBase(ByteBuffer _bb, ITurntableConnectorGameplayBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A196 RID: 172438 RVA: 0x005BF1B9 File Offset: 0x005BD3B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A197 RID: 172439 RVA: 0x005BF1C8 File Offset: 0x005BD3C8
		public ITurntableConnectorGameplayBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B8E9 RID: 47337
		// (get) Token: 0x0602A198 RID: 172440 RVA: 0x005BF1D8 File Offset: 0x005BD3D8
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

		// Token: 0x0602A199 RID: 172441 RVA: 0x005BF214 File Offset: 0x005BD414
		public static Offset<ITurntableConnectorGameplayBase> CreateITurntableConnectorGameplayBase(FlatBufferBuilder builder, ETurntableConnectorGameplayType Type = ETurntableConnectorGameplayType.CircuitConnect)
		{
			builder.StartTable(1);
			ITurntableConnectorGameplayBase.AddType(builder, Type);
			return ITurntableConnectorGameplayBase.EndITurntableConnectorGameplayBase(builder);
		}

		// Token: 0x0602A19A RID: 172442 RVA: 0x005BF22A File Offset: 0x005BD42A
		public static void StartITurntableConnectorGameplayBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602A19B RID: 172443 RVA: 0x005BF233 File Offset: 0x005BD433
		public static void AddType(FlatBufferBuilder builder, ETurntableConnectorGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A19C RID: 172444 RVA: 0x005BF23E File Offset: 0x005BD43E
		public static Offset<ITurntableConnectorGameplayBase> EndITurntableConnectorGameplayBase(FlatBufferBuilder builder)
		{
			return new Offset<ITurntableConnectorGameplayBase>(builder.EndTable());
		}

		// Token: 0x0602A19D RID: 172445 RVA: 0x005BF24C File Offset: 0x005BD44C
		public ITurntableConnectorGameplayBaseT UnPack()
		{
			ITurntableConnectorGameplayBaseT turntableConnectorGameplayBaseT = new ITurntableConnectorGameplayBaseT();
			this.UnPackTo(turntableConnectorGameplayBaseT);
			return turntableConnectorGameplayBaseT;
		}

		// Token: 0x0602A19E RID: 172446 RVA: 0x005BF267 File Offset: 0x005BD467
		public void UnPackTo(ITurntableConnectorGameplayBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602A19F RID: 172447 RVA: 0x005BF278 File Offset: 0x005BD478
		public static Offset<ITurntableConnectorGameplayBase> Pack(FlatBufferBuilder builder, ITurntableConnectorGameplayBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITurntableConnectorGameplayBase>);
			}
			return ITurntableConnectorGameplayBase.CreateITurntableConnectorGameplayBase(builder, _o.Type);
		}

		// Token: 0x0400FEEB RID: 65259
		private Table __p;
	}
}
