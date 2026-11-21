using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043DC RID: 17372
	public struct IPhotoTarget : IFlatbufferObject
	{
		// Token: 0x170077A6 RID: 30630
		// (get) Token: 0x06018AAF RID: 101039 RVA: 0x003846C4 File Offset: 0x003828C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018AB0 RID: 101040 RVA: 0x003846D1 File Offset: 0x003828D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018AB1 RID: 101041 RVA: 0x003846D8 File Offset: 0x003828D8
		public static IPhotoTarget GetRootAsIPhotoTarget(ByteBuffer _bb)
		{
			return IPhotoTarget.GetRootAsIPhotoTarget(_bb, default(IPhotoTarget));
		}

		// Token: 0x06018AB2 RID: 101042 RVA: 0x003846F4 File Offset: 0x003828F4
		public static IPhotoTarget GetRootAsIPhotoTarget(ByteBuffer _bb, IPhotoTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018AB3 RID: 101043 RVA: 0x00384711 File Offset: 0x00382911
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018AB4 RID: 101044 RVA: 0x00384720 File Offset: 0x00382920
		public IPhotoTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170077A7 RID: 30631
		// (get) Token: 0x06018AB5 RID: 101045 RVA: 0x00384730 File Offset: 0x00382930
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170077A8 RID: 30632
		// (get) Token: 0x06018AB6 RID: 101046 RVA: 0x0038476C File Offset: 0x0038296C
		public string TidDescription
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018AB7 RID: 101047 RVA: 0x003847A3 File Offset: 0x003829A3
		public Span<byte> GetTidDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06018AB8 RID: 101048 RVA: 0x003847B2 File Offset: 0x003829B2
		public byte[] GetTidDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x170077A9 RID: 30633
		// (get) Token: 0x06018AB9 RID: 101049 RVA: 0x003847C0 File Offset: 0x003829C0
		public bool IsOptionalTarget
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170077AA RID: 30634
		// (get) Token: 0x06018ABA RID: 101050 RVA: 0x00384800 File Offset: 0x00382A00
		public ISetVar? SetVar
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new ISetVar?(default(ISetVar).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170077AB RID: 30635
		// (get) Token: 0x06018ABB RID: 101051 RVA: 0x00384860 File Offset: 0x00382A60
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018ABC RID: 101052 RVA: 0x0038489D File Offset: 0x00382A9D
		public static Offset<IPhotoTarget> CreateIPhotoTarget(FlatBufferBuilder builder, int EntityId = 0, StringOffset TidDescriptionOffset = default(StringOffset), bool IsOptionalTarget = false, Offset<ISetVar> SetVarOffset = default(Offset<ISetVar>), byte NullMask = 0)
		{
			builder.StartTable(5);
			IPhotoTarget.AddSetVar(builder, SetVarOffset);
			IPhotoTarget.AddTidDescription(builder, TidDescriptionOffset);
			IPhotoTarget.AddEntityId(builder, EntityId);
			IPhotoTarget.AddNullMask(builder, NullMask);
			IPhotoTarget.AddIsOptionalTarget(builder, IsOptionalTarget);
			return IPhotoTarget.EndIPhotoTarget(builder);
		}

		// Token: 0x06018ABD RID: 101053 RVA: 0x003848D1 File Offset: 0x00382AD1
		public static void StartIPhotoTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06018ABE RID: 101054 RVA: 0x003848DA File Offset: 0x00382ADA
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06018ABF RID: 101055 RVA: 0x003848E5 File Offset: 0x00382AE5
		public static void AddTidDescription(FlatBufferBuilder builder, StringOffset tidDescriptionOffset)
		{
			builder.AddOffset(1, tidDescriptionOffset.Value, 0);
		}

		// Token: 0x06018AC0 RID: 101056 RVA: 0x003848F5 File Offset: 0x00382AF5
		public static void AddIsOptionalTarget(FlatBufferBuilder builder, bool isOptionalTarget)
		{
			builder.AddBool(2, isOptionalTarget, false);
		}

		// Token: 0x06018AC1 RID: 101057 RVA: 0x00384900 File Offset: 0x00382B00
		public static void AddSetVar(FlatBufferBuilder builder, Offset<ISetVar> setVarOffset)
		{
			builder.AddOffset(3, setVarOffset.Value, 0);
		}

		// Token: 0x06018AC2 RID: 101058 RVA: 0x00384910 File Offset: 0x00382B10
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06018AC3 RID: 101059 RVA: 0x0038491B File Offset: 0x00382B1B
		public static Offset<IPhotoTarget> EndIPhotoTarget(FlatBufferBuilder builder)
		{
			return new Offset<IPhotoTarget>(builder.EndTable());
		}

		// Token: 0x06018AC4 RID: 101060 RVA: 0x00384928 File Offset: 0x00382B28
		public IPhotoTargetT UnPack()
		{
			IPhotoTargetT photoTargetT = new IPhotoTargetT();
			this.UnPackTo(photoTargetT);
			return photoTargetT;
		}

		// Token: 0x06018AC5 RID: 101061 RVA: 0x00384944 File Offset: 0x00382B44
		public void UnPackTo(IPhotoTargetT _o)
		{
			_o.EntityId = this.EntityId;
			_o.TidDescription = this.TidDescription;
			_o.IsOptionalTarget = this.IsOptionalTarget;
			_o.SetVar = ((this.SetVar != null) ? this.SetVar.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06018AC6 RID: 101062 RVA: 0x003849B0 File Offset: 0x00382BB0
		public static Offset<IPhotoTarget> Pack(FlatBufferBuilder builder, IPhotoTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhotoTarget>);
			}
			StringOffset tidDescriptionOffset = (_o.TidDescription == null) ? default(StringOffset) : builder.CreateString(_o.TidDescription);
			Offset<ISetVar> setVarOffset = (_o.SetVar == null) ? default(Offset<ISetVar>) : ISetVar.Pack(builder, _o.SetVar);
			return IPhotoTarget.CreateIPhotoTarget(builder, _o.EntityId, tidDescriptionOffset, _o.IsOptionalTarget, setVarOffset, _o.NullMask);
		}

		// Token: 0x0400C3E3 RID: 50147
		private Table __p;
	}
}
