using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063B2 RID: 25522
	public struct IClientEventUi : IFlatbufferObject
	{
		// Token: 0x1700BE37 RID: 48695
		// (get) Token: 0x0602C25F RID: 180831 RVA: 0x0060FFF8 File Offset: 0x0060E1F8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C260 RID: 180832 RVA: 0x00610005 File Offset: 0x0060E205
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C261 RID: 180833 RVA: 0x0061000C File Offset: 0x0060E20C
		public static IClientEventUi GetRootAsIClientEventUi(ByteBuffer _bb)
		{
			return IClientEventUi.GetRootAsIClientEventUi(_bb, default(IClientEventUi));
		}

		// Token: 0x0602C262 RID: 180834 RVA: 0x00610028 File Offset: 0x0060E228
		public static IClientEventUi GetRootAsIClientEventUi(ByteBuffer _bb, IClientEventUi obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C263 RID: 180835 RVA: 0x00610045 File Offset: 0x0060E245
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C264 RID: 180836 RVA: 0x00610054 File Offset: 0x0060E254
		public IClientEventUi __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE38 RID: 48696
		// (get) Token: 0x0602C265 RID: 180837 RVA: 0x00610064 File Offset: 0x0060E264
		public EClientEventUiType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EClientEventUiType.PlayPiano;
				}
				return (EClientEventUiType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C266 RID: 180838 RVA: 0x006100A0 File Offset: 0x0060E2A0
		public static Offset<IClientEventUi> CreateIClientEventUi(FlatBufferBuilder builder, EClientEventUiType Type = EClientEventUiType.PlayPiano)
		{
			builder.StartTable(1);
			IClientEventUi.AddType(builder, Type);
			return IClientEventUi.EndIClientEventUi(builder);
		}

		// Token: 0x0602C267 RID: 180839 RVA: 0x006100B6 File Offset: 0x0060E2B6
		public static void StartIClientEventUi(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602C268 RID: 180840 RVA: 0x006100BF File Offset: 0x0060E2BF
		public static void AddType(FlatBufferBuilder builder, EClientEventUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C269 RID: 180841 RVA: 0x006100CA File Offset: 0x0060E2CA
		public static Offset<IClientEventUi> EndIClientEventUi(FlatBufferBuilder builder)
		{
			return new Offset<IClientEventUi>(builder.EndTable());
		}

		// Token: 0x0602C26A RID: 180842 RVA: 0x006100D8 File Offset: 0x0060E2D8
		public IClientEventUiT UnPack()
		{
			IClientEventUiT clientEventUiT = new IClientEventUiT();
			this.UnPackTo(clientEventUiT);
			return clientEventUiT;
		}

		// Token: 0x0602C26B RID: 180843 RVA: 0x006100F3 File Offset: 0x0060E2F3
		public void UnPackTo(IClientEventUiT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602C26C RID: 180844 RVA: 0x00610104 File Offset: 0x0060E304
		public static Offset<IClientEventUi> Pack(FlatBufferBuilder builder, IClientEventUiT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientEventUi>);
			}
			return IClientEventUi.CreateIClientEventUi(builder, _o.Type);
		}

		// Token: 0x04010989 RID: 67977
		private Table __p;
	}
}
