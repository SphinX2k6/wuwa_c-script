using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200033A RID: 826
	[NetMessage(EMessageId.DangoBrawlActivityLimitCoinUpdateNotify)]
	public sealed class DangoBrawlActivityLimitCoinUpdateNotify : IMessage<DangoBrawlActivityLimitCoinUpdateNotify>, IMessage, IEquatable<DangoBrawlActivityLimitCoinUpdateNotify>, IDeepCloneable<DangoBrawlActivityLimitCoinUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600532D RID: 21293 RVA: 0x000CB587 File Offset: 0x000C9787
		[NullableContext(1)]
		public static DangoBrawlActivityLimitCoinUpdateNotify Create()
		{
			return new DangoBrawlActivityLimitCoinUpdateNotify();
		}

		// Token: 0x17000F18 RID: 3864
		// (get) Token: 0x0600532E RID: 21294 RVA: 0x000CB58E File Offset: 0x000C978E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F19 RID: 3865
		// (get) Token: 0x0600532F RID: 21295 RVA: 0x000CB591 File Offset: 0x000C9791
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlActivityLimitCoinUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06005330 RID: 21296 RVA: 0x000CB598 File Offset: 0x000C9798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlActivityLimitCoinUpdateNotify()
		{
		}

		// Token: 0x06005331 RID: 21297 RVA: 0x000CB5A0 File Offset: 0x000C97A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlActivityLimitCoinUpdateNotify(DangoBrawlActivityLimitCoinUpdateNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.limitCoinCost_ = other.limitCoinCost_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005332 RID: 21298 RVA: 0x000CB5D1 File Offset: 0x000C97D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlActivityLimitCoinUpdateNotify Clone()
		{
			return new DangoBrawlActivityLimitCoinUpdateNotify(this);
		}

		// Token: 0x17000F1A RID: 3866
		// (get) Token: 0x06005333 RID: 21299 RVA: 0x000CB5D9 File Offset: 0x000C97D9
		// (set) Token: 0x06005334 RID: 21300 RVA: 0x000CB5E1 File Offset: 0x000C97E1
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

		// Token: 0x17000F1B RID: 3867
		// (get) Token: 0x06005335 RID: 21301 RVA: 0x000CB5EA File Offset: 0x000C97EA
		// (set) Token: 0x06005336 RID: 21302 RVA: 0x000CB5F2 File Offset: 0x000C97F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LimitCoinCost
		{
			get
			{
				return this.limitCoinCost_;
			}
			set
			{
				this.limitCoinCost_ = value;
			}
		}

		// Token: 0x06005337 RID: 21303 RVA: 0x000CB5FB File Offset: 0x000C97FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlActivityLimitCoinUpdateNotify);
		}

		// Token: 0x06005338 RID: 21304 RVA: 0x000CB609 File Offset: 0x000C9809
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlActivityLimitCoinUpdateNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.LimitCoinCost == other.LimitCoinCost && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005339 RID: 21305 RVA: 0x000CB648 File Offset: 0x000C9848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.LimitCoinCost != 0)
			{
				num ^= this.LimitCoinCost.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600533A RID: 21306 RVA: 0x000CB6A0 File Offset: 0x000C98A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600533B RID: 21307 RVA: 0x000CB6AD File Offset: 0x000C98AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600533C RID: 21308 RVA: 0x000CB6B8 File Offset: 0x000C98B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LimitCoinCost != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.LimitCoinCost);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600533D RID: 21309 RVA: 0x000CB714 File Offset: 0x000C9914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.LimitCoinCost != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LimitCoinCost);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600533E RID: 21310 RVA: 0x000CB76C File Offset: 0x000C996C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlActivityLimitCoinUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.LimitCoinCost != 0)
			{
				this.LimitCoinCost = other.LimitCoinCost;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600533F RID: 21311 RVA: 0x000CB7BC File Offset: 0x000C99BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005340 RID: 21312 RVA: 0x000CB7C8 File Offset: 0x000C99C8
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
				if (num != 88U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.LimitCoinCost = input.ReadInt32();
				}
			}
		}

		// Token: 0x040033C3 RID: 13251
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033C4 RID: 13252
		public const int ActivityIdFieldNumber = 14;

		// Token: 0x040033C5 RID: 13253
		private int activityId_;

		// Token: 0x040033C6 RID: 13254
		public const int LimitCoinCostFieldNumber = 11;

		// Token: 0x040033C7 RID: 13255
		private int limitCoinCost_;
	}
}
