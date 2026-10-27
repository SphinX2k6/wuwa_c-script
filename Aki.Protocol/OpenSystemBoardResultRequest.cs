using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BA2 RID: 2978
	[NetMessage(EMessageId.OpenSystemBoardResultRequest)]
	public sealed class OpenSystemBoardResultRequest : IMessage<OpenSystemBoardResultRequest>, IMessage, IEquatable<OpenSystemBoardResultRequest>, IDeepCloneable<OpenSystemBoardResultRequest>, IBufferMessage
	{
		// Token: 0x06010260 RID: 66144 RVA: 0x0025B858 File Offset: 0x00259A58
		[NullableContext(1)]
		public static OpenSystemBoardResultRequest Create()
		{
			return new OpenSystemBoardResultRequest();
		}

		// Token: 0x170034F0 RID: 13552
		// (get) Token: 0x06010261 RID: 66145 RVA: 0x0025B85F File Offset: 0x00259A5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170034F1 RID: 13553
		// (get) Token: 0x06010262 RID: 66146 RVA: 0x0025B862 File Offset: 0x00259A62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OpenSystemBoardResultRequest.Descriptor;
			}
		}

		// Token: 0x06010263 RID: 66147 RVA: 0x0025B869 File Offset: 0x00259A69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OpenSystemBoardResultRequest()
		{
		}

		// Token: 0x06010264 RID: 66148 RVA: 0x0025B871 File Offset: 0x00259A71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OpenSystemBoardResultRequest(OpenSystemBoardResultRequest other) : this()
		{
			this.playerId_ = other.playerId_;
			this.result_ = other.result_;
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010265 RID: 66149 RVA: 0x0025B8AE File Offset: 0x00259AAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OpenSystemBoardResultRequest Clone()
		{
			return new OpenSystemBoardResultRequest(this);
		}

		// Token: 0x170034F2 RID: 13554
		// (get) Token: 0x06010266 RID: 66150 RVA: 0x0025B8B6 File Offset: 0x00259AB6
		// (set) Token: 0x06010267 RID: 66151 RVA: 0x0025B8BE File Offset: 0x00259ABE
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

		// Token: 0x170034F3 RID: 13555
		// (get) Token: 0x06010268 RID: 66152 RVA: 0x0025B8C7 File Offset: 0x00259AC7
		// (set) Token: 0x06010269 RID: 66153 RVA: 0x0025B8CF File Offset: 0x00259ACF
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

		// Token: 0x170034F4 RID: 13556
		// (get) Token: 0x0601026A RID: 66154 RVA: 0x0025B8D8 File Offset: 0x00259AD8
		// (set) Token: 0x0601026B RID: 66155 RVA: 0x0025B8E0 File Offset: 0x00259AE0
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

		// Token: 0x0601026C RID: 66156 RVA: 0x0025B8E9 File Offset: 0x00259AE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OpenSystemBoardResultRequest);
		}

		// Token: 0x0601026D RID: 66157 RVA: 0x0025B8F8 File Offset: 0x00259AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OpenSystemBoardResultRequest other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.Result == other.Result && this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601026E RID: 66158 RVA: 0x0025B954 File Offset: 0x00259B54
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

		// Token: 0x0601026F RID: 66159 RVA: 0x0025B9C5 File Offset: 0x00259BC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010270 RID: 66160 RVA: 0x0025B9D2 File Offset: 0x00259BD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010271 RID: 66161 RVA: 0x0025B9DC File Offset: 0x00259BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.IncId);
			}
			if (this.Result != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Result);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010272 RID: 66162 RVA: 0x0025BA50 File Offset: 0x00259C50
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

		// Token: 0x06010273 RID: 66163 RVA: 0x0025BAC0 File Offset: 0x00259CC0
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

		// Token: 0x06010274 RID: 66164 RVA: 0x0025BB24 File Offset: 0x00259D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010275 RID: 66165 RVA: 0x0025BB30 File Offset: 0x00259D30
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
					if (num != 40U)
					{
						if (num != 72U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.PlayerId = input.ReadInt32();
						}
					}
					else
					{
						this.Result = input.ReadInt32();
					}
				}
				else
				{
					this.IncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040066E5 RID: 26341
		private UnknownFieldSet _unknownFields;

		// Token: 0x040066E6 RID: 26342
		public const int PlayerIdFieldNumber = 9;

		// Token: 0x040066E7 RID: 26343
		private int playerId_;

		// Token: 0x040066E8 RID: 26344
		public const int ResultFieldNumber = 5;

		// Token: 0x040066E9 RID: 26345
		private int result_;

		// Token: 0x040066EA RID: 26346
		public const int IncIdFieldNumber = 1;

		// Token: 0x040066EB RID: 26347
		private int incId_;
	}
}
