using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.Base;
using CSharpScript.Game.Module.Map.MapDefine;

namespace CSharpScript.Game.Module.Map.Mark.Component
{
	// Token: 0x020054C8 RID: 21704
	public class MarkConfigComponent : MapComponent
	{
		// Token: 0x06037693 RID: 226963 RVA: 0x00D28F7C File Offset: 0x00D2717C
		public MarkConfigComponent([Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] OneOf<MapComponent, MapComponentContainer, MapEntity> parent) : base(parent)
		{
		}

		// Token: 0x170084E1 RID: 34017
		// (get) Token: 0x06037694 RID: 226964 RVA: 0x00D28F85 File Offset: 0x00D27185
		public override EMapComponent ComponentType
		{
			get
			{
				return EMapComponent.MarkConfig;
			}
		}

		// Token: 0x170084E2 RID: 34018
		// (get) Token: 0x06037695 RID: 226965 RVA: 0x00D28F8C File Offset: 0x00D2718C
		public int? RelativeId
		{
			get
			{
				if (!this.Config.HasValue)
				{
					return null;
				}
				if (this.Config.IsT1)
				{
					return new int?(this.Config.AsT1.RelativeId);
				}
				if (this.Config.IsT2)
				{
					return new int?(this.Config.AsT2.RelativeId);
				}
				return null;
			}
		}

		// Token: 0x170084E3 RID: 34019
		// (get) Token: 0x06037696 RID: 226966 RVA: 0x00D29008 File Offset: 0x00D27208
		public EMarkRelativeSubType? RelativeSubType
		{
			get
			{
				if (!this.Config.HasValue)
				{
					return null;
				}
				if (this.Config.IsT1)
				{
					return new EMarkRelativeSubType?((EMarkRelativeSubType)this.Config.AsT1.RelativeSubType);
				}
				if (this.Config.IsT2)
				{
					return new EMarkRelativeSubType?((EMarkRelativeSubType)this.Config.AsT2.RelativeSubType);
				}
				return null;
			}
		}

		// Token: 0x170084E4 RID: 34020
		// (get) Token: 0x06037697 RID: 226967 RVA: 0x00D29084 File Offset: 0x00D27284
		public int? MarkId
		{
			get
			{
				if (!this.Config.HasValue)
				{
					return null;
				}
				if (this.Config.IsT1)
				{
					return new int?(this.Config.AsT1.MarkId);
				}
				if (this.Config.IsT2)
				{
					return new int?(this.Config.AsT2.MarkId);
				}
				if (this.Config.IsT3)
				{
					return new int?(this.Config.AsT3.MarkId);
				}
				return null;
			}
		}

		// Token: 0x170084E5 RID: 34021
		// (get) Token: 0x06037698 RID: 226968 RVA: 0x00D29124 File Offset: 0x00D27324
		public EMarkRelativeType? RelativeType
		{
			get
			{
				if (!this.Config.HasValue)
				{
					return null;
				}
				if (this.Config.IsT1)
				{
					return new EMarkRelativeType?((EMarkRelativeType)this.Config.AsT1.RelativeType);
				}
				if (this.Config.IsT2)
				{
					return new EMarkRelativeType?((EMarkRelativeType)this.Config.AsT2.RelativeType);
				}
				return null;
			}
		}

		// Token: 0x170084E6 RID: 34022
		// (get) Token: 0x06037699 RID: 226969 RVA: 0x00D291A0 File Offset: 0x00D273A0
		public int? RelativeDungeonId
		{
			get
			{
				if (!this.Config.HasValue)
				{
					return null;
				}
				if (this.Config.IsT1)
				{
					return new int?(this.Config.AsT1.RelativeDungeonId);
				}
				if (this.Config.IsT2)
				{
					return new int?(this.Config.AsT2.RelativeDungeonId);
				}
				return null;
			}
		}

		// Token: 0x170084E7 RID: 34023
		// (get) Token: 0x0603769A RID: 226970 RVA: 0x00D2921C File Offset: 0x00D2741C
		public int? FogHide
		{
			get
			{
				if (!this.Config.HasValue)
				{
					return null;
				}
				if (this.Config.IsT1)
				{
					return new int?(this.Config.AsT1.FogHide);
				}
				if (this.Config.IsT2)
				{
					return new int?(this.Config.AsT2.FogHide);
				}
				return null;
			}
		}

		// Token: 0x0401D374 RID: 119668
		public OneOf<MapMark, DynamicMapMark, TreasureBoxDetectorMark> Config;
	}
}
