using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A57 RID: 6743
	[NullableContext(2)]
	[Nullable(0)]
	[JsonConverter(typeof(IFadeBackgroundUiPrefabBlackScreenWhiteTextConverter))]
	public class IFadeBackgroundUiPrefabBlackScreenWhiteText : IFadeBackgroundUiPrefabType
	{
		// Token: 0x06009058 RID: 36952 RVA: 0x00150870 File Offset: 0x0014EA70
		[NullableContext(1)]
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

		// Token: 0x06009059 RID: 36953 RVA: 0x001508A8 File Offset: 0x0014EAA8
		[NullableContext(1)]
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

		// Token: 0x0600905A RID: 36954 RVA: 0x001508BB File Offset: 0x0014EABB
		[NullableContext(1)]
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

		// Token: 0x0600905B RID: 36955 RVA: 0x001508CE File Offset: 0x0014EACE
		[NullableContext(1)]
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

		// Token: 0x17002DFF RID: 11775
		// (get) Token: 0x0600905C RID: 36956 RVA: 0x00150905 File Offset: 0x0014EB05
		// (set) Token: 0x0600905D RID: 36957 RVA: 0x00150930 File Offset: 0x0014EB30
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

		// Token: 0x17002E00 RID: 11776
		// (get) Token: 0x0600905E RID: 36958 RVA: 0x0015093E File Offset: 0x0014EB3E
		// (set) Token: 0x0600905F RID: 36959 RVA: 0x00150969 File Offset: 0x0014EB69
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

		// Token: 0x17002E01 RID: 11777
		// (get) Token: 0x06009060 RID: 36960 RVA: 0x00150977 File Offset: 0x0014EB77
		// (set) Token: 0x06009061 RID: 36961 RVA: 0x0015099E File Offset: 0x0014EB9E
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

		// Token: 0x17002E02 RID: 11778
		// (get) Token: 0x06009062 RID: 36962 RVA: 0x001509AC File Offset: 0x0014EBAC
		// (set) Token: 0x06009063 RID: 36963 RVA: 0x001509D3 File Offset: 0x0014EBD3
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

		// Token: 0x04005928 RID: 22824
		protected new IFadeBackgroundUiPrefabBlackScreenWhiteText FbInstance;

		// Token: 0x04005929 RID: 22825
		protected new IFadeBackgroundUiPrefabBlackScreenWhiteText_SetValue PocoInterface;
	}
}
