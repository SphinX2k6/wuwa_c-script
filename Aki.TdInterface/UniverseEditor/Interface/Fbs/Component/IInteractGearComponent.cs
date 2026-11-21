using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059DB RID: 23003
	public struct IInteractGearComponent : IFlatbufferObject
	{
		// Token: 0x1700A72B RID: 42795
		// (get) Token: 0x060258E1 RID: 153825 RVA: 0x00526C98 File Offset: 0x00524E98
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060258E2 RID: 153826 RVA: 0x00526CA5 File Offset: 0x00524EA5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060258E3 RID: 153827 RVA: 0x00526CAC File Offset: 0x00524EAC
		public static IInteractGearComponent GetRootAsIInteractGearComponent(ByteBuffer _bb)
		{
			return IInteractGearComponent.GetRootAsIInteractGearComponent(_bb, default(IInteractGearComponent));
		}

		// Token: 0x060258E4 RID: 153828 RVA: 0x00526CC8 File Offset: 0x00524EC8
		public static IInteractGearComponent GetRootAsIInteractGearComponent(ByteBuffer _bb, IInteractGearComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060258E5 RID: 153829 RVA: 0x00526CE5 File Offset: 0x00524EE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060258E6 RID: 153830 RVA: 0x00526CF4 File Offset: 0x00524EF4
		public IInteractGearComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A72C RID: 42796
		// (get) Token: 0x060258E7 RID: 153831 RVA: 0x00526D04 File Offset: 0x00524F04
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A72D RID: 42797
		// (get) Token: 0x060258E8 RID: 153832 RVA: 0x00526D44 File Offset: 0x00524F44
		public float NormalPrepareTime
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A72E RID: 42798
		// (get) Token: 0x060258E9 RID: 153833 RVA: 0x00526D84 File Offset: 0x00524F84
		public float ActivePrepareTime
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A72F RID: 42799
		// (get) Token: 0x060258EA RID: 153834 RVA: 0x00526DC4 File Offset: 0x00524FC4
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

		// Token: 0x060258EB RID: 153835 RVA: 0x00526E01 File Offset: 0x00525001
		public static Offset<IInteractGearComponent> CreateIInteractGearComponent(FlatBufferBuilder builder, bool Disabled = false, float NormalPrepareTime = 0f, float ActivePrepareTime = 0f, byte NullMask = 0)
		{
			builder.StartTable(4);
			IInteractGearComponent.AddActivePrepareTime(builder, ActivePrepareTime);
			IInteractGearComponent.AddNormalPrepareTime(builder, NormalPrepareTime);
			IInteractGearComponent.AddNullMask(builder, NullMask);
			IInteractGearComponent.AddDisabled(builder, Disabled);
			return IInteractGearComponent.EndIInteractGearComponent(builder);
		}

		// Token: 0x060258EC RID: 153836 RVA: 0x00526E2D File Offset: 0x0052502D
		public static void StartIInteractGearComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060258ED RID: 153837 RVA: 0x00526E36 File Offset: 0x00525036
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060258EE RID: 153838 RVA: 0x00526E41 File Offset: 0x00525041
		public static void AddNormalPrepareTime(FlatBufferBuilder builder, float normalPrepareTime)
		{
			builder.AddFloat(1, normalPrepareTime, 0.0);
		}

		// Token: 0x060258EF RID: 153839 RVA: 0x00526E54 File Offset: 0x00525054
		public static void AddActivePrepareTime(FlatBufferBuilder builder, float activePrepareTime)
		{
			builder.AddFloat(2, activePrepareTime, 0.0);
		}

		// Token: 0x060258F0 RID: 153840 RVA: 0x00526E67 File Offset: 0x00525067
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060258F1 RID: 153841 RVA: 0x00526E72 File Offset: 0x00525072
		public static Offset<IInteractGearComponent> EndIInteractGearComponent(FlatBufferBuilder builder)
		{
			return new Offset<IInteractGearComponent>(builder.EndTable());
		}

		// Token: 0x060258F2 RID: 153842 RVA: 0x00526E80 File Offset: 0x00525080
		public IInteractGearComponentT UnPack()
		{
			IInteractGearComponentT interactGearComponentT = new IInteractGearComponentT();
			this.UnPackTo(interactGearComponentT);
			return interactGearComponentT;
		}

		// Token: 0x060258F3 RID: 153843 RVA: 0x00526E9B File Offset: 0x0052509B
		public void UnPackTo(IInteractGearComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.NormalPrepareTime = this.NormalPrepareTime;
			_o.ActivePrepareTime = this.ActivePrepareTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060258F4 RID: 153844 RVA: 0x00526ED0 File Offset: 0x005250D0
		public static Offset<IInteractGearComponent> Pack(FlatBufferBuilder builder, IInteractGearComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractGearComponent>);
			}
			return IInteractGearComponent.CreateIInteractGearComponent(builder, _o.Disabled, _o.NormalPrepareTime, _o.ActivePrepareTime, _o.NullMask);
		}

		// Token: 0x0400F2FB RID: 62203
		private Table __p;
	}
}
