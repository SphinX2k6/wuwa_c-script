using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F27 RID: 3879
	public sealed class RhythmActivityPb : IMessage<RhythmActivityPb>, IMessage, IEquatable<RhythmActivityPb>, IDeepCloneable<RhythmActivityPb>, IBufferMessage
	{
		// Token: 0x06014C99 RID: 85145 RVA: 0x00304B7D File Offset: 0x00302D7D
		[NullableContext(1)]
		public static RhythmActivityPb Create()
		{
			return new RhythmActivityPb();
		}

		// Token: 0x17004523 RID: 17699
		// (get) Token: 0x06014C9A RID: 85146 RVA: 0x00304B84 File Offset: 0x00302D84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004524 RID: 17700
		// (get) Token: 0x06014C9B RID: 85147 RVA: 0x00304B87 File Offset: 0x00302D87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmActivityPb.Descriptor;
			}
		}

		// Token: 0x06014C9C RID: 85148 RVA: 0x00304B8E File Offset: 0x00302D8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmActivityPb()
		{
		}

		// Token: 0x06014C9D RID: 85149 RVA: 0x00304BB8 File Offset: 0x00302DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmActivityPb(RhythmActivityPb other) : this()
		{
			this.rhythmShipPlanetPb_ = other.rhythmShipPlanetPb_.Clone();
			this.rhythmRoleId_ = other.rhythmRoleId_;
			this.rhythmTask_ = other.rhythmTask_.Clone();
			this.unlockedRole_ = other.unlockedRole_.Clone();
			this.redDot_ = ((other.redDot_ != null) ? other.redDot_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014C9E RID: 85150 RVA: 0x00304C37 File Offset: 0x00302E37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmActivityPb Clone()
		{
			return new RhythmActivityPb(this);
		}

		// Token: 0x17004525 RID: 17701
		// (get) Token: 0x06014C9F RID: 85151 RVA: 0x00304C3F File Offset: 0x00302E3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RhythmShipPlanetPb> RhythmShipPlanetPb
		{
			get
			{
				return this.rhythmShipPlanetPb_;
			}
		}

		// Token: 0x17004526 RID: 17702
		// (get) Token: 0x06014CA0 RID: 85152 RVA: 0x00304C47 File Offset: 0x00302E47
		// (set) Token: 0x06014CA1 RID: 85153 RVA: 0x00304C4F File Offset: 0x00302E4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RhythmRoleId
		{
			get
			{
				return this.rhythmRoleId_;
			}
			set
			{
				this.rhythmRoleId_ = value;
			}
		}

		// Token: 0x17004527 RID: 17703
		// (get) Token: 0x06014CA2 RID: 85154 RVA: 0x00304C58 File Offset: 0x00302E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RhythmTaskPb> RhythmTask
		{
			get
			{
				return this.rhythmTask_;
			}
		}

		// Token: 0x17004528 RID: 17704
		// (get) Token: 0x06014CA3 RID: 85155 RVA: 0x00304C60 File Offset: 0x00302E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockedRole
		{
			get
			{
				return this.unlockedRole_;
			}
		}

		// Token: 0x17004529 RID: 17705
		// (get) Token: 0x06014CA4 RID: 85156 RVA: 0x00304C68 File Offset: 0x00302E68
		// (set) Token: 0x06014CA5 RID: 85157 RVA: 0x00304C70 File Offset: 0x00302E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmRedDotPb RedDot
		{
			get
			{
				return this.redDot_;
			}
			set
			{
				this.redDot_ = value;
			}
		}

		// Token: 0x06014CA6 RID: 85158 RVA: 0x00304C79 File Offset: 0x00302E79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmActivityPb);
		}

		// Token: 0x06014CA7 RID: 85159 RVA: 0x00304C88 File Offset: 0x00302E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmActivityPb other)
		{
			return other != null && (other == this || (this.rhythmShipPlanetPb_.Equals(other.rhythmShipPlanetPb_) && this.RhythmRoleId == other.RhythmRoleId && this.rhythmTask_.Equals(other.rhythmTask_) && this.unlockedRole_.Equals(other.unlockedRole_) && object.Equals(this.RedDot, other.RedDot) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014CA8 RID: 85160 RVA: 0x00304D18 File Offset: 0x00302F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.rhythmShipPlanetPb_.GetHashCode();
			if (this.RhythmRoleId != 0)
			{
				num ^= this.RhythmRoleId.GetHashCode();
			}
			num ^= this.rhythmTask_.GetHashCode();
			num ^= this.unlockedRole_.GetHashCode();
			if (this.redDot_ != null)
			{
				num ^= this.RedDot.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014CA9 RID: 85161 RVA: 0x00304D97 File Offset: 0x00302F97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014CAA RID: 85162 RVA: 0x00304DA4 File Offset: 0x00302FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014CAB RID: 85163 RVA: 0x00304DB0 File Offset: 0x00302FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rhythmShipPlanetPb_.WriteTo(ref output, RhythmActivityPb._repeated_rhythmShipPlanetPb_codec);
			if (this.RhythmRoleId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RhythmRoleId);
			}
			this.rhythmTask_.WriteTo(ref output, RhythmActivityPb._repeated_rhythmTask_codec);
			this.unlockedRole_.WriteTo(ref output, RhythmActivityPb._repeated_unlockedRole_codec);
			if (this.redDot_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.RedDot);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014CAC RID: 85164 RVA: 0x00304E3C File Offset: 0x0030303C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rhythmShipPlanetPb_.CalculateSize(RhythmActivityPb._repeated_rhythmShipPlanetPb_codec);
			if (this.RhythmRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RhythmRoleId);
			}
			num += this.rhythmTask_.CalculateSize(RhythmActivityPb._repeated_rhythmTask_codec);
			num += this.unlockedRole_.CalculateSize(RhythmActivityPb._repeated_unlockedRole_codec);
			if (this.redDot_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RedDot);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014CAD RID: 85165 RVA: 0x00304ECC File Offset: 0x003030CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RhythmActivityPb other)
		{
			if (other == null)
			{
				return;
			}
			this.rhythmShipPlanetPb_.Add(other.rhythmShipPlanetPb_);
			if (other.RhythmRoleId != 0)
			{
				this.RhythmRoleId = other.RhythmRoleId;
			}
			this.rhythmTask_.Add(other.rhythmTask_);
			this.unlockedRole_.Add(other.unlockedRole_);
			if (other.redDot_ != null)
			{
				if (this.redDot_ == null)
				{
					this.RedDot = new RhythmRedDotPb();
				}
				this.RedDot.MergeFrom(other.RedDot);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014CAE RID: 85166 RVA: 0x00304F67 File Offset: 0x00303167
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014CAF RID: 85167 RVA: 0x00304F70 File Offset: 0x00303170
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
				if (num <= 42U)
				{
					if (num == 18U)
					{
						this.rhythmShipPlanetPb_.AddEntriesFrom(ref input, RhythmActivityPb._repeated_rhythmShipPlanetPb_codec);
						continue;
					}
					if (num == 24U)
					{
						this.RhythmRoleId = input.ReadInt32();
						continue;
					}
					if (num == 42U)
					{
						this.rhythmTask_.AddEntriesFrom(ref input, RhythmActivityPb._repeated_rhythmTask_codec);
						continue;
					}
				}
				else
				{
					if (num == 48U || num == 50U)
					{
						this.unlockedRole_.AddEntriesFrom(ref input, RhythmActivityPb._repeated_unlockedRole_codec);
						continue;
					}
					if (num == 58U)
					{
						if (this.redDot_ == null)
						{
							this.RedDot = new RhythmRedDotPb();
						}
						input.ReadMessage(this.RedDot);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007DEF RID: 32239
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007DF0 RID: 32240
		public const int RhythmShipPlanetPbFieldNumber = 2;

		// Token: 0x04007DF1 RID: 32241
		private static readonly FieldCodec<RhythmShipPlanetPb> _repeated_rhythmShipPlanetPb_codec = FieldCodec.ForMessage<RhythmShipPlanetPb>(18U, Aki.Protocol.RhythmShipPlanetPb.Parser);

		// Token: 0x04007DF2 RID: 32242
		private readonly RepeatedField<RhythmShipPlanetPb> rhythmShipPlanetPb_ = new RepeatedField<RhythmShipPlanetPb>();

		// Token: 0x04007DF3 RID: 32243
		public const int RhythmRoleIdFieldNumber = 3;

		// Token: 0x04007DF4 RID: 32244
		private int rhythmRoleId_;

		// Token: 0x04007DF5 RID: 32245
		public const int RhythmTaskFieldNumber = 5;

		// Token: 0x04007DF6 RID: 32246
		private static readonly FieldCodec<RhythmTaskPb> _repeated_rhythmTask_codec = FieldCodec.ForMessage<RhythmTaskPb>(42U, RhythmTaskPb.Parser);

		// Token: 0x04007DF7 RID: 32247
		private readonly RepeatedField<RhythmTaskPb> rhythmTask_ = new RepeatedField<RhythmTaskPb>();

		// Token: 0x04007DF8 RID: 32248
		public const int UnlockedRoleFieldNumber = 6;

		// Token: 0x04007DF9 RID: 32249
		private static readonly FieldCodec<int> _repeated_unlockedRole_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04007DFA RID: 32250
		private readonly RepeatedField<int> unlockedRole_ = new RepeatedField<int>();

		// Token: 0x04007DFB RID: 32251
		public const int RedDotFieldNumber = 7;

		// Token: 0x04007DFC RID: 32252
		private RhythmRedDotPb redDot_;
	}
}
