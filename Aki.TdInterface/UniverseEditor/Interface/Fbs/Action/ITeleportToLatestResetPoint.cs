using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B72 RID: 31602
	public struct ITeleportToLatestResetPoint : IFlatbufferObject
	{
		// Token: 0x1700EC9F RID: 60575
		// (get) Token: 0x06038EA8 RID: 233128 RVA: 0x007B1B1B File Offset: 0x007AFD1B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038EA9 RID: 233129 RVA: 0x007B1B28 File Offset: 0x007AFD28
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038EAA RID: 233130 RVA: 0x007B1B30 File Offset: 0x007AFD30
		public static ITeleportToLatestResetPoint GetRootAsITeleportToLatestResetPoint(ByteBuffer _bb)
		{
			return ITeleportToLatestResetPoint.GetRootAsITeleportToLatestResetPoint(_bb, default(ITeleportToLatestResetPoint));
		}

		// Token: 0x06038EAB RID: 233131 RVA: 0x007B1B4C File Offset: 0x007AFD4C
		public static ITeleportToLatestResetPoint GetRootAsITeleportToLatestResetPoint(ByteBuffer _bb, ITeleportToLatestResetPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038EAC RID: 233132 RVA: 0x007B1B69 File Offset: 0x007AFD69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038EAD RID: 233133 RVA: 0x007B1B78 File Offset: 0x007AFD78
		public ITeleportToLatestResetPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ECA0 RID: 60576
		// (get) Token: 0x06038EAE RID: 233134 RVA: 0x007B1B88 File Offset: 0x007AFD88
		public ITeleportToLatestResetPointDirectly? Option
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new ITeleportToLatestResetPointDirectly?(default(ITeleportToLatestResetPointDirectly).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06038EAF RID: 233135 RVA: 0x007B1BE5 File Offset: 0x007AFDE5
		public static Offset<ITeleportToLatestResetPoint> CreateITeleportToLatestResetPoint(FlatBufferBuilder builder, Offset<ITeleportToLatestResetPointDirectly> OptionOffset = default(Offset<ITeleportToLatestResetPointDirectly>))
		{
			builder.StartTable(1);
			ITeleportToLatestResetPoint.AddOption(builder, OptionOffset);
			return ITeleportToLatestResetPoint.EndITeleportToLatestResetPoint(builder);
		}

		// Token: 0x06038EB0 RID: 233136 RVA: 0x007B1BFB File Offset: 0x007AFDFB
		public static void StartITeleportToLatestResetPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06038EB1 RID: 233137 RVA: 0x007B1C04 File Offset: 0x007AFE04
		public static void AddOption(FlatBufferBuilder builder, Offset<ITeleportToLatestResetPointDirectly> optionOffset)
		{
			builder.AddOffset(0, optionOffset.Value, 0);
		}

		// Token: 0x06038EB2 RID: 233138 RVA: 0x007B1C14 File Offset: 0x007AFE14
		public static Offset<ITeleportToLatestResetPoint> EndITeleportToLatestResetPoint(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportToLatestResetPoint>(builder.EndTable());
		}

		// Token: 0x06038EB3 RID: 233139 RVA: 0x007B1C24 File Offset: 0x007AFE24
		public ITeleportToLatestResetPointT UnPack()
		{
			ITeleportToLatestResetPointT teleportToLatestResetPointT = new ITeleportToLatestResetPointT();
			this.UnPackTo(teleportToLatestResetPointT);
			return teleportToLatestResetPointT;
		}

		// Token: 0x06038EB4 RID: 233140 RVA: 0x007B1C40 File Offset: 0x007AFE40
		public void UnPackTo(ITeleportToLatestResetPointT _o)
		{
			_o.Option = ((this.Option != null) ? this.Option.Value.UnPack() : null);
		}

		// Token: 0x06038EB5 RID: 233141 RVA: 0x007B1C7C File Offset: 0x007AFE7C
		public static Offset<ITeleportToLatestResetPoint> Pack(FlatBufferBuilder builder, ITeleportToLatestResetPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportToLatestResetPoint>);
			}
			Offset<ITeleportToLatestResetPointDirectly> optionOffset = (_o.Option == null) ? default(Offset<ITeleportToLatestResetPointDirectly>) : ITeleportToLatestResetPointDirectly.Pack(builder, _o.Option);
			return ITeleportToLatestResetPoint.CreateITeleportToLatestResetPoint(builder, optionOffset);
		}

		// Token: 0x040131BF RID: 78271
		private Table __p;
	}
}
