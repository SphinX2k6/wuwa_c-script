using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010B3 RID: 4275
	[NetMessage(EMessageId.RoleSkillNodeNotify)]
	public sealed class RoleSkillNodeNotify : IMessage<RoleSkillNodeNotify>, IMessage, IEquatable<RoleSkillNodeNotify>, IDeepCloneable<RoleSkillNodeNotify>, IBufferMessage
	{
		// Token: 0x06016D2C RID: 93484 RVA: 0x00350C81 File Offset: 0x0034EE81
		[NullableContext(1)]
		public static RoleSkillNodeNotify Create()
		{
			return new RoleSkillNodeNotify();
		}

		// Token: 0x17004C77 RID: 19575
		// (get) Token: 0x06016D2D RID: 93485 RVA: 0x00350C88 File Offset: 0x0034EE88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C78 RID: 19576
		// (get) Token: 0x06016D2E RID: 93486 RVA: 0x00350C8B File Offset: 0x0034EE8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkillNodeNotify.Descriptor;
			}
		}

		// Token: 0x06016D2F RID: 93487 RVA: 0x00350C92 File Offset: 0x0034EE92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillNodeNotify()
		{
		}

		// Token: 0x06016D30 RID: 93488 RVA: 0x00350CA5 File Offset: 0x0034EEA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillNodeNotify(RoleSkillNodeNotify other) : this()
		{
			this.roleId_ = other.roleId_;
			this.skillNodeState_ = other.skillNodeState_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016D31 RID: 93489 RVA: 0x00350CDB File Offset: 0x0034EEDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillNodeNotify Clone()
		{
			return new RoleSkillNodeNotify(this);
		}

		// Token: 0x17004C79 RID: 19577
		// (get) Token: 0x06016D32 RID: 93490 RVA: 0x00350CE3 File Offset: 0x0034EEE3
		// (set) Token: 0x06016D33 RID: 93491 RVA: 0x00350CEB File Offset: 0x0034EEEB
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

		// Token: 0x17004C7A RID: 19578
		// (get) Token: 0x06016D34 RID: 93492 RVA: 0x00350CF4 File Offset: 0x0034EEF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArraySkillNode> SkillNodeState
		{
			get
			{
				return this.skillNodeState_;
			}
		}

		// Token: 0x06016D35 RID: 93493 RVA: 0x00350CFC File Offset: 0x0034EEFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkillNodeNotify);
		}

		// Token: 0x06016D36 RID: 93494 RVA: 0x00350D0C File Offset: 0x0034EF0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkillNodeNotify other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.skillNodeState_.Equals(other.skillNodeState_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016D37 RID: 93495 RVA: 0x00350D5C File Offset: 0x0034EF5C
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

		// Token: 0x06016D38 RID: 93496 RVA: 0x00350DA9 File Offset: 0x0034EFA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016D39 RID: 93497 RVA: 0x00350DB6 File Offset: 0x0034EFB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016D3A RID: 93498 RVA: 0x00350DC0 File Offset: 0x0034EFC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.skillNodeState_.WriteTo(ref output, RoleSkillNodeNotify._repeated_skillNodeState_codec);
			if (this.RoleId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016D3B RID: 93499 RVA: 0x00350E10 File Offset: 0x0034F010
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

		// Token: 0x06016D3C RID: 93500 RVA: 0x00350E64 File Offset: 0x0034F064
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

		// Token: 0x06016D3D RID: 93501 RVA: 0x00350EB1 File Offset: 0x0034F0B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016D3E RID: 93502 RVA: 0x00350EBC File Offset: 0x0034F0BC
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
				if (num != 66U)
				{
					if (num != 104U)
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

		// Token: 0x0400882F RID: 34863
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008830 RID: 34864
		public const int RoleIdFieldNumber = 13;

		// Token: 0x04008831 RID: 34865
		private int roleId_;

		// Token: 0x04008832 RID: 34866
		public const int SkillNodeStateFieldNumber = 8;

		// Token: 0x04008833 RID: 34867
		private static readonly FieldCodec<ArraySkillNode> _repeated_skillNodeState_codec = FieldCodec.ForMessage<ArraySkillNode>(66U, ArraySkillNode.Parser);

		// Token: 0x04008834 RID: 34868
		private readonly RepeatedField<ArraySkillNode> skillNodeState_ = new RepeatedField<ArraySkillNode>();
	}
}
