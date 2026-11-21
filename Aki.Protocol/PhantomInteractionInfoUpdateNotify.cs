using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CC9 RID: 3273
	[NetMessage(EMessageId.PhantomInteractionInfoUpdateNotify)]
	public sealed class PhantomInteractionInfoUpdateNotify : IMessage<PhantomInteractionInfoUpdateNotify>, IMessage, IEquatable<PhantomInteractionInfoUpdateNotify>, IDeepCloneable<PhantomInteractionInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06011BC9 RID: 72649 RVA: 0x00298D01 File Offset: 0x00296F01
		[NullableContext(1)]
		public static PhantomInteractionInfoUpdateNotify Create()
		{
			return new PhantomInteractionInfoUpdateNotify();
		}

		// Token: 0x17003AC2 RID: 15042
		// (get) Token: 0x06011BCA RID: 72650 RVA: 0x00298D08 File Offset: 0x00296F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003AC3 RID: 15043
		// (get) Token: 0x06011BCB RID: 72651 RVA: 0x00298D0B File Offset: 0x00296F0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomInteractionInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06011BCC RID: 72652 RVA: 0x00298D12 File Offset: 0x00296F12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomInteractionInfoUpdateNotify()
		{
		}

		// Token: 0x06011BCD RID: 72653 RVA: 0x00298D1A File Offset: 0x00296F1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomInteractionInfoUpdateNotify(PhantomInteractionInfoUpdateNotify other) : this()
		{
			this.unlockIllustratedPhantom_ = ((other.unlockIllustratedPhantom_ != null) ? other.unlockIllustratedPhantom_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011BCE RID: 72654 RVA: 0x00298D4F File Offset: 0x00296F4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomInteractionInfoUpdateNotify Clone()
		{
			return new PhantomInteractionInfoUpdateNotify(this);
		}

		// Token: 0x17003AC4 RID: 15044
		// (get) Token: 0x06011BCF RID: 72655 RVA: 0x00298D57 File Offset: 0x00296F57
		// (set) Token: 0x06011BD0 RID: 72656 RVA: 0x00298D5F File Offset: 0x00296F5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockIllustratedPhantom UnlockIllustratedPhantom
		{
			get
			{
				return this.unlockIllustratedPhantom_;
			}
			set
			{
				this.unlockIllustratedPhantom_ = value;
			}
		}

		// Token: 0x06011BD1 RID: 72657 RVA: 0x00298D68 File Offset: 0x00296F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomInteractionInfoUpdateNotify);
		}

		// Token: 0x06011BD2 RID: 72658 RVA: 0x00298D76 File Offset: 0x00296F76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomInteractionInfoUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.UnlockIllustratedPhantom, other.UnlockIllustratedPhantom) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011BD3 RID: 72659 RVA: 0x00298DAC File Offset: 0x00296FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.unlockIllustratedPhantom_ != null)
			{
				num ^= this.UnlockIllustratedPhantom.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011BD4 RID: 72660 RVA: 0x00298DE8 File Offset: 0x00296FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011BD5 RID: 72661 RVA: 0x00298DF5 File Offset: 0x00296FF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011BD6 RID: 72662 RVA: 0x00298DFE File Offset: 0x00296FFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.unlockIllustratedPhantom_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.UnlockIllustratedPhantom);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011BD7 RID: 72663 RVA: 0x00298E30 File Offset: 0x00297030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.unlockIllustratedPhantom_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UnlockIllustratedPhantom);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011BD8 RID: 72664 RVA: 0x00298E70 File Offset: 0x00297070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomInteractionInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.unlockIllustratedPhantom_ != null)
			{
				if (this.unlockIllustratedPhantom_ == null)
				{
					this.UnlockIllustratedPhantom = new UnlockIllustratedPhantom();
				}
				this.UnlockIllustratedPhantom.MergeFrom(other.UnlockIllustratedPhantom);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011BD9 RID: 72665 RVA: 0x00298EC4 File Offset: 0x002970C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011BDA RID: 72666 RVA: 0x00298ED0 File Offset: 0x002970D0
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
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.unlockIllustratedPhantom_ == null)
					{
						this.UnlockIllustratedPhantom = new UnlockIllustratedPhantom();
					}
					input.ReadMessage(this.UnlockIllustratedPhantom);
				}
			}
		}

		// Token: 0x04006FDB RID: 28635
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006FDC RID: 28636
		public const int UnlockIllustratedPhantomFieldNumber = 15;

		// Token: 0x04006FDD RID: 28637
		private UnlockIllustratedPhantom unlockIllustratedPhantom_;
	}
}
