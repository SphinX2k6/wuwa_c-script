using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C8C RID: 27788
	public struct IDurationInteract : IFlatbufferObject
	{
		// Token: 0x1700CBD8 RID: 52184
		// (get) Token: 0x0602FE16 RID: 196118 RVA: 0x00684F9A File Offset: 0x0068319A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FE17 RID: 196119 RVA: 0x00684FA7 File Offset: 0x006831A7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FE18 RID: 196120 RVA: 0x00684FB0 File Offset: 0x006831B0
		public static IDurationInteract GetRootAsIDurationInteract(ByteBuffer _bb)
		{
			return IDurationInteract.GetRootAsIDurationInteract(_bb, default(IDurationInteract));
		}

		// Token: 0x0602FE19 RID: 196121 RVA: 0x00684FCC File Offset: 0x006831CC
		public static IDurationInteract GetRootAsIDurationInteract(ByteBuffer _bb, IDurationInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FE1A RID: 196122 RVA: 0x00684FE9 File Offset: 0x006831E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FE1B RID: 196123 RVA: 0x00684FF8 File Offset: 0x006831F8
		public IDurationInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CBD9 RID: 52185
		// (get) Token: 0x0602FE1C RID: 196124 RVA: 0x00685008 File Offset: 0x00683208
		public float Duration
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FE1D RID: 196125 RVA: 0x00685048 File Offset: 0x00683248
		public static Offset<IDurationInteract> CreateIDurationInteract(FlatBufferBuilder builder, float Duration = 0f)
		{
			builder.StartTable(1);
			IDurationInteract.AddDuration(builder, Duration);
			return IDurationInteract.EndIDurationInteract(builder);
		}

		// Token: 0x0602FE1E RID: 196126 RVA: 0x0068505E File Offset: 0x0068325E
		public static void StartIDurationInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602FE1F RID: 196127 RVA: 0x00685067 File Offset: 0x00683267
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(0, duration, 0.0);
		}

		// Token: 0x0602FE20 RID: 196128 RVA: 0x0068507A File Offset: 0x0068327A
		public static Offset<IDurationInteract> EndIDurationInteract(FlatBufferBuilder builder)
		{
			return new Offset<IDurationInteract>(builder.EndTable());
		}

		// Token: 0x0602FE21 RID: 196129 RVA: 0x00685088 File Offset: 0x00683288
		public IDurationInteractT UnPack()
		{
			IDurationInteractT durationInteractT = new IDurationInteractT();
			this.UnPackTo(durationInteractT);
			return durationInteractT;
		}

		// Token: 0x0602FE22 RID: 196130 RVA: 0x006850A3 File Offset: 0x006832A3
		public void UnPackTo(IDurationInteractT _o)
		{
			_o.Duration = this.Duration;
		}

		// Token: 0x0602FE23 RID: 196131 RVA: 0x006850B4 File Offset: 0x006832B4
		public static Offset<IDurationInteract> Pack(FlatBufferBuilder builder, IDurationInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDurationInteract>);
			}
			return IDurationInteract.CreateIDurationInteract(builder, _o.Duration);
		}

		// Token: 0x04011AC4 RID: 72388
		private Table __p;
	}
}
