using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FEC RID: 28652
	public struct IHookLockInteract : IFlatbufferObject
	{
		// Token: 0x1700D1DE RID: 53726
		// (get) Token: 0x06031A5A RID: 203354 RVA: 0x006B9C26 File Offset: 0x006B7E26
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031A5B RID: 203355 RVA: 0x006B9C33 File Offset: 0x006B7E33
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031A5C RID: 203356 RVA: 0x006B9C3C File Offset: 0x006B7E3C
		public static IHookLockInteract GetRootAsIHookLockInteract(ByteBuffer _bb)
		{
			return IHookLockInteract.GetRootAsIHookLockInteract(_bb, default(IHookLockInteract));
		}

		// Token: 0x06031A5D RID: 203357 RVA: 0x006B9C58 File Offset: 0x006B7E58
		public static IHookLockInteract GetRootAsIHookLockInteract(ByteBuffer _bb, IHookLockInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031A5E RID: 203358 RVA: 0x006B9C75 File Offset: 0x006B7E75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031A5F RID: 203359 RVA: 0x006B9C84 File Offset: 0x006B7E84
		public IHookLockInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D1DF RID: 53727
		// (get) Token: 0x06031A60 RID: 203360 RVA: 0x006B9C94 File Offset: 0x006B7E94
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

		// Token: 0x1700D1E0 RID: 53728
		// (get) Token: 0x06031A61 RID: 203361 RVA: 0x006B9CD0 File Offset: 0x006B7ED0
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

		// Token: 0x06031A62 RID: 203362 RVA: 0x006B9D0C File Offset: 0x006B7F0C
		public static Offset<IHookLockInteract> CreateIHookLockInteract(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill, int EntityId = 0)
		{
			builder.StartTable(2);
			IHookLockInteract.AddEntityId(builder, EntityId);
			IHookLockInteract.AddType(builder, Type);
			return IHookLockInteract.EndIHookLockInteract(builder);
		}

		// Token: 0x06031A63 RID: 203363 RVA: 0x006B9D29 File Offset: 0x006B7F29
		public static void StartIHookLockInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031A64 RID: 203364 RVA: 0x006B9D32 File Offset: 0x006B7F32
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031A65 RID: 203365 RVA: 0x006B9D3D File Offset: 0x006B7F3D
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x06031A66 RID: 203366 RVA: 0x006B9D48 File Offset: 0x006B7F48
		public static Offset<IHookLockInteract> EndIHookLockInteract(FlatBufferBuilder builder)
		{
			return new Offset<IHookLockInteract>(builder.EndTable());
		}

		// Token: 0x06031A67 RID: 203367 RVA: 0x006B9D58 File Offset: 0x006B7F58
		public IHookLockInteractT UnPack()
		{
			IHookLockInteractT hookLockInteractT = new IHookLockInteractT();
			this.UnPackTo(hookLockInteractT);
			return hookLockInteractT;
		}

		// Token: 0x06031A68 RID: 203368 RVA: 0x006B9D73 File Offset: 0x006B7F73
		public void UnPackTo(IHookLockInteractT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x06031A69 RID: 203369 RVA: 0x006B9D90 File Offset: 0x006B7F90
		public static Offset<IHookLockInteract> Pack(FlatBufferBuilder builder, IHookLockInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHookLockInteract>);
			}
			return IHookLockInteract.CreateIHookLockInteract(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x04011F23 RID: 73507
		private Table __p;
	}
}
