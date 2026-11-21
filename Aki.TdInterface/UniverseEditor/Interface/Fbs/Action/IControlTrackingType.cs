using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B48 RID: 27464
	public struct IControlTrackingType : IFlatbufferObject
	{
		// Token: 0x1700C9AC RID: 51628
		// (get) Token: 0x0602F42A RID: 193578 RVA: 0x00673BBD File Offset: 0x00671DBD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F42B RID: 193579 RVA: 0x00673BCA File Offset: 0x00671DCA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F42C RID: 193580 RVA: 0x00673BD4 File Offset: 0x00671DD4
		public static IControlTrackingType GetRootAsIControlTrackingType(ByteBuffer _bb)
		{
			return IControlTrackingType.GetRootAsIControlTrackingType(_bb, default(IControlTrackingType));
		}

		// Token: 0x0602F42D RID: 193581 RVA: 0x00673BF0 File Offset: 0x00671DF0
		public static IControlTrackingType GetRootAsIControlTrackingType(ByteBuffer _bb, IControlTrackingType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F42E RID: 193582 RVA: 0x00673C0D File Offset: 0x00671E0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F42F RID: 193583 RVA: 0x00673C1C File Offset: 0x00671E1C
		public IControlTrackingType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C9AD RID: 51629
		// (get) Token: 0x0602F430 RID: 193584 RVA: 0x00673C2C File Offset: 0x00671E2C
		public EControlTrackingType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EControlTrackingType.Self;
				}
				return (EControlTrackingType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F431 RID: 193585 RVA: 0x00673C68 File Offset: 0x00671E68
		public static Offset<IControlTrackingType> CreateIControlTrackingType(FlatBufferBuilder builder, EControlTrackingType Type = EControlTrackingType.Self)
		{
			builder.StartTable(1);
			IControlTrackingType.AddType(builder, Type);
			return IControlTrackingType.EndIControlTrackingType(builder);
		}

		// Token: 0x0602F432 RID: 193586 RVA: 0x00673C7E File Offset: 0x00671E7E
		public static void StartIControlTrackingType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F433 RID: 193587 RVA: 0x00673C87 File Offset: 0x00671E87
		public static void AddType(FlatBufferBuilder builder, EControlTrackingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F434 RID: 193588 RVA: 0x00673C92 File Offset: 0x00671E92
		public static Offset<IControlTrackingType> EndIControlTrackingType(FlatBufferBuilder builder)
		{
			return new Offset<IControlTrackingType>(builder.EndTable());
		}

		// Token: 0x0602F435 RID: 193589 RVA: 0x00673CA0 File Offset: 0x00671EA0
		public IControlTrackingTypeT UnPack()
		{
			IControlTrackingTypeT controlTrackingTypeT = new IControlTrackingTypeT();
			this.UnPackTo(controlTrackingTypeT);
			return controlTrackingTypeT;
		}

		// Token: 0x0602F436 RID: 193590 RVA: 0x00673CBB File Offset: 0x00671EBB
		public void UnPackTo(IControlTrackingTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602F437 RID: 193591 RVA: 0x00673CCC File Offset: 0x00671ECC
		public static Offset<IControlTrackingType> Pack(FlatBufferBuilder builder, IControlTrackingTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IControlTrackingType>);
			}
			return IControlTrackingType.CreateIControlTrackingType(builder, _o.Type);
		}

		// Token: 0x0401192D RID: 71981
		private Table __p;
	}
}
