using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DB5 RID: 23989
	public struct IGiantAnimDataType : IFlatbufferObject
	{
		// Token: 0x1700B3A1 RID: 45985
		// (get) Token: 0x060290F2 RID: 168178 RVA: 0x005A32FF File Offset: 0x005A14FF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060290F3 RID: 168179 RVA: 0x005A330C File Offset: 0x005A150C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060290F4 RID: 168180 RVA: 0x005A3314 File Offset: 0x005A1514
		public static IGiantAnimDataType GetRootAsIGiantAnimDataType(ByteBuffer _bb)
		{
			return IGiantAnimDataType.GetRootAsIGiantAnimDataType(_bb, default(IGiantAnimDataType));
		}

		// Token: 0x060290F5 RID: 168181 RVA: 0x005A3330 File Offset: 0x005A1530
		public static IGiantAnimDataType GetRootAsIGiantAnimDataType(ByteBuffer _bb, IGiantAnimDataType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060290F6 RID: 168182 RVA: 0x005A334D File Offset: 0x005A154D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060290F7 RID: 168183 RVA: 0x005A335C File Offset: 0x005A155C
		public IGiantAnimDataType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B3A2 RID: 45986
		// (get) Token: 0x060290F8 RID: 168184 RVA: 0x005A336C File Offset: 0x005A156C
		public EGiantAnimationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGiantAnimationType.Idle;
				}
				return (EGiantAnimationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060290F9 RID: 168185 RVA: 0x005A33A8 File Offset: 0x005A15A8
		public static Offset<IGiantAnimDataType> CreateIGiantAnimDataType(FlatBufferBuilder builder, EGiantAnimationType Type = EGiantAnimationType.Idle)
		{
			builder.StartTable(1);
			IGiantAnimDataType.AddType(builder, Type);
			return IGiantAnimDataType.EndIGiantAnimDataType(builder);
		}

		// Token: 0x060290FA RID: 168186 RVA: 0x005A33BE File Offset: 0x005A15BE
		public static void StartIGiantAnimDataType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060290FB RID: 168187 RVA: 0x005A33C7 File Offset: 0x005A15C7
		public static void AddType(FlatBufferBuilder builder, EGiantAnimationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060290FC RID: 168188 RVA: 0x005A33D2 File Offset: 0x005A15D2
		public static Offset<IGiantAnimDataType> EndIGiantAnimDataType(FlatBufferBuilder builder)
		{
			return new Offset<IGiantAnimDataType>(builder.EndTable());
		}

		// Token: 0x060290FD RID: 168189 RVA: 0x005A33E0 File Offset: 0x005A15E0
		public IGiantAnimDataTypeT UnPack()
		{
			IGiantAnimDataTypeT giantAnimDataTypeT = new IGiantAnimDataTypeT();
			this.UnPackTo(giantAnimDataTypeT);
			return giantAnimDataTypeT;
		}

		// Token: 0x060290FE RID: 168190 RVA: 0x005A33FB File Offset: 0x005A15FB
		public void UnPackTo(IGiantAnimDataTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060290FF RID: 168191 RVA: 0x005A340C File Offset: 0x005A160C
		public static Offset<IGiantAnimDataType> Pack(FlatBufferBuilder builder, IGiantAnimDataTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGiantAnimDataType>);
			}
			return IGiantAnimDataType.CreateIGiantAnimDataType(builder, _o.Type);
		}

		// Token: 0x0400F792 RID: 63378
		private Table __p;
	}
}
