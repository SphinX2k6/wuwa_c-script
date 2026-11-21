using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008A1 RID: 2209
	[NetMessage(EMessageId.KurotatoResTaskReceiveRequest)]
	public sealed class KurotatoResTaskReceiveRequest : IMessage<KurotatoResTaskReceiveRequest>, IMessage, IEquatable<KurotatoResTaskReceiveRequest>, IDeepCloneable<KurotatoResTaskReceiveRequest>, IBufferMessage
	{
		// Token: 0x0600C473 RID: 50291 RVA: 0x001D1C2E File Offset: 0x001CFE2E
		[NullableContext(1)]
		public static KurotatoResTaskReceiveRequest Create()
		{
			return new KurotatoResTaskReceiveRequest();
		}

		// Token: 0x170027AE RID: 10158
		// (get) Token: 0x0600C474 RID: 50292 RVA: 0x001D1C35 File Offset: 0x001CFE35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027AF RID: 10159
		// (get) Token: 0x0600C475 RID: 50293 RVA: 0x001D1C38 File Offset: 0x001CFE38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoResTaskReceiveRequest.Descriptor;
			}
		}

		// Token: 0x0600C476 RID: 50294 RVA: 0x001D1C3F File Offset: 0x001CFE3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoResTaskReceiveRequest()
		{
		}

		// Token: 0x0600C477 RID: 50295 RVA: 0x001D1C52 File Offset: 0x001CFE52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoResTaskReceiveRequest(KurotatoResTaskReceiveRequest other) : this()
		{
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C478 RID: 50296 RVA: 0x001D1C7C File Offset: 0x001CFE7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoResTaskReceiveRequest Clone()
		{
			return new KurotatoResTaskReceiveRequest(this);
		}

		// Token: 0x170027B0 RID: 10160
		// (get) Token: 0x0600C479 RID: 50297 RVA: 0x001D1C84 File Offset: 0x001CFE84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x0600C47A RID: 50298 RVA: 0x001D1C8C File Offset: 0x001CFE8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoResTaskReceiveRequest);
		}

		// Token: 0x0600C47B RID: 50299 RVA: 0x001D1C9A File Offset: 0x001CFE9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoResTaskReceiveRequest other)
		{
			return other != null && (other == this || (this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C47C RID: 50300 RVA: 0x001D1CD0 File Offset: 0x001CFED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.taskIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C47D RID: 50301 RVA: 0x001D1D04 File Offset: 0x001CFF04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C47E RID: 50302 RVA: 0x001D1D11 File Offset: 0x001CFF11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C47F RID: 50303 RVA: 0x001D1D1A File Offset: 0x001CFF1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskIds_.WriteTo(ref output, KurotatoResTaskReceiveRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C480 RID: 50304 RVA: 0x001D1D44 File Offset: 0x001CFF44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.taskIds_.CalculateSize(KurotatoResTaskReceiveRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C481 RID: 50305 RVA: 0x001D1D7D File Offset: 0x001CFF7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoResTaskReceiveRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.taskIds_.Add(other.taskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C482 RID: 50306 RVA: 0x001D1DAB File Offset: 0x001CFFAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C483 RID: 50307 RVA: 0x001D1DB4 File Offset: 0x001CFFB4
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
				if (num != 80U && num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.taskIds_.AddEntriesFrom(ref input, KurotatoResTaskReceiveRequest._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x04005504 RID: 21764
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005505 RID: 21765
		public const int TaskIdsFieldNumber = 10;

		// Token: 0x04005506 RID: 21766
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04005507 RID: 21767
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
