using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E8C RID: 16012
	public struct IFishIdleState : IFlatbufferObject
	{
		// Token: 0x17006C3A RID: 27706
		// (get) Token: 0x060159CA RID: 88522 RVA: 0x0031D4AB File Offset: 0x0031B6AB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060159CB RID: 88523 RVA: 0x0031D4B8 File Offset: 0x0031B6B8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060159CC RID: 88524 RVA: 0x0031D4C0 File Offset: 0x0031B6C0
		public static IFishIdleState GetRootAsIFishIdleState(ByteBuffer _bb)
		{
			return IFishIdleState.GetRootAsIFishIdleState(_bb, default(IFishIdleState));
		}

		// Token: 0x060159CD RID: 88525 RVA: 0x0031D4DC File Offset: 0x0031B6DC
		public static IFishIdleState GetRootAsIFishIdleState(ByteBuffer _bb, IFishIdleState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060159CE RID: 88526 RVA: 0x0031D4F9 File Offset: 0x0031B6F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060159CF RID: 88527 RVA: 0x0031D508 File Offset: 0x0031B708
		public IFishIdleState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006C3B RID: 27707
		// (get) Token: 0x060159D0 RID: 88528 RVA: 0x0031D518 File Offset: 0x0031B718
		public EFishState Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFishState.Idle;
				}
				return (EFishState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006C3C RID: 27708
		// (get) Token: 0x060159D1 RID: 88529 RVA: 0x0031D554 File Offset: 0x0031B754
		public bool EnableFlee
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006C3D RID: 27709
		// (get) Token: 0x060159D2 RID: 88530 RVA: 0x0031D594 File Offset: 0x0031B794
		public float FleeRadius
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

		// Token: 0x17006C3E RID: 27710
		// (get) Token: 0x060159D3 RID: 88531 RVA: 0x0031D5D4 File Offset: 0x0031B7D4
		public bool UseRangeComponent
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006C3F RID: 27711
		// (get) Token: 0x060159D4 RID: 88532 RVA: 0x0031D614 File Offset: 0x0031B814
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060159D5 RID: 88533 RVA: 0x0031D651 File Offset: 0x0031B851
		public static Offset<IFishIdleState> CreateIFishIdleState(FlatBufferBuilder builder, EFishState Type = EFishState.Idle, bool EnableFlee = false, float FleeRadius = 0f, bool UseRangeComponent = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			IFishIdleState.AddFleeRadius(builder, FleeRadius);
			IFishIdleState.AddNullMask(builder, NullMask);
			IFishIdleState.AddUseRangeComponent(builder, UseRangeComponent);
			IFishIdleState.AddEnableFlee(builder, EnableFlee);
			IFishIdleState.AddType(builder, Type);
			return IFishIdleState.EndIFishIdleState(builder);
		}

		// Token: 0x060159D6 RID: 88534 RVA: 0x0031D685 File Offset: 0x0031B885
		public static void StartIFishIdleState(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060159D7 RID: 88535 RVA: 0x0031D68E File Offset: 0x0031B88E
		public static void AddType(FlatBufferBuilder builder, EFishState type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060159D8 RID: 88536 RVA: 0x0031D699 File Offset: 0x0031B899
		public static void AddEnableFlee(FlatBufferBuilder builder, bool enableFlee)
		{
			builder.AddBool(1, enableFlee, false);
		}

		// Token: 0x060159D9 RID: 88537 RVA: 0x0031D6A4 File Offset: 0x0031B8A4
		public static void AddFleeRadius(FlatBufferBuilder builder, float fleeRadius)
		{
			builder.AddFloat(2, fleeRadius, 0.0);
		}

		// Token: 0x060159DA RID: 88538 RVA: 0x0031D6B7 File Offset: 0x0031B8B7
		public static void AddUseRangeComponent(FlatBufferBuilder builder, bool useRangeComponent)
		{
			builder.AddBool(3, useRangeComponent, false);
		}

		// Token: 0x060159DB RID: 88539 RVA: 0x0031D6C2 File Offset: 0x0031B8C2
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060159DC RID: 88540 RVA: 0x0031D6CD File Offset: 0x0031B8CD
		public static Offset<IFishIdleState> EndIFishIdleState(FlatBufferBuilder builder)
		{
			return new Offset<IFishIdleState>(builder.EndTable());
		}

		// Token: 0x060159DD RID: 88541 RVA: 0x0031D6DC File Offset: 0x0031B8DC
		public IFishIdleStateT UnPack()
		{
			IFishIdleStateT fishIdleStateT = new IFishIdleStateT();
			this.UnPackTo(fishIdleStateT);
			return fishIdleStateT;
		}

		// Token: 0x060159DE RID: 88542 RVA: 0x0031D6F7 File Offset: 0x0031B8F7
		public void UnPackTo(IFishIdleStateT _o)
		{
			_o.Type = this.Type;
			_o.EnableFlee = this.EnableFlee;
			_o.FleeRadius = this.FleeRadius;
			_o.UseRangeComponent = this.UseRangeComponent;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060159DF RID: 88543 RVA: 0x0031D738 File Offset: 0x0031B938
		public static Offset<IFishIdleState> Pack(FlatBufferBuilder builder, IFishIdleStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFishIdleState>);
			}
			return IFishIdleState.CreateIFishIdleState(builder, _o.Type, _o.EnableFlee, _o.FleeRadius, _o.UseRangeComponent, _o.NullMask);
		}

		// Token: 0x0400B867 RID: 47207
		private Table __p;
	}
}
