using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DFF RID: 3583
	[NetMessage(EMessageId.QueryOnlinePlayersAreaResponse)]
	public sealed class QueryOnlinePlayersAreaResponse : IMessage<QueryOnlinePlayersAreaResponse>, IMessage, IEquatable<QueryOnlinePlayersAreaResponse>, IDeepCloneable<QueryOnlinePlayersAreaResponse>, IBufferMessage
	{
		// Token: 0x06013441 RID: 78913 RVA: 0x002CE0BA File Offset: 0x002CC2BA
		[NullableContext(1)]
		public static QueryOnlinePlayersAreaResponse Create()
		{
			return new QueryOnlinePlayersAreaResponse();
		}

		// Token: 0x17003FEA RID: 16362
		// (get) Token: 0x06013442 RID: 78914 RVA: 0x002CE0C1 File Offset: 0x002CC2C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FEB RID: 16363
		// (get) Token: 0x06013443 RID: 78915 RVA: 0x002CE0C4 File Offset: 0x002CC2C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QueryOnlinePlayersAreaResponse.Descriptor;
			}
		}

		// Token: 0x06013444 RID: 78916 RVA: 0x002CE0CB File Offset: 0x002CC2CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QueryOnlinePlayersAreaResponse()
		{
		}

		// Token: 0x06013445 RID: 78917 RVA: 0x002CE0DE File Offset: 0x002CC2DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QueryOnlinePlayersAreaResponse(QueryOnlinePlayersAreaResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.areaDict_ = other.areaDict_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013446 RID: 78918 RVA: 0x002CE114 File Offset: 0x002CC314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QueryOnlinePlayersAreaResponse Clone()
		{
			return new QueryOnlinePlayersAreaResponse(this);
		}

		// Token: 0x17003FEC RID: 16364
		// (get) Token: 0x06013447 RID: 78919 RVA: 0x002CE11C File Offset: 0x002CC31C
		// (set) Token: 0x06013448 RID: 78920 RVA: 0x002CE124 File Offset: 0x002CC324
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

		// Token: 0x17003FED RID: 16365
		// (get) Token: 0x06013449 RID: 78921 RVA: 0x002CE12D File Offset: 0x002CC32D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> AreaDict
		{
			get
			{
				return this.areaDict_;
			}
		}

		// Token: 0x0601344A RID: 78922 RVA: 0x002CE135 File Offset: 0x002CC335
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QueryOnlinePlayersAreaResponse);
		}

		// Token: 0x0601344B RID: 78923 RVA: 0x002CE144 File Offset: 0x002CC344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QueryOnlinePlayersAreaResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.AreaDict.Equals(other.AreaDict) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601344C RID: 78924 RVA: 0x002CE194 File Offset: 0x002CC394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.AreaDict.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601344D RID: 78925 RVA: 0x002CE1E7 File Offset: 0x002CC3E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601344E RID: 78926 RVA: 0x002CE1F4 File Offset: 0x002CC3F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601344F RID: 78927 RVA: 0x002CE200 File Offset: 0x002CC400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.areaDict_.WriteTo(ref output, QueryOnlinePlayersAreaResponse._map_areaDict_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013450 RID: 78928 RVA: 0x002CE250 File Offset: 0x002CC450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.areaDict_.CalculateSize(QueryOnlinePlayersAreaResponse._map_areaDict_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013451 RID: 78929 RVA: 0x002CE2A4 File Offset: 0x002CC4A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QueryOnlinePlayersAreaResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.areaDict_.MergeFrom(other.areaDict_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013452 RID: 78930 RVA: 0x002CE2F1 File Offset: 0x002CC4F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013453 RID: 78931 RVA: 0x002CE2FC File Offset: 0x002CC4FC
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
				if (num != 16U)
				{
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.areaDict_.AddEntriesFrom(ref input, QueryOnlinePlayersAreaResponse._map_areaDict_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400767C RID: 30332
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400767D RID: 30333
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x0400767E RID: 30334
		private ErrorCode errorCode_;

		// Token: 0x0400767F RID: 30335
		public const int AreaDictFieldNumber = 10;

		// Token: 0x04007680 RID: 30336
		private static readonly MapField<int, int>.Codec _map_areaDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 82U);

		// Token: 0x04007681 RID: 30337
		private readonly MapField<int, int> areaDict_ = new MapField<int, int>();
	}
}
