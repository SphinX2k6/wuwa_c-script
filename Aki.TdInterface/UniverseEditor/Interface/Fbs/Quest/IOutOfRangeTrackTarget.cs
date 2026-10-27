using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F6B RID: 16235
	public struct IOutOfRangeTrackTarget : IFlatbufferObject
	{
		// Token: 0x170070E6 RID: 28902
		// (get) Token: 0x0601718A RID: 94602 RVA: 0x0035413B File Offset: 0x0035233B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601718B RID: 94603 RVA: 0x00354148 File Offset: 0x00352348
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601718C RID: 94604 RVA: 0x00354150 File Offset: 0x00352350
		public static IOutOfRangeTrackTarget GetRootAsIOutOfRangeTrackTarget(ByteBuffer _bb)
		{
			return IOutOfRangeTrackTarget.GetRootAsIOutOfRangeTrackTarget(_bb, default(IOutOfRangeTrackTarget));
		}

		// Token: 0x0601718D RID: 94605 RVA: 0x0035416C File Offset: 0x0035236C
		public static IOutOfRangeTrackTarget GetRootAsIOutOfRangeTrackTarget(ByteBuffer _bb, IOutOfRangeTrackTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601718E RID: 94606 RVA: 0x00354189 File Offset: 0x00352389
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601718F RID: 94607 RVA: 0x00354198 File Offset: 0x00352398
		public IOutOfRangeTrackTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170070E7 RID: 28903
		// (get) Token: 0x06017190 RID: 94608 RVA: 0x003541A8 File Offset: 0x003523A8
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

		// Token: 0x170070E8 RID: 28904
		// (get) Token: 0x06017191 RID: 94609 RVA: 0x00354208 File Offset: 0x00352408
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

		// Token: 0x170070E9 RID: 28905
		// (get) Token: 0x06017192 RID: 94610 RVA: 0x00354268 File Offset: 0x00352468
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

		// Token: 0x170070EA RID: 28906
		// (get) Token: 0x06017193 RID: 94611 RVA: 0x003542A4 File Offset: 0x003524A4
		public bool OverrideChildNodeTrackTarget
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170070EB RID: 28907
		// (get) Token: 0x06017194 RID: 94612 RVA: 0x003542E4 File Offset: 0x003524E4
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

		// Token: 0x06017195 RID: 94613 RVA: 0x00354321 File Offset: 0x00352521
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

		// Token: 0x06017196 RID: 94614 RVA: 0x00354355 File Offset: 0x00352555
		public static void StartIOutOfRangeTrackTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06017197 RID: 94615 RVA: 0x0035435E File Offset: 0x0035255E
		public static void AddTrackPos(FlatBufferBuilder builder, Offset<IVectorInfo> trackPosOffset)
		{
			builder.AddOffset(0, trackPosOffset.Value, 0);
		}

		// Token: 0x06017198 RID: 94616 RVA: 0x0035436E File Offset: 0x0035256E
		public static void AddCenter(FlatBufferBuilder builder, Offset<IVectorInfo> centerOffset)
		{
			builder.AddOffset(1, centerOffset.Value, 0);
		}

		// Token: 0x06017199 RID: 94617 RVA: 0x0035437E File Offset: 0x0035257E
		public static void AddRadius(FlatBufferBuilder builder, int radius)
		{
			builder.AddInt(2, radius, 0);
		}

		// Token: 0x0601719A RID: 94618 RVA: 0x00354389 File Offset: 0x00352589
		public static void AddOverrideChildNodeTrackTarget(FlatBufferBuilder builder, bool overrideChildNodeTrackTarget)
		{
			builder.AddBool(3, overrideChildNodeTrackTarget, false);
		}

		// Token: 0x0601719B RID: 94619 RVA: 0x00354394 File Offset: 0x00352594
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601719C RID: 94620 RVA: 0x0035439F File Offset: 0x0035259F
		public static Offset<IOutOfRangeTrackTarget> EndIOutOfRangeTrackTarget(FlatBufferBuilder builder)
		{
			return new Offset<IOutOfRangeTrackTarget>(builder.EndTable());
		}

		// Token: 0x0601719D RID: 94621 RVA: 0x003543AC File Offset: 0x003525AC
		public IOutOfRangeTrackTargetT UnPack()
		{
			IOutOfRangeTrackTargetT outOfRangeTrackTargetT = new IOutOfRangeTrackTargetT();
			this.UnPackTo(outOfRangeTrackTargetT);
			return outOfRangeTrackTargetT;
		}

		// Token: 0x0601719E RID: 94622 RVA: 0x003543C8 File Offset: 0x003525C8
		public void UnPackTo(IOutOfRangeTrackTargetT _o)
		{
			_o.TrackPos = ((this.TrackPos != null) ? this.TrackPos.Value.UnPack() : null);
			_o.Center = ((this.Center != null) ? this.Center.Value.UnPack() : null);
			_o.Radius = this.Radius;
			_o.OverrideChildNodeTrackTarget = this.OverrideChildNodeTrackTarget;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601719F RID: 94623 RVA: 0x00354458 File Offset: 0x00352658
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

		// Token: 0x0400B987 RID: 47495
		private Table __p;
	}
}
