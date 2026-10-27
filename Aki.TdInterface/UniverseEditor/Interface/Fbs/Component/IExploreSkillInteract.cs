using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051E3 RID: 20963
	public struct IExploreSkillInteract : IFlatbufferObject
	{
		// Token: 0x17009970 RID: 39280
		// (get) Token: 0x06022006 RID: 139270 RVA: 0x004B7686 File Offset: 0x004B5886
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022007 RID: 139271 RVA: 0x004B7693 File Offset: 0x004B5893
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022008 RID: 139272 RVA: 0x004B769C File Offset: 0x004B589C
		public static IExploreSkillInteract GetRootAsIExploreSkillInteract(ByteBuffer _bb)
		{
			return IExploreSkillInteract.GetRootAsIExploreSkillInteract(_bb, default(IExploreSkillInteract));
		}

		// Token: 0x06022009 RID: 139273 RVA: 0x004B76B8 File Offset: 0x004B58B8
		public static IExploreSkillInteract GetRootAsIExploreSkillInteract(ByteBuffer _bb, IExploreSkillInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602200A RID: 139274 RVA: 0x004B76D5 File Offset: 0x004B58D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602200B RID: 139275 RVA: 0x004B76E4 File Offset: 0x004B58E4
		public IExploreSkillInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009971 RID: 39281
		// (get) Token: 0x0602200C RID: 139276 RVA: 0x004B76F4 File Offset: 0x004B58F4
		public string ExploreSkillUiResource
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602200D RID: 139277 RVA: 0x004B772B File Offset: 0x004B592B
		public Span<byte> GetExploreSkillUiResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602200E RID: 139278 RVA: 0x004B773A File Offset: 0x004B593A
		public byte[] GetExploreSkillUiResourceArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17009972 RID: 39282
		// (get) Token: 0x0602200F RID: 139279 RVA: 0x004B7748 File Offset: 0x004B5948
		public TExploreSkillInteractOption OptionType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TExploreSkillInteractOption.NONE;
				}
				return (TExploreSkillInteractOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022010 RID: 139280 RVA: 0x004B7784 File Offset: 0x004B5984
		public TTable? Option<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06022011 RID: 139281 RVA: 0x004B77C8 File Offset: 0x004B59C8
		public IExploreSkillArrowInteractPoint OptionAsIExploreSkillArrowInteractPoint()
		{
			return this.Option<IExploreSkillArrowInteractPoint>().Value;
		}

		// Token: 0x06022012 RID: 139282 RVA: 0x004B77E4 File Offset: 0x004B59E4
		public IExploreSkillCustom OptionAsIExploreSkillCustom()
		{
			return this.Option<IExploreSkillCustom>().Value;
		}

		// Token: 0x06022013 RID: 139283 RVA: 0x004B7800 File Offset: 0x004B5A00
		public IExploreSkillEavesdrop OptionAsIExploreSkillEavesdrop()
		{
			return this.Option<IExploreSkillEavesdrop>().Value;
		}

		// Token: 0x06022014 RID: 139284 RVA: 0x004B781C File Offset: 0x004B5A1C
		public IExploreSkillLonelyDollPollutant OptionAsIExploreSkillLonelyDollPollutant()
		{
			return this.Option<IExploreSkillLonelyDollPollutant>().Value;
		}

		// Token: 0x06022015 RID: 139285 RVA: 0x004B7838 File Offset: 0x004B5A38
		public IExploreSkillMechascoutDrag OptionAsIExploreSkillMechascoutDrag()
		{
			return this.Option<IExploreSkillMechascoutDrag>().Value;
		}

		// Token: 0x06022016 RID: 139286 RVA: 0x004B7854 File Offset: 0x004B5A54
		public IExploreSkillPullGiant OptionAsIExploreSkillPullGiant()
		{
			return this.Option<IExploreSkillPullGiant>().Value;
		}

		// Token: 0x06022017 RID: 139287 RVA: 0x004B7870 File Offset: 0x004B5A70
		public IExploreSkillPullStatue OptionAsIExploreSkillPullStatue()
		{
			return this.Option<IExploreSkillPullStatue>().Value;
		}

		// Token: 0x06022018 RID: 139288 RVA: 0x004B788C File Offset: 0x004B5A8C
		public IExploreSkillQuantumDiffusion OptionAsIExploreSkillQuantumDiffusion()
		{
			return this.Option<IExploreSkillQuantumDiffusion>().Value;
		}

		// Token: 0x06022019 RID: 139289 RVA: 0x004B78A8 File Offset: 0x004B5AA8
		public IExploreSkillRagDollCrushingRock OptionAsIExploreSkillRagDollCrushingRock()
		{
			return this.Option<IExploreSkillRagDollCrushingRock>().Value;
		}

		// Token: 0x0602201A RID: 139290 RVA: 0x004B78C4 File Offset: 0x004B5AC4
		public IExploreSkillRagDollDestroySolidRock OptionAsIExploreSkillRagDollDestroySolidRock()
		{
			return this.Option<IExploreSkillRagDollDestroySolidRock>().Value;
		}

		// Token: 0x0602201B RID: 139291 RVA: 0x004B78E0 File Offset: 0x004B5AE0
		public IExploreSkillStatueInteractPoint OptionAsIExploreSkillStatueInteractPoint()
		{
			return this.Option<IExploreSkillStatueInteractPoint>().Value;
		}

		// Token: 0x0602201C RID: 139292 RVA: 0x004B78FC File Offset: 0x004B5AFC
		public IFollowShooterInteractPoint OptionAsIFollowShooterInteractPoint()
		{
			return this.Option<IFollowShooterInteractPoint>().Value;
		}

		// Token: 0x0602201D RID: 139293 RVA: 0x004B7918 File Offset: 0x004B5B18
		public IFoxJumpInteractPoint OptionAsIFoxJumpInteractPoint()
		{
			return this.Option<IFoxJumpInteractPoint>().Value;
		}

		// Token: 0x0602201E RID: 139294 RVA: 0x004B7934 File Offset: 0x004B5B34
		public IMonsterSummonInteractPoint OptionAsIMonsterSummonInteractPoint()
		{
			return this.Option<IMonsterSummonInteractPoint>().Value;
		}

		// Token: 0x17009973 RID: 39283
		// (get) Token: 0x0602201F RID: 139295 RVA: 0x004B7950 File Offset: 0x004B5B50
		public int PlayerStateRestritionId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022020 RID: 139296 RVA: 0x004B7990 File Offset: 0x004B5B90
		public TMatchRoleOption MatchRoleOptionType(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return TMatchRoleOption.NONE;
			}
			return (TMatchRoleOption)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17009974 RID: 39284
		// (get) Token: 0x06022021 RID: 139297 RVA: 0x004B79D0 File Offset: 0x004B5BD0
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

		// Token: 0x06022022 RID: 139298 RVA: 0x004B79FC File Offset: 0x004B5BFC
		public Span<TMatchRoleOption> GetMatchRoleOptionTypeBytes()
		{
			return this.__p.__vector_as_span<TMatchRoleOption>(12, 1);
		}

		// Token: 0x06022023 RID: 139299 RVA: 0x004B7A0C File Offset: 0x004B5C0C
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

		// Token: 0x06022024 RID: 139300 RVA: 0x004B7A78 File Offset: 0x004B5C78
		public TTable? MatchRoleOption<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17009975 RID: 39285
		// (get) Token: 0x06022025 RID: 139301 RVA: 0x004B7AC0 File Offset: 0x004B5CC0
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

		// Token: 0x17009976 RID: 39286
		// (get) Token: 0x06022026 RID: 139302 RVA: 0x004B7AEC File Offset: 0x004B5CEC
		public IConditionGroup? Condition
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009977 RID: 39287
		// (get) Token: 0x06022027 RID: 139303 RVA: 0x004B7B4C File Offset: 0x004B5D4C
		public TExploreSkillSearchTargetCfg SearchTargetCfgType
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return TExploreSkillSearchTargetCfg.NONE;
				}
				return (TExploreSkillSearchTargetCfg)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022028 RID: 139304 RVA: 0x004B7B8C File Offset: 0x004B5D8C
		public TTable? SearchTargetCfg<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06022029 RID: 139305 RVA: 0x004B7BD4 File Offset: 0x004B5DD4
		public IAngleWeight SearchTargetCfgAsIAngleWeight()
		{
			return this.SearchTargetCfg<IAngleWeight>().Value;
		}

		// Token: 0x0602202A RID: 139306 RVA: 0x004B7BF0 File Offset: 0x004B5DF0
		public IEnterScreenWeight SearchTargetCfgAsIEnterScreenWeight()
		{
			return this.SearchTargetCfg<IEnterScreenWeight>().Value;
		}

		// Token: 0x17009978 RID: 39288
		// (get) Token: 0x0602202B RID: 139307 RVA: 0x004B7C0C File Offset: 0x004B5E0C
		public IIgnoresCollisionCfg? IgnoresCollisionCfg
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return new IIgnoresCollisionCfg?(default(IIgnoresCollisionCfg).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602202C RID: 139308 RVA: 0x004B7C6C File Offset: 0x004B5E6C
		public string SelfInteractBlockDetectionKeys(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17009979 RID: 39289
		// (get) Token: 0x0602202D RID: 139309 RVA: 0x004B7CA8 File Offset: 0x004B5EA8
		public int SelfInteractBlockDetectionKeysLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700997A RID: 39290
		// (get) Token: 0x0602202E RID: 139310 RVA: 0x004B7CD4 File Offset: 0x004B5ED4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602202F RID: 139311 RVA: 0x004B7D14 File Offset: 0x004B5F14
		public static Offset<IExploreSkillInteract> CreateIExploreSkillInteract(FlatBufferBuilder builder, StringOffset ExploreSkillUiResourceOffset = default(StringOffset), TExploreSkillInteractOption Option_type = TExploreSkillInteractOption.NONE, int OptionOffset = 0, int PlayerStateRestritionId = 0, VectorOffset MatchRoleOption_typeOffset = default(VectorOffset), VectorOffset MatchRoleOptionOffset = default(VectorOffset), Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), TExploreSkillSearchTargetCfg SearchTargetCfg_type = TExploreSkillSearchTargetCfg.NONE, int SearchTargetCfgOffset = 0, Offset<IIgnoresCollisionCfg> IgnoresCollisionCfgOffset = default(Offset<IIgnoresCollisionCfg>), VectorOffset SelfInteractBlockDetectionKeysOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(12);
			IExploreSkillInteract.AddSelfInteractBlockDetectionKeys(builder, SelfInteractBlockDetectionKeysOffset);
			IExploreSkillInteract.AddIgnoresCollisionCfg(builder, IgnoresCollisionCfgOffset);
			IExploreSkillInteract.AddSearchTargetCfg(builder, SearchTargetCfgOffset);
			IExploreSkillInteract.AddCondition(builder, ConditionOffset);
			IExploreSkillInteract.AddMatchRoleOption(builder, MatchRoleOptionOffset);
			IExploreSkillInteract.AddMatchRoleOptionType(builder, MatchRoleOption_typeOffset);
			IExploreSkillInteract.AddPlayerStateRestritionId(builder, PlayerStateRestritionId);
			IExploreSkillInteract.AddOption(builder, OptionOffset);
			IExploreSkillInteract.AddExploreSkillUiResource(builder, ExploreSkillUiResourceOffset);
			IExploreSkillInteract.AddNullMask(builder, NullMask);
			IExploreSkillInteract.AddSearchTargetCfgType(builder, SearchTargetCfg_type);
			IExploreSkillInteract.AddOptionType(builder, Option_type);
			return IExploreSkillInteract.EndIExploreSkillInteract(builder);
		}

		// Token: 0x06022030 RID: 139312 RVA: 0x004B7D8C File Offset: 0x004B5F8C
		public static void StartIExploreSkillInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(12);
		}

		// Token: 0x06022031 RID: 139313 RVA: 0x004B7D96 File Offset: 0x004B5F96
		public static void AddExploreSkillUiResource(FlatBufferBuilder builder, StringOffset exploreSkillUiResourceOffset)
		{
			builder.AddOffset(0, exploreSkillUiResourceOffset.Value, 0);
		}

		// Token: 0x06022032 RID: 139314 RVA: 0x004B7DA6 File Offset: 0x004B5FA6
		public static void AddOptionType(FlatBufferBuilder builder, TExploreSkillInteractOption optionType)
		{
			builder.AddByte(1, (byte)optionType, 0);
		}

		// Token: 0x06022033 RID: 139315 RVA: 0x004B7DB1 File Offset: 0x004B5FB1
		public static void AddOption(FlatBufferBuilder builder, int optionOffset)
		{
			builder.AddOffset(2, optionOffset, 0);
		}

		// Token: 0x06022034 RID: 139316 RVA: 0x004B7DBC File Offset: 0x004B5FBC
		public static void AddPlayerStateRestritionId(FlatBufferBuilder builder, int playerStateRestritionId)
		{
			builder.AddInt(3, playerStateRestritionId, 0);
		}

		// Token: 0x06022035 RID: 139317 RVA: 0x004B7DC7 File Offset: 0x004B5FC7
		public static void AddMatchRoleOptionType(FlatBufferBuilder builder, VectorOffset matchRoleOptionTypeOffset)
		{
			builder.AddOffset(4, matchRoleOptionTypeOffset.Value, 0);
		}

		// Token: 0x06022036 RID: 139318 RVA: 0x004B7DD8 File Offset: 0x004B5FD8
		public static VectorOffset CreateMatchRoleOptionTypeVector(FlatBufferBuilder builder, TMatchRoleOption[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06022037 RID: 139319 RVA: 0x004B7E0F File Offset: 0x004B600F
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, TMatchRoleOption[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TMatchRoleOption>(data);
			return builder.EndVector();
		}

		// Token: 0x06022038 RID: 139320 RVA: 0x004B7E29 File Offset: 0x004B6029
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TMatchRoleOption> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TMatchRoleOption>(data);
			return builder.EndVector();
		}

		// Token: 0x06022039 RID: 139321 RVA: 0x004B7E47 File Offset: 0x004B6047
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TMatchRoleOption>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602203A RID: 139322 RVA: 0x004B7E60 File Offset: 0x004B6060
		public static void StartMatchRoleOptionTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0602203B RID: 139323 RVA: 0x004B7E6B File Offset: 0x004B606B
		public static void AddMatchRoleOption(FlatBufferBuilder builder, VectorOffset matchRoleOptionOffset)
		{
			builder.AddOffset(5, matchRoleOptionOffset.Value, 0);
		}

		// Token: 0x0602203C RID: 139324 RVA: 0x004B7E7C File Offset: 0x004B607C
		public static VectorOffset CreateMatchRoleOptionVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602203D RID: 139325 RVA: 0x004B7EB3 File Offset: 0x004B60B3
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602203E RID: 139326 RVA: 0x004B7ECD File Offset: 0x004B60CD
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602203F RID: 139327 RVA: 0x004B7EEB File Offset: 0x004B60EB
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022040 RID: 139328 RVA: 0x004B7F04 File Offset: 0x004B6104
		public static void StartMatchRoleOptionVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022041 RID: 139329 RVA: 0x004B7F0F File Offset: 0x004B610F
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(6, conditionOffset.Value, 0);
		}

		// Token: 0x06022042 RID: 139330 RVA: 0x004B7F1F File Offset: 0x004B611F
		public static void AddSearchTargetCfgType(FlatBufferBuilder builder, TExploreSkillSearchTargetCfg searchTargetCfgType)
		{
			builder.AddByte(7, (byte)searchTargetCfgType, 0);
		}

		// Token: 0x06022043 RID: 139331 RVA: 0x004B7F2A File Offset: 0x004B612A
		public static void AddSearchTargetCfg(FlatBufferBuilder builder, int searchTargetCfgOffset)
		{
			builder.AddOffset(8, searchTargetCfgOffset, 0);
		}

		// Token: 0x06022044 RID: 139332 RVA: 0x004B7F35 File Offset: 0x004B6135
		public static void AddIgnoresCollisionCfg(FlatBufferBuilder builder, Offset<IIgnoresCollisionCfg> ignoresCollisionCfgOffset)
		{
			builder.AddOffset(9, ignoresCollisionCfgOffset.Value, 0);
		}

		// Token: 0x06022045 RID: 139333 RVA: 0x004B7F46 File Offset: 0x004B6146
		public static void AddSelfInteractBlockDetectionKeys(FlatBufferBuilder builder, VectorOffset selfInteractBlockDetectionKeysOffset)
		{
			builder.AddOffset(10, selfInteractBlockDetectionKeysOffset.Value, 0);
		}

		// Token: 0x06022046 RID: 139334 RVA: 0x004B7F58 File Offset: 0x004B6158
		public static VectorOffset CreateSelfInteractBlockDetectionKeysVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022047 RID: 139335 RVA: 0x004B7F98 File Offset: 0x004B6198
		public static VectorOffset CreateSelfInteractBlockDetectionKeysVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06022048 RID: 139336 RVA: 0x004B7FB2 File Offset: 0x004B61B2
		public static VectorOffset CreateSelfInteractBlockDetectionKeysVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06022049 RID: 139337 RVA: 0x004B7FD0 File Offset: 0x004B61D0
		public static VectorOffset CreateSelfInteractBlockDetectionKeysVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602204A RID: 139338 RVA: 0x004B7FE9 File Offset: 0x004B61E9
		public static void StartSelfInteractBlockDetectionKeysVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602204B RID: 139339 RVA: 0x004B7FF4 File Offset: 0x004B61F4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(11, nullMask, 0);
		}

		// Token: 0x0602204C RID: 139340 RVA: 0x004B8000 File Offset: 0x004B6200
		public static Offset<IExploreSkillInteract> EndIExploreSkillInteract(FlatBufferBuilder builder)
		{
			return new Offset<IExploreSkillInteract>(builder.EndTable());
		}

		// Token: 0x0602204D RID: 139341 RVA: 0x004B8010 File Offset: 0x004B6210
		public IExploreSkillInteractT UnPack()
		{
			IExploreSkillInteractT exploreSkillInteractT = new IExploreSkillInteractT();
			this.UnPackTo(exploreSkillInteractT);
			return exploreSkillInteractT;
		}

		// Token: 0x0602204E RID: 139342 RVA: 0x004B802C File Offset: 0x004B622C
		public void UnPackTo(IExploreSkillInteractT _o)
		{
			_o.ExploreSkillUiResource = this.ExploreSkillUiResource;
			_o.Option = new TExploreSkillInteractOptionUnion();
			_o.Option.Type = this.OptionType;
			switch (this.OptionType)
			{
			case TExploreSkillInteractOption.IExploreSkillArrowInteractPoint:
				_o.Option.Value = ((this.Option<IExploreSkillArrowInteractPoint>() != null) ? this.Option<IExploreSkillArrowInteractPoint>().Value.UnPack() : null);
				break;
			case TExploreSkillInteractOption.IExploreSkillCustom:
				_o.Option.Value = ((this.Option<IExploreSkillCustom>() != null) ? this.Option<IExploreSkillCustom>().Value.UnPack() : null);
				break;
			case TExploreSkillInteractOption.IExploreSkillEavesdrop:
				_o.Option.Value = ((this.Option<IExploreSkillEavesdrop>() != null) ? this.Option<IExploreSkillEavesdrop>().Value.UnPack() : null);
				break;
			case TExploreSkillInteractOption.IExploreSkillLonelyDollPollutant:
				_o.Option.Value = ((this.Option<IExploreSkillLonelyDollPollutant>() != null) ? this.Option<IExploreSkillLonelyDollPollutant>().Value.UnPack() : null);
				break;
			case TExploreSkillInteractOption.IExploreSkillMechascoutDrag:
				_o.Option.Value = ((this.Option<IExploreSkillMechascoutDrag>() != null) ? this.Option<IExploreSkillMechascoutDrag>().Value.UnPack() : null);
				break;
			case TExploreSkillInteractOption.IExploreSkillPullGiant:
				_o.Option.Value = ((this.Option<IExploreSkillPullGiant>() != null) ? this.Option<IExploreSkillPullGiant>().Value.UnPack() : null);
				break;
			case TExploreSkillInteractOption.IExploreSkillPullStatue:
				_o.Option.Value = ((this.Option<IExploreSkillPullStatue>() != null) ? this.Option<IExploreSkillPullStatue>().Value.UnPack() : null);
				break;
			case TExploreSkillInteractOption.IExploreSkillQuantumDiffusion:
				_o.Option.Value = ((this.Option<IExploreSkillQuantumDiffusion>() != null) ? this.Option<IExploreSkillQuantumDiffusion>().Value.UnPack() : null);
				break;
			case TExploreSkillInteractOption.IExploreSkillRagDollCrushingRock:
				_o.Option.Value = ((this.Option<IExploreSkillRagDollCrushingRock>() != null) ? this.Option<IExploreSkillRagDollCrushingRock>().Value.UnPack() : null);
				break;
			case TExploreSkillInteractOption.IExploreSkillRagDollDestroySolidRock:
				_o.Option.Value = ((this.Option<IExploreSkillRagDollDestroySolidRock>() != null) ? this.Option<IExploreSkillRagDollDestroySolidRock>().Value.UnPack() : null);
				break;
			case TExploreSkillInteractOption.IExploreSkillStatueInteractPoint:
				_o.Option.Value = ((this.Option<IExploreSkillStatueInteractPoint>() != null) ? this.Option<IExploreSkillStatueInteractPoint>().Value.UnPack() : null);
				break;
			case TExploreSkillInteractOption.IFollowShooterInteractPoint:
				_o.Option.Value = ((this.Option<IFollowShooterInteractPoint>() != null) ? this.Option<IFollowShooterInteractPoint>().Value.UnPack() : null);
				break;
			case TExploreSkillInteractOption.IFoxJumpInteractPoint:
				_o.Option.Value = ((this.Option<IFoxJumpInteractPoint>() != null) ? this.Option<IFoxJumpInteractPoint>().Value.UnPack() : null);
				break;
			case TExploreSkillInteractOption.IMonsterSummonInteractPoint:
				_o.Option.Value = ((this.Option<IMonsterSummonInteractPoint>() != null) ? this.Option<IMonsterSummonInteractPoint>().Value.UnPack() : null);
				break;
			}
			_o.PlayerStateRestritionId = this.PlayerStateRestritionId;
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
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.SearchTargetCfg = new TExploreSkillSearchTargetCfgUnion();
			_o.SearchTargetCfg.Type = this.SearchTargetCfgType;
			TExploreSkillSearchTargetCfg searchTargetCfgType = this.SearchTargetCfgType;
			if (searchTargetCfgType != TExploreSkillSearchTargetCfg.IAngleWeight)
			{
				if (searchTargetCfgType == TExploreSkillSearchTargetCfg.IEnterScreenWeight)
				{
					_o.SearchTargetCfg.Value = ((this.SearchTargetCfg<IEnterScreenWeight>() != null) ? this.SearchTargetCfg<IEnterScreenWeight>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.SearchTargetCfg.Value = ((this.SearchTargetCfg<IAngleWeight>() != null) ? this.SearchTargetCfg<IAngleWeight>().Value.UnPack() : null);
			}
			_o.IgnoresCollisionCfg = ((this.IgnoresCollisionCfg != null) ? this.IgnoresCollisionCfg.Value.UnPack() : null);
			_o.SelfInteractBlockDetectionKeys = new List<string>();
			for (int j = 0; j < this.SelfInteractBlockDetectionKeysLength; j++)
			{
				_o.SelfInteractBlockDetectionKeys.Add(this.SelfInteractBlockDetectionKeys(j));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602204F RID: 139343 RVA: 0x004B8604 File Offset: 0x004B6804
		public static Offset<IExploreSkillInteract> Pack(FlatBufferBuilder builder, IExploreSkillInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExploreSkillInteract>);
			}
			StringOffset exploreSkillUiResourceOffset = (_o.ExploreSkillUiResource == null) ? default(StringOffset) : builder.CreateString(_o.ExploreSkillUiResource);
			TExploreSkillInteractOption option_type = (_o.Option == null) ? TExploreSkillInteractOption.NONE : _o.Option.Type;
			int optionOffset = (_o.Option == null) ? 0 : TExploreSkillInteractOptionUnion.Pack(builder, _o.Option);
			VectorOffset matchRoleOption_typeOffset = default(VectorOffset);
			if (_o.MatchRoleOption != null)
			{
				TMatchRoleOption[] array = new TMatchRoleOption[_o.MatchRoleOption.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.MatchRoleOption[i].Type;
				}
				matchRoleOption_typeOffset = IExploreSkillInteract.CreateMatchRoleOptionTypeVector(builder, array);
			}
			VectorOffset matchRoleOptionOffset = default(VectorOffset);
			if (_o.MatchRoleOption != null)
			{
				int[] array2 = new int[_o.MatchRoleOption.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TMatchRoleOptionUnion.Pack(builder, _o.MatchRoleOption[j]);
				}
				matchRoleOptionOffset = IExploreSkillInteract.CreateMatchRoleOptionVector(builder, array2);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			TExploreSkillSearchTargetCfg searchTargetCfg_type = (_o.SearchTargetCfg == null) ? TExploreSkillSearchTargetCfg.NONE : _o.SearchTargetCfg.Type;
			int searchTargetCfgOffset = (_o.SearchTargetCfg == null) ? 0 : TExploreSkillSearchTargetCfgUnion.Pack(builder, _o.SearchTargetCfg);
			Offset<IIgnoresCollisionCfg> ignoresCollisionCfgOffset = (_o.IgnoresCollisionCfg == null) ? default(Offset<IIgnoresCollisionCfg>) : IIgnoresCollisionCfg.Pack(builder, _o.IgnoresCollisionCfg);
			VectorOffset selfInteractBlockDetectionKeysOffset = default(VectorOffset);
			if (_o.SelfInteractBlockDetectionKeys != null)
			{
				StringOffset[] array3 = new StringOffset[_o.SelfInteractBlockDetectionKeys.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = builder.CreateString(_o.SelfInteractBlockDetectionKeys[k]);
				}
				selfInteractBlockDetectionKeysOffset = IExploreSkillInteract.CreateSelfInteractBlockDetectionKeysVector(builder, array3);
			}
			return IExploreSkillInteract.CreateIExploreSkillInteract(builder, exploreSkillUiResourceOffset, option_type, optionOffset, _o.PlayerStateRestritionId, matchRoleOption_typeOffset, matchRoleOptionOffset, conditionOffset, searchTargetCfg_type, searchTargetCfgOffset, ignoresCollisionCfgOffset, selfInteractBlockDetectionKeysOffset, _o.NullMask);
		}

		// Token: 0x0400E2F1 RID: 58097
		private Table __p;
	}
}
