using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012F0 RID: 4848
	public class ITrackEffectType
	{
		// Token: 0x06006D3B RID: 27963 RVA: 0x00104488 File Offset: 0x00102688
		private ITrackEffectType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITrackEffectType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITrackEffectType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITrackEffectType_SetValue());
			}
			return result;
		}

		// Token: 0x06006D3C RID: 27964 RVA: 0x001044C0 File Offset: 0x001026C0
		public static ITrackEffectType Create([Nullable(2)] ITrackEffectType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrackEffectType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006D3D RID: 27965 RVA: 0x001044D3 File Offset: 0x001026D3
		public static ITrackEffectType CreateFromSetValue([Nullable(2)] ITrackEffectType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITrackEffectType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006D3E RID: 27966 RVA: 0x001044E6 File Offset: 0x001026E6
		public ITrackEffectType_SetValue ToSetValue()
		{
			return new ITrackEffectType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002335 RID: 9013
		// (get) Token: 0x06006D3F RID: 27967 RVA: 0x001044F9 File Offset: 0x001026F9
		// (set) Token: 0x06006D40 RID: 27968 RVA: 0x00104524 File Offset: 0x00102724
		public virtual ETrackEffectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETrackEffectType.AutoChange;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04004145 RID: 16709
		[Nullable(2)]
		protected ITrackEffectType FbInstance;

		// Token: 0x04004146 RID: 16710
		[Nullable(2)]
		protected ITrackEffectType_SetValue PocoInterface;
	}
}
