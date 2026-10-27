using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000113 RID: 275
	public sealed class ArraySkillNode : IMessage<ArraySkillNode>, IMessage, IEquatable<ArraySkillNode>, IDeepCloneable<ArraySkillNode>, IBufferMessage
	{
		// Token: 0x060025CB RID: 9675 RVA: 0x00064A9B File Offset: 0x00062C9B
		[NullableContext(1)]
		public static ArraySkillNode Create()
		{
			return new ArraySkillNode();
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x060025CC RID: 9676 RVA: 0x00064AA2 File Offset: 0x00062CA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ArraySkillNode> Parser
		{
			get
			{
				return ArraySkillNode._parser;
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x060025CD RID: 9677 RVA: 0x00064AA9 File Offset: 0x00062CA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x060025CE RID: 9678 RVA: 0x00064AAC File Offset: 0x00062CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ArraySkillNode.Descriptor;
			}
		}

		// Token: 0x060025CF RID: 9679 RVA: 0x00064AB3 File Offset: 0x00062CB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArraySkillNode()
		{
		}

		// Token: 0x060025D0 RID: 9680 RVA: 0x00064ABB File Offset: 0x00062CBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArraySkillNode(ArraySkillNode other) : this()
		{
			this.skillNodeId_ = other.skillNodeId_;
			this.isActive_ = other.isActive_;
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060025D1 RID: 9681 RVA: 0x00064AF8 File Offset: 0x00062CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArraySkillNode Clone()
		{
			return new ArraySkillNode(this);
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x060025D2 RID: 9682 RVA: 0x00064B00 File Offset: 0x00062D00
		// (set) Token: 0x060025D3 RID: 9683 RVA: 0x00064B08 File Offset: 0x00062D08
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

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x060025D4 RID: 9684 RVA: 0x00064B11 File Offset: 0x00062D11
		// (set) Token: 0x060025D5 RID: 9685 RVA: 0x00064B19 File Offset: 0x00062D19
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

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x060025D6 RID: 9686 RVA: 0x00064B22 File Offset: 0x00062D22
		// (set) Token: 0x060025D7 RID: 9687 RVA: 0x00064B2A File Offset: 0x00062D2A
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

		// Token: 0x060025D8 RID: 9688 RVA: 0x00064B33 File Offset: 0x00062D33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ArraySkillNode);
		}

		// Token: 0x060025D9 RID: 9689 RVA: 0x00064B44 File Offset: 0x00062D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ArraySkillNode other)
		{
			return other != null && (other == this || (this.SkillNodeId == other.SkillNodeId && this.IsActive == other.IsActive && this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060025DA RID: 9690 RVA: 0x00064BA0 File Offset: 0x00062DA0
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

		// Token: 0x060025DB RID: 9691 RVA: 0x00064C11 File Offset: 0x00062E11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060025DC RID: 9692 RVA: 0x00064C1E File Offset: 0x00062E1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060025DD RID: 9693 RVA: 0x00064C28 File Offset: 0x00062E28
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

		// Token: 0x060025DE RID: 9694 RVA: 0x00064C9C File Offset: 0x00062E9C
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

		// Token: 0x060025DF RID: 9695 RVA: 0x00064D00 File Offset: 0x00062F00
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

		// Token: 0x060025E0 RID: 9696 RVA: 0x00064D64 File Offset: 0x00062F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060025E1 RID: 9697 RVA: 0x00064D70 File Offset: 0x00062F70
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

		// Token: 0x040025E4 RID: 9700
		private static readonly MessageParser<ArraySkillNode> _parser = new MessageParser<ArraySkillNode>(() => new ArraySkillNode());

		// Token: 0x040025E5 RID: 9701
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025E6 RID: 9702
		public const int SkillNodeIdFieldNumber = 1;

		// Token: 0x040025E7 RID: 9703
		private int skillNodeId_;

		// Token: 0x040025E8 RID: 9704
		public const int IsActiveFieldNumber = 2;

		// Token: 0x040025E9 RID: 9705
		private bool isActive_;

		// Token: 0x040025EA RID: 9706
		public const int SkillIdFieldNumber = 3;

		// Token: 0x040025EB RID: 9707
		private int skillId_;
	}
}
