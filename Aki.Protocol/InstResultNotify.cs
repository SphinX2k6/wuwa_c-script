using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000829 RID: 2089
	[NetMessage(EMessageId.InstResultNotify)]
	public sealed class InstResultNotify : IMessage<InstResultNotify>, IMessage, IEquatable<InstResultNotify>, IDeepCloneable<InstResultNotify>, IBufferMessage
	{
		// Token: 0x0600BAA9 RID: 47785 RVA: 0x001BC6F1 File Offset: 0x001BA8F1
		[NullableContext(1)]
		public static InstResultNotify Create()
		{
			return new InstResultNotify();
		}

		// Token: 0x170025A8 RID: 9640
		// (get) Token: 0x0600BAAA RID: 47786 RVA: 0x001BC6F8 File Offset: 0x001BA8F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170025A9 RID: 9641
		// (get) Token: 0x0600BAAB RID: 47787 RVA: 0x001BC6FB File Offset: 0x001BA8FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InstResultNotify.Descriptor;
			}
		}

		// Token: 0x0600BAAC RID: 47788 RVA: 0x001BC702 File Offset: 0x001BA902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstResultNotify()
		{
		}

		// Token: 0x0600BAAD RID: 47789 RVA: 0x001BC70C File Offset: 0x001BA90C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstResultNotify(InstResultNotify other) : this()
		{
			this.id_ = other.id_;
			this.succ_ = other.succ_;
			this.reason_ = other.reason_;
			this.isRecReward_ = other.isRecReward_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BAAE RID: 47790 RVA: 0x001BC760 File Offset: 0x001BA960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstResultNotify Clone()
		{
			return new InstResultNotify(this);
		}

		// Token: 0x170025AA RID: 9642
		// (get) Token: 0x0600BAAF RID: 47791 RVA: 0x001BC768 File Offset: 0x001BA968
		// (set) Token: 0x0600BAB0 RID: 47792 RVA: 0x001BC770 File Offset: 0x001BA970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170025AB RID: 9643
		// (get) Token: 0x0600BAB1 RID: 47793 RVA: 0x001BC779 File Offset: 0x001BA979
		// (set) Token: 0x0600BAB2 RID: 47794 RVA: 0x001BC781 File Offset: 0x001BA981
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Succ
		{
			get
			{
				return this.succ_;
			}
			set
			{
				this.succ_ = value;
			}
		}

		// Token: 0x170025AC RID: 9644
		// (get) Token: 0x0600BAB3 RID: 47795 RVA: 0x001BC78A File Offset: 0x001BA98A
		// (set) Token: 0x0600BAB4 RID: 47796 RVA: 0x001BC792 File Offset: 0x001BA992
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x170025AD RID: 9645
		// (get) Token: 0x0600BAB5 RID: 47797 RVA: 0x001BC79B File Offset: 0x001BA99B
		// (set) Token: 0x0600BAB6 RID: 47798 RVA: 0x001BC7A3 File Offset: 0x001BA9A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsRecReward
		{
			get
			{
				return this.isRecReward_;
			}
			set
			{
				this.isRecReward_ = value;
			}
		}

		// Token: 0x0600BAB7 RID: 47799 RVA: 0x001BC7AC File Offset: 0x001BA9AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InstResultNotify);
		}

		// Token: 0x0600BAB8 RID: 47800 RVA: 0x001BC7BC File Offset: 0x001BA9BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InstResultNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Succ == other.Succ && this.Reason == other.Reason && this.IsRecReward == other.IsRecReward && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BAB9 RID: 47801 RVA: 0x001BC828 File Offset: 0x001BAA28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Succ)
			{
				num ^= this.Succ.GetHashCode();
			}
			if (this.Reason != 0)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this.IsRecReward)
			{
				num ^= this.IsRecReward.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BABA RID: 47802 RVA: 0x001BC8B2 File Offset: 0x001BAAB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BABB RID: 47803 RVA: 0x001BC8BF File Offset: 0x001BAABF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BABC RID: 47804 RVA: 0x001BC8C8 File Offset: 0x001BAAC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Reason != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Reason);
			}
			if (this.Succ)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.Succ);
			}
			if (this.IsRecReward)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.IsRecReward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BABD RID: 47805 RVA: 0x001BC958 File Offset: 0x001BAB58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Succ)
			{
				num += 2;
			}
			if (this.Reason != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Reason);
			}
			if (this.IsRecReward)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BABE RID: 47806 RVA: 0x001BC9C8 File Offset: 0x001BABC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InstResultNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Succ)
			{
				this.Succ = other.Succ;
			}
			if (other.Reason != 0)
			{
				this.Reason = other.Reason;
			}
			if (other.IsRecReward)
			{
				this.IsRecReward = other.IsRecReward;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BABF RID: 47807 RVA: 0x001BCA40 File Offset: 0x001BAC40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BAC0 RID: 47808 RVA: 0x001BCA4C File Offset: 0x001BAC4C
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
				if (num <= 32U)
				{
					if (num == 8U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.Reason = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.Succ = input.ReadBool();
						continue;
					}
					if (num == 112U)
					{
						this.IsRecReward = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040051F4 RID: 20980
		private UnknownFieldSet _unknownFields;

		// Token: 0x040051F5 RID: 20981
		public const int IdFieldNumber = 1;

		// Token: 0x040051F6 RID: 20982
		private int id_;

		// Token: 0x040051F7 RID: 20983
		public const int SuccFieldNumber = 12;

		// Token: 0x040051F8 RID: 20984
		private bool succ_;

		// Token: 0x040051F9 RID: 20985
		public const int ReasonFieldNumber = 4;

		// Token: 0x040051FA RID: 20986
		private int reason_;

		// Token: 0x040051FB RID: 20987
		public const int IsRecRewardFieldNumber = 14;

		// Token: 0x040051FC RID: 20988
		private bool isRecReward_;
	}
}
