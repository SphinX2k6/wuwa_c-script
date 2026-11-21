using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069AB RID: 27051
	public struct ICharacterLookAt : IFlatbufferObject
	{
		// Token: 0x1700C71B RID: 50971
		// (get) Token: 0x0602E66D RID: 190061 RVA: 0x0065522A File Offset: 0x0065342A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E66E RID: 190062 RVA: 0x00655237 File Offset: 0x00653437
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E66F RID: 190063 RVA: 0x00655240 File Offset: 0x00653440
		public static ICharacterLookAt GetRootAsICharacterLookAt(ByteBuffer _bb)
		{
			return ICharacterLookAt.GetRootAsICharacterLookAt(_bb, default(ICharacterLookAt));
		}

		// Token: 0x0602E670 RID: 190064 RVA: 0x0065525C File Offset: 0x0065345C
		public static ICharacterLookAt GetRootAsICharacterLookAt(ByteBuffer _bb, ICharacterLookAt obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E671 RID: 190065 RVA: 0x00655279 File Offset: 0x00653479
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E672 RID: 190066 RVA: 0x00655288 File Offset: 0x00653488
		public ICharacterLookAt __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C71C RID: 50972
		// (get) Token: 0x0602E673 RID: 190067 RVA: 0x00655298 File Offset: 0x00653498
		public int CharEntityId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C71D RID: 50973
		// (get) Token: 0x0602E674 RID: 190068 RVA: 0x006552D4 File Offset: 0x006534D4
		public TCharacterLookAtData TargetType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TCharacterLookAtData.NONE;
				}
				return (TCharacterLookAtData)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E675 RID: 190069 RVA: 0x00655310 File Offset: 0x00653510
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602E676 RID: 190070 RVA: 0x00655354 File Offset: 0x00653554
		public ICharacterLookAtEmptyData TargetAsICharacterLookAtEmptyData()
		{
			return this.Target<ICharacterLookAtEmptyData>().Value;
		}

		// Token: 0x0602E677 RID: 190071 RVA: 0x00655370 File Offset: 0x00653570
		public ICharacterLookAtEntityData TargetAsICharacterLookAtEntityData()
		{
			return this.Target<ICharacterLookAtEntityData>().Value;
		}

		// Token: 0x0602E678 RID: 190072 RVA: 0x0065538C File Offset: 0x0065358C
		public ICharacterLookAtPlayerData TargetAsICharacterLookAtPlayerData()
		{
			return this.Target<ICharacterLookAtPlayerData>().Value;
		}

		// Token: 0x0602E679 RID: 190073 RVA: 0x006553A8 File Offset: 0x006535A8
		public ICharacterLookAtPositionData TargetAsICharacterLookAtPositionData()
		{
			return this.Target<ICharacterLookAtPositionData>().Value;
		}

		// Token: 0x0602E67A RID: 190074 RVA: 0x006553C4 File Offset: 0x006535C4
		public ICharacterLookAtUnlockData TargetAsICharacterLookAtUnlockData()
		{
			return this.Target<ICharacterLookAtUnlockData>().Value;
		}

		// Token: 0x0602E67B RID: 190075 RVA: 0x006553DF File Offset: 0x006535DF
		public static Offset<ICharacterLookAt> CreateICharacterLookAt(FlatBufferBuilder builder, int CharEntityId = 0, TCharacterLookAtData Target_type = TCharacterLookAtData.NONE, int TargetOffset = 0)
		{
			builder.StartTable(3);
			ICharacterLookAt.AddTarget(builder, TargetOffset);
			ICharacterLookAt.AddCharEntityId(builder, CharEntityId);
			ICharacterLookAt.AddTargetType(builder, Target_type);
			return ICharacterLookAt.EndICharacterLookAt(builder);
		}

		// Token: 0x0602E67C RID: 190076 RVA: 0x00655403 File Offset: 0x00653603
		public static void StartICharacterLookAt(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602E67D RID: 190077 RVA: 0x0065540C File Offset: 0x0065360C
		public static void AddCharEntityId(FlatBufferBuilder builder, int charEntityId)
		{
			builder.AddInt(0, charEntityId, 0);
		}

		// Token: 0x0602E67E RID: 190078 RVA: 0x00655417 File Offset: 0x00653617
		public static void AddTargetType(FlatBufferBuilder builder, TCharacterLookAtData targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x0602E67F RID: 190079 RVA: 0x00655422 File Offset: 0x00653622
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x0602E680 RID: 190080 RVA: 0x0065542D File Offset: 0x0065362D
		public static Offset<ICharacterLookAt> EndICharacterLookAt(FlatBufferBuilder builder)
		{
			return new Offset<ICharacterLookAt>(builder.EndTable());
		}

		// Token: 0x0602E681 RID: 190081 RVA: 0x0065543C File Offset: 0x0065363C
		public ICharacterLookAtT UnPack()
		{
			ICharacterLookAtT characterLookAtT = new ICharacterLookAtT();
			this.UnPackTo(characterLookAtT);
			return characterLookAtT;
		}

		// Token: 0x0602E682 RID: 190082 RVA: 0x00655458 File Offset: 0x00653658
		public void UnPackTo(ICharacterLookAtT _o)
		{
			_o.CharEntityId = this.CharEntityId;
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

		// Token: 0x0602E683 RID: 190083 RVA: 0x006555C4 File Offset: 0x006537C4
		public static Offset<ICharacterLookAt> Pack(FlatBufferBuilder builder, ICharacterLookAtT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICharacterLookAt>);
			}
			TCharacterLookAtData target_type = (_o.Target == null) ? TCharacterLookAtData.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TCharacterLookAtDataUnion.Pack(builder, _o.Target);
			return ICharacterLookAt.CreateICharacterLookAt(builder, _o.CharEntityId, target_type, targetOffset);
		}

		// Token: 0x04011716 RID: 71446
		private Table __p;
	}
}
