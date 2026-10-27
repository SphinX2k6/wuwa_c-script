using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BC5 RID: 19397
	public struct ICompareTeammateDieCondition : IFlatbufferObject
	{
		// Token: 0x17008CDE RID: 36062
		// (get) Token: 0x0601E9BD RID: 125373 RVA: 0x00447E48 File Offset: 0x00446048
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E9BE RID: 125374 RVA: 0x00447E55 File Offset: 0x00446055
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E9BF RID: 125375 RVA: 0x00447E5C File Offset: 0x0044605C
		public static ICompareTeammateDieCondition GetRootAsICompareTeammateDieCondition(ByteBuffer _bb)
		{
			return ICompareTeammateDieCondition.GetRootAsICompareTeammateDieCondition(_bb, default(ICompareTeammateDieCondition));
		}

		// Token: 0x0601E9C0 RID: 125376 RVA: 0x00447E78 File Offset: 0x00446078
		public static ICompareTeammateDieCondition GetRootAsICompareTeammateDieCondition(ByteBuffer _bb, ICompareTeammateDieCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E9C1 RID: 125377 RVA: 0x00447E95 File Offset: 0x00446095
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E9C2 RID: 125378 RVA: 0x00447EA4 File Offset: 0x004460A4
		public ICompareTeammateDieCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008CDF RID: 36063
		// (get) Token: 0x0601E9C3 RID: 125379 RVA: 0x00447EB4 File Offset: 0x004460B4
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008CE0 RID: 36064
		// (get) Token: 0x0601E9C4 RID: 125380 RVA: 0x00447EF0 File Offset: 0x004460F0
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008CE1 RID: 36065
		// (get) Token: 0x0601E9C5 RID: 125381 RVA: 0x00447F2C File Offset: 0x0044612C
		public int DieCount
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E9C6 RID: 125382 RVA: 0x00447F68 File Offset: 0x00446168
		public static Offset<ICompareTeammateDieCondition> CreateICompareTeammateDieCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, ECompare Compare = ECompare.Eq, int DieCount = 0)
		{
			builder.StartTable(3);
			ICompareTeammateDieCondition.AddDieCount(builder, DieCount);
			ICompareTeammateDieCondition.AddCompare(builder, Compare);
			ICompareTeammateDieCondition.AddType(builder, Type);
			return ICompareTeammateDieCondition.EndICompareTeammateDieCondition(builder);
		}

		// Token: 0x0601E9C7 RID: 125383 RVA: 0x00447F8C File Offset: 0x0044618C
		public static void StartICompareTeammateDieCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601E9C8 RID: 125384 RVA: 0x00447F95 File Offset: 0x00446195
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E9C9 RID: 125385 RVA: 0x00447FA0 File Offset: 0x004461A0
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x0601E9CA RID: 125386 RVA: 0x00447FAB File Offset: 0x004461AB
		public static void AddDieCount(FlatBufferBuilder builder, int dieCount)
		{
			builder.AddInt(2, dieCount, 0);
		}

		// Token: 0x0601E9CB RID: 125387 RVA: 0x00447FB6 File Offset: 0x004461B6
		public static Offset<ICompareTeammateDieCondition> EndICompareTeammateDieCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICompareTeammateDieCondition>(builder.EndTable());
		}

		// Token: 0x0601E9CC RID: 125388 RVA: 0x00447FC4 File Offset: 0x004461C4
		public ICompareTeammateDieConditionT UnPack()
		{
			ICompareTeammateDieConditionT compareTeammateDieConditionT = new ICompareTeammateDieConditionT();
			this.UnPackTo(compareTeammateDieConditionT);
			return compareTeammateDieConditionT;
		}

		// Token: 0x0601E9CD RID: 125389 RVA: 0x00447FDF File Offset: 0x004461DF
		public void UnPackTo(ICompareTeammateDieConditionT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.DieCount = this.DieCount;
		}

		// Token: 0x0601E9CE RID: 125390 RVA: 0x00448008 File Offset: 0x00446208
		public static Offset<ICompareTeammateDieCondition> Pack(FlatBufferBuilder builder, ICompareTeammateDieConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareTeammateDieCondition>);
			}
			return ICompareTeammateDieCondition.CreateICompareTeammateDieCondition(builder, _o.Type, _o.Compare, _o.DieCount);
		}

		// Token: 0x0400D4B0 RID: 54448
		private Table __p;
	}
}
