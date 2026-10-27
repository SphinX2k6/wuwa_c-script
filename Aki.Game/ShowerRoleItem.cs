using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002A04 RID: 10756
[NullableContext(2)]
[Nullable(0)]
public class ShowerRoleItem : UiPanelBase
{
	// Token: 0x06016517 RID: 91415 RVA: 0x005A5E48 File Offset: 0x005A4048
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

	// Token: 0x06016518 RID: 91416 RVA: 0x005A5EF4 File Offset: 0x005A40F4
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

	// Token: 0x06016519 RID: 91417 RVA: 0x005A600C File Offset: 0x005A420C
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

	// Token: 0x0601651A RID: 91418 RVA: 0x005A605A File Offset: 0x005A425A
	[NullableContext(1)]
	public void BindPosChangeCallback(Action<int> callback)
	{
		this.PosChangeCallback = callback;
	}

	// Token: 0x0601651B RID: 91419 RVA: 0x005A6063 File Offset: 0x005A4263
	private void OnClickToggle(EToggleState toggleState)
	{
		if (this.PosChangeCallback != null)
		{
			this.PosChangeCallback(this.PosIndex);
		}
	}

	// Token: 0x0400A5FD RID: 42493
	private int PosIndex = -1;

	// Token: 0x0400A5FE RID: 42494
	private Action<int> PosChangeCallback;

	// Token: 0x0200903F RID: 36927
	[NullableContext(0)]
	private class EShowerRoleItemDefine
	{
		// Token: 0x0402EB4D RID: 191309
		public const int Toggle = 0;

		// Token: 0x0402EB4E RID: 191310
		public const int EmptyTexture = 1;

		// Token: 0x0402EB4F RID: 191311
		public const int RoleIconTexture = 2;

		// Token: 0x0402EB50 RID: 191312
		public const int BathNumPanel = 3;

		// Token: 0x0402EB51 RID: 191313
		public const int BathNumText = 4;
	}
}
