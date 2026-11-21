using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004B9 RID: 1209
	[NetMessage(EMessageId.EntranceStateNotify)]
	public sealed class EntranceStateNotify : IMessage<EntranceStateNotify>, IMessage, IEquatable<EntranceStateNotify>, IDeepCloneable<EntranceStateNotify>, IBufferMessage
	{
		// Token: 0x06007378 RID: 29560 RVA: 0x0011B97C File Offset: 0x00119B7C
		[NullableContext(1)]
		public static EntranceStateNotify Create()
		{
			return new EntranceStateNotify();
		}

		// Token: 0x1700165A RID: 5722
		// (get) Token: 0x06007379 RID: 29561 RVA: 0x0011B983 File Offset: 0x00119B83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700165B RID: 5723
		// (get) Token: 0x0600737A RID: 29562 RVA: 0x0011B986 File Offset: 0x00119B86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntranceStateNotify.Descriptor;
			}
		}

		// Token: 0x0600737B RID: 29563 RVA: 0x0011B98D File Offset: 0x00119B8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntranceStateNotify()
		{
		}

		// Token: 0x0600737C RID: 29564 RVA: 0x0011B995 File Offset: 0x00119B95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntranceStateNotify(EntranceStateNotify other) : this()
		{
			this.id_ = other.id_;
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600737D RID: 29565 RVA: 0x0011B9C6 File Offset: 0x00119BC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntranceStateNotify Clone()
		{
			return new EntranceStateNotify(this);
		}

		// Token: 0x1700165C RID: 5724
		// (get) Token: 0x0600737E RID: 29566 RVA: 0x0011B9CE File Offset: 0x00119BCE
		// (set) Token: 0x0600737F RID: 29567 RVA: 0x0011B9D6 File Offset: 0x00119BD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
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

		// Token: 0x1700165D RID: 5725
		// (get) Token: 0x06007380 RID: 29568 RVA: 0x0011B9DF File Offset: 0x00119BDF
		// (set) Token: 0x06007381 RID: 29569 RVA: 0x0011B9E7 File Offset: 0x00119BE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntranceState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x06007382 RID: 29570 RVA: 0x0011B9F0 File Offset: 0x00119BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntranceStateNotify);
		}

		// Token: 0x06007383 RID: 29571 RVA: 0x0011B9FE File Offset: 0x00119BFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntranceStateNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.State == other.State && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007384 RID: 29572 RVA: 0x0011BA3C File Offset: 0x00119C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.State != EntranceState.NotUnlock)
			{
				num ^= this.State.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007385 RID: 29573 RVA: 0x0011BA9A File Offset: 0x00119C9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007386 RID: 29574 RVA: 0x0011BAA7 File Offset: 0x00119CA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007387 RID: 29575 RVA: 0x0011BAB0 File Offset: 0x00119CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.State != EntranceState.NotUnlock)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.State);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007388 RID: 29576 RVA: 0x0011BB0C File Offset: 0x00119D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this.State != EntranceState.NotUnlock)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.State);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007389 RID: 29577 RVA: 0x0011BB64 File Offset: 0x00119D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntranceStateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			if (other.State != EntranceState.NotUnlock)
			{
				this.State = other.State;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600738A RID: 29578 RVA: 0x0011BBB4 File Offset: 0x00119DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600738B RID: 29579 RVA: 0x0011BBC0 File Offset: 0x00119DC0
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
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadInt64();
					}
				}
				else
				{
					this.State = (EntranceState)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003D81 RID: 15745
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D82 RID: 15746
		public const int IdFieldNumber = 15;

		// Token: 0x04003D83 RID: 15747
		private long id_;

		// Token: 0x04003D84 RID: 15748
		public const int StateFieldNumber = 12;

		// Token: 0x04003D85 RID: 15749
		private EntranceState state_;
	}
}
