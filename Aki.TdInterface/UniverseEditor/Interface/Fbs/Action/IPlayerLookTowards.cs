using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CFF RID: 27903
	public struct IPlayerLookTowards : IFlatbufferObject
	{
		// Token: 0x1700CFCD RID: 53197
		// (get) Token: 0x0603133B RID: 201531 RVA: 0x006ACB03 File Offset: 0x006AAD03
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603133C RID: 201532 RVA: 0x006ACB10 File Offset: 0x006AAD10
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603133D RID: 201533 RVA: 0x006ACB18 File Offset: 0x006AAD18
		public static IPlayerLookTowards GetRootAsIPlayerLookTowards(ByteBuffer _bb)
		{
			return IPlayerLookTowards.GetRootAsIPlayerLookTowards(_bb, default(IPlayerLookTowards));
		}

		// Token: 0x0603133E RID: 201534 RVA: 0x006ACB34 File Offset: 0x006AAD34
		public static IPlayerLookTowards GetRootAsIPlayerLookTowards(ByteBuffer _bb, IPlayerLookTowards obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603133F RID: 201535 RVA: 0x006ACB51 File Offset: 0x006AAD51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031340 RID: 201536 RVA: 0x006ACB60 File Offset: 0x006AAD60
		public IPlayerLookTowards __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CFCE RID: 53198
		// (get) Token: 0x06031341 RID: 201537 RVA: 0x006ACB70 File Offset: 0x006AAD70
		public TCharacterLookAtData TargetType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TCharacterLookAtData.NONE;
				}
				return (TCharacterLookAtData)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031342 RID: 201538 RVA: 0x006ACBAC File Offset: 0x006AADAC
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06031343 RID: 201539 RVA: 0x006ACBF0 File Offset: 0x006AADF0
		public ICharacterLookAtEmptyData TargetAsICharacterLookAtEmptyData()
		{
			return this.Target<ICharacterLookAtEmptyData>().Value;
		}

		// Token: 0x06031344 RID: 201540 RVA: 0x006ACC0C File Offset: 0x006AAE0C
		public ICharacterLookAtEntityData TargetAsICharacterLookAtEntityData()
		{
			return this.Target<ICharacterLookAtEntityData>().Value;
		}

		// Token: 0x06031345 RID: 201541 RVA: 0x006ACC28 File Offset: 0x006AAE28
		public ICharacterLookAtPlayerData TargetAsICharacterLookAtPlayerData()
		{
			return this.Target<ICharacterLookAtPlayerData>().Value;
		}

		// Token: 0x06031346 RID: 201542 RVA: 0x006ACC44 File Offset: 0x006AAE44
		public ICharacterLookAtPositionData TargetAsICharacterLookAtPositionData()
		{
			return this.Target<ICharacterLookAtPositionData>().Value;
		}

		// Token: 0x06031347 RID: 201543 RVA: 0x006ACC60 File Offset: 0x006AAE60
		public ICharacterLookAtUnlockData TargetAsICharacterLookAtUnlockData()
		{
			return this.Target<ICharacterLookAtUnlockData>().Value;
		}

		// Token: 0x06031348 RID: 201544 RVA: 0x006ACC7B File Offset: 0x006AAE7B
		public static Offset<IPlayerLookTowards> CreateIPlayerLookTowards(FlatBufferBuilder builder, TCharacterLookAtData Target_type = TCharacterLookAtData.NONE, int TargetOffset = 0)
		{
			builder.StartTable(2);
			IPlayerLookTowards.AddTarget(builder, TargetOffset);
			IPlayerLookTowards.AddTargetType(builder, Target_type);
			return IPlayerLookTowards.EndIPlayerLookTowards(builder);
		}

		// Token: 0x06031349 RID: 201545 RVA: 0x006ACC98 File Offset: 0x006AAE98
		public static void StartIPlayerLookTowards(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603134A RID: 201546 RVA: 0x006ACCA1 File Offset: 0x006AAEA1
		public static void AddTargetType(FlatBufferBuilder builder, TCharacterLookAtData targetType)
		{
			builder.AddByte(0, (byte)targetType, 0);
		}

		// Token: 0x0603134B RID: 201547 RVA: 0x006ACCAC File Offset: 0x006AAEAC
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(1, targetOffset, 0);
		}

		// Token: 0x0603134C RID: 201548 RVA: 0x006ACCB7 File Offset: 0x006AAEB7
		public static Offset<IPlayerLookTowards> EndIPlayerLookTowards(FlatBufferBuilder builder)
		{
			return new Offset<IPlayerLookTowards>(builder.EndTable());
		}

		// Token: 0x0603134D RID: 201549 RVA: 0x006ACCC4 File Offset: 0x006AAEC4
		public IPlayerLookTowardsT UnPack()
		{
			IPlayerLookTowardsT playerLookTowardsT = new IPlayerLookTowardsT();
			this.UnPackTo(playerLookTowardsT);
			return playerLookTowardsT;
		}

		// Token: 0x0603134E RID: 201550 RVA: 0x006ACCE0 File Offset: 0x006AAEE0
		public void UnPackTo(IPlayerLookTowardsT _o)
		{
			_o.Target = new TCharacterLookAtDataUnion();
			_o.Target.Type = this.TargetType;
			switch (this.TargetType)
			{
			case TCharacterLookAtData.ICharacterLookAtEmptyData:
				_o.Target.Value = ((this.Target<ICharacterLookAtEmptyData>() != null) ? this.Target<ICharacterLookAtEmptyData>().Value.UnPack() : null);
				return;
			case TCharacterLookAtData.ICharacterLookAtEntityData:
				_o.Target.Value = ((this.Target<ICharacterLookAtEntityData>() != null) ? this.Target<ICharacterLookAtEntityData>().Value.UnPack() : null);
				return;
			case TCharacterLookAtData.ICharacterLookAtPlayerData:
				_o.Target.Value = ((this.Target<ICharacterLookAtPlayerData>() != null) ? this.Target<ICharacterLookAtPlayerData>().Value.UnPack() : null);
				return;
			case TCharacterLookAtData.ICharacterLookAtPositionData:
				_o.Target.Value = ((this.Target<ICharacterLookAtPositionData>() != null) ? this.Target<ICharacterLookAtPositionData>().Value.UnPack() : null);
				return;
			case TCharacterLookAtData.ICharacterLookAtUnlockData:
				_o.Target.Value = ((this.Target<ICharacterLookAtUnlockData>() != null) ? this.Target<ICharacterLookAtUnlockData>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0603134F RID: 201551 RVA: 0x006ACE40 File Offset: 0x006AB040
		public static Offset<IPlayerLookTowards> Pack(FlatBufferBuilder builder, IPlayerLookTowardsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayerLookTowards>);
			}
			TCharacterLookAtData target_type = (_o.Target == null) ? TCharacterLookAtData.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TCharacterLookAtDataUnion.Pack(builder, _o.Target);
			return IPlayerLookTowards.CreateIPlayerLookTowards(builder, target_type, targetOffset);
		}

		// Token: 0x0401167C RID: 71292
		private Table __p;
	}
}
