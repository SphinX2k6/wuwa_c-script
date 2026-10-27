using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BA1 RID: 2977
	public sealed class OpenSystemBoardData : IMessage<OpenSystemBoardData>, IMessage, IEquatable<OpenSystemBoardData>, IDeepCloneable<OpenSystemBoardData>, IBufferMessage
	{
		// Token: 0x0601024E RID: 66126 RVA: 0x0025B681 File Offset: 0x00259881
		[NullableContext(1)]
		public static OpenSystemBoardData Create()
		{
			return new OpenSystemBoardData();
		}

		// Token: 0x170034ED RID: 13549
		// (get) Token: 0x0601024F RID: 66127 RVA: 0x0025B688 File Offset: 0x00259888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170034EE RID: 13550
		// (get) Token: 0x06010250 RID: 66128 RVA: 0x0025B68B File Offset: 0x0025988B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OpenSystemBoardData.Descriptor;
			}
		}

		// Token: 0x06010251 RID: 66129 RVA: 0x0025B692 File Offset: 0x00259892
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OpenSystemBoardData()
		{
		}

		// Token: 0x06010252 RID: 66130 RVA: 0x0025B69A File Offset: 0x0025989A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OpenSystemBoardData(OpenSystemBoardData other) : this()
		{
			this.boardId_ = other.boardId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010253 RID: 66131 RVA: 0x0025B6BF File Offset: 0x002598BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OpenSystemBoardData Clone()
		{
			return new OpenSystemBoardData(this);
		}

		// Token: 0x170034EF RID: 13551
		// (get) Token: 0x06010254 RID: 66132 RVA: 0x0025B6C7 File Offset: 0x002598C7
		// (set) Token: 0x06010255 RID: 66133 RVA: 0x0025B6CF File Offset: 0x002598CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BoardId
		{
			get
			{
				return this.boardId_;
			}
			set
			{
				this.boardId_ = value;
			}
		}

		// Token: 0x06010256 RID: 66134 RVA: 0x0025B6D8 File Offset: 0x002598D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OpenSystemBoardData);
		}

		// Token: 0x06010257 RID: 66135 RVA: 0x0025B6E6 File Offset: 0x002598E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OpenSystemBoardData other)
		{
			return other != null && (other == this || (this.BoardId == other.BoardId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010258 RID: 66136 RVA: 0x0025B714 File Offset: 0x00259914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BoardId != 0)
			{
				num ^= this.BoardId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010259 RID: 66137 RVA: 0x0025B753 File Offset: 0x00259953
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601025A RID: 66138 RVA: 0x0025B760 File Offset: 0x00259960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601025B RID: 66139 RVA: 0x0025B769 File Offset: 0x00259969
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BoardId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BoardId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601025C RID: 66140 RVA: 0x0025B79C File Offset: 0x0025999C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BoardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BoardId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601025D RID: 66141 RVA: 0x0025B7DA File Offset: 0x002599DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OpenSystemBoardData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BoardId != 0)
			{
				this.BoardId = other.BoardId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601025E RID: 66142 RVA: 0x0025B80B File Offset: 0x00259A0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601025F RID: 66143 RVA: 0x0025B814 File Offset: 0x00259A14
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.BoardId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040066E2 RID: 26338
		private UnknownFieldSet _unknownFields;

		// Token: 0x040066E3 RID: 26339
		public const int BoardIdFieldNumber = 1;

		// Token: 0x040066E4 RID: 26340
		private int boardId_;
	}
}
