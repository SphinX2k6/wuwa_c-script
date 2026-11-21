using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200145B RID: 5211
	[NetMessage(EMessageId.TrackMoonRoleDataResponse)]
	public sealed class TrackMoonRoleDataResponse : IMessage<TrackMoonRoleDataResponse>, IMessage, IEquatable<TrackMoonRoleDataResponse>, IDeepCloneable<TrackMoonRoleDataResponse>, IBufferMessage
	{
		// Token: 0x0601BAAA RID: 113322 RVA: 0x00404732 File Offset: 0x00402932
		[NullableContext(1)]
		public static TrackMoonRoleDataResponse Create()
		{
			return new TrackMoonRoleDataResponse();
		}

		// Token: 0x17005D99 RID: 23961
		// (get) Token: 0x0601BAAB RID: 113323 RVA: 0x00404739 File Offset: 0x00402939
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D9A RID: 23962
		// (get) Token: 0x0601BAAC RID: 113324 RVA: 0x0040473C File Offset: 0x0040293C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonRoleDataResponse.Descriptor;
			}
		}

		// Token: 0x0601BAAD RID: 113325 RVA: 0x00404743 File Offset: 0x00402943
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonRoleDataResponse()
		{
		}

		// Token: 0x0601BAAE RID: 113326 RVA: 0x00404756 File Offset: 0x00402956
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonRoleDataResponse(TrackMoonRoleDataResponse other) : this()
		{
			this.entrustRoleInfos_ = other.entrustRoleInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BAAF RID: 113327 RVA: 0x00404780 File Offset: 0x00402980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonRoleDataResponse Clone()
		{
			return new TrackMoonRoleDataResponse(this);
		}

		// Token: 0x17005D9B RID: 23963
		// (get) Token: 0x0601BAB0 RID: 113328 RVA: 0x00404788 File Offset: 0x00402988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EntrustRoleInfo> EntrustRoleInfos
		{
			get
			{
				return this.entrustRoleInfos_;
			}
		}

		// Token: 0x0601BAB1 RID: 113329 RVA: 0x00404790 File Offset: 0x00402990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonRoleDataResponse);
		}

		// Token: 0x0601BAB2 RID: 113330 RVA: 0x0040479E File Offset: 0x0040299E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonRoleDataResponse other)
		{
			return other != null && (other == this || (this.entrustRoleInfos_.Equals(other.entrustRoleInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BAB3 RID: 113331 RVA: 0x004047D4 File Offset: 0x004029D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.entrustRoleInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BAB4 RID: 113332 RVA: 0x00404808 File Offset: 0x00402A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BAB5 RID: 113333 RVA: 0x00404815 File Offset: 0x00402A15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BAB6 RID: 113334 RVA: 0x0040481E File Offset: 0x00402A1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entrustRoleInfos_.WriteTo(ref output, TrackMoonRoleDataResponse._repeated_entrustRoleInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BAB7 RID: 113335 RVA: 0x00404848 File Offset: 0x00402A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.entrustRoleInfos_.CalculateSize(TrackMoonRoleDataResponse._repeated_entrustRoleInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BAB8 RID: 113336 RVA: 0x00404881 File Offset: 0x00402A81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrackMoonRoleDataResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.entrustRoleInfos_.Add(other.entrustRoleInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BAB9 RID: 113337 RVA: 0x004048AF File Offset: 0x00402AAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BABA RID: 113338 RVA: 0x004048B8 File Offset: 0x00402AB8
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
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.entrustRoleInfos_.AddEntriesFrom(ref input, TrackMoonRoleDataResponse._repeated_entrustRoleInfos_codec);
				}
			}
		}

		// Token: 0x0400A0A1 RID: 41121
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A0A2 RID: 41122
		public const int EntrustRoleInfosFieldNumber = 7;

		// Token: 0x0400A0A3 RID: 41123
		private static readonly FieldCodec<EntrustRoleInfo> _repeated_entrustRoleInfos_codec = FieldCodec.ForMessage<EntrustRoleInfo>(58U, EntrustRoleInfo.Parser);

		// Token: 0x0400A0A4 RID: 41124
		private readonly RepeatedField<EntrustRoleInfo> entrustRoleInfos_ = new RepeatedField<EntrustRoleInfo>();
	}
}
