using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AC2 RID: 19138
	public struct IGmCommand : IFlatbufferObject
	{
		// Token: 0x17008613 RID: 34323
		// (get) Token: 0x0601CC84 RID: 117892 RVA: 0x0040E061 File Offset: 0x0040C261
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CC85 RID: 117893 RVA: 0x0040E06E File Offset: 0x0040C26E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CC86 RID: 117894 RVA: 0x0040E078 File Offset: 0x0040C278
		public static IGmCommand GetRootAsIGmCommand(ByteBuffer _bb)
		{
			return IGmCommand.GetRootAsIGmCommand(_bb, default(IGmCommand));
		}

		// Token: 0x0601CC87 RID: 117895 RVA: 0x0040E094 File Offset: 0x0040C294
		public static IGmCommand GetRootAsIGmCommand(ByteBuffer _bb, IGmCommand obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CC88 RID: 117896 RVA: 0x0040E0B1 File Offset: 0x0040C2B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CC89 RID: 117897 RVA: 0x0040E0C0 File Offset: 0x0040C2C0
		public IGmCommand __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008614 RID: 34324
		// (get) Token: 0x0601CC8A RID: 117898 RVA: 0x0040E0D0 File Offset: 0x0040C2D0
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601CC8B RID: 117899 RVA: 0x0040E10C File Offset: 0x0040C30C
		public static Offset<IGmCommand> CreateIGmCommand(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode)
		{
			builder.StartTable(1);
			IGmCommand.AddType(builder, Type);
			return IGmCommand.EndIGmCommand(builder);
		}

		// Token: 0x0601CC8C RID: 117900 RVA: 0x0040E122 File Offset: 0x0040C322
		public static void StartIGmCommand(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601CC8D RID: 117901 RVA: 0x0040E12B File Offset: 0x0040C32B
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CC8E RID: 117902 RVA: 0x0040E136 File Offset: 0x0040C336
		public static Offset<IGmCommand> EndIGmCommand(FlatBufferBuilder builder)
		{
			return new Offset<IGmCommand>(builder.EndTable());
		}

		// Token: 0x0601CC8F RID: 117903 RVA: 0x0040E144 File Offset: 0x0040C344
		public IGmCommandT UnPack()
		{
			IGmCommandT gmCommandT = new IGmCommandT();
			this.UnPackTo(gmCommandT);
			return gmCommandT;
		}

		// Token: 0x0601CC90 RID: 117904 RVA: 0x0040E15F File Offset: 0x0040C35F
		public void UnPackTo(IGmCommandT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601CC91 RID: 117905 RVA: 0x0040E170 File Offset: 0x0040C370
		public static Offset<IGmCommand> Pack(FlatBufferBuilder builder, IGmCommandT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGmCommand>);
			}
			return IGmCommand.CreateIGmCommand(builder, _o.Type);
		}

		// Token: 0x0400D205 RID: 53765
		private Table __p;
	}
}
