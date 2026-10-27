using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068CD RID: 26829
	public struct IHeadStyleMonsterDisplay : IFlatbufferObject
	{
		// Token: 0x1700C712 RID: 50962
		// (get) Token: 0x0602ECB0 RID: 191664 RVA: 0x00662C29 File Offset: 0x00660E29
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602ECB1 RID: 191665 RVA: 0x00662C36 File Offset: 0x00660E36
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602ECB2 RID: 191666 RVA: 0x00662C40 File Offset: 0x00660E40
		public static IHeadStyleMonsterDisplay GetRootAsIHeadStyleMonsterDisplay(ByteBuffer _bb)
		{
			return IHeadStyleMonsterDisplay.GetRootAsIHeadStyleMonsterDisplay(_bb, default(IHeadStyleMonsterDisplay));
		}

		// Token: 0x0602ECB3 RID: 191667 RVA: 0x00662C5C File Offset: 0x00660E5C
		public static IHeadStyleMonsterDisplay GetRootAsIHeadStyleMonsterDisplay(ByteBuffer _bb, IHeadStyleMonsterDisplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602ECB4 RID: 191668 RVA: 0x00662C79 File Offset: 0x00660E79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602ECB5 RID: 191669 RVA: 0x00662C88 File Offset: 0x00660E88
		public IHeadStyleMonsterDisplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C713 RID: 50963
		// (get) Token: 0x0602ECB6 RID: 191670 RVA: 0x00662C98 File Offset: 0x00660E98
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

		// Token: 0x1700C714 RID: 50964
		// (get) Token: 0x0602ECB7 RID: 191671 RVA: 0x00662CD4 File Offset: 0x00660ED4
		public int MonsterDisplayId
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

		// Token: 0x0602ECB8 RID: 191672 RVA: 0x00662D10 File Offset: 0x00660F10
		public static Offset<IHeadStyleMonsterDisplay> CreateIHeadStyleMonsterDisplay(FlatBufferBuilder builder, EHeadStyle Type = EHeadStyle.Normal, int MonsterDisplayId = 0)
		{
			builder.StartTable(2);
			IHeadStyleMonsterDisplay.AddMonsterDisplayId(builder, MonsterDisplayId);
			IHeadStyleMonsterDisplay.AddType(builder, Type);
			return IHeadStyleMonsterDisplay.EndIHeadStyleMonsterDisplay(builder);
		}

		// Token: 0x0602ECB9 RID: 191673 RVA: 0x00662D2D File Offset: 0x00660F2D
		public static void StartIHeadStyleMonsterDisplay(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602ECBA RID: 191674 RVA: 0x00662D36 File Offset: 0x00660F36
		public static void AddType(FlatBufferBuilder builder, EHeadStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602ECBB RID: 191675 RVA: 0x00662D41 File Offset: 0x00660F41
		public static void AddMonsterDisplayId(FlatBufferBuilder builder, int monsterDisplayId)
		{
			builder.AddInt(1, monsterDisplayId, 0);
		}

		// Token: 0x0602ECBC RID: 191676 RVA: 0x00662D4C File Offset: 0x00660F4C
		public static Offset<IHeadStyleMonsterDisplay> EndIHeadStyleMonsterDisplay(FlatBufferBuilder builder)
		{
			return new Offset<IHeadStyleMonsterDisplay>(builder.EndTable());
		}

		// Token: 0x0602ECBD RID: 191677 RVA: 0x00662D5C File Offset: 0x00660F5C
		public IHeadStyleMonsterDisplayT UnPack()
		{
			IHeadStyleMonsterDisplayT headStyleMonsterDisplayT = new IHeadStyleMonsterDisplayT();
			this.UnPackTo(headStyleMonsterDisplayT);
			return headStyleMonsterDisplayT;
		}

		// Token: 0x0602ECBE RID: 191678 RVA: 0x00662D77 File Offset: 0x00660F77
		public void UnPackTo(IHeadStyleMonsterDisplayT _o)
		{
			_o.Type = this.Type;
			_o.MonsterDisplayId = this.MonsterDisplayId;
		}

		// Token: 0x0602ECBF RID: 191679 RVA: 0x00662D94 File Offset: 0x00660F94
		public static Offset<IHeadStyleMonsterDisplay> Pack(FlatBufferBuilder builder, IHeadStyleMonsterDisplayT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHeadStyleMonsterDisplay>);
			}
			return IHeadStyleMonsterDisplay.CreateIHeadStyleMonsterDisplay(builder, _o.Type, _o.MonsterDisplayId);
		}

		// Token: 0x04011029 RID: 69673
		private Table __p;
	}
}
