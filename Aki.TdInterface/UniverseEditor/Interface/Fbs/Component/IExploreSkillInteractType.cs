using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051EC RID: 20972
	public struct IExploreSkillInteractType : IFlatbufferObject
	{
		// Token: 0x170099A1 RID: 39329
		// (get) Token: 0x060220E6 RID: 139494 RVA: 0x004BA2AF File Offset: 0x004B84AF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060220E7 RID: 139495 RVA: 0x004BA2BC File Offset: 0x004B84BC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060220E8 RID: 139496 RVA: 0x004BA2C4 File Offset: 0x004B84C4
		public static IExploreSkillInteractType GetRootAsIExploreSkillInteractType(ByteBuffer _bb)
		{
			return IExploreSkillInteractType.GetRootAsIExploreSkillInteractType(_bb, default(IExploreSkillInteractType));
		}

		// Token: 0x060220E9 RID: 139497 RVA: 0x004BA2E0 File Offset: 0x004B84E0
		public static IExploreSkillInteractType GetRootAsIExploreSkillInteractType(ByteBuffer _bb, IExploreSkillInteractType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060220EA RID: 139498 RVA: 0x004BA2FD File Offset: 0x004B84FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060220EB RID: 139499 RVA: 0x004BA30C File Offset: 0x004B850C
		public IExploreSkillInteractType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170099A2 RID: 39330
		// (get) Token: 0x060220EC RID: 139500 RVA: 0x004BA31C File Offset: 0x004B851C
		public EExploreSkillInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExploreSkillInteractType.PullGiant;
				}
				return (EExploreSkillInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060220ED RID: 139501 RVA: 0x004BA358 File Offset: 0x004B8558
		public static Offset<IExploreSkillInteractType> CreateIExploreSkillInteractType(FlatBufferBuilder builder, EExploreSkillInteractType Type = EExploreSkillInteractType.PullGiant)
		{
			builder.StartTable(1);
			IExploreSkillInteractType.AddType(builder, Type);
			return IExploreSkillInteractType.EndIExploreSkillInteractType(builder);
		}

		// Token: 0x060220EE RID: 139502 RVA: 0x004BA36E File Offset: 0x004B856E
		public static void StartIExploreSkillInteractType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060220EF RID: 139503 RVA: 0x004BA377 File Offset: 0x004B8577
		public static void AddType(FlatBufferBuilder builder, EExploreSkillInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060220F0 RID: 139504 RVA: 0x004BA382 File Offset: 0x004B8582
		public static Offset<IExploreSkillInteractType> EndIExploreSkillInteractType(FlatBufferBuilder builder)
		{
			return new Offset<IExploreSkillInteractType>(builder.EndTable());
		}

		// Token: 0x060220F1 RID: 139505 RVA: 0x004BA390 File Offset: 0x004B8590
		public IExploreSkillInteractTypeT UnPack()
		{
			IExploreSkillInteractTypeT exploreSkillInteractTypeT = new IExploreSkillInteractTypeT();
			this.UnPackTo(exploreSkillInteractTypeT);
			return exploreSkillInteractTypeT;
		}

		// Token: 0x060220F2 RID: 139506 RVA: 0x004BA3AB File Offset: 0x004B85AB
		public void UnPackTo(IExploreSkillInteractTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060220F3 RID: 139507 RVA: 0x004BA3BC File Offset: 0x004B85BC
		public static Offset<IExploreSkillInteractType> Pack(FlatBufferBuilder builder, IExploreSkillInteractTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExploreSkillInteractType>);
			}
			return IExploreSkillInteractType.CreateIExploreSkillInteractType(builder, _o.Type);
		}

		// Token: 0x0400E30A RID: 58122
		private Table __p;
	}
}
