using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B3B RID: 2875
	[NetMessage(EMessageId.NewTowerSeasonScoreRewardResponse)]
	public sealed class NewTowerSeasonScoreRewardResponse : IMessage<NewTowerSeasonScoreRewardResponse>, IMessage, IEquatable<NewTowerSeasonScoreRewardResponse>, IDeepCloneable<NewTowerSeasonScoreRewardResponse>, IBufferMessage
	{
		// Token: 0x0600F9B9 RID: 63929 RVA: 0x00246D65 File Offset: 0x00244F65
		[NullableContext(1)]
		public static NewTowerSeasonScoreRewardResponse Create()
		{
			return new NewTowerSeasonScoreRewardResponse();
		}

		// Token: 0x170032E6 RID: 13030
		// (get) Token: 0x0600F9BA RID: 63930 RVA: 0x00246D6C File Offset: 0x00244F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170032E7 RID: 13031
		// (get) Token: 0x0600F9BB RID: 63931 RVA: 0x00246D6F File Offset: 0x00244F6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerSeasonScoreRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600F9BC RID: 63932 RVA: 0x00246D76 File Offset: 0x00244F76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerSeasonScoreRewardResponse()
		{
		}

		// Token: 0x0600F9BD RID: 63933 RVA: 0x00246D7E File Offset: 0x00244F7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerSeasonScoreRewardResponse(NewTowerSeasonScoreRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F9BE RID: 63934 RVA: 0x00246DA3 File Offset: 0x00244FA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerSeasonScoreRewardResponse Clone()
		{
			return new NewTowerSeasonScoreRewardResponse(this);
		}

		// Token: 0x170032E8 RID: 13032
		// (get) Token: 0x0600F9BF RID: 63935 RVA: 0x00246DAB File Offset: 0x00244FAB
		// (set) Token: 0x0600F9C0 RID: 63936 RVA: 0x00246DB3 File Offset: 0x00244FB3
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

		// Token: 0x0600F9C1 RID: 63937 RVA: 0x00246DBC File Offset: 0x00244FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerSeasonScoreRewardResponse);
		}

		// Token: 0x0600F9C2 RID: 63938 RVA: 0x00246DCA File Offset: 0x00244FCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerSeasonScoreRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F9C3 RID: 63939 RVA: 0x00246DF8 File Offset: 0x00244FF8
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

		// Token: 0x0600F9C4 RID: 63940 RVA: 0x00246E3D File Offset: 0x0024503D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F9C5 RID: 63941 RVA: 0x00246E4A File Offset: 0x0024504A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F9C6 RID: 63942 RVA: 0x00246E53 File Offset: 0x00245053
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F9C7 RID: 63943 RVA: 0x00246E88 File Offset: 0x00245088
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

		// Token: 0x0600F9C8 RID: 63944 RVA: 0x00246EC6 File Offset: 0x002450C6
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

		// Token: 0x0600F9C9 RID: 63945 RVA: 0x00246EF7 File Offset: 0x002450F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F9CA RID: 63946 RVA: 0x00246F00 File Offset: 0x00245100
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006463 RID: 25699
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006464 RID: 25700
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04006465 RID: 25701
		private ErrorCode errorCode_;
	}
}
