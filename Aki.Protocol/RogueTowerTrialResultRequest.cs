using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001020 RID: 4128
	[NetMessage(EMessageId.RogueTowerTrialResultRequest)]
	public sealed class RogueTowerTrialResultRequest : IMessage<RogueTowerTrialResultRequest>, IMessage, IEquatable<RogueTowerTrialResultRequest>, IDeepCloneable<RogueTowerTrialResultRequest>, IBufferMessage
	{
		// Token: 0x0601611A RID: 90394 RVA: 0x00335212 File Offset: 0x00333412
		[NullableContext(1)]
		public static RogueTowerTrialResultRequest Create()
		{
			return new RogueTowerTrialResultRequest();
		}

		// Token: 0x170049C6 RID: 18886
		// (get) Token: 0x0601611B RID: 90395 RVA: 0x00335219 File Offset: 0x00333419
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049C7 RID: 18887
		// (get) Token: 0x0601611C RID: 90396 RVA: 0x0033521C File Offset: 0x0033341C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTowerTrialResultRequest.Descriptor;
			}
		}

		// Token: 0x0601611D RID: 90397 RVA: 0x00335223 File Offset: 0x00333423
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialResultRequest()
		{
		}

		// Token: 0x0601611E RID: 90398 RVA: 0x0033522B File Offset: 0x0033342B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialResultRequest(RogueTowerTrialResultRequest other) : this()
		{
			this.instId_ = other.instId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601611F RID: 90399 RVA: 0x00335250 File Offset: 0x00333450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialResultRequest Clone()
		{
			return new RogueTowerTrialResultRequest(this);
		}

		// Token: 0x170049C8 RID: 18888
		// (get) Token: 0x06016120 RID: 90400 RVA: 0x00335258 File Offset: 0x00333458
		// (set) Token: 0x06016121 RID: 90401 RVA: 0x00335260 File Offset: 0x00333460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x06016122 RID: 90402 RVA: 0x00335269 File Offset: 0x00333469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTowerTrialResultRequest);
		}

		// Token: 0x06016123 RID: 90403 RVA: 0x00335277 File Offset: 0x00333477
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTowerTrialResultRequest other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016124 RID: 90404 RVA: 0x003352A8 File Offset: 0x003334A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016125 RID: 90405 RVA: 0x003352E7 File Offset: 0x003334E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016126 RID: 90406 RVA: 0x003352F4 File Offset: 0x003334F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016127 RID: 90407 RVA: 0x003352FD File Offset: 0x003334FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016128 RID: 90408 RVA: 0x00335330 File Offset: 0x00333530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016129 RID: 90409 RVA: 0x0033536E File Offset: 0x0033356E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTowerTrialResultRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601612A RID: 90410 RVA: 0x0033539F File Offset: 0x0033359F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601612B RID: 90411 RVA: 0x003353A8 File Offset: 0x003335A8
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.InstId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008448 RID: 33864
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008449 RID: 33865
		public const int InstIdFieldNumber = 9;

		// Token: 0x0400844A RID: 33866
		private int instId_;
	}
}
