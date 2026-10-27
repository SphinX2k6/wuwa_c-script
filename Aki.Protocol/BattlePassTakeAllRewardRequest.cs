using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000172 RID: 370
	[NetMessage(EMessageId.BattlePassTakeAllRewardRequest)]
	public sealed class BattlePassTakeAllRewardRequest : IMessage<BattlePassTakeAllRewardRequest>, IMessage, IEquatable<BattlePassTakeAllRewardRequest>, IDeepCloneable<BattlePassTakeAllRewardRequest>, IBufferMessage
	{
		// Token: 0x06002D74 RID: 11636 RVA: 0x00075967 File Offset: 0x00073B67
		[NullableContext(1)]
		public static BattlePassTakeAllRewardRequest Create()
		{
			return new BattlePassTakeAllRewardRequest();
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x06002D75 RID: 11637 RVA: 0x0007596E File Offset: 0x00073B6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06002D76 RID: 11638 RVA: 0x00075971 File Offset: 0x00073B71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattlePassTakeAllRewardRequest.Descriptor;
			}
		}

		// Token: 0x06002D77 RID: 11639 RVA: 0x00075978 File Offset: 0x00073B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTakeAllRewardRequest()
		{
		}

		// Token: 0x06002D78 RID: 11640 RVA: 0x00075980 File Offset: 0x00073B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTakeAllRewardRequest(BattlePassTakeAllRewardRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002D79 RID: 11641 RVA: 0x00075999 File Offset: 0x00073B99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTakeAllRewardRequest Clone()
		{
			return new BattlePassTakeAllRewardRequest(this);
		}

		// Token: 0x06002D7A RID: 11642 RVA: 0x000759A1 File Offset: 0x00073BA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattlePassTakeAllRewardRequest);
		}

		// Token: 0x06002D7B RID: 11643 RVA: 0x000759AF File Offset: 0x00073BAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattlePassTakeAllRewardRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06002D7C RID: 11644 RVA: 0x000759D0 File Offset: 0x00073BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002D7D RID: 11645 RVA: 0x000759F6 File Offset: 0x00073BF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002D7E RID: 11646 RVA: 0x00075A03 File Offset: 0x00073C03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002D7F RID: 11647 RVA: 0x00075A0C File Offset: 0x00073C0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002D80 RID: 11648 RVA: 0x00075A24 File Offset: 0x00073C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002D81 RID: 11649 RVA: 0x00075A4A File Offset: 0x00073C4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattlePassTakeAllRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002D82 RID: 11650 RVA: 0x00075A67 File Offset: 0x00073C67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002D83 RID: 11651 RVA: 0x00075A70 File Offset: 0x00073C70
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002834 RID: 10292
		private UnknownFieldSet _unknownFields;
	}
}
