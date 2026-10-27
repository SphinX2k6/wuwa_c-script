using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001275 RID: 4725
	[NetMessage(EMessageId.SpringFestivalAtmosphereRewardResponse)]
	public sealed class SpringFestivalAtmosphereRewardResponse : IMessage<SpringFestivalAtmosphereRewardResponse>, IMessage, IEquatable<SpringFestivalAtmosphereRewardResponse>, IDeepCloneable<SpringFestivalAtmosphereRewardResponse>, IBufferMessage
	{
		// Token: 0x060192C0 RID: 103104 RVA: 0x003A9B40 File Offset: 0x003A7D40
		[NullableContext(1)]
		public static SpringFestivalAtmosphereRewardResponse Create()
		{
			return new SpringFestivalAtmosphereRewardResponse();
		}

		// Token: 0x170054EF RID: 21743
		// (get) Token: 0x060192C1 RID: 103105 RVA: 0x003A9B47 File Offset: 0x003A7D47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170054F0 RID: 21744
		// (get) Token: 0x060192C2 RID: 103106 RVA: 0x003A9B4A File Offset: 0x003A7D4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringFestivalAtmosphereRewardResponse.Descriptor;
			}
		}

		// Token: 0x060192C3 RID: 103107 RVA: 0x003A9B51 File Offset: 0x003A7D51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalAtmosphereRewardResponse()
		{
		}

		// Token: 0x060192C4 RID: 103108 RVA: 0x003A9B59 File Offset: 0x003A7D59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalAtmosphereRewardResponse(SpringFestivalAtmosphereRewardResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060192C5 RID: 103109 RVA: 0x003A9B7E File Offset: 0x003A7D7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalAtmosphereRewardResponse Clone()
		{
			return new SpringFestivalAtmosphereRewardResponse(this);
		}

		// Token: 0x170054F1 RID: 21745
		// (get) Token: 0x060192C6 RID: 103110 RVA: 0x003A9B86 File Offset: 0x003A7D86
		// (set) Token: 0x060192C7 RID: 103111 RVA: 0x003A9B8E File Offset: 0x003A7D8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x060192C8 RID: 103112 RVA: 0x003A9B97 File Offset: 0x003A7D97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringFestivalAtmosphereRewardResponse);
		}

		// Token: 0x060192C9 RID: 103113 RVA: 0x003A9BA5 File Offset: 0x003A7DA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringFestivalAtmosphereRewardResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060192CA RID: 103114 RVA: 0x003A9BD4 File Offset: 0x003A7DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060192CB RID: 103115 RVA: 0x003A9C19 File Offset: 0x003A7E19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060192CC RID: 103116 RVA: 0x003A9C26 File Offset: 0x003A7E26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060192CD RID: 103117 RVA: 0x003A9C2F File Offset: 0x003A7E2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060192CE RID: 103118 RVA: 0x003A9C60 File Offset: 0x003A7E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060192CF RID: 103119 RVA: 0x003A9C9E File Offset: 0x003A7E9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpringFestivalAtmosphereRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060192D0 RID: 103120 RVA: 0x003A9CCF File Offset: 0x003A7ECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060192D1 RID: 103121 RVA: 0x003A9CD8 File Offset: 0x003A7ED8
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400943C RID: 37948
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400943D RID: 37949
		public const int ErrCodeFieldNumber = 1;

		// Token: 0x0400943E RID: 37950
		private ErrorCode errCode_;
	}
}
