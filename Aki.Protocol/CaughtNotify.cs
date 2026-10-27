using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200023C RID: 572
	[NetMessage(EMessageId.CaughtNotify)]
	public sealed class CaughtNotify : IMessage<CaughtNotify>, IMessage, IEquatable<CaughtNotify>, IDeepCloneable<CaughtNotify>, IBufferMessage
	{
		// Token: 0x06003DA1 RID: 15777 RVA: 0x0009895C File Offset: 0x00096B5C
		[NullableContext(1)]
		public static CaughtNotify Create()
		{
			return new CaughtNotify();
		}

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x06003DA2 RID: 15778 RVA: 0x00098963 File Offset: 0x00096B63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x06003DA3 RID: 15779 RVA: 0x00098966 File Offset: 0x00096B66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CaughtNotify.Descriptor;
			}
		}

		// Token: 0x06003DA4 RID: 15780 RVA: 0x0009896D File Offset: 0x00096B6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaughtNotify()
		{
		}

		// Token: 0x06003DA5 RID: 15781 RVA: 0x00098975 File Offset: 0x00096B75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaughtNotify(CaughtNotify other) : this()
		{
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003DA6 RID: 15782 RVA: 0x000989AA File Offset: 0x00096BAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaughtNotify Clone()
		{
			return new CaughtNotify(this);
		}

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x06003DA7 RID: 15783 RVA: 0x000989B2 File Offset: 0x00096BB2
		// (set) Token: 0x06003DA8 RID: 15784 RVA: 0x000989BA File Offset: 0x00096BBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaughtInfo Info
		{
			get
			{
				return this.info_;
			}
			set
			{
				this.info_ = value;
			}
		}

		// Token: 0x06003DA9 RID: 15785 RVA: 0x000989C3 File Offset: 0x00096BC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CaughtNotify);
		}

		// Token: 0x06003DAA RID: 15786 RVA: 0x000989D1 File Offset: 0x00096BD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CaughtNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Info, other.Info) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003DAB RID: 15787 RVA: 0x00098A04 File Offset: 0x00096C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.info_ != null)
			{
				num ^= this.Info.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003DAC RID: 15788 RVA: 0x00098A40 File Offset: 0x00096C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003DAD RID: 15789 RVA: 0x00098A4D File Offset: 0x00096C4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003DAE RID: 15790 RVA: 0x00098A56 File Offset: 0x00096C56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.info_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.Info);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003DAF RID: 15791 RVA: 0x00098A88 File Offset: 0x00096C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.info_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Info);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003DB0 RID: 15792 RVA: 0x00098AC8 File Offset: 0x00096CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CaughtNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.info_ != null)
			{
				if (this.info_ == null)
				{
					this.Info = new CaughtInfo();
				}
				this.Info.MergeFrom(other.Info);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003DB1 RID: 15793 RVA: 0x00098B1C File Offset: 0x00096D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003DB2 RID: 15794 RVA: 0x00098B28 File Offset: 0x00096D28
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
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.info_ == null)
					{
						this.Info = new CaughtInfo();
					}
					input.ReadMessage(this.Info);
				}
			}
		}

		// Token: 0x04002CBA RID: 11450
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CBB RID: 11451
		public const int InfoFieldNumber = 11;

		// Token: 0x04002CBC RID: 11452
		private CaughtInfo info_;
	}
}
