using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006ED RID: 1773
	[NetMessage(EMessageId.GmLevelActionResponse)]
	public sealed class GmLevelActionResponse : IMessage<GmLevelActionResponse>, IMessage, IEquatable<GmLevelActionResponse>, IDeepCloneable<GmLevelActionResponse>, IBufferMessage
	{
		// Token: 0x0600A1E2 RID: 41442 RVA: 0x00187BD9 File Offset: 0x00185DD9
		[NullableContext(1)]
		public static GmLevelActionResponse Create()
		{
			return new GmLevelActionResponse();
		}

		// Token: 0x17002084 RID: 8324
		// (get) Token: 0x0600A1E3 RID: 41443 RVA: 0x00187BE0 File Offset: 0x00185DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002085 RID: 8325
		// (get) Token: 0x0600A1E4 RID: 41444 RVA: 0x00187BE3 File Offset: 0x00185DE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GmLevelActionResponse.Descriptor;
			}
		}

		// Token: 0x0600A1E5 RID: 41445 RVA: 0x00187BEA File Offset: 0x00185DEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmLevelActionResponse()
		{
		}

		// Token: 0x0600A1E6 RID: 41446 RVA: 0x00187BF2 File Offset: 0x00185DF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmLevelActionResponse(GmLevelActionResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A1E7 RID: 41447 RVA: 0x00187C17 File Offset: 0x00185E17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmLevelActionResponse Clone()
		{
			return new GmLevelActionResponse(this);
		}

		// Token: 0x17002086 RID: 8326
		// (get) Token: 0x0600A1E8 RID: 41448 RVA: 0x00187C1F File Offset: 0x00185E1F
		// (set) Token: 0x0600A1E9 RID: 41449 RVA: 0x00187C27 File Offset: 0x00185E27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x0600A1EA RID: 41450 RVA: 0x00187C30 File Offset: 0x00185E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GmLevelActionResponse);
		}

		// Token: 0x0600A1EB RID: 41451 RVA: 0x00187C3E File Offset: 0x00185E3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GmLevelActionResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A1EC RID: 41452 RVA: 0x00187C6C File Offset: 0x00185E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A1ED RID: 41453 RVA: 0x00187CB1 File Offset: 0x00185EB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A1EE RID: 41454 RVA: 0x00187CBE File Offset: 0x00185EBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A1EF RID: 41455 RVA: 0x00187CC7 File Offset: 0x00185EC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A1F0 RID: 41456 RVA: 0x00187CFC File Offset: 0x00185EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A1F1 RID: 41457 RVA: 0x00187D3A File Offset: 0x00185F3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GmLevelActionResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A1F2 RID: 41458 RVA: 0x00187D6B File Offset: 0x00185F6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A1F3 RID: 41459 RVA: 0x00187D74 File Offset: 0x00185F74
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004B72 RID: 19314
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B73 RID: 19315
		public const int CodeFieldNumber = 7;

		// Token: 0x04004B74 RID: 19316
		private ErrorCode code_;
	}
}
