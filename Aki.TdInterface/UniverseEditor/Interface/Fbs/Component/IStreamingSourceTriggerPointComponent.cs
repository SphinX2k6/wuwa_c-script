using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FEA RID: 24554
	public struct IStreamingSourceTriggerPointComponent : IFlatbufferObject
	{
		// Token: 0x1700B60B RID: 46603
		// (get) Token: 0x060295DE RID: 169438 RVA: 0x005A59E8 File Offset: 0x005A3BE8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060295DF RID: 169439 RVA: 0x005A59F5 File Offset: 0x005A3BF5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060295E0 RID: 169440 RVA: 0x005A59FC File Offset: 0x005A3BFC
		public static IStreamingSourceTriggerPointComponent GetRootAsIStreamingSourceTriggerPointComponent(ByteBuffer _bb)
		{
			return IStreamingSourceTriggerPointComponent.GetRootAsIStreamingSourceTriggerPointComponent(_bb, default(IStreamingSourceTriggerPointComponent));
		}

		// Token: 0x060295E1 RID: 169441 RVA: 0x005A5A18 File Offset: 0x005A3C18
		public static IStreamingSourceTriggerPointComponent GetRootAsIStreamingSourceTriggerPointComponent(ByteBuffer _bb, IStreamingSourceTriggerPointComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060295E2 RID: 169442 RVA: 0x005A5A35 File Offset: 0x005A3C35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060295E3 RID: 169443 RVA: 0x005A5A44 File Offset: 0x005A3C44
		public IStreamingSourceTriggerPointComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B60C RID: 46604
		// (get) Token: 0x060295E4 RID: 169444 RVA: 0x005A5A54 File Offset: 0x005A3C54
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B60D RID: 46605
		// (get) Token: 0x060295E5 RID: 169445 RVA: 0x005A5A94 File Offset: 0x005A3C94
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

		// Token: 0x1700B60E RID: 46606
		// (get) Token: 0x060295E6 RID: 169446 RVA: 0x005A5AD0 File Offset: 0x005A3CD0
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

		// Token: 0x060295E7 RID: 169447 RVA: 0x005A5B0C File Offset: 0x005A3D0C
		public TTable? StreamingSource<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060295E8 RID: 169448 RVA: 0x005A5B54 File Offset: 0x005A3D54
		public IConditionalStreamingSource StreamingSourceAsIConditionalStreamingSource()
		{
			return this.StreamingSource<IConditionalStreamingSource>().Value;
		}

		// Token: 0x060295E9 RID: 169449 RVA: 0x005A5B70 File Offset: 0x005A3D70
		public IFixedStreamingSource StreamingSourceAsIFixedStreamingSource()
		{
			return this.StreamingSource<IFixedStreamingSource>().Value;
		}

		// Token: 0x1700B60F RID: 46607
		// (get) Token: 0x060295EA RID: 169450 RVA: 0x005A5B8C File Offset: 0x005A3D8C
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

		// Token: 0x060295EB RID: 169451 RVA: 0x005A5BC9 File Offset: 0x005A3DC9
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

		// Token: 0x060295EC RID: 169452 RVA: 0x005A5BFD File Offset: 0x005A3DFD
		public static void StartIStreamingSourceTriggerPointComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060295ED RID: 169453 RVA: 0x005A5C06 File Offset: 0x005A3E06
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060295EE RID: 169454 RVA: 0x005A5C11 File Offset: 0x005A3E11
		public static void AddRadius(FlatBufferBuilder builder, int radius)
		{
			builder.AddInt(1, radius, 0);
		}

		// Token: 0x060295EF RID: 169455 RVA: 0x005A5C1C File Offset: 0x005A3E1C
		public static void AddStreamingSourceType(FlatBufferBuilder builder, TStreamingSourceConfig streamingSourceType)
		{
			builder.AddByte(2, (byte)streamingSourceType, 0);
		}

		// Token: 0x060295F0 RID: 169456 RVA: 0x005A5C27 File Offset: 0x005A3E27
		public static void AddStreamingSource(FlatBufferBuilder builder, int streamingSourceOffset)
		{
			builder.AddOffset(3, streamingSourceOffset, 0);
		}

		// Token: 0x060295F1 RID: 169457 RVA: 0x005A5C32 File Offset: 0x005A3E32
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060295F2 RID: 169458 RVA: 0x005A5C3D File Offset: 0x005A3E3D
		public static Offset<IStreamingSourceTriggerPointComponent> EndIStreamingSourceTriggerPointComponent(FlatBufferBuilder builder)
		{
			return new Offset<IStreamingSourceTriggerPointComponent>(builder.EndTable());
		}

		// Token: 0x060295F3 RID: 169459 RVA: 0x005A5C4C File Offset: 0x005A3E4C
		public IStreamingSourceTriggerPointComponentT UnPack()
		{
			IStreamingSourceTriggerPointComponentT streamingSourceTriggerPointComponentT = new IStreamingSourceTriggerPointComponentT();
			this.UnPackTo(streamingSourceTriggerPointComponentT);
			return streamingSourceTriggerPointComponentT;
		}

		// Token: 0x060295F4 RID: 169460 RVA: 0x005A5C68 File Offset: 0x005A3E68
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

		// Token: 0x060295F5 RID: 169461 RVA: 0x005A5D34 File Offset: 0x005A3F34
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

		// Token: 0x0400FD0B RID: 64779
		private Table __p;
	}
}
