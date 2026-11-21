using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera;

namespace CSharpScript.Game.Camera.FightCameraController.SpecialGameplay
{
	// Token: 0x0200647D RID: 25725
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class PhotoCameraComponentBase
	{
		// Token: 0x0603E7EB RID: 255979 RVA: 0x01230A0B File Offset: 0x0122EC0B
		[NullableContext(1)]
		public static EPhotoCameraComponent GetId(Type type)
		{
			RegisterPhotoCameraComponentAttribute customAttribute = type.GetCustomAttribute<RegisterPhotoCameraComponentAttribute>();
			if (customAttribute == null)
			{
				return (EPhotoCameraComponent)(-1);
			}
			return customAttribute.Id;
		}

		// Token: 0x170076FD RID: 30461
		// (get) Token: 0x0603E7EC RID: 255980 RVA: 0x01230A1E File Offset: 0x0122EC1E
		public bool IsInited
		{
			get
			{
				return this.InitedFlag;
			}
		}

		// Token: 0x170076FE RID: 30462
		// (get) Token: 0x0603E7ED RID: 255981 RVA: 0x01230A26 File Offset: 0x0122EC26
		public bool IsActive
		{
			get
			{
				return this.ActiveFlag;
			}
		}

		// Token: 0x170076FF RID: 30463
		// (get) Token: 0x0603E7EE RID: 255982 RVA: 0x01230A2E File Offset: 0x0122EC2E
		public bool IsDestroyed
		{
			get
			{
				return this.DestroyedFlag;
			}
		}

		// Token: 0x0603E7EF RID: 255983 RVA: 0x01230A36 File Offset: 0x0122EC36
		[NullableContext(1)]
		public void Init(IPhotoCameraHost host)
		{
			if (this.DestroyedFlag || this.InitedFlag)
			{
				return;
			}
			this.Host = host;
			this.InitedFlag = true;
			this.OnInit();
		}

		// Token: 0x0603E7F0 RID: 255984 RVA: 0x01230A5D File Offset: 0x0122EC5D
		public void Activate()
		{
			if (!this.InitedFlag || this.ActiveFlag || this.DestroyedFlag)
			{
				return;
			}
			this.ActiveFlag = true;
			this.OnActivate();
		}

		// Token: 0x0603E7F1 RID: 255985 RVA: 0x01230A85 File Offset: 0x0122EC85
		public void Deactivate()
		{
			if (!this.ActiveFlag)
			{
				return;
			}
			this.ActiveFlag = false;
			this.OnDeactivate();
		}

		// Token: 0x0603E7F2 RID: 255986 RVA: 0x01230A9D File Offset: 0x0122EC9D
		public void Tick(float deltaTime)
		{
			if (!this.ActiveFlag)
			{
				return;
			}
			this.OnTick(deltaTime);
		}

		// Token: 0x0603E7F3 RID: 255987 RVA: 0x01230AAF File Offset: 0x0122ECAF
		public void ModeChangeStart(PhotoCameraType? prev, PhotoCameraType next)
		{
			if (!this.ActiveFlag)
			{
				return;
			}
			this.OnModeChangeStart(prev, next);
		}

		// Token: 0x0603E7F4 RID: 255988 RVA: 0x01230AC2 File Offset: 0x0122ECC2
		public void ModeChangeFinish(PhotoCameraType? prev, PhotoCameraType next)
		{
			if (!this.ActiveFlag)
			{
				return;
			}
			this.OnModeChangeFinish(prev, next);
		}

		// Token: 0x0603E7F5 RID: 255989 RVA: 0x01230AD5 File Offset: 0x0122ECD5
		public void CharacterChanged(TsBaseCharacter character)
		{
			if (!this.ActiveFlag)
			{
				return;
			}
			this.OnCharacterChanged(character);
		}

		// Token: 0x0603E7F6 RID: 255990 RVA: 0x01230AE7 File Offset: 0x0122ECE7
		public void Destroy()
		{
			if (this.DestroyedFlag)
			{
				return;
			}
			if (this.ActiveFlag)
			{
				this.Deactivate();
			}
			this.DestroyedFlag = true;
			this.OnDestroy();
			this.Host = null;
		}

		// Token: 0x0603E7F7 RID: 255991 RVA: 0x01230B14 File Offset: 0x0122ED14
		protected virtual void OnInit()
		{
		}

		// Token: 0x0603E7F8 RID: 255992 RVA: 0x01230B16 File Offset: 0x0122ED16
		protected virtual void OnActivate()
		{
		}

		// Token: 0x0603E7F9 RID: 255993 RVA: 0x01230B18 File Offset: 0x0122ED18
		protected virtual void OnDeactivate()
		{
		}

		// Token: 0x0603E7FA RID: 255994 RVA: 0x01230B1A File Offset: 0x0122ED1A
		protected virtual void OnTick(float deltaTime)
		{
		}

		// Token: 0x0603E7FB RID: 255995 RVA: 0x01230B1C File Offset: 0x0122ED1C
		protected virtual void OnModeChangeStart(PhotoCameraType? prev, PhotoCameraType next)
		{
		}

		// Token: 0x0603E7FC RID: 255996 RVA: 0x01230B1E File Offset: 0x0122ED1E
		protected virtual void OnModeChangeFinish(PhotoCameraType? prev, PhotoCameraType next)
		{
		}

		// Token: 0x0603E7FD RID: 255997 RVA: 0x01230B20 File Offset: 0x0122ED20
		protected virtual void OnCharacterChanged(TsBaseCharacter character)
		{
		}

		// Token: 0x0603E7FE RID: 255998 RVA: 0x01230B22 File Offset: 0x0122ED22
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x04021578 RID: 136568
		protected IPhotoCameraHost Host;

		// Token: 0x04021579 RID: 136569
		private bool InitedFlag;

		// Token: 0x0402157A RID: 136570
		private bool ActiveFlag;

		// Token: 0x0402157B RID: 136571
		private bool DestroyedFlag;
	}
}
