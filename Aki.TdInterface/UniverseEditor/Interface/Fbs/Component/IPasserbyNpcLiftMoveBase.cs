using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C8A RID: 23690
	public struct IPasserbyNpcLiftMoveBase : IFlatbufferObject
	{
		// Token: 0x1700AE09 RID: 44553
		// (get) Token: 0x060274C1 RID: 160961 RVA: 0x0056198C File Offset: 0x0055FB8C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060274C2 RID: 160962 RVA: 0x00561999 File Offset: 0x0055FB99
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060274C3 RID: 160963 RVA: 0x005619A0 File Offset: 0x0055FBA0
		public static IPasserbyNpcLiftMoveBase GetRootAsIPasserbyNpcLiftMoveBase(ByteBuffer _bb)
		{
			return IPasserbyNpcLiftMoveBase.GetRootAsIPasserbyNpcLiftMoveBase(_bb, default(IPasserbyNpcLiftMoveBase));
		}

		// Token: 0x060274C4 RID: 160964 RVA: 0x005619BC File Offset: 0x0055FBBC
		public static IPasserbyNpcLiftMoveBase GetRootAsIPasserbyNpcLiftMoveBase(ByteBuffer _bb, IPasserbyNpcLiftMoveBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060274C5 RID: 160965 RVA: 0x005619D9 File Offset: 0x0055FBD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060274C6 RID: 160966 RVA: 0x005619E8 File Offset: 0x0055FBE8
		public IPasserbyNpcLiftMoveBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AE0A RID: 44554
		// (get) Token: 0x060274C7 RID: 160967 RVA: 0x005619F8 File Offset: 0x0055FBF8
		public EPasserbyNpcLiftMoveType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPasserbyNpcLiftMoveType.RideLiftLeaveOnArrival;
				}
				return (EPasserbyNpcLiftMoveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060274C8 RID: 160968 RVA: 0x00561A34 File Offset: 0x0055FC34
		public static Offset<IPasserbyNpcLiftMoveBase> CreateIPasserbyNpcLiftMoveBase(FlatBufferBuilder builder, EPasserbyNpcLiftMoveType Type = EPasserbyNpcLiftMoveType.RideLiftLeaveOnArrival)
		{
			builder.StartTable(1);
			IPasserbyNpcLiftMoveBase.AddType(builder, Type);
			return IPasserbyNpcLiftMoveBase.EndIPasserbyNpcLiftMoveBase(builder);
		}

		// Token: 0x060274C9 RID: 160969 RVA: 0x00561A4A File Offset: 0x0055FC4A
		public static void StartIPasserbyNpcLiftMoveBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060274CA RID: 160970 RVA: 0x00561A53 File Offset: 0x0055FC53
		public static void AddType(FlatBufferBuilder builder, EPasserbyNpcLiftMoveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060274CB RID: 160971 RVA: 0x00561A5E File Offset: 0x0055FC5E
		public static Offset<IPasserbyNpcLiftMoveBase> EndIPasserbyNpcLiftMoveBase(FlatBufferBuilder builder)
		{
			return new Offset<IPasserbyNpcLiftMoveBase>(builder.EndTable());
		}

		// Token: 0x060274CC RID: 160972 RVA: 0x00561A6C File Offset: 0x0055FC6C
		public IPasserbyNpcLiftMoveBaseT UnPack()
		{
			IPasserbyNpcLiftMoveBaseT passerbyNpcLiftMoveBaseT = new IPasserbyNpcLiftMoveBaseT();
			this.UnPackTo(passerbyNpcLiftMoveBaseT);
			return passerbyNpcLiftMoveBaseT;
		}

		// Token: 0x060274CD RID: 160973 RVA: 0x00561A87 File Offset: 0x0055FC87
		public void UnPackTo(IPasserbyNpcLiftMoveBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060274CE RID: 160974 RVA: 0x00561A98 File Offset: 0x0055FC98
		public static Offset<IPasserbyNpcLiftMoveBase> Pack(FlatBufferBuilder builder, IPasserbyNpcLiftMoveBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPasserbyNpcLiftMoveBase>);
			}
			return IPasserbyNpcLiftMoveBase.CreateIPasserbyNpcLiftMoveBase(builder, _o.Type);
		}

		// Token: 0x0400F793 RID: 63379
		private Table __p;
	}
}
