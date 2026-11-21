using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001159 RID: 4441
	public class INumberWordArtEffectiveTargetType : IWordArtEffectiveTargetType
	{
		// Token: 0x06006240 RID: 25152 RVA: 0x000EC8A8 File Offset: 0x000EAAA8
		private INumberWordArtEffectiveTargetType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INumberWordArtEffectiveTargetType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INumberWordArtEffectiveTargetType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INumberWordArtEffectiveTargetType_SetValue());
			}
			return result;
		}

		// Token: 0x06006241 RID: 25153 RVA: 0x000EC8E0 File Offset: 0x000EAAE0
		public static INumberWordArtEffectiveTargetType Create([Nullable(2)] INumberWordArtEffectiveTargetType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INumberWordArtEffectiveTargetType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006242 RID: 25154 RVA: 0x000EC8F3 File Offset: 0x000EAAF3
		public static INumberWordArtEffectiveTargetType CreateFromSetValue([Nullable(2)] INumberWordArtEffectiveTargetType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INumberWordArtEffectiveTargetType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006243 RID: 25155 RVA: 0x000EC906 File Offset: 0x000EAB06
		public new INumberWordArtEffectiveTargetType_SetValue ToSetValue()
		{
			return new INumberWordArtEffectiveTargetType_SetValue
			{
				Type = this.Type,
				ShowUiMotion = this.ShowUiMotion
			};
		}

		// Token: 0x17002017 RID: 8215
		// (get) Token: 0x06006244 RID: 25156 RVA: 0x000EC925 File Offset: 0x000EAB25
		// (set) Token: 0x06006245 RID: 25157 RVA: 0x000EC950 File Offset: 0x000EAB50
		public override EWordArtEffectiveTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EWordArtEffectiveTargetType.Number;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002018 RID: 8216
		// (get) Token: 0x06006246 RID: 25158 RVA: 0x000EC960 File Offset: 0x000EAB60
		// (set) Token: 0x06006247 RID: 25159 RVA: 0x000EC99A File Offset: 0x000EAB9A
		public virtual bool? ShowUiMotion
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ShowUiMotion;
				}
				INumberWordArtEffectiveTargetType_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ShowUiMotion;
			}
			set
			{
				this.GetOrCreatePoco().ShowUiMotion = value;
			}
		}

		// Token: 0x04003ACB RID: 15051
		[Nullable(2)]
		protected new INumberWordArtEffectiveTargetType FbInstance;

		// Token: 0x04003ACC RID: 15052
		[Nullable(2)]
		protected new INumberWordArtEffectiveTargetType_SetValue PocoInterface;
	}
}
