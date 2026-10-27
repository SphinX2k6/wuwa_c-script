using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004ED RID: 1261
	[NetMessage(EMessageId.ExitViewDirectionRequest)]
	public sealed class ExitViewDirectionRequest : IMessage<ExitViewDirectionRequest>, IMessage, IEquatable<ExitViewDirectionRequest>, IDeepCloneable<ExitViewDirectionRequest>, IBufferMessage
	{
		// Token: 0x06007745 RID: 30533 RVA: 0x001231D2 File Offset: 0x001213D2
		[NullableContext(1)]
		public static ExitViewDirectionRequest Create()
		{
			return new ExitViewDirectionRequest();
		}

		// Token: 0x17001720 RID: 5920
		// (get) Token: 0x06007746 RID: 30534 RVA: 0x001231D9 File Offset: 0x001213D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001721 RID: 5921
		// (get) Token: 0x06007747 RID: 30535 RVA: 0x001231DC File Offset: 0x001213DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExitViewDirectionRequest.Descriptor;
			}
		}

		// Token: 0x06007748 RID: 30536 RVA: 0x001231E3 File Offset: 0x001213E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExitViewDirectionRequest()
		{
		}

		// Token: 0x06007749 RID: 30537 RVA: 0x001231EB File Offset: 0x001213EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExitViewDirectionRequest(ExitViewDirectionRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600774A RID: 30538 RVA: 0x00123204 File Offset: 0x00121404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExitViewDirectionRequest Clone()
		{
			return new ExitViewDirectionRequest(this);
		}

		// Token: 0x0600774B RID: 30539 RVA: 0x0012320C File Offset: 0x0012140C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExitViewDirectionRequest);
		}

		// Token: 0x0600774C RID: 30540 RVA: 0x0012321A File Offset: 0x0012141A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExitViewDirectionRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600774D RID: 30541 RVA: 0x00123238 File Offset: 0x00121438
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

		// Token: 0x0600774E RID: 30542 RVA: 0x0012325E File Offset: 0x0012145E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600774F RID: 30543 RVA: 0x0012326B File Offset: 0x0012146B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007750 RID: 30544 RVA: 0x00123274 File Offset: 0x00121474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007751 RID: 30545 RVA: 0x0012328C File Offset: 0x0012148C
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

		// Token: 0x06007752 RID: 30546 RVA: 0x001232B2 File Offset: 0x001214B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExitViewDirectionRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007753 RID: 30547 RVA: 0x001232CF File Offset: 0x001214CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007754 RID: 30548 RVA: 0x001232D8 File Offset: 0x001214D8
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

		// Token: 0x04003E24 RID: 15908
		private UnknownFieldSet _unknownFields;
	}
}
