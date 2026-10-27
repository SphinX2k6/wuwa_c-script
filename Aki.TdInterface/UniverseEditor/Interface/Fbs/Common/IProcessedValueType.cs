using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E45 RID: 24133
	public struct IProcessedValueType : IFlatbufferObject
	{
		// Token: 0x1700B471 RID: 46193
		// (get) Token: 0x06029501 RID: 169217 RVA: 0x005AA168 File Offset: 0x005A8368
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029502 RID: 169218 RVA: 0x005AA175 File Offset: 0x005A8375
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029503 RID: 169219 RVA: 0x005AA17C File Offset: 0x005A837C
		public static IProcessedValueType GetRootAsIProcessedValueType(ByteBuffer _bb)
		{
			return IProcessedValueType.GetRootAsIProcessedValueType(_bb, default(IProcessedValueType));
		}

		// Token: 0x06029504 RID: 169220 RVA: 0x005AA198 File Offset: 0x005A8398
		public static IProcessedValueType GetRootAsIProcessedValueType(ByteBuffer _bb, IProcessedValueType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029505 RID: 169221 RVA: 0x005AA1B5 File Offset: 0x005A83B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029506 RID: 169222 RVA: 0x005AA1C4 File Offset: 0x005A83C4
		public IProcessedValueType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B472 RID: 46194
		// (get) Token: 0x06029507 RID: 169223 RVA: 0x005AA1D4 File Offset: 0x005A83D4
		public EProcessedValueType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EProcessedValueType.Constant;
				}
				return (EProcessedValueType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029508 RID: 169224 RVA: 0x005AA210 File Offset: 0x005A8410
		public static Offset<IProcessedValueType> CreateIProcessedValueType(FlatBufferBuilder builder, EProcessedValueType Type = EProcessedValueType.Constant)
		{
			builder.StartTable(1);
			IProcessedValueType.AddType(builder, Type);
			return IProcessedValueType.EndIProcessedValueType(builder);
		}

		// Token: 0x06029509 RID: 169225 RVA: 0x005AA226 File Offset: 0x005A8426
		public static void StartIProcessedValueType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602950A RID: 169226 RVA: 0x005AA22F File Offset: 0x005A842F
		public static void AddType(FlatBufferBuilder builder, EProcessedValueType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602950B RID: 169227 RVA: 0x005AA23A File Offset: 0x005A843A
		public static Offset<IProcessedValueType> EndIProcessedValueType(FlatBufferBuilder builder)
		{
			return new Offset<IProcessedValueType>(builder.EndTable());
		}

		// Token: 0x0602950C RID: 169228 RVA: 0x005AA248 File Offset: 0x005A8448
		public IProcessedValueTypeT UnPack()
		{
			IProcessedValueTypeT processedValueTypeT = new IProcessedValueTypeT();
			this.UnPackTo(processedValueTypeT);
			return processedValueTypeT;
		}

		// Token: 0x0602950D RID: 169229 RVA: 0x005AA263 File Offset: 0x005A8463
		public void UnPackTo(IProcessedValueTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602950E RID: 169230 RVA: 0x005AA274 File Offset: 0x005A8474
		public static Offset<IProcessedValueType> Pack(FlatBufferBuilder builder, IProcessedValueTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IProcessedValueType>);
			}
			return IProcessedValueType.CreateIProcessedValueType(builder, _o.Type);
		}

		// Token: 0x0400F845 RID: 63557
		private Table __p;
	}
}
