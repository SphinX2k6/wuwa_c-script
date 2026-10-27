using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x0200640E RID: 25614
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MotorFightDetailAttrItem : GridProxyAbstract<MotorFightDetailAttrDetailData>
	{
		// Token: 0x060406DB RID: 263899 RVA: 0x00F95C48 File Offset: 0x00F93E48
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060406DC RID: 263900 RVA: 0x00F95D94 File Offset: 0x00F93F94
		protected override void OnStart()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			extendToggle.CanExecuteChange.Unbind();
			extendToggle.CanExecuteChange.Bind(new Func<bool>(this.CanClickToggle));
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			base.GetItem(5).SetUIActive(false);
		}

		// Token: 0x060406DD RID: 263901 RVA: 0x00F95DE8 File Offset: 0x00F93FE8
		[NullableContext(1)]
		public override void Refresh(MotorFightDetailAttrDetailData data, bool isSelected, int gridIndex)
		{
			this.Config = data.Config;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), data.Config.Name, Array.Empty<object>());
			UUISprite sprite = base.GetSprite(4);
			if (sprite != null)
			{
				sprite.SetUIActive(data.Config.Desc.Length > 0);
			}
			if (!StringUtils.IsEmpty(data.Config.Desc))
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(6), data.Config.Desc, Array.Empty<object>());
			}
			UUISprite sprite2 = base.GetSprite(1);
			UUIItem uuiitem = sprite2;
			bool bUseChangeColor = gridIndex % 2 != 0;
			FColor? fcolor = new FColor?(sprite2.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			EMotorFightAttrShowType type = data.Type;
			AKSC_Entity aksc_Entity;
			if (type == EMotorFightAttrShowType.Wingman)
			{
				aksc_Entity = (KuroSimpleCombatController.Instance.CurSubModel as MotorcycleArrowSubModel).MotorcycleKscEntity;
			}
			else
			{
				KscSubModelBase curSubModel = KuroSimpleCombatController.Instance.CurSubModel;
				aksc_Entity = ((curSubModel != null) ? curSubModel.KscPlayerEntity : null);
			}
			if (aksc_Entity == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MotorFightActivity;
				ELogAuthor author = ELogAuthor.CXJ;
				string message = "实体不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("type", type);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			UKSC_SkillComp skillComp = aksc_Entity.GetSkillComp();
			TMap<EKSC_AttrType, int> tmap;
			if (skillComp == null)
			{
				tmap = null;
			}
			else
			{
				UKSC_AttrSet attrSet_ = skillComp.AttrSet_;
				tmap = ((attrSet_ != null) ? attrSet_.Attrs_ : null);
			}
			TMap<EKSC_AttrType, int> tmap2 = tmap;
			if (tmap2 == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.MotorFightActivity;
				ELogAuthor author2 = ELogAuthor.CXJ;
				string message2 = "实体属性不存在";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("type", type);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			int num;
			tmap2.TryGetValue((EKSC_AttrType)this.Config.AttriId, out num);
			float value = (float)(num * this.Config.Ratio) * 0.0001f;
			string value2 = this.Config.IsNeedPercentSign ? "%" : "";
			UUIText text = base.GetText(3);
			if (text == null)
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
			defaultInterpolatedStringHandler.AppendFormatted<float>(value);
			defaultInterpolatedStringHandler.AppendFormatted(value2);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x060406DE RID: 263902 RVA: 0x00F95FE8 File Offset: 0x00F941E8
		protected override void OnBeforeDestroy()
		{
			if (this.LevelSequencePlayer != null)
			{
				this.LevelSequencePlayer.Clear();
				this.LevelSequencePlayer = null;
			}
		}

		// Token: 0x060406DF RID: 263903 RVA: 0x00F96004 File Offset: 0x00F94204
		private bool CanClickToggle()
		{
			return !StringUtils.IsEmpty(this.Config.Desc);
		}

		// Token: 0x060406E0 RID: 263904 RVA: 0x00F9601C File Offset: 0x00F9421C
		protected void OnToggleClick(EToggleState bState)
		{
			bool flag = bState == EToggleState.ETT_Checked;
			base.GetItem(5).SetUIActive(flag);
			string sequenceName = flag ? "Show" : "Hide";
			if (this.LevelSequencePlayer != null)
			{
				this.LevelSequencePlayer.StopCurrentSequence(false, false);
				this.LevelSequencePlayer.PlayLevelSequenceByName(sequenceName, false, null, false);
			}
		}

		// Token: 0x04021802 RID: 137218
		private MotorFightAttrShow Config;

		// Token: 0x04021803 RID: 137219
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200C630 RID: 50736
		private class EComponent
		{
			// Token: 0x0403BD55 RID: 245077
			public const int ToggleBase = 0;

			// Token: 0x0403BD56 RID: 245078
			public const int SpriteBg = 1;

			// Token: 0x0403BD57 RID: 245079
			public const int TextAttrName = 2;

			// Token: 0x0403BD58 RID: 245080
			public const int TextValue = 3;

			// Token: 0x0403BD59 RID: 245081
			public const int SpriteArrow = 4;

			// Token: 0x0403BD5A RID: 245082
			public const int ItemDescPanel = 5;

			// Token: 0x0403BD5B RID: 245083
			public const int TextDesc = 6;
		}
	}
}
