using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Wrapper.Out;
using Aki.UniverseEditor.Interface.Fbs.Action;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.SeamlessTravel;
using Google.FlatBuffers;
using UnrealEngine;

namespace CSharpScript.Game.Module.Teleport
{
	// Token: 0x02004B70 RID: 19312
	[NullableContext(2)]
	[Nullable(0)]
	[Model(0)]
	public class TeleportModel : ModelBase
	{
		// Token: 0x17007C1C RID: 31772
		// (get) Token: 0x06032065 RID: 204901 RVA: 0x00B9C654 File Offset: 0x00B9A854
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

		// Token: 0x06032066 RID: 204902 RVA: 0x00B9C688 File Offset: 0x00B9A888
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

		// Token: 0x17007C1D RID: 31773
		// (get) Token: 0x06032067 RID: 204903 RVA: 0x00B9C6DC File Offset: 0x00B9A8DC
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

		// Token: 0x17007C1E RID: 31774
		// (get) Token: 0x06032068 RID: 204904 RVA: 0x00B9C705 File Offset: 0x00B9A905
		public bool IsTeleport
		{
			get
			{
				return this.TeleportContextQueue.Count > 0;
			}
		}

		// Token: 0x17007C1F RID: 31775
		// (get) Token: 0x06032069 RID: 204905 RVA: 0x00B9C715 File Offset: 0x00B9A915
		public global::Vector StartPosition
		{
			get
			{
				return this.StartPositionInternal;
			}
		}

		// Token: 0x17007C20 RID: 31776
		// (get) Token: 0x0603206A RID: 204906 RVA: 0x00B9C71D File Offset: 0x00B9A91D
		public Rotator StartRotation
		{
			get
			{
				return this.StartRotationInternal;
			}
		}

		// Token: 0x17007C21 RID: 31777
		// (get) Token: 0x0603206B RID: 204907 RVA: 0x00B9C725 File Offset: 0x00B9A925
		public global::Vector StartGravityDirect
		{
			get
			{
				return this.StartGravityDirectInternal;
			}
		}

		// Token: 0x17007C22 RID: 31778
		// (get) Token: 0x0603206C RID: 204908 RVA: 0x00B9C72D File Offset: 0x00B9A92D
		public global::Vector TargetPosition
		{
			get
			{
				return this.TargetPositionInternal;
			}
		}

		// Token: 0x17007C23 RID: 31779
		// (get) Token: 0x0603206D RID: 204909 RVA: 0x00B9C735 File Offset: 0x00B9A935
		public Rotator TargetRotation
		{
			get
			{
				return this.TargetRotationInternal;
			}
		}

		// Token: 0x17007C24 RID: 31780
		// (get) Token: 0x0603206E RID: 204910 RVA: 0x00B9C73D File Offset: 0x00B9A93D
		public global::Vector TargetGravityDirect
		{
			get
			{
				return this.TargetGravityDirectInternal;
			}
		}

		// Token: 0x17007C25 RID: 31781
		// (get) Token: 0x0603206F RID: 204911 RVA: 0x00B9C745 File Offset: 0x00B9A945
		public Rotator CameraStartRotation
		{
			get
			{
				return this.CameraStartRotationInternal;
			}
		}

		// Token: 0x17007C26 RID: 31782
		// (get) Token: 0x06032070 RID: 204912 RVA: 0x00B9C74D File Offset: 0x00B9A94D
		// (set) Token: 0x06032071 RID: 204913 RVA: 0x00B9C758 File Offset: 0x00B9A958
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

		// Token: 0x06032072 RID: 204914 RVA: 0x00B9C79C File Offset: 0x00B9A99C
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

		// Token: 0x17007C27 RID: 31783
		// (get) Token: 0x06032073 RID: 204915 RVA: 0x00B9C80B File Offset: 0x00B9AA0B
		public bool AllowTeleportByUi
		{
			get
			{
				return this.AllowTeleportInternal;
			}
		}

		// Token: 0x06032074 RID: 204916 RVA: 0x00B9C814 File Offset: 0x00B9AA14
		protected override bool OnInit()
		{
			this.StartPositionInternal = global::Vector.Create();
			this.TargetPositionInternal = global::Vector.Create();
			this.StartRotationInternal = Rotator.Create();
			this.CameraStartRotationInternal = Rotator.Create();
			this.TargetRotationInternal = Rotator.Create();
			this.StartGravityDirectInternal = global::Vector.Create();
			this.TargetGravityDirectInternal = global::Vector.Create();
			return true;
		}

		// Token: 0x06032075 RID: 204917 RVA: 0x00B9C86F File Offset: 0x00B9AA6F
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

		// Token: 0x06032076 RID: 204918 RVA: 0x00B9C8AE File Offset: 0x00B9AAAE
		protected override bool OnLeaveLevel()
		{
			this.SetAllowTeleportByUi(true, "OnLeaveLevel");
			return true;
		}

		// Token: 0x06032077 RID: 204919 RVA: 0x00B9C8C0 File Offset: 0x00B9AAC0
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

		// Token: 0x06032078 RID: 204920 RVA: 0x00B9CA60 File Offset: 0x00B9AC60
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

		// Token: 0x06032079 RID: 204921 RVA: 0x00B9CB38 File Offset: 0x00B9AD38
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

