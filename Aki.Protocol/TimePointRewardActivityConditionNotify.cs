using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013F0 RID: 5104
	[NetMessage(EMessageId.TimePointRewardActivityConditionNotify)]
	public sealed class TimePointRewardActivityConditionNotify : IMessage<TimePointRewardActivityConditionNotify>, IMessage, IEquatable<TimePointRewardActivityConditionNotify>, IDeepCloneable<TimePointRewardActivityConditionNotify>, IBufferMessage
	{
		// Token: 0x0601B24E RID: 111182 RVA: 0x003F33FD File Offset: 0x003F15FD
		[NullableContext(1)]
		public static TimePointRewardActivityConditionNotify Create()
		{
			return new TimePointRewardActivityConditionNotify();
		}

		// Token: 0x17005BE7 RID: 23527
		// (get) Token: 0x0601B24F RID: 111183 RVA: 0x003F3404 File Offset: 0x003F1604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005BE8 RID: 23528
		// (get) Token: 0x0601B250 RID: 111184 RVA: 0x003F3407 File Offset: 0x003F1607
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimePointRewardActivityConditionNotify.Descriptor;
			}
		}

		// Token: 0x0601B251 RID: 111185 RVA: 0x003F340E File Offset: 0x003F160E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimePointRewardActivityConditionNotify()
		{
		}

		// Token: 0x0601B252 RID: 111186 RVA: 0x003F3418 File Offset: 0x003F1618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimePointRewardActivityConditionNotify(TimePointRewardActivityConditionNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.data_ = ((other.data_ != null) ? other.data_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B253 RID: 111187 RVA: 0x003F3464 File Offset: 0x003F1664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimePointRewardActivityConditionNotify Clone()
		{
			return new TimePointRewardActivityConditionNotify(this);
		}

		// Token: 0x17005BE9 RID: 23529
		// (get) Token: 0x0601B254 RID: 111188 RVA: 0x003F346C File Offset: 0x003F166C
		// (set) Token: 0x0601B255 RID: 111189 RVA: 0x003F3474 File Offset: 0x003F1674
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

		// Token: 0x17005BEA RID: 23530
		// (get) Token: 0x0601B256 RID: 111190 RVA: 0x003F347D File Offset: 0x003F167D
		// (set) Token: 0x0601B257 RID: 111191 RVA: 0x003F3485 File Offset: 0x003F1685
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimePointRewardActivityData Data
		{
			get
			{
				return this.data_;
			}
			set
			{
				this.data_ = value;
			}
		}

		// Token: 0x0601B258 RID: 111192 RVA: 0x003F348E File Offset: 0x003F168E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimePointRewardActivityConditionNotify);
		}

		// Token: 0x0601B259 RID: 111193 RVA: 0x003F349C File Offset: 0x003F169C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimePointRewardActivityConditionNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this.Data, other.Data) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B25A RID: 111194 RVA: 0x003F34EC File Offset: 0x003F16EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.data_ != null)
			{
				num ^= this.Data.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B25B RID: 111195 RVA: 0x003F3541 File Offset: 0x003F1741
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B25C RID: 111196 RVA: 0x003F354E File Offset: 0x003F174E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B25D RID: 111197 RVA: 0x003F3558 File Offset: 0x003F1758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.data_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.Data);
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

		// Token: 0x0601B25E RID: 111198 RVA: 0x003F35B4 File Offset: 0x003F17B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.data_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Data);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B25F RID: 111199 RVA: 0x003F360C File Offset: 0x003F180C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TimePointRewardActivityConditionNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.data_ != null)
			{
				if (this.data_ == null)
				{
					this.Data = new TimePointRewardActivityData();
				}
				this.Data.MergeFrom(other.Data);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B260 RID: 111200 RVA: 0x003F3674 File Offset: 0x003F1874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B261 RID: 111201 RVA: 0x003F3680 File Offset: 0x003F1880
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
				if (num != 74U)
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
					if (this.data_ == null)
					{
						this.Data = new TimePointRewardActivityData();
					}
					input.ReadMessage(this.Data);
				}
			}
		}

		// Token: 0x04009E63 RID: 40547
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E64 RID: 40548
		public const int ActivityIdFieldNumber = 14;

		// Token: 0x04009E65 RID: 40549
		private int activityId_;

		// Token: 0x04009E66 RID: 40550
		public const int DataFieldNumber = 9;

		// Token: 0x04009E67 RID: 40551
		private TimePointRewardActivityData data_;
	}
}
