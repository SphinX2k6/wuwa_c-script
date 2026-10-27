using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F9B RID: 16283
	public struct IPhotoTarget : IFlatbufferObject
	{
		// Token: 0x170071A8 RID: 29096
		// (get) Token: 0x06017420 RID: 95264 RVA: 0x0035AAAC File Offset: 0x00358CAC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017421 RID: 95265 RVA: 0x0035AAB9 File Offset: 0x00358CB9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017422 RID: 95266 RVA: 0x0035AAC0 File Offset: 0x00358CC0
		public static IPhotoTarget GetRootAsIPhotoTarget(ByteBuffer _bb)
		{
			return IPhotoTarget.GetRootAsIPhotoTarget(_bb, default(IPhotoTarget));
		}

		// Token: 0x06017423 RID: 95267 RVA: 0x0035AADC File Offset: 0x00358CDC
		public static IPhotoTarget GetRootAsIPhotoTarget(ByteBuffer _bb, IPhotoTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017424 RID: 95268 RVA: 0x0035AAF9 File Offset: 0x00358CF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017425 RID: 95269 RVA: 0x0035AB08 File Offset: 0x00358D08
		public IPhotoTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170071A9 RID: 29097
		// (get) Token: 0x06017426 RID: 95270 RVA: 0x0035AB18 File Offset: 0x00358D18
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

		// Token: 0x170071AA RID: 29098
		// (get) Token: 0x06017427 RID: 95271 RVA: 0x0035AB54 File Offset: 0x00358D54
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

		// Token: 0x06017428 RID: 95272 RVA: 0x0035AB8B File Offset: 0x00358D8B
		public Span<byte> GetTidDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06017429 RID: 95273 RVA: 0x0035AB9A File Offset: 0x00358D9A
		public byte[] GetTidDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x170071AB RID: 29099
		// (get) Token: 0x0601742A RID: 95274 RVA: 0x0035ABA8 File Offset: 0x00358DA8
		public bool IsOptionalTarget
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170071AC RID: 29100
		// (get) Token: 0x0601742B RID: 95275 RVA: 0x0035ABE8 File Offset: 0x00358DE8
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

		// Token: 0x170071AD RID: 29101
		// (get) Token: 0x0601742C RID: 95276 RVA: 0x0035AC48 File Offset: 0x00358E48
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

		// Token: 0x0601742D RID: 95277 RVA: 0x0035AC85 File Offset: 0x00358E85
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

		// Token: 0x0601742E RID: 95278 RVA: 0x0035ACB9 File Offset: 0x00358EB9
		public static void StartIPhotoTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601742F RID: 95279 RVA: 0x0035ACC2 File Offset: 0x00358EC2
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06017430 RID: 95280 RVA: 0x0035ACCD File Offset: 0x00358ECD
		public static void AddTidDescription(FlatBufferBuilder builder, StringOffset tidDescriptionOffset)
		{
			builder.AddOffset(1, tidDescriptionOffset.Value, 0);
		}

		// Token: 0x06017431 RID: 95281 RVA: 0x0035ACDD File Offset: 0x00358EDD
		public static void AddIsOptionalTarget(FlatBufferBuilder builder, bool isOptionalTarget)
		{
			builder.AddBool(2, isOptionalTarget, false);
		}

		// Token: 0x06017432 RID: 95282 RVA: 0x0035ACE8 File Offset: 0x00358EE8
		public static void AddSetVar(FlatBufferBuilder builder, Offset<ISetVar> setVarOffset)
		{
			builder.AddOffset(3, setVarOffset.Value, 0);
		}

		// Token: 0x06017433 RID: 95283 RVA: 0x0035ACF8 File Offset: 0x00358EF8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06017434 RID: 95284 RVA: 0x0035AD03 File Offset: 0x00358F03
		public static Offset<IPhotoTarget> EndIPhotoTarget(FlatBufferBuilder builder)
		{
			return new Offset<IPhotoTarget>(builder.EndTable());
		}

		// Token: 0x06017435 RID: 95285 RVA: 0x0035AD10 File Offset: 0x00358F10
		public IPhotoTargetT UnPack()
		{
			IPhotoTargetT photoTargetT = new IPhotoTargetT();
			this.UnPackTo(photoTargetT);
			return photoTargetT;
		}

		// Token: 0x06017436 RID: 95286 RVA: 0x0035AD2C File Offset: 0x00358F2C
		public void UnPackTo(IPhotoTargetT _o)
		{
			_o.EntityId = this.EntityId;
			_o.TidDescription = this.TidDescription;
			_o.IsOptionalTarget = this.IsOptionalTarget;
			_o.SetVar = ((this.SetVar != null) ? this.SetVar.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06017437 RID: 95287 RVA: 0x0035AD98 File Offset: 0x00358F98
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

		// Token: 0x0400B9FE RID: 47614
		private Table __p;
	}
}
