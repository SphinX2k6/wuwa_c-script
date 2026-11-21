using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F3B RID: 20283
	public struct ICheckInfrActivityExp : IFlatbufferObject
	{
		// Token: 0x170090E9 RID: 37097
		// (get) Token: 0x0601F897 RID: 129175 RVA: 0x00463554 File Offset: 0x00461754
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F898 RID: 129176 RVA: 0x00463561 File Offset: 0x00461761
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F899 RID: 129177 RVA: 0x00463568 File Offset: 0x00461768
		public static ICheckInfrActivityExp GetRootAsICheckInfrActivityExp(ByteBuffer _bb)
		{
			return ICheckInfrActivityExp.GetRootAsICheckInfrActivityExp(_bb, default(ICheckInfrActivityExp));
		}

		// Token: 0x0601F89A RID: 129178 RVA: 0x00463584 File Offset: 0x00461784
		public static ICheckInfrActivityExp GetRootAsICheckInfrActivityExp(ByteBuffer _bb, ICheckInfrActivityExp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F89B RID: 129179 RVA: 0x004635A1 File Offset: 0x004617A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F89C RID: 129180 RVA: 0x004635B0 File Offset: 0x004617B0
		public ICheckInfrActivityExp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170090EA RID: 37098
		// (get) Token: 0x0601F89D RID: 129181 RVA: 0x004635C0 File Offset: 0x004617C0
		public ECheckSystemStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckSystemStateType.TrackMoonBuilding;
				}
				return (ECheckSystemStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170090EB RID: 37099
		// (get) Token: 0x0601F89E RID: 129182 RVA: 0x004635FC File Offset: 0x004617FC
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

		// Token: 0x170090EC RID: 37100
		// (get) Token: 0x0601F89F RID: 129183 RVA: 0x00463638 File Offset: 0x00461838
		public int Exp
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

		// Token: 0x0601F8A0 RID: 129184 RVA: 0x00463674 File Offset: 0x00461874
		public static Offset<ICheckInfrActivityExp> CreateICheckInfrActivityExp(FlatBufferBuilder builder, ECheckSystemStateType Type = ECheckSystemStateType.TrackMoonBuilding, ECompare Compare = ECompare.Eq, int Exp = 0)
		{
			builder.StartTable(3);
			ICheckInfrActivityExp.AddExp(builder, Exp);
			ICheckInfrActivityExp.AddCompare(builder, Compare);
			ICheckInfrActivityExp.AddType(builder, Type);
			return ICheckInfrActivityExp.EndICheckInfrActivityExp(builder);
		}

		// Token: 0x0601F8A1 RID: 129185 RVA: 0x00463698 File Offset: 0x00461898
		public static void StartICheckInfrActivityExp(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601F8A2 RID: 129186 RVA: 0x004636A1 File Offset: 0x004618A1
		public static void AddType(FlatBufferBuilder builder, ECheckSystemStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F8A3 RID: 129187 RVA: 0x004636AC File Offset: 0x004618AC
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x0601F8A4 RID: 129188 RVA: 0x004636B7 File Offset: 0x004618B7
		public static void AddExp(FlatBufferBuilder builder, int exp)
		{
			builder.AddInt(2, exp, 0);
		}

		// Token: 0x0601F8A5 RID: 129189 RVA: 0x004636C2 File Offset: 0x004618C2
		public static Offset<ICheckInfrActivityExp> EndICheckInfrActivityExp(FlatBufferBuilder builder)
		{
			return new Offset<ICheckInfrActivityExp>(builder.EndTable());
		}

		// Token: 0x0601F8A6 RID: 129190 RVA: 0x004636D0 File Offset: 0x004618D0
		public ICheckInfrActivityExpT UnPack()
		{
			ICheckInfrActivityExpT checkInfrActivityExpT = new ICheckInfrActivityExpT();
			this.UnPackTo(checkInfrActivityExpT);
			return checkInfrActivityExpT;
		}

		// Token: 0x0601F8A7 RID: 129191 RVA: 0x004636EB File Offset: 0x004618EB
		public void UnPackTo(ICheckInfrActivityExpT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.Exp = this.Exp;
		}

		// Token: 0x0601F8A8 RID: 129192 RVA: 0x00463714 File Offset: 0x00461914
		public static Offset<ICheckInfrActivityExp> Pack(FlatBufferBuilder builder, ICheckInfrActivityExpT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckInfrActivityExp>);
			}
			return ICheckInfrActivityExp.CreateICheckInfrActivityExp(builder, _o.Type, _o.Compare, _o.Exp);
		}

		// Token: 0x0400DDB8 RID: 56760
		private Table __p;
	}
}
