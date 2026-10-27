using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A6B RID: 27243
	public struct IManipulate : IFlatbufferObject
	{
		// Token: 0x1700CA1E RID: 51742
		// (get) Token: 0x0602FB64 RID: 195428 RVA: 0x0067E351 File Offset: 0x0067C551
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FB65 RID: 195429 RVA: 0x0067E35E File Offset: 0x0067C55E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FB66 RID: 195430 RVA: 0x0067E368 File Offset: 0x0067C568
		public static IManipulate GetRootAsIManipulate(ByteBuffer _bb)
		{
			return IManipulate.GetRootAsIManipulate(_bb, default(IManipulate));
		}

		// Token: 0x0602FB67 RID: 195431 RVA: 0x0067E384 File Offset: 0x0067C584
		public static IManipulate GetRootAsIManipulate(ByteBuffer _bb, IManipulate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FB68 RID: 195432 RVA: 0x0067E3A1 File Offset: 0x0067C5A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FB69 RID: 195433 RVA: 0x0067E3B0 File Offset: 0x0067C5B0
		public IManipulate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA1F RID: 51743
		// (get) Token: 0x0602FB6A RID: 195434 RVA: 0x0067E3C0 File Offset: 0x0067C5C0
		public ELeisureInteract Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELeisureInteract.CustomSkill;
				}
				return (ELeisureInteract)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CA20 RID: 51744
		// (get) Token: 0x0602FB6B RID: 195435 RVA: 0x0067E3FC File Offset: 0x0067C5FC
		public int TargetEntityId
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

		// Token: 0x0602FB6C RID: 195436 RVA: 0x0067E438 File Offset: 0x0067C638
		public static Offset<IManipulate> CreateIManipulate(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill, int TargetEntityId = 0)
		{
			builder.StartTable(2);
			IManipulate.AddTargetEntityId(builder, TargetEntityId);
			IManipulate.AddType(builder, Type);
			return IManipulate.EndIManipulate(builder);
		}

		// Token: 0x0602FB6D RID: 195437 RVA: 0x0067E455 File Offset: 0x0067C655
		public static void StartIManipulate(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602FB6E RID: 195438 RVA: 0x0067E45E File Offset: 0x0067C65E
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FB6F RID: 195439 RVA: 0x0067E469 File Offset: 0x0067C669
		public static void AddTargetEntityId(FlatBufferBuilder builder, int targetEntityId)
		{
			builder.AddInt(1, targetEntityId, 0);
		}

		// Token: 0x0602FB70 RID: 195440 RVA: 0x0067E474 File Offset: 0x0067C674
		public static Offset<IManipulate> EndIManipulate(FlatBufferBuilder builder)
		{
			return new Offset<IManipulate>(builder.EndTable());
		}

		// Token: 0x0602FB71 RID: 195441 RVA: 0x0067E484 File Offset: 0x0067C684
		public IManipulateT UnPack()
		{
			IManipulateT manipulateT = new IManipulateT();
			this.UnPackTo(manipulateT);
			return manipulateT;
		}

		// Token: 0x0602FB72 RID: 195442 RVA: 0x0067E49F File Offset: 0x0067C69F
		public void UnPackTo(IManipulateT _o)
		{
			_o.Type = this.Type;
			_o.TargetEntityId = this.TargetEntityId;
		}

		// Token: 0x0602FB73 RID: 195443 RVA: 0x0067E4BC File Offset: 0x0067C6BC
		public static Offset<IManipulate> Pack(FlatBufferBuilder builder, IManipulateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IManipulate>);
			}
			return IManipulate.CreateIManipulate(builder, _o.Type, _o.TargetEntityId);
		}

		// Token: 0x0401128F RID: 70287
		private Table __p;
	}
}
