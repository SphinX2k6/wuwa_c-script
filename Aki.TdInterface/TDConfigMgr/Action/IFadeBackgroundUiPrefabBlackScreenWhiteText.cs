using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BEC RID: 7148
	[NullableContext(2)]
	[Nullable(0)]
	[JsonConverter(typeof(IFadeBackgroundUiPrefabBlackScreenWhiteTextConverter))]
	public class IFadeBackgroundUiPrefabBlackScreenWhiteText : IFadeBackgroundUiPrefabType
	{
		// Token: 0x060097C2 RID: 38850 RVA: 0x0016079C File Offset: 0x0015E99C
		[NullableContext(0)]
		private IFadeBackgroundUiPrefabBlackScreenWhiteText_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFadeBackgroundUiPrefabBlackScreenWhiteText 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFadeBackgroundUiPrefabBlackScreenWhiteText_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFadeBackgroundUiPrefabBlackScreenWhiteText_SetValue());
			}
			return result;
		}

		// Token: 0x060097C3 RID: 38851 RVA: 0x001607D4 File Offset: 0x0015E9D4
		[NullableContext(0)]
		public static IFadeBackgroundUiPrefabBlackScreenWhiteText Create([Nullable(2)] IFadeBackgroundUiPrefabBlackScreenWhiteText instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFadeBackgroundUiPrefabBlackScreenWhiteText
			{
				FbInstance = instance
			};
		}

		// Token: 0x060097C4 RID: 38852 RVA: 0x001607E7 File Offset: 0x0015E9E7
		[NullableContext(0)]
		public static IFadeBackgroundUiPrefabBlackScreenWhiteText CreateFromSetValue([Nullable(2)] IFadeBackgroundUiPrefabBlackScreenWhiteText_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFadeBackgroundUiPrefabBlackScreenWhiteText
			{
				PocoInterface = value
			};
		}

		// Token: 0x060097C5 RID: 38853 RVA: 0x001607FA File Offset: 0x0015E9FA
		[NullableContext(0)]
		public new IFadeBackgroundUiPrefabBlackScreenWhiteText_SetValue ToSetValue()
		{
			return new IFadeBackgroundUiPrefabBlackScreenWhiteText_SetValue
			{
				Type = this.Type,
				StartAnimName = this.StartAnimName,
				Text = this.Text,
				AudioEvent = this.AudioEvent
			};
		}

		// Token: 0x1700300C RID: 12300
		// (get) Token: 0x060097C6 RID: 38854 RVA: 0x00160831 File Offset: 0x0015EA31
		// (set) Token: 0x060097C7 RID: 38855 RVA: 0x0016085C File Offset: 0x0015EA5C
		public override EFadeBackgroundUiPrefabType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EFadeBackgroundUiPrefabType.BlackScreenWhiteText;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700300D RID: 12301
		// (get) Token: 0x060097C8 RID: 38856 RVA: 0x0016086A File Offset: 0x0015EA6A
		// (set) Token: 0x060097C9 RID: 38857 RVA: 0x00160895 File Offset: 0x0015EA95
		public virtual EBlackScreenWhiteTextStartAnimName StartAnimName
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StartAnimName;
				}
				if (this.PocoInterface == null)
				{
					return EBlackScreenWhiteTextStartAnimName.Start01;
				}
				return this.PocoInterface.StartAnimName;
			}
			set
			{
				this.GetOrCreatePoco().StartAnimName = value;
			}
		}

		// Token: 0x1700300E RID: 12302
		// (get) Token: 0x060097CA RID: 38858 RVA: 0x001608A3 File Offset: 0x0015EAA3
		// (set) Token: 0x060097CB RID: 38859 RVA: 0x001608CA File Offset: 0x0015EACA
		public virtual string Text
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Text;
				}
				IFadeBackgroundUiPrefabBlackScreenWhiteText_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Text;
			}
			set
			{
				this.GetOrCreatePoco().Text = value;
			}
		}

		// Token: 0x1700300F RID: 12303
		// (get) Token: 0x060097CC RID: 38860 RVA: 0x001608D8 File Offset: 0x0015EAD8
		// (set) Token: 0x060097CD RID: 38861 RVA: 0x001608FF File Offset: 0x0015EAFF
		public virtual string AudioEvent
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AudioEvent;
				}
				IFadeBackgroundUiPrefabBlackScreenWhiteText_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AudioEvent;
			}
			set
			{
				this.GetOrCreatePoco().AudioEvent = value;
			}
		}

		// Token: 0x04005D8D RID: 23949
		protected new IFadeBackgroundUiPrefabBlackScreenWhiteText FbInstance;

		// Token: 0x04005D8E RID: 23950
		protected new IFadeBackgroundUiPrefabBlackScreenWhiteText_SetValue PocoInterface;
	}
}
