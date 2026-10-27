using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B3E RID: 19262
	public struct ICheckSystemFunction : IFlatbufferObject
	{
		// Token: 0x17008BBF RID: 35775
		// (get) Token: 0x0601E508 RID: 124168 RVA: 0x0043F4BA File Offset: 0x0043D6BA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E509 RID: 124169 RVA: 0x0043F4C7 File Offset: 0x0043D6C7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E50A RID: 124170 RVA: 0x0043F4D0 File Offset: 0x0043D6D0
		public static ICheckSystemFunction GetRootAsICheckSystemFunction(ByteBuffer _bb)
		{
			return ICheckSystemFunction.GetRootAsICheckSystemFunction(_bb, default(ICheckSystemFunction));
		}

		// Token: 0x0601E50B RID: 124171 RVA: 0x0043F4EC File Offset: 0x0043D6EC
		public static ICheckSystemFunction GetRootAsICheckSystemFunction(ByteBuffer _bb, ICheckSystemFunction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E50C RID: 124172 RVA: 0x0043F509 File Offset: 0x0043D709
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E50D RID: 124173 RVA: 0x0043F518 File Offset: 0x0043D718
		public ICheckSystemFunction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008BC0 RID: 35776
		// (get) Token: 0x0601E50E RID: 124174 RVA: 0x0043F528 File Offset: 0x0043D728
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

		// Token: 0x17008BC1 RID: 35777
		// (get) Token: 0x0601E50F RID: 124175 RVA: 0x0043F564 File Offset: 0x0043D764
		public int SystemId
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

		// Token: 0x17008BC2 RID: 35778
		// (get) Token: 0x0601E510 RID: 124176 RVA: 0x0043F5A0 File Offset: 0x0043D7A0
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E511 RID: 124177 RVA: 0x0043F5DC File Offset: 0x0043D7DC
		public static Offset<ICheckSystemFunction> CreateICheckSystemFunction(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int SystemId = 0, ECompare Compare = ECompare.Eq)
		{
			builder.StartTable(3);
			ICheckSystemFunction.AddSystemId(builder, SystemId);
			ICheckSystemFunction.AddCompare(builder, Compare);
			ICheckSystemFunction.AddType(builder, Type);
			return ICheckSystemFunction.EndICheckSystemFunction(builder);
		}

		// Token: 0x0601E512 RID: 124178 RVA: 0x0043F600 File Offset: 0x0043D800
		public static void StartICheckSystemFunction(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601E513 RID: 124179 RVA: 0x0043F609 File Offset: 0x0043D809
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E514 RID: 124180 RVA: 0x0043F614 File Offset: 0x0043D814
		public static void AddSystemId(FlatBufferBuilder builder, int systemId)
		{
			builder.AddInt(1, systemId, 0);
		}

		// Token: 0x0601E515 RID: 124181 RVA: 0x0043F61F File Offset: 0x0043D81F
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x0601E516 RID: 124182 RVA: 0x0043F62A File Offset: 0x0043D82A
		public static Offset<ICheckSystemFunction> EndICheckSystemFunction(FlatBufferBuilder builder)
		{
			return new Offset<ICheckSystemFunction>(builder.EndTable());
		}

		// Token: 0x0601E517 RID: 124183 RVA: 0x0043F638 File Offset: 0x0043D838
		public ICheckSystemFunctionT UnPack()
		{
			ICheckSystemFunctionT checkSystemFunctionT = new ICheckSystemFunctionT();
			this.UnPackTo(checkSystemFunctionT);
			return checkSystemFunctionT;
		}

		// Token: 0x0601E518 RID: 124184 RVA: 0x0043F653 File Offset: 0x0043D853
		public void UnPackTo(ICheckSystemFunctionT _o)
		{
			_o.Type = this.Type;
			_o.SystemId = this.SystemId;
			_o.Compare = this.Compare;
		}

		// Token: 0x0601E519 RID: 124185 RVA: 0x0043F67C File Offset: 0x0043D87C
		public static Offset<ICheckSystemFunction> Pack(FlatBufferBuilder builder, ICheckSystemFunctionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckSystemFunction>);
			}
			return ICheckSystemFunction.CreateICheckSystemFunction(builder, _o.Type, _o.SystemId, _o.Compare);
		}

		// Token: 0x0400D3E6 RID: 54246
		private Table __p;
	}
}
