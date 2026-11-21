using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005895 RID: 22677
	public struct IGraph3dEffectBase : IFlatbufferObject
	{
		// Token: 0x1700A45B RID: 42075
		// (get) Token: 0x06024C7A RID: 150650 RVA: 0x0050D0E4 File Offset: 0x0050B2E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024C7B RID: 150651 RVA: 0x0050D0F1 File Offset: 0x0050B2F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024C7C RID: 150652 RVA: 0x0050D0F8 File Offset: 0x0050B2F8
		public static IGraph3dEffectBase GetRootAsIGraph3dEffectBase(ByteBuffer _bb)
		{
			return IGraph3dEffectBase.GetRootAsIGraph3dEffectBase(_bb, default(IGraph3dEffectBase));
		}

		// Token: 0x06024C7D RID: 150653 RVA: 0x0050D114 File Offset: 0x0050B314
		public static IGraph3dEffectBase GetRootAsIGraph3dEffectBase(ByteBuffer _bb, IGraph3dEffectBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024C7E RID: 150654 RVA: 0x0050D131 File Offset: 0x0050B331
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024C7F RID: 150655 RVA: 0x0050D140 File Offset: 0x0050B340
		public IGraph3dEffectBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A45C RID: 42076
		// (get) Token: 0x06024C80 RID: 150656 RVA: 0x0050D150 File Offset: 0x0050B350
		public EGraph3dEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGraph3dEffectType.FireBoxFish;
				}
				return (EGraph3dEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024C81 RID: 150657 RVA: 0x0050D18C File Offset: 0x0050B38C
		public static Offset<IGraph3dEffectBase> CreateIGraph3dEffectBase(FlatBufferBuilder builder, EGraph3dEffectType Type = EGraph3dEffectType.FireBoxFish)
		{
			builder.StartTable(1);
			IGraph3dEffectBase.AddType(builder, Type);
			return IGraph3dEffectBase.EndIGraph3dEffectBase(builder);
		}

		// Token: 0x06024C82 RID: 150658 RVA: 0x0050D1A2 File Offset: 0x0050B3A2
		public static void StartIGraph3dEffectBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06024C83 RID: 150659 RVA: 0x0050D1AB File Offset: 0x0050B3AB
		public static void AddType(FlatBufferBuilder builder, EGraph3dEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024C84 RID: 150660 RVA: 0x0050D1B6 File Offset: 0x0050B3B6
		public static Offset<IGraph3dEffectBase> EndIGraph3dEffectBase(FlatBufferBuilder builder)
		{
			return new Offset<IGraph3dEffectBase>(builder.EndTable());
		}

		// Token: 0x06024C85 RID: 150661 RVA: 0x0050D1C4 File Offset: 0x0050B3C4
		public IGraph3dEffectBaseT UnPack()
		{
			IGraph3dEffectBaseT graph3dEffectBaseT = new IGraph3dEffectBaseT();
			this.UnPackTo(graph3dEffectBaseT);
			return graph3dEffectBaseT;
		}

		// Token: 0x06024C86 RID: 150662 RVA: 0x0050D1DF File Offset: 0x0050B3DF
		public void UnPackTo(IGraph3dEffectBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06024C87 RID: 150663 RVA: 0x0050D1F0 File Offset: 0x0050B3F0
		public static Offset<IGraph3dEffectBase> Pack(FlatBufferBuilder builder, IGraph3dEffectBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGraph3dEffectBase>);
			}
			return IGraph3dEffectBase.CreateIGraph3dEffectBase(builder, _o.Type);
		}

		// Token: 0x0400F0F4 RID: 61684
		private Table __p;
	}
}
