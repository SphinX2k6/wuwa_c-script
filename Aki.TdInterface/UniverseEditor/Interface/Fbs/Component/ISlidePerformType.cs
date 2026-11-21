using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F3C RID: 24380
	public struct ISlidePerformType : IFlatbufferObject
	{
		// Token: 0x1700B48C RID: 46220
		// (get) Token: 0x06028F6E RID: 167790 RVA: 0x00598CF2 File Offset: 0x00596EF2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028F6F RID: 167791 RVA: 0x00598CFF File Offset: 0x00596EFF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028F70 RID: 167792 RVA: 0x00598D08 File Offset: 0x00596F08
		public static ISlidePerformType GetRootAsISlidePerformType(ByteBuffer _bb)
		{
			return ISlidePerformType.GetRootAsISlidePerformType(_bb, default(ISlidePerformType));
		}

		// Token: 0x06028F71 RID: 167793 RVA: 0x00598D24 File Offset: 0x00596F24
		public static ISlidePerformType GetRootAsISlidePerformType(ByteBuffer _bb, ISlidePerformType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028F72 RID: 167794 RVA: 0x00598D41 File Offset: 0x00596F41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028F73 RID: 167795 RVA: 0x00598D50 File Offset: 0x00596F50
		public ISlidePerformType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B48D RID: 46221
		// (get) Token: 0x06028F74 RID: 167796 RVA: 0x00598D60 File Offset: 0x00596F60
		public ESlidePerformType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESlidePerformType.SlopeSlide;
				}
				return (ESlidePerformType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028F75 RID: 167797 RVA: 0x00598D9C File Offset: 0x00596F9C
		public static Offset<ISlidePerformType> CreateISlidePerformType(FlatBufferBuilder builder, ESlidePerformType Type = ESlidePerformType.SlopeSlide)
		{
			builder.StartTable(1);
			ISlidePerformType.AddType(builder, Type);
			return ISlidePerformType.EndISlidePerformType(builder);
		}

		// Token: 0x06028F76 RID: 167798 RVA: 0x00598DB2 File Offset: 0x00596FB2
		public static void StartISlidePerformType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06028F77 RID: 167799 RVA: 0x00598DBB File Offset: 0x00596FBB
		public static void AddType(FlatBufferBuilder builder, ESlidePerformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028F78 RID: 167800 RVA: 0x00598DC6 File Offset: 0x00596FC6
		public static Offset<ISlidePerformType> EndISlidePerformType(FlatBufferBuilder builder)
		{
			return new Offset<ISlidePerformType>(builder.EndTable());
		}

		// Token: 0x06028F79 RID: 167801 RVA: 0x00598DD4 File Offset: 0x00596FD4
		public ISlidePerformTypeT UnPack()
		{
			ISlidePerformTypeT slidePerformTypeT = new ISlidePerformTypeT();
			this.UnPackTo(slidePerformTypeT);
			return slidePerformTypeT;
		}

		// Token: 0x06028F7A RID: 167802 RVA: 0x00598DEF File Offset: 0x00596FEF
		public void UnPackTo(ISlidePerformTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06028F7B RID: 167803 RVA: 0x00598E00 File Offset: 0x00597000
		public static Offset<ISlidePerformType> Pack(FlatBufferBuilder builder, ISlidePerformTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISlidePerformType>);
			}
			return ISlidePerformType.CreateISlidePerformType(builder, _o.Type);
		}

		// Token: 0x0400FBEB RID: 64491
		private Table __p;
	}
}
