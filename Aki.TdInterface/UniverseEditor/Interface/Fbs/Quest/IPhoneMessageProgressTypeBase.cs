using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043BB RID: 17339
	public struct IPhoneMessageProgressTypeBase : IFlatbufferObject
	{
		// Token: 0x1700776D RID: 30573
		// (get) Token: 0x060189AD RID: 100781 RVA: 0x00382950 File Offset: 0x00380B50
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060189AE RID: 100782 RVA: 0x0038295D File Offset: 0x00380B5D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060189AF RID: 100783 RVA: 0x00382964 File Offset: 0x00380B64
		public static IPhoneMessageProgressTypeBase GetRootAsIPhoneMessageProgressTypeBase(ByteBuffer _bb)
		{
			return IPhoneMessageProgressTypeBase.GetRootAsIPhoneMessageProgressTypeBase(_bb, default(IPhoneMessageProgressTypeBase));
		}

		// Token: 0x060189B0 RID: 100784 RVA: 0x00382980 File Offset: 0x00380B80
		public static IPhoneMessageProgressTypeBase GetRootAsIPhoneMessageProgressTypeBase(ByteBuffer _bb, IPhoneMessageProgressTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060189B1 RID: 100785 RVA: 0x0038299D File Offset: 0x00380B9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060189B2 RID: 100786 RVA: 0x003829AC File Offset: 0x00380BAC
		public IPhoneMessageProgressTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700776E RID: 30574
		// (get) Token: 0x060189B3 RID: 100787 RVA: 0x003829BC File Offset: 0x00380BBC
		public EPhoneMessageProgressType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPhoneMessageProgressType.CompleteMessage;
				}
				return (EPhoneMessageProgressType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060189B4 RID: 100788 RVA: 0x003829F8 File Offset: 0x00380BF8
		public static Offset<IPhoneMessageProgressTypeBase> CreateIPhoneMessageProgressTypeBase(FlatBufferBuilder builder, EPhoneMessageProgressType Type = EPhoneMessageProgressType.CompleteMessage)
		{
			builder.StartTable(1);
			IPhoneMessageProgressTypeBase.AddType(builder, Type);
			return IPhoneMessageProgressTypeBase.EndIPhoneMessageProgressTypeBase(builder);
		}

		// Token: 0x060189B5 RID: 100789 RVA: 0x00382A0E File Offset: 0x00380C0E
		public static void StartIPhoneMessageProgressTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060189B6 RID: 100790 RVA: 0x00382A17 File Offset: 0x00380C17
		public static void AddType(FlatBufferBuilder builder, EPhoneMessageProgressType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060189B7 RID: 100791 RVA: 0x00382A22 File Offset: 0x00380C22
		public static Offset<IPhoneMessageProgressTypeBase> EndIPhoneMessageProgressTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<IPhoneMessageProgressTypeBase>(builder.EndTable());
		}

		// Token: 0x060189B8 RID: 100792 RVA: 0x00382A30 File Offset: 0x00380C30
		public IPhoneMessageProgressTypeBaseT UnPack()
		{
			IPhoneMessageProgressTypeBaseT phoneMessageProgressTypeBaseT = new IPhoneMessageProgressTypeBaseT();
			this.UnPackTo(phoneMessageProgressTypeBaseT);
			return phoneMessageProgressTypeBaseT;
		}

		// Token: 0x060189B9 RID: 100793 RVA: 0x00382A4B File Offset: 0x00380C4B
		public void UnPackTo(IPhoneMessageProgressTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060189BA RID: 100794 RVA: 0x00382A5C File Offset: 0x00380C5C
		public static Offset<IPhoneMessageProgressTypeBase> Pack(FlatBufferBuilder builder, IPhoneMessageProgressTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhoneMessageProgressTypeBase>);
			}
			return IPhoneMessageProgressTypeBase.CreateIPhoneMessageProgressTypeBase(builder, _o.Type);
		}

		// Token: 0x0400C3B2 RID: 50098
		private Table __p;
	}
}
