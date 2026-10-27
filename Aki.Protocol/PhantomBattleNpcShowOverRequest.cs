using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C9B RID: 3227
	[NetMessage(EMessageId.PhantomBattleNpcShowOverRequest)]
	public sealed class PhantomBattleNpcShowOverRequest : IMessage<PhantomBattleNpcShowOverRequest>, IMessage, IEquatable<PhantomBattleNpcShowOverRequest>, IDeepCloneable<PhantomBattleNpcShowOverRequest>, IBufferMessage
	{
		// Token: 0x060117D5 RID: 71637 RVA: 0x002900A7 File Offset: 0x0028E2A7
		[NullableContext(1)]
		public static PhantomBattleNpcShowOverRequest Create()
		{
			return new PhantomBattleNpcShowOverRequest();
		}

		// Token: 0x170039F0 RID: 14832
		// (get) Token: 0x060117D6 RID: 71638 RVA: 0x002900AE File Offset: 0x0028E2AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170039F1 RID: 14833
		// (get) Token: 0x060117D7 RID: 71639 RVA: 0x002900B1 File Offset: 0x0028E2B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleNpcShowOverRequest.Descriptor;
			}
		}

		// Token: 0x060117D8 RID: 71640 RVA: 0x002900B8 File Offset: 0x0028E2B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleNpcShowOverRequest()
		{
		}

		// Token: 0x060117D9 RID: 71641 RVA: 0x002900C0 File Offset: 0x0028E2C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleNpcShowOverRequest(PhantomBattleNpcShowOverRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060117DA RID: 71642 RVA: 0x002900D9 File Offset: 0x0028E2D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleNpcShowOverRequest Clone()
		{
			return new PhantomBattleNpcShowOverRequest(this);
		}

		// Token: 0x060117DB RID: 71643 RVA: 0x002900E1 File Offset: 0x0028E2E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleNpcShowOverRequest);
		}

		// Token: 0x060117DC RID: 71644 RVA: 0x002900EF File Offset: 0x0028E2EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleNpcShowOverRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060117DD RID: 71645 RVA: 0x00290110 File Offset: 0x0028E310
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

		// Token: 0x060117DE RID: 71646 RVA: 0x00290136 File Offset: 0x0028E336
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060117DF RID: 71647 RVA: 0x00290143 File Offset: 0x0028E343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060117E0 RID: 71648 RVA: 0x0029014C File Offset: 0x0028E34C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060117E1 RID: 71649 RVA: 0x00290164 File Offset: 0x0028E364
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

		// Token: 0x060117E2 RID: 71650 RVA: 0x0029018A File Offset: 0x0028E38A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleNpcShowOverRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060117E3 RID: 71651 RVA: 0x002901A7 File Offset: 0x0028E3A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060117E4 RID: 71652 RVA: 0x002901B0 File Offset: 0x0028E3B0
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

		// Token: 0x04006E58 RID: 28248
		private UnknownFieldSet _unknownFields;
	}
}
