using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E27 RID: 24103
	public struct IOutAreaBorderType : IFlatbufferObject
	{
		// Token: 0x1700B44F RID: 46159
		// (get) Token: 0x0602943C RID: 169020 RVA: 0x005A8DB2 File Offset: 0x005A6FB2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602943D RID: 169021 RVA: 0x005A8DBF File Offset: 0x005A6FBF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602943E RID: 169022 RVA: 0x005A8DC8 File Offset: 0x005A6FC8
		public static IOutAreaBorderType GetRootAsIOutAreaBorderType(ByteBuffer _bb)
		{
			return IOutAreaBorderType.GetRootAsIOutAreaBorderType(_bb, default(IOutAreaBorderType));
		}

		// Token: 0x0602943F RID: 169023 RVA: 0x005A8DE4 File Offset: 0x005A6FE4
		public static IOutAreaBorderType GetRootAsIOutAreaBorderType(ByteBuffer _bb, IOutAreaBorderType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029440 RID: 169024 RVA: 0x005A8E01 File Offset: 0x005A7001
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029441 RID: 169025 RVA: 0x005A8E10 File Offset: 0x005A7010
		public IOutAreaBorderType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B450 RID: 46160
		// (get) Token: 0x06029442 RID: 169026 RVA: 0x005A8E20 File Offset: 0x005A7020
		public EOutAreaBorderType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EOutAreaBorderType.TeleportTimer;
				}
				return (EOutAreaBorderType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029443 RID: 169027 RVA: 0x005A8E5C File Offset: 0x005A705C
		public static Offset<IOutAreaBorderType> CreateIOutAreaBorderType(FlatBufferBuilder builder, EOutAreaBorderType Type = EOutAreaBorderType.TeleportTimer)
		{
			builder.StartTable(1);
			IOutAreaBorderType.AddType(builder, Type);
			return IOutAreaBorderType.EndIOutAreaBorderType(builder);
		}

		// Token: 0x06029444 RID: 169028 RVA: 0x005A8E72 File Offset: 0x005A7072
		public static void StartIOutAreaBorderType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06029445 RID: 169029 RVA: 0x005A8E7B File Offset: 0x005A707B
		public static void AddType(FlatBufferBuilder builder, EOutAreaBorderType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029446 RID: 169030 RVA: 0x005A8E86 File Offset: 0x005A7086
		public static Offset<IOutAreaBorderType> EndIOutAreaBorderType(FlatBufferBuilder builder)
		{
			return new Offset<IOutAreaBorderType>(builder.EndTable());
		}

		// Token: 0x06029447 RID: 169031 RVA: 0x005A8E94 File Offset: 0x005A7094
		public IOutAreaBorderTypeT UnPack()
		{
			IOutAreaBorderTypeT outAreaBorderTypeT = new IOutAreaBorderTypeT();
			this.UnPackTo(outAreaBorderTypeT);
			return outAreaBorderTypeT;
		}

		// Token: 0x06029448 RID: 169032 RVA: 0x005A8EAF File Offset: 0x005A70AF
		public void UnPackTo(IOutAreaBorderTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06029449 RID: 169033 RVA: 0x005A8EC0 File Offset: 0x005A70C0
		public static Offset<IOutAreaBorderType> Pack(FlatBufferBuilder builder, IOutAreaBorderTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOutAreaBorderType>);
			}
			return IOutAreaBorderType.CreateIOutAreaBorderType(builder, _o.Type);
		}

		// Token: 0x0400F823 RID: 63523
		private Table __p;
	}
}
