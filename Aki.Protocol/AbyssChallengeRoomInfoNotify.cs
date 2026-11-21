using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200001F RID: 31
	[NetMessage(EMessageId.AbyssChallengeRoomInfoNotify)]
	public sealed class AbyssChallengeRoomInfoNotify : IMessage<AbyssChallengeRoomInfoNotify>, IMessage, IEquatable<AbyssChallengeRoomInfoNotify>, IDeepCloneable<AbyssChallengeRoomInfoNotify>, IBufferMessage
	{
		// Token: 0x0600110E RID: 4366 RVA: 0x0002F676 File Offset: 0x0002D876
		[NullableContext(1)]
		public static AbyssChallengeRoomInfoNotify Create()
		{
			return new AbyssChallengeRoomInfoNotify();
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600110F RID: 4367 RVA: 0x0002F67D File Offset: 0x0002D87D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06001110 RID: 4368 RVA: 0x0002F680 File Offset: 0x0002D880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssChallengeRoomInfoNotify.Descriptor;
			}
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x0002F687 File Offset: 0x0002D887
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeRoomInfoNotify()
		{
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x0002F6A8 File Offset: 0x0002D8A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeRoomInfoNotify(AbyssChallengeRoomInfoNotify other) : this()
		{
			this.curFloor_ = other.curFloor_;
			this.maxFloor_ = other.maxFloor_;
			this.maxBox_ = other.maxBox_;
			this.gainBox_ = other.gainBox_;
			this.roomId_ = other.roomId_;
			this.routeId_ = other.routeId_;
			this.challengeId_ = other.challengeId_;
			this.roleEquipMap_ = other.roleEquipMap_.Clone();
			this.maxScore_ = other.maxScore_;
			this.curScore_ = other.curScore_;
			this.likeRecord_ = other.likeRecord_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x0002F75A File Offset: 0x0002D95A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeRoomInfoNotify Clone()
		{
			return new AbyssChallengeRoomInfoNotify(this);
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06001114 RID: 4372 RVA: 0x0002F762 File Offset: 0x0002D962
		// (set) Token: 0x06001115 RID: 4373 RVA: 0x0002F76A File Offset: 0x0002D96A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurFloor
		{
			get
			{
				return this.curFloor_;
			}
			set
			{
				this.curFloor_ = value;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06001116 RID: 4374 RVA: 0x0002F773 File Offset: 0x0002D973
		// (set) Token: 0x06001117 RID: 4375 RVA: 0x0002F77B File Offset: 0x0002D97B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxFloor
		{
			get
			{
				return this.maxFloor_;
			}
			set
			{
				this.maxFloor_ = value;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06001118 RID: 4376 RVA: 0x0002F784 File Offset: 0x0002D984
		// (set) Token: 0x06001119 RID: 4377 RVA: 0x0002F78C File Offset: 0x0002D98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxBox
		{
			get
			{
				return this.maxBox_;
			}
			set
			{
				this.maxBox_ = value;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600111A RID: 4378 RVA: 0x0002F795 File Offset: 0x0002D995
		// (set) Token: 0x0600111B RID: 4379 RVA: 0x0002F79D File Offset: 0x0002D99D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GainBox
		{
			get
			{
				return this.gainBox_;
			}
			set
			{
				this.gainBox_ = value;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600111C RID: 4380 RVA: 0x0002F7A6 File Offset: 0x0002D9A6
		// (set) Token: 0x0600111D RID: 4381 RVA: 0x0002F7AE File Offset: 0x0002D9AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoomId
		{
			get
			{
				return this.roomId_;
			}
			set
			{
				this.roomId_ = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600111E RID: 4382 RVA: 0x0002F7B7 File Offset: 0x0002D9B7
		// (set) Token: 0x0600111F RID: 4383 RVA: 0x0002F7BF File Offset: 0x0002D9BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RouteId
		{
			get
			{
				return this.routeId_;
			}
			set
			{
				this.routeId_ = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06001120 RID: 4384 RVA: 0x0002F7C8 File Offset: 0x0002D9C8
		// (set) Token: 0x06001121 RID: 4385 RVA: 0x0002F7D0 File Offset: 0x0002D9D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChallengeId
		{
			get
			{
				return this.challengeId_;
			}
			set
			{
				this.challengeId_ = value;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06001122 RID: 4386 RVA: 0x0002F7D9 File Offset: 0x0002D9D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> RoleEquipMap
		{
			get
			{
				return this.roleEquipMap_;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06001123 RID: 4387 RVA: 0x0002F7E1 File Offset: 0x0002D9E1
		// (set) Token: 0x06001124 RID: 4388 RVA: 0x0002F7E9 File Offset: 0x0002D9E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxScore
		{
			get
			{
				return this.maxScore_;
			}
			set
			{
				this.maxScore_ = value;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06001125 RID: 4389 RVA: 0x0002F7F2 File Offset: 0x0002D9F2
		// (set) Token: 0x06001126 RID: 4390 RVA: 0x0002F7FA File Offset: 0x0002D9FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurScore
		{
			get
			{
				return this.curScore_;
			}
			set
			{
				this.curScore_ = value;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06001127 RID: 4391 RVA: 0x0002F803 File Offset: 0x0002DA03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AbyssLikeRecord> LikeRecord
		{
			get
			{
				return this.likeRecord_;
			}
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x0002F80B File Offset: 0x0002DA0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssChallengeRoomInfoNotify);
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x0002F81C File Offset: 0x0002DA1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssChallengeRoomInfoNotify other)
		{
			return other != null && (other == this || (this.CurFloor == other.CurFloor && this.MaxFloor == other.MaxFloor && this.MaxBox == other.MaxBox && this.GainBox == other.GainBox && this.RoomId == other.RoomId && this.RouteId == other.RouteId && this.ChallengeId == other.ChallengeId && this.RoleEquipMap.Equals(other.RoleEquipMap) && this.MaxScore == other.MaxScore && this.CurScore == other.CurScore && this.likeRecord_.Equals(other.likeRecord_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x0002F900 File Offset: 0x0002DB00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurFloor != 0)
			{
				num ^= this.CurFloor.GetHashCode();
			}
			if (this.MaxFloor != 0)
			{
				num ^= this.MaxFloor.GetHashCode();
			}
			if (this.MaxBox != 0)
			{
				num ^= this.MaxBox.GetHashCode();
			}
			if (this.GainBox != 0)
			{
				num ^= this.GainBox.GetHashCode();
			}
			if (this.RoomId != 0)
			{
				num ^= this.RoomId.GetHashCode();
			}
			if (this.RouteId != 0)
			{
				num ^= this.RouteId.GetHashCode();
			}
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			num ^= this.RoleEquipMap.GetHashCode();
			if (this.MaxScore != 0)
			{
				num ^= this.MaxScore.GetHashCode();
			}
			if (this.CurScore != 0)
			{
				num ^= this.CurScore.GetHashCode();
			}
			num ^= this.likeRecord_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x0002FA23 File Offset: 0x0002DC23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x0002FA30 File Offset: 0x0002DC30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x0002FA3C File Offset: 0x0002DC3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MaxScore != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MaxScore);
			}
			if (this.GainBox != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.GainBox);
			}
			if (this.MaxFloor != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.MaxFloor);
			}
			if (this.RoomId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.RoomId);
			}
			if (this.CurScore != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.CurScore);
			}
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ChallengeId);
			}
			if (this.CurFloor != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.CurFloor);
			}
			this.likeRecord_.WriteTo(ref output, AbyssChallengeRoomInfoNotify._repeated_likeRecord_codec);
			this.roleEquipMap_.WriteTo(ref output, AbyssChallengeRoomInfoNotify._map_roleEquipMap_codec);
			if (this.RouteId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.RouteId);
			}
			if (this.MaxBox != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.MaxBox);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x0002FB7C File Offset: 0x0002DD7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurFloor != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurFloor);
			}
			if (this.MaxFloor != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxFloor);
			}
			if (this.MaxBox != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxBox);
			}
			if (this.GainBox != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GainBox);
			}
			if (this.RoomId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoomId);
			}
			if (this.RouteId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RouteId);
			}
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			num += this.roleEquipMap_.CalculateSize(AbyssChallengeRoomInfoNotify._map_roleEquipMap_codec);
			if (this.MaxScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxScore);
			}
			if (this.CurScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurScore);
			}
			num += this.likeRecord_.CalculateSize(AbyssChallengeRoomInfoNotify._repeated_likeRecord_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x0002FCA0 File Offset: 0x0002DEA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssChallengeRoomInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurFloor != 0)
			{
				this.CurFloor = other.CurFloor;
			}
			if (other.MaxFloor != 0)
			{
				this.MaxFloor = other.MaxFloor;
			}
			if (other.MaxBox != 0)
			{
				this.MaxBox = other.MaxBox;
			}
			if (other.GainBox != 0)
			{
				this.GainBox = other.GainBox;
			}
			if (other.RoomId != 0)
			{
				this.RoomId = other.RoomId;
			}
			if (other.RouteId != 0)
			{
				this.RouteId = other.RouteId;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			this.roleEquipMap_.MergeFrom(other.roleEquipMap_);
			if (other.MaxScore != 0)
			{
				this.MaxScore = other.MaxScore;
			}
			if (other.CurScore != 0)
			{
				this.CurScore = other.CurScore;
			}
			this.likeRecord_.Add(other.likeRecord_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x0002FD9E File Offset: 0x0002DF9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001131 RID: 4401 RVA: 0x0002FDA8 File Offset: 0x0002DFA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num <= 48U)
				{
					if (num <= 24U)
					{
						if (num == 16U)
						{
							this.MaxScore = input.ReadInt32();
							continue;
						}
						if (num == 24U)
						{
							this.GainBox = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 32U)
						{
							this.MaxFloor = input.ReadInt32();
							continue;
						}
						if (num == 40U)
						{
							this.RoomId = input.ReadInt32();
							continue;
						}
						if (num == 48U)
						{
							this.CurScore = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 74U)
				{
					if (num == 56U)
					{
						this.ChallengeId = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.CurFloor = input.ReadInt32();
						continue;
					}
					if (num == 74U)
					{
						this.likeRecord_.AddEntriesFrom(ref input, AbyssChallengeRoomInfoNotify._repeated_likeRecord_codec);
						continue;
					}
				}
				else
				{
					if (num == 90U)
					{
						this.roleEquipMap_.AddEntriesFrom(ref input, AbyssChallengeRoomInfoNotify._map_roleEquipMap_codec);
						continue;
					}
					if (num == 104U)
					{
						this.RouteId = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.MaxBox = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001F91 RID: 8081
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F92 RID: 8082
		public const int CurFloorFieldNumber = 8;

		// Token: 0x04001F93 RID: 8083
		private int curFloor_;

		// Token: 0x04001F94 RID: 8084
		public const int MaxFloorFieldNumber = 4;

		// Token: 0x04001F95 RID: 8085
		private int maxFloor_;

		// Token: 0x04001F96 RID: 8086
		public const int MaxBoxFieldNumber = 15;

		// Token: 0x04001F97 RID: 8087
		private int maxBox_;

		// Token: 0x04001F98 RID: 8088
		public const int GainBoxFieldNumber = 3;

		// Token: 0x04001F99 RID: 8089
		private int gainBox_;

		// Token: 0x04001F9A RID: 8090
		public const int RoomIdFieldNumber = 5;

		// Token: 0x04001F9B RID: 8091
		private int roomId_;

		// Token: 0x04001F9C RID: 8092
		public const int RouteIdFieldNumber = 13;

		// Token: 0x04001F9D RID: 8093
		private int routeId_;

		// Token: 0x04001F9E RID: 8094
		public const int ChallengeIdFieldNumber = 7;

		// Token: 0x04001F9F RID: 8095
		private int challengeId_;

		// Token: 0x04001FA0 RID: 8096
		public const int RoleEquipMapFieldNumber = 11;

		// Token: 0x04001FA1 RID: 8097
		private static readonly MapField<int, int>.Codec _map_roleEquipMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 90U);

		// Token: 0x04001FA2 RID: 8098
		private readonly MapField<int, int> roleEquipMap_ = new MapField<int, int>();

		// Token: 0x04001FA3 RID: 8099
		public const int MaxScoreFieldNumber = 2;

		// Token: 0x04001FA4 RID: 8100
		private int maxScore_;

		// Token: 0x04001FA5 RID: 8101
		public const int CurScoreFieldNumber = 6;

		// Token: 0x04001FA6 RID: 8102
		private int curScore_;

		// Token: 0x04001FA7 RID: 8103
		public const int LikeRecordFieldNumber = 9;

		// Token: 0x04001FA8 RID: 8104
		private static readonly FieldCodec<AbyssLikeRecord> _repeated_likeRecord_codec = FieldCodec.ForMessage<AbyssLikeRecord>(74U, AbyssLikeRecord.Parser);

		// Token: 0x04001FA9 RID: 8105
		private readonly RepeatedField<AbyssLikeRecord> likeRecord_ = new RepeatedField<AbyssLikeRecord>();
	}
}
