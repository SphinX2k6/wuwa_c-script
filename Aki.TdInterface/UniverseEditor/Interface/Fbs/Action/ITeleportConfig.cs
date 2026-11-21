using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B5D RID: 31581
	public struct ITeleportConfig : IFlatbufferObject
	{
		// Token: 0x1700EC73 RID: 60531
		// (get) Token: 0x06038DE5 RID: 232933 RVA: 0x007B02BE File Offset: 0x007AE4BE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038DE6 RID: 232934 RVA: 0x007B02CB File Offset: 0x007AE4CB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038DE7 RID: 232935 RVA: 0x007B02D4 File Offset: 0x007AE4D4
		public static ITeleportConfig GetRootAsITeleportConfig(ByteBuffer _bb)
		{
			return ITeleportConfig.GetRootAsITeleportConfig(_bb, default(ITeleportConfig));
		}

		// Token: 0x06038DE8 RID: 232936 RVA: 0x007B02F0 File Offset: 0x007AE4F0
		public static ITeleportConfig GetRootAsITeleportConfig(ByteBuffer _bb, ITeleportConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038DE9 RID: 232937 RVA: 0x007B030D File Offset: 0x007AE50D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038DEA RID: 232938 RVA: 0x007B031C File Offset: 0x007AE51C
		public ITeleportConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EC74 RID: 60532
		// (get) Token: 0x06038DEB RID: 232939 RVA: 0x007B032C File Offset: 0x007AE52C
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

		// Token: 0x06038DEC RID: 232940 RVA: 0x007B0368 File Offset: 0x007AE568
		public static Offset<ITeleportConfig> CreateITeleportConfig(FlatBufferBuilder builder, ETeleportType Type = ETeleportType.FixedPos)
		{
			builder.StartTable(1);
			ITeleportConfig.AddType(builder, Type);
			return ITeleportConfig.EndITeleportConfig(builder);
		}

		// Token: 0x06038DED RID: 232941 RVA: 0x007B037E File Offset: 0x007AE57E
		public static void StartITeleportConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06038DEE RID: 232942 RVA: 0x007B0387 File Offset: 0x007AE587
		public static void AddType(FlatBufferBuilder builder, ETeleportType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06038DEF RID: 232943 RVA: 0x007B0392 File Offset: 0x007AE592
		public static Offset<ITeleportConfig> EndITeleportConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportConfig>(builder.EndTable());
		}

		// Token: 0x06038DF0 RID: 232944 RVA: 0x007B03A0 File Offset: 0x007AE5A0
		public ITeleportConfigT UnPack()
		{
			ITeleportConfigT teleportConfigT = new ITeleportConfigT();
			this.UnPackTo(teleportConfigT);
			return teleportConfigT;
		}

		// Token: 0x06038DF1 RID: 232945 RVA: 0x007B03BB File Offset: 0x007AE5BB
		public void UnPackTo(ITeleportConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06038DF2 RID: 232946 RVA: 0x007B03CC File Offset: 0x007AE5CC
		public static Offset<ITeleportConfig> Pack(FlatBufferBuilder builder, ITeleportConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportConfig>);
			}
			return ITeleportConfig.CreateITeleportConfig(builder, _o.Type);
		}

		// Token: 0x0401319E RID: 78238
		private Table __p;
	}
}
