using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C80 RID: 3200
	[NetMessage(EMessageId.PhantomBattleGuideRewardRequest)]
	public sealed class PhantomBattleGuideRewardRequest : IMessage<PhantomBattleGuideRewardRequest>, IMessage, IEquatable<PhantomBattleGuideRewardRequest>, IDeepCloneable<PhantomBattleGuideRewardRequest>, IBufferMessage
	{
		// Token: 0x060115F8 RID: 71160 RVA: 0x0028C626 File Offset: 0x0028A826
		[NullableContext(1)]
		public static PhantomBattleGuideRewardRequest Create()
		{
			return new PhantomBattleGuideRewardRequest();
		}

		// Token: 0x1700398C RID: 14732
		// (get) Token: 0x060115F9 RID: 71161 RVA: 0x0028C62D File Offset: 0x0028A82D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700398D RID: 14733
		// (get) Token: 0x060115FA RID: 71162 RVA: 0x0028C630 File Offset: 0x0028A830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleGuideRewardRequest.Descriptor;
			}
		}

		// Token: 0x060115FB RID: 71163 RVA: 0x0028C637 File Offset: 0x0028A837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleGuideRewardRequest()
		{
		}

		// Token: 0x060115FC RID: 71164 RVA: 0x0028C63F File Offset: 0x0028A83F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleGuideRewardRequest(PhantomBattleGuideRewardRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060115FD RID: 71165 RVA: 0x0028C658 File Offset: 0x0028A858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleGuideRewardRequest Clone()
		{
			return new PhantomBattleGuideRewardRequest(this);
		}

		// Token: 0x060115FE RID: 71166 RVA: 0x0028C660 File Offset: 0x0028A860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleGuideRewardRequest);
		}

		// Token: 0x060115FF RID: 71167 RVA: 0x0028C66E File Offset: 0x0028A86E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleGuideRewardRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06011600 RID: 71168 RVA: 0x0028C68C File Offset: 0x0028A88C
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

		// Token: 0x06011601 RID: 71169 RVA: 0x0028C6B2 File Offset: 0x0028A8B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011602 RID: 71170 RVA: 0x0028C6BF File Offset: 0x0028A8BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011603 RID: 71171 RVA: 0x0028C6C8 File Offset: 0x0028A8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011604 RID: 71172 RVA: 0x0028C6E0 File Offset: 0x0028A8E0
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

		// Token: 0x06011605 RID: 71173 RVA: 0x0028C706 File Offset: 0x0028A906
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleGuideRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011606 RID: 71174 RVA: 0x0028C723 File Offset: 0x0028A923
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011607 RID: 71175 RVA: 0x0028C72C File Offset: 0x0028A92C
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

		// Token: 0x04006E30 RID: 28208
		private UnknownFieldSet _unknownFields;
	}
}
