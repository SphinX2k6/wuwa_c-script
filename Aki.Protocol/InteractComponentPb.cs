using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000831 RID: 2097
	public sealed class InteractComponentPb : IMessage<InteractComponentPb>, IMessage, IEquatable<InteractComponentPb>, IDeepCloneable<InteractComponentPb>, IBufferMessage
	{
		// Token: 0x0600BB67 RID: 47975 RVA: 0x001BE614 File Offset: 0x001BC814
		[NullableContext(1)]
		public static InteractComponentPb Create()
		{
			return new InteractComponentPb();
		}

		// Token: 0x170025D8 RID: 9688
		// (get) Token: 0x0600BB68 RID: 47976 RVA: 0x001BE61B File Offset: 0x001BC81B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170025D9 RID: 9689
		// (get) Token: 0x0600BB69 RID: 47977 RVA: 0x001BE61E File Offset: 0x001BC81E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InteractComponentPb.Descriptor;
			}
		}

		// Token: 0x0600BB6A RID: 47978 RVA: 0x001BE625 File Offset: 0x001BC825
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractComponentPb()
		{
		}

		// Token: 0x0600BB6B RID: 47979 RVA: 0x001BE644 File Offset: 0x001BC844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractComponentPb(InteractComponentPb other) : this()
		{
			this.dynamicInteractInfos_ = other.dynamicInteractInfos_.Clone();
			this.randomInteractIndex_ = other.randomInteractIndex_.Clone();
			this.interacting_ = other.interacting_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BB6C RID: 47980 RVA: 0x001BE696 File Offset: 0x001BC896
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractComponentPb Clone()
		{
			return new InteractComponentPb(this);
		}

		// Token: 0x170025DA RID: 9690
		// (get) Token: 0x0600BB6D RID: 47981 RVA: 0x001BE69E File Offset: 0x001BC89E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DynamicInteractInfo> DynamicInteractInfos
		{
			get
			{
				return this.dynamicInteractInfos_;
			}
		}

		// Token: 0x170025DB RID: 9691
		// (get) Token: 0x0600BB6E RID: 47982 RVA: 0x001BE6A6 File Offset: 0x001BC8A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RandomInteractIndex
		{
			get
			{
				return this.randomInteractIndex_;
			}
		}

		// Token: 0x170025DC RID: 9692
		// (get) Token: 0x0600BB6F RID: 47983 RVA: 0x001BE6AE File Offset: 0x001BC8AE
		// (set) Token: 0x0600BB70 RID: 47984 RVA: 0x001BE6B6 File Offset: 0x001BC8B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Interacting
		{
			get
			{
				return this.interacting_;
			}
			set
			{
				this.interacting_ = value;
			}
		}

		// Token: 0x0600BB71 RID: 47985 RVA: 0x001BE6BF File Offset: 0x001BC8BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InteractComponentPb);
		}

		// Token: 0x0600BB72 RID: 47986 RVA: 0x001BE6D0 File Offset: 0x001BC8D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InteractComponentPb other)
		{
			return other != null && (other == this || (this.dynamicInteractInfos_.Equals(other.dynamicInteractInfos_) && this.randomInteractIndex_.Equals(other.randomInteractIndex_) && this.Interacting == other.Interacting && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BB73 RID: 47987 RVA: 0x001BE734 File Offset: 0x001BC934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.dynamicInteractInfos_.GetHashCode();
			num ^= this.randomInteractIndex_.GetHashCode();
			if (this.Interacting)
			{
				num ^= this.Interacting.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BB74 RID: 47988 RVA: 0x001BE78F File Offset: 0x001BC98F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BB75 RID: 47989 RVA: 0x001BE79C File Offset: 0x001BC99C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BB76 RID: 47990 RVA: 0x001BE7A8 File Offset: 0x001BC9A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.dynamicInteractInfos_.WriteTo(ref output, InteractComponentPb._repeated_dynamicInteractInfos_codec);
			this.randomInteractIndex_.WriteTo(ref output, InteractComponentPb._repeated_randomInteractIndex_codec);
			if (this.Interacting)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.Interacting);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BB77 RID: 47991 RVA: 0x001BE808 File Offset: 0x001BCA08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.dynamicInteractInfos_.CalculateSize(InteractComponentPb._repeated_dynamicInteractInfos_codec);
			num += this.randomInteractIndex_.CalculateSize(InteractComponentPb._repeated_randomInteractIndex_codec);
			if (this.Interacting)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BB78 RID: 47992 RVA: 0x001BE860 File Offset: 0x001BCA60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InteractComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			this.dynamicInteractInfos_.Add(other.dynamicInteractInfos_);
			this.randomInteractIndex_.Add(other.randomInteractIndex_);
			if (other.Interacting)
			{
				this.Interacting = other.Interacting;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BB79 RID: 47993 RVA: 0x001BE8BE File Offset: 0x001BCABE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BB7A RID: 47994 RVA: 0x001BE8C8 File Offset: 0x001BCAC8
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
				if (num <= 16U)
				{
					if (num == 10U)
					{
						this.dynamicInteractInfos_.AddEntriesFrom(ref input, InteractComponentPb._repeated_dynamicInteractInfos_codec);
						continue;
					}
					if (num == 16U)
					{
						goto IL_4B;
					}
				}
				else
				{
					if (num == 18U)
					{
						goto IL_4B;
					}
					if (num == 24U)
					{
						this.Interacting = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4B:
				this.randomInteractIndex_.AddEntriesFrom(ref input, InteractComponentPb._repeated_randomInteractIndex_codec);
			}
		}

		// Token: 0x04005242 RID: 21058
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005243 RID: 21059
		public const int DynamicInteractInfosFieldNumber = 1;

		// Token: 0x04005244 RID: 21060
		private static readonly FieldCodec<DynamicInteractInfo> _repeated_dynamicInteractInfos_codec = FieldCodec.ForMessage<DynamicInteractInfo>(10U, DynamicInteractInfo.Parser);

		// Token: 0x04005245 RID: 21061
		private readonly RepeatedField<DynamicInteractInfo> dynamicInteractInfos_ = new RepeatedField<DynamicInteractInfo>();

		// Token: 0x04005246 RID: 21062
		public const int RandomInteractIndexFieldNumber = 2;

		// Token: 0x04005247 RID: 21063
		private static readonly FieldCodec<int> _repeated_randomInteractIndex_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04005248 RID: 21064
		private readonly RepeatedField<int> randomInteractIndex_ = new RepeatedField<int>();

		// Token: 0x04005249 RID: 21065
		public const int InteractingFieldNumber = 3;

		// Token: 0x0400524A RID: 21066
		private bool interacting_;
	}
}
