using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E1E RID: 19998
	public struct IAllPlayerType : IFlatbufferObject
	{
		// Token: 0x17008E7E RID: 36478
		// (get) Token: 0x0601EEB5 RID: 126645 RVA: 0x00451FED File Offset: 0x004501ED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EEB6 RID: 126646 RVA: 0x00451FFA File Offset: 0x004501FA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EEB7 RID: 126647 RVA: 0x00452004 File Offset: 0x00450204
		public static IAllPlayerType GetRootAsIAllPlayerType(ByteBuffer _bb)
		{
			return IAllPlayerType.GetRootAsIAllPlayerType(_bb, default(IAllPlayerType));
		}

		// Token: 0x0601EEB8 RID: 126648 RVA: 0x00452020 File Offset: 0x00450220
		public static IAllPlayerType GetRootAsIAllPlayerType(ByteBuffer _bb, IAllPlayerType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EEB9 RID: 126649 RVA: 0x0045203D File Offset: 0x0045023D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EEBA RID: 126650 RVA: 0x0045204C File Offset: 0x0045024C
		public IAllPlayerType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E7F RID: 36479
		// (get) Token: 0x0601EEBB RID: 126651 RVA: 0x0045205C File Offset: 0x0045025C
		public ECheckTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckTargetType.AllPlayer;
				}
				return (ECheckTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601EEBC RID: 126652 RVA: 0x00452098 File Offset: 0x00450298
		public static Offset<IAllPlayerType> CreateIAllPlayerType(FlatBufferBuilder builder, ECheckTargetType Type = ECheckTargetType.AllPlayer)
		{
			builder.StartTable(1);
			IAllPlayerType.AddType(builder, Type);
			return IAllPlayerType.EndIAllPlayerType(builder);
		}

		// Token: 0x0601EEBD RID: 126653 RVA: 0x004520AE File Offset: 0x004502AE
		public static void StartIAllPlayerType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601EEBE RID: 126654 RVA: 0x004520B7 File Offset: 0x004502B7
		public static void AddType(FlatBufferBuilder builder, ECheckTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EEBF RID: 126655 RVA: 0x004520C2 File Offset: 0x004502C2
		public static Offset<IAllPlayerType> EndIAllPlayerType(FlatBufferBuilder builder)
		{
			return new Offset<IAllPlayerType>(builder.EndTable());
		}

		// Token: 0x0601EEC0 RID: 126656 RVA: 0x004520D0 File Offset: 0x004502D0
		public IAllPlayerTypeT UnPack()
		{
			IAllPlayerTypeT allPlayerTypeT = new IAllPlayerTypeT();
			this.UnPackTo(allPlayerTypeT);
			return allPlayerTypeT;
		}

		// Token: 0x0601EEC1 RID: 126657 RVA: 0x004520EB File Offset: 0x004502EB
		public void UnPackTo(IAllPlayerTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601EEC2 RID: 126658 RVA: 0x004520FC File Offset: 0x004502FC
		public static Offset<IAllPlayerType> Pack(FlatBufferBuilder builder, IAllPlayerTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAllPlayerType>);
			}
			return IAllPlayerType.CreateIAllPlayerType(builder, _o.Type);
		}

		// Token: 0x0400DC28 RID: 56360
		private Table __p;
	}
}
