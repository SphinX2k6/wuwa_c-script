using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070E8 RID: 28904
	public struct ILiveDanmakuOperation : IFlatbufferObject
	{
		// Token: 0x1700D3AE RID: 54190
		// (get) Token: 0x0603231E RID: 205598 RVA: 0x006CA48E File Offset: 0x006C868E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603231F RID: 205599 RVA: 0x006CA49B File Offset: 0x006C869B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032320 RID: 205600 RVA: 0x006CA4A4 File Offset: 0x006C86A4
		public static ILiveDanmakuOperation GetRootAsILiveDanmakuOperation(ByteBuffer _bb)
		{
			return ILiveDanmakuOperation.GetRootAsILiveDanmakuOperation(_bb, default(ILiveDanmakuOperation));
		}

		// Token: 0x06032321 RID: 205601 RVA: 0x006CA4C0 File Offset: 0x006C86C0
		public static ILiveDanmakuOperation GetRootAsILiveDanmakuOperation(ByteBuffer _bb, ILiveDanmakuOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032322 RID: 205602 RVA: 0x006CA4DD File Offset: 0x006C86DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032323 RID: 205603 RVA: 0x006CA4EC File Offset: 0x006C86EC
		public ILiveDanmakuOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D3AF RID: 54191
		// (get) Token: 0x06032324 RID: 205604 RVA: 0x006CA4FC File Offset: 0x006C86FC
		public ELiveDanmakuOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELiveDanmakuOperationType.Load;
				}
				return (ELiveDanmakuOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032325 RID: 205605 RVA: 0x006CA538 File Offset: 0x006C8738
		public static Offset<ILiveDanmakuOperation> CreateILiveDanmakuOperation(FlatBufferBuilder builder, ELiveDanmakuOperationType Type = ELiveDanmakuOperationType.Load)
		{
			builder.StartTable(1);
			ILiveDanmakuOperation.AddType(builder, Type);
			return ILiveDanmakuOperation.EndILiveDanmakuOperation(builder);
		}

		// Token: 0x06032326 RID: 205606 RVA: 0x006CA54E File Offset: 0x006C874E
		public static void StartILiveDanmakuOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032327 RID: 205607 RVA: 0x006CA557 File Offset: 0x006C8757
		public static void AddType(FlatBufferBuilder builder, ELiveDanmakuOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032328 RID: 205608 RVA: 0x006CA562 File Offset: 0x006C8762
		public static Offset<ILiveDanmakuOperation> EndILiveDanmakuOperation(FlatBufferBuilder builder)
		{
			return new Offset<ILiveDanmakuOperation>(builder.EndTable());
		}

		// Token: 0x06032329 RID: 205609 RVA: 0x006CA570 File Offset: 0x006C8770
		public ILiveDanmakuOperationT UnPack()
		{
			ILiveDanmakuOperationT liveDanmakuOperationT = new ILiveDanmakuOperationT();
			this.UnPackTo(liveDanmakuOperationT);
			return liveDanmakuOperationT;
		}

		// Token: 0x0603232A RID: 205610 RVA: 0x006CA58B File Offset: 0x006C878B
		public void UnPackTo(ILiveDanmakuOperationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603232B RID: 205611 RVA: 0x006CA59C File Offset: 0x006C879C
		public static Offset<ILiveDanmakuOperation> Pack(FlatBufferBuilder builder, ILiveDanmakuOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiveDanmakuOperation>);
			}
			return ILiveDanmakuOperation.CreateILiveDanmakuOperation(builder, _o.Type);
		}

		// Token: 0x040120B1 RID: 73905
		private Table __p;
	}
}
