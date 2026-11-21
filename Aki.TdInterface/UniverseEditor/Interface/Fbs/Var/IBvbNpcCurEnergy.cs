using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E4A RID: 15946
	public struct IBvbNpcCurEnergy : IFlatbufferObject
	{
		// Token: 0x17006BB1 RID: 27569
		// (get) Token: 0x06015791 RID: 87953 RVA: 0x00319485 File Offset: 0x00317685
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015792 RID: 87954 RVA: 0x00319492 File Offset: 0x00317692
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015793 RID: 87955 RVA: 0x0031949C File Offset: 0x0031769C
		public static IBvbNpcCurEnergy GetRootAsIBvbNpcCurEnergy(ByteBuffer _bb)
		{
			return IBvbNpcCurEnergy.GetRootAsIBvbNpcCurEnergy(_bb, default(IBvbNpcCurEnergy));
		}

		// Token: 0x06015794 RID: 87956 RVA: 0x003194B8 File Offset: 0x003176B8
		public static IBvbNpcCurEnergy GetRootAsIBvbNpcCurEnergy(ByteBuffer _bb, IBvbNpcCurEnergy obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015795 RID: 87957 RVA: 0x003194D5 File Offset: 0x003176D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015796 RID: 87958 RVA: 0x003194E4 File Offset: 0x003176E4
		public IBvbNpcCurEnergy __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006BB2 RID: 27570
		// (get) Token: 0x06015797 RID: 87959 RVA: 0x003194F4 File Offset: 0x003176F4
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

		// Token: 0x06015798 RID: 87960 RVA: 0x00319530 File Offset: 0x00317730
		public static Offset<IBvbNpcCurEnergy> CreateIBvbNpcCurEnergy(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar)
		{
			builder.StartTable(1);
			IBvbNpcCurEnergy.AddType(builder, Type);
			return IBvbNpcCurEnergy.EndIBvbNpcCurEnergy(builder);
		}

		// Token: 0x06015799 RID: 87961 RVA: 0x00319546 File Offset: 0x00317746
		public static void StartIBvbNpcCurEnergy(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601579A RID: 87962 RVA: 0x0031954F File Offset: 0x0031774F
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601579B RID: 87963 RVA: 0x0031955A File Offset: 0x0031775A
		public static Offset<IBvbNpcCurEnergy> EndIBvbNpcCurEnergy(FlatBufferBuilder builder)
		{
			return new Offset<IBvbNpcCurEnergy>(builder.EndTable());
		}

		// Token: 0x0601579C RID: 87964 RVA: 0x00319568 File Offset: 0x00317768
		public IBvbNpcCurEnergyT UnPack()
		{
			IBvbNpcCurEnergyT bvbNpcCurEnergyT = new IBvbNpcCurEnergyT();
			this.UnPackTo(bvbNpcCurEnergyT);
			return bvbNpcCurEnergyT;
		}

		// Token: 0x0601579D RID: 87965 RVA: 0x00319583 File Offset: 0x00317783
		public void UnPackTo(IBvbNpcCurEnergyT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601579E RID: 87966 RVA: 0x00319594 File Offset: 0x00317794
		public static Offset<IBvbNpcCurEnergy> Pack(FlatBufferBuilder builder, IBvbNpcCurEnergyT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbNpcCurEnergy>);
			}
			return IBvbNpcCurEnergy.CreateIBvbNpcCurEnergy(builder, _o.Type);
		}

		// Token: 0x0400B812 RID: 47122
		private Table __p;
	}
}
