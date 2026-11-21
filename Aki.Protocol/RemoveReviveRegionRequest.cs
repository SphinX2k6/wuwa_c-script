using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EF8 RID: 3832
	[NetMessage(EMessageId.RemoveReviveRegionRequest)]
	public sealed class RemoveReviveRegionRequest : IMessage<RemoveReviveRegionRequest>, IMessage, IEquatable<RemoveReviveRegionRequest>, IDeepCloneable<RemoveReviveRegionRequest>, IBufferMessage
	{
		// Token: 0x060148D9 RID: 84185 RVA: 0x002FCC3F File Offset: 0x002FAE3F
		[NullableContext(1)]
		public static RemoveReviveRegionRequest Create()
		{
			return new RemoveReviveRegionRequest();
		}

		// Token: 0x1700445C RID: 17500
		// (get) Token: 0x060148DA RID: 84186 RVA: 0x002FCC46 File Offset: 0x002FAE46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700445D RID: 17501
		// (get) Token: 0x060148DB RID: 84187 RVA: 0x002FCC49 File Offset: 0x002FAE49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveReviveRegionRequest.Descriptor;
			}
		}

		// Token: 0x060148DC RID: 84188 RVA: 0x002FCC50 File Offset: 0x002FAE50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveReviveRegionRequest()
		{
		}

		// Token: 0x060148DD RID: 84189 RVA: 0x002FCC58 File Offset: 0x002FAE58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveReviveRegionRequest(RemoveReviveRegionRequest other) : this()
		{
			this.reviveId_ = other.reviveId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060148DE RID: 84190 RVA: 0x002FCC7D File Offset: 0x002FAE7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveReviveRegionRequest Clone()
		{
			return new RemoveReviveRegionRequest(this);
		}

		// Token: 0x1700445E RID: 17502
		// (get) Token: 0x060148DF RID: 84191 RVA: 0x002FCC85 File Offset: 0x002FAE85
		// (set) Token: 0x060148E0 RID: 84192 RVA: 0x002FCC8D File Offset: 0x002FAE8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ReviveId
		{
			get
			{
				return this.reviveId_;
			}
			set
			{
				this.reviveId_ = value;
			}
		}

		// Token: 0x060148E1 RID: 84193 RVA: 0x002FCC96 File Offset: 0x002FAE96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveReviveRegionRequest);
		}

		// Token: 0x060148E2 RID: 84194 RVA: 0x002FCCA4 File Offset: 0x002FAEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveReviveRegionRequest other)
		{
			return other != null && (other == this || (this.ReviveId == other.ReviveId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060148E3 RID: 84195 RVA: 0x002FCCD4 File Offset: 0x002FAED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ReviveId != 0)
			{
				num ^= this.ReviveId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060148E4 RID: 84196 RVA: 0x002FCD13 File Offset: 0x002FAF13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060148E5 RID: 84197 RVA: 0x002FCD20 File Offset: 0x002FAF20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060148E6 RID: 84198 RVA: 0x002FCD29 File Offset: 0x002FAF29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ReviveId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ReviveId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060148E7 RID: 84199 RVA: 0x002FCD5C File Offset: 0x002FAF5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ReviveId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ReviveId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060148E8 RID: 84200 RVA: 0x002FCD9A File Offset: 0x002FAF9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveReviveRegionRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ReviveId != 0)
			{
				this.ReviveId = other.ReviveId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060148E9 RID: 84201 RVA: 0x002FCDCB File Offset: 0x002FAFCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060148EA RID: 84202 RVA: 0x002FCDD4 File Offset: 0x002FAFD4
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ReviveId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007CEE RID: 31982
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007CEF RID: 31983
		public const int ReviveIdFieldNumber = 7;

		// Token: 0x04007CF0 RID: 31984
		private int reviveId_;
	}
}
