using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EE1 RID: 7905
	[NullableContext(1)]
	[Nullable(0)]
	public class ISubScreenPresetInitData : ISubScreenInitData
	{
		// Token: 0x0600A920 RID: 43296 RVA: 0x0017D8C4 File Offset: 0x0017BAC4
		private ISubScreenPresetInitData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISubScreenPresetInitData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISubScreenPresetInitData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISubScreenPresetInitData_SetValue());
			}
			return result;
		}

		// Token: 0x0600A921 RID: 43297 RVA: 0x0017D8FC File Offset: 0x0017BAFC
		public static ISubScreenPresetInitData Create([Nullable(2)] ISubScreenPresetInitData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISubScreenPresetInitData
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A922 RID: 43298 RVA: 0x0017D90F File Offset: 0x0017BB0F
		public static ISubScreenPresetInitData CreateFromSetValue([Nullable(2)] ISubScreenPresetInitData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISubScreenPresetInitData
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A923 RID: 43299 RVA: 0x0017D922 File Offset: 0x0017BB22
		public new ISubScreenPresetInitData_SetValue ToSetValue()
		{
			return new ISubScreenPresetInitData_SetValue
			{
				Type = this.Type,
				SubScreenKey = this.SubScreenKey,
				AnchorType = this.AnchorType
			};
		}

		// Token: 0x17003396 RID: 13206
		// (get) Token: 0x0600A924 RID: 43300 RVA: 0x0017D94D File Offset: 0x0017BB4D
		// (set) Token: 0x0600A925 RID: 43301 RVA: 0x0017D978 File Offset: 0x0017BB78
		public override ESubScreenInitDataType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESubScreenInitDataType.Preset;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003397 RID: 13207
		// (get) Token: 0x0600A926 RID: 43302 RVA: 0x0017D986 File Offset: 0x0017BB86
		// (set) Token: 0x0600A927 RID: 43303 RVA: 0x0017D9B1 File Offset: 0x0017BBB1
		public override string SubScreenKey
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SubScreenKey;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.SubScreenKey;
			}
			set
			{
				this.GetOrCreatePoco().SubScreenKey = value;
			}
		}

		// Token: 0x17003398 RID: 13208
		// (get) Token: 0x0600A928 RID: 43304 RVA: 0x0017D9BF File Offset: 0x0017BBBF
		// (set) Token: 0x0600A929 RID: 43305 RVA: 0x0017D9EA File Offset: 0x0017BBEA
		public virtual ESubScreenInitPreset AnchorType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AnchorType;
				}
				if (this.PocoInterface == null)
				{
					return ESubScreenInitPreset.Left;
				}
				return this.PocoInterface.AnchorType;
			}
			set
			{
				this.GetOrCreatePoco().AnchorType = value;
			}
		}

		// Token: 0x040064AD RID: 25773
		[Nullable(2)]
		protected new ISubScreenPresetInitData FbInstance;

		// Token: 0x040064AE RID: 25774
		[Nullable(2)]
		protected new ISubScreenPresetInitData_SetValue PocoInterface;
	}
}
