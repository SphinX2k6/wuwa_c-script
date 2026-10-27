using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005234 RID: 21044
	public struct IFanInteractByHit : IFlatbufferObject
	{
		// Token: 0x17009A33 RID: 39475
		// (get) Token: 0x060223A5 RID: 140197 RVA: 0x004BF8B1 File Offset: 0x004BDAB1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060223A6 RID: 140198 RVA: 0x004BF8BE File Offset: 0x004BDABE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060223A7 RID: 140199 RVA: 0x004BF8C8 File Offset: 0x004BDAC8
		public static IFanInteractByHit GetRootAsIFanInteractByHit(ByteBuffer _bb)
		{
			return IFanInteractByHit.GetRootAsIFanInteractByHit(_bb, default(IFanInteractByHit));
		}

		// Token: 0x060223A8 RID: 140200 RVA: 0x004BF8E4 File Offset: 0x004BDAE4
		public static IFanInteractByHit GetRootAsIFanInteractByHit(ByteBuffer _bb, IFanInteractByHit obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060223A9 RID: 140201 RVA: 0x004BF901 File Offset: 0x004BDB01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060223AA RID: 140202 RVA: 0x004BF910 File Offset: 0x004BDB10
		public IFanInteractByHit __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009A34 RID: 39476
		// (get) Token: 0x060223AB RID: 140203 RVA: 0x004BF920 File Offset: 0x004BDB20
		public EFanInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFanInteractType.Hit;
				}
				return (EFanInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060223AC RID: 140204 RVA: 0x004BF95C File Offset: 0x004BDB5C
		public static Offset<IFanInteractByHit> CreateIFanInteractByHit(FlatBufferBuilder builder, EFanInteractType Type = EFanInteractType.Hit)
		{
			builder.StartTable(1);
			IFanInteractByHit.AddType(builder, Type);
			return IFanInteractByHit.EndIFanInteractByHit(builder);
		}

		// Token: 0x060223AD RID: 140205 RVA: 0x004BF972 File Offset: 0x004BDB72
		public static void StartIFanInteractByHit(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060223AE RID: 140206 RVA: 0x004BF97B File Offset: 0x004BDB7B
		public static void AddType(FlatBufferBuilder builder, EFanInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060223AF RID: 140207 RVA: 0x004BF986 File Offset: 0x004BDB86
		public static Offset<IFanInteractByHit> EndIFanInteractByHit(FlatBufferBuilder builder)
		{
			return new Offset<IFanInteractByHit>(builder.EndTable());
		}

		// Token: 0x060223B0 RID: 140208 RVA: 0x004BF994 File Offset: 0x004BDB94
		public IFanInteractByHitT UnPack()
		{
			IFanInteractByHitT fanInteractByHitT = new IFanInteractByHitT();
			this.UnPackTo(fanInteractByHitT);
			return fanInteractByHitT;
		}

		// Token: 0x060223B1 RID: 140209 RVA: 0x004BF9AF File Offset: 0x004BDBAF
		public void UnPackTo(IFanInteractByHitT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060223B2 RID: 140210 RVA: 0x004BF9C0 File Offset: 0x004BDBC0
		public static Offset<IFanInteractByHit> Pack(FlatBufferBuilder builder, IFanInteractByHitT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFanInteractByHit>);
			}
			return IFanInteractByHit.CreateIFanInteractByHit(builder, _o.Type);
		}

		// Token: 0x0400E37A RID: 58234
		private Table __p;
	}
}
