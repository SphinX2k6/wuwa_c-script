using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FA3 RID: 16291
	public struct IShowTimelineAction : IFlatbufferObject
	{
		// Token: 0x17006E33 RID: 28211
		// (get) Token: 0x06016342 RID: 90946 RVA: 0x0032EC64 File Offset: 0x0032CE64
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016343 RID: 90947 RVA: 0x0032EC71 File Offset: 0x0032CE71
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016344 RID: 90948 RVA: 0x0032EC78 File Offset: 0x0032CE78
		public static IShowTimelineAction GetRootAsIShowTimelineAction(ByteBuffer _bb)
		{
			return IShowTimelineAction.GetRootAsIShowTimelineAction(_bb, default(IShowTimelineAction));
		}

		// Token: 0x06016345 RID: 90949 RVA: 0x0032EC94 File Offset: 0x0032CE94
		public static IShowTimelineAction GetRootAsIShowTimelineAction(ByteBuffer _bb, IShowTimelineAction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016346 RID: 90950 RVA: 0x0032ECB1 File Offset: 0x0032CEB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016347 RID: 90951 RVA: 0x0032ECC0 File Offset: 0x0032CEC0
		public IShowTimelineAction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006E34 RID: 28212
		// (get) Token: 0x06016348 RID: 90952 RVA: 0x0032ECD0 File Offset: 0x0032CED0
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

		// Token: 0x17006E35 RID: 28213
		// (get) Token: 0x06016349 RID: 90953 RVA: 0x0032ED0C File Offset: 0x0032CF0C
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

		// Token: 0x17006E36 RID: 28214
		// (get) Token: 0x0601634A RID: 90954 RVA: 0x0032ED48 File Offset: 0x0032CF48
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

		// Token: 0x17006E37 RID: 28215
		// (get) Token: 0x0601634B RID: 90955 RVA: 0x0032ED84 File Offset: 0x0032CF84
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

		// Token: 0x0601634C RID: 90956 RVA: 0x0032EDC4 File Offset: 0x0032CFC4
		public TTable? ActionData<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601634D RID: 90957 RVA: 0x0032EE0C File Offset: 0x0032D00C
		public IShowTimelineCastSkill ActionDataAsIShowTimelineCastSkill()
		{
			return this.ActionData<IShowTimelineCastSkill>().Value;
		}

		// Token: 0x0601634E RID: 90958 RVA: 0x0032EE28 File Offset: 0x0032D028
		public IShowTimelineJump ActionDataAsIShowTimelineJump()
		{
			return this.ActionData<IShowTimelineJump>().Value;
		}

		// Token: 0x0601634F RID: 90959 RVA: 0x0032EE44 File Offset: 0x0032D044
		public IShowTimelineSwitchRole ActionDataAsIShowTimelineSwitchRole()
		{
			return this.ActionData<IShowTimelineSwitchRole>().Value;
		}

		// Token: 0x17006E38 RID: 28216
		// (get) Token: 0x06016350 RID: 90960 RVA: 0x0032EE60 File Offset: 0x0032D060
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

		// Token: 0x06016351 RID: 90961 RVA: 0x0032EEBE File Offset: 0x0032D0BE
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

		// Token: 0x06016352 RID: 90962 RVA: 0x0032EEFA File Offset: 0x0032D0FA
		public static void StartIShowTimelineAction(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06016353 RID: 90963 RVA: 0x0032EF03 File Offset: 0x0032D103
		public static void AddType(FlatBufferBuilder builder, EShowTimelineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016354 RID: 90964 RVA: 0x0032EF0E File Offset: 0x0032D10E
		public static void AddActionType(FlatBufferBuilder builder, EShowTimelineActionType actionType)
		{
			builder.AddByte(1, (byte)actionType, 0);
		}

		// Token: 0x06016355 RID: 90965 RVA: 0x0032EF19 File Offset: 0x0032D119
		public static void AddActionParam(FlatBufferBuilder builder, int actionParam)
		{
			builder.AddInt(2, actionParam, 0);
		}

		// Token: 0x06016356 RID: 90966 RVA: 0x0032EF24 File Offset: 0x0032D124
		public static void AddActionDataType(FlatBufferBuilder builder, TShowTimelineActionOption actionDataType)
		{
			builder.AddByte(3, (byte)actionDataType, 0);
		}

		// Token: 0x06016357 RID: 90967 RVA: 0x0032EF2F File Offset: 0x0032D12F
		public static void AddActionData(FlatBufferBuilder builder, int actionDataOffset)
		{
			builder.AddOffset(4, actionDataOffset, 0);
		}

		// Token: 0x06016358 RID: 90968 RVA: 0x0032EF3A File Offset: 0x0032D13A
		public static void AddDisplayConfig(FlatBufferBuilder builder, Offset<IShowTimelineActionDisplayConfig> displayConfigOffset)
		{
			builder.AddOffset(5, displayConfigOffset.Value, 0);
		}

		// Token: 0x06016359 RID: 90969 RVA: 0x0032EF4A File Offset: 0x0032D14A
		public static Offset<IShowTimelineAction> EndIShowTimelineAction(FlatBufferBuilder builder)
		{
			return new Offset<IShowTimelineAction>(builder.EndTable());
		}

		// Token: 0x0601635A RID: 90970 RVA: 0x0032EF58 File Offset: 0x0032D158
		public IShowTimelineActionT UnPack()
		{
			IShowTimelineActionT showTimelineActionT = new IShowTimelineActionT();
			this.UnPackTo(showTimelineActionT);
			return showTimelineActionT;
		}

		// Token: 0x0601635B RID: 90971 RVA: 0x0032EF74 File Offset: 0x0032D174
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

		// Token: 0x0601635C RID: 90972 RVA: 0x0032F0B8 File Offset: 0x0032D2B8
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

		// Token: 0x0400BA85 RID: 47749
		private Table __p;
	}
}
