using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B90 RID: 31632
	public struct ITeleportTransitionWithCenterText : IFlatbufferObject
	{
		// Token: 0x1700ECD4 RID: 60628
		// (get) Token: 0x06038FA0 RID: 233376 RVA: 0x007B362A File Offset: 0x007B182A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038FA1 RID: 233377 RVA: 0x007B3637 File Offset: 0x007B1837
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038FA2 RID: 233378 RVA: 0x007B3640 File Offset: 0x007B1840
		public static ITeleportTransitionWithCenterText GetRootAsITeleportTransitionWithCenterText(ByteBuffer _bb)
		{
			return ITeleportTransitionWithCenterText.GetRootAsITeleportTransitionWithCenterText(_bb, default(ITeleportTransitionWithCenterText));
		}

		// Token: 0x06038FA3 RID: 233379 RVA: 0x007B365C File Offset: 0x007B185C
		public static ITeleportTransitionWithCenterText GetRootAsITeleportTransitionWithCenterText(ByteBuffer _bb, ITeleportTransitionWithCenterText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038FA4 RID: 233380 RVA: 0x007B3679 File Offset: 0x007B1879
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038FA5 RID: 233381 RVA: 0x007B3688 File Offset: 0x007B1888
		public ITeleportTransitionWithCenterText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ECD5 RID: 60629
		// (get) Token: 0x06038FA6 RID: 233382 RVA: 0x007B3698 File Offset: 0x007B1898
		public ETeleportTransitionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETeleportTransitionType.PlayMp4;
				}
				return (ETeleportTransitionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700ECD6 RID: 60630
		// (get) Token: 0x06038FA7 RID: 233383 RVA: 0x007B36D4 File Offset: 0x007B18D4
		public IPlayFlow? CenterTextFlow
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPlayFlow?(default(IPlayFlow).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06038FA8 RID: 233384 RVA: 0x007B3731 File Offset: 0x007B1931
		public static Offset<ITeleportTransitionWithCenterText> CreateITeleportTransitionWithCenterText(FlatBufferBuilder builder, ETeleportTransitionType Type = ETeleportTransitionType.PlayMp4, Offset<IPlayFlow> CenterTextFlowOffset = default(Offset<IPlayFlow>))
		{
			builder.StartTable(2);
			ITeleportTransitionWithCenterText.AddCenterTextFlow(builder, CenterTextFlowOffset);
			ITeleportTransitionWithCenterText.AddType(builder, Type);
			return ITeleportTransitionWithCenterText.EndITeleportTransitionWithCenterText(builder);
		}

		// Token: 0x06038FA9 RID: 233385 RVA: 0x007B374E File Offset: 0x007B194E
		public static void StartITeleportTransitionWithCenterText(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06038FAA RID: 233386 RVA: 0x007B3757 File Offset: 0x007B1957
		public static void AddType(FlatBufferBuilder builder, ETeleportTransitionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06038FAB RID: 233387 RVA: 0x007B3762 File Offset: 0x007B1962
		public static void AddCenterTextFlow(FlatBufferBuilder builder, Offset<IPlayFlow> centerTextFlowOffset)
		{
			builder.AddOffset(1, centerTextFlowOffset.Value, 0);
		}

		// Token: 0x06038FAC RID: 233388 RVA: 0x007B3772 File Offset: 0x007B1972
		public static Offset<ITeleportTransitionWithCenterText> EndITeleportTransitionWithCenterText(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportTransitionWithCenterText>(builder.EndTable());
		}

		// Token: 0x06038FAD RID: 233389 RVA: 0x007B3780 File Offset: 0x007B1980
		public ITeleportTransitionWithCenterTextT UnPack()
		{
			ITeleportTransitionWithCenterTextT teleportTransitionWithCenterTextT = new ITeleportTransitionWithCenterTextT();
			this.UnPackTo(teleportTransitionWithCenterTextT);
			return teleportTransitionWithCenterTextT;
		}

		// Token: 0x06038FAE RID: 233390 RVA: 0x007B379C File Offset: 0x007B199C
		public void UnPackTo(ITeleportTransitionWithCenterTextT _o)
		{
			_o.Type = this.Type;
			_o.CenterTextFlow = ((this.CenterTextFlow != null) ? this.CenterTextFlow.Value.UnPack() : null);
		}

		// Token: 0x06038FAF RID: 233391 RVA: 0x007B37E4 File Offset: 0x007B19E4
		public static Offset<ITeleportTransitionWithCenterText> Pack(FlatBufferBuilder builder, ITeleportTransitionWithCenterTextT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportTransitionWithCenterText>);
			}
			Offset<IPlayFlow> centerTextFlowOffset = (_o.CenterTextFlow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.CenterTextFlow);
			return ITeleportTransitionWithCenterText.CreateITeleportTransitionWithCenterText(builder, _o.Type, centerTextFlowOffset);
		}

		// Token: 0x040131F6 RID: 78326
		private Table __p;
	}
}
