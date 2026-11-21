using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C93 RID: 23699
	public struct IPasserbyNpcMoveBase : IFlatbufferObject
	{
		// Token: 0x1700AE13 RID: 44563
		// (get) Token: 0x060274F5 RID: 161013 RVA: 0x00561E8C File Offset: 0x0056008C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060274F6 RID: 161014 RVA: 0x00561E99 File Offset: 0x00560099
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060274F7 RID: 161015 RVA: 0x00561EA0 File Offset: 0x005600A0
		public static IPasserbyNpcMoveBase GetRootAsIPasserbyNpcMoveBase(ByteBuffer _bb)
		{
			return IPasserbyNpcMoveBase.GetRootAsIPasserbyNpcMoveBase(_bb, default(IPasserbyNpcMoveBase));
		}

		// Token: 0x060274F8 RID: 161016 RVA: 0x00561EBC File Offset: 0x005600BC
		public static IPasserbyNpcMoveBase GetRootAsIPasserbyNpcMoveBase(ByteBuffer _bb, IPasserbyNpcMoveBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060274F9 RID: 161017 RVA: 0x00561ED9 File Offset: 0x005600D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060274FA RID: 161018 RVA: 0x00561EE8 File Offset: 0x005600E8
		public IPasserbyNpcMoveBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AE14 RID: 44564
		// (get) Token: 0x060274FB RID: 161019 RVA: 0x00561EF8 File Offset: 0x005600F8
		public EPasserbyNpcMoveType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPasserbyNpcMoveType.Spline;
				}
				return (EPasserbyNpcMoveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060274FC RID: 161020 RVA: 0x00561F34 File Offset: 0x00560134
		public static Offset<IPasserbyNpcMoveBase> CreateIPasserbyNpcMoveBase(FlatBufferBuilder builder, EPasserbyNpcMoveType Type = EPasserbyNpcMoveType.Spline)
		{
			builder.StartTable(1);
			IPasserbyNpcMoveBase.AddType(builder, Type);
			return IPasserbyNpcMoveBase.EndIPasserbyNpcMoveBase(builder);
		}

		// Token: 0x060274FD RID: 161021 RVA: 0x00561F4A File Offset: 0x0056014A
		public static void StartIPasserbyNpcMoveBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060274FE RID: 161022 RVA: 0x00561F53 File Offset: 0x00560153
		public static void AddType(FlatBufferBuilder builder, EPasserbyNpcMoveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060274FF RID: 161023 RVA: 0x00561F5E File Offset: 0x0056015E
		public static Offset<IPasserbyNpcMoveBase> EndIPasserbyNpcMoveBase(FlatBufferBuilder builder)
		{
			return new Offset<IPasserbyNpcMoveBase>(builder.EndTable());
		}

		// Token: 0x06027500 RID: 161024 RVA: 0x00561F6C File Offset: 0x0056016C
		public IPasserbyNpcMoveBaseT UnPack()
		{
			IPasserbyNpcMoveBaseT passerbyNpcMoveBaseT = new IPasserbyNpcMoveBaseT();
			this.UnPackTo(passerbyNpcMoveBaseT);
			return passerbyNpcMoveBaseT;
		}

		// Token: 0x06027501 RID: 161025 RVA: 0x00561F87 File Offset: 0x00560187
		public void UnPackTo(IPasserbyNpcMoveBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06027502 RID: 161026 RVA: 0x00561F98 File Offset: 0x00560198
		public static Offset<IPasserbyNpcMoveBase> Pack(FlatBufferBuilder builder, IPasserbyNpcMoveBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPasserbyNpcMoveBase>);
			}
			return IPasserbyNpcMoveBase.CreateIPasserbyNpcMoveBase(builder, _o.Type);
		}

		// Token: 0x0400F79E RID: 63390
		private Table __p;
	}
}
