using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059DD RID: 23005
	public struct IStreamingSourceTriggerPointComponent : IFlatbufferObject
	{
		// Token: 0x1700ACD3 RID: 44243
		// (get) Token: 0x06027066 RID: 159846 RVA: 0x0055EA24 File Offset: 0x0055CC24
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027067 RID: 159847 RVA: 0x0055EA31 File Offset: 0x0055CC31
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027068 RID: 159848 RVA: 0x0055EA38 File Offset: 0x0055CC38
		public static IStreamingSourceTriggerPointComponent GetRootAsIStreamingSourceTriggerPointComponent(ByteBuffer _bb)
		{
			return IStreamingSourceTriggerPointComponent.GetRootAsIStreamingSourceTriggerPointComponent(_bb, default(IStreamingSourceTriggerPointComponent));
		}

		// Token: 0x06027069 RID: 159849 RVA: 0x0055EA54 File Offset: 0x0055CC54
		public static IStreamingSourceTriggerPointComponent GetRootAsIStreamingSourceTriggerPointComponent(ByteBuffer _bb, IStreamingSourceTriggerPointComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602706A RID: 159850 RVA: 0x0055EA71 File Offset: 0x0055CC71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602706B RID: 159851 RVA: 0x0055EA80 File Offset: 0x0055CC80
		public IStreamingSourceTriggerPointComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ACD4 RID: 44244
		// (get) Token: 0x0602706C RID: 159852 RVA: 0x0055EA90 File Offset: 0x0055CC90
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700ACD5 RID: 44245
		// (get) Token: 0x0602706D RID: 159853 RVA: 0x0055EAD0 File Offset: 0x0055CCD0
		public int Radius
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

		// Token: 0x1700ACD6 RID: 44246
		// (get) Token: 0x0602706E RID: 159854 RVA: 0x0055EB0C File Offset: 0x0055CD0C
		public TStreamingSourceConfig StreamingSourceType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TStreamingSourceConfig.NONE;
				}
				return (TStreamingSourceConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602706F RID: 159855 RVA: 0x0055EB48 File Offset: 0x0055CD48
		public TTable? StreamingSource<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06027070 RID: 159856 RVA: 0x0055EB90 File Offset: 0x0055CD90
		public IConditionalStreamingSource StreamingSourceAsIConditionalStreamingSource()
		{
			return this.StreamingSource<IConditionalStreamingSource>().Value;
		}

		// Token: 0x06027071 RID: 159857 RVA: 0x0055EBAC File Offset: 0x0055CDAC
		public IFixedStreamingSource StreamingSourceAsIFixedStreamingSource()
		{
			return this.StreamingSource<IFixedStreamingSource>().Value;
		}

		// Token: 0x1700ACD7 RID: 44247
		// (get) Token: 0x06027072 RID: 159858 RVA: 0x0055EBC8 File Offset: 0x0055CDC8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027073 RID: 159859 RVA: 0x0055EC05 File Offset: 0x0055CE05
		public static Offset<IStreamingSourceTriggerPointComponent> CreateIStreamingSourceTriggerPointComponent(FlatBufferBuilder builder, bool Disabled = false, int Radius = 0, TStreamingSourceConfig StreamingSource_type = TStreamingSourceConfig.NONE, int StreamingSourceOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(5);
			IStreamingSourceTriggerPointComponent.AddStreamingSource(builder, StreamingSourceOffset);
			IStreamingSourceTriggerPointComponent.AddRadius(builder, Radius);
			IStreamingSourceTriggerPointComponent.AddNullMask(builder, NullMask);
			IStreamingSourceTriggerPointComponent.AddStreamingSourceType(builder, StreamingSource_type);
			IStreamingSourceTriggerPointComponent.AddDisabled(builder, Disabled);
			return IStreamingSourceTriggerPointComponent.EndIStreamingSourceTriggerPointComponent(builder);
		}

		// Token: 0x06027074 RID: 159860 RVA: 0x0055EC39 File Offset: 0x0055CE39
		public static void StartIStreamingSourceTriggerPointComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06027075 RID: 159861 RVA: 0x0055EC42 File Offset: 0x0055CE42
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06027076 RID: 159862 RVA: 0x0055EC4D File Offset: 0x0055CE4D
		public static void AddRadius(FlatBufferBuilder builder, int radius)
		{
			builder.AddInt(1, radius, 0);
		}

		// Token: 0x06027077 RID: 159863 RVA: 0x0055EC58 File Offset: 0x0055CE58
		public static void AddStreamingSourceType(FlatBufferBuilder builder, TStreamingSourceConfig streamingSourceType)
		{
			builder.AddByte(2, (byte)streamingSourceType, 0);
		}

		// Token: 0x06027078 RID: 159864 RVA: 0x0055EC63 File Offset: 0x0055CE63
		public static void AddStreamingSource(FlatBufferBuilder builder, int streamingSourceOffset)
		{
			builder.AddOffset(3, streamingSourceOffset, 0);
		}

		// Token: 0x06027079 RID: 159865 RVA: 0x0055EC6E File Offset: 0x0055CE6E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602707A RID: 159866 RVA: 0x0055EC79 File Offset: 0x0055CE79
		public static Offset<IStreamingSourceTriggerPointComponent> EndIStreamingSourceTriggerPointComponent(FlatBufferBuilder builder)
		{
			return new Offset<IStreamingSourceTriggerPointComponent>(builder.EndTable());
		}

		// Token: 0x0602707B RID: 159867 RVA: 0x0055EC88 File Offset: 0x0055CE88
		public IStreamingSourceTriggerPointComponentT UnPack()
		{
			IStreamingSourceTriggerPointComponentT streamingSourceTriggerPointComponentT = new IStreamingSourceTriggerPointComponentT();
			this.UnPackTo(streamingSourceTriggerPointComponentT);
			return streamingSourceTriggerPointComponentT;
		}

		// Token: 0x0602707C RID: 159868 RVA: 0x0055ECA4 File Offset: 0x0055CEA4
		public void UnPackTo(IStreamingSourceTriggerPointComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Radius = this.Radius;
			_o.StreamingSource = new TStreamingSourceConfigUnion();
			_o.StreamingSource.Type = this.StreamingSourceType;
			TStreamingSourceConfig streamingSourceType = this.StreamingSourceType;
			if (streamingSourceType != TStreamingSourceConfig.IConditionalStreamingSource)
			{
				if (streamingSourceType == TStreamingSourceConfig.IFixedStreamingSource)
				{
					_o.StreamingSource.Value = ((this.StreamingSource<IFixedStreamingSource>() != null) ? this.StreamingSource<IFixedStreamingSource>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.StreamingSource.Value = ((this.StreamingSource<IConditionalStreamingSource>() != null) ? this.StreamingSource<IConditionalStreamingSource>().Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602707D RID: 159869 RVA: 0x0055ED70 File Offset: 0x0055CF70
		public static Offset<IStreamingSourceTriggerPointComponent> Pack(FlatBufferBuilder builder, IStreamingSourceTriggerPointComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStreamingSourceTriggerPointComponent>);
			}
			TStreamingSourceConfig streamingSource_type = (_o.StreamingSource == null) ? TStreamingSourceConfig.NONE : _o.StreamingSource.Type;
			int streamingSourceOffset = (_o.StreamingSource == null) ? 0 : TStreamingSourceConfigUnion.Pack(builder, _o.StreamingSource);
			return IStreamingSourceTriggerPointComponent.CreateIStreamingSourceTriggerPointComponent(builder, _o.Disabled, _o.Radius, streamingSource_type, streamingSourceOffset, _o.NullMask);
		}

		// Token: 0x0400F014 RID: 61460
		private Table __p;
	}
}
