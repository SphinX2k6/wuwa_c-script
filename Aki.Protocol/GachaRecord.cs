using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000686 RID: 1670
	public sealed class GachaRecord : IMessage<GachaRecord>, IMessage, IEquatable<GachaRecord>, IDeepCloneable<GachaRecord>, IBufferMessage
	{
		// Token: 0x0600996E RID: 39278 RVA: 0x00172DF0 File Offset: 0x00170FF0
		[NullableContext(1)]
		public static GachaRecord Create()
		{
			return new GachaRecord();
		}

		// Token: 0x17001EAD RID: 7853
		// (get) Token: 0x0600996F RID: 39279 RVA: 0x00172DF7 File Offset: 0x00170FF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001EAE RID: 7854
		// (get) Token: 0x06009970 RID: 39280 RVA: 0x00172DFA File Offset: 0x00170FFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaRecord.Descriptor;
			}
		}

		// Token: 0x06009971 RID: 39281 RVA: 0x00172E01 File Offset: 0x00171001
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaRecord()
		{
		}

		// Token: 0x06009972 RID: 39282 RVA: 0x00172E0C File Offset: 0x0017100C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaRecord(GachaRecord other) : this()
		{
			this.gachaReward_ = ((other.gachaReward_ != null) ? other.gachaReward_.Clone() : null);
			this.gachaTime_ = other.gachaTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009973 RID: 39283 RVA: 0x00172E58 File Offset: 0x00171058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaRecord Clone()
		{
			return new GachaRecord(this);
		}

		// Token: 0x17001EAF RID: 7855
		// (get) Token: 0x06009974 RID: 39284 RVA: 0x00172E60 File Offset: 0x00171060
		// (set) Token: 0x06009975 RID: 39285 RVA: 0x00172E68 File Offset: 0x00171068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaReward GachaReward
		{
			get
			{
				return this.gachaReward_;
			}
			set
			{
				this.gachaReward_ = value;
			}
		}

		// Token: 0x17001EB0 RID: 7856
		// (get) Token: 0x06009976 RID: 39286 RVA: 0x00172E71 File Offset: 0x00171071
		// (set) Token: 0x06009977 RID: 39287 RVA: 0x00172E79 File Offset: 0x00171079
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long GachaTime
		{
			get
			{
				return this.gachaTime_;
			}
			set
			{
				this.gachaTime_ = value;
			}
		}

		// Token: 0x06009978 RID: 39288 RVA: 0x00172E82 File Offset: 0x00171082
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaRecord);
		}

		// Token: 0x06009979 RID: 39289 RVA: 0x00172E90 File Offset: 0x00171090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaRecord other)
		{
			return other != null && (other == this || (object.Equals(this.GachaReward, other.GachaReward) && this.GachaTime == other.GachaTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600997A RID: 39290 RVA: 0x00172EE0 File Offset: 0x001710E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.gachaReward_ != null)
			{
				num ^= this.GachaReward.GetHashCode();
			}
			if (this.GachaTime != 0L)
			{
				num ^= this.GachaTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600997B RID: 39291 RVA: 0x00172F35 File Offset: 0x00171135
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600997C RID: 39292 RVA: 0x00172F42 File Offset: 0x00171142
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600997D RID: 39293 RVA: 0x00172F4C File Offset: 0x0017114C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.gachaReward_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.GachaReward);
			}
			if (this.GachaTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.GachaTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600997E RID: 39294 RVA: 0x00172FA8 File Offset: 0x001711A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.gachaReward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GachaReward);
			}
			if (this.GachaTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.GachaTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600997F RID: 39295 RVA: 0x00173000 File Offset: 0x00171200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaRecord other)
		{
			if (other == null)
			{
				return;
			}
			if (other.gachaReward_ != null)
			{
				if (this.gachaReward_ == null)
				{
					this.GachaReward = new GachaReward();
				}
				this.GachaReward.MergeFrom(other.GachaReward);
			}
			if (other.GachaTime != 0L)
			{
				this.GachaTime = other.GachaTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009980 RID: 39296 RVA: 0x00173068 File Offset: 0x00171268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009981 RID: 39297 RVA: 0x00173074 File Offset: 0x00171274
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
						this.GachaTime = input.ReadInt64();
					}
				}
				else
				{
					if (this.gachaReward_ == null)
					{
						this.GachaReward = new GachaReward();
					}
					input.ReadMessage(this.GachaReward);
				}
			}
		}

		// Token: 0x0400492C RID: 18732
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400492D RID: 18733
		public const int GachaRewardFieldNumber = 1;

		// Token: 0x0400492E RID: 18734
		private GachaReward gachaReward_;

		// Token: 0x0400492F RID: 18735
		public const int GachaTimeFieldNumber = 2;

		// Token: 0x04004930 RID: 18736
		private long gachaTime_;
	}
}
