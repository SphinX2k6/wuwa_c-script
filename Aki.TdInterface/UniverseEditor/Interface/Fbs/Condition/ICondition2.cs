using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050C4 RID: 20676
	public struct ICondition2 : IFlatbufferObject
	{
		// Token: 0x17009434 RID: 37940
		// (get) Token: 0x06020653 RID: 132691 RVA: 0x0047C924 File Offset: 0x0047AB24
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020654 RID: 132692 RVA: 0x0047C931 File Offset: 0x0047AB31
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020655 RID: 132693 RVA: 0x0047C938 File Offset: 0x0047AB38
		public static ICondition2 GetRootAsICondition2(ByteBuffer _bb)
		{
			return ICondition2.GetRootAsICondition2(_bb, default(ICondition2));
		}

		// Token: 0x06020656 RID: 132694 RVA: 0x0047C954 File Offset: 0x0047AB54
		public static ICondition2 GetRootAsICondition2(ByteBuffer _bb, ICondition2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020657 RID: 132695 RVA: 0x0047C971 File Offset: 0x0047AB71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020658 RID: 132696 RVA: 0x0047C980 File Offset: 0x0047AB80
		public ICondition2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009435 RID: 37941
		// (get) Token: 0x06020659 RID: 132697 RVA: 0x0047C990 File Offset: 0x0047AB90
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602065A RID: 132698 RVA: 0x0047C9CC File Offset: 0x0047ABCC
		public static Offset<ICondition2> CreateICondition2(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar)
		{
			builder.StartTable(1);
			ICondition2.AddType(builder, Type);
			return ICondition2.EndICondition2(builder);
		}

		// Token: 0x0602065B RID: 132699 RVA: 0x0047C9E2 File Offset: 0x0047ABE2
		public static void StartICondition2(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602065C RID: 132700 RVA: 0x0047C9EB File Offset: 0x0047ABEB
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602065D RID: 132701 RVA: 0x0047C9F6 File Offset: 0x0047ABF6
		public static Offset<ICondition2> EndICondition2(FlatBufferBuilder builder)
		{
			return new Offset<ICondition2>(builder.EndTable());
		}

		// Token: 0x0602065E RID: 132702 RVA: 0x0047CA04 File Offset: 0x0047AC04
		public ICondition2T UnPack()
		{
			ICondition2T condition2T = new ICondition2T();
			this.UnPackTo(condition2T);
			return condition2T;
		}

		// Token: 0x0602065F RID: 132703 RVA: 0x0047CA1F File Offset: 0x0047AC1F
		public void UnPackTo(ICondition2T _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06020660 RID: 132704 RVA: 0x0047CA30 File Offset: 0x0047AC30
		public static Offset<ICondition2> Pack(FlatBufferBuilder builder, ICondition2T _o)
		{
			if (_o == null)
			{
				return default(Offset<ICondition2>);
			}
			return ICondition2.CreateICondition2(builder, _o.Type);
		}

		// Token: 0x0400DFD7 RID: 57303
		private Table __p;
	}
}
