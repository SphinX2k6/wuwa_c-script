using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FFE RID: 20478
	public struct ICheckRogueStateType : IFlatbufferObject
	{
		// Token: 0x17009283 RID: 37507
		// (get) Token: 0x0601FF51 RID: 130897 RVA: 0x0046FA50 File Offset: 0x0046DC50
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FF52 RID: 130898 RVA: 0x0046FA5D File Offset: 0x0046DC5D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FF53 RID: 130899 RVA: 0x0046FA64 File Offset: 0x0046DC64
		public static ICheckRogueStateType GetRootAsICheckRogueStateType(ByteBuffer _bb)
		{
			return ICheckRogueStateType.GetRootAsICheckRogueStateType(_bb, default(ICheckRogueStateType));
		}

		// Token: 0x0601FF54 RID: 130900 RVA: 0x0046FA80 File Offset: 0x0046DC80
		public static ICheckRogueStateType GetRootAsICheckRogueStateType(ByteBuffer _bb, ICheckRogueStateType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FF55 RID: 130901 RVA: 0x0046FA9D File Offset: 0x0046DC9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FF56 RID: 130902 RVA: 0x0046FAAC File Offset: 0x0046DCAC
		public ICheckRogueStateType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009284 RID: 37508
		// (get) Token: 0x0601FF57 RID: 130903 RVA: 0x0046FABC File Offset: 0x0046DCBC
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

		// Token: 0x0601FF58 RID: 130904 RVA: 0x0046FAF8 File Offset: 0x0046DCF8
		public static Offset<ICheckRogueStateType> CreateICheckRogueStateType(FlatBufferBuilder builder, ERogueStateType Type = ERogueStateType.Talent)
		{
			builder.StartTable(1);
			ICheckRogueStateType.AddType(builder, Type);
			return ICheckRogueStateType.EndICheckRogueStateType(builder);
		}

		// Token: 0x0601FF59 RID: 130905 RVA: 0x0046FB0E File Offset: 0x0046DD0E
		public static void StartICheckRogueStateType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601FF5A RID: 130906 RVA: 0x0046FB17 File Offset: 0x0046DD17
		public static void AddType(FlatBufferBuilder builder, ERogueStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FF5B RID: 130907 RVA: 0x0046FB22 File Offset: 0x0046DD22
		public static Offset<ICheckRogueStateType> EndICheckRogueStateType(FlatBufferBuilder builder)
		{
			return new Offset<ICheckRogueStateType>(builder.EndTable());
		}

		// Token: 0x0601FF5C RID: 130908 RVA: 0x0046FB30 File Offset: 0x0046DD30
		public ICheckRogueStateTypeT UnPack()
		{
			ICheckRogueStateTypeT checkRogueStateTypeT = new ICheckRogueStateTypeT();
			this.UnPackTo(checkRogueStateTypeT);
			return checkRogueStateTypeT;
		}

		// Token: 0x0601FF5D RID: 130909 RVA: 0x0046FB4B File Offset: 0x0046DD4B
		public void UnPackTo(ICheckRogueStateTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601FF5E RID: 130910 RVA: 0x0046FB5C File Offset: 0x0046DD5C
		public static Offset<ICheckRogueStateType> Pack(FlatBufferBuilder builder, ICheckRogueStateTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckRogueStateType>);
			}
			return ICheckRogueStateType.CreateICheckRogueStateType(builder, _o.Type);
		}

		// Token: 0x0400DEB3 RID: 57011
		private Table __p;
	}
}
