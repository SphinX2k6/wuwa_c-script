using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D5E RID: 23902
	public struct IPointField : IFlatbufferObject
	{
		// Token: 0x1700AFF0 RID: 45040
		// (get) Token: 0x06027C97 RID: 162967 RVA: 0x00571722 File Offset: 0x0056F922
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027C98 RID: 162968 RVA: 0x0057172F File Offset: 0x0056F92F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027C99 RID: 162969 RVA: 0x00571738 File Offset: 0x0056F938
		public static IPointField GetRootAsIPointField(ByteBuffer _bb)
		{
			return IPointField.GetRootAsIPointField(_bb, default(IPointField));
		}

		// Token: 0x06027C9A RID: 162970 RVA: 0x00571754 File Offset: 0x0056F954
		public static IPointField GetRootAsIPointField(ByteBuffer _bb, IPointField obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027C9B RID: 162971 RVA: 0x00571771 File Offset: 0x0056F971
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027C9C RID: 162972 RVA: 0x00571780 File Offset: 0x0056F980
		public IPointField __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AFF1 RID: 45041
		// (get) Token: 0x06027C9D RID: 162973 RVA: 0x00571790 File Offset: 0x0056F990
		public EConveyorBeltFieldType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EConveyorBeltFieldType.DirectionalField;
				}
				return (EConveyorBeltFieldType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027C9E RID: 162974 RVA: 0x005717CC File Offset: 0x0056F9CC
		public static Offset<IPointField> CreateIPointField(FlatBufferBuilder builder, EConveyorBeltFieldType Type = EConveyorBeltFieldType.DirectionalField)
		{
			builder.StartTable(1);
			IPointField.AddType(builder, Type);
			return IPointField.EndIPointField(builder);
		}

		// Token: 0x06027C9F RID: 162975 RVA: 0x005717E2 File Offset: 0x0056F9E2
		public static void StartIPointField(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06027CA0 RID: 162976 RVA: 0x005717EB File Offset: 0x0056F9EB
		public static void AddType(FlatBufferBuilder builder, EConveyorBeltFieldType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027CA1 RID: 162977 RVA: 0x005717F6 File Offset: 0x0056F9F6
		public static Offset<IPointField> EndIPointField(FlatBufferBuilder builder)
		{
			return new Offset<IPointField>(builder.EndTable());
		}

		// Token: 0x06027CA2 RID: 162978 RVA: 0x00571804 File Offset: 0x0056FA04
		public IPointFieldT UnPack()
		{
			IPointFieldT pointFieldT = new IPointFieldT();
			this.UnPackTo(pointFieldT);
			return pointFieldT;
		}

		// Token: 0x06027CA3 RID: 162979 RVA: 0x0057181F File Offset: 0x0056FA1F
		public void UnPackTo(IPointFieldT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06027CA4 RID: 162980 RVA: 0x00571830 File Offset: 0x0056FA30
		public static Offset<IPointField> Pack(FlatBufferBuilder builder, IPointFieldT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPointField>);
			}
			return IPointField.CreateIPointField(builder, _o.Type);
		}

		// Token: 0x0400F8E3 RID: 63715
		private Table __p;
	}
}
