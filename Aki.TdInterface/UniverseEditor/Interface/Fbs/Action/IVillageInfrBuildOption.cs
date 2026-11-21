using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D34 RID: 32052
	public struct IVillageInfrBuildOption : IFlatbufferObject
	{
		// Token: 0x1700EFE9 RID: 61417
		// (get) Token: 0x06039DD4 RID: 237012 RVA: 0x007CE7A8 File Offset: 0x007CC9A8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039DD5 RID: 237013 RVA: 0x007CE7B5 File Offset: 0x007CC9B5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039DD6 RID: 237014 RVA: 0x007CE7BC File Offset: 0x007CC9BC
		public static IVillageInfrBuildOption GetRootAsIVillageInfrBuildOption(ByteBuffer _bb)
		{
			return IVillageInfrBuildOption.GetRootAsIVillageInfrBuildOption(_bb, default(IVillageInfrBuildOption));
		}

		// Token: 0x06039DD7 RID: 237015 RVA: 0x007CE7D8 File Offset: 0x007CC9D8
		public static IVillageInfrBuildOption GetRootAsIVillageInfrBuildOption(ByteBuffer _bb, IVillageInfrBuildOption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039DD8 RID: 237016 RVA: 0x007CE7F5 File Offset: 0x007CC9F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039DD9 RID: 237017 RVA: 0x007CE804 File Offset: 0x007CCA04
		public IVillageInfrBuildOption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EFEA RID: 61418
		// (get) Token: 0x06039DDA RID: 237018 RVA: 0x007CE814 File Offset: 0x007CCA14
		public EVillageInfrBuildType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVillageInfrBuildType.Village;
				}
				return (EVillageInfrBuildType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06039DDB RID: 237019 RVA: 0x007CE850 File Offset: 0x007CCA50
		public static Offset<IVillageInfrBuildOption> CreateIVillageInfrBuildOption(FlatBufferBuilder builder, EVillageInfrBuildType Type = EVillageInfrBuildType.Village)
		{
			builder.StartTable(1);
			IVillageInfrBuildOption.AddType(builder, Type);
			return IVillageInfrBuildOption.EndIVillageInfrBuildOption(builder);
		}

		// Token: 0x06039DDC RID: 237020 RVA: 0x007CE866 File Offset: 0x007CCA66
		public static void StartIVillageInfrBuildOption(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06039DDD RID: 237021 RVA: 0x007CE86F File Offset: 0x007CCA6F
		public static void AddType(FlatBufferBuilder builder, EVillageInfrBuildType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039DDE RID: 237022 RVA: 0x007CE87A File Offset: 0x007CCA7A
		public static Offset<IVillageInfrBuildOption> EndIVillageInfrBuildOption(FlatBufferBuilder builder)
		{
			return new Offset<IVillageInfrBuildOption>(builder.EndTable());
		}

		// Token: 0x06039DDF RID: 237023 RVA: 0x007CE888 File Offset: 0x007CCA88
		public IVillageInfrBuildOptionT UnPack()
		{
			IVillageInfrBuildOptionT villageInfrBuildOptionT = new IVillageInfrBuildOptionT();
			this.UnPackTo(villageInfrBuildOptionT);
			return villageInfrBuildOptionT;
		}

		// Token: 0x06039DE0 RID: 237024 RVA: 0x007CE8A3 File Offset: 0x007CCAA3
		public void UnPackTo(IVillageInfrBuildOptionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06039DE1 RID: 237025 RVA: 0x007CE8B4 File Offset: 0x007CCAB4
		public static Offset<IVillageInfrBuildOption> Pack(FlatBufferBuilder builder, IVillageInfrBuildOptionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVillageInfrBuildOption>);
			}
			return IVillageInfrBuildOption.CreateIVillageInfrBuildOption(builder, _o.Type);
		}

		// Token: 0x04013462 RID: 78946
		private Table __p;
	}
}
