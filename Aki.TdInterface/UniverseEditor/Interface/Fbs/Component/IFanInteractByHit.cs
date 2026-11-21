using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200579C RID: 22428
	public struct IFanInteractByHit : IFlatbufferObject
	{
		// Token: 0x1700A22F RID: 41519
		// (get) Token: 0x0602433B RID: 148283 RVA: 0x004FA375 File Offset: 0x004F8575
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602433C RID: 148284 RVA: 0x004FA382 File Offset: 0x004F8582
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602433D RID: 148285 RVA: 0x004FA38C File Offset: 0x004F858C
		public static IFanInteractByHit GetRootAsIFanInteractByHit(ByteBuffer _bb)
		{
			return IFanInteractByHit.GetRootAsIFanInteractByHit(_bb, default(IFanInteractByHit));
		}

		// Token: 0x0602433E RID: 148286 RVA: 0x004FA3A8 File Offset: 0x004F85A8
		public static IFanInteractByHit GetRootAsIFanInteractByHit(ByteBuffer _bb, IFanInteractByHit obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602433F RID: 148287 RVA: 0x004FA3C5 File Offset: 0x004F85C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024340 RID: 148288 RVA: 0x004FA3D4 File Offset: 0x004F85D4
		public IFanInteractByHit __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A230 RID: 41520
		// (get) Token: 0x06024341 RID: 148289 RVA: 0x004FA3E4 File Offset: 0x004F85E4
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

		// Token: 0x06024342 RID: 148290 RVA: 0x004FA420 File Offset: 0x004F8620
		public static Offset<IFanInteractByHit> CreateIFanInteractByHit(FlatBufferBuilder builder, EFanInteractType Type = EFanInteractType.Hit)
		{
			builder.StartTable(1);
			IFanInteractByHit.AddType(builder, Type);
			return IFanInteractByHit.EndIFanInteractByHit(builder);
		}

		// Token: 0x06024343 RID: 148291 RVA: 0x004FA436 File Offset: 0x004F8636
		public static void StartIFanInteractByHit(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06024344 RID: 148292 RVA: 0x004FA43F File Offset: 0x004F863F
		public static void AddType(FlatBufferBuilder builder, EFanInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024345 RID: 148293 RVA: 0x004FA44A File Offset: 0x004F864A
		public static Offset<IFanInteractByHit> EndIFanInteractByHit(FlatBufferBuilder builder)
		{
			return new Offset<IFanInteractByHit>(builder.EndTable());
		}

		// Token: 0x06024346 RID: 148294 RVA: 0x004FA458 File Offset: 0x004F8658
		public IFanInteractByHitT UnPack()
		{
			IFanInteractByHitT fanInteractByHitT = new IFanInteractByHitT();
			this.UnPackTo(fanInteractByHitT);
			return fanInteractByHitT;
		}

		// Token: 0x06024347 RID: 148295 RVA: 0x004FA473 File Offset: 0x004F8673
		public void UnPackTo(IFanInteractByHitT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06024348 RID: 148296 RVA: 0x004FA484 File Offset: 0x004F8684
		public static Offset<IFanInteractByHit> Pack(FlatBufferBuilder builder, IFanInteractByHitT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFanInteractByHit>);
			}
			return IFanInteractByHit.CreateIFanInteractByHit(builder, _o.Type);
		}

		// Token: 0x0400EF80 RID: 61312
		private Table __p;
	}
}
