using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005E1 RID: 1505
	[NetMessage(EMessageId.FloroRanchSettleRequest)]
	public sealed class FloroRanchSettleRequest : IMessage<FloroRanchSettleRequest>, IMessage, IEquatable<FloroRanchSettleRequest>, IDeepCloneable<FloroRanchSettleRequest>, IBufferMessage
	{
		// Token: 0x06008B29 RID: 35625 RVA: 0x001504FE File Offset: 0x0014E6FE
		[NullableContext(1)]
		public static FloroRanchSettleRequest Create()
		{
			return new FloroRanchSettleRequest();
		}

		// Token: 0x17001B71 RID: 7025
		// (get) Token: 0x06008B2A RID: 35626 RVA: 0x00150505 File Offset: 0x0014E705
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B72 RID: 7026
		// (get) Token: 0x06008B2B RID: 35627 RVA: 0x00150508 File Offset: 0x0014E708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchSettleRequest.Descriptor;
			}
		}

		// Token: 0x06008B2C RID: 35628 RVA: 0x0015050F File Offset: 0x0014E70F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchSettleRequest()
		{
		}

		// Token: 0x06008B2D RID: 35629 RVA: 0x00150517 File Offset: 0x0014E717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchSettleRequest(FloroRanchSettleRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.subInsId_ = other.subInsId_;
			this.settle_ = other.settle_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008B2E RID: 35630 RVA: 0x00150554 File Offset: 0x0014E754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchSettleRequest Clone()
		{
			return new FloroRanchSettleRequest(this);
		}

		// Token: 0x17001B73 RID: 7027
		// (get) Token: 0x06008B2F RID: 35631 RVA: 0x0015055C File Offset: 0x0014E75C
		// (set) Token: 0x06008B30 RID: 35632 RVA: 0x00150564 File Offset: 0x0014E764
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

		// Token: 0x17001B74 RID: 7028
		// (get) Token: 0x06008B31 RID: 35633 RVA: 0x0015056D File Offset: 0x0014E76D
		// (set) Token: 0x06008B32 RID: 35634 RVA: 0x00150575 File Offset: 0x0014E775
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubInsId
		{
			get
			{
				return this.subInsId_;
			}
			set
			{
				this.subInsId_ = value;
			}
		}

		// Token: 0x17001B75 RID: 7029
		// (get) Token: 0x06008B33 RID: 35635 RVA: 0x0015057E File Offset: 0x0014E77E
		// (set) Token: 0x06008B34 RID: 35636 RVA: 0x00150586 File Offset: 0x0014E786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Settle
		{
			get
			{
				return this.settle_;
			}
			set
			{
				this.settle_ = value;
			}
		}

		// Token: 0x06008B35 RID: 35637 RVA: 0x0015058F File Offset: 0x0014E78F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchSettleRequest);
		}

		// Token: 0x06008B36 RID: 35638 RVA: 0x001505A0 File Offset: 0x0014E7A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchSettleRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.SubInsId == other.SubInsId && this.Settle == other.Settle && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008B37 RID: 35639 RVA: 0x001505FC File Offset: 0x0014E7FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.SubInsId != 0)
			{
				num ^= this.SubInsId.GetHashCode();
			}
			if (this.Settle)
			{
				num ^= this.Settle.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008B38 RID: 35640 RVA: 0x0015066D File Offset: 0x0014E86D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008B39 RID: 35641 RVA: 0x0015067A File Offset: 0x0014E87A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008B3A RID: 35642 RVA: 0x00150684 File Offset: 0x0014E884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ActivityId);
			}
			if (this.SubInsId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.SubInsId);
			}
			if (this.Settle)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.Settle);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008B3B RID: 35643 RVA: 0x001506FC File Offset: 0x0014E8FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.SubInsId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubInsId);
			}
			if (this.Settle)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008B3C RID: 35644 RVA: 0x00150760 File Offset: 0x0014E960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchSettleRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.SubInsId != 0)
			{
				this.SubInsId = other.SubInsId;
			}
			if (other.Settle)
			{
				this.Settle = other.Settle;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008B3D RID: 35645 RVA: 0x001507C4 File Offset: 0x0014E9C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008B3E RID: 35646 RVA: 0x001507D0 File Offset: 0x0014E9D0
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
				if (num != 48U)
				{
					if (num != 56U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Settle = input.ReadBool();
						}
					}
					else
					{
						this.SubInsId = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004435 RID: 17461
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004436 RID: 17462
		public const int ActivityIdFieldNumber = 6;

		// Token: 0x04004437 RID: 17463
		private int activityId_;

		// Token: 0x04004438 RID: 17464
		public const int SubInsIdFieldNumber = 7;

		// Token: 0x04004439 RID: 17465
		private int subInsId_;

		// Token: 0x0400443A RID: 17466
		public const int SettleFieldNumber = 10;

		// Token: 0x0400443B RID: 17467
		private bool settle_;
	}
}
