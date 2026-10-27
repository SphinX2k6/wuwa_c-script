using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001E4 RID: 484
	[NetMessage(EMessageId.BrochureRewardRequest)]
	public sealed class BrochureRewardRequest : IMessage<BrochureRewardRequest>, IMessage, IEquatable<BrochureRewardRequest>, IDeepCloneable<BrochureRewardRequest>, IBufferMessage
	{
		// Token: 0x0600366B RID: 13931 RVA: 0x000888A1 File Offset: 0x00086AA1
		[NullableContext(1)]
		public static BrochureRewardRequest Create()
		{
			return new BrochureRewardRequest();
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x0600366C RID: 13932 RVA: 0x000888A8 File Offset: 0x00086AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x0600366D RID: 13933 RVA: 0x000888AB File Offset: 0x00086AAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BrochureRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600366E RID: 13934 RVA: 0x000888B2 File Offset: 0x00086AB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BrochureRewardRequest()
		{
		}

		// Token: 0x0600366F RID: 13935 RVA: 0x000888C8 File Offset: 0x00086AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BrochureRewardRequest(BrochureRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.brochureId_ = other.brochureId_;
			this.bookItems_ = other.bookItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003670 RID: 13936 RVA: 0x00088915 File Offset: 0x00086B15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BrochureRewardRequest Clone()
		{
			return new BrochureRewardRequest(this);
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x06003671 RID: 13937 RVA: 0x0008891D File Offset: 0x00086B1D
		// (set) Token: 0x06003672 RID: 13938 RVA: 0x00088925 File Offset: 0x00086B25
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

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06003673 RID: 13939 RVA: 0x0008892E File Offset: 0x00086B2E
		// (set) Token: 0x06003674 RID: 13940 RVA: 0x00088936 File Offset: 0x00086B36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BrochureId
		{
			get
			{
				return this.brochureId_;
			}
			set
			{
				this.brochureId_ = value;
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06003675 RID: 13941 RVA: 0x0008893F File Offset: 0x00086B3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BookItems
		{
			get
			{
				return this.bookItems_;
			}
		}

		// Token: 0x06003676 RID: 13942 RVA: 0x00088947 File Offset: 0x00086B47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BrochureRewardRequest);
		}

		// Token: 0x06003677 RID: 13943 RVA: 0x00088958 File Offset: 0x00086B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BrochureRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.BrochureId == other.BrochureId && this.bookItems_.Equals(other.bookItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003678 RID: 13944 RVA: 0x000889B8 File Offset: 0x00086BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.BrochureId != 0)
			{
				num ^= this.BrochureId.GetHashCode();
			}
			num ^= this.bookItems_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003679 RID: 13945 RVA: 0x00088A1E File Offset: 0x00086C1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600367A RID: 13946 RVA: 0x00088A2B File Offset: 0x00086C2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600367B RID: 13947 RVA: 0x00088A34 File Offset: 0x00086C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BrochureId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.BrochureId);
			}
			this.bookItems_.WriteTo(ref output, BrochureRewardRequest._repeated_bookItems_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600367C RID: 13948 RVA: 0x00088AA0 File Offset: 0x00086CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.BrochureId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BrochureId);
			}
			num += this.bookItems_.CalculateSize(BrochureRewardRequest._repeated_bookItems_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600367D RID: 13949 RVA: 0x00088B0C File Offset: 0x00086D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BrochureRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.BrochureId != 0)
			{
				this.BrochureId = other.BrochureId;
			}
			this.bookItems_.Add(other.bookItems_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600367E RID: 13950 RVA: 0x00088B6D File Offset: 0x00086D6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600367F RID: 13951 RVA: 0x00088B78 File Offset: 0x00086D78
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
				if (num <= 104U)
				{
					if (num == 96U)
					{
						this.BrochureId = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						goto IL_46;
					}
				}
				else
				{
					if (num == 106U)
					{
						goto IL_46;
					}
					if (num == 120U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_46:
				this.bookItems_.AddEntriesFrom(ref input, BrochureRewardRequest._repeated_bookItems_codec);
			}
		}

		// Token: 0x04002A9F RID: 10911
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002AA0 RID: 10912
		public const int ActivityIdFieldNumber = 15;

		// Token: 0x04002AA1 RID: 10913
		private int activityId_;

		// Token: 0x04002AA2 RID: 10914
		public const int BrochureIdFieldNumber = 12;

		// Token: 0x04002AA3 RID: 10915
		private int brochureId_;

		// Token: 0x04002AA4 RID: 10916
		public const int BookItemsFieldNumber = 13;

		// Token: 0x04002AA5 RID: 10917
		private static readonly FieldCodec<int> _repeated_bookItems_codec = FieldCodec.ForInt32(106U);

		// Token: 0x04002AA6 RID: 10918
		private readonly RepeatedField<int> bookItems_ = new RepeatedField<int>();
	}
}
