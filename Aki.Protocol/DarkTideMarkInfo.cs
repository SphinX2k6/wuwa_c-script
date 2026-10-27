using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003AD RID: 941
	public sealed class DarkTideMarkInfo : IMessage<DarkTideMarkInfo>, IMessage, IEquatable<DarkTideMarkInfo>, IDeepCloneable<DarkTideMarkInfo>, IBufferMessage
	{
		// Token: 0x06005C71 RID: 23665 RVA: 0x000E091E File Offset: 0x000DEB1E
		[NullableContext(1)]
		public static DarkTideMarkInfo Create()
		{
			return new DarkTideMarkInfo();
		}

		// Token: 0x17001124 RID: 4388
		// (get) Token: 0x06005C72 RID: 23666 RVA: 0x000E0925 File Offset: 0x000DEB25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DarkTideMarkInfo> Parser
		{
			get
			{
				return DarkTideMarkInfo._parser;
			}
		}

		// Token: 0x17001125 RID: 4389
		// (get) Token: 0x06005C73 RID: 23667 RVA: 0x000E092C File Offset: 0x000DEB2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001126 RID: 4390
		// (get) Token: 0x06005C74 RID: 23668 RVA: 0x000E092F File Offset: 0x000DEB2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DarkTideMarkInfo.Descriptor;
			}
		}

		// Token: 0x06005C75 RID: 23669 RVA: 0x000E0936 File Offset: 0x000DEB36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideMarkInfo()
		{
		}

		// Token: 0x06005C76 RID: 23670 RVA: 0x000E094C File Offset: 0x000DEB4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideMarkInfo(DarkTideMarkInfo other) : this()
		{
			this.markId_ = other.markId_;
			this.markType_ = other.markType_;
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this.markState_ = other.markState_;
			this.ownerIds_ = other.ownerIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005C77 RID: 23671 RVA: 0x000E09C1 File Offset: 0x000DEBC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideMarkInfo Clone()
		{
			return new DarkTideMarkInfo(this);
		}

		// Token: 0x17001127 RID: 4391
		// (get) Token: 0x06005C78 RID: 23672 RVA: 0x000E09C9 File Offset: 0x000DEBC9
		// (set) Token: 0x06005C79 RID: 23673 RVA: 0x000E09D1 File Offset: 0x000DEBD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MarkId
		{
			get
			{
				return this.markId_;
			}
			set
			{
				this.markId_ = value;
			}
		}

		// Token: 0x17001128 RID: 4392
		// (get) Token: 0x06005C7A RID: 23674 RVA: 0x000E09DA File Offset: 0x000DEBDA
		// (set) Token: 0x06005C7B RID: 23675 RVA: 0x000E09E2 File Offset: 0x000DEBE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideMapMarkType MarkType
		{
			get
			{
				return this.markType_;
			}
			set
			{
				this.markType_ = value;
			}
		}

		// Token: 0x17001129 RID: 4393
		// (get) Token: 0x06005C7C RID: 23676 RVA: 0x000E09EB File Offset: 0x000DEBEB
		// (set) Token: 0x06005C7D RID: 23677 RVA: 0x000E09F3 File Offset: 0x000DEBF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Pos
		{
			get
			{
				return this.pos_;
			}
			set
			{
				this.pos_ = value;
			}
		}

		// Token: 0x1700112A RID: 4394
		// (get) Token: 0x06005C7E RID: 23678 RVA: 0x000E09FC File Offset: 0x000DEBFC
		// (set) Token: 0x06005C7F RID: 23679 RVA: 0x000E0A04 File Offset: 0x000DEC04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideMapMarkMarkState MarkState
		{
			get
			{
				return this.markState_;
			}
			set
			{
				this.markState_ = value;
			}
		}

		// Token: 0x1700112B RID: 4395
		// (get) Token: 0x06005C80 RID: 23680 RVA: 0x000E0A0D File Offset: 0x000DEC0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> OwnerIds
		{
			get
			{
				return this.ownerIds_;
			}
		}

		// Token: 0x06005C81 RID: 23681 RVA: 0x000E0A15 File Offset: 0x000DEC15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DarkTideMarkInfo);
		}

		// Token: 0x06005C82 RID: 23682 RVA: 0x000E0A24 File Offset: 0x000DEC24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DarkTideMarkInfo other)
		{
			return other != null && (other == this || (this.MarkId == other.MarkId && this.MarkType == other.MarkType && object.Equals(this.Pos, other.Pos) && this.MarkState == other.MarkState && this.ownerIds_.Equals(other.ownerIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005C83 RID: 23683 RVA: 0x000E0AA8 File Offset: 0x000DECA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MarkId != 0)
			{
				num ^= this.MarkId.GetHashCode();
			}
			if (this.MarkType != DarkTideMapMarkType.Player)
			{
				num ^= this.MarkType.GetHashCode();
			}
			if (this.pos_ != null)
			{
				num ^= this.Pos.GetHashCode();
			}
			if (this.MarkState != DarkTideMapMarkMarkState.DarkTideMapMarkNormal)
			{
				num ^= this.MarkState.GetHashCode();
			}
			num ^= this.ownerIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005C84 RID: 23684 RVA: 0x000E0B49 File Offset: 0x000DED49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005C85 RID: 23685 RVA: 0x000E0B56 File Offset: 0x000DED56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005C86 RID: 23686 RVA: 0x000E0B60 File Offset: 0x000DED60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MarkId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MarkId);
			}
			if (this.MarkType != DarkTideMapMarkType.Player)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.MarkType);
			}
			if (this.pos_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Pos);
			}
			if (this.MarkState != DarkTideMapMarkMarkState.DarkTideMapMarkNormal)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.MarkState);
			}
			this.ownerIds_.WriteTo(ref output, DarkTideMarkInfo._repeated_ownerIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005C87 RID: 23687 RVA: 0x000E0C04 File Offset: 0x000DEE04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MarkId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MarkId);
			}
			if (this.MarkType != DarkTideMapMarkType.Player)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.MarkType);
			}
			if (this.pos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Pos);
			}
			if (this.MarkState != DarkTideMapMarkMarkState.DarkTideMapMarkNormal)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.MarkState);
			}
			num += this.ownerIds_.CalculateSize(DarkTideMarkInfo._repeated_ownerIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005C88 RID: 23688 RVA: 0x000E0CA0 File Offset: 0x000DEEA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DarkTideMarkInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MarkId != 0)
			{
				this.MarkId = other.MarkId;
			}
			if (other.MarkType != DarkTideMapMarkType.Player)
			{
				this.MarkType = other.MarkType;
			}
			if (other.pos_ != null)
			{
				if (this.pos_ == null)
				{
					this.Pos = new Vector();
				}
				this.Pos.MergeFrom(other.Pos);
			}
			if (other.MarkState != DarkTideMapMarkMarkState.DarkTideMapMarkNormal)
			{
				this.MarkState = other.MarkState;
			}
			this.ownerIds_.Add(other.ownerIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005C89 RID: 23689 RVA: 0x000E0D41 File Offset: 0x000DEF41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005C8A RID: 23690 RVA: 0x000E0D4C File Offset: 0x000DEF4C
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
				if (num <= 26U)
				{
					if (num == 8U)
					{
						this.MarkId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.MarkType = (DarkTideMapMarkType)input.ReadEnum();
						continue;
					}
					if (num == 26U)
					{
						if (this.pos_ == null)
						{
							this.Pos = new Vector();
						}
						input.ReadMessage(this.Pos);
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.MarkState = (DarkTideMapMarkMarkState)input.ReadEnum();
						continue;
					}
					if (num == 40U || num == 42U)
					{
						this.ownerIds_.AddEntriesFrom(ref input, DarkTideMarkInfo._repeated_ownerIds_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003646 RID: 13894
		private static readonly MessageParser<DarkTideMarkInfo> _parser = new MessageParser<DarkTideMarkInfo>(() => new DarkTideMarkInfo());

		// Token: 0x04003647 RID: 13895
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003648 RID: 13896
		public const int MarkIdFieldNumber = 1;

		// Token: 0x04003649 RID: 13897
		private int markId_;

		// Token: 0x0400364A RID: 13898
		public const int MarkTypeFieldNumber = 2;

		// Token: 0x0400364B RID: 13899
		private DarkTideMapMarkType markType_;

		// Token: 0x0400364C RID: 13900
		public const int PosFieldNumber = 3;

		// Token: 0x0400364D RID: 13901
		private Vector pos_;

		// Token: 0x0400364E RID: 13902
		public const int MarkStateFieldNumber = 4;

		// Token: 0x0400364F RID: 13903
		private DarkTideMapMarkMarkState markState_;

		// Token: 0x04003650 RID: 13904
		public const int OwnerIdsFieldNumber = 5;

		// Token: 0x04003651 RID: 13905
		private static readonly FieldCodec<int> _repeated_ownerIds_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04003652 RID: 13906
		private readonly RepeatedField<int> ownerIds_ = new RepeatedField<int>();
	}
}
