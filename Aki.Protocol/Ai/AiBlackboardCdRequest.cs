using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x02001721 RID: 5921
	[NetMessage(EMessageId.AiBlackboardCdRequest)]
	public sealed class AiBlackboardCdRequest : IMessage<AiBlackboardCdRequest>, IMessage, IEquatable<AiBlackboardCdRequest>, IDeepCloneable<AiBlackboardCdRequest>, IBufferMessage
	{
		// Token: 0x0601DB99 RID: 121753 RVA: 0x0045C5A6 File Offset: 0x0045A7A6
		[NullableContext(1)]
		public static AiBlackboardCdRequest Create()
		{
			return new AiBlackboardCdRequest();
		}

		// Token: 0x17006538 RID: 25912
		// (get) Token: 0x0601DB9A RID: 121754 RVA: 0x0045C5AD File Offset: 0x0045A7AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006539 RID: 25913
		// (get) Token: 0x0601DB9B RID: 121755 RVA: 0x0045C5B0 File Offset: 0x0045A7B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AiBlackboardCdRequest.Descriptor;
			}
		}

		// Token: 0x0601DB9C RID: 121756 RVA: 0x0045C5B7 File Offset: 0x0045A7B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardCdRequest()
		{
		}

		// Token: 0x0601DB9D RID: 121757 RVA: 0x0045C5D5 File Offset: 0x0045A7D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardCdRequest(AiBlackboardCdRequest other) : this()
		{
			this.aiBlackboardCdModify_ = other.aiBlackboardCdModify_.Clone();
			this.aiBlackboardCdComplete_ = other.aiBlackboardCdComplete_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601DB9E RID: 121758 RVA: 0x0045C610 File Offset: 0x0045A810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardCdRequest Clone()
		{
			return new AiBlackboardCdRequest(this);
		}

		// Token: 0x1700653A RID: 25914
		// (get) Token: 0x0601DB9F RID: 121759 RVA: 0x0045C618 File Offset: 0x0045A818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Int2Long> AiBlackboardCdModify
		{
			get
			{
				return this.aiBlackboardCdModify_;
			}
		}

		// Token: 0x1700653B RID: 25915
		// (get) Token: 0x0601DBA0 RID: 121760 RVA: 0x0045C620 File Offset: 0x0045A820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Int2Bool> AiBlackboardCdComplete
		{
			get
			{
				return this.aiBlackboardCdComplete_;
			}
		}

		// Token: 0x0601DBA1 RID: 121761 RVA: 0x0045C628 File Offset: 0x0045A828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AiBlackboardCdRequest);
		}

		// Token: 0x0601DBA2 RID: 121762 RVA: 0x0045C638 File Offset: 0x0045A838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AiBlackboardCdRequest other)
		{
			return other != null && (other == this || (this.aiBlackboardCdModify_.Equals(other.aiBlackboardCdModify_) && this.aiBlackboardCdComplete_.Equals(other.aiBlackboardCdComplete_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601DBA3 RID: 121763 RVA: 0x0045C68C File Offset: 0x0045A88C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.aiBlackboardCdModify_.GetHashCode();
			num ^= this.aiBlackboardCdComplete_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601DBA4 RID: 121764 RVA: 0x0045C6CE File Offset: 0x0045A8CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601DBA5 RID: 121765 RVA: 0x0045C6DB File Offset: 0x0045A8DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601DBA6 RID: 121766 RVA: 0x0045C6E4 File Offset: 0x0045A8E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.aiBlackboardCdModify_.WriteTo(ref output, AiBlackboardCdRequest._repeated_aiBlackboardCdModify_codec);
			this.aiBlackboardCdComplete_.WriteTo(ref output, AiBlackboardCdRequest._repeated_aiBlackboardCdComplete_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601DBA7 RID: 121767 RVA: 0x0045C71C File Offset: 0x0045A91C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.aiBlackboardCdModify_.CalculateSize(AiBlackboardCdRequest._repeated_aiBlackboardCdModify_codec);
			num += this.aiBlackboardCdComplete_.CalculateSize(AiBlackboardCdRequest._repeated_aiBlackboardCdComplete_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601DBA8 RID: 121768 RVA: 0x0045C768 File Offset: 0x0045A968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AiBlackboardCdRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.aiBlackboardCdModify_.Add(other.aiBlackboardCdModify_);
			this.aiBlackboardCdComplete_.Add(other.aiBlackboardCdComplete_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601DBA9 RID: 121769 RVA: 0x0045C7A7 File Offset: 0x0045A9A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601DBAA RID: 121770 RVA: 0x0045C7B0 File Offset: 0x0045A9B0
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
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.aiBlackboardCdComplete_.AddEntriesFrom(ref input, AiBlackboardCdRequest._repeated_aiBlackboardCdComplete_codec);
					}
				}
				else
				{
					this.aiBlackboardCdModify_.AddEntriesFrom(ref input, AiBlackboardCdRequest._repeated_aiBlackboardCdModify_codec);
				}
			}
		}

		// Token: 0x0400C942 RID: 51522
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C943 RID: 51523
		public const int AiBlackboardCdModifyFieldNumber = 5;

		// Token: 0x0400C944 RID: 51524
		private static readonly FieldCodec<Int2Long> _repeated_aiBlackboardCdModify_codec = FieldCodec.ForMessage<Int2Long>(42U, Int2Long.Parser);

		// Token: 0x0400C945 RID: 51525
		private readonly RepeatedField<Int2Long> aiBlackboardCdModify_ = new RepeatedField<Int2Long>();

		// Token: 0x0400C946 RID: 51526
		public const int AiBlackboardCdCompleteFieldNumber = 11;

		// Token: 0x0400C947 RID: 51527
		private static readonly FieldCodec<Int2Bool> _repeated_aiBlackboardCdComplete_codec = FieldCodec.ForMessage<Int2Bool>(90U, Int2Bool.Parser);

		// Token: 0x0400C948 RID: 51528
		private readonly RepeatedField<Int2Bool> aiBlackboardCdComplete_ = new RepeatedField<Int2Bool>();
	}
}
