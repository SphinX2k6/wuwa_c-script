using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EDA RID: 24282
	public struct ISceneItemPatrol : IFlatbufferObject
	{
		// Token: 0x1700B36B RID: 45931
		// (get) Token: 0x06028B40 RID: 166720 RVA: 0x00590496 File Offset: 0x0058E696
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028B41 RID: 166721 RVA: 0x005904A3 File Offset: 0x0058E6A3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028B42 RID: 166722 RVA: 0x005904AC File Offset: 0x0058E6AC
		public static ISceneItemPatrol GetRootAsISceneItemPatrol(ByteBuffer _bb)
		{
			return ISceneItemPatrol.GetRootAsISceneItemPatrol(_bb, default(ISceneItemPatrol));
		}

		// Token: 0x06028B43 RID: 166723 RVA: 0x005904C8 File Offset: 0x0058E6C8
		public static ISceneItemPatrol GetRootAsISceneItemPatrol(ByteBuffer _bb, ISceneItemPatrol obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028B44 RID: 166724 RVA: 0x005904E5 File Offset: 0x0058E6E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028B45 RID: 166725 RVA: 0x005904F4 File Offset: 0x0058E6F4
		public ISceneItemPatrol __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B36C RID: 45932
		// (get) Token: 0x06028B46 RID: 166726 RVA: 0x00590504 File Offset: 0x0058E704
		public ESceneItemAiType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESceneItemAiType.SceneItemPatrol;
				}
				return (ESceneItemAiType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B36D RID: 45933
		// (get) Token: 0x06028B47 RID: 166727 RVA: 0x00590540 File Offset: 0x0058E740
		public IConditionGroup? EnableCondition
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B36E RID: 45934
		// (get) Token: 0x06028B48 RID: 166728 RVA: 0x005905A0 File Offset: 0x0058E7A0
		public IConditionGroup? DisableCondition
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B36F RID: 45935
		// (get) Token: 0x06028B49 RID: 166729 RVA: 0x00590600 File Offset: 0x0058E800
		public bool HideWhenDisable
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B370 RID: 45936
		// (get) Token: 0x06028B4A RID: 166730 RVA: 0x00590640 File Offset: 0x0058E840
		public ISceneItemAiPatrolByGameTime? PatrolType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new ISceneItemAiPatrolByGameTime?(default(ISceneItemAiPatrolByGameTime).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06028B4B RID: 166731 RVA: 0x0059069E File Offset: 0x0058E89E
		public static Offset<ISceneItemPatrol> CreateISceneItemPatrol(FlatBufferBuilder builder, ESceneItemAiType Type = ESceneItemAiType.SceneItemPatrol, Offset<IConditionGroup> EnableConditionOffset = default(Offset<IConditionGroup>), Offset<IConditionGroup> DisableConditionOffset = default(Offset<IConditionGroup>), bool HideWhenDisable = false, Offset<ISceneItemAiPatrolByGameTime> PatrolTypeOffset = default(Offset<ISceneItemAiPatrolByGameTime>))
		{
			builder.StartTable(5);
			ISceneItemPatrol.AddPatrolType(builder, PatrolTypeOffset);
			ISceneItemPatrol.AddDisableCondition(builder, DisableConditionOffset);
			ISceneItemPatrol.AddEnableCondition(builder, EnableConditionOffset);
			ISceneItemPatrol.AddHideWhenDisable(builder, HideWhenDisable);
			ISceneItemPatrol.AddType(builder, Type);
			return ISceneItemPatrol.EndISceneItemPatrol(builder);
		}

		// Token: 0x06028B4C RID: 166732 RVA: 0x005906D2 File Offset: 0x0058E8D2
		public static void StartISceneItemPatrol(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06028B4D RID: 166733 RVA: 0x005906DB File Offset: 0x0058E8DB
		public static void AddType(FlatBufferBuilder builder, ESceneItemAiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028B4E RID: 166734 RVA: 0x005906E6 File Offset: 0x0058E8E6
		public static void AddEnableCondition(FlatBufferBuilder builder, Offset<IConditionGroup> enableConditionOffset)
		{
			builder.AddOffset(1, enableConditionOffset.Value, 0);
		}

		// Token: 0x06028B4F RID: 166735 RVA: 0x005906F6 File Offset: 0x0058E8F6
		public static void AddDisableCondition(FlatBufferBuilder builder, Offset<IConditionGroup> disableConditionOffset)
		{
			builder.AddOffset(2, disableConditionOffset.Value, 0);
		}

		// Token: 0x06028B50 RID: 166736 RVA: 0x00590706 File Offset: 0x0058E906
		public static void AddHideWhenDisable(FlatBufferBuilder builder, bool hideWhenDisable)
		{
			builder.AddBool(3, hideWhenDisable, false);
		}

		// Token: 0x06028B51 RID: 166737 RVA: 0x00590711 File Offset: 0x0058E911
		public static void AddPatrolType(FlatBufferBuilder builder, Offset<ISceneItemAiPatrolByGameTime> patrolTypeOffset)
		{
			builder.AddOffset(4, patrolTypeOffset.Value, 0);
		}

		// Token: 0x06028B52 RID: 166738 RVA: 0x00590721 File Offset: 0x0058E921
		public static Offset<ISceneItemPatrol> EndISceneItemPatrol(FlatBufferBuilder builder)
		{
			return new Offset<ISceneItemPatrol>(builder.EndTable());
		}

		// Token: 0x06028B53 RID: 166739 RVA: 0x00590730 File Offset: 0x0058E930
		public ISceneItemPatrolT UnPack()
		{
			ISceneItemPatrolT sceneItemPatrolT = new ISceneItemPatrolT();
			this.UnPackTo(sceneItemPatrolT);
			return sceneItemPatrolT;
		}

		// Token: 0x06028B54 RID: 166740 RVA: 0x0059074C File Offset: 0x0058E94C
		public void UnPackTo(ISceneItemPatrolT _o)
		{
			_o.Type = this.Type;
			_o.EnableCondition = ((this.EnableCondition != null) ? this.EnableCondition.Value.UnPack() : null);
			_o.DisableCondition = ((this.DisableCondition != null) ? this.DisableCondition.Value.UnPack() : null);
			_o.HideWhenDisable = this.HideWhenDisable;
			_o.PatrolType = ((this.PatrolType != null) ? this.PatrolType.Value.UnPack() : null);
		}

		// Token: 0x06028B55 RID: 166741 RVA: 0x00590800 File Offset: 0x0058EA00
		public static Offset<ISceneItemPatrol> Pack(FlatBufferBuilder builder, ISceneItemPatrolT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneItemPatrol>);
			}
			Offset<IConditionGroup> enableConditionOffset = (_o.EnableCondition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.EnableCondition);
			Offset<IConditionGroup> disableConditionOffset = (_o.DisableCondition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.DisableCondition);
			Offset<ISceneItemAiPatrolByGameTime> patrolTypeOffset = (_o.PatrolType == null) ? default(Offset<ISceneItemAiPatrolByGameTime>) : ISceneItemAiPatrolByGameTime.Pack(builder, _o.PatrolType);
			return ISceneItemPatrol.CreateISceneItemPatrol(builder, _o.Type, enableConditionOffset, disableConditionOffset, _o.HideWhenDisable, patrolTypeOffset);
		}

		// Token: 0x0400FB3A RID: 64314
		private Table __p;
	}
}
