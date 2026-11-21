using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B91 RID: 2961
	public sealed class OpenSystemBoardData : IMessage<OpenSystemBoardData>, IMessage, IEquatable<OpenSystemBoardData>, IDeepCloneable<OpenSystemBoardData>, IBufferMessage
	{
		// Token: 0x0601014A RID: 65866 RVA: 0x002597BA File Offset: 0x002579BA
		[NullableContext(1)]
		public static OpenSystemBoardData Create()
		{
			return new OpenSystemBoardData();
		}

		// Token: 0x170034B4 RID: 13492
		// (get) Token: 0x0601014B RID: 65867 RVA: 0x002597C1 File Offset: 0x002579C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170034B5 RID: 13493
		// (get) Token: 0x0601014C RID: 65868 RVA: 0x002597C4 File Offset: 0x002579C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OpenSystemBoardData.Descriptor;
			}
		}

		// Token: 0x0601014D RID: 65869 RVA: 0x002597CB File Offset: 0x002579CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OpenSystemBoardData()
		{
		}

		// Token: 0x0601014E RID: 65870 RVA: 0x002597D3 File Offset: 0x002579D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OpenSystemBoardData(OpenSystemBoardData other) : this()
		{
			this.boardId_ = other.boardId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601014F RID: 65871 RVA: 0x002597F8 File Offset: 0x002579F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OpenSystemBoardData Clone()
		{
			return new OpenSystemBoardData(this);
		}

		// Token: 0x170034B6 RID: 13494
		// (get) Token: 0x06010150 RID: 65872 RVA: 0x00259800 File Offset: 0x00257A00
		// (set) Token: 0x06010151 RID: 65873 RVA: 0x00259808 File Offset: 0x00257A08
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

		// Token: 0x06010152 RID: 65874 RVA: 0x00259811 File Offset: 0x00257A11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OpenSystemBoardData);
		}

		// Token: 0x06010153 RID: 65875 RVA: 0x0025981F File Offset: 0x00257A1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OpenSystemBoardData other)
		{
			return other != null && (other == this || (this.BoardId == other.BoardId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010154 RID: 65876 RVA: 0x00259850 File Offset: 0x00257A50
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

		// Token: 0x06010155 RID: 65877 RVA: 0x0025988F File Offset: 0x00257A8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010156 RID: 65878 RVA: 0x0025989C File Offset: 0x00257A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010157 RID: 65879 RVA: 0x002598A5 File Offset: 0x00257AA5
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

		// Token: 0x06010158 RID: 65880 RVA: 0x002598D8 File Offset: 0x00257AD8
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

		// Token: 0x06010159 RID: 65881 RVA: 0x00259916 File Offset: 0x00257B16
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

		// Token: 0x0601015A RID: 65882 RVA: 0x00259947 File Offset: 0x00257B47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601015B RID: 65883 RVA: 0x00259950 File Offset: 0x00257B50
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

		// Token: 0x040066F2 RID: 26354
		private UnknownFieldSet _unknownFields;

		// Token: 0x040066F3 RID: 26355
		public const int BoardIdFieldNumber = 1;

		// Token: 0x040066F4 RID: 26356
		private int boardId_;
	}
}
