using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F11 RID: 3857
	public sealed class ReportTargetInfo : IMessage<ReportTargetInfo>, IMessage, IEquatable<ReportTargetInfo>, IDeepCloneable<ReportTargetInfo>, IBufferMessage
	{
		// Token: 0x06014AC5 RID: 84677 RVA: 0x00300B30 File Offset: 0x002FED30
		[NullableContext(1)]
		public static ReportTargetInfo Create()
		{
			return new ReportTargetInfo();
		}

		// Token: 0x170044BC RID: 17596
		// (get) Token: 0x06014AC6 RID: 84678 RVA: 0x00300B37 File Offset: 0x002FED37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044BD RID: 17597
		// (get) Token: 0x06014AC7 RID: 84679 RVA: 0x00300B3A File Offset: 0x002FED3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReportTargetInfo.Descriptor;
			}
		}

		// Token: 0x06014AC8 RID: 84680 RVA: 0x00300B41 File Offset: 0x002FED41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReportTargetInfo()
		{
		}

		// Token: 0x06014AC9 RID: 84681 RVA: 0x00300B5F File Offset: 0x002FED5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReportTargetInfo(ReportTargetInfo other) : this()
		{
			this.name_ = other.name_;
			this.signature_ = other.signature_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014ACA RID: 84682 RVA: 0x00300B90 File Offset: 0x002FED90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReportTargetInfo Clone()
		{
			return new ReportTargetInfo(this);
		}

		// Token: 0x170044BE RID: 17598
		// (get) Token: 0x06014ACB RID: 84683 RVA: 0x00300B98 File Offset: 0x002FED98
		// (set) Token: 0x06014ACC RID: 84684 RVA: 0x00300BA0 File Offset: 0x002FEDA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170044BF RID: 17599
		// (get) Token: 0x06014ACD RID: 84685 RVA: 0x00300BB3 File Offset: 0x002FEDB3
		// (set) Token: 0x06014ACE RID: 84686 RVA: 0x00300BBB File Offset: 0x002FEDBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Signature
		{
			get
			{
				return this.signature_;
			}
			set
			{
				this.signature_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06014ACF RID: 84687 RVA: 0x00300BCE File Offset: 0x002FEDCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReportTargetInfo);
		}

		// Token: 0x06014AD0 RID: 84688 RVA: 0x00300BDC File Offset: 0x002FEDDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReportTargetInfo other)
		{
			return other != null && (other == this || (!(this.Name != other.Name) && !(this.Signature != other.Signature) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014AD1 RID: 84689 RVA: 0x00300C30 File Offset: 0x002FEE30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.Signature.Length != 0)
			{
				num ^= this.Signature.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014AD2 RID: 84690 RVA: 0x00300C8C File Offset: 0x002FEE8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014AD3 RID: 84691 RVA: 0x00300C99 File Offset: 0x002FEE99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014AD4 RID: 84692 RVA: 0x00300CA4 File Offset: 0x002FEEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Name);
			}
			if (this.Signature.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Signature);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014AD5 RID: 84693 RVA: 0x00300D08 File Offset: 0x002FEF08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this.Signature.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Signature);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014AD6 RID: 84694 RVA: 0x00300D68 File Offset: 0x002FEF68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ReportTargetInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.Signature.Length != 0)
			{
				this.Signature = other.Signature;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014AD7 RID: 84695 RVA: 0x00300DC2 File Offset: 0x002FEFC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014AD8 RID: 84696 RVA: 0x00300DCC File Offset: 0x002FEFCC
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
						this.Signature = input.ReadString();
					}
				}
				else
				{
					this.Name = input.ReadString();
				}
			}
		}

		// Token: 0x04007D64 RID: 32100
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D65 RID: 32101
		public const int NameFieldNumber = 1;

		// Token: 0x04007D66 RID: 32102
		private string name_ = "";

		// Token: 0x04007D67 RID: 32103
		public const int SignatureFieldNumber = 2;

		// Token: 0x04007D68 RID: 32104
		private string signature_ = "";
	}
}
