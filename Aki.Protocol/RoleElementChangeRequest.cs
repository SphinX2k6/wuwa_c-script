using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200105A RID: 4186
	[NetMessage(EMessageId.RoleElementChangeRequest)]
	public sealed class RoleElementChangeRequest : IMessage<RoleElementChangeRequest>, IMessage, IEquatable<RoleElementChangeRequest>, IDeepCloneable<RoleElementChangeRequest>, IBufferMessage
	{
		// Token: 0x06016667 RID: 91751 RVA: 0x003425AB File Offset: 0x003407AB
		[NullableContext(1)]
		public static RoleElementChangeRequest Create()
		{
			return new RoleElementChangeRequest();
		}

		// Token: 0x17004B04 RID: 19204
		// (get) Token: 0x06016668 RID: 91752 RVA: 0x003425B2 File Offset: 0x003407B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B05 RID: 19205
		// (get) Token: 0x06016669 RID: 91753 RVA: 0x003425B5 File Offset: 0x003407B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleElementChangeRequest.Descriptor;
			}
		}

		// Token: 0x0601666A RID: 91754 RVA: 0x003425BC File Offset: 0x003407BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleElementChangeRequest()
		{
		}

		// Token: 0x0601666B RID: 91755 RVA: 0x003425C4 File Offset: 0x003407C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleElementChangeRequest(RoleElementChangeRequest other) : this()
		{
			this.elementType_ = other.elementType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601666C RID: 91756 RVA: 0x003425E9 File Offset: 0x003407E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleElementChangeRequest Clone()
		{
			return new RoleElementChangeRequest(this);
		}

		// Token: 0x17004B06 RID: 19206
		// (get) Token: 0x0601666D RID: 91757 RVA: 0x003425F1 File Offset: 0x003407F1
		// (set) Token: 0x0601666E RID: 91758 RVA: 0x003425F9 File Offset: 0x003407F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ElementType
		{
			get
			{
				return this.elementType_;
			}
			set
			{
				this.elementType_ = value;
			}
		}

		// Token: 0x0601666F RID: 91759 RVA: 0x00342602 File Offset: 0x00340802
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleElementChangeRequest);
		}

		// Token: 0x06016670 RID: 91760 RVA: 0x00342610 File Offset: 0x00340810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleElementChangeRequest other)
		{
			return other != null && (other == this || (this.ElementType == other.ElementType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016671 RID: 91761 RVA: 0x00342640 File Offset: 0x00340840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ElementType != 0)
			{
				num ^= this.ElementType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016672 RID: 91762 RVA: 0x0034267F File Offset: 0x0034087F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016673 RID: 91763 RVA: 0x0034268C File Offset: 0x0034088C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016674 RID: 91764 RVA: 0x00342695 File Offset: 0x00340895
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ElementType != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ElementType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016675 RID: 91765 RVA: 0x003426C8 File Offset: 0x003408C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ElementType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ElementType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016676 RID: 91766 RVA: 0x00342706 File Offset: 0x00340906
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleElementChangeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ElementType != 0)
			{
				this.ElementType = other.ElementType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016677 RID: 91767 RVA: 0x00342737 File Offset: 0x00340937
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016678 RID: 91768 RVA: 0x00342740 File Offset: 0x00340940
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ElementType = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008681 RID: 34433
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008682 RID: 34434
		public const int ElementTypeFieldNumber = 2;

		// Token: 0x04008683 RID: 34435
		private int elementType_;
	}
}
