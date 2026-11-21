using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Match
{
	// Token: 0x02004868 RID: 18536
	public struct IMatchRoleType : IFlatbufferObject
	{
		// Token: 0x17008116 RID: 33046
		// (get) Token: 0x0601B679 RID: 112249 RVA: 0x003E13E0 File Offset: 0x003DF5E0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B67A RID: 112250 RVA: 0x003E13ED File Offset: 0x003DF5ED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B67B RID: 112251 RVA: 0x003E13F4 File Offset: 0x003DF5F4
		public static IMatchRoleType GetRootAsIMatchRoleType(ByteBuffer _bb)
		{
			return IMatchRoleType.GetRootAsIMatchRoleType(_bb, default(IMatchRoleType));
		}

		// Token: 0x0601B67C RID: 112252 RVA: 0x003E1410 File Offset: 0x003DF610
		public static IMatchRoleType GetRootAsIMatchRoleType(ByteBuffer _bb, IMatchRoleType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B67D RID: 112253 RVA: 0x003E142D File Offset: 0x003DF62D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B67E RID: 112254 RVA: 0x003E143C File Offset: 0x003DF63C
		public IMatchRoleType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008117 RID: 33047
		// (get) Token: 0x0601B67F RID: 112255 RVA: 0x003E144C File Offset: 0x003DF64C
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

		// Token: 0x0601B680 RID: 112256 RVA: 0x003E1488 File Offset: 0x003DF688
		public static Offset<IMatchRoleType> CreateIMatchRoleType(FlatBufferBuilder builder, EMatchRoleType Type = EMatchRoleType.Player)
		{
			builder.StartTable(1);
			IMatchRoleType.AddType(builder, Type);
			return IMatchRoleType.EndIMatchRoleType(builder);
		}

		// Token: 0x0601B681 RID: 112257 RVA: 0x003E149E File Offset: 0x003DF69E
		public static void StartIMatchRoleType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601B682 RID: 112258 RVA: 0x003E14A7 File Offset: 0x003DF6A7
		public static void AddType(FlatBufferBuilder builder, EMatchRoleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B683 RID: 112259 RVA: 0x003E14B2 File Offset: 0x003DF6B2
		public static Offset<IMatchRoleType> EndIMatchRoleType(FlatBufferBuilder builder)
		{
			return new Offset<IMatchRoleType>(builder.EndTable());
		}

		// Token: 0x0601B684 RID: 112260 RVA: 0x003E14C0 File Offset: 0x003DF6C0
		public IMatchRoleTypeT UnPack()
		{
			IMatchRoleTypeT matchRoleTypeT = new IMatchRoleTypeT();
			this.UnPackTo(matchRoleTypeT);
			return matchRoleTypeT;
		}

		// Token: 0x0601B685 RID: 112261 RVA: 0x003E14DB File Offset: 0x003DF6DB
		public void UnPackTo(IMatchRoleTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601B686 RID: 112262 RVA: 0x003E14EC File Offset: 0x003DF6EC
		public static Offset<IMatchRoleType> Pack(FlatBufferBuilder builder, IMatchRoleTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMatchRoleType>);
			}
			return IMatchRoleType.CreateIMatchRoleType(builder, _o.Type);
		}

		// Token: 0x0400CD80 RID: 52608
		private Table __p;
	}
}
