using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.CombatMessage
{
	// Token: 0x020016FE RID: 5886
	[NetMessage(EMessageId.CombatMaxCaseMessageResponse)]
	public sealed class CombatMaxCaseMessageResponse : IMessage<CombatMaxCaseMessageResponse>, IMessage, IEquatable<CombatMaxCaseMessageResponse>, IDeepCloneable<CombatMaxCaseMessageResponse>, IBufferMessage
	{
		// Token: 0x0601D68C RID: 120460 RVA: 0x00441816 File Offset: 0x0043FA16
		[NullableContext(1)]
		public static CombatMaxCaseMessageResponse Create()
		{
			return new CombatMaxCaseMessageResponse();
		}

		// Token: 0x1700637A RID: 25466
		// (get) Token: 0x0601D68D RID: 120461 RVA: 0x0044181D File Offset: 0x0043FA1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700637B RID: 25467
		// (get) Token: 0x0601D68E RID: 120462 RVA: 0x00441820 File Offset: 0x0043FA20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombatMaxCaseMessageResponse.Descriptor;
			}
		}

		// Token: 0x0601D68F RID: 120463 RVA: 0x00441827 File Offset: 0x0043FA27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatMaxCaseMessageResponse()
		{
		}

		// Token: 0x0601D690 RID: 120464 RVA: 0x0044182F File Offset: 0x0043FA2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatMaxCaseMessageResponse(CombatMaxCaseMessageResponse other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D691 RID: 120465 RVA: 0x00441848 File Offset: 0x0043FA48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatMaxCaseMessageResponse Clone()
		{
			return new CombatMaxCaseMessageResponse(this);
		}

		// Token: 0x0601D692 RID: 120466 RVA: 0x00441850 File Offset: 0x0043FA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombatMaxCaseMessageResponse);
		}

		// Token: 0x0601D693 RID: 120467 RVA: 0x0044185E File Offset: 0x0043FA5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombatMaxCaseMessageResponse other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601D694 RID: 120468 RVA: 0x0044187C File Offset: 0x0043FA7C
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

		// Token: 0x0601D695 RID: 120469 RVA: 0x004418A2 File Offset: 0x0043FAA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D696 RID: 120470 RVA: 0x004418AF File Offset: 0x0043FAAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D697 RID: 120471 RVA: 0x004418B8 File Offset: 0x0043FAB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D698 RID: 120472 RVA: 0x004418D0 File Offset: 0x0043FAD0
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

		// Token: 0x0601D699 RID: 120473 RVA: 0x004418F6 File Offset: 0x0043FAF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CombatMaxCaseMessageResponse other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D69A RID: 120474 RVA: 0x00441913 File Offset: 0x0043FB13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D69B RID: 120475 RVA: 0x0044191C File Offset: 0x0043FB1C
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

		// Token: 0x0400C736 RID: 50998
		private UnknownFieldSet _unknownFields;
	}
}
