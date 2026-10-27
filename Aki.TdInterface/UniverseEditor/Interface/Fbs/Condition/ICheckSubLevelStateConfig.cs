using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B32 RID: 19250
	public struct ICheckSubLevelStateConfig : IFlatbufferObject
	{
		// Token: 0x17008BA7 RID: 35751
		// (get) Token: 0x0601E4A6 RID: 124070 RVA: 0x0043EB6F File Offset: 0x0043CD6F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E4A7 RID: 124071 RVA: 0x0043EB7C File Offset: 0x0043CD7C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E4A8 RID: 124072 RVA: 0x0043EB84 File Offset: 0x0043CD84
		public static ICheckSubLevelStateConfig GetRootAsICheckSubLevelStateConfig(ByteBuffer _bb)
		{
			return ICheckSubLevelStateConfig.GetRootAsICheckSubLevelStateConfig(_bb, default(ICheckSubLevelStateConfig));
		}

		// Token: 0x0601E4A9 RID: 124073 RVA: 0x0043EBA0 File Offset: 0x0043CDA0
		public static ICheckSubLevelStateConfig GetRootAsICheckSubLevelStateConfig(ByteBuffer _bb, ICheckSubLevelStateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E4AA RID: 124074 RVA: 0x0043EBBD File Offset: 0x0043CDBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E4AB RID: 124075 RVA: 0x0043EBCC File Offset: 0x0043CDCC
		public ICheckSubLevelStateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008BA8 RID: 35752
		// (get) Token: 0x0601E4AC RID: 124076 RVA: 0x0043EBDC File Offset: 0x0043CDDC
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

		// Token: 0x0601E4AD RID: 124077 RVA: 0x0043EC13 File Offset: 0x0043CE13
		public Span<byte> GetSubLevelNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601E4AE RID: 124078 RVA: 0x0043EC22 File Offset: 0x0043CE22
		public byte[] GetSubLevelNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17008BA9 RID: 35753
		// (get) Token: 0x0601E4AF RID: 124079 RVA: 0x0043EC30 File Offset: 0x0043CE30
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

		// Token: 0x0601E4B0 RID: 124080 RVA: 0x0043EC6C File Offset: 0x0043CE6C
		public static Offset<ICheckSubLevelStateConfig> CreateICheckSubLevelStateConfig(FlatBufferBuilder builder, StringOffset SubLevelNameOffset = default(StringOffset), ESubLevelState SubLevelState = ESubLevelState.Enable)
		{
			builder.StartTable(2);
			ICheckSubLevelStateConfig.AddSubLevelName(builder, SubLevelNameOffset);
			ICheckSubLevelStateConfig.AddSubLevelState(builder, SubLevelState);
			return ICheckSubLevelStateConfig.EndICheckSubLevelStateConfig(builder);
		}

		// Token: 0x0601E4B1 RID: 124081 RVA: 0x0043EC89 File Offset: 0x0043CE89
		public static void StartICheckSubLevelStateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601E4B2 RID: 124082 RVA: 0x0043EC92 File Offset: 0x0043CE92
		public static void AddSubLevelName(FlatBufferBuilder builder, StringOffset subLevelNameOffset)
		{
			builder.AddOffset(0, subLevelNameOffset.Value, 0);
		}

		// Token: 0x0601E4B3 RID: 124083 RVA: 0x0043ECA2 File Offset: 0x0043CEA2
		public static void AddSubLevelState(FlatBufferBuilder builder, ESubLevelState subLevelState)
		{
			builder.AddByte(1, (byte)subLevelState, 0);
		}

		// Token: 0x0601E4B4 RID: 124084 RVA: 0x0043ECAD File Offset: 0x0043CEAD
		public static Offset<ICheckSubLevelStateConfig> EndICheckSubLevelStateConfig(FlatBufferBuilder builder)
		{
			return new Offset<ICheckSubLevelStateConfig>(builder.EndTable());
		}

		// Token: 0x0601E4B5 RID: 124085 RVA: 0x0043ECBC File Offset: 0x0043CEBC
		public ICheckSubLevelStateConfigT UnPack()
		{
			ICheckSubLevelStateConfigT checkSubLevelStateConfigT = new ICheckSubLevelStateConfigT();
			this.UnPackTo(checkSubLevelStateConfigT);
			return checkSubLevelStateConfigT;
		}

		// Token: 0x0601E4B6 RID: 124086 RVA: 0x0043ECD7 File Offset: 0x0043CED7
		public void UnPackTo(ICheckSubLevelStateConfigT _o)
		{
			_o.SubLevelName = this.SubLevelName;
			_o.SubLevelState = this.SubLevelState;
		}

		// Token: 0x0601E4B7 RID: 124087 RVA: 0x0043ECF4 File Offset: 0x0043CEF4
		public static Offset<ICheckSubLevelStateConfig> Pack(FlatBufferBuilder builder, ICheckSubLevelStateConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckSubLevelStateConfig>);
			}
			StringOffset subLevelNameOffset = (_o.SubLevelName == null) ? default(StringOffset) : builder.CreateString(_o.SubLevelName);
			return ICheckSubLevelStateConfig.CreateICheckSubLevelStateConfig(builder, subLevelNameOffset, _o.SubLevelState);
		}

		// Token: 0x0400D3D8 RID: 54232
		private Table __p;
	}
}
