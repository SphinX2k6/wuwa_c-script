using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006188 RID: 24968
	public struct IAlertSystemOption : IFlatbufferObject
	{
		// Token: 0x1700BA29 RID: 47657
		// (get) Token: 0x0602B01C RID: 176156 RVA: 0x005EEDAA File Offset: 0x005ECFAA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B01D RID: 176157 RVA: 0x005EEDB7 File Offset: 0x005ECFB7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B01E RID: 176158 RVA: 0x005EEDC0 File Offset: 0x005ECFC0
		public static IAlertSystemOption GetRootAsIAlertSystemOption(ByteBuffer _bb)
		{
			return IAlertSystemOption.GetRootAsIAlertSystemOption(_bb, default(IAlertSystemOption));
		}

		// Token: 0x0602B01F RID: 176159 RVA: 0x005EEDDC File Offset: 0x005ECFDC
		public static IAlertSystemOption GetRootAsIAlertSystemOption(ByteBuffer _bb, IAlertSystemOption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B020 RID: 176160 RVA: 0x005EEDF9 File Offset: 0x005ECFF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B021 RID: 176161 RVA: 0x005EEE08 File Offset: 0x005ED008
		public IAlertSystemOption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BA2A RID: 47658
		// (get) Token: 0x0602B022 RID: 176162 RVA: 0x005EEE18 File Offset: 0x005ED018
		public EAlertSystemOption Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAlertSystemOption.EnableAlertArea;
				}
				return (EAlertSystemOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BA2B RID: 47659
		// (get) Token: 0x0602B023 RID: 176163 RVA: 0x005EEE54 File Offset: 0x005ED054
		public int AreaId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B024 RID: 176164 RVA: 0x005EEE90 File Offset: 0x005ED090
		public static Offset<IAlertSystemOption> CreateIAlertSystemOption(FlatBufferBuilder builder, EAlertSystemOption Type = EAlertSystemOption.EnableAlertArea, int AreaId = 0)
		{
			builder.StartTable(2);
			IAlertSystemOption.AddAreaId(builder, AreaId);
			IAlertSystemOption.AddType(builder, Type);
			return IAlertSystemOption.EndIAlertSystemOption(builder);
		}

		// Token: 0x0602B025 RID: 176165 RVA: 0x005EEEAD File Offset: 0x005ED0AD
		public static void StartIAlertSystemOption(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602B026 RID: 176166 RVA: 0x005EEEB6 File Offset: 0x005ED0B6
		public static void AddType(FlatBufferBuilder builder, EAlertSystemOption type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B027 RID: 176167 RVA: 0x005EEEC1 File Offset: 0x005ED0C1
		public static void AddAreaId(FlatBufferBuilder builder, int areaId)
		{
			builder.AddInt(1, areaId, 0);
		}

		// Token: 0x0602B028 RID: 176168 RVA: 0x005EEECC File Offset: 0x005ED0CC
		public static Offset<IAlertSystemOption> EndIAlertSystemOption(FlatBufferBuilder builder)
		{
			return new Offset<IAlertSystemOption>(builder.EndTable());
		}

		// Token: 0x0602B029 RID: 176169 RVA: 0x005EEEDC File Offset: 0x005ED0DC
		public IAlertSystemOptionT UnPack()
		{
			IAlertSystemOptionT alertSystemOptionT = new IAlertSystemOptionT();
			this.UnPackTo(alertSystemOptionT);
			return alertSystemOptionT;
		}

		// Token: 0x0602B02A RID: 176170 RVA: 0x005EEEF7 File Offset: 0x005ED0F7
		public void UnPackTo(IAlertSystemOptionT _o)
		{
			_o.Type = this.Type;
			_o.AreaId = this.AreaId;
		}

		// Token: 0x0602B02B RID: 176171 RVA: 0x005EEF14 File Offset: 0x005ED114
		public static Offset<IAlertSystemOption> Pack(FlatBufferBuilder builder, IAlertSystemOptionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAlertSystemOption>);
			}
			return IAlertSystemOption.CreateIAlertSystemOption(builder, _o.Type, _o.AreaId);
		}

		// Token: 0x0401068E RID: 67214
		private Table __p;
	}
}
