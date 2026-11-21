using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E48 RID: 20040
	public struct ICheckCalabashDevelopRewardCondition : IFlatbufferObject
	{
		// Token: 0x17008EC6 RID: 36550
		// (get) Token: 0x0601F005 RID: 126981 RVA: 0x00454294 File Offset: 0x00452494
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F006 RID: 126982 RVA: 0x004542A1 File Offset: 0x004524A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F007 RID: 126983 RVA: 0x004542A8 File Offset: 0x004524A8
		public static ICheckCalabashDevelopRewardCondition GetRootAsICheckCalabashDevelopRewardCondition(ByteBuffer _bb)
		{
			return ICheckCalabashDevelopRewardCondition.GetRootAsICheckCalabashDevelopRewardCondition(_bb, default(ICheckCalabashDevelopRewardCondition));
		}

		// Token: 0x0601F008 RID: 126984 RVA: 0x004542C4 File Offset: 0x004524C4
		public static ICheckCalabashDevelopRewardCondition GetRootAsICheckCalabashDevelopRewardCondition(ByteBuffer _bb, ICheckCalabashDevelopRewardCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F009 RID: 126985 RVA: 0x004542E1 File Offset: 0x004524E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F00A RID: 126986 RVA: 0x004542F0 File Offset: 0x004524F0
		public ICheckCalabashDevelopRewardCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008EC7 RID: 36551
		// (get) Token: 0x0601F00B RID: 126987 RVA: 0x00454300 File Offset: 0x00452500
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

		// Token: 0x17008EC8 RID: 36552
		// (get) Token: 0x0601F00C RID: 126988 RVA: 0x0045433C File Offset: 0x0045253C
		public int MonsterId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008EC9 RID: 36553
		// (get) Token: 0x0601F00D RID: 126989 RVA: 0x00454378 File Offset: 0x00452578
		public ECalabashDevelop Develop
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ECalabashDevelop.None;
				}
				return (ECalabashDevelop)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F00E RID: 126990 RVA: 0x004543B4 File Offset: 0x004525B4
		public static Offset<ICheckCalabashDevelopRewardCondition> CreateICheckCalabashDevelopRewardCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int MonsterId = 0, ECalabashDevelop Develop = ECalabashDevelop.None)
		{
			builder.StartTable(3);
			ICheckCalabashDevelopRewardCondition.AddMonsterId(builder, MonsterId);
			ICheckCalabashDevelopRewardCondition.AddDevelop(builder, Develop);
			ICheckCalabashDevelopRewardCondition.AddType(builder, Type);
			return ICheckCalabashDevelopRewardCondition.EndICheckCalabashDevelopRewardCondition(builder);
		}

		// Token: 0x0601F00F RID: 126991 RVA: 0x004543D8 File Offset: 0x004525D8
		public static void StartICheckCalabashDevelopRewardCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601F010 RID: 126992 RVA: 0x004543E1 File Offset: 0x004525E1
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F011 RID: 126993 RVA: 0x004543EC File Offset: 0x004525EC
		public static void AddMonsterId(FlatBufferBuilder builder, int monsterId)
		{
			builder.AddInt(1, monsterId, 0);
		}

		// Token: 0x0601F012 RID: 126994 RVA: 0x004543F7 File Offset: 0x004525F7
		public static void AddDevelop(FlatBufferBuilder builder, ECalabashDevelop develop)
		{
			builder.AddByte(2, (byte)develop, 0);
		}

		// Token: 0x0601F013 RID: 126995 RVA: 0x00454402 File Offset: 0x00452602
		public static Offset<ICheckCalabashDevelopRewardCondition> EndICheckCalabashDevelopRewardCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckCalabashDevelopRewardCondition>(builder.EndTable());
		}

		// Token: 0x0601F014 RID: 126996 RVA: 0x00454410 File Offset: 0x00452610
		public ICheckCalabashDevelopRewardConditionT UnPack()
		{
			ICheckCalabashDevelopRewardConditionT checkCalabashDevelopRewardConditionT = new ICheckCalabashDevelopRewardConditionT();
			this.UnPackTo(checkCalabashDevelopRewardConditionT);
			return checkCalabashDevelopRewardConditionT;
		}

		// Token: 0x0601F015 RID: 126997 RVA: 0x0045442B File Offset: 0x0045262B
		public void UnPackTo(ICheckCalabashDevelopRewardConditionT _o)
		{
			_o.Type = this.Type;
			_o.MonsterId = this.MonsterId;
			_o.Develop = this.Develop;
		}

		// Token: 0x0601F016 RID: 126998 RVA: 0x00454454 File Offset: 0x00452654
		public static Offset<ICheckCalabashDevelopRewardCondition> Pack(FlatBufferBuilder builder, ICheckCalabashDevelopRewardConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckCalabashDevelopRewardCondition>);
			}
			return ICheckCalabashDevelopRewardCondition.CreateICheckCalabashDevelopRewardCondition(builder, _o.Type, _o.MonsterId, _o.Develop);
		}

		// Token: 0x0400DC69 RID: 56425
		private Table __p;
	}
}
