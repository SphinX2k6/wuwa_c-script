using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006E6 RID: 1766
	[NetMessage(EMessageId.GiantStableValueActivityRequest)]
	public sealed class GiantStableValueActivityRequest : IMessage<GiantStableValueActivityRequest>, IMessage, IEquatable<GiantStableValueActivityRequest>, IDeepCloneable<GiantStableValueActivityRequest>, IBufferMessage
	{
		// Token: 0x0600A11E RID: 41246 RVA: 0x00186067 File Offset: 0x00184267
		[NullableContext(1)]
		public static GiantStableValueActivityRequest Create()
		{
			return new GiantStableValueActivityRequest();
		}

		// Token: 0x1700205F RID: 8287
		// (get) Token: 0x0600A11F RID: 41247 RVA: 0x0018606E File Offset: 0x0018426E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002060 RID: 8288
		// (get) Token: 0x0600A120 RID: 41248 RVA: 0x00186071 File Offset: 0x00184271
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiantStableValueActivityRequest.Descriptor;
			}
		}

		// Token: 0x0600A121 RID: 41249 RVA: 0x00186078 File Offset: 0x00184278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantStableValueActivityRequest()
		{
		}

		// Token: 0x0600A122 RID: 41250 RVA: 0x0018608B File Offset: 0x0018428B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantStableValueActivityRequest(GiantStableValueActivityRequest other) : this()
		{
			this.rewardIds_ = other.rewardIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A123 RID: 41251 RVA: 0x001860B5 File Offset: 0x001842B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantStableValueActivityRequest Clone()
		{
			return new GiantStableValueActivityRequest(this);
		}

		// Token: 0x17002061 RID: 8289
		// (get) Token: 0x0600A124 RID: 41252 RVA: 0x001860BD File Offset: 0x001842BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardIds
		{
			get
			{
				return this.rewardIds_;
			}
		}

		// Token: 0x0600A125 RID: 41253 RVA: 0x001860C5 File Offset: 0x001842C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiantStableValueActivityRequest);
		}

		// Token: 0x0600A126 RID: 41254 RVA: 0x001860D3 File Offset: 0x001842D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiantStableValueActivityRequest other)
		{
			return other != null && (other == this || (this.rewardIds_.Equals(other.rewardIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A127 RID: 41255 RVA: 0x00186108 File Offset: 0x00184308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.rewardIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A128 RID: 41256 RVA: 0x0018613C File Offset: 0x0018433C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A129 RID: 41257 RVA: 0x00186149 File Offset: 0x00184349
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A12A RID: 41258 RVA: 0x00186152 File Offset: 0x00184352
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rewardIds_.WriteTo(ref output, GiantStableValueActivityRequest._repeated_rewardIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A12B RID: 41259 RVA: 0x0018617C File Offset: 0x0018437C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rewardIds_.CalculateSize(GiantStableValueActivityRequest._repeated_rewardIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A12C RID: 41260 RVA: 0x001861B5 File Offset: 0x001843B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GiantStableValueActivityRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.rewardIds_.Add(other.rewardIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A12D RID: 41261 RVA: 0x001861E3 File Offset: 0x001843E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A12E RID: 41262 RVA: 0x001861EC File Offset: 0x001843EC
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
				if (num != 48U && num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.rewardIds_.AddEntriesFrom(ref input, GiantStableValueActivityRequest._repeated_rewardIds_codec);
				}
			}
		}

		// Token: 0x04004AE2 RID: 19170
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AE3 RID: 19171
		public const int RewardIdsFieldNumber = 6;

		// Token: 0x04004AE4 RID: 19172
		private static readonly FieldCodec<int> _repeated_rewardIds_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04004AE5 RID: 19173
		private readonly RepeatedField<int> rewardIds_ = new RepeatedField<int>();
	}
}
