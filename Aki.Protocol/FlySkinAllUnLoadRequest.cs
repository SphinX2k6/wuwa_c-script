using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200060C RID: 1548
	[NetMessage(EMessageId.FlySkinAllUnLoadRequest)]
	public sealed class FlySkinAllUnLoadRequest : IMessage<FlySkinAllUnLoadRequest>, IMessage, IEquatable<FlySkinAllUnLoadRequest>, IDeepCloneable<FlySkinAllUnLoadRequest>, IBufferMessage
	{
		// Token: 0x06008F1A RID: 36634 RVA: 0x0015AD11 File Offset: 0x00158F11
		[NullableContext(1)]
		public static FlySkinAllUnLoadRequest Create()
		{
			return new FlySkinAllUnLoadRequest();
		}

		// Token: 0x17001C69 RID: 7273
		// (get) Token: 0x06008F1B RID: 36635 RVA: 0x0015AD18 File Offset: 0x00158F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C6A RID: 7274
		// (get) Token: 0x06008F1C RID: 36636 RVA: 0x0015AD1B File Offset: 0x00158F1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlySkinAllUnLoadRequest.Descriptor;
			}
		}

		// Token: 0x06008F1D RID: 36637 RVA: 0x0015AD22 File Offset: 0x00158F22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinAllUnLoadRequest()
		{
		}

		// Token: 0x06008F1E RID: 36638 RVA: 0x0015AD2A File Offset: 0x00158F2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinAllUnLoadRequest(FlySkinAllUnLoadRequest other) : this()
		{
			this.skinType_ = other.skinType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008F1F RID: 36639 RVA: 0x0015AD4F File Offset: 0x00158F4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinAllUnLoadRequest Clone()
		{
			return new FlySkinAllUnLoadRequest(this);
		}

		// Token: 0x17001C6B RID: 7275
		// (get) Token: 0x06008F20 RID: 36640 RVA: 0x0015AD57 File Offset: 0x00158F57
		// (set) Token: 0x06008F21 RID: 36641 RVA: 0x0015AD5F File Offset: 0x00158F5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkinType
		{
			get
			{
				return this.skinType_;
			}
			set
			{
				this.skinType_ = value;
			}
		}

		// Token: 0x06008F22 RID: 36642 RVA: 0x0015AD68 File Offset: 0x00158F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlySkinAllUnLoadRequest);
		}

		// Token: 0x06008F23 RID: 36643 RVA: 0x0015AD76 File Offset: 0x00158F76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlySkinAllUnLoadRequest other)
		{
			return other != null && (other == this || (this.SkinType == other.SkinType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008F24 RID: 36644 RVA: 0x0015ADA4 File Offset: 0x00158FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkinType != 0)
			{
				num ^= this.SkinType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008F25 RID: 36645 RVA: 0x0015ADE3 File Offset: 0x00158FE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008F26 RID: 36646 RVA: 0x0015ADF0 File Offset: 0x00158FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008F27 RID: 36647 RVA: 0x0015ADF9 File Offset: 0x00158FF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkinType != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.SkinType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008F28 RID: 36648 RVA: 0x0015AE2C File Offset: 0x0015902C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkinType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkinType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008F29 RID: 36649 RVA: 0x0015AE6A File Offset: 0x0015906A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlySkinAllUnLoadRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkinType != 0)
			{
				this.SkinType = other.SkinType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008F2A RID: 36650 RVA: 0x0015AE9B File Offset: 0x0015909B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008F2B RID: 36651 RVA: 0x0015AEA4 File Offset: 0x001590A4
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SkinType = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004590 RID: 17808
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004591 RID: 17809
		public const int SkinTypeFieldNumber = 12;

		// Token: 0x04004592 RID: 17810
		private int skinType_;
	}
}
