using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200095D RID: 2397
	public sealed class MailBindInfo : IMessage<MailBindInfo>, IMessage, IEquatable<MailBindInfo>, IDeepCloneable<MailBindInfo>, IBufferMessage
	{
		// Token: 0x0600D374 RID: 54132 RVA: 0x001F2AE7 File Offset: 0x001F0CE7
		[NullableContext(1)]
		public static MailBindInfo Create()
		{
			return new MailBindInfo();
		}

		// Token: 0x17002ACF RID: 10959
		// (get) Token: 0x0600D375 RID: 54133 RVA: 0x001F2AEE File Offset: 0x001F0CEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002AD0 RID: 10960
		// (get) Token: 0x0600D376 RID: 54134 RVA: 0x001F2AF1 File Offset: 0x001F0CF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MailBindInfo.Descriptor;
			}
		}

		// Token: 0x0600D377 RID: 54135 RVA: 0x001F2AF8 File Offset: 0x001F0CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindInfo()
		{
		}

		// Token: 0x0600D378 RID: 54136 RVA: 0x001F2B00 File Offset: 0x001F0D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindInfo(MailBindInfo other) : this()
		{
			this.isBind_ = other.isBind_;
			this.isReward_ = other.isReward_;
			this.closeTime_ = other.closeTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D379 RID: 54137 RVA: 0x001F2B3D File Offset: 0x001F0D3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindInfo Clone()
		{
			return new MailBindInfo(this);
		}

		// Token: 0x17002AD1 RID: 10961
		// (get) Token: 0x0600D37A RID: 54138 RVA: 0x001F2B45 File Offset: 0x001F0D45
		// (set) Token: 0x0600D37B RID: 54139 RVA: 0x001F2B4D File Offset: 0x001F0D4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsBind
		{
			get
			{
				return this.isBind_;
			}
			set
			{
				this.isBind_ = value;
			}
		}

		// Token: 0x17002AD2 RID: 10962
		// (get) Token: 0x0600D37C RID: 54140 RVA: 0x001F2B56 File Offset: 0x001F0D56
		// (set) Token: 0x0600D37D RID: 54141 RVA: 0x001F2B5E File Offset: 0x001F0D5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsReward
		{
			get
			{
				return this.isReward_;
			}
			set
			{
				this.isReward_ = value;
			}
		}

		// Token: 0x17002AD3 RID: 10963
		// (get) Token: 0x0600D37E RID: 54142 RVA: 0x001F2B67 File Offset: 0x001F0D67
		// (set) Token: 0x0600D37F RID: 54143 RVA: 0x001F2B6F File Offset: 0x001F0D6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CloseTime
		{
			get
			{
				return this.closeTime_;
			}
			set
			{
				this.closeTime_ = value;
			}
		}

		// Token: 0x0600D380 RID: 54144 RVA: 0x001F2B78 File Offset: 0x001F0D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MailBindInfo);
		}

		// Token: 0x0600D381 RID: 54145 RVA: 0x001F2B88 File Offset: 0x001F0D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MailBindInfo other)
		{
			return other != null && (other == this || (this.IsBind == other.IsBind && this.IsReward == other.IsReward && this.CloseTime == other.CloseTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D382 RID: 54146 RVA: 0x001F2BE4 File Offset: 0x001F0DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsBind)
			{
				num ^= this.IsBind.GetHashCode();
			}
			if (this.IsReward)
			{
				num ^= this.IsReward.GetHashCode();
			}
			if (this.CloseTime != 0L)
			{
				num ^= this.CloseTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D383 RID: 54147 RVA: 0x001F2C55 File Offset: 0x001F0E55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D384 RID: 54148 RVA: 0x001F2C62 File Offset: 0x001F0E62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D385 RID: 54149 RVA: 0x001F2C6C File Offset: 0x001F0E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsBind)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsBind);
			}
			if (this.IsReward)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsReward);
			}
			if (this.CloseTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.CloseTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D386 RID: 54150 RVA: 0x001F2CE0 File Offset: 0x001F0EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsBind)
			{
				num += 2;
			}
			if (this.IsReward)
			{
				num += 2;
			}
			if (this.CloseTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CloseTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D387 RID: 54151 RVA: 0x001F2D38 File Offset: 0x001F0F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MailBindInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsBind)
			{
				this.IsBind = other.IsBind;
			}
			if (other.IsReward)
			{
				this.IsReward = other.IsReward;
			}
			if (other.CloseTime != 0L)
			{
				this.CloseTime = other.CloseTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D388 RID: 54152 RVA: 0x001F2D9C File Offset: 0x001F0F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D389 RID: 54153 RVA: 0x001F2DA8 File Offset: 0x001F0FA8
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
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.CloseTime = input.ReadInt64();
						}
					}
					else
					{
						this.IsReward = input.ReadBool();
					}
				}
				else
				{
					this.IsBind = input.ReadBool();
				}
			}
		}

		// Token: 0x04005935 RID: 22837
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005936 RID: 22838
		public const int IsBindFieldNumber = 1;

		// Token: 0x04005937 RID: 22839
		private bool isBind_;

		// Token: 0x04005938 RID: 22840
		public const int IsRewardFieldNumber = 2;

		// Token: 0x04005939 RID: 22841
		private bool isReward_;

		// Token: 0x0400593A RID: 22842
		public const int CloseTimeFieldNumber = 3;

		// Token: 0x0400593B RID: 22843
		private long closeTime_;
	}
}
