using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000115 RID: 277
	public sealed class ArraySkillNode : IMessage<ArraySkillNode>, IMessage, IEquatable<ArraySkillNode>, IDeepCloneable<ArraySkillNode>, IBufferMessage
	{
		// Token: 0x0600262A RID: 9770 RVA: 0x00065ABF File Offset: 0x00063CBF
		[NullableContext(1)]
		public static ArraySkillNode Create()
		{
			return new ArraySkillNode();
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x0600262B RID: 9771 RVA: 0x00065AC6 File Offset: 0x00063CC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ArraySkillNode> Parser
		{
			get
			{
				return ArraySkillNode._parser;
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x0600262C RID: 9772 RVA: 0x00065ACD File Offset: 0x00063CCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x0600262D RID: 9773 RVA: 0x00065AD0 File Offset: 0x00063CD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ArraySkillNode.Descriptor;
			}
		}

		// Token: 0x0600262E RID: 9774 RVA: 0x00065AD7 File Offset: 0x00063CD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArraySkillNode()
		{
		}

		// Token: 0x0600262F RID: 9775 RVA: 0x00065ADF File Offset: 0x00063CDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArraySkillNode(ArraySkillNode other) : this()
		{
			this.skillNodeId_ = other.skillNodeId_;
			this.isActive_ = other.isActive_;
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002630 RID: 9776 RVA: 0x00065B1C File Offset: 0x00063D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArraySkillNode Clone()
		{
			return new ArraySkillNode(this);
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06002631 RID: 9777 RVA: 0x00065B24 File Offset: 0x00063D24
		// (set) Token: 0x06002632 RID: 9778 RVA: 0x00065B2C File Offset: 0x00063D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillNodeId
		{
			get
			{
				return this.skillNodeId_;
			}
			set
			{
				this.skillNodeId_ = value;
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06002633 RID: 9779 RVA: 0x00065B35 File Offset: 0x00063D35
		// (set) Token: 0x06002634 RID: 9780 RVA: 0x00065B3D File Offset: 0x00063D3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsActive
		{
			get
			{
				return this.isActive_;
			}
			set
			{
				this.isActive_ = value;
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06002635 RID: 9781 RVA: 0x00065B46 File Offset: 0x00063D46
		// (set) Token: 0x06002636 RID: 9782 RVA: 0x00065B4E File Offset: 0x00063D4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x06002637 RID: 9783 RVA: 0x00065B57 File Offset: 0x00063D57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ArraySkillNode);
		}

		// Token: 0x06002638 RID: 9784 RVA: 0x00065B68 File Offset: 0x00063D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ArraySkillNode other)
		{
			return other != null && (other == this || (this.SkillNodeId == other.SkillNodeId && this.IsActive == other.IsActive && this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002639 RID: 9785 RVA: 0x00065BC4 File Offset: 0x00063DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkillNodeId != 0)
			{
				num ^= this.SkillNodeId.GetHashCode();
			}
			if (this.IsActive)
			{
				num ^= this.IsActive.GetHashCode();
			}
			if (this.SkillId != 0)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600263A RID: 9786 RVA: 0x00065C35 File Offset: 0x00063E35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600263B RID: 9787 RVA: 0x00065C42 File Offset: 0x00063E42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600263C RID: 9788 RVA: 0x00065C4C File Offset: 0x00063E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillNodeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SkillNodeId);
			}
			if (this.IsActive)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsActive);
			}
			if (this.SkillId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600263D RID: 9789 RVA: 0x00065CC0 File Offset: 0x00063EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkillNodeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillNodeId);
			}
			if (this.IsActive)
			{
				num += 2;
			}
			if (this.SkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600263E RID: 9790 RVA: 0x00065D24 File Offset: 0x00063F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ArraySkillNode other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillNodeId != 0)
			{
				this.SkillNodeId = other.SkillNodeId;
			}
			if (other.IsActive)
			{
				this.IsActive = other.IsActive;
			}
			if (other.SkillId != 0)
			{
				this.SkillId = other.SkillId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600263F RID: 9791 RVA: 0x00065D88 File Offset: 0x00063F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002640 RID: 9792 RVA: 0x00065D94 File Offset: 0x00063F94
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.SkillId = input.ReadInt32();
						}
					}
					else
					{
						this.IsActive = input.ReadBool();
					}
				}
				else
				{
					this.SkillNodeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400264F RID: 9807
		private static readonly MessageParser<ArraySkillNode> _parser = new MessageParser<ArraySkillNode>(() => new ArraySkillNode());

		// Token: 0x04002650 RID: 9808
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002651 RID: 9809
		public const int SkillNodeIdFieldNumber = 1;

		// Token: 0x04002652 RID: 9810
		private int skillNodeId_;

		// Token: 0x04002653 RID: 9811
		public const int IsActiveFieldNumber = 2;

		// Token: 0x04002654 RID: 9812
		private bool isActive_;

		// Token: 0x04002655 RID: 9813
		public const int SkillIdFieldNumber = 3;

		// Token: 0x04002656 RID: 9814
		private int skillId_;
	}
}
