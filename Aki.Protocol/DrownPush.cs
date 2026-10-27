using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000416 RID: 1046
	[NetMessage(EMessageId.DrownPush)]
	public sealed class DrownPush : IMessage<DrownPush>, IMessage, IEquatable<DrownPush>, IDeepCloneable<DrownPush>, IBufferMessage
	{
		// Token: 0x0600649A RID: 25754 RVA: 0x000F16C6 File Offset: 0x000EF8C6
		[NullableContext(1)]
		public static DrownPush Create()
		{
			return new DrownPush();
		}

		// Token: 0x170012C8 RID: 4808
		// (get) Token: 0x0600649B RID: 25755 RVA: 0x000F16CD File Offset: 0x000EF8CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170012C9 RID: 4809
		// (get) Token: 0x0600649C RID: 25756 RVA: 0x000F16D0 File Offset: 0x000EF8D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DrownPush.Descriptor;
			}
		}

		// Token: 0x0600649D RID: 25757 RVA: 0x000F16D7 File Offset: 0x000EF8D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownPush()
		{
		}

		// Token: 0x0600649E RID: 25758 RVA: 0x000F16DF File Offset: 0x000EF8DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownPush(DrownPush other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600649F RID: 25759 RVA: 0x000F16F8 File Offset: 0x000EF8F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownPush Clone()
		{
			return new DrownPush(this);
		}

		// Token: 0x060064A0 RID: 25760 RVA: 0x000F1700 File Offset: 0x000EF900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DrownPush);
		}

		// Token: 0x060064A1 RID: 25761 RVA: 0x000F170E File Offset: 0x000EF90E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DrownPush other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060064A2 RID: 25762 RVA: 0x000F172C File Offset: 0x000EF92C
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

		// Token: 0x060064A3 RID: 25763 RVA: 0x000F1752 File Offset: 0x000EF952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060064A4 RID: 25764 RVA: 0x000F175F File Offset: 0x000EF95F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060064A5 RID: 25765 RVA: 0x000F1768 File Offset: 0x000EF968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060064A6 RID: 25766 RVA: 0x000F1780 File Offset: 0x000EF980
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

		// Token: 0x060064A7 RID: 25767 RVA: 0x000F17A6 File Offset: 0x000EF9A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DrownPush other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060064A8 RID: 25768 RVA: 0x000F17C3 File Offset: 0x000EF9C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060064A9 RID: 25769 RVA: 0x000F17CC File Offset: 0x000EF9CC
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

		// Token: 0x0400386B RID: 14443
		private UnknownFieldSet _unknownFields;
	}
}
