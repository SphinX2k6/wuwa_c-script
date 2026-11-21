using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B45 RID: 27461
	public struct IControlTrackingSelf : IFlatbufferObject
	{
		// Token: 0x1700C9A9 RID: 51625
		// (get) Token: 0x0602F418 RID: 193560 RVA: 0x00673A47 File Offset: 0x00671C47
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F419 RID: 193561 RVA: 0x00673A54 File Offset: 0x00671C54
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F41A RID: 193562 RVA: 0x00673A5C File Offset: 0x00671C5C
		public static IControlTrackingSelf GetRootAsIControlTrackingSelf(ByteBuffer _bb)
		{
			return IControlTrackingSelf.GetRootAsIControlTrackingSelf(_bb, default(IControlTrackingSelf));
		}

		// Token: 0x0602F41B RID: 193563 RVA: 0x00673A78 File Offset: 0x00671C78
		public static IControlTrackingSelf GetRootAsIControlTrackingSelf(ByteBuffer _bb, IControlTrackingSelf obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F41C RID: 193564 RVA: 0x00673A95 File Offset: 0x00671C95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F41D RID: 193565 RVA: 0x00673AA4 File Offset: 0x00671CA4
		public IControlTrackingSelf __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C9AA RID: 51626
		// (get) Token: 0x0602F41E RID: 193566 RVA: 0x00673AB4 File Offset: 0x00671CB4
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

		// Token: 0x0602F41F RID: 193567 RVA: 0x00673AF0 File Offset: 0x00671CF0
		public static Offset<IControlTrackingSelf> CreateIControlTrackingSelf(FlatBufferBuilder builder, EControlTrackingType Type = EControlTrackingType.Self)
		{
			builder.StartTable(1);
			IControlTrackingSelf.AddType(builder, Type);
			return IControlTrackingSelf.EndIControlTrackingSelf(builder);
		}

		// Token: 0x0602F420 RID: 193568 RVA: 0x00673B06 File Offset: 0x00671D06
		public static void StartIControlTrackingSelf(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F421 RID: 193569 RVA: 0x00673B0F File Offset: 0x00671D0F
		public static void AddType(FlatBufferBuilder builder, EControlTrackingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F422 RID: 193570 RVA: 0x00673B1A File Offset: 0x00671D1A
		public static Offset<IControlTrackingSelf> EndIControlTrackingSelf(FlatBufferBuilder builder)
		{
			return new Offset<IControlTrackingSelf>(builder.EndTable());
		}

		// Token: 0x0602F423 RID: 193571 RVA: 0x00673B28 File Offset: 0x00671D28
		public IControlTrackingSelfT UnPack()
		{
			IControlTrackingSelfT controlTrackingSelfT = new IControlTrackingSelfT();
			this.UnPackTo(controlTrackingSelfT);
			return controlTrackingSelfT;
		}

		// Token: 0x0602F424 RID: 193572 RVA: 0x00673B43 File Offset: 0x00671D43
		public void UnPackTo(IControlTrackingSelfT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602F425 RID: 193573 RVA: 0x00673B54 File Offset: 0x00671D54
		public static Offset<IControlTrackingSelf> Pack(FlatBufferBuilder builder, IControlTrackingSelfT _o)
		{
			if (_o == null)
			{
				return default(Offset<IControlTrackingSelf>);
			}
			return IControlTrackingSelf.CreateIControlTrackingSelf(builder, _o.Type);
		}

		// Token: 0x0401192B RID: 71979
		private Table __p;
	}
}
