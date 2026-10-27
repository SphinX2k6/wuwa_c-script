using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200545B RID: 21595
	public struct IInteractPlayerDiractionToLeisure : IFlatbufferObject
	{
		// Token: 0x17009F03 RID: 40707
		// (get) Token: 0x06023869 RID: 145513 RVA: 0x004EA2E8 File Offset: 0x004E84E8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602386A RID: 145514 RVA: 0x004EA2F5 File Offset: 0x004E84F5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602386B RID: 145515 RVA: 0x004EA2FC File Offset: 0x004E84FC
		public static IInteractPlayerDiractionToLeisure GetRootAsIInteractPlayerDiractionToLeisure(ByteBuffer _bb)
		{
			return IInteractPlayerDiractionToLeisure.GetRootAsIInteractPlayerDiractionToLeisure(_bb, default(IInteractPlayerDiractionToLeisure));
		}

		// Token: 0x0602386C RID: 145516 RVA: 0x004EA318 File Offset: 0x004E8518
		public static IInteractPlayerDiractionToLeisure GetRootAsIInteractPlayerDiractionToLeisure(ByteBuffer _bb, IInteractPlayerDiractionToLeisure obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602386D RID: 145517 RVA: 0x004EA335 File Offset: 0x004E8535
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602386E RID: 145518 RVA: 0x004EA344 File Offset: 0x004E8544
		public IInteractPlayerDiractionToLeisure __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009F04 RID: 40708
		// (get) Token: 0x0602386F RID: 145519 RVA: 0x004EA354 File Offset: 0x004E8554
		public EInteractPlayerDiractionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInteractPlayerDiractionType.Npc;
				}
				return (EInteractPlayerDiractionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009F05 RID: 40709
		// (get) Token: 0x06023870 RID: 145520 RVA: 0x004EA390 File Offset: 0x004E8590
		public int Begin
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

		// Token: 0x17009F06 RID: 40710
		// (get) Token: 0x06023871 RID: 145521 RVA: 0x004EA3CC File Offset: 0x004E85CC
		public int End
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023872 RID: 145522 RVA: 0x004EA408 File Offset: 0x004E8608
		public static Offset<IInteractPlayerDiractionToLeisure> CreateIInteractPlayerDiractionToLeisure(FlatBufferBuilder builder, EInteractPlayerDiractionType Type = EInteractPlayerDiractionType.Npc, int Begin = 0, int End = 0)
		{
			builder.StartTable(3);
			IInteractPlayerDiractionToLeisure.AddEnd(builder, End);
			IInteractPlayerDiractionToLeisure.AddBegin(builder, Begin);
			IInteractPlayerDiractionToLeisure.AddType(builder, Type);
			return IInteractPlayerDiractionToLeisure.EndIInteractPlayerDiractionToLeisure(builder);
		}

		// Token: 0x06023873 RID: 145523 RVA: 0x004EA42C File Offset: 0x004E862C
		public static void StartIInteractPlayerDiractionToLeisure(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06023874 RID: 145524 RVA: 0x004EA435 File Offset: 0x004E8635
		public static void AddType(FlatBufferBuilder builder, EInteractPlayerDiractionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023875 RID: 145525 RVA: 0x004EA440 File Offset: 0x004E8640
		public static void AddBegin(FlatBufferBuilder builder, int begin)
		{
			builder.AddInt(1, begin, 0);
		}

		// Token: 0x06023876 RID: 145526 RVA: 0x004EA44B File Offset: 0x004E864B
		public static void AddEnd(FlatBufferBuilder builder, int end)
		{
			builder.AddInt(2, end, 0);
		}

		// Token: 0x06023877 RID: 145527 RVA: 0x004EA456 File Offset: 0x004E8656
		public static Offset<IInteractPlayerDiractionToLeisure> EndIInteractPlayerDiractionToLeisure(FlatBufferBuilder builder)
		{
			return new Offset<IInteractPlayerDiractionToLeisure>(builder.EndTable());
		}

		// Token: 0x06023878 RID: 145528 RVA: 0x004EA464 File Offset: 0x004E8664
		public IInteractPlayerDiractionToLeisureT UnPack()
		{
			IInteractPlayerDiractionToLeisureT interactPlayerDiractionToLeisureT = new IInteractPlayerDiractionToLeisureT();
			this.UnPackTo(interactPlayerDiractionToLeisureT);
			return interactPlayerDiractionToLeisureT;
		}

		// Token: 0x06023879 RID: 145529 RVA: 0x004EA47F File Offset: 0x004E867F
		public void UnPackTo(IInteractPlayerDiractionToLeisureT _o)
		{
			_o.Type = this.Type;
			_o.Begin = this.Begin;
			_o.End = this.End;
		}

		// Token: 0x0602387A RID: 145530 RVA: 0x004EA4A8 File Offset: 0x004E86A8
		public static Offset<IInteractPlayerDiractionToLeisure> Pack(FlatBufferBuilder builder, IInteractPlayerDiractionToLeisureT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractPlayerDiractionToLeisure>);
			}
			return IInteractPlayerDiractionToLeisure.CreateIInteractPlayerDiractionToLeisure(builder, _o.Type, _o.Begin, _o.End);
		}

		// Token: 0x0400E6D4 RID: 59092
		private Table __p;
	}
}
