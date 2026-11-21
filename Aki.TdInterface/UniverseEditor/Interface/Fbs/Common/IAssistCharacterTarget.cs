using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200634A RID: 25418
	public struct IAssistCharacterTarget : IFlatbufferObject
	{
		// Token: 0x1700BBED RID: 48109
		// (get) Token: 0x0602B1AD RID: 176557 RVA: 0x005DFFF7 File Offset: 0x005DE1F7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B1AE RID: 176558 RVA: 0x005E0004 File Offset: 0x005DE204
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B1AF RID: 176559 RVA: 0x005E000C File Offset: 0x005DE20C
		public static IAssistCharacterTarget GetRootAsIAssistCharacterTarget(ByteBuffer _bb)
		{
			return IAssistCharacterTarget.GetRootAsIAssistCharacterTarget(_bb, default(IAssistCharacterTarget));
		}

		// Token: 0x0602B1B0 RID: 176560 RVA: 0x005E0028 File Offset: 0x005DE228
		public static IAssistCharacterTarget GetRootAsIAssistCharacterTarget(ByteBuffer _bb, IAssistCharacterTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B1B1 RID: 176561 RVA: 0x005E0045 File Offset: 0x005DE245
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B1B2 RID: 176562 RVA: 0x005E0054 File Offset: 0x005DE254
		public IAssistCharacterTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BBEE RID: 48110
		// (get) Token: 0x0602B1B3 RID: 176563 RVA: 0x005E0064 File Offset: 0x005DE264
		public ECommonTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonTargetType.Player;
				}
				return (ECommonTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BBEF RID: 48111
		// (get) Token: 0x0602B1B4 RID: 176564 RVA: 0x005E00A0 File Offset: 0x005DE2A0
		public int Id
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

		// Token: 0x0602B1B5 RID: 176565 RVA: 0x005E00DC File Offset: 0x005DE2DC
		public static Offset<IAssistCharacterTarget> CreateIAssistCharacterTarget(FlatBufferBuilder builder, ECommonTargetType Type = ECommonTargetType.Player, int Id = 0)
		{
			builder.StartTable(2);
			IAssistCharacterTarget.AddId(builder, Id);
			IAssistCharacterTarget.AddType(builder, Type);
			return IAssistCharacterTarget.EndIAssistCharacterTarget(builder);
		}

		// Token: 0x0602B1B6 RID: 176566 RVA: 0x005E00F9 File Offset: 0x005DE2F9
		public static void StartIAssistCharacterTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602B1B7 RID: 176567 RVA: 0x005E0102 File Offset: 0x005DE302
		public static void AddType(FlatBufferBuilder builder, ECommonTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B1B8 RID: 176568 RVA: 0x005E010D File Offset: 0x005DE30D
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0602B1B9 RID: 176569 RVA: 0x005E0118 File Offset: 0x005DE318
		public static Offset<IAssistCharacterTarget> EndIAssistCharacterTarget(FlatBufferBuilder builder)
		{
			return new Offset<IAssistCharacterTarget>(builder.EndTable());
		}

		// Token: 0x0602B1BA RID: 176570 RVA: 0x005E0128 File Offset: 0x005DE328
		public IAssistCharacterTargetT UnPack()
		{
			IAssistCharacterTargetT assistCharacterTargetT = new IAssistCharacterTargetT();
			this.UnPackTo(assistCharacterTargetT);
			return assistCharacterTargetT;
		}

		// Token: 0x0602B1BB RID: 176571 RVA: 0x005E0143 File Offset: 0x005DE343
		public void UnPackTo(IAssistCharacterTargetT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x0602B1BC RID: 176572 RVA: 0x005E0160 File Offset: 0x005DE360
		public static Offset<IAssistCharacterTarget> Pack(FlatBufferBuilder builder, IAssistCharacterTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAssistCharacterTarget>);
			}
			return IAssistCharacterTarget.CreateIAssistCharacterTarget(builder, _o.Type, _o.Id);
		}

		// Token: 0x0401040D RID: 66573
		private Table __p;
	}
}
