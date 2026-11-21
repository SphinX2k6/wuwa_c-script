using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001582 RID: 5506
	[NetMessage(EMessageId.WeeklyFrameworkInfoResponse)]
	public sealed class WeeklyFrameworkInfoResponse : IMessage<WeeklyFrameworkInfoResponse>, IMessage, IEquatable<WeeklyFrameworkInfoResponse>, IDeepCloneable<WeeklyFrameworkInfoResponse>, IBufferMessage
	{
		// Token: 0x0601D26A RID: 119402 RVA: 0x004389B6 File Offset: 0x00436BB6
		[NullableContext(1)]
		public static WeeklyFrameworkInfoResponse Create()
		{
			return new WeeklyFrameworkInfoResponse();
		}

		// Token: 0x170062A1 RID: 25249
		// (get) Token: 0x0601D26B RID: 119403 RVA: 0x004389BD File Offset: 0x00436BBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170062A2 RID: 25250
		// (get) Token: 0x0601D26C RID: 119404 RVA: 0x004389C0 File Offset: 0x00436BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeeklyFrameworkInfoResponse.Descriptor;
			}
		}

		// Token: 0x0601D26D RID: 119405 RVA: 0x004389C7 File Offset: 0x00436BC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyFrameworkInfoResponse()
		{
		}

		// Token: 0x0601D26E RID: 119406 RVA: 0x004389D0 File Offset: 0x00436BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyFrameworkInfoResponse(WeeklyFrameworkInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.frameworkInfo_ = ((other.frameworkInfo_ != null) ? other.frameworkInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D26F RID: 119407 RVA: 0x00438A1C File Offset: 0x00436C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyFrameworkInfoResponse Clone()
		{
			return new WeeklyFrameworkInfoResponse(this);
		}

		// Token: 0x170062A3 RID: 25251
		// (get) Token: 0x0601D270 RID: 119408 RVA: 0x00438A24 File Offset: 0x00436C24
		// (set) Token: 0x0601D271 RID: 119409 RVA: 0x00438A2C File Offset: 0x00436C2C
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

		// Token: 0x170062A4 RID: 25252
		// (get) Token: 0x0601D272 RID: 119410 RVA: 0x00438A35 File Offset: 0x00436C35
		// (set) Token: 0x0601D273 RID: 119411 RVA: 0x00438A3D File Offset: 0x00436C3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyFrameworkInfo FrameworkInfo
		{
			get
			{
				return this.frameworkInfo_;
			}
			set
			{
				this.frameworkInfo_ = value;
			}
		}

		// Token: 0x0601D274 RID: 119412 RVA: 0x00438A46 File Offset: 0x00436C46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeeklyFrameworkInfoResponse);
		}

		// Token: 0x0601D275 RID: 119413 RVA: 0x00438A54 File Offset: 0x00436C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeeklyFrameworkInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.FrameworkInfo, other.FrameworkInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D276 RID: 119414 RVA: 0x00438AA4 File Offset: 0x00436CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.frameworkInfo_ != null)
			{
				num ^= this.FrameworkInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D277 RID: 119415 RVA: 0x00438AFF File Offset: 0x00436CFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D278 RID: 119416 RVA: 0x00438B0C File Offset: 0x00436D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D279 RID: 119417 RVA: 0x00438B18 File Offset: 0x00436D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.frameworkInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.FrameworkInfo);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D27A RID: 119418 RVA: 0x00438B74 File Offset: 0x00436D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.frameworkInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FrameworkInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D27B RID: 119419 RVA: 0x00438BCC File Offset: 0x00436DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeeklyFrameworkInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.frameworkInfo_ != null)
			{
				if (this.frameworkInfo_ == null)
				{
					this.FrameworkInfo = new WeeklyFrameworkInfo();
				}
				this.FrameworkInfo.MergeFrom(other.FrameworkInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D27C RID: 119420 RVA: 0x00438C34 File Offset: 0x00436E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D27D RID: 119421 RVA: 0x00438C40 File Offset: 0x00436E40
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
				if (num != 18U)
				{
					if (num != 48U)
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
					if (this.frameworkInfo_ == null)
					{
						this.FrameworkInfo = new WeeklyFrameworkInfo();
					}
					input.ReadMessage(this.FrameworkInfo);
				}
			}
		}

		// Token: 0x0400A759 RID: 42841
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A75A RID: 42842
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x0400A75B RID: 42843
		private ErrorCode errorCode_;

		// Token: 0x0400A75C RID: 42844
		public const int FrameworkInfoFieldNumber = 2;

		// Token: 0x0400A75D RID: 42845
		private WeeklyFrameworkInfo frameworkInfo_;
	}
}
