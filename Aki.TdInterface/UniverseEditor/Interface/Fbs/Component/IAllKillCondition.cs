using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E95 RID: 20117
	public struct IAllKillCondition : IFlatbufferObject
	{
		// Token: 0x17009045 RID: 36933
		// (get) Token: 0x0601FA7E RID: 129662 RVA: 0x00468952 File Offset: 0x00466B52
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FA7F RID: 129663 RVA: 0x0046895F File Offset: 0x00466B5F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FA80 RID: 129664 RVA: 0x00468968 File Offset: 0x00466B68
		public static IAllKillCondition GetRootAsIAllKillCondition(ByteBuffer _bb)
		{
			return IAllKillCondition.GetRootAsIAllKillCondition(_bb, default(IAllKillCondition));
		}

		// Token: 0x0601FA81 RID: 129665 RVA: 0x00468984 File Offset: 0x00466B84
		public static IAllKillCondition GetRootAsIAllKillCondition(ByteBuffer _bb, IAllKillCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FA82 RID: 129666 RVA: 0x004689A1 File Offset: 0x00466BA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FA83 RID: 129667 RVA: 0x004689B0 File Offset: 0x00466BB0
		public IAllKillCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009046 RID: 36934
		// (get) Token: 0x0601FA84 RID: 129668 RVA: 0x004689C0 File Offset: 0x00466BC0
		public ESpawnMonsterCompleteCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpawnMonsterCompleteCondition.AllKill;
				}
				return (ESpawnMonsterCompleteCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601FA85 RID: 129669 RVA: 0x004689FC File Offset: 0x00466BFC
		public static Offset<IAllKillCondition> CreateIAllKillCondition(FlatBufferBuilder builder, ESpawnMonsterCompleteCondition Type = ESpawnMonsterCompleteCondition.AllKill)
		{
			builder.StartTable(1);
			IAllKillCondition.AddType(builder, Type);
			return IAllKillCondition.EndIAllKillCondition(builder);
		}

		// Token: 0x0601FA86 RID: 129670 RVA: 0x00468A12 File Offset: 0x00466C12
		public static void StartIAllKillCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601FA87 RID: 129671 RVA: 0x00468A1B File Offset: 0x00466C1B
		public static void AddType(FlatBufferBuilder builder, ESpawnMonsterCompleteCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FA88 RID: 129672 RVA: 0x00468A26 File Offset: 0x00466C26
		public static Offset<IAllKillCondition> EndIAllKillCondition(FlatBufferBuilder builder)
		{
			return new Offset<IAllKillCondition>(builder.EndTable());
		}

		// Token: 0x0601FA89 RID: 129673 RVA: 0x00468A34 File Offset: 0x00466C34
		public IAllKillConditionT UnPack()
		{
			IAllKillConditionT allKillConditionT = new IAllKillConditionT();
			this.UnPackTo(allKillConditionT);
			return allKillConditionT;
		}

		// Token: 0x0601FA8A RID: 129674 RVA: 0x00468A4F File Offset: 0x00466C4F
		public void UnPackTo(IAllKillConditionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601FA8B RID: 129675 RVA: 0x00468A60 File Offset: 0x00466C60
		public static Offset<IAllKillCondition> Pack(FlatBufferBuilder builder, IAllKillConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAllKillCondition>);
			}
			return IAllKillCondition.CreateIAllKillCondition(builder, _o.Type);
		}

		// Token: 0x0400DC6F RID: 56431
		private Table __p;
	}
}
