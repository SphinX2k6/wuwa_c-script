using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera;

namespace CSharpScript.Game.Camera.FightCameraController.SpecialGameplay
{
	// Token: 0x020072FA RID: 29434
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class PhotoCameraComponentBase
	{
		// Token: 0x0604839F RID: 295839 RVA: 0x0128E057 File Offset: 0x0128C257
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

		// Token: 0x17009F5F RID: 40799
		// (get) Token: 0x060483A0 RID: 295840 RVA: 0x0128E06A File Offset: 0x0128C26A
		public bool IsInited
		{
			get
			{
				return this.InitedFlag;
			}
		}

		// Token: 0x17009F60 RID: 40800
		// (get) Token: 0x060483A1 RID: 295841 RVA: 0x0128E072 File Offset: 0x0128C272
		public bool IsActive
		{
			get
			{
				return this.ActiveFlag;
			}
		}

		// Token: 0x17009F61 RID: 40801
		// (get) Token: 0x060483A2 RID: 295842 RVA: 0x0128E07A File Offset: 0x0128C27A
		public bool IsDestroyed
		{
			get
			{
				return this.DestroyedFlag;
			}
		}

		// Token: 0x060483A3 RID: 295843 RVA: 0x0128E082 File Offset: 0x0128C282
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

		// Token: 0x060483A4 RID: 295844 RVA: 0x0128E0A9 File Offset: 0x0128C2A9
		public void Activate()
		{
			if (!this.InitedFlag || this.ActiveFlag || this.DestroyedFlag)
			{
				return;
			}
			this.ActiveFlag = true;
			this.OnActivate();
		}

		// Token: 0x060483A5 RID: 295845 RVA: 0x0128E0D1 File Offset: 0x0128C2D1
		public void Deactivate()
		{
			if (!this.ActiveFlag)
			{
				return;
			}
			this.ActiveFlag = false;
			this.OnDeactivate();
		}

		// Token: 0x060483A6 RID: 295846 RVA: 0x0128E0E9 File Offset: 0x0128C2E9
		public void Tick(float deltaTime)
		{
			if (!this.ActiveFlag)
			{
				return;
			}
			this.OnTick(deltaTime);
		}

		// Token: 0x060483A7 RID: 295847 RVA: 0x0128E0FB File Offset: 0x0128C2FB
		public void ModeChangeStart(PhotoCameraType? prev, PhotoCameraType next)
		{
			if (!this.ActiveFlag)
			{
				return;
			}
			this.OnModeChangeStart(prev, next);
		}

		// Token: 0x060483A8 RID: 295848 RVA: 0x0128E10E File Offset: 0x0128C30E
		public void ModeChangeFinish(PhotoCameraType? prev, PhotoCameraType next)
		{
			if (!this.ActiveFlag)
			{
				return;
			}
			this.OnModeChangeFinish(prev, next);
		}

		// Token: 0x060483A9 RID: 295849 RVA: 0x0128E121 File Offset: 0x0128C321
		public void CharacterChanged(TsBaseCharacter character)
		{
			if (!this.ActiveFlag)
			{
				return;
			}
			this.OnCharacterChanged(character);
		}

		// Token: 0x060483AA RID: 295850 RVA: 0x0128E133 File Offset: 0x0128C333
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

		// Token: 0x060483AB RID: 295851 RVA: 0x0128E160 File Offset: 0x0128C360
		protected virtual void OnInit()
		{
		}

		// Token: 0x060483AC RID: 295852 RVA: 0x0128E162 File Offset: 0x0128C362
		protected virtual void OnActivate()
		{
		}

		// Token: 0x060483AD RID: 295853 RVA: 0x0128E164 File Offset: 0x0128C364
		protected virtual void OnDeactivate()
		{
		}

		// Token: 0x060483AE RID: 295854 RVA: 0x0128E166 File Offset: 0x0128C366
		protected virtual void OnTick(float deltaTime)
		{
		}

		// Token: 0x060483AF RID: 295855 RVA: 0x0128E168 File Offset: 0x0128C368
		protected virtual void OnModeChangeStart(PhotoCameraType? prev, PhotoCameraType next)
		{
		}

		// Token: 0x060483B0 RID: 295856 RVA: 0x0128E16A File Offset: 0x0128C36A
		protected virtual void OnModeChangeFinish(PhotoCameraType? prev, PhotoCameraType next)
		{
		}

		// Token: 0x060483B1 RID: 295857 RVA: 0x0128E16C File Offset: 0x0128C36C
		protected virtual void OnCharacterChanged(TsBaseCharacter character)
		{
		}

		// Token: 0x060483B2 RID: 295858 RVA: 0x0128E16E File Offset: 0x0128C36E
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x0402628D RID: 156301
		protected IPhotoCameraHost Host;

		// Token: 0x0402628E RID: 156302
		private bool InitedFlag;

		// Token: 0x0402628F RID: 156303
		private bool ActiveFlag;

		// Token: 0x04026290 RID: 156304
		private bool DestroyedFlag;
	}
}
