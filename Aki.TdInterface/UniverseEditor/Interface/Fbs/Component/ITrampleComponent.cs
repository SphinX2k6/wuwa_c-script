using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060D6 RID: 24790
	public struct ITrampleComponent : IFlatbufferObject
	{
		// Token: 0x1700B850 RID: 47184
		// (get) Token: 0x06029F61 RID: 171873 RVA: 0x005BA061 File Offset: 0x005B8261
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029F62 RID: 171874 RVA: 0x005BA06E File Offset: 0x005B826E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029F63 RID: 171875 RVA: 0x005BA078 File Offset: 0x005B8278
		public static ITrampleComponent GetRootAsITrampleComponent(ByteBuffer _bb)
		{
			return ITrampleComponent.GetRootAsITrampleComponent(_bb, default(ITrampleComponent));
		}

		// Token: 0x06029F64 RID: 171876 RVA: 0x005BA094 File Offset: 0x005B8294
		public static ITrampleComponent GetRootAsITrampleComponent(ByteBuffer _bb, ITrampleComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029F65 RID: 171877 RVA: 0x005BA0B1 File Offset: 0x005B82B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029F66 RID: 171878 RVA: 0x005BA0C0 File Offset: 0x005B82C0
		public ITrampleComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B851 RID: 47185
		// (get) Token: 0x06029F67 RID: 171879 RVA: 0x005BA0D0 File Offset: 0x005B82D0
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B852 RID: 47186
		// (get) Token: 0x06029F68 RID: 171880 RVA: 0x005BA110 File Offset: 0x005B8310
		public IConditionGroup? Condition
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

		// Token: 0x1700B853 RID: 47187
		// (get) Token: 0x06029F69 RID: 171881 RVA: 0x005BA170 File Offset: 0x005B8370
		public ITrampleRayDetection? RayDetectionCondition
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new ITrampleRayDetection?(default(ITrampleRayDetection).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B854 RID: 47188
		// (get) Token: 0x06029F6A RID: 171882 RVA: 0x005BA1D0 File Offset: 0x005B83D0
		public IEntityMatch? Match
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IEntityMatch?(default(IEntityMatch).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06029F6B RID: 171883 RVA: 0x005BA230 File Offset: 0x005B8430
		public TMatchRoleOption MatchRoleOptionType(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return TMatchRoleOption.NONE;
			}
			return (TMatchRoleOption)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700B855 RID: 47189
		// (get) Token: 0x06029F6C RID: 171884 RVA: 0x005BA270 File Offset: 0x005B8470
		public int MatchRoleOptionTypeLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06029F6D RID: 171885 RVA: 0x005BA29C File Offset: 0x005B849C
		public Span<TMatchRoleOption> GetMatchRoleOptionTypeBytes()
		{
			return this.__p.__vector_as_span<TMatchRoleOption>(12, 1);
		}

		// Token: 0x06029F6E RID: 171886 RVA: 0x005BA2AC File Offset: 0x005B84AC
		public TMatchRoleOption[] GetMatchRoleOptionTypeArray()
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TMatchRoleOption[] array = new TMatchRoleOption[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TMatchRoleOption)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06029F6F RID: 171887 RVA: 0x005BA318 File Offset: 0x005B8518
		public TTable? MatchRoleOption<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700B856 RID: 47190
		// (get) Token: 0x06029F70 RID: 171888 RVA: 0x005BA360 File Offset: 0x005B8560
		public int MatchRoleOptionLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700B857 RID: 47191
		// (get) Token: 0x06029F71 RID: 171889 RVA: 0x005BA38C File Offset: 0x005B858C
		public float DownTime
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B858 RID: 47192
		// (get) Token: 0x06029F72 RID: 171890 RVA: 0x005BA3D0 File Offset: 0x005B85D0
		public float StayTime
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B859 RID: 47193
		// (get) Token: 0x06029F73 RID: 171891 RVA: 0x005BA414 File Offset: 0x005B8614
		public float UpTime
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B85A RID: 47194
		// (get) Token: 0x06029F74 RID: 171892 RVA: 0x005BA458 File Offset: 0x005B8658
		public bool IsResetGear
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B85B RID: 47195
		// (get) Token: 0x06029F75 RID: 171893 RVA: 0x005BA498 File Offset: 0x005B8698
		public IEnterLeaveRadius? ShowLandTipRadius
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return new IEnterLeaveRadius?(default(IEnterLeaveRadius).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B85C RID: 47196
		// (get) Token: 0x06029F76 RID: 171894 RVA: 0x005BA4F8 File Offset: 0x005B86F8
		public bool StopTeleControlMove
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B85D RID: 47197
		// (get) Token: 0x06029F77 RID: 171895 RVA: 0x005BA538 File Offset: 0x005B8738
		public TTrampleTipOption TrampleTipOptionType
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return TTrampleTipOption.NONE;
				}
				return (TTrampleTipOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029F78 RID: 171896 RVA: 0x005BA578 File Offset: 0x005B8778
		public TTable? TrampleTipOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06029F79 RID: 171897 RVA: 0x005BA5C0 File Offset: 0x005B87C0
		public ICountDownTextTip TrampleTipOptionAsICountDownTextTip()
		{
			return this.TrampleTipOption<ICountDownTextTip>().Value;
		}

		// Token: 0x06029F7A RID: 171898 RVA: 0x005BA5DC File Offset: 0x005B87DC
		public IMechaTrackCountDownTip TrampleTipOptionAsIMechaTrackCountDownTip()
		{
			return this.TrampleTipOption<IMechaTrackCountDownTip>().Value;
		}

		// Token: 0x06029F7B RID: 171899 RVA: 0x005BA5F8 File Offset: 0x005B87F8
		public IActionInfo? EnterActions(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B85E RID: 47198
		// (get) Token: 0x06029F7C RID: 171900 RVA: 0x005BA65C File Offset: 0x005B885C
		public int EnterActionsLength
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06029F7D RID: 171901 RVA: 0x005BA688 File Offset: 0x005B8888
		public IActionInfo? ExitActions(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B85F RID: 47199
		// (get) Token: 0x06029F7E RID: 171902 RVA: 0x005BA6EC File Offset: 0x005B88EC
		public int ExitActionsLength
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700B860 RID: 47200
		// (get) Token: 0x06029F7F RID: 171903 RVA: 0x005BA718 File Offset: 0x005B8918
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029F80 RID: 171904 RVA: 0x005BA758 File Offset: 0x005B8958
		public static Offset<ITrampleComponent> CreateITrampleComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), Offset<ITrampleRayDetection> RayDetectionConditionOffset = default(Offset<ITrampleRayDetection>), Offset<IEntityMatch> MatchOffset = default(Offset<IEntityMatch>), VectorOffset MatchRoleOption_typeOffset = default(VectorOffset), VectorOffset MatchRoleOptionOffset = default(VectorOffset), float DownTime = 0f, float StayTime = 0f, float UpTime = 0f, bool IsResetGear = false, Offset<IEnterLeaveRadius> ShowLandTipRadiusOffset = default(Offset<IEnterLeaveRadius>), bool StopTeleControlMove = false, TTrampleTipOption TrampleTipOption_type = TTrampleTipOption.NONE, int TrampleTipOptionOffset = 0, VectorOffset EnterActionsOffset = default(VectorOffset), VectorOffset ExitActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(17);
			ITrampleComponent.AddExitActions(builder, ExitActionsOffset);
			ITrampleComponent.AddEnterActions(builder, EnterActionsOffset);
			ITrampleComponent.AddTrampleTipOption(builder, TrampleTipOptionOffset);
			ITrampleComponent.AddShowLandTipRadius(builder, ShowLandTipRadiusOffset);
			ITrampleComponent.AddUpTime(builder, UpTime);
			ITrampleComponent.AddStayTime(builder, StayTime);
			ITrampleComponent.AddDownTime(builder, DownTime);
			ITrampleComponent.AddMatchRoleOption(builder, MatchRoleOptionOffset);
			ITrampleComponent.AddMatchRoleOptionType(builder, MatchRoleOption_typeOffset);
			ITrampleComponent.AddMatch(builder, MatchOffset);
			ITrampleComponent.AddRayDetectionCondition(builder, RayDetectionConditionOffset);
			ITrampleComponent.AddCondition(builder, ConditionOffset);
			ITrampleComponent.AddNullMask(builder, NullMask);
			ITrampleComponent.AddTrampleTipOptionType(builder, TrampleTipOption_type);
			ITrampleComponent.AddStopTeleControlMove(builder, StopTeleControlMove);
			ITrampleComponent.AddIsResetGear(builder, IsResetGear);
			ITrampleComponent.AddDisabled(builder, Disabled);
			return ITrampleComponent.EndITrampleComponent(builder);
		}

		// Token: 0x06029F81 RID: 171905 RVA: 0x005BA7F8 File Offset: 0x005B89F8
		public static void StartITrampleComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(17);
		}

		// Token: 0x06029F82 RID: 171906 RVA: 0x005BA802 File Offset: 0x005B8A02
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06029F83 RID: 171907 RVA: 0x005BA80D File Offset: 0x005B8A0D
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(1, conditionOffset.Value, 0);
		}

		// Token: 0x06029F84 RID: 171908 RVA: 0x005BA81D File Offset: 0x005B8A1D
		public static void AddRayDetectionCondition(FlatBufferBuilder builder, Offset<ITrampleRayDetection> rayDetectionConditionOffset)
		{
			builder.AddOffset(2, rayDetectionConditionOffset.Value, 0);
		}

		// Token: 0x06029F85 RID: 171909 RVA: 0x005BA82D File Offset: 0x005B8A2D
		public static void AddMatch(FlatBufferBuilder builder, Offset<IEntityMatch> matchOffset)
		{
			builder.AddOffset(3, matchOffset.Value, 0);
		}

		// Token: 0x06029F86 RID: 171910 RVA: 0x005BA83D File Offset: 0x005B8A3D
		public static void AddMatchRoleOptionType(FlatBufferBuilder builder, VectorOffset matchRoleOptionTypeOffset)
		{
			builder.AddOffset(4, matchRoleOptionTypeOffset.Value, 0);
		}

		// Token: 0x06029F87 RID: 171911 RVA: 0x005BA850 File Offset: 0x005B8A50
		public static VectorOffset CreateMatchRoleOptionTypeVector(FlatBufferBuilder builder, TMatchRoleOption[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06029F88 RID: 171912 RVA: 0x005BA887 File Offset: 0x005B8A87
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, TMatchRoleOption[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TMatchRoleOption>(data);
			return builder.EndVector();
		}

		// Token: 0x06029F89 RID: 171913 RVA: 0x005BA8A1 File Offset: 0x005B8AA1
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TMatchRoleOption> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TMatchRoleOption>(data);
			return builder.EndVector();
		}

		// Token: 0x06029F8A RID: 171914 RVA: 0x005BA8BF File Offset: 0x005B8ABF
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TMatchRoleOption>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029F8B RID: 171915 RVA: 0x005BA8D8 File Offset: 0x005B8AD8
		public static void StartMatchRoleOptionTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06029F8C RID: 171916 RVA: 0x005BA8E3 File Offset: 0x005B8AE3
		public static void AddMatchRoleOption(FlatBufferBuilder builder, VectorOffset matchRoleOptionOffset)
		{
			builder.AddOffset(5, matchRoleOptionOffset.Value, 0);
		}

		// Token: 0x06029F8D RID: 171917 RVA: 0x005BA8F4 File Offset: 0x005B8AF4
		public static VectorOffset CreateMatchRoleOptionVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06029F8E RID: 171918 RVA: 0x005BA92B File Offset: 0x005B8B2B
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06029F8F RID: 171919 RVA: 0x005BA945 File Offset: 0x005B8B45
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06029F90 RID: 171920 RVA: 0x005BA963 File Offset: 0x005B8B63
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029F91 RID: 171921 RVA: 0x005BA97C File Offset: 0x005B8B7C
		public static void StartMatchRoleOptionVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029F92 RID: 171922 RVA: 0x005BA987 File Offset: 0x005B8B87
		public static void AddDownTime(FlatBufferBuilder builder, float downTime)
		{
			builder.AddFloat(6, downTime, 0.0);
		}

		// Token: 0x06029F93 RID: 171923 RVA: 0x005BA99A File Offset: 0x005B8B9A
		public static void AddStayTime(FlatBufferBuilder builder, float stayTime)
		{
			builder.AddFloat(7, stayTime, 0.0);
		}

		// Token: 0x06029F94 RID: 171924 RVA: 0x005BA9AD File Offset: 0x005B8BAD
		public static void AddUpTime(FlatBufferBuilder builder, float upTime)
		{
			builder.AddFloat(8, upTime, 0.0);
		}

		// Token: 0x06029F95 RID: 171925 RVA: 0x005BA9C0 File Offset: 0x005B8BC0
		public static void AddIsResetGear(FlatBufferBuilder builder, bool isResetGear)
		{
			builder.AddBool(9, isResetGear, false);
		}

		// Token: 0x06029F96 RID: 171926 RVA: 0x005BA9CC File Offset: 0x005B8BCC
		public static void AddShowLandTipRadius(FlatBufferBuilder builder, Offset<IEnterLeaveRadius> showLandTipRadiusOffset)
		{
			builder.AddOffset(10, showLandTipRadiusOffset.Value, 0);
		}

		// Token: 0x06029F97 RID: 171927 RVA: 0x005BA9DD File Offset: 0x005B8BDD
		public static void AddStopTeleControlMove(FlatBufferBuilder builder, bool stopTeleControlMove)
		{
			builder.AddBool(11, stopTeleControlMove, false);
		}

		// Token: 0x06029F98 RID: 171928 RVA: 0x005BA9E9 File Offset: 0x005B8BE9
		public static void AddTrampleTipOptionType(FlatBufferBuilder builder, TTrampleTipOption trampleTipOptionType)
		{
			builder.AddByte(12, (byte)trampleTipOptionType, 0);
		}

		// Token: 0x06029F99 RID: 171929 RVA: 0x005BA9F5 File Offset: 0x005B8BF5
		public static void AddTrampleTipOption(FlatBufferBuilder builder, int trampleTipOptionOffset)
		{
			builder.AddOffset(13, trampleTipOptionOffset, 0);
		}

		// Token: 0x06029F9A RID: 171930 RVA: 0x005BAA01 File Offset: 0x005B8C01
		public static void AddEnterActions(FlatBufferBuilder builder, VectorOffset enterActionsOffset)
		{
			builder.AddOffset(14, enterActionsOffset.Value, 0);
		}

		// Token: 0x06029F9B RID: 171931 RVA: 0x005BAA14 File Offset: 0x005B8C14
		public static VectorOffset CreateEnterActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06029F9C RID: 171932 RVA: 0x005BAA54 File Offset: 0x005B8C54
		public static VectorOffset CreateEnterActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029F9D RID: 171933 RVA: 0x005BAA6E File Offset: 0x005B8C6E
		public static VectorOffset CreateEnterActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029F9E RID: 171934 RVA: 0x005BAA8C File Offset: 0x005B8C8C
		public static VectorOffset CreateEnterActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029F9F RID: 171935 RVA: 0x005BAAA5 File Offset: 0x005B8CA5
		public static void StartEnterActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029FA0 RID: 171936 RVA: 0x005BAAB0 File Offset: 0x005B8CB0
		public static void AddExitActions(FlatBufferBuilder builder, VectorOffset exitActionsOffset)
		{
			builder.AddOffset(15, exitActionsOffset.Value, 0);
		}

		// Token: 0x06029FA1 RID: 171937 RVA: 0x005BAAC4 File Offset: 0x005B8CC4
		public static VectorOffset CreateExitActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06029FA2 RID: 171938 RVA: 0x005BAB04 File Offset: 0x005B8D04
		public static VectorOffset CreateExitActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029FA3 RID: 171939 RVA: 0x005BAB1E File Offset: 0x005B8D1E
		public static VectorOffset CreateExitActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029FA4 RID: 171940 RVA: 0x005BAB3C File Offset: 0x005B8D3C
		public static VectorOffset CreateExitActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029FA5 RID: 171941 RVA: 0x005BAB55 File Offset: 0x005B8D55
		public static void StartExitActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029FA6 RID: 171942 RVA: 0x005BAB60 File Offset: 0x005B8D60
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(16, nullMask, 0);
		}

		// Token: 0x06029FA7 RID: 171943 RVA: 0x005BAB6C File Offset: 0x005B8D6C
		public static Offset<ITrampleComponent> EndITrampleComponent(FlatBufferBuilder builder)
		{
			return new Offset<ITrampleComponent>(builder.EndTable());
		}

		// Token: 0x06029FA8 RID: 171944 RVA: 0x005BAB7C File Offset: 0x005B8D7C
		public ITrampleComponentT UnPack()
		{
			ITrampleComponentT trampleComponentT = new ITrampleComponentT();
			this.UnPackTo(trampleComponentT);
			return trampleComponentT;
		}

		// Token: 0x06029FA9 RID: 171945 RVA: 0x005BAB98 File Offset: 0x005B8D98
		public void UnPackTo(ITrampleComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.RayDetectionCondition = ((this.RayDetectionCondition != null) ? this.RayDetectionCondition.Value.UnPack() : null);
			_o.Match = ((this.Match != null) ? this.Match.Value.UnPack() : null);
			_o.MatchRoleOption = new List<TMatchRoleOptionUnion>();
			for (int i = 0; i < this.MatchRoleOptionLength; i++)
			{
				TMatchRoleOptionUnion tmatchRoleOptionUnion = new TMatchRoleOptionUnion();
				tmatchRoleOptionUnion.Type = this.MatchRoleOptionType(i);
				switch (this.MatchRoleOptionType(i))
				{
				case TMatchRoleOption.IMatchAssistCharacterRole:
					tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchAssistCharacterRole>(i) != null) ? this.MatchRoleOption<IMatchAssistCharacterRole>(i).Value.UnPack() : null);
					break;
				case TMatchRoleOption.IMatchPhantomRole:
					tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchPhantomRole>(i) != null) ? this.MatchRoleOption<IMatchPhantomRole>(i).Value.UnPack() : null);
					break;
				case TMatchRoleOption.IMatchPlayerRole:
					tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchPlayerRole>(i) != null) ? this.MatchRoleOption<IMatchPlayerRole>(i).Value.UnPack() : null);
					break;
				}
				_o.MatchRoleOption.Add(tmatchRoleOptionUnion);
			}
			_o.DownTime = this.DownTime;
			_o.StayTime = this.StayTime;
			_o.UpTime = this.UpTime;
			_o.IsResetGear = this.IsResetGear;
			_o.ShowLandTipRadius = ((this.ShowLandTipRadius != null) ? this.ShowLandTipRadius.Value.UnPack() : null);
			_o.StopTeleControlMove = this.StopTeleControlMove;
			_o.TrampleTipOption = new TTrampleTipOptionUnion();
			_o.TrampleTipOption.Type = this.TrampleTipOptionType;
			TTrampleTipOption trampleTipOptionType = this.TrampleTipOptionType;
			if (trampleTipOptionType != TTrampleTipOption.ICountDownTextTip)
			{
				if (trampleTipOptionType == TTrampleTipOption.IMechaTrackCountDownTip)
				{
					_o.TrampleTipOption.Value = ((this.TrampleTipOption<IMechaTrackCountDownTip>() != null) ? this.TrampleTipOption<IMechaTrackCountDownTip>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.TrampleTipOption.Value = ((this.TrampleTipOption<ICountDownTextTip>() != null) ? this.TrampleTipOption<ICountDownTextTip>().Value.UnPack() : null);
			}
			_o.EnterActions = new List<IActionInfoT>();
			for (int j = 0; j < this.EnterActionsLength; j++)
			{
				_o.EnterActions.Add((this.EnterActions(j) != null) ? this.EnterActions(j).Value.UnPack() : null);
			}
			_o.ExitActions = new List<IActionInfoT>();
			for (int k = 0; k < this.ExitActionsLength; k++)
			{
				_o.ExitActions.Add((this.ExitActions(k) != null) ? this.ExitActions(k).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06029FAA RID: 171946 RVA: 0x005BAF28 File Offset: 0x005B9128
		public static Offset<ITrampleComponent> Pack(FlatBufferBuilder builder, ITrampleComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrampleComponent>);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			Offset<ITrampleRayDetection> rayDetectionConditionOffset = (_o.RayDetectionCondition == null) ? default(Offset<ITrampleRayDetection>) : ITrampleRayDetection.Pack(builder, _o.RayDetectionCondition);
			Offset<IEntityMatch> matchOffset = (_o.Match == null) ? default(Offset<IEntityMatch>) : IEntityMatch.Pack(builder, _o.Match);
			VectorOffset matchRoleOption_typeOffset = default(VectorOffset);
			if (_o.MatchRoleOption != null)
			{
				TMatchRoleOption[] array = new TMatchRoleOption[_o.MatchRoleOption.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.MatchRoleOption[i].Type;
				}
				matchRoleOption_typeOffset = ITrampleComponent.CreateMatchRoleOptionTypeVector(builder, array);
			}
			VectorOffset matchRoleOptionOffset = default(VectorOffset);
			if (_o.MatchRoleOption != null)
			{
				int[] array2 = new int[_o.MatchRoleOption.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TMatchRoleOptionUnion.Pack(builder, _o.MatchRoleOption[j]);
				}
				matchRoleOptionOffset = ITrampleComponent.CreateMatchRoleOptionVector(builder, array2);
			}
			Offset<IEnterLeaveRadius> showLandTipRadiusOffset = (_o.ShowLandTipRadius == null) ? default(Offset<IEnterLeaveRadius>) : IEnterLeaveRadius.Pack(builder, _o.ShowLandTipRadius);
			TTrampleTipOption trampleTipOption_type = (_o.TrampleTipOption == null) ? TTrampleTipOption.NONE : _o.TrampleTipOption.Type;
			int trampleTipOptionOffset = (_o.TrampleTipOption == null) ? 0 : TTrampleTipOptionUnion.Pack(builder, _o.TrampleTipOption);
			VectorOffset enterActionsOffset = default(VectorOffset);
			if (_o.EnterActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.EnterActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.EnterActions[k]);
				}
				enterActionsOffset = ITrampleComponent.CreateEnterActionsVector(builder, array3);
			}
			VectorOffset exitActionsOffset = default(VectorOffset);
			if (_o.ExitActions != null)
			{
				Offset<IActionInfo>[] array4 = new Offset<IActionInfo>[_o.ExitActions.Count];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = IActionInfo.Pack(builder, _o.ExitActions[l]);
				}
				exitActionsOffset = ITrampleComponent.CreateExitActionsVector(builder, array4);
			}
			return ITrampleComponent.CreateITrampleComponent(builder, _o.Disabled, conditionOffset, rayDetectionConditionOffset, matchOffset, matchRoleOption_typeOffset, matchRoleOptionOffset, _o.DownTime, _o.StayTime, _o.UpTime, _o.IsResetGear, showLandTipRadiusOffset, _o.StopTeleControlMove, trampleTipOption_type, trampleTipOptionOffset, enterActionsOffset, exitActionsOffset, _o.NullMask);
		}

		// Token: 0x0400FE93 RID: 65171
		private Table __p;
	}
}
