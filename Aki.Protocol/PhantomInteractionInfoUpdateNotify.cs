using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CD9 RID: 3289
	[NetMessage(EMessageId.PhantomInteractionInfoUpdateNotify)]
	public sealed class PhantomInteractionInfoUpdateNotify : IMessage<PhantomInteractionInfoUpdateNotify>, IMessage, IEquatable<PhantomInteractionInfoUpdateNotify>, IDeepCloneable<PhantomInteractionInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06011CC5 RID: 72901 RVA: 0x0029A91D File Offset: 0x00298B1D
		[NullableContext(1)]
		public static PhantomInteractionInfoUpdateNotify Create()
		{
			return new PhantomInteractionInfoUpdateNotify();
		}

		// Token: 0x17003AF7 RID: 15095
		// (get) Token: 0x06011CC6 RID: 72902 RVA: 0x0029A924 File Offset: 0x00298B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003AF8 RID: 15096
		// (get) Token: 0x06011CC7 RID: 72903 RVA: 0x0029A927 File Offset: 0x00298B27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomInteractionInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06011CC8 RID: 72904 RVA: 0x0029A92E File Offset: 0x00298B2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomInteractionInfoUpdateNotify()
		{
		}

		// Token: 0x06011CC9 RID: 72905 RVA: 0x0029A936 File Offset: 0x00298B36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomInteractionInfoUpdateNotify(PhantomInteractionInfoUpdateNotify other) : this()
		{
			this.unlockIllustratedPhantom_ = ((other.unlockIllustratedPhantom_ != null) ? other.unlockIllustratedPhantom_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011CCA RID: 72906 RVA: 0x0029A96B File Offset: 0x00298B6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomInteractionInfoUpdateNotify Clone()
		{
			return new PhantomInteractionInfoUpdateNotify(this);
		}

		// Token: 0x17003AF9 RID: 15097
		// (get) Token: 0x06011CCB RID: 72907 RVA: 0x0029A973 File Offset: 0x00298B73
		// (set) Token: 0x06011CCC RID: 72908 RVA: 0x0029A97B File Offset: 0x00298B7B
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

		// Token: 0x06011CCD RID: 72909 RVA: 0x0029A984 File Offset: 0x00298B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomInteractionInfoUpdateNotify);
		}

		// Token: 0x06011CCE RID: 72910 RVA: 0x0029A992 File Offset: 0x00298B92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomInteractionInfoUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.UnlockIllustratedPhantom, other.UnlockIllustratedPhantom) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011CCF RID: 72911 RVA: 0x0029A9C8 File Offset: 0x00298BC8
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

		// Token: 0x06011CD0 RID: 72912 RVA: 0x0029AA04 File Offset: 0x00298C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011CD1 RID: 72913 RVA: 0x0029AA11 File Offset: 0x00298C11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011CD2 RID: 72914 RVA: 0x0029AA1A File Offset: 0x00298C1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.unlockIllustratedPhantom_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.UnlockIllustratedPhantom);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011CD3 RID: 72915 RVA: 0x0029AA4C File Offset: 0x00298C4C
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

		// Token: 0x06011CD4 RID: 72916 RVA: 0x0029AA8C File Offset: 0x00298C8C
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

		// Token: 0x06011CD5 RID: 72917 RVA: 0x0029AAE0 File Offset: 0x00298CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011CD6 RID: 72918 RVA: 0x0029AAEC File Offset: 0x00298CEC
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
				if (num != 74U)
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

		// Token: 0x04006FC3 RID: 28611
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006FC4 RID: 28612
		public const int UnlockIllustratedPhantomFieldNumber = 9;

		// Token: 0x04006FC5 RID: 28613
		private UnlockIllustratedPhantom unlockIllustratedPhantom_;
	}
}
