using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005019 RID: 20505
	public struct ICheckSubLevelStateConfig : IFlatbufferObject
	{
		// Token: 0x170092B7 RID: 37559
		// (get) Token: 0x06020031 RID: 131121 RVA: 0x0047131B File Offset: 0x0046F51B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020032 RID: 131122 RVA: 0x00471328 File Offset: 0x0046F528
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020033 RID: 131123 RVA: 0x00471330 File Offset: 0x0046F530
		public static ICheckSubLevelStateConfig GetRootAsICheckSubLevelStateConfig(ByteBuffer _bb)
		{
			return ICheckSubLevelStateConfig.GetRootAsICheckSubLevelStateConfig(_bb, default(ICheckSubLevelStateConfig));
		}

		// Token: 0x06020034 RID: 131124 RVA: 0x0047134C File Offset: 0x0046F54C
		public static ICheckSubLevelStateConfig GetRootAsICheckSubLevelStateConfig(ByteBuffer _bb, ICheckSubLevelStateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020035 RID: 131125 RVA: 0x00471369 File Offset: 0x0046F569
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020036 RID: 131126 RVA: 0x00471378 File Offset: 0x0046F578
		public ICheckSubLevelStateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170092B8 RID: 37560
		// (get) Token: 0x06020037 RID: 131127 RVA: 0x00471388 File Offset: 0x0046F588
		public string SubLevelName
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

		// Token: 0x06020038 RID: 131128 RVA: 0x004713BF File Offset: 0x0046F5BF
		public Span<byte> GetSubLevelNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06020039 RID: 131129 RVA: 0x004713CE File Offset: 0x0046F5CE
		public byte[] GetSubLevelNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x170092B9 RID: 37561
		// (get) Token: 0x0602003A RID: 131130 RVA: 0x004713DC File Offset: 0x0046F5DC
		public ESubLevelState SubLevelState
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ESubLevelState.Enable;
				}
				return (ESubLevelState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602003B RID: 131131 RVA: 0x00471418 File Offset: 0x0046F618
		public static Offset<ICheckSubLevelStateConfig> CreateICheckSubLevelStateConfig(FlatBufferBuilder builder, StringOffset SubLevelNameOffset = default(StringOffset), ESubLevelState SubLevelState = ESubLevelState.Enable)
		{
			builder.StartTable(2);
			ICheckSubLevelStateConfig.AddSubLevelName(builder, SubLevelNameOffset);
			ICheckSubLevelStateConfig.AddSubLevelState(builder, SubLevelState);
			return ICheckSubLevelStateConfig.EndICheckSubLevelStateConfig(builder);
		}

		// Token: 0x0602003C RID: 131132 RVA: 0x00471435 File Offset: 0x0046F635
		public static void StartICheckSubLevelStateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602003D RID: 131133 RVA: 0x0047143E File Offset: 0x0046F63E
		public static void AddSubLevelName(FlatBufferBuilder builder, StringOffset subLevelNameOffset)
		{
			builder.AddOffset(0, subLevelNameOffset.Value, 0);
		}

		// Token: 0x0602003E RID: 131134 RVA: 0x0047144E File Offset: 0x0046F64E
		public static void AddSubLevelState(FlatBufferBuilder builder, ESubLevelState subLevelState)
		{
			builder.AddByte(1, (byte)subLevelState, 0);
		}

		// Token: 0x0602003F RID: 131135 RVA: 0x00471459 File Offset: 0x0046F659
		public static Offset<ICheckSubLevelStateConfig> EndICheckSubLevelStateConfig(FlatBufferBuilder builder)
		{
			return new Offset<ICheckSubLevelStateConfig>(builder.EndTable());
		}

		// Token: 0x06020040 RID: 131136 RVA: 0x00471468 File Offset: 0x0046F668
		public ICheckSubLevelStateConfigT UnPack()
		{
			ICheckSubLevelStateConfigT checkSubLevelStateConfigT = new ICheckSubLevelStateConfigT();
			this.UnPackTo(checkSubLevelStateConfigT);
			return checkSubLevelStateConfigT;
		}

		// Token: 0x06020041 RID: 131137 RVA: 0x00471483 File Offset: 0x0046F683
		public void UnPackTo(ICheckSubLevelStateConfigT _o)
		{
			_o.SubLevelName = this.SubLevelName;
			_o.SubLevelState = this.SubLevelState;
		}

		// Token: 0x06020042 RID: 131138 RVA: 0x004714A0 File Offset: 0x0046F6A0
		public static Offset<ICheckSubLevelStateConfig> Pack(FlatBufferBuilder builder, ICheckSubLevelStateConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckSubLevelStateConfig>);
			}
			StringOffset subLevelNameOffset = (_o.SubLevelName == null) ? default(StringOffset) : builder.CreateString(_o.SubLevelName);
			return ICheckSubLevelStateConfig.CreateICheckSubLevelStateConfig(builder, subLevelNameOffset, _o.SubLevelState);
		}

		// Token: 0x0400DED7 RID: 57047
		private Table __p;
	}
}
