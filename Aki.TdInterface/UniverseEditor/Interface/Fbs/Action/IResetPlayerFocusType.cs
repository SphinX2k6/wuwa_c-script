using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E97 RID: 28311
	public struct IResetPlayerFocusType : IFlatbufferObject
	{
		// Token: 0x1700D2CF RID: 53967
		// (get) Token: 0x06032099 RID: 204953 RVA: 0x006C4808 File Offset: 0x006C2A08
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603209A RID: 204954 RVA: 0x006C4815 File Offset: 0x006C2A15
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603209B RID: 204955 RVA: 0x006C481C File Offset: 0x006C2A1C
		public static IResetPlayerFocusType GetRootAsIResetPlayerFocusType(ByteBuffer _bb)
		{
			return IResetPlayerFocusType.GetRootAsIResetPlayerFocusType(_bb, default(IResetPlayerFocusType));
		}

		// Token: 0x0603209C RID: 204956 RVA: 0x006C4838 File Offset: 0x006C2A38
		public static IResetPlayerFocusType GetRootAsIResetPlayerFocusType(ByteBuffer _bb, IResetPlayerFocusType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603209D RID: 204957 RVA: 0x006C4855 File Offset: 0x006C2A55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603209E RID: 204958 RVA: 0x006C4864 File Offset: 0x006C2A64
		public IResetPlayerFocusType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D2D0 RID: 53968
		// (get) Token: 0x0603209F RID: 204959 RVA: 0x006C4874 File Offset: 0x006C2A74
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

		// Token: 0x060320A0 RID: 204960 RVA: 0x006C48B0 File Offset: 0x006C2AB0
		public static Offset<IResetPlayerFocusType> CreateIResetPlayerFocusType(FlatBufferBuilder builder, EResetPlayerFocusType Type = EResetPlayerFocusType.ResetToDefaultDirection)
		{
			builder.StartTable(1);
			IResetPlayerFocusType.AddType(builder, Type);
			return IResetPlayerFocusType.EndIResetPlayerFocusType(builder);
		}

		// Token: 0x060320A1 RID: 204961 RVA: 0x006C48C6 File Offset: 0x006C2AC6
		public static void StartIResetPlayerFocusType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060320A2 RID: 204962 RVA: 0x006C48CF File Offset: 0x006C2ACF
		public static void AddType(FlatBufferBuilder builder, EResetPlayerFocusType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060320A3 RID: 204963 RVA: 0x006C48DA File Offset: 0x006C2ADA
		public static Offset<IResetPlayerFocusType> EndIResetPlayerFocusType(FlatBufferBuilder builder)
		{
			return new Offset<IResetPlayerFocusType>(builder.EndTable());
		}

		// Token: 0x060320A4 RID: 204964 RVA: 0x006C48E8 File Offset: 0x006C2AE8
		public IResetPlayerFocusTypeT UnPack()
		{
			IResetPlayerFocusTypeT resetPlayerFocusTypeT = new IResetPlayerFocusTypeT();
			this.UnPackTo(resetPlayerFocusTypeT);
			return resetPlayerFocusTypeT;
		}

		// Token: 0x060320A5 RID: 204965 RVA: 0x006C4903 File Offset: 0x006C2B03
		public void UnPackTo(IResetPlayerFocusTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060320A6 RID: 204966 RVA: 0x006C4914 File Offset: 0x006C2B14
		public static Offset<IResetPlayerFocusType> Pack(FlatBufferBuilder builder, IResetPlayerFocusTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IResetPlayerFocusType>);
			}
			return IResetPlayerFocusType.CreateIResetPlayerFocusType(builder, _o.Type);
		}

		// Token: 0x04011885 RID: 71813
		private Table __p;
	}
}
