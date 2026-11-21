using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007276 RID: 29302
	public struct IMotorSoarInteract : IFlatbufferObject
	{
		// Token: 0x1700D6CE RID: 54990
		// (get) Token: 0x060330EE RID: 209134 RVA: 0x006E42A4 File Offset: 0x006E24A4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060330EF RID: 209135 RVA: 0x006E42B1 File Offset: 0x006E24B1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060330F0 RID: 209136 RVA: 0x006E42B8 File Offset: 0x006E24B8
		public static IMotorSoarInteract GetRootAsIMotorSoarInteract(ByteBuffer _bb)
		{
			return IMotorSoarInteract.GetRootAsIMotorSoarInteract(_bb, default(IMotorSoarInteract));
		}

		// Token: 0x060330F1 RID: 209137 RVA: 0x006E42D4 File Offset: 0x006E24D4
		public static IMotorSoarInteract GetRootAsIMotorSoarInteract(ByteBuffer _bb, IMotorSoarInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060330F2 RID: 209138 RVA: 0x006E42F1 File Offset: 0x006E24F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060330F3 RID: 209139 RVA: 0x006E4300 File Offset: 0x006E2500
		public IMotorSoarInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D6CF RID: 54991
		// (get) Token: 0x060330F4 RID: 209140 RVA: 0x006E4310 File Offset: 0x006E2510
		public ELeisureInteract Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELeisureInteract.CustomSkill;
				}
				return (ELeisureInteract)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060330F5 RID: 209141 RVA: 0x006E434C File Offset: 0x006E254C
		public static Offset<IMotorSoarInteract> CreateIMotorSoarInteract(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IMotorSoarInteract.AddType(builder, Type);
			return IMotorSoarInteract.EndIMotorSoarInteract(builder);
		}

		// Token: 0x060330F6 RID: 209142 RVA: 0x006E4362 File Offset: 0x006E2562
		public static void StartIMotorSoarInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060330F7 RID: 209143 RVA: 0x006E436B File Offset: 0x006E256B
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060330F8 RID: 209144 RVA: 0x006E4376 File Offset: 0x006E2576
		public static Offset<IMotorSoarInteract> EndIMotorSoarInteract(FlatBufferBuilder builder)
		{
			return new Offset<IMotorSoarInteract>(builder.EndTable());
		}

		// Token: 0x060330F9 RID: 209145 RVA: 0x006E4384 File Offset: 0x006E2584
		public IMotorSoarInteractT UnPack()
		{
			IMotorSoarInteractT motorSoarInteractT = new IMotorSoarInteractT();
			this.UnPackTo(motorSoarInteractT);
			return motorSoarInteractT;
		}

		// Token: 0x060330FA RID: 209146 RVA: 0x006E439F File Offset: 0x006E259F
		public void UnPackTo(IMotorSoarInteractT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060330FB RID: 209147 RVA: 0x006E43B0 File Offset: 0x006E25B0
		public static Offset<IMotorSoarInteract> Pack(FlatBufferBuilder builder, IMotorSoarInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorSoarInteract>);
			}
			return IMotorSoarInteract.CreateIMotorSoarInteract(builder, _o.Type);
		}

		// Token: 0x040122F2 RID: 74482
		private Table __p;
	}
}
