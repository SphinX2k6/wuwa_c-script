using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051D4 RID: 20948
	public struct IExhibitItemType : IFlatbufferObject
	{
		// Token: 0x17009952 RID: 39250
		// (get) Token: 0x06021F84 RID: 139140 RVA: 0x004B667B File Offset: 0x004B487B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021F85 RID: 139141 RVA: 0x004B6688 File Offset: 0x004B4888
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021F86 RID: 139142 RVA: 0x004B6690 File Offset: 0x004B4890
		public static IExhibitItemType GetRootAsIExhibitItemType(ByteBuffer _bb)
		{
			return IExhibitItemType.GetRootAsIExhibitItemType(_bb, default(IExhibitItemType));
		}

		// Token: 0x06021F87 RID: 139143 RVA: 0x004B66AC File Offset: 0x004B48AC
		public static IExhibitItemType GetRootAsIExhibitItemType(ByteBuffer _bb, IExhibitItemType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021F88 RID: 139144 RVA: 0x004B66C9 File Offset: 0x004B48C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021F89 RID: 139145 RVA: 0x004B66D8 File Offset: 0x004B48D8
		public IExhibitItemType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009953 RID: 39251
		// (get) Token: 0x06021F8A RID: 139146 RVA: 0x004B66E8 File Offset: 0x004B48E8
		public EExhibitItemType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExhibitItemType.Phantom;
				}
				return (EExhibitItemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021F8B RID: 139147 RVA: 0x004B6724 File Offset: 0x004B4924
		public static Offset<IExhibitItemType> CreateIExhibitItemType(FlatBufferBuilder builder, EExhibitItemType Type = EExhibitItemType.Phantom)
		{
			builder.StartTable(1);
			IExhibitItemType.AddType(builder, Type);
			return IExhibitItemType.EndIExhibitItemType(builder);
		}

		// Token: 0x06021F8C RID: 139148 RVA: 0x004B673A File Offset: 0x004B493A
		public static void StartIExhibitItemType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06021F8D RID: 139149 RVA: 0x004B6743 File Offset: 0x004B4943
		public static void AddType(FlatBufferBuilder builder, EExhibitItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021F8E RID: 139150 RVA: 0x004B674E File Offset: 0x004B494E
		public static Offset<IExhibitItemType> EndIExhibitItemType(FlatBufferBuilder builder)
		{
			return new Offset<IExhibitItemType>(builder.EndTable());
		}

		// Token: 0x06021F8F RID: 139151 RVA: 0x004B675C File Offset: 0x004B495C
		public IExhibitItemTypeT UnPack()
		{
			IExhibitItemTypeT exhibitItemTypeT = new IExhibitItemTypeT();
			this.UnPackTo(exhibitItemTypeT);
			return exhibitItemTypeT;
		}

		// Token: 0x06021F90 RID: 139152 RVA: 0x004B6777 File Offset: 0x004B4977
		public void UnPackTo(IExhibitItemTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06021F91 RID: 139153 RVA: 0x004B6788 File Offset: 0x004B4988
		public static Offset<IExhibitItemType> Pack(FlatBufferBuilder builder, IExhibitItemTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExhibitItemType>);
			}
			return IExhibitItemType.CreateIExhibitItemType(builder, _o.Type);
		}

		// Token: 0x0400E2DA RID: 58074
		private Table __p;
	}
}
