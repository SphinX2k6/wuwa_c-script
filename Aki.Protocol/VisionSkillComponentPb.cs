using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014E3 RID: 5347
	public sealed class VisionSkillComponentPb : IMessage<VisionSkillComponentPb>, IMessage, IEquatable<VisionSkillComponentPb>, IDeepCloneable<VisionSkillComponentPb>, IBufferMessage
	{
		// Token: 0x0601C45D RID: 115805 RVA: 0x00415F96 File Offset: 0x00414196
		[NullableContext(1)]
		public static VisionSkillComponentPb Create()
		{
			return new VisionSkillComponentPb();
		}

		// Token: 0x17005F51 RID: 24401
		// (get) Token: 0x0601C45E RID: 115806 RVA: 0x00415F9D File Offset: 0x0041419D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F52 RID: 24402
		// (get) Token: 0x0601C45F RID: 115807 RVA: 0x00415FA0 File Offset: 0x004141A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VisionSkillComponentPb.Descriptor;
			}
		}

		// Token: 0x0601C460 RID: 115808 RVA: 0x00415FA7 File Offset: 0x004141A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionSkillComponentPb()
		{
		}

		// Token: 0x0601C461 RID: 115809 RVA: 0x00415FBC File Offset: 0x004141BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionSkillComponentPb(VisionSkillComponentPb other) : this()
		{
			this.visionSkillInfos_ = other.visionSkillInfos_.Clone();
			this.phantomSkillInfo_ = ((other.phantomSkillInfo_ != null) ? other.phantomSkillInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C462 RID: 115810 RVA: 0x0041600D File Offset: 0x0041420D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionSkillComponentPb Clone()
		{
			return new VisionSkillComponentPb(this);
		}

		// Token: 0x17005F53 RID: 24403
		// (get) Token: 0x0601C463 RID: 115811 RVA: 0x00416015 File Offset: 0x00414215
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<VisionSkillInformation> VisionSkillInfos
		{
			get
			{
				return this.visionSkillInfos_;
			}
		}

		// Token: 0x17005F54 RID: 24404
		// (get) Token: 0x0601C464 RID: 115812 RVA: 0x0041601D File Offset: 0x0041421D
		// (set) Token: 0x0601C465 RID: 115813 RVA: 0x00416025 File Offset: 0x00414225
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

		// Token: 0x0601C466 RID: 115814 RVA: 0x0041602E File Offset: 0x0041422E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VisionSkillComponentPb);
		}

		// Token: 0x0601C467 RID: 115815 RVA: 0x0041603C File Offset: 0x0041423C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VisionSkillComponentPb other)
		{
			return other != null && (other == this || (this.visionSkillInfos_.Equals(other.visionSkillInfos_) && object.Equals(this.PhantomSkillInfo, other.PhantomSkillInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C468 RID: 115816 RVA: 0x00416090 File Offset: 0x00414290
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

		// Token: 0x0601C469 RID: 115817 RVA: 0x004160DA File Offset: 0x004142DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C46A RID: 115818 RVA: 0x004160E7 File Offset: 0x004142E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C46B RID: 115819 RVA: 0x004160F0 File Offset: 0x004142F0
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

		// Token: 0x0601C46C RID: 115820 RVA: 0x00416140 File Offset: 0x00414340
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

		// Token: 0x0601C46D RID: 115821 RVA: 0x00416194 File Offset: 0x00414394
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

		// Token: 0x0601C46E RID: 115822 RVA: 0x004161F9 File Offset: 0x004143F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C46F RID: 115823 RVA: 0x00416204 File Offset: 0x00414404
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

		// Token: 0x0400A20F RID: 41487
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A210 RID: 41488
		public const int VisionSkillInfosFieldNumber = 1;

		// Token: 0x0400A211 RID: 41489
		private static readonly FieldCodec<VisionSkillInformation> _repeated_visionSkillInfos_codec = FieldCodec.ForMessage<VisionSkillInformation>(10U, VisionSkillInformation.Parser);

		// Token: 0x0400A212 RID: 41490
		private readonly RepeatedField<VisionSkillInformation> visionSkillInfos_ = new RepeatedField<VisionSkillInformation>();

		// Token: 0x0400A213 RID: 41491
		public const int PhantomSkillInfoFieldNumber = 2;

		// Token: 0x0400A214 RID: 41492
		private VisionSkillInformation phantomSkillInfo_;
	}
}
