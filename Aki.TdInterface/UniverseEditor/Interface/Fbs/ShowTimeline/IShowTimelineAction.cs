using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003B9B RID: 15259
	public struct IShowTimelineAction : IFlatbufferObject
	{
		// Token: 0x17006894 RID: 26772
		// (get) Token: 0x06014E78 RID: 85624 RVA: 0x003086CC File Offset: 0x003068CC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014E79 RID: 85625 RVA: 0x003086D9 File Offset: 0x003068D9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014E7A RID: 85626 RVA: 0x003086E0 File Offset: 0x003068E0
		public static IShowTimelineAction GetRootAsIShowTimelineAction(ByteBuffer _bb)
		{
			return IShowTimelineAction.GetRootAsIShowTimelineAction(_bb, default(IShowTimelineAction));
		}

		// Token: 0x06014E7B RID: 85627 RVA: 0x003086FC File Offset: 0x003068FC
		public static IShowTimelineAction GetRootAsIShowTimelineAction(ByteBuffer _bb, IShowTimelineAction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014E7C RID: 85628 RVA: 0x00308719 File Offset: 0x00306919
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014E7D RID: 85629 RVA: 0x00308728 File Offset: 0x00306928
		public IShowTimelineAction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006895 RID: 26773
		// (get) Token: 0x06014E7E RID: 85630 RVA: 0x00308738 File Offset: 0x00306938
		public EShowTimelineType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EShowTimelineType.Checkpoint;
				}
				return (EShowTimelineType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006896 RID: 26774
		// (get) Token: 0x06014E7F RID: 85631 RVA: 0x00308774 File Offset: 0x00306974
		public EShowTimelineActionType ActionType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EShowTimelineActionType.Skill;
				}
				return (EShowTimelineActionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006897 RID: 26775
		// (get) Token: 0x06014E80 RID: 85632 RVA: 0x003087B0 File Offset: 0x003069B0
		public int ActionParam
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

		// Token: 0x17006898 RID: 26776
		// (get) Token: 0x06014E81 RID: 85633 RVA: 0x003087EC File Offset: 0x003069EC
		public TShowTimelineActionOption ActionDataType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TShowTimelineActionOption.NONE;
				}
				return (TShowTimelineActionOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014E82 RID: 85634 RVA: 0x0030882C File Offset: 0x00306A2C
		public TTable? ActionData<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06014E83 RID: 85635 RVA: 0x00308874 File Offset: 0x00306A74
		public IShowTimelineCastSkill ActionDataAsIShowTimelineCastSkill()
		{
			return this.ActionData<IShowTimelineCastSkill>().Value;
		}

		// Token: 0x06014E84 RID: 85636 RVA: 0x00308890 File Offset: 0x00306A90
		public IShowTimelineJump ActionDataAsIShowTimelineJump()
		{
			return this.ActionData<IShowTimelineJump>().Value;
		}

		// Token: 0x06014E85 RID: 85637 RVA: 0x003088AC File Offset: 0x00306AAC
		public IShowTimelineSwitchRole ActionDataAsIShowTimelineSwitchRole()
		{
			return this.ActionData<IShowTimelineSwitchRole>().Value;
		}

		// Token: 0x17006899 RID: 26777
		// (get) Token: 0x06014E86 RID: 85638 RVA: 0x003088C8 File Offset: 0x00306AC8
		public IShowTimelineActionDisplayConfig? DisplayConfig
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IShowTimelineActionDisplayConfig?(default(IShowTimelineActionDisplayConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06014E87 RID: 85639 RVA: 0x00308926 File Offset: 0x00306B26
		public static Offset<IShowTimelineAction> CreateIShowTimelineAction(FlatBufferBuilder builder, EShowTimelineType Type = EShowTimelineType.Checkpoint, EShowTimelineActionType ActionType = EShowTimelineActionType.Skill, int ActionParam = 0, TShowTimelineActionOption ActionData_type = TShowTimelineActionOption.NONE, int ActionDataOffset = 0, Offset<IShowTimelineActionDisplayConfig> DisplayConfigOffset = default(Offset<IShowTimelineActionDisplayConfig>))
		{
			builder.StartTable(6);
			IShowTimelineAction.AddDisplayConfig(builder, DisplayConfigOffset);
			IShowTimelineAction.AddActionData(builder, ActionDataOffset);
			IShowTimelineAction.AddActionParam(builder, ActionParam);
			IShowTimelineAction.AddActionDataType(builder, ActionData_type);
			IShowTimelineAction.AddActionType(builder, ActionType);
			IShowTimelineAction.AddType(builder, Type);
			return IShowTimelineAction.EndIShowTimelineAction(builder);
		}

		// Token: 0x06014E88 RID: 85640 RVA: 0x00308962 File Offset: 0x00306B62
		public static void StartIShowTimelineAction(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06014E89 RID: 85641 RVA: 0x0030896B File Offset: 0x00306B6B
		public static void AddType(FlatBufferBuilder builder, EShowTimelineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014E8A RID: 85642 RVA: 0x00308976 File Offset: 0x00306B76
		public static void AddActionType(FlatBufferBuilder builder, EShowTimelineActionType actionType)
		{
			builder.AddByte(1, (byte)actionType, 0);
		}

		// Token: 0x06014E8B RID: 85643 RVA: 0x00308981 File Offset: 0x00306B81
		public static void AddActionParam(FlatBufferBuilder builder, int actionParam)
		{
			builder.AddInt(2, actionParam, 0);
		}

		// Token: 0x06014E8C RID: 85644 RVA: 0x0030898C File Offset: 0x00306B8C
		public static void AddActionDataType(FlatBufferBuilder builder, TShowTimelineActionOption actionDataType)
		{
			builder.AddByte(3, (byte)actionDataType, 0);
		}

		// Token: 0x06014E8D RID: 85645 RVA: 0x00308997 File Offset: 0x00306B97
		public static void AddActionData(FlatBufferBuilder builder, int actionDataOffset)
		{
			builder.AddOffset(4, actionDataOffset, 0);
		}

		// Token: 0x06014E8E RID: 85646 RVA: 0x003089A2 File Offset: 0x00306BA2
		public static void AddDisplayConfig(FlatBufferBuilder builder, Offset<IShowTimelineActionDisplayConfig> displayConfigOffset)
		{
			builder.AddOffset(5, displayConfigOffset.Value, 0);
		}

		// Token: 0x06014E8F RID: 85647 RVA: 0x003089B2 File Offset: 0x00306BB2
		public static Offset<IShowTimelineAction> EndIShowTimelineAction(FlatBufferBuilder builder)
		{
			return new Offset<IShowTimelineAction>(builder.EndTable());
		}

		// Token: 0x06014E90 RID: 85648 RVA: 0x003089C0 File Offset: 0x00306BC0
		public IShowTimelineActionT UnPack()
		{
			IShowTimelineActionT showTimelineActionT = new IShowTimelineActionT();
			this.UnPackTo(showTimelineActionT);
			return showTimelineActionT;
		}

		// Token: 0x06014E91 RID: 85649 RVA: 0x003089DC File Offset: 0x00306BDC
		public void UnPackTo(IShowTimelineActionT _o)
		{
			_o.Type = this.Type;
			_o.ActionType = this.ActionType;
			_o.ActionParam = this.ActionParam;
			_o.ActionData = new TShowTimelineActionOptionUnion();
			_o.ActionData.Type = this.ActionDataType;
			switch (this.ActionDataType)
			{
			case TShowTimelineActionOption.IShowTimelineCastSkill:
				_o.ActionData.Value = ((this.ActionData<IShowTimelineCastSkill>() != null) ? this.ActionData<IShowTimelineCastSkill>().Value.UnPack() : null);
				break;
			case TShowTimelineActionOption.IShowTimelineJump:
				_o.ActionData.Value = ((this.ActionData<IShowTimelineJump>() != null) ? this.ActionData<IShowTimelineJump>().Value.UnPack() : null);
				break;
			case TShowTimelineActionOption.IShowTimelineSwitchRole:
				_o.ActionData.Value = ((this.ActionData<IShowTimelineSwitchRole>() != null) ? this.ActionData<IShowTimelineSwitchRole>().Value.UnPack() : null);
				break;
			}
			_o.DisplayConfig = ((this.DisplayConfig != null) ? this.DisplayConfig.Value.UnPack() : null);
		}

		// Token: 0x06014E92 RID: 85650 RVA: 0x00308B20 File Offset: 0x00306D20
		public static Offset<IShowTimelineAction> Pack(FlatBufferBuilder builder, IShowTimelineActionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowTimelineAction>);
			}
			TShowTimelineActionOption actionData_type = (_o.ActionData == null) ? TShowTimelineActionOption.NONE : _o.ActionData.Type;
			int actionDataOffset = (_o.ActionData == null) ? 0 : TShowTimelineActionOptionUnion.Pack(builder, _o.ActionData);
			Offset<IShowTimelineActionDisplayConfig> displayConfigOffset = (_o.DisplayConfig == null) ? default(Offset<IShowTimelineActionDisplayConfig>) : IShowTimelineActionDisplayConfig.Pack(builder, _o.DisplayConfig);
			return IShowTimelineAction.CreateIShowTimelineAction(builder, _o.Type, _o.ActionType, _o.ActionParam, actionData_type, actionDataOffset, displayConfigOffset);
		}

		// Token: 0x0400B108 RID: 45320
		private Table __p;
	}
}
