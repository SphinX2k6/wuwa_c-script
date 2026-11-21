using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000978 RID: 2424
	[NetMessage(EMessageId.MapMarkInfoResponse)]
	public sealed class MapMarkInfoResponse : IMessage<MapMarkInfoResponse>, IMessage, IEquatable<MapMarkInfoResponse>, IDeepCloneable<MapMarkInfoResponse>, IBufferMessage
	{
		// Token: 0x0600D57D RID: 54653 RVA: 0x001F6CFE File Offset: 0x001F4EFE
		[NullableContext(1)]
		public static MapMarkInfoResponse Create()
		{
			return new MapMarkInfoResponse();
		}

		// Token: 0x17002B34 RID: 11060
		// (get) Token: 0x0600D57E RID: 54654 RVA: 0x001F6D05 File Offset: 0x001F4F05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B35 RID: 11061
		// (get) Token: 0x0600D57F RID: 54655 RVA: 0x001F6D08 File Offset: 0x001F4F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapMarkInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600D580 RID: 54656 RVA: 0x001F6D0F File Offset: 0x001F4F0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkInfoResponse()
		{
		}

		// Token: 0x0600D581 RID: 54657 RVA: 0x001F6D30 File Offset: 0x001F4F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkInfoResponse(MapMarkInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.infoList_ = other.infoList_.Clone();
			this.showMarkIds_ = other.showMarkIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D582 RID: 54658 RVA: 0x001F6D82 File Offset: 0x001F4F82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkInfoResponse Clone()
		{
			return new MapMarkInfoResponse(this);
		}

		// Token: 0x17002B36 RID: 11062
		// (get) Token: 0x0600D583 RID: 54659 RVA: 0x001F6D8A File Offset: 0x001F4F8A
		// (set) Token: 0x0600D584 RID: 54660 RVA: 0x001F6D92 File Offset: 0x001F4F92
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

		// Token: 0x17002B37 RID: 11063
		// (get) Token: 0x0600D585 RID: 54661 RVA: 0x001F6D9B File Offset: 0x001F4F9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MarkPointInfo> InfoList
		{
			get
			{
				return this.infoList_;
			}
		}

		// Token: 0x17002B38 RID: 11064
		// (get) Token: 0x0600D586 RID: 54662 RVA: 0x001F6DA3 File Offset: 0x001F4FA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MapMarkShowInfo> ShowMarkIds
		{
			get
			{
				return this.showMarkIds_;
			}
		}

		// Token: 0x0600D587 RID: 54663 RVA: 0x001F6DAB File Offset: 0x001F4FAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapMarkInfoResponse);
		}

		// Token: 0x0600D588 RID: 54664 RVA: 0x001F6DBC File Offset: 0x001F4FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapMarkInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.infoList_.Equals(other.infoList_) && this.showMarkIds_.Equals(other.showMarkIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D589 RID: 54665 RVA: 0x001F6E20 File Offset: 0x001F5020
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

		// Token: 0x0600D58A RID: 54666 RVA: 0x001F6E81 File Offset: 0x001F5081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D58B RID: 54667 RVA: 0x001F6E8E File Offset: 0x001F508E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D58C RID: 54668 RVA: 0x001F6E98 File Offset: 0x001F5098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.showMarkIds_.WriteTo(ref output, MapMarkInfoResponse._repeated_showMarkIds_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.infoList_.WriteTo(ref output, MapMarkInfoResponse._repeated_infoList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D58D RID: 54669 RVA: 0x001F6EF8 File Offset: 0x001F50F8
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

		// Token: 0x0600D58E RID: 54670 RVA: 0x001F6F5C File Offset: 0x001F515C
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

		// Token: 0x0600D58F RID: 54671 RVA: 0x001F6FBA File Offset: 0x001F51BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D590 RID: 54672 RVA: 0x001F6FC4 File Offset: 0x001F51C4
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
				if (num != 50U)
				{
					if (num != 80U)
					{
						if (num != 106U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.showMarkIds_.AddEntriesFrom(ref input, MapMarkInfoResponse._repeated_showMarkIds_codec);
				}
			}
		}

		// Token: 0x040059B9 RID: 22969
		private UnknownFieldSet _unknownFields;

		// Token: 0x040059BA RID: 22970
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x040059BB RID: 22971
		private ErrorCode errorCode_;

		// Token: 0x040059BC RID: 22972
		public const int InfoListFieldNumber = 13;

		// Token: 0x040059BD RID: 22973
		private static readonly FieldCodec<MarkPointInfo> _repeated_infoList_codec = FieldCodec.ForMessage<MarkPointInfo>(106U, MarkPointInfo.Parser);

		// Token: 0x040059BE RID: 22974
		private readonly RepeatedField<MarkPointInfo> infoList_ = new RepeatedField<MarkPointInfo>();

		// Token: 0x040059BF RID: 22975
		public const int ShowMarkIdsFieldNumber = 6;

		// Token: 0x040059C0 RID: 22976
		private static readonly FieldCodec<MapMarkShowInfo> _repeated_showMarkIds_codec = FieldCodec.ForMessage<MapMarkShowInfo>(50U, MapMarkShowInfo.Parser);

		// Token: 0x040059C1 RID: 22977
		private readonly RepeatedField<MapMarkShowInfo> showMarkIds_ = new RepeatedField<MapMarkShowInfo>();
	}
}
