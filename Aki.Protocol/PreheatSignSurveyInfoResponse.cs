using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DC2 RID: 3522
	[NetMessage(EMessageId.PreheatSignSurveyInfoResponse)]
	public sealed class PreheatSignSurveyInfoResponse : IMessage<PreheatSignSurveyInfoResponse>, IMessage, IEquatable<PreheatSignSurveyInfoResponse>, IDeepCloneable<PreheatSignSurveyInfoResponse>, IBufferMessage
	{
		// Token: 0x06012FD2 RID: 77778 RVA: 0x002C51ED File Offset: 0x002C33ED
		[NullableContext(1)]
		public static PreheatSignSurveyInfoResponse Create()
		{
			return new PreheatSignSurveyInfoResponse();
		}

		// Token: 0x17003F07 RID: 16135
		// (get) Token: 0x06012FD3 RID: 77779 RVA: 0x002C51F4 File Offset: 0x002C33F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F08 RID: 16136
		// (get) Token: 0x06012FD4 RID: 77780 RVA: 0x002C51F7 File Offset: 0x002C33F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PreheatSignSurveyInfoResponse.Descriptor;
			}
		}

		// Token: 0x06012FD5 RID: 77781 RVA: 0x002C51FE File Offset: 0x002C33FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreheatSignSurveyInfoResponse()
		{
		}

		// Token: 0x06012FD6 RID: 77782 RVA: 0x002C5208 File Offset: 0x002C3408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreheatSignSurveyInfoResponse(PreheatSignSurveyInfoResponse other) : this()
		{
			this.preheatSignSurveyInfo_ = ((other.preheatSignSurveyInfo_ != null) ? other.preheatSignSurveyInfo_.Clone() : null);
			this.error_ = other.error_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012FD7 RID: 77783 RVA: 0x002C5254 File Offset: 0x002C3454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreheatSignSurveyInfoResponse Clone()
		{
			return new PreheatSignSurveyInfoResponse(this);
		}

		// Token: 0x17003F09 RID: 16137
		// (get) Token: 0x06012FD8 RID: 77784 RVA: 0x002C525C File Offset: 0x002C345C
		// (set) Token: 0x06012FD9 RID: 77785 RVA: 0x002C5264 File Offset: 0x002C3464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreheatSignSurveyInfo PreheatSignSurveyInfo
		{
			get
			{
				return this.preheatSignSurveyInfo_;
			}
			set
			{
				this.preheatSignSurveyInfo_ = value;
			}
		}

		// Token: 0x17003F0A RID: 16138
		// (get) Token: 0x06012FDA RID: 77786 RVA: 0x002C526D File Offset: 0x002C346D
		// (set) Token: 0x06012FDB RID: 77787 RVA: 0x002C5275 File Offset: 0x002C3475
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Error
		{
			get
			{
				return this.error_;
			}
			set
			{
				this.error_ = value;
			}
		}

		// Token: 0x06012FDC RID: 77788 RVA: 0x002C527E File Offset: 0x002C347E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PreheatSignSurveyInfoResponse);
		}

		// Token: 0x06012FDD RID: 77789 RVA: 0x002C528C File Offset: 0x002C348C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PreheatSignSurveyInfoResponse other)
		{
			return other != null && (other == this || (object.Equals(this.PreheatSignSurveyInfo, other.PreheatSignSurveyInfo) && this.Error == other.Error && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012FDE RID: 77790 RVA: 0x002C52DC File Offset: 0x002C34DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.preheatSignSurveyInfo_ != null)
			{
				num ^= this.PreheatSignSurveyInfo.GetHashCode();
			}
			if (this.Error != ErrorCode.Success)
			{
				num ^= this.Error.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012FDF RID: 77791 RVA: 0x002C5337 File Offset: 0x002C3537
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012FE0 RID: 77792 RVA: 0x002C5344 File Offset: 0x002C3544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012FE1 RID: 77793 RVA: 0x002C5350 File Offset: 0x002C3550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Error != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Error);
			}
			if (this.preheatSignSurveyInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.PreheatSignSurveyInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012FE2 RID: 77794 RVA: 0x002C53A8 File Offset: 0x002C35A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.preheatSignSurveyInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PreheatSignSurveyInfo);
			}
			if (this.Error != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Error);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012FE3 RID: 77795 RVA: 0x002C5400 File Offset: 0x002C3600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PreheatSignSurveyInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.preheatSignSurveyInfo_ != null)
			{
				if (this.preheatSignSurveyInfo_ == null)
				{
					this.PreheatSignSurveyInfo = new PreheatSignSurveyInfo();
				}
				this.PreheatSignSurveyInfo.MergeFrom(other.PreheatSignSurveyInfo);
			}
			if (other.Error != ErrorCode.Success)
			{
				this.Error = other.Error;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012FE4 RID: 77796 RVA: 0x002C5468 File Offset: 0x002C3668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012FE5 RID: 77797 RVA: 0x002C5474 File Offset: 0x002C3674
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
				if (num != 8U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.preheatSignSurveyInfo_ == null)
						{
							this.PreheatSignSurveyInfo = new PreheatSignSurveyInfo();
						}
						input.ReadMessage(this.PreheatSignSurveyInfo);
					}
				}
				else
				{
					this.Error = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040075B6 RID: 30134
		private UnknownFieldSet _unknownFields;

		// Token: 0x040075B7 RID: 30135
		public const int PreheatSignSurveyInfoFieldNumber = 11;

		// Token: 0x040075B8 RID: 30136
		private PreheatSignSurveyInfo preheatSignSurveyInfo_;

		// Token: 0x040075B9 RID: 30137
		public const int ErrorFieldNumber = 1;

		// Token: 0x040075BA RID: 30138
		private ErrorCode error_;
	}
}
