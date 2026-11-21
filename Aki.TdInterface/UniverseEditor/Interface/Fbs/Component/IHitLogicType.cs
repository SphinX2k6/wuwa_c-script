using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005927 RID: 22823
	public struct IHitLogicType : IFlatbufferObject
	{
		// Token: 0x1700A585 RID: 42373
		// (get) Token: 0x060251BE RID: 151998 RVA: 0x00517C0E File Offset: 0x00515E0E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060251BF RID: 151999 RVA: 0x00517C1B File Offset: 0x00515E1B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060251C0 RID: 152000 RVA: 0x00517C24 File Offset: 0x00515E24
		public static IHitLogicType GetRootAsIHitLogicType(ByteBuffer _bb)
		{
			return IHitLogicType.GetRootAsIHitLogicType(_bb, default(IHitLogicType));
		}

		// Token: 0x060251C1 RID: 152001 RVA: 0x00517C40 File Offset: 0x00515E40
		public static IHitLogicType GetRootAsIHitLogicType(ByteBuffer _bb, IHitLogicType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060251C2 RID: 152002 RVA: 0x00517C5D File Offset: 0x00515E5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060251C3 RID: 152003 RVA: 0x00517C6C File Offset: 0x00515E6C
		public IHitLogicType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A586 RID: 42374
		// (get) Token: 0x060251C4 RID: 152004 RVA: 0x00517C7C File Offset: 0x00515E7C
		public EHitLogicType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHitLogicType.ChangeNextState;
				}
				return (EHitLogicType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060251C5 RID: 152005 RVA: 0x00517CB8 File Offset: 0x00515EB8
		public static Offset<IHitLogicType> CreateIHitLogicType(FlatBufferBuilder builder, EHitLogicType Type = EHitLogicType.ChangeNextState)
		{
			builder.StartTable(1);
			IHitLogicType.AddType(builder, Type);
			return IHitLogicType.EndIHitLogicType(builder);
		}

		// Token: 0x060251C6 RID: 152006 RVA: 0x00517CCE File Offset: 0x00515ECE
		public static void StartIHitLogicType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060251C7 RID: 152007 RVA: 0x00517CD7 File Offset: 0x00515ED7
		public static void AddType(FlatBufferBuilder builder, EHitLogicType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060251C8 RID: 152008 RVA: 0x00517CE2 File Offset: 0x00515EE2
		public static Offset<IHitLogicType> EndIHitLogicType(FlatBufferBuilder builder)
		{
			return new Offset<IHitLogicType>(builder.EndTable());
		}

		// Token: 0x060251C9 RID: 152009 RVA: 0x00517CF0 File Offset: 0x00515EF0
		public IHitLogicTypeT UnPack()
		{
			IHitLogicTypeT hitLogicTypeT = new IHitLogicTypeT();
			this.UnPackTo(hitLogicTypeT);
			return hitLogicTypeT;
		}

		// Token: 0x060251CA RID: 152010 RVA: 0x00517D0B File Offset: 0x00515F0B
		public void UnPackTo(IHitLogicTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060251CB RID: 152011 RVA: 0x00517D1C File Offset: 0x00515F1C
		public static Offset<IHitLogicType> Pack(FlatBufferBuilder builder, IHitLogicTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHitLogicType>);
			}
			return IHitLogicType.CreateIHitLogicType(builder, _o.Type);
		}

		// Token: 0x0400F1BB RID: 61883
		private Table __p;
	}
}
