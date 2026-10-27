using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200096E RID: 2414
	public sealed class MailBindInfo : IMessage<MailBindInfo>, IMessage, IEquatable<MailBindInfo>, IDeepCloneable<MailBindInfo>, IBufferMessage
	{
		// Token: 0x0600D48E RID: 54414 RVA: 0x001F4CCF File Offset: 0x001F2ECF
		[NullableContext(1)]
		public static MailBindInfo Create()
		{
			return new MailBindInfo();
		}

		// Token: 0x17002B0D RID: 11021
		// (get) Token: 0x0600D48F RID: 54415 RVA: 0x001F4CD6 File Offset: 0x001F2ED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B0E RID: 11022
		// (get) Token: 0x0600D490 RID: 54416 RVA: 0x001F4CD9 File Offset: 0x001F2ED9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MailBindInfo.Descriptor;
			}
		}

		// Token: 0x0600D491 RID: 54417 RVA: 0x001F4CE0 File Offset: 0x001F2EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindInfo()
		{
		}

		// Token: 0x0600D492 RID: 54418 RVA: 0x001F4CE8 File Offset: 0x001F2EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindInfo(MailBindInfo other) : this()
		{
			this.isBind_ = other.isBind_;
			this.isReward_ = other.isReward_;
			this.closeTime_ = other.closeTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D493 RID: 54419 RVA: 0x001F4D25 File Offset: 0x001F2F25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindInfo Clone()
		{
			return new MailBindInfo(this);
		}

		// Token: 0x17002B0F RID: 11023
		// (get) Token: 0x0600D494 RID: 54420 RVA: 0x001F4D2D File Offset: 0x001F2F2D
		// (set) Token: 0x0600D495 RID: 54421 RVA: 0x001F4D35 File Offset: 0x001F2F35
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

		// Token: 0x17002B10 RID: 11024
		// (get) Token: 0x0600D496 RID: 54422 RVA: 0x001F4D3E File Offset: 0x001F2F3E
		// (set) Token: 0x0600D497 RID: 54423 RVA: 0x001F4D46 File Offset: 0x001F2F46
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

		// Token: 0x17002B11 RID: 11025
		// (get) Token: 0x0600D498 RID: 54424 RVA: 0x001F4D4F File Offset: 0x001F2F4F
		// (set) Token: 0x0600D499 RID: 54425 RVA: 0x001F4D57 File Offset: 0x001F2F57
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

		// Token: 0x0600D49A RID: 54426 RVA: 0x001F4D60 File Offset: 0x001F2F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MailBindInfo);
		}

		// Token: 0x0600D49B RID: 54427 RVA: 0x001F4D70 File Offset: 0x001F2F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MailBindInfo other)
		{
			return other != null && (other == this || (this.IsBind == other.IsBind && this.IsReward == other.IsReward && this.CloseTime == other.CloseTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D49C RID: 54428 RVA: 0x001F4DCC File Offset: 0x001F2FCC
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

		// Token: 0x0600D49D RID: 54429 RVA: 0x001F4E3D File Offset: 0x001F303D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D49E RID: 54430 RVA: 0x001F4E4A File Offset: 0x001F304A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D49F RID: 54431 RVA: 0x001F4E54 File Offset: 0x001F3054
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

		// Token: 0x0600D4A0 RID: 54432 RVA: 0x001F4EC8 File Offset: 0x001F30C8
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

		// Token: 0x0600D4A1 RID: 54433 RVA: 0x001F4F20 File Offset: 0x001F3120
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

		// Token: 0x0600D4A2 RID: 54434 RVA: 0x001F4F84 File Offset: 0x001F3184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D4A3 RID: 54435 RVA: 0x001F4F90 File Offset: 0x001F3190
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

		// Token: 0x0400592C RID: 22828
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400592D RID: 22829
		public const int IsBindFieldNumber = 1;

		// Token: 0x0400592E RID: 22830
		private bool isBind_;

		// Token: 0x0400592F RID: 22831
		public const int IsRewardFieldNumber = 2;

		// Token: 0x04005930 RID: 22832
		private bool isReward_;

		// Token: 0x04005931 RID: 22833
		public const int CloseTimeFieldNumber = 3;

		// Token: 0x04005932 RID: 22834
		private long closeTime_;
	}
}
