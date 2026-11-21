using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007615 RID: 30229
	public struct IResetPlayerFocusToDefaultDirection : IFlatbufferObject
	{
		// Token: 0x1700DE1E RID: 56862
		// (get) Token: 0x060350B1 RID: 217265 RVA: 0x00720138 File Offset: 0x0071E338
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060350B2 RID: 217266 RVA: 0x00720145 File Offset: 0x0071E345
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060350B3 RID: 217267 RVA: 0x0072014C File Offset: 0x0071E34C
		public static IResetPlayerFocusToDefaultDirection GetRootAsIResetPlayerFocusToDefaultDirection(ByteBuffer _bb)
		{
			return IResetPlayerFocusToDefaultDirection.GetRootAsIResetPlayerFocusToDefaultDirection(_bb, default(IResetPlayerFocusToDefaultDirection));
		}

		// Token: 0x060350B4 RID: 217268 RVA: 0x00720168 File Offset: 0x0071E368
		public static IResetPlayerFocusToDefaultDirection GetRootAsIResetPlayerFocusToDefaultDirection(ByteBuffer _bb, IResetPlayerFocusToDefaultDirection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060350B5 RID: 217269 RVA: 0x00720185 File Offset: 0x0071E385
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060350B6 RID: 217270 RVA: 0x00720194 File Offset: 0x0071E394
		public IResetPlayerFocusToDefaultDirection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DE1F RID: 56863
		// (get) Token: 0x060350B7 RID: 217271 RVA: 0x007201A4 File Offset: 0x0071E3A4
		public EResetPlayerFocusType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EResetPlayerFocusType.ResetToDefaultDirection;
				}
				return (EResetPlayerFocusType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060350B8 RID: 217272 RVA: 0x007201E0 File Offset: 0x0071E3E0
		public static Offset<IResetPlayerFocusToDefaultDirection> CreateIResetPlayerFocusToDefaultDirection(FlatBufferBuilder builder, EResetPlayerFocusType Type = EResetPlayerFocusType.ResetToDefaultDirection)
		{
			builder.StartTable(1);
			IResetPlayerFocusToDefaultDirection.AddType(builder, Type);
			return IResetPlayerFocusToDefaultDirection.EndIResetPlayerFocusToDefaultDirection(builder);
		}

		// Token: 0x060350B9 RID: 217273 RVA: 0x007201F6 File Offset: 0x0071E3F6
		public static void StartIResetPlayerFocusToDefaultDirection(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060350BA RID: 217274 RVA: 0x007201FF File Offset: 0x0071E3FF
		public static void AddType(FlatBufferBuilder builder, EResetPlayerFocusType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060350BB RID: 217275 RVA: 0x0072020A File Offset: 0x0071E40A
		public static Offset<IResetPlayerFocusToDefaultDirection> EndIResetPlayerFocusToDefaultDirection(FlatBufferBuilder builder)
		{
			return new Offset<IResetPlayerFocusToDefaultDirection>(builder.EndTable());
		}

		// Token: 0x060350BC RID: 217276 RVA: 0x00720218 File Offset: 0x0071E418
		public IResetPlayerFocusToDefaultDirectionT UnPack()
		{
			IResetPlayerFocusToDefaultDirectionT resetPlayerFocusToDefaultDirectionT = new IResetPlayerFocusToDefaultDirectionT();
			this.UnPackTo(resetPlayerFocusToDefaultDirectionT);
			return resetPlayerFocusToDefaultDirectionT;
		}

		// Token: 0x060350BD RID: 217277 RVA: 0x00720233 File Offset: 0x0071E433
		public void UnPackTo(IResetPlayerFocusToDefaultDirectionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060350BE RID: 217278 RVA: 0x00720244 File Offset: 0x0071E444
		public static Offset<IResetPlayerFocusToDefaultDirection> Pack(FlatBufferBuilder builder, IResetPlayerFocusToDefaultDirectionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IResetPlayerFocusToDefaultDirection>);
			}
			return IResetPlayerFocusToDefaultDirection.CreateIResetPlayerFocusToDefaultDirection(builder, _o.Type);
		}

		// Token: 0x04012805 RID: 75781
		private Table __p;
	}
}
