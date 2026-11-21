using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CCA RID: 19658
	public struct IEditorRestartInfo : IFlatbufferObject
	{
		// Token: 0x17008BC0 RID: 35776
		// (get) Token: 0x0601E3FF RID: 123903 RVA: 0x0043D08C File Offset: 0x0043B28C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E400 RID: 123904 RVA: 0x0043D099 File Offset: 0x0043B299
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E401 RID: 123905 RVA: 0x0043D0A0 File Offset: 0x0043B2A0
		public static IEditorRestartInfo GetRootAsIEditorRestartInfo(ByteBuffer _bb)
		{
			return IEditorRestartInfo.GetRootAsIEditorRestartInfo(_bb, default(IEditorRestartInfo));
		}

		// Token: 0x0601E402 RID: 123906 RVA: 0x0043D0BC File Offset: 0x0043B2BC
		public static IEditorRestartInfo GetRootAsIEditorRestartInfo(ByteBuffer _bb, IEditorRestartInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E403 RID: 123907 RVA: 0x0043D0D9 File Offset: 0x0043B2D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E404 RID: 123908 RVA: 0x0043D0E8 File Offset: 0x0043B2E8
		public IEditorRestartInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008BC1 RID: 35777
		// (get) Token: 0x0601E405 RID: 123909 RVA: 0x0043D0F8 File Offset: 0x0043B2F8
		public bool IsRestarting
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008BC2 RID: 35778
		// (get) Token: 0x0601E406 RID: 123910 RVA: 0x0043D138 File Offset: 0x0043B338
		public bool IsUseIdleLoad
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008BC3 RID: 35779
		// (get) Token: 0x0601E407 RID: 123911 RVA: 0x0043D178 File Offset: 0x0043B378
		public TEditorRestartReason Reason
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TEditorRestartReason.ChangeMap;
				}
				return (TEditorRestartReason)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008BC4 RID: 35780
		// (get) Token: 0x0601E408 RID: 123912 RVA: 0x0043D1B4 File Offset: 0x0043B3B4
		public long Timestamp
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0L;
				}
				return this.__p.bb.GetLong(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E409 RID: 123913 RVA: 0x0043D1F2 File Offset: 0x0043B3F2
		public static Offset<IEditorRestartInfo> CreateIEditorRestartInfo(FlatBufferBuilder builder, bool IsRestarting = false, bool IsUseIdleLoad = false, TEditorRestartReason Reason = TEditorRestartReason.ChangeMap, long Timestamp = 0L)
		{
			builder.StartTable(4);
			IEditorRestartInfo.AddTimestamp(builder, Timestamp);
			IEditorRestartInfo.AddReason(builder, Reason);
			IEditorRestartInfo.AddIsUseIdleLoad(builder, IsUseIdleLoad);
			IEditorRestartInfo.AddIsRestarting(builder, IsRestarting);
			return IEditorRestartInfo.EndIEditorRestartInfo(builder);
		}

		// Token: 0x0601E40A RID: 123914 RVA: 0x0043D21E File Offset: 0x0043B41E
		public static void StartIEditorRestartInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601E40B RID: 123915 RVA: 0x0043D227 File Offset: 0x0043B427
		public static void AddIsRestarting(FlatBufferBuilder builder, bool isRestarting)
		{
			builder.AddBool(0, isRestarting, false);
		}

		// Token: 0x0601E40C RID: 123916 RVA: 0x0043D232 File Offset: 0x0043B432
		public static void AddIsUseIdleLoad(FlatBufferBuilder builder, bool isUseIdleLoad)
		{
			builder.AddBool(1, isUseIdleLoad, false);
		}

		// Token: 0x0601E40D RID: 123917 RVA: 0x0043D23D File Offset: 0x0043B43D
		public static void AddReason(FlatBufferBuilder builder, TEditorRestartReason reason)
		{
			builder.AddByte(2, (byte)reason, 0);
		}

		// Token: 0x0601E40E RID: 123918 RVA: 0x0043D248 File Offset: 0x0043B448
		public static void AddTimestamp(FlatBufferBuilder builder, long timestamp)
		{
			builder.AddLong(3, timestamp, 0L);
		}

		// Token: 0x0601E40F RID: 123919 RVA: 0x0043D254 File Offset: 0x0043B454
		public static Offset<IEditorRestartInfo> EndIEditorRestartInfo(FlatBufferBuilder builder)
		{
			return new Offset<IEditorRestartInfo>(builder.EndTable());
		}

		// Token: 0x0601E410 RID: 123920 RVA: 0x0043D264 File Offset: 0x0043B464
		public IEditorRestartInfoT UnPack()
		{
			IEditorRestartInfoT editorRestartInfoT = new IEditorRestartInfoT();
			this.UnPackTo(editorRestartInfoT);
			return editorRestartInfoT;
		}

		// Token: 0x0601E411 RID: 123921 RVA: 0x0043D27F File Offset: 0x0043B47F
		public void UnPackTo(IEditorRestartInfoT _o)
		{
			_o.IsRestarting = this.IsRestarting;
			_o.IsUseIdleLoad = this.IsUseIdleLoad;
			_o.Reason = this.Reason;
			_o.Timestamp = this.Timestamp;
		}

		// Token: 0x0601E412 RID: 123922 RVA: 0x0043D2B4 File Offset: 0x0043B4B4
		public static Offset<IEditorRestartInfo> Pack(FlatBufferBuilder builder, IEditorRestartInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEditorRestartInfo>);
			}
			return IEditorRestartInfo.CreateIEditorRestartInfo(builder, _o.IsRestarting, _o.IsUseIdleLoad, _o.Reason, _o.Timestamp);
		}

		// Token: 0x0400D80A RID: 55306
		private Table __p;
	}
}
