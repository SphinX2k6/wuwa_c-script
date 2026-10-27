using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001391 RID: 5009
	[NetMessage(EMessageId.TotalTopUpScoreInfoRequest)]
	public sealed class TotalTopUpScoreInfoRequest : IMessage<TotalTopUpScoreInfoRequest>, IMessage, IEquatable<TotalTopUpScoreInfoRequest>, IDeepCloneable<TotalTopUpScoreInfoRequest>, IBufferMessage
	{
		// Token: 0x0601A952 RID: 108882 RVA: 0x003DB500 File Offset: 0x003D9700
		[NullableContext(1)]
		public static TotalTopUpScoreInfoRequest Create()
		{
			return new TotalTopUpScoreInfoRequest();
		}

		// Token: 0x170059A2 RID: 22946
		// (get) Token: 0x0601A953 RID: 108883 RVA: 0x003DB507 File Offset: 0x003D9707
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170059A3 RID: 22947
		// (get) Token: 0x0601A954 RID: 108884 RVA: 0x003DB50A File Offset: 0x003D970A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TotalTopUpScoreInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601A955 RID: 108885 RVA: 0x003DB511 File Offset: 0x003D9711
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpScoreInfoRequest()
		{
		}

		// Token: 0x0601A956 RID: 108886 RVA: 0x003DB519 File Offset: 0x003D9719
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpScoreInfoRequest(TotalTopUpScoreInfoRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A957 RID: 108887 RVA: 0x003DB53E File Offset: 0x003D973E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpScoreInfoRequest Clone()
		{
			return new TotalTopUpScoreInfoRequest(this);
		}

		// Token: 0x170059A4 RID: 22948
		// (get) Token: 0x0601A958 RID: 108888 RVA: 0x003DB546 File Offset: 0x003D9746
		// (set) Token: 0x0601A959 RID: 108889 RVA: 0x003DB54E File Offset: 0x003D974E
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

		// Token: 0x0601A95A RID: 108890 RVA: 0x003DB557 File Offset: 0x003D9757
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TotalTopUpScoreInfoRequest);
		}

		// Token: 0x0601A95B RID: 108891 RVA: 0x003DB565 File Offset: 0x003D9765
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TotalTopUpScoreInfoRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A95C RID: 108892 RVA: 0x003DB594 File Offset: 0x003D9794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A95D RID: 108893 RVA: 0x003DB5D3 File Offset: 0x003D97D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A95E RID: 108894 RVA: 0x003DB5E0 File Offset: 0x003D97E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A95F RID: 108895 RVA: 0x003DB5E9 File Offset: 0x003D97E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A960 RID: 108896 RVA: 0x003DB61C File Offset: 0x003D981C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A961 RID: 108897 RVA: 0x003DB65A File Offset: 0x003D985A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TotalTopUpScoreInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A962 RID: 108898 RVA: 0x003DB68B File Offset: 0x003D988B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A963 RID: 108899 RVA: 0x003DB694 File Offset: 0x003D9894
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009A85 RID: 39557
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A86 RID: 39558
		public const int ActivityIdFieldNumber = 4;

		// Token: 0x04009A87 RID: 39559
		private int activityId_;
	}
}
