using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D00 RID: 3328
	[NetMessage(EMessageId.PhantomVicePolishRequest)]
	public sealed class PhantomVicePolishRequest : IMessage<PhantomVicePolishRequest>, IMessage, IEquatable<PhantomVicePolishRequest>, IDeepCloneable<PhantomVicePolishRequest>, IBufferMessage
	{
		// Token: 0x0601201A RID: 73754 RVA: 0x002A2337 File Offset: 0x002A0537
		[NullableContext(1)]
		public static PhantomVicePolishRequest Create()
		{
			return new PhantomVicePolishRequest();
		}

		// Token: 0x17003BA8 RID: 15272
		// (get) Token: 0x0601201B RID: 73755 RVA: 0x002A233E File Offset: 0x002A053E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BA9 RID: 15273
		// (get) Token: 0x0601201C RID: 73756 RVA: 0x002A2341 File Offset: 0x002A0541
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomVicePolishRequest.Descriptor;
			}
		}

		// Token: 0x0601201D RID: 73757 RVA: 0x002A2348 File Offset: 0x002A0548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomVicePolishRequest()
		{
		}

		// Token: 0x0601201E RID: 73758 RVA: 0x002A235B File Offset: 0x002A055B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomVicePolishRequest(PhantomVicePolishRequest other) : this()
		{
			this.incrId_ = other.incrId_;
			this.lockPropIndex_ = other.lockPropIndex_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601201F RID: 73759 RVA: 0x002A2391 File Offset: 0x002A0591
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomVicePolishRequest Clone()
		{
			return new PhantomVicePolishRequest(this);
		}

		// Token: 0x17003BAA RID: 15274
		// (get) Token: 0x06012020 RID: 73760 RVA: 0x002A2399 File Offset: 0x002A0599
		// (set) Token: 0x06012021 RID: 73761 RVA: 0x002A23A1 File Offset: 0x002A05A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncrId
		{
			get
			{
				return this.incrId_;
			}
			set
			{
				this.incrId_ = value;
			}
		}

		// Token: 0x17003BAB RID: 15275
		// (get) Token: 0x06012022 RID: 73762 RVA: 0x002A23AA File Offset: 0x002A05AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> LockPropIndex
		{
			get
			{
				return this.lockPropIndex_;
			}
		}

		// Token: 0x06012023 RID: 73763 RVA: 0x002A23B2 File Offset: 0x002A05B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomVicePolishRequest);
		}

		// Token: 0x06012024 RID: 73764 RVA: 0x002A23C0 File Offset: 0x002A05C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomVicePolishRequest other)
		{
			return other != null && (other == this || (this.IncrId == other.IncrId && this.lockPropIndex_.Equals(other.lockPropIndex_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012025 RID: 73765 RVA: 0x002A2410 File Offset: 0x002A0610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncrId != 0)
			{
				num ^= this.IncrId.GetHashCode();
			}
			num ^= this.lockPropIndex_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012026 RID: 73766 RVA: 0x002A245D File Offset: 0x002A065D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012027 RID: 73767 RVA: 0x002A246A File Offset: 0x002A066A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012028 RID: 73768 RVA: 0x002A2474 File Offset: 0x002A0674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncrId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.IncrId);
			}
			this.lockPropIndex_.WriteTo(ref output, PhantomVicePolishRequest._repeated_lockPropIndex_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012029 RID: 73769 RVA: 0x002A24C4 File Offset: 0x002A06C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncrId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncrId);
			}
			num += this.lockPropIndex_.CalculateSize(PhantomVicePolishRequest._repeated_lockPropIndex_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601202A RID: 73770 RVA: 0x002A2518 File Offset: 0x002A0718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomVicePolishRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncrId != 0)
			{
				this.IncrId = other.IncrId;
			}
			this.lockPropIndex_.Add(other.lockPropIndex_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601202B RID: 73771 RVA: 0x002A2565 File Offset: 0x002A0765
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601202C RID: 73772 RVA: 0x002A2570 File Offset: 0x002A0770
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
				if (num != 56U)
				{
					if (num != 64U && num != 66U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.lockPropIndex_.AddEntriesFrom(ref input, PhantomVicePolishRequest._repeated_lockPropIndex_codec);
					}
				}
				else
				{
					this.IncrId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007126 RID: 28966
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007127 RID: 28967
		public const int IncrIdFieldNumber = 7;

		// Token: 0x04007128 RID: 28968
		private int incrId_;

		// Token: 0x04007129 RID: 28969
		public const int LockPropIndexFieldNumber = 8;

		// Token: 0x0400712A RID: 28970
		private static readonly FieldCodec<int> _repeated_lockPropIndex_codec = FieldCodec.ForInt32(66U);

		// Token: 0x0400712B RID: 28971
		private readonly RepeatedField<int> lockPropIndex_ = new RepeatedField<int>();
	}
}
