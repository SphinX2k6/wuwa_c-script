using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.CombatMessage
{
	// Token: 0x020016FD RID: 5885
	[NetMessage(EMessageId.CombatMaxCaseMessageRequest)]
	public sealed class CombatMaxCaseMessageRequest : IMessage<CombatMaxCaseMessageRequest>, IMessage, IEquatable<CombatMaxCaseMessageRequest>, IDeepCloneable<CombatMaxCaseMessageRequest>, IBufferMessage
	{
		// Token: 0x0601D67C RID: 120444 RVA: 0x004416DE File Offset: 0x0043F8DE
		[NullableContext(1)]
		public static CombatMaxCaseMessageRequest Create()
		{
			return new CombatMaxCaseMessageRequest();
		}

		// Token: 0x17006378 RID: 25464
		// (get) Token: 0x0601D67D RID: 120445 RVA: 0x004416E5 File Offset: 0x0043F8E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006379 RID: 25465
		// (get) Token: 0x0601D67E RID: 120446 RVA: 0x004416E8 File Offset: 0x0043F8E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombatMaxCaseMessageRequest.Descriptor;
			}
		}

		// Token: 0x0601D67F RID: 120447 RVA: 0x004416EF File Offset: 0x0043F8EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatMaxCaseMessageRequest()
		{
		}

		// Token: 0x0601D680 RID: 120448 RVA: 0x004416F7 File Offset: 0x0043F8F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatMaxCaseMessageRequest(CombatMaxCaseMessageRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D681 RID: 120449 RVA: 0x00441710 File Offset: 0x0043F910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatMaxCaseMessageRequest Clone()
		{
			return new CombatMaxCaseMessageRequest(this);
		}

		// Token: 0x0601D682 RID: 120450 RVA: 0x00441718 File Offset: 0x0043F918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombatMaxCaseMessageRequest);
		}

		// Token: 0x0601D683 RID: 120451 RVA: 0x00441726 File Offset: 0x0043F926
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombatMaxCaseMessageRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601D684 RID: 120452 RVA: 0x00441744 File Offset: 0x0043F944
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

		// Token: 0x0601D685 RID: 120453 RVA: 0x0044176A File Offset: 0x0043F96A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D686 RID: 120454 RVA: 0x00441777 File Offset: 0x0043F977
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D687 RID: 120455 RVA: 0x00441780 File Offset: 0x0043F980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D688 RID: 120456 RVA: 0x00441798 File Offset: 0x0043F998
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

		// Token: 0x0601D689 RID: 120457 RVA: 0x004417BE File Offset: 0x0043F9BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CombatMaxCaseMessageRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D68A RID: 120458 RVA: 0x004417DB File Offset: 0x0043F9DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D68B RID: 120459 RVA: 0x004417E4 File Offset: 0x0043F9E4
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

		// Token: 0x0400C735 RID: 50997
		private UnknownFieldSet _unknownFields;
	}
}
