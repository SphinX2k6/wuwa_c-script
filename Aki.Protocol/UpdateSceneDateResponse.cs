using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200151D RID: 5405
	[NetMessage(EMessageId.UpdateSceneDateResponse)]
	public sealed class UpdateSceneDateResponse : IMessage<UpdateSceneDateResponse>, IMessage, IEquatable<UpdateSceneDateResponse>, IDeepCloneable<UpdateSceneDateResponse>, IBufferMessage
	{
		// Token: 0x0601CA28 RID: 117288 RVA: 0x00426431 File Offset: 0x00424631
		[NullableContext(1)]
		public static UpdateSceneDateResponse Create()
		{
			return new UpdateSceneDateResponse();
		}

		// Token: 0x170060DB RID: 24795
		// (get) Token: 0x0601CA29 RID: 117289 RVA: 0x00426438 File Offset: 0x00424638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170060DC RID: 24796
		// (get) Token: 0x0601CA2A RID: 117290 RVA: 0x0042643B File Offset: 0x0042463B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateSceneDateResponse.Descriptor;
			}
		}

		// Token: 0x0601CA2B RID: 117291 RVA: 0x00426442 File Offset: 0x00424642
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSceneDateResponse()
		{
		}

		// Token: 0x0601CA2C RID: 117292 RVA: 0x0042644A File Offset: 0x0042464A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSceneDateResponse(UpdateSceneDateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.currDate_ = other.currDate_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CA2D RID: 117293 RVA: 0x0042647B File Offset: 0x0042467B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSceneDateResponse Clone()
		{
			return new UpdateSceneDateResponse(this);
		}

		// Token: 0x170060DD RID: 24797
		// (get) Token: 0x0601CA2E RID: 117294 RVA: 0x00426483 File Offset: 0x00424683
		// (set) Token: 0x0601CA2F RID: 117295 RVA: 0x0042648B File Offset: 0x0042468B
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

		// Token: 0x170060DE RID: 24798
		// (get) Token: 0x0601CA30 RID: 117296 RVA: 0x00426494 File Offset: 0x00424694
		// (set) Token: 0x0601CA31 RID: 117297 RVA: 0x0042649C File Offset: 0x0042469C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurrDate
		{
			get
			{
				return this.currDate_;
			}
			set
			{
				this.currDate_ = value;
			}
		}

		// Token: 0x0601CA32 RID: 117298 RVA: 0x004264A5 File Offset: 0x004246A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateSceneDateResponse);
		}

		// Token: 0x0601CA33 RID: 117299 RVA: 0x004264B3 File Offset: 0x004246B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateSceneDateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.CurrDate == other.CurrDate && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CA34 RID: 117300 RVA: 0x004264F4 File Offset: 0x004246F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.CurrDate != 0U)
			{
				num ^= this.CurrDate.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CA35 RID: 117301 RVA: 0x00426552 File Offset: 0x00424752
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CA36 RID: 117302 RVA: 0x0042655F File Offset: 0x0042475F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CA37 RID: 117303 RVA: 0x00426568 File Offset: 0x00424768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurrDate != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.CurrDate);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CA38 RID: 117304 RVA: 0x004265C4 File Offset: 0x004247C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.CurrDate != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurrDate);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CA39 RID: 117305 RVA: 0x0042661C File Offset: 0x0042481C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateSceneDateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.CurrDate != 0U)
			{
				this.CurrDate = other.CurrDate;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CA3A RID: 117306 RVA: 0x0042666C File Offset: 0x0042486C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CA3B RID: 117307 RVA: 0x00426678 File Offset: 0x00424878
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
				if (num != 88U)
				{
					if (num != 96U)
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
					this.CurrDate = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400A4FA RID: 42234
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A4FB RID: 42235
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x0400A4FC RID: 42236
		private ErrorCode errorCode_;

		// Token: 0x0400A4FD RID: 42237
		public const int CurrDateFieldNumber = 11;

		// Token: 0x0400A4FE RID: 42238
		private uint currDate_;
	}
}
