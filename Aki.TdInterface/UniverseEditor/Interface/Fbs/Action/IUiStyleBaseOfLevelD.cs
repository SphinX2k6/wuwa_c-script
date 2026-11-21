using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CA1 RID: 31905
	public struct IUiStyleBaseOfLevelD : IFlatbufferObject
	{
		// Token: 0x1700EEDC RID: 61148
		// (get) Token: 0x060398D7 RID: 235735 RVA: 0x007C46F6 File Offset: 0x007C28F6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060398D8 RID: 235736 RVA: 0x007C4703 File Offset: 0x007C2903
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060398D9 RID: 235737 RVA: 0x007C470C File Offset: 0x007C290C
		public static IUiStyleBaseOfLevelD GetRootAsIUiStyleBaseOfLevelD(ByteBuffer _bb)
		{
			return IUiStyleBaseOfLevelD.GetRootAsIUiStyleBaseOfLevelD(_bb, default(IUiStyleBaseOfLevelD));
		}

		// Token: 0x060398DA RID: 235738 RVA: 0x007C4728 File Offset: 0x007C2928
		public static IUiStyleBaseOfLevelD GetRootAsIUiStyleBaseOfLevelD(ByteBuffer _bb, IUiStyleBaseOfLevelD obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060398DB RID: 235739 RVA: 0x007C4745 File Offset: 0x007C2945
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060398DC RID: 235740 RVA: 0x007C4754 File Offset: 0x007C2954
		public IUiStyleBaseOfLevelD __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EEDD RID: 61149
		// (get) Token: 0x060398DD RID: 235741 RVA: 0x007C4764 File Offset: 0x007C2964
		public EUiStyleTypeOfLevelD Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EUiStyleTypeOfLevelD.GiantSubtitle;
				}
				return (EUiStyleTypeOfLevelD)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060398DE RID: 235742 RVA: 0x007C47A0 File Offset: 0x007C29A0
		public static Offset<IUiStyleBaseOfLevelD> CreateIUiStyleBaseOfLevelD(FlatBufferBuilder builder, EUiStyleTypeOfLevelD Type = EUiStyleTypeOfLevelD.GiantSubtitle)
		{
			builder.StartTable(1);
			IUiStyleBaseOfLevelD.AddType(builder, Type);
			return IUiStyleBaseOfLevelD.EndIUiStyleBaseOfLevelD(builder);
		}

		// Token: 0x060398DF RID: 235743 RVA: 0x007C47B6 File Offset: 0x007C29B6
		public static void StartIUiStyleBaseOfLevelD(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060398E0 RID: 235744 RVA: 0x007C47BF File Offset: 0x007C29BF
		public static void AddType(FlatBufferBuilder builder, EUiStyleTypeOfLevelD type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060398E1 RID: 235745 RVA: 0x007C47CA File Offset: 0x007C29CA
		public static Offset<IUiStyleBaseOfLevelD> EndIUiStyleBaseOfLevelD(FlatBufferBuilder builder)
		{
			return new Offset<IUiStyleBaseOfLevelD>(builder.EndTable());
		}

		// Token: 0x060398E2 RID: 235746 RVA: 0x007C47D8 File Offset: 0x007C29D8
		public IUiStyleBaseOfLevelDT UnPack()
		{
			IUiStyleBaseOfLevelDT uiStyleBaseOfLevelDT = new IUiStyleBaseOfLevelDT();
			this.UnPackTo(uiStyleBaseOfLevelDT);
			return uiStyleBaseOfLevelDT;
		}

		// Token: 0x060398E3 RID: 235747 RVA: 0x007C47F3 File Offset: 0x007C29F3
		public void UnPackTo(IUiStyleBaseOfLevelDT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060398E4 RID: 235748 RVA: 0x007C4804 File Offset: 0x007C2A04
		public static Offset<IUiStyleBaseOfLevelD> Pack(FlatBufferBuilder builder, IUiStyleBaseOfLevelDT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUiStyleBaseOfLevelD>);
			}
			return IUiStyleBaseOfLevelD.CreateIUiStyleBaseOfLevelD(builder, _o.Type);
		}

		// Token: 0x0401339C RID: 78748
		private Table __p;
	}
}
