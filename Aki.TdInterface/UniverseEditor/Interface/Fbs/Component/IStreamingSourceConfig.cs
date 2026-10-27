using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059D4 RID: 22996
	public struct IStreamingSourceConfig : IFlatbufferObject
	{
		// Token: 0x1700ACC7 RID: 44231
		// (get) Token: 0x0602702C RID: 159788 RVA: 0x0055E4D0 File Offset: 0x0055C6D0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602702D RID: 159789 RVA: 0x0055E4DD File Offset: 0x0055C6DD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602702E RID: 159790 RVA: 0x0055E4E4 File Offset: 0x0055C6E4
		public static IStreamingSourceConfig GetRootAsIStreamingSourceConfig(ByteBuffer _bb)
		{
			return IStreamingSourceConfig.GetRootAsIStreamingSourceConfig(_bb, default(IStreamingSourceConfig));
		}

		// Token: 0x0602702F RID: 159791 RVA: 0x0055E500 File Offset: 0x0055C700
		public static IStreamingSourceConfig GetRootAsIStreamingSourceConfig(ByteBuffer _bb, IStreamingSourceConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027030 RID: 159792 RVA: 0x0055E51D File Offset: 0x0055C71D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027031 RID: 159793 RVA: 0x0055E52C File Offset: 0x0055C72C
		public IStreamingSourceConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ACC8 RID: 44232
		// (get) Token: 0x06027032 RID: 159794 RVA: 0x0055E53C File Offset: 0x0055C73C
		public int StreamingSourceTargetEntityId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700ACC9 RID: 44233
		// (get) Token: 0x06027033 RID: 159795 RVA: 0x0055E578 File Offset: 0x0055C778
		public bool IsNoRenderStreaming
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700ACCA RID: 44234
		// (get) Token: 0x06027034 RID: 159796 RVA: 0x0055E5B8 File Offset: 0x0055C7B8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027035 RID: 159797 RVA: 0x0055E5F4 File Offset: 0x0055C7F4
		public static Offset<IStreamingSourceConfig> CreateIStreamingSourceConfig(FlatBufferBuilder builder, int StreamingSourceTargetEntityId = 0, bool IsNoRenderStreaming = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IStreamingSourceConfig.AddStreamingSourceTargetEntityId(builder, StreamingSourceTargetEntityId);
			IStreamingSourceConfig.AddNullMask(builder, NullMask);
			IStreamingSourceConfig.AddIsNoRenderStreaming(builder, IsNoRenderStreaming);
			return IStreamingSourceConfig.EndIStreamingSourceConfig(builder);
		}

		// Token: 0x06027036 RID: 159798 RVA: 0x0055E618 File Offset: 0x0055C818
		public static void StartIStreamingSourceConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06027037 RID: 159799 RVA: 0x0055E621 File Offset: 0x0055C821
		public static void AddStreamingSourceTargetEntityId(FlatBufferBuilder builder, int streamingSourceTargetEntityId)
		{
			builder.AddInt(0, streamingSourceTargetEntityId, 0);
		}

		// Token: 0x06027038 RID: 159800 RVA: 0x0055E62C File Offset: 0x0055C82C
		public static void AddIsNoRenderStreaming(FlatBufferBuilder builder, bool isNoRenderStreaming)
		{
			builder.AddBool(1, isNoRenderStreaming, false);
		}

		// Token: 0x06027039 RID: 159801 RVA: 0x0055E637 File Offset: 0x0055C837
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602703A RID: 159802 RVA: 0x0055E642 File Offset: 0x0055C842
		public static Offset<IStreamingSourceConfig> EndIStreamingSourceConfig(FlatBufferBuilder builder)
		{
			return new Offset<IStreamingSourceConfig>(builder.EndTable());
		}

		// Token: 0x0602703B RID: 159803 RVA: 0x0055E650 File Offset: 0x0055C850
		public IStreamingSourceConfigT UnPack()
		{
			IStreamingSourceConfigT streamingSourceConfigT = new IStreamingSourceConfigT();
			this.UnPackTo(streamingSourceConfigT);
			return streamingSourceConfigT;
		}

		// Token: 0x0602703C RID: 159804 RVA: 0x0055E66B File Offset: 0x0055C86B
		public void UnPackTo(IStreamingSourceConfigT _o)
		{
			_o.StreamingSourceTargetEntityId = this.StreamingSourceTargetEntityId;
			_o.IsNoRenderStreaming = this.IsNoRenderStreaming;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602703D RID: 159805 RVA: 0x0055E694 File Offset: 0x0055C894
		public static Offset<IStreamingSourceConfig> Pack(FlatBufferBuilder builder, IStreamingSourceConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStreamingSourceConfig>);
			}
			return IStreamingSourceConfig.CreateIStreamingSourceConfig(builder, _o.StreamingSourceTargetEntityId, _o.IsNoRenderStreaming, _o.NullMask);
		}

		// Token: 0x0400F007 RID: 61447
		private Table __p;
	}
}
