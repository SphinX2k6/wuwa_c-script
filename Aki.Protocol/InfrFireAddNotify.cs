using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007D8 RID: 2008
	[NetMessage(EMessageId.InfrFireAddNotify)]
	public sealed class InfrFireAddNotify : IMessage<InfrFireAddNotify>, IMessage, IEquatable<InfrFireAddNotify>, IDeepCloneable<InfrFireAddNotify>, IBufferMessage
	{
		// Token: 0x0600B462 RID: 46178 RVA: 0x001AF485 File Offset: 0x001AD685
		[NullableContext(1)]
		public static InfrFireAddNotify Create()
		{
			return new InfrFireAddNotify();
		}

		// Token: 0x17002463 RID: 9315
		// (get) Token: 0x0600B463 RID: 46179 RVA: 0x001AF48C File Offset: 0x001AD68C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002464 RID: 9316
		// (get) Token: 0x0600B464 RID: 46180 RVA: 0x001AF48F File Offset: 0x001AD68F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrFireAddNotify.Descriptor;
			}
		}

		// Token: 0x0600B465 RID: 46181 RVA: 0x001AF496 File Offset: 0x001AD696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrFireAddNotify()
		{
		}

		// Token: 0x0600B466 RID: 46182 RVA: 0x001AF4A0 File Offset: 0x001AD6A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrFireAddNotify(InfrFireAddNotify other) : this()
		{
			this.fireInfo_ = ((other.fireInfo_ != null) ? other.fireInfo_.Clone() : null);
			this.add_ = other.add_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B467 RID: 46183 RVA: 0x001AF4EC File Offset: 0x001AD6EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrFireAddNotify Clone()
		{
			return new InfrFireAddNotify(this);
		}

		// Token: 0x17002465 RID: 9317
		// (get) Token: 0x0600B468 RID: 46184 RVA: 0x001AF4F4 File Offset: 0x001AD6F4
		// (set) Token: 0x0600B469 RID: 46185 RVA: 0x001AF4FC File Offset: 0x001AD6FC
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

		// Token: 0x17002466 RID: 9318
		// (get) Token: 0x0600B46A RID: 46186 RVA: 0x001AF505 File Offset: 0x001AD705
		// (set) Token: 0x0600B46B RID: 46187 RVA: 0x001AF50D File Offset: 0x001AD70D
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

		// Token: 0x0600B46C RID: 46188 RVA: 0x001AF516 File Offset: 0x001AD716
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrFireAddNotify);
		}

		// Token: 0x0600B46D RID: 46189 RVA: 0x001AF524 File Offset: 0x001AD724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrFireAddNotify other)
		{
			return other != null && (other == this || (object.Equals(this.FireInfo, other.FireInfo) && this.Add == other.Add && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B46E RID: 46190 RVA: 0x001AF574 File Offset: 0x001AD774
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

		// Token: 0x0600B46F RID: 46191 RVA: 0x001AF5C9 File Offset: 0x001AD7C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B470 RID: 46192 RVA: 0x001AF5D6 File Offset: 0x001AD7D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B471 RID: 46193 RVA: 0x001AF5E0 File Offset: 0x001AD7E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.fireInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.FireInfo);
			}
			if (this.Add != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Add);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B472 RID: 46194 RVA: 0x001AF63C File Offset: 0x001AD83C
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

		// Token: 0x0600B473 RID: 46195 RVA: 0x001AF694 File Offset: 0x001AD894
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

		// Token: 0x0600B474 RID: 46196 RVA: 0x001AF6FC File Offset: 0x001AD8FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B475 RID: 46197 RVA: 0x001AF708 File Offset: 0x001AD908
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
				if (num != 26U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Add = input.ReadInt32();
					}
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
		}

		// Token: 0x04005048 RID: 20552
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005049 RID: 20553
		public const int FireInfoFieldNumber = 3;

		// Token: 0x0400504A RID: 20554
		private InfrFirePb fireInfo_;

		// Token: 0x0400504B RID: 20555
		public const int AddFieldNumber = 10;

		// Token: 0x0400504C RID: 20556
		private int add_;
	}
}
