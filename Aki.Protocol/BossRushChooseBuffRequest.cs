using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001D2 RID: 466
	[NetMessage(EMessageId.BossRushChooseBuffRequest)]
	public sealed class BossRushChooseBuffRequest : IMessage<BossRushChooseBuffRequest>, IMessage, IEquatable<BossRushChooseBuffRequest>, IDeepCloneable<BossRushChooseBuffRequest>, IBufferMessage
	{
		// Token: 0x060034FA RID: 13562 RVA: 0x00085561 File Offset: 0x00083761
		[NullableContext(1)]
		public static BossRushChooseBuffRequest Create()
		{
			return new BossRushChooseBuffRequest();
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x060034FB RID: 13563 RVA: 0x00085568 File Offset: 0x00083768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x060034FC RID: 13564 RVA: 0x0008556B File Offset: 0x0008376B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushChooseBuffRequest.Descriptor;
			}
		}

		// Token: 0x060034FD RID: 13565 RVA: 0x00085572 File Offset: 0x00083772
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushChooseBuffRequest()
		{
		}

		// Token: 0x060034FE RID: 13566 RVA: 0x0008557A File Offset: 0x0008377A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushChooseBuffRequest(BossRushChooseBuffRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060034FF RID: 13567 RVA: 0x00085593 File Offset: 0x00083793
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushChooseBuffRequest Clone()
		{
			return new BossRushChooseBuffRequest(this);
		}

		// Token: 0x06003500 RID: 13568 RVA: 0x0008559B File Offset: 0x0008379B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushChooseBuffRequest);
		}

		// Token: 0x06003501 RID: 13569 RVA: 0x000855A9 File Offset: 0x000837A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushChooseBuffRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06003502 RID: 13570 RVA: 0x000855C8 File Offset: 0x000837C8
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

		// Token: 0x06003503 RID: 13571 RVA: 0x000855EE File Offset: 0x000837EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003504 RID: 13572 RVA: 0x000855FB File Offset: 0x000837FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003505 RID: 13573 RVA: 0x00085604 File Offset: 0x00083804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003506 RID: 13574 RVA: 0x0008561C File Offset: 0x0008381C
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

		// Token: 0x06003507 RID: 13575 RVA: 0x00085642 File Offset: 0x00083842
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

		// Token: 0x06003508 RID: 13576 RVA: 0x0008565F File Offset: 0x0008385F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003509 RID: 13577 RVA: 0x00085668 File Offset: 0x00083868
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

		// Token: 0x04002A2B RID: 10795
		private UnknownFieldSet _unknownFields;
	}
}
