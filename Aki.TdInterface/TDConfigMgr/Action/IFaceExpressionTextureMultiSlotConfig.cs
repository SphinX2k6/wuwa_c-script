using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BD2 RID: 7122
	public class IFaceExpressionTextureMultiSlotConfig : IFaceExpressionConfig
	{
		// Token: 0x06009738 RID: 38712 RVA: 0x0015F814 File Offset: 0x0015DA14
		private IFaceExpressionTextureMultiSlotConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFaceExpressionTextureMultiSlotConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFaceExpressionTextureMultiSlotConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFaceExpressionTextureMultiSlotConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06009739 RID: 38713 RVA: 0x0015F84C File Offset: 0x0015DA4C
		public static IFaceExpressionTextureMultiSlotConfig Create([Nullable(2)] IFaceExpressionTextureMultiSlotConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFaceExpressionTextureMultiSlotConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600973A RID: 38714 RVA: 0x0015F85F File Offset: 0x0015DA5F
		public static IFaceExpressionTextureMultiSlotConfig CreateFromSetValue([Nullable(2)] IFaceExpressionTextureMultiSlotConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFaceExpressionTextureMultiSlotConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600973B RID: 38715 RVA: 0x0015F872 File Offset: 0x0015DA72
		public new IFaceExpressionTextureMultiSlotConfig_SetValue ToSetValue()
		{
			return new IFaceExpressionTextureMultiSlotConfig_SetValue
			{
				Type = this.Type,
				SlotIndex = this.SlotIndex,
				FaceIndex = this.FaceIndex
			};
		}

		// Token: 0x17002FEE RID: 12270
		// (get) Token: 0x0600973C RID: 38716 RVA: 0x0015F89D File Offset: 0x0015DA9D
		// (set) Token: 0x0600973D RID: 38717 RVA: 0x0015F8C8 File Offset: 0x0015DAC8
		public override EFaceExpressionConfigType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EFaceExpressionConfigType.Morph;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002FEF RID: 12271
		// (get) Token: 0x0600973E RID: 38718 RVA: 0x0015F8D6 File Offset: 0x0015DAD6
		// (set) Token: 0x0600973F RID: 38719 RVA: 0x0015F901 File Offset: 0x0015DB01
		public virtual int SlotIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SlotIndex;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SlotIndex;
			}
			set
			{
				this.GetOrCreatePoco().SlotIndex = value;
			}
		}

		// Token: 0x17002FF0 RID: 12272
		// (get) Token: 0x06009740 RID: 38720 RVA: 0x0015F90F File Offset: 0x0015DB0F
		// (set) Token: 0x06009741 RID: 38721 RVA: 0x0015F93A File Offset: 0x0015DB3A
		public virtual int FaceIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FaceIndex;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.FaceIndex;
			}
			set
			{
				this.GetOrCreatePoco().FaceIndex = value;
			}
		}

		// Token: 0x04005D4B RID: 23883
		[Nullable(2)]
		protected new IFaceExpressionTextureMultiSlotConfig FbInstance;

		// Token: 0x04005D4C RID: 23884
		[Nullable(2)]
		protected new IFaceExpressionTextureMultiSlotConfig_SetValue PocoInterface;
	}
}
