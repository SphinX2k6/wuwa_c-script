using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000AE RID: 174
	public sealed class AddRoleView : IMessage<AddRoleView>, IMessage, IEquatable<AddRoleView>, IDeepCloneable<AddRoleView>, IBufferMessage
	{
		// Token: 0x06001D53 RID: 7507 RVA: 0x00050B15 File Offset: 0x0004ED15
		[NullableContext(1)]
		public static AddRoleView Create()
		{
			return new AddRoleView();
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06001D54 RID: 7508 RVA: 0x00050B1C File Offset: 0x0004ED1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06001D55 RID: 7509 RVA: 0x00050B1F File Offset: 0x0004ED1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddRoleView.Descriptor;
			}
		}

		// Token: 0x06001D56 RID: 7510 RVA: 0x00050B26 File Offset: 0x0004ED26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddRoleView()
		{
		}

		// Token: 0x06001D57 RID: 7511 RVA: 0x00050B30 File Offset: 0x0004ED30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddRoleView(AddRoleView other) : this()
		{
			this.oldRogueResRole_ = ((other.oldRogueResRole_ != null) ? other.oldRogueResRole_.Clone() : null);
			this.newRogueResRole_ = ((other.newRogueResRole_ != null) ? other.newRogueResRole_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001D58 RID: 7512 RVA: 0x00050B8C File Offset: 0x0004ED8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddRoleView Clone()
		{
			return new AddRoleView(this);
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06001D59 RID: 7513 RVA: 0x00050B94 File Offset: 0x0004ED94
		// (set) Token: 0x06001D5A RID: 7514 RVA: 0x00050B9C File Offset: 0x0004ED9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResRole OldRogueResRole
		{
			get
			{
				return this.oldRogueResRole_;
			}
			set
			{
				this.oldRogueResRole_ = value;
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06001D5B RID: 7515 RVA: 0x00050BA5 File Offset: 0x0004EDA5
		// (set) Token: 0x06001D5C RID: 7516 RVA: 0x00050BAD File Offset: 0x0004EDAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResRole NewRogueResRole
		{
			get
			{
				return this.newRogueResRole_;
			}
			set
			{
				this.newRogueResRole_ = value;
			}
		}

		// Token: 0x06001D5D RID: 7517 RVA: 0x00050BB6 File Offset: 0x0004EDB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddRoleView);
		}

		// Token: 0x06001D5E RID: 7518 RVA: 0x00050BC4 File Offset: 0x0004EDC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddRoleView other)
		{
			return other != null && (other == this || (object.Equals(this.OldRogueResRole, other.OldRogueResRole) && object.Equals(this.NewRogueResRole, other.NewRogueResRole) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001D5F RID: 7519 RVA: 0x00050C18 File Offset: 0x0004EE18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.oldRogueResRole_ != null)
			{
				num ^= this.OldRogueResRole.GetHashCode();
			}
			if (this.newRogueResRole_ != null)
			{
				num ^= this.NewRogueResRole.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001D60 RID: 7520 RVA: 0x00050C6A File Offset: 0x0004EE6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001D61 RID: 7521 RVA: 0x00050C77 File Offset: 0x0004EE77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001D62 RID: 7522 RVA: 0x00050C80 File Offset: 0x0004EE80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.oldRogueResRole_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.OldRogueResRole);
			}
			if (this.newRogueResRole_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.NewRogueResRole);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001D63 RID: 7523 RVA: 0x00050CDC File Offset: 0x0004EEDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.oldRogueResRole_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.OldRogueResRole);
			}
			if (this.newRogueResRole_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NewRogueResRole);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001D64 RID: 7524 RVA: 0x00050D34 File Offset: 0x0004EF34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AddRoleView other)
		{
			if (other == null)
			{
				return;
			}
			if (other.oldRogueResRole_ != null)
			{
				if (this.oldRogueResRole_ == null)
				{
					this.OldRogueResRole = new RogueResRole();
				}
				this.OldRogueResRole.MergeFrom(other.OldRogueResRole);
			}
			if (other.newRogueResRole_ != null)
			{
				if (this.newRogueResRole_ == null)
				{
					this.NewRogueResRole = new RogueResRole();
				}
				this.NewRogueResRole.MergeFrom(other.NewRogueResRole);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001D65 RID: 7525 RVA: 0x00050DB4 File Offset: 0x0004EFB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001D66 RID: 7526 RVA: 0x00050DC0 File Offset: 0x0004EFC0
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
				if (num != 10U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.newRogueResRole_ == null)
						{
							this.NewRogueResRole = new RogueResRole();
						}
						input.ReadMessage(this.NewRogueResRole);
					}
				}
				else
				{
					if (this.oldRogueResRole_ == null)
					{
						this.OldRogueResRole = new RogueResRole();
					}
					input.ReadMessage(this.OldRogueResRole);
				}
			}
		}

		// Token: 0x04002314 RID: 8980
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002315 RID: 8981
		public const int OldRogueResRoleFieldNumber = 1;

		// Token: 0x04002316 RID: 8982
		private RogueResRole oldRogueResRole_;

		// Token: 0x04002317 RID: 8983
		public const int NewRogueResRoleFieldNumber = 2;

		// Token: 0x04002318 RID: 8984
		private RogueResRole newRogueResRole_;
	}
}
