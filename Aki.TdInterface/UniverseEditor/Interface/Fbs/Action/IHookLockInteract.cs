using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006939 RID: 26937
	public struct IHookLockInteract : IFlatbufferObject
	{
		// Token: 0x1700C7DB RID: 51163
		// (get) Token: 0x0602F08A RID: 192650 RVA: 0x0066973E File Offset: 0x0066793E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F08B RID: 192651 RVA: 0x0066974B File Offset: 0x0066794B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F08C RID: 192652 RVA: 0x00669754 File Offset: 0x00667954
		public static IHookLockInteract GetRootAsIHookLockInteract(ByteBuffer _bb)
		{
			return IHookLockInteract.GetRootAsIHookLockInteract(_bb, default(IHookLockInteract));
		}

		// Token: 0x0602F08D RID: 192653 RVA: 0x00669770 File Offset: 0x00667970
		public static IHookLockInteract GetRootAsIHookLockInteract(ByteBuffer _bb, IHookLockInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F08E RID: 192654 RVA: 0x0066978D File Offset: 0x0066798D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F08F RID: 192655 RVA: 0x0066979C File Offset: 0x0066799C
		public IHookLockInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C7DC RID: 51164
		// (get) Token: 0x0602F090 RID: 192656 RVA: 0x006697AC File Offset: 0x006679AC
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

		// Token: 0x1700C7DD RID: 51165
		// (get) Token: 0x0602F091 RID: 192657 RVA: 0x006697E8 File Offset: 0x006679E8
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

		// Token: 0x0602F092 RID: 192658 RVA: 0x00669824 File Offset: 0x00667A24
		public static Offset<IHookLockInteract> CreateIHookLockInteract(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill, int EntityId = 0)
		{
			builder.StartTable(2);
			IHookLockInteract.AddEntityId(builder, EntityId);
			IHookLockInteract.AddType(builder, Type);
			return IHookLockInteract.EndIHookLockInteract(builder);
		}

		// Token: 0x0602F093 RID: 192659 RVA: 0x00669841 File Offset: 0x00667A41
		public static void StartIHookLockInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F094 RID: 192660 RVA: 0x0066984A File Offset: 0x00667A4A
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F095 RID: 192661 RVA: 0x00669855 File Offset: 0x00667A55
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0602F096 RID: 192662 RVA: 0x00669860 File Offset: 0x00667A60
		public static Offset<IHookLockInteract> EndIHookLockInteract(FlatBufferBuilder builder)
		{
			return new Offset<IHookLockInteract>(builder.EndTable());
		}

		// Token: 0x0602F097 RID: 192663 RVA: 0x00669870 File Offset: 0x00667A70
		public IHookLockInteractT UnPack()
		{
			IHookLockInteractT hookLockInteractT = new IHookLockInteractT();
			this.UnPackTo(hookLockInteractT);
			return hookLockInteractT;
		}

		// Token: 0x0602F098 RID: 192664 RVA: 0x0066988B File Offset: 0x00667A8B
		public void UnPackTo(IHookLockInteractT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x0602F099 RID: 192665 RVA: 0x006698A8 File Offset: 0x00667AA8
		public static Offset<IHookLockInteract> Pack(FlatBufferBuilder builder, IHookLockInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHookLockInteract>);
			}
			return IHookLockInteract.CreateIHookLockInteract(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x040110B7 RID: 69815
		private Table __p;
	}
}
