using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001484 RID: 5252
	[NetMessage(EMessageId.UnlockCardNotify)]
	public sealed class UnlockCardNotify : IMessage<UnlockCardNotify>, IMessage, IEquatable<UnlockCardNotify>, IDeepCloneable<UnlockCardNotify>, IBufferMessage
	{
		// Token: 0x0601BCB3 RID: 113843 RVA: 0x004053AA File Offset: 0x004035AA
		[NullableContext(1)]
		public static UnlockCardNotify Create()
		{
			return new UnlockCardNotify();
		}

		// Token: 0x17005DB4 RID: 23988
		// (get) Token: 0x0601BCB4 RID: 113844 RVA: 0x004053B1 File Offset: 0x004035B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005DB5 RID: 23989
		// (get) Token: 0x0601BCB5 RID: 113845 RVA: 0x004053B4 File Offset: 0x004035B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnlockCardNotify.Descriptor;
			}
		}

		// Token: 0x0601BCB6 RID: 113846 RVA: 0x004053BB File Offset: 0x004035BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockCardNotify()
		{
		}

		// Token: 0x0601BCB7 RID: 113847 RVA: 0x004053C3 File Offset: 0x004035C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockCardNotify(UnlockCardNotify other) : this()
		{
			this.cardId_ = other.cardId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BCB8 RID: 113848 RVA: 0x004053E8 File Offset: 0x004035E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockCardNotify Clone()
		{
			return new UnlockCardNotify(this);
		}

		// Token: 0x17005DB6 RID: 23990
		// (get) Token: 0x0601BCB9 RID: 113849 RVA: 0x004053F0 File Offset: 0x004035F0
		// (set) Token: 0x0601BCBA RID: 113850 RVA: 0x004053F8 File Offset: 0x004035F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardId
		{
			get
			{
				return this.cardId_;
			}
			set
			{
				this.cardId_ = value;
			}
		}

		// Token: 0x0601BCBB RID: 113851 RVA: 0x00405401 File Offset: 0x00403601
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnlockCardNotify);
		}

		// Token: 0x0601BCBC RID: 113852 RVA: 0x0040540F File Offset: 0x0040360F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnlockCardNotify other)
		{
			return other != null && (other == this || (this.CardId == other.CardId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BCBD RID: 113853 RVA: 0x00405440 File Offset: 0x00403640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CardId != 0)
			{
				num ^= this.CardId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BCBE RID: 113854 RVA: 0x0040547F File Offset: 0x0040367F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BCBF RID: 113855 RVA: 0x0040548C File Offset: 0x0040368C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BCC0 RID: 113856 RVA: 0x00405495 File Offset: 0x00403695
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CardId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CardId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BCC1 RID: 113857 RVA: 0x004054C8 File Offset: 0x004036C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BCC2 RID: 113858 RVA: 0x00405506 File Offset: 0x00403706
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnlockCardNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CardId != 0)
			{
				this.CardId = other.CardId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BCC3 RID: 113859 RVA: 0x00405537 File Offset: 0x00403737
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BCC4 RID: 113860 RVA: 0x00405540 File Offset: 0x00403740
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CardId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009FF2 RID: 40946
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009FF3 RID: 40947
		public const int CardIdFieldNumber = 2;

		// Token: 0x04009FF4 RID: 40948
		private int cardId_;
	}
}
