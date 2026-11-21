using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Action;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.SeamlessTravel;
using Google.FlatBuffers;
using UnrealEngine;

namespace CSharpScript.Game.Module.Teleport
{
	// Token: 0x02003B1A RID: 15130
	[NullableContext(2)]
	[Nullable(0)]
	[Model(0)]
	public class TeleportModel : ModelBase
	{
		// Token: 0x17004FC6 RID: 20422
		// (get) Token: 0x06026DF6 RID: 159222 RVA: 0x00AE0960 File Offset: 0x00ADEB60
		[Nullable(1)]
		private CacheLru<int, Aki.TDConfigMgr.Action.ITeleportTransitionType> TeleportTransitionFbLru
		{
			[NullableContext(1)]
			get
			{
				CacheLru<int, Aki.TDConfigMgr.Action.ITeleportTransitionType> result;
				if ((result = this.TeleportTransitionFbLruInternal) == null)
				{
					result = (this.TeleportTransitionFbLruInternal = new CacheLru<int, Aki.TDConfigMgr.Action.ITeleportTransitionType>(50, new Func<int, Aki.TDConfigMgr.Action.ITeleportTransitionType>(this.LoadTeleportTransitionFromFb)));
				}
				return result;
			}
		}

		// Token: 0x06026DF7 RID: 159223 RVA: 0x00AE0994 File Offset: 0x00ADEB94
		private Aki.TDConfigMgr.Action.ITeleportTransitionType LoadTeleportTransitionFromFb(int id)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 2);
			defaultInterpolatedStringHandler.AppendFormatted(this.TeleportTransitionFbPath);
			defaultInterpolatedStringHandler.AppendFormatted<int>(id);
			defaultInterpolatedStringHandler.AppendLiteral(".bytes");
			ByteBuffer byteBuffer = FbFileLoader.LoadBytes(defaultInterpolatedStringHandler.ToStringAndClear());
			if (byteBuffer == null)
			{
				return null;
			}
			return ActionReadHelper.ReadTCsvTeleportTransitionData_Data(Aki.UniverseEditor.Interface.Fbs.Action.TCsvTeleportTransitionData.GetRootAsTCsvTeleportTransitionData(byteBuffer));
		}

		// Token: 0x17004FC7 RID: 20423
		// (get) Token: 0x06026DF8 RID: 159224 RVA: 0x00AE09E8 File Offset: 0x00ADEBE8
		public TeleportContext TeleportContext
		{
			get
			{
				if (this.TeleportContextQueue.Count == 0)
				{
					return null;
				}
				return this.TeleportContextQueue[this.TeleportContextQueue.Count - 1];
			}
		}

		// Token: 0x17004FC8 RID: 20424
		// (get) Token: 0x06026DF9 RID: 159225 RVA: 0x00AE0A11 File Offset: 0x00ADEC11
		public bool IsTeleport
		{
			get
			{
				return this.TeleportContextQueue.Count > 0;
			}
		}

		// Token: 0x17004FC9 RID: 20425
		// (get) Token: 0x06026DFA RID: 159226 RVA: 0x00AE0A21 File Offset: 0x00ADEC21
		public Vector StartPosition
		{
			get
			{
				return this.StartPositionInternal;
			}
		}

		// Token: 0x17004FCA RID: 20426
		// (get) Token: 0x06026DFB RID: 159227 RVA: 0x00AE0A29 File Offset: 0x00ADEC29
		public Rotator StartRotation
		{
			get
			{
				return this.StartRotationInternal;
			}
		}

		// Token: 0x17004FCB RID: 20427
		// (get) Token: 0x06026DFC RID: 159228 RVA: 0x00AE0A31 File Offset: 0x00ADEC31
		public Vector StartGravityDirect
		{
			get
			{
				return this.StartGravityDirectInternal;
			}
		}

		// Token: 0x17004FCC RID: 20428
		// (get) Token: 0x06026DFD RID: 159229 RVA: 0x00AE0A39 File Offset: 0x00ADEC39
		public Vector TargetPosition
		{
			get
			{
				return this.TargetPositionInternal;
			}
		}

		// Token: 0x17004FCD RID: 20429
		// (get) Token: 0x06026DFE RID: 159230 RVA: 0x00AE0A41 File Offset: 0x00ADEC41
		public Rotator TargetRotation
		{
			get
			{
				return this.TargetRotationInternal;
			}
		}

		// Token: 0x17004FCE RID: 20430
		// (get) Token: 0x06026DFF RID: 159231 RVA: 0x00AE0A49 File Offset: 0x00ADEC49
		public Vector TargetGravityDirect
		{
			get
			{
				return this.TargetGravityDirectInternal;
			}
		}

		// Token: 0x17004FCF RID: 20431
		// (get) Token: 0x06026E00 RID: 159232 RVA: 0x00AE0A51 File Offset: 0x00ADEC51
		public Rotator CameraStartRotation
		{
			get
			{
				return this.CameraStartRotationInternal;
			}
		}

		// Token: 0x17004FD0 RID: 20432
		// (get) Token: 0x06026E01 RID: 159233 RVA: 0x00AE0A59 File Offset: 0x00ADEC59
		// (set) Token: 0x06026E02 RID: 159234 RVA: 0x00AE0A64 File Offset: 0x00ADEC64
		public bool IsSkillBlocked
		{
			get
			{
				return this.IsSkillBlockedInternal;
			}
			set
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.TeleportMisc;
				ELogAuthor author = ELogAuthor.CK;
				string message = "设置是否禁止释放技能";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("IsSkillBlocked", value);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.IsSkillBlockedInternal = value;
			}
		}

		// Token: 0x06026E03 RID: 159235 RVA: 0x00AE0AA8 File Offset: 0x00ADECA8
		[NullableContext(1)]
		public unsafe void SetAllowTeleportByUi(bool allowTeleport, string reason)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.TeleportMisc;
			ELogAuthor author = ELogAuthor.CK;
			string message = "传送: 设置是否允许UI发起传送";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("AllowTeleport", allowTeleport);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Reason", reason);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.AllowTeleportInternal = allowTeleport;
		}

		// Token: 0x17004FD1 RID: 20433
		// (get) Token: 0x06026E04 RID: 159236 RVA: 0x00AE0B17 File Offset: 0x00ADED17
		public bool AllowTeleportByUi
		{
			get
			{
				return this.AllowTeleportInternal;
			}
		}

		// Token: 0x06026E05 RID: 159237 RVA: 0x00AE0B20 File Offset: 0x00ADED20
		protected override bool OnInit()
		{
			this.StartPositionInternal = Vector.Create();
			this.TargetPositionInternal = Vector.Create();
			this.StartRotationInternal = Rotator.Create();
			this.CameraStartRotationInternal = Rotator.Create();
			this.TargetRotationInternal = Rotator.Create();
			this.StartGravityDirectInternal = Vector.Create();
			this.TargetGravityDirectInternal = Vector.Create();
			return true;
		}

		// Token: 0x06026E06 RID: 159238 RVA: 0x00AE0B7B File Offset: 0x00ADED7B
		protected override bool OnClear()
		{
			this.StartPositionInternal = null;
			this.TargetPositionInternal = null;
			this.StartRotationInternal = null;
			this.CameraStartRotationInternal = null;
			this.TargetRotationInternal = null;
			this.StartGravityDirectInternal = null;
			this.TargetGravityDirectInternal = null;
			this.Cache.Clear();
			return true;
		}

		// Token: 0x06026E07 RID: 159239 RVA: 0x00AE0BBA File Offset: 0x00ADEDBA
		protected override bool OnLeaveLevel()
		{
			this.SetAllowTeleportByUi(true, "OnLeaveLevel");
			return true;
		}

		// Token: 0x06026E08 RID: 159240 RVA: 0x00AE0BCC File Offset: 0x00ADEDCC
		public bool GetIsKeepingCurrentMovementMode()
		{
			if (this.TeleportContext != null && this.TeleportContext.IsInSeamlessTeleport)
			{
				SeamlessTravelKeepMovementMode keepMovementMode = this.TeleportContext.KeepMovementMode;
				if (keepMovementMode != null && keepMovementMode.IsActive)
				{
					TsBaseCharacter baseCharacter = Global.BaseCharacter;
					object obj;
					if (baseCharacter == null)
					{
						obj = null;
					}
					else
					{
						CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
						if (characterActorComponent == null)
						{
							obj = null;
						}
						else
						{
							BaseMoveComponent moveComp = characterActorComponent.MoveComp;
							obj = ((moveComp != null) ? moveComp.CharacterMovement : null);
						}
					}
					object obj2 = obj;
					TEnumAsByte<EMovementMode>? tenumAsByte = (obj2 != null) ? new TEnumAsByte<EMovementMode>?(obj2.MovementMode) : null;
					byte? b = (obj2 != null) ? new byte?(obj2.CustomMovementMode) : null;
					if (tenumAsByte == null || b == null)
					{
						return false;
					}
					EMovementMode? targetMovementMode = this.TeleportContext.KeepMovementMode.TargetMovementMode;
					if (((targetMovementMode != null) ? new TEnumAsByte<EMovementMode>?(targetMovementMode.GetValueOrDefault()) : null) == tenumAsByte)
					{
						byte? b2 = this.TeleportContext.KeepMovementMode.TargetCustomMode;
						int? num = (b2 != null) ? new int?((int)b2.GetValueOrDefault()) : null;
						b2 = b;
						int? num2 = (b2 != null) ? new int?((int)b2.GetValueOrDefault()) : null;
						return num.GetValueOrDefault() == num2.GetValueOrDefault() & num != null == (num2 != null);
					}
					return false;
				}
			}
			return false;
		}

		// Token: 0x06026E09 RID: 159241 RVA: 0x00AE0D6C File Offset: 0x00ADEF6C
		[NullableContext(1)]
		public unsafe TeleportContext CreateContext(ITeleportContext contextParams)
		{
			if (this.TeleportContextQueue.Count > 0)
			{
				global::Log.Instance.Error(ELogModule.Teleport, ELogAuthor.CK, "传送: 尝试在传送过程中再次发起传送, 需要关注", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			TeleportContext teleportContext = TeleportContext.CreateContext(contextParams);
			this.TeleportContextQueue.Add(teleportContext);
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.TeleportMisc;
			ELogAuthor author = ELogAuthor.CK;
			string message = "创建上下文";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("TeleportContextId", teleportContext.TeleportContextId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ClientReason", teleportContext.ClientReason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ServerReason", teleportContext.ServerReason);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return teleportContext;
		}

		// Token: 0x06026E0A RID: 159242 RVA: 0x00AE0E44 File Offset: 0x00ADF044
		[NullableContext(1)]
		public void RemoveContext(TeleportContext context)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.TeleportMisc;
			ELogAuthor author = ELogAuthor.CK;
			string message = "移除上下文";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TeleportContextId", context.TeleportContextId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			for (int i = 0; i < this.TeleportContextQueue.Count; i++)
			{
				if (this.TeleportContextQueue[i] == context)
				{
					this.TeleportContextQueue.RemoveAt(i);
					return;
				}
			}
			global::Log instance2 = global::Log.Instance;
			ELogModule module2 = ELogModule.TeleportMisc;
			ELogAuthor author2 = ELogAuthor.CK;
			string message2 = "移除上下文失败";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("TeleportContextId", context.TeleportContextId);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		}

		// Token: 0x06026E0B RID: 159243 RVA: 0x00AE0EEC File Offset: 0x00ADF0EC
		public Aki.TDConfigMgr.Action.ITeleportTransitionType ParseTransitionConfig(int id)
		{
			Aki.TDConfigMgr.Action.ITeleportTransitionType result;
			if (this.Cache.TryGetValue(id, out result))
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.TeleportMisc;
				ELogAuthor author = ELogAuthor.CK;
				string message = "传送过渡配置缓存命中, 直接读取缓存结果";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ConfigId", id);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return result;
			}
			Aki.TDConfigMgr.Action.ITeleportTransitionType teleportTransitionType = this.TeleportTransitionFbLru.Get(id);
			if (teleportTransitionType != null)
			{
				this.Cache[id] = teleportTransitionType;
			}
			else
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.TeleportMisc;
				ELogAuthor author2 = ELogAuthor.CK;
				string message2 = "传送过渡配置FB读取失败: 未找到或解析为空";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("ConfigId", id);
				instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			}
			return teleportTransitionType;
		}

		// Token: 0x17004FD2 RID: 20434
		// (get) Token: 0x06026E0C RID: 159244 RVA: 0x00AE0F8D File Offset: 0x00ADF18D
		[Nullable(1)]
		public static TeleportModel Instance
		{
			[NullableContext(1)]
			get
			{
				return TeleportModel._Instance;
			}
		}

		// Token: 0x06026E0D RID: 159245 RVA: 0x00AE0F94 File Offset: 0x00ADF194
		[NullableContext(1)]
		public static TeleportModel GetOrCreateInstance()
		{
			if (TeleportModel._Instance == null)
			{
				TeleportModel.CreateInstance();
			}
			return TeleportModel._Instance;
		}

		// Token: 0x06026E0E RID: 159246 RVA: 0x00AE0FA8 File Offset: 0x00ADF1A8
		public static bool CreateInstance()
		{
			if (TeleportModel._Instance != null)
			{
				return true;
			}
			TeleportModel._Instance = new TeleportModel();
			return true;
		}

		// Token: 0x06026E0F RID: 159247 RVA: 0x00AE0FBE File Offset: 0x00ADF1BE
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06026E10 RID: 159248 RVA: 0x00AE0FC0 File Offset: 0x00ADF1C0
		public static void ResetStaticDefaultValue()
		{
			TeleportModel._Instance = null;
		}

		// Token: 0x06026E11 RID: 159249 RVA: 0x00AE0FC8 File Offset: 0x00ADF1C8
		static TeleportModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TeleportModel.CreateStaticDefaultValue), new Action(TeleportModel.ResetStaticDefaultValue));
		}

		// Token: 0x040153F3 RID: 87027
		[Nullable(1)]
		private readonly List<TeleportContext> TeleportContextQueue = new List<TeleportContext>();

		// Token: 0x040153F4 RID: 87028
		[Nullable(1)]
		private readonly Dictionary<int, Aki.TDConfigMgr.Action.ITeleportTransitionType> Cache = new Dictionary<int, Aki.TDConfigMgr.Action.ITeleportTransitionType>();

		// Token: 0x040153F5 RID: 87029
		[Nullable(1)]
		private string TeleportTransitionFbPath = UBlueprintPathsLibrary.ProjectContentDir() + "Aki/Config/UniverseEditorConfig/TeleportTransitions/";

		// Token: 0x040153F6 RID: 87030
		private const int TELEPORT_TRANSITION_FB_LRU_CAPACITY = 50;

		// Token: 0x040153F7 RID: 87031
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private CacheLru<int, Aki.TDConfigMgr.Action.ITeleportTransitionType> TeleportTransitionFbLruInternal;

		// Token: 0x040153F8 RID: 87032
		private Vector StartPositionInternal;

		// Token: 0x040153F9 RID: 87033
		private Rotator StartRotationInternal;

		// Token: 0x040153FA RID: 87034
		private Vector StartGravityDirectInternal;

		// Token: 0x040153FB RID: 87035
		private Vector TargetPositionInternal;

		// Token: 0x040153FC RID: 87036
		private Rotator TargetRotationInternal;

		// Token: 0x040153FD RID: 87037
		private Vector TargetGravityDirectInternal;

		// Token: 0x040153FE RID: 87038
		private Rotator CameraStartRotationInternal;

		// Token: 0x040153FF RID: 87039
		private bool IsSkillBlockedInternal;

		// Token: 0x04015400 RID: 87040
		private bool AllowTeleportInternal = true;

		// Token: 0x04015401 RID: 87041
		private static TeleportModel _Instance;
	}
}
