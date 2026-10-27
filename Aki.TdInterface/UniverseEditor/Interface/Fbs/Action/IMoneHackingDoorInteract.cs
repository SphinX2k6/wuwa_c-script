using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AD9 RID: 27353
	public struct IMoneHackingDoorInteract : IFlatbufferObject
	{
		// Token: 0x1700CAF0 RID: 51952
		// (get) Token: 0x0602FF1E RID: 196382 RVA: 0x00685340 File Offset: 0x00683540
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FF1F RID: 196383 RVA: 0x0068534D File Offset: 0x0068354D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FF20 RID: 196384 RVA: 0x00685354 File Offset: 0x00683554
		public static IMoneHackingDoorInteract GetRootAsIMoneHackingDoorInteract(ByteBuffer _bb)
		{
			return IMoneHackingDoorInteract.GetRootAsIMoneHackingDoorInteract(_bb, default(IMoneHackingDoorInteract));
		}

		// Token: 0x0602FF21 RID: 196385 RVA: 0x00685370 File Offset: 0x00683570
		public static IMoneHackingDoorInteract GetRootAsIMoneHackingDoorInteract(ByteBuffer _bb, IMoneHackingDoorInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FF22 RID: 196386 RVA: 0x0068538D File Offset: 0x0068358D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FF23 RID: 196387 RVA: 0x0068539C File Offset: 0x0068359C
		public IMoneHackingDoorInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CAF1 RID: 51953
		// (get) Token: 0x0602FF24 RID: 196388 RVA: 0x006853AC File Offset: 0x006835AC
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

		// Token: 0x0602FF25 RID: 196389 RVA: 0x006853E8 File Offset: 0x006835E8
		public static Offset<IMoneHackingDoorInteract> CreateIMoneHackingDoorInteract(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IMoneHackingDoorInteract.AddType(builder, Type);
			return IMoneHackingDoorInteract.EndIMoneHackingDoorInteract(builder);
		}

		// Token: 0x0602FF26 RID: 196390 RVA: 0x006853FE File Offset: 0x006835FE
		public static void StartIMoneHackingDoorInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602FF27 RID: 196391 RVA: 0x00685407 File Offset: 0x00683607
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FF28 RID: 196392 RVA: 0x00685412 File Offset: 0x00683612
		public static Offset<IMoneHackingDoorInteract> EndIMoneHackingDoorInteract(FlatBufferBuilder builder)
		{
			return new Offset<IMoneHackingDoorInteract>(builder.EndTable());
		}

		// Token: 0x0602FF29 RID: 196393 RVA: 0x00685420 File Offset: 0x00683620
		public IMoneHackingDoorInteractT UnPack()
		{
			IMoneHackingDoorInteractT moneHackingDoorInteractT = new IMoneHackingDoorInteractT();
			this.UnPackTo(moneHackingDoorInteractT);
			return moneHackingDoorInteractT;
		}

		// Token: 0x0602FF2A RID: 196394 RVA: 0x0068543B File Offset: 0x0068363B
		public void UnPackTo(IMoneHackingDoorInteractT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602FF2B RID: 196395 RVA: 0x0068544C File Offset: 0x0068364C
		public static Offset<IMoneHackingDoorInteract> Pack(FlatBufferBuilder builder, IMoneHackingDoorInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMoneHackingDoorInteract>);
			}
			return IMoneHackingDoorInteract.CreateIMoneHackingDoorInteract(builder, _o.Type);
		}

		// Token: 0x04011329 RID: 70441
		private Table __p;
	}
}
