using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048A4 RID: 18596
	public struct IScanDirectory : IFlatbufferObject
	{
		// Token: 0x170086D8 RID: 34520
		// (get) Token: 0x0601D060 RID: 118880 RVA: 0x00419704 File Offset: 0x00417904
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D061 RID: 118881 RVA: 0x00419711 File Offset: 0x00417911
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D062 RID: 118882 RVA: 0x00419718 File Offset: 0x00417918
		public static IScanDirectory GetRootAsIScanDirectory(ByteBuffer _bb)
		{
			return IScanDirectory.GetRootAsIScanDirectory(_bb, default(IScanDirectory));
		}

		// Token: 0x0601D063 RID: 118883 RVA: 0x00419734 File Offset: 0x00417934
		public static IScanDirectory GetRootAsIScanDirectory(ByteBuffer _bb, IScanDirectory obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D064 RID: 118884 RVA: 0x00419751 File Offset: 0x00417951
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D065 RID: 118885 RVA: 0x00419760 File Offset: 0x00417960
		public IScanDirectory __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170086D9 RID: 34521
		// (get) Token: 0x0601D066 RID: 118886 RVA: 0x00419770 File Offset: 0x00417970
		public bool IsEnable
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170086DA RID: 34522
		// (get) Token: 0x0601D067 RID: 118887 RVA: 0x004197B0 File Offset: 0x004179B0
		public string Path
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D068 RID: 118888 RVA: 0x004197E7 File Offset: 0x004179E7
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601D069 RID: 118889 RVA: 0x004197F6 File Offset: 0x004179F6
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601D06A RID: 118890 RVA: 0x00419804 File Offset: 0x00417A04
		public static Offset<IScanDirectory> CreateIScanDirectory(FlatBufferBuilder builder, bool IsEnable = false, StringOffset PathOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IScanDirectory.AddPath(builder, PathOffset);
			IScanDirectory.AddIsEnable(builder, IsEnable);
			return IScanDirectory.EndIScanDirectory(builder);
		}

		// Token: 0x0601D06B RID: 118891 RVA: 0x00419821 File Offset: 0x00417A21
		public static void StartIScanDirectory(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D06C RID: 118892 RVA: 0x0041982A File Offset: 0x00417A2A
		public static void AddIsEnable(FlatBufferBuilder builder, bool isEnable)
		{
			builder.AddBool(0, isEnable, false);
		}

		// Token: 0x0601D06D RID: 118893 RVA: 0x00419835 File Offset: 0x00417A35
		public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset)
		{
			builder.AddOffset(1, pathOffset.Value, 0);
		}

		// Token: 0x0601D06E RID: 118894 RVA: 0x00419845 File Offset: 0x00417A45
		public static Offset<IScanDirectory> EndIScanDirectory(FlatBufferBuilder builder)
		{
			return new Offset<IScanDirectory>(builder.EndTable());
		}

		// Token: 0x0601D06F RID: 118895 RVA: 0x00419854 File Offset: 0x00417A54
		public IScanDirectoryT UnPack()
		{
			IScanDirectoryT scanDirectoryT = new IScanDirectoryT();
			this.UnPackTo(scanDirectoryT);
			return scanDirectoryT;
		}

		// Token: 0x0601D070 RID: 118896 RVA: 0x0041986F File Offset: 0x00417A6F
		public void UnPackTo(IScanDirectoryT _o)
		{
			_o.IsEnable = this.IsEnable;
			_o.Path = this.Path;
		}

		// Token: 0x0601D071 RID: 118897 RVA: 0x0041988C File Offset: 0x00417A8C
		public static Offset<IScanDirectory> Pack(FlatBufferBuilder builder, IScanDirectoryT _o)
		{
			if (_o == null)
			{
				return default(Offset<IScanDirectory>);
			}
			StringOffset pathOffset = (_o.Path == null) ? default(StringOffset) : builder.CreateString(_o.Path);
			return IScanDirectory.CreateIScanDirectory(builder, _o.IsEnable, pathOffset);
		}

		// Token: 0x0400CE90 RID: 52880
		private Table __p;
	}
}
