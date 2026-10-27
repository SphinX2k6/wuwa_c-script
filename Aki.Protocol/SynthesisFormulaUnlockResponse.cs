using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200130B RID: 4875
	[NetMessage(EMessageId.SynthesisFormulaUnlockResponse)]
	public sealed class SynthesisFormulaUnlockResponse : IMessage<SynthesisFormulaUnlockResponse>, IMessage, IEquatable<SynthesisFormulaUnlockResponse>, IDeepCloneable<SynthesisFormulaUnlockResponse>, IBufferMessage
	{
		// Token: 0x06019E8E RID: 106126 RVA: 0x003C3A64 File Offset: 0x003C1C64
		[NullableContext(1)]
		public static SynthesisFormulaUnlockResponse Create()
		{
			return new SynthesisFormulaUnlockResponse();
		}

		// Token: 0x1700575D RID: 22365
		// (get) Token: 0x06019E8F RID: 106127 RVA: 0x003C3A6B File Offset: 0x003C1C6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700575E RID: 22366
		// (get) Token: 0x06019E90 RID: 106128 RVA: 0x003C3A6E File Offset: 0x003C1C6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SynthesisFormulaUnlockResponse.Descriptor;
			}
		}

		// Token: 0x06019E91 RID: 106129 RVA: 0x003C3A75 File Offset: 0x003C1C75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisFormulaUnlockResponse()
		{
		}

		// Token: 0x06019E92 RID: 106130 RVA: 0x003C3A7D File Offset: 0x003C1C7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisFormulaUnlockResponse(SynthesisFormulaUnlockResponse other) : this()
		{
			this.code_ = other.code_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019E93 RID: 106131 RVA: 0x003C3AAE File Offset: 0x003C1CAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisFormulaUnlockResponse Clone()
		{
			return new SynthesisFormulaUnlockResponse(this);
		}

		// Token: 0x1700575F RID: 22367
		// (get) Token: 0x06019E94 RID: 106132 RVA: 0x003C3AB6 File Offset: 0x003C1CB6
		// (set) Token: 0x06019E95 RID: 106133 RVA: 0x003C3ABE File Offset: 0x003C1CBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x17005760 RID: 22368
		// (get) Token: 0x06019E96 RID: 106134 RVA: 0x003C3AC7 File Offset: 0x003C1CC7
		// (set) Token: 0x06019E97 RID: 106135 RVA: 0x003C3ACF File Offset: 0x003C1CCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x06019E98 RID: 106136 RVA: 0x003C3AD8 File Offset: 0x003C1CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SynthesisFormulaUnlockResponse);
		}

		// Token: 0x06019E99 RID: 106137 RVA: 0x003C3AE6 File Offset: 0x003C1CE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SynthesisFormulaUnlockResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019E9A RID: 106138 RVA: 0x003C3B24 File Offset: 0x003C1D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019E9B RID: 106139 RVA: 0x003C3B82 File Offset: 0x003C1D82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019E9C RID: 106140 RVA: 0x003C3B8F File Offset: 0x003C1D8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019E9D RID: 106141 RVA: 0x003C3B98 File Offset: 0x003C1D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Id);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019E9E RID: 106142 RVA: 0x003C3BF4 File Offset: 0x003C1DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019E9F RID: 106143 RVA: 0x003C3C4C File Offset: 0x003C1E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SynthesisFormulaUnlockResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019EA0 RID: 106144 RVA: 0x003C3C9C File Offset: 0x003C1E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019EA1 RID: 106145 RVA: 0x003C3CA8 File Offset: 0x003C1EA8
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
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Code = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400976D RID: 38765
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400976E RID: 38766
		public const int CodeFieldNumber = 14;

		// Token: 0x0400976F RID: 38767
		private ErrorCode code_;

		// Token: 0x04009770 RID: 38768
		public const int IdFieldNumber = 7;

		// Token: 0x04009771 RID: 38769
		private int id_;
	}
}
