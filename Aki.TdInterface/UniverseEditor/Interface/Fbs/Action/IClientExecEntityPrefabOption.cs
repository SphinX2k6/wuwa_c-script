using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A32 RID: 27186
	public struct IClientExecEntityPrefabOption : IFlatbufferObject
	{
		// Token: 0x1700C7CD RID: 51149
		// (get) Token: 0x0602EA23 RID: 191011 RVA: 0x0065BAF7 File Offset: 0x00659CF7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EA24 RID: 191012 RVA: 0x0065BB04 File Offset: 0x00659D04
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EA25 RID: 191013 RVA: 0x0065BB0C File Offset: 0x00659D0C
		public static IClientExecEntityPrefabOption GetRootAsIClientExecEntityPrefabOption(ByteBuffer _bb)
		{
			return IClientExecEntityPrefabOption.GetRootAsIClientExecEntityPrefabOption(_bb, default(IClientExecEntityPrefabOption));
		}

		// Token: 0x0602EA26 RID: 191014 RVA: 0x0065BB28 File Offset: 0x00659D28
		public static IClientExecEntityPrefabOption GetRootAsIClientExecEntityPrefabOption(ByteBuffer _bb, IClientExecEntityPrefabOption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EA27 RID: 191015 RVA: 0x0065BB45 File Offset: 0x00659D45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EA28 RID: 191016 RVA: 0x0065BB54 File Offset: 0x00659D54
		public IClientExecEntityPrefabOption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C7CE RID: 51150
		// (get) Token: 0x0602EA29 RID: 191017 RVA: 0x0065BB64 File Offset: 0x00659D64
		public EClientExecEntityPrefabOption Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EClientExecEntityPrefabOption.ModifyPrefabParams;
				}
				return (EClientExecEntityPrefabOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602EA2A RID: 191018 RVA: 0x0065BBA0 File Offset: 0x00659DA0
		public static Offset<IClientExecEntityPrefabOption> CreateIClientExecEntityPrefabOption(FlatBufferBuilder builder, EClientExecEntityPrefabOption Type = EClientExecEntityPrefabOption.ModifyPrefabParams)
		{
			builder.StartTable(1);
			IClientExecEntityPrefabOption.AddType(builder, Type);
			return IClientExecEntityPrefabOption.EndIClientExecEntityPrefabOption(builder);
		}

		// Token: 0x0602EA2B RID: 191019 RVA: 0x0065BBB6 File Offset: 0x00659DB6
		public static void StartIClientExecEntityPrefabOption(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602EA2C RID: 191020 RVA: 0x0065BBBF File Offset: 0x00659DBF
		public static void AddType(FlatBufferBuilder builder, EClientExecEntityPrefabOption type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EA2D RID: 191021 RVA: 0x0065BBCA File Offset: 0x00659DCA
		public static Offset<IClientExecEntityPrefabOption> EndIClientExecEntityPrefabOption(FlatBufferBuilder builder)
		{
			return new Offset<IClientExecEntityPrefabOption>(builder.EndTable());
		}

		// Token: 0x0602EA2E RID: 191022 RVA: 0x0065BBD8 File Offset: 0x00659DD8
		public IClientExecEntityPrefabOptionT UnPack()
		{
			IClientExecEntityPrefabOptionT clientExecEntityPrefabOptionT = new IClientExecEntityPrefabOptionT();
			this.UnPackTo(clientExecEntityPrefabOptionT);
			return clientExecEntityPrefabOptionT;
		}

		// Token: 0x0602EA2F RID: 191023 RVA: 0x0065BBF3 File Offset: 0x00659DF3
		public void UnPackTo(IClientExecEntityPrefabOptionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602EA30 RID: 191024 RVA: 0x0065BC04 File Offset: 0x00659E04
		public static Offset<IClientExecEntityPrefabOption> Pack(FlatBufferBuilder builder, IClientExecEntityPrefabOptionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientExecEntityPrefabOption>);
			}
			return IClientExecEntityPrefabOption.CreateIClientExecEntityPrefabOption(builder, _o.Type);
		}

		// Token: 0x040117AD RID: 71597
		private Table __p;
	}
}
