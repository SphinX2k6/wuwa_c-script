using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F37 RID: 3895
	public sealed class RhythmActivityPb : IMessage<RhythmActivityPb>, IMessage, IEquatable<RhythmActivityPb>, IDeepCloneable<RhythmActivityPb>, IBufferMessage
	{
		// Token: 0x06014D7E RID: 85374 RVA: 0x00306239 File Offset: 0x00304439
		[NullableContext(1)]
		public static RhythmActivityPb Create()
		{
			return new RhythmActivityPb();
		}

		// Token: 0x1700454D RID: 17741
		// (get) Token: 0x06014D7F RID: 85375 RVA: 0x00306240 File Offset: 0x00304440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700454E RID: 17742
		// (get) Token: 0x06014D80 RID: 85376 RVA: 0x00306243 File Offset: 0x00304443
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmActivityPb.Descriptor;
			}
		}

		// Token: 0x06014D81 RID: 85377 RVA: 0x0030624A File Offset: 0x0030444A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmActivityPb()
		{
		}

		// Token: 0x06014D82 RID: 85378 RVA: 0x00306274 File Offset: 0x00304474
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

		// Token: 0x06014D83 RID: 85379 RVA: 0x003062F3 File Offset: 0x003044F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmActivityPb Clone()
		{
			return new RhythmActivityPb(this);
		}

		// Token: 0x1700454F RID: 17743
		// (get) Token: 0x06014D84 RID: 85380 RVA: 0x003062FB File Offset: 0x003044FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RhythmShipPlanetPb> RhythmShipPlanetPb
		{
			get
			{
				return this.rhythmShipPlanetPb_;
			}
		}

		// Token: 0x17004550 RID: 17744
		// (get) Token: 0x06014D85 RID: 85381 RVA: 0x00306303 File Offset: 0x00304503
		// (set) Token: 0x06014D86 RID: 85382 RVA: 0x0030630B File Offset: 0x0030450B
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

		// Token: 0x17004551 RID: 17745
		// (get) Token: 0x06014D87 RID: 85383 RVA: 0x00306314 File Offset: 0x00304514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RhythmTaskPb> RhythmTask
		{
			get
			{
				return this.rhythmTask_;
			}
		}

		// Token: 0x17004552 RID: 17746
		// (get) Token: 0x06014D88 RID: 85384 RVA: 0x0030631C File Offset: 0x0030451C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockedRole
		{
			get
			{
				return this.unlockedRole_;
			}
		}

		// Token: 0x17004553 RID: 17747
		// (get) Token: 0x06014D89 RID: 85385 RVA: 0x00306324 File Offset: 0x00304524
		// (set) Token: 0x06014D8A RID: 85386 RVA: 0x0030632C File Offset: 0x0030452C
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

		// Token: 0x06014D8B RID: 85387 RVA: 0x00306335 File Offset: 0x00304535
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmActivityPb);
		}

		// Token: 0x06014D8C RID: 85388 RVA: 0x00306344 File Offset: 0x00304544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmActivityPb other)
		{
			return other != null && (other == this || (this.rhythmShipPlanetPb_.Equals(other.rhythmShipPlanetPb_) && this.RhythmRoleId == other.RhythmRoleId && this.rhythmTask_.Equals(other.rhythmTask_) && this.unlockedRole_.Equals(other.unlockedRole_) && object.Equals(this.RedDot, other.RedDot) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014D8D RID: 85389 RVA: 0x003063D4 File Offset: 0x003045D4
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

		// Token: 0x06014D8E RID: 85390 RVA: 0x00306453 File Offset: 0x00304653
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014D8F RID: 85391 RVA: 0x00306460 File Offset: 0x00304660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014D90 RID: 85392 RVA: 0x0030646C File Offset: 0x0030466C
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

		// Token: 0x06014D91 RID: 85393 RVA: 0x003064F8 File Offset: 0x003046F8
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

		// Token: 0x06014D92 RID: 85394 RVA: 0x00306588 File Offset: 0x00304788
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

		// Token: 0x06014D93 RID: 85395 RVA: 0x00306623 File Offset: 0x00304823
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014D94 RID: 85396 RVA: 0x0030662C File Offset: 0x0030482C
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

		// Token: 0x04007DC5 RID: 32197
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007DC6 RID: 32198
		public const int RhythmShipPlanetPbFieldNumber = 2;

		// Token: 0x04007DC7 RID: 32199
		private static readonly FieldCodec<RhythmShipPlanetPb> _repeated_rhythmShipPlanetPb_codec = FieldCodec.ForMessage<RhythmShipPlanetPb>(18U, Aki.Protocol.RhythmShipPlanetPb.Parser);

		// Token: 0x04007DC8 RID: 32200
		private readonly RepeatedField<RhythmShipPlanetPb> rhythmShipPlanetPb_ = new RepeatedField<RhythmShipPlanetPb>();

		// Token: 0x04007DC9 RID: 32201
		public const int RhythmRoleIdFieldNumber = 3;

		// Token: 0x04007DCA RID: 32202
		private int rhythmRoleId_;

		// Token: 0x04007DCB RID: 32203
		public const int RhythmTaskFieldNumber = 5;

		// Token: 0x04007DCC RID: 32204
		private static readonly FieldCodec<RhythmTaskPb> _repeated_rhythmTask_codec = FieldCodec.ForMessage<RhythmTaskPb>(42U, RhythmTaskPb.Parser);

		// Token: 0x04007DCD RID: 32205
		private readonly RepeatedField<RhythmTaskPb> rhythmTask_ = new RepeatedField<RhythmTaskPb>();

		// Token: 0x04007DCE RID: 32206
		public const int UnlockedRoleFieldNumber = 6;

		// Token: 0x04007DCF RID: 32207
		private static readonly FieldCodec<int> _repeated_unlockedRole_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04007DD0 RID: 32208
		private readonly RepeatedField<int> unlockedRole_ = new RepeatedField<int>();

		// Token: 0x04007DD1 RID: 32209
		public const int RedDotFieldNumber = 7;

		// Token: 0x04007DD2 RID: 32210
		private RhythmRedDotPb redDot_;
	}
}
