using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054AE RID: 21678
	public struct ICharacterConnectorLogicType : IFlatbufferObject
	{
		// Token: 0x17009A8E RID: 39566
		// (get) Token: 0x0602223B RID: 139835 RVA: 0x004B4A53 File Offset: 0x004B2C53
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602223C RID: 139836 RVA: 0x004B4A60 File Offset: 0x004B2C60
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602223D RID: 139837 RVA: 0x004B4A68 File Offset: 0x004B2C68
		public static ICharacterConnectorLogicType GetRootAsICharacterConnectorLogicType(ByteBuffer _bb)
		{
			return ICharacterConnectorLogicType.GetRootAsICharacterConnectorLogicType(_bb, default(ICharacterConnectorLogicType));
		}

		// Token: 0x0602223E RID: 139838 RVA: 0x004B4A84 File Offset: 0x004B2C84
		public static ICharacterConnectorLogicType GetRootAsICharacterConnectorLogicType(ByteBuffer _bb, ICharacterConnectorLogicType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602223F RID: 139839 RVA: 0x004B4AA1 File Offset: 0x004B2CA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022240 RID: 139840 RVA: 0x004B4AB0 File Offset: 0x004B2CB0
		public ICharacterConnectorLogicType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009A8F RID: 39567
		// (get) Token: 0x06022241 RID: 139841 RVA: 0x004B4AC0 File Offset: 0x004B2CC0
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

		// Token: 0x17009A90 RID: 39568
		// (get) Token: 0x06022242 RID: 139842 RVA: 0x004B4AFC File Offset: 0x004B2CFC
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

		// Token: 0x06022243 RID: 139843 RVA: 0x004B4B59 File Offset: 0x004B2D59
		public static Offset<ICharacterConnectorLogicType> CreateICharacterConnectorLogicType(FlatBufferBuilder builder, ECharacterConnectorLogicType Type = ECharacterConnectorLogicType.Range, Offset<IConnectorEffectConfig> EffectConfigOffset = default(Offset<IConnectorEffectConfig>))
		{
			builder.StartTable(2);
			ICharacterConnectorLogicType.AddEffectConfig(builder, EffectConfigOffset);
			ICharacterConnectorLogicType.AddType(builder, Type);
			return ICharacterConnectorLogicType.EndICharacterConnectorLogicType(builder);
		}

		// Token: 0x06022244 RID: 139844 RVA: 0x004B4B76 File Offset: 0x004B2D76
		public static void StartICharacterConnectorLogicType(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06022245 RID: 139845 RVA: 0x004B4B7F File Offset: 0x004B2D7F
		public static void AddType(FlatBufferBuilder builder, ECharacterConnectorLogicType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022246 RID: 139846 RVA: 0x004B4B8A File Offset: 0x004B2D8A
		public static void AddEffectConfig(FlatBufferBuilder builder, Offset<IConnectorEffectConfig> effectConfigOffset)
		{
			builder.AddOffset(1, effectConfigOffset.Value, 0);
		}

		// Token: 0x06022247 RID: 139847 RVA: 0x004B4B9A File Offset: 0x004B2D9A
		public static Offset<ICharacterConnectorLogicType> EndICharacterConnectorLogicType(FlatBufferBuilder builder)
		{
			return new Offset<ICharacterConnectorLogicType>(builder.EndTable());
		}

		// Token: 0x06022248 RID: 139848 RVA: 0x004B4BA8 File Offset: 0x004B2DA8
		public ICharacterConnectorLogicTypeT UnPack()
		{
			ICharacterConnectorLogicTypeT characterConnectorLogicTypeT = new ICharacterConnectorLogicTypeT();
			this.UnPackTo(characterConnectorLogicTypeT);
			return characterConnectorLogicTypeT;
		}

		// Token: 0x06022249 RID: 139849 RVA: 0x004B4BC4 File Offset: 0x004B2DC4
		public void UnPackTo(ICharacterConnectorLogicTypeT _o)
		{
			_o.Type = this.Type;
			_o.EffectConfig = ((this.EffectConfig != null) ? this.EffectConfig.Value.UnPack() : null);
		}

		// Token: 0x0602224A RID: 139850 RVA: 0x004B4C0C File Offset: 0x004B2E0C
		public static Offset<ICharacterConnectorLogicType> Pack(FlatBufferBuilder builder, ICharacterConnectorLogicTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICharacterConnectorLogicType>);
			}
			Offset<IConnectorEffectConfig> effectConfigOffset = (_o.EffectConfig == null) ? default(Offset<IConnectorEffectConfig>) : IConnectorEffectConfig.Pack(builder, _o.EffectConfig);
			return ICharacterConnectorLogicType.CreateICharacterConnectorLogicType(builder, _o.Type, effectConfigOffset);
		}

		// Token: 0x0400E9D1 RID: 59857
		private Table __p;
	}
}
