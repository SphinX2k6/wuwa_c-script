using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000175 RID: 373
	[NetMessage(EMessageId.BattlePassTakeAllRewardRequest)]
	public sealed class BattlePassTakeAllRewardRequest : IMessage<BattlePassTakeAllRewardRequest>, IMessage, IEquatable<BattlePassTakeAllRewardRequest>, IDeepCloneable<BattlePassTakeAllRewardRequest>, IBufferMessage
	{
		// Token: 0x06002DEB RID: 11755 RVA: 0x00076D93 File Offset: 0x00074F93
		[NullableContext(1)]
		public static BattlePassTakeAllRewardRequest Create()
		{
			return new BattlePassTakeAllRewardRequest();
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06002DEC RID: 11756 RVA: 0x00076D9A File Offset: 0x00074F9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06002DED RID: 11757 RVA: 0x00076D9D File Offset: 0x00074F9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattlePassTakeAllRewardRequest.Descriptor;
			}
		}

		// Token: 0x06002DEE RID: 11758 RVA: 0x00076DA4 File Offset: 0x00074FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTakeAllRewardRequest()
		{
		}

		// Token: 0x06002DEF RID: 11759 RVA: 0x00076DAC File Offset: 0x00074FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTakeAllRewardRequest(BattlePassTakeAllRewardRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002DF0 RID: 11760 RVA: 0x00076DC5 File Offset: 0x00074FC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTakeAllRewardRequest Clone()
		{
			return new BattlePassTakeAllRewardRequest(this);
		}

		// Token: 0x06002DF1 RID: 11761 RVA: 0x00076DCD File Offset: 0x00074FCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattlePassTakeAllRewardRequest);
		}

		// Token: 0x06002DF2 RID: 11762 RVA: 0x00076DDB File Offset: 0x00074FDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattlePassTakeAllRewardRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06002DF3 RID: 11763 RVA: 0x00076DFC File Offset: 0x00074FFC
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

		// Token: 0x06002DF4 RID: 11764 RVA: 0x00076E22 File Offset: 0x00075022
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002DF5 RID: 11765 RVA: 0x00076E2F File Offset: 0x0007502F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002DF6 RID: 11766 RVA: 0x00076E38 File Offset: 0x00075038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002DF7 RID: 11767 RVA: 0x00076E50 File Offset: 0x00075050
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

		// Token: 0x06002DF8 RID: 11768 RVA: 0x00076E76 File Offset: 0x00075076
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

		// Token: 0x06002DF9 RID: 11769 RVA: 0x00076E93 File Offset: 0x00075093
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002DFA RID: 11770 RVA: 0x00076E9C File Offset: 0x0007509C
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

		// Token: 0x040028A8 RID: 10408
		private UnknownFieldSet _unknownFields;
	}
}
