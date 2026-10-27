using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000533 RID: 1331
	[NetMessage(EMessageId.FeiXuePreheatInfoRewardRequest)]
	public sealed class FeiXuePreheatInfoRewardRequest : IMessage<FeiXuePreheatInfoRewardRequest>, IMessage, IEquatable<FeiXuePreheatInfoRewardRequest>, IDeepCloneable<FeiXuePreheatInfoRewardRequest>, IBufferMessage
	{
		// Token: 0x06007CAC RID: 31916 RVA: 0x0012DF36 File Offset: 0x0012C136
		[NullableContext(1)]
		public static FeiXuePreheatInfoRewardRequest Create()
		{
			return new FeiXuePreheatInfoRewardRequest();
		}

		// Token: 0x17001832 RID: 6194
		// (get) Token: 0x06007CAD RID: 31917 RVA: 0x0012DF3D File Offset: 0x0012C13D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001833 RID: 6195
		// (get) Token: 0x06007CAE RID: 31918 RVA: 0x0012DF40 File Offset: 0x0012C140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FeiXuePreheatInfoRewardRequest.Descriptor;
			}
		}

		// Token: 0x06007CAF RID: 31919 RVA: 0x0012DF47 File Offset: 0x0012C147
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeiXuePreheatInfoRewardRequest()
		{
		}

		// Token: 0x06007CB0 RID: 31920 RVA: 0x0012DF5A File Offset: 0x0012C15A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeiXuePreheatInfoRewardRequest(FeiXuePreheatInfoRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.feiXuePreheatInfoIds_ = other.feiXuePreheatInfoIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007CB1 RID: 31921 RVA: 0x0012DF90 File Offset: 0x0012C190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeiXuePreheatInfoRewardRequest Clone()
		{
			return new FeiXuePreheatInfoRewardRequest(this);
		}

		// Token: 0x17001834 RID: 6196
		// (get) Token: 0x06007CB2 RID: 31922 RVA: 0x0012DF98 File Offset: 0x0012C198
		// (set) Token: 0x06007CB3 RID: 31923 RVA: 0x0012DFA0 File Offset: 0x0012C1A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17001835 RID: 6197
		// (get) Token: 0x06007CB4 RID: 31924 RVA: 0x0012DFA9 File Offset: 0x0012C1A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> FeiXuePreheatInfoIds
		{
			get
			{
				return this.feiXuePreheatInfoIds_;
			}
		}

		// Token: 0x06007CB5 RID: 31925 RVA: 0x0012DFB1 File Offset: 0x0012C1B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FeiXuePreheatInfoRewardRequest);
		}

		// Token: 0x06007CB6 RID: 31926 RVA: 0x0012DFC0 File Offset: 0x0012C1C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FeiXuePreheatInfoRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.feiXuePreheatInfoIds_.Equals(other.feiXuePreheatInfoIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007CB7 RID: 31927 RVA: 0x0012E010 File Offset: 0x0012C210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.feiXuePreheatInfoIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007CB8 RID: 31928 RVA: 0x0012E05D File Offset: 0x0012C25D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007CB9 RID: 31929 RVA: 0x0012E06A File Offset: 0x0012C26A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007CBA RID: 31930 RVA: 0x0012E074 File Offset: 0x0012C274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActivityId);
			}
			this.feiXuePreheatInfoIds_.WriteTo(ref output, FeiXuePreheatInfoRewardRequest._repeated_feiXuePreheatInfoIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007CBB RID: 31931 RVA: 0x0012E0C4 File Offset: 0x0012C2C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.feiXuePreheatInfoIds_.CalculateSize(FeiXuePreheatInfoRewardRequest._repeated_feiXuePreheatInfoIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007CBC RID: 31932 RVA: 0x0012E118 File Offset: 0x0012C318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FeiXuePreheatInfoRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.feiXuePreheatInfoIds_.Add(other.feiXuePreheatInfoIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007CBD RID: 31933 RVA: 0x0012E165 File Offset: 0x0012C365
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007CBE RID: 31934 RVA: 0x0012E170 File Offset: 0x0012C370
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
					if (num != 48U && num != 50U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.feiXuePreheatInfoIds_.AddEntriesFrom(ref input, FeiXuePreheatInfoRewardRequest._repeated_feiXuePreheatInfoIds_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003F7F RID: 16255
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F80 RID: 16256
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x04003F81 RID: 16257
		private int activityId_;

		// Token: 0x04003F82 RID: 16258
		public const int FeiXuePreheatInfoIdsFieldNumber = 6;

		// Token: 0x04003F83 RID: 16259
		private static readonly FieldCodec<int> _repeated_feiXuePreheatInfoIds_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04003F84 RID: 16260
		private readonly RepeatedField<int> feiXuePreheatInfoIds_ = new RepeatedField<int>();
	}
}
