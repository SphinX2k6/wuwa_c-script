using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011B7 RID: 4535
	[NetMessage(EMessageId.SecWorldInfoFlowResponse)]
	public sealed class SecWorldInfoFlowResponse : IMessage<SecWorldInfoFlowResponse>, IMessage, IEquatable<SecWorldInfoFlowResponse>, IDeepCloneable<SecWorldInfoFlowResponse>, IBufferMessage
	{
		// Token: 0x06018312 RID: 99090 RVA: 0x00385072 File Offset: 0x00383272
		[NullableContext(1)]
		public static SecWorldInfoFlowResponse Create()
		{
			return new SecWorldInfoFlowResponse();
		}

		// Token: 0x17005176 RID: 20854
		// (get) Token: 0x06018313 RID: 99091 RVA: 0x00385079 File Offset: 0x00383279
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005177 RID: 20855
		// (get) Token: 0x06018314 RID: 99092 RVA: 0x0038507C File Offset: 0x0038327C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SecWorldInfoFlowResponse.Descriptor;
			}
		}

		// Token: 0x06018315 RID: 99093 RVA: 0x00385083 File Offset: 0x00383283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecWorldInfoFlowResponse()
		{
		}

		// Token: 0x06018316 RID: 99094 RVA: 0x0038508C File Offset: 0x0038328C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecWorldInfoFlowResponse(SecWorldInfoFlowResponse other) : this()
		{
			this.logId_ = other.logId_;
			this.error_ = ((other.error_ != null) ? other.error_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018317 RID: 99095 RVA: 0x003850D8 File Offset: 0x003832D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecWorldInfoFlowResponse Clone()
		{
			return new SecWorldInfoFlowResponse(this);
		}

		// Token: 0x17005178 RID: 20856
		// (get) Token: 0x06018318 RID: 99096 RVA: 0x003850E0 File Offset: 0x003832E0
		// (set) Token: 0x06018319 RID: 99097 RVA: 0x003850E8 File Offset: 0x003832E8
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

		// Token: 0x17005179 RID: 20857
		// (get) Token: 0x0601831A RID: 99098 RVA: 0x003850F1 File Offset: 0x003832F1
		// (set) Token: 0x0601831B RID: 99099 RVA: 0x003850F9 File Offset: 0x003832F9
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

		// Token: 0x0601831C RID: 99100 RVA: 0x00385102 File Offset: 0x00383302
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SecWorldInfoFlowResponse);
		}

		// Token: 0x0601831D RID: 99101 RVA: 0x00385110 File Offset: 0x00383310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SecWorldInfoFlowResponse other)
		{
			return other != null && (other == this || (this.LogId == other.LogId && object.Equals(this.Error, other.Error) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601831E RID: 99102 RVA: 0x00385160 File Offset: 0x00383360
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

		// Token: 0x0601831F RID: 99103 RVA: 0x003851B5 File Offset: 0x003833B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018320 RID: 99104 RVA: 0x003851C2 File Offset: 0x003833C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018321 RID: 99105 RVA: 0x003851CC File Offset: 0x003833CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LogId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.LogId);
			}
			if (this.error_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.Error);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018322 RID: 99106 RVA: 0x00385224 File Offset: 0x00383424
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

		// Token: 0x06018323 RID: 99107 RVA: 0x0038527C File Offset: 0x0038347C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SecWorldInfoFlowResponse other)
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

		// Token: 0x06018324 RID: 99108 RVA: 0x003852E4 File Offset: 0x003834E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018325 RID: 99109 RVA: 0x003852F0 File Offset: 0x003834F0
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
					if (num != 74U)
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

		// Token: 0x04008F68 RID: 36712
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008F69 RID: 36713
		public const int LogIdFieldNumber = 1;

		// Token: 0x04008F6A RID: 36714
		private long logId_;

		// Token: 0x04008F6B RID: 36715
		public const int ErrorFieldNumber = 9;

		// Token: 0x04008F6C RID: 36716
		private DErrorResult error_;
	}
}
