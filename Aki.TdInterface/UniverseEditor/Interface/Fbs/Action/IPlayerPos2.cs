using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D0B RID: 27915
	public struct IPlayerPos2 : IFlatbufferObject
	{
		// Token: 0x1700CFDF RID: 53215
		// (get) Token: 0x06031396 RID: 201622 RVA: 0x006AD59D File Offset: 0x006AB79D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031397 RID: 201623 RVA: 0x006AD5AA File Offset: 0x006AB7AA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031398 RID: 201624 RVA: 0x006AD5B4 File Offset: 0x006AB7B4
		public static IPlayerPos2 GetRootAsIPlayerPos2(ByteBuffer _bb)
		{
			return IPlayerPos2.GetRootAsIPlayerPos2(_bb, default(IPlayerPos2));
		}

		// Token: 0x06031399 RID: 201625 RVA: 0x006AD5D0 File Offset: 0x006AB7D0
		public static IPlayerPos2 GetRootAsIPlayerPos2(ByteBuffer _bb, IPlayerPos2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603139A RID: 201626 RVA: 0x006AD5ED File Offset: 0x006AB7ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603139B RID: 201627 RVA: 0x006AD5FC File Offset: 0x006AB7FC
		public IPlayerPos2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CFE0 RID: 53216
		// (get) Token: 0x0603139C RID: 201628 RVA: 0x006AD60C File Offset: 0x006AB80C
		public EPos2 Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPos2.Player;
				}
				return (EPos2)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CFE1 RID: 53217
		// (get) Token: 0x0603139D RID: 201629 RVA: 0x006AD648 File Offset: 0x006AB848
		public IVectorInfo? Offset
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0603139E RID: 201630 RVA: 0x006AD6A5 File Offset: 0x006AB8A5
		public static Offset<IPlayerPos2> CreateIPlayerPos2(FlatBufferBuilder builder, EPos2 Type = EPos2.Player, Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IPlayerPos2.AddOffset(builder, OffsetOffset);
			IPlayerPos2.AddType(builder, Type);
			return IPlayerPos2.EndIPlayerPos2(builder);
		}

		// Token: 0x0603139F RID: 201631 RVA: 0x006AD6C2 File Offset: 0x006AB8C2
		public static void StartIPlayerPos2(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060313A0 RID: 201632 RVA: 0x006AD6CB File Offset: 0x006AB8CB
		public static void AddType(FlatBufferBuilder builder, EPos2 type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060313A1 RID: 201633 RVA: 0x006AD6D6 File Offset: 0x006AB8D6
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(1, offsetOffset.Value, 0);
		}

		// Token: 0x060313A2 RID: 201634 RVA: 0x006AD6E6 File Offset: 0x006AB8E6
		public static Offset<IPlayerPos2> EndIPlayerPos2(FlatBufferBuilder builder)
		{
			return new Offset<IPlayerPos2>(builder.EndTable());
		}

		// Token: 0x060313A3 RID: 201635 RVA: 0x006AD6F4 File Offset: 0x006AB8F4
		public IPlayerPos2T UnPack()
		{
			IPlayerPos2T playerPos2T = new IPlayerPos2T();
			this.UnPackTo(playerPos2T);
			return playerPos2T;
		}

		// Token: 0x060313A4 RID: 201636 RVA: 0x006AD710 File Offset: 0x006AB910
		public void UnPackTo(IPlayerPos2T _o)
		{
			_o.Type = this.Type;
			_o.Offset = ((this.Offset != null) ? this.Offset.Value.UnPack() : null);
		}

		// Token: 0x060313A5 RID: 201637 RVA: 0x006AD758 File Offset: 0x006AB958
		public static Offset<IPlayerPos2> Pack(FlatBufferBuilder builder, IPlayerPos2T _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayerPos2>);
			}
			Offset<IVectorInfo> offsetOffset = (_o.Offset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Offset);
			return IPlayerPos2.CreateIPlayerPos2(builder, _o.Type, offsetOffset);
		}

		// Token: 0x04011687 RID: 71303
		private Table __p;
	}
}
