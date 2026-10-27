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
		// Token: 0x060010E3 RID: 4323 RVA: 0x0002F0C2 File Offset: 0x0002D2C2
		[NullableContext(1)]
		public static AbyssChallengeRoomInfoNotify Create()
		{
			return new AbyssChallengeRoomInfoNotify();
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060010E4 RID: 4324 RVA: 0x0002F0C9 File Offset: 0x0002D2C9
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
		// (get) Token: 0x060010E5 RID: 4325 RVA: 0x0002F0CC File Offset: 0x0002D2CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssChallengeRoomInfoNotify.Descriptor;
			}
		}

		// Token: 0x060010E6 RID: 4326 RVA: 0x0002F0D3 File Offset: 0x0002D2D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeRoomInfoNotify()
		{
		}

		// Token: 0x060010E7 RID: 4327 RVA: 0x0002F0F4 File Offset: 0x0002D2F4
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

		// Token: 0x060010E8 RID: 4328 RVA: 0x0002F1A6 File Offset: 0x0002D3A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeRoomInfoNotify Clone()
		{
			return new AbyssChallengeRoomInfoNotify(this);
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060010E9 RID: 4329 RVA: 0x0002F1AE File Offset: 0x0002D3AE
		// (set) Token: 0x060010EA RID: 4330 RVA: 0x0002F1B6 File Offset: 0x0002D3B6
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
		// (get) Token: 0x060010EB RID: 4331 RVA: 0x0002F1BF File Offset: 0x0002D3BF
		// (set) Token: 0x060010EC RID: 4332 RVA: 0x0002F1C7 File Offset: 0x0002D3C7
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
		// (get) Token: 0x060010ED RID: 4333 RVA: 0x0002F1D0 File Offset: 0x0002D3D0
		// (set) Token: 0x060010EE RID: 4334 RVA: 0x0002F1D8 File Offset: 0x0002D3D8
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
		// (get) Token: 0x060010EF RID: 4335 RVA: 0x0002F1E1 File Offset: 0x0002D3E1
		// (set) Token: 0x060010F0 RID: 4336 RVA: 0x0002F1E9 File Offset: 0x0002D3E9
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
		// (get) Token: 0x060010F1 RID: 4337 RVA: 0x0002F1F2 File Offset: 0x0002D3F2
		// (set) Token: 0x060010F2 RID: 4338 RVA: 0x0002F1FA File Offset: 0x0002D3FA
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
		// (get) Token: 0x060010F3 RID: 4339 RVA: 0x0002F203 File Offset: 0x0002D403
		// (set) Token: 0x060010F4 RID: 4340 RVA: 0x0002F20B File Offset: 0x0002D40B
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
		// (get) Token: 0x060010F5 RID: 4341 RVA: 0x0002F214 File Offset: 0x0002D414
		// (set) Token: 0x060010F6 RID: 4342 RVA: 0x0002F21C File Offset: 0x0002D41C
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
		// (get) Token: 0x060010F7 RID: 4343 RVA: 0x0002F225 File Offset: 0x0002D425
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
		// (get) Token: 0x060010F8 RID: 4344 RVA: 0x0002F22D File Offset: 0x0002D42D
		// (set) Token: 0x060010F9 RID: 4345 RVA: 0x0002F235 File Offset: 0x0002D435
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
		// (get) Token: 0x060010FA RID: 4346 RVA: 0x0002F23E File Offset: 0x0002D43E
		// (set) Token: 0x060010FB RID: 4347 RVA: 0x0002F246 File Offset: 0x0002D446
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
		// (get) Token: 0x060010FC RID: 4348 RVA: 0x0002F24F File Offset: 0x0002D44F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AbyssLikeRecord> LikeRecord
		{
			get
			{
				return this.likeRecord_;
			}
		}

		// Token: 0x060010FD RID: 4349 RVA: 0x0002F257 File Offset: 0x0002D457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssChallengeRoomInfoNotify);
		}

		// Token: 0x060010FE RID: 4350 RVA: 0x0002F268 File Offset: 0x0002D468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssChallengeRoomInfoNotify other)
		{
			return other != null && (other == this || (this.CurFloor == other.CurFloor && this.MaxFloor == other.MaxFloor && this.MaxBox == other.MaxBox && this.GainBox == other.GainBox && this.RoomId == other.RoomId && this.RouteId == other.RouteId && this.ChallengeId == other.ChallengeId && this.RoleEquipMap.Equals(other.RoleEquipMap) && this.MaxScore == other.MaxScore && this.CurScore == other.CurScore && this.likeRecord_.Equals(other.likeRecord_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060010FF RID: 4351 RVA: 0x0002F34C File Offset: 0x0002D54C
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

		// Token: 0x06001100 RID: 4352 RVA: 0x0002F46F File Offset: 0x0002D66F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001101 RID: 4353 RVA: 0x0002F47C File Offset: 0x0002D67C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001102 RID: 4354 RVA: 0x0002F488 File Offset: 0x0002D688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurFloor != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CurFloor);
			}
			this.likeRecord_.WriteTo(ref output, AbyssChallengeRoomInfoNotify._repeated_likeRecord_codec);
			this.roleEquipMap_.WriteTo(ref output, AbyssChallengeRoomInfoNotify._map_roleEquipMap_codec);
			if (this.CurScore != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.CurScore);
			}
			if (this.RouteId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.RouteId);
			}
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ChallengeId);
			}
			if (this.RoomId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.RoomId);
			}
			if (this.MaxFloor != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.MaxFloor);
			}
			if (this.MaxScore != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.MaxScore);
			}
			if (this.MaxBox != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.MaxBox);
			}
			if (this.GainBox != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.GainBox);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x0002F5C8 File Offset: 0x0002D7C8
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

		// Token: 0x06001104 RID: 4356 RVA: 0x0002F6EC File Offset: 0x0002D8EC
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

		// Token: 0x06001105 RID: 4357 RVA: 0x0002F7EA File Offset: 0x0002D9EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001106 RID: 4358 RVA: 0x0002F7F4 File Offset: 0x0002D9F4
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
				if (num <= 56U)
				{
					if (num <= 26U)
					{
						if (num == 16U)
						{
							this.CurFloor = input.ReadInt32();
							continue;
						}
						if (num == 26U)
						{
							this.likeRecord_.AddEntriesFrom(ref input, AbyssChallengeRoomInfoNotify._repeated_likeRecord_codec);
							continue;
						}
					}
					else
					{
						if (num == 34U)
						{
							this.roleEquipMap_.AddEntriesFrom(ref input, AbyssChallengeRoomInfoNotify._map_roleEquipMap_codec);
							continue;
						}
						if (num == 40U)
						{
							this.CurScore = input.ReadInt32();
							continue;
						}
						if (num == 56U)
						{
							this.RouteId = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 88U)
				{
					if (num == 64U)
					{
						this.ChallengeId = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.RoomId = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.MaxFloor = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.MaxScore = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.MaxBox = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.GainBox = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001F3B RID: 7995
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F3C RID: 7996
		public const int CurFloorFieldNumber = 2;

		// Token: 0x04001F3D RID: 7997
		private int curFloor_;

		// Token: 0x04001F3E RID: 7998
		public const int MaxFloorFieldNumber = 11;

		// Token: 0x04001F3F RID: 7999
		private int maxFloor_;

		// Token: 0x04001F40 RID: 8000
		public const int MaxBoxFieldNumber = 13;

		// Token: 0x04001F41 RID: 8001
		private int maxBox_;

		// Token: 0x04001F42 RID: 8002
		public const int GainBoxFieldNumber = 14;

		// Token: 0x04001F43 RID: 8003
		private int gainBox_;

		// Token: 0x04001F44 RID: 8004
		public const int RoomIdFieldNumber = 10;

		// Token: 0x04001F45 RID: 8005
		private int roomId_;

		// Token: 0x04001F46 RID: 8006
		public const int RouteIdFieldNumber = 7;

		// Token: 0x04001F47 RID: 8007
		private int routeId_;

		// Token: 0x04001F48 RID: 8008
		public const int ChallengeIdFieldNumber = 8;

		// Token: 0x04001F49 RID: 8009
		private int challengeId_;

		// Token: 0x04001F4A RID: 8010
		public const int RoleEquipMapFieldNumber = 4;

		// Token: 0x04001F4B RID: 8011
		private static readonly MapField<int, int>.Codec _map_roleEquipMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 34U);

		// Token: 0x04001F4C RID: 8012
		private readonly MapField<int, int> roleEquipMap_ = new MapField<int, int>();

		// Token: 0x04001F4D RID: 8013
		public const int MaxScoreFieldNumber = 12;

		// Token: 0x04001F4E RID: 8014
		private int maxScore_;

		// Token: 0x04001F4F RID: 8015
		public const int CurScoreFieldNumber = 5;

		// Token: 0x04001F50 RID: 8016
		private int curScore_;

		// Token: 0x04001F51 RID: 8017
		public const int LikeRecordFieldNumber = 3;

		// Token: 0x04001F52 RID: 8018
		private static readonly FieldCodec<AbyssLikeRecord> _repeated_likeRecord_codec = FieldCodec.ForMessage<AbyssLikeRecord>(26U, AbyssLikeRecord.Parser);

		// Token: 0x04001F53 RID: 8019
		private readonly RepeatedField<AbyssLikeRecord> likeRecord_ = new RepeatedField<AbyssLikeRecord>();
	}
}
