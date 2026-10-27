using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.NewWorld.SceneItem;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.GravityFlip
{
	// Token: 0x02006E1B RID: 28187
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class GravityFlipModel : ModelBase
	{
		// Token: 0x06044B84 RID: 281476 RVA: 0x010F6059 File Offset: 0x010F4259
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x06044B85 RID: 281477 RVA: 0x010F605C File Offset: 0x010F425C
		protected override bool OnClear()
		{
			return true;
		}

		// Token: 0x06044B86 RID: 281478 RVA: 0x010F6060 File Offset: 0x010F4260
		public void InitGravityFlipParams(SceneItemGravityFlipComponent gravityFlipComp)
		{
			this.GravityFlipComp = gravityFlipComp;
			this.GravityFlipEntity = gravityFlipComp.Entity;
			this.ValidGravityDirections.Clear();
			this.CurrentGravityDirection = gravityFlipComp.CurGravityDirection;
			List<IGravityFlipConfig> gravityFlipDirection = gravityFlipComp.GetGravityFlipDirection();
			if (gravityFlipDirection == null || gravityFlipDirection.Count <= 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[GravityFlipModel] 未找到重力方向配置";
				string item = "PbDataId";
				CreatureDataComponent component = gravityFlipComp.Entity.GetComponent<CreatureDataComponent>();
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (component != null) ? new int?(component.GetPbDataId()) : null);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			using (List<IGravityFlipConfig>.Enumerator enumerator = gravityFlipDirection.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					switch (enumerator.Current.Type)
					{
					case EGravityFlipType.Up:
						this.ValidGravityDirections.Add(EGravityDirection.Up);
						break;
					case EGravityFlipType.Down:
						this.ValidGravityDirections.Add(EGravityDirection.Down);
						break;
					case EGravityFlipType.Left:
						this.ValidGravityDirections.Add(EGravityDirection.Left);
						break;
					case EGravityFlipType.Right:
						this.ValidGravityDirections.Add(EGravityDirection.Right);
						break;
					}
				}
			}
			this.GravityFlipComp.OnEnterInteract();
		}

		// Token: 0x06044B87 RID: 281479 RVA: 0x010F61A0 File Offset: 0x010F43A0
		public bool NeedChangeGravity()
		{
			return this.GravityFlipComp.CurGravityDirection != this.CurrentGravityDirection;
		}

		// Token: 0x170099F7 RID: 39415
		// (get) Token: 0x06044B88 RID: 281480 RVA: 0x010F61B8 File Offset: 0x010F43B8
		public long GravityFlipEntityCreatureDataId
		{
			get
			{
				Entity gravityFlipEntity = this.GravityFlipEntity;
				long? num;
				if (gravityFlipEntity == null)
				{
					num = null;
				}
				else
				{
					CreatureDataComponent component = gravityFlipEntity.GetComponent<CreatureDataComponent>();
					num = ((component != null) ? new long?(component.GetCreatureDataId()) : null);
				}
				long? num2 = num;
				return num2.GetValueOrDefault();
			}
		}

		// Token: 0x06044B89 RID: 281481 RVA: 0x010F6200 File Offset: 0x010F4400
		private GravityFlipType ConvertGravityDirectionToProtoType(EGravityDirection direction)
		{
			if (direction <= EGravityDirection.Left)
			{
				if (direction == EGravityDirection.Down)
				{
					return GravityFlipType.GravityDown;
				}
				if (direction == EGravityDirection.Left)
				{
					return GravityFlipType.GravityLeft;
				}
			}
			else
			{
				if (direction == EGravityDirection.Up)
				{
					return GravityFlipType.GravityUp;
				}
				if (direction == EGravityDirection.Right)
				{
					return GravityFlipType.GravityRight;
				}
			}
			return GravityFlipType.GravityDown;
		}

		// Token: 0x170099F8 RID: 39416
		// (get) Token: 0x06044B8A RID: 281482 RVA: 0x010F622C File Offset: 0x010F442C
		public GravityFlipType CurGravityFlipType
		{
			get
			{
				return this.ConvertGravityDirectionToProtoType(this.CurrentGravityDirection);
			}
		}

		// Token: 0x170099F9 RID: 39417
		// (get) Token: 0x06044B8B RID: 281483 RVA: 0x010F623C File Offset: 0x010F443C
		public EGravityDirection TargetDirection
		{
			get
			{
				Entity gravityFlipEntity = this.GravityFlipEntity;
				BaseTagComponent baseTagComponent = (gravityFlipEntity != null) ? gravityFlipEntity.GetComponent<BaseTagComponent>() : null;
				if (baseTagComponent == null)
				{
					return EGravityDirection.None;
				}
				if (baseTagComponent.GetTagCount(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.重力机关.重力方向提示"]) != 1)
				{
					return EGravityDirection.None;
				}
				if (baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.重力机关.重力方向提示.上"]))
				{
					return EGravityDirection.Up;
				}
				if (baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.重力机关.重力方向提示.下"]))
				{
					return EGravityDirection.Down;
				}
				if (baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.重力机关.重力方向提示.左"]))
				{
					return EGravityDirection.Left;
				}
				if (baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.重力机关.重力方向提示.右"]))
				{
					return EGravityDirection.Right;
				}
				return EGravityDirection.None;
			}
		}

		// Token: 0x06044B8C RID: 281484 RVA: 0x010F62EC File Offset: 0x010F44EC
		protected override bool OnChangeMode()
		{
			SceneItemGravityFlipComponent gravityFlipComp = this.GravityFlipComp;
			if (gravityFlipComp == null || !gravityFlipComp.IsInteracting)
			{
				return true;
			}
			GravityFlipViewOpenParam param = new GravityFlipViewOpenParam
			{
				SelectCallback = this.ViewCallBackCache
			};
			UiManager.Instance.OpenView(EUiViewName.GravityFlipView, param, null);
			return true;
		}

		// Token: 0x170099FA RID: 39418
		// (get) Token: 0x06044B8D RID: 281485 RVA: 0x010F6336 File Offset: 0x010F4536
		public static GravityFlipModel Instance
		{
			get
			{
				return GravityFlipModel._Instance;
			}
		}

		// Token: 0x06044B8E RID: 281486 RVA: 0x010F633D File Offset: 0x010F453D
		public static GravityFlipModel GetOrCreateInstance()
		{
			if (GravityFlipModel._Instance == null)
			{
				GravityFlipModel.CreateInstance();
			}
			return GravityFlipModel._Instance;
		}

		// Token: 0x06044B8F RID: 281487 RVA: 0x010F6351 File Offset: 0x010F4551
		public static bool CreateInstance()
		{
			if (GravityFlipModel._Instance != null)
			{
				return true;
			}
			GravityFlipModel._Instance = new GravityFlipModel();
			return true;
		}

		// Token: 0x06044B90 RID: 281488 RVA: 0x010F6367 File Offset: 0x010F4567
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06044B91 RID: 281489 RVA: 0x010F6369 File Offset: 0x010F4569
		public static void ResetStaticDefaultValue()
		{
			GravityFlipModel._Instance = null;
		}

		// Token: 0x06044B92 RID: 281490 RVA: 0x010F6371 File Offset: 0x010F4571
		static GravityFlipModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GravityFlipModel.CreateStaticDefaultValue), new Action(GravityFlipModel.ResetStaticDefaultValue));
		}

		// Token: 0x04023BF4 RID: 146420
		[Nullable(2)]
		public Entity GravityFlipEntity;

		// Token: 0x04023BF5 RID: 146421
		[Nullable(2)]
		public SceneItemGravityFlipComponent GravityFlipComp;

		// Token: 0x04023BF6 RID: 146422
		public GravityFlipType CacheCorrectDirection = GravityFlipType.GravityDown;

		// Token: 0x04023BF7 RID: 146423
		public EGravityDirection CurrentGravityDirection;

		// Token: 0x04023BF8 RID: 146424
		public List<EGravityDirection> ValidGravityDirections = new List<EGravityDirection>();

		// Token: 0x04023BF9 RID: 146425
		[Nullable(2)]
		public Action<int> ViewCallBackCache;

		// Token: 0x04023BFA RID: 146426
		[Nullable(2)]
		private static GravityFlipModel _Instance;
	}
}
