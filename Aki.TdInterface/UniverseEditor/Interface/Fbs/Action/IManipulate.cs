using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200718D RID: 29069
	public struct IManipulate : IFlatbufferObject
	{
		// Token: 0x1700D4C9 RID: 54473
		// (get) Token: 0x0603288A RID: 206986 RVA: 0x006D4411 File Offset: 0x006D2611
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603288B RID: 206987 RVA: 0x006D441E File Offset: 0x006D261E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603288C RID: 206988 RVA: 0x006D4428 File Offset: 0x006D2628
		public static IManipulate GetRootAsIManipulate(ByteBuffer _bb)
		{
			return IManipulate.GetRootAsIManipulate(_bb, default(IManipulate));
		}

		// Token: 0x0603288D RID: 206989 RVA: 0x006D4444 File Offset: 0x006D2644
		public static IManipulate GetRootAsIManipulate(ByteBuffer _bb, IManipulate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603288E RID: 206990 RVA: 0x006D4461 File Offset: 0x006D2661
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603288F RID: 206991 RVA: 0x006D4470 File Offset: 0x006D2670
		public IManipulate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D4CA RID: 54474
		// (get) Token: 0x06032890 RID: 206992 RVA: 0x006D4480 File Offset: 0x006D2680
		public ELeisureInteract Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELeisureInteract.CustomSkill;
				}
				return (ELeisureInteract)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D4CB RID: 54475
		// (get) Token: 0x06032891 RID: 206993 RVA: 0x006D44BC File Offset: 0x006D26BC
		public int TargetEntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032892 RID: 206994 RVA: 0x006D44F8 File Offset: 0x006D26F8
		public static Offset<IManipulate> CreateIManipulate(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill, int TargetEntityId = 0)
		{
			builder.StartTable(2);
			IManipulate.AddTargetEntityId(builder, TargetEntityId);
			IManipulate.AddType(builder, Type);
			return IManipulate.EndIManipulate(builder);
		}

		// Token: 0x06032893 RID: 206995 RVA: 0x006D4515 File Offset: 0x006D2715
		public static void StartIManipulate(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032894 RID: 206996 RVA: 0x006D451E File Offset: 0x006D271E
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032895 RID: 206997 RVA: 0x006D4529 File Offset: 0x006D2729
		public static void AddTargetEntityId(FlatBufferBuilder builder, int targetEntityId)
		{
			builder.AddInt(1, targetEntityId, 0);
		}

		// Token: 0x06032896 RID: 206998 RVA: 0x006D4534 File Offset: 0x006D2734
		public static Offset<IManipulate> EndIManipulate(FlatBufferBuilder builder)
		{
			return new Offset<IManipulate>(builder.EndTable());
		}

		// Token: 0x06032897 RID: 206999 RVA: 0x006D4544 File Offset: 0x006D2744
		public IManipulateT UnPack()
		{
			IManipulateT manipulateT = new IManipulateT();
			this.UnPackTo(manipulateT);
			return manipulateT;
		}

		// Token: 0x06032898 RID: 207000 RVA: 0x006D455F File Offset: 0x006D275F
		public void UnPackTo(IManipulateT _o)
		{
			_o.Type = this.Type;
			_o.TargetEntityId = this.TargetEntityId;
		}

		// Token: 0x06032899 RID: 207001 RVA: 0x006D457C File Offset: 0x006D277C
		public static Offset<IManipulate> Pack(FlatBufferBuilder builder, IManipulateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IManipulate>);
			}
			return IManipulate.CreateIManipulate(builder, _o.Type, _o.TargetEntityId);
		}

		// Token: 0x04012187 RID: 74119
		private Table __p;
	}
}
