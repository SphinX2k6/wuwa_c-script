using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200009B RID: 155
	[NetMessage(EMessageId.ActorVisibleResponse)]
	public sealed class ActorVisibleResponse : IMessage<ActorVisibleResponse>, IMessage, IEquatable<ActorVisibleResponse>, IDeepCloneable<ActorVisibleResponse>, IBufferMessage
	{
		// Token: 0x06001BDD RID: 7133 RVA: 0x0004DA7C File Offset: 0x0004BC7C
		[NullableContext(1)]
		public static ActorVisibleResponse Create()
		{
			return new ActorVisibleResponse();
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06001BDE RID: 7134 RVA: 0x0004DA83 File Offset: 0x0004BC83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06001BDF RID: 7135 RVA: 0x0004DA86 File Offset: 0x0004BC86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActorVisibleResponse.Descriptor;
			}
		}

		// Token: 0x06001BE0 RID: 7136 RVA: 0x0004DA8D File Offset: 0x0004BC8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActorVisibleResponse()
		{
		}

		// Token: 0x06001BE1 RID: 7137 RVA: 0x0004DA95 File Offset: 0x0004BC95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActorVisibleResponse(ActorVisibleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001BE2 RID: 7138 RVA: 0x0004DABA File Offset: 0x0004BCBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActorVisibleResponse Clone()
		{
			return new ActorVisibleResponse(this);
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06001BE3 RID: 7139 RVA: 0x0004DAC2 File Offset: 0x0004BCC2
		// (set) Token: 0x06001BE4 RID: 7140 RVA: 0x0004DACA File Offset: 0x0004BCCA
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

		// Token: 0x06001BE5 RID: 7141 RVA: 0x0004DAD3 File Offset: 0x0004BCD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActorVisibleResponse);
		}

		// Token: 0x06001BE6 RID: 7142 RVA: 0x0004DAE1 File Offset: 0x0004BCE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActorVisibleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001BE7 RID: 7143 RVA: 0x0004DB10 File Offset: 0x0004BD10
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

		// Token: 0x06001BE8 RID: 7144 RVA: 0x0004DB55 File Offset: 0x0004BD55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001BE9 RID: 7145 RVA: 0x0004DB62 File Offset: 0x0004BD62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001BEA RID: 7146 RVA: 0x0004DB6B File Offset: 0x0004BD6B
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

		// Token: 0x06001BEB RID: 7147 RVA: 0x0004DBA0 File Offset: 0x0004BDA0
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

		// Token: 0x06001BEC RID: 7148 RVA: 0x0004DBDE File Offset: 0x0004BDDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActorVisibleResponse other)
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

		// Token: 0x06001BED RID: 7149 RVA: 0x0004DC0F File Offset: 0x0004BE0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001BEE RID: 7150 RVA: 0x0004DC18 File Offset: 0x0004BE18
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

		// Token: 0x040022B8 RID: 8888
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022B9 RID: 8889
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x040022BA RID: 8890
		private ErrorCode errorCode_;
	}
}
