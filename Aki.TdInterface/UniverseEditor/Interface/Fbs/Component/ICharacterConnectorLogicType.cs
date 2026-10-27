using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F7F RID: 20351
	public struct ICharacterConnectorLogicType : IFlatbufferObject
	{
		// Token: 0x17009315 RID: 37653
		// (get) Token: 0x060204E9 RID: 132329 RVA: 0x0047EA63 File Offset: 0x0047CC63
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060204EA RID: 132330 RVA: 0x0047EA70 File Offset: 0x0047CC70
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060204EB RID: 132331 RVA: 0x0047EA78 File Offset: 0x0047CC78
		public static ICharacterConnectorLogicType GetRootAsICharacterConnectorLogicType(ByteBuffer _bb)
		{
			return ICharacterConnectorLogicType.GetRootAsICharacterConnectorLogicType(_bb, default(ICharacterConnectorLogicType));
		}

		// Token: 0x060204EC RID: 132332 RVA: 0x0047EA94 File Offset: 0x0047CC94
		public static ICharacterConnectorLogicType GetRootAsICharacterConnectorLogicType(ByteBuffer _bb, ICharacterConnectorLogicType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060204ED RID: 132333 RVA: 0x0047EAB1 File Offset: 0x0047CCB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060204EE RID: 132334 RVA: 0x0047EAC0 File Offset: 0x0047CCC0
		public ICharacterConnectorLogicType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009316 RID: 37654
		// (get) Token: 0x060204EF RID: 132335 RVA: 0x0047EAD0 File Offset: 0x0047CCD0
		public ECharacterConnectorLogicType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECharacterConnectorLogicType.Range;
				}
				return (ECharacterConnectorLogicType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009317 RID: 37655
		// (get) Token: 0x060204F0 RID: 132336 RVA: 0x0047EB0C File Offset: 0x0047CD0C
		public IConnectorEffectConfig? EffectConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConnectorEffectConfig?(default(IConnectorEffectConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060204F1 RID: 132337 RVA: 0x0047EB69 File Offset: 0x0047CD69
		public static Offset<ICharacterConnectorLogicType> CreateICharacterConnectorLogicType(FlatBufferBuilder builder, ECharacterConnectorLogicType Type = ECharacterConnectorLogicType.Range, Offset<IConnectorEffectConfig> EffectConfigOffset = default(Offset<IConnectorEffectConfig>))
		{
			builder.StartTable(2);
			ICharacterConnectorLogicType.AddEffectConfig(builder, EffectConfigOffset);
			ICharacterConnectorLogicType.AddType(builder, Type);
			return ICharacterConnectorLogicType.EndICharacterConnectorLogicType(builder);
		}

		// Token: 0x060204F2 RID: 132338 RVA: 0x0047EB86 File Offset: 0x0047CD86
		public static void StartICharacterConnectorLogicType(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060204F3 RID: 132339 RVA: 0x0047EB8F File Offset: 0x0047CD8F
		public static void AddType(FlatBufferBuilder builder, ECharacterConnectorLogicType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060204F4 RID: 132340 RVA: 0x0047EB9A File Offset: 0x0047CD9A
		public static void AddEffectConfig(FlatBufferBuilder builder, Offset<IConnectorEffectConfig> effectConfigOffset)
		{
			builder.AddOffset(1, effectConfigOffset.Value, 0);
		}

		// Token: 0x060204F5 RID: 132341 RVA: 0x0047EBAA File Offset: 0x0047CDAA
		public static Offset<ICharacterConnectorLogicType> EndICharacterConnectorLogicType(FlatBufferBuilder builder)
		{
			return new Offset<ICharacterConnectorLogicType>(builder.EndTable());
		}

		// Token: 0x060204F6 RID: 132342 RVA: 0x0047EBB8 File Offset: 0x0047CDB8
		public ICharacterConnectorLogicTypeT UnPack()
		{
			ICharacterConnectorLogicTypeT characterConnectorLogicTypeT = new ICharacterConnectorLogicTypeT();
			this.UnPackTo(characterConnectorLogicTypeT);
			return characterConnectorLogicTypeT;
		}

		// Token: 0x060204F7 RID: 132343 RVA: 0x0047EBD4 File Offset: 0x0047CDD4
		public void UnPackTo(ICharacterConnectorLogicTypeT _o)
		{
			_o.Type = this.Type;
			_o.EffectConfig = ((this.EffectConfig != null) ? this.EffectConfig.Value.UnPack() : null);
		}

		// Token: 0x060204F8 RID: 132344 RVA: 0x0047EC1C File Offset: 0x0047CE1C
		public static Offset<ICharacterConnectorLogicType> Pack(FlatBufferBuilder builder, ICharacterConnectorLogicTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICharacterConnectorLogicType>);
			}
			Offset<IConnectorEffectConfig> effectConfigOffset = (_o.EffectConfig == null) ? default(Offset<IConnectorEffectConfig>) : IConnectorEffectConfig.Pack(builder, _o.EffectConfig);
			return ICharacterConnectorLogicType.CreateICharacterConnectorLogicType(builder, _o.Type, effectConfigOffset);
		}

		// Token: 0x0400DE27 RID: 56871
		private Table __p;
	}
}
