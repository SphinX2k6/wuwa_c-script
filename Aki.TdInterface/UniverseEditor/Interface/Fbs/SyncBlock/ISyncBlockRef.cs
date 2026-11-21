using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.SyncBlock
{
	// Token: 0x02003F8F RID: 16271
	public struct ISyncBlockRef : IFlatbufferObject
	{
		// Token: 0x17006E1D RID: 28189
		// (get) Token: 0x060162DF RID: 90847 RVA: 0x0032E320 File Offset: 0x0032C520
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060162E0 RID: 90848 RVA: 0x0032E32D File Offset: 0x0032C52D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060162E1 RID: 90849 RVA: 0x0032E334 File Offset: 0x0032C534
		public static ISyncBlockRef GetRootAsISyncBlockRef(ByteBuffer _bb)
		{
			return ISyncBlockRef.GetRootAsISyncBlockRef(_bb, default(ISyncBlockRef));
		}

		// Token: 0x060162E2 RID: 90850 RVA: 0x0032E350 File Offset: 0x0032C550
		public static ISyncBlockRef GetRootAsISyncBlockRef(ByteBuffer _bb, ISyncBlockRef obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060162E3 RID: 90851 RVA: 0x0032E36D File Offset: 0x0032C56D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060162E4 RID: 90852 RVA: 0x0032E37C File Offset: 0x0032C57C
		public ISyncBlockRef __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x060162E5 RID: 90853 RVA: 0x0032E38C File Offset: 0x0032C58C
		public static void StartISyncBlockRef(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x060162E6 RID: 90854 RVA: 0x0032E395 File Offset: 0x0032C595
		public static Offset<ISyncBlockRef> EndISyncBlockRef(FlatBufferBuilder builder)
		{
			return new Offset<ISyncBlockRef>(builder.EndTable());
		}

		// Token: 0x060162E7 RID: 90855 RVA: 0x0032E3A4 File Offset: 0x0032C5A4
		public ISyncBlockRefT UnPack()
		{
			ISyncBlockRefT syncBlockRefT = new ISyncBlockRefT();
			this.UnPackTo(syncBlockRefT);
			return syncBlockRefT;
		}

		// Token: 0x060162E8 RID: 90856 RVA: 0x0032E3BF File Offset: 0x0032C5BF
		public void UnPackTo(ISyncBlockRefT _o)
		{
		}

		// Token: 0x060162E9 RID: 90857 RVA: 0x0032E3C4 File Offset: 0x0032C5C4
		public static Offset<ISyncBlockRef> Pack(FlatBufferBuilder builder, ISyncBlockRefT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISyncBlockRef>);
			}
			ISyncBlockRef.StartISyncBlockRef(builder);
			return ISyncBlockRef.EndISyncBlockRef(builder);
		}

		// Token: 0x0400BA54 RID: 47700
		private Table __p;
	}
}
