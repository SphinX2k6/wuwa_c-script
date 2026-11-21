using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200694C RID: 26956
	public struct IChangeElementalBoxStateTargetBoxId : IFlatbufferObject
	{
		// Token: 0x1700C66D RID: 50797
		// (get) Token: 0x0602E34C RID: 189260 RVA: 0x0064FC45 File Offset: 0x0064DE45
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E34D RID: 189261 RVA: 0x0064FC52 File Offset: 0x0064DE52
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E34E RID: 189262 RVA: 0x0064FC5C File Offset: 0x0064DE5C
		public static IChangeElementalBoxStateTargetBoxId GetRootAsIChangeElementalBoxStateTargetBoxId(ByteBuffer _bb)
		{
			return IChangeElementalBoxStateTargetBoxId.GetRootAsIChangeElementalBoxStateTargetBoxId(_bb, default(IChangeElementalBoxStateTargetBoxId));
		}

		// Token: 0x0602E34F RID: 189263 RVA: 0x0064FC78 File Offset: 0x0064DE78
		public static IChangeElementalBoxStateTargetBoxId GetRootAsIChangeElementalBoxStateTargetBoxId(ByteBuffer _bb, IChangeElementalBoxStateTargetBoxId obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E350 RID: 189264 RVA: 0x0064FC95 File Offset: 0x0064DE95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E351 RID: 189265 RVA: 0x0064FCA4 File Offset: 0x0064DEA4
		public IChangeElementalBoxStateTargetBoxId __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C66E RID: 50798
		// (get) Token: 0x0602E352 RID: 189266 RVA: 0x0064FCB4 File Offset: 0x0064DEB4
		public EChangeElementalBoxStateTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChangeElementalBoxStateTargetType.Player;
				}
				return (EChangeElementalBoxStateTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C66F RID: 50799
		// (get) Token: 0x0602E353 RID: 189267 RVA: 0x0064FCF0 File Offset: 0x0064DEF0
		public int TargetBoxId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E354 RID: 189268 RVA: 0x0064FD2C File Offset: 0x0064DF2C
		public static Offset<IChangeElementalBoxStateTargetBoxId> CreateIChangeElementalBoxStateTargetBoxId(FlatBufferBuilder builder, EChangeElementalBoxStateTargetType Type = EChangeElementalBoxStateTargetType.Player, int TargetBoxId = 0)
		{
			builder.StartTable(2);
			IChangeElementalBoxStateTargetBoxId.AddTargetBoxId(builder, TargetBoxId);
			IChangeElementalBoxStateTargetBoxId.AddType(builder, Type);
			return IChangeElementalBoxStateTargetBoxId.EndIChangeElementalBoxStateTargetBoxId(builder);
		}

		// Token: 0x0602E355 RID: 189269 RVA: 0x0064FD49 File Offset: 0x0064DF49
		public static void StartIChangeElementalBoxStateTargetBoxId(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E356 RID: 189270 RVA: 0x0064FD52 File Offset: 0x0064DF52
		public static void AddType(FlatBufferBuilder builder, EChangeElementalBoxStateTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E357 RID: 189271 RVA: 0x0064FD5D File Offset: 0x0064DF5D
		public static void AddTargetBoxId(FlatBufferBuilder builder, int targetBoxId)
		{
			builder.AddInt(1, targetBoxId, 0);
		}

		// Token: 0x0602E358 RID: 189272 RVA: 0x0064FD68 File Offset: 0x0064DF68
		public static Offset<IChangeElementalBoxStateTargetBoxId> EndIChangeElementalBoxStateTargetBoxId(FlatBufferBuilder builder)
		{
			return new Offset<IChangeElementalBoxStateTargetBoxId>(builder.EndTable());
		}

		// Token: 0x0602E359 RID: 189273 RVA: 0x0064FD78 File Offset: 0x0064DF78
		public IChangeElementalBoxStateTargetBoxIdT UnPack()
		{
			IChangeElementalBoxStateTargetBoxIdT changeElementalBoxStateTargetBoxIdT = new IChangeElementalBoxStateTargetBoxIdT();
			this.UnPackTo(changeElementalBoxStateTargetBoxIdT);
			return changeElementalBoxStateTargetBoxIdT;
		}

		// Token: 0x0602E35A RID: 189274 RVA: 0x0064FD93 File Offset: 0x0064DF93
		public void UnPackTo(IChangeElementalBoxStateTargetBoxIdT _o)
		{
			_o.Type = this.Type;
			_o.TargetBoxId = this.TargetBoxId;
		}

		// Token: 0x0602E35B RID: 189275 RVA: 0x0064FDB0 File Offset: 0x0064DFB0
		public static Offset<IChangeElementalBoxStateTargetBoxId> Pack(FlatBufferBuilder builder, IChangeElementalBoxStateTargetBoxIdT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeElementalBoxStateTargetBoxId>);
			}
			return IChangeElementalBoxStateTargetBoxId.CreateIChangeElementalBoxStateTargetBoxId(builder, _o.Type, _o.TargetBoxId);
		}

		// Token: 0x04011697 RID: 71319
		private Table __p;
	}
}
