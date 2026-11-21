using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007210 RID: 29200
	public struct IMoneHackingDoorInteract : IFlatbufferObject
	{
		// Token: 0x1700D5BB RID: 54715
		// (get) Token: 0x06032CEA RID: 208106 RVA: 0x006DC8DC File Offset: 0x006DAADC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032CEB RID: 208107 RVA: 0x006DC8E9 File Offset: 0x006DAAE9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032CEC RID: 208108 RVA: 0x006DC8F0 File Offset: 0x006DAAF0
		public static IMoneHackingDoorInteract GetRootAsIMoneHackingDoorInteract(ByteBuffer _bb)
		{
			return IMoneHackingDoorInteract.GetRootAsIMoneHackingDoorInteract(_bb, default(IMoneHackingDoorInteract));
		}

		// Token: 0x06032CED RID: 208109 RVA: 0x006DC90C File Offset: 0x006DAB0C
		public static IMoneHackingDoorInteract GetRootAsIMoneHackingDoorInteract(ByteBuffer _bb, IMoneHackingDoorInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032CEE RID: 208110 RVA: 0x006DC929 File Offset: 0x006DAB29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032CEF RID: 208111 RVA: 0x006DC938 File Offset: 0x006DAB38
		public IMoneHackingDoorInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D5BC RID: 54716
		// (get) Token: 0x06032CF0 RID: 208112 RVA: 0x006DC948 File Offset: 0x006DAB48
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

		// Token: 0x06032CF1 RID: 208113 RVA: 0x006DC984 File Offset: 0x006DAB84
		public static Offset<IMoneHackingDoorInteract> CreateIMoneHackingDoorInteract(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IMoneHackingDoorInteract.AddType(builder, Type);
			return IMoneHackingDoorInteract.EndIMoneHackingDoorInteract(builder);
		}

		// Token: 0x06032CF2 RID: 208114 RVA: 0x006DC99A File Offset: 0x006DAB9A
		public static void StartIMoneHackingDoorInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032CF3 RID: 208115 RVA: 0x006DC9A3 File Offset: 0x006DABA3
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032CF4 RID: 208116 RVA: 0x006DC9AE File Offset: 0x006DABAE
		public static Offset<IMoneHackingDoorInteract> EndIMoneHackingDoorInteract(FlatBufferBuilder builder)
		{
			return new Offset<IMoneHackingDoorInteract>(builder.EndTable());
		}

		// Token: 0x06032CF5 RID: 208117 RVA: 0x006DC9BC File Offset: 0x006DABBC
		public IMoneHackingDoorInteractT UnPack()
		{
			IMoneHackingDoorInteractT moneHackingDoorInteractT = new IMoneHackingDoorInteractT();
			this.UnPackTo(moneHackingDoorInteractT);
			return moneHackingDoorInteractT;
		}

		// Token: 0x06032CF6 RID: 208118 RVA: 0x006DC9D7 File Offset: 0x006DABD7
		public void UnPackTo(IMoneHackingDoorInteractT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06032CF7 RID: 208119 RVA: 0x006DC9E8 File Offset: 0x006DABE8
		public static Offset<IMoneHackingDoorInteract> Pack(FlatBufferBuilder builder, IMoneHackingDoorInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMoneHackingDoorInteract>);
			}
			return IMoneHackingDoorInteract.CreateIMoneHackingDoorInteract(builder, _o.Type);
		}

		// Token: 0x0401223A RID: 74298
		private Table __p;
	}
}
