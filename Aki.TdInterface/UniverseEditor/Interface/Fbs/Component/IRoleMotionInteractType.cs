using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200587C RID: 22652
	public struct IRoleMotionInteractType : IFlatbufferObject
	{
		// Token: 0x1700A96D RID: 43373
		// (get) Token: 0x060262B2 RID: 156338 RVA: 0x005432BF File Offset: 0x005414BF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060262B3 RID: 156339 RVA: 0x005432CC File Offset: 0x005414CC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060262B4 RID: 156340 RVA: 0x005432D4 File Offset: 0x005414D4
		public static IRoleMotionInteractType GetRootAsIRoleMotionInteractType(ByteBuffer _bb)
		{
			return IRoleMotionInteractType.GetRootAsIRoleMotionInteractType(_bb, default(IRoleMotionInteractType));
		}

		// Token: 0x060262B5 RID: 156341 RVA: 0x005432F0 File Offset: 0x005414F0
		public static IRoleMotionInteractType GetRootAsIRoleMotionInteractType(ByteBuffer _bb, IRoleMotionInteractType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060262B6 RID: 156342 RVA: 0x0054330D File Offset: 0x0054150D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060262B7 RID: 156343 RVA: 0x0054331C File Offset: 0x0054151C
		public IRoleMotionInteractType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A96E RID: 43374
		// (get) Token: 0x060262B8 RID: 156344 RVA: 0x0054332C File Offset: 0x0054152C
		public ERoleMotionInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERoleMotionInteractType.PetalGrab;
				}
				return (ERoleMotionInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060262B9 RID: 156345 RVA: 0x00543368 File Offset: 0x00541568
		public static Offset<IRoleMotionInteractType> CreateIRoleMotionInteractType(FlatBufferBuilder builder, ERoleMotionInteractType Type = ERoleMotionInteractType.PetalGrab)
		{
			builder.StartTable(1);
			IRoleMotionInteractType.AddType(builder, Type);
			return IRoleMotionInteractType.EndIRoleMotionInteractType(builder);
		}

		// Token: 0x060262BA RID: 156346 RVA: 0x0054337E File Offset: 0x0054157E
		public static void StartIRoleMotionInteractType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060262BB RID: 156347 RVA: 0x00543387 File Offset: 0x00541587
		public static void AddType(FlatBufferBuilder builder, ERoleMotionInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060262BC RID: 156348 RVA: 0x00543392 File Offset: 0x00541592
		public static Offset<IRoleMotionInteractType> EndIRoleMotionInteractType(FlatBufferBuilder builder)
		{
			return new Offset<IRoleMotionInteractType>(builder.EndTable());
		}

		// Token: 0x060262BD RID: 156349 RVA: 0x005433A0 File Offset: 0x005415A0
		public IRoleMotionInteractTypeT UnPack()
		{
			IRoleMotionInteractTypeT roleMotionInteractTypeT = new IRoleMotionInteractTypeT();
			this.UnPackTo(roleMotionInteractTypeT);
			return roleMotionInteractTypeT;
		}

		// Token: 0x060262BE RID: 156350 RVA: 0x005433BB File Offset: 0x005415BB
		public void UnPackTo(IRoleMotionInteractTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060262BF RID: 156351 RVA: 0x005433CC File Offset: 0x005415CC
		public static Offset<IRoleMotionInteractType> Pack(FlatBufferBuilder builder, IRoleMotionInteractTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoleMotionInteractType>);
			}
			return IRoleMotionInteractType.CreateIRoleMotionInteractType(builder, _o.Type);
		}

		// Token: 0x0400EDC5 RID: 60869
		private Table __p;
	}
}
