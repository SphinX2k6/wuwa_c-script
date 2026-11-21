using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x0200538C RID: 21388
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MotorFightDetailAttrItem : GridProxyAbstract<MotorFightDetailAttrDetailData>
	{
		// Token: 0x0603539C RID: 218012 RVA: 0x00EDCBE8 File Offset: 0x00EDADE8
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

		// Token: 0x0603539D RID: 218013 RVA: 0x00EDCD34 File Offset: 0x00EDAF34
		protected override void OnStart()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			extendToggle.CanExecuteChange.Unbind();
			extendToggle.CanExecuteChange.Bind(new Func<bool>(this.CanClickToggle));
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			base.GetItem(5).SetUIActive(false);
		}

		// Token: 0x0603539E RID: 218014 RVA: 0x00EDCD88 File Offset: 0x00EDAF88
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

		// Token: 0x0603539F RID: 218015 RVA: 0x00EDCF88 File Offset: 0x00EDB188
		protected override void OnBeforeDestroy()
		{
			if (this.LevelSequencePlayer != null)
			{
				this.LevelSequencePlayer.Clear();
				this.LevelSequencePlayer = null;
			}
		}

		// Token: 0x060353A0 RID: 218016 RVA: 0x00EDCFA4 File Offset: 0x00EDB1A4
		private bool CanClickToggle()
		{
			return !StringUtils.IsEmpty(this.Config.Desc);
		}

		// Token: 0x060353A1 RID: 218017 RVA: 0x00EDCFBC File Offset: 0x00EDB1BC
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

		// Token: 0x0401C131 RID: 114993
		private MotorFightAttrShow Config;

		// Token: 0x0401C132 RID: 114994
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200B017 RID: 45079
		private class EComponent
		{
			// Token: 0x040366B2 RID: 222898
			public const int ToggleBase = 0;

			// Token: 0x040366B3 RID: 222899
			public const int SpriteBg = 1;

			// Token: 0x040366B4 RID: 222900
			public const int TextAttrName = 2;

			// Token: 0x040366B5 RID: 222901
			public const int TextValue = 3;

			// Token: 0x040366B6 RID: 222902
			public const int SpriteArrow = 4;

			// Token: 0x040366B7 RID: 222903
			public const int ItemDescPanel = 5;

			// Token: 0x040366B8 RID: 222904
			public const int TextDesc = 6;
		}
	}
}
