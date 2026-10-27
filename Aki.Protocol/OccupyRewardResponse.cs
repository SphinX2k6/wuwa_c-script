using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B81 RID: 2945
	[NetMessage(EMessageId.OccupyRewardResponse)]
	public sealed class OccupyRewardResponse : IMessage<OccupyRewardResponse>, IMessage, IEquatable<OccupyRewardResponse>, IDeepCloneable<OccupyRewardResponse>, IBufferMessage
	{
		// Token: 0x0600FF3C RID: 65340 RVA: 0x00253859 File Offset: 0x00251A59
		[NullableContext(1)]
		public static OccupyRewardResponse Create()
		{
			return new OccupyRewardResponse();
		}

		// Token: 0x1700341D RID: 13341
		// (get) Token: 0x0600FF3D RID: 65341 RVA: 0x00253860 File Offset: 0x00251A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700341E RID: 13342
		// (get) Token: 0x0600FF3E RID: 65342 RVA: 0x00253863 File Offset: 0x00251A63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OccupyRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600FF3F RID: 65343 RVA: 0x0025386A File Offset: 0x00251A6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OccupyRewardResponse()
		{
		}

		// Token: 0x0600FF40 RID: 65344 RVA: 0x0025387D File Offset: 0x00251A7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OccupyRewardResponse(OccupyRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FF41 RID: 65345 RVA: 0x002538B3 File Offset: 0x00251AB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OccupyRewardResponse Clone()
		{
			return new OccupyRewardResponse(this);
		}

		// Token: 0x1700341F RID: 13343
		// (get) Token: 0x0600FF42 RID: 65346 RVA: 0x002538BB File Offset: 0x00251ABB
		// (set) Token: 0x0600FF43 RID: 65347 RVA: 0x002538C3 File Offset: 0x00251AC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17003420 RID: 13344
		// (get) Token: 0x0600FF44 RID: 65348 RVA: 0x002538CC File Offset: 0x00251ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x0600FF45 RID: 65349 RVA: 0x002538D4 File Offset: 0x00251AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OccupyRewardResponse);
		}

		// Token: 0x0600FF46 RID: 65350 RVA: 0x002538E4 File Offset: 0x00251AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OccupyRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FF47 RID: 65351 RVA: 0x00253934 File Offset: 0x00251B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.ids_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FF48 RID: 65352 RVA: 0x00253987 File Offset: 0x00251B87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FF49 RID: 65353 RVA: 0x00253994 File Offset: 0x00251B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FF4A RID: 65354 RVA: 0x002539A0 File Offset: 0x00251BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.ids_.WriteTo(ref output, OccupyRewardResponse._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FF4B RID: 65355 RVA: 0x002539F0 File Offset: 0x00251BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.ids_.CalculateSize(OccupyRewardResponse._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FF4C RID: 65356 RVA: 0x00253A44 File Offset: 0x00251C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OccupyRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.ids_.Add(other.ids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FF4D RID: 65357 RVA: 0x00253A91 File Offset: 0x00251C91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FF4E RID: 65358 RVA: 0x00253A9C File Offset: 0x00251C9C
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
				if (num != 72U)
				{
					if (num != 120U && num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ids_.AddEntriesFrom(ref input, OccupyRewardResponse._repeated_ids_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040065A8 RID: 26024
		private UnknownFieldSet _unknownFields;

		// Token: 0x040065A9 RID: 26025
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x040065AA RID: 26026
		private ErrorCode errorCode_;

		// Token: 0x040065AB RID: 26027
		public const int IdsFieldNumber = 15;

		// Token: 0x040065AC RID: 26028
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(122U);

		// Token: 0x040065AD RID: 26029
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
