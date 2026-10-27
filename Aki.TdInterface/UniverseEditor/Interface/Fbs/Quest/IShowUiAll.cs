using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200411E RID: 16670
	public struct IShowUiAll : IFlatbufferObject
	{
		// Token: 0x1700760A RID: 30218
		// (get) Token: 0x0601868B RID: 99979 RVA: 0x00385391 File Offset: 0x00383591
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601868C RID: 99980 RVA: 0x0038539E File Offset: 0x0038359E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601868D RID: 99981 RVA: 0x003853A8 File Offset: 0x003835A8
		public static IShowUiAll GetRootAsIShowUiAll(ByteBuffer _bb)
		{
			return IShowUiAll.GetRootAsIShowUiAll(_bb, default(IShowUiAll));
		}

		// Token: 0x0601868E RID: 99982 RVA: 0x003853C4 File Offset: 0x003835C4
		public static IShowUiAll GetRootAsIShowUiAll(ByteBuffer _bb, IShowUiAll obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601868F RID: 99983 RVA: 0x003853E1 File Offset: 0x003835E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018690 RID: 99984 RVA: 0x003853F0 File Offset: 0x003835F0
		public IShowUiAll __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700760B RID: 30219
		// (get) Token: 0x06018691 RID: 99985 RVA: 0x00385400 File Offset: 0x00383600
		public EShowUiType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EShowUiType.All;
				}
				return (EShowUiType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018692 RID: 99986 RVA: 0x0038543C File Offset: 0x0038363C
		public static Offset<IShowUiAll> CreateIShowUiAll(FlatBufferBuilder builder, EShowUiType Type = EShowUiType.All)
		{
			builder.StartTable(1);
			IShowUiAll.AddType(builder, Type);
			return IShowUiAll.EndIShowUiAll(builder);
		}

		// Token: 0x06018693 RID: 99987 RVA: 0x00385452 File Offset: 0x00383652
		public static void StartIShowUiAll(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06018694 RID: 99988 RVA: 0x0038545B File Offset: 0x0038365B
		public static void AddType(FlatBufferBuilder builder, EShowUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018695 RID: 99989 RVA: 0x00385466 File Offset: 0x00383666
		public static Offset<IShowUiAll> EndIShowUiAll(FlatBufferBuilder builder)
		{
			return new Offset<IShowUiAll>(builder.EndTable());
		}

		// Token: 0x06018696 RID: 99990 RVA: 0x00385474 File Offset: 0x00383674
		public IShowUiAllT UnPack()
		{
			IShowUiAllT showUiAllT = new IShowUiAllT();
			this.UnPackTo(showUiAllT);
			return showUiAllT;
		}

		// Token: 0x06018697 RID: 99991 RVA: 0x0038548F File Offset: 0x0038368F
		public void UnPackTo(IShowUiAllT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06018698 RID: 99992 RVA: 0x003854A0 File Offset: 0x003836A0
		public static Offset<IShowUiAll> Pack(FlatBufferBuilder builder, IShowUiAllT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowUiAll>);
			}
			return IShowUiAll.CreateIShowUiAll(builder, _o.Type);
		}

		// Token: 0x0400BD08 RID: 48392
		private Table __p;
	}
}
