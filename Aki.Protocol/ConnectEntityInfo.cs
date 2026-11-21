using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002DC RID: 732
	public sealed class ConnectEntityInfo : IMessage<ConnectEntityInfo>, IMessage, IEquatable<ConnectEntityInfo>, IDeepCloneable<ConnectEntityInfo>, IBufferMessage
	{
		// Token: 0x06004B0A RID: 19210 RVA: 0x000B78CA File Offset: 0x000B5ACA
		[NullableContext(1)]
		public static ConnectEntityInfo Create()
		{
			return new ConnectEntityInfo();
		}

		// Token: 0x17000D31 RID: 3377
		// (get) Token: 0x06004B0B RID: 19211 RVA: 0x000B78D1 File Offset: 0x000B5AD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ConnectEntityInfo> Parser
		{
			get
			{
				return ConnectEntityInfo._parser;
			}
		}

		// Token: 0x17000D32 RID: 3378
		// (get) Token: 0x06004B0C RID: 19212 RVA: 0x000B78D8 File Offset: 0x000B5AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D33 RID: 3379
		// (get) Token: 0x06004B0D RID: 19213 RVA: 0x000B78DB File Offset: 0x000B5ADB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConnectEntityInfo.Descriptor;
			}
		}

		// Token: 0x06004B0E RID: 19214 RVA: 0x000B78E2 File Offset: 0x000B5AE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectEntityInfo()
		{
		}

		// Token: 0x06004B0F RID: 19215 RVA: 0x000B78F8 File Offset: 0x000B5AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectEntityInfo(ConnectEntityInfo other) : this()
		{
			this.srcEntityId_ = other.srcEntityId_;
			this.targetEntityInfos_ = other.targetEntityInfos_.Clone();
			this.isConnect_ = other.isConnect_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004B10 RID: 19216 RVA: 0x000B7945 File Offset: 0x000B5B45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectEntityInfo Clone()
		{
			return new ConnectEntityInfo(this);
		}

		// Token: 0x17000D34 RID: 3380
		// (get) Token: 0x06004B11 RID: 19217 RVA: 0x000B794D File Offset: 0x000B5B4D
		// (set) Token: 0x06004B12 RID: 19218 RVA: 0x000B7955 File Offset: 0x000B5B55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SrcEntityId
		{
			get
			{
				return this.srcEntityId_;
			}
			set
			{
				this.srcEntityId_ = value;
			}
		}

		// Token: 0x17000D35 RID: 3381
		// (get) Token: 0x06004B13 RID: 19219 RVA: 0x000B795E File Offset: 0x000B5B5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConnectEntityTarget> TargetEntityInfos
		{
			get
			{
				return this.targetEntityInfos_;
			}
		}

		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x06004B14 RID: 19220 RVA: 0x000B7966 File Offset: 0x000B5B66
		// (set) Token: 0x06004B15 RID: 19221 RVA: 0x000B796E File Offset: 0x000B5B6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsConnect
		{
			get
			{
				return this.isConnect_;
			}
			set
			{
				this.isConnect_ = value;
			}
		}

		// Token: 0x06004B16 RID: 19222 RVA: 0x000B7977 File Offset: 0x000B5B77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConnectEntityInfo);
		}

		// Token: 0x06004B17 RID: 19223 RVA: 0x000B7988 File Offset: 0x000B5B88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConnectEntityInfo other)
		{
			return other != null && (other == this || (this.SrcEntityId == other.SrcEntityId && this.targetEntityInfos_.Equals(other.targetEntityInfos_) && this.IsConnect == other.IsConnect && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004B18 RID: 19224 RVA: 0x000B79E8 File Offset: 0x000B5BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SrcEntityId != 0L)
			{
				num ^= this.SrcEntityId.GetHashCode();
			}
			num ^= this.targetEntityInfos_.GetHashCode();
			if (this.IsConnect)
			{
				num ^= this.IsConnect.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004B19 RID: 19225 RVA: 0x000B7A4E File Offset: 0x000B5C4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004B1A RID: 19226 RVA: 0x000B7A5B File Offset: 0x000B5C5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004B1B RID: 19227 RVA: 0x000B7A64 File Offset: 0x000B5C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SrcEntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.SrcEntityId);
			}
			this.targetEntityInfos_.WriteTo(ref output, ConnectEntityInfo._repeated_targetEntityInfos_codec);
			if (this.IsConnect)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsConnect);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004B1C RID: 19228 RVA: 0x000B7AD0 File Offset: 0x000B5CD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SrcEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SrcEntityId);
			}
			num += this.targetEntityInfos_.CalculateSize(ConnectEntityInfo._repeated_targetEntityInfos_codec);
			if (this.IsConnect)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004B1D RID: 19229 RVA: 0x000B7B30 File Offset: 0x000B5D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConnectEntityInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SrcEntityId != 0L)
			{
				this.SrcEntityId = other.SrcEntityId;
			}
			this.targetEntityInfos_.Add(other.targetEntityInfos_);
			if (other.IsConnect)
			{
				this.IsConnect = other.IsConnect;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004B1E RID: 19230 RVA: 0x000B7B91 File Offset: 0x000B5D91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004B1F RID: 19231 RVA: 0x000B7B9C File Offset: 0x000B5D9C
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
				if (num != 8U)
				{
					if (num != 18U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsConnect = input.ReadBool();
						}
					}
					else
					{
						this.targetEntityInfos_.AddEntriesFrom(ref input, ConnectEntityInfo._repeated_targetEntityInfos_codec);
					}
				}
				else
				{
					this.SrcEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040030FF RID: 12543
		private static readonly MessageParser<ConnectEntityInfo> _parser = new MessageParser<ConnectEntityInfo>(() => new ConnectEntityInfo());

		// Token: 0x04003100 RID: 12544
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003101 RID: 12545
		public const int SrcEntityIdFieldNumber = 1;

		// Token: 0x04003102 RID: 12546
		private long srcEntityId_;

		// Token: 0x04003103 RID: 12547
		public const int TargetEntityInfosFieldNumber = 2;

		// Token: 0x04003104 RID: 12548
		private static readonly FieldCodec<ConnectEntityTarget> _repeated_targetEntityInfos_codec = FieldCodec.ForMessage<ConnectEntityTarget>(18U, ConnectEntityTarget.Parser);

		// Token: 0x04003105 RID: 12549
		private readonly RepeatedField<ConnectEntityTarget> targetEntityInfos_ = new RepeatedField<ConnectEntityTarget>();

		// Token: 0x04003106 RID: 12550
		public const int IsConnectFieldNumber = 3;

		// Token: 0x04003107 RID: 12551
		private bool isConnect_;
	}
}
