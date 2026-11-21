using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013D1 RID: 5073
	[NetMessage(EMessageId.ThirdPartySharedNotify)]
	public sealed class ThirdPartySharedNotify : IMessage<ThirdPartySharedNotify>, IMessage, IEquatable<ThirdPartySharedNotify>, IDeepCloneable<ThirdPartySharedNotify>, IBufferMessage
	{
		// Token: 0x0601AFEC RID: 110572 RVA: 0x003EE799 File Offset: 0x003EC999
		[NullableContext(1)]
		public static ThirdPartySharedNotify Create()
		{
			return new ThirdPartySharedNotify();
		}

		// Token: 0x17005B6F RID: 23407
		// (get) Token: 0x0601AFED RID: 110573 RVA: 0x003EE7A0 File Offset: 0x003EC9A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B70 RID: 23408
		// (get) Token: 0x0601AFEE RID: 110574 RVA: 0x003EE7A3 File Offset: 0x003EC9A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ThirdPartySharedNotify.Descriptor;
			}
		}

		// Token: 0x0601AFEF RID: 110575 RVA: 0x003EE7AA File Offset: 0x003EC9AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThirdPartySharedNotify()
		{
		}

		// Token: 0x0601AFF0 RID: 110576 RVA: 0x003EE7BD File Offset: 0x003EC9BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThirdPartySharedNotify(ThirdPartySharedNotify other) : this()
		{
			this.sharedIds_ = other.sharedIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AFF1 RID: 110577 RVA: 0x003EE7E7 File Offset: 0x003EC9E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThirdPartySharedNotify Clone()
		{
			return new ThirdPartySharedNotify(this);
		}

		// Token: 0x17005B71 RID: 23409
		// (get) Token: 0x0601AFF2 RID: 110578 RVA: 0x003EE7EF File Offset: 0x003EC9EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SharedIds
		{
			get
			{
				return this.sharedIds_;
			}
		}

		// Token: 0x0601AFF3 RID: 110579 RVA: 0x003EE7F7 File Offset: 0x003EC9F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ThirdPartySharedNotify);
		}

		// Token: 0x0601AFF4 RID: 110580 RVA: 0x003EE805 File Offset: 0x003ECA05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ThirdPartySharedNotify other)
		{
			return other != null && (other == this || (this.sharedIds_.Equals(other.sharedIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AFF5 RID: 110581 RVA: 0x003EE838 File Offset: 0x003ECA38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.sharedIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AFF6 RID: 110582 RVA: 0x003EE86C File Offset: 0x003ECA6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AFF7 RID: 110583 RVA: 0x003EE879 File Offset: 0x003ECA79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AFF8 RID: 110584 RVA: 0x003EE882 File Offset: 0x003ECA82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.sharedIds_.WriteTo(ref output, ThirdPartySharedNotify._repeated_sharedIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AFF9 RID: 110585 RVA: 0x003EE8AC File Offset: 0x003ECAAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.sharedIds_.CalculateSize(ThirdPartySharedNotify._repeated_sharedIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AFFA RID: 110586 RVA: 0x003EE8E5 File Offset: 0x003ECAE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ThirdPartySharedNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.sharedIds_.Add(other.sharedIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AFFB RID: 110587 RVA: 0x003EE913 File Offset: 0x003ECB13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AFFC RID: 110588 RVA: 0x003EE91C File Offset: 0x003ECB1C
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
				if (num != 96U && num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.sharedIds_.AddEntriesFrom(ref input, ThirdPartySharedNotify._repeated_sharedIds_codec);
				}
			}
		}

		// Token: 0x04009DCA RID: 40394
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009DCB RID: 40395
		public const int SharedIdsFieldNumber = 12;

		// Token: 0x04009DCC RID: 40396
		private static readonly FieldCodec<int> _repeated_sharedIds_codec = FieldCodec.ForInt32(98U);

		// Token: 0x04009DCD RID: 40397
		private readonly RepeatedField<int> sharedIds_ = new RepeatedField<int>();
	}
}
