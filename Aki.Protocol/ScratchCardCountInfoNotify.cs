using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200119E RID: 4510
	[NetMessage(EMessageId.ScratchCardCountInfoNotify)]
	public sealed class ScratchCardCountInfoNotify : IMessage<ScratchCardCountInfoNotify>, IMessage, IEquatable<ScratchCardCountInfoNotify>, IDeepCloneable<ScratchCardCountInfoNotify>, IBufferMessage
	{
		// Token: 0x0601807E RID: 98430 RVA: 0x0037D3FB File Offset: 0x0037B5FB
		[NullableContext(1)]
		public static ScratchCardCountInfoNotify Create()
		{
			return new ScratchCardCountInfoNotify();
		}

		// Token: 0x170050BF RID: 20671
		// (get) Token: 0x0601807F RID: 98431 RVA: 0x0037D402 File Offset: 0x0037B602
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170050C0 RID: 20672
		// (get) Token: 0x06018080 RID: 98432 RVA: 0x0037D405 File Offset: 0x0037B605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ScratchCardCountInfoNotify.Descriptor;
			}
		}

		// Token: 0x06018081 RID: 98433 RVA: 0x0037D40C File Offset: 0x0037B60C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardCountInfoNotify()
		{
		}

		// Token: 0x06018082 RID: 98434 RVA: 0x0037D41F File Offset: 0x0037B61F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardCountInfoNotify(ScratchCardCountInfoNotify other) : this()
		{
			this.scratchTimeInfos_ = other.scratchTimeInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018083 RID: 98435 RVA: 0x0037D449 File Offset: 0x0037B649
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardCountInfoNotify Clone()
		{
			return new ScratchCardCountInfoNotify(this);
		}

		// Token: 0x170050C1 RID: 20673
		// (get) Token: 0x06018084 RID: 98436 RVA: 0x0037D451 File Offset: 0x0037B651
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ScratchCardTimeInfo> ScratchTimeInfos
		{
			get
			{
				return this.scratchTimeInfos_;
			}
		}

		// Token: 0x06018085 RID: 98437 RVA: 0x0037D459 File Offset: 0x0037B659
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ScratchCardCountInfoNotify);
		}

		// Token: 0x06018086 RID: 98438 RVA: 0x0037D467 File Offset: 0x0037B667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ScratchCardCountInfoNotify other)
		{
			return other != null && (other == this || (this.scratchTimeInfos_.Equals(other.scratchTimeInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018087 RID: 98439 RVA: 0x0037D49C File Offset: 0x0037B69C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.scratchTimeInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018088 RID: 98440 RVA: 0x0037D4D0 File Offset: 0x0037B6D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018089 RID: 98441 RVA: 0x0037D4DD File Offset: 0x0037B6DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601808A RID: 98442 RVA: 0x0037D4E6 File Offset: 0x0037B6E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.scratchTimeInfos_.WriteTo(ref output, ScratchCardCountInfoNotify._repeated_scratchTimeInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601808B RID: 98443 RVA: 0x0037D510 File Offset: 0x0037B710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.scratchTimeInfos_.CalculateSize(ScratchCardCountInfoNotify._repeated_scratchTimeInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601808C RID: 98444 RVA: 0x0037D549 File Offset: 0x0037B749
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ScratchCardCountInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.scratchTimeInfos_.Add(other.scratchTimeInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601808D RID: 98445 RVA: 0x0037D577 File Offset: 0x0037B777
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601808E RID: 98446 RVA: 0x0037D580 File Offset: 0x0037B780
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.scratchTimeInfos_.AddEntriesFrom(ref input, ScratchCardCountInfoNotify._repeated_scratchTimeInfos_codec);
				}
			}
		}

		// Token: 0x04008E43 RID: 36419
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E44 RID: 36420
		public const int ScratchTimeInfosFieldNumber = 2;

		// Token: 0x04008E45 RID: 36421
		private static readonly FieldCodec<ScratchCardTimeInfo> _repeated_scratchTimeInfos_codec = FieldCodec.ForMessage<ScratchCardTimeInfo>(18U, ScratchCardTimeInfo.Parser);

		// Token: 0x04008E46 RID: 36422
		private readonly RepeatedField<ScratchCardTimeInfo> scratchTimeInfos_ = new RepeatedField<ScratchCardTimeInfo>();
	}
}
