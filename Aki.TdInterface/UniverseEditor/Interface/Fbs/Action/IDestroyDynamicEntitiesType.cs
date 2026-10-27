using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006585 RID: 25989
	public struct IDestroyDynamicEntitiesType : IFlatbufferObject
	{
		// Token: 0x1700C10A RID: 49418
		// (get) Token: 0x0602D149 RID: 184649 RVA: 0x0062F3D3 File Offset: 0x0062D5D3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D14A RID: 184650 RVA: 0x0062F3E0 File Offset: 0x0062D5E0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D14B RID: 184651 RVA: 0x0062F3E8 File Offset: 0x0062D5E8
		public static IDestroyDynamicEntitiesType GetRootAsIDestroyDynamicEntitiesType(ByteBuffer _bb)
		{
			return IDestroyDynamicEntitiesType.GetRootAsIDestroyDynamicEntitiesType(_bb, default(IDestroyDynamicEntitiesType));
		}

		// Token: 0x0602D14C RID: 184652 RVA: 0x0062F404 File Offset: 0x0062D604
		public static IDestroyDynamicEntitiesType GetRootAsIDestroyDynamicEntitiesType(ByteBuffer _bb, IDestroyDynamicEntitiesType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D14D RID: 184653 RVA: 0x0062F421 File Offset: 0x0062D621
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D14E RID: 184654 RVA: 0x0062F430 File Offset: 0x0062D630
		public IDestroyDynamicEntitiesType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C10B RID: 49419
		// (get) Token: 0x0602D14F RID: 184655 RVA: 0x0062F440 File Offset: 0x0062D640
		public EDynamicEntityType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDynamicEntityType.VisionDisplay;
				}
				return (EDynamicEntityType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D150 RID: 184656 RVA: 0x0062F47C File Offset: 0x0062D67C
		public static Offset<IDestroyDynamicEntitiesType> CreateIDestroyDynamicEntitiesType(FlatBufferBuilder builder, EDynamicEntityType Type = EDynamicEntityType.VisionDisplay)
		{
			builder.StartTable(1);
			IDestroyDynamicEntitiesType.AddType(builder, Type);
			return IDestroyDynamicEntitiesType.EndIDestroyDynamicEntitiesType(builder);
		}

		// Token: 0x0602D151 RID: 184657 RVA: 0x0062F492 File Offset: 0x0062D692
		public static void StartIDestroyDynamicEntitiesType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602D152 RID: 184658 RVA: 0x0062F49B File Offset: 0x0062D69B
		public static void AddType(FlatBufferBuilder builder, EDynamicEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D153 RID: 184659 RVA: 0x0062F4A6 File Offset: 0x0062D6A6
		public static Offset<IDestroyDynamicEntitiesType> EndIDestroyDynamicEntitiesType(FlatBufferBuilder builder)
		{
			return new Offset<IDestroyDynamicEntitiesType>(builder.EndTable());
		}

		// Token: 0x0602D154 RID: 184660 RVA: 0x0062F4B4 File Offset: 0x0062D6B4
		public IDestroyDynamicEntitiesTypeT UnPack()
		{
			IDestroyDynamicEntitiesTypeT destroyDynamicEntitiesTypeT = new IDestroyDynamicEntitiesTypeT();
			this.UnPackTo(destroyDynamicEntitiesTypeT);
			return destroyDynamicEntitiesTypeT;
		}

		// Token: 0x0602D155 RID: 184661 RVA: 0x0062F4CF File Offset: 0x0062D6CF
		public void UnPackTo(IDestroyDynamicEntitiesTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602D156 RID: 184662 RVA: 0x0062F4E0 File Offset: 0x0062D6E0
		public static Offset<IDestroyDynamicEntitiesType> Pack(FlatBufferBuilder builder, IDestroyDynamicEntitiesTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDestroyDynamicEntitiesType>);
			}
			return IDestroyDynamicEntitiesType.CreateIDestroyDynamicEntitiesType(builder, _o.Type);
		}

		// Token: 0x04010BDC RID: 68572
		private Table __p;
	}
}
