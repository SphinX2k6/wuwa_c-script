using System;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005437 RID: 21559
	public struct IInteractAudioComponent : IFlatbufferObject
	{
		// Token: 0x17009E89 RID: 40585
		// (get) Token: 0x0602369D RID: 145053 RVA: 0x004E62CA File Offset: 0x004E44CA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602369E RID: 145054 RVA: 0x004E62D7 File Offset: 0x004E44D7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602369F RID: 145055 RVA: 0x004E62E0 File Offset: 0x004E44E0
		public static IInteractAudioComponent GetRootAsIInteractAudioComponent(ByteBuffer _bb)
		{
			return IInteractAudioComponent.GetRootAsIInteractAudioComponent(_bb, default(IInteractAudioComponent));
		}

		// Token: 0x060236A0 RID: 145056 RVA: 0x004E62FC File Offset: 0x004E44FC
		public static IInteractAudioComponent GetRootAsIInteractAudioComponent(ByteBuffer _bb, IInteractAudioComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060236A1 RID: 145057 RVA: 0x004E6319 File Offset: 0x004E4519
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060236A2 RID: 145058 RVA: 0x004E6328 File Offset: 0x004E4528
		public IInteractAudioComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009E8A RID: 40586
		// (get) Token: 0x060236A3 RID: 145059 RVA: 0x004E6338 File Offset: 0x004E4538
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009E8B RID: 40587
		// (get) Token: 0x060236A4 RID: 145060 RVA: 0x004E6378 File Offset: 0x004E4578
		public EInteractAudioMaterial CollisionMaterial
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EInteractAudioMaterial.GrowSolution;
				}
				return (EInteractAudioMaterial)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009E8C RID: 40588
		// (get) Token: 0x060236A5 RID: 145061 RVA: 0x004E63B4 File Offset: 0x004E45B4
		public IAudioEventConfig? InteractEventConfig
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IAudioEventConfig?(default(IAudioEventConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009E8D RID: 40589
		// (get) Token: 0x060236A6 RID: 145062 RVA: 0x004E6414 File Offset: 0x004E4614
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060236A7 RID: 145063 RVA: 0x004E6451 File Offset: 0x004E4651
		public static Offset<IInteractAudioComponent> CreateIInteractAudioComponent(FlatBufferBuilder builder, bool Disabled = false, EInteractAudioMaterial CollisionMaterial = EInteractAudioMaterial.GrowSolution, Offset<IAudioEventConfig> InteractEventConfigOffset = default(Offset<IAudioEventConfig>), byte NullMask = 0)
		{
			builder.StartTable(4);
			IInteractAudioComponent.AddInteractEventConfig(builder, InteractEventConfigOffset);
			IInteractAudioComponent.AddNullMask(builder, NullMask);
			IInteractAudioComponent.AddCollisionMaterial(builder, CollisionMaterial);
			IInteractAudioComponent.AddDisabled(builder, Disabled);
			return IInteractAudioComponent.EndIInteractAudioComponent(builder);
		}

		// Token: 0x060236A8 RID: 145064 RVA: 0x004E647D File Offset: 0x004E467D
		public static void StartIInteractAudioComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060236A9 RID: 145065 RVA: 0x004E6486 File Offset: 0x004E4686
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060236AA RID: 145066 RVA: 0x004E6491 File Offset: 0x004E4691
		public static void AddCollisionMaterial(FlatBufferBuilder builder, EInteractAudioMaterial collisionMaterial)
		{
			builder.AddByte(1, (byte)collisionMaterial, 0);
		}

		// Token: 0x060236AB RID: 145067 RVA: 0x004E649C File Offset: 0x004E469C
		public static void AddInteractEventConfig(FlatBufferBuilder builder, Offset<IAudioEventConfig> interactEventConfigOffset)
		{
			builder.AddOffset(2, interactEventConfigOffset.Value, 0);
		}

		// Token: 0x060236AC RID: 145068 RVA: 0x004E64AC File Offset: 0x004E46AC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060236AD RID: 145069 RVA: 0x004E64B7 File Offset: 0x004E46B7
		public static Offset<IInteractAudioComponent> EndIInteractAudioComponent(FlatBufferBuilder builder)
		{
			return new Offset<IInteractAudioComponent>(builder.EndTable());
		}

		// Token: 0x060236AE RID: 145070 RVA: 0x004E64C4 File Offset: 0x004E46C4
		public IInteractAudioComponentT UnPack()
		{
			IInteractAudioComponentT interactAudioComponentT = new IInteractAudioComponentT();
			this.UnPackTo(interactAudioComponentT);
			return interactAudioComponentT;
		}

		// Token: 0x060236AF RID: 145071 RVA: 0x004E64E0 File Offset: 0x004E46E0
		public void UnPackTo(IInteractAudioComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.CollisionMaterial = this.CollisionMaterial;
			_o.InteractEventConfig = ((this.InteractEventConfig != null) ? this.InteractEventConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060236B0 RID: 145072 RVA: 0x004E6540 File Offset: 0x004E4740
		public static Offset<IInteractAudioComponent> Pack(FlatBufferBuilder builder, IInteractAudioComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractAudioComponent>);
			}
			Offset<IAudioEventConfig> interactEventConfigOffset = (_o.InteractEventConfig == null) ? default(Offset<IAudioEventConfig>) : IAudioEventConfig.Pack(builder, _o.InteractEventConfig);
			return IInteractAudioComponent.CreateIInteractAudioComponent(builder, _o.Disabled, _o.CollisionMaterial, interactEventConfigOffset, _o.NullMask);
		}

		// Token: 0x0400E68C RID: 59020
		private Table __p;
	}
}
