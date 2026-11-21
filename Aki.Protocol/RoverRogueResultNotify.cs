using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001156 RID: 4438
	[NetMessage(EMessageId.RoverRogueResultNotify)]
	public sealed class RoverRogueResultNotify : IMessage<RoverRogueResultNotify>, IMessage, IEquatable<RoverRogueResultNotify>, IDeepCloneable<RoverRogueResultNotify>, IBufferMessage
	{
		// Token: 0x06017B7D RID: 97149 RVA: 0x003741EF File Offset: 0x003723EF
		[NullableContext(1)]
		public static RoverRogueResultNotify Create()
		{
			return new RoverRogueResultNotify();
		}

		// Token: 0x17004FD6 RID: 20438
		// (get) Token: 0x06017B7E RID: 97150 RVA: 0x003741F6 File Offset: 0x003723F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004FD7 RID: 20439
		// (get) Token: 0x06017B7F RID: 97151 RVA: 0x003741F9 File Offset: 0x003723F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueResultNotify.Descriptor;
			}
		}

		// Token: 0x06017B80 RID: 97152 RVA: 0x00374200 File Offset: 0x00372400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueResultNotify()
		{
		}

		// Token: 0x06017B81 RID: 97153 RVA: 0x00374208 File Offset: 0x00372408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueResultNotify(RoverRogueResultNotify other) : this()
		{
			this.resultInfo_ = ((other.resultInfo_ != null) ? other.resultInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017B82 RID: 97154 RVA: 0x0037423D File Offset: 0x0037243D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueResultNotify Clone()
		{
			return new RoverRogueResultNotify(this);
		}

		// Token: 0x17004FD8 RID: 20440
		// (get) Token: 0x06017B83 RID: 97155 RVA: 0x00374245 File Offset: 0x00372445
		// (set) Token: 0x06017B84 RID: 97156 RVA: 0x0037424D File Offset: 0x0037244D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueResultInfo ResultInfo
		{
			get
			{
				return this.resultInfo_;
			}
			set
			{
				this.resultInfo_ = value;
			}
		}

		// Token: 0x06017B85 RID: 97157 RVA: 0x00374256 File Offset: 0x00372456
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueResultNotify);
		}

		// Token: 0x06017B86 RID: 97158 RVA: 0x00374264 File Offset: 0x00372464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueResultNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ResultInfo, other.ResultInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017B87 RID: 97159 RVA: 0x00374298 File Offset: 0x00372498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.resultInfo_ != null)
			{
				num ^= this.ResultInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017B88 RID: 97160 RVA: 0x003742D4 File Offset: 0x003724D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017B89 RID: 97161 RVA: 0x003742E1 File Offset: 0x003724E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017B8A RID: 97162 RVA: 0x003742EA File Offset: 0x003724EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.resultInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.ResultInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017B8B RID: 97163 RVA: 0x0037431C File Offset: 0x0037251C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.resultInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ResultInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017B8C RID: 97164 RVA: 0x0037435C File Offset: 0x0037255C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueResultNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.resultInfo_ != null)
			{
				if (this.resultInfo_ == null)
				{
					this.ResultInfo = new RoverRogueResultInfo();
				}
				this.ResultInfo.MergeFrom(other.ResultInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017B8D RID: 97165 RVA: 0x003743B0 File Offset: 0x003725B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017B8E RID: 97166 RVA: 0x003743BC File Offset: 0x003725BC
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.resultInfo_ == null)
					{
						this.ResultInfo = new RoverRogueResultInfo();
					}
					input.ReadMessage(this.ResultInfo);
				}
			}
		}

		// Token: 0x04008D9B RID: 36251
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D9C RID: 36252
		public const int ResultInfoFieldNumber = 4;

		// Token: 0x04008D9D RID: 36253
		private RoverRogueResultInfo resultInfo_;
	}
}
