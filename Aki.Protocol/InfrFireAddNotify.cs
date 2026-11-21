using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007C4 RID: 1988
	[NetMessage(EMessageId.InfrFireAddNotify)]
	public sealed class InfrFireAddNotify : IMessage<InfrFireAddNotify>, IMessage, IEquatable<InfrFireAddNotify>, IDeepCloneable<InfrFireAddNotify>, IBufferMessage
	{
		// Token: 0x0600B30C RID: 45836 RVA: 0x001ACA51 File Offset: 0x001AAC51
		[NullableContext(1)]
		public static InfrFireAddNotify Create()
		{
			return new InfrFireAddNotify();
		}

		// Token: 0x17002419 RID: 9241
		// (get) Token: 0x0600B30D RID: 45837 RVA: 0x001ACA58 File Offset: 0x001AAC58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700241A RID: 9242
		// (get) Token: 0x0600B30E RID: 45838 RVA: 0x001ACA5B File Offset: 0x001AAC5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrFireAddNotify.Descriptor;
			}
		}

		// Token: 0x0600B30F RID: 45839 RVA: 0x001ACA62 File Offset: 0x001AAC62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrFireAddNotify()
		{
		}

		// Token: 0x0600B310 RID: 45840 RVA: 0x001ACA6C File Offset: 0x001AAC6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrFireAddNotify(InfrFireAddNotify other) : this()
		{
			this.fireInfo_ = ((other.fireInfo_ != null) ? other.fireInfo_.Clone() : null);
			this.add_ = other.add_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B311 RID: 45841 RVA: 0x001ACAB8 File Offset: 0x001AACB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrFireAddNotify Clone()
		{
			return new InfrFireAddNotify(this);
		}

		// Token: 0x1700241B RID: 9243
		// (get) Token: 0x0600B312 RID: 45842 RVA: 0x001ACAC0 File Offset: 0x001AACC0
		// (set) Token: 0x0600B313 RID: 45843 RVA: 0x001ACAC8 File Offset: 0x001AACC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrFirePb FireInfo
		{
			get
			{
				return this.fireInfo_;
			}
			set
			{
				this.fireInfo_ = value;
			}
		}

		// Token: 0x1700241C RID: 9244
		// (get) Token: 0x0600B314 RID: 45844 RVA: 0x001ACAD1 File Offset: 0x001AACD1
		// (set) Token: 0x0600B315 RID: 45845 RVA: 0x001ACAD9 File Offset: 0x001AACD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Add
		{
			get
			{
				return this.add_;
			}
			set
			{
				this.add_ = value;
			}
		}

		// Token: 0x0600B316 RID: 45846 RVA: 0x001ACAE2 File Offset: 0x001AACE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrFireAddNotify);
		}

		// Token: 0x0600B317 RID: 45847 RVA: 0x001ACAF0 File Offset: 0x001AACF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrFireAddNotify other)
		{
			return other != null && (other == this || (object.Equals(this.FireInfo, other.FireInfo) && this.Add == other.Add && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B318 RID: 45848 RVA: 0x001ACB40 File Offset: 0x001AAD40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.fireInfo_ != null)
			{
				num ^= this.FireInfo.GetHashCode();
			}
			if (this.Add != 0)
			{
				num ^= this.Add.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B319 RID: 45849 RVA: 0x001ACB95 File Offset: 0x001AAD95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B31A RID: 45850 RVA: 0x001ACBA2 File Offset: 0x001AADA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B31B RID: 45851 RVA: 0x001ACBAC File Offset: 0x001AADAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Add != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Add);
			}
			if (this.fireInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.FireInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B31C RID: 45852 RVA: 0x001ACC08 File Offset: 0x001AAE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.fireInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FireInfo);
			}
			if (this.Add != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Add);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B31D RID: 45853 RVA: 0x001ACC60 File Offset: 0x001AAE60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrFireAddNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.fireInfo_ != null)
			{
				if (this.fireInfo_ == null)
				{
					this.FireInfo = new InfrFirePb();
				}
				this.FireInfo.MergeFrom(other.FireInfo);
			}
			if (other.Add != 0)
			{
				this.Add = other.Add;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B31E RID: 45854 RVA: 0x001ACCC8 File Offset: 0x001AAEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B31F RID: 45855 RVA: 0x001ACCD4 File Offset: 0x001AAED4
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
				if (num != 96U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.fireInfo_ == null)
						{
							this.FireInfo = new InfrFirePb();
						}
						input.ReadMessage(this.FireInfo);
					}
				}
				else
				{
					this.Add = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005041 RID: 20545
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005042 RID: 20546
		public const int FireInfoFieldNumber = 14;

		// Token: 0x04005043 RID: 20547
		private InfrFirePb fireInfo_;

		// Token: 0x04005044 RID: 20548
		public const int AddFieldNumber = 12;

		// Token: 0x04005045 RID: 20549
		private int add_;
	}
}
