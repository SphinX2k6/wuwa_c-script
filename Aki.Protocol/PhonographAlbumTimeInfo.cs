using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D16 RID: 3350
	public sealed class PhonographAlbumTimeInfo : IMessage<PhonographAlbumTimeInfo>, IMessage, IEquatable<PhonographAlbumTimeInfo>, IDeepCloneable<PhonographAlbumTimeInfo>, IBufferMessage
	{
		// Token: 0x060121CF RID: 74191 RVA: 0x002A5B21 File Offset: 0x002A3D21
		[NullableContext(1)]
		public static PhonographAlbumTimeInfo Create()
		{
			return new PhonographAlbumTimeInfo();
		}

		// Token: 0x17003C00 RID: 15360
		// (get) Token: 0x060121D0 RID: 74192 RVA: 0x002A5B28 File Offset: 0x002A3D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhonographAlbumTimeInfo> Parser
		{
			get
			{
				return PhonographAlbumTimeInfo._parser;
			}
		}

		// Token: 0x17003C01 RID: 15361
		// (get) Token: 0x060121D1 RID: 74193 RVA: 0x002A5B2F File Offset: 0x002A3D2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C02 RID: 15362
		// (get) Token: 0x060121D2 RID: 74194 RVA: 0x002A5B32 File Offset: 0x002A3D32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhonographAlbumTimeInfo.Descriptor;
			}
		}

		// Token: 0x060121D3 RID: 74195 RVA: 0x002A5B39 File Offset: 0x002A3D39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhonographAlbumTimeInfo()
		{
		}

		// Token: 0x060121D4 RID: 74196 RVA: 0x002A5B4C File Offset: 0x002A3D4C
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

		// Token: 0x060121D5 RID: 74197 RVA: 0x002A5BA5 File Offset: 0x002A3DA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhonographAlbumTimeInfo Clone()
		{
			return new PhonographAlbumTimeInfo(this);
		}

		// Token: 0x17003C03 RID: 15363
		// (get) Token: 0x060121D6 RID: 74198 RVA: 0x002A5BAD File Offset: 0x002A3DAD
		// (set) Token: 0x060121D7 RID: 74199 RVA: 0x002A5BB5 File Offset: 0x002A3DB5
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

		// Token: 0x17003C04 RID: 15364
		// (get) Token: 0x060121D8 RID: 74200 RVA: 0x002A5BBE File Offset: 0x002A3DBE
		// (set) Token: 0x060121D9 RID: 74201 RVA: 0x002A5BC6 File Offset: 0x002A3DC6
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

		// Token: 0x17003C05 RID: 15365
		// (get) Token: 0x060121DA RID: 74202 RVA: 0x002A5BCF File Offset: 0x002A3DCF
		// (set) Token: 0x060121DB RID: 74203 RVA: 0x002A5BD7 File Offset: 0x002A3DD7
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

		// Token: 0x17003C06 RID: 15366
		// (get) Token: 0x060121DC RID: 74204 RVA: 0x002A5BE0 File Offset: 0x002A3DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MusicIds
		{
			get
			{
				return this.musicIds_;
			}
		}

		// Token: 0x060121DD RID: 74205 RVA: 0x002A5BE8 File Offset: 0x002A3DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhonographAlbumTimeInfo);
		}

		// Token: 0x060121DE RID: 74206 RVA: 0x002A5BF8 File Offset: 0x002A3DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhonographAlbumTimeInfo other)
		{
			return other != null && (other == this || (this.AlbumId == other.AlbumId && this.BeginTime == other.BeginTime && this.EndTime == other.EndTime && this.musicIds_.Equals(other.musicIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060121DF RID: 74207 RVA: 0x002A5C68 File Offset: 0x002A3E68
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

		// Token: 0x060121E0 RID: 74208 RVA: 0x002A5CE7 File Offset: 0x002A3EE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060121E1 RID: 74209 RVA: 0x002A5CF4 File Offset: 0x002A3EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060121E2 RID: 74210 RVA: 0x002A5D00 File Offset: 0x002A3F00
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

		// Token: 0x060121E3 RID: 74211 RVA: 0x002A5D88 File Offset: 0x002A3F88
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

		// Token: 0x060121E4 RID: 74212 RVA: 0x002A5E0C File Offset: 0x002A400C
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

		// Token: 0x060121E5 RID: 74213 RVA: 0x002A5E81 File Offset: 0x002A4081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060121E6 RID: 74214 RVA: 0x002A5E8C File Offset: 0x002A408C
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

		// Token: 0x04007197 RID: 29079
		private static readonly MessageParser<PhonographAlbumTimeInfo> _parser = new MessageParser<PhonographAlbumTimeInfo>(() => new PhonographAlbumTimeInfo());

		// Token: 0x04007198 RID: 29080
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007199 RID: 29081
		public const int AlbumIdFieldNumber = 1;

		// Token: 0x0400719A RID: 29082
		private int albumId_;

		// Token: 0x0400719B RID: 29083
		public const int BeginTimeFieldNumber = 2;

		// Token: 0x0400719C RID: 29084
		private long beginTime_;

		// Token: 0x0400719D RID: 29085
		public const int EndTimeFieldNumber = 3;

		// Token: 0x0400719E RID: 29086
		private long endTime_;

		// Token: 0x0400719F RID: 29087
		public const int MusicIdsFieldNumber = 4;

		// Token: 0x040071A0 RID: 29088
		private static readonly FieldCodec<int> _repeated_musicIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x040071A1 RID: 29089
		private readonly RepeatedField<int> musicIds_ = new RepeatedField<int>();
	}
}
