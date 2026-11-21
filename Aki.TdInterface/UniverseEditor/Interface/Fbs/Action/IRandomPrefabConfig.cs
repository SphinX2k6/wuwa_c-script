using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200757F RID: 30079
	public struct IRandomPrefabConfig : IFlatbufferObject
	{
		// Token: 0x1700DD3E RID: 56638
		// (get) Token: 0x06034C1F RID: 216095 RVA: 0x00718042 File Offset: 0x00716242
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034C20 RID: 216096 RVA: 0x0071804F File Offset: 0x0071624F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034C21 RID: 216097 RVA: 0x00718058 File Offset: 0x00716258
		public static IRandomPrefabConfig GetRootAsIRandomPrefabConfig(ByteBuffer _bb)
		{
			return IRandomPrefabConfig.GetRootAsIRandomPrefabConfig(_bb, default(IRandomPrefabConfig));
		}

		// Token: 0x06034C22 RID: 216098 RVA: 0x00718074 File Offset: 0x00716274
		public static IRandomPrefabConfig GetRootAsIRandomPrefabConfig(ByteBuffer _bb, IRandomPrefabConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034C23 RID: 216099 RVA: 0x00718091 File Offset: 0x00716291
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034C24 RID: 216100 RVA: 0x007180A0 File Offset: 0x007162A0
		public IRandomPrefabConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DD3F RID: 56639
		// (get) Token: 0x06034C25 RID: 216101 RVA: 0x007180B0 File Offset: 0x007162B0
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

		// Token: 0x1700DD40 RID: 56640
		// (get) Token: 0x06034C26 RID: 216102 RVA: 0x007180EC File Offset: 0x007162EC
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

		// Token: 0x06034C27 RID: 216103 RVA: 0x00718128 File Offset: 0x00716328
		public static Offset<IRandomPrefabConfig> CreateIRandomPrefabConfig(FlatBufferBuilder builder, ECreatePrefabType Type = ECreatePrefabType.PrefabId, int RandomPrefabId = 0)
		{
			builder.StartTable(2);
			IRandomPrefabConfig.AddRandomPrefabId(builder, RandomPrefabId);
			IRandomPrefabConfig.AddType(builder, Type);
			return IRandomPrefabConfig.EndIRandomPrefabConfig(builder);
		}

		// Token: 0x06034C28 RID: 216104 RVA: 0x00718145 File Offset: 0x00716345
		public static void StartIRandomPrefabConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06034C29 RID: 216105 RVA: 0x0071814E File Offset: 0x0071634E
		public static void AddType(FlatBufferBuilder builder, ECreatePrefabType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034C2A RID: 216106 RVA: 0x00718159 File Offset: 0x00716359
		public static void AddRandomPrefabId(FlatBufferBuilder builder, int randomPrefabId)
		{
			builder.AddInt(1, randomPrefabId, 0);
		}

		// Token: 0x06034C2B RID: 216107 RVA: 0x00718164 File Offset: 0x00716364
		public static Offset<IRandomPrefabConfig> EndIRandomPrefabConfig(FlatBufferBuilder builder)
		{
			return new Offset<IRandomPrefabConfig>(builder.EndTable());
		}

		// Token: 0x06034C2C RID: 216108 RVA: 0x00718174 File Offset: 0x00716374
		public IRandomPrefabConfigT UnPack()
		{
			IRandomPrefabConfigT randomPrefabConfigT = new IRandomPrefabConfigT();
			this.UnPackTo(randomPrefabConfigT);
			return randomPrefabConfigT;
		}

		// Token: 0x06034C2D RID: 216109 RVA: 0x0071818F File Offset: 0x0071638F
		public void UnPackTo(IRandomPrefabConfigT _o)
		{
			_o.Type = this.Type;
			_o.RandomPrefabId = this.RandomPrefabId;
		}

		// Token: 0x06034C2E RID: 216110 RVA: 0x007181AC File Offset: 0x007163AC
		public static Offset<IRandomPrefabConfig> Pack(FlatBufferBuilder builder, IRandomPrefabConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRandomPrefabConfig>);
			}
			return IRandomPrefabConfig.CreateIRandomPrefabConfig(builder, _o.Type, _o.RandomPrefabId);
		}

		// Token: 0x04012766 RID: 75622
		private Table __p;
	}
}
