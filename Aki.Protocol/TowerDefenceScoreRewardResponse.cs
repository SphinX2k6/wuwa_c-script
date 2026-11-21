using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001425 RID: 5157
	[NetMessage(EMessageId.TowerDefenceScoreRewardResponse)]
	public sealed class TowerDefenceScoreRewardResponse : IMessage<TowerDefenceScoreRewardResponse>, IMessage, IEquatable<TowerDefenceScoreRewardResponse>, IDeepCloneable<TowerDefenceScoreRewardResponse>, IBufferMessage
	{
		// Token: 0x0601B691 RID: 112273 RVA: 0x003FC605 File Offset: 0x003FA805
		[NullableContext(1)]
		public static TowerDefenceScoreRewardResponse Create()
		{
			return new TowerDefenceScoreRewardResponse();
		}

		// Token: 0x17005CCE RID: 23758
		// (get) Token: 0x0601B692 RID: 112274 RVA: 0x003FC60C File Offset: 0x003FA80C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005CCF RID: 23759
		// (get) Token: 0x0601B693 RID: 112275 RVA: 0x003FC60F File Offset: 0x003FA80F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceScoreRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601B694 RID: 112276 RVA: 0x003FC616 File Offset: 0x003FA816
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceScoreRewardResponse()
		{
		}

		// Token: 0x0601B695 RID: 112277 RVA: 0x003FC61E File Offset: 0x003FA81E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceScoreRewardResponse(TowerDefenceScoreRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B696 RID: 112278 RVA: 0x003FC643 File Offset: 0x003FA843
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceScoreRewardResponse Clone()
		{
			return new TowerDefenceScoreRewardResponse(this);
		}

		// Token: 0x17005CD0 RID: 23760
		// (get) Token: 0x0601B697 RID: 112279 RVA: 0x003FC64B File Offset: 0x003FA84B
		// (set) Token: 0x0601B698 RID: 112280 RVA: 0x003FC653 File Offset: 0x003FA853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x0601B699 RID: 112281 RVA: 0x003FC65C File Offset: 0x003FA85C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceScoreRewardResponse);
		}

		// Token: 0x0601B69A RID: 112282 RVA: 0x003FC66A File Offset: 0x003FA86A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceScoreRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B69B RID: 112283 RVA: 0x003FC698 File Offset: 0x003FA898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B69C RID: 112284 RVA: 0x003FC6DD File Offset: 0x003FA8DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B69D RID: 112285 RVA: 0x003FC6EA File Offset: 0x003FA8EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B69E RID: 112286 RVA: 0x003FC6F3 File Offset: 0x003FA8F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B69F RID: 112287 RVA: 0x003FC728 File Offset: 0x003FA928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B6A0 RID: 112288 RVA: 0x003FC766 File Offset: 0x003FA966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerDefenceScoreRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B6A1 RID: 112289 RVA: 0x003FC797 File Offset: 0x003FA997
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B6A2 RID: 112290 RVA: 0x003FC7A0 File Offset: 0x003FA9A0
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009F9F RID: 40863
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009FA0 RID: 40864
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04009FA1 RID: 40865
		private ErrorCode errorCode_;
	}
}
