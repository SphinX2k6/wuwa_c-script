using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005455 RID: 21589
	public struct IInteractGearComponent : IFlatbufferObject
	{
		// Token: 0x17009EF1 RID: 40689
		// (get) Token: 0x06023829 RID: 145449 RVA: 0x004E9C24 File Offset: 0x004E7E24
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602382A RID: 145450 RVA: 0x004E9C31 File Offset: 0x004E7E31
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602382B RID: 145451 RVA: 0x004E9C38 File Offset: 0x004E7E38
		public static IInteractGearComponent GetRootAsIInteractGearComponent(ByteBuffer _bb)
		{
			return IInteractGearComponent.GetRootAsIInteractGearComponent(_bb, default(IInteractGearComponent));
		}

		// Token: 0x0602382C RID: 145452 RVA: 0x004E9C54 File Offset: 0x004E7E54
		public static IInteractGearComponent GetRootAsIInteractGearComponent(ByteBuffer _bb, IInteractGearComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602382D RID: 145453 RVA: 0x004E9C71 File Offset: 0x004E7E71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602382E RID: 145454 RVA: 0x004E9C80 File Offset: 0x004E7E80
		public IInteractGearComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009EF2 RID: 40690
		// (get) Token: 0x0602382F RID: 145455 RVA: 0x004E9C90 File Offset: 0x004E7E90
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009EF3 RID: 40691
		// (get) Token: 0x06023830 RID: 145456 RVA: 0x004E9CD0 File Offset: 0x004E7ED0
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

		// Token: 0x17009EF4 RID: 40692
		// (get) Token: 0x06023831 RID: 145457 RVA: 0x004E9D10 File Offset: 0x004E7F10
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

		// Token: 0x17009EF5 RID: 40693
		// (get) Token: 0x06023832 RID: 145458 RVA: 0x004E9D50 File Offset: 0x004E7F50
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

		// Token: 0x06023833 RID: 145459 RVA: 0x004E9D8D File Offset: 0x004E7F8D
		public static Offset<IInteractGearComponent> CreateIInteractGearComponent(FlatBufferBuilder builder, bool Disabled = false, float NormalPrepareTime = 0f, float ActivePrepareTime = 0f, byte NullMask = 0)
		{
			builder.StartTable(4);
			IInteractGearComponent.AddActivePrepareTime(builder, ActivePrepareTime);
			IInteractGearComponent.AddNormalPrepareTime(builder, NormalPrepareTime);
			IInteractGearComponent.AddNullMask(builder, NullMask);
			IInteractGearComponent.AddDisabled(builder, Disabled);
			return IInteractGearComponent.EndIInteractGearComponent(builder);
		}

		// Token: 0x06023834 RID: 145460 RVA: 0x004E9DB9 File Offset: 0x004E7FB9
		public static void StartIInteractGearComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06023835 RID: 145461 RVA: 0x004E9DC2 File Offset: 0x004E7FC2
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06023836 RID: 145462 RVA: 0x004E9DCD File Offset: 0x004E7FCD
		public static void AddNormalPrepareTime(FlatBufferBuilder builder, float normalPrepareTime)
		{
			builder.AddFloat(1, normalPrepareTime, 0.0);
		}

		// Token: 0x06023837 RID: 145463 RVA: 0x004E9DE0 File Offset: 0x004E7FE0
		public static void AddActivePrepareTime(FlatBufferBuilder builder, float activePrepareTime)
		{
			builder.AddFloat(2, activePrepareTime, 0.0);
		}

		// Token: 0x06023838 RID: 145464 RVA: 0x004E9DF3 File Offset: 0x004E7FF3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06023839 RID: 145465 RVA: 0x004E9DFE File Offset: 0x004E7FFE
		public static Offset<IInteractGearComponent> EndIInteractGearComponent(FlatBufferBuilder builder)
		{
			return new Offset<IInteractGearComponent>(builder.EndTable());
		}

		// Token: 0x0602383A RID: 145466 RVA: 0x004E9E0C File Offset: 0x004E800C
		public IInteractGearComponentT UnPack()
		{
			IInteractGearComponentT interactGearComponentT = new IInteractGearComponentT();
			this.UnPackTo(interactGearComponentT);
			return interactGearComponentT;
		}

		// Token: 0x0602383B RID: 145467 RVA: 0x004E9E27 File Offset: 0x004E8027
		public void UnPackTo(IInteractGearComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.NormalPrepareTime = this.NormalPrepareTime;
			_o.ActivePrepareTime = this.ActivePrepareTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602383C RID: 145468 RVA: 0x004E9E5C File Offset: 0x004E805C
		public static Offset<IInteractGearComponent> Pack(FlatBufferBuilder builder, IInteractGearComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractGearComponent>);
			}
			return IInteractGearComponent.CreateIInteractGearComponent(builder, _o.Disabled, _o.NormalPrepareTime, _o.ActivePrepareTime, _o.NullMask);
		}

		// Token: 0x0400E6CA RID: 59082
		private Table __p;
	}
}
