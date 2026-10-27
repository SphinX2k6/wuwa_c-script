using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003D9 RID: 985
	[NetMessage(EMessageId.DirectTrainInfoNotify)]
	public sealed class DirectTrainInfoNotify : IMessage<DirectTrainInfoNotify>, IMessage, IEquatable<DirectTrainInfoNotify>, IDeepCloneable<DirectTrainInfoNotify>, IBufferMessage
	{
		// Token: 0x06005FF9 RID: 24569 RVA: 0x000E84CD File Offset: 0x000E66CD
		[NullableContext(1)]
		public static DirectTrainInfoNotify Create()
		{
			return new DirectTrainInfoNotify();
		}

		// Token: 0x170011E3 RID: 4579
		// (get) Token: 0x06005FFA RID: 24570 RVA: 0x000E84D4 File Offset: 0x000E66D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011E4 RID: 4580
		// (get) Token: 0x06005FFB RID: 24571 RVA: 0x000E84D7 File Offset: 0x000E66D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DirectTrainInfoNotify.Descriptor;
			}
		}

		// Token: 0x06005FFC RID: 24572 RVA: 0x000E84DE File Offset: 0x000E66DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DirectTrainInfoNotify()
		{
		}

		// Token: 0x06005FFD RID: 24573 RVA: 0x000E84E6 File Offset: 0x000E66E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DirectTrainInfoNotify(DirectTrainInfoNotify other) : this()
		{
			this.activity_ = ((other.activity_ != null) ? other.activity_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005FFE RID: 24574 RVA: 0x000E851B File Offset: 0x000E671B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DirectTrainInfoNotify Clone()
		{
			return new DirectTrainInfoNotify(this);
		}

		// Token: 0x170011E5 RID: 4581
		// (get) Token: 0x06005FFF RID: 24575 RVA: 0x000E8523 File Offset: 0x000E6723
		// (set) Token: 0x06006000 RID: 24576 RVA: 0x000E852B File Offset: 0x000E672B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityData Activity
		{
			get
			{
				return this.activity_;
			}
			set
			{
				this.activity_ = value;
			}
		}

		// Token: 0x06006001 RID: 24577 RVA: 0x000E8534 File Offset: 0x000E6734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DirectTrainInfoNotify);
		}

		// Token: 0x06006002 RID: 24578 RVA: 0x000E8542 File Offset: 0x000E6742
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DirectTrainInfoNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Activity, other.Activity) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006003 RID: 24579 RVA: 0x000E8578 File Offset: 0x000E6778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.activity_ != null)
			{
				num ^= this.Activity.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006004 RID: 24580 RVA: 0x000E85B4 File Offset: 0x000E67B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006005 RID: 24581 RVA: 0x000E85C1 File Offset: 0x000E67C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006006 RID: 24582 RVA: 0x000E85CA File Offset: 0x000E67CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.activity_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.Activity);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006007 RID: 24583 RVA: 0x000E85FC File Offset: 0x000E67FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.activity_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Activity);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006008 RID: 24584 RVA: 0x000E863C File Offset: 0x000E683C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DirectTrainInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.activity_ != null)
			{
				if (this.activity_ == null)
				{
					this.Activity = new ActivityData();
				}
				this.Activity.MergeFrom(other.Activity);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006009 RID: 24585 RVA: 0x000E8690 File Offset: 0x000E6890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600600A RID: 24586 RVA: 0x000E869C File Offset: 0x000E689C
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
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.activity_ == null)
					{
						this.Activity = new ActivityData();
					}
					input.ReadMessage(this.Activity);
				}
			}
		}

		// Token: 0x04003749 RID: 14153
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400374A RID: 14154
		public const int ActivityFieldNumber = 7;

		// Token: 0x0400374B RID: 14155
		private ActivityData activity_;
	}
}
