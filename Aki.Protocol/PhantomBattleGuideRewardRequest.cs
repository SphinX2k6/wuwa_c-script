using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C90 RID: 3216
	[NetMessage(EMessageId.PhantomBattleGuideRewardRequest)]
	public sealed class PhantomBattleGuideRewardRequest : IMessage<PhantomBattleGuideRewardRequest>, IMessage, IEquatable<PhantomBattleGuideRewardRequest>, IDeepCloneable<PhantomBattleGuideRewardRequest>, IBufferMessage
	{
		// Token: 0x060116F8 RID: 71416 RVA: 0x0028E392 File Offset: 0x0028C592
		[NullableContext(1)]
		public static PhantomBattleGuideRewardRequest Create()
		{
			return new PhantomBattleGuideRewardRequest();
		}

		// Token: 0x170039C3 RID: 14787
		// (get) Token: 0x060116F9 RID: 71417 RVA: 0x0028E399 File Offset: 0x0028C599
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170039C4 RID: 14788
		// (get) Token: 0x060116FA RID: 71418 RVA: 0x0028E39C File Offset: 0x0028C59C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleGuideRewardRequest.Descriptor;
			}
		}

		// Token: 0x060116FB RID: 71419 RVA: 0x0028E3A3 File Offset: 0x0028C5A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleGuideRewardRequest()
		{
		}

		// Token: 0x060116FC RID: 71420 RVA: 0x0028E3AB File Offset: 0x0028C5AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleGuideRewardRequest(PhantomBattleGuideRewardRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060116FD RID: 71421 RVA: 0x0028E3C4 File Offset: 0x0028C5C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleGuideRewardRequest Clone()
		{
			return new PhantomBattleGuideRewardRequest(this);
		}

		// Token: 0x060116FE RID: 71422 RVA: 0x0028E3CC File Offset: 0x0028C5CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleGuideRewardRequest);
		}

		// Token: 0x060116FF RID: 71423 RVA: 0x0028E3DA File Offset: 0x0028C5DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleGuideRewardRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06011700 RID: 71424 RVA: 0x0028E3F8 File Offset: 0x0028C5F8
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

		// Token: 0x06011701 RID: 71425 RVA: 0x0028E41E File Offset: 0x0028C61E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011702 RID: 71426 RVA: 0x0028E42B File Offset: 0x0028C62B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011703 RID: 71427 RVA: 0x0028E434 File Offset: 0x0028C634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011704 RID: 71428 RVA: 0x0028E44C File Offset: 0x0028C64C
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

		// Token: 0x06011705 RID: 71429 RVA: 0x0028E472 File Offset: 0x0028C672
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

		// Token: 0x06011706 RID: 71430 RVA: 0x0028E48F File Offset: 0x0028C68F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011707 RID: 71431 RVA: 0x0028E498 File Offset: 0x0028C698
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

		// Token: 0x04006E1C RID: 28188
		private UnknownFieldSet _unknownFields;
	}
}
