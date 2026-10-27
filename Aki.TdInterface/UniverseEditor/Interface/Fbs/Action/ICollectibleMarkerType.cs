using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200644E RID: 25678
	public struct ICollectibleMarkerType : IFlatbufferObject
	{
		// Token: 0x1700BF27 RID: 48935
		// (get) Token: 0x0602C70A RID: 182026 RVA: 0x006188A6 File Offset: 0x00616AA6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C70B RID: 182027 RVA: 0x006188B3 File Offset: 0x00616AB3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C70C RID: 182028 RVA: 0x006188BC File Offset: 0x00616ABC
		public static ICollectibleMarkerType GetRootAsICollectibleMarkerType(ByteBuffer _bb)
		{
			return ICollectibleMarkerType.GetRootAsICollectibleMarkerType(_bb, default(ICollectibleMarkerType));
		}

		// Token: 0x0602C70D RID: 182029 RVA: 0x006188D8 File Offset: 0x00616AD8
		public static ICollectibleMarkerType GetRootAsICollectibleMarkerType(ByteBuffer _bb, ICollectibleMarkerType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C70E RID: 182030 RVA: 0x006188F5 File Offset: 0x00616AF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C70F RID: 182031 RVA: 0x00618904 File Offset: 0x00616B04
		public ICollectibleMarkerType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BF28 RID: 48936
		// (get) Token: 0x0602C710 RID: 182032 RVA: 0x00618914 File Offset: 0x00616B14
		public ECollectibleMarkerType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECollectibleMarkerType.Placeholder;
				}
				return (ECollectibleMarkerType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C711 RID: 182033 RVA: 0x00618950 File Offset: 0x00616B50
		public static Offset<ICollectibleMarkerType> CreateICollectibleMarkerType(FlatBufferBuilder builder, ECollectibleMarkerType Type = ECollectibleMarkerType.Placeholder)
		{
			builder.StartTable(1);
			ICollectibleMarkerType.AddType(builder, Type);
			return ICollectibleMarkerType.EndICollectibleMarkerType(builder);
		}

		// Token: 0x0602C712 RID: 182034 RVA: 0x00618966 File Offset: 0x00616B66
		public static void StartICollectibleMarkerType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602C713 RID: 182035 RVA: 0x0061896F File Offset: 0x00616B6F
		public static void AddType(FlatBufferBuilder builder, ECollectibleMarkerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C714 RID: 182036 RVA: 0x0061897A File Offset: 0x00616B7A
		public static Offset<ICollectibleMarkerType> EndICollectibleMarkerType(FlatBufferBuilder builder)
		{
			return new Offset<ICollectibleMarkerType>(builder.EndTable());
		}

		// Token: 0x0602C715 RID: 182037 RVA: 0x00618988 File Offset: 0x00616B88
		public ICollectibleMarkerTypeT UnPack()
		{
			ICollectibleMarkerTypeT collectibleMarkerTypeT = new ICollectibleMarkerTypeT();
			this.UnPackTo(collectibleMarkerTypeT);
			return collectibleMarkerTypeT;
		}

		// Token: 0x0602C716 RID: 182038 RVA: 0x006189A3 File Offset: 0x00616BA3
		public void UnPackTo(ICollectibleMarkerTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602C717 RID: 182039 RVA: 0x006189B4 File Offset: 0x00616BB4
		public static Offset<ICollectibleMarkerType> Pack(FlatBufferBuilder builder, ICollectibleMarkerTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICollectibleMarkerType>);
			}
			return ICollectibleMarkerType.CreateICollectibleMarkerType(builder, _o.Type);
		}

		// Token: 0x04010A4C RID: 68172
		private Table __p;
	}
}
