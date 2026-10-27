using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000417 RID: 1047
	[NetMessage(EMessageId.DrownRequest)]
	public sealed class DrownRequest : IMessage<DrownRequest>, IMessage, IEquatable<DrownRequest>, IDeepCloneable<DrownRequest>, IBufferMessage
	{
		// Token: 0x060064AA RID: 25770 RVA: 0x000F17FE File Offset: 0x000EF9FE
		[NullableContext(1)]
		public static DrownRequest Create()
		{
			return new DrownRequest();
		}

		// Token: 0x170012CA RID: 4810
		// (get) Token: 0x060064AB RID: 25771 RVA: 0x000F1805 File Offset: 0x000EFA05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170012CB RID: 4811
		// (get) Token: 0x060064AC RID: 25772 RVA: 0x000F1808 File Offset: 0x000EFA08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DrownRequest.Descriptor;
			}
		}

		// Token: 0x060064AD RID: 25773 RVA: 0x000F180F File Offset: 0x000EFA0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownRequest()
		{
		}

		// Token: 0x060064AE RID: 25774 RVA: 0x000F1817 File Offset: 0x000EFA17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownRequest(DrownRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060064AF RID: 25775 RVA: 0x000F1830 File Offset: 0x000EFA30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownRequest Clone()
		{
			return new DrownRequest(this);
		}

		// Token: 0x060064B0 RID: 25776 RVA: 0x000F1838 File Offset: 0x000EFA38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DrownRequest);
		}

		// Token: 0x060064B1 RID: 25777 RVA: 0x000F1846 File Offset: 0x000EFA46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DrownRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060064B2 RID: 25778 RVA: 0x000F1864 File Offset: 0x000EFA64
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

		// Token: 0x060064B3 RID: 25779 RVA: 0x000F188A File Offset: 0x000EFA8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060064B4 RID: 25780 RVA: 0x000F1897 File Offset: 0x000EFA97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060064B5 RID: 25781 RVA: 0x000F18A0 File Offset: 0x000EFAA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060064B6 RID: 25782 RVA: 0x000F18B8 File Offset: 0x000EFAB8
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

		// Token: 0x060064B7 RID: 25783 RVA: 0x000F18DE File Offset: 0x000EFADE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DrownRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060064B8 RID: 25784 RVA: 0x000F18FB File Offset: 0x000EFAFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060064B9 RID: 25785 RVA: 0x000F1904 File Offset: 0x000EFB04
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

		// Token: 0x0400386C RID: 14444
		private UnknownFieldSet _unknownFields;
	}
}
