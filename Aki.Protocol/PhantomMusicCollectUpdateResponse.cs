using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CD6 RID: 3286
	[NetMessage(EMessageId.PhantomMusicCollectUpdateResponse)]
	public sealed class PhantomMusicCollectUpdateResponse : IMessage<PhantomMusicCollectUpdateResponse>, IMessage, IEquatable<PhantomMusicCollectUpdateResponse>, IDeepCloneable<PhantomMusicCollectUpdateResponse>, IBufferMessage
	{
		// Token: 0x06011CDB RID: 72923 RVA: 0x0029B695 File Offset: 0x00299895
		[NullableContext(1)]
		public static PhantomMusicCollectUpdateResponse Create()
		{
			return new PhantomMusicCollectUpdateResponse();
		}

		// Token: 0x17003B01 RID: 15105
		// (get) Token: 0x06011CDC RID: 72924 RVA: 0x0029B69C File Offset: 0x0029989C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B02 RID: 15106
		// (get) Token: 0x06011CDD RID: 72925 RVA: 0x0029B69F File Offset: 0x0029989F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomMusicCollectUpdateResponse.Descriptor;
			}
		}

		// Token: 0x06011CDE RID: 72926 RVA: 0x0029B6A6 File Offset: 0x002998A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicCollectUpdateResponse()
		{
		}

		// Token: 0x06011CDF RID: 72927 RVA: 0x0029B6AE File Offset: 0x002998AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicCollectUpdateResponse(PhantomMusicCollectUpdateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011CE0 RID: 72928 RVA: 0x0029B6D3 File Offset: 0x002998D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicCollectUpdateResponse Clone()
		{
			return new PhantomMusicCollectUpdateResponse(this);
		}

		// Token: 0x17003B03 RID: 15107
		// (get) Token: 0x06011CE1 RID: 72929 RVA: 0x0029B6DB File Offset: 0x002998DB
		// (set) Token: 0x06011CE2 RID: 72930 RVA: 0x0029B6E3 File Offset: 0x002998E3
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

		// Token: 0x06011CE3 RID: 72931 RVA: 0x0029B6EC File Offset: 0x002998EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomMusicCollectUpdateResponse);
		}

		// Token: 0x06011CE4 RID: 72932 RVA: 0x0029B6FA File Offset: 0x002998FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomMusicCollectUpdateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011CE5 RID: 72933 RVA: 0x0029B728 File Offset: 0x00299928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011CE6 RID: 72934 RVA: 0x0029B76D File Offset: 0x0029996D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011CE7 RID: 72935 RVA: 0x0029B77A File Offset: 0x0029997A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011CE8 RID: 72936 RVA: 0x0029B783 File Offset: 0x00299983
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011CE9 RID: 72937 RVA: 0x0029B7B8 File Offset: 0x002999B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011CEA RID: 72938 RVA: 0x0029B7F6 File Offset: 0x002999F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomMusicCollectUpdateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011CEB RID: 72939 RVA: 0x0029B827 File Offset: 0x00299A27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011CEC RID: 72940 RVA: 0x0029B830 File Offset: 0x00299A30
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007042 RID: 28738
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007043 RID: 28739
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04007044 RID: 28740
		private ErrorCode errorCode_;
	}
}
