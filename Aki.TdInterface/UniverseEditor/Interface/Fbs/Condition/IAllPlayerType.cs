using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004967 RID: 18791
	public struct IAllPlayerType : IFlatbufferObject
	{
		// Token: 0x170087C3 RID: 34755
		// (get) Token: 0x0601D490 RID: 119952 RVA: 0x00421B39 File Offset: 0x0041FD39
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D491 RID: 119953 RVA: 0x00421B46 File Offset: 0x0041FD46
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D492 RID: 119954 RVA: 0x00421B50 File Offset: 0x0041FD50
		public static IAllPlayerType GetRootAsIAllPlayerType(ByteBuffer _bb)
		{
			return IAllPlayerType.GetRootAsIAllPlayerType(_bb, default(IAllPlayerType));
		}

		// Token: 0x0601D493 RID: 119955 RVA: 0x00421B6C File Offset: 0x0041FD6C
		public static IAllPlayerType GetRootAsIAllPlayerType(ByteBuffer _bb, IAllPlayerType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D494 RID: 119956 RVA: 0x00421B89 File Offset: 0x0041FD89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D495 RID: 119957 RVA: 0x00421B98 File Offset: 0x0041FD98
		public IAllPlayerType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170087C4 RID: 34756
		// (get) Token: 0x0601D496 RID: 119958 RVA: 0x00421BA8 File Offset: 0x0041FDA8
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

		// Token: 0x0601D497 RID: 119959 RVA: 0x00421BE4 File Offset: 0x0041FDE4
		public static Offset<IAllPlayerType> CreateIAllPlayerType(FlatBufferBuilder builder, ECheckTargetType Type = ECheckTargetType.AllPlayer)
		{
			builder.StartTable(1);
			IAllPlayerType.AddType(builder, Type);
			return IAllPlayerType.EndIAllPlayerType(builder);
		}

		// Token: 0x0601D498 RID: 119960 RVA: 0x00421BFA File Offset: 0x0041FDFA
		public static void StartIAllPlayerType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601D499 RID: 119961 RVA: 0x00421C03 File Offset: 0x0041FE03
		public static void AddType(FlatBufferBuilder builder, ECheckTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D49A RID: 119962 RVA: 0x00421C0E File Offset: 0x0041FE0E
		public static Offset<IAllPlayerType> EndIAllPlayerType(FlatBufferBuilder builder)
		{
			return new Offset<IAllPlayerType>(builder.EndTable());
		}

		// Token: 0x0601D49B RID: 119963 RVA: 0x00421C1C File Offset: 0x0041FE1C
		public IAllPlayerTypeT UnPack()
		{
			IAllPlayerTypeT allPlayerTypeT = new IAllPlayerTypeT();
			this.UnPackTo(allPlayerTypeT);
			return allPlayerTypeT;
		}

		// Token: 0x0601D49C RID: 119964 RVA: 0x00421C37 File Offset: 0x0041FE37
		public void UnPackTo(IAllPlayerTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601D49D RID: 119965 RVA: 0x00421C48 File Offset: 0x0041FE48
		public static Offset<IAllPlayerType> Pack(FlatBufferBuilder builder, IAllPlayerTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAllPlayerType>);
			}
			return IAllPlayerType.CreateIAllPlayerType(builder, _o.Type);
		}

		// Token: 0x0400D160 RID: 53600
		private Table __p;
	}
}
