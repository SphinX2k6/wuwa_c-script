using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DE4 RID: 7652
	[NullableContext(1)]
	[Nullable(0)]
	public class ISceneItemNewSplineMoveTarget : INewSplineMoveTarget
	{
		// Token: 0x0600A3CB RID: 41931 RVA: 0x00173C5C File Offset: 0x00171E5C
		private ISceneItemNewSplineMoveTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISceneItemNewSplineMoveTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISceneItemNewSplineMoveTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISceneItemNewSplineMoveTarget_SetValue());
			}
			return result;
		}

		// Token: 0x0600A3CC RID: 41932 RVA: 0x00173C94 File Offset: 0x00171E94
		public static ISceneItemNewSplineMoveTarget Create([Nullable(2)] ISceneItemNewSplineMoveTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneItemNewSplineMoveTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A3CD RID: 41933 RVA: 0x00173CA7 File Offset: 0x00171EA7
		public static ISceneItemNewSplineMoveTarget CreateFromSetValue([Nullable(2)] ISceneItemNewSplineMoveTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISceneItemNewSplineMoveTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A3CE RID: 41934 RVA: 0x00173CBA File Offset: 0x00171EBA
		public new ISceneItemNewSplineMoveTarget_SetValue ToSetValue()
		{
			return new ISceneItemNewSplineMoveTarget_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId,
				IsLookDir = this.IsLookDir
			};
		}

		// Token: 0x17003266 RID: 12902
		// (get) Token: 0x0600A3CF RID: 41935 RVA: 0x00173CE5 File Offset: 0x00171EE5
		// (set) Token: 0x0600A3D0 RID: 41936 RVA: 0x00173D10 File Offset: 0x00171F10
		public override ENewSplineMoveTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENewSplineMoveTargetType.Player;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003267 RID: 12903
		// (get) Token: 0x0600A3D1 RID: 41937 RVA: 0x00173D1E File Offset: 0x00171F1E
		// (set) Token: 0x0600A3D2 RID: 41938 RVA: 0x00173D49 File Offset: 0x00171F49
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x17003268 RID: 12904
		// (get) Token: 0x0600A3D3 RID: 41939 RVA: 0x00173D58 File Offset: 0x00171F58
		// (set) Token: 0x0600A3D4 RID: 41940 RVA: 0x00173D92 File Offset: 0x00171F92
		public virtual bool? IsLookDir
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsLookDir;
				}
				ISceneItemNewSplineMoveTarget_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsLookDir;
			}
			set
			{
				this.GetOrCreatePoco().IsLookDir = value;
			}
		}

		// Token: 0x0400622B RID: 25131
		[Nullable(2)]
		protected new ISceneItemNewSplineMoveTarget FbInstance;

		// Token: 0x0400622C RID: 25132
		[Nullable(2)]
		protected new ISceneItemNewSplineMoveTarget_SetValue PocoInterface;
	}
}
