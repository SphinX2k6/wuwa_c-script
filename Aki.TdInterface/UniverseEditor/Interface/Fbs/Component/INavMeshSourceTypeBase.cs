using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055EA RID: 21994
	public struct INavMeshSourceTypeBase : IFlatbufferObject
	{
		// Token: 0x1700A2C2 RID: 41666
		// (get) Token: 0x060247D3 RID: 149459 RVA: 0x005096C3 File Offset: 0x005078C3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060247D4 RID: 149460 RVA: 0x005096D0 File Offset: 0x005078D0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060247D5 RID: 149461 RVA: 0x005096D8 File Offset: 0x005078D8
		public static INavMeshSourceTypeBase GetRootAsINavMeshSourceTypeBase(ByteBuffer _bb)
		{
			return INavMeshSourceTypeBase.GetRootAsINavMeshSourceTypeBase(_bb, default(INavMeshSourceTypeBase));
		}

		// Token: 0x060247D6 RID: 149462 RVA: 0x005096F4 File Offset: 0x005078F4
		public static INavMeshSourceTypeBase GetRootAsINavMeshSourceTypeBase(ByteBuffer _bb, INavMeshSourceTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060247D7 RID: 149463 RVA: 0x00509711 File Offset: 0x00507911
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060247D8 RID: 149464 RVA: 0x00509720 File Offset: 0x00507920
		public INavMeshSourceTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A2C3 RID: 41667
		// (get) Token: 0x060247D9 RID: 149465 RVA: 0x00509730 File Offset: 0x00507930
		public ENavMeshSourceType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENavMeshSourceType.AkiEntitySource;
				}
				return (ENavMeshSourceType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060247DA RID: 149466 RVA: 0x0050976C File Offset: 0x0050796C
		public static Offset<INavMeshSourceTypeBase> CreateINavMeshSourceTypeBase(FlatBufferBuilder builder, ENavMeshSourceType Type = ENavMeshSourceType.AkiEntitySource)
		{
			builder.StartTable(1);
			INavMeshSourceTypeBase.AddType(builder, Type);
			return INavMeshSourceTypeBase.EndINavMeshSourceTypeBase(builder);
		}

		// Token: 0x060247DB RID: 149467 RVA: 0x00509782 File Offset: 0x00507982
		public static void StartINavMeshSourceTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060247DC RID: 149468 RVA: 0x0050978B File Offset: 0x0050798B
		public static void AddType(FlatBufferBuilder builder, ENavMeshSourceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060247DD RID: 149469 RVA: 0x00509796 File Offset: 0x00507996
		public static Offset<INavMeshSourceTypeBase> EndINavMeshSourceTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<INavMeshSourceTypeBase>(builder.EndTable());
		}

		// Token: 0x060247DE RID: 149470 RVA: 0x005097A4 File Offset: 0x005079A4
		public INavMeshSourceTypeBaseT UnPack()
		{
			INavMeshSourceTypeBaseT navMeshSourceTypeBaseT = new INavMeshSourceTypeBaseT();
			this.UnPackTo(navMeshSourceTypeBaseT);
			return navMeshSourceTypeBaseT;
		}

		// Token: 0x060247DF RID: 149471 RVA: 0x005097BF File Offset: 0x005079BF
		public void UnPackTo(INavMeshSourceTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060247E0 RID: 149472 RVA: 0x005097D0 File Offset: 0x005079D0
		public static Offset<INavMeshSourceTypeBase> Pack(FlatBufferBuilder builder, INavMeshSourceTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<INavMeshSourceTypeBase>);
			}
			return INavMeshSourceTypeBase.CreateINavMeshSourceTypeBase(builder, _o.Type);
		}

		// Token: 0x0400E955 RID: 59733
		private Table __p;
	}
}
