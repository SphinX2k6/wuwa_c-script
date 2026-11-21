using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012BD RID: 4797
	[NetMessage(EMessageId.SolarSchoolReachEndingResponse)]
	public sealed class SolarSchoolReachEndingResponse : IMessage<SolarSchoolReachEndingResponse>, IMessage, IEquatable<SolarSchoolReachEndingResponse>, IDeepCloneable<SolarSchoolReachEndingResponse>, IBufferMessage
	{
		// Token: 0x060199A2 RID: 104866 RVA: 0x003BBF01 File Offset: 0x003BA101
		[NullableContext(1)]
		public static SolarSchoolReachEndingResponse Create()
		{
			return new SolarSchoolReachEndingResponse();
		}

		// Token: 0x170056A9 RID: 22185
		// (get) Token: 0x060199A3 RID: 104867 RVA: 0x003BBF08 File Offset: 0x003BA108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170056AA RID: 22186
		// (get) Token: 0x060199A4 RID: 104868 RVA: 0x003BBF0B File Offset: 0x003BA10B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolReachEndingResponse.Descriptor;
			}
		}

		// Token: 0x060199A5 RID: 104869 RVA: 0x003BBF12 File Offset: 0x003BA112
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolReachEndingResponse()
		{
		}

		// Token: 0x060199A6 RID: 104870 RVA: 0x003BBF1A File Offset: 0x003BA11A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolReachEndingResponse(SolarSchoolReachEndingResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060199A7 RID: 104871 RVA: 0x003BBF3F File Offset: 0x003BA13F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolReachEndingResponse Clone()
		{
			return new SolarSchoolReachEndingResponse(this);
		}

		// Token: 0x170056AB RID: 22187
		// (get) Token: 0x060199A8 RID: 104872 RVA: 0x003BBF47 File Offset: 0x003BA147
		// (set) Token: 0x060199A9 RID: 104873 RVA: 0x003BBF4F File Offset: 0x003BA14F
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

		// Token: 0x060199AA RID: 104874 RVA: 0x003BBF58 File Offset: 0x003BA158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolReachEndingResponse);
		}

		// Token: 0x060199AB RID: 104875 RVA: 0x003BBF66 File Offset: 0x003BA166
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolReachEndingResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060199AC RID: 104876 RVA: 0x003BBF94 File Offset: 0x003BA194
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

		// Token: 0x060199AD RID: 104877 RVA: 0x003BBFD9 File Offset: 0x003BA1D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060199AE RID: 104878 RVA: 0x003BBFE6 File Offset: 0x003BA1E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060199AF RID: 104879 RVA: 0x003BBFEF File Offset: 0x003BA1EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060199B0 RID: 104880 RVA: 0x003BC024 File Offset: 0x003BA224
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

		// Token: 0x060199B1 RID: 104881 RVA: 0x003BC062 File Offset: 0x003BA262
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolReachEndingResponse other)
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

		// Token: 0x060199B2 RID: 104882 RVA: 0x003BC093 File Offset: 0x003BA293
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060199B3 RID: 104883 RVA: 0x003BC09C File Offset: 0x003BA29C
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400973F RID: 38719
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009740 RID: 38720
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04009741 RID: 38721
		private ErrorCode errorCode_;
	}
}
