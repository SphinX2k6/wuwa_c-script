using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008D2 RID: 2258
	[NetMessage(EMessageId.LandingDamageResponse)]
	public sealed class LandingDamageResponse : IMessage<LandingDamageResponse>, IMessage, IEquatable<LandingDamageResponse>, IDeepCloneable<LandingDamageResponse>, IBufferMessage
	{
		// Token: 0x0600C838 RID: 51256 RVA: 0x001D9CD3 File Offset: 0x001D7ED3
		[NullableContext(1)]
		public static LandingDamageResponse Create()
		{
			return new LandingDamageResponse();
		}

		// Token: 0x1700286D RID: 10349
		// (get) Token: 0x0600C839 RID: 51257 RVA: 0x001D9CDA File Offset: 0x001D7EDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700286E RID: 10350
		// (get) Token: 0x0600C83A RID: 51258 RVA: 0x001D9CDD File Offset: 0x001D7EDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LandingDamageResponse.Descriptor;
			}
		}

		// Token: 0x0600C83B RID: 51259 RVA: 0x001D9CE4 File Offset: 0x001D7EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LandingDamageResponse()
		{
		}

		// Token: 0x0600C83C RID: 51260 RVA: 0x001D9CEC File Offset: 0x001D7EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LandingDamageResponse(LandingDamageResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C83D RID: 51261 RVA: 0x001D9D11 File Offset: 0x001D7F11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LandingDamageResponse Clone()
		{
			return new LandingDamageResponse(this);
		}

		// Token: 0x1700286F RID: 10351
		// (get) Token: 0x0600C83E RID: 51262 RVA: 0x001D9D19 File Offset: 0x001D7F19
		// (set) Token: 0x0600C83F RID: 51263 RVA: 0x001D9D21 File Offset: 0x001D7F21
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

		// Token: 0x0600C840 RID: 51264 RVA: 0x001D9D2A File Offset: 0x001D7F2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LandingDamageResponse);
		}

		// Token: 0x0600C841 RID: 51265 RVA: 0x001D9D38 File Offset: 0x001D7F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LandingDamageResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C842 RID: 51266 RVA: 0x001D9D68 File Offset: 0x001D7F68
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

		// Token: 0x0600C843 RID: 51267 RVA: 0x001D9DAD File Offset: 0x001D7FAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C844 RID: 51268 RVA: 0x001D9DBA File Offset: 0x001D7FBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C845 RID: 51269 RVA: 0x001D9DC3 File Offset: 0x001D7FC3
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

		// Token: 0x0600C846 RID: 51270 RVA: 0x001D9DF8 File Offset: 0x001D7FF8
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

		// Token: 0x0600C847 RID: 51271 RVA: 0x001D9E36 File Offset: 0x001D8036
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LandingDamageResponse other)
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

		// Token: 0x0600C848 RID: 51272 RVA: 0x001D9E67 File Offset: 0x001D8067
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C849 RID: 51273 RVA: 0x001D9E70 File Offset: 0x001D8070
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

		// Token: 0x040055F2 RID: 22002
		private UnknownFieldSet _unknownFields;

		// Token: 0x040055F3 RID: 22003
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x040055F4 RID: 22004
		private ErrorCode errorCode_;
	}
}
