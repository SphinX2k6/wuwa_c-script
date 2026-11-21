using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200579F RID: 22431
	public struct IFanInteractType : IFlatbufferObject
	{
		// Token: 0x1700A232 RID: 41522
		// (get) Token: 0x0602434D RID: 148301 RVA: 0x004FA4ED File Offset: 0x004F86ED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602434E RID: 148302 RVA: 0x004FA4FA File Offset: 0x004F86FA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602434F RID: 148303 RVA: 0x004FA504 File Offset: 0x004F8704
		public static IFanInteractType GetRootAsIFanInteractType(ByteBuffer _bb)
		{
			return IFanInteractType.GetRootAsIFanInteractType(_bb, default(IFanInteractType));
		}

		// Token: 0x06024350 RID: 148304 RVA: 0x004FA520 File Offset: 0x004F8720
		public static IFanInteractType GetRootAsIFanInteractType(ByteBuffer _bb, IFanInteractType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024351 RID: 148305 RVA: 0x004FA53D File Offset: 0x004F873D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024352 RID: 148306 RVA: 0x004FA54C File Offset: 0x004F874C
		public IFanInteractType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A233 RID: 41523
		// (get) Token: 0x06024353 RID: 148307 RVA: 0x004FA55C File Offset: 0x004F875C
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

		// Token: 0x06024354 RID: 148308 RVA: 0x004FA598 File Offset: 0x004F8798
		public static Offset<IFanInteractType> CreateIFanInteractType(FlatBufferBuilder builder, EFanInteractType Type = EFanInteractType.Hit)
		{
			builder.StartTable(1);
			IFanInteractType.AddType(builder, Type);
			return IFanInteractType.EndIFanInteractType(builder);
		}

		// Token: 0x06024355 RID: 148309 RVA: 0x004FA5AE File Offset: 0x004F87AE
		public static void StartIFanInteractType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06024356 RID: 148310 RVA: 0x004FA5B7 File Offset: 0x004F87B7
		public static void AddType(FlatBufferBuilder builder, EFanInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024357 RID: 148311 RVA: 0x004FA5C2 File Offset: 0x004F87C2
		public static Offset<IFanInteractType> EndIFanInteractType(FlatBufferBuilder builder)
		{
			return new Offset<IFanInteractType>(builder.EndTable());
		}

		// Token: 0x06024358 RID: 148312 RVA: 0x004FA5D0 File Offset: 0x004F87D0
		public IFanInteractTypeT UnPack()
		{
			IFanInteractTypeT fanInteractTypeT = new IFanInteractTypeT();
			this.UnPackTo(fanInteractTypeT);
			return fanInteractTypeT;
		}

		// Token: 0x06024359 RID: 148313 RVA: 0x004FA5EB File Offset: 0x004F87EB
		public void UnPackTo(IFanInteractTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602435A RID: 148314 RVA: 0x004FA5FC File Offset: 0x004F87FC
		public static Offset<IFanInteractType> Pack(FlatBufferBuilder builder, IFanInteractTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFanInteractType>);
			}
			return IFanInteractType.CreateIFanInteractType(builder, _o.Type);
		}

		// Token: 0x0400EF82 RID: 61314
		private Table __p;
	}
}
