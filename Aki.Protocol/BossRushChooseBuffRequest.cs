using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001D6 RID: 470
	[NetMessage(EMessageId.BossRushChooseBuffRequest)]
	public sealed class BossRushChooseBuffRequest : IMessage<BossRushChooseBuffRequest>, IMessage, IEquatable<BossRushChooseBuffRequest>, IDeepCloneable<BossRushChooseBuffRequest>, IBufferMessage
	{
		// Token: 0x06003587 RID: 13703 RVA: 0x00086CD5 File Offset: 0x00084ED5
		[NullableContext(1)]
		public static BossRushChooseBuffRequest Create()
		{
			return new BossRushChooseBuffRequest();
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x06003588 RID: 13704 RVA: 0x00086CDC File Offset: 0x00084EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x06003589 RID: 13705 RVA: 0x00086CDF File Offset: 0x00084EDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushChooseBuffRequest.Descriptor;
			}
		}

		// Token: 0x0600358A RID: 13706 RVA: 0x00086CE6 File Offset: 0x00084EE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushChooseBuffRequest()
		{
		}

		// Token: 0x0600358B RID: 13707 RVA: 0x00086CEE File Offset: 0x00084EEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushChooseBuffRequest(BossRushChooseBuffRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600358C RID: 13708 RVA: 0x00086D07 File Offset: 0x00084F07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushChooseBuffRequest Clone()
		{
			return new BossRushChooseBuffRequest(this);
		}

		// Token: 0x0600358D RID: 13709 RVA: 0x00086D0F File Offset: 0x00084F0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushChooseBuffRequest);
		}

		// Token: 0x0600358E RID: 13710 RVA: 0x00086D1D File Offset: 0x00084F1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushChooseBuffRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600358F RID: 13711 RVA: 0x00086D3C File Offset: 0x00084F3C
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

		// Token: 0x06003590 RID: 13712 RVA: 0x00086D62 File Offset: 0x00084F62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003591 RID: 13713 RVA: 0x00086D6F File Offset: 0x00084F6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003592 RID: 13714 RVA: 0x00086D78 File Offset: 0x00084F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003593 RID: 13715 RVA: 0x00086D90 File Offset: 0x00084F90
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

		// Token: 0x06003594 RID: 13716 RVA: 0x00086DB6 File Offset: 0x00084FB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossRushChooseBuffRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003595 RID: 13717 RVA: 0x00086DD3 File Offset: 0x00084FD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003596 RID: 13718 RVA: 0x00086DDC File Offset: 0x00084FDC
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

		// Token: 0x04002AA6 RID: 10918
		private UnknownFieldSet _unknownFields;
	}
}
