using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007148 RID: 29000
	public struct ISlideRailEndType : IFlatbufferObject
	{
		// Token: 0x1700D778 RID: 55160
		// (get) Token: 0x06033692 RID: 210578 RVA: 0x006ED8F5 File Offset: 0x006EBAF5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033693 RID: 210579 RVA: 0x006ED902 File Offset: 0x006EBB02
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033694 RID: 210580 RVA: 0x006ED90C File Offset: 0x006EBB0C
		public static ISlideRailEndType GetRootAsISlideRailEndType(ByteBuffer _bb)
		{
			return ISlideRailEndType.GetRootAsISlideRailEndType(_bb, default(ISlideRailEndType));
		}

		// Token: 0x06033695 RID: 210581 RVA: 0x006ED928 File Offset: 0x006EBB28
		public static ISlideRailEndType GetRootAsISlideRailEndType(ByteBuffer _bb, ISlideRailEndType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033696 RID: 210582 RVA: 0x006ED945 File Offset: 0x006EBB45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033697 RID: 210583 RVA: 0x006ED954 File Offset: 0x006EBB54
		public ISlideRailEndType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D779 RID: 55161
		// (get) Token: 0x06033698 RID: 210584 RVA: 0x006ED964 File Offset: 0x006EBB64
		public ESlideRailEndType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESlideRailEndType.Player;
				}
				return (ESlideRailEndType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033699 RID: 210585 RVA: 0x006ED9A0 File Offset: 0x006EBBA0
		public static Offset<ISlideRailEndType> CreateISlideRailEndType(FlatBufferBuilder builder, ESlideRailEndType Type = ESlideRailEndType.Player)
		{
			builder.StartTable(1);
			ISlideRailEndType.AddType(builder, Type);
			return ISlideRailEndType.EndISlideRailEndType(builder);
		}

		// Token: 0x0603369A RID: 210586 RVA: 0x006ED9B6 File Offset: 0x006EBBB6
		public static void StartISlideRailEndType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603369B RID: 210587 RVA: 0x006ED9BF File Offset: 0x006EBBBF
		public static void AddType(FlatBufferBuilder builder, ESlideRailEndType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603369C RID: 210588 RVA: 0x006ED9CA File Offset: 0x006EBBCA
		public static Offset<ISlideRailEndType> EndISlideRailEndType(FlatBufferBuilder builder)
		{
			return new Offset<ISlideRailEndType>(builder.EndTable());
		}

		// Token: 0x0603369D RID: 210589 RVA: 0x006ED9D8 File Offset: 0x006EBBD8
		public ISlideRailEndTypeT UnPack()
		{
			ISlideRailEndTypeT slideRailEndTypeT = new ISlideRailEndTypeT();
			this.UnPackTo(slideRailEndTypeT);
			return slideRailEndTypeT;
		}

		// Token: 0x0603369E RID: 210590 RVA: 0x006ED9F3 File Offset: 0x006EBBF3
		public void UnPackTo(ISlideRailEndTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603369F RID: 210591 RVA: 0x006EDA04 File Offset: 0x006EBC04
		public static Offset<ISlideRailEndType> Pack(FlatBufferBuilder builder, ISlideRailEndTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISlideRailEndType>);
			}
			return ISlideRailEndType.CreateISlideRailEndType(builder, _o.Type);
		}

		// Token: 0x04011BE2 RID: 72674
		private Table __p;
	}
}
