using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007376 RID: 29558
	public struct ITeleportConfig : IFlatbufferObject
	{
		// Token: 0x1700E063 RID: 57443
		// (get) Token: 0x06035A4A RID: 219722 RVA: 0x0074DD7E File Offset: 0x0074BF7E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035A4B RID: 219723 RVA: 0x0074DD8B File Offset: 0x0074BF8B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035A4C RID: 219724 RVA: 0x0074DD94 File Offset: 0x0074BF94
		public static ITeleportConfig GetRootAsITeleportConfig(ByteBuffer _bb)
		{
			return ITeleportConfig.GetRootAsITeleportConfig(_bb, default(ITeleportConfig));
		}

		// Token: 0x06035A4D RID: 219725 RVA: 0x0074DDB0 File Offset: 0x0074BFB0
		public static ITeleportConfig GetRootAsITeleportConfig(ByteBuffer _bb, ITeleportConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035A4E RID: 219726 RVA: 0x0074DDCD File Offset: 0x0074BFCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035A4F RID: 219727 RVA: 0x0074DDDC File Offset: 0x0074BFDC
		public ITeleportConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E064 RID: 57444
		// (get) Token: 0x06035A50 RID: 219728 RVA: 0x0074DDEC File Offset: 0x0074BFEC
		public ETeleportType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETeleportType.FixedPos;
				}
				return (ETeleportType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035A51 RID: 219729 RVA: 0x0074DE28 File Offset: 0x0074C028
		public static Offset<ITeleportConfig> CreateITeleportConfig(FlatBufferBuilder builder, ETeleportType Type = ETeleportType.FixedPos)
		{
			builder.StartTable(1);
			ITeleportConfig.AddType(builder, Type);
			return ITeleportConfig.EndITeleportConfig(builder);
		}

		// Token: 0x06035A52 RID: 219730 RVA: 0x0074DE3E File Offset: 0x0074C03E
		public static void StartITeleportConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035A53 RID: 219731 RVA: 0x0074DE47 File Offset: 0x0074C047
		public static void AddType(FlatBufferBuilder builder, ETeleportType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035A54 RID: 219732 RVA: 0x0074DE52 File Offset: 0x0074C052
		public static Offset<ITeleportConfig> EndITeleportConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportConfig>(builder.EndTable());
		}

		// Token: 0x06035A55 RID: 219733 RVA: 0x0074DE60 File Offset: 0x0074C060
		public ITeleportConfigT UnPack()
		{
			ITeleportConfigT teleportConfigT = new ITeleportConfigT();
			this.UnPackTo(teleportConfigT);
			return teleportConfigT;
		}

		// Token: 0x06035A56 RID: 219734 RVA: 0x0074DE7B File Offset: 0x0074C07B
		public void UnPackTo(ITeleportConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06035A57 RID: 219735 RVA: 0x0074DE8C File Offset: 0x0074C08C
		public static Offset<ITeleportConfig> Pack(FlatBufferBuilder builder, ITeleportConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportConfig>);
			}
			return ITeleportConfig.CreateITeleportConfig(builder, _o.Type);
		}

		// Token: 0x04012185 RID: 74117
		private Table __p;
	}
}
