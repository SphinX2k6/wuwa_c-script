using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007F7 RID: 2039
	[NetMessage(EMessageId.InfrV2FireUpdateNotify)]
	public sealed class InfrV2FireUpdateNotify : IMessage<InfrV2FireUpdateNotify>, IMessage, IEquatable<InfrV2FireUpdateNotify>, IDeepCloneable<InfrV2FireUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600B6BE RID: 46782 RVA: 0x001B4164 File Offset: 0x001B2364
		[NullableContext(1)]
		public static InfrV2FireUpdateNotify Create()
		{
			return new InfrV2FireUpdateNotify();
		}

		// Token: 0x170024D9 RID: 9433
		// (get) Token: 0x0600B6BF RID: 46783 RVA: 0x001B416B File Offset: 0x001B236B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024DA RID: 9434
		// (get) Token: 0x0600B6C0 RID: 46784 RVA: 0x001B416E File Offset: 0x001B236E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2FireUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600B6C1 RID: 46785 RVA: 0x001B4175 File Offset: 0x001B2375
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2FireUpdateNotify()
		{
		}

		// Token: 0x0600B6C2 RID: 46786 RVA: 0x001B417D File Offset: 0x001B237D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2FireUpdateNotify(InfrV2FireUpdateNotify other) : this()
		{
			this.fireInfo_ = ((other.fireInfo_ != null) ? other.fireInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B6C3 RID: 46787 RVA: 0x001B41B2 File Offset: 0x001B23B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2FireUpdateNotify Clone()
		{
			return new InfrV2FireUpdateNotify(this);
		}

		// Token: 0x170024DB RID: 9435
		// (get) Token: 0x0600B6C4 RID: 46788 RVA: 0x001B41BA File Offset: 0x001B23BA
		// (set) Token: 0x0600B6C5 RID: 46789 RVA: 0x001B41C2 File Offset: 0x001B23C2
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

		// Token: 0x0600B6C6 RID: 46790 RVA: 0x001B41CB File Offset: 0x001B23CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2FireUpdateNotify);
		}

		// Token: 0x0600B6C7 RID: 46791 RVA: 0x001B41D9 File Offset: 0x001B23D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2FireUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.FireInfo, other.FireInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B6C8 RID: 46792 RVA: 0x001B420C File Offset: 0x001B240C
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

		// Token: 0x0600B6C9 RID: 46793 RVA: 0x001B4248 File Offset: 0x001B2448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B6CA RID: 46794 RVA: 0x001B4255 File Offset: 0x001B2455
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B6CB RID: 46795 RVA: 0x001B425E File Offset: 0x001B245E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.fireInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.FireInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B6CC RID: 46796 RVA: 0x001B4290 File Offset: 0x001B2490
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

		// Token: 0x0600B6CD RID: 46797 RVA: 0x001B42D0 File Offset: 0x001B24D0
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

		// Token: 0x0600B6CE RID: 46798 RVA: 0x001B4324 File Offset: 0x001B2524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B6CF RID: 46799 RVA: 0x001B4330 File Offset: 0x001B2530
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
				if (num != 98U)
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

		// Token: 0x040050DE RID: 20702
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050DF RID: 20703
		public const int FireInfoFieldNumber = 12;

		// Token: 0x040050E0 RID: 20704
		private InfrV2FirePb fireInfo_;
	}
}
