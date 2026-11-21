using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F86 RID: 28550
	public struct IHeadStyleWarning : IFlatbufferObject
	{
		// Token: 0x1700D11B RID: 53531
		// (get) Token: 0x060316A4 RID: 202404 RVA: 0x006B3372 File Offset: 0x006B1572
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060316A5 RID: 202405 RVA: 0x006B337F File Offset: 0x006B157F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060316A6 RID: 202406 RVA: 0x006B3388 File Offset: 0x006B1588
		public static IHeadStyleWarning GetRootAsIHeadStyleWarning(ByteBuffer _bb)
		{
			return IHeadStyleWarning.GetRootAsIHeadStyleWarning(_bb, default(IHeadStyleWarning));
		}

		// Token: 0x060316A7 RID: 202407 RVA: 0x006B33A4 File Offset: 0x006B15A4
		public static IHeadStyleWarning GetRootAsIHeadStyleWarning(ByteBuffer _bb, IHeadStyleWarning obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060316A8 RID: 202408 RVA: 0x006B33C1 File Offset: 0x006B15C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060316A9 RID: 202409 RVA: 0x006B33D0 File Offset: 0x006B15D0
		public IHeadStyleWarning __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D11C RID: 53532
		// (get) Token: 0x060316AA RID: 202410 RVA: 0x006B33E0 File Offset: 0x006B15E0
		public EHeadStyle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHeadStyle.Normal;
				}
				return (EHeadStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060316AB RID: 202411 RVA: 0x006B341C File Offset: 0x006B161C
		public static Offset<IHeadStyleWarning> CreateIHeadStyleWarning(FlatBufferBuilder builder, EHeadStyle Type = EHeadStyle.Normal)
		{
			builder.StartTable(1);
			IHeadStyleWarning.AddType(builder, Type);
			return IHeadStyleWarning.EndIHeadStyleWarning(builder);
		}

		// Token: 0x060316AC RID: 202412 RVA: 0x006B3432 File Offset: 0x006B1632
		public static void StartIHeadStyleWarning(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060316AD RID: 202413 RVA: 0x006B343B File Offset: 0x006B163B
		public static void AddType(FlatBufferBuilder builder, EHeadStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060316AE RID: 202414 RVA: 0x006B3446 File Offset: 0x006B1646
		public static Offset<IHeadStyleWarning> EndIHeadStyleWarning(FlatBufferBuilder builder)
		{
			return new Offset<IHeadStyleWarning>(builder.EndTable());
		}

		// Token: 0x060316AF RID: 202415 RVA: 0x006B3454 File Offset: 0x006B1654
		public IHeadStyleWarningT UnPack()
		{
			IHeadStyleWarningT headStyleWarningT = new IHeadStyleWarningT();
			this.UnPackTo(headStyleWarningT);
			return headStyleWarningT;
		}

		// Token: 0x060316B0 RID: 202416 RVA: 0x006B346F File Offset: 0x006B166F
		public void UnPackTo(IHeadStyleWarningT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060316B1 RID: 202417 RVA: 0x006B3480 File Offset: 0x006B1680
		public static Offset<IHeadStyleWarning> Pack(FlatBufferBuilder builder, IHeadStyleWarningT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHeadStyleWarning>);
			}
			return IHeadStyleWarning.CreateIHeadStyleWarning(builder, _o.Type);
		}

		// Token: 0x04011E99 RID: 73369
		private Table __p;
	}
}
