using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C52 RID: 19538
	public struct IMonsterTagDeathEffectData : IFlatbufferObject
	{
		// Token: 0x17008A9A RID: 35482
		// (get) Token: 0x0601DF79 RID: 122745 RVA: 0x00433970 File Offset: 0x00431B70
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DF7A RID: 122746 RVA: 0x0043397D File Offset: 0x00431B7D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DF7B RID: 122747 RVA: 0x00433984 File Offset: 0x00431B84
		public static IMonsterTagDeathEffectData GetRootAsIMonsterTagDeathEffectData(ByteBuffer _bb)
		{
			return IMonsterTagDeathEffectData.GetRootAsIMonsterTagDeathEffectData(_bb, default(IMonsterTagDeathEffectData));
		}

		// Token: 0x0601DF7C RID: 122748 RVA: 0x004339A0 File Offset: 0x00431BA0
		public static IMonsterTagDeathEffectData GetRootAsIMonsterTagDeathEffectData(ByteBuffer _bb, IMonsterTagDeathEffectData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DF7D RID: 122749 RVA: 0x004339BD File Offset: 0x00431BBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DF7E RID: 122750 RVA: 0x004339CC File Offset: 0x00431BCC
		public IMonsterTagDeathEffectData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008A9B RID: 35483
		// (get) Token: 0x0601DF7F RID: 122751 RVA: 0x004339DC File Offset: 0x00431BDC
		public string Tag
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601DF80 RID: 122752 RVA: 0x00433A13 File Offset: 0x00431C13
		public Span<byte> GetTagBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601DF81 RID: 122753 RVA: 0x00433A22 File Offset: 0x00431C22
		public byte[] GetTagArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17008A9C RID: 35484
		// (get) Token: 0x0601DF82 RID: 122754 RVA: 0x00433A30 File Offset: 0x00431C30
		public IEffectConfigMonsterDeath? EffectConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IEffectConfigMonsterDeath?(default(IEffectConfigMonsterDeath).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601DF83 RID: 122755 RVA: 0x00433A8D File Offset: 0x00431C8D
		public static Offset<IMonsterTagDeathEffectData> CreateIMonsterTagDeathEffectData(FlatBufferBuilder builder, StringOffset TagOffset = default(StringOffset), Offset<IEffectConfigMonsterDeath> EffectConfigOffset = default(Offset<IEffectConfigMonsterDeath>))
		{
			builder.StartTable(2);
			IMonsterTagDeathEffectData.AddEffectConfig(builder, EffectConfigOffset);
			IMonsterTagDeathEffectData.AddTag(builder, TagOffset);
			return IMonsterTagDeathEffectData.EndIMonsterTagDeathEffectData(builder);
		}

		// Token: 0x0601DF84 RID: 122756 RVA: 0x00433AAA File Offset: 0x00431CAA
		public static void StartIMonsterTagDeathEffectData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601DF85 RID: 122757 RVA: 0x00433AB3 File Offset: 0x00431CB3
		public static void AddTag(FlatBufferBuilder builder, StringOffset tagOffset)
		{
			builder.AddOffset(0, tagOffset.Value, 0);
		}

		// Token: 0x0601DF86 RID: 122758 RVA: 0x00433AC3 File Offset: 0x00431CC3
		public static void AddEffectConfig(FlatBufferBuilder builder, Offset<IEffectConfigMonsterDeath> effectConfigOffset)
		{
			builder.AddOffset(1, effectConfigOffset.Value, 0);
		}

		// Token: 0x0601DF87 RID: 122759 RVA: 0x00433AD3 File Offset: 0x00431CD3
		public static Offset<IMonsterTagDeathEffectData> EndIMonsterTagDeathEffectData(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterTagDeathEffectData>(builder.EndTable());
		}

		// Token: 0x0601DF88 RID: 122760 RVA: 0x00433AE0 File Offset: 0x00431CE0
		public IMonsterTagDeathEffectDataT UnPack()
		{
			IMonsterTagDeathEffectDataT monsterTagDeathEffectDataT = new IMonsterTagDeathEffectDataT();
			this.UnPackTo(monsterTagDeathEffectDataT);
			return monsterTagDeathEffectDataT;
		}

		// Token: 0x0601DF89 RID: 122761 RVA: 0x00433AFC File Offset: 0x00431CFC
		public void UnPackTo(IMonsterTagDeathEffectDataT _o)
		{
			_o.Tag = this.Tag;
			_o.EffectConfig = ((this.EffectConfig != null) ? this.EffectConfig.Value.UnPack() : null);
		}

		// Token: 0x0601DF8A RID: 122762 RVA: 0x00433B44 File Offset: 0x00431D44
		public static Offset<IMonsterTagDeathEffectData> Pack(FlatBufferBuilder builder, IMonsterTagDeathEffectDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterTagDeathEffectData>);
			}
			StringOffset tagOffset = (_o.Tag == null) ? default(StringOffset) : builder.CreateString(_o.Tag);
			Offset<IEffectConfigMonsterDeath> effectConfigOffset = (_o.EffectConfig == null) ? default(Offset<IEffectConfigMonsterDeath>) : IEffectConfigMonsterDeath.Pack(builder, _o.EffectConfig);
			return IMonsterTagDeathEffectData.CreateIMonsterTagDeathEffectData(builder, tagOffset, effectConfigOffset);
		}

		// Token: 0x0400D6BC RID: 54972
		private Table __p;
	}
}
