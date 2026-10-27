using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001CA RID: 458
	[NetMessage(EMessageId.BossPilingSettleRequest)]
	public sealed class BossPilingSettleRequest : IMessage<BossPilingSettleRequest>, IMessage, IEquatable<BossPilingSettleRequest>, IDeepCloneable<BossPilingSettleRequest>, IBufferMessage
	{
		// Token: 0x06003467 RID: 13415 RVA: 0x00084400 File Offset: 0x00082600
		[NullableContext(1)]
		public static BossPilingSettleRequest Create()
		{
			return new BossPilingSettleRequest();
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x06003468 RID: 13416 RVA: 0x00084407 File Offset: 0x00082607
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x06003469 RID: 13417 RVA: 0x0008440A File Offset: 0x0008260A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossPilingSettleRequest.Descriptor;
			}
		}

		// Token: 0x0600346A RID: 13418 RVA: 0x00084411 File Offset: 0x00082611
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingSettleRequest()
		{
		}

		// Token: 0x0600346B RID: 13419 RVA: 0x00084419 File Offset: 0x00082619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingSettleRequest(BossPilingSettleRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600346C RID: 13420 RVA: 0x00084432 File Offset: 0x00082632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingSettleRequest Clone()
		{
			return new BossPilingSettleRequest(this);
		}

		// Token: 0x0600346D RID: 13421 RVA: 0x0008443A File Offset: 0x0008263A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossPilingSettleRequest);
		}

		// Token: 0x0600346E RID: 13422 RVA: 0x00084448 File Offset: 0x00082648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossPilingSettleRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600346F RID: 13423 RVA: 0x00084468 File Offset: 0x00082668
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

		// Token: 0x06003470 RID: 13424 RVA: 0x0008448E File Offset: 0x0008268E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003471 RID: 13425 RVA: 0x0008449B File Offset: 0x0008269B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003472 RID: 13426 RVA: 0x000844A4 File Offset: 0x000826A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003473 RID: 13427 RVA: 0x000844BC File Offset: 0x000826BC
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

		// Token: 0x06003474 RID: 13428 RVA: 0x000844E2 File Offset: 0x000826E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossPilingSettleRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003475 RID: 13429 RVA: 0x000844FF File Offset: 0x000826FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003476 RID: 13430 RVA: 0x00084508 File Offset: 0x00082708
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

		// Token: 0x04002A07 RID: 10759
		private UnknownFieldSet _unknownFields;
	}
}
