using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000243 RID: 579
	[NetMessage(EMessageId.CertificateLevelRewardResponse)]
	public sealed class CertificateLevelRewardResponse : IMessage<CertificateLevelRewardResponse>, IMessage, IEquatable<CertificateLevelRewardResponse>, IDeepCloneable<CertificateLevelRewardResponse>, IBufferMessage
	{
		// Token: 0x06003E1D RID: 15901 RVA: 0x000996CA File Offset: 0x000978CA
		[NullableContext(1)]
		public static CertificateLevelRewardResponse Create()
		{
			return new CertificateLevelRewardResponse();
		}

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x06003E1E RID: 15902 RVA: 0x000996D1 File Offset: 0x000978D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x06003E1F RID: 15903 RVA: 0x000996D4 File Offset: 0x000978D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CertificateLevelRewardResponse.Descriptor;
			}
		}

		// Token: 0x06003E20 RID: 15904 RVA: 0x000996DB File Offset: 0x000978DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CertificateLevelRewardResponse()
		{
		}

		// Token: 0x06003E21 RID: 15905 RVA: 0x000996E3 File Offset: 0x000978E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CertificateLevelRewardResponse(CertificateLevelRewardResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003E22 RID: 15906 RVA: 0x00099708 File Offset: 0x00097908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CertificateLevelRewardResponse Clone()
		{
			return new CertificateLevelRewardResponse(this);
		}

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x06003E23 RID: 15907 RVA: 0x00099710 File Offset: 0x00097910
		// (set) Token: 0x06003E24 RID: 15908 RVA: 0x00099718 File Offset: 0x00097918
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

		// Token: 0x06003E25 RID: 15909 RVA: 0x00099721 File Offset: 0x00097921
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CertificateLevelRewardResponse);
		}

		// Token: 0x06003E26 RID: 15910 RVA: 0x0009972F File Offset: 0x0009792F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CertificateLevelRewardResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003E27 RID: 15911 RVA: 0x00099760 File Offset: 0x00097960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003E28 RID: 15912 RVA: 0x000997A5 File Offset: 0x000979A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003E29 RID: 15913 RVA: 0x000997B2 File Offset: 0x000979B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003E2A RID: 15914 RVA: 0x000997BB File Offset: 0x000979BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003E2B RID: 15915 RVA: 0x000997F0 File Offset: 0x000979F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003E2C RID: 15916 RVA: 0x0009982E File Offset: 0x00097A2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CertificateLevelRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003E2D RID: 15917 RVA: 0x0009985F File Offset: 0x00097A5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003E2E RID: 15918 RVA: 0x00099868 File Offset: 0x00097A68
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002CCD RID: 11469
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CCE RID: 11470
		public const int CodeFieldNumber = 9;

		// Token: 0x04002CCF RID: 11471
		private ErrorCode code_;
	}
}
