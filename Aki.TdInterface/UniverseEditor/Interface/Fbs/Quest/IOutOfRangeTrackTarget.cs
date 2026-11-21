using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043A9 RID: 17321
	public struct IOutOfRangeTrackTarget : IFlatbufferObject
	{
		// Token: 0x170076D7 RID: 30423
		// (get) Token: 0x060187EC RID: 100332 RVA: 0x0037D5AF File Offset: 0x0037B7AF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060187ED RID: 100333 RVA: 0x0037D5BC File Offset: 0x0037B7BC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060187EE RID: 100334 RVA: 0x0037D5C4 File Offset: 0x0037B7C4
		public static IOutOfRangeTrackTarget GetRootAsIOutOfRangeTrackTarget(ByteBuffer _bb)
		{
			return IOutOfRangeTrackTarget.GetRootAsIOutOfRangeTrackTarget(_bb, default(IOutOfRangeTrackTarget));
		}

		// Token: 0x060187EF RID: 100335 RVA: 0x0037D5E0 File Offset: 0x0037B7E0
		public static IOutOfRangeTrackTarget GetRootAsIOutOfRangeTrackTarget(ByteBuffer _bb, IOutOfRangeTrackTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060187F0 RID: 100336 RVA: 0x0037D5FD File Offset: 0x0037B7FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060187F1 RID: 100337 RVA: 0x0037D60C File Offset: 0x0037B80C
		public IOutOfRangeTrackTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170076D8 RID: 30424
		// (get) Token: 0x060187F2 RID: 100338 RVA: 0x0037D61C File Offset: 0x0037B81C
		public IVectorInfo? TrackPos
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170076D9 RID: 30425
		// (get) Token: 0x060187F3 RID: 100339 RVA: 0x0037D67C File Offset: 0x0037B87C
		public IVectorInfo? Center
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

		// Token: 0x170076DA RID: 30426
		// (get) Token: 0x060187F4 RID: 100340 RVA: 0x0037D6DC File Offset: 0x0037B8DC
		public int Radius
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170076DB RID: 30427
		// (get) Token: 0x060187F5 RID: 100341 RVA: 0x0037D718 File Offset: 0x0037B918
		public bool OverrideChildNodeTrackTarget
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170076DC RID: 30428
		// (get) Token: 0x060187F6 RID: 100342 RVA: 0x0037D758 File Offset: 0x0037B958
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

		// Token: 0x060187F7 RID: 100343 RVA: 0x0037D795 File Offset: 0x0037B995
		public static Offset<IOutOfRangeTrackTarget> CreateIOutOfRangeTrackTarget(FlatBufferBuilder builder, Offset<IVectorInfo> TrackPosOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> CenterOffset = default(Offset<IVectorInfo>), int Radius = 0, bool OverrideChildNodeTrackTarget = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			IOutOfRangeTrackTarget.AddRadius(builder, Radius);
			IOutOfRangeTrackTarget.AddCenter(builder, CenterOffset);
			IOutOfRangeTrackTarget.AddTrackPos(builder, TrackPosOffset);
			IOutOfRangeTrackTarget.AddNullMask(builder, NullMask);
			IOutOfRangeTrackTarget.AddOverrideChildNodeTrackTarget(builder, OverrideChildNodeTrackTarget);
			return IOutOfRangeTrackTarget.EndIOutOfRangeTrackTarget(builder);
		}

		// Token: 0x060187F8 RID: 100344 RVA: 0x0037D7C9 File Offset: 0x0037B9C9
		public static void StartIOutOfRangeTrackTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060187F9 RID: 100345 RVA: 0x0037D7D2 File Offset: 0x0037B9D2
		public static void AddTrackPos(FlatBufferBuilder builder, Offset<IVectorInfo> trackPosOffset)
		{
			builder.AddOffset(0, trackPosOffset.Value, 0);
		}

		// Token: 0x060187FA RID: 100346 RVA: 0x0037D7E2 File Offset: 0x0037B9E2
		public static void AddCenter(FlatBufferBuilder builder, Offset<IVectorInfo> centerOffset)
		{
			builder.AddOffset(1, centerOffset.Value, 0);
		}

		// Token: 0x060187FB RID: 100347 RVA: 0x0037D7F2 File Offset: 0x0037B9F2
		public static void AddRadius(FlatBufferBuilder builder, int radius)
		{
			builder.AddInt(2, radius, 0);
		}

		// Token: 0x060187FC RID: 100348 RVA: 0x0037D7FD File Offset: 0x0037B9FD
		public static void AddOverrideChildNodeTrackTarget(FlatBufferBuilder builder, bool overrideChildNodeTrackTarget)
		{
			builder.AddBool(3, overrideChildNodeTrackTarget, false);
		}

		// Token: 0x060187FD RID: 100349 RVA: 0x0037D808 File Offset: 0x0037BA08
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060187FE RID: 100350 RVA: 0x0037D813 File Offset: 0x0037BA13
		public static Offset<IOutOfRangeTrackTarget> EndIOutOfRangeTrackTarget(FlatBufferBuilder builder)
		{
			return new Offset<IOutOfRangeTrackTarget>(builder.EndTable());
		}

		// Token: 0x060187FF RID: 100351 RVA: 0x0037D820 File Offset: 0x0037BA20
		public IOutOfRangeTrackTargetT UnPack()
		{
			IOutOfRangeTrackTargetT outOfRangeTrackTargetT = new IOutOfRangeTrackTargetT();
			this.UnPackTo(outOfRangeTrackTargetT);
			return outOfRangeTrackTargetT;
		}

		// Token: 0x06018800 RID: 100352 RVA: 0x0037D83C File Offset: 0x0037BA3C
		public void UnPackTo(IOutOfRangeTrackTargetT _o)
		{
			_o.TrackPos = ((this.TrackPos != null) ? this.TrackPos.Value.UnPack() : null);
			_o.Center = ((this.Center != null) ? this.Center.Value.UnPack() : null);
			_o.Radius = this.Radius;
			_o.OverrideChildNodeTrackTarget = this.OverrideChildNodeTrackTarget;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06018801 RID: 100353 RVA: 0x0037D8CC File Offset: 0x0037BACC
		public static Offset<IOutOfRangeTrackTarget> Pack(FlatBufferBuilder builder, IOutOfRangeTrackTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOutOfRangeTrackTarget>);
			}
			Offset<IVectorInfo> trackPosOffset = (_o.TrackPos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.TrackPos);
			Offset<IVectorInfo> centerOffset = (_o.Center == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Center);
			return IOutOfRangeTrackTarget.CreateIOutOfRangeTrackTarget(builder, trackPosOffset, centerOffset, _o.Radius, _o.OverrideChildNodeTrackTarget, _o.NullMask);
		}

		// Token: 0x0400C365 RID: 50021
		private Table __p;
	}
}
