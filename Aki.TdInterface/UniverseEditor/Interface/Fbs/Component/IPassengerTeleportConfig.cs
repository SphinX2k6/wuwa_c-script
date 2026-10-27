using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056BC RID: 22204
	public struct IPassengerTeleportConfig : IFlatbufferObject
	{
		// Token: 0x1700A541 RID: 42305
		// (get) Token: 0x0602516C RID: 151916 RVA: 0x0051F122 File Offset: 0x0051D322
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602516D RID: 151917 RVA: 0x0051F12F File Offset: 0x0051D32F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602516E RID: 151918 RVA: 0x0051F138 File Offset: 0x0051D338
		public static IPassengerTeleportConfig GetRootAsIPassengerTeleportConfig(ByteBuffer _bb)
		{
			return IPassengerTeleportConfig.GetRootAsIPassengerTeleportConfig(_bb, default(IPassengerTeleportConfig));
		}

		// Token: 0x0602516F RID: 151919 RVA: 0x0051F154 File Offset: 0x0051D354
		public static IPassengerTeleportConfig GetRootAsIPassengerTeleportConfig(ByteBuffer _bb, IPassengerTeleportConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025170 RID: 151920 RVA: 0x0051F171 File Offset: 0x0051D371
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025171 RID: 151921 RVA: 0x0051F180 File Offset: 0x0051D380
		public IPassengerTeleportConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A542 RID: 42306
		// (get) Token: 0x06025172 RID: 151922 RVA: 0x0051F190 File Offset: 0x0051D390
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

		// Token: 0x06025173 RID: 151923 RVA: 0x0051F1ED File Offset: 0x0051D3ED
		public static Offset<IPassengerTeleportConfig> CreateIPassengerTeleportConfig(FlatBufferBuilder builder, Offset<IPosA> PosAOffset = default(Offset<IPosA>))
		{
			builder.StartTable(1);
			IPassengerTeleportConfig.AddPosA(builder, PosAOffset);
			return IPassengerTeleportConfig.EndIPassengerTeleportConfig(builder);
		}

		// Token: 0x06025174 RID: 151924 RVA: 0x0051F203 File Offset: 0x0051D403
		public static void StartIPassengerTeleportConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06025175 RID: 151925 RVA: 0x0051F20C File Offset: 0x0051D40C
		public static void AddPosA(FlatBufferBuilder builder, Offset<IPosA> posAOffset)
		{
			builder.AddOffset(0, posAOffset.Value, 0);
		}

		// Token: 0x06025176 RID: 151926 RVA: 0x0051F21C File Offset: 0x0051D41C
		public static Offset<IPassengerTeleportConfig> EndIPassengerTeleportConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPassengerTeleportConfig>(builder.EndTable());
		}

		// Token: 0x06025177 RID: 151927 RVA: 0x0051F22C File Offset: 0x0051D42C
		public IPassengerTeleportConfigT UnPack()
		{
			IPassengerTeleportConfigT passengerTeleportConfigT = new IPassengerTeleportConfigT();
			this.UnPackTo(passengerTeleportConfigT);
			return passengerTeleportConfigT;
		}

		// Token: 0x06025178 RID: 151928 RVA: 0x0051F248 File Offset: 0x0051D448
		public void UnPackTo(IPassengerTeleportConfigT _o)
		{
			_o.PosA = ((this.PosA != null) ? this.PosA.Value.UnPack() : null);
		}

		// Token: 0x06025179 RID: 151929 RVA: 0x0051F284 File Offset: 0x0051D484
		public static Offset<IPassengerTeleportConfig> Pack(FlatBufferBuilder builder, IPassengerTeleportConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPassengerTeleportConfig>);
			}
			Offset<IPosA> posAOffset = (_o.PosA == null) ? default(Offset<IPosA>) : IPosA.Pack(builder, _o.PosA);
			return IPassengerTeleportConfig.CreateIPassengerTeleportConfig(builder, posAOffset);
		}

		// Token: 0x0400EAF4 RID: 60148
		private Table __p;
	}
}
