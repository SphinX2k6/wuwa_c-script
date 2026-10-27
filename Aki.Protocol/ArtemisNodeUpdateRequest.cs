using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000117 RID: 279
	[NetMessage(EMessageId.ArtemisNodeUpdateRequest)]
	public sealed class ArtemisNodeUpdateRequest : IMessage<ArtemisNodeUpdateRequest>, IMessage, IEquatable<ArtemisNodeUpdateRequest>, IDeepCloneable<ArtemisNodeUpdateRequest>, IBufferMessage
	{
		// Token: 0x06002625 RID: 9765 RVA: 0x000657CF File Offset: 0x000639CF
		[NullableContext(1)]
		public static ArtemisNodeUpdateRequest Create()
		{
			return new ArtemisNodeUpdateRequest();
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06002626 RID: 9766 RVA: 0x000657D6 File Offset: 0x000639D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06002627 RID: 9767 RVA: 0x000657D9 File Offset: 0x000639D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ArtemisNodeUpdateRequest.Descriptor;
			}
		}

		// Token: 0x06002628 RID: 9768 RVA: 0x000657E0 File Offset: 0x000639E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArtemisNodeUpdateRequest()
		{
		}

		// Token: 0x06002629 RID: 9769 RVA: 0x000657E8 File Offset: 0x000639E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArtemisNodeUpdateRequest(ArtemisNodeUpdateRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600262A RID: 9770 RVA: 0x00065819 File Offset: 0x00063A19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArtemisNodeUpdateRequest Clone()
		{
			return new ArtemisNodeUpdateRequest(this);
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x0600262B RID: 9771 RVA: 0x00065821 File Offset: 0x00063A21
		// (set) Token: 0x0600262C RID: 9772 RVA: 0x00065829 File Offset: 0x00063A29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x0600262D RID: 9773 RVA: 0x00065832 File Offset: 0x00063A32
		// (set) Token: 0x0600262E RID: 9774 RVA: 0x0006583A File Offset: 0x00063A3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x0600262F RID: 9775 RVA: 0x00065843 File Offset: 0x00063A43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ArtemisNodeUpdateRequest);
		}

		// Token: 0x06002630 RID: 9776 RVA: 0x00065851 File Offset: 0x00063A51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ArtemisNodeUpdateRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002631 RID: 9777 RVA: 0x00065890 File Offset: 0x00063A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002632 RID: 9778 RVA: 0x000658E8 File Offset: 0x00063AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002633 RID: 9779 RVA: 0x000658F5 File Offset: 0x00063AF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002634 RID: 9780 RVA: 0x00065900 File Offset: 0x00063B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Index);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002635 RID: 9781 RVA: 0x0006595C File Offset: 0x00063B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002636 RID: 9782 RVA: 0x000659B4 File Offset: 0x00063BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ArtemisNodeUpdateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002637 RID: 9783 RVA: 0x00065A04 File Offset: 0x00063C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002638 RID: 9784 RVA: 0x00065A10 File Offset: 0x00063C10
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
				if (num != 24U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.Index = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002601 RID: 9729
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002602 RID: 9730
		public const int ActivityIdFieldNumber = 11;

		// Token: 0x04002603 RID: 9731
		private int activityId_;

		// Token: 0x04002604 RID: 9732
		public const int IndexFieldNumber = 3;

		// Token: 0x04002605 RID: 9733
		private int index_;
	}
}
