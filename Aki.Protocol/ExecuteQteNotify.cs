using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004E4 RID: 1252
	[NetMessage(EMessageId.ExecuteQteNotify)]
	public sealed class ExecuteQteNotify : IMessage<ExecuteQteNotify>, IMessage, IEquatable<ExecuteQteNotify>, IDeepCloneable<ExecuteQteNotify>, IBufferMessage
	{
		// Token: 0x0600769B RID: 30363 RVA: 0x00121E13 File Offset: 0x00120013
		[NullableContext(1)]
		public static ExecuteQteNotify Create()
		{
			return new ExecuteQteNotify();
		}

		// Token: 0x17001701 RID: 5889
		// (get) Token: 0x0600769C RID: 30364 RVA: 0x00121E1A File Offset: 0x0012001A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001702 RID: 5890
		// (get) Token: 0x0600769D RID: 30365 RVA: 0x00121E1D File Offset: 0x0012001D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExecuteQteNotify.Descriptor;
			}
		}

		// Token: 0x0600769E RID: 30366 RVA: 0x00121E24 File Offset: 0x00120024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExecuteQteNotify()
		{
		}

		// Token: 0x0600769F RID: 30367 RVA: 0x00121E2C File Offset: 0x0012002C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExecuteQteNotify(ExecuteQteNotify other) : this()
		{
			this.downEntityId_ = other.downEntityId_;
			this.upEntityId_ = other.upEntityId_;
			this.qteId_ = other.qteId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060076A0 RID: 30368 RVA: 0x00121E69 File Offset: 0x00120069
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExecuteQteNotify Clone()
		{
			return new ExecuteQteNotify(this);
		}

		// Token: 0x17001703 RID: 5891
		// (get) Token: 0x060076A1 RID: 30369 RVA: 0x00121E71 File Offset: 0x00120071
		// (set) Token: 0x060076A2 RID: 30370 RVA: 0x00121E79 File Offset: 0x00120079
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long DownEntityId
		{
			get
			{
				return this.downEntityId_;
			}
			set
			{
				this.downEntityId_ = value;
			}
		}

		// Token: 0x17001704 RID: 5892
		// (get) Token: 0x060076A3 RID: 30371 RVA: 0x00121E82 File Offset: 0x00120082
		// (set) Token: 0x060076A4 RID: 30372 RVA: 0x00121E8A File Offset: 0x0012008A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long UpEntityId
		{
			get
			{
				return this.upEntityId_;
			}
			set
			{
				this.upEntityId_ = value;
			}
		}

		// Token: 0x17001705 RID: 5893
		// (get) Token: 0x060076A5 RID: 30373 RVA: 0x00121E93 File Offset: 0x00120093
		// (set) Token: 0x060076A6 RID: 30374 RVA: 0x00121E9B File Offset: 0x0012009B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int QteId
		{
			get
			{
				return this.qteId_;
			}
			set
			{
				this.qteId_ = value;
			}
		}

		// Token: 0x060076A7 RID: 30375 RVA: 0x00121EA4 File Offset: 0x001200A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExecuteQteNotify);
		}

		// Token: 0x060076A8 RID: 30376 RVA: 0x00121EB4 File Offset: 0x001200B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExecuteQteNotify other)
		{
			return other != null && (other == this || (this.DownEntityId == other.DownEntityId && this.UpEntityId == other.UpEntityId && this.QteId == other.QteId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060076A9 RID: 30377 RVA: 0x00121F10 File Offset: 0x00120110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DownEntityId != 0L)
			{
				num ^= this.DownEntityId.GetHashCode();
			}
			if (this.UpEntityId != 0L)
			{
				num ^= this.UpEntityId.GetHashCode();
			}
			if (this.QteId != 0)
			{
				num ^= this.QteId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060076AA RID: 30378 RVA: 0x00121F81 File Offset: 0x00120181
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060076AB RID: 30379 RVA: 0x00121F8E File Offset: 0x0012018E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060076AC RID: 30380 RVA: 0x00121F98 File Offset: 0x00120198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.UpEntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.UpEntityId);
			}
			if (this.QteId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.QteId);
			}
			if (this.DownEntityId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.DownEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060076AD RID: 30381 RVA: 0x00122010 File Offset: 0x00120210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DownEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.DownEntityId);
			}
			if (this.UpEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UpEntityId);
			}
			if (this.QteId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QteId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060076AE RID: 30382 RVA: 0x00122080 File Offset: 0x00120280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExecuteQteNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DownEntityId != 0L)
			{
				this.DownEntityId = other.DownEntityId;
			}
			if (other.UpEntityId != 0L)
			{
				this.UpEntityId = other.UpEntityId;
			}
			if (other.QteId != 0)
			{
				this.QteId = other.QteId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060076AF RID: 30383 RVA: 0x001220E4 File Offset: 0x001202E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060076B0 RID: 30384 RVA: 0x001220F0 File Offset: 0x001202F0
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
				if (num != 64U)
				{
					if (num != 80U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.DownEntityId = input.ReadInt64();
						}
					}
					else
					{
						this.QteId = input.ReadInt32();
					}
				}
				else
				{
					this.UpEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003E00 RID: 15872
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E01 RID: 15873
		public const int DownEntityIdFieldNumber = 15;

		// Token: 0x04003E02 RID: 15874
		private long downEntityId_;

		// Token: 0x04003E03 RID: 15875
		public const int UpEntityIdFieldNumber = 8;

		// Token: 0x04003E04 RID: 15876
		private long upEntityId_;

		// Token: 0x04003E05 RID: 15877
		public const int QteIdFieldNumber = 10;

		// Token: 0x04003E06 RID: 15878
		private int qteId_;
	}
}
