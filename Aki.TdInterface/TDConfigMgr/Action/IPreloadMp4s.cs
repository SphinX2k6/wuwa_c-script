using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D4A RID: 7498
	[NullableContext(1)]
	[Nullable(0)]
	public class IPreloadMp4s : IPreloadCharacterType
	{
		// Token: 0x0600A0DD RID: 41181 RVA: 0x0016EC70 File Offset: 0x0016CE70
		private IPreloadMp4s_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPreloadMp4s 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPreloadMp4s_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPreloadMp4s_SetValue());
			}
			return result;
		}

		// Token: 0x0600A0DE RID: 41182 RVA: 0x0016ECA8 File Offset: 0x0016CEA8
		public static IPreloadMp4s Create([Nullable(2)] IPreloadMp4s instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPreloadMp4s
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A0DF RID: 41183 RVA: 0x0016ECBB File Offset: 0x0016CEBB
		public static IPreloadMp4s CreateFromSetValue([Nullable(2)] IPreloadMp4s_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPreloadMp4s
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A0E0 RID: 41184 RVA: 0x0016ECCE File Offset: 0x0016CECE
		public new IPreloadMp4s_SetValue ToSetValue()
		{
			return new IPreloadMp4s_SetValue
			{
				Type = this.Type,
				Mp4s = this.Mp4s
			};
		}

		// Token: 0x170031D6 RID: 12758
		// (get) Token: 0x0600A0E1 RID: 41185 RVA: 0x0016ECED File Offset: 0x0016CEED
		// (set) Token: 0x0600A0E2 RID: 41186 RVA: 0x0016ED18 File Offset: 0x0016CF18
		public override EPreloadObjectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPreloadObjectType.PreloadTrialCharacterForSkill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170031D7 RID: 12759
		// (get) Token: 0x0600A0E3 RID: 41187 RVA: 0x0016ED26 File Offset: 0x0016CF26
		// (set) Token: 0x0600A0E4 RID: 41188 RVA: 0x0016ED4D File Offset: 0x0016CF4D
		public virtual List<string> Mp4s
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Mp4s;
				}
				IPreloadMp4s_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Mp4s;
			}
			set
			{
				this.GetOrCreatePoco().Mp4s = value;
			}
		}

		// Token: 0x040060E5 RID: 24805
		[Nullable(2)]
		protected new IPreloadMp4s FbInstance;

		// Token: 0x040060E6 RID: 24806
		[Nullable(2)]
		protected new IPreloadMp4s_SetValue PocoInterface;
	}
}
