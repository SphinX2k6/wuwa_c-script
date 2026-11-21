using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E26 RID: 15910
	public struct IBvbCustomSystemVarFloat : IFlatbufferObject
	{
		// Token: 0x17006B7B RID: 27515
		// (get) Token: 0x06015678 RID: 87672 RVA: 0x00317491 File Offset: 0x00315691
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015679 RID: 87673 RVA: 0x0031749E File Offset: 0x0031569E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601567A RID: 87674 RVA: 0x003174A8 File Offset: 0x003156A8
		public static IBvbCustomSystemVarFloat GetRootAsIBvbCustomSystemVarFloat(ByteBuffer _bb)
		{
			return IBvbCustomSystemVarFloat.GetRootAsIBvbCustomSystemVarFloat(_bb, default(IBvbCustomSystemVarFloat));
		}

		// Token: 0x0601567B RID: 87675 RVA: 0x003174C4 File Offset: 0x003156C4
		public static IBvbCustomSystemVarFloat GetRootAsIBvbCustomSystemVarFloat(ByteBuffer _bb, IBvbCustomSystemVarFloat obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601567C RID: 87676 RVA: 0x003174E1 File Offset: 0x003156E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601567D RID: 87677 RVA: 0x003174F0 File Offset: 0x003156F0
		public IBvbCustomSystemVarFloat __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006B7C RID: 27516
		// (get) Token: 0x0601567E RID: 87678 RVA: 0x00317500 File Offset: 0x00315700
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

		// Token: 0x17006B7D RID: 27517
		// (get) Token: 0x0601567F RID: 87679 RVA: 0x0031753C File Offset: 0x0031573C
		public string VarName
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015680 RID: 87680 RVA: 0x00317573 File Offset: 0x00315773
		public Span<byte> GetVarNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06015681 RID: 87681 RVA: 0x00317582 File Offset: 0x00315782
		public byte[] GetVarNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17006B7E RID: 27518
		// (get) Token: 0x06015682 RID: 87682 RVA: 0x00317590 File Offset: 0x00315790
		public string VarParams
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015683 RID: 87683 RVA: 0x003175C7 File Offset: 0x003157C7
		public Span<byte> GetVarParamsBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06015684 RID: 87684 RVA: 0x003175D6 File Offset: 0x003157D6
		public byte[] GetVarParamsArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06015685 RID: 87685 RVA: 0x003175E4 File Offset: 0x003157E4
		public static Offset<IBvbCustomSystemVarFloat> CreateIBvbCustomSystemVarFloat(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar, StringOffset VarNameOffset = default(StringOffset), StringOffset VarParamsOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IBvbCustomSystemVarFloat.AddVarParams(builder, VarParamsOffset);
			IBvbCustomSystemVarFloat.AddVarName(builder, VarNameOffset);
			IBvbCustomSystemVarFloat.AddType(builder, Type);
			return IBvbCustomSystemVarFloat.EndIBvbCustomSystemVarFloat(builder);
		}

		// Token: 0x06015686 RID: 87686 RVA: 0x00317608 File Offset: 0x00315808
		public static void StartIBvbCustomSystemVarFloat(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06015687 RID: 87687 RVA: 0x00317611 File Offset: 0x00315811
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015688 RID: 87688 RVA: 0x0031761C File Offset: 0x0031581C
		public static void AddVarName(FlatBufferBuilder builder, StringOffset varNameOffset)
		{
			builder.AddOffset(1, varNameOffset.Value, 0);
		}

		// Token: 0x06015689 RID: 87689 RVA: 0x0031762C File Offset: 0x0031582C
		public static void AddVarParams(FlatBufferBuilder builder, StringOffset varParamsOffset)
		{
			builder.AddOffset(2, varParamsOffset.Value, 0);
		}

		// Token: 0x0601568A RID: 87690 RVA: 0x0031763C File Offset: 0x0031583C
		public static Offset<IBvbCustomSystemVarFloat> EndIBvbCustomSystemVarFloat(FlatBufferBuilder builder)
		{
			return new Offset<IBvbCustomSystemVarFloat>(builder.EndTable());
		}

		// Token: 0x0601568B RID: 87691 RVA: 0x0031764C File Offset: 0x0031584C
		public IBvbCustomSystemVarFloatT UnPack()
		{
			IBvbCustomSystemVarFloatT bvbCustomSystemVarFloatT = new IBvbCustomSystemVarFloatT();
			this.UnPackTo(bvbCustomSystemVarFloatT);
			return bvbCustomSystemVarFloatT;
		}

		// Token: 0x0601568C RID: 87692 RVA: 0x00317667 File Offset: 0x00315867
		public void UnPackTo(IBvbCustomSystemVarFloatT _o)
		{
			_o.Type = this.Type;
			_o.VarName = this.VarName;
			_o.VarParams = this.VarParams;
		}

		// Token: 0x0601568D RID: 87693 RVA: 0x00317690 File Offset: 0x00315890
		public static Offset<IBvbCustomSystemVarFloat> Pack(FlatBufferBuilder builder, IBvbCustomSystemVarFloatT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbCustomSystemVarFloat>);
			}
			StringOffset varNameOffset = (_o.VarName == null) ? default(StringOffset) : builder.CreateString(_o.VarName);
			StringOffset varParamsOffset = (_o.VarParams == null) ? default(StringOffset) : builder.CreateString(_o.VarParams);
			return IBvbCustomSystemVarFloat.CreateIBvbCustomSystemVarFloat(builder, _o.Type, varNameOffset, varParamsOffset);
		}

		// Token: 0x0400B7F1 RID: 47089
		private Table __p;
	}
}
