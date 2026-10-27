using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F21 RID: 3873
	public sealed class ReportTargetInfo : IMessage<ReportTargetInfo>, IMessage, IEquatable<ReportTargetInfo>, IDeepCloneable<ReportTargetInfo>, IBufferMessage
	{
		// Token: 0x06014BAA RID: 84906 RVA: 0x003021EC File Offset: 0x003003EC
		[NullableContext(1)]
		public static ReportTargetInfo Create()
		{
			return new ReportTargetInfo();
		}

		// Token: 0x170044E6 RID: 17638
		// (get) Token: 0x06014BAB RID: 84907 RVA: 0x003021F3 File Offset: 0x003003F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044E7 RID: 17639
		// (get) Token: 0x06014BAC RID: 84908 RVA: 0x003021F6 File Offset: 0x003003F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReportTargetInfo.Descriptor;
			}
		}

		// Token: 0x06014BAD RID: 84909 RVA: 0x003021FD File Offset: 0x003003FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReportTargetInfo()
		{
		}

		// Token: 0x06014BAE RID: 84910 RVA: 0x0030221B File Offset: 0x0030041B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReportTargetInfo(ReportTargetInfo other) : this()
		{
			this.name_ = other.name_;
			this.signature_ = other.signature_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014BAF RID: 84911 RVA: 0x0030224C File Offset: 0x0030044C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReportTargetInfo Clone()
		{
			return new ReportTargetInfo(this);
		}

		// Token: 0x170044E8 RID: 17640
		// (get) Token: 0x06014BB0 RID: 84912 RVA: 0x00302254 File Offset: 0x00300454
		// (set) Token: 0x06014BB1 RID: 84913 RVA: 0x0030225C File Offset: 0x0030045C
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

		// Token: 0x170044E9 RID: 17641
		// (get) Token: 0x06014BB2 RID: 84914 RVA: 0x0030226F File Offset: 0x0030046F
		// (set) Token: 0x06014BB3 RID: 84915 RVA: 0x00302277 File Offset: 0x00300477
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

		// Token: 0x06014BB4 RID: 84916 RVA: 0x0030228A File Offset: 0x0030048A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReportTargetInfo);
		}

		// Token: 0x06014BB5 RID: 84917 RVA: 0x00302298 File Offset: 0x00300498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReportTargetInfo other)
		{
			return other != null && (other == this || (!(this.Name != other.Name) && !(this.Signature != other.Signature) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014BB6 RID: 84918 RVA: 0x003022EC File Offset: 0x003004EC
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

		// Token: 0x06014BB7 RID: 84919 RVA: 0x00302348 File Offset: 0x00300548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014BB8 RID: 84920 RVA: 0x00302355 File Offset: 0x00300555
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014BB9 RID: 84921 RVA: 0x00302360 File Offset: 0x00300560
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

		// Token: 0x06014BBA RID: 84922 RVA: 0x003023C4 File Offset: 0x003005C4
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

		// Token: 0x06014BBB RID: 84923 RVA: 0x00302424 File Offset: 0x00300624
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

		// Token: 0x06014BBC RID: 84924 RVA: 0x0030247E File Offset: 0x0030067E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014BBD RID: 84925 RVA: 0x00302488 File Offset: 0x00300688
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

		// Token: 0x04007D3A RID: 32058
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D3B RID: 32059
		public const int NameFieldNumber = 1;

		// Token: 0x04007D3C RID: 32060
		private string name_ = "";

		// Token: 0x04007D3D RID: 32061
		public const int SignatureFieldNumber = 2;

		// Token: 0x04007D3E RID: 32062
		private string signature_ = "";
	}
}
