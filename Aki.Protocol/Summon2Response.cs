using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200131A RID: 4890
	[NetMessage(EMessageId.Summon2Response)]
	public sealed class Summon2Response : IMessage<Summon2Response>, IMessage, IEquatable<Summon2Response>, IDeepCloneable<Summon2Response>, IBufferMessage
	{
		// Token: 0x0601A126 RID: 106790 RVA: 0x003CCC9A File Offset: 0x003CAE9A
		[NullableContext(1)]
		public static Summon2Response Create()
		{
			return new Summon2Response();
		}

		// Token: 0x17005846 RID: 22598
		// (get) Token: 0x0601A127 RID: 106791 RVA: 0x003CCCA1 File Offset: 0x003CAEA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005847 RID: 22599
		// (get) Token: 0x0601A128 RID: 106792 RVA: 0x003CCCA4 File Offset: 0x003CAEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Summon2Response.Descriptor;
			}
		}

		// Token: 0x0601A129 RID: 106793 RVA: 0x003CCCAB File Offset: 0x003CAEAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Summon2Response()
		{
		}

		// Token: 0x0601A12A RID: 106794 RVA: 0x003CCCB3 File Offset: 0x003CAEB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Summon2Response(Summon2Response other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.version_ = other.version_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A12B RID: 106795 RVA: 0x003CCCE4 File Offset: 0x003CAEE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Summon2Response Clone()
		{
			return new Summon2Response(this);
		}

		// Token: 0x17005848 RID: 22600
		// (get) Token: 0x0601A12C RID: 106796 RVA: 0x003CCCEC File Offset: 0x003CAEEC
		// (set) Token: 0x0601A12D RID: 106797 RVA: 0x003CCCF4 File Offset: 0x003CAEF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17005849 RID: 22601
		// (get) Token: 0x0601A12E RID: 106798 RVA: 0x003CCCFD File Offset: 0x003CAEFD
		// (set) Token: 0x0601A12F RID: 106799 RVA: 0x003CCD05 File Offset: 0x003CAF05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Version
		{
			get
			{
				return this.version_;
			}
			set
			{
				this.version_ = value;
			}
		}

		// Token: 0x0601A130 RID: 106800 RVA: 0x003CCD0E File Offset: 0x003CAF0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as Summon2Response);
		}

		// Token: 0x0601A131 RID: 106801 RVA: 0x003CCD1C File Offset: 0x003CAF1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Summon2Response other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.Version == other.Version && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A132 RID: 106802 RVA: 0x003CCD5C File Offset: 0x003CAF5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.Version != 0)
			{
				num ^= this.Version.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A133 RID: 106803 RVA: 0x003CCDBA File Offset: 0x003CAFBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A134 RID: 106804 RVA: 0x003CCDC7 File Offset: 0x003CAFC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A135 RID: 106805 RVA: 0x003CCDD0 File Offset: 0x003CAFD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Version != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Version);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A136 RID: 106806 RVA: 0x003CCE2C File Offset: 0x003CB02C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.Version != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Version);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A137 RID: 106807 RVA: 0x003CCE84 File Offset: 0x003CB084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Summon2Response other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.Version != 0)
			{
				this.Version = other.Version;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A138 RID: 106808 RVA: 0x003CCED4 File Offset: 0x003CB0D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A139 RID: 106809 RVA: 0x003CCEE0 File Offset: 0x003CB0E0
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
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.Version = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009978 RID: 39288
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009979 RID: 39289
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x0400997A RID: 39290
		private ErrorCode errorCode_;

		// Token: 0x0400997B RID: 39291
		public const int VersionFieldNumber = 2;

		// Token: 0x0400997C RID: 39292
		private int version_;
	}
}
