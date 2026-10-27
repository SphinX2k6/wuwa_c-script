using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B53 RID: 19283
	public struct ICheckTargetType : IFlatbufferObject
	{
		// Token: 0x17008BE7 RID: 35815
		// (get) Token: 0x0601E5E9 RID: 124393 RVA: 0x0044148D File Offset: 0x0043F68D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E5EA RID: 124394 RVA: 0x0044149A File Offset: 0x0043F69A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E5EB RID: 124395 RVA: 0x004414A4 File Offset: 0x0043F6A4
		public static ICheckTargetType GetRootAsICheckTargetType(ByteBuffer _bb)
		{
			return ICheckTargetType.GetRootAsICheckTargetType(_bb, default(ICheckTargetType));
		}

		// Token: 0x0601E5EC RID: 124396 RVA: 0x004414C0 File Offset: 0x0043F6C0
		public static ICheckTargetType GetRootAsICheckTargetType(ByteBuffer _bb, ICheckTargetType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E5ED RID: 124397 RVA: 0x004414DD File Offset: 0x0043F6DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E5EE RID: 124398 RVA: 0x004414EC File Offset: 0x0043F6EC
		public ICheckTargetType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008BE8 RID: 35816
		// (get) Token: 0x0601E5EF RID: 124399 RVA: 0x004414FC File Offset: 0x0043F6FC
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

		// Token: 0x0601E5F0 RID: 124400 RVA: 0x00441538 File Offset: 0x0043F738
		public static Offset<ICheckTargetType> CreateICheckTargetType(FlatBufferBuilder builder, ECheckTargetType Type = ECheckTargetType.AllPlayer)
		{
			builder.StartTable(1);
			ICheckTargetType.AddType(builder, Type);
			return ICheckTargetType.EndICheckTargetType(builder);
		}

		// Token: 0x0601E5F1 RID: 124401 RVA: 0x0044154E File Offset: 0x0043F74E
		public static void StartICheckTargetType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601E5F2 RID: 124402 RVA: 0x00441557 File Offset: 0x0043F757
		public static void AddType(FlatBufferBuilder builder, ECheckTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E5F3 RID: 124403 RVA: 0x00441562 File Offset: 0x0043F762
		public static Offset<ICheckTargetType> EndICheckTargetType(FlatBufferBuilder builder)
		{
			return new Offset<ICheckTargetType>(builder.EndTable());
		}

		// Token: 0x0601E5F4 RID: 124404 RVA: 0x00441570 File Offset: 0x0043F770
		public ICheckTargetTypeT UnPack()
		{
			ICheckTargetTypeT checkTargetTypeT = new ICheckTargetTypeT();
			this.UnPackTo(checkTargetTypeT);
			return checkTargetTypeT;
		}

		// Token: 0x0601E5F5 RID: 124405 RVA: 0x0044158B File Offset: 0x0043F78B
		public void UnPackTo(ICheckTargetTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601E5F6 RID: 124406 RVA: 0x0044159C File Offset: 0x0043F79C
		public static Offset<ICheckTargetType> Pack(FlatBufferBuilder builder, ICheckTargetTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckTargetType>);
			}
			return ICheckTargetType.CreateICheckTargetType(builder, _o.Type);
		}

		// Token: 0x0400D412 RID: 54290
		private Table __p;
	}
}
