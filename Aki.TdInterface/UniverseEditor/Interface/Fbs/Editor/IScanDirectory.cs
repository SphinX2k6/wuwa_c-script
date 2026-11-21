using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D09 RID: 19721
	public struct IScanDirectory : IFlatbufferObject
	{
		// Token: 0x17008D20 RID: 36128
		// (get) Token: 0x0601E84D RID: 125005 RVA: 0x00445EA0 File Offset: 0x004440A0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E84E RID: 125006 RVA: 0x00445EAD File Offset: 0x004440AD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E84F RID: 125007 RVA: 0x00445EB4 File Offset: 0x004440B4
		public static IScanDirectory GetRootAsIScanDirectory(ByteBuffer _bb)
		{
			return IScanDirectory.GetRootAsIScanDirectory(_bb, default(IScanDirectory));
		}

		// Token: 0x0601E850 RID: 125008 RVA: 0x00445ED0 File Offset: 0x004440D0
		public static IScanDirectory GetRootAsIScanDirectory(ByteBuffer _bb, IScanDirectory obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E851 RID: 125009 RVA: 0x00445EED File Offset: 0x004440ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E852 RID: 125010 RVA: 0x00445EFC File Offset: 0x004440FC
		public IScanDirectory __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008D21 RID: 36129
		// (get) Token: 0x0601E853 RID: 125011 RVA: 0x00445F0C File Offset: 0x0044410C
		public bool IsEnable
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008D22 RID: 36130
		// (get) Token: 0x0601E854 RID: 125012 RVA: 0x00445F4C File Offset: 0x0044414C
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

		// Token: 0x0601E855 RID: 125013 RVA: 0x00445F83 File Offset: 0x00444183
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601E856 RID: 125014 RVA: 0x00445F92 File Offset: 0x00444192
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601E857 RID: 125015 RVA: 0x00445FA0 File Offset: 0x004441A0
		public static Offset<IScanDirectory> CreateIScanDirectory(FlatBufferBuilder builder, bool IsEnable = false, StringOffset PathOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IScanDirectory.AddPath(builder, PathOffset);
			IScanDirectory.AddIsEnable(builder, IsEnable);
			return IScanDirectory.EndIScanDirectory(builder);
		}

		// Token: 0x0601E858 RID: 125016 RVA: 0x00445FBD File Offset: 0x004441BD
		public static void StartIScanDirectory(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601E859 RID: 125017 RVA: 0x00445FC6 File Offset: 0x004441C6
		public static void AddIsEnable(FlatBufferBuilder builder, bool isEnable)
		{
			builder.AddBool(0, isEnable, false);
		}

		// Token: 0x0601E85A RID: 125018 RVA: 0x00445FD1 File Offset: 0x004441D1
		public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset)
		{
			builder.AddOffset(1, pathOffset.Value, 0);
		}

		// Token: 0x0601E85B RID: 125019 RVA: 0x00445FE1 File Offset: 0x004441E1
		public static Offset<IScanDirectory> EndIScanDirectory(FlatBufferBuilder builder)
		{
			return new Offset<IScanDirectory>(builder.EndTable());
		}

		// Token: 0x0601E85C RID: 125020 RVA: 0x00445FF0 File Offset: 0x004441F0
		public IScanDirectoryT UnPack()
		{
			IScanDirectoryT scanDirectoryT = new IScanDirectoryT();
			this.UnPackTo(scanDirectoryT);
			return scanDirectoryT;
		}

		// Token: 0x0601E85D RID: 125021 RVA: 0x0044600B File Offset: 0x0044420B
		public void UnPackTo(IScanDirectoryT _o)
		{
			_o.IsEnable = this.IsEnable;
			_o.Path = this.Path;
		}

		// Token: 0x0601E85E RID: 125022 RVA: 0x00446028 File Offset: 0x00444228
		public static Offset<IScanDirectory> Pack(FlatBufferBuilder builder, IScanDirectoryT _o)
		{
			if (_o == null)
			{
				return default(Offset<IScanDirectory>);
			}
			StringOffset pathOffset = (_o.Path == null) ? default(StringOffset) : builder.CreateString(_o.Path);
			return IScanDirectory.CreateIScanDirectory(builder, _o.IsEnable, pathOffset);
		}

		// Token: 0x0400D8C9 RID: 55497
		private Table __p;
	}
}
