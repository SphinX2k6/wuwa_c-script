using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009B4 RID: 2484
	[NetMessage(EMessageId.MatchThreeEndResponse)]
	public sealed class MatchThreeEndResponse : IMessage<MatchThreeEndResponse>, IMessage, IEquatable<MatchThreeEndResponse>, IDeepCloneable<MatchThreeEndResponse>, IBufferMessage
	{
		// Token: 0x0600DA53 RID: 55891 RVA: 0x002017A4 File Offset: 0x001FF9A4
		[NullableContext(1)]
		public static MatchThreeEndResponse Create()
		{
			return new MatchThreeEndResponse();
		}

		// Token: 0x17002C3B RID: 11323
		// (get) Token: 0x0600DA54 RID: 55892 RVA: 0x002017AB File Offset: 0x001FF9AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C3C RID: 11324
		// (get) Token: 0x0600DA55 RID: 55893 RVA: 0x002017AE File Offset: 0x001FF9AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchThreeEndResponse.Descriptor;
			}
		}

		// Token: 0x0600DA56 RID: 55894 RVA: 0x002017B5 File Offset: 0x001FF9B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeEndResponse()
		{
		}

		// Token: 0x0600DA57 RID: 55895 RVA: 0x002017BD File Offset: 0x001FF9BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeEndResponse(MatchThreeEndResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.success_ = other.success_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DA58 RID: 55896 RVA: 0x002017EE File Offset: 0x001FF9EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeEndResponse Clone()
		{
			return new MatchThreeEndResponse(this);
		}

		// Token: 0x17002C3D RID: 11325
		// (get) Token: 0x0600DA59 RID: 55897 RVA: 0x002017F6 File Offset: 0x001FF9F6
		// (set) Token: 0x0600DA5A RID: 55898 RVA: 0x002017FE File Offset: 0x001FF9FE
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

		// Token: 0x17002C3E RID: 11326
		// (get) Token: 0x0600DA5B RID: 55899 RVA: 0x00201807 File Offset: 0x001FFA07
		// (set) Token: 0x0600DA5C RID: 55900 RVA: 0x0020180F File Offset: 0x001FFA0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Success
		{
			get
			{
				return this.success_;
			}
			set
			{
				this.success_ = value;
			}
		}

		// Token: 0x0600DA5D RID: 55901 RVA: 0x00201818 File Offset: 0x001FFA18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchThreeEndResponse);
		}

		// Token: 0x0600DA5E RID: 55902 RVA: 0x00201826 File Offset: 0x001FFA26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchThreeEndResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.Success == other.Success && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DA5F RID: 55903 RVA: 0x00201864 File Offset: 0x001FFA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.Success)
			{
				num ^= this.Success.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DA60 RID: 55904 RVA: 0x002018C2 File Offset: 0x001FFAC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DA61 RID: 55905 RVA: 0x002018CF File Offset: 0x001FFACF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DA62 RID: 55906 RVA: 0x002018D8 File Offset: 0x001FFAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.Success)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.Success);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DA63 RID: 55907 RVA: 0x00201934 File Offset: 0x001FFB34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.Success)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DA64 RID: 55908 RVA: 0x00201980 File Offset: 0x001FFB80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchThreeEndResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.Success)
			{
				this.Success = other.Success;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DA65 RID: 55909 RVA: 0x002019D0 File Offset: 0x001FFBD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DA66 RID: 55910 RVA: 0x002019DC File Offset: 0x001FFBDC
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
					if (num != 32U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Success = input.ReadBool();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005B19 RID: 23321
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B1A RID: 23322
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04005B1B RID: 23323
		private ErrorCode errorCode_;

		// Token: 0x04005B1C RID: 23324
		public const int SuccessFieldNumber = 4;

		// Token: 0x04005B1D RID: 23325
		private bool success_;
	}
}
