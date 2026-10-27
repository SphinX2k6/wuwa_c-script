using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200719C RID: 29084
	public struct ISportConfig : IFlatbufferObject
	{
		// Token: 0x1700D801 RID: 55297
		// (get) Token: 0x0603390C RID: 211212 RVA: 0x006F1DFE File Offset: 0x006EFFFE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603390D RID: 211213 RVA: 0x006F1E0B File Offset: 0x006F000B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603390E RID: 211214 RVA: 0x006F1E14 File Offset: 0x006F0014
		public static ISportConfig GetRootAsISportConfig(ByteBuffer _bb)
		{
			return ISportConfig.GetRootAsISportConfig(_bb, default(ISportConfig));
		}

		// Token: 0x0603390F RID: 211215 RVA: 0x006F1E30 File Offset: 0x006F0030
		public static ISportConfig GetRootAsISportConfig(ByteBuffer _bb, ISportConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033910 RID: 211216 RVA: 0x006F1E4D File Offset: 0x006F004D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033911 RID: 211217 RVA: 0x006F1E5C File Offset: 0x006F005C
		public ISportConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D802 RID: 55298
		// (get) Token: 0x06033912 RID: 211218 RVA: 0x006F1E6C File Offset: 0x006F006C
		public ESportStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESportStateType.Slide;
				}
				return (ESportStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033913 RID: 211219 RVA: 0x006F1EA8 File Offset: 0x006F00A8
		public static Offset<ISportConfig> CreateISportConfig(FlatBufferBuilder builder, ESportStateType Type = ESportStateType.Slide)
		{
			builder.StartTable(1);
			ISportConfig.AddType(builder, Type);
			return ISportConfig.EndISportConfig(builder);
		}

		// Token: 0x06033914 RID: 211220 RVA: 0x006F1EBE File Offset: 0x006F00BE
		public static void StartISportConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033915 RID: 211221 RVA: 0x006F1EC7 File Offset: 0x006F00C7
		public static void AddType(FlatBufferBuilder builder, ESportStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033916 RID: 211222 RVA: 0x006F1ED2 File Offset: 0x006F00D2
		public static Offset<ISportConfig> EndISportConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISportConfig>(builder.EndTable());
		}

		// Token: 0x06033917 RID: 211223 RVA: 0x006F1EE0 File Offset: 0x006F00E0
		public ISportConfigT UnPack()
		{
			ISportConfigT sportConfigT = new ISportConfigT();
			this.UnPackTo(sportConfigT);
			return sportConfigT;
		}

		// Token: 0x06033918 RID: 211224 RVA: 0x006F1EFB File Offset: 0x006F00FB
		public void UnPackTo(ISportConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033919 RID: 211225 RVA: 0x006F1F0C File Offset: 0x006F010C
		public static Offset<ISportConfig> Pack(FlatBufferBuilder builder, ISportConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISportConfig>);
			}
			return ISportConfig.CreateISportConfig(builder, _o.Type);
		}

		// Token: 0x04011C5E RID: 72798
		private Table __p;
	}
}
