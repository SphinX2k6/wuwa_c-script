using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054ED RID: 21741
	public struct ICircuitConnectOutputPortLayout : IFlatbufferObject
	{
		// Token: 0x17009B4C RID: 39756
		// (get) Token: 0x0602253B RID: 140603 RVA: 0x004BB4F4 File Offset: 0x004B96F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602253C RID: 140604 RVA: 0x004BB501 File Offset: 0x004B9701
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602253D RID: 140605 RVA: 0x004BB508 File Offset: 0x004B9708
		public static ICircuitConnectOutputPortLayout GetRootAsICircuitConnectOutputPortLayout(ByteBuffer _bb)
		{
			return ICircuitConnectOutputPortLayout.GetRootAsICircuitConnectOutputPortLayout(_bb, default(ICircuitConnectOutputPortLayout));
		}

		// Token: 0x0602253E RID: 140606 RVA: 0x004BB524 File Offset: 0x004B9724
		public static ICircuitConnectOutputPortLayout GetRootAsICircuitConnectOutputPortLayout(ByteBuffer _bb, ICircuitConnectOutputPortLayout obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602253F RID: 140607 RVA: 0x004BB541 File Offset: 0x004B9741
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022540 RID: 140608 RVA: 0x004BB550 File Offset: 0x004B9750
		public ICircuitConnectOutputPortLayout __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009B4D RID: 39757
		// (get) Token: 0x06022541 RID: 140609 RVA: 0x004BB560 File Offset: 0x004B9760
		public ECircuitConnectElementType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECircuitConnectElementType.Straight;
				}
				return (ECircuitConnectElementType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022542 RID: 140610 RVA: 0x004BB59C File Offset: 0x004B979C
		public static Offset<ICircuitConnectOutputPortLayout> CreateICircuitConnectOutputPortLayout(FlatBufferBuilder builder, ECircuitConnectElementType Type = ECircuitConnectElementType.Straight)
		{
			builder.StartTable(1);
			ICircuitConnectOutputPortLayout.AddType(builder, Type);
			return ICircuitConnectOutputPortLayout.EndICircuitConnectOutputPortLayout(builder);
		}

		// Token: 0x06022543 RID: 140611 RVA: 0x004BB5B2 File Offset: 0x004B97B2
		public static void StartICircuitConnectOutputPortLayout(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06022544 RID: 140612 RVA: 0x004BB5BB File Offset: 0x004B97BB
		public static void AddType(FlatBufferBuilder builder, ECircuitConnectElementType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022545 RID: 140613 RVA: 0x004BB5C6 File Offset: 0x004B97C6
		public static Offset<ICircuitConnectOutputPortLayout> EndICircuitConnectOutputPortLayout(FlatBufferBuilder builder)
		{
			return new Offset<ICircuitConnectOutputPortLayout>(builder.EndTable());
		}

		// Token: 0x06022546 RID: 140614 RVA: 0x004BB5D4 File Offset: 0x004B97D4
		public ICircuitConnectOutputPortLayoutT UnPack()
		{
			ICircuitConnectOutputPortLayoutT circuitConnectOutputPortLayoutT = new ICircuitConnectOutputPortLayoutT();
			this.UnPackTo(circuitConnectOutputPortLayoutT);
			return circuitConnectOutputPortLayoutT;
		}

		// Token: 0x06022547 RID: 140615 RVA: 0x004BB5EF File Offset: 0x004B97EF
		public void UnPackTo(ICircuitConnectOutputPortLayoutT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06022548 RID: 140616 RVA: 0x004BB600 File Offset: 0x004B9800
		public static Offset<ICircuitConnectOutputPortLayout> Pack(FlatBufferBuilder builder, ICircuitConnectOutputPortLayoutT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICircuitConnectOutputPortLayout>);
			}
			return ICircuitConnectOutputPortLayout.CreateICircuitConnectOutputPortLayout(builder, _o.Type);
		}

		// Token: 0x0400EA4C RID: 59980
		private Table __p;
	}
}
