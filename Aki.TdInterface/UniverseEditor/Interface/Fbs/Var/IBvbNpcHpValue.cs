using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E50 RID: 15952
	public struct IBvbNpcHpValue : IFlatbufferObject
	{
		// Token: 0x17006BB7 RID: 27575
		// (get) Token: 0x060157B5 RID: 87989 RVA: 0x00319775 File Offset: 0x00317975
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060157B6 RID: 87990 RVA: 0x00319782 File Offset: 0x00317982
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060157B7 RID: 87991 RVA: 0x0031978C File Offset: 0x0031798C
		public static IBvbNpcHpValue GetRootAsIBvbNpcHpValue(ByteBuffer _bb)
		{
			return IBvbNpcHpValue.GetRootAsIBvbNpcHpValue(_bb, default(IBvbNpcHpValue));
		}

		// Token: 0x060157B8 RID: 87992 RVA: 0x003197A8 File Offset: 0x003179A8
		public static IBvbNpcHpValue GetRootAsIBvbNpcHpValue(ByteBuffer _bb, IBvbNpcHpValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060157B9 RID: 87993 RVA: 0x003197C5 File Offset: 0x003179C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060157BA RID: 87994 RVA: 0x003197D4 File Offset: 0x003179D4
		public IBvbNpcHpValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006BB8 RID: 27576
		// (get) Token: 0x060157BB RID: 87995 RVA: 0x003197E4 File Offset: 0x003179E4
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

		// Token: 0x060157BC RID: 87996 RVA: 0x00319820 File Offset: 0x00317A20
		public static Offset<IBvbNpcHpValue> CreateIBvbNpcHpValue(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar)
		{
			builder.StartTable(1);
			IBvbNpcHpValue.AddType(builder, Type);
			return IBvbNpcHpValue.EndIBvbNpcHpValue(builder);
		}

		// Token: 0x060157BD RID: 87997 RVA: 0x00319836 File Offset: 0x00317A36
		public static void StartIBvbNpcHpValue(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060157BE RID: 87998 RVA: 0x0031983F File Offset: 0x00317A3F
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060157BF RID: 87999 RVA: 0x0031984A File Offset: 0x00317A4A
		public static Offset<IBvbNpcHpValue> EndIBvbNpcHpValue(FlatBufferBuilder builder)
		{
			return new Offset<IBvbNpcHpValue>(builder.EndTable());
		}

		// Token: 0x060157C0 RID: 88000 RVA: 0x00319858 File Offset: 0x00317A58
		public IBvbNpcHpValueT UnPack()
		{
			IBvbNpcHpValueT bvbNpcHpValueT = new IBvbNpcHpValueT();
			this.UnPackTo(bvbNpcHpValueT);
			return bvbNpcHpValueT;
		}

		// Token: 0x060157C1 RID: 88001 RVA: 0x00319873 File Offset: 0x00317A73
		public void UnPackTo(IBvbNpcHpValueT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060157C2 RID: 88002 RVA: 0x00319884 File Offset: 0x00317A84
		public static Offset<IBvbNpcHpValue> Pack(FlatBufferBuilder builder, IBvbNpcHpValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbNpcHpValue>);
			}
			return IBvbNpcHpValue.CreateIBvbNpcHpValue(builder, _o.Type);
		}

		// Token: 0x0400B816 RID: 47126
		private Table __p;
	}
}
