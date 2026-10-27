using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000332 RID: 818
	[NetMessage(EMessageId.DangoBrawlActivityLimitCoinUpdateNotify)]
	public sealed class DangoBrawlActivityLimitCoinUpdateNotify : IMessage<DangoBrawlActivityLimitCoinUpdateNotify>, IMessage, IEquatable<DangoBrawlActivityLimitCoinUpdateNotify>, IDeepCloneable<DangoBrawlActivityLimitCoinUpdateNotify>, IBufferMessage
	{
		// Token: 0x06005240 RID: 21056 RVA: 0x000C8F03 File Offset: 0x000C7103
		[NullableContext(1)]
		public static DangoBrawlActivityLimitCoinUpdateNotify Create()
		{
			return new DangoBrawlActivityLimitCoinUpdateNotify();
		}

		// Token: 0x17000EE7 RID: 3815
		// (get) Token: 0x06005241 RID: 21057 RVA: 0x000C8F0A File Offset: 0x000C710A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000EE8 RID: 3816
		// (get) Token: 0x06005242 RID: 21058 RVA: 0x000C8F0D File Offset: 0x000C710D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlActivityLimitCoinUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06005243 RID: 21059 RVA: 0x000C8F14 File Offset: 0x000C7114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlActivityLimitCoinUpdateNotify()
		{
		}

		// Token: 0x06005244 RID: 21060 RVA: 0x000C8F1C File Offset: 0x000C711C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlActivityLimitCoinUpdateNotify(DangoBrawlActivityLimitCoinUpdateNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.limitCoinCost_ = other.limitCoinCost_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005245 RID: 21061 RVA: 0x000C8F4D File Offset: 0x000C714D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlActivityLimitCoinUpdateNotify Clone()
		{
			return new DangoBrawlActivityLimitCoinUpdateNotify(this);
		}

		// Token: 0x17000EE9 RID: 3817
		// (get) Token: 0x06005246 RID: 21062 RVA: 0x000C8F55 File Offset: 0x000C7155
		// (set) Token: 0x06005247 RID: 21063 RVA: 0x000C8F5D File Offset: 0x000C715D
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

		// Token: 0x17000EEA RID: 3818
		// (get) Token: 0x06005248 RID: 21064 RVA: 0x000C8F66 File Offset: 0x000C7166
		// (set) Token: 0x06005249 RID: 21065 RVA: 0x000C8F6E File Offset: 0x000C716E
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

		// Token: 0x0600524A RID: 21066 RVA: 0x000C8F77 File Offset: 0x000C7177
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlActivityLimitCoinUpdateNotify);
		}

		// Token: 0x0600524B RID: 21067 RVA: 0x000C8F85 File Offset: 0x000C7185
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlActivityLimitCoinUpdateNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.LimitCoinCost == other.LimitCoinCost && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600524C RID: 21068 RVA: 0x000C8FC4 File Offset: 0x000C71C4
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

		// Token: 0x0600524D RID: 21069 RVA: 0x000C901C File Offset: 0x000C721C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600524E RID: 21070 RVA: 0x000C9029 File Offset: 0x000C7229
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600524F RID: 21071 RVA: 0x000C9034 File Offset: 0x000C7234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LimitCoinCost != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.LimitCoinCost);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005250 RID: 21072 RVA: 0x000C9090 File Offset: 0x000C7290
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

		// Token: 0x06005251 RID: 21073 RVA: 0x000C90E8 File Offset: 0x000C72E8
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

		// Token: 0x06005252 RID: 21074 RVA: 0x000C9138 File Offset: 0x000C7338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005253 RID: 21075 RVA: 0x000C9144 File Offset: 0x000C7344
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
				if (num != 40U)
				{
					if (num != 96U)
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

		// Token: 0x04003327 RID: 13095
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003328 RID: 13096
		public const int ActivityIdFieldNumber = 12;

		// Token: 0x04003329 RID: 13097
		private int activityId_;

		// Token: 0x0400332A RID: 13098
		public const int LimitCoinCostFieldNumber = 5;

		// Token: 0x0400332B RID: 13099
		private int limitCoinCost_;
	}
}
