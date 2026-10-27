using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011B5 RID: 4533
	[NetMessage(EMessageId.SecRoleFightFlowResponse)]
	public sealed class SecRoleFightFlowResponse : IMessage<SecRoleFightFlowResponse>, IMessage, IEquatable<SecRoleFightFlowResponse>, IDeepCloneable<SecRoleFightFlowResponse>, IBufferMessage
	{
		// Token: 0x060182CC RID: 99020 RVA: 0x00384015 File Offset: 0x00382215
		[NullableContext(1)]
		public static SecRoleFightFlowResponse Create()
		{
			return new SecRoleFightFlowResponse();
		}

		// Token: 0x1700515F RID: 20831
		// (get) Token: 0x060182CD RID: 99021 RVA: 0x0038401C File Offset: 0x0038221C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005160 RID: 20832
		// (get) Token: 0x060182CE RID: 99022 RVA: 0x0038401F File Offset: 0x0038221F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SecRoleFightFlowResponse.Descriptor;
			}
		}

		// Token: 0x060182CF RID: 99023 RVA: 0x00384026 File Offset: 0x00382226
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecRoleFightFlowResponse()
		{
		}

		// Token: 0x060182D0 RID: 99024 RVA: 0x00384030 File Offset: 0x00382230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecRoleFightFlowResponse(SecRoleFightFlowResponse other) : this()
		{
			this.logId_ = other.logId_;
			this.error_ = ((other.error_ != null) ? other.error_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060182D1 RID: 99025 RVA: 0x0038407C File Offset: 0x0038227C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecRoleFightFlowResponse Clone()
		{
			return new SecRoleFightFlowResponse(this);
		}

		// Token: 0x17005161 RID: 20833
		// (get) Token: 0x060182D2 RID: 99026 RVA: 0x00384084 File Offset: 0x00382284
		// (set) Token: 0x060182D3 RID: 99027 RVA: 0x0038408C File Offset: 0x0038228C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LogId
		{
			get
			{
				return this.logId_;
			}
			set
			{
				this.logId_ = value;
			}
		}

		// Token: 0x17005162 RID: 20834
		// (get) Token: 0x060182D4 RID: 99028 RVA: 0x00384095 File Offset: 0x00382295
		// (set) Token: 0x060182D5 RID: 99029 RVA: 0x0038409D File Offset: 0x0038229D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DErrorResult Error
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

		// Token: 0x060182D6 RID: 99030 RVA: 0x003840A6 File Offset: 0x003822A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SecRoleFightFlowResponse);
		}

		// Token: 0x060182D7 RID: 99031 RVA: 0x003840B4 File Offset: 0x003822B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SecRoleFightFlowResponse other)
		{
			return other != null && (other == this || (this.LogId == other.LogId && object.Equals(this.Error, other.Error) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060182D8 RID: 99032 RVA: 0x00384104 File Offset: 0x00382304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LogId != 0L)
			{
				num ^= this.LogId.GetHashCode();
			}
			if (this.error_ != null)
			{
				num ^= this.Error.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060182D9 RID: 99033 RVA: 0x00384159 File Offset: 0x00382359
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060182DA RID: 99034 RVA: 0x00384166 File Offset: 0x00382366
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060182DB RID: 99035 RVA: 0x00384170 File Offset: 0x00382370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LogId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.LogId);
			}
			if (this.error_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.Error);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060182DC RID: 99036 RVA: 0x003841CC File Offset: 0x003823CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LogId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LogId);
			}
			if (this.error_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Error);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060182DD RID: 99037 RVA: 0x00384224 File Offset: 0x00382424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SecRoleFightFlowResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LogId != 0L)
			{
				this.LogId = other.LogId;
			}
			if (other.error_ != null)
			{
				if (this.error_ == null)
				{
					this.Error = new DErrorResult();
				}
				this.Error.MergeFrom(other.Error);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060182DE RID: 99038 RVA: 0x0038428C File Offset: 0x0038248C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060182DF RID: 99039 RVA: 0x00384298 File Offset: 0x00382498
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
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.error_ == null)
						{
							this.Error = new DErrorResult();
						}
						input.ReadMessage(this.Error);
					}
				}
				else
				{
					this.LogId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04008F40 RID: 36672
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008F41 RID: 36673
		public const int LogIdFieldNumber = 3;

		// Token: 0x04008F42 RID: 36674
		private long logId_;

		// Token: 0x04008F43 RID: 36675
		public const int ErrorFieldNumber = 13;

		// Token: 0x04008F44 RID: 36676
		private DErrorResult error_;
	}
}
