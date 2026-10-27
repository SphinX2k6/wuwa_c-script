using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004ADB RID: 19163
	public struct ICheckPlayerCanJoinActivityType : IFlatbufferObject
	{
		// Token: 0x17008AF1 RID: 35569
		// (get) Token: 0x0601E19E RID: 123294 RVA: 0x0043906C File Offset: 0x0043726C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E19F RID: 123295 RVA: 0x00439079 File Offset: 0x00437279
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E1A0 RID: 123296 RVA: 0x00439080 File Offset: 0x00437280
		public static ICheckPlayerCanJoinActivityType GetRootAsICheckPlayerCanJoinActivityType(ByteBuffer _bb)
		{
			return ICheckPlayerCanJoinActivityType.GetRootAsICheckPlayerCanJoinActivityType(_bb, default(ICheckPlayerCanJoinActivityType));
		}

		// Token: 0x0601E1A1 RID: 123297 RVA: 0x0043909C File Offset: 0x0043729C
		public static ICheckPlayerCanJoinActivityType GetRootAsICheckPlayerCanJoinActivityType(ByteBuffer _bb, ICheckPlayerCanJoinActivityType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E1A2 RID: 123298 RVA: 0x004390B9 File Offset: 0x004372B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E1A3 RID: 123299 RVA: 0x004390C8 File Offset: 0x004372C8
		public ICheckPlayerCanJoinActivityType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008AF2 RID: 35570
		// (get) Token: 0x0601E1A4 RID: 123300 RVA: 0x004390D8 File Offset: 0x004372D8
		public ECheckPlayerCanJoinActivityType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckPlayerCanJoinActivityType.Rogue;
				}
				return (ECheckPlayerCanJoinActivityType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008AF3 RID: 35571
		// (get) Token: 0x0601E1A5 RID: 123301 RVA: 0x00439114 File Offset: 0x00437314
		public bool CanJoin
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601E1A6 RID: 123302 RVA: 0x00439153 File Offset: 0x00437353
		public static Offset<ICheckPlayerCanJoinActivityType> CreateICheckPlayerCanJoinActivityType(FlatBufferBuilder builder, ECheckPlayerCanJoinActivityType Type = ECheckPlayerCanJoinActivityType.Rogue, bool CanJoin = false)
		{
			builder.StartTable(2);
			ICheckPlayerCanJoinActivityType.AddCanJoin(builder, CanJoin);
			ICheckPlayerCanJoinActivityType.AddType(builder, Type);
			return ICheckPlayerCanJoinActivityType.EndICheckPlayerCanJoinActivityType(builder);
		}

		// Token: 0x0601E1A7 RID: 123303 RVA: 0x00439170 File Offset: 0x00437370
		public static void StartICheckPlayerCanJoinActivityType(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601E1A8 RID: 123304 RVA: 0x00439179 File Offset: 0x00437379
		public static void AddType(FlatBufferBuilder builder, ECheckPlayerCanJoinActivityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E1A9 RID: 123305 RVA: 0x00439184 File Offset: 0x00437384
		public static void AddCanJoin(FlatBufferBuilder builder, bool canJoin)
		{
			builder.AddBool(1, canJoin, false);
		}

		// Token: 0x0601E1AA RID: 123306 RVA: 0x0043918F File Offset: 0x0043738F
		public static Offset<ICheckPlayerCanJoinActivityType> EndICheckPlayerCanJoinActivityType(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPlayerCanJoinActivityType>(builder.EndTable());
		}

		// Token: 0x0601E1AB RID: 123307 RVA: 0x0043919C File Offset: 0x0043739C
		public ICheckPlayerCanJoinActivityTypeT UnPack()
		{
			ICheckPlayerCanJoinActivityTypeT checkPlayerCanJoinActivityTypeT = new ICheckPlayerCanJoinActivityTypeT();
			this.UnPackTo(checkPlayerCanJoinActivityTypeT);
			return checkPlayerCanJoinActivityTypeT;
		}

		// Token: 0x0601E1AC RID: 123308 RVA: 0x004391B7 File Offset: 0x004373B7
		public void UnPackTo(ICheckPlayerCanJoinActivityTypeT _o)
		{
			_o.Type = this.Type;
			_o.CanJoin = this.CanJoin;
		}

		// Token: 0x0601E1AD RID: 123309 RVA: 0x004391D4 File Offset: 0x004373D4
		public static Offset<ICheckPlayerCanJoinActivityType> Pack(FlatBufferBuilder builder, ICheckPlayerCanJoinActivityTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckPlayerCanJoinActivityType>);
			}
			return ICheckPlayerCanJoinActivityType.CreateICheckPlayerCanJoinActivityType(builder, _o.Type, _o.CanJoin);
		}

		// Token: 0x0400D365 RID: 54117
		private Table __p;
	}
}
