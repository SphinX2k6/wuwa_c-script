using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000118 RID: 280
	[NetMessage(EMessageId.ArtemisNodeUpdateResponse)]
	public sealed class ArtemisNodeUpdateResponse : IMessage<ArtemisNodeUpdateResponse>, IMessage, IEquatable<ArtemisNodeUpdateResponse>, IDeepCloneable<ArtemisNodeUpdateResponse>, IBufferMessage
	{
		// Token: 0x06002639 RID: 9785 RVA: 0x00065A68 File Offset: 0x00063C68
		[NullableContext(1)]
		public static ArtemisNodeUpdateResponse Create()
		{
			return new ArtemisNodeUpdateResponse();
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x0600263A RID: 9786 RVA: 0x00065A6F File Offset: 0x00063C6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x0600263B RID: 9787 RVA: 0x00065A72 File Offset: 0x00063C72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ArtemisNodeUpdateResponse.Descriptor;
			}
		}

		// Token: 0x0600263C RID: 9788 RVA: 0x00065A79 File Offset: 0x00063C79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArtemisNodeUpdateResponse()
		{
		}

		// Token: 0x0600263D RID: 9789 RVA: 0x00065A81 File Offset: 0x00063C81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArtemisNodeUpdateResponse(ArtemisNodeUpdateResponse other) : this()
		{
			this.error_ = other.error_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600263E RID: 9790 RVA: 0x00065AA6 File Offset: 0x00063CA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArtemisNodeUpdateResponse Clone()
		{
			return new ArtemisNodeUpdateResponse(this);
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x0600263F RID: 9791 RVA: 0x00065AAE File Offset: 0x00063CAE
		// (set) Token: 0x06002640 RID: 9792 RVA: 0x00065AB6 File Offset: 0x00063CB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Error
		{
			get
			{
				return this.error_;
			}
			set
			{
				this.error_ = value;
			}
		}

		// Token: 0x06002641 RID: 9793 RVA: 0x00065ABF File Offset: 0x00063CBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ArtemisNodeUpdateResponse);
		}

		// Token: 0x06002642 RID: 9794 RVA: 0x00065ACD File Offset: 0x00063CCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ArtemisNodeUpdateResponse other)
		{
			return other != null && (other == this || (this.Error == other.Error && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002643 RID: 9795 RVA: 0x00065AFC File Offset: 0x00063CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Error != ErrorCode.Success)
			{
				num ^= this.Error.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002644 RID: 9796 RVA: 0x00065B41 File Offset: 0x00063D41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002645 RID: 9797 RVA: 0x00065B4E File Offset: 0x00063D4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002646 RID: 9798 RVA: 0x00065B57 File Offset: 0x00063D57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Error != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.Error);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002647 RID: 9799 RVA: 0x00065B8C File Offset: 0x00063D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Error != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Error);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002648 RID: 9800 RVA: 0x00065BCA File Offset: 0x00063DCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ArtemisNodeUpdateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Error != ErrorCode.Success)
			{
				this.Error = other.Error;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002649 RID: 9801 RVA: 0x00065BFB File Offset: 0x00063DFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600264A RID: 9802 RVA: 0x00065C04 File Offset: 0x00063E04
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Error = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002606 RID: 9734
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002607 RID: 9735
		public const int ErrorFieldNumber = 7;

		// Token: 0x04002608 RID: 9736
		private ErrorCode error_;
	}
}
