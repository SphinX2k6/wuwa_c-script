using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CB8 RID: 3256
	[NetMessage(EMessageId.PhantomCollectUpdateNotify)]
	public sealed class PhantomCollectUpdateNotify : IMessage<PhantomCollectUpdateNotify>, IMessage, IEquatable<PhantomCollectUpdateNotify>, IDeepCloneable<PhantomCollectUpdateNotify>, IBufferMessage
	{
		// Token: 0x06011A73 RID: 72307 RVA: 0x00296033 File Offset: 0x00294233
		[NullableContext(1)]
		public static PhantomCollectUpdateNotify Create()
		{
			return new PhantomCollectUpdateNotify();
		}

		// Token: 0x17003A7B RID: 14971
		// (get) Token: 0x06011A74 RID: 72308 RVA: 0x0029603A File Offset: 0x0029423A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A7C RID: 14972
		// (get) Token: 0x06011A75 RID: 72309 RVA: 0x0029603D File Offset: 0x0029423D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomCollectUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06011A76 RID: 72310 RVA: 0x00296044 File Offset: 0x00294244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectUpdateNotify()
		{
		}

		// Token: 0x06011A77 RID: 72311 RVA: 0x0029604C File Offset: 0x0029424C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectUpdateNotify(PhantomCollectUpdateNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.phantomCollectReward_ = ((other.phantomCollectReward_ != null) ? other.phantomCollectReward_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011A78 RID: 72312 RVA: 0x00296098 File Offset: 0x00294298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectUpdateNotify Clone()
		{
			return new PhantomCollectUpdateNotify(this);
		}

		// Token: 0x17003A7D RID: 14973
		// (get) Token: 0x06011A79 RID: 72313 RVA: 0x002960A0 File Offset: 0x002942A0
		// (set) Token: 0x06011A7A RID: 72314 RVA: 0x002960A8 File Offset: 0x002942A8
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

		// Token: 0x17003A7E RID: 14974
		// (get) Token: 0x06011A7B RID: 72315 RVA: 0x002960B1 File Offset: 0x002942B1
		// (set) Token: 0x06011A7C RID: 72316 RVA: 0x002960B9 File Offset: 0x002942B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectReward PhantomCollectReward
		{
			get
			{
				return this.phantomCollectReward_;
			}
			set
			{
				this.phantomCollectReward_ = value;
			}
		}

		// Token: 0x06011A7D RID: 72317 RVA: 0x002960C2 File Offset: 0x002942C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomCollectUpdateNotify);
		}

		// Token: 0x06011A7E RID: 72318 RVA: 0x002960D0 File Offset: 0x002942D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomCollectUpdateNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this.PhantomCollectReward, other.PhantomCollectReward) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011A7F RID: 72319 RVA: 0x00296120 File Offset: 0x00294320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.phantomCollectReward_ != null)
			{
				num ^= this.PhantomCollectReward.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011A80 RID: 72320 RVA: 0x00296175 File Offset: 0x00294375
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011A81 RID: 72321 RVA: 0x00296182 File Offset: 0x00294382
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011A82 RID: 72322 RVA: 0x0029618C File Offset: 0x0029438C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.phantomCollectReward_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.PhantomCollectReward);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011A83 RID: 72323 RVA: 0x002961E8 File Offset: 0x002943E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.phantomCollectReward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomCollectReward);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011A84 RID: 72324 RVA: 0x00296240 File Offset: 0x00294440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomCollectUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.phantomCollectReward_ != null)
			{
				if (this.phantomCollectReward_ == null)
				{
					this.PhantomCollectReward = new PhantomCollectReward();
				}
				this.PhantomCollectReward.MergeFrom(other.PhantomCollectReward);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011A85 RID: 72325 RVA: 0x002962A8 File Offset: 0x002944A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011A86 RID: 72326 RVA: 0x002962B4 File Offset: 0x002944B4
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
					if (num != 80U)
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
					if (this.phantomCollectReward_ == null)
					{
						this.PhantomCollectReward = new PhantomCollectReward();
					}
					input.ReadMessage(this.PhantomCollectReward);
				}
			}
		}

		// Token: 0x04006F7A RID: 28538
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F7B RID: 28539
		public const int ActivityIdFieldNumber = 10;

		// Token: 0x04006F7C RID: 28540
		private int activityId_;

		// Token: 0x04006F7D RID: 28541
		public const int PhantomCollectRewardFieldNumber = 9;

		// Token: 0x04006F7E RID: 28542
		private PhantomCollectReward phantomCollectReward_;
	}
}
