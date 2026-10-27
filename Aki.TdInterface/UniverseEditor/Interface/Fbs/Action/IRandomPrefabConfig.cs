using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E04 RID: 28164
	public struct IRandomPrefabConfig : IFlatbufferObject
	{
		// Token: 0x1700D1F6 RID: 53750
		// (get) Token: 0x06031C23 RID: 203811 RVA: 0x006BC95A File Offset: 0x006BAB5A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031C24 RID: 203812 RVA: 0x006BC967 File Offset: 0x006BAB67
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031C25 RID: 203813 RVA: 0x006BC970 File Offset: 0x006BAB70
		public static IRandomPrefabConfig GetRootAsIRandomPrefabConfig(ByteBuffer _bb)
		{
			return IRandomPrefabConfig.GetRootAsIRandomPrefabConfig(_bb, default(IRandomPrefabConfig));
		}

		// Token: 0x06031C26 RID: 203814 RVA: 0x006BC98C File Offset: 0x006BAB8C
		public static IRandomPrefabConfig GetRootAsIRandomPrefabConfig(ByteBuffer _bb, IRandomPrefabConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031C27 RID: 203815 RVA: 0x006BC9A9 File Offset: 0x006BABA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031C28 RID: 203816 RVA: 0x006BC9B8 File Offset: 0x006BABB8
		public IRandomPrefabConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D1F7 RID: 53751
		// (get) Token: 0x06031C29 RID: 203817 RVA: 0x006BC9C8 File Offset: 0x006BABC8
		public ECreatePrefabType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECreatePrefabType.PrefabId;
				}
				return (ECreatePrefabType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D1F8 RID: 53752
		// (get) Token: 0x06031C2A RID: 203818 RVA: 0x006BCA04 File Offset: 0x006BAC04
		public int RandomPrefabId
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

		// Token: 0x06031C2B RID: 203819 RVA: 0x006BCA40 File Offset: 0x006BAC40
		public static Offset<IRandomPrefabConfig> CreateIRandomPrefabConfig(FlatBufferBuilder builder, ECreatePrefabType Type = ECreatePrefabType.PrefabId, int RandomPrefabId = 0)
		{
			builder.StartTable(2);
			IRandomPrefabConfig.AddRandomPrefabId(builder, RandomPrefabId);
			IRandomPrefabConfig.AddType(builder, Type);
			return IRandomPrefabConfig.EndIRandomPrefabConfig(builder);
		}

		// Token: 0x06031C2C RID: 203820 RVA: 0x006BCA5D File Offset: 0x006BAC5D
		public static void StartIRandomPrefabConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031C2D RID: 203821 RVA: 0x006BCA66 File Offset: 0x006BAC66
		public static void AddType(FlatBufferBuilder builder, ECreatePrefabType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031C2E RID: 203822 RVA: 0x006BCA71 File Offset: 0x006BAC71
		public static void AddRandomPrefabId(FlatBufferBuilder builder, int randomPrefabId)
		{
			builder.AddInt(1, randomPrefabId, 0);
		}

		// Token: 0x06031C2F RID: 203823 RVA: 0x006BCA7C File Offset: 0x006BAC7C
		public static Offset<IRandomPrefabConfig> EndIRandomPrefabConfig(FlatBufferBuilder builder)
		{
			return new Offset<IRandomPrefabConfig>(builder.EndTable());
		}

		// Token: 0x06031C30 RID: 203824 RVA: 0x006BCA8C File Offset: 0x006BAC8C
		public IRandomPrefabConfigT UnPack()
		{
			IRandomPrefabConfigT randomPrefabConfigT = new IRandomPrefabConfigT();
			this.UnPackTo(randomPrefabConfigT);
			return randomPrefabConfigT;
		}

		// Token: 0x06031C31 RID: 203825 RVA: 0x006BCAA7 File Offset: 0x006BACA7
		public void UnPackTo(IRandomPrefabConfigT _o)
		{
			_o.Type = this.Type;
			_o.RandomPrefabId = this.RandomPrefabId;
		}

		// Token: 0x06031C32 RID: 203826 RVA: 0x006BCAC4 File Offset: 0x006BACC4
		public static Offset<IRandomPrefabConfig> Pack(FlatBufferBuilder builder, IRandomPrefabConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRandomPrefabConfig>);
			}
			return IRandomPrefabConfig.CreateIRandomPrefabConfig(builder, _o.Type, _o.RandomPrefabId);
		}

		// Token: 0x040117EA RID: 71658
		private Table __p;
	}
}
