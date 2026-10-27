using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000334 RID: 820
	[NetMessage(EMessageId.DangoBrawlBagOperateRequest)]
	public sealed class DangoBrawlBagOperateRequest : IMessage<DangoBrawlBagOperateRequest>, IMessage, IEquatable<DangoBrawlBagOperateRequest>, IDeepCloneable<DangoBrawlBagOperateRequest>, IBufferMessage
	{
		// Token: 0x06005267 RID: 21095 RVA: 0x000C942A File Offset: 0x000C762A
		[NullableContext(1)]
		public static DangoBrawlBagOperateRequest Create()
		{
			return new DangoBrawlBagOperateRequest();
		}

		// Token: 0x17000EEF RID: 3823
		// (get) Token: 0x06005268 RID: 21096 RVA: 0x000C9431 File Offset: 0x000C7631
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000EF0 RID: 3824
		// (get) Token: 0x06005269 RID: 21097 RVA: 0x000C9434 File Offset: 0x000C7634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlBagOperateRequest.Descriptor;
			}
		}

		// Token: 0x0600526A RID: 21098 RVA: 0x000C943B File Offset: 0x000C763B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBagOperateRequest()
		{
		}

		// Token: 0x0600526B RID: 21099 RVA: 0x000C944E File Offset: 0x000C764E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBagOperateRequest(DangoBrawlBagOperateRequest other) : this()
		{
			this.ops_ = other.ops_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600526C RID: 21100 RVA: 0x000C9478 File Offset: 0x000C7678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBagOperateRequest Clone()
		{
			return new DangoBrawlBagOperateRequest(this);
		}

		// Token: 0x17000EF1 RID: 3825
		// (get) Token: 0x0600526D RID: 21101 RVA: 0x000C9480 File Offset: 0x000C7680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DangoBrawlBagOpInfo> Ops
		{
			get
			{
				return this.ops_;
			}
		}

		// Token: 0x0600526E RID: 21102 RVA: 0x000C9488 File Offset: 0x000C7688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlBagOperateRequest);
		}

		// Token: 0x0600526F RID: 21103 RVA: 0x000C9496 File Offset: 0x000C7696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlBagOperateRequest other)
		{
			return other != null && (other == this || (this.ops_.Equals(other.ops_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005270 RID: 21104 RVA: 0x000C94CC File Offset: 0x000C76CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ops_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005271 RID: 21105 RVA: 0x000C9500 File Offset: 0x000C7700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005272 RID: 21106 RVA: 0x000C950D File Offset: 0x000C770D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005273 RID: 21107 RVA: 0x000C9516 File Offset: 0x000C7716
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ops_.WriteTo(ref output, DangoBrawlBagOperateRequest._repeated_ops_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005274 RID: 21108 RVA: 0x000C9540 File Offset: 0x000C7740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ops_.CalculateSize(DangoBrawlBagOperateRequest._repeated_ops_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005275 RID: 21109 RVA: 0x000C9579 File Offset: 0x000C7779
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlBagOperateRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.ops_.Add(other.ops_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005276 RID: 21110 RVA: 0x000C95A7 File Offset: 0x000C77A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005277 RID: 21111 RVA: 0x000C95B0 File Offset: 0x000C77B0
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ops_.AddEntriesFrom(ref input, DangoBrawlBagOperateRequest._repeated_ops_codec);
				}
			}
		}

		// Token: 0x04003333 RID: 13107
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003334 RID: 13108
		public const int OpsFieldNumber = 4;

		// Token: 0x04003335 RID: 13109
		private static readonly FieldCodec<DangoBrawlBagOpInfo> _repeated_ops_codec = FieldCodec.ForMessage<DangoBrawlBagOpInfo>(34U, DangoBrawlBagOpInfo.Parser);

		// Token: 0x04003336 RID: 13110
		private readonly RepeatedField<DangoBrawlBagOpInfo> ops_ = new RepeatedField<DangoBrawlBagOpInfo>();
	}
}
