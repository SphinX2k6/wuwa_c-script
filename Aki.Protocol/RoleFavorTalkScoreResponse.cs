using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001079 RID: 4217
	[NetMessage(EMessageId.RoleFavorTalkScoreResponse)]
	public sealed class RoleFavorTalkScoreResponse : IMessage<RoleFavorTalkScoreResponse>, IMessage, IEquatable<RoleFavorTalkScoreResponse>, IDeepCloneable<RoleFavorTalkScoreResponse>, IBufferMessage
	{
		// Token: 0x0601687E RID: 92286 RVA: 0x0034674C File Offset: 0x0034494C
		[NullableContext(1)]
		public static RoleFavorTalkScoreResponse Create()
		{
			return new RoleFavorTalkScoreResponse();
		}

		// Token: 0x17004B6F RID: 19311
		// (get) Token: 0x0601687F RID: 92287 RVA: 0x00346753 File Offset: 0x00344953
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B70 RID: 19312
		// (get) Token: 0x06016880 RID: 92288 RVA: 0x00346756 File Offset: 0x00344956
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleFavorTalkScoreResponse.Descriptor;
			}
		}

		// Token: 0x06016881 RID: 92289 RVA: 0x0034675D File Offset: 0x0034495D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorTalkScoreResponse()
		{
		}

		// Token: 0x06016882 RID: 92290 RVA: 0x00346765 File Offset: 0x00344965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorTalkScoreResponse(RoleFavorTalkScoreResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this.isComplete_ = other.isComplete_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016883 RID: 92291 RVA: 0x00346796 File Offset: 0x00344996
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorTalkScoreResponse Clone()
		{
			return new RoleFavorTalkScoreResponse(this);
		}

		// Token: 0x17004B71 RID: 19313
		// (get) Token: 0x06016884 RID: 92292 RVA: 0x0034679E File Offset: 0x0034499E
		// (set) Token: 0x06016885 RID: 92293 RVA: 0x003467A6 File Offset: 0x003449A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x17004B72 RID: 19314
		// (get) Token: 0x06016886 RID: 92294 RVA: 0x003467AF File Offset: 0x003449AF
		// (set) Token: 0x06016887 RID: 92295 RVA: 0x003467B7 File Offset: 0x003449B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsComplete
		{
			get
			{
				return this.isComplete_;
			}
			set
			{
				this.isComplete_ = value;
			}
		}

		// Token: 0x06016888 RID: 92296 RVA: 0x003467C0 File Offset: 0x003449C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleFavorTalkScoreResponse);
		}

		// Token: 0x06016889 RID: 92297 RVA: 0x003467CE File Offset: 0x003449CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleFavorTalkScoreResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && this.IsComplete == other.IsComplete && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601688A RID: 92298 RVA: 0x0034680C File Offset: 0x00344A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this.IsComplete)
			{
				num ^= this.IsComplete.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601688B RID: 92299 RVA: 0x0034686A File Offset: 0x00344A6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601688C RID: 92300 RVA: 0x00346877 File Offset: 0x00344A77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601688D RID: 92301 RVA: 0x00346880 File Offset: 0x00344A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsComplete)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsComplete);
			}
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601688E RID: 92302 RVA: 0x003468DC File Offset: 0x00344ADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this.IsComplete)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601688F RID: 92303 RVA: 0x00346928 File Offset: 0x00344B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleFavorTalkScoreResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			if (other.IsComplete)
			{
				this.IsComplete = other.IsComplete;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016890 RID: 92304 RVA: 0x00346978 File Offset: 0x00344B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016891 RID: 92305 RVA: 0x00346984 File Offset: 0x00344B84
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
				if (num != 32U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.IsComplete = input.ReadBool();
				}
			}
		}

		// Token: 0x040086B3 RID: 34483
		private UnknownFieldSet _unknownFields;

		// Token: 0x040086B4 RID: 34484
		public const int ErrCodeFieldNumber = 13;

		// Token: 0x040086B5 RID: 34485
		private ErrorCode errCode_;

		// Token: 0x040086B6 RID: 34486
		public const int IsCompleteFieldNumber = 4;

		// Token: 0x040086B7 RID: 34487
		private bool isComplete_;
	}
}
