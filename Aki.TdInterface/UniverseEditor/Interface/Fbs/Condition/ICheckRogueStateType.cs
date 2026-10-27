using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B17 RID: 19223
	public struct ICheckRogueStateType : IFlatbufferObject
	{
		// Token: 0x17008B73 RID: 35699
		// (get) Token: 0x0601E3C6 RID: 123846 RVA: 0x0043D2A4 File Offset: 0x0043B4A4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E3C7 RID: 123847 RVA: 0x0043D2B1 File Offset: 0x0043B4B1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E3C8 RID: 123848 RVA: 0x0043D2B8 File Offset: 0x0043B4B8
		public static ICheckRogueStateType GetRootAsICheckRogueStateType(ByteBuffer _bb)
		{
			return ICheckRogueStateType.GetRootAsICheckRogueStateType(_bb, default(ICheckRogueStateType));
		}

		// Token: 0x0601E3C9 RID: 123849 RVA: 0x0043D2D4 File Offset: 0x0043B4D4
		public static ICheckRogueStateType GetRootAsICheckRogueStateType(ByteBuffer _bb, ICheckRogueStateType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E3CA RID: 123850 RVA: 0x0043D2F1 File Offset: 0x0043B4F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E3CB RID: 123851 RVA: 0x0043D300 File Offset: 0x0043B500
		public ICheckRogueStateType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008B74 RID: 35700
		// (get) Token: 0x0601E3CC RID: 123852 RVA: 0x0043D310 File Offset: 0x0043B510
		public ERogueStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERogueStateType.Talent;
				}
				return (ERogueStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E3CD RID: 123853 RVA: 0x0043D34C File Offset: 0x0043B54C
		public static Offset<ICheckRogueStateType> CreateICheckRogueStateType(FlatBufferBuilder builder, ERogueStateType Type = ERogueStateType.Talent)
		{
			builder.StartTable(1);
			ICheckRogueStateType.AddType(builder, Type);
			return ICheckRogueStateType.EndICheckRogueStateType(builder);
		}

		// Token: 0x0601E3CE RID: 123854 RVA: 0x0043D362 File Offset: 0x0043B562
		public static void StartICheckRogueStateType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601E3CF RID: 123855 RVA: 0x0043D36B File Offset: 0x0043B56B
		public static void AddType(FlatBufferBuilder builder, ERogueStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E3D0 RID: 123856 RVA: 0x0043D376 File Offset: 0x0043B576
		public static Offset<ICheckRogueStateType> EndICheckRogueStateType(FlatBufferBuilder builder)
		{
			return new Offset<ICheckRogueStateType>(builder.EndTable());
		}

		// Token: 0x0601E3D1 RID: 123857 RVA: 0x0043D384 File Offset: 0x0043B584
		public ICheckRogueStateTypeT UnPack()
		{
			ICheckRogueStateTypeT checkRogueStateTypeT = new ICheckRogueStateTypeT();
			this.UnPackTo(checkRogueStateTypeT);
			return checkRogueStateTypeT;
		}

		// Token: 0x0601E3D2 RID: 123858 RVA: 0x0043D39F File Offset: 0x0043B59F
		public void UnPackTo(ICheckRogueStateTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601E3D3 RID: 123859 RVA: 0x0043D3B0 File Offset: 0x0043B5B0
		public static Offset<ICheckRogueStateType> Pack(FlatBufferBuilder builder, ICheckRogueStateTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckRogueStateType>);
			}
			return ICheckRogueStateType.CreateICheckRogueStateType(builder, _o.Type);
		}

		// Token: 0x0400D3B4 RID: 54196
		private Table __p;
	}
}
