using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069E7 RID: 27111
	public struct IClaimDynamicEntityRewardType : IFlatbufferObject
	{
		// Token: 0x1700C76F RID: 51055
		// (get) Token: 0x0602E820 RID: 190496 RVA: 0x0065828B File Offset: 0x0065648B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E821 RID: 190497 RVA: 0x00658298 File Offset: 0x00656498
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E822 RID: 190498 RVA: 0x006582A0 File Offset: 0x006564A0
		public static IClaimDynamicEntityRewardType GetRootAsIClaimDynamicEntityRewardType(ByteBuffer _bb)
		{
			return IClaimDynamicEntityRewardType.GetRootAsIClaimDynamicEntityRewardType(_bb, default(IClaimDynamicEntityRewardType));
		}

		// Token: 0x0602E823 RID: 190499 RVA: 0x006582BC File Offset: 0x006564BC
		public static IClaimDynamicEntityRewardType GetRootAsIClaimDynamicEntityRewardType(ByteBuffer _bb, IClaimDynamicEntityRewardType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E824 RID: 190500 RVA: 0x006582D9 File Offset: 0x006564D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E825 RID: 190501 RVA: 0x006582E8 File Offset: 0x006564E8
		public IClaimDynamicEntityRewardType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C770 RID: 51056
		// (get) Token: 0x0602E826 RID: 190502 RVA: 0x006582F8 File Offset: 0x006564F8
		public EDynamicEntityRewardType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDynamicEntityRewardType.Traffic;
				}
				return (EDynamicEntityRewardType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E827 RID: 190503 RVA: 0x00658334 File Offset: 0x00656534
		public static Offset<IClaimDynamicEntityRewardType> CreateIClaimDynamicEntityRewardType(FlatBufferBuilder builder, EDynamicEntityRewardType Type = EDynamicEntityRewardType.Traffic)
		{
			builder.StartTable(1);
			IClaimDynamicEntityRewardType.AddType(builder, Type);
			return IClaimDynamicEntityRewardType.EndIClaimDynamicEntityRewardType(builder);
		}

		// Token: 0x0602E828 RID: 190504 RVA: 0x0065834A File Offset: 0x0065654A
		public static void StartIClaimDynamicEntityRewardType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E829 RID: 190505 RVA: 0x00658353 File Offset: 0x00656553
		public static void AddType(FlatBufferBuilder builder, EDynamicEntityRewardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E82A RID: 190506 RVA: 0x0065835E File Offset: 0x0065655E
		public static Offset<IClaimDynamicEntityRewardType> EndIClaimDynamicEntityRewardType(FlatBufferBuilder builder)
		{
			return new Offset<IClaimDynamicEntityRewardType>(builder.EndTable());
		}

		// Token: 0x0602E82B RID: 190507 RVA: 0x0065836C File Offset: 0x0065656C
		public IClaimDynamicEntityRewardTypeT UnPack()
		{
			IClaimDynamicEntityRewardTypeT claimDynamicEntityRewardTypeT = new IClaimDynamicEntityRewardTypeT();
			this.UnPackTo(claimDynamicEntityRewardTypeT);
			return claimDynamicEntityRewardTypeT;
		}

		// Token: 0x0602E82C RID: 190508 RVA: 0x00658387 File Offset: 0x00656587
		public void UnPackTo(IClaimDynamicEntityRewardTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602E82D RID: 190509 RVA: 0x00658398 File Offset: 0x00656598
		public static Offset<IClaimDynamicEntityRewardType> Pack(FlatBufferBuilder builder, IClaimDynamicEntityRewardTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClaimDynamicEntityRewardType>);
			}
			return IClaimDynamicEntityRewardType.CreateIClaimDynamicEntityRewardType(builder, _o.Type);
		}

		// Token: 0x04011758 RID: 71512
		private Table __p;
	}
}
