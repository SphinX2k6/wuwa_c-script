using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CE5 RID: 3301
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcModel : IModelConfig
	{
		// Token: 0x06004B63 RID: 19299 RVA: 0x000BC458 File Offset: 0x000BA658
		public static INpcModel Create(INpcModel? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcModel
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001756 RID: 5974
		// (get) Token: 0x06004B64 RID: 19300 RVA: 0x000BC477 File Offset: 0x000BA677
		public override EModelType Type
		{
			get
			{
				return (EModelType)this.Instance.Type;
			}
		}

		// Token: 0x17001757 RID: 5975
		// (get) Token: 0x06004B65 RID: 19301 RVA: 0x000BC484 File Offset: 0x000BA684
		public virtual string BlueprintPath
		{
			get
			{
				return this.Instance.BlueprintPath;
			}
		}

		// Token: 0x17001758 RID: 5976
		// (get) Token: 0x06004B66 RID: 19302 RVA: 0x000BC491 File Offset: 0x000BA691
		public virtual INpcModelConfig NpcModel
		{
			get
			{
				if (this._NpcModelInited)
				{
					return this._NpcModelCache;
				}
				this._NpcModelInited = true;
				this._NpcModelCache = ComponentReadHelper.ReadINpcModel_NpcModel(this.Instance);
				return this._NpcModelCache;
			}
		}

		// Token: 0x17001759 RID: 5977
		// (get) Token: 0x06004B67 RID: 19303 RVA: 0x000BC4C0 File Offset: 0x000BA6C0
		public virtual string Abp
		{
			get
			{
				return this.Instance.Abp;
			}
		}

		// Token: 0x1700175A RID: 5978
		// (get) Token: 0x06004B68 RID: 19304 RVA: 0x000BC4D0 File Offset: 0x000BA6D0
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<string> BattleSockets
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._BattleSocketsInited)
				{
					return this._BattleSocketsCache;
				}
				this._BattleSocketsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int battleSocketsLength = this.Instance.BattleSocketsLength;
				this._BattleSocketsCache = new List<string>(battleSocketsLength);
				for (int i = 0; i < battleSocketsLength; i++)
				{
					this._BattleSocketsCache.Add(this.Instance.BattleSockets(i));
				}
				return this._BattleSocketsCache;
			}
		}

		// Token: 0x1700175B RID: 5979
		// (get) Token: 0x06004B69 RID: 19305 RVA: 0x000BC548 File Offset: 0x000BA748
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<string> NormalSockets
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._NormalSocketsInited)
				{
					return this._NormalSocketsCache;
				}
				this._NormalSocketsInited = true;
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int normalSocketsLength = this.Instance.NormalSocketsLength;
				this._NormalSocketsCache = new List<string>(normalSocketsLength);
				for (int i = 0; i < normalSocketsLength; i++)
				{
					this._NormalSocketsCache.Add(this.Instance.NormalSockets(i));
				}
				return this._NormalSocketsCache;
			}
		}

		// Token: 0x1700175C RID: 5980
		// (get) Token: 0x06004B6A RID: 19306 RVA: 0x000BC5C0 File Offset: 0x000BA7C0
		public virtual float? LookingUpAngle
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new float?(this.Instance.LookingUpAngle);
			}
		}

		// Token: 0x1700175D RID: 5981
		// (get) Token: 0x06004B6B RID: 19307 RVA: 0x000BC5F8 File Offset: 0x000BA7F8
		public virtual EBodyType? BodyType
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new EBodyType?((EBodyType)this.Instance.BodyType);
			}
		}

		// Token: 0x1700175E RID: 5982
		// (get) Token: 0x06004B6C RID: 19308 RVA: 0x000BC630 File Offset: 0x000BA830
		public virtual float? NameZaxisOffset
		{
			get
			{
				if ((this.Instance.NullMask & 16) == 0)
				{
					return null;
				}
				return new float?(this.Instance.NameZaxisOffset);
			}
		}

		// Token: 0x04002B1C RID: 11036
		private INpcModel Instance;

		// Token: 0x04002B1D RID: 11037
		private INpcModelConfig _NpcModelCache;

		// Token: 0x04002B1E RID: 11038
		private bool _NpcModelInited;

		// Token: 0x04002B1F RID: 11039
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<string> _BattleSocketsCache;

		// Token: 0x04002B20 RID: 11040
		private bool _BattleSocketsInited;

		// Token: 0x04002B21 RID: 11041
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<string> _NormalSocketsCache;

		// Token: 0x04002B22 RID: 11042
		private bool _NormalSocketsInited;
	}
}
