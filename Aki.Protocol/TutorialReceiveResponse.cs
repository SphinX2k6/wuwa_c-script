using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014EA RID: 5354
	[NetMessage(EMessageId.TutorialReceiveResponse)]
	public sealed class TutorialReceiveResponse : IMessage<TutorialReceiveResponse>, IMessage, IEquatable<TutorialReceiveResponse>, IDeepCloneable<TutorialReceiveResponse>, IBufferMessage
	{
		// Token: 0x0601C63D RID: 116285 RVA: 0x0041E554 File Offset: 0x0041C754
		[NullableContext(1)]
		public static TutorialReceiveResponse Create()
		{
			return new TutorialReceiveResponse();
		}

		// Token: 0x17006016 RID: 24598
		// (get) Token: 0x0601C63E RID: 116286 RVA: 0x0041E55B File Offset: 0x0041C75B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006017 RID: 24599
		// (get) Token: 0x0601C63F RID: 116287 RVA: 0x0041E55E File Offset: 0x0041C75E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TutorialReceiveResponse.Descriptor;
			}
		}

		// Token: 0x0601C640 RID: 116288 RVA: 0x0041E565 File Offset: 0x0041C765
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialReceiveResponse()
		{
		}

		// Token: 0x0601C641 RID: 116289 RVA: 0x0041E584 File Offset: 0x0041C784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialReceiveResponse(TutorialReceiveResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.errorParams_ = other.errorParams_.Clone();
			this.itemMap_ = other.itemMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C642 RID: 116290 RVA: 0x0041E5D6 File Offset: 0x0041C7D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialReceiveResponse Clone()
		{
			return new TutorialReceiveResponse(this);
		}

		// Token: 0x17006018 RID: 24600
		// (get) Token: 0x0601C643 RID: 116291 RVA: 0x0041E5DE File Offset: 0x0041C7DE
		// (set) Token: 0x0601C644 RID: 116292 RVA: 0x0041E5E6 File Offset: 0x0041C7E6
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

		// Token: 0x17006019 RID: 24601
		// (get) Token: 0x0601C645 RID: 116293 RVA: 0x0041E5EF File Offset: 0x0041C7EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ErrorParams
		{
			get
			{
				return this.errorParams_;
			}
		}

		// Token: 0x1700601A RID: 24602
		// (get) Token: 0x0601C646 RID: 116294 RVA: 0x0041E5F7 File Offset: 0x0041C7F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemMap
		{
			get
			{
				return this.itemMap_;
			}
		}

		// Token: 0x0601C647 RID: 116295 RVA: 0x0041E5FF File Offset: 0x0041C7FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TutorialReceiveResponse);
		}

		// Token: 0x0601C648 RID: 116296 RVA: 0x0041E610 File Offset: 0x0041C810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TutorialReceiveResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.errorParams_.Equals(other.errorParams_) && this.ItemMap.Equals(other.ItemMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C649 RID: 116297 RVA: 0x0041E674 File Offset: 0x0041C874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.errorParams_.GetHashCode();
			num ^= this.ItemMap.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C64A RID: 116298 RVA: 0x0041E6D5 File Offset: 0x0041C8D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C64B RID: 116299 RVA: 0x0041E6E2 File Offset: 0x0041C8E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C64C RID: 116300 RVA: 0x0041E6EC File Offset: 0x0041C8EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.errorParams_.WriteTo(ref output, TutorialReceiveResponse._repeated_errorParams_codec);
			this.itemMap_.WriteTo(ref output, TutorialReceiveResponse._map_itemMap_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C64D RID: 116301 RVA: 0x0041E74C File Offset: 0x0041C94C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.errorParams_.CalculateSize(TutorialReceiveResponse._repeated_errorParams_codec);
			num += this.itemMap_.CalculateSize(TutorialReceiveResponse._map_itemMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C64E RID: 116302 RVA: 0x0041E7B0 File Offset: 0x0041C9B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TutorialReceiveResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.errorParams_.Add(other.errorParams_);
			this.itemMap_.MergeFrom(other.itemMap_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C64F RID: 116303 RVA: 0x0041E80E File Offset: 0x0041CA0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C650 RID: 116304 RVA: 0x0041E818 File Offset: 0x0041CA18
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
				if (num != 10U)
				{
					if (num != 26U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ErrorCode = (ErrorCode)input.ReadEnum();
						}
					}
					else
					{
						this.itemMap_.AddEntriesFrom(ref input, TutorialReceiveResponse._map_itemMap_codec);
					}
				}
				else
				{
					this.errorParams_.AddEntriesFrom(ref input, TutorialReceiveResponse._repeated_errorParams_codec);
				}
			}
		}

		// Token: 0x0400A3F6 RID: 41974
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A3F7 RID: 41975
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x0400A3F8 RID: 41976
		private ErrorCode errorCode_;

		// Token: 0x0400A3F9 RID: 41977
		public const int ErrorParamsFieldNumber = 1;

		// Token: 0x0400A3FA RID: 41978
		private static readonly FieldCodec<string> _repeated_errorParams_codec = FieldCodec.ForString(10U);

		// Token: 0x0400A3FB RID: 41979
		private readonly RepeatedField<string> errorParams_ = new RepeatedField<string>();

		// Token: 0x0400A3FC RID: 41980
		public const int ItemMapFieldNumber = 3;

		// Token: 0x0400A3FD RID: 41981
		private static readonly MapField<int, int>.Codec _map_itemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 26U);

		// Token: 0x0400A3FE RID: 41982
		private readonly MapField<int, int> itemMap_ = new MapField<int, int>();
	}
}
