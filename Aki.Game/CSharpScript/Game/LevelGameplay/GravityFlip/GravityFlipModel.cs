using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.NewWorld.SceneItem;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.GravityFlip
{
	// Token: 0x02005F9B RID: 24475
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class GravityFlipModel : ModelBase
	{
		// Token: 0x0603ACED RID: 240877 RVA: 0x010A0595 File Offset: 0x0109E795
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x0603ACEE RID: 240878 RVA: 0x010A0598 File Offset: 0x0109E798
		protected override bool OnClear()
		{
			return true;
		}

		// Token: 0x0603ACEF RID: 240879 RVA: 0x010A059C File Offset: 0x0109E79C
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

		// Token: 0x0603ACF0 RID: 240880 RVA: 0x010A06DC File Offset: 0x0109E8DC
		public bool NeedChangeGravity()
		{
			return this.GravityFlipComp.CurGravityDirection != this.CurrentGravityDirection;
		}

		// Token: 0x17006EFA RID: 28410
		// (get) Token: 0x0603ACF1 RID: 240881 RVA: 0x010A06F4 File Offset: 0x0109E8F4
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

		// Token: 0x0603ACF2 RID: 240882 RVA: 0x010A073C File Offset: 0x0109E93C
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

		// Token: 0x17006EFB RID: 28411
		// (get) Token: 0x0603ACF3 RID: 240883 RVA: 0x010A0768 File Offset: 0x0109E968
		public GravityFlipType CurGravityFlipType
		{
			get
			{
				return this.ConvertGravityDirectionToProtoType(this.CurrentGravityDirection);
			}
		}

		// Token: 0x17006EFC RID: 28412
		// (get) Token: 0x0603ACF4 RID: 240884 RVA: 0x010A0778 File Offset: 0x0109E978
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

		// Token: 0x0603ACF5 RID: 240885 RVA: 0x010A0828 File Offset: 0x0109EA28
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

		// Token: 0x17006EFD RID: 28413
		// (get) Token: 0x0603ACF6 RID: 240886 RVA: 0x010A0872 File Offset: 0x0109EA72
		public static GravityFlipModel Instance
		{
			get
			{
				return GravityFlipModel._Instance;
			}
		}

		// Token: 0x0603ACF7 RID: 240887 RVA: 0x010A0879 File Offset: 0x0109EA79
		public static GravityFlipModel GetOrCreateInstance()
		{
			if (GravityFlipModel._Instance == null)
			{
				GravityFlipModel.CreateInstance();
			}
			return GravityFlipModel._Instance;
		}

		// Token: 0x0603ACF8 RID: 240888 RVA: 0x010A088D File Offset: 0x0109EA8D
		public static bool CreateInstance()
		{
			if (GravityFlipModel._Instance != null)
			{
				return true;
			}
			GravityFlipModel._Instance = new GravityFlipModel();
			return true;
		}

		// Token: 0x0603ACF9 RID: 240889 RVA: 0x010A08A3 File Offset: 0x0109EAA3
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603ACFA RID: 240890 RVA: 0x010A08A5 File Offset: 0x0109EAA5
		public static void ResetStaticDefaultValue()
		{
			GravityFlipModel._Instance = null;
		}

		// Token: 0x0603ACFB RID: 240891 RVA: 0x010A08AD File Offset: 0x0109EAAD
		static GravityFlipModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GravityFlipModel.CreateStaticDefaultValue), new Action(GravityFlipModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401EE97 RID: 126615
		[Nullable(2)]
		public Entity GravityFlipEntity;

		// Token: 0x0401EE98 RID: 126616
		[Nullable(2)]
		public SceneItemGravityFlipComponent GravityFlipComp;

		// Token: 0x0401EE99 RID: 126617
		public GravityFlipType CacheCorrectDirection = GravityFlipType.GravityDown;

		// Token: 0x0401EE9A RID: 126618
		public EGravityDirection CurrentGravityDirection;

		// Token: 0x0401EE9B RID: 126619
		public List<EGravityDirection> ValidGravityDirections = new List<EGravityDirection>();

		// Token: 0x0401EE9C RID: 126620
		[Nullable(2)]
		public Action<int> ViewCallBackCache;

		// Token: 0x0401EE9D RID: 126621
		[Nullable(2)]
		private static GravityFlipModel _Instance;
	}
}
