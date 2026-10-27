using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.NewWorld.Common.Component;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Jigsaw
{
	// Token: 0x020071F4 RID: 29172
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemJigsawItemComponent : EntityComponent
	{
		// Token: 0x17009E0A RID: 40458
		// (get) Token: 0x06047687 RID: 292487 RVA: 0x0122E798 File Offset: 0x0122C998
		// (set) Token: 0x06047688 RID: 292488 RVA: 0x0122E7A0 File Offset: 0x0122C9A0
		public JigsawIndex PutDownIndex
		{
			get
			{
				return this.PutDownIndexInternal;
			}
			set
			{
				this.PutDownIndexInternal = value;
			}
		}

		// Token: 0x17009E0B RID: 40459
		// (get) Token: 0x06047689 RID: 292489 RVA: 0x0122E7A9 File Offset: 0x0122C9A9
		// (set) Token: 0x0604768A RID: 292490 RVA: 0x0122E7B1 File Offset: 0x0122C9B1
		public SceneItemJigsawBaseComponent PutDownBase
		{
			get
			{
				return this.PutDownBaseInternal;
			}
			set
			{
				this.PutDownBaseInternal = value;
			}
		}

		// Token: 0x17009E0C RID: 40460
		// (get) Token: 0x0604768B RID: 292491 RVA: 0x0122E7BA File Offset: 0x0122C9BA
		// (set) Token: 0x0604768C RID: 292492 RVA: 0x0122E7C2 File Offset: 0x0122C9C2
		public Number Rotation
		{
			get
			{
				return this.SelfRotation;
			}
			set
			{
				this.SelfRotation = value;
			}
		}

		// Token: 0x0604768D RID: 292493 RVA: 0x0122E7CC File Offset: 0x0122C9CC
		[NullableContext(2)]
		protected override bool OnInitData(IEntityArgs args = null)
		{
			JigsawItem config = args.GetP1<CreateEntityData>().GetParam<SceneItemJigsawItemComponent>() as JigsawItem;
			this.Config = config;
			IDirectionFill directionFill = this.Config.FillCfg as IDirectionFill;
			IFixedFill fixedFill = this.Config.FillCfg as IFixedFill;
			EFillType type = this.Config.FillCfg.Type;
			if (type != EFillType.Fixed)
			{
				if (type != EFillType.Direction)
				{
					return true;
				}
			}
			else
			{
				IPieceIndex centre = fixedFill.Centre;
				this.CenterIndex = new JigsawIndex(centre.RowIndex, centre.ColumnIndex);
				using (List<IJigsawPiece>.Enumerator enumerator = fixedFill.Config.Pieces.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						IJigsawPiece jigsawPiece = enumerator.Current;
						if (jigsawPiece.InitState == EJigsawPieceState.Correct)
						{
							this.ActivatedBlock.Add(new JigsawIndex(jigsawPiece.Index.RowIndex, jigsawPiece.Index.ColumnIndex));
						}
					}
					return true;
				}
			}
			if (directionFill.W)
			{
				this.Direction |= 2;
			}
			if (directionFill.S)
			{
				this.Direction |= 4;
			}
			if (directionFill.A)
			{
				this.Direction |= 8;
			}
			if (directionFill.D)
			{
				this.Direction |= 16;
			}
			JigsawIndex jigsawIndex = new JigsawIndex(0, 0);
			this.ActivatedBlock.Add(jigsawIndex);
			this.CenterIndex = jigsawIndex;
			return true;
		}

		// Token: 0x0604768E RID: 292494 RVA: 0x0122E948 File Offset: 0x0122CB48
		protected override bool OnStart()
		{
			this.ActorComp = base.Entity.GetComponent<SceneItemActorComponent>();
			this.CreatureDataComp = base.Entity.GetComponent<CreatureDataComponent>();
			this.MultiActorComp = base.Entity.GetComponent<SceneItemMultiInteractionActorComponent>();
			this.TagComp = base.Entity.GetComponent<LevelTagComponent>();
			LevelTagComponent tagComp = this.TagComp;
			if (tagComp != null)
			{
				tagComp.AddTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.被控物被锁定中"], new BaseTagComponent.TTagSwitchedCallback(this.OnGameplayTagChanged), null);
			}
			LevelTagComponent tagComp2 = this.TagComp;
			if (tagComp2 != null)
			{
				tagComp2.AddTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["关卡.Common.属性.底座中.正确"], new BaseTagComponent.TTagSwitchedCallback(this.OnGameplayTagChanged), null);
			}
			LevelTagComponent tagComp3 = this.TagComp;
			if (tagComp3 != null)
			{
				tagComp3.AddTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["关卡.Common.属性.底座中.错误"], new BaseTagComponent.TTagSwitchedCallback(this.OnGameplayTagChanged), null);
			}
			return true;
		}

		// Token: 0x0604768F RID: 292495 RVA: 0x0122EA24 File Offset: 0x0122CC24
		private void OnGameplayTagChanged(int tagId, bool tagExist)
		{
			int num = GameplayTagDefine.EGameplayTagId["关卡.Common.表现.被控物被锁定中"];
			int num2 = GameplayTagDefine.EGameplayTagId["关卡.Common.属性.底座中.正确"];
			int num3 = GameplayTagDefine.EGameplayTagId["关卡.Common.属性.底座中.错误"];
			bool flag = this.TagComp.HasTag(num2) || this.TagComp.HasTag(num3);
			bool flag2 = this.TagComp.HasTag(num);
			int tags = flag ? GameplayTagDefine.EGameplayTagId["关卡.Common.表现.控物拼图.已匹配锁定"] : GameplayTagDefine.EGameplayTagId["关卡.Common.表现.控物拼图.未匹配锁定"];
			if (tagId == num && tagExist)
			{
				foreach (JigsawIndex index in this.ActivatedBlock)
				{
					this.MultiActorComp.AddTagsByIndex(index, tagId);
					this.MultiActorComp.AddTagsByIndex(index, tags);
				}
			}
			if ((tagId == num2 || tagId == num3) && !tagExist && flag2)
			{
				foreach (JigsawIndex index2 in this.ActivatedBlock)
				{
					this.MultiActorComp.RemoveTagsByIndex(index2, GameplayTagDefine.EGameplayTagId["关卡.Common.表现.控物拼图.已匹配锁定"]);
				}
			}
			if (tagId == num)
			{
				foreach (JigsawIndex index3 in this.ActivatedBlock)
				{
					this.MultiActorComp.RemoveTagsByIndex(index3, tagId);
					this.MultiActorComp.RemoveTagsByIndex(index3, tags);
				}
			}
		}

		// Token: 0x06047690 RID: 292496 RVA: 0x0122EBDC File Offset: 0x0122CDDC
		protected override bool OnEnd()
		{
			LevelTagComponent tagComp = this.TagComp;
			if (tagComp != null)
			{
				tagComp.RemoveTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.被控物被锁定中"], new BaseTagComponent.TTagSwitchedCallback(this.OnGameplayTagChanged));
			}
			LevelTagComponent tagComp2 = this.TagComp;
			if (tagComp2 != null)
			{
				tagComp2.RemoveTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["关卡.Common.属性.底座中.正确"], new BaseTagComponent.TTagSwitchedCallback(this.OnGameplayTagChanged));
			}
			LevelTagComponent tagComp3 = this.TagComp;
			if (tagComp3 != null)
			{
				tagComp3.RemoveTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["关卡.Common.属性.底座中.错误"], new BaseTagComponent.TTagSwitchedCallback(this.OnGameplayTagChanged));
			}
			return true;
		}

		// Token: 0x06047691 RID: 292497 RVA: 0x0122EC6E File Offset: 0x0122CE6E
		protected override void OnActivate()
		{
			this.GenDynamicBlock();
		}

		// Token: 0x06047692 RID: 292498 RVA: 0x0122EC78 File Offset: 0x0122CE78
		private void GenDynamicBlock()
		{
			IFixedFill fixedFill = this.Config.FillCfg as IFixedFill;
			if (fixedFill == null)
			{
				return;
			}
			if (fixedFill.Type == EFillType.Fixed)
			{
				int? modelId = fixedFill.ModelId;
				if (modelId != null && modelId.GetValueOrDefault() != 0)
				{
					List<JigsawIndex> list = new List<JigsawIndex>();
					foreach (JigsawIndex item in this.ActivatedBlock)
					{
						list.Add(item);
					}
					this.MultiActorComp.InitGenerateInfo(fixedFill.ModelId.Value.ToString(), list, (JigsawIndex index) => Vector.Create(this.GetBlockLocationByIndex(index)), null, null);
					return;
				}
				this.MultiActorComp.SetIsFinish(true);
			}
		}

		// Token: 0x06047693 RID: 292499 RVA: 0x0122ED4C File Offset: 0x0122CF4C
		public JigsawIndex GetCenterIndex()
		{
			return this.CenterIndex;
		}

		// Token: 0x06047694 RID: 292500 RVA: 0x0122ED54 File Offset: 0x0122CF54
		public List<JigsawIndex> GetActiveBlockOffset(int? rotation = null)
		{
			List<JigsawIndex> list = new List<JigsawIndex>();
			foreach (JigsawIndex jigsawIndex in this.ActivatedBlock)
			{
				list.Add(this.GetRotatedIndex(new JigsawIndex(jigsawIndex.Row - this.CenterIndex.Row, jigsawIndex.Col - this.CenterIndex.Col), rotation));
			}
			return list;
		}

		// Token: 0x06047695 RID: 292501 RVA: 0x0122EDE0 File Offset: 0x0122CFE0
		public void RotateSelf()
		{
			this.SelfRotation += 90;
		}

		// Token: 0x06047696 RID: 292502 RVA: 0x0122EDFC File Offset: 0x0122CFFC
		private JigsawIndex GetRotatedIndex(JigsawIndex index, int? rotation = null)
		{
			int num = (rotation ?? this.SelfRotation) / 90 % SceneItemJigsawItemComponent.sinValue.Length;
			int row = index.Row * SceneItemJigsawItemComponent.cosValue[num] - index.Col * SceneItemJigsawItemComponent.sinValue[num];
			int col = index.Row * SceneItemJigsawItemComponent.sinValue[num] + index.Col * SceneItemJigsawItemComponent.cosValue[num];
			return new JigsawIndex(row, col);
		}

		// Token: 0x06047697 RID: 292503 RVA: 0x0122EE78 File Offset: 0x0122D078
		[return: Nullable(2)]
		public Vector GetBlockLocationByIndex(JigsawIndex index)
		{
			IFixedFill fixedFill = this.Config.FillCfg as IFixedFill;
			if ((((fixedFill != null) ? new EFillType?(fixedFill.Type) : null) ?? EFillType.Direction) != EFillType.Fixed)
			{
				return this.ActorComp.ActorLocationProxy;
			}
			if (index.Row >= fixedFill.Config.Row || index.Col >= fixedFill.Config.Column)
			{
				return null;
			}
			JigsawIndex centerIndex = this.CenterIndex;
			int num = centerIndex.Row - index.Row;
			int num2 = centerIndex.Col - index.Col;
			int size = fixedFill.Config.Size;
			Vector2D vector2D = Vector2D.Create((double)size, (double)size).MultiplyEqual(Vector2D.Create((double)num, (double)num2));
			FVectorDouble fvectorDouble = new FVectorDouble(vector2D.X, -vector2D.Y, 0.0);
			Vector vector = Vector.Create(0.0, 0.0, 0.0);
			FVectorDouble fvectorDouble2 = this.ActorComp.ActorTransform.TransformPosition(fvectorDouble);
			vector.FromUeVector(fvectorDouble2);
			return vector;
		}

		// Token: 0x06047698 RID: 292504 RVA: 0x0122EFA4 File Offset: 0x0122D1A4
		public void OnPutDownToBase(SceneItemJigsawBaseComponent baseComp)
		{
			this.PutDownBaseInternal = baseComp;
			foreach (JigsawIndex jigsawIndex in this.ActivatedBlock)
			{
				JigsawIndex rotatedIndex = this.GetRotatedIndex(new JigsawIndex(jigsawIndex.Row - this.CenterIndex.Row, jigsawIndex.Col - this.CenterIndex.Col), null);
				rotatedIndex.Row += this.PutDownIndex.Row;
				rotatedIndex.Col += this.PutDownIndex.Col;
				EJigsawSocketState blockStateByIndex = baseComp.GetBlockStateByIndex(rotatedIndex);
				if (blockStateByIndex != EJigsawSocketState.Correct)
				{
					if (blockStateByIndex == EJigsawSocketState.Active)
					{
						this.MultiActorComp.AddTagsByIndex(jigsawIndex, GameplayTagDefine.EGameplayTagId["关卡.Common.表现.拼图.物件.错误位放置"]);
					}
				}
				else
				{
					this.MultiActorComp.AddTagsByIndex(jigsawIndex, GameplayTagDefine.EGameplayTagId["关卡.Common.表现.拼图.物件.正确位放置"]);
				}
			}
		}

		// Token: 0x06047699 RID: 292505 RVA: 0x0122F0B4 File Offset: 0x0122D2B4
		public void OnPickUpFormBase(SceneItemJigsawBaseComponent baseComp)
		{
			this.PutDownBaseInternal = null;
			foreach (JigsawIndex jigsawIndex in this.ActivatedBlock)
			{
				JigsawIndex rotatedIndex = this.GetRotatedIndex(new JigsawIndex(jigsawIndex.Row - this.CenterIndex.Row, jigsawIndex.Col - this.CenterIndex.Col), null);
				rotatedIndex.Row += this.PutDownIndex.Row;
				rotatedIndex.Col += this.PutDownIndex.Col;
				EJigsawSocketState blockStateByIndex = baseComp.GetBlockStateByIndex(rotatedIndex);
				if (blockStateByIndex != EJigsawSocketState.Correct)
				{
					if (blockStateByIndex == EJigsawSocketState.Active)
					{
						this.MultiActorComp.RemoveTagsByIndex(jigsawIndex, GameplayTagDefine.EGameplayTagId["关卡.Common.表现.拼图.物件.错误位放置"]);
					}
				}
				else
				{
					this.MultiActorComp.RemoveTagsByIndex(jigsawIndex, GameplayTagDefine.EGameplayTagId["关卡.Common.表现.拼图.物件.正确位放置"]);
				}
			}
		}

		// Token: 0x0604769A RID: 292506 RVA: 0x0122F1C4 File Offset: 0x0122D3C4
		public void OnFinish()
		{
			foreach (JigsawIndex index in this.ActivatedBlock)
			{
				this.MultiActorComp.AddTagsByIndex(index, GameplayTagDefine.EGameplayTagId["关卡.Common.表现.拼图.物件.完成"]);
			}
		}

		// Token: 0x0604769B RID: 292507 RVA: 0x0122F22C File Offset: 0x0122D42C
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public ValueTuple<bool, Vector, JigsawIndex>? GetNextMoveTargetOnHit(Vector direction)
		{
			SceneItemJigsawBaseComponent putDownBase = this.PutDownBase;
			if (putDownBase == null || !putDownBase.Valid)
			{
				return null;
			}
			JigsawIndex nextPosByDirection = this.PutDownBase.GetNextPosByDirection(this.PutDownIndex, direction, base.Entity);
			return new ValueTuple<bool, Vector, JigsawIndex>?(new ValueTuple<bool, Vector, JigsawIndex>(nextPosByDirection.GetKey() != this.PutDownIndex.GetKey(), this.PutDownBase.GetBlockLocationByIndex(nextPosByDirection, true), nextPosByDirection));
		}

		// Token: 0x0604769C RID: 292508 RVA: 0x0122F2A1 File Offset: 0x0122D4A1
		public void OnMove(JigsawIndex targetIndex)
		{
			this.PutDownBase.OnItemMove(this, targetIndex);
		}

		// Token: 0x0604769D RID: 292509 RVA: 0x0122F2B0 File Offset: 0x0122D4B0
		public void RemoveMagnetTipsTag()
		{
			this.PutDownBase.RemoveMagnetTipsTag(this.PutDownIndex);
		}

		// Token: 0x0604769E RID: 292510 RVA: 0x0122F2C4 File Offset: 0x0122D4C4
		public List<Vector> GetAllActivatedBlockPos()
		{
			List<Vector> list = new List<Vector>();
			foreach (JigsawIndex index in this.ActivatedBlock)
			{
				Vector blockLocationByIndex = this.GetBlockLocationByIndex(index);
				if (blockLocationByIndex != null)
				{
					list.Add(Vector.Create(blockLocationByIndex));
				}
			}
			return list;
		}

		// Token: 0x0604769F RID: 292511 RVA: 0x0122F330 File Offset: 0x0122D530
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemJigsawItemComponent sceneItemJigsawItemComponent = (SceneItemJigsawItemComponent)componentTemplate;
			if (base.CanResetComponentProperty("Config"))
			{
				if (sceneItemJigsawItemComponent.Config == null)
				{
					this.Config = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<JigsawItem>(this.Config), "Config"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CreatureDataComp"))
			{
				if (sceneItemJigsawItemComponent.CreatureDataComp == null)
				{
					this.CreatureDataComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CreatureDataComponent>(this.CreatureDataComp), "CreatureDataComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ActorComp"))
			{
				if (sceneItemJigsawItemComponent.ActorComp == null)
				{
					this.ActorComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemActorComponent>(this.ActorComp), "ActorComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("MultiActorComp"))
			{
				if (sceneItemJigsawItemComponent.MultiActorComp == null)
				{
					this.MultiActorComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemMultiInteractionActorComponent>(this.MultiActorComp), "MultiActorComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TagComp"))
			{
				if (sceneItemJigsawItemComponent.TagComp == null)
				{
					this.TagComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<LevelTagComponent>(this.TagComp), "TagComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("Direction"))
			{
				this.Direction = sceneItemJigsawItemComponent.Direction;
			}
			if (base.CanResetComponentProperty("ActivatedBlock") && sceneItemJigsawItemComponent.ActivatedBlock != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<JigsawIndex>>(this.ActivatedBlock), "ActivatedBlock"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("CenterIndex"))
			{
				if (sceneItemJigsawItemComponent.CenterIndex == null)
				{
					this.CenterIndex = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<JigsawIndex>(this.CenterIndex), "CenterIndex"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("PutDownIndexInternal"))
			{
				if (sceneItemJigsawItemComponent.PutDownIndexInternal == null)
				{
					this.PutDownIndexInternal = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<JigsawIndex>(this.PutDownIndexInternal), "PutDownIndexInternal"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("PutDownBaseInternal"))
			{
				if (sceneItemJigsawItemComponent.PutDownBaseInternal == null)
				{
					this.PutDownBaseInternal = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemJigsawBaseComponent>(this.PutDownBaseInternal), "PutDownBaseInternal"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("SelfRotation"))
			{
				this.SelfRotation = sceneItemJigsawItemComponent.SelfRotation;
			}
			return true;
		}

		// Token: 0x060476A1 RID: 292513 RVA: 0x0122F590 File Offset: 0x0122D790
		// Note: this type is marked as 'beforefieldinit'.
		static SceneItemJigsawItemComponent()
		{
			int[] array = new int[4];
			array[0] = 1;
			array[2] = -1;
			SceneItemJigsawItemComponent.cosValue = array;
		}

		// Token: 0x040258ED RID: 153837
		[StaticVariableRuleIgnore]
		private static readonly int[] sinValue = new int[]
		{
			0,
			1,
			0,
			-1
		};

		// Token: 0x040258EE RID: 153838
		[StaticVariableRuleIgnore]
		private static readonly int[] cosValue;

		// Token: 0x040258EF RID: 153839
		[Nullable(2)]
		public JigsawItem Config;

		// Token: 0x040258F0 RID: 153840
		[Nullable(2)]
		public CreatureDataComponent CreatureDataComp;

		// Token: 0x040258F1 RID: 153841
		[Nullable(2)]
		private SceneItemActorComponent ActorComp;

		// Token: 0x040258F2 RID: 153842
		[Nullable(2)]
		private SceneItemMultiInteractionActorComponent MultiActorComp;

		// Token: 0x040258F3 RID: 153843
		[Nullable(2)]
		private LevelTagComponent TagComp;

		// Token: 0x040258F4 RID: 153844
		public int Direction;

		// Token: 0x040258F5 RID: 153845
		private readonly List<JigsawIndex> ActivatedBlock = new List<JigsawIndex>();

		// Token: 0x040258F6 RID: 153846
		[Nullable(2)]
		private JigsawIndex CenterIndex;

		// Token: 0x040258F7 RID: 153847
		[Nullable(2)]
		private JigsawIndex PutDownIndexInternal;

		// Token: 0x040258F8 RID: 153848
		[Nullable(2)]
		private SceneItemJigsawBaseComponent PutDownBaseInternal;

		// Token: 0x040258F9 RID: 153849
		private Number SelfRotation = 0;
	}
}
