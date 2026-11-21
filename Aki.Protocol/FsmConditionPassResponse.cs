using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000655 RID: 1621
	[NetMessage(EMessageId.FsmConditionPassResponse)]
	public sealed class FsmConditionPassResponse : IMessage<FsmConditionPassResponse>, IMessage, IEquatable<FsmConditionPassResponse>, IDeepCloneable<FsmConditionPassResponse>, IBufferMessage
	{
		// Token: 0x0600953B RID: 38203 RVA: 0x0016895B File Offset: 0x00166B5B
		[NullableContext(1)]
		public static FsmConditionPassResponse Create()
		{
			return new FsmConditionPassResponse();
		}

		// Token: 0x17001DB2 RID: 7602
		// (get) Token: 0x0600953C RID: 38204 RVA: 0x00168962 File Offset: 0x00166B62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001DB3 RID: 7603
		// (get) Token: 0x0600953D RID: 38205 RVA: 0x00168965 File Offset: 0x00166B65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FsmConditionPassResponse.Descriptor;
			}
		}

		// Token: 0x0600953E RID: 38206 RVA: 0x0016896C File Offset: 0x00166B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmConditionPassResponse()
		{
		}

		// Token: 0x0600953F RID: 38207 RVA: 0x00168974 File Offset: 0x00166B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmConditionPassResponse(FsmConditionPassResponse other) : this()
		{
			this.fsmId_ = other.fsmId_;
			this.error_ = ((other.error_ != null) ? other.error_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009540 RID: 38208 RVA: 0x001689C0 File Offset: 0x00166BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmConditionPassResponse Clone()
		{
			return new FsmConditionPassResponse(this);
		}

		// Token: 0x17001DB4 RID: 7604
		// (get) Token: 0x06009541 RID: 38209 RVA: 0x001689C8 File Offset: 0x00166BC8
		// (set) Token: 0x06009542 RID: 38210 RVA: 0x001689D0 File Offset: 0x00166BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FsmId
		{
			get
			{
				return this.fsmId_;
			}
			set
			{
				this.fsmId_ = value;
			}
		}

		// Token: 0x17001DB5 RID: 7605
		// (get) Token: 0x06009543 RID: 38211 RVA: 0x001689D9 File Offset: 0x00166BD9
		// (set) Token: 0x06009544 RID: 38212 RVA: 0x001689E1 File Offset: 0x00166BE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DErrorResult Error
		{
			get
			{
				return this.error_;
			}
			set
			{
				this.error_ = value;
			}
		}

		// Token: 0x06009545 RID: 38213 RVA: 0x001689EA File Offset: 0x00166BEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FsmConditionPassResponse);
		}

		// Token: 0x06009546 RID: 38214 RVA: 0x001689F8 File Offset: 0x00166BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FsmConditionPassResponse other)
		{
			return other != null && (other == this || (this.FsmId == other.FsmId && object.Equals(this.Error, other.Error) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009547 RID: 38215 RVA: 0x00168A48 File Offset: 0x00166C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FsmId != 0)
			{
				num ^= this.FsmId.GetHashCode();
			}
			if (this.error_ != null)
			{
				num ^= this.Error.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009548 RID: 38216 RVA: 0x00168A9D File Offset: 0x00166C9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009549 RID: 38217 RVA: 0x00168AAA File Offset: 0x00166CAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600954A RID: 38218 RVA: 0x00168AB4 File Offset: 0x00166CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FsmId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.FsmId);
			}
			if (this.error_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.Error);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600954B RID: 38219 RVA: 0x00168B10 File Offset: 0x00166D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FsmId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FsmId);
			}
			if (this.error_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Error);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600954C RID: 38220 RVA: 0x00168B68 File Offset: 0x00166D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FsmConditionPassResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FsmId != 0)
			{
				this.FsmId = other.FsmId;
			}
			if (other.error_ != null)
			{
				if (this.error_ == null)
				{
					this.Error = new DErrorResult();
				}
				this.Error.MergeFrom(other.Error);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600954D RID: 38221 RVA: 0x00168BD0 File Offset: 0x00166DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600954E RID: 38222 RVA: 0x00168BDC File Offset: 0x00166DDC
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
				if (num != 104U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.error_ == null)
						{
							this.Error = new DErrorResult();
						}
						input.ReadMessage(this.Error);
					}
				}
				else
				{
					this.FsmId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040047B6 RID: 18358
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047B7 RID: 18359
		public const int FsmIdFieldNumber = 13;

		// Token: 0x040047B8 RID: 18360
		private int fsmId_;

		// Token: 0x040047B9 RID: 18361
		public const int ErrorFieldNumber = 14;

		// Token: 0x040047BA RID: 18362
		private DErrorResult error_;
	}
}
