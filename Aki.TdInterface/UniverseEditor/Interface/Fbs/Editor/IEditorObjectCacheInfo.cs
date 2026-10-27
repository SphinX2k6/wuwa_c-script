using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004862 RID: 18530
	public struct IEditorObjectCacheInfo : IFlatbufferObject
	{
		// Token: 0x17008571 RID: 34161
		// (get) Token: 0x0601CBF8 RID: 117752 RVA: 0x004105E0 File Offset: 0x0040E7E0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CBF9 RID: 117753 RVA: 0x004105ED File Offset: 0x0040E7ED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CBFA RID: 117754 RVA: 0x004105F4 File Offset: 0x0040E7F4
		public static IEditorObjectCacheInfo GetRootAsIEditorObjectCacheInfo(ByteBuffer _bb)
		{
			return IEditorObjectCacheInfo.GetRootAsIEditorObjectCacheInfo(_bb, default(IEditorObjectCacheInfo));
		}

		// Token: 0x0601CBFB RID: 117755 RVA: 0x00410610 File Offset: 0x0040E810
		public static IEditorObjectCacheInfo GetRootAsIEditorObjectCacheInfo(ByteBuffer _bb, IEditorObjectCacheInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CBFC RID: 117756 RVA: 0x0041062D File Offset: 0x0040E82D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CBFD RID: 117757 RVA: 0x0041063C File Offset: 0x0040E83C
		public IEditorObjectCacheInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008572 RID: 34162
		// (get) Token: 0x0601CBFE RID: 117758 RVA: 0x0041064C File Offset: 0x0040E84C
		public bool UseCache
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008573 RID: 34163
		// (get) Token: 0x0601CBFF RID: 117759 RVA: 0x0041068C File Offset: 0x0040E88C
		public int Timestamp
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601CC00 RID: 117760 RVA: 0x004106C8 File Offset: 0x0040E8C8
		public static Offset<IEditorObjectCacheInfo> CreateIEditorObjectCacheInfo(FlatBufferBuilder builder, bool UseCache = false, int Timestamp = 0)
		{
			builder.StartTable(2);
			IEditorObjectCacheInfo.AddTimestamp(builder, Timestamp);
			IEditorObjectCacheInfo.AddUseCache(builder, UseCache);
			return IEditorObjectCacheInfo.EndIEditorObjectCacheInfo(builder);
		}

		// Token: 0x0601CC01 RID: 117761 RVA: 0x004106E5 File Offset: 0x0040E8E5
		public static void StartIEditorObjectCacheInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601CC02 RID: 117762 RVA: 0x004106EE File Offset: 0x0040E8EE
		public static void AddUseCache(FlatBufferBuilder builder, bool useCache)
		{
			builder.AddBool(0, useCache, false);
		}

		// Token: 0x0601CC03 RID: 117763 RVA: 0x004106F9 File Offset: 0x0040E8F9
		public static void AddTimestamp(FlatBufferBuilder builder, int timestamp)
		{
			builder.AddInt(1, timestamp, 0);
		}

		// Token: 0x0601CC04 RID: 117764 RVA: 0x00410704 File Offset: 0x0040E904
		public static Offset<IEditorObjectCacheInfo> EndIEditorObjectCacheInfo(FlatBufferBuilder builder)
		{
			return new Offset<IEditorObjectCacheInfo>(builder.EndTable());
		}

		// Token: 0x0601CC05 RID: 117765 RVA: 0x00410714 File Offset: 0x0040E914
		public IEditorObjectCacheInfoT UnPack()
		{
			IEditorObjectCacheInfoT editorObjectCacheInfoT = new IEditorObjectCacheInfoT();
			this.UnPackTo(editorObjectCacheInfoT);
			return editorObjectCacheInfoT;
		}

		// Token: 0x0601CC06 RID: 117766 RVA: 0x0041072F File Offset: 0x0040E92F
		public void UnPackTo(IEditorObjectCacheInfoT _o)
		{
			_o.UseCache = this.UseCache;
			_o.Timestamp = this.Timestamp;
		}

		// Token: 0x0601CC07 RID: 117767 RVA: 0x0041074C File Offset: 0x0040E94C
		public static Offset<IEditorObjectCacheInfo> Pack(FlatBufferBuilder builder, IEditorObjectCacheInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEditorObjectCacheInfo>);
			}
			return IEditorObjectCacheInfo.CreateIEditorObjectCacheInfo(builder, _o.UseCache, _o.Timestamp);
		}

		// Token: 0x0400CDCD RID: 52685
		private Table __p;
	}
}
