using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001311 RID: 4881
	[NetMessage(EMessageId.SubmitItemInfoNotify)]
	public sealed class SubmitItemInfoNotify : IMessage<SubmitItemInfoNotify>, IMessage, IEquatable<SubmitItemInfoNotify>, IDeepCloneable<SubmitItemInfoNotify>, IBufferMessage
	{
		// Token: 0x0601A06A RID: 106602 RVA: 0x003CB1F9 File Offset: 0x003C93F9
		[NullableContext(1)]
		public static SubmitItemInfoNotify Create()
		{
			return new SubmitItemInfoNotify();
		}

		// Token: 0x1700581E RID: 22558
		// (get) Token: 0x0601A06B RID: 106603 RVA: 0x003CB200 File Offset: 0x003C9400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700581F RID: 22559
		// (get) Token: 0x0601A06C RID: 106604 RVA: 0x003CB203 File Offset: 0x003C9403
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubmitItemInfoNotify.Descriptor;
			}
		}

		// Token: 0x0601A06D RID: 106605 RVA: 0x003CB20A File Offset: 0x003C940A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitItemInfoNotify()
		{
		}

		// Token: 0x0601A06E RID: 106606 RVA: 0x003CB21D File Offset: 0x003C941D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitItemInfoNotify(SubmitItemInfoNotify other) : this()
		{
			this.gatherTaskSubmitInfos_ = other.gatherTaskSubmitInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A06F RID: 106607 RVA: 0x003CB247 File Offset: 0x003C9447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitItemInfoNotify Clone()
		{
			return new SubmitItemInfoNotify(this);
		}

		// Token: 0x17005820 RID: 22560
		// (get) Token: 0x0601A070 RID: 106608 RVA: 0x003CB24F File Offset: 0x003C944F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GatherTaskSubmitInfo> GatherTaskSubmitInfos
		{
			get
			{
				return this.gatherTaskSubmitInfos_;
			}
		}

		// Token: 0x0601A071 RID: 106609 RVA: 0x003CB257 File Offset: 0x003C9457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubmitItemInfoNotify);
		}

		// Token: 0x0601A072 RID: 106610 RVA: 0x003CB265 File Offset: 0x003C9465
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SubmitItemInfoNotify other)
		{
			return other != null && (other == this || (this.gatherTaskSubmitInfos_.Equals(other.gatherTaskSubmitInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A073 RID: 106611 RVA: 0x003CB298 File Offset: 0x003C9498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.gatherTaskSubmitInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A074 RID: 106612 RVA: 0x003CB2CC File Offset: 0x003C94CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A075 RID: 106613 RVA: 0x003CB2D9 File Offset: 0x003C94D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A076 RID: 106614 RVA: 0x003CB2E2 File Offset: 0x003C94E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.gatherTaskSubmitInfos_.WriteTo(ref output, SubmitItemInfoNotify._repeated_gatherTaskSubmitInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A077 RID: 106615 RVA: 0x003CB30C File Offset: 0x003C950C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.gatherTaskSubmitInfos_.CalculateSize(SubmitItemInfoNotify._repeated_gatherTaskSubmitInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A078 RID: 106616 RVA: 0x003CB345 File Offset: 0x003C9545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SubmitItemInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.gatherTaskSubmitInfos_.Add(other.gatherTaskSubmitInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A079 RID: 106617 RVA: 0x003CB373 File Offset: 0x003C9573
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A07A RID: 106618 RVA: 0x003CB37C File Offset: 0x003C957C
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.gatherTaskSubmitInfos_.AddEntriesFrom(ref input, SubmitItemInfoNotify._repeated_gatherTaskSubmitInfos_codec);
				}
			}
		}

		// Token: 0x04009941 RID: 39233
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009942 RID: 39234
		public const int GatherTaskSubmitInfosFieldNumber = 10;

		// Token: 0x04009943 RID: 39235
		private static readonly FieldCodec<GatherTaskSubmitInfo> _repeated_gatherTaskSubmitInfos_codec = FieldCodec.ForMessage<GatherTaskSubmitInfo>(82U, GatherTaskSubmitInfo.Parser);

		// Token: 0x04009944 RID: 39236
		private readonly RepeatedField<GatherTaskSubmitInfo> gatherTaskSubmitInfos_ = new RepeatedField<GatherTaskSubmitInfo>();
	}
}
