using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004202 RID: 16898
	public struct ITrackLevelPlay : IFlatbufferObject
	{
		// Token: 0x170077F4 RID: 30708
		// (get) Token: 0x06018F1A RID: 102170 RVA: 0x00396E15 File Offset: 0x00395015
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018F1B RID: 102171 RVA: 0x00396E22 File Offset: 0x00395022
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018F1C RID: 102172 RVA: 0x00396E2C File Offset: 0x0039502C
		public static ITrackLevelPlay GetRootAsITrackLevelPlay(ByteBuffer _bb)
		{
			return ITrackLevelPlay.GetRootAsITrackLevelPlay(_bb, default(ITrackLevelPlay));
		}

		// Token: 0x06018F1D RID: 102173 RVA: 0x00396E48 File Offset: 0x00395048
		public static ITrackLevelPlay GetRootAsITrackLevelPlay(ByteBuffer _bb, ITrackLevelPlay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018F1E RID: 102174 RVA: 0x00396E65 File Offset: 0x00395065
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018F1F RID: 102175 RVA: 0x00396E74 File Offset: 0x00395074
		public ITrackLevelPlay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170077F5 RID: 30709
		// (get) Token: 0x06018F20 RID: 102176 RVA: 0x00396E84 File Offset: 0x00395084
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

		// Token: 0x170077F6 RID: 30710
		// (get) Token: 0x06018F21 RID: 102177 RVA: 0x00396EC0 File Offset: 0x003950C0
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

		// Token: 0x06018F22 RID: 102178 RVA: 0x00396EFC File Offset: 0x003950FC
		public TTable? GravityDirection<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06018F23 RID: 102179 RVA: 0x00396F40 File Offset: 0x00395140
		public IGravityDirectionByEntityGravity GravityDirectionAsIGravityDirectionByEntityGravity()
		{
			return this.GravityDirection<IGravityDirectionByEntityGravity>().Value;
		}

		// Token: 0x06018F24 RID: 102180 RVA: 0x00396F5C File Offset: 0x0039515C
		public IGravityDirectionSelfRotation GravityDirectionAsIGravityDirectionSelfRotation()
		{
			return this.GravityDirection<IGravityDirectionSelfRotation>().Value;
		}

		// Token: 0x06018F25 RID: 102181 RVA: 0x00396F78 File Offset: 0x00395178
		public IGravityDirectionVectorInfo GravityDirectionAsIGravityDirectionVectorInfo()
		{
			return this.GravityDirection<IGravityDirectionVectorInfo>().Value;
		}

		// Token: 0x06018F26 RID: 102182 RVA: 0x00396F94 File Offset: 0x00395194
		public IGravityDirectionWorldAxis GravityDirectionAsIGravityDirectionWorldAxis()
		{
			return this.GravityDirection<IGravityDirectionWorldAxis>().Value;
		}

		// Token: 0x170077F7 RID: 30711
		// (get) Token: 0x06018F27 RID: 102183 RVA: 0x00396FB0 File Offset: 0x003951B0
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

		// Token: 0x170077F8 RID: 30712
		// (get) Token: 0x06018F28 RID: 102184 RVA: 0x00396FF0 File Offset: 0x003951F0
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

		// Token: 0x06018F29 RID: 102185 RVA: 0x00397050 File Offset: 0x00395250
		public IConditionTrackPos? ConditionTrackPosList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IConditionTrackPos?(default(IConditionTrackPos).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170077F9 RID: 30713
		// (get) Token: 0x06018F2A RID: 102186 RVA: 0x003970B4 File Offset: 0x003952B4
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

		// Token: 0x170077FA RID: 30714
		// (get) Token: 0x06018F2B RID: 102187 RVA: 0x003970E0 File Offset: 0x003952E0
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

		// Token: 0x170077FB RID: 30715
		// (get) Token: 0x06018F2C RID: 102188 RVA: 0x00397120 File Offset: 0x00395320
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

		// Token: 0x06018F2D RID: 102189 RVA: 0x00397160 File Offset: 0x00395360
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

		// Token: 0x06018F2E RID: 102190 RVA: 0x003971B7 File Offset: 0x003953B7
		public static void StartITrackLevelPlay(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06018F2F RID: 102191 RVA: 0x003971C0 File Offset: 0x003953C0
		public static void AddType(FlatBufferBuilder builder, ETrackType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018F30 RID: 102192 RVA: 0x003971CB File Offset: 0x003953CB
		public static void AddGravityDirectionType(FlatBufferBuilder builder, TGravityDirection gravityDirectionType)
		{
			builder.AddByte(1, (byte)gravityDirectionType, 0);
		}

		// Token: 0x06018F31 RID: 102193 RVA: 0x003971D6 File Offset: 0x003953D6
		public static void AddGravityDirection(FlatBufferBuilder builder, int gravityDirectionOffset)
		{
			builder.AddOffset(2, gravityDirectionOffset, 0);
		}

		// Token: 0x06018F32 RID: 102194 RVA: 0x003971E1 File Offset: 0x003953E1
		public static void AddLevelPlayId(FlatBufferBuilder builder, int levelPlayId)
		{
			builder.AddInt(3, levelPlayId, 0);
		}

		// Token: 0x06018F33 RID: 102195 RVA: 0x003971EC File Offset: 0x003953EC
		public static void AddOutOfRangeTrackPos(FlatBufferBuilder builder, Offset<IVectorInfo> outOfRangeTrackPosOffset)
		{
			builder.AddOffset(4, outOfRangeTrackPosOffset.Value, 0);
		}

		// Token: 0x06018F34 RID: 102196 RVA: 0x003971FC File Offset: 0x003953FC
		public static void AddConditionTrackPosList(FlatBufferBuilder builder, VectorOffset conditionTrackPosListOffset)
		{
			builder.AddOffset(5, conditionTrackPosListOffset.Value, 0);
		}

		// Token: 0x06018F35 RID: 102197 RVA: 0x0039720C File Offset: 0x0039540C
		public static VectorOffset CreateConditionTrackPosListVector(FlatBufferBuilder builder, Offset<IConditionTrackPos>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06018F36 RID: 102198 RVA: 0x0039724C File Offset: 0x0039544C
		public static VectorOffset CreateConditionTrackPosListVectorBlock(FlatBufferBuilder builder, Offset<IConditionTrackPos>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IConditionTrackPos>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018F37 RID: 102199 RVA: 0x00397266 File Offset: 0x00395466
		public static VectorOffset CreateConditionTrackPosListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IConditionTrackPos>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IConditionTrackPos>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018F38 RID: 102200 RVA: 0x00397284 File Offset: 0x00395484
		public static VectorOffset CreateConditionTrackPosListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IConditionTrackPos>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018F39 RID: 102201 RVA: 0x0039729D File Offset: 0x0039549D
		public static void StartConditionTrackPosListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018F3A RID: 102202 RVA: 0x003972A8 File Offset: 0x003954A8
		public static void AddTrackSwitchRule(FlatBufferBuilder builder, ELevelPlayTrackSwitchRule trackSwitchRule)
		{
			builder.AddByte(6, (byte)trackSwitchRule, 0);
		}

		// Token: 0x06018F3B RID: 102203 RVA: 0x003972B3 File Offset: 0x003954B3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06018F3C RID: 102204 RVA: 0x003972BE File Offset: 0x003954BE
		public static Offset<ITrackLevelPlay> EndITrackLevelPlay(FlatBufferBuilder builder)
		{
			return new Offset<ITrackLevelPlay>(builder.EndTable());
		}

		// Token: 0x06018F3D RID: 102205 RVA: 0x003972CC File Offset: 0x003954CC
		public ITrackLevelPlayT UnPack()
		{
			ITrackLevelPlayT trackLevelPlayT = new ITrackLevelPlayT();
			this.UnPackTo(trackLevelPlayT);
			return trackLevelPlayT;
		}

		// Token: 0x06018F3E RID: 102206 RVA: 0x003972E8 File Offset: 0x003954E8
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

		// Token: 0x06018F3F RID: 102207 RVA: 0x003974D4 File Offset: 0x003956D4
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

		// Token: 0x0400BE67 RID: 48743
		private Table __p;
	}
}
