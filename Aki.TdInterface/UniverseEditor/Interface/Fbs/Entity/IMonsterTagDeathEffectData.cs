using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047EA RID: 18410
	public struct IMonsterTagDeathEffectData : IFlatbufferObject
	{
		// Token: 0x1700844F RID: 33871
		// (get) Token: 0x0601C77C RID: 116604 RVA: 0x00407020 File Offset: 0x00405220
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C77D RID: 116605 RVA: 0x0040702D File Offset: 0x0040522D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C77E RID: 116606 RVA: 0x00407034 File Offset: 0x00405234
		public static IMonsterTagDeathEffectData GetRootAsIMonsterTagDeathEffectData(ByteBuffer _bb)
		{
			return IMonsterTagDeathEffectData.GetRootAsIMonsterTagDeathEffectData(_bb, default(IMonsterTagDeathEffectData));
		}

		// Token: 0x0601C77F RID: 116607 RVA: 0x00407050 File Offset: 0x00405250
		public static IMonsterTagDeathEffectData GetRootAsIMonsterTagDeathEffectData(ByteBuffer _bb, IMonsterTagDeathEffectData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C780 RID: 116608 RVA: 0x0040706D File Offset: 0x0040526D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C781 RID: 116609 RVA: 0x0040707C File Offset: 0x0040527C
		public IMonsterTagDeathEffectData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008450 RID: 33872
		// (get) Token: 0x0601C782 RID: 116610 RVA: 0x0040708C File Offset: 0x0040528C
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

		// Token: 0x0601C783 RID: 116611 RVA: 0x004070C3 File Offset: 0x004052C3
		public Span<byte> GetTagBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601C784 RID: 116612 RVA: 0x004070D2 File Offset: 0x004052D2
		public byte[] GetTagArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17008451 RID: 33873
		// (get) Token: 0x0601C785 RID: 116613 RVA: 0x004070E0 File Offset: 0x004052E0
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

		// Token: 0x0601C786 RID: 116614 RVA: 0x0040713D File Offset: 0x0040533D
		public static Offset<IMonsterTagDeathEffectData> CreateIMonsterTagDeathEffectData(FlatBufferBuilder builder, StringOffset TagOffset = default(StringOffset), Offset<IEffectConfigMonsterDeath> EffectConfigOffset = default(Offset<IEffectConfigMonsterDeath>))
		{
			builder.StartTable(2);
			IMonsterTagDeathEffectData.AddEffectConfig(builder, EffectConfigOffset);
			IMonsterTagDeathEffectData.AddTag(builder, TagOffset);
			return IMonsterTagDeathEffectData.EndIMonsterTagDeathEffectData(builder);
		}

		// Token: 0x0601C787 RID: 116615 RVA: 0x0040715A File Offset: 0x0040535A
		public static void StartIMonsterTagDeathEffectData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601C788 RID: 116616 RVA: 0x00407163 File Offset: 0x00405363
		public static void AddTag(FlatBufferBuilder builder, StringOffset tagOffset)
		{
			builder.AddOffset(0, tagOffset.Value, 0);
		}

		// Token: 0x0601C789 RID: 116617 RVA: 0x00407173 File Offset: 0x00405373
		public static void AddEffectConfig(FlatBufferBuilder builder, Offset<IEffectConfigMonsterDeath> effectConfigOffset)
		{
			builder.AddOffset(1, effectConfigOffset.Value, 0);
		}

		// Token: 0x0601C78A RID: 116618 RVA: 0x00407183 File Offset: 0x00405383
		public static Offset<IMonsterTagDeathEffectData> EndIMonsterTagDeathEffectData(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterTagDeathEffectData>(builder.EndTable());
		}

		// Token: 0x0601C78B RID: 116619 RVA: 0x00407190 File Offset: 0x00405390
		public IMonsterTagDeathEffectDataT UnPack()
		{
			IMonsterTagDeathEffectDataT monsterTagDeathEffectDataT = new IMonsterTagDeathEffectDataT();
			this.UnPackTo(monsterTagDeathEffectDataT);
			return monsterTagDeathEffectDataT;
		}

		// Token: 0x0601C78C RID: 116620 RVA: 0x004071AC File Offset: 0x004053AC
		public void UnPackTo(IMonsterTagDeathEffectDataT _o)
		{
			_o.Tag = this.Tag;
			_o.EffectConfig = ((this.EffectConfig != null) ? this.EffectConfig.Value.UnPack() : null);
		}

		// Token: 0x0601C78D RID: 116621 RVA: 0x004071F4 File Offset: 0x004053F4
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

		// Token: 0x0400CC81 RID: 52353
		private Table __p;
	}
}
