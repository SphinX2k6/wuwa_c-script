using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053A1 RID: 21409
	public struct IHitLogicType : IFlatbufferObject
	{
		// Token: 0x17009D4D RID: 40269
		// (get) Token: 0x0602310A RID: 143626 RVA: 0x004DAD3A File Offset: 0x004D8F3A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602310B RID: 143627 RVA: 0x004DAD47 File Offset: 0x004D8F47
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602310C RID: 143628 RVA: 0x004DAD50 File Offset: 0x004D8F50
		public static IHitLogicType GetRootAsIHitLogicType(ByteBuffer _bb)
		{
			return IHitLogicType.GetRootAsIHitLogicType(_bb, default(IHitLogicType));
		}

		// Token: 0x0602310D RID: 143629 RVA: 0x004DAD6C File Offset: 0x004D8F6C
		public static IHitLogicType GetRootAsIHitLogicType(ByteBuffer _bb, IHitLogicType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602310E RID: 143630 RVA: 0x004DAD89 File Offset: 0x004D8F89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602310F RID: 143631 RVA: 0x004DAD98 File Offset: 0x004D8F98
		public IHitLogicType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009D4E RID: 40270
		// (get) Token: 0x06023110 RID: 143632 RVA: 0x004DADA8 File Offset: 0x004D8FA8
		public EHitLogicType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHitLogicType.ChangeNextState;
				}
				return (EHitLogicType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023111 RID: 143633 RVA: 0x004DADE4 File Offset: 0x004D8FE4
		public static Offset<IHitLogicType> CreateIHitLogicType(FlatBufferBuilder builder, EHitLogicType Type = EHitLogicType.ChangeNextState)
		{
			builder.StartTable(1);
			IHitLogicType.AddType(builder, Type);
			return IHitLogicType.EndIHitLogicType(builder);
		}

		// Token: 0x06023112 RID: 143634 RVA: 0x004DADFA File Offset: 0x004D8FFA
		public static void StartIHitLogicType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06023113 RID: 143635 RVA: 0x004DAE03 File Offset: 0x004D9003
		public static void AddType(FlatBufferBuilder builder, EHitLogicType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023114 RID: 143636 RVA: 0x004DAE0E File Offset: 0x004D900E
		public static Offset<IHitLogicType> EndIHitLogicType(FlatBufferBuilder builder)
		{
			return new Offset<IHitLogicType>(builder.EndTable());
		}

		// Token: 0x06023115 RID: 143637 RVA: 0x004DAE1C File Offset: 0x004D901C
		public IHitLogicTypeT UnPack()
		{
			IHitLogicTypeT hitLogicTypeT = new IHitLogicTypeT();
			this.UnPackTo(hitLogicTypeT);
			return hitLogicTypeT;
		}

		// Token: 0x06023116 RID: 143638 RVA: 0x004DAE37 File Offset: 0x004D9037
		public void UnPackTo(IHitLogicTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06023117 RID: 143639 RVA: 0x004DAE48 File Offset: 0x004D9048
		public static Offset<IHitLogicType> Pack(FlatBufferBuilder builder, IHitLogicTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHitLogicType>);
			}
			return IHitLogicType.CreateIHitLogicType(builder, _o.Type);
		}

		// Token: 0x0400E58B RID: 58763
		private Table __p;
	}
}
