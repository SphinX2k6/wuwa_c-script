using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069B7 RID: 27063
	public struct ICharacterLookAtEntityData : IFlatbufferObject
	{
		// Token: 0x1700C728 RID: 50984
		// (get) Token: 0x0602E6C2 RID: 190146 RVA: 0x00655BB5 File Offset: 0x00653DB5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E6C3 RID: 190147 RVA: 0x00655BC2 File Offset: 0x00653DC2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E6C4 RID: 190148 RVA: 0x00655BCC File Offset: 0x00653DCC
		public static ICharacterLookAtEntityData GetRootAsICharacterLookAtEntityData(ByteBuffer _bb)
		{
			return ICharacterLookAtEntityData.GetRootAsICharacterLookAtEntityData(_bb, default(ICharacterLookAtEntityData));
		}

		// Token: 0x0602E6C5 RID: 190149 RVA: 0x00655BE8 File Offset: 0x00653DE8
		public static ICharacterLookAtEntityData GetRootAsICharacterLookAtEntityData(ByteBuffer _bb, ICharacterLookAtEntityData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E6C6 RID: 190150 RVA: 0x00655C05 File Offset: 0x00653E05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E6C7 RID: 190151 RVA: 0x00655C14 File Offset: 0x00653E14
		public ICharacterLookAtEntityData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C729 RID: 50985
		// (get) Token: 0x0602E6C8 RID: 190152 RVA: 0x00655C24 File Offset: 0x00653E24
		public ECharacterLookAt Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECharacterLookAt.Empty;
				}
				return (ECharacterLookAt)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C72A RID: 50986
		// (get) Token: 0x0602E6C9 RID: 190153 RVA: 0x00655C60 File Offset: 0x00653E60
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

		// Token: 0x0602E6CA RID: 190154 RVA: 0x00655C9C File Offset: 0x00653E9C
		public static Offset<ICharacterLookAtEntityData> CreateICharacterLookAtEntityData(FlatBufferBuilder builder, ECharacterLookAt Type = ECharacterLookAt.Empty, int EntityId = 0)
		{
			builder.StartTable(2);
			ICharacterLookAtEntityData.AddEntityId(builder, EntityId);
			ICharacterLookAtEntityData.AddType(builder, Type);
			return ICharacterLookAtEntityData.EndICharacterLookAtEntityData(builder);
		}

		// Token: 0x0602E6CB RID: 190155 RVA: 0x00655CB9 File Offset: 0x00653EB9
		public static void StartICharacterLookAtEntityData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E6CC RID: 190156 RVA: 0x00655CC2 File Offset: 0x00653EC2
		public static void AddType(FlatBufferBuilder builder, ECharacterLookAt type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E6CD RID: 190157 RVA: 0x00655CCD File Offset: 0x00653ECD
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0602E6CE RID: 190158 RVA: 0x00655CD8 File Offset: 0x00653ED8
		public static Offset<ICharacterLookAtEntityData> EndICharacterLookAtEntityData(FlatBufferBuilder builder)
		{
			return new Offset<ICharacterLookAtEntityData>(builder.EndTable());
		}

		// Token: 0x0602E6CF RID: 190159 RVA: 0x00655CE8 File Offset: 0x00653EE8
		public ICharacterLookAtEntityDataT UnPack()
		{
			ICharacterLookAtEntityDataT characterLookAtEntityDataT = new ICharacterLookAtEntityDataT();
			this.UnPackTo(characterLookAtEntityDataT);
			return characterLookAtEntityDataT;
		}

		// Token: 0x0602E6D0 RID: 190160 RVA: 0x00655D03 File Offset: 0x00653F03
		public void UnPackTo(ICharacterLookAtEntityDataT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x0602E6D1 RID: 190161 RVA: 0x00655D20 File Offset: 0x00653F20
		public static Offset<ICharacterLookAtEntityData> Pack(FlatBufferBuilder builder, ICharacterLookAtEntityDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICharacterLookAtEntityData>);
			}
			return ICharacterLookAtEntityData.CreateICharacterLookAtEntityData(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x04011727 RID: 71463
		private Table __p;
	}
}
