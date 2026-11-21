using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200520E RID: 21006
	public struct IVisibleCondition : IFlatbufferObject
	{
		// Token: 0x1700964F RID: 38479
		// (get) Token: 0x0602114D RID: 135501 RVA: 0x00491F80 File Offset: 0x00490180
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602114E RID: 135502 RVA: 0x00491F8D File Offset: 0x0049018D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602114F RID: 135503 RVA: 0x00491F94 File Offset: 0x00490194
		public static IVisibleCondition GetRootAsIVisibleCondition(ByteBuffer _bb)
		{
			return IVisibleCondition.GetRootAsIVisibleCondition(_bb, default(IVisibleCondition));
		}

		// Token: 0x06021150 RID: 135504 RVA: 0x00491FB0 File Offset: 0x004901B0
		public static IVisibleCondition GetRootAsIVisibleCondition(ByteBuffer _bb, IVisibleCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021151 RID: 135505 RVA: 0x00491FCD File Offset: 0x004901CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021152 RID: 135506 RVA: 0x00491FDC File Offset: 0x004901DC
		public IVisibleCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009650 RID: 38480
		// (get) Token: 0x06021153 RID: 135507 RVA: 0x00491FEC File Offset: 0x004901EC
		public EVisibleCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisibleCondition.Weather;
				}
				return (EVisibleCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009651 RID: 38481
		// (get) Token: 0x06021154 RID: 135508 RVA: 0x00492028 File Offset: 0x00490228
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021155 RID: 135509 RVA: 0x00492064 File Offset: 0x00490264
		public static Offset<IVisibleCondition> CreateIVisibleCondition(FlatBufferBuilder builder, EVisibleCondition Type = EVisibleCondition.Weather, ECompare Compare = ECompare.Eq)
		{
			builder.StartTable(2);
			IVisibleCondition.AddCompare(builder, Compare);
			IVisibleCondition.AddType(builder, Type);
			return IVisibleCondition.EndIVisibleCondition(builder);
		}

		// Token: 0x06021156 RID: 135510 RVA: 0x00492081 File Offset: 0x00490281
		public static void StartIVisibleCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06021157 RID: 135511 RVA: 0x0049208A File Offset: 0x0049028A
		public static void AddType(FlatBufferBuilder builder, EVisibleCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021158 RID: 135512 RVA: 0x00492095 File Offset: 0x00490295
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x06021159 RID: 135513 RVA: 0x004920A0 File Offset: 0x004902A0
		public static Offset<IVisibleCondition> EndIVisibleCondition(FlatBufferBuilder builder)
		{
			return new Offset<IVisibleCondition>(builder.EndTable());
		}

		// Token: 0x0602115A RID: 135514 RVA: 0x004920B0 File Offset: 0x004902B0
		public IVisibleConditionT UnPack()
		{
			IVisibleConditionT visibleConditionT = new IVisibleConditionT();
			this.UnPackTo(visibleConditionT);
			return visibleConditionT;
		}

		// Token: 0x0602115B RID: 135515 RVA: 0x004920CB File Offset: 0x004902CB
		public void UnPackTo(IVisibleConditionT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
		}

		// Token: 0x0602115C RID: 135516 RVA: 0x004920E8 File Offset: 0x004902E8
		public static Offset<IVisibleCondition> Pack(FlatBufferBuilder builder, IVisibleConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisibleCondition>);
			}
			return IVisibleCondition.CreateIVisibleCondition(builder, _o.Type, _o.Compare);
		}

		// Token: 0x0400E220 RID: 57888
		private Table __p;
	}
}
