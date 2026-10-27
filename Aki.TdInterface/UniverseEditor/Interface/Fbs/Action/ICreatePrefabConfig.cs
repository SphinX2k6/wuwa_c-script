using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064E6 RID: 25830
	public struct ICreatePrefabConfig : IFlatbufferObject
	{
		// Token: 0x1700C02B RID: 49195
		// (get) Token: 0x0602CCEF RID: 183535 RVA: 0x00628568 File Offset: 0x00626768
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CCF0 RID: 183536 RVA: 0x00628575 File Offset: 0x00626775
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CCF1 RID: 183537 RVA: 0x0062857C File Offset: 0x0062677C
		public static ICreatePrefabConfig GetRootAsICreatePrefabConfig(ByteBuffer _bb)
		{
			return ICreatePrefabConfig.GetRootAsICreatePrefabConfig(_bb, default(ICreatePrefabConfig));
		}

		// Token: 0x0602CCF2 RID: 183538 RVA: 0x00628598 File Offset: 0x00626798
		public static ICreatePrefabConfig GetRootAsICreatePrefabConfig(ByteBuffer _bb, ICreatePrefabConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CCF3 RID: 183539 RVA: 0x006285B5 File Offset: 0x006267B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CCF4 RID: 183540 RVA: 0x006285C4 File Offset: 0x006267C4
		public ICreatePrefabConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C02C RID: 49196
		// (get) Token: 0x0602CCF5 RID: 183541 RVA: 0x006285D4 File Offset: 0x006267D4
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

		// Token: 0x0602CCF6 RID: 183542 RVA: 0x00628610 File Offset: 0x00626810
		public static Offset<ICreatePrefabConfig> CreateICreatePrefabConfig(FlatBufferBuilder builder, ECreatePrefabType Type = ECreatePrefabType.PrefabId)
		{
			builder.StartTable(1);
			ICreatePrefabConfig.AddType(builder, Type);
			return ICreatePrefabConfig.EndICreatePrefabConfig(builder);
		}

		// Token: 0x0602CCF7 RID: 183543 RVA: 0x00628626 File Offset: 0x00626826
		public static void StartICreatePrefabConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602CCF8 RID: 183544 RVA: 0x0062862F File Offset: 0x0062682F
		public static void AddType(FlatBufferBuilder builder, ECreatePrefabType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CCF9 RID: 183545 RVA: 0x0062863A File Offset: 0x0062683A
		public static Offset<ICreatePrefabConfig> EndICreatePrefabConfig(FlatBufferBuilder builder)
		{
			return new Offset<ICreatePrefabConfig>(builder.EndTable());
		}

		// Token: 0x0602CCFA RID: 183546 RVA: 0x00628648 File Offset: 0x00626848
		public ICreatePrefabConfigT UnPack()
		{
			ICreatePrefabConfigT createPrefabConfigT = new ICreatePrefabConfigT();
			this.UnPackTo(createPrefabConfigT);
			return createPrefabConfigT;
		}

		// Token: 0x0602CCFB RID: 183547 RVA: 0x00628663 File Offset: 0x00626863
		public void UnPackTo(ICreatePrefabConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602CCFC RID: 183548 RVA: 0x00628674 File Offset: 0x00626874
		public static Offset<ICreatePrefabConfig> Pack(FlatBufferBuilder builder, ICreatePrefabConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICreatePrefabConfig>);
			}
			return ICreatePrefabConfig.CreateICreatePrefabConfig(builder, _o.Type);
		}

		// Token: 0x04010B24 RID: 68388
		private Table __p;
	}
}
