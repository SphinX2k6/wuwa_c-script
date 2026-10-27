using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F91 RID: 3985
	[NetMessage(EMessageId.RoguelikeBossInstStartResponse)]
	public sealed class RoguelikeBossInstStartResponse : IMessage<RoguelikeBossInstStartResponse>, IMessage, IEquatable<RoguelikeBossInstStartResponse>, IDeepCloneable<RoguelikeBossInstStartResponse>, IBufferMessage
	{
		// Token: 0x060154FC RID: 87292 RVA: 0x00317984 File Offset: 0x00315B84
		[NullableContext(1)]
		public static RoguelikeBossInstStartResponse Create()
		{
			return new RoguelikeBossInstStartResponse();
		}

		// Token: 0x17004700 RID: 18176
		// (get) Token: 0x060154FD RID: 87293 RVA: 0x0031798B File Offset: 0x00315B8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004701 RID: 18177
		// (get) Token: 0x060154FE RID: 87294 RVA: 0x0031798E File Offset: 0x00315B8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeBossInstStartResponse.Descriptor;
			}
		}

		// Token: 0x060154FF RID: 87295 RVA: 0x00317995 File Offset: 0x00315B95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeBossInstStartResponse()
		{
		}

		// Token: 0x06015500 RID: 87296 RVA: 0x0031799D File Offset: 0x00315B9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeBossInstStartResponse(RoguelikeBossInstStartResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015501 RID: 87297 RVA: 0x003179C2 File Offset: 0x00315BC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeBossInstStartResponse Clone()
		{
			return new RoguelikeBossInstStartResponse(this);
		}

		// Token: 0x17004702 RID: 18178
		// (get) Token: 0x06015502 RID: 87298 RVA: 0x003179CA File Offset: 0x00315BCA
		// (set) Token: 0x06015503 RID: 87299 RVA: 0x003179D2 File Offset: 0x00315BD2
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

		// Token: 0x06015504 RID: 87300 RVA: 0x003179DB File Offset: 0x00315BDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeBossInstStartResponse);
		}

		// Token: 0x06015505 RID: 87301 RVA: 0x003179E9 File Offset: 0x00315BE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeBossInstStartResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015506 RID: 87302 RVA: 0x00317A18 File Offset: 0x00315C18
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

		// Token: 0x06015507 RID: 87303 RVA: 0x00317A5D File Offset: 0x00315C5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015508 RID: 87304 RVA: 0x00317A6A File Offset: 0x00315C6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015509 RID: 87305 RVA: 0x00317A73 File Offset: 0x00315C73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601550A RID: 87306 RVA: 0x00317AA8 File Offset: 0x00315CA8
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

		// Token: 0x0601550B RID: 87307 RVA: 0x00317AE6 File Offset: 0x00315CE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeBossInstStartResponse other)
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

		// Token: 0x0601550C RID: 87308 RVA: 0x00317B17 File Offset: 0x00315D17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601550D RID: 87309 RVA: 0x00317B20 File Offset: 0x00315D20
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008037 RID: 32823
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008038 RID: 32824
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04008039 RID: 32825
		private ErrorCode errorCode_;
	}
}
