using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DD2 RID: 3538
	[NetMessage(EMessageId.PreheatSignSurveyInfoResponse)]
	public sealed class PreheatSignSurveyInfoResponse : IMessage<PreheatSignSurveyInfoResponse>, IMessage, IEquatable<PreheatSignSurveyInfoResponse>, IDeepCloneable<PreheatSignSurveyInfoResponse>, IBufferMessage
	{
		// Token: 0x060130B7 RID: 78007 RVA: 0x002C68AD File Offset: 0x002C4AAD
		[NullableContext(1)]
		public static PreheatSignSurveyInfoResponse Create()
		{
			return new PreheatSignSurveyInfoResponse();
		}

		// Token: 0x17003F31 RID: 16177
		// (get) Token: 0x060130B8 RID: 78008 RVA: 0x002C68B4 File Offset: 0x002C4AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F32 RID: 16178
		// (get) Token: 0x060130B9 RID: 78009 RVA: 0x002C68B7 File Offset: 0x002C4AB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PreheatSignSurveyInfoResponse.Descriptor;
			}
		}

		// Token: 0x060130BA RID: 78010 RVA: 0x002C68BE File Offset: 0x002C4ABE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreheatSignSurveyInfoResponse()
		{
		}

		// Token: 0x060130BB RID: 78011 RVA: 0x002C68C8 File Offset: 0x002C4AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreheatSignSurveyInfoResponse(PreheatSignSurveyInfoResponse other) : this()
		{
			this.preheatSignSurveyInfo_ = ((other.preheatSignSurveyInfo_ != null) ? other.preheatSignSurveyInfo_.Clone() : null);
			this.error_ = other.error_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060130BC RID: 78012 RVA: 0x002C6914 File Offset: 0x002C4B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreheatSignSurveyInfoResponse Clone()
		{
			return new PreheatSignSurveyInfoResponse(this);
		}

		// Token: 0x17003F33 RID: 16179
		// (get) Token: 0x060130BD RID: 78013 RVA: 0x002C691C File Offset: 0x002C4B1C
		// (set) Token: 0x060130BE RID: 78014 RVA: 0x002C6924 File Offset: 0x002C4B24
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

		// Token: 0x17003F34 RID: 16180
		// (get) Token: 0x060130BF RID: 78015 RVA: 0x002C692D File Offset: 0x002C4B2D
		// (set) Token: 0x060130C0 RID: 78016 RVA: 0x002C6935 File Offset: 0x002C4B35
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

		// Token: 0x060130C1 RID: 78017 RVA: 0x002C693E File Offset: 0x002C4B3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PreheatSignSurveyInfoResponse);
		}

		// Token: 0x060130C2 RID: 78018 RVA: 0x002C694C File Offset: 0x002C4B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PreheatSignSurveyInfoResponse other)
		{
			return other != null && (other == this || (object.Equals(this.PreheatSignSurveyInfo, other.PreheatSignSurveyInfo) && this.Error == other.Error && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060130C3 RID: 78019 RVA: 0x002C699C File Offset: 0x002C4B9C
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

		// Token: 0x060130C4 RID: 78020 RVA: 0x002C69F7 File Offset: 0x002C4BF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060130C5 RID: 78021 RVA: 0x002C6A04 File Offset: 0x002C4C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060130C6 RID: 78022 RVA: 0x002C6A10 File Offset: 0x002C4C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.preheatSignSurveyInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.PreheatSignSurveyInfo);
			}
			if (this.Error != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.Error);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060130C7 RID: 78023 RVA: 0x002C6A6C File Offset: 0x002C4C6C
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

		// Token: 0x060130C8 RID: 78024 RVA: 0x002C6AC4 File Offset: 0x002C4CC4
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

		// Token: 0x060130C9 RID: 78025 RVA: 0x002C6B2C File Offset: 0x002C4D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060130CA RID: 78026 RVA: 0x002C6B38 File Offset: 0x002C4D38
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
				if (num != 26U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Error = (ErrorCode)input.ReadEnum();
					}
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
		}

		// Token: 0x0400758C RID: 30092
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400758D RID: 30093
		public const int PreheatSignSurveyInfoFieldNumber = 3;

		// Token: 0x0400758E RID: 30094
		private PreheatSignSurveyInfo preheatSignSurveyInfo_;

		// Token: 0x0400758F RID: 30095
		public const int ErrorFieldNumber = 10;

		// Token: 0x04007590 RID: 30096
		private ErrorCode error_;
	}
}
