using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A3D RID: 6717
	[NullableContext(1)]
	[Nullable(0)]
	public class IFaceExpressionTextureMultiSlotConfig : IFaceExpressionConfig
	{
		// Token: 0x06008FCE RID: 36814 RVA: 0x0014F8E8 File Offset: 0x0014DAE8
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

		// Token: 0x06008FCF RID: 36815 RVA: 0x0014F920 File Offset: 0x0014DB20
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

		// Token: 0x06008FD0 RID: 36816 RVA: 0x0014F933 File Offset: 0x0014DB33
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

		// Token: 0x06008FD1 RID: 36817 RVA: 0x0014F946 File Offset: 0x0014DB46
		public new IFaceExpressionTextureMultiSlotConfig_SetValue ToSetValue()
		{
			return new IFaceExpressionTextureMultiSlotConfig_SetValue
			{
				Type = this.Type,
				SlotIndex = this.SlotIndex,
				FaceIndex = this.FaceIndex
			};
		}

		// Token: 0x17002DE1 RID: 11745
		// (get) Token: 0x06008FD2 RID: 36818 RVA: 0x0014F971 File Offset: 0x0014DB71
		// (set) Token: 0x06008FD3 RID: 36819 RVA: 0x0014F99C File Offset: 0x0014DB9C
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

		// Token: 0x17002DE2 RID: 11746
		// (get) Token: 0x06008FD4 RID: 36820 RVA: 0x0014F9AA File Offset: 0x0014DBAA
		// (set) Token: 0x06008FD5 RID: 36821 RVA: 0x0014F9D5 File Offset: 0x0014DBD5
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

		// Token: 0x17002DE3 RID: 11747
		// (get) Token: 0x06008FD6 RID: 36822 RVA: 0x0014F9E3 File Offset: 0x0014DBE3
		// (set) Token: 0x06008FD7 RID: 36823 RVA: 0x0014FA0E File Offset: 0x0014DC0E
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

		// Token: 0x040058E6 RID: 22758
		[Nullable(2)]
		protected new IFaceExpressionTextureMultiSlotConfig FbInstance;

		// Token: 0x040058E7 RID: 22759
		[Nullable(2)]
		protected new IFaceExpressionTextureMultiSlotConfig_SetValue PocoInterface;
	}
}
