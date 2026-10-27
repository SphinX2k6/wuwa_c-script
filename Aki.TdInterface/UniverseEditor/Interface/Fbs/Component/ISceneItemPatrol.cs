using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058CD RID: 22733
	public struct ISceneItemPatrol : IFlatbufferObject
	{
		// Token: 0x1700AA3B RID: 43579
		// (get) Token: 0x060265DE RID: 157150 RVA: 0x0054994A File Offset: 0x00547B4A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060265DF RID: 157151 RVA: 0x00549957 File Offset: 0x00547B57
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060265E0 RID: 157152 RVA: 0x00549960 File Offset: 0x00547B60
		public static ISceneItemPatrol GetRootAsISceneItemPatrol(ByteBuffer _bb)
		{
			return ISceneItemPatrol.GetRootAsISceneItemPatrol(_bb, default(ISceneItemPatrol));
		}

		// Token: 0x060265E1 RID: 157153 RVA: 0x0054997C File Offset: 0x00547B7C
		public static ISceneItemPatrol GetRootAsISceneItemPatrol(ByteBuffer _bb, ISceneItemPatrol obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060265E2 RID: 157154 RVA: 0x00549999 File Offset: 0x00547B99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060265E3 RID: 157155 RVA: 0x005499A8 File Offset: 0x00547BA8
		public ISceneItemPatrol __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AA3C RID: 43580
		// (get) Token: 0x060265E4 RID: 157156 RVA: 0x005499B8 File Offset: 0x00547BB8
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

		// Token: 0x1700AA3D RID: 43581
		// (get) Token: 0x060265E5 RID: 157157 RVA: 0x005499F4 File Offset: 0x00547BF4
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

		// Token: 0x1700AA3E RID: 43582
		// (get) Token: 0x060265E6 RID: 157158 RVA: 0x00549A54 File Offset: 0x00547C54
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

		// Token: 0x1700AA3F RID: 43583
		// (get) Token: 0x060265E7 RID: 157159 RVA: 0x00549AB4 File Offset: 0x00547CB4
		public bool HideWhenDisable
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AA40 RID: 43584
		// (get) Token: 0x060265E8 RID: 157160 RVA: 0x00549AF4 File Offset: 0x00547CF4
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

		// Token: 0x060265E9 RID: 157161 RVA: 0x00549B52 File Offset: 0x00547D52
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

		// Token: 0x060265EA RID: 157162 RVA: 0x00549B86 File Offset: 0x00547D86
		public static void StartISceneItemPatrol(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060265EB RID: 157163 RVA: 0x00549B8F File Offset: 0x00547D8F
		public static void AddType(FlatBufferBuilder builder, ESceneItemAiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060265EC RID: 157164 RVA: 0x00549B9A File Offset: 0x00547D9A
		public static void AddEnableCondition(FlatBufferBuilder builder, Offset<IConditionGroup> enableConditionOffset)
		{
			builder.AddOffset(1, enableConditionOffset.Value, 0);
		}

		// Token: 0x060265ED RID: 157165 RVA: 0x00549BAA File Offset: 0x00547DAA
		public static void AddDisableCondition(FlatBufferBuilder builder, Offset<IConditionGroup> disableConditionOffset)
		{
			builder.AddOffset(2, disableConditionOffset.Value, 0);
		}

		// Token: 0x060265EE RID: 157166 RVA: 0x00549BBA File Offset: 0x00547DBA
		public static void AddHideWhenDisable(FlatBufferBuilder builder, bool hideWhenDisable)
		{
			builder.AddBool(3, hideWhenDisable, false);
		}

		// Token: 0x060265EF RID: 157167 RVA: 0x00549BC5 File Offset: 0x00547DC5
		public static void AddPatrolType(FlatBufferBuilder builder, Offset<ISceneItemAiPatrolByGameTime> patrolTypeOffset)
		{
			builder.AddOffset(4, patrolTypeOffset.Value, 0);
		}

		// Token: 0x060265F0 RID: 157168 RVA: 0x00549BD5 File Offset: 0x00547DD5
		public static Offset<ISceneItemPatrol> EndISceneItemPatrol(FlatBufferBuilder builder)
		{
			return new Offset<ISceneItemPatrol>(builder.EndTable());
		}

		// Token: 0x060265F1 RID: 157169 RVA: 0x00549BE4 File Offset: 0x00547DE4
		public ISceneItemPatrolT UnPack()
		{
			ISceneItemPatrolT sceneItemPatrolT = new ISceneItemPatrolT();
			this.UnPackTo(sceneItemPatrolT);
			return sceneItemPatrolT;
		}

		// Token: 0x060265F2 RID: 157170 RVA: 0x00549C00 File Offset: 0x00547E00
		public void UnPackTo(ISceneItemPatrolT _o)
		{
			_o.Type = this.Type;
			_o.EnableCondition = ((this.EnableCondition != null) ? this.EnableCondition.Value.UnPack() : null);
			_o.DisableCondition = ((this.DisableCondition != null) ? this.DisableCondition.Value.UnPack() : null);
			_o.HideWhenDisable = this.HideWhenDisable;
			_o.PatrolType = ((this.PatrolType != null) ? this.PatrolType.Value.UnPack() : null);
		}

		// Token: 0x060265F3 RID: 157171 RVA: 0x00549CB4 File Offset: 0x00547EB4
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

		// Token: 0x0400EE47 RID: 60999
		private Table __p;
	}
}
