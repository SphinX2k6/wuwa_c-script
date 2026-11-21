using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010A3 RID: 4259
	[NetMessage(EMessageId.RoleSkillNodeNotify)]
	public sealed class RoleSkillNodeNotify : IMessage<RoleSkillNodeNotify>, IMessage, IEquatable<RoleSkillNodeNotify>, IDeepCloneable<RoleSkillNodeNotify>, IBufferMessage
	{
		// Token: 0x06016C47 RID: 93255 RVA: 0x0034F5A5 File Offset: 0x0034D7A5
		[NullableContext(1)]
		public static RoleSkillNodeNotify Create()
		{
			return new RoleSkillNodeNotify();
		}

		// Token: 0x17004C4D RID: 19533
		// (get) Token: 0x06016C48 RID: 93256 RVA: 0x0034F5AC File Offset: 0x0034D7AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C4E RID: 19534
		// (get) Token: 0x06016C49 RID: 93257 RVA: 0x0034F5AF File Offset: 0x0034D7AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkillNodeNotify.Descriptor;
			}
		}

		// Token: 0x06016C4A RID: 93258 RVA: 0x0034F5B6 File Offset: 0x0034D7B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillNodeNotify()
		{
		}

		// Token: 0x06016C4B RID: 93259 RVA: 0x0034F5C9 File Offset: 0x0034D7C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillNodeNotify(RoleSkillNodeNotify other) : this()
		{
			this.roleId_ = other.roleId_;
			this.skillNodeState_ = other.skillNodeState_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016C4C RID: 93260 RVA: 0x0034F5FF File Offset: 0x0034D7FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillNodeNotify Clone()
		{
			return new RoleSkillNodeNotify(this);
		}

		// Token: 0x17004C4F RID: 19535
		// (get) Token: 0x06016C4D RID: 93261 RVA: 0x0034F607 File Offset: 0x0034D807
		// (set) Token: 0x06016C4E RID: 93262 RVA: 0x0034F60F File Offset: 0x0034D80F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x17004C50 RID: 19536
		// (get) Token: 0x06016C4F RID: 93263 RVA: 0x0034F618 File Offset: 0x0034D818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArraySkillNode> SkillNodeState
		{
			get
			{
				return this.skillNodeState_;
			}
		}

		// Token: 0x06016C50 RID: 93264 RVA: 0x0034F620 File Offset: 0x0034D820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkillNodeNotify);
		}

		// Token: 0x06016C51 RID: 93265 RVA: 0x0034F630 File Offset: 0x0034D830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkillNodeNotify other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.skillNodeState_.Equals(other.skillNodeState_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016C52 RID: 93266 RVA: 0x0034F680 File Offset: 0x0034D880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			num ^= this.skillNodeState_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016C53 RID: 93267 RVA: 0x0034F6CD File Offset: 0x0034D8CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016C54 RID: 93268 RVA: 0x0034F6DA File Offset: 0x0034D8DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016C55 RID: 93269 RVA: 0x0034F6E4 File Offset: 0x0034D8E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.skillNodeState_.WriteTo(ref output, RoleSkillNodeNotify._repeated_skillNodeState_codec);
			if (this.RoleId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016C56 RID: 93270 RVA: 0x0034F734 File Offset: 0x0034D934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			num += this.skillNodeState_.CalculateSize(RoleSkillNodeNotify._repeated_skillNodeState_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016C57 RID: 93271 RVA: 0x0034F788 File Offset: 0x0034D988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleSkillNodeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this.skillNodeState_.Add(other.skillNodeState_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016C58 RID: 93272 RVA: 0x0034F7D5 File Offset: 0x0034D9D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016C59 RID: 93273 RVA: 0x0034F7E0 File Offset: 0x0034D9E0
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
				if (num != 50U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RoleId = input.ReadInt32();
					}
				}
				else
				{
					this.skillNodeState_.AddEntriesFrom(ref input, RoleSkillNodeNotify._repeated_skillNodeState_codec);
				}
			}
		}

		// Token: 0x04008859 RID: 34905
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400885A RID: 34906
		public const int RoleIdFieldNumber = 11;

		// Token: 0x0400885B RID: 34907
		private int roleId_;

		// Token: 0x0400885C RID: 34908
		public const int SkillNodeStateFieldNumber = 6;

		// Token: 0x0400885D RID: 34909
		private static readonly FieldCodec<ArraySkillNode> _repeated_skillNodeState_codec = FieldCodec.ForMessage<ArraySkillNode>(50U, ArraySkillNode.Parser);

		// Token: 0x0400885E RID: 34910
		private readonly RepeatedField<ArraySkillNode> skillNodeState_ = new RepeatedField<ArraySkillNode>();
	}
}
