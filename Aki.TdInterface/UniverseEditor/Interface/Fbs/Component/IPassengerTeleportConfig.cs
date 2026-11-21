using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C60 RID: 23648
	public struct IPassengerTeleportConfig : IFlatbufferObject
	{
		// Token: 0x1700ADD5 RID: 44501
		// (get) Token: 0x060273C1 RID: 160705 RVA: 0x0056006A File Offset: 0x0055E26A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060273C2 RID: 160706 RVA: 0x00560077 File Offset: 0x0055E277
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060273C3 RID: 160707 RVA: 0x00560080 File Offset: 0x0055E280
		public static IPassengerTeleportConfig GetRootAsIPassengerTeleportConfig(ByteBuffer _bb)
		{
			return IPassengerTeleportConfig.GetRootAsIPassengerTeleportConfig(_bb, default(IPassengerTeleportConfig));
		}

		// Token: 0x060273C4 RID: 160708 RVA: 0x0056009C File Offset: 0x0055E29C
		public static IPassengerTeleportConfig GetRootAsIPassengerTeleportConfig(ByteBuffer _bb, IPassengerTeleportConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060273C5 RID: 160709 RVA: 0x005600B9 File Offset: 0x0055E2B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060273C6 RID: 160710 RVA: 0x005600C8 File Offset: 0x0055E2C8
		public IPassengerTeleportConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ADD6 RID: 44502
		// (get) Token: 0x060273C7 RID: 160711 RVA: 0x005600D8 File Offset: 0x0055E2D8
		public IPosA? PosA
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IPosA?(default(IPosA).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060273C8 RID: 160712 RVA: 0x00560135 File Offset: 0x0055E335
		public static Offset<IPassengerTeleportConfig> CreateIPassengerTeleportConfig(FlatBufferBuilder builder, Offset<IPosA> PosAOffset = default(Offset<IPosA>))
		{
			builder.StartTable(1);
			IPassengerTeleportConfig.AddPosA(builder, PosAOffset);
			return IPassengerTeleportConfig.EndIPassengerTeleportConfig(builder);
		}

		// Token: 0x060273C9 RID: 160713 RVA: 0x0056014B File Offset: 0x0055E34B
		public static void StartIPassengerTeleportConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060273CA RID: 160714 RVA: 0x00560154 File Offset: 0x0055E354
		public static void AddPosA(FlatBufferBuilder builder, Offset<IPosA> posAOffset)
		{
			builder.AddOffset(0, posAOffset.Value, 0);
		}

		// Token: 0x060273CB RID: 160715 RVA: 0x00560164 File Offset: 0x0055E364
		public static Offset<IPassengerTeleportConfig> EndIPassengerTeleportConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPassengerTeleportConfig>(builder.EndTable());
		}

		// Token: 0x060273CC RID: 160716 RVA: 0x00560174 File Offset: 0x0055E374
		public IPassengerTeleportConfigT UnPack()
		{
			IPassengerTeleportConfigT passengerTeleportConfigT = new IPassengerTeleportConfigT();
			this.UnPackTo(passengerTeleportConfigT);
			return passengerTeleportConfigT;
		}

		// Token: 0x060273CD RID: 160717 RVA: 0x00560190 File Offset: 0x0055E390
		public void UnPackTo(IPassengerTeleportConfigT _o)
		{
			_o.PosA = ((this.PosA != null) ? this.PosA.Value.UnPack() : null);
		}

		// Token: 0x060273CE RID: 160718 RVA: 0x005601CC File Offset: 0x0055E3CC
		public static Offset<IPassengerTeleportConfig> Pack(FlatBufferBuilder builder, IPassengerTeleportConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPassengerTeleportConfig>);
			}
			Offset<IPosA> posAOffset = (_o.PosA == null) ? default(Offset<IPosA>) : IPosA.Pack(builder, _o.PosA);
			return IPassengerTeleportConfig.CreateIPassengerTeleportConfig(builder, posAOffset);
		}

		// Token: 0x0400F760 RID: 63328
		private Table __p;
	}
}
