using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C6E RID: 27758
	public struct IDollGrab : IFlatbufferObject
	{
		// Token: 0x1700CB9D RID: 52125
		// (get) Token: 0x0602FD1E RID: 195870 RVA: 0x006835D8 File Offset: 0x006817D8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FD1F RID: 195871 RVA: 0x006835E5 File Offset: 0x006817E5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FD20 RID: 195872 RVA: 0x006835EC File Offset: 0x006817EC
		public static IDollGrab GetRootAsIDollGrab(ByteBuffer _bb)
		{
			return IDollGrab.GetRootAsIDollGrab(_bb, default(IDollGrab));
		}

		// Token: 0x0602FD21 RID: 195873 RVA: 0x00683608 File Offset: 0x00681808
		public static IDollGrab GetRootAsIDollGrab(ByteBuffer _bb, IDollGrab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FD22 RID: 195874 RVA: 0x00683625 File Offset: 0x00681825
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FD23 RID: 195875 RVA: 0x00683634 File Offset: 0x00681834
		public IDollGrab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CB9E RID: 52126
		// (get) Token: 0x0602FD24 RID: 195876 RVA: 0x00683644 File Offset: 0x00681844
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

		// Token: 0x1700CB9F RID: 52127
		// (get) Token: 0x0602FD25 RID: 195877 RVA: 0x00683680 File Offset: 0x00681880
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

		// Token: 0x0602FD26 RID: 195878 RVA: 0x006836BC File Offset: 0x006818BC
		public static Offset<IDollGrab> CreateIDollGrab(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, int TargetDollGrabMachineId = 0)
		{
			builder.StartTable(2);
			IDollGrab.AddTargetDollGrabMachineId(builder, TargetDollGrabMachineId);
			IDollGrab.AddType(builder, Type);
			return IDollGrab.EndIDollGrab(builder);
		}

		// Token: 0x0602FD27 RID: 195879 RVA: 0x006836D9 File Offset: 0x006818D9
		public static void StartIDollGrab(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602FD28 RID: 195880 RVA: 0x006836E2 File Offset: 0x006818E2
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FD29 RID: 195881 RVA: 0x006836ED File Offset: 0x006818ED
		public static void AddTargetDollGrabMachineId(FlatBufferBuilder builder, int targetDollGrabMachineId)
		{
			builder.AddInt(1, targetDollGrabMachineId, 0);
		}

		// Token: 0x0602FD2A RID: 195882 RVA: 0x006836F8 File Offset: 0x006818F8
		public static Offset<IDollGrab> EndIDollGrab(FlatBufferBuilder builder)
		{
			return new Offset<IDollGrab>(builder.EndTable());
		}

		// Token: 0x0602FD2B RID: 195883 RVA: 0x00683708 File Offset: 0x00681908
		public IDollGrabT UnPack()
		{
			IDollGrabT dollGrabT = new IDollGrabT();
			this.UnPackTo(dollGrabT);
			return dollGrabT;
		}

		// Token: 0x0602FD2C RID: 195884 RVA: 0x00683723 File Offset: 0x00681923
		public void UnPackTo(IDollGrabT _o)
		{
			_o.Type = this.Type;
			_o.TargetDollGrabMachineId = this.TargetDollGrabMachineId;
		}

		// Token: 0x0602FD2D RID: 195885 RVA: 0x00683740 File Offset: 0x00681940
		public static Offset<IDollGrab> Pack(FlatBufferBuilder builder, IDollGrabT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDollGrab>);
			}
			return IDollGrab.CreateIDollGrab(builder, _o.Type, _o.TargetDollGrabMachineId);
		}

		// Token: 0x04011A9D RID: 72349
		private Table __p;
	}
}
