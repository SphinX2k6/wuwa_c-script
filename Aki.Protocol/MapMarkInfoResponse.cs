using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000989 RID: 2441
	[NetMessage(EMessageId.MapMarkInfoResponse)]
	public sealed class MapMarkInfoResponse : IMessage<MapMarkInfoResponse>, IMessage, IEquatable<MapMarkInfoResponse>, IDeepCloneable<MapMarkInfoResponse>, IBufferMessage
	{
		// Token: 0x0600D697 RID: 54935 RVA: 0x001F8EE2 File Offset: 0x001F70E2
		[NullableContext(1)]
		public static MapMarkInfoResponse Create()
		{
			return new MapMarkInfoResponse();
		}

		// Token: 0x17002B72 RID: 11122
		// (get) Token: 0x0600D698 RID: 54936 RVA: 0x001F8EE9 File Offset: 0x001F70E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B73 RID: 11123
		// (get) Token: 0x0600D699 RID: 54937 RVA: 0x001F8EEC File Offset: 0x001F70EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapMarkInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600D69A RID: 54938 RVA: 0x001F8EF3 File Offset: 0x001F70F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkInfoResponse()
		{
		}

		// Token: 0x0600D69B RID: 54939 RVA: 0x001F8F14 File Offset: 0x001F7114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkInfoResponse(MapMarkInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.infoList_ = other.infoList_.Clone();
			this.showMarkIds_ = other.showMarkIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D69C RID: 54940 RVA: 0x001F8F66 File Offset: 0x001F7166
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkInfoResponse Clone()
		{
			return new MapMarkInfoResponse(this);
		}

		// Token: 0x17002B74 RID: 11124
		// (get) Token: 0x0600D69D RID: 54941 RVA: 0x001F8F6E File Offset: 0x001F716E
		// (set) Token: 0x0600D69E RID: 54942 RVA: 0x001F8F76 File Offset: 0x001F7176
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

		// Token: 0x17002B75 RID: 11125
		// (get) Token: 0x0600D69F RID: 54943 RVA: 0x001F8F7F File Offset: 0x001F717F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MarkPointInfo> InfoList
		{
			get
			{
				return this.infoList_;
			}
		}

		// Token: 0x17002B76 RID: 11126
		// (get) Token: 0x0600D6A0 RID: 54944 RVA: 0x001F8F87 File Offset: 0x001F7187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MapMarkShowInfo> ShowMarkIds
		{
			get
			{
				return this.showMarkIds_;
			}
		}

		// Token: 0x0600D6A1 RID: 54945 RVA: 0x001F8F8F File Offset: 0x001F718F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapMarkInfoResponse);
		}

		// Token: 0x0600D6A2 RID: 54946 RVA: 0x001F8FA0 File Offset: 0x001F71A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapMarkInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.infoList_.Equals(other.infoList_) && this.showMarkIds_.Equals(other.showMarkIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D6A3 RID: 54947 RVA: 0x001F9004 File Offset: 0x001F7204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.infoList_.GetHashCode();
			num ^= this.showMarkIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D6A4 RID: 54948 RVA: 0x001F9065 File Offset: 0x001F7265
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D6A5 RID: 54949 RVA: 0x001F9072 File Offset: 0x001F7272
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D6A6 RID: 54950 RVA: 0x001F907C File Offset: 0x001F727C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.infoList_.WriteTo(ref output, MapMarkInfoResponse._repeated_infoList_codec);
			this.showMarkIds_.WriteTo(ref output, MapMarkInfoResponse._repeated_showMarkIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D6A7 RID: 54951 RVA: 0x001F90DC File Offset: 0x001F72DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.infoList_.CalculateSize(MapMarkInfoResponse._repeated_infoList_codec);
			num += this.showMarkIds_.CalculateSize(MapMarkInfoResponse._repeated_showMarkIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D6A8 RID: 54952 RVA: 0x001F9140 File Offset: 0x001F7340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapMarkInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.infoList_.Add(other.infoList_);
			this.showMarkIds_.Add(other.showMarkIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D6A9 RID: 54953 RVA: 0x001F919E File Offset: 0x001F739E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D6AA RID: 54954 RVA: 0x001F91A8 File Offset: 0x001F73A8
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
				if (num != 32U)
				{
					if (num != 58U)
					{
						if (num != 82U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.showMarkIds_.AddEntriesFrom(ref input, MapMarkInfoResponse._repeated_showMarkIds_codec);
						}
					}
					else
					{
						this.infoList_.AddEntriesFrom(ref input, MapMarkInfoResponse._repeated_infoList_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040059B0 RID: 22960
		private UnknownFieldSet _unknownFields;

		// Token: 0x040059B1 RID: 22961
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x040059B2 RID: 22962
		private ErrorCode errorCode_;

		// Token: 0x040059B3 RID: 22963
		public const int InfoListFieldNumber = 7;

		// Token: 0x040059B4 RID: 22964
		private static readonly FieldCodec<MarkPointInfo> _repeated_infoList_codec = FieldCodec.ForMessage<MarkPointInfo>(58U, MarkPointInfo.Parser);

		// Token: 0x040059B5 RID: 22965
		private readonly RepeatedField<MarkPointInfo> infoList_ = new RepeatedField<MarkPointInfo>();

		// Token: 0x040059B6 RID: 22966
		public const int ShowMarkIdsFieldNumber = 10;

		// Token: 0x040059B7 RID: 22967
		private static readonly FieldCodec<MapMarkShowInfo> _repeated_showMarkIds_codec = FieldCodec.ForMessage<MapMarkShowInfo>(82U, MapMarkShowInfo.Parser);

		// Token: 0x040059B8 RID: 22968
		private readonly RepeatedField<MapMarkShowInfo> showMarkIds_ = new RepeatedField<MapMarkShowInfo>();
	}
}
