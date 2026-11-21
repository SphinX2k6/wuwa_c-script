using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200465E RID: 18014
	public struct ITrackLevelPlay : IFlatbufferObject
	{
		// Token: 0x17007E25 RID: 32293
		// (get) Token: 0x0601A686 RID: 108166 RVA: 0x003C24ED File Offset: 0x003C06ED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A687 RID: 108167 RVA: 0x003C24FA File Offset: 0x003C06FA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A688 RID: 108168 RVA: 0x003C2504 File Offset: 0x003C0704
		public static ITrackLevelPlay GetRootAsITrackLevelPlay(ByteBuffer _bb)
		{
			return ITrackLevelPlay.GetRootAsITrackLevelPlay(_bb, default(ITrackLevelPlay));
		}

		// Token: 0x0601A689 RID: 108169 RVA: 0x003C2520 File Offset: 0x003C0720
		public static ITrackLevelPlay GetRootAsITrackLevelPlay(ByteBuffer _bb, ITrackLevelPlay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A68A RID: 108170 RVA: 0x003C253D File Offset: 0x003C073D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A68B RID: 108171 RVA: 0x003C254C File Offset: 0x003C074C
		public ITrackLevelPlay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007E26 RID: 32294
		// (get) Token: 0x0601A68C RID: 108172 RVA: 0x003C255C File Offset: 0x003C075C
		public ETrackType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETrackType.Locations;
				}
				return (ETrackType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007E27 RID: 32295
		// (get) Token: 0x0601A68D RID: 108173 RVA: 0x003C2598 File Offset: 0x003C0798
		public TGravityDirection GravityDirectionType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TGravityDirection.NONE;
				}
				return (TGravityDirection)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A68E RID: 108174 RVA: 0x003C25D4 File Offset: 0x003C07D4
		public TTable? GravityDirection<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601A68F RID: 108175 RVA: 0x003C2618 File Offset: 0x003C0818
		public IGravityDirectionByEntityGravity GravityDirectionAsIGravityDirectionByEntityGravity()
		{
			return this.GravityDirection<IGravityDirectionByEntityGravity>().Value;
		}

		// Token: 0x0601A690 RID: 108176 RVA: 0x003C2634 File Offset: 0x003C0834
		public IGravityDirectionSelfRotation GravityDirectionAsIGravityDirectionSelfRotation()
		{
			return this.GravityDirection<IGravityDirectionSelfRotation>().Value;
		}

		// Token: 0x0601A691 RID: 108177 RVA: 0x003C2650 File Offset: 0x003C0850
		public IGravityDirectionVectorInfo GravityDirectionAsIGravityDirectionVectorInfo()
		{
			return this.GravityDirection<IGravityDirectionVectorInfo>().Value;
		}

		// Token: 0x0601A692 RID: 108178 RVA: 0x003C266C File Offset: 0x003C086C
		public IGravityDirectionWorldAxis GravityDirectionAsIGravityDirectionWorldAxis()
		{
			return this.GravityDirection<IGravityDirectionWorldAxis>().Value;
		}

		// Token: 0x17007E28 RID: 32296
		// (get) Token: 0x0601A693 RID: 108179 RVA: 0x003C2688 File Offset: 0x003C0888
		public int LevelPlayId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007E29 RID: 32297
		// (get) Token: 0x0601A694 RID: 108180 RVA: 0x003C26C8 File Offset: 0x003C08C8
		public IVectorInfo? OutOfRangeTrackPos
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601A695 RID: 108181 RVA: 0x003C2728 File Offset: 0x003C0928
		public IConditionTrackPos? ConditionTrackPosList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IConditionTrackPos?(default(IConditionTrackPos).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007E2A RID: 32298
		// (get) Token: 0x0601A696 RID: 108182 RVA: 0x003C278C File Offset: 0x003C098C
		public int ConditionTrackPosListLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17007E2B RID: 32299
		// (get) Token: 0x0601A697 RID: 108183 RVA: 0x003C27B8 File Offset: 0x003C09B8
		public ELevelPlayTrackSwitchRule TrackSwitchRule
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return ELevelPlayTrackSwitchRule.SwitchByLevelPlayTrack;
				}
				return (ELevelPlayTrackSwitchRule)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007E2C RID: 32300
		// (get) Token: 0x0601A698 RID: 108184 RVA: 0x003C27F8 File Offset: 0x003C09F8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A699 RID: 108185 RVA: 0x003C2838 File Offset: 0x003C0A38
		public static Offset<ITrackLevelPlay> CreateITrackLevelPlay(FlatBufferBuilder builder, ETrackType Type = ETrackType.Locations, TGravityDirection GravityDirection_type = TGravityDirection.NONE, int GravityDirectionOffset = 0, int LevelPlayId = 0, Offset<IVectorInfo> OutOfRangeTrackPosOffset = default(Offset<IVectorInfo>), VectorOffset ConditionTrackPosListOffset = default(VectorOffset), ELevelPlayTrackSwitchRule TrackSwitchRule = ELevelPlayTrackSwitchRule.SwitchByLevelPlayTrack, byte NullMask = 0)
		{
			builder.StartTable(8);
			ITrackLevelPlay.AddConditionTrackPosList(builder, ConditionTrackPosListOffset);
			ITrackLevelPlay.AddOutOfRangeTrackPos(builder, OutOfRangeTrackPosOffset);
			ITrackLevelPlay.AddLevelPlayId(builder, LevelPlayId);
			ITrackLevelPlay.AddGravityDirection(builder, GravityDirectionOffset);
			ITrackLevelPlay.AddNullMask(builder, NullMask);
			ITrackLevelPlay.AddTrackSwitchRule(builder, TrackSwitchRule);
			ITrackLevelPlay.AddGravityDirectionType(builder, GravityDirection_type);
			ITrackLevelPlay.AddType(builder, Type);
			return ITrackLevelPlay.EndITrackLevelPlay(builder);
		}

		// Token: 0x0601A69A RID: 108186 RVA: 0x003C288F File Offset: 0x003C0A8F
		public static void StartITrackLevelPlay(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0601A69B RID: 108187 RVA: 0x003C2898 File Offset: 0x003C0A98
		public static void AddType(FlatBufferBuilder builder, ETrackType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A69C RID: 108188 RVA: 0x003C28A3 File Offset: 0x003C0AA3
		public static void AddGravityDirectionType(FlatBufferBuilder builder, TGravityDirection gravityDirectionType)
		{
			builder.AddByte(1, (byte)gravityDirectionType, 0);
		}

		// Token: 0x0601A69D RID: 108189 RVA: 0x003C28AE File Offset: 0x003C0AAE
		public static void AddGravityDirection(FlatBufferBuilder builder, int gravityDirectionOffset)
		{
			builder.AddOffset(2, gravityDirectionOffset, 0);
		}

		// Token: 0x0601A69E RID: 108190 RVA: 0x003C28B9 File Offset: 0x003C0AB9
		public static void AddLevelPlayId(FlatBufferBuilder builder, int levelPlayId)
		{
			builder.AddInt(3, levelPlayId, 0);
		}

		// Token: 0x0601A69F RID: 108191 RVA: 0x003C28C4 File Offset: 0x003C0AC4
		public static void AddOutOfRangeTrackPos(FlatBufferBuilder builder, Offset<IVectorInfo> outOfRangeTrackPosOffset)
		{
			builder.AddOffset(4, outOfRangeTrackPosOffset.Value, 0);
		}

		// Token: 0x0601A6A0 RID: 108192 RVA: 0x003C28D4 File Offset: 0x003C0AD4
		public static void AddConditionTrackPosList(FlatBufferBuilder builder, VectorOffset conditionTrackPosListOffset)
		{
			builder.AddOffset(5, conditionTrackPosListOffset.Value, 0);
		}

		// Token: 0x0601A6A1 RID: 108193 RVA: 0x003C28E4 File Offset: 0x003C0AE4
		public static VectorOffset CreateConditionTrackPosListVector(FlatBufferBuilder builder, Offset<IConditionTrackPos>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A6A2 RID: 108194 RVA: 0x003C2924 File Offset: 0x003C0B24
		public static VectorOffset CreateConditionTrackPosListVectorBlock(FlatBufferBuilder builder, Offset<IConditionTrackPos>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IConditionTrackPos>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A6A3 RID: 108195 RVA: 0x003C293E File Offset: 0x003C0B3E
		public static VectorOffset CreateConditionTrackPosListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IConditionTrackPos>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IConditionTrackPos>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A6A4 RID: 108196 RVA: 0x003C295C File Offset: 0x003C0B5C
		public static VectorOffset CreateConditionTrackPosListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IConditionTrackPos>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A6A5 RID: 108197 RVA: 0x003C2975 File Offset: 0x003C0B75
		public static void StartConditionTrackPosListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A6A6 RID: 108198 RVA: 0x003C2980 File Offset: 0x003C0B80
		public static void AddTrackSwitchRule(FlatBufferBuilder builder, ELevelPlayTrackSwitchRule trackSwitchRule)
		{
			builder.AddByte(6, (byte)trackSwitchRule, 0);
		}

		// Token: 0x0601A6A7 RID: 108199 RVA: 0x003C298B File Offset: 0x003C0B8B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x0601A6A8 RID: 108200 RVA: 0x003C2996 File Offset: 0x003C0B96
		public static Offset<ITrackLevelPlay> EndITrackLevelPlay(FlatBufferBuilder builder)
		{
			return new Offset<ITrackLevelPlay>(builder.EndTable());
		}

		// Token: 0x0601A6A9 RID: 108201 RVA: 0x003C29A4 File Offset: 0x003C0BA4
		public ITrackLevelPlayT UnPack()
		{
			ITrackLevelPlayT trackLevelPlayT = new ITrackLevelPlayT();
			this.UnPackTo(trackLevelPlayT);
			return trackLevelPlayT;
		}

		// Token: 0x0601A6AA RID: 108202 RVA: 0x003C29C0 File Offset: 0x003C0BC0
		public void UnPackTo(ITrackLevelPlayT _o)
		{
			_o.Type = this.Type;
			_o.GravityDirection = new TGravityDirectionUnion();
			_o.GravityDirection.Type = this.GravityDirectionType;
			switch (this.GravityDirectionType)
			{
			case TGravityDirection.IGravityDirectionByEntityGravity:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionByEntityGravity>() != null) ? this.GravityDirection<IGravityDirectionByEntityGravity>().Value.UnPack() : null);
				break;
			case TGravityDirection.IGravityDirectionSelfRotation:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionSelfRotation>() != null) ? this.GravityDirection<IGravityDirectionSelfRotation>().Value.UnPack() : null);
				break;
			case TGravityDirection.IGravityDirectionVectorInfo:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionVectorInfo>() != null) ? this.GravityDirection<IGravityDirectionVectorInfo>().Value.UnPack() : null);
				break;
			case TGravityDirection.IGravityDirectionWorldAxis:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionWorldAxis>() != null) ? this.GravityDirection<IGravityDirectionWorldAxis>().Value.UnPack() : null);
				break;
			}
			_o.LevelPlayId = this.LevelPlayId;
			_o.OutOfRangeTrackPos = ((this.OutOfRangeTrackPos != null) ? this.OutOfRangeTrackPos.Value.UnPack() : null);
			_o.ConditionTrackPosList = new List<IConditionTrackPosT>();
			for (int i = 0; i < this.ConditionTrackPosListLength; i++)
			{
				_o.ConditionTrackPosList.Add((this.ConditionTrackPosList(i) != null) ? this.ConditionTrackPosList(i).Value.UnPack() : null);
			}
			_o.TrackSwitchRule = this.TrackSwitchRule;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601A6AB RID: 108203 RVA: 0x003C2BAC File Offset: 0x003C0DAC
		public static Offset<ITrackLevelPlay> Pack(FlatBufferBuilder builder, ITrackLevelPlayT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrackLevelPlay>);
			}
			TGravityDirection gravityDirection_type = (_o.GravityDirection == null) ? TGravityDirection.NONE : _o.GravityDirection.Type;
			int gravityDirectionOffset = (_o.GravityDirection == null) ? 0 : TGravityDirectionUnion.Pack(builder, _o.GravityDirection);
			Offset<IVectorInfo> outOfRangeTrackPosOffset = (_o.OutOfRangeTrackPos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.OutOfRangeTrackPos);
			VectorOffset conditionTrackPosListOffset = default(VectorOffset);
			if (_o.ConditionTrackPosList != null)
			{
				Offset<IConditionTrackPos>[] array = new Offset<IConditionTrackPos>[_o.ConditionTrackPosList.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IConditionTrackPos.Pack(builder, _o.ConditionTrackPosList[i]);
				}
				conditionTrackPosListOffset = ITrackLevelPlay.CreateConditionTrackPosListVector(builder, array);
			}
			return ITrackLevelPlay.CreateITrackLevelPlay(builder, _o.Type, gravityDirection_type, gravityDirectionOffset, _o.LevelPlayId, outOfRangeTrackPosOffset, conditionTrackPosListOffset, _o.TrackSwitchRule, _o.NullMask);
		}

		// Token: 0x0400C874 RID: 51316
		private Table __p;
	}
}
