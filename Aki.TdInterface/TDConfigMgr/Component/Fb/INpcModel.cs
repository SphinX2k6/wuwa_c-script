using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DDD RID: 3549
	public class INpcModel : IModelConfig
	{
		// Token: 0x06005070 RID: 20592 RVA: 0x000C790D File Offset: 0x000C5B0D
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

		// Token: 0x170018B1 RID: 6321
		// (get) Token: 0x06005071 RID: 20593 RVA: 0x000C792C File Offset: 0x000C5B2C
		public override EModelType Type
		{
			get
			{
				return (EModelType)this.Instance.Type;
			}
		}

		// Token: 0x170018B2 RID: 6322
		// (get) Token: 0x06005072 RID: 20594 RVA: 0x000C7939 File Offset: 0x000C5B39
		public virtual string BlueprintPath
		{
			get
			{
				return this.Instance.BlueprintPath;
			}
		}

		// Token: 0x170018B3 RID: 6323
		// (get) Token: 0x06005073 RID: 20595 RVA: 0x000C7946 File Offset: 0x000C5B46
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

		// Token: 0x170018B4 RID: 6324
		// (get) Token: 0x06005074 RID: 20596 RVA: 0x000C7975 File Offset: 0x000C5B75
		public virtual string Abp
		{
			get
			{
				return this.Instance.Abp;
			}
		}

		// Token: 0x170018B5 RID: 6325
		// (get) Token: 0x06005075 RID: 20597 RVA: 0x000C7984 File Offset: 0x000C5B84
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<string> BattleSockets
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x170018B6 RID: 6326
		// (get) Token: 0x06005076 RID: 20598 RVA: 0x000C79FC File Offset: 0x000C5BFC
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<string> NormalSockets
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x170018B7 RID: 6327
		// (get) Token: 0x06005077 RID: 20599 RVA: 0x000C7A74 File Offset: 0x000C5C74
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

		// Token: 0x170018B8 RID: 6328
		// (get) Token: 0x06005078 RID: 20600 RVA: 0x000C7AAC File Offset: 0x000C5CAC
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

		// Token: 0x170018B9 RID: 6329
		// (get) Token: 0x06005079 RID: 20601 RVA: 0x000C7AE4 File Offset: 0x000C5CE4
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

		// Token: 0x04002DD4 RID: 11732
		private INpcModel Instance;

		// Token: 0x04002DD5 RID: 11733
		private INpcModelConfig _NpcModelCache;

		// Token: 0x04002DD6 RID: 11734
		private bool _NpcModelInited;

		// Token: 0x04002DD7 RID: 11735
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<string> _BattleSocketsCache;

		// Token: 0x04002DD8 RID: 11736
		private bool _BattleSocketsInited;

		// Token: 0x04002DD9 RID: 11737
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<string> _NormalSocketsCache;

		// Token: 0x04002DDA RID: 11738
		private bool _NormalSocketsInited;
	}
}
