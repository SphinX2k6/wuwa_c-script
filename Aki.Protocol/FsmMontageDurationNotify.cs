using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000658 RID: 1624
	[NetMessage(EMessageId.FsmMontageDurationNotify)]
	public sealed class FsmMontageDurationNotify : IMessage<FsmMontageDurationNotify>, IMessage, IEquatable<FsmMontageDurationNotify>, IDeepCloneable<FsmMontageDurationNotify>, IBufferMessage
	{
		// Token: 0x06009573 RID: 38259 RVA: 0x00169050 File Offset: 0x00167250
		[NullableContext(1)]
		public static FsmMontageDurationNotify Create()
		{
			return new FsmMontageDurationNotify();
		}

		// Token: 0x17001DBC RID: 7612
		// (get) Token: 0x06009574 RID: 38260 RVA: 0x00169057 File Offset: 0x00167257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001DBD RID: 7613
		// (get) Token: 0x06009575 RID: 38261 RVA: 0x0016905A File Offset: 0x0016725A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FsmMontageDurationNotify.Descriptor;
			}
		}

		// Token: 0x06009576 RID: 38262 RVA: 0x00169061 File Offset: 0x00167261
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmMontageDurationNotify()
		{
		}

		// Token: 0x06009577 RID: 38263 RVA: 0x00169069 File Offset: 0x00167269
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmMontageDurationNotify(FsmMontageDurationNotify other) : this()
		{
			this.montageHashCode_ = other.montageHashCode_;
			this.durationTime_ = other.durationTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009578 RID: 38264 RVA: 0x0016909A File Offset: 0x0016729A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmMontageDurationNotify Clone()
		{
			return new FsmMontageDurationNotify(this);
		}

		// Token: 0x17001DBE RID: 7614
		// (get) Token: 0x06009579 RID: 38265 RVA: 0x001690A2 File Offset: 0x001672A2
		// (set) Token: 0x0600957A RID: 38266 RVA: 0x001690AA File Offset: 0x001672AA
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

		// Token: 0x17001DBF RID: 7615
		// (get) Token: 0x0600957B RID: 38267 RVA: 0x001690B3 File Offset: 0x001672B3
		// (set) Token: 0x0600957C RID: 38268 RVA: 0x001690BB File Offset: 0x001672BB
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

		// Token: 0x0600957D RID: 38269 RVA: 0x001690C4 File Offset: 0x001672C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FsmMontageDurationNotify);
		}

		// Token: 0x0600957E RID: 38270 RVA: 0x001690D2 File Offset: 0x001672D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FsmMontageDurationNotify other)
		{
			return other != null && (other == this || (this.MontageHashCode == other.MontageHashCode && this.DurationTime == other.DurationTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600957F RID: 38271 RVA: 0x00169110 File Offset: 0x00167310
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

		// Token: 0x06009580 RID: 38272 RVA: 0x00169168 File Offset: 0x00167368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009581 RID: 38273 RVA: 0x00169175 File Offset: 0x00167375
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009582 RID: 38274 RVA: 0x00169180 File Offset: 0x00167380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DurationTime != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.DurationTime);
			}
			if (this.MontageHashCode != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.MontageHashCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009583 RID: 38275 RVA: 0x001691D8 File Offset: 0x001673D8
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

		// Token: 0x06009584 RID: 38276 RVA: 0x00169230 File Offset: 0x00167430
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

		// Token: 0x06009585 RID: 38277 RVA: 0x00169280 File Offset: 0x00167480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009586 RID: 38278 RVA: 0x0016928C File Offset: 0x0016748C
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
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.MontageHashCode = input.ReadInt32();
					}
				}
				else
				{
					this.DurationTime = input.ReadInt32();
				}
			}
		}

		// Token: 0x040047C2 RID: 18370
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047C3 RID: 18371
		public const int MontageHashCodeFieldNumber = 5;

		// Token: 0x040047C4 RID: 18372
		private int montageHashCode_;

		// Token: 0x040047C5 RID: 18373
		public const int DurationTimeFieldNumber = 1;

		// Token: 0x040047C6 RID: 18374
		private int durationTime_;
	}
}
