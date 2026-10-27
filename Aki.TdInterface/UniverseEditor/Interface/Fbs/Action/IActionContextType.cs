using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006074 RID: 24692
	public struct IActionContextType : IFlatbufferObject
	{
		// Token: 0x1700B5FB RID: 46587
		// (get) Token: 0x06029D0E RID: 171278 RVA: 0x005BCB3C File Offset: 0x005BAD3C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029D0F RID: 171279 RVA: 0x005BCB49 File Offset: 0x005BAD49
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029D10 RID: 171280 RVA: 0x005BCB50 File Offset: 0x005BAD50
		public static IActionContextType GetRootAsIActionContextType(ByteBuffer _bb)
		{
			return IActionContextType.GetRootAsIActionContextType(_bb, default(IActionContextType));
		}

		// Token: 0x06029D11 RID: 171281 RVA: 0x005BCB6C File Offset: 0x005BAD6C
		public static IActionContextType GetRootAsIActionContextType(ByteBuffer _bb, IActionContextType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029D12 RID: 171282 RVA: 0x005BCB89 File Offset: 0x005BAD89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029D13 RID: 171283 RVA: 0x005BCB98 File Offset: 0x005BAD98
		public IActionContextType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B5FC RID: 46588
		// (get) Token: 0x06029D14 RID: 171284 RVA: 0x005BCBA8 File Offset: 0x005BADA8
		public TActionContextType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TActionContextType.commonBt;
				}
				return (TActionContextType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029D15 RID: 171285 RVA: 0x005BCBE4 File Offset: 0x005BADE4
		public static Offset<IActionContextType> CreateIActionContextType(FlatBufferBuilder builder, TActionContextType Type = TActionContextType.commonBt)
		{
			builder.StartTable(1);
			IActionContextType.AddType(builder, Type);
			return IActionContextType.EndIActionContextType(builder);
		}

		// Token: 0x06029D16 RID: 171286 RVA: 0x005BCBFA File Offset: 0x005BADFA
		public static void StartIActionContextType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06029D17 RID: 171287 RVA: 0x005BCC03 File Offset: 0x005BAE03
		public static void AddType(FlatBufferBuilder builder, TActionContextType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029D18 RID: 171288 RVA: 0x005BCC0E File Offset: 0x005BAE0E
		public static Offset<IActionContextType> EndIActionContextType(FlatBufferBuilder builder)
		{
			return new Offset<IActionContextType>(builder.EndTable());
		}

		// Token: 0x06029D19 RID: 171289 RVA: 0x005BCC1C File Offset: 0x005BAE1C
		public IActionContextTypeT UnPack()
		{
			IActionContextTypeT actionContextTypeT = new IActionContextTypeT();
			this.UnPackTo(actionContextTypeT);
			return actionContextTypeT;
		}

		// Token: 0x06029D1A RID: 171290 RVA: 0x005BCC37 File Offset: 0x005BAE37
		public void UnPackTo(IActionContextTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06029D1B RID: 171291 RVA: 0x005BCC48 File Offset: 0x005BAE48
		public static Offset<IActionContextType> Pack(FlatBufferBuilder builder, IActionContextTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActionContextType>);
			}
			return IActionContextType.CreateIActionContextType(builder, _o.Type);
		}

		// Token: 0x0401023C RID: 66108
		private Table __p;
	}
}
