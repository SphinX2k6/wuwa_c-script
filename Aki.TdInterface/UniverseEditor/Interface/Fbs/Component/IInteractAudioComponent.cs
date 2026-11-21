using System;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059BD RID: 22973
	public struct IInteractAudioComponent : IFlatbufferObject
	{
		// Token: 0x1700A6C3 RID: 42691
		// (get) Token: 0x06025755 RID: 153429 RVA: 0x005232F6 File Offset: 0x005214F6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025756 RID: 153430 RVA: 0x00523303 File Offset: 0x00521503
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025757 RID: 153431 RVA: 0x0052330C File Offset: 0x0052150C
		public static IInteractAudioComponent GetRootAsIInteractAudioComponent(ByteBuffer _bb)
		{
			return IInteractAudioComponent.GetRootAsIInteractAudioComponent(_bb, default(IInteractAudioComponent));
		}

		// Token: 0x06025758 RID: 153432 RVA: 0x00523328 File Offset: 0x00521528
		public static IInteractAudioComponent GetRootAsIInteractAudioComponent(ByteBuffer _bb, IInteractAudioComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025759 RID: 153433 RVA: 0x00523345 File Offset: 0x00521545
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602575A RID: 153434 RVA: 0x00523354 File Offset: 0x00521554
		public IInteractAudioComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A6C4 RID: 42692
		// (get) Token: 0x0602575B RID: 153435 RVA: 0x00523364 File Offset: 0x00521564
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A6C5 RID: 42693
		// (get) Token: 0x0602575C RID: 153436 RVA: 0x005233A4 File Offset: 0x005215A4
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

		// Token: 0x1700A6C6 RID: 42694
		// (get) Token: 0x0602575D RID: 153437 RVA: 0x005233E0 File Offset: 0x005215E0
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

		// Token: 0x1700A6C7 RID: 42695
		// (get) Token: 0x0602575E RID: 153438 RVA: 0x00523440 File Offset: 0x00521640
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

		// Token: 0x0602575F RID: 153439 RVA: 0x0052347D File Offset: 0x0052167D
		public static Offset<IInteractAudioComponent> CreateIInteractAudioComponent(FlatBufferBuilder builder, bool Disabled = false, EInteractAudioMaterial CollisionMaterial = EInteractAudioMaterial.GrowSolution, Offset<IAudioEventConfig> InteractEventConfigOffset = default(Offset<IAudioEventConfig>), byte NullMask = 0)
		{
			builder.StartTable(4);
			IInteractAudioComponent.AddInteractEventConfig(builder, InteractEventConfigOffset);
			IInteractAudioComponent.AddNullMask(builder, NullMask);
			IInteractAudioComponent.AddCollisionMaterial(builder, CollisionMaterial);
			IInteractAudioComponent.AddDisabled(builder, Disabled);
			return IInteractAudioComponent.EndIInteractAudioComponent(builder);
		}

		// Token: 0x06025760 RID: 153440 RVA: 0x005234A9 File Offset: 0x005216A9
		public static void StartIInteractAudioComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06025761 RID: 153441 RVA: 0x005234B2 File Offset: 0x005216B2
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06025762 RID: 153442 RVA: 0x005234BD File Offset: 0x005216BD
		public static void AddCollisionMaterial(FlatBufferBuilder builder, EInteractAudioMaterial collisionMaterial)
		{
			builder.AddByte(1, (byte)collisionMaterial, 0);
		}

		// Token: 0x06025763 RID: 153443 RVA: 0x005234C8 File Offset: 0x005216C8
		public static void AddInteractEventConfig(FlatBufferBuilder builder, Offset<IAudioEventConfig> interactEventConfigOffset)
		{
			builder.AddOffset(2, interactEventConfigOffset.Value, 0);
		}

		// Token: 0x06025764 RID: 153444 RVA: 0x005234D8 File Offset: 0x005216D8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06025765 RID: 153445 RVA: 0x005234E3 File Offset: 0x005216E3
		public static Offset<IInteractAudioComponent> EndIInteractAudioComponent(FlatBufferBuilder builder)
		{
			return new Offset<IInteractAudioComponent>(builder.EndTable());
		}

		// Token: 0x06025766 RID: 153446 RVA: 0x005234F0 File Offset: 0x005216F0
		public IInteractAudioComponentT UnPack()
		{
			IInteractAudioComponentT interactAudioComponentT = new IInteractAudioComponentT();
			this.UnPackTo(interactAudioComponentT);
			return interactAudioComponentT;
		}

		// Token: 0x06025767 RID: 153447 RVA: 0x0052350C File Offset: 0x0052170C
		public void UnPackTo(IInteractAudioComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.CollisionMaterial = this.CollisionMaterial;
			_o.InteractEventConfig = ((this.InteractEventConfig != null) ? this.InteractEventConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06025768 RID: 153448 RVA: 0x0052356C File Offset: 0x0052176C
		public static Offset<IInteractAudioComponent> Pack(FlatBufferBuilder builder, IInteractAudioComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractAudioComponent>);
			}
			Offset<IAudioEventConfig> interactEventConfigOffset = (_o.InteractEventConfig == null) ? default(Offset<IAudioEventConfig>) : IAudioEventConfig.Pack(builder, _o.InteractEventConfig);
			return IInteractAudioComponent.CreateIInteractAudioComponent(builder, _o.Disabled, _o.CollisionMaterial, interactEventConfigOffset, _o.NullMask);
		}

		// Token: 0x0400F2BD RID: 62141
		private Table __p;
	}
}
