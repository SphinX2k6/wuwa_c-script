using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000146 RID: 326
	[NetMessage(EMessageId.BabelActivityItemNumUpdateNotify)]
	public sealed class BabelActivityItemNumUpdateNotify : IMessage<BabelActivityItemNumUpdateNotify>, IMessage, IEquatable<BabelActivityItemNumUpdateNotify>, IDeepCloneable<BabelActivityItemNumUpdateNotify>, IBufferMessage
	{
		// Token: 0x06002A35 RID: 10805 RVA: 0x0006EC1D File Offset: 0x0006CE1D
		[NullableContext(1)]
		public static BabelActivityItemNumUpdateNotify Create()
		{
			return new BabelActivityItemNumUpdateNotify();
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06002A36 RID: 10806 RVA: 0x0006EC24 File Offset: 0x0006CE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06002A37 RID: 10807 RVA: 0x0006EC27 File Offset: 0x0006CE27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelActivityItemNumUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06002A38 RID: 10808 RVA: 0x0006EC2E File Offset: 0x0006CE2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityItemNumUpdateNotify()
		{
		}

		// Token: 0x06002A39 RID: 10809 RVA: 0x0006EC36 File Offset: 0x0006CE36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityItemNumUpdateNotify(BabelActivityItemNumUpdateNotify other) : this()
		{
			this.activityItemNum_ = other.activityItemNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002A3A RID: 10810 RVA: 0x0006EC5B File Offset: 0x0006CE5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityItemNumUpdateNotify Clone()
		{
			return new BabelActivityItemNumUpdateNotify(this);
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06002A3B RID: 10811 RVA: 0x0006EC63 File Offset: 0x0006CE63
		// (set) Token: 0x06002A3C RID: 10812 RVA: 0x0006EC6B File Offset: 0x0006CE6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityItemNum
		{
			get
			{
				return this.activityItemNum_;
			}
			set
			{
				this.activityItemNum_ = value;
			}
		}

		// Token: 0x06002A3D RID: 10813 RVA: 0x0006EC74 File Offset: 0x0006CE74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelActivityItemNumUpdateNotify);
		}

		// Token: 0x06002A3E RID: 10814 RVA: 0x0006EC82 File Offset: 0x0006CE82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelActivityItemNumUpdateNotify other)
		{
			return other != null && (other == this || (this.ActivityItemNum == other.ActivityItemNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002A3F RID: 10815 RVA: 0x0006ECB0 File Offset: 0x0006CEB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityItemNum != 0)
			{
				num ^= this.ActivityItemNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002A40 RID: 10816 RVA: 0x0006ECEF File Offset: 0x0006CEEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002A41 RID: 10817 RVA: 0x0006ECFC File Offset: 0x0006CEFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002A42 RID: 10818 RVA: 0x0006ED05 File Offset: 0x0006CF05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityItemNum != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ActivityItemNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002A43 RID: 10819 RVA: 0x0006ED38 File Offset: 0x0006CF38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityItemNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityItemNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002A44 RID: 10820 RVA: 0x0006ED76 File Offset: 0x0006CF76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BabelActivityItemNumUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityItemNum != 0)
			{
				this.ActivityItemNum = other.ActivityItemNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002A45 RID: 10821 RVA: 0x0006EDA7 File Offset: 0x0006CFA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002A46 RID: 10822 RVA: 0x0006EDB0 File Offset: 0x0006CFB0
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
					this.ActivityItemNum = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400278B RID: 10123
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400278C RID: 10124
		public const int ActivityItemNumFieldNumber = 4;

		// Token: 0x0400278D RID: 10125
		private int activityItemNum_;
	}
}
