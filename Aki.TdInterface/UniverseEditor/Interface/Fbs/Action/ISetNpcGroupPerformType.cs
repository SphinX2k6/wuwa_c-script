using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077FA RID: 30714
	public struct ISetNpcGroupPerformType : IFlatbufferObject
	{
		// Token: 0x1700E11C RID: 57628
		// (get) Token: 0x06035F57 RID: 221015 RVA: 0x0073A6BC File Offset: 0x007388BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035F58 RID: 221016 RVA: 0x0073A6C9 File Offset: 0x007388C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035F59 RID: 221017 RVA: 0x0073A6D0 File Offset: 0x007388D0
		public static ISetNpcGroupPerformType GetRootAsISetNpcGroupPerformType(ByteBuffer _bb)
		{
			return ISetNpcGroupPerformType.GetRootAsISetNpcGroupPerformType(_bb, default(ISetNpcGroupPerformType));
		}

		// Token: 0x06035F5A RID: 221018 RVA: 0x0073A6EC File Offset: 0x007388EC
		public static ISetNpcGroupPerformType GetRootAsISetNpcGroupPerformType(ByteBuffer _bb, ISetNpcGroupPerformType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035F5B RID: 221019 RVA: 0x0073A709 File Offset: 0x00738909
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035F5C RID: 221020 RVA: 0x0073A718 File Offset: 0x00738918
		public ISetNpcGroupPerformType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E11D RID: 57629
		// (get) Token: 0x06035F5D RID: 221021 RVA: 0x0073A728 File Offset: 0x00738928
		public ENpcGroupPerformType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENpcGroupPerformType.HandInHand;
				}
				return (ENpcGroupPerformType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035F5E RID: 221022 RVA: 0x0073A764 File Offset: 0x00738964
		public static Offset<ISetNpcGroupPerformType> CreateISetNpcGroupPerformType(FlatBufferBuilder builder, ENpcGroupPerformType Type = ENpcGroupPerformType.HandInHand)
		{
			builder.StartTable(1);
			ISetNpcGroupPerformType.AddType(builder, Type);
			return ISetNpcGroupPerformType.EndISetNpcGroupPerformType(builder);
		}

		// Token: 0x06035F5F RID: 221023 RVA: 0x0073A77A File Offset: 0x0073897A
		public static void StartISetNpcGroupPerformType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035F60 RID: 221024 RVA: 0x0073A783 File Offset: 0x00738983
		public static void AddType(FlatBufferBuilder builder, ENpcGroupPerformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035F61 RID: 221025 RVA: 0x0073A78E File Offset: 0x0073898E
		public static Offset<ISetNpcGroupPerformType> EndISetNpcGroupPerformType(FlatBufferBuilder builder)
		{
			return new Offset<ISetNpcGroupPerformType>(builder.EndTable());
		}

		// Token: 0x06035F62 RID: 221026 RVA: 0x0073A79C File Offset: 0x0073899C
		public ISetNpcGroupPerformTypeT UnPack()
		{
			ISetNpcGroupPerformTypeT setNpcGroupPerformTypeT = new ISetNpcGroupPerformTypeT();
			this.UnPackTo(setNpcGroupPerformTypeT);
			return setNpcGroupPerformTypeT;
		}

		// Token: 0x06035F63 RID: 221027 RVA: 0x0073A7B7 File Offset: 0x007389B7
		public void UnPackTo(ISetNpcGroupPerformTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06035F64 RID: 221028 RVA: 0x0073A7C8 File Offset: 0x007389C8
		public static Offset<ISetNpcGroupPerformType> Pack(FlatBufferBuilder builder, ISetNpcGroupPerformTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetNpcGroupPerformType>);
			}
			return ISetNpcGroupPerformType.CreateISetNpcGroupPerformType(builder, _o.Type);
		}

		// Token: 0x04012A47 RID: 76359
		private Table __p;
	}
}
