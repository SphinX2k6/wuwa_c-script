using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B75 RID: 31605
	public struct ITeleportToLatestResetPointDirectly : IFlatbufferObject
	{
		// Token: 0x1700ECA2 RID: 60578
		// (get) Token: 0x06038EBA RID: 233146 RVA: 0x007B1D17 File Offset: 0x007AFF17
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038EBB RID: 233147 RVA: 0x007B1D24 File Offset: 0x007AFF24
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038EBC RID: 233148 RVA: 0x007B1D2C File Offset: 0x007AFF2C
		public static ITeleportToLatestResetPointDirectly GetRootAsITeleportToLatestResetPointDirectly(ByteBuffer _bb)
		{
			return ITeleportToLatestResetPointDirectly.GetRootAsITeleportToLatestResetPointDirectly(_bb, default(ITeleportToLatestResetPointDirectly));
		}

		// Token: 0x06038EBD RID: 233149 RVA: 0x007B1D48 File Offset: 0x007AFF48
		public static ITeleportToLatestResetPointDirectly GetRootAsITeleportToLatestResetPointDirectly(ByteBuffer _bb, ITeleportToLatestResetPointDirectly obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038EBE RID: 233150 RVA: 0x007B1D65 File Offset: 0x007AFF65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038EBF RID: 233151 RVA: 0x007B1D74 File Offset: 0x007AFF74
		public ITeleportToLatestResetPointDirectly __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ECA3 RID: 60579
		// (get) Token: 0x06038EC0 RID: 233152 RVA: 0x007B1D84 File Offset: 0x007AFF84
		public ETeleportToLatestResetPointType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETeleportToLatestResetPointType.Directly;
				}
				return (ETeleportToLatestResetPointType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06038EC1 RID: 233153 RVA: 0x007B1DC0 File Offset: 0x007AFFC0
		public static Offset<ITeleportToLatestResetPointDirectly> CreateITeleportToLatestResetPointDirectly(FlatBufferBuilder builder, ETeleportToLatestResetPointType Type = ETeleportToLatestResetPointType.Directly)
		{
			builder.StartTable(1);
			ITeleportToLatestResetPointDirectly.AddType(builder, Type);
			return ITeleportToLatestResetPointDirectly.EndITeleportToLatestResetPointDirectly(builder);
		}

		// Token: 0x06038EC2 RID: 233154 RVA: 0x007B1DD6 File Offset: 0x007AFFD6
		public static void StartITeleportToLatestResetPointDirectly(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06038EC3 RID: 233155 RVA: 0x007B1DDF File Offset: 0x007AFFDF
		public static void AddType(FlatBufferBuilder builder, ETeleportToLatestResetPointType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06038EC4 RID: 233156 RVA: 0x007B1DEA File Offset: 0x007AFFEA
		public static Offset<ITeleportToLatestResetPointDirectly> EndITeleportToLatestResetPointDirectly(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportToLatestResetPointDirectly>(builder.EndTable());
		}

		// Token: 0x06038EC5 RID: 233157 RVA: 0x007B1DF8 File Offset: 0x007AFFF8
		public ITeleportToLatestResetPointDirectlyT UnPack()
		{
			ITeleportToLatestResetPointDirectlyT teleportToLatestResetPointDirectlyT = new ITeleportToLatestResetPointDirectlyT();
			this.UnPackTo(teleportToLatestResetPointDirectlyT);
			return teleportToLatestResetPointDirectlyT;
		}

		// Token: 0x06038EC6 RID: 233158 RVA: 0x007B1E13 File Offset: 0x007B0013
		public void UnPackTo(ITeleportToLatestResetPointDirectlyT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06038EC7 RID: 233159 RVA: 0x007B1E24 File Offset: 0x007B0024
		public static Offset<ITeleportToLatestResetPointDirectly> Pack(FlatBufferBuilder builder, ITeleportToLatestResetPointDirectlyT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportToLatestResetPointDirectly>);
			}
			return ITeleportToLatestResetPointDirectly.CreateITeleportToLatestResetPointDirectly(builder, _o.Type);
		}

		// Token: 0x040131C1 RID: 78273
		private Table __p;
	}
}
