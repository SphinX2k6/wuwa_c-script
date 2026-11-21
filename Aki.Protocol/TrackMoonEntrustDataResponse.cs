using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001456 RID: 5206
	[NetMessage(EMessageId.TrackMoonEntrustDataResponse)]
	public sealed class TrackMoonEntrustDataResponse : IMessage<TrackMoonEntrustDataResponse>, IMessage, IEquatable<TrackMoonEntrustDataResponse>, IDeepCloneable<TrackMoonEntrustDataResponse>, IBufferMessage
	{
		// Token: 0x0601BA52 RID: 113234 RVA: 0x00403E76 File Offset: 0x00402076
		[NullableContext(1)]
		public static TrackMoonEntrustDataResponse Create()
		{
			return new TrackMoonEntrustDataResponse();
		}

		// Token: 0x17005D8B RID: 23947
		// (get) Token: 0x0601BA53 RID: 113235 RVA: 0x00403E7D File Offset: 0x0040207D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D8C RID: 23948
		// (get) Token: 0x0601BA54 RID: 113236 RVA: 0x00403E80 File Offset: 0x00402080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonEntrustDataResponse.Descriptor;
			}
		}

		// Token: 0x0601BA55 RID: 113237 RVA: 0x00403E87 File Offset: 0x00402087
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonEntrustDataResponse()
		{
		}

		// Token: 0x0601BA56 RID: 113238 RVA: 0x00403E9A File Offset: 0x0040209A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonEntrustDataResponse(TrackMoonEntrustDataResponse other) : this()
		{
			this.entrustInfos_ = other.entrustInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BA57 RID: 113239 RVA: 0x00403EC4 File Offset: 0x004020C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonEntrustDataResponse Clone()
		{
			return new TrackMoonEntrustDataResponse(this);
		}

		// Token: 0x17005D8D RID: 23949
		// (get) Token: 0x0601BA58 RID: 113240 RVA: 0x00403ECC File Offset: 0x004020CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EntrustInfo> EntrustInfos
		{
			get
			{
				return this.entrustInfos_;
			}
		}

		// Token: 0x0601BA59 RID: 113241 RVA: 0x00403ED4 File Offset: 0x004020D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonEntrustDataResponse);
		}

		// Token: 0x0601BA5A RID: 113242 RVA: 0x00403EE2 File Offset: 0x004020E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonEntrustDataResponse other)
		{
			return other != null && (other == this || (this.entrustInfos_.Equals(other.entrustInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BA5B RID: 113243 RVA: 0x00403F18 File Offset: 0x00402118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.entrustInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BA5C RID: 113244 RVA: 0x00403F4C File Offset: 0x0040214C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BA5D RID: 113245 RVA: 0x00403F59 File Offset: 0x00402159
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BA5E RID: 113246 RVA: 0x00403F62 File Offset: 0x00402162
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entrustInfos_.WriteTo(ref output, TrackMoonEntrustDataResponse._repeated_entrustInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BA5F RID: 113247 RVA: 0x00403F8C File Offset: 0x0040218C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.entrustInfos_.CalculateSize(TrackMoonEntrustDataResponse._repeated_entrustInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BA60 RID: 113248 RVA: 0x00403FC5 File Offset: 0x004021C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrackMoonEntrustDataResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.entrustInfos_.Add(other.entrustInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BA61 RID: 113249 RVA: 0x00403FF3 File Offset: 0x004021F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BA62 RID: 113250 RVA: 0x00403FFC File Offset: 0x004021FC
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
					this.entrustInfos_.AddEntriesFrom(ref input, TrackMoonEntrustDataResponse._repeated_entrustInfos_codec);
				}
			}
		}

		// Token: 0x0400A090 RID: 41104
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A091 RID: 41105
		public const int EntrustInfosFieldNumber = 5;

		// Token: 0x0400A092 RID: 41106
		private static readonly FieldCodec<EntrustInfo> _repeated_entrustInfos_codec = FieldCodec.ForMessage<EntrustInfo>(42U, EntrustInfo.Parser);

		// Token: 0x0400A093 RID: 41107
		private readonly RepeatedField<EntrustInfo> entrustInfos_ = new RepeatedField<EntrustInfo>();
	}
}
