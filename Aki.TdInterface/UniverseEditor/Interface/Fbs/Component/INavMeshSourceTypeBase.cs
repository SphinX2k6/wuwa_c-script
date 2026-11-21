using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B88 RID: 23432
	public struct INavMeshSourceTypeBase : IFlatbufferObject
	{
		// Token: 0x1700AB4A RID: 43850
		// (get) Token: 0x060269E0 RID: 158176 RVA: 0x00549C3B File Offset: 0x00547E3B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060269E1 RID: 158177 RVA: 0x00549C48 File Offset: 0x00547E48
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060269E2 RID: 158178 RVA: 0x00549C50 File Offset: 0x00547E50
		public static INavMeshSourceTypeBase GetRootAsINavMeshSourceTypeBase(ByteBuffer _bb)
		{
			return INavMeshSourceTypeBase.GetRootAsINavMeshSourceTypeBase(_bb, default(INavMeshSourceTypeBase));
		}

		// Token: 0x060269E3 RID: 158179 RVA: 0x00549C6C File Offset: 0x00547E6C
		public static INavMeshSourceTypeBase GetRootAsINavMeshSourceTypeBase(ByteBuffer _bb, INavMeshSourceTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060269E4 RID: 158180 RVA: 0x00549C89 File Offset: 0x00547E89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060269E5 RID: 158181 RVA: 0x00549C98 File Offset: 0x00547E98
		public INavMeshSourceTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AB4B RID: 43851
		// (get) Token: 0x060269E6 RID: 158182 RVA: 0x00549CA8 File Offset: 0x00547EA8
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

		// Token: 0x060269E7 RID: 158183 RVA: 0x00549CE4 File Offset: 0x00547EE4
		public static Offset<INavMeshSourceTypeBase> CreateINavMeshSourceTypeBase(FlatBufferBuilder builder, ENavMeshSourceType Type = ENavMeshSourceType.AkiEntitySource)
		{
			builder.StartTable(1);
			INavMeshSourceTypeBase.AddType(builder, Type);
			return INavMeshSourceTypeBase.EndINavMeshSourceTypeBase(builder);
		}

		// Token: 0x060269E8 RID: 158184 RVA: 0x00549CFA File Offset: 0x00547EFA
		public static void StartINavMeshSourceTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060269E9 RID: 158185 RVA: 0x00549D03 File Offset: 0x00547F03
		public static void AddType(FlatBufferBuilder builder, ENavMeshSourceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060269EA RID: 158186 RVA: 0x00549D0E File Offset: 0x00547F0E
		public static Offset<INavMeshSourceTypeBase> EndINavMeshSourceTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<INavMeshSourceTypeBase>(builder.EndTable());
		}

		// Token: 0x060269EB RID: 158187 RVA: 0x00549D1C File Offset: 0x00547F1C
		public INavMeshSourceTypeBaseT UnPack()
		{
			INavMeshSourceTypeBaseT navMeshSourceTypeBaseT = new INavMeshSourceTypeBaseT();
			this.UnPackTo(navMeshSourceTypeBaseT);
			return navMeshSourceTypeBaseT;
		}

		// Token: 0x060269EC RID: 158188 RVA: 0x00549D37 File Offset: 0x00547F37
		public void UnPackTo(INavMeshSourceTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060269ED RID: 158189 RVA: 0x00549D48 File Offset: 0x00547F48
		public static Offset<INavMeshSourceTypeBase> Pack(FlatBufferBuilder builder, INavMeshSourceTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<INavMeshSourceTypeBase>);
			}
			return INavMeshSourceTypeBase.CreateINavMeshSourceTypeBase(builder, _o.Type);
		}

		// Token: 0x0400F5B7 RID: 62903
		private Table __p;
	}
}
