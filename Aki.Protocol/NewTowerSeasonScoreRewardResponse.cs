using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B4C RID: 2892
	[NetMessage(EMessageId.NewTowerSeasonScoreRewardResponse)]
	public sealed class NewTowerSeasonScoreRewardResponse : IMessage<NewTowerSeasonScoreRewardResponse>, IMessage, IEquatable<NewTowerSeasonScoreRewardResponse>, IDeepCloneable<NewTowerSeasonScoreRewardResponse>, IBufferMessage
	{
		// Token: 0x0600FAD3 RID: 64211 RVA: 0x00248F7D File Offset: 0x0024717D
		[NullableContext(1)]
		public static NewTowerSeasonScoreRewardResponse Create()
		{
			return new NewTowerSeasonScoreRewardResponse();
		}

		// Token: 0x17003324 RID: 13092
		// (get) Token: 0x0600FAD4 RID: 64212 RVA: 0x00248F84 File Offset: 0x00247184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003325 RID: 13093
		// (get) Token: 0x0600FAD5 RID: 64213 RVA: 0x00248F87 File Offset: 0x00247187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerSeasonScoreRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600FAD6 RID: 64214 RVA: 0x00248F8E File Offset: 0x0024718E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerSeasonScoreRewardResponse()
		{
		}

		// Token: 0x0600FAD7 RID: 64215 RVA: 0x00248F96 File Offset: 0x00247196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerSeasonScoreRewardResponse(NewTowerSeasonScoreRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FAD8 RID: 64216 RVA: 0x00248FBB File Offset: 0x002471BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerSeasonScoreRewardResponse Clone()
		{
			return new NewTowerSeasonScoreRewardResponse(this);
		}

		// Token: 0x17003326 RID: 13094
		// (get) Token: 0x0600FAD9 RID: 64217 RVA: 0x00248FC3 File Offset: 0x002471C3
		// (set) Token: 0x0600FADA RID: 64218 RVA: 0x00248FCB File Offset: 0x002471CB
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

		// Token: 0x0600FADB RID: 64219 RVA: 0x00248FD4 File Offset: 0x002471D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerSeasonScoreRewardResponse);
		}

		// Token: 0x0600FADC RID: 64220 RVA: 0x00248FE2 File Offset: 0x002471E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerSeasonScoreRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FADD RID: 64221 RVA: 0x00249010 File Offset: 0x00247210
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

		// Token: 0x0600FADE RID: 64222 RVA: 0x00249055 File Offset: 0x00247255
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FADF RID: 64223 RVA: 0x00249062 File Offset: 0x00247262
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FAE0 RID: 64224 RVA: 0x0024906B File Offset: 0x0024726B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FAE1 RID: 64225 RVA: 0x0024909C File Offset: 0x0024729C
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

		// Token: 0x0600FAE2 RID: 64226 RVA: 0x002490DA File Offset: 0x002472DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerSeasonScoreRewardResponse other)
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

		// Token: 0x0600FAE3 RID: 64227 RVA: 0x0024910B File Offset: 0x0024730B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FAE4 RID: 64228 RVA: 0x00249114 File Offset: 0x00247314
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400645A RID: 25690
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400645B RID: 25691
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x0400645C RID: 25692
		private ErrorCode errorCode_;
	}
}
