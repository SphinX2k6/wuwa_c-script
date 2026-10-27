using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AC9 RID: 23241
	public struct ITrampleComponent : IFlatbufferObject
	{
		// Token: 0x1700AF14 RID: 44820
		// (get) Token: 0x060279DB RID: 162267 RVA: 0x00572D79 File Offset: 0x00570F79
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060279DC RID: 162268 RVA: 0x00572D86 File Offset: 0x00570F86
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060279DD RID: 162269 RVA: 0x00572D90 File Offset: 0x00570F90
		public static ITrampleComponent GetRootAsITrampleComponent(ByteBuffer _bb)
		{
			return ITrampleComponent.GetRootAsITrampleComponent(_bb, default(ITrampleComponent));
		}

		// Token: 0x060279DE RID: 162270 RVA: 0x00572DAC File Offset: 0x00570FAC
		public static ITrampleComponent GetRootAsITrampleComponent(ByteBuffer _bb, ITrampleComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060279DF RID: 162271 RVA: 0x00572DC9 File Offset: 0x00570FC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060279E0 RID: 162272 RVA: 0x00572DD8 File Offset: 0x00570FD8
		public ITrampleComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AF15 RID: 44821
		// (get) Token: 0x060279E1 RID: 162273 RVA: 0x00572DE8 File Offset: 0x00570FE8
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AF16 RID: 44822
		// (get) Token: 0x060279E2 RID: 162274 RVA: 0x00572E28 File Offset: 0x00571028
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

		// Token: 0x1700AF17 RID: 44823
		// (get) Token: 0x060279E3 RID: 162275 RVA: 0x00572E88 File Offset: 0x00571088
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

		// Token: 0x1700AF18 RID: 44824
		// (get) Token: 0x060279E4 RID: 162276 RVA: 0x00572EE8 File Offset: 0x005710E8
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

		// Token: 0x060279E5 RID: 162277 RVA: 0x00572F48 File Offset: 0x00571148
		public TMatchRoleOption MatchRoleOptionType(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return TMatchRoleOption.NONE;
			}
			return (TMatchRoleOption)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700AF19 RID: 44825
		// (get) Token: 0x060279E6 RID: 162278 RVA: 0x00572F88 File Offset: 0x00571188
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

		// Token: 0x060279E7 RID: 162279 RVA: 0x00572FB4 File Offset: 0x005711B4
		public Span<TMatchRoleOption> GetMatchRoleOptionTypeBytes()
		{
			return this.__p.__vector_as_span<TMatchRoleOption>(12, 1);
		}

		// Token: 0x060279E8 RID: 162280 RVA: 0x00572FC4 File Offset: 0x005711C4
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

		// Token: 0x060279E9 RID: 162281 RVA: 0x00573030 File Offset: 0x00571230
		public TTable? MatchRoleOption<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700AF1A RID: 44826
		// (get) Token: 0x060279EA RID: 162282 RVA: 0x00573078 File Offset: 0x00571278
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

		// Token: 0x1700AF1B RID: 44827
		// (get) Token: 0x060279EB RID: 162283 RVA: 0x005730A4 File Offset: 0x005712A4
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

		// Token: 0x1700AF1C RID: 44828
		// (get) Token: 0x060279EC RID: 162284 RVA: 0x005730E8 File Offset: 0x005712E8
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

		// Token: 0x1700AF1D RID: 44829
		// (get) Token: 0x060279ED RID: 162285 RVA: 0x0057312C File Offset: 0x0057132C
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

		// Token: 0x1700AF1E RID: 44830
		// (get) Token: 0x060279EE RID: 162286 RVA: 0x00573170 File Offset: 0x00571370
		public bool IsResetGear
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AF1F RID: 44831
		// (get) Token: 0x060279EF RID: 162287 RVA: 0x005731B0 File Offset: 0x005713B0
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

		// Token: 0x1700AF20 RID: 44832
		// (get) Token: 0x060279F0 RID: 162288 RVA: 0x00573210 File Offset: 0x00571410
		public bool StopTeleControlMove
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AF21 RID: 44833
		// (get) Token: 0x060279F1 RID: 162289 RVA: 0x00573250 File Offset: 0x00571450
		public ICountDownTextTip? TrampleTipOption
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return new ICountDownTextTip?(default(ICountDownTextTip).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060279F2 RID: 162290 RVA: 0x005732B0 File Offset: 0x005714B0
		public IActionInfo? EnterActions(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AF22 RID: 44834
		// (get) Token: 0x060279F3 RID: 162291 RVA: 0x00573314 File Offset: 0x00571514
		public int EnterActionsLength
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060279F4 RID: 162292 RVA: 0x00573340 File Offset: 0x00571540
		public IActionInfo? ExitActions(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AF23 RID: 44835
		// (get) Token: 0x060279F5 RID: 162293 RVA: 0x005733A4 File Offset: 0x005715A4
		public int ExitActionsLength
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

		// Token: 0x1700AF24 RID: 44836
		// (get) Token: 0x060279F6 RID: 162294 RVA: 0x005733D0 File Offset: 0x005715D0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060279F7 RID: 162295 RVA: 0x00573410 File Offset: 0x00571610
		public static Offset<ITrampleComponent> CreateITrampleComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), Offset<ITrampleRayDetection> RayDetectionConditionOffset = default(Offset<ITrampleRayDetection>), Offset<IEntityMatch> MatchOffset = default(Offset<IEntityMatch>), VectorOffset MatchRoleOption_typeOffset = default(VectorOffset), VectorOffset MatchRoleOptionOffset = default(VectorOffset), float DownTime = 0f, float StayTime = 0f, float UpTime = 0f, bool IsResetGear = false, Offset<IEnterLeaveRadius> ShowLandTipRadiusOffset = default(Offset<IEnterLeaveRadius>), bool StopTeleControlMove = false, Offset<ICountDownTextTip> TrampleTipOptionOffset = default(Offset<ICountDownTextTip>), VectorOffset EnterActionsOffset = default(VectorOffset), VectorOffset ExitActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(16);
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
			ITrampleComponent.AddStopTeleControlMove(builder, StopTeleControlMove);
			ITrampleComponent.AddIsResetGear(builder, IsResetGear);
			ITrampleComponent.AddDisabled(builder, Disabled);
			return ITrampleComponent.EndITrampleComponent(builder);
		}

		// Token: 0x060279F8 RID: 162296 RVA: 0x005734A8 File Offset: 0x005716A8
		public static void StartITrampleComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(16);
		}

		// Token: 0x060279F9 RID: 162297 RVA: 0x005734B2 File Offset: 0x005716B2
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060279FA RID: 162298 RVA: 0x005734BD File Offset: 0x005716BD
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(1, conditionOffset.Value, 0);
		}

		// Token: 0x060279FB RID: 162299 RVA: 0x005734CD File Offset: 0x005716CD
		public static void AddRayDetectionCondition(FlatBufferBuilder builder, Offset<ITrampleRayDetection> rayDetectionConditionOffset)
		{
			builder.AddOffset(2, rayDetectionConditionOffset.Value, 0);
		}

		// Token: 0x060279FC RID: 162300 RVA: 0x005734DD File Offset: 0x005716DD
		public static void AddMatch(FlatBufferBuilder builder, Offset<IEntityMatch> matchOffset)
		{
			builder.AddOffset(3, matchOffset.Value, 0);
		}

		// Token: 0x060279FD RID: 162301 RVA: 0x005734ED File Offset: 0x005716ED
		public static void AddMatchRoleOptionType(FlatBufferBuilder builder, VectorOffset matchRoleOptionTypeOffset)
		{
			builder.AddOffset(4, matchRoleOptionTypeOffset.Value, 0);
		}

		// Token: 0x060279FE RID: 162302 RVA: 0x00573500 File Offset: 0x00571700
		public static VectorOffset CreateMatchRoleOptionTypeVector(FlatBufferBuilder builder, TMatchRoleOption[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060279FF RID: 162303 RVA: 0x00573537 File Offset: 0x00571737
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, TMatchRoleOption[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TMatchRoleOption>(data);
			return builder.EndVector();
		}

		// Token: 0x06027A00 RID: 162304 RVA: 0x00573551 File Offset: 0x00571751
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TMatchRoleOption> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TMatchRoleOption>(data);
			return builder.EndVector();
		}

		// Token: 0x06027A01 RID: 162305 RVA: 0x0057356F File Offset: 0x0057176F
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TMatchRoleOption>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027A02 RID: 162306 RVA: 0x00573588 File Offset: 0x00571788
		public static void StartMatchRoleOptionTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06027A03 RID: 162307 RVA: 0x00573593 File Offset: 0x00571793
		public static void AddMatchRoleOption(FlatBufferBuilder builder, VectorOffset matchRoleOptionOffset)
		{
			builder.AddOffset(5, matchRoleOptionOffset.Value, 0);
		}

		// Token: 0x06027A04 RID: 162308 RVA: 0x005735A4 File Offset: 0x005717A4
		public static VectorOffset CreateMatchRoleOptionVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06027A05 RID: 162309 RVA: 0x005735DB File Offset: 0x005717DB
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06027A06 RID: 162310 RVA: 0x005735F5 File Offset: 0x005717F5
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06027A07 RID: 162311 RVA: 0x00573613 File Offset: 0x00571813
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027A08 RID: 162312 RVA: 0x0057362C File Offset: 0x0057182C
		public static void StartMatchRoleOptionVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027A09 RID: 162313 RVA: 0x00573637 File Offset: 0x00571837
		public static void AddDownTime(FlatBufferBuilder builder, float downTime)
		{
			builder.AddFloat(6, downTime, 0.0);
		}

		// Token: 0x06027A0A RID: 162314 RVA: 0x0057364A File Offset: 0x0057184A
		public static void AddStayTime(FlatBufferBuilder builder, float stayTime)
		{
			builder.AddFloat(7, stayTime, 0.0);
		}

		// Token: 0x06027A0B RID: 162315 RVA: 0x0057365D File Offset: 0x0057185D
		public static void AddUpTime(FlatBufferBuilder builder, float upTime)
		{
			builder.AddFloat(8, upTime, 0.0);
		}

		// Token: 0x06027A0C RID: 162316 RVA: 0x00573670 File Offset: 0x00571870
		public static void AddIsResetGear(FlatBufferBuilder builder, bool isResetGear)
		{
			builder.AddBool(9, isResetGear, false);
		}

		// Token: 0x06027A0D RID: 162317 RVA: 0x0057367C File Offset: 0x0057187C
		public static void AddShowLandTipRadius(FlatBufferBuilder builder, Offset<IEnterLeaveRadius> showLandTipRadiusOffset)
		{
			builder.AddOffset(10, showLandTipRadiusOffset.Value, 0);
		}

		// Token: 0x06027A0E RID: 162318 RVA: 0x0057368D File Offset: 0x0057188D
		public static void AddStopTeleControlMove(FlatBufferBuilder builder, bool stopTeleControlMove)
		{
			builder.AddBool(11, stopTeleControlMove, false);
		}

		// Token: 0x06027A0F RID: 162319 RVA: 0x00573699 File Offset: 0x00571899
		public static void AddTrampleTipOption(FlatBufferBuilder builder, Offset<ICountDownTextTip> trampleTipOptionOffset)
		{
			builder.AddOffset(12, trampleTipOptionOffset.Value, 0);
		}

		// Token: 0x06027A10 RID: 162320 RVA: 0x005736AA File Offset: 0x005718AA
		public static void AddEnterActions(FlatBufferBuilder builder, VectorOffset enterActionsOffset)
		{
			builder.AddOffset(13, enterActionsOffset.Value, 0);
		}

		// Token: 0x06027A11 RID: 162321 RVA: 0x005736BC File Offset: 0x005718BC
		public static VectorOffset CreateEnterActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027A12 RID: 162322 RVA: 0x005736FC File Offset: 0x005718FC
		public static VectorOffset CreateEnterActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027A13 RID: 162323 RVA: 0x00573716 File Offset: 0x00571916
		public static VectorOffset CreateEnterActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027A14 RID: 162324 RVA: 0x00573734 File Offset: 0x00571934
		public static VectorOffset CreateEnterActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027A15 RID: 162325 RVA: 0x0057374D File Offset: 0x0057194D
		public static void StartEnterActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027A16 RID: 162326 RVA: 0x00573758 File Offset: 0x00571958
		public static void AddExitActions(FlatBufferBuilder builder, VectorOffset exitActionsOffset)
		{
			builder.AddOffset(14, exitActionsOffset.Value, 0);
		}

		// Token: 0x06027A17 RID: 162327 RVA: 0x0057376C File Offset: 0x0057196C
		public static VectorOffset CreateExitActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027A18 RID: 162328 RVA: 0x005737AC File Offset: 0x005719AC
		public static VectorOffset CreateExitActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027A19 RID: 162329 RVA: 0x005737C6 File Offset: 0x005719C6
		public static VectorOffset CreateExitActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027A1A RID: 162330 RVA: 0x005737E4 File Offset: 0x005719E4
		public static VectorOffset CreateExitActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027A1B RID: 162331 RVA: 0x005737FD File Offset: 0x005719FD
		public static void StartExitActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027A1C RID: 162332 RVA: 0x00573808 File Offset: 0x00571A08
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(15, nullMask, 0);
		}

		// Token: 0x06027A1D RID: 162333 RVA: 0x00573814 File Offset: 0x00571A14
		public static Offset<ITrampleComponent> EndITrampleComponent(FlatBufferBuilder builder)
		{
			return new Offset<ITrampleComponent>(builder.EndTable());
		}

		// Token: 0x06027A1E RID: 162334 RVA: 0x00573824 File Offset: 0x00571A24
		public ITrampleComponentT UnPack()
		{
			ITrampleComponentT trampleComponentT = new ITrampleComponentT();
			this.UnPackTo(trampleComponentT);
			return trampleComponentT;
		}

		// Token: 0x06027A1F RID: 162335 RVA: 0x00573840 File Offset: 0x00571A40
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
				TMatchRoleOption tmatchRoleOption = this.MatchRoleOptionType(i);
				if (tmatchRoleOption != TMatchRoleOption.IMatchPhantomRole)
				{
					if (tmatchRoleOption == TMatchRoleOption.IMatchPlayerRole)
					{
						tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchPlayerRole>(i) != null) ? this.MatchRoleOption<IMatchPlayerRole>(i).Value.UnPack() : null);
					}
				}
				else
				{
					tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchPhantomRole>(i) != null) ? this.MatchRoleOption<IMatchPhantomRole>(i).Value.UnPack() : null);
				}
				_o.MatchRoleOption.Add(tmatchRoleOptionUnion);
			}
			_o.DownTime = this.DownTime;
			_o.StayTime = this.StayTime;
			_o.UpTime = this.UpTime;
			_o.IsResetGear = this.IsResetGear;
			_o.ShowLandTipRadius = ((this.ShowLandTipRadius != null) ? this.ShowLandTipRadius.Value.UnPack() : null);
			_o.StopTeleControlMove = this.StopTeleControlMove;
			_o.TrampleTipOption = ((this.TrampleTipOption != null) ? this.TrampleTipOption.Value.UnPack() : null);
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

		// Token: 0x06027A20 RID: 162336 RVA: 0x00573B1C File Offset: 0x00571D1C
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
			Offset<ICountDownTextTip> trampleTipOptionOffset = (_o.TrampleTipOption == null) ? default(Offset<ICountDownTextTip>) : ICountDownTextTip.Pack(builder, _o.TrampleTipOption);
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
			return ITrampleComponent.CreateITrampleComponent(builder, _o.Disabled, conditionOffset, rayDetectionConditionOffset, matchOffset, matchRoleOption_typeOffset, matchRoleOptionOffset, _o.DownTime, _o.StayTime, _o.UpTime, _o.IsResetGear, showLandTipRadiusOffset, _o.StopTeleControlMove, trampleTipOptionOffset, enterActionsOffset, exitActionsOffset, _o.NullMask);
		}

		// Token: 0x0400F19A RID: 61850
		private Table __p;
	}
}
