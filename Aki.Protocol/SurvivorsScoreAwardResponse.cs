using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012E5 RID: 4837
	[NetMessage(EMessageId.SurvivorsScoreAwardResponse)]
	public sealed class SurvivorsScoreAwardResponse : IMessage<SurvivorsScoreAwardResponse>, IMessage, IEquatable<SurvivorsScoreAwardResponse>, IDeepCloneable<SurvivorsScoreAwardResponse>, IBufferMessage
	{
		// Token: 0x06019B9A RID: 105370 RVA: 0x003BD2F9 File Offset: 0x003BB4F9
		[NullableContext(1)]
		public static SurvivorsScoreAwardResponse Create()
		{
			return new SurvivorsScoreAwardResponse();
		}

		// Token: 0x170056C6 RID: 22214
		// (get) Token: 0x06019B9B RID: 105371 RVA: 0x003BD300 File Offset: 0x003BB500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170056C7 RID: 22215
		// (get) Token: 0x06019B9C RID: 105372 RVA: 0x003BD303 File Offset: 0x003BB503
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsScoreAwardResponse.Descriptor;
			}
		}

		// Token: 0x06019B9D RID: 105373 RVA: 0x003BD30A File Offset: 0x003BB50A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsScoreAwardResponse()
		{
		}

		// Token: 0x06019B9E RID: 105374 RVA: 0x003BD312 File Offset: 0x003BB512
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsScoreAwardResponse(SurvivorsScoreAwardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019B9F RID: 105375 RVA: 0x003BD337 File Offset: 0x003BB537
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsScoreAwardResponse Clone()
		{
			return new SurvivorsScoreAwardResponse(this);
		}

		// Token: 0x170056C8 RID: 22216
		// (get) Token: 0x06019BA0 RID: 105376 RVA: 0x003BD33F File Offset: 0x003BB53F
		// (set) Token: 0x06019BA1 RID: 105377 RVA: 0x003BD347 File Offset: 0x003BB547
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

		// Token: 0x06019BA2 RID: 105378 RVA: 0x003BD350 File Offset: 0x003BB550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsScoreAwardResponse);
		}

		// Token: 0x06019BA3 RID: 105379 RVA: 0x003BD35E File Offset: 0x003BB55E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsScoreAwardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019BA4 RID: 105380 RVA: 0x003BD38C File Offset: 0x003BB58C
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

		// Token: 0x06019BA5 RID: 105381 RVA: 0x003BD3D1 File Offset: 0x003BB5D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019BA6 RID: 105382 RVA: 0x003BD3DE File Offset: 0x003BB5DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019BA7 RID: 105383 RVA: 0x003BD3E7 File Offset: 0x003BB5E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019BA8 RID: 105384 RVA: 0x003BD41C File Offset: 0x003BB61C
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

		// Token: 0x06019BA9 RID: 105385 RVA: 0x003BD45A File Offset: 0x003BB65A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsScoreAwardResponse other)
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

		// Token: 0x06019BAA RID: 105386 RVA: 0x003BD48B File Offset: 0x003BB68B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019BAB RID: 105387 RVA: 0x003BD494 File Offset: 0x003BB694
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040096B2 RID: 38578
		private UnknownFieldSet _unknownFields;

		// Token: 0x040096B3 RID: 38579
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x040096B4 RID: 38580
		private ErrorCode errorCode_;
	}
}
