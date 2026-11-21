using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200747A RID: 29818
	public struct IPlayerLookTowards : IFlatbufferObject
	{
		// Token: 0x1700DB11 RID: 56081
		// (get) Token: 0x0603432F RID: 213807 RVA: 0x00708033 File Offset: 0x00706233
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034330 RID: 213808 RVA: 0x00708040 File Offset: 0x00706240
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034331 RID: 213809 RVA: 0x00708048 File Offset: 0x00706248
		public static IPlayerLookTowards GetRootAsIPlayerLookTowards(ByteBuffer _bb)
		{
			return IPlayerLookTowards.GetRootAsIPlayerLookTowards(_bb, default(IPlayerLookTowards));
		}

		// Token: 0x06034332 RID: 213810 RVA: 0x00708064 File Offset: 0x00706264
		public static IPlayerLookTowards GetRootAsIPlayerLookTowards(ByteBuffer _bb, IPlayerLookTowards obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034333 RID: 213811 RVA: 0x00708081 File Offset: 0x00706281
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034334 RID: 213812 RVA: 0x00708090 File Offset: 0x00706290
		public IPlayerLookTowards __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DB12 RID: 56082
		// (get) Token: 0x06034335 RID: 213813 RVA: 0x007080A0 File Offset: 0x007062A0
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

		// Token: 0x06034336 RID: 213814 RVA: 0x007080DC File Offset: 0x007062DC
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06034337 RID: 213815 RVA: 0x00708120 File Offset: 0x00706320
		public ICharacterLookAtEmptyData TargetAsICharacterLookAtEmptyData()
		{
			return this.Target<ICharacterLookAtEmptyData>().Value;
		}

		// Token: 0x06034338 RID: 213816 RVA: 0x0070813C File Offset: 0x0070633C
		public ICharacterLookAtEntityData TargetAsICharacterLookAtEntityData()
		{
			return this.Target<ICharacterLookAtEntityData>().Value;
		}

		// Token: 0x06034339 RID: 213817 RVA: 0x00708158 File Offset: 0x00706358
		public ICharacterLookAtPlayerData TargetAsICharacterLookAtPlayerData()
		{
			return this.Target<ICharacterLookAtPlayerData>().Value;
		}

		// Token: 0x0603433A RID: 213818 RVA: 0x00708174 File Offset: 0x00706374
		public ICharacterLookAtPositionData TargetAsICharacterLookAtPositionData()
		{
			return this.Target<ICharacterLookAtPositionData>().Value;
		}

		// Token: 0x0603433B RID: 213819 RVA: 0x00708190 File Offset: 0x00706390
		public ICharacterLookAtUnlockData TargetAsICharacterLookAtUnlockData()
		{
			return this.Target<ICharacterLookAtUnlockData>().Value;
		}

		// Token: 0x0603433C RID: 213820 RVA: 0x007081AB File Offset: 0x007063AB
		public static Offset<IPlayerLookTowards> CreateIPlayerLookTowards(FlatBufferBuilder builder, TCharacterLookAtData Target_type = TCharacterLookAtData.NONE, int TargetOffset = 0)
		{
			builder.StartTable(2);
			IPlayerLookTowards.AddTarget(builder, TargetOffset);
			IPlayerLookTowards.AddTargetType(builder, Target_type);
			return IPlayerLookTowards.EndIPlayerLookTowards(builder);
		}

		// Token: 0x0603433D RID: 213821 RVA: 0x007081C8 File Offset: 0x007063C8
		public static void StartIPlayerLookTowards(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603433E RID: 213822 RVA: 0x007081D1 File Offset: 0x007063D1
		public static void AddTargetType(FlatBufferBuilder builder, TCharacterLookAtData targetType)
		{
			builder.AddByte(0, (byte)targetType, 0);
		}

		// Token: 0x0603433F RID: 213823 RVA: 0x007081DC File Offset: 0x007063DC
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(1, targetOffset, 0);
		}

		// Token: 0x06034340 RID: 213824 RVA: 0x007081E7 File Offset: 0x007063E7
		public static Offset<IPlayerLookTowards> EndIPlayerLookTowards(FlatBufferBuilder builder)
		{
			return new Offset<IPlayerLookTowards>(builder.EndTable());
		}

		// Token: 0x06034341 RID: 213825 RVA: 0x007081F4 File Offset: 0x007063F4
		public IPlayerLookTowardsT UnPack()
		{
			IPlayerLookTowardsT playerLookTowardsT = new IPlayerLookTowardsT();
			this.UnPackTo(playerLookTowardsT);
			return playerLookTowardsT;
		}

		// Token: 0x06034342 RID: 213826 RVA: 0x00708210 File Offset: 0x00706410
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

		// Token: 0x06034343 RID: 213827 RVA: 0x00708370 File Offset: 0x00706570
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

		// Token: 0x040125F6 RID: 75254
		private Table __p;
	}
}
