using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004865 RID: 18533
	public struct IEditorRestartInfo : IFlatbufferObject
	{
		// Token: 0x17008576 RID: 34166
		// (get) Token: 0x0601CC0E RID: 117774 RVA: 0x004107E2 File Offset: 0x0040E9E2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CC0F RID: 117775 RVA: 0x004107EF File Offset: 0x0040E9EF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CC10 RID: 117776 RVA: 0x004107F8 File Offset: 0x0040E9F8
		public static IEditorRestartInfo GetRootAsIEditorRestartInfo(ByteBuffer _bb)
		{
			return IEditorRestartInfo.GetRootAsIEditorRestartInfo(_bb, default(IEditorRestartInfo));
		}

		// Token: 0x0601CC11 RID: 117777 RVA: 0x00410814 File Offset: 0x0040EA14
		public static IEditorRestartInfo GetRootAsIEditorRestartInfo(ByteBuffer _bb, IEditorRestartInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CC12 RID: 117778 RVA: 0x00410831 File Offset: 0x0040EA31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CC13 RID: 117779 RVA: 0x00410840 File Offset: 0x0040EA40
		public IEditorRestartInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008577 RID: 34167
		// (get) Token: 0x0601CC14 RID: 117780 RVA: 0x00410850 File Offset: 0x0040EA50
		public bool IsRestarting
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008578 RID: 34168
		// (get) Token: 0x0601CC15 RID: 117781 RVA: 0x00410890 File Offset: 0x0040EA90
		public bool IsUseIdleLoad
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008579 RID: 34169
		// (get) Token: 0x0601CC16 RID: 117782 RVA: 0x004108D0 File Offset: 0x0040EAD0
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

		// Token: 0x1700857A RID: 34170
		// (get) Token: 0x0601CC17 RID: 117783 RVA: 0x0041090C File Offset: 0x0040EB0C
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

		// Token: 0x0601CC18 RID: 117784 RVA: 0x0041094A File Offset: 0x0040EB4A
		public static Offset<IEditorRestartInfo> CreateIEditorRestartInfo(FlatBufferBuilder builder, bool IsRestarting = false, bool IsUseIdleLoad = false, TEditorRestartReason Reason = TEditorRestartReason.ChangeMap, long Timestamp = 0L)
		{
			builder.StartTable(4);
			IEditorRestartInfo.AddTimestamp(builder, Timestamp);
			IEditorRestartInfo.AddReason(builder, Reason);
			IEditorRestartInfo.AddIsUseIdleLoad(builder, IsUseIdleLoad);
			IEditorRestartInfo.AddIsRestarting(builder, IsRestarting);
			return IEditorRestartInfo.EndIEditorRestartInfo(builder);
		}

		// Token: 0x0601CC19 RID: 117785 RVA: 0x00410976 File Offset: 0x0040EB76
		public static void StartIEditorRestartInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601CC1A RID: 117786 RVA: 0x0041097F File Offset: 0x0040EB7F
		public static void AddIsRestarting(FlatBufferBuilder builder, bool isRestarting)
		{
			builder.AddBool(0, isRestarting, false);
		}

		// Token: 0x0601CC1B RID: 117787 RVA: 0x0041098A File Offset: 0x0040EB8A
		public static void AddIsUseIdleLoad(FlatBufferBuilder builder, bool isUseIdleLoad)
		{
			builder.AddBool(1, isUseIdleLoad, false);
		}

		// Token: 0x0601CC1C RID: 117788 RVA: 0x00410995 File Offset: 0x0040EB95
		public static void AddReason(FlatBufferBuilder builder, TEditorRestartReason reason)
		{
			builder.AddByte(2, (byte)reason, 0);
		}

		// Token: 0x0601CC1D RID: 117789 RVA: 0x004109A0 File Offset: 0x0040EBA0
		public static void AddTimestamp(FlatBufferBuilder builder, long timestamp)
		{
			builder.AddLong(3, timestamp, 0L);
		}

		// Token: 0x0601CC1E RID: 117790 RVA: 0x004109AC File Offset: 0x0040EBAC
		public static Offset<IEditorRestartInfo> EndIEditorRestartInfo(FlatBufferBuilder builder)
		{
			return new Offset<IEditorRestartInfo>(builder.EndTable());
		}

		// Token: 0x0601CC1F RID: 117791 RVA: 0x004109BC File Offset: 0x0040EBBC
		public IEditorRestartInfoT UnPack()
		{
			IEditorRestartInfoT editorRestartInfoT = new IEditorRestartInfoT();
			this.UnPackTo(editorRestartInfoT);
			return editorRestartInfoT;
		}

		// Token: 0x0601CC20 RID: 117792 RVA: 0x004109D7 File Offset: 0x0040EBD7
		public void UnPackTo(IEditorRestartInfoT _o)
		{
			_o.IsRestarting = this.IsRestarting;
			_o.IsUseIdleLoad = this.IsUseIdleLoad;
			_o.Reason = this.Reason;
			_o.Timestamp = this.Timestamp;
		}

		// Token: 0x0601CC21 RID: 117793 RVA: 0x00410A0C File Offset: 0x0040EC0C
		public static Offset<IEditorRestartInfo> Pack(FlatBufferBuilder builder, IEditorRestartInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEditorRestartInfo>);
			}
			return IEditorRestartInfo.CreateIEditorRestartInfo(builder, _o.IsRestarting, _o.IsUseIdleLoad, _o.Reason, _o.Timestamp);
		}

		// Token: 0x0400CDD0 RID: 52688
		private Table __p;
	}
}
