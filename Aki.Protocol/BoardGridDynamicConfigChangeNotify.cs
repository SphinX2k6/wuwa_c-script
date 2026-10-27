using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001B7 RID: 439
	[NetMessage(EMessageId.BoardGridDynamicConfigChangeNotify)]
	public sealed class BoardGridDynamicConfigChangeNotify : IMessage<BoardGridDynamicConfigChangeNotify>, IMessage, IEquatable<BoardGridDynamicConfigChangeNotify>, IDeepCloneable<BoardGridDynamicConfigChangeNotify>, IBufferMessage
	{
		// Token: 0x060032E7 RID: 13031 RVA: 0x00081092 File Offset: 0x0007F292
		[NullableContext(1)]
		public static BoardGridDynamicConfigChangeNotify Create()
		{
			return new BoardGridDynamicConfigChangeNotify();
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x060032E8 RID: 13032 RVA: 0x00081099 File Offset: 0x0007F299
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x060032E9 RID: 13033 RVA: 0x0008109C File Offset: 0x0007F29C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BoardGridDynamicConfigChangeNotify.Descriptor;
			}
		}

		// Token: 0x060032EA RID: 13034 RVA: 0x000810A3 File Offset: 0x0007F2A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoardGridDynamicConfigChangeNotify()
		{
		}

		// Token: 0x060032EB RID: 13035 RVA: 0x000810B6 File Offset: 0x0007F2B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoardGridDynamicConfigChangeNotify(BoardGridDynamicConfigChangeNotify other) : this()
		{
			this.boardEntityId_ = other.boardEntityId_;
			this.changedConfigs_ = other.changedConfigs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060032EC RID: 13036 RVA: 0x000810EC File Offset: 0x0007F2EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoardGridDynamicConfigChangeNotify Clone()
		{
			return new BoardGridDynamicConfigChangeNotify(this);
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x060032ED RID: 13037 RVA: 0x000810F4 File Offset: 0x0007F2F4
		// (set) Token: 0x060032EE RID: 13038 RVA: 0x000810FC File Offset: 0x0007F2FC
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

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x060032EF RID: 13039 RVA: 0x00081105 File Offset: 0x0007F305
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BoardGridDynamicConfig> ChangedConfigs
		{
			get
			{
				return this.changedConfigs_;
			}
		}

		// Token: 0x060032F0 RID: 13040 RVA: 0x0008110D File Offset: 0x0007F30D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BoardGridDynamicConfigChangeNotify);
		}

		// Token: 0x060032F1 RID: 13041 RVA: 0x0008111C File Offset: 0x0007F31C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BoardGridDynamicConfigChangeNotify other)
		{
			return other != null && (other == this || (this.BoardEntityId == other.BoardEntityId && this.changedConfigs_.Equals(other.changedConfigs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060032F2 RID: 13042 RVA: 0x0008116C File Offset: 0x0007F36C
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

		// Token: 0x060032F3 RID: 13043 RVA: 0x000811B9 File Offset: 0x0007F3B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060032F4 RID: 13044 RVA: 0x000811C6 File Offset: 0x0007F3C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060032F5 RID: 13045 RVA: 0x000811D0 File Offset: 0x0007F3D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.changedConfigs_.WriteTo(ref output, BoardGridDynamicConfigChangeNotify._repeated_changedConfigs_codec);
			if (this.BoardEntityId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.BoardEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060032F6 RID: 13046 RVA: 0x00081220 File Offset: 0x0007F420
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

		// Token: 0x060032F7 RID: 13047 RVA: 0x00081274 File Offset: 0x0007F474
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

		// Token: 0x060032F8 RID: 13048 RVA: 0x000812C1 File Offset: 0x0007F4C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060032F9 RID: 13049 RVA: 0x000812CC File Offset: 0x0007F4CC
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
					if (num != 112U)
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

		// Token: 0x04002996 RID: 10646
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002997 RID: 10647
		public const int BoardEntityIdFieldNumber = 14;

		// Token: 0x04002998 RID: 10648
		private long boardEntityId_;

		// Token: 0x04002999 RID: 10649
		public const int ChangedConfigsFieldNumber = 1;

		// Token: 0x0400299A RID: 10650
		private static readonly FieldCodec<BoardGridDynamicConfig> _repeated_changedConfigs_codec = FieldCodec.ForMessage<BoardGridDynamicConfig>(10U, BoardGridDynamicConfig.Parser);

		// Token: 0x0400299B RID: 10651
		private readonly RepeatedField<BoardGridDynamicConfig> changedConfigs_ = new RepeatedField<BoardGridDynamicConfig>();
	}
}
