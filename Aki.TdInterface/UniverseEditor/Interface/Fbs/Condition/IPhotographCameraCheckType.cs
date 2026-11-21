using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005172 RID: 20850
	public struct IPhotographCameraCheckType : IFlatbufferObject
	{
		// Token: 0x1700955F RID: 38239
		// (get) Token: 0x06020CDD RID: 134365 RVA: 0x0048AA4E File Offset: 0x00488C4E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020CDE RID: 134366 RVA: 0x0048AA5B File Offset: 0x00488C5B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020CDF RID: 134367 RVA: 0x0048AA64 File Offset: 0x00488C64
		public static IPhotographCameraCheckType GetRootAsIPhotographCameraCheckType(ByteBuffer _bb)
		{
			return IPhotographCameraCheckType.GetRootAsIPhotographCameraCheckType(_bb, default(IPhotographCameraCheckType));
		}

		// Token: 0x06020CE0 RID: 134368 RVA: 0x0048AA80 File Offset: 0x00488C80
		public static IPhotographCameraCheckType GetRootAsIPhotographCameraCheckType(ByteBuffer _bb, IPhotographCameraCheckType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020CE1 RID: 134369 RVA: 0x0048AA9D File Offset: 0x00488C9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020CE2 RID: 134370 RVA: 0x0048AAAC File Offset: 0x00488CAC
		public IPhotographCameraCheckType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009560 RID: 38240
		// (get) Token: 0x06020CE3 RID: 134371 RVA: 0x0048AABC File Offset: 0x00488CBC
		public EPhotographCameraCheckType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPhotographCameraCheckType.CameraTemplate;
				}
				return (EPhotographCameraCheckType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020CE4 RID: 134372 RVA: 0x0048AAF8 File Offset: 0x00488CF8
		public static Offset<IPhotographCameraCheckType> CreateIPhotographCameraCheckType(FlatBufferBuilder builder, EPhotographCameraCheckType Type = EPhotographCameraCheckType.CameraTemplate)
		{
			builder.StartTable(1);
			IPhotographCameraCheckType.AddType(builder, Type);
			return IPhotographCameraCheckType.EndIPhotographCameraCheckType(builder);
		}

		// Token: 0x06020CE5 RID: 134373 RVA: 0x0048AB0E File Offset: 0x00488D0E
		public static void StartIPhotographCameraCheckType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06020CE6 RID: 134374 RVA: 0x0048AB17 File Offset: 0x00488D17
		public static void AddType(FlatBufferBuilder builder, EPhotographCameraCheckType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020CE7 RID: 134375 RVA: 0x0048AB22 File Offset: 0x00488D22
		public static Offset<IPhotographCameraCheckType> EndIPhotographCameraCheckType(FlatBufferBuilder builder)
		{
			return new Offset<IPhotographCameraCheckType>(builder.EndTable());
		}

		// Token: 0x06020CE8 RID: 134376 RVA: 0x0048AB30 File Offset: 0x00488D30
		public IPhotographCameraCheckTypeT UnPack()
		{
			IPhotographCameraCheckTypeT photographCameraCheckTypeT = new IPhotographCameraCheckTypeT();
			this.UnPackTo(photographCameraCheckTypeT);
			return photographCameraCheckTypeT;
		}

		// Token: 0x06020CE9 RID: 134377 RVA: 0x0048AB4B File Offset: 0x00488D4B
		public void UnPackTo(IPhotographCameraCheckTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06020CEA RID: 134378 RVA: 0x0048AB5C File Offset: 0x00488D5C
		public static Offset<IPhotographCameraCheckType> Pack(FlatBufferBuilder builder, IPhotographCameraCheckTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhotographCameraCheckType>);
			}
			return IPhotographCameraCheckType.CreateIPhotographCameraCheckType(builder, _o.Type);
		}

		// Token: 0x0400E152 RID: 57682
		private Table __p;
	}
}
