using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F6F RID: 3951
	[NetMessage(EMessageId.RoadBookLevelUpResponse)]
	public sealed class RoadBookLevelUpResponse : IMessage<RoadBookLevelUpResponse>, IMessage, IEquatable<RoadBookLevelUpResponse>, IDeepCloneable<RoadBookLevelUpResponse>, IBufferMessage
	{
		// Token: 0x060151FD RID: 86525 RVA: 0x003100FE File Offset: 0x0030E2FE
		[NullableContext(1)]
		public static RoadBookLevelUpResponse Create()
		{
			return new RoadBookLevelUpResponse();
		}

		// Token: 0x17004645 RID: 17989
		// (get) Token: 0x060151FE RID: 86526 RVA: 0x00310105 File Offset: 0x0030E305
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004646 RID: 17990
		// (get) Token: 0x060151FF RID: 86527 RVA: 0x00310108 File Offset: 0x0030E308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoadBookLevelUpResponse.Descriptor;
			}
		}

		// Token: 0x06015200 RID: 86528 RVA: 0x0031010F File Offset: 0x0030E30F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookLevelUpResponse()
		{
		}

		// Token: 0x06015201 RID: 86529 RVA: 0x00310117 File Offset: 0x0030E317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookLevelUpResponse(RoadBookLevelUpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015202 RID: 86530 RVA: 0x0031013C File Offset: 0x0030E33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookLevelUpResponse Clone()
		{
			return new RoadBookLevelUpResponse(this);
		}

		// Token: 0x17004647 RID: 17991
		// (get) Token: 0x06015203 RID: 86531 RVA: 0x00310144 File Offset: 0x0030E344
		// (set) Token: 0x06015204 RID: 86532 RVA: 0x0031014C File Offset: 0x0030E34C
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

		// Token: 0x06015205 RID: 86533 RVA: 0x00310155 File Offset: 0x0030E355
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoadBookLevelUpResponse);
		}

		// Token: 0x06015206 RID: 86534 RVA: 0x00310163 File Offset: 0x0030E363
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoadBookLevelUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015207 RID: 86535 RVA: 0x00310194 File Offset: 0x0030E394
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

		// Token: 0x06015208 RID: 86536 RVA: 0x003101D9 File Offset: 0x0030E3D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015209 RID: 86537 RVA: 0x003101E6 File Offset: 0x0030E3E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601520A RID: 86538 RVA: 0x003101EF File Offset: 0x0030E3EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601520B RID: 86539 RVA: 0x00310220 File Offset: 0x0030E420
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

		// Token: 0x0601520C RID: 86540 RVA: 0x0031025E File Offset: 0x0030E45E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoadBookLevelUpResponse other)
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

		// Token: 0x0601520D RID: 86541 RVA: 0x0031028F File Offset: 0x0030E48F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601520E RID: 86542 RVA: 0x00310298 File Offset: 0x0030E498
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007F18 RID: 32536
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F19 RID: 32537
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04007F1A RID: 32538
		private ErrorCode errorCode_;
	}
}
