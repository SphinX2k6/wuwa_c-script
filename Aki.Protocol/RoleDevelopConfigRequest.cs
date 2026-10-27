using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001064 RID: 4196
	[NetMessage(EMessageId.RoleDevelopConfigRequest)]
	public sealed class RoleDevelopConfigRequest : IMessage<RoleDevelopConfigRequest>, IMessage, IEquatable<RoleDevelopConfigRequest>, IDeepCloneable<RoleDevelopConfigRequest>, IBufferMessage
	{
		// Token: 0x060166AB RID: 91819 RVA: 0x00341D73 File Offset: 0x0033FF73
		[NullableContext(1)]
		public static RoleDevelopConfigRequest Create()
		{
			return new RoleDevelopConfigRequest();
		}

		// Token: 0x17004AFF RID: 19199
		// (get) Token: 0x060166AC RID: 91820 RVA: 0x00341D7A File Offset: 0x0033FF7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B00 RID: 19200
		// (get) Token: 0x060166AD RID: 91821 RVA: 0x00341D7D File Offset: 0x0033FF7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleDevelopConfigRequest.Descriptor;
			}
		}

		// Token: 0x060166AE RID: 91822 RVA: 0x00341D84 File Offset: 0x0033FF84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleDevelopConfigRequest()
		{
		}

		// Token: 0x060166AF RID: 91823 RVA: 0x00341D8C File Offset: 0x0033FF8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleDevelopConfigRequest(RoleDevelopConfigRequest other) : this()
		{
			this.version_ = other.version_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060166B0 RID: 91824 RVA: 0x00341DB1 File Offset: 0x0033FFB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleDevelopConfigRequest Clone()
		{
			return new RoleDevelopConfigRequest(this);
		}

		// Token: 0x17004B01 RID: 19201
		// (get) Token: 0x060166B1 RID: 91825 RVA: 0x00341DB9 File Offset: 0x0033FFB9
		// (set) Token: 0x060166B2 RID: 91826 RVA: 0x00341DCA File Offset: 0x0033FFCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Version
		{
			get
			{
				return this.version_ ?? RoleDevelopConfigRequest.VersionDefaultValue;
			}
			set
			{
				this.version_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17004B02 RID: 19202
		// (get) Token: 0x060166B3 RID: 91827 RVA: 0x00341DDD File Offset: 0x0033FFDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasVersion
		{
			get
			{
				return this.version_ != null;
			}
		}

		// Token: 0x060166B4 RID: 91828 RVA: 0x00341DE8 File Offset: 0x0033FFE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearVersion()
		{
			this.version_ = null;
		}

		// Token: 0x060166B5 RID: 91829 RVA: 0x00341DF1 File Offset: 0x0033FFF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleDevelopConfigRequest);
		}

		// Token: 0x060166B6 RID: 91830 RVA: 0x00341DFF File Offset: 0x0033FFFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleDevelopConfigRequest other)
		{
			return other != null && (other == this || (!(this.Version != other.Version) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060166B7 RID: 91831 RVA: 0x00341E34 File Offset: 0x00340034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HasVersion)
			{
				num ^= this.Version.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060166B8 RID: 91832 RVA: 0x00341E70 File Offset: 0x00340070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060166B9 RID: 91833 RVA: 0x00341E7D File Offset: 0x0034007D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060166BA RID: 91834 RVA: 0x00341E86 File Offset: 0x00340086
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasVersion)
			{
				output.WriteRawTag(74);
				output.WriteString(this.Version);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060166BB RID: 91835 RVA: 0x00341EB8 File Offset: 0x003400B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HasVersion)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Version);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060166BC RID: 91836 RVA: 0x00341EF6 File Offset: 0x003400F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleDevelopConfigRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HasVersion)
			{
				this.Version = other.Version;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060166BD RID: 91837 RVA: 0x00341F27 File Offset: 0x00340127
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060166BE RID: 91838 RVA: 0x00341F30 File Offset: 0x00340130
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
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Version = input.ReadString();
				}
			}
		}

		// Token: 0x04008607 RID: 34311
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008608 RID: 34312
		public const int VersionFieldNumber = 9;

		// Token: 0x04008609 RID: 34313
		private static readonly string VersionDefaultValue = "";

		// Token: 0x0400860A RID: 34314
		private string version_;
	}
}
