using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A23 RID: 27171
	public struct IClientEventUi : IFlatbufferObject
	{
		// Token: 0x1700C7BB RID: 51131
		// (get) Token: 0x0602E9C1 RID: 190913 RVA: 0x0065B030 File Offset: 0x00659230
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E9C2 RID: 190914 RVA: 0x0065B03D File Offset: 0x0065923D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E9C3 RID: 190915 RVA: 0x0065B044 File Offset: 0x00659244
		public static IClientEventUi GetRootAsIClientEventUi(ByteBuffer _bb)
		{
			return IClientEventUi.GetRootAsIClientEventUi(_bb, default(IClientEventUi));
		}

		// Token: 0x0602E9C4 RID: 190916 RVA: 0x0065B060 File Offset: 0x00659260
		public static IClientEventUi GetRootAsIClientEventUi(ByteBuffer _bb, IClientEventUi obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E9C5 RID: 190917 RVA: 0x0065B07D File Offset: 0x0065927D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E9C6 RID: 190918 RVA: 0x0065B08C File Offset: 0x0065928C
		public IClientEventUi __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C7BC RID: 51132
		// (get) Token: 0x0602E9C7 RID: 190919 RVA: 0x0065B09C File Offset: 0x0065929C
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

		// Token: 0x0602E9C8 RID: 190920 RVA: 0x0065B0D8 File Offset: 0x006592D8
		public static Offset<IClientEventUi> CreateIClientEventUi(FlatBufferBuilder builder, EClientEventUiType Type = EClientEventUiType.PlayPiano)
		{
			builder.StartTable(1);
			IClientEventUi.AddType(builder, Type);
			return IClientEventUi.EndIClientEventUi(builder);
		}

		// Token: 0x0602E9C9 RID: 190921 RVA: 0x0065B0EE File Offset: 0x006592EE
		public static void StartIClientEventUi(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E9CA RID: 190922 RVA: 0x0065B0F7 File Offset: 0x006592F7
		public static void AddType(FlatBufferBuilder builder, EClientEventUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E9CB RID: 190923 RVA: 0x0065B102 File Offset: 0x00659302
		public static Offset<IClientEventUi> EndIClientEventUi(FlatBufferBuilder builder)
		{
			return new Offset<IClientEventUi>(builder.EndTable());
		}

		// Token: 0x0602E9CC RID: 190924 RVA: 0x0065B110 File Offset: 0x00659310
		public IClientEventUiT UnPack()
		{
			IClientEventUiT clientEventUiT = new IClientEventUiT();
			this.UnPackTo(clientEventUiT);
			return clientEventUiT;
		}

		// Token: 0x0602E9CD RID: 190925 RVA: 0x0065B12B File Offset: 0x0065932B
		public void UnPackTo(IClientEventUiT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602E9CE RID: 190926 RVA: 0x0065B13C File Offset: 0x0065933C
		public static Offset<IClientEventUi> Pack(FlatBufferBuilder builder, IClientEventUiT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientEventUi>);
			}
			return IClientEventUi.CreateIClientEventUi(builder, _o.Type);
		}

		// Token: 0x0401179C RID: 71580
		private Table __p;
	}
}
