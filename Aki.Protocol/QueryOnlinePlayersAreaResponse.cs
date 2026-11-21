using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DEF RID: 3567
	[NetMessage(EMessageId.QueryOnlinePlayersAreaResponse)]
	public sealed class QueryOnlinePlayersAreaResponse : IMessage<QueryOnlinePlayersAreaResponse>, IMessage, IEquatable<QueryOnlinePlayersAreaResponse>, IDeepCloneable<QueryOnlinePlayersAreaResponse>, IBufferMessage
	{
		// Token: 0x0601335C RID: 78684 RVA: 0x002CC9FE File Offset: 0x002CABFE
		[NullableContext(1)]
		public static QueryOnlinePlayersAreaResponse Create()
		{
			return new QueryOnlinePlayersAreaResponse();
		}

		// Token: 0x17003FC0 RID: 16320
		// (get) Token: 0x0601335D RID: 78685 RVA: 0x002CCA05 File Offset: 0x002CAC05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FC1 RID: 16321
		// (get) Token: 0x0601335E RID: 78686 RVA: 0x002CCA08 File Offset: 0x002CAC08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QueryOnlinePlayersAreaResponse.Descriptor;
			}
		}

		// Token: 0x0601335F RID: 78687 RVA: 0x002CCA0F File Offset: 0x002CAC0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QueryOnlinePlayersAreaResponse()
		{
		}

		// Token: 0x06013360 RID: 78688 RVA: 0x002CCA22 File Offset: 0x002CAC22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QueryOnlinePlayersAreaResponse(QueryOnlinePlayersAreaResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.areaDict_ = other.areaDict_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013361 RID: 78689 RVA: 0x002CCA58 File Offset: 0x002CAC58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QueryOnlinePlayersAreaResponse Clone()
		{
			return new QueryOnlinePlayersAreaResponse(this);
		}

		// Token: 0x17003FC2 RID: 16322
		// (get) Token: 0x06013362 RID: 78690 RVA: 0x002CCA60 File Offset: 0x002CAC60
		// (set) Token: 0x06013363 RID: 78691 RVA: 0x002CCA68 File Offset: 0x002CAC68
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

		// Token: 0x17003FC3 RID: 16323
		// (get) Token: 0x06013364 RID: 78692 RVA: 0x002CCA71 File Offset: 0x002CAC71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> AreaDict
		{
			get
			{
				return this.areaDict_;
			}
		}

		// Token: 0x06013365 RID: 78693 RVA: 0x002CCA79 File Offset: 0x002CAC79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QueryOnlinePlayersAreaResponse);
		}

		// Token: 0x06013366 RID: 78694 RVA: 0x002CCA88 File Offset: 0x002CAC88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QueryOnlinePlayersAreaResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.AreaDict.Equals(other.AreaDict) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013367 RID: 78695 RVA: 0x002CCAD8 File Offset: 0x002CACD8
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

		// Token: 0x06013368 RID: 78696 RVA: 0x002CCB2B File Offset: 0x002CAD2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013369 RID: 78697 RVA: 0x002CCB38 File Offset: 0x002CAD38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601336A RID: 78698 RVA: 0x002CCB44 File Offset: 0x002CAD44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.areaDict_.WriteTo(ref output, QueryOnlinePlayersAreaResponse._map_areaDict_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601336B RID: 78699 RVA: 0x002CCB94 File Offset: 0x002CAD94
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

		// Token: 0x0601336C RID: 78700 RVA: 0x002CCBE8 File Offset: 0x002CADE8
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

		// Token: 0x0601336D RID: 78701 RVA: 0x002CCC35 File Offset: 0x002CAE35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601336E RID: 78702 RVA: 0x002CCC40 File Offset: 0x002CAE40
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
				if (num != 106U)
				{
					if (num != 120U)
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
					this.areaDict_.AddEntriesFrom(ref input, QueryOnlinePlayersAreaResponse._map_areaDict_codec);
				}
			}
		}

		// Token: 0x040076A6 RID: 30374
		private UnknownFieldSet _unknownFields;

		// Token: 0x040076A7 RID: 30375
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x040076A8 RID: 30376
		private ErrorCode errorCode_;

		// Token: 0x040076A9 RID: 30377
		public const int AreaDictFieldNumber = 13;

		// Token: 0x040076AA RID: 30378
		private static readonly MapField<int, int>.Codec _map_areaDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 106U);

		// Token: 0x040076AB RID: 30379
		private readonly MapField<int, int> areaDict_ = new MapField<int, int>();
	}
}
