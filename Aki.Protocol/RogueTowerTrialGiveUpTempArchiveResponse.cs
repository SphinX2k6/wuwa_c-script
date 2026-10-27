using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200101A RID: 4122
	[NetMessage(EMessageId.RogueTowerTrialGiveUpTempArchiveResponse)]
	public sealed class RogueTowerTrialGiveUpTempArchiveResponse : IMessage<RogueTowerTrialGiveUpTempArchiveResponse>, IMessage, IEquatable<RogueTowerTrialGiveUpTempArchiveResponse>, IDeepCloneable<RogueTowerTrialGiveUpTempArchiveResponse>, IBufferMessage
	{
		// Token: 0x060160A2 RID: 90274 RVA: 0x0033426A File Offset: 0x0033246A
		[NullableContext(1)]
		public static RogueTowerTrialGiveUpTempArchiveResponse Create()
		{
			return new RogueTowerTrialGiveUpTempArchiveResponse();
		}

		// Token: 0x170049AE RID: 18862
		// (get) Token: 0x060160A3 RID: 90275 RVA: 0x00334271 File Offset: 0x00332471
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049AF RID: 18863
		// (get) Token: 0x060160A4 RID: 90276 RVA: 0x00334274 File Offset: 0x00332474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTowerTrialGiveUpTempArchiveResponse.Descriptor;
			}
		}

		// Token: 0x060160A5 RID: 90277 RVA: 0x0033427B File Offset: 0x0033247B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialGiveUpTempArchiveResponse()
		{
		}

		// Token: 0x060160A6 RID: 90278 RVA: 0x00334283 File Offset: 0x00332483
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialGiveUpTempArchiveResponse(RogueTowerTrialGiveUpTempArchiveResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060160A7 RID: 90279 RVA: 0x003342A8 File Offset: 0x003324A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialGiveUpTempArchiveResponse Clone()
		{
			return new RogueTowerTrialGiveUpTempArchiveResponse(this);
		}

		// Token: 0x170049B0 RID: 18864
		// (get) Token: 0x060160A8 RID: 90280 RVA: 0x003342B0 File Offset: 0x003324B0
		// (set) Token: 0x060160A9 RID: 90281 RVA: 0x003342B8 File Offset: 0x003324B8
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

		// Token: 0x060160AA RID: 90282 RVA: 0x003342C1 File Offset: 0x003324C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTowerTrialGiveUpTempArchiveResponse);
		}

		// Token: 0x060160AB RID: 90283 RVA: 0x003342CF File Offset: 0x003324CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTowerTrialGiveUpTempArchiveResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060160AC RID: 90284 RVA: 0x00334300 File Offset: 0x00332500
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

		// Token: 0x060160AD RID: 90285 RVA: 0x00334345 File Offset: 0x00332545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060160AE RID: 90286 RVA: 0x00334352 File Offset: 0x00332552
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060160AF RID: 90287 RVA: 0x0033435B File Offset: 0x0033255B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060160B0 RID: 90288 RVA: 0x00334390 File Offset: 0x00332590
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

		// Token: 0x060160B1 RID: 90289 RVA: 0x003343CE File Offset: 0x003325CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTowerTrialGiveUpTempArchiveResponse other)
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

		// Token: 0x060160B2 RID: 90290 RVA: 0x003343FF File Offset: 0x003325FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060160B3 RID: 90291 RVA: 0x00334408 File Offset: 0x00332608
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008429 RID: 33833
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400842A RID: 33834
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x0400842B RID: 33835
		private ErrorCode errorCode_;
	}
}
