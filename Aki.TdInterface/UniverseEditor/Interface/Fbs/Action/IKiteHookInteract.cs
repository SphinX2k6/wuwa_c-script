using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069D8 RID: 27096
	public struct IKiteHookInteract : IFlatbufferObject
	{
		// Token: 0x1700C910 RID: 51472
		// (get) Token: 0x0602F5DD RID: 194013 RVA: 0x0067342D File Offset: 0x0067162D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F5DE RID: 194014 RVA: 0x0067343A File Offset: 0x0067163A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F5DF RID: 194015 RVA: 0x00673444 File Offset: 0x00671644
		public static IKiteHookInteract GetRootAsIKiteHookInteract(ByteBuffer _bb)
		{
			return IKiteHookInteract.GetRootAsIKiteHookInteract(_bb, default(IKiteHookInteract));
		}

		// Token: 0x0602F5E0 RID: 194016 RVA: 0x00673460 File Offset: 0x00671660
		public static IKiteHookInteract GetRootAsIKiteHookInteract(ByteBuffer _bb, IKiteHookInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F5E1 RID: 194017 RVA: 0x0067347D File Offset: 0x0067167D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F5E2 RID: 194018 RVA: 0x0067348C File Offset: 0x0067168C
		public IKiteHookInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C911 RID: 51473
		// (get) Token: 0x0602F5E3 RID: 194019 RVA: 0x0067349C File Offset: 0x0067169C
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

		// Token: 0x1700C912 RID: 51474
		// (get) Token: 0x0602F5E4 RID: 194020 RVA: 0x006734D8 File Offset: 0x006716D8
		public int EntityId
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

		// Token: 0x0602F5E5 RID: 194021 RVA: 0x00673514 File Offset: 0x00671714
		public static Offset<IKiteHookInteract> CreateIKiteHookInteract(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill, int EntityId = 0)
		{
			builder.StartTable(2);
			IKiteHookInteract.AddEntityId(builder, EntityId);
			IKiteHookInteract.AddType(builder, Type);
			return IKiteHookInteract.EndIKiteHookInteract(builder);
		}

		// Token: 0x0602F5E6 RID: 194022 RVA: 0x00673531 File Offset: 0x00671731
		public static void StartIKiteHookInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F5E7 RID: 194023 RVA: 0x0067353A File Offset: 0x0067173A
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F5E8 RID: 194024 RVA: 0x00673545 File Offset: 0x00671745
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0602F5E9 RID: 194025 RVA: 0x00673550 File Offset: 0x00671750
		public static Offset<IKiteHookInteract> EndIKiteHookInteract(FlatBufferBuilder builder)
		{
			return new Offset<IKiteHookInteract>(builder.EndTable());
		}

		// Token: 0x0602F5EA RID: 194026 RVA: 0x00673560 File Offset: 0x00671760
		public IKiteHookInteractT UnPack()
		{
			IKiteHookInteractT kiteHookInteractT = new IKiteHookInteractT();
			this.UnPackTo(kiteHookInteractT);
			return kiteHookInteractT;
		}

		// Token: 0x0602F5EB RID: 194027 RVA: 0x0067357B File Offset: 0x0067177B
		public void UnPackTo(IKiteHookInteractT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x0602F5EC RID: 194028 RVA: 0x00673598 File Offset: 0x00671798
		public static Offset<IKiteHookInteract> Pack(FlatBufferBuilder builder, IKiteHookInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IKiteHookInteract>);
			}
			return IKiteHookInteract.CreateIKiteHookInteract(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x04011197 RID: 70039
		private Table __p;
	}
}