		// Token: 0x0603207A RID: 204922 RVA: 0x00B9CBE0 File Offset: 0x00B9ADE0
		public unsafe Aki.TDConfigMgr.Action.ITeleportTransitionType ParseTransitionConfig(int id)
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
			if (WrapperSetting.UseFb)
			{
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
			global::Log instance3 = global::Log.Instance;
			ELogModule module3 = ELogModule.TeleportMisc;
			ELogAuthor author3 = ELogAuthor.CK;
			string message3 = "传送过渡配置JSON解析";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("ConfigId", id);
			instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			TeleportTransitionConfig? config = ConfigTeleportTransitionConfigById.GetConfig(id, true);
			if (config == null)
			{
				global::Log instance4 = global::Log.Instance;
				ELogModule module4 = ELogModule.TeleportMisc;
				ELogAuthor author4 = ELogAuthor.CK;
				string message4 = "传送过渡配置查询失败: 未找到配置";
				ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("ConfigId", id);
				instance4.Warn(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
				return null;
			}
			string data = config.Value.Data;
			if (data == null)
			{
				global::Log instance5 = global::Log.Instance;
				ELogModule module5 = ELogModule.TeleportMisc;
				ELogAuthor author5 = ELogAuthor.CK;
				string message5 = "传送过渡配置查询失败: Data为空";
				ValueTuple<string, object> valueTuple5 = new ValueTuple<string, object>("ConfigId", id);
				instance5.Warn(module5, author5, message5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple5));
				return null;
			}
			Aki.TDConfigMgr.Action.ITeleportTransitionType result2;
			try
			{
				Aki.TDConfigMgr.Action.ITeleportTransitionType teleportTransitionType2 = Json.Parse<Aki.TDConfigMgr.Action.ITeleportTransitionType>(data, null);
				this.Cache[id] = teleportTransitionType2;
				result2 = teleportTransitionType2;
			}
			catch (Exception ex)
			{
				global::Log instance6 = global::Log.Instance;
				ELogModule module6 = ELogModule.TeleportMisc;
				ELogAuthor author6 = ELogAuthor.CK;
				string message6 = "传送过渡配置JSON解析失败";
				Exception error = ex;
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Error", ex.Message);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ConfigId", id);
				instance6.ErrorWithStack(module6, author6, message6, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				result2 = null;
			}
			return result2;
		}

		// Token: 0x17007C28 RID: 31784
		// (get) Token: 0x0603207B RID: 204923 RVA: 0x00B9CDDC File Offset: 0x00B9AFDC
		[Nullable(1)]
		public static TeleportModel Instance
		{
			[NullableContext(1)]
			get
			{
				return TeleportModel._Instance;
			}
		}

		// Token: 0x0603207C RID: 204924 RVA: 0x00B9CDE3 File Offset: 0x00B9AFE3
		[NullableContext(1)]
		public static TeleportModel GetOrCreateInstance()
		{
			if (TeleportModel._Instance == null)
			{
				TeleportModel.CreateInstance();
			}
			return TeleportModel._Instance;
		}

		// Token: 0x0603207D RID: 204925 RVA: 0x00B9CDF7 File Offset: 0x00B9AFF7
		public static bool CreateInstance()
		{
			if (TeleportModel._Instance != null)
			{
				return true;
			}
			TeleportModel._Instance = new TeleportModel();
			return true;
		}

		// Token: 0x0603207E RID: 204926 RVA: 0x00B9CE0D File Offset: 0x00B9B00D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603207F RID: 204927 RVA: 0x00B9CE0F File Offset: 0x00B9B00F
		public static void ResetStaticDefaultValue()
		{
			TeleportModel._Instance = null;
		}

		// Token: 0x06032080 RID: 204928 RVA: 0x00B9CE17 File Offset: 0x00B9B017
		static TeleportModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TeleportModel.CreateStaticDefaultValue), new Action(TeleportModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401AA9F RID: 109215
		[Nullable(1)]
		private readonly List<TeleportContext> TeleportContextQueue = new List<TeleportContext>();

		// Token: 0x0401AAA0 RID: 109216
		[Nullable(1)]
		private readonly Dictionary<int, Aki.TDConfigMgr.Action.ITeleportTransitionType> Cache = new Dictionary<int, Aki.TDConfigMgr.Action.ITeleportTransitionType>();

		// Token: 0x0401AAA1 RID: 109217
		[Nullable(1)]
		private string TeleportTransitionFbPath = UBlueprintPathsLibrary.ProjectContentDir() + "Aki/Config/UniverseEditorConfig/TeleportTransitions/";

		// Token: 0x0401AAA2 RID: 109218
		private const int TELEPORT_TRANSITION_FB_LRU_CAPACITY = 50;

		// Token: 0x0401AAA3 RID: 109219
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private CacheLru<int, Aki.TDConfigMgr.Action.ITeleportTransitionType> TeleportTransitionFbLruInternal;

		// Token: 0x0401AAA4 RID: 109220
		private global::Vector StartPositionInternal;

		// Token: 0x0401AAA5 RID: 109221
		private Rotator StartRotationInternal;

		// Token: 0x0401AAA6 RID: 109222
		private global::Vector StartGravityDirectInternal;

		// Token: 0x0401AAA7 RID: 109223
		private global::Vector TargetPositionInternal;

		// Token: 0x0401AAA8 RID: 109224
		private Rotator TargetRotationInternal;

		// Token: 0x0401AAA9 RID: 109225
		private global::Vector TargetGravityDirectInternal;

		// Token: 0x0401AAAA RID: 109226
		private Rotator CameraStartRotationInternal;

		// Token: 0x0401AAAB RID: 109227
		private bool IsSkillBlockedInternal;

		// Token: 0x0401AAAC RID: 109228
		private bool AllowTeleportInternal = true;

		// Token: 0x0401AAAD RID: 109229
		private static TeleportModel _Instance;
	}
}
