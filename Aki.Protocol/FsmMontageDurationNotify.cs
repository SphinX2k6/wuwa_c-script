using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200066C RID: 1644
	[NetMessage(EMessageId.FsmMontageDurationNotify)]
	public sealed class FsmMontageDurationNotify : IMessage<FsmMontageDurationNotify>, IMessage, IEquatable<FsmMontageDurationNotify>, IDeepCloneable<FsmMontageDurationNotify>, IBufferMessage
	{
		// Token: 0x060096C9 RID: 38601 RVA: 0x0016BA78 File Offset: 0x00169C78
		[NullableContext(1)]
		public static FsmMontageDurationNotify Create()
		{
			return new FsmMontageDurationNotify();
		}

		// Token: 0x17001E06 RID: 7686
		// (get) Token: 0x060096CA RID: 38602 RVA: 0x0016BA7F File Offset: 0x00169C7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E07 RID: 7687
		// (get) Token: 0x060096CB RID: 38603 RVA: 0x0016BA82 File Offset: 0x00169C82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FsmMontageDurationNotify.Descriptor;
			}
		}

		// Token: 0x060096CC RID: 38604 RVA: 0x0016BA89 File Offset: 0x00169C89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmMontageDurationNotify()
		{
		}

		// Token: 0x060096CD RID: 38605 RVA: 0x0016BA91 File Offset: 0x00169C91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmMontageDurationNotify(FsmMontageDurationNotify other) : this()
		{
			this.montageHashCode_ = other.montageHashCode_;
			this.durationTime_ = other.durationTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060096CE RID: 38606 RVA: 0x0016BAC2 File Offset: 0x00169CC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmMontageDurationNotify Clone()
		{
			return new FsmMontageDurationNotify(this);
		}

		// Token: 0x17001E08 RID: 7688
		// (get) Token: 0x060096CF RID: 38607 RVA: 0x0016BACA File Offset: 0x00169CCA
		// (set) Token: 0x060096D0 RID: 38608 RVA: 0x0016BAD2 File Offset: 0x00169CD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MontageHashCode
		{
			get
			{
				return this.montageHashCode_;
			}
			set
			{
				this.montageHashCode_ = value;
			}
		}

		// Token: 0x17001E09 RID: 7689
		// (get) Token: 0x060096D1 RID: 38609 RVA: 0x0016BADB File Offset: 0x00169CDB
		// (set) Token: 0x060096D2 RID: 38610 RVA: 0x0016BAE3 File Offset: 0x00169CE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DurationTime
		{
			get
			{
				return this.durationTime_;
			}
			set
			{
				this.durationTime_ = value;
			}
		}

		// Token: 0x060096D3 RID: 38611 RVA: 0x0016BAEC File Offset: 0x00169CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FsmMontageDurationNotify);
		}

		// Token: 0x060096D4 RID: 38612 RVA: 0x0016BAFA File Offset: 0x00169CFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FsmMontageDurationNotify other)
		{
			return other != null && (other == this || (this.MontageHashCode == other.MontageHashCode && this.DurationTime == other.DurationTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060096D5 RID: 38613 RVA: 0x0016BB38 File Offset: 0x00169D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MontageHashCode != 0)
			{
				num ^= this.MontageHashCode.GetHashCode();
			}
			if (this.DurationTime != 0)
			{
				num ^= this.DurationTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060096D6 RID: 38614 RVA: 0x0016BB90 File Offset: 0x00169D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060096D7 RID: 38615 RVA: 0x0016BB9D File Offset: 0x00169D9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060096D8 RID: 38616 RVA: 0x0016BBA8 File Offset: 0x00169DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MontageHashCode != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.MontageHashCode);
			}
			if (this.DurationTime != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.DurationTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060096D9 RID: 38617 RVA: 0x0016BC04 File Offset: 0x00169E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MontageHashCode != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MontageHashCode);
			}
			if (this.DurationTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DurationTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060096DA RID: 38618 RVA: 0x0016BC5C File Offset: 0x00169E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FsmMontageDurationNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MontageHashCode != 0)
			{
				this.MontageHashCode = other.MontageHashCode;
			}
			if (other.DurationTime != 0)
			{
				this.DurationTime = other.DurationTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060096DB RID: 38619 RVA: 0x0016BCAC File Offset: 0x00169EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060096DC RID: 38620 RVA: 0x0016BCB8 File Offset: 0x00169EB8
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
				if (num != 32U)
				{
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.DurationTime = input.ReadInt32();
					}
				}
				else
				{
					this.MontageHashCode = input.ReadInt32();
				}
			}
		}

		// Token: 0x040047C9 RID: 18377
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047CA RID: 18378
		public const int MontageHashCodeFieldNumber = 4;

		// Token: 0x040047CB RID: 18379
		private int montageHashCode_;

		// Token: 0x040047CC RID: 18380
		public const int DurationTimeFieldNumber = 6;

		// Token: 0x040047CD RID: 18381
		private int durationTime_;
	}
}
