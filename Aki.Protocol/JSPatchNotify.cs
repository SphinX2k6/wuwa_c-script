using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200087B RID: 2171
	[NetMessage(EMessageId.JSPatchNotify)]
	public sealed class JSPatchNotify : IMessage<JSPatchNotify>, IMessage, IEquatable<JSPatchNotify>, IDeepCloneable<JSPatchNotify>, IBufferMessage
	{
		// Token: 0x0600C14D RID: 49485 RVA: 0x001CB338 File Offset: 0x001C9538
		[NullableContext(1)]
		public static JSPatchNotify Create()
		{
			return new JSPatchNotify();
		}

		// Token: 0x17002711 RID: 10001
		// (get) Token: 0x0600C14E RID: 49486 RVA: 0x001CB33F File Offset: 0x001C953F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002712 RID: 10002
		// (get) Token: 0x0600C14F RID: 49487 RVA: 0x001CB342 File Offset: 0x001C9542
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JSPatchNotify.Descriptor;
			}
		}

		// Token: 0x0600C150 RID: 49488 RVA: 0x001CB349 File Offset: 0x001C9549
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JSPatchNotify()
		{
		}

		// Token: 0x0600C151 RID: 49489 RVA: 0x001CB35C File Offset: 0x001C955C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JSPatchNotify(JSPatchNotify other) : this()
		{
			this.content_ = other.content_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C152 RID: 49490 RVA: 0x001CB381 File Offset: 0x001C9581
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JSPatchNotify Clone()
		{
			return new JSPatchNotify(this);
		}

		// Token: 0x17002713 RID: 10003
		// (get) Token: 0x0600C153 RID: 49491 RVA: 0x001CB389 File Offset: 0x001C9589
		// (set) Token: 0x0600C154 RID: 49492 RVA: 0x001CB391 File Offset: 0x001C9591
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Content
		{
			get
			{
				return this.content_;
			}
			set
			{
				this.content_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0600C155 RID: 49493 RVA: 0x001CB3A4 File Offset: 0x001C95A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JSPatchNotify);
		}

		// Token: 0x0600C156 RID: 49494 RVA: 0x001CB3B2 File Offset: 0x001C95B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JSPatchNotify other)
		{
			return other != null && (other == this || (!(this.Content != other.Content) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C157 RID: 49495 RVA: 0x001CB3E8 File Offset: 0x001C95E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Content.Length != 0)
			{
				num ^= this.Content.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C158 RID: 49496 RVA: 0x001CB429 File Offset: 0x001C9629
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C159 RID: 49497 RVA: 0x001CB436 File Offset: 0x001C9636
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C15A RID: 49498 RVA: 0x001CB43F File Offset: 0x001C963F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Content.Length != 0)
			{
				output.WriteRawTag(114);
				output.WriteString(this.Content);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C15B RID: 49499 RVA: 0x001CB478 File Offset: 0x001C9678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Content.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Content);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C15C RID: 49500 RVA: 0x001CB4BB File Offset: 0x001C96BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JSPatchNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Content.Length != 0)
			{
				this.Content = other.Content;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C15D RID: 49501 RVA: 0x001CB4F1 File Offset: 0x001C96F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C15E RID: 49502 RVA: 0x001CB4FC File Offset: 0x001C96FC
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Content = input.ReadString();
				}
			}
		}

		// Token: 0x040053DC RID: 21468
		private UnknownFieldSet _unknownFields;

		// Token: 0x040053DD RID: 21469
		public const int ContentFieldNumber = 14;

		// Token: 0x040053DE RID: 21470
		private string content_ = "";
	}
}
