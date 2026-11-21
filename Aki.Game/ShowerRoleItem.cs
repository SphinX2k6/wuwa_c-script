using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001F7F RID: 8063
[NullableContext(2)]
[Nullable(0)]
public class ShowerRoleItem : UiPanelBase
{
	// Token: 0x06013F1E RID: 81694 RVA: 0x005D0E20 File Offset: 0x005CF020
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle))
		};
	}

	// Token: 0x06013F1F RID: 81695 RVA: 0x005D0ECC File Offset: 0x005CF0CC
	public void RefreshRoleInfo(int curSelectPosIndex, RoleInstance roleInstance)
	{
		if (this.PosIndex < 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Shower;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "位置信息错误";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("pos", this.PosIndex);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		bool flag = roleInstance != null;
		UUITexture texture = base.GetTexture(1);
		if (texture != null)
		{
			texture.SetUIActive(!flag);
		}
		UUITexture texture2 = base.GetTexture(2);
		if (texture2 != null)
		{
			texture2.SetUIActive(false);
		}
		if (flag)
		{
			int roleSkinId = roleInstance.GetRoleSkinId();
			string roleHeadIconCircle = SkinConfig.Instance.GetRoleSkinConfig(roleSkinId).Value.RoleHeadIconCircle;
			base.SetRoleSkinIcon(roleHeadIconCircle, base.GetTexture(2), roleSkinId, null, delegate(bool _)
			{
				UUITexture texture3 = base.GetTexture(2);
				if (texture3 == null)
				{
					return;
				}
				texture3.SetUIActive(true);
			});
		}
		UUIText text = base.GetText(4);
		if (text != null)
		{
			text.SetText((this.PosIndex + 1).ToString(), true);
		}
		if (this.PosIndex == curSelectPosIndex)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
			return;
		}
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06013F20 RID: 81696 RVA: 0x005D0FE4 File Offset: 0x005CF1E4
	public bool SetPos(int posIndex, WorldEntity entity)
	{
		if (entity == null)
		{
			return false;
		}
		this.PosIndex = posIndex;
		FVectorDouble actorLocation = entity.GetComponent<BaseActorComponent>().ActorLocation;
		Vector2D vector2D = new Vector2D();
		if (HudUnitUtils.PositionUtil.ProjectWorldToScreen(actorLocation, vector2D))
		{
			this.RootItem.SetAnchorOffset(vector2D.ToUeVector2D(false));
			return true;
		}
		return false;
	}

	// Token: 0x06013F21 RID: 81697 RVA: 0x005D1032 File Offset: 0x005CF232
	[NullableContext(1)]
	public void BindPosChangeCallback(Action<int> callback)
	{
		this.PosChangeCallback = callback;
	}

	// Token: 0x06013F22 RID: 81698 RVA: 0x005D103B File Offset: 0x005CF23B
	private void OnClickToggle(EToggleState toggleState)
	{
		if (this.PosChangeCallback != null)
		{
			this.PosChangeCallback(this.PosIndex);
		}
	}

	// Token: 0x0400A9E7 RID: 43495
	private int PosIndex = -1;

	// Token: 0x0400A9E8 RID: 43496
	private Action<int> PosChangeCallback;

	// Token: 0x02008286 RID: 33414
	[NullableContext(0)]
	private class EShowerRoleItemDefine
	{
		// Token: 0x0402A245 RID: 172613
		public const int Toggle = 0;

		// Token: 0x0402A246 RID: 172614
		public const int EmptyTexture = 1;

		// Token: 0x0402A247 RID: 172615
		public const int RoleIconTexture = 2;

		// Token: 0x0402A248 RID: 172616
		public const int BathNumPanel = 3;

		// Token: 0x0402A249 RID: 172617
		public const int BathNumText = 4;
	}
}
