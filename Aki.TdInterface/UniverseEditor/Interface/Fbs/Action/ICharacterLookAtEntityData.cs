using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006346 RID: 25414
	public struct ICharacterLookAtEntityData : IFlatbufferObject
	{
		// Token: 0x1700BDA0 RID: 48544
		// (get) Token: 0x0602BF58 RID: 180056 RVA: 0x0060AA61 File Offset: 0x00608C61
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BF59 RID: 180057 RVA: 0x0060AA6E File Offset: 0x00608C6E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BF5A RID: 180058 RVA: 0x0060AA78 File Offset: 0x00608C78
		public static ICharacterLookAtEntityData GetRootAsICharacterLookAtEntityData(ByteBuffer _bb)
		{
			return ICharacterLookAtEntityData.GetRootAsICharacterLookAtEntityData(_bb, default(ICharacterLookAtEntityData));
		}

		// Token: 0x0602BF5B RID: 180059 RVA: 0x0060AA94 File Offset: 0x00608C94
		public static ICharacterLookAtEntityData GetRootAsICharacterLookAtEntityData(ByteBuffer _bb, ICharacterLookAtEntityData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BF5C RID: 180060 RVA: 0x0060AAB1 File Offset: 0x00608CB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BF5D RID: 180061 RVA: 0x0060AAC0 File Offset: 0x00608CC0
		public ICharacterLookAtEntityData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BDA1 RID: 48545
		// (get) Token: 0x0602BF5E RID: 180062 RVA: 0x0060AAD0 File Offset: 0x00608CD0
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

		// Token: 0x1700BDA2 RID: 48546
		// (get) Token: 0x0602BF5F RID: 180063 RVA: 0x0060AB0C File Offset: 0x00608D0C
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

		// Token: 0x0602BF60 RID: 180064 RVA: 0x0060AB48 File Offset: 0x00608D48
		public static Offset<ICharacterLookAtEntityData> CreateICharacterLookAtEntityData(FlatBufferBuilder builder, ECharacterLookAt Type = ECharacterLookAt.Empty, int EntityId = 0)
		{
			builder.StartTable(2);
			ICharacterLookAtEntityData.AddEntityId(builder, EntityId);
			ICharacterLookAtEntityData.AddType(builder, Type);
			return ICharacterLookAtEntityData.EndICharacterLookAtEntityData(builder);
		}

		// Token: 0x0602BF61 RID: 180065 RVA: 0x0060AB65 File Offset: 0x00608D65
		public static void StartICharacterLookAtEntityData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602BF62 RID: 180066 RVA: 0x0060AB6E File Offset: 0x00608D6E
		public static void AddType(FlatBufferBuilder builder, ECharacterLookAt type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BF63 RID: 180067 RVA: 0x0060AB79 File Offset: 0x00608D79
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0602BF64 RID: 180068 RVA: 0x0060AB84 File Offset: 0x00608D84
		public static Offset<ICharacterLookAtEntityData> EndICharacterLookAtEntityData(FlatBufferBuilder builder)
		{
			return new Offset<ICharacterLookAtEntityData>(builder.EndTable());
		}

		// Token: 0x0602BF65 RID: 180069 RVA: 0x0060AB94 File Offset: 0x00608D94
		public ICharacterLookAtEntityDataT UnPack()
		{
			ICharacterLookAtEntityDataT characterLookAtEntityDataT = new ICharacterLookAtEntityDataT();
			this.UnPackTo(characterLookAtEntityDataT);
			return characterLookAtEntityDataT;
		}

		// Token: 0x0602BF66 RID: 180070 RVA: 0x0060ABAF File Offset: 0x00608DAF
		public void UnPackTo(ICharacterLookAtEntityDataT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x0602BF67 RID: 180071 RVA: 0x0060ABCC File Offset: 0x00608DCC
		public static Offset<ICharacterLookAtEntityData> Pack(FlatBufferBuilder builder, ICharacterLookAtEntityDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICharacterLookAtEntityData>);
			}
			return ICharacterLookAtEntityData.CreateICharacterLookAtEntityData(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x04010912 RID: 67858
		private Table __p;
	}
}
