using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007E3 RID: 2019
	[NetMessage(EMessageId.InfrV2FireUpdateNotify)]
	public sealed class InfrV2FireUpdateNotify : IMessage<InfrV2FireUpdateNotify>, IMessage, IEquatable<InfrV2FireUpdateNotify>, IDeepCloneable<InfrV2FireUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600B568 RID: 46440 RVA: 0x001B172C File Offset: 0x001AF92C
		[NullableContext(1)]
		public static InfrV2FireUpdateNotify Create()
		{
			return new InfrV2FireUpdateNotify();
		}

		// Token: 0x1700248F RID: 9359
		// (get) Token: 0x0600B569 RID: 46441 RVA: 0x001B1733 File Offset: 0x001AF933
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002490 RID: 9360
		// (get) Token: 0x0600B56A RID: 46442 RVA: 0x001B1736 File Offset: 0x001AF936
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2FireUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600B56B RID: 46443 RVA: 0x001B173D File Offset: 0x001AF93D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2FireUpdateNotify()
		{
		}

		// Token: 0x0600B56C RID: 46444 RVA: 0x001B1745 File Offset: 0x001AF945
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2FireUpdateNotify(InfrV2FireUpdateNotify other) : this()
		{
			this.fireInfo_ = ((other.fireInfo_ != null) ? other.fireInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B56D RID: 46445 RVA: 0x001B177A File Offset: 0x001AF97A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2FireUpdateNotify Clone()
		{
			return new InfrV2FireUpdateNotify(this);
		}

		// Token: 0x17002491 RID: 9361
		// (get) Token: 0x0600B56E RID: 46446 RVA: 0x001B1782 File Offset: 0x001AF982
		// (set) Token: 0x0600B56F RID: 46447 RVA: 0x001B178A File Offset: 0x001AF98A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2FirePb FireInfo
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

		// Token: 0x0600B570 RID: 46448 RVA: 0x001B1793 File Offset: 0x001AF993
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2FireUpdateNotify);
		}

		// Token: 0x0600B571 RID: 46449 RVA: 0x001B17A1 File Offset: 0x001AF9A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2FireUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.FireInfo, other.FireInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B572 RID: 46450 RVA: 0x001B17D4 File Offset: 0x001AF9D4
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

		// Token: 0x0600B573 RID: 46451 RVA: 0x001B1810 File Offset: 0x001AFA10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B574 RID: 46452 RVA: 0x001B181D File Offset: 0x001AFA1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B575 RID: 46453 RVA: 0x001B1826 File Offset: 0x001AFA26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.fireInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.FireInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B576 RID: 46454 RVA: 0x001B1858 File Offset: 0x001AFA58
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

		// Token: 0x0600B577 RID: 46455 RVA: 0x001B1898 File Offset: 0x001AFA98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrV2FireUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.fireInfo_ != null)
			{
				if (this.fireInfo_ == null)
				{
					this.FireInfo = new InfrV2FirePb();
				}
				this.FireInfo.MergeFrom(other.FireInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B578 RID: 46456 RVA: 0x001B18EC File Offset: 0x001AFAEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B579 RID: 46457 RVA: 0x001B18F8 File Offset: 0x001AFAF8
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.fireInfo_ == null)
					{
						this.FireInfo = new InfrV2FirePb();
					}
					input.ReadMessage(this.FireInfo);
				}
			}
		}

		// Token: 0x040050D7 RID: 20695
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050D8 RID: 20696
		public const int FireInfoFieldNumber = 5;

		// Token: 0x040050D9 RID: 20697
		private InfrV2FirePb fireInfo_;
	}
}
