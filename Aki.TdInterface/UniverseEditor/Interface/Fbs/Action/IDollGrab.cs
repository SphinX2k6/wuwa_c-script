using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065FD RID: 26109
	public struct IDollGrab : IFlatbufferObject
	{
		// Token: 0x1700C1FF RID: 49663
		// (get) Token: 0x0602D54D RID: 185677 RVA: 0x00636A70 File Offset: 0x00634C70
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D54E RID: 185678 RVA: 0x00636A7D File Offset: 0x00634C7D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D54F RID: 185679 RVA: 0x00636A84 File Offset: 0x00634C84
		public static IDollGrab GetRootAsIDollGrab(ByteBuffer _bb)
		{
			return IDollGrab.GetRootAsIDollGrab(_bb, default(IDollGrab));
		}

		// Token: 0x0602D550 RID: 185680 RVA: 0x00636AA0 File Offset: 0x00634CA0
		public static IDollGrab GetRootAsIDollGrab(ByteBuffer _bb, IDollGrab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D551 RID: 185681 RVA: 0x00636ABD File Offset: 0x00634CBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D552 RID: 185682 RVA: 0x00636ACC File Offset: 0x00634CCC
		public IDollGrab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C200 RID: 49664
		// (get) Token: 0x0602D553 RID: 185683 RVA: 0x00636ADC File Offset: 0x00634CDC
		public ESimpleGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESimpleGameplayType.Cipher;
				}
				return (ESimpleGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C201 RID: 49665
		// (get) Token: 0x0602D554 RID: 185684 RVA: 0x00636B18 File Offset: 0x00634D18
		public int TargetDollGrabMachineId
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

		// Token: 0x0602D555 RID: 185685 RVA: 0x00636B54 File Offset: 0x00634D54
		public static Offset<IDollGrab> CreateIDollGrab(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, int TargetDollGrabMachineId = 0)
		{
			builder.StartTable(2);
			IDollGrab.AddTargetDollGrabMachineId(builder, TargetDollGrabMachineId);
			IDollGrab.AddType(builder, Type);
			return IDollGrab.EndIDollGrab(builder);
		}

		// Token: 0x0602D556 RID: 185686 RVA: 0x00636B71 File Offset: 0x00634D71
		public static void StartIDollGrab(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602D557 RID: 185687 RVA: 0x00636B7A File Offset: 0x00634D7A
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D558 RID: 185688 RVA: 0x00636B85 File Offset: 0x00634D85
		public static void AddTargetDollGrabMachineId(FlatBufferBuilder builder, int targetDollGrabMachineId)
		{
			builder.AddInt(1, targetDollGrabMachineId, 0);
		}

		// Token: 0x0602D559 RID: 185689 RVA: 0x00636B90 File Offset: 0x00634D90
		public static Offset<IDollGrab> EndIDollGrab(FlatBufferBuilder builder)
		{
			return new Offset<IDollGrab>(builder.EndTable());
		}

		// Token: 0x0602D55A RID: 185690 RVA: 0x00636BA0 File Offset: 0x00634DA0
		public IDollGrabT UnPack()
		{
			IDollGrabT dollGrabT = new IDollGrabT();
			this.UnPackTo(dollGrabT);
			return dollGrabT;
		}

		// Token: 0x0602D55B RID: 185691 RVA: 0x00636BBB File Offset: 0x00634DBB
		public void UnPackTo(IDollGrabT _o)
		{
			_o.Type = this.Type;
			_o.TargetDollGrabMachineId = this.TargetDollGrabMachineId;
		}

		// Token: 0x0602D55C RID: 185692 RVA: 0x00636BD8 File Offset: 0x00634DD8
		public static Offset<IDollGrab> Pack(FlatBufferBuilder builder, IDollGrabT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDollGrab>);
			}
			return IDollGrab.CreateIDollGrab(builder, _o.Type, _o.TargetDollGrabMachineId);
		}

		// Token: 0x04010C82 RID: 68738
		private Table __p;
	}
}
