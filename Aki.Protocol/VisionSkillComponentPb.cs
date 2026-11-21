using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001559 RID: 5465
	public sealed class VisionSkillComponentPb : IMessage<VisionSkillComponentPb>, IMessage, IEquatable<VisionSkillComponentPb>, IDeepCloneable<VisionSkillComponentPb>, IBufferMessage
	{
		// Token: 0x0601CF24 RID: 118564 RVA: 0x00431A52 File Offset: 0x0042FC52
		[NullableContext(1)]
		public static VisionSkillComponentPb Create()
		{
			return new VisionSkillComponentPb();
		}

		// Token: 0x170061F2 RID: 25074
		// (get) Token: 0x0601CF25 RID: 118565 RVA: 0x00431A59 File Offset: 0x0042FC59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170061F3 RID: 25075
		// (get) Token: 0x0601CF26 RID: 118566 RVA: 0x00431A5C File Offset: 0x0042FC5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VisionSkillComponentPb.Descriptor;
			}
		}

		// Token: 0x0601CF27 RID: 118567 RVA: 0x00431A63 File Offset: 0x0042FC63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionSkillComponentPb()
		{
		}

		// Token: 0x0601CF28 RID: 118568 RVA: 0x00431A78 File Offset: 0x0042FC78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionSkillComponentPb(VisionSkillComponentPb other) : this()
		{
			this.visionSkillInfos_ = other.visionSkillInfos_.Clone();
			this.phantomSkillInfo_ = ((other.phantomSkillInfo_ != null) ? other.phantomSkillInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CF29 RID: 118569 RVA: 0x00431AC9 File Offset: 0x0042FCC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionSkillComponentPb Clone()
		{
			return new VisionSkillComponentPb(this);
		}

		// Token: 0x170061F4 RID: 25076
		// (get) Token: 0x0601CF2A RID: 118570 RVA: 0x00431AD1 File Offset: 0x0042FCD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<VisionSkillInformation> VisionSkillInfos
		{
			get
			{
				return this.visionSkillInfos_;
			}
		}

		// Token: 0x170061F5 RID: 25077
		// (get) Token: 0x0601CF2B RID: 118571 RVA: 0x00431AD9 File Offset: 0x0042FCD9
		// (set) Token: 0x0601CF2C RID: 118572 RVA: 0x00431AE1 File Offset: 0x0042FCE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionSkillInformation PhantomSkillInfo
		{
			get
			{
				return this.phantomSkillInfo_;
			}
			set
			{
				this.phantomSkillInfo_ = value;
			}
		}

		// Token: 0x0601CF2D RID: 118573 RVA: 0x00431AEA File Offset: 0x0042FCEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VisionSkillComponentPb);
		}

		// Token: 0x0601CF2E RID: 118574 RVA: 0x00431AF8 File Offset: 0x0042FCF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VisionSkillComponentPb other)
		{
			return other != null && (other == this || (this.visionSkillInfos_.Equals(other.visionSkillInfos_) && object.Equals(this.PhantomSkillInfo, other.PhantomSkillInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CF2F RID: 118575 RVA: 0x00431B4C File Offset: 0x0042FD4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.visionSkillInfos_.GetHashCode();
			if (this.phantomSkillInfo_ != null)
			{
				num ^= this.PhantomSkillInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CF30 RID: 118576 RVA: 0x00431B96 File Offset: 0x0042FD96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CF31 RID: 118577 RVA: 0x00431BA3 File Offset: 0x0042FDA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CF32 RID: 118578 RVA: 0x00431BAC File Offset: 0x0042FDAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.visionSkillInfos_.WriteTo(ref output, VisionSkillComponentPb._repeated_visionSkillInfos_codec);
			if (this.phantomSkillInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.PhantomSkillInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CF33 RID: 118579 RVA: 0x00431BFC File Offset: 0x0042FDFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.visionSkillInfos_.CalculateSize(VisionSkillComponentPb._repeated_visionSkillInfos_codec);
			if (this.phantomSkillInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomSkillInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CF34 RID: 118580 RVA: 0x00431C50 File Offset: 0x0042FE50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VisionSkillComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			this.visionSkillInfos_.Add(other.visionSkillInfos_);
			if (other.phantomSkillInfo_ != null)
			{
				if (this.phantomSkillInfo_ == null)
				{
					this.PhantomSkillInfo = new VisionSkillInformation();
				}
				this.PhantomSkillInfo.MergeFrom(other.PhantomSkillInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CF35 RID: 118581 RVA: 0x00431CB5 File Offset: 0x0042FEB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CF36 RID: 118582 RVA: 0x00431CC0 File Offset: 0x0042FEC0
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
				if (num != 10U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.phantomSkillInfo_ == null)
						{
							this.PhantomSkillInfo = new VisionSkillInformation();
						}
						input.ReadMessage(this.PhantomSkillInfo);
					}
				}
				else
				{
					this.visionSkillInfos_.AddEntriesFrom(ref input, VisionSkillComponentPb._repeated_visionSkillInfos_codec);
				}
			}
		}

		// Token: 0x0400A668 RID: 42600
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A669 RID: 42601
		public const int VisionSkillInfosFieldNumber = 1;

		// Token: 0x0400A66A RID: 42602
		private static readonly FieldCodec<VisionSkillInformation> _repeated_visionSkillInfos_codec = FieldCodec.ForMessage<VisionSkillInformation>(10U, VisionSkillInformation.Parser);

		// Token: 0x0400A66B RID: 42603
		private readonly RepeatedField<VisionSkillInformation> visionSkillInfos_ = new RepeatedField<VisionSkillInformation>();

		// Token: 0x0400A66C RID: 42604
		public const int PhantomSkillInfoFieldNumber = 2;

		// Token: 0x0400A66D RID: 42605
		private VisionSkillInformation phantomSkillInfo_;
	}
}
