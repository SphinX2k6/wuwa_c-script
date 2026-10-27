using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D26 RID: 3366
	public sealed class PhonographAlbumTimeInfo : IMessage<PhonographAlbumTimeInfo>, IMessage, IEquatable<PhonographAlbumTimeInfo>, IDeepCloneable<PhonographAlbumTimeInfo>, IBufferMessage
	{
		// Token: 0x060122CB RID: 74443 RVA: 0x002A7745 File Offset: 0x002A5945
		[NullableContext(1)]
		public static PhonographAlbumTimeInfo Create()
		{
			return new PhonographAlbumTimeInfo();
		}

		// Token: 0x17003C35 RID: 15413
		// (get) Token: 0x060122CC RID: 74444 RVA: 0x002A774C File Offset: 0x002A594C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhonographAlbumTimeInfo> Parser
		{
			get
			{
				return PhonographAlbumTimeInfo._parser;
			}
		}

		// Token: 0x17003C36 RID: 15414
		// (get) Token: 0x060122CD RID: 74445 RVA: 0x002A7753 File Offset: 0x002A5953
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C37 RID: 15415
		// (get) Token: 0x060122CE RID: 74446 RVA: 0x002A7756 File Offset: 0x002A5956
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhonographAlbumTimeInfo.Descriptor;
			}
		}

		// Token: 0x060122CF RID: 74447 RVA: 0x002A775D File Offset: 0x002A595D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhonographAlbumTimeInfo()
		{
		}

		// Token: 0x060122D0 RID: 74448 RVA: 0x002A7770 File Offset: 0x002A5970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhonographAlbumTimeInfo(PhonographAlbumTimeInfo other) : this()
		{
			this.albumId_ = other.albumId_;
			this.beginTime_ = other.beginTime_;
			this.endTime_ = other.endTime_;
			this.musicIds_ = other.musicIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060122D1 RID: 74449 RVA: 0x002A77C9 File Offset: 0x002A59C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhonographAlbumTimeInfo Clone()
		{
			return new PhonographAlbumTimeInfo(this);
		}

		// Token: 0x17003C38 RID: 15416
		// (get) Token: 0x060122D2 RID: 74450 RVA: 0x002A77D1 File Offset: 0x002A59D1
		// (set) Token: 0x060122D3 RID: 74451 RVA: 0x002A77D9 File Offset: 0x002A59D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AlbumId
		{
			get
			{
				return this.albumId_;
			}
			set
			{
				this.albumId_ = value;
			}
		}

		// Token: 0x17003C39 RID: 15417
		// (get) Token: 0x060122D4 RID: 74452 RVA: 0x002A77E2 File Offset: 0x002A59E2
		// (set) Token: 0x060122D5 RID: 74453 RVA: 0x002A77EA File Offset: 0x002A59EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BeginTime
		{
			get
			{
				return this.beginTime_;
			}
			set
			{
				this.beginTime_ = value;
			}
		}

		// Token: 0x17003C3A RID: 15418
		// (get) Token: 0x060122D6 RID: 74454 RVA: 0x002A77F3 File Offset: 0x002A59F3
		// (set) Token: 0x060122D7 RID: 74455 RVA: 0x002A77FB File Offset: 0x002A59FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EndTime
		{
			get
			{
				return this.endTime_;
			}
			set
			{
				this.endTime_ = value;
			}
		}

		// Token: 0x17003C3B RID: 15419
		// (get) Token: 0x060122D8 RID: 74456 RVA: 0x002A7804 File Offset: 0x002A5A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MusicIds
		{
			get
			{
				return this.musicIds_;
			}
		}

		// Token: 0x060122D9 RID: 74457 RVA: 0x002A780C File Offset: 0x002A5A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhonographAlbumTimeInfo);
		}

		// Token: 0x060122DA RID: 74458 RVA: 0x002A781C File Offset: 0x002A5A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhonographAlbumTimeInfo other)
		{
			return other != null && (other == this || (this.AlbumId == other.AlbumId && this.BeginTime == other.BeginTime && this.EndTime == other.EndTime && this.musicIds_.Equals(other.musicIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060122DB RID: 74459 RVA: 0x002A788C File Offset: 0x002A5A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AlbumId != 0)
			{
				num ^= this.AlbumId.GetHashCode();
			}
			if (this.BeginTime != 0L)
			{
				num ^= this.BeginTime.GetHashCode();
			}
			if (this.EndTime != 0L)
			{
				num ^= this.EndTime.GetHashCode();
			}
			num ^= this.musicIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060122DC RID: 74460 RVA: 0x002A790B File Offset: 0x002A5B0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060122DD RID: 74461 RVA: 0x002A7918 File Offset: 0x002A5B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060122DE RID: 74462 RVA: 0x002A7924 File Offset: 0x002A5B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AlbumId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.AlbumId);
			}
			if (this.BeginTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.BeginTime);
			}
			if (this.EndTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.EndTime);
			}
			this.musicIds_.WriteTo(ref output, PhonographAlbumTimeInfo._repeated_musicIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060122DF RID: 74463 RVA: 0x002A79AC File Offset: 0x002A5BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AlbumId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AlbumId);
			}
			if (this.BeginTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BeginTime);
			}
			if (this.EndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTime);
			}
			num += this.musicIds_.CalculateSize(PhonographAlbumTimeInfo._repeated_musicIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060122E0 RID: 74464 RVA: 0x002A7A30 File Offset: 0x002A5C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhonographAlbumTimeInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AlbumId != 0)
			{
				this.AlbumId = other.AlbumId;
			}
			if (other.BeginTime != 0L)
			{
				this.BeginTime = other.BeginTime;
			}
			if (other.EndTime != 0L)
			{
				this.EndTime = other.EndTime;
			}
			this.musicIds_.Add(other.musicIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060122E1 RID: 74465 RVA: 0x002A7AA5 File Offset: 0x002A5CA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060122E2 RID: 74466 RVA: 0x002A7AB0 File Offset: 0x002A5CB0
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.AlbumId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.BeginTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.EndTime = input.ReadInt64();
						continue;
					}
					if (num == 32U || num == 34U)
					{
						this.musicIds_.AddEntriesFrom(ref input, PhonographAlbumTimeInfo._repeated_musicIds_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400717F RID: 29055
		private static readonly MessageParser<PhonographAlbumTimeInfo> _parser = new MessageParser<PhonographAlbumTimeInfo>(() => new PhonographAlbumTimeInfo());

		// Token: 0x04007180 RID: 29056
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007181 RID: 29057
		public const int AlbumIdFieldNumber = 1;

		// Token: 0x04007182 RID: 29058
		private int albumId_;

		// Token: 0x04007183 RID: 29059
		public const int BeginTimeFieldNumber = 2;

		// Token: 0x04007184 RID: 29060
		private long beginTime_;

		// Token: 0x04007185 RID: 29061
		public const int EndTimeFieldNumber = 3;

		// Token: 0x04007186 RID: 29062
		private long endTime_;

		// Token: 0x04007187 RID: 29063
		public const int MusicIdsFieldNumber = 4;

		// Token: 0x04007188 RID: 29064
		private static readonly FieldCodec<int> _repeated_musicIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04007189 RID: 29065
		private readonly RepeatedField<int> musicIds_ = new RepeatedField<int>();
	}
}
