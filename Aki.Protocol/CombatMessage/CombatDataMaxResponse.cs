using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.CombatMessage
{
	// Token: 0x020016FC RID: 5884
	public sealed class CombatDataMaxResponse : IMessage<CombatDataMaxResponse>, IMessage, IEquatable<CombatDataMaxResponse>, IDeepCloneable<CombatDataMaxResponse>, IBufferMessage
	{
		// Token: 0x0601D66C RID: 120428 RVA: 0x004415A6 File Offset: 0x0043F7A6
		[NullableContext(1)]
		public static CombatDataMaxResponse Create()
		{
			return new CombatDataMaxResponse();
		}

		// Token: 0x17006376 RID: 25462
		// (get) Token: 0x0601D66D RID: 120429 RVA: 0x004415AD File Offset: 0x0043F7AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006377 RID: 25463
		// (get) Token: 0x0601D66E RID: 120430 RVA: 0x004415B0 File Offset: 0x0043F7B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombatDataMaxResponse.Descriptor;
			}
		}

		// Token: 0x0601D66F RID: 120431 RVA: 0x004415B7 File Offset: 0x0043F7B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatDataMaxResponse()
		{
		}

		// Token: 0x0601D670 RID: 120432 RVA: 0x004415BF File Offset: 0x0043F7BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatDataMaxResponse(CombatDataMaxResponse other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D671 RID: 120433 RVA: 0x004415D8 File Offset: 0x0043F7D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatDataMaxResponse Clone()
		{
			return new CombatDataMaxResponse(this);
		}

		// Token: 0x0601D672 RID: 120434 RVA: 0x004415E0 File Offset: 0x0043F7E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombatDataMaxResponse);
		}

		// Token: 0x0601D673 RID: 120435 RVA: 0x004415EE File Offset: 0x0043F7EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombatDataMaxResponse other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601D674 RID: 120436 RVA: 0x0044160C File Offset: 0x0043F80C
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

		// Token: 0x0601D675 RID: 120437 RVA: 0x00441632 File Offset: 0x0043F832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D676 RID: 120438 RVA: 0x0044163F File Offset: 0x0043F83F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D677 RID: 120439 RVA: 0x00441648 File Offset: 0x0043F848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D678 RID: 120440 RVA: 0x00441660 File Offset: 0x0043F860
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

		// Token: 0x0601D679 RID: 120441 RVA: 0x00441686 File Offset: 0x0043F886
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CombatDataMaxResponse other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D67A RID: 120442 RVA: 0x004416A3 File Offset: 0x0043F8A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D67B RID: 120443 RVA: 0x004416AC File Offset: 0x0043F8AC
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

		// Token: 0x0400C734 RID: 50996
		private UnknownFieldSet _unknownFields;
	}
}
