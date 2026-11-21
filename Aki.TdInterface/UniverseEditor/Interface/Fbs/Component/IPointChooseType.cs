using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D58 RID: 23896
	public struct IPointChooseType : IFlatbufferObject
	{
		// Token: 0x1700AFEB RID: 45035
		// (get) Token: 0x06027C79 RID: 162937 RVA: 0x005714B0 File Offset: 0x0056F6B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027C7A RID: 162938 RVA: 0x005714BD File Offset: 0x0056F6BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027C7B RID: 162939 RVA: 0x005714C4 File Offset: 0x0056F6C4
		public static IPointChooseType GetRootAsIPointChooseType(ByteBuffer _bb)
		{
			return IPointChooseType.GetRootAsIPointChooseType(_bb, default(IPointChooseType));
		}

		// Token: 0x06027C7C RID: 162940 RVA: 0x005714E0 File Offset: 0x0056F6E0
		public static IPointChooseType GetRootAsIPointChooseType(ByteBuffer _bb, IPointChooseType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027C7D RID: 162941 RVA: 0x005714FD File Offset: 0x0056F6FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027C7E RID: 162942 RVA: 0x0057150C File Offset: 0x0056F70C
		public IPointChooseType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AFEC RID: 45036
		// (get) Token: 0x06027C7F RID: 162943 RVA: 0x0057151C File Offset: 0x0056F71C
		public EPointChooseType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPointChooseType.SpawnMonsterPoint;
				}
				return (EPointChooseType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027C80 RID: 162944 RVA: 0x00571558 File Offset: 0x0056F758
		public static Offset<IPointChooseType> CreateIPointChooseType(FlatBufferBuilder builder, EPointChooseType Type = EPointChooseType.SpawnMonsterPoint)
		{
			builder.StartTable(1);
			IPointChooseType.AddType(builder, Type);
			return IPointChooseType.EndIPointChooseType(builder);
		}

		// Token: 0x06027C81 RID: 162945 RVA: 0x0057156E File Offset: 0x0056F76E
		public static void StartIPointChooseType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06027C82 RID: 162946 RVA: 0x00571577 File Offset: 0x0056F777
		public static void AddType(FlatBufferBuilder builder, EPointChooseType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027C83 RID: 162947 RVA: 0x00571582 File Offset: 0x0056F782
		public static Offset<IPointChooseType> EndIPointChooseType(FlatBufferBuilder builder)
		{
			return new Offset<IPointChooseType>(builder.EndTable());
		}

		// Token: 0x06027C84 RID: 162948 RVA: 0x00571590 File Offset: 0x0056F790
		public IPointChooseTypeT UnPack()
		{
			IPointChooseTypeT pointChooseTypeT = new IPointChooseTypeT();
			this.UnPackTo(pointChooseTypeT);
			return pointChooseTypeT;
		}

		// Token: 0x06027C85 RID: 162949 RVA: 0x005715AB File Offset: 0x0056F7AB
		public void UnPackTo(IPointChooseTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06027C86 RID: 162950 RVA: 0x005715BC File Offset: 0x0056F7BC
		public static Offset<IPointChooseType> Pack(FlatBufferBuilder builder, IPointChooseTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPointChooseType>);
			}
			return IPointChooseType.CreateIPointChooseType(builder, _o.Type);
		}

		// Token: 0x0400F8DB RID: 63707
		private Table __p;
	}
}
