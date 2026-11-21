using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.NewWorld.Common.Component;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Jigsaw
{
	// Token: 0x020062A9 RID: 25257
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemJigsawItemComponent : EntityComponent
	{
		// Token: 0x17007364 RID: 29540
		// (get) Token: 0x0603CF8C RID: 249740 RVA: 0x011883E0 File Offset: 0x011865E0
		// (set) Token: 0x0603CF8D RID: 249741 RVA: 0x011883E8 File Offset: 0x011865E8
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

		// Token: 0x17007365 RID: 29541
		// (get) Token: 0x0603CF8E RID: 249742 RVA: 0x011883F1 File Offset: 0x011865F1
		// (set) Token: 0x0603CF8F RID: 249743 RVA: 0x011883F9 File Offset: 0x011865F9
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

		// Token: 0x17007366 RID: 29542
		// (get) Token: 0x0603CF90 RID: 249744 RVA: 0x01188402 File Offset: 0x01186602
		// (set) Token: 0x0603CF91 RID: 249745 RVA: 0x0118840A File Offset: 0x0118660A
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

		// Token: 0x0603CF92 RID: 249746 RVA: 0x01188414 File Offset: 0x01186614
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

		// Token: 0x0603CF93 RID: 249747 RVA: 0x01188590 File Offset: 0x01186790
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

		// Token: 0x0603CF94 RID: 249748 RVA: 0x0118866C File Offset: 0x0118686C
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

		// Token: 0x0603CF95 RID: 249749 RVA: 0x01188824 File Offset: 0x01186A24
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

		// Token: 0x0603CF96 RID: 249750 RVA: 0x011888B6 File Offset: 0x01186AB6
		protected override void OnActivate()
		{
			this.GenDynamicBlock();
		}

		// Token: 0x0603CF97 RID: 249751 RVA: 0x011888C0 File Offset: 0x01186AC0
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

		// Token: 0x0603CF98 RID: 249752 RVA: 0x01188994 File Offset: 0x01186B94
		public JigsawIndex GetCenterIndex()
		{
			return this.CenterIndex;
		}

		// Token: 0x0603CF99 RID: 249753 RVA: 0x0118899C File Offset: 0x01186B9C
		public List<JigsawIndex> GetActiveBlockOffset(int? rotation = null)
		{
			List<JigsawIndex> list = new List<JigsawIndex>();
			foreach (JigsawIndex jigsawIndex in this.ActivatedBlock)
			{
				list.Add(this.GetRotatedIndex(new JigsawIndex(jigsawIndex.Row - this.CenterIndex.Row, jigsawIndex.Col - this.CenterIndex.Col), rotation));
			}
			return list;
		}

		// Token: 0x0603CF9A RID: 249754 RVA: 0x01188A28 File Offset: 0x01186C28
		public void RotateSelf()
		{
			this.SelfRotation += 90;
		}

		// Token: 0x0603CF9B RID: 249755 RVA: 0x01188A44 File Offset: 0x01186C44
		private JigsawIndex GetRotatedIndex(JigsawIndex index, int? rotation = null)
		{
			int num = (rotation ?? this.SelfRotation) / 90 % SceneItemJigsawItemComponent.sinValue.Length;
			int row = index.Row * SceneItemJigsawItemComponent.cosValue[num] - index.Col * SceneItemJigsawItemComponent.sinValue[num];
			int col = index.Row * SceneItemJigsawItemComponent.sinValue[num] + index.Col * SceneItemJigsawItemComponent.cosValue[num];
			return new JigsawIndex(row, col);
		}

		// Token: 0x0603CF9C RID: 249756 RVA: 0x01188AC0 File Offset: 0x01186CC0
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

		// Token: 0x0603CF9D RID: 249757 RVA: 0x01188BEC File Offset: 0x01186DEC
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

		// Token: 0x0603CF9E RID: 249758 RVA: 0x01188CFC File Offset: 0x01186EFC
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

		// Token: 0x0603CF9F RID: 249759 RVA: 0x01188E0C File Offset: 0x0118700C
		public void OnFinish()
		{
			foreach (JigsawIndex index in this.ActivatedBlock)
			{
				this.MultiActorComp.AddTagsByIndex(index, GameplayTagDefine.EGameplayTagId["关卡.Common.表现.拼图.物件.完成"]);
			}
		}

		// Token: 0x0603CFA0 RID: 249760 RVA: 0x01188E74 File Offset: 0x01187074
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

		// Token: 0x0603CFA1 RID: 249761 RVA: 0x01188EE9 File Offset: 0x011870E9
		public void OnMove(JigsawIndex targetIndex)
		{
			this.PutDownBase.OnItemMove(this, targetIndex);
		}

		// Token: 0x0603CFA2 RID: 249762 RVA: 0x01188EF8 File Offset: 0x011870F8
		public void RemoveMagnetTipsTag()
		{
			this.PutDownBase.RemoveMagnetTipsTag(this.PutDownIndex);
		}

		// Token: 0x0603CFA3 RID: 249763 RVA: 0x01188F0C File Offset: 0x0118710C
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

		// Token: 0x0603CFA4 RID: 249764 RVA: 0x01188F78 File Offset: 0x01187178
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemJigsawItemComponent sceneItemJigsawItemComponent = (SceneItemJigsawItemComponent)componentTemplate;
			if (sceneItemJigsawItemComponent.Config == null)
			{
				this.Config = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.Config), "Config"))
			{
				return false;
			}
			if (sceneItemJigsawItemComponent.CreatureDataComp == null)
			{
				this.CreatureDataComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureDataComp), "CreatureDataComp"))
			{
				return false;
			}
			if (sceneItemJigsawItemComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			if (sceneItemJigsawItemComponent.MultiActorComp == null)
			{
				this.MultiActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MultiActorComp), "MultiActorComp"))
			{
				return false;
			}
			if (sceneItemJigsawItemComponent.TagComp == null)
			{
				this.TagComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComp), "TagComp"))
			{
				return false;
			}
			this.Direction = sceneItemJigsawItemComponent.Direction;
			if (sceneItemJigsawItemComponent.ActivatedBlock != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActivatedBlock), "ActivatedBlock"))
			{
				return false;
			}
			if (sceneItemJigsawItemComponent.CenterIndex == null)
			{
				this.CenterIndex = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CenterIndex), "CenterIndex"))
			{
				return false;
			}
			if (sceneItemJigsawItemComponent.PutDownIndexInternal == null)
			{
				this.PutDownIndexInternal = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.PutDownIndexInternal), "PutDownIndexInternal"))
			{
				return false;
			}
			if (sceneItemJigsawItemComponent.PutDownBaseInternal == null)
			{
				this.PutDownBaseInternal = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.PutDownBaseInternal), "PutDownBaseInternal"))
			{
				return false;
			}
			this.SelfRotation = sceneItemJigsawItemComponent.SelfRotation;
			return true;
		}

		// Token: 0x17007367 RID: 29543
		// (get) Token: 0x0603CFA5 RID: 249765 RVA: 0x0118912A File Offset: 0x0118732A
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007368 RID: 29544
		// (get) Token: 0x0603CFA6 RID: 249766 RVA: 0x0118912D File Offset: 0x0118732D
		public override bool NeedActivateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007369 RID: 29545
		// (get) Token: 0x0603CFA7 RID: 249767 RVA: 0x01189130 File Offset: 0x01187330
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0603CFA9 RID: 249769 RVA: 0x01189152 File Offset: 0x01187352
		// Note: this type is marked as 'beforefieldinit'.
		static SceneItemJigsawItemComponent()
		{
			int[] array = new int[4];
			array[0] = 1;
			array[2] = -1;
			SceneItemJigsawItemComponent.cosValue = array;
		}

		// Token: 0x0402055C RID: 132444
		[StaticVariableRuleIgnore]
		private static readonly int[] sinValue = new int[]
		{
			0,
			1,
			0,
			-1
		};

		// Token: 0x0402055D RID: 132445
		[StaticVariableRuleIgnore]
		private static readonly int[] cosValue;

		// Token: 0x0402055E RID: 132446
		[Nullable(2)]
		public JigsawItem Config;

		// Token: 0x0402055F RID: 132447
		[Nullable(2)]
		public CreatureDataComponent CreatureDataComp;

		// Token: 0x04020560 RID: 132448
		[Nullable(2)]
		private SceneItemActorComponent ActorComp;

		// Token: 0x04020561 RID: 132449
		[Nullable(2)]
		private SceneItemMultiInteractionActorComponent MultiActorComp;

		// Token: 0x04020562 RID: 132450
		[Nullable(2)]
		private LevelTagComponent TagComp;

		// Token: 0x04020563 RID: 132451
		public int Direction;

		// Token: 0x04020564 RID: 132452
		private readonly List<JigsawIndex> ActivatedBlock = new List<JigsawIndex>();

		// Token: 0x04020565 RID: 132453
		[Nullable(2)]
		private JigsawIndex CenterIndex;

		// Token: 0x04020566 RID: 132454
		[Nullable(2)]
		private JigsawIndex PutDownIndexInternal;

		// Token: 0x04020567 RID: 132455
		[Nullable(2)]
		private SceneItemJigsawBaseComponent PutDownBaseInternal;

		// Token: 0x04020568 RID: 132456
		private Number SelfRotation = 0;
	}
}
