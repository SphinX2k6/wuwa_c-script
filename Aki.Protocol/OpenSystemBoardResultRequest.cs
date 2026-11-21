using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B92 RID: 2962
	[NetMessage(EMessageId.OpenSystemBoardResultRequest)]
	public sealed class OpenSystemBoardResultRequest : IMessage<OpenSystemBoardResultRequest>, IMessage, IEquatable<OpenSystemBoardResultRequest>, IDeepCloneable<OpenSystemBoardResultRequest>, IBufferMessage
	{
		// Token: 0x0601015C RID: 65884 RVA: 0x00259994 File Offset: 0x00257B94
		[NullableContext(1)]
		public static OpenSystemBoardResultRequest Create()
		{
			return new OpenSystemBoardResultRequest();
		}

		// Token: 0x170034B7 RID: 13495
		// (get) Token: 0x0601015D RID: 65885 RVA: 0x0025999B File Offset: 0x00257B9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170034B8 RID: 13496
		// (get) Token: 0x0601015E RID: 65886 RVA: 0x0025999E File Offset: 0x00257B9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OpenSystemBoardResultRequest.Descriptor;
			}
		}

		// Token: 0x0601015F RID: 65887 RVA: 0x002599A5 File Offset: 0x00257BA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OpenSystemBoardResultRequest()
		{
		}

		// Token: 0x06010160 RID: 65888 RVA: 0x002599AD File Offset: 0x00257BAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OpenSystemBoardResultRequest(OpenSystemBoardResultRequest other) : this()
		{
			this.playerId_ = other.playerId_;
			this.result_ = other.result_;
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010161 RID: 65889 RVA: 0x002599EA File Offset: 0x00257BEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OpenSystemBoardResultRequest Clone()
		{
			return new OpenSystemBoardResultRequest(this);
		}

		// Token: 0x170034B9 RID: 13497
		// (get) Token: 0x06010162 RID: 65890 RVA: 0x002599F2 File Offset: 0x00257BF2
		// (set) Token: 0x06010163 RID: 65891 RVA: 0x002599FA File Offset: 0x00257BFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x170034BA RID: 13498
		// (get) Token: 0x06010164 RID: 65892 RVA: 0x00259A03 File Offset: 0x00257C03
		// (set) Token: 0x06010165 RID: 65893 RVA: 0x00259A0B File Offset: 0x00257C0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Result
		{
			get
			{
				return this.result_;
			}
			set
			{
				this.result_ = value;
			}
		}

		// Token: 0x170034BB RID: 13499
		// (get) Token: 0x06010166 RID: 65894 RVA: 0x00259A14 File Offset: 0x00257C14
		// (set) Token: 0x06010167 RID: 65895 RVA: 0x00259A1C File Offset: 0x00257C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x06010168 RID: 65896 RVA: 0x00259A25 File Offset: 0x00257C25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OpenSystemBoardResultRequest);
		}

		// Token: 0x06010169 RID: 65897 RVA: 0x00259A34 File Offset: 0x00257C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OpenSystemBoardResultRequest other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.Result == other.Result && this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601016A RID: 65898 RVA: 0x00259A90 File Offset: 0x00257C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.Result != 0)
			{
				num ^= this.Result.GetHashCode();
			}
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601016B RID: 65899 RVA: 0x00259B01 File Offset: 0x00257D01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601016C RID: 65900 RVA: 0x00259B0E File Offset: 0x00257D0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601016D RID: 65901 RVA: 0x00259B18 File Offset: 0x00257D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.IncId);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.PlayerId);
			}
			if (this.Result != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Result);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601016E RID: 65902 RVA: 0x00259B90 File Offset: 0x00257D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.Result != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Result);
			}
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601016F RID: 65903 RVA: 0x00259C00 File Offset: 0x00257E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OpenSystemBoardResultRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.Result != 0)
			{
				this.Result = other.Result;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010170 RID: 65904 RVA: 0x00259C64 File Offset: 0x00257E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010171 RID: 65905 RVA: 0x00259C70 File Offset: 0x00257E70
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
				if (num != 24U)
				{
					if (num != 40U)
					{
						if (num != 48U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Result = input.ReadInt32();
						}
					}
					else
					{
						this.PlayerId = input.ReadInt32();
					}
				}
				else
				{
					this.IncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040066F5 RID: 26357
		private UnknownFieldSet _unknownFields;

		// Token: 0x040066F6 RID: 26358
		public const int PlayerIdFieldNumber = 5;

		// Token: 0x040066F7 RID: 26359
		private int playerId_;

		// Token: 0x040066F8 RID: 26360
		public const int ResultFieldNumber = 6;

		// Token: 0x040066F9 RID: 26361
		private int result_;

		// Token: 0x040066FA RID: 26362
		public const int IncIdFieldNumber = 3;

		// Token: 0x040066FB RID: 26363
		private int incId_;
	}
}
