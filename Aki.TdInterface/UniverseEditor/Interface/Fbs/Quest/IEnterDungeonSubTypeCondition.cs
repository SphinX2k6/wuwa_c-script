using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200423B RID: 16955
	public struct IEnterDungeonSubTypeCondition : IFlatbufferObject
	{
		// Token: 0x17007396 RID: 29590
		// (get) Token: 0x06017964 RID: 96612 RVA: 0x0035D7F6 File Offset: 0x0035B9F6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017965 RID: 96613 RVA: 0x0035D803 File Offset: 0x0035BA03
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017966 RID: 96614 RVA: 0x0035D80C File Offset: 0x0035BA0C
		public static IEnterDungeonSubTypeCondition GetRootAsIEnterDungeonSubTypeCondition(ByteBuffer _bb)
		{
			return IEnterDungeonSubTypeCondition.GetRootAsIEnterDungeonSubTypeCondition(_bb, default(IEnterDungeonSubTypeCondition));
		}

		// Token: 0x06017967 RID: 96615 RVA: 0x0035D828 File Offset: 0x0035BA28
		public static IEnterDungeonSubTypeCondition GetRootAsIEnterDungeonSubTypeCondition(ByteBuffer _bb, IEnterDungeonSubTypeCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017968 RID: 96616 RVA: 0x0035D845 File Offset: 0x0035BA45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017969 RID: 96617 RVA: 0x0035D854 File Offset: 0x0035BA54
		public IEnterDungeonSubTypeCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007397 RID: 29591
		// (get) Token: 0x0601796A RID: 96618 RVA: 0x0035D864 File Offset: 0x0035BA64
		public EDungeonConditionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDungeonConditionType.DungeonSubType;
				}
				return (EDungeonConditionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007398 RID: 29592
		// (get) Token: 0x0601796B RID: 96619 RVA: 0x0035D8A0 File Offset: 0x0035BAA0
		public EDungeonSubType DungeonSubType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EDungeonSubType.Test;
				}
				return (EDungeonSubType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601796C RID: 96620 RVA: 0x0035D8DC File Offset: 0x0035BADC
		public static Offset<IEnterDungeonSubTypeCondition> CreateIEnterDungeonSubTypeCondition(FlatBufferBuilder builder, EDungeonConditionType Type = EDungeonConditionType.DungeonSubType, EDungeonSubType DungeonSubType = EDungeonSubType.Test)
		{
			builder.StartTable(2);
			IEnterDungeonSubTypeCondition.AddDungeonSubType(builder, DungeonSubType);
			IEnterDungeonSubTypeCondition.AddType(builder, Type);
			return IEnterDungeonSubTypeCondition.EndIEnterDungeonSubTypeCondition(builder);
		}

		// Token: 0x0601796D RID: 96621 RVA: 0x0035D8F9 File Offset: 0x0035BAF9
		public static void StartIEnterDungeonSubTypeCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601796E RID: 96622 RVA: 0x0035D902 File Offset: 0x0035BB02
		public static void AddType(FlatBufferBuilder builder, EDungeonConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601796F RID: 96623 RVA: 0x0035D90D File Offset: 0x0035BB0D
		public static void AddDungeonSubType(FlatBufferBuilder builder, EDungeonSubType dungeonSubType)
		{
			builder.AddByte(1, (byte)dungeonSubType, 0);
		}

		// Token: 0x06017970 RID: 96624 RVA: 0x0035D918 File Offset: 0x0035BB18
		public static Offset<IEnterDungeonSubTypeCondition> EndIEnterDungeonSubTypeCondition(FlatBufferBuilder builder)
		{
			return new Offset<IEnterDungeonSubTypeCondition>(builder.EndTable());
		}

		// Token: 0x06017971 RID: 96625 RVA: 0x0035D928 File Offset: 0x0035BB28
		public IEnterDungeonSubTypeConditionT UnPack()
		{
			IEnterDungeonSubTypeConditionT enterDungeonSubTypeConditionT = new IEnterDungeonSubTypeConditionT();
			this.UnPackTo(enterDungeonSubTypeConditionT);
			return enterDungeonSubTypeConditionT;
		}

		// Token: 0x06017972 RID: 96626 RVA: 0x0035D943 File Offset: 0x0035BB43
		public void UnPackTo(IEnterDungeonSubTypeConditionT _o)
		{
			_o.Type = this.Type;
			_o.DungeonSubType = this.DungeonSubType;
		}

		// Token: 0x06017973 RID: 96627 RVA: 0x0035D960 File Offset: 0x0035BB60
		public static Offset<IEnterDungeonSubTypeCondition> Pack(FlatBufferBuilder builder, IEnterDungeonSubTypeConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnterDungeonSubTypeCondition>);
			}
			return IEnterDungeonSubTypeCondition.CreateIEnterDungeonSubTypeCondition(builder, _o.Type, _o.DungeonSubType);
		}

		// Token: 0x0400C143 RID: 49475
		private Table __p;
	}
}
