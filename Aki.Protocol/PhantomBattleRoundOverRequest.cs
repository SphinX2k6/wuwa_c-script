using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CAD RID: 3245
	[NetMessage(EMessageId.PhantomBattleRoundOverRequest)]
	public sealed class PhantomBattleRoundOverRequest : IMessage<PhantomBattleRoundOverRequest>, IMessage, IEquatable<PhantomBattleRoundOverRequest>, IDeepCloneable<PhantomBattleRoundOverRequest>, IBufferMessage
	{
		// Token: 0x0601194C RID: 72012 RVA: 0x00293399 File Offset: 0x00291599
		[NullableContext(1)]
		public static PhantomBattleRoundOverRequest Create()
		{
			return new PhantomBattleRoundOverRequest();
		}

		// Token: 0x17003A40 RID: 14912
		// (get) Token: 0x0601194D RID: 72013 RVA: 0x002933A0 File Offset: 0x002915A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A41 RID: 14913
		// (get) Token: 0x0601194E RID: 72014 RVA: 0x002933A3 File Offset: 0x002915A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleRoundOverRequest.Descriptor;
			}
		}

		// Token: 0x0601194F RID: 72015 RVA: 0x002933AA File Offset: 0x002915AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRoundOverRequest()
		{
		}

		// Token: 0x06011950 RID: 72016 RVA: 0x002933B2 File Offset: 0x002915B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRoundOverRequest(PhantomBattleRoundOverRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011951 RID: 72017 RVA: 0x002933CB File Offset: 0x002915CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRoundOverRequest Clone()
		{
			return new PhantomBattleRoundOverRequest(this);
		}

		// Token: 0x06011952 RID: 72018 RVA: 0x002933D3 File Offset: 0x002915D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleRoundOverRequest);
		}

		// Token: 0x06011953 RID: 72019 RVA: 0x002933E1 File Offset: 0x002915E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleRoundOverRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06011954 RID: 72020 RVA: 0x00293400 File Offset: 0x00291600
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

		// Token: 0x06011955 RID: 72021 RVA: 0x00293426 File Offset: 0x00291626
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011956 RID: 72022 RVA: 0x00293433 File Offset: 0x00291633
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011957 RID: 72023 RVA: 0x0029343C File Offset: 0x0029163C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011958 RID: 72024 RVA: 0x00293454 File Offset: 0x00291654
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

		// Token: 0x06011959 RID: 72025 RVA: 0x0029347A File Offset: 0x0029167A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleRoundOverRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601195A RID: 72026 RVA: 0x00293497 File Offset: 0x00291697
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601195B RID: 72027 RVA: 0x002934A0 File Offset: 0x002916A0
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

		// Token: 0x04006EC9 RID: 28361
		private UnknownFieldSet _unknownFields;
	}
}
