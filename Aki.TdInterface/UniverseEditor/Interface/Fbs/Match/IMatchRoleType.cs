using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Match
{
	// Token: 0x02004400 RID: 17408
	public struct IMatchRoleType : IFlatbufferObject
	{
		// Token: 0x17007AD7 RID: 31447
		// (get) Token: 0x06019EAC RID: 106156 RVA: 0x003B5264 File Offset: 0x003B3464
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019EAD RID: 106157 RVA: 0x003B5271 File Offset: 0x003B3471
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019EAE RID: 106158 RVA: 0x003B5278 File Offset: 0x003B3478
		public static IMatchRoleType GetRootAsIMatchRoleType(ByteBuffer _bb)
		{
			return IMatchRoleType.GetRootAsIMatchRoleType(_bb, default(IMatchRoleType));
		}

		// Token: 0x06019EAF RID: 106159 RVA: 0x003B5294 File Offset: 0x003B3494
		public static IMatchRoleType GetRootAsIMatchRoleType(ByteBuffer _bb, IMatchRoleType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019EB0 RID: 106160 RVA: 0x003B52B1 File Offset: 0x003B34B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019EB1 RID: 106161 RVA: 0x003B52C0 File Offset: 0x003B34C0
		public IMatchRoleType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007AD8 RID: 31448
		// (get) Token: 0x06019EB2 RID: 106162 RVA: 0x003B52D0 File Offset: 0x003B34D0
		public EMatchRoleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMatchRoleType.Player;
				}
				return (EMatchRoleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019EB3 RID: 106163 RVA: 0x003B530C File Offset: 0x003B350C
		public static Offset<IMatchRoleType> CreateIMatchRoleType(FlatBufferBuilder builder, EMatchRoleType Type = EMatchRoleType.Player)
		{
			builder.StartTable(1);
			IMatchRoleType.AddType(builder, Type);
			return IMatchRoleType.EndIMatchRoleType(builder);
		}

		// Token: 0x06019EB4 RID: 106164 RVA: 0x003B5322 File Offset: 0x003B3522
		public static void StartIMatchRoleType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06019EB5 RID: 106165 RVA: 0x003B532B File Offset: 0x003B352B
		public static void AddType(FlatBufferBuilder builder, EMatchRoleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019EB6 RID: 106166 RVA: 0x003B5336 File Offset: 0x003B3536
		public static Offset<IMatchRoleType> EndIMatchRoleType(FlatBufferBuilder builder)
		{
			return new Offset<IMatchRoleType>(builder.EndTable());
		}

		// Token: 0x06019EB7 RID: 106167 RVA: 0x003B5344 File Offset: 0x003B3544
		public IMatchRoleTypeT UnPack()
		{
			IMatchRoleTypeT matchRoleTypeT = new IMatchRoleTypeT();
			this.UnPackTo(matchRoleTypeT);
			return matchRoleTypeT;
		}

		// Token: 0x06019EB8 RID: 106168 RVA: 0x003B535F File Offset: 0x003B355F
		public void UnPackTo(IMatchRoleTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06019EB9 RID: 106169 RVA: 0x003B5370 File Offset: 0x003B3570
		public static Offset<IMatchRoleType> Pack(FlatBufferBuilder builder, IMatchRoleTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMatchRoleType>);
			}
			return IMatchRoleType.CreateIMatchRoleType(builder, _o.Type);
		}

		// Token: 0x0400C355 RID: 50005
		private Table __p;
	}
}
