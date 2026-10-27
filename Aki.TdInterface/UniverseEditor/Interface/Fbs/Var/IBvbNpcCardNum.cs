using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A69 RID: 14953
	public struct IBvbNpcCardNum : IFlatbufferObject
	{
		// Token: 0x1700667B RID: 26235
		// (get) Token: 0x06014451 RID: 83025 RVA: 0x002F5FA9 File Offset: 0x002F41A9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014452 RID: 83026 RVA: 0x002F5FB6 File Offset: 0x002F41B6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014453 RID: 83027 RVA: 0x002F5FC0 File Offset: 0x002F41C0
		public static IBvbNpcCardNum GetRootAsIBvbNpcCardNum(ByteBuffer _bb)
		{
			return IBvbNpcCardNum.GetRootAsIBvbNpcCardNum(_bb, default(IBvbNpcCardNum));
		}

		// Token: 0x06014454 RID: 83028 RVA: 0x002F5FDC File Offset: 0x002F41DC
		public static IBvbNpcCardNum GetRootAsIBvbNpcCardNum(ByteBuffer _bb, IBvbNpcCardNum obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014455 RID: 83029 RVA: 0x002F5FF9 File Offset: 0x002F41F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014456 RID: 83030 RVA: 0x002F6008 File Offset: 0x002F4208
		public IBvbNpcCardNum __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700667C RID: 26236
		// (get) Token: 0x06014457 RID: 83031 RVA: 0x002F6018 File Offset: 0x002F4218
		public ESystemVarName Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESystemVarName.CommonHotFixVar;
				}
				return (ESystemVarName)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014458 RID: 83032 RVA: 0x002F6054 File Offset: 0x002F4254
		public static Offset<IBvbNpcCardNum> CreateIBvbNpcCardNum(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar)
		{
			builder.StartTable(1);
			IBvbNpcCardNum.AddType(builder, Type);
			return IBvbNpcCardNum.EndIBvbNpcCardNum(builder);
		}

		// Token: 0x06014459 RID: 83033 RVA: 0x002F606A File Offset: 0x002F426A
		public static void StartIBvbNpcCardNum(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601445A RID: 83034 RVA: 0x002F6073 File Offset: 0x002F4273
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601445B RID: 83035 RVA: 0x002F607E File Offset: 0x002F427E
		public static Offset<IBvbNpcCardNum> EndIBvbNpcCardNum(FlatBufferBuilder builder)
		{
			return new Offset<IBvbNpcCardNum>(builder.EndTable());
		}

		// Token: 0x0601445C RID: 83036 RVA: 0x002F608C File Offset: 0x002F428C
		public IBvbNpcCardNumT UnPack()
		{
			IBvbNpcCardNumT bvbNpcCardNumT = new IBvbNpcCardNumT();
			this.UnPackTo(bvbNpcCardNumT);
			return bvbNpcCardNumT;
		}

		// Token: 0x0601445D RID: 83037 RVA: 0x002F60A7 File Offset: 0x002F42A7
		public void UnPackTo(IBvbNpcCardNumT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601445E RID: 83038 RVA: 0x002F60B8 File Offset: 0x002F42B8
		public static Offset<IBvbNpcCardNum> Pack(FlatBufferBuilder builder, IBvbNpcCardNumT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbNpcCardNum>);
			}
			return IBvbNpcCardNum.CreateIBvbNpcCardNum(builder, _o.Type);
		}

		// Token: 0x0400AEEC RID: 44780
		private Table __p;
	}
}
