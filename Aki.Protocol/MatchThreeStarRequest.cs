using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009B6 RID: 2486
	[NetMessage(EMessageId.MatchThreeStarRequest)]
	public sealed class MatchThreeStarRequest : IMessage<MatchThreeStarRequest>, IMessage, IEquatable<MatchThreeStarRequest>, IDeepCloneable<MatchThreeStarRequest>, IBufferMessage
	{
		// Token: 0x0600DA85 RID: 55941 RVA: 0x00201EB4 File Offset: 0x002000B4
		[NullableContext(1)]
		public static MatchThreeStarRequest Create()
		{
			return new MatchThreeStarRequest();
		}

		// Token: 0x17002C48 RID: 11336
		// (get) Token: 0x0600DA86 RID: 55942 RVA: 0x00201EBB File Offset: 0x002000BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C49 RID: 11337
		// (get) Token: 0x0600DA87 RID: 55943 RVA: 0x00201EBE File Offset: 0x002000BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchThreeStarRequest.Descriptor;
			}
		}

		// Token: 0x0600DA88 RID: 55944 RVA: 0x00201EC5 File Offset: 0x002000C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeStarRequest()
		{
		}

		// Token: 0x0600DA89 RID: 55945 RVA: 0x00201ECD File Offset: 0x002000CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeStarRequest(MatchThreeStarRequest other) : this()
		{
			this.levelId_ = other.levelId_;
			this.joinRole_ = other.joinRole_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DA8A RID: 55946 RVA: 0x00201EFE File Offset: 0x002000FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeStarRequest Clone()
		{
			return new MatchThreeStarRequest(this);
		}

		// Token: 0x17002C4A RID: 11338
		// (get) Token: 0x0600DA8B RID: 55947 RVA: 0x00201F06 File Offset: 0x00200106
		// (set) Token: 0x0600DA8C RID: 55948 RVA: 0x00201F0E File Offset: 0x0020010E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x17002C4B RID: 11339
		// (get) Token: 0x0600DA8D RID: 55949 RVA: 0x00201F17 File Offset: 0x00200117
		// (set) Token: 0x0600DA8E RID: 55950 RVA: 0x00201F1F File Offset: 0x0020011F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int JoinRole
		{
			get
			{
				return this.joinRole_;
			}
			set
			{
				this.joinRole_ = value;
			}
		}

		// Token: 0x0600DA8F RID: 55951 RVA: 0x00201F28 File Offset: 0x00200128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchThreeStarRequest);
		}

		// Token: 0x0600DA90 RID: 55952 RVA: 0x00201F36 File Offset: 0x00200136
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchThreeStarRequest other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.JoinRole == other.JoinRole && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DA91 RID: 55953 RVA: 0x00201F74 File Offset: 0x00200174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this.JoinRole != 0)
			{
				num ^= this.JoinRole.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DA92 RID: 55954 RVA: 0x00201FCC File Offset: 0x002001CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DA93 RID: 55955 RVA: 0x00201FD9 File Offset: 0x002001D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DA94 RID: 55956 RVA: 0x00201FE4 File Offset: 0x002001E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.LevelId);
			}
			if (this.JoinRole != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.JoinRole);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DA95 RID: 55957 RVA: 0x00202040 File Offset: 0x00200240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			if (this.JoinRole != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.JoinRole);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DA96 RID: 55958 RVA: 0x00202098 File Offset: 0x00200298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchThreeStarRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			if (other.JoinRole != 0)
			{
				this.JoinRole = other.JoinRole;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DA97 RID: 55959 RVA: 0x002020E8 File Offset: 0x002002E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DA98 RID: 55960 RVA: 0x002020F4 File Offset: 0x002002F4
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
				if (num != 32U)
				{
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.JoinRole = input.ReadInt32();
					}
				}
				else
				{
					this.LevelId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005B29 RID: 23337
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B2A RID: 23338
		public const int LevelIdFieldNumber = 4;

		// Token: 0x04005B2B RID: 23339
		private int levelId_;

		// Token: 0x04005B2C RID: 23340
		public const int JoinRoleFieldNumber = 6;

		// Token: 0x04005B2D RID: 23341
		private int joinRole_;
	}
}
