using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BC7 RID: 23495
	public struct INpcModelConfig : IFlatbufferObject
	{
		// Token: 0x1700ABC9 RID: 43977
		// (get) Token: 0x06026C0A RID: 158730 RVA: 0x0054DE78 File Offset: 0x0054C078
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026C0B RID: 158731 RVA: 0x0054DE85 File Offset: 0x0054C085
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026C0C RID: 158732 RVA: 0x0054DE8C File Offset: 0x0054C08C
		public static INpcModelConfig GetRootAsINpcModelConfig(ByteBuffer _bb)
		{
			return INpcModelConfig.GetRootAsINpcModelConfig(_bb, default(INpcModelConfig));
		}

		// Token: 0x06026C0D RID: 158733 RVA: 0x0054DEA8 File Offset: 0x0054C0A8
		public static INpcModelConfig GetRootAsINpcModelConfig(ByteBuffer _bb, INpcModelConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026C0E RID: 158734 RVA: 0x0054DEC5 File Offset: 0x0054C0C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026C0F RID: 158735 RVA: 0x0054DED4 File Offset: 0x0054C0D4
		public INpcModelConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ABCA RID: 43978
		// (get) Token: 0x06026C10 RID: 158736 RVA: 0x0054DEE4 File Offset: 0x0054C0E4
		public ENpcModelType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENpcModelType.Mesh;
				}
				return (ENpcModelType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026C11 RID: 158737 RVA: 0x0054DF20 File Offset: 0x0054C120
		public static Offset<INpcModelConfig> CreateINpcModelConfig(FlatBufferBuilder builder, ENpcModelType Type = ENpcModelType.Mesh)
		{
			builder.StartTable(1);
			INpcModelConfig.AddType(builder, Type);
			return INpcModelConfig.EndINpcModelConfig(builder);
		}

		// Token: 0x06026C12 RID: 158738 RVA: 0x0054DF36 File Offset: 0x0054C136
		public static void StartINpcModelConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06026C13 RID: 158739 RVA: 0x0054DF3F File Offset: 0x0054C13F
		public static void AddType(FlatBufferBuilder builder, ENpcModelType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026C14 RID: 158740 RVA: 0x0054DF4A File Offset: 0x0054C14A
		public static Offset<INpcModelConfig> EndINpcModelConfig(FlatBufferBuilder builder)
		{
			return new Offset<INpcModelConfig>(builder.EndTable());
		}

		// Token: 0x06026C15 RID: 158741 RVA: 0x0054DF58 File Offset: 0x0054C158
		public INpcModelConfigT UnPack()
		{
			INpcModelConfigT npcModelConfigT = new INpcModelConfigT();
			this.UnPackTo(npcModelConfigT);
			return npcModelConfigT;
		}

		// Token: 0x06026C16 RID: 158742 RVA: 0x0054DF73 File Offset: 0x0054C173
		public void UnPackTo(INpcModelConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06026C17 RID: 158743 RVA: 0x0054DF84 File Offset: 0x0054C184
		public static Offset<INpcModelConfig> Pack(FlatBufferBuilder builder, INpcModelConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcModelConfig>);
			}
			return INpcModelConfig.CreateINpcModelConfig(builder, _o.Type);
		}

		// Token: 0x0400F618 RID: 63000
		private Table __p;
	}
}
