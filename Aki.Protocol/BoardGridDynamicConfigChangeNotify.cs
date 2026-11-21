using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001BB RID: 443
	[NetMessage(EMessageId.BoardGridDynamicConfigChangeNotify)]
	public sealed class BoardGridDynamicConfigChangeNotify : IMessage<BoardGridDynamicConfigChangeNotify>, IMessage, IEquatable<BoardGridDynamicConfigChangeNotify>, IDeepCloneable<BoardGridDynamicConfigChangeNotify>, IBufferMessage
	{
		// Token: 0x06003374 RID: 13172 RVA: 0x00082802 File Offset: 0x00080A02
		[NullableContext(1)]
		public static BoardGridDynamicConfigChangeNotify Create()
		{
			return new BoardGridDynamicConfigChangeNotify();
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x06003375 RID: 13173 RVA: 0x00082809 File Offset: 0x00080A09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x06003376 RID: 13174 RVA: 0x0008280C File Offset: 0x00080A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BoardGridDynamicConfigChangeNotify.Descriptor;
			}
		}

		// Token: 0x06003377 RID: 13175 RVA: 0x00082813 File Offset: 0x00080A13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoardGridDynamicConfigChangeNotify()
		{
		}

		// Token: 0x06003378 RID: 13176 RVA: 0x00082826 File Offset: 0x00080A26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoardGridDynamicConfigChangeNotify(BoardGridDynamicConfigChangeNotify other) : this()
		{
			this.boardEntityId_ = other.boardEntityId_;
			this.changedConfigs_ = other.changedConfigs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003379 RID: 13177 RVA: 0x0008285C File Offset: 0x00080A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoardGridDynamicConfigChangeNotify Clone()
		{
			return new BoardGridDynamicConfigChangeNotify(this);
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x0600337A RID: 13178 RVA: 0x00082864 File Offset: 0x00080A64
		// (set) Token: 0x0600337B RID: 13179 RVA: 0x0008286C File Offset: 0x00080A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BoardEntityId
		{
			get
			{
				return this.boardEntityId_;
			}
			set
			{
				this.boardEntityId_ = value;
			}
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x0600337C RID: 13180 RVA: 0x00082875 File Offset: 0x00080A75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BoardGridDynamicConfig> ChangedConfigs
		{
			get
			{
				return this.changedConfigs_;
			}
		}

		// Token: 0x0600337D RID: 13181 RVA: 0x0008287D File Offset: 0x00080A7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BoardGridDynamicConfigChangeNotify);
		}

		// Token: 0x0600337E RID: 13182 RVA: 0x0008288C File Offset: 0x00080A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BoardGridDynamicConfigChangeNotify other)
		{
			return other != null && (other == this || (this.BoardEntityId == other.BoardEntityId && this.changedConfigs_.Equals(other.changedConfigs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600337F RID: 13183 RVA: 0x000828DC File Offset: 0x00080ADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BoardEntityId != 0L)
			{
				num ^= this.BoardEntityId.GetHashCode();
			}
			num ^= this.changedConfigs_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003380 RID: 13184 RVA: 0x00082929 File Offset: 0x00080B29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003381 RID: 13185 RVA: 0x00082936 File Offset: 0x00080B36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003382 RID: 13186 RVA: 0x00082940 File Offset: 0x00080B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.changedConfigs_.WriteTo(ref output, BoardGridDynamicConfigChangeNotify._repeated_changedConfigs_codec);
			if (this.BoardEntityId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.BoardEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003383 RID: 13187 RVA: 0x00082990 File Offset: 0x00080B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BoardEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BoardEntityId);
			}
			num += this.changedConfigs_.CalculateSize(BoardGridDynamicConfigChangeNotify._repeated_changedConfigs_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003384 RID: 13188 RVA: 0x000829E4 File Offset: 0x00080BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BoardGridDynamicConfigChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BoardEntityId != 0L)
			{
				this.BoardEntityId = other.BoardEntityId;
			}
			this.changedConfigs_.Add(other.changedConfigs_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003385 RID: 13189 RVA: 0x00082A31 File Offset: 0x00080C31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003386 RID: 13190 RVA: 0x00082A3C File Offset: 0x00080C3C
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.BoardEntityId = input.ReadInt64();
					}
				}
				else
				{
					this.changedConfigs_.AddEntriesFrom(ref input, BoardGridDynamicConfigChangeNotify._repeated_changedConfigs_codec);
				}
			}
		}

		// Token: 0x04002A11 RID: 10769
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A12 RID: 10770
		public const int BoardEntityIdFieldNumber = 10;

		// Token: 0x04002A13 RID: 10771
		private long boardEntityId_;

		// Token: 0x04002A14 RID: 10772
		public const int ChangedConfigsFieldNumber = 6;

		// Token: 0x04002A15 RID: 10773
		private static readonly FieldCodec<BoardGridDynamicConfig> _repeated_changedConfigs_codec = FieldCodec.ForMessage<BoardGridDynamicConfig>(50U, BoardGridDynamicConfig.Parser);

		// Token: 0x04002A16 RID: 10774
		private readonly RepeatedField<BoardGridDynamicConfig> changedConfigs_ = new RepeatedField<BoardGridDynamicConfig>();
	}
}
