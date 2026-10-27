using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200542B RID: 21547
	public struct IInitStateWuYinQu : IFlatbufferObject
	{
		// Token: 0x17009E7F RID: 40575
		// (get) Token: 0x06023657 RID: 144983 RVA: 0x004E5C91 File Offset: 0x004E3E91
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023658 RID: 144984 RVA: 0x004E5C9E File Offset: 0x004E3E9E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023659 RID: 144985 RVA: 0x004E5CA8 File Offset: 0x004E3EA8
		public static IInitStateWuYinQu GetRootAsIInitStateWuYinQu(ByteBuffer _bb)
		{
			return IInitStateWuYinQu.GetRootAsIInitStateWuYinQu(_bb, default(IInitStateWuYinQu));
		}

		// Token: 0x0602365A RID: 144986 RVA: 0x004E5CC4 File Offset: 0x004E3EC4
		public static IInitStateWuYinQu GetRootAsIInitStateWuYinQu(ByteBuffer _bb, IInitStateWuYinQu obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602365B RID: 144987 RVA: 0x004E5CE1 File Offset: 0x004E3EE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602365C RID: 144988 RVA: 0x004E5CF0 File Offset: 0x004E3EF0
		public IInitStateWuYinQu __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009E80 RID: 40576
		// (get) Token: 0x0602365D RID: 144989 RVA: 0x004E5D00 File Offset: 0x004E3F00
		public EInitStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInitStateType.Birth;
				}
				return (EInitStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602365E RID: 144990 RVA: 0x004E5D3C File Offset: 0x004E3F3C
		public static Offset<IInitStateWuYinQu> CreateIInitStateWuYinQu(FlatBufferBuilder builder, EInitStateType Type = EInitStateType.Birth)
		{
			builder.StartTable(1);
			IInitStateWuYinQu.AddType(builder, Type);
			return IInitStateWuYinQu.EndIInitStateWuYinQu(builder);
		}

		// Token: 0x0602365F RID: 144991 RVA: 0x004E5D52 File Offset: 0x004E3F52
		public static void StartIInitStateWuYinQu(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06023660 RID: 144992 RVA: 0x004E5D5B File Offset: 0x004E3F5B
		public static void AddType(FlatBufferBuilder builder, EInitStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023661 RID: 144993 RVA: 0x004E5D66 File Offset: 0x004E3F66
		public static Offset<IInitStateWuYinQu> EndIInitStateWuYinQu(FlatBufferBuilder builder)
		{
			return new Offset<IInitStateWuYinQu>(builder.EndTable());
		}

		// Token: 0x06023662 RID: 144994 RVA: 0x004E5D74 File Offset: 0x004E3F74
		public IInitStateWuYinQuT UnPack()
		{
			IInitStateWuYinQuT initStateWuYinQuT = new IInitStateWuYinQuT();
			this.UnPackTo(initStateWuYinQuT);
			return initStateWuYinQuT;
		}

		// Token: 0x06023663 RID: 144995 RVA: 0x004E5D8F File Offset: 0x004E3F8F
		public void UnPackTo(IInitStateWuYinQuT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06023664 RID: 144996 RVA: 0x004E5DA0 File Offset: 0x004E3FA0
		public static Offset<IInitStateWuYinQu> Pack(FlatBufferBuilder builder, IInitStateWuYinQuT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInitStateWuYinQu>);
			}
			return IInitStateWuYinQu.CreateIInitStateWuYinQu(builder, _o.Type);
		}

		// Token: 0x0400E677 RID: 58999
		private Table __p;
	}
}
