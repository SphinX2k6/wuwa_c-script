using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007C8 RID: 1992
	[NetMessage(EMessageId.InfrFireUpdateNotify)]
	public sealed class InfrFireUpdateNotify : IMessage<InfrFireUpdateNotify>, IMessage, IEquatable<InfrFireUpdateNotify>, IDeepCloneable<InfrFireUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600B35A RID: 45914 RVA: 0x001AD45C File Offset: 0x001AB65C
		[NullableContext(1)]
		public static InfrFireUpdateNotify Create()
		{
			return new InfrFireUpdateNotify();
		}

		// Token: 0x17002428 RID: 9256
		// (get) Token: 0x0600B35B RID: 45915 RVA: 0x001AD463 File Offset: 0x001AB663
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002429 RID: 9257
		// (get) Token: 0x0600B35C RID: 45916 RVA: 0x001AD466 File Offset: 0x001AB666
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrFireUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600B35D RID: 45917 RVA: 0x001AD46D File Offset: 0x001AB66D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrFireUpdateNotify()
		{
		}

		// Token: 0x0600B35E RID: 45918 RVA: 0x001AD475 File Offset: 0x001AB675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrFireUpdateNotify(InfrFireUpdateNotify other) : this()
		{
			this.fireInfo_ = ((other.fireInfo_ != null) ? other.fireInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B35F RID: 45919 RVA: 0x001AD4AA File Offset: 0x001AB6AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrFireUpdateNotify Clone()
		{
			return new InfrFireUpdateNotify(this);
		}

		// Token: 0x1700242A RID: 9258
		// (get) Token: 0x0600B360 RID: 45920 RVA: 0x001AD4B2 File Offset: 0x001AB6B2
		// (set) Token: 0x0600B361 RID: 45921 RVA: 0x001AD4BA File Offset: 0x001AB6BA
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

		// Token: 0x0600B362 RID: 45922 RVA: 0x001AD4C3 File Offset: 0x001AB6C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrFireUpdateNotify);
		}

		// Token: 0x0600B363 RID: 45923 RVA: 0x001AD4D1 File Offset: 0x001AB6D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrFireUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.FireInfo, other.FireInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B364 RID: 45924 RVA: 0x001AD504 File Offset: 0x001AB704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.fireInfo_ != null)
			{
				num ^= this.FireInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B365 RID: 45925 RVA: 0x001AD540 File Offset: 0x001AB740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B366 RID: 45926 RVA: 0x001AD54D File Offset: 0x001AB74D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B367 RID: 45927 RVA: 0x001AD556 File Offset: 0x001AB756
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.fireInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.FireInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B368 RID: 45928 RVA: 0x001AD588 File Offset: 0x001AB788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.fireInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FireInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B369 RID: 45929 RVA: 0x001AD5C8 File Offset: 0x001AB7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrFireUpdateNotify other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B36A RID: 45930 RVA: 0x001AD61C File Offset: 0x001AB81C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B36B RID: 45931 RVA: 0x001AD628 File Offset: 0x001AB828
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
				if (num != 50U)
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
		}

		// Token: 0x04005054 RID: 20564
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005055 RID: 20565
		public const int FireInfoFieldNumber = 6;

		// Token: 0x04005056 RID: 20566
		private InfrFirePb fireInfo_;
	}
}
