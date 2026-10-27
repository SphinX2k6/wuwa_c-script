using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200738B RID: 29579
	public struct ITeleportToLatestResetPoint : IFlatbufferObject
	{
		// Token: 0x1700E08F RID: 57487
		// (get) Token: 0x06035B0D RID: 219917 RVA: 0x0074F5DB File Offset: 0x0074D7DB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035B0E RID: 219918 RVA: 0x0074F5E8 File Offset: 0x0074D7E8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035B0F RID: 219919 RVA: 0x0074F5F0 File Offset: 0x0074D7F0
		public static ITeleportToLatestResetPoint GetRootAsITeleportToLatestResetPoint(ByteBuffer _bb)
		{
			return ITeleportToLatestResetPoint.GetRootAsITeleportToLatestResetPoint(_bb, default(ITeleportToLatestResetPoint));
		}

		// Token: 0x06035B10 RID: 219920 RVA: 0x0074F60C File Offset: 0x0074D80C
		public static ITeleportToLatestResetPoint GetRootAsITeleportToLatestResetPoint(ByteBuffer _bb, ITeleportToLatestResetPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035B11 RID: 219921 RVA: 0x0074F629 File Offset: 0x0074D829
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035B12 RID: 219922 RVA: 0x0074F638 File Offset: 0x0074D838
		public ITeleportToLatestResetPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E090 RID: 57488
		// (get) Token: 0x06035B13 RID: 219923 RVA: 0x0074F648 File Offset: 0x0074D848
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

		// Token: 0x06035B14 RID: 219924 RVA: 0x0074F6A5 File Offset: 0x0074D8A5
		public static Offset<ITeleportToLatestResetPoint> CreateITeleportToLatestResetPoint(FlatBufferBuilder builder, Offset<ITeleportToLatestResetPointDirectly> OptionOffset = default(Offset<ITeleportToLatestResetPointDirectly>))
		{
			builder.StartTable(1);
			ITeleportToLatestResetPoint.AddOption(builder, OptionOffset);
			return ITeleportToLatestResetPoint.EndITeleportToLatestResetPoint(builder);
		}

		// Token: 0x06035B15 RID: 219925 RVA: 0x0074F6BB File Offset: 0x0074D8BB
		public static void StartITeleportToLatestResetPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035B16 RID: 219926 RVA: 0x0074F6C4 File Offset: 0x0074D8C4
		public static void AddOption(FlatBufferBuilder builder, Offset<ITeleportToLatestResetPointDirectly> optionOffset)
		{
			builder.AddOffset(0, optionOffset.Value, 0);
		}

		// Token: 0x06035B17 RID: 219927 RVA: 0x0074F6D4 File Offset: 0x0074D8D4
		public static Offset<ITeleportToLatestResetPoint> EndITeleportToLatestResetPoint(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportToLatestResetPoint>(builder.EndTable());
		}

		// Token: 0x06035B18 RID: 219928 RVA: 0x0074F6E4 File Offset: 0x0074D8E4
		public ITeleportToLatestResetPointT UnPack()
		{
			ITeleportToLatestResetPointT teleportToLatestResetPointT = new ITeleportToLatestResetPointT();
			this.UnPackTo(teleportToLatestResetPointT);
			return teleportToLatestResetPointT;
		}

		// Token: 0x06035B19 RID: 219929 RVA: 0x0074F700 File Offset: 0x0074D900
		public void UnPackTo(ITeleportToLatestResetPointT _o)
		{
			_o.Option = ((this.Option != null) ? this.Option.Value.UnPack() : null);
		}

		// Token: 0x06035B1A RID: 219930 RVA: 0x0074F73C File Offset: 0x0074D93C
		public static Offset<ITeleportToLatestResetPoint> Pack(FlatBufferBuilder builder, ITeleportToLatestResetPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportToLatestResetPoint>);
			}
			Offset<ITeleportToLatestResetPointDirectly> optionOffset = (_o.Option == null) ? default(Offset<ITeleportToLatestResetPointDirectly>) : ITeleportToLatestResetPointDirectly.Pack(builder, _o.Option);
			return ITeleportToLatestResetPoint.CreateITeleportToLatestResetPoint(builder, optionOffset);
		}

		// Token: 0x040121A6 RID: 74150
		private Table __p;
	}
}
