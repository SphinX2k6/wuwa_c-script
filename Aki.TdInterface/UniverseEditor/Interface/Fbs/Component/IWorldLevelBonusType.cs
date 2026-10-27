using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B92 RID: 23442
	public struct IWorldLevelBonusType : IFlatbufferObject
	{
		// Token: 0x1700B12C RID: 45356
		// (get) Token: 0x06028225 RID: 164389 RVA: 0x00584336 File Offset: 0x00582536
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028226 RID: 164390 RVA: 0x00584343 File Offset: 0x00582543
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028227 RID: 164391 RVA: 0x0058434C File Offset: 0x0058254C
		public static IWorldLevelBonusType GetRootAsIWorldLevelBonusType(ByteBuffer _bb)
		{
			return IWorldLevelBonusType.GetRootAsIWorldLevelBonusType(_bb, default(IWorldLevelBonusType));
		}

		// Token: 0x06028228 RID: 164392 RVA: 0x00584368 File Offset: 0x00582568
		public static IWorldLevelBonusType GetRootAsIWorldLevelBonusType(ByteBuffer _bb, IWorldLevelBonusType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028229 RID: 164393 RVA: 0x00584385 File Offset: 0x00582585
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602822A RID: 164394 RVA: 0x00584394 File Offset: 0x00582594
		public IWorldLevelBonusType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B12D RID: 45357
		// (get) Token: 0x0602822B RID: 164395 RVA: 0x005843A4 File Offset: 0x005825A4
		public EWorldLevelBonus Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EWorldLevelBonus.WorldLevelTable;
				}
				return (EWorldLevelBonus)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602822C RID: 164396 RVA: 0x005843E0 File Offset: 0x005825E0
		public static Offset<IWorldLevelBonusType> CreateIWorldLevelBonusType(FlatBufferBuilder builder, EWorldLevelBonus Type = EWorldLevelBonus.WorldLevelTable)
		{
			builder.StartTable(1);
			IWorldLevelBonusType.AddType(builder, Type);
			return IWorldLevelBonusType.EndIWorldLevelBonusType(builder);
		}

		// Token: 0x0602822D RID: 164397 RVA: 0x005843F6 File Offset: 0x005825F6
		public static void StartIWorldLevelBonusType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602822E RID: 164398 RVA: 0x005843FF File Offset: 0x005825FF
		public static void AddType(FlatBufferBuilder builder, EWorldLevelBonus type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602822F RID: 164399 RVA: 0x0058440A File Offset: 0x0058260A
		public static Offset<IWorldLevelBonusType> EndIWorldLevelBonusType(FlatBufferBuilder builder)
		{
			return new Offset<IWorldLevelBonusType>(builder.EndTable());
		}

		// Token: 0x06028230 RID: 164400 RVA: 0x00584418 File Offset: 0x00582618
		public IWorldLevelBonusTypeT UnPack()
		{
			IWorldLevelBonusTypeT worldLevelBonusTypeT = new IWorldLevelBonusTypeT();
			this.UnPackTo(worldLevelBonusTypeT);
			return worldLevelBonusTypeT;
		}

		// Token: 0x06028231 RID: 164401 RVA: 0x00584433 File Offset: 0x00582633
		public void UnPackTo(IWorldLevelBonusTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06028232 RID: 164402 RVA: 0x00584444 File Offset: 0x00582644
		public static Offset<IWorldLevelBonusType> Pack(FlatBufferBuilder builder, IWorldLevelBonusTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWorldLevelBonusType>);
			}
			return IWorldLevelBonusType.CreateIWorldLevelBonusType(builder, _o.Type);
		}

		// Token: 0x0400F2F4 RID: 62196
		private Table __p;
	}
}
