using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001132 RID: 4402
	[NetMessage(EMessageId.RoverRogueChooseDataResultResponse)]
	public sealed class RoverRogueChooseDataResultResponse : IMessage<RoverRogueChooseDataResultResponse>, IMessage, IEquatable<RoverRogueChooseDataResultResponse>, IDeepCloneable<RoverRogueChooseDataResultResponse>, IBufferMessage
	{
		// Token: 0x06017848 RID: 96328 RVA: 0x0036BEE8 File Offset: 0x0036A0E8
		[NullableContext(1)]
		public static RoverRogueChooseDataResultResponse Create()
		{
			return new RoverRogueChooseDataResultResponse();
		}

		// Token: 0x17004F0B RID: 20235
		// (get) Token: 0x06017849 RID: 96329 RVA: 0x0036BEEF File Offset: 0x0036A0EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F0C RID: 20236
		// (get) Token: 0x0601784A RID: 96330 RVA: 0x0036BEF2 File Offset: 0x0036A0F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueChooseDataResultResponse.Descriptor;
			}
		}

		// Token: 0x0601784B RID: 96331 RVA: 0x0036BEF9 File Offset: 0x0036A0F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueChooseDataResultResponse()
		{
		}

		// Token: 0x0601784C RID: 96332 RVA: 0x0036BF01 File Offset: 0x0036A101
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueChooseDataResultResponse(RoverRogueChooseDataResultResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.isSelect_ = other.isSelect_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601784D RID: 96333 RVA: 0x0036BF32 File Offset: 0x0036A132
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueChooseDataResultResponse Clone()
		{
			return new RoverRogueChooseDataResultResponse(this);
		}

		// Token: 0x17004F0D RID: 20237
		// (get) Token: 0x0601784E RID: 96334 RVA: 0x0036BF3A File Offset: 0x0036A13A
		// (set) Token: 0x0601784F RID: 96335 RVA: 0x0036BF42 File Offset: 0x0036A142
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

		// Token: 0x17004F0E RID: 20238
		// (get) Token: 0x06017850 RID: 96336 RVA: 0x0036BF4B File Offset: 0x0036A14B
		// (set) Token: 0x06017851 RID: 96337 RVA: 0x0036BF53 File Offset: 0x0036A153
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSelect
		{
			get
			{
				return this.isSelect_;
			}
			set
			{
				this.isSelect_ = value;
			}
		}

		// Token: 0x06017852 RID: 96338 RVA: 0x0036BF5C File Offset: 0x0036A15C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueChooseDataResultResponse);
		}

		// Token: 0x06017853 RID: 96339 RVA: 0x0036BF6A File Offset: 0x0036A16A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueChooseDataResultResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.IsSelect == other.IsSelect && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017854 RID: 96340 RVA: 0x0036BFA8 File Offset: 0x0036A1A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.IsSelect)
			{
				num ^= this.IsSelect.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017855 RID: 96341 RVA: 0x0036C006 File Offset: 0x0036A206
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017856 RID: 96342 RVA: 0x0036C013 File Offset: 0x0036A213
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017857 RID: 96343 RVA: 0x0036C01C File Offset: 0x0036A21C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsSelect)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsSelect);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017858 RID: 96344 RVA: 0x0036C078 File Offset: 0x0036A278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.IsSelect)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017859 RID: 96345 RVA: 0x0036C0C4 File Offset: 0x0036A2C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueChooseDataResultResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.IsSelect)
			{
				this.IsSelect = other.IsSelect;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601785A RID: 96346 RVA: 0x0036C114 File Offset: 0x0036A314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601785B RID: 96347 RVA: 0x0036C120 File Offset: 0x0036A320
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
					if (num != 64U)
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
					this.IsSelect = input.ReadBool();
				}
			}
		}

		// Token: 0x04008C5C RID: 35932
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008C5D RID: 35933
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04008C5E RID: 35934
		private ErrorCode errorCode_;

		// Token: 0x04008C5F RID: 35935
		public const int IsSelectFieldNumber = 2;

		// Token: 0x04008C60 RID: 35936
		private bool isSelect_;
	}
}
