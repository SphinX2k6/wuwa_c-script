using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000AF RID: 175
	public sealed class AddRoleView : IMessage<AddRoleView>, IMessage, IEquatable<AddRoleView>, IDeepCloneable<AddRoleView>, IBufferMessage
	{
		// Token: 0x06001D9C RID: 7580 RVA: 0x000517C9 File Offset: 0x0004F9C9
		[NullableContext(1)]
		public static AddRoleView Create()
		{
			return new AddRoleView();
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06001D9D RID: 7581 RVA: 0x000517D0 File Offset: 0x0004F9D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06001D9E RID: 7582 RVA: 0x000517D3 File Offset: 0x0004F9D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddRoleView.Descriptor;
			}
		}

		// Token: 0x06001D9F RID: 7583 RVA: 0x000517DA File Offset: 0x0004F9DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddRoleView()
		{
		}

		// Token: 0x06001DA0 RID: 7584 RVA: 0x000517E4 File Offset: 0x0004F9E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddRoleView(AddRoleView other) : this()
		{
			this.oldRogueResRole_ = ((other.oldRogueResRole_ != null) ? other.oldRogueResRole_.Clone() : null);
			this.newRogueResRole_ = ((other.newRogueResRole_ != null) ? other.newRogueResRole_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001DA1 RID: 7585 RVA: 0x00051840 File Offset: 0x0004FA40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddRoleView Clone()
		{
			return new AddRoleView(this);
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06001DA2 RID: 7586 RVA: 0x00051848 File Offset: 0x0004FA48
		// (set) Token: 0x06001DA3 RID: 7587 RVA: 0x00051850 File Offset: 0x0004FA50
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

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06001DA4 RID: 7588 RVA: 0x00051859 File Offset: 0x0004FA59
		// (set) Token: 0x06001DA5 RID: 7589 RVA: 0x00051861 File Offset: 0x0004FA61
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

		// Token: 0x06001DA6 RID: 7590 RVA: 0x0005186A File Offset: 0x0004FA6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddRoleView);
		}

		// Token: 0x06001DA7 RID: 7591 RVA: 0x00051878 File Offset: 0x0004FA78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddRoleView other)
		{
			return other != null && (other == this || (object.Equals(this.OldRogueResRole, other.OldRogueResRole) && object.Equals(this.NewRogueResRole, other.NewRogueResRole) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001DA8 RID: 7592 RVA: 0x000518CC File Offset: 0x0004FACC
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

		// Token: 0x06001DA9 RID: 7593 RVA: 0x0005191E File Offset: 0x0004FB1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001DAA RID: 7594 RVA: 0x0005192B File Offset: 0x0004FB2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001DAB RID: 7595 RVA: 0x00051934 File Offset: 0x0004FB34
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

		// Token: 0x06001DAC RID: 7596 RVA: 0x00051990 File Offset: 0x0004FB90
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

		// Token: 0x06001DAD RID: 7597 RVA: 0x000519E8 File Offset: 0x0004FBE8
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

		// Token: 0x06001DAE RID: 7598 RVA: 0x00051A68 File Offset: 0x0004FC68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001DAF RID: 7599 RVA: 0x00051A74 File Offset: 0x0004FC74
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

		// Token: 0x04002377 RID: 9079
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002378 RID: 9080
		public const int OldRogueResRoleFieldNumber = 1;

		// Token: 0x04002379 RID: 9081
		private RogueResRole oldRogueResRole_;

		// Token: 0x0400237A RID: 9082
		public const int NewRogueResRoleFieldNumber = 2;

		// Token: 0x0400237B RID: 9083
		private RogueResRole newRogueResRole_;
	}
}
