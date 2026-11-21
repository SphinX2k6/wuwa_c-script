using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002BB RID: 699
	public sealed class CombineEntityInfoPb : IMessage<CombineEntityInfoPb>, IMessage, IEquatable<CombineEntityInfoPb>, IDeepCloneable<CombineEntityInfoPb>, IBufferMessage
	{
		// Token: 0x06004869 RID: 18537 RVA: 0x000B2065 File Offset: 0x000B0265
		[NullableContext(1)]
		public static CombineEntityInfoPb Create()
		{
			return new CombineEntityInfoPb();
		}

		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x0600486A RID: 18538 RVA: 0x000B206C File Offset: 0x000B026C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x0600486B RID: 18539 RVA: 0x000B206F File Offset: 0x000B026F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombineEntityInfoPb.Descriptor;
			}
		}

		// Token: 0x0600486C RID: 18540 RVA: 0x000B2076 File Offset: 0x000B0276
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombineEntityInfoPb()
		{
		}

		// Token: 0x0600486D RID: 18541 RVA: 0x000B2089 File Offset: 0x000B0289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombineEntityInfoPb(CombineEntityInfoPb other) : this()
		{
			this.combinePartInfoList_ = other.combinePartInfoList_.Clone();
			this.targetEntityId_ = other.targetEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600486E RID: 18542 RVA: 0x000B20BF File Offset: 0x000B02BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombineEntityInfoPb Clone()
		{
			return new CombineEntityInfoPb(this);
		}

		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x0600486F RID: 18543 RVA: 0x000B20C7 File Offset: 0x000B02C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CombinePartInfo> CombinePartInfoList
		{
			get
			{
				return this.combinePartInfoList_;
			}
		}

		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x06004870 RID: 18544 RVA: 0x000B20CF File Offset: 0x000B02CF
		// (set) Token: 0x06004871 RID: 18545 RVA: 0x000B20D7 File Offset: 0x000B02D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TargetEntityId
		{
			get
			{
				return this.targetEntityId_;
			}
			set
			{
				this.targetEntityId_ = value;
			}
		}

		// Token: 0x06004872 RID: 18546 RVA: 0x000B20E0 File Offset: 0x000B02E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombineEntityInfoPb);
		}

		// Token: 0x06004873 RID: 18547 RVA: 0x000B20F0 File Offset: 0x000B02F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombineEntityInfoPb other)
		{
			return other != null && (other == this || (this.combinePartInfoList_.Equals(other.combinePartInfoList_) && this.TargetEntityId == other.TargetEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004874 RID: 18548 RVA: 0x000B2140 File Offset: 0x000B0340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.combinePartInfoList_.GetHashCode();
			if (this.TargetEntityId != 0L)
			{
				num ^= this.TargetEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004875 RID: 18549 RVA: 0x000B218D File Offset: 0x000B038D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004876 RID: 18550 RVA: 0x000B219A File Offset: 0x000B039A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004877 RID: 18551 RVA: 0x000B21A4 File Offset: 0x000B03A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.combinePartInfoList_.WriteTo(ref output, CombineEntityInfoPb._repeated_combinePartInfoList_codec);
			if (this.TargetEntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.TargetEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004878 RID: 18552 RVA: 0x000B21F4 File Offset: 0x000B03F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.combinePartInfoList_.CalculateSize(CombineEntityInfoPb._repeated_combinePartInfoList_codec);
			if (this.TargetEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TargetEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004879 RID: 18553 RVA: 0x000B2248 File Offset: 0x000B0448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CombineEntityInfoPb other)
		{
			if (other == null)
			{
				return;
			}
			this.combinePartInfoList_.Add(other.combinePartInfoList_);
			if (other.TargetEntityId != 0L)
			{
				this.TargetEntityId = other.TargetEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600487A RID: 18554 RVA: 0x000B2295 File Offset: 0x000B0495
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600487B RID: 18555 RVA: 0x000B22A0 File Offset: 0x000B04A0
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TargetEntityId = input.ReadInt64();
					}
				}
				else
				{
					this.combinePartInfoList_.AddEntriesFrom(ref input, CombineEntityInfoPb._repeated_combinePartInfoList_codec);
				}
			}
		}

		// Token: 0x04003041 RID: 12353
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003042 RID: 12354
		public const int CombinePartInfoListFieldNumber = 1;

		// Token: 0x04003043 RID: 12355
		private static readonly FieldCodec<CombinePartInfo> _repeated_combinePartInfoList_codec = FieldCodec.ForMessage<CombinePartInfo>(10U, CombinePartInfo.Parser);

		// Token: 0x04003044 RID: 12356
		private readonly RepeatedField<CombinePartInfo> combinePartInfoList_ = new RepeatedField<CombinePartInfo>();

		// Token: 0x04003045 RID: 12357
		public const int TargetEntityIdFieldNumber = 2;

		// Token: 0x04003046 RID: 12358
		private long targetEntityId_;
	}
}
