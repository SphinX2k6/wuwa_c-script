using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.CombatMessage
{
	// Token: 0x020016FB RID: 5883
	[NetMessage(EMessageId.CombatDataMaxNotify)]
	public sealed class CombatDataMaxNotify : IMessage<CombatDataMaxNotify>, IMessage, IEquatable<CombatDataMaxNotify>, IDeepCloneable<CombatDataMaxNotify>, IBufferMessage
	{
		// Token: 0x0601D65C RID: 120412 RVA: 0x0044146D File Offset: 0x0043F66D
		[NullableContext(1)]
		public static CombatDataMaxNotify Create()
		{
			return new CombatDataMaxNotify();
		}

		// Token: 0x17006374 RID: 25460
		// (get) Token: 0x0601D65D RID: 120413 RVA: 0x00441474 File Offset: 0x0043F674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006375 RID: 25461
		// (get) Token: 0x0601D65E RID: 120414 RVA: 0x00441477 File Offset: 0x0043F677
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombatDataMaxNotify.Descriptor;
			}
		}

		// Token: 0x0601D65F RID: 120415 RVA: 0x0044147E File Offset: 0x0043F67E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatDataMaxNotify()
		{
		}

		// Token: 0x0601D660 RID: 120416 RVA: 0x00441486 File Offset: 0x0043F686
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatDataMaxNotify(CombatDataMaxNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D661 RID: 120417 RVA: 0x0044149F File Offset: 0x0043F69F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatDataMaxNotify Clone()
		{
			return new CombatDataMaxNotify(this);
		}

		// Token: 0x0601D662 RID: 120418 RVA: 0x004414A7 File Offset: 0x0043F6A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombatDataMaxNotify);
		}

		// Token: 0x0601D663 RID: 120419 RVA: 0x004414B5 File Offset: 0x0043F6B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombatDataMaxNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601D664 RID: 120420 RVA: 0x004414D4 File Offset: 0x0043F6D4
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

		// Token: 0x0601D665 RID: 120421 RVA: 0x004414FA File Offset: 0x0043F6FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D666 RID: 120422 RVA: 0x00441507 File Offset: 0x0043F707
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D667 RID: 120423 RVA: 0x00441510 File Offset: 0x0043F710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D668 RID: 120424 RVA: 0x00441528 File Offset: 0x0043F728
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

		// Token: 0x0601D669 RID: 120425 RVA: 0x0044154E File Offset: 0x0043F74E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CombatDataMaxNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D66A RID: 120426 RVA: 0x0044156B File Offset: 0x0043F76B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D66B RID: 120427 RVA: 0x00441574 File Offset: 0x0043F774
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

		// Token: 0x0400C733 RID: 50995
		private UnknownFieldSet _unknownFields;
	}
}
