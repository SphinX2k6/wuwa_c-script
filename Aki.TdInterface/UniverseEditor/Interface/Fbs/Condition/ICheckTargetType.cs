using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200503A RID: 20538
	public struct ICheckTargetType : IFlatbufferObject
	{
		// Token: 0x170092F7 RID: 37623
		// (get) Token: 0x06020177 RID: 131447 RVA: 0x00473CD9 File Offset: 0x00471ED9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020178 RID: 131448 RVA: 0x00473CE6 File Offset: 0x00471EE6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020179 RID: 131449 RVA: 0x00473CF0 File Offset: 0x00471EF0
		public static ICheckTargetType GetRootAsICheckTargetType(ByteBuffer _bb)
		{
			return ICheckTargetType.GetRootAsICheckTargetType(_bb, default(ICheckTargetType));
		}

		// Token: 0x0602017A RID: 131450 RVA: 0x00473D0C File Offset: 0x00471F0C
		public static ICheckTargetType GetRootAsICheckTargetType(ByteBuffer _bb, ICheckTargetType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602017B RID: 131451 RVA: 0x00473D29 File Offset: 0x00471F29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602017C RID: 131452 RVA: 0x00473D38 File Offset: 0x00471F38
		public ICheckTargetType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170092F8 RID: 37624
		// (get) Token: 0x0602017D RID: 131453 RVA: 0x00473D48 File Offset: 0x00471F48
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

		// Token: 0x0602017E RID: 131454 RVA: 0x00473D84 File Offset: 0x00471F84
		public static Offset<ICheckTargetType> CreateICheckTargetType(FlatBufferBuilder builder, ECheckTargetType Type = ECheckTargetType.AllPlayer)
		{
			builder.StartTable(1);
			ICheckTargetType.AddType(builder, Type);
			return ICheckTargetType.EndICheckTargetType(builder);
		}

		// Token: 0x0602017F RID: 131455 RVA: 0x00473D9A File Offset: 0x00471F9A
		public static void StartICheckTargetType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06020180 RID: 131456 RVA: 0x00473DA3 File Offset: 0x00471FA3
		public static void AddType(FlatBufferBuilder builder, ECheckTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020181 RID: 131457 RVA: 0x00473DAE File Offset: 0x00471FAE
		public static Offset<ICheckTargetType> EndICheckTargetType(FlatBufferBuilder builder)
		{
			return new Offset<ICheckTargetType>(builder.EndTable());
		}

		// Token: 0x06020182 RID: 131458 RVA: 0x00473DBC File Offset: 0x00471FBC
		public ICheckTargetTypeT UnPack()
		{
			ICheckTargetTypeT checkTargetTypeT = new ICheckTargetTypeT();
			this.UnPackTo(checkTargetTypeT);
			return checkTargetTypeT;
		}

		// Token: 0x06020183 RID: 131459 RVA: 0x00473DD7 File Offset: 0x00471FD7
		public void UnPackTo(ICheckTargetTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06020184 RID: 131460 RVA: 0x00473DE8 File Offset: 0x00471FE8
		public static Offset<ICheckTargetType> Pack(FlatBufferBuilder builder, ICheckTargetTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckTargetType>);
			}
			return ICheckTargetType.CreateICheckTargetType(builder, _o.Type);
		}

		// Token: 0x0400DF12 RID: 57106
		private Table __p;
	}
}
