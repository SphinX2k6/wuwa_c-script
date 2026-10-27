using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E9C RID: 3740
	[NetMessage(EMessageId.RealmBetweenFullRewardResponse)]
	public sealed class RealmBetweenFullRewardResponse : IMessage<RealmBetweenFullRewardResponse>, IMessage, IEquatable<RealmBetweenFullRewardResponse>, IDeepCloneable<RealmBetweenFullRewardResponse>, IBufferMessage
	{
		// Token: 0x0601413B RID: 82235 RVA: 0x002EC346 File Offset: 0x002EA546
		[NullableContext(1)]
		public static RealmBetweenFullRewardResponse Create()
		{
			return new RealmBetweenFullRewardResponse();
		}

		// Token: 0x170042C7 RID: 17095
		// (get) Token: 0x0601413C RID: 82236 RVA: 0x002EC34D File Offset: 0x002EA54D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042C8 RID: 17096
		// (get) Token: 0x0601413D RID: 82237 RVA: 0x002EC350 File Offset: 0x002EA550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RealmBetweenFullRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601413E RID: 82238 RVA: 0x002EC357 File Offset: 0x002EA557
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenFullRewardResponse()
		{
		}

		// Token: 0x0601413F RID: 82239 RVA: 0x002EC35F File Offset: 0x002EA55F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenFullRewardResponse(RealmBetweenFullRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014140 RID: 82240 RVA: 0x002EC384 File Offset: 0x002EA584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenFullRewardResponse Clone()
		{
			return new RealmBetweenFullRewardResponse(this);
		}

		// Token: 0x170042C9 RID: 17097
		// (get) Token: 0x06014141 RID: 82241 RVA: 0x002EC38C File Offset: 0x002EA58C
		// (set) Token: 0x06014142 RID: 82242 RVA: 0x002EC394 File Offset: 0x002EA594
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

		// Token: 0x06014143 RID: 82243 RVA: 0x002EC39D File Offset: 0x002EA59D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RealmBetweenFullRewardResponse);
		}

		// Token: 0x06014144 RID: 82244 RVA: 0x002EC3AB File Offset: 0x002EA5AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RealmBetweenFullRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014145 RID: 82245 RVA: 0x002EC3DC File Offset: 0x002EA5DC
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

		// Token: 0x06014146 RID: 82246 RVA: 0x002EC421 File Offset: 0x002EA621
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014147 RID: 82247 RVA: 0x002EC42E File Offset: 0x002EA62E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014148 RID: 82248 RVA: 0x002EC437 File Offset: 0x002EA637
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014149 RID: 82249 RVA: 0x002EC46C File Offset: 0x002EA66C
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

		// Token: 0x0601414A RID: 82250 RVA: 0x002EC4AA File Offset: 0x002EA6AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RealmBetweenFullRewardResponse other)
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

		// Token: 0x0601414B RID: 82251 RVA: 0x002EC4DB File Offset: 0x002EA6DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601414C RID: 82252 RVA: 0x002EC4E4 File Offset: 0x002EA6E4
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007A72 RID: 31346
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A73 RID: 31347
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04007A74 RID: 31348
		private ErrorCode errorCode_;
	}
}
